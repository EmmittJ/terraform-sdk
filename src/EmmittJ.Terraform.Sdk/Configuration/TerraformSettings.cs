using System.Linq;
using System.Text;
using EmmittJ.Terraform.Sdk.Core;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents the terraform {} settings block.
/// This is a configuration container rather than a construct and renders the terraform block directly.
/// </summary>
public class TerraformSettings : ITerraformPreparable
{
    private readonly TerraformPropertyCollection _properties = new();
    private readonly Dictionary<string, ProviderRequirement> _requiredProviders = new();
    private readonly List<string> _experiments = new();
    private readonly List<TerraformProviderMetaConfig> _providerMetas = new();

    /// <summary>
    /// Gets or sets the required Terraform version constraint (e.g., ">= 1.0", "~> 1.5.0").
    /// </summary>
    public TerraformProperty<string>? RequiredVersion
    {
        get => GetProperty<TerraformProperty<string>>("required_version");
        set => SetProperty("required_version", value);
    }

    /// <summary>
    /// Gets the required providers with their source and version constraints.
    /// Use this dictionary to add provider requirements.
    /// </summary>
    public Dictionary<string, ProviderRequirement> RequiredProviders => _requiredProviders;

    /// <summary>
    /// Gets the list of experimental features to enable.
    /// </summary>
    public List<string> Experiments => _experiments;

    /// <summary>
    /// Gets or sets the backend configuration for remote state storage.
    /// Backend is a block expression with a label.
    /// </summary>
    public TerraformBackend? Backend
    {
        get => GetProperty<TerraformExpressionProperty>("backend")?.Expression as TerraformBackend;
        set => SetProperty("backend", value != null ? new TerraformExpressionProperty(value) : null);
    }

    /// <summary>
    /// Gets the list of provider metadata configurations.
    /// Provider metadata allows modules to pass provider-specific information independently of provider configuration.
    /// Multiple provider_meta blocks can be defined for different providers.
    /// </summary>
    public List<TerraformProviderMetaConfig> ProviderMetas => _providerMetas;

    /// <summary>
    /// Gets or sets the cloud block configuration (for Terraform Cloud/Enterprise).
    /// Mutually exclusive with Backend.
    /// </summary>
    public TerraformCloudConfig? Cloud { get; set; }

    /// <summary>
    /// Adds or updates an arbitrary property on the terraform block.
    /// </summary>
    public TerraformSettings WithProperty(string key, TerraformProperty value, int? priority = null)
    {
        SetProperty(key, value, priority);
        return this;
    }

    /// <summary>
    /// Gets an ordered, read-only view of the property dictionary.
    /// Primarily used for rendering.
    /// </summary>
    internal IEnumerable<KeyValuePair<string, object?>> Properties => _properties.GetOrderedProperties();

    /// <inheritdoc />
    public void Prepare(ITerraformContext context)
    {
        if (context == null)
        {
            throw new ArgumentNullException(nameof(context));
        }

        foreach (var value in _properties.GetValues())
        {
            TerraformValueResolver.PrepareValue(value, context);
        }
    }

    /// <summary>
    /// Renders the terraform block to HCL.
    /// </summary>
    public string ToHcl(ITerraformContext? context = null)
    {
        context ??= TerraformContext.Temporary();

        var sb = new StringBuilder();
        sb.AppendLine("terraform {");

        using (context.PushIndent())
        {
            // 1. required_version (conventionally first)
            var versionProp = _properties.Get<TerraformProperty>("required_version");
            if (versionProp != null)
            {
                var expression = TerraformValueResolver.ResolveValue(versionProp, context);
                var hcl = expression.ToHcl(context);
                sb.AppendLine($"{context.Indent}required_version{expression.AssignmentOperator}{hcl}");
            }

            // 2. required_providers block
            if (_requiredProviders.Count > 0)
            {
                sb.AppendLine($"{context.Indent}required_providers {{");

                using (context.PushIndent())
                {
                    foreach (var (name, requirement) in _requiredProviders.OrderBy(p => p.Key))
                    {
                        sb.AppendLine($"{context.Indent}{name} = {{");

                        using (context.PushIndent())
                        {
                            sb.AppendLine($"{context.Indent}source = \"{requirement.Source}\"");

                            if (!string.IsNullOrWhiteSpace(requirement.Version))
                            {
                                sb.AppendLine($"{context.Indent}version = \"{requirement.Version}\"");
                            }
                        }

                        sb.AppendLine($"{context.Indent}}}");
                    }
                }

                sb.AppendLine($"{context.Indent}}}");
            }

            // 3. experiments list
            if (_experiments.Count > 0)
            {
                var experimentsList = string.Join(", ", _experiments.Select(e => $"\"{e}\""));
                sb.AppendLine($"{context.Indent}experiments = [{experimentsList}]");
            }

            // 4. provider_meta blocks (if present)
            foreach (var providerMeta in _providerMetas.OrderBy(pm => pm.ProviderName))
            {
                RenderProviderMetaBlock(sb, context, providerMeta);
            }

            // 5. cloud block (if present)
            if (Cloud != null)
            {
                RenderCloudBlock(sb, context);
            }

            // 6. Remaining properties (backend, etc.) ordered by priority then key
            foreach (var kvp in _properties.GetOrderedProperties().Where(p => p.Key != "required_version"))
            {
                var expression = TerraformValueResolver.ResolveValue(kvp.Value, context);
                var hcl = expression.ToHcl(context);
                sb.AppendLine($"{context.Indent}{kvp.Key}{expression.AssignmentOperator}{hcl}");
            }
        }

        sb.AppendLine($"{context.Indent}}}");

        return sb.ToString();
    }

    private void RenderCloudBlock(StringBuilder sb, ITerraformContext context)
    {
        if (Cloud == null)
        {
            return;
        }

        sb.AppendLine($"{context.Indent}cloud {{");

        using (context.PushIndent())
        {
            if (!string.IsNullOrWhiteSpace(Cloud.Organization))
            {
                sb.AppendLine($"{context.Indent}organization = \"{Cloud.Organization}\"");
            }

            if (!string.IsNullOrWhiteSpace(Cloud.Hostname))
            {
                sb.AppendLine($"{context.Indent}hostname = \"{Cloud.Hostname}\"");
            }

            if (!string.IsNullOrWhiteSpace(Cloud.Token))
            {
                sb.AppendLine($"{context.Indent}token = \"{Cloud.Token}\"");
            }

            if (Cloud.Workspaces != null)
            {
                RenderWorkspacesBlock(sb, context, Cloud.Workspaces);
            }
        }

        sb.AppendLine($"{context.Indent}}}");
    }

    private void RenderWorkspacesBlock(StringBuilder sb, ITerraformContext context, CloudWorkspaceConfig workspaces)
    {
        sb.AppendLine($"{context.Indent}workspaces {{");

        using (context.PushIndent())
        {
            if (!string.IsNullOrWhiteSpace(workspaces.Name))
            {
                sb.AppendLine($"{context.Indent}name = \"{workspaces.Name}\"");
            }

            if (workspaces.Tags != null && workspaces.Tags.Count > 0)
            {
                var tagsList = string.Join(", ", workspaces.Tags.Select(t => $"\"{t}\""));
                sb.AppendLine($"{context.Indent}tags = [{tagsList}]");
            }

            if (!string.IsNullOrWhiteSpace(workspaces.Project))
            {
                sb.AppendLine($"{context.Indent}project = \"{workspaces.Project}\"");
            }
        }

        sb.AppendLine($"{context.Indent}}}");
    }

    private void RenderProviderMetaBlock(StringBuilder sb, ITerraformContext context, TerraformProviderMetaConfig providerMeta)
    {
        if (string.IsNullOrWhiteSpace(providerMeta.ProviderName))
        {
            return;
        }

        sb.AppendLine($"{context.Indent}provider_meta \"{providerMeta.ProviderName}\" {{");

        using (context.PushIndent())
        {
            foreach (var (key, value) in providerMeta.Metadata.OrderBy(kvp => kvp.Key))
            {
                var formattedValue = FormatMetadataValue(value);
                sb.AppendLine($"{context.Indent}{key} = {formattedValue}");
            }
        }

        sb.AppendLine($"{context.Indent}}}");
    }

    private static string FormatMetadataValue(object? value)
    {
        return value switch
        {
            null => "null",
            string s => $"\"{s}\"",
            bool b => b ? "true" : "false",
            int or long or short or byte => value.ToString() ?? "0",
            float or double or decimal => value.ToString() ?? "0",
            _ => $"\"{value}\""
        };
    }

    private T? GetProperty<T>(string key) where T : class
        => _properties.Get<T>(key);

    private void SetProperty(string key, TerraformProperty? value, int? priority = null)
    {
        _properties.Set(key, value, priority);
    }

    private void SetProperty(string key, TerraformProperty? value)
        => SetProperty(key, value, null);
}

/// <summary>
/// Represents a provider requirement with source and version constraint.
/// </summary>
public class ProviderRequirement
{
    /// <summary>
    /// Gets or sets the provider source (e.g., "hashicorp/aws", "hashicorp/azurerm").
    /// </summary>
    public required string Source { get; set; }

    /// <summary>
    /// Gets or sets the version constraint (e.g., "~> 5.0", ">= 4.0.0").
    /// </summary>
    public string? Version { get; set; }
}

/// <summary>
/// Represents the cloud block for Terraform Cloud/Enterprise configuration.
/// </summary>
public class TerraformCloudBlock : TerraformConstruct
{
    /// <inheritdoc/>
    public override string BlockType => "cloud";

    /// <inheritdoc/>
    protected override string[] BlockLabels => Array.Empty<string>();

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => throw new NotSupportedException("Cloud blocks cannot be referenced in expressions.");
}
