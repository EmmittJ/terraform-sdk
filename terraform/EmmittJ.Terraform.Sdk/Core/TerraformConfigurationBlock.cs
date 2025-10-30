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
    public string? RequiredVersion
    {
        get => (GetProperty("required_version") as LiteralProperty<string>)?.Value;
        set => WithPropertyInternal("required_version", value != null ? new LiteralProperty<string>(value) : null);
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
        get => (GetProperty("backend") as ExpressionProperty)?.Expression as TerraformBackend;
        set => WithPropertyInternal("backend", value != null ? new ExpressionProperty(value) : null);
    }

    /// <summary>
    /// Gets or sets the provider metadata block (for provider development).
    /// </summary>
    public object? ProviderMeta
    {
        get => (GetProperty("provider_meta") as LiteralProperty<object>)?.Value;
        set => WithPropertyInternal("provider_meta", value != null ? new LiteralProperty<object>(value) : null);
    }

    /// <summary>
    /// Gets or sets the cloud block configuration (for Terraform Cloud/Enterprise).
    /// </summary>
    public object? Cloud
    {
        get => (GetProperty("cloud") as LiteralProperty<object>)?.Value;
        set => WithPropertyInternal("cloud", value != null ? new LiteralProperty<object>(value) : null);
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
                sb.AppendLine($"{context.Indent}required_version = {versionProp.Resolve(context)}");
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
                var expression = property.ToExpression();

                // Check if this is a block (nested block syntax without '=')
                if (expression is TerraformBlockExpression block)
                {
                    // Don't push indent - block.ToHcl() will handle its own indentation
                    sb.AppendLine($"{context.Indent}{key} {block.ToHcl(context)}");
                }
                else
                {
                    // Standard property assignment with '='
                    var hcl = property.Resolve(context);
                    sb.AppendLine($"{context.Indent}{key} = {hcl}");
                }
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
    public override TerraformExpression AsReference()
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
