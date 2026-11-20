// Licensed under the MIT License.

using System.Globalization;
using System.Text;
using System.Text.Json;
using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform;

internal sealed class TerraformModulesConfiguration(
    IReadOnlyList<TerraformModuleResource> modules,
    string outputDirectory)
{
    private readonly Dictionary<string, ParameterResource> _parameters = new(StringComparer.Ordinal);
    private readonly HashSet<TerraformModuleResource> _modules = new(modules, ReferenceEqualityComparer.Instance);

    public IReadOnlyDictionary<string, ParameterResource> Parameters => _parameters;

    public string Render()
    {
        var moduleBlocks = new SortedDictionary<string, object>(StringComparer.Ordinal);
        var outputBlocks = new SortedDictionary<string, object>(StringComparer.Ordinal);

        foreach (var module in modules.OrderBy(module => module.ModuleLabel, StringComparer.Ordinal))
        {
            var label = ModuleLabel(module);
            var arguments = new SortedDictionary<string, object>(StringComparer.Ordinal)
            {
                ["source"] = EscapeTemplate(ResolveSource(module))
            };

            foreach (var (name, value) in module.Variables.OrderBy(variable => variable.Key, StringComparer.Ordinal))
            {
                EnsureIdentifier(name, "variable");
                if (name is "source" or "version" or "count" or "for_each" or "depends_on" or "providers")
                {
                    throw new DistributedApplicationException(
                        $"'{name}' is a reserved Terraform module argument and cannot be set with WithVariable().");
                }

                arguments.Add(name, RenderValue(value));
            }

            if (!moduleBlocks.TryAdd(label, arguments))
            {
                throw new DistributedApplicationException($"Multiple Terraform modules use the name '{module.ModuleLabel}'.");
            }

            foreach (var (name, sensitive) in module.RequestedOutputs.OrderBy(output => output.Key, StringComparer.Ordinal))
            {
                EnsureIdentifier(name, "output");
                outputBlocks.Add(TerraformModulesEnvironmentResource.GetRootOutputName(module, name), new Dictionary<string, object>
                {
                    ["value"] = Interpolate(ModuleOutput(module, name)),
                    ["sensitive"] = sensitive
                });
            }
        }

        var variableBlocks = new SortedDictionary<string, object>(StringComparer.Ordinal);
        foreach (var (name, parameter) in _parameters)
        {
            variableBlocks.Add(name, new Dictionary<string, object>
            {
                ["type"] = "string",
                ["sensitive"] = parameter.Secret
            });
        }

        var root = new Dictionary<string, object>
        {
            ["variable"] = variableBlocks,
            ["module"] = moduleBlocks,
            ["output"] = outputBlocks
        };
        return JsonSerializer.Serialize(root, new JsonSerializerOptions { WriteIndented = true }) + "\n";
    }

    private object RenderValue(object value) => value switch
    {
        string literal => EscapeTemplate(literal),
        bool or int => value,
        ReferenceExpression expression => RenderTemplate(expression),
        ParameterResource parameter => Interpolate(ParameterExpression(parameter)),
        TerraformModuleOutputReference output => Interpolate(ModuleOutput(output.Module, output.Name)),
        EndpointReference endpoint => Interpolate(EndpointOutput(endpoint, EndpointProperty.Url)),
        EndpointReferenceExpression endpoint => Interpolate(EndpointOutput(endpoint.Endpoint, endpoint.Property)),
        _ => throw new DistributedApplicationException(
            $"Terraform module input type '{value.GetType().Name}' cannot be represented in the generated configuration.")
    };

    private string RenderTemplate(ReferenceExpression expression)
    {
        if (expression.IsConditional)
        {
            throw new DistributedApplicationException("Conditional Aspire reference expressions are not yet supported in Terraform module inputs.");
        }

        var arguments = new object[expression.ValueProviders.Count];
        for (var index = 0; index < arguments.Length; index++)
        {
            if (expression.StringFormats[index] is not null)
            {
                throw new DistributedApplicationException("Formatted Aspire reference values are not yet supported in Terraform module inputs.");
            }

            arguments[index] = expression.ValueProviders[index] switch
            {
                ReferenceExpression nested => RenderTemplate(nested),
                ParameterResource parameter => Interpolate(ParameterExpression(parameter)),
                TerraformModuleOutputReference output => Interpolate(ModuleOutput(output.Module, output.Name)),
                EndpointReference endpoint => Interpolate(EndpointOutput(endpoint, EndpointProperty.Url)),
                EndpointReferenceExpression endpoint => Interpolate(EndpointOutput(endpoint.Endpoint, endpoint.Property)),
                var provider => throw new DistributedApplicationException(
                    $"Aspire value '{provider.GetType().Name}' cannot be represented in a Terraform reference expression.")
            };
        }

        return string.Format(CultureInfo.InvariantCulture, EscapeTemplate(expression.Format), arguments);
    }

    private string ParameterExpression(ParameterResource parameter)
    {
        var name = ParameterName(parameter.Name);
        if (_parameters.TryGetValue(name, out var existing) && !ReferenceEquals(existing, parameter))
        {
            throw new DistributedApplicationException($"Terraform parameters '{existing.Name}' and '{parameter.Name}' have the same generated name.");
        }

        _parameters[name] = parameter;
        return $"var.{name}";
    }

    private string EndpointOutput(EndpointReference endpoint, EndpointProperty property)
    {
        var module = endpoint.Resource.Annotations.OfType<DeploymentTargetAnnotation>()
            .Select(annotation => annotation.DeploymentTarget)
            .OfType<TerraformModuleResource>()
            .SingleOrDefault(candidate => _modules.Contains(candidate));

        if (module is null)
        {
            throw new DistributedApplicationException(
                $"Endpoint '{endpoint.Resource.Name}.{endpoint.EndpointName}' is not backed by a module in this Terraform environment.");
        }

        return ModuleOutput(module, module.GetEndpointOutput(endpoint.EndpointName, property));
    }

    private string ModuleOutput(TerraformModuleResource module, string outputName)
    {
        if (!_modules.Contains(module))
        {
            throw new DistributedApplicationException(
                $"Terraform output '{module.Name}.{outputName}' is not in this Terraform environment. " +
                "Existing root configurations have separate state and cannot be used as generated module inputs.");
        }

        EnsureIdentifier(outputName, "output");
        return $"module.{ModuleLabel(module)}.{outputName}";
    }

    private string ResolveSource(TerraformModuleResource module)
    {
        if (module.Template is not null)
        {
            var templateDirectory = Path.Combine(outputDirectory, "templates", ModuleLabel(module));
            Directory.CreateDirectory(templateDirectory);
            File.WriteAllText(Path.Combine(templateDirectory, "main.tf"), module.Template());
            return $"./templates/{ModuleLabel(module)}";
        }

        var source = module.Source!;
        if (!Path.IsPathRooted(source) &&
            !source.StartsWith("./", StringComparison.Ordinal) &&
            !source.StartsWith("../", StringComparison.Ordinal) &&
            !source.StartsWith(@".\", StringComparison.Ordinal) &&
            !source.StartsWith(@"..\", StringComparison.Ordinal))
        {
            return source;
        }

        var fullPath = Path.GetFullPath(source, module.AppHostDirectory);
        if (!Directory.Exists(fullPath))
        {
            throw new DistributedApplicationException($"Terraform module source directory for '{module.ModuleLabel}' does not exist: {fullPath}");
        }

        var relativePath = Path.GetRelativePath(outputDirectory, fullPath).Replace('\\', '/');
        return relativePath.StartsWith(".", StringComparison.Ordinal) || Path.IsPathRooted(relativePath)
            ? relativePath
            : $"./{relativePath}";
    }

    private static string ModuleLabel(TerraformModuleResource module)
    {
        var label = $"m_{module.ModuleLabel}";
        EnsureIdentifier(label, "module");
        return label;
    }

    private static string ParameterName(string name)
    {
        var result = new StringBuilder("aspire_");
        foreach (var character in name)
        {
            result.Append(character switch
            {
                '_' => "__",
                '-' => "_d",
                _ => character.ToString()
            });
        }

        var identifier = result.ToString();
        EnsureIdentifier(identifier, "parameter");
        return identifier;
    }

    private static void EnsureIdentifier(string name, string kind)
    {
        if (string.IsNullOrEmpty(name) ||
            !(char.IsAsciiLetter(name[0]) || name[0] == '_') ||
            name.Any(character => !(char.IsAsciiLetterOrDigit(character) || character is '_' or '-')))
        {
            throw new DistributedApplicationException($"Terraform {kind} name '{name}' is not a supported identifier.");
        }
    }

    private static string EscapeTemplate(string value) =>
        value.Replace("${", "$${", StringComparison.Ordinal).Replace("%{", "%%{", StringComparison.Ordinal);

    private static string Interpolate(string expression) => $"${{{expression}}}";
}
