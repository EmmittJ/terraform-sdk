namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents the terraform {} configuration block.
/// This block configures Terraform itself, including backend, required providers, and other settings.
/// See: https://developer.hashicorp.com/terraform/language/block/terraform
/// </summary>
public class TerraformConfigurationBlock : NamedTerraformConstruct
{
    private readonly Dictionary<string, ProviderRequirement> _requiredProviders = new();
    private readonly List<string> _experiments = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformConfigurationBlock"/> class.
    /// </summary>
    public TerraformConfigurationBlock() : base("terraform")
    {
    }

    /// <inheritdoc/>
    protected override string BlockType => "terraform";

    /// <inheritdoc/>
    protected override string[] Labels => Array.Empty<string>();

    /// <summary>
    /// Gets or sets the required Terraform version constraint (e.g., ">= 1.0", "~> 1.5.0").
    /// </summary>
    public TerraformLiteralProperty<string>? RequiredVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("required_version");
        set => WithPropertyInternal("required_version", value);
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
        set => WithPropertyInternal("backend", value != null ? new TerraformExpressionProperty(value) : null);
    }

    /// <summary>
    /// Gets or sets the provider metadata block (for provider development).
    /// </summary>
    public object? ProviderMeta
    {
        get => GetProperty<TerraformLiteralProperty<object>>("provider_meta")?.Value;
        set => WithPropertyInternal("provider_meta", value != null ? new TerraformLiteralProperty<object>(value) : null);
    }

    /// <summary>
    /// Gets or sets the cloud block configuration (for Terraform Cloud/Enterprise).
    /// </summary>
    public object? Cloud
    {
        get => GetProperty<TerraformLiteralProperty<object>>("cloud")?.Value;
        set => WithPropertyInternal("cloud", value != null ? new TerraformLiteralProperty<object>(value) : null);
    }

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => throw new NotSupportedException("Terraform configuration blocks cannot be referenced in expressions.");

    /// <inheritdoc/>
    public override string Resolve(ITerraformContext? context = null)
    {
        context ??= TerraformContext.Temporary(this);

        var sb = new System.Text.StringBuilder();
        sb.AppendLine("terraform {");

        using (context.PushIndent())
        {
            // Render in specific order for Terraform conventions
            // 1. required_version (from properties)
            if (Properties.TryGetValue("required_version", out var versionProp))
            {
                sb.AppendLine($"{context.Indent}required_version = {versionProp.Resolve(context).ToHcl(context)}");
                sb.AppendLine();
            }

            // 2. Required providers
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

            // 3. Experiments
            if (_experiments.Count > 0)
            {
                var experimentsList = string.Join(", ", _experiments.Select(e => $"\"{e}\""));
                sb.AppendLine($"{context.Indent}experiments = [{experimentsList}]");
                sb.AppendLine();
            }

            // 4. Other properties (backend, cloud, provider_meta, etc.) - exclude required_version
            foreach (var (key, property) in Properties.Where(p => p.Key != "required_version").OrderBy(p => p.Key))
            {
                var expression = property.Resolve(context);
                var hcl = expression.ToHcl(context);
                sb.AppendLine($"{context.Indent}{key}{expression.AssignmentOperator}{hcl}");
            }
        }

        sb.AppendLine("}");

        return sb.ToString();
    }
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
