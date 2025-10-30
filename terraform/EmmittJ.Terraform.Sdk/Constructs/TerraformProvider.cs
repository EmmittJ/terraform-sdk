namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform provider configuration block.
/// </summary>
public class TerraformProvider(string name) : NamedTerraformConstruct(name)
{
    /// <summary>
    /// Gets or sets the alias for this provider instance.
    /// </summary>
    public string? Alias { get; set; }

    /// <inheritdoc/>
    public override TerraformExpression GetReferenceExpression()
        => TerraformExpression.Identifier(Alias != null ? $"{Name}.{Alias}" : Name);

    /// <inheritdoc/>
    public override string Resolve(ITerraformContext? context = null)
    {
        context ??= TerraformContext.Temporary(this);
        var sb = new System.Text.StringBuilder();

        sb.AppendLine($"{context.Indent}provider \"{Name}\" {{");

        using (context.PushIndent())
        {
            // Alias comes first if present
            if (Alias != null)
            {
                sb.AppendLine($"{context.Indent}alias = \"{Alias}\"");
            }

            WriteProperties(sb, context);
        }

        sb.AppendLine($"{context.Indent}}}");

        return sb.ToString();
    }
}
