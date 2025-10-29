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
    public override string ToHcl(int indent = 0)
    {
        var indentStr = new string(' ', indent * 2);
        var innerIndent = new string(' ', (indent + 1) * 2);
        var sb = new System.Text.StringBuilder();

        sb.AppendLine($"{indentStr}provider \"{Name}\" {{");

        // Alias comes first if present
        if (Alias != null)
        {
            sb.AppendLine($"{innerIndent}alias = \"{Alias}\"");
        }

        // Configuration properties
        foreach (var (key, value) in Properties)
        {
            if (!value.IsEmpty)
            {
                var compiledExpr = value.Compile();

                // Check if this is a block (nested block syntax without '=')
                if (compiledExpr is TerraformBlock block)
                {
                    sb.AppendLine($"{innerIndent}{key} {block.ToHcl(indent + 1)}");
                }
                else
                {
                    sb.AppendLine($"{innerIndent}{key} = {compiledExpr.ToHcl()}");
                }
            }
        }

        sb.AppendLine($"{indentStr}}}");

        return sb.ToString();
    }
}
