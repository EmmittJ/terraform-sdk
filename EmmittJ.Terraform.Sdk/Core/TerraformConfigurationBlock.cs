using System.Linq;
using System.Text;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents the terraform {} configuration block.
/// This is a configuration container rather than a construct and renders the terraform block directly.
/// </summary>
public class TerraformConfigurationBlock : ITerraformPreparable
{
    private readonly TerraformPropertyCollection _properties = new();
    private readonly Dictionary<string, ProviderRequirement> _requiredProviders = new();
    private readonly List<string> _experiments = new();

    /// <summary>
    /// Gets or sets the required Terraform version constraint (e.g., ">= 1.0", "~> 1.5.0").
    /// </summary>
    public TerraformLiteralProperty<string>? RequiredVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("required_version");
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
    /// Gets or sets the provider metadata block (for provider development).
    /// </summary>
    public object? ProviderMeta
    {
        get => GetProperty<TerraformLiteralProperty<object>>("provider_meta")?.Value;
        set => SetProperty("provider_meta", value != null ? new TerraformLiteralProperty<object>(value) : null);
    }

    /// <summary>
    /// Gets or sets the cloud block configuration (for Terraform Cloud/Enterprise).
    /// </summary>
    public object? Cloud
    {
        get => GetProperty<TerraformLiteralProperty<object>>("cloud")?.Value;
        set => SetProperty("cloud", value != null ? new TerraformLiteralProperty<object>(value) : null);
    }

    /// <summary>
    /// Adds or updates an arbitrary property on the terraform block.
    /// </summary>
    public TerraformConfigurationBlock WithProperty(string key, TerraformProperty value, int? priority = null)
    {
        SetProperty(key, value, priority);
        return this;
    }

    /// <summary>
    /// Gets an ordered, read-only view of the property dictionary.
    /// Primarily used for rendering.
    /// </summary>
    internal IReadOnlyDictionary<string, TerraformProperty> Properties => _properties;

    /// <inheritdoc />
    public void Prepare(ITerraformContext context)
    {
        if (context == null)
        {
            throw new ArgumentNullException(nameof(context));
        }

        foreach (var property in _properties.Values)
        {
            property.Prepare(context);
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
            if (_properties.TryGetValue("required_version", out var versionProp))
            {
                var expression = versionProp.Resolve(context);
                var hcl = expression.ToHcl(context);
                sb.AppendLine($"{context.Indent}required_version{expression.AssignmentOperator}{hcl}");
                sb.AppendLine();
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
                sb.AppendLine();
            }

            // 3. experiments list
            if (_experiments.Count > 0)
            {
                var experimentsList = string.Join(", ", _experiments.Select(e => $"\"{e}\""));
                sb.AppendLine($"{context.Indent}experiments = [{experimentsList}]");
                sb.AppendLine();
            }

            // 4. Remaining properties (backend, cloud, etc.) ordered by priority then key, excluding required_version
            foreach (var (key, property) in _properties.GetOrderedProperties().Where(p => p.Key != "required_version"))
            {
                var expression = property.Resolve(context);
                var hcl = expression.ToHcl(context);
                sb.AppendLine($"{context.Indent}{key}{expression.AssignmentOperator}{hcl}");
            }
        }

        sb.AppendLine("}");

        return sb.ToString();
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
    protected override string BlockType => "cloud";

    /// <inheritdoc/>
    protected override string[] Labels => Array.Empty<string>();

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => throw new NotSupportedException("Cloud blocks cannot be referenced in expressions.");
}

/// <summary>
/// Represents workspace configuration for Terraform Cloud.
/// </summary>
public class CloudWorkspaceConfig
{
    /// <summary>
    /// Gets or sets the workspace name.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the workspace tags.
    /// </summary>
    public List<string>? Tags { get; set; }
}
