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

    /// <summary>
    /// Gets or sets the required Terraform version constraint (e.g., ">= 1.0", "~> 1.5.0").
    /// </summary>
    public TerraformValue<string> RequiredVersion { get; set; } = new();

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
        get => this.Get<TerraformBackend>("backend")?.LiteralValue;
        set
        {
            if (value is not null)
            {
                SetInternal("backend", new TerraformValue<TerraformBackend>(value));
            }
        }
    }
    private TerraformBackend? _backend;

    /// <summary>
    /// Gets or sets the provider metadata block (for provider development).
    /// </summary>
    public TerraformValue<object> ProviderMeta { get; set; } = new();

    /// <summary>
    /// Gets or sets the cloud block configuration (for Terraform Cloud/Enterprise).
    /// </summary>
    public TerraformValue<object> Cloud { get; set; } = new();

    /// <inheritdoc/>
    public override TerraformExpression GetReferenceExpression()
        => throw new NotSupportedException("Terraform configuration blocks cannot be referenced in expressions.");

    /// <inheritdoc/>
    public override string Resolve(ITerraformContext? context = null)
    {
        context ??= TerraformContext.Temporary(this);

        var sb = new System.Text.StringBuilder();
        sb.AppendLine("terraform {");

        using (context.PushIndent())
        {
            // Required version
            if (!RequiredVersion.IsEmpty)
            {
                sb.AppendLine($"{context.Indent}required_version = {RequiredVersion.Resolve(context).ToHcl(context)}");
                sb.AppendLine();
            }

            // Required providers
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

            // Experiments
            if (_experiments.Count > 0)
            {
                var experimentsList = string.Join(", ", _experiments.Select(e => $"\"{e}\""));
                sb.AppendLine($"{context.Indent}experiments = [{experimentsList}]");
                sb.AppendLine();
            }

            // Write properties added via SetInternal (backend, cloud, provider_meta, etc.)
            if (Properties.Count > 0)
            {
                WriteProperties(sb, context);
                sb.AppendLine();
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
    public override TerraformExpression GetReferenceExpression()
        => throw new NotSupportedException("Cloud blocks cannot be referenced in expressions.");

    /// <inheritdoc/>
    public override string Resolve(ITerraformContext? context = null)
    {
        context ??= TerraformContext.Temporary(this);
        var sb = new System.Text.StringBuilder();

        sb.AppendLine($"{context.Indent}cloud {{");

        using (context.PushIndent())
        {
            WriteProperties(sb, context);
        }

        sb.AppendLine($"{context.Indent}}}");

        return sb.ToString();
    }
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
