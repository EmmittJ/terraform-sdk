namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents Terraform settings including required version, provider requirements, and experiments.
/// Rendered in the terraform {} block.
/// </summary>
public class TerraformSettings
{
    /// <summary>
    /// Gets or sets the required Terraform version constraint (e.g., ">= 1.0", "~> 1.5.0").
    /// </summary>
    public string? RequiredVersion { get; set; }

    /// <summary>
    /// Gets the required providers with their source and version constraints.
    /// </summary>
    public Dictionary<string, ProviderRequirement> RequiredProviders { get; } = new();

    /// <summary>
    /// Gets the list of experimental features to enable.
    /// </summary>
    public List<string> Experiments { get; } = new();

    /// <summary>
    /// Generates the HCL for the terraform settings.
    /// </summary>
    internal string ToHcl(ITerraformContext context)
    {
        var sb = new System.Text.StringBuilder();

        // Required version
        if (!string.IsNullOrWhiteSpace(RequiredVersion))
        {
            sb.AppendLine($"{context.Indent}required_version = \"{RequiredVersion}\"");
            sb.AppendLine();
        }

        // Required providers
        if (RequiredProviders.Count > 0)
        {
            sb.AppendLine($"{context.Indent}required_providers {{");

            using (context.PushIndent())
            {
                foreach (var (name, requirement) in RequiredProviders.OrderBy(p => p.Key))
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
        if (Experiments.Count > 0)
        {
            var experimentsList = string.Join(", ", Experiments.Select(e => $"\"{e}\""));
            sb.AppendLine($"{context.Indent}experiments = [{experimentsList}]");
            sb.AppendLine();
        }

        return sb.ToString();
    }
}
