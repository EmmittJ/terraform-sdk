namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform locals block containing local values.
/// </summary>
public class TerraformLocal : TerraformConstruct
{
    /// <summary>
    /// Gets a reference to a local value.
    /// </summary>
    public TerraformReferenceExpression this[string name]
    {
        get
        {
            if (!Properties.ContainsKey(name))
            {
                throw new TerraformConfigurationException(
                    $"Local value '{name}' has not been defined. " +
                    $"Use Set(\"{name}\", value) to define it first.",
                    this,
                    name);
            }
            return new TerraformReferenceExpression(this, name);
        }
    }

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier("local");

    /// <summary>
    /// Gets the reference expression for a specific local value.
    /// </summary>
    public TerraformExpression AsReference(string name)
        => TerraformExpression.Identifier($"local.{name}");

    /// <inheritdoc/>
    public override string Resolve(ITerraformContext? context = null)
    {
        if (Properties.Count == 0)
        {
            return string.Empty;
        }
        context ??= TerraformContext.Temporary(this);

        var sb = new System.Text.StringBuilder();

        sb.AppendLine($"{context.Indent}locals {{");

        using (context.PushIndent())
        {
            foreach (var (name, property) in Properties)
            {
                var expression = property.ToExpression();

                // Check if this is a block (nested block syntax without '=')
                if (expression is TerraformBlockExpression block)
                {
                    // Don't push indent - block.ToHcl() will handle its own indentation
                    sb.AppendLine($"{context.Indent}{name} {block.ToHcl(context)}");
                }
                else
                {
                    // Standard property assignment with '='
                    var hcl = property.Resolve(context);
                    sb.AppendLine($"{context.Indent}{name} = {hcl}");
                }
            }
        }

        sb.AppendLine($"{context.Indent}}}");

        return sb.ToString();
    }
}
