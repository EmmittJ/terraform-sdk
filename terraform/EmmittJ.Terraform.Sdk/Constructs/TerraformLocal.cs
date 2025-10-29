namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform locals block containing local values.
/// </summary>
public class TerraformLocal : TerraformConstruct
{
    /// <summary>
    /// Gets a reference to a local value.
    /// </summary>
    public TerraformReference this[string name]
    {
        get
        {
            if (!Properties.ContainsKey(name))
            {
                throw new InvalidOperationException(
                    $"Local value '{name}' has not been defined. " +
                    $"Call Set(\"{name}\", value) first.");
            }
            return new TerraformReference(this, name);
        }
    }

    /// <inheritdoc/>
    public override TerraformExpression GetReferenceExpression()
        => TerraformExpression.Identifier("local");

    /// <summary>
    /// Gets the reference expression for a specific local value.
    /// </summary>
    public TerraformExpression GetReferenceExpression(string name)
        => TerraformExpression.Identifier($"local.{name}");

    /// <inheritdoc/>
    public override string ToHcl(int indent = 0)
    {
        if (Properties.Count == 0)
        {
            return string.Empty;
        }

        var indentStr = new string(' ', indent * 2);
        var innerIndent = new string(' ', (indent + 1) * 2);
        var sb = new System.Text.StringBuilder();

        sb.AppendLine($"{indentStr}locals {{");

        foreach (var (name, value) in Properties)
        {
            if (!value.IsEmpty)
            {
                var compiledExpr = value.Compile();

                // Check if this is a block (nested block syntax without '=')
                if (compiledExpr is TerraformBlock block)
                {
                    sb.AppendLine($"{innerIndent}{name} {block.ToHcl(indent + 1)}");
                }
                else
                {
                    sb.AppendLine($"{innerIndent}{name} = {compiledExpr.ToHcl()}");
                }
            }
        }

        sb.AppendLine($"{indentStr}}}");

        return sb.ToString();
    }
}
