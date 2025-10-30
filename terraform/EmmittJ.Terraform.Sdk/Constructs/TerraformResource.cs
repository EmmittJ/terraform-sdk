namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform resource block.
/// </summary>
public class TerraformResource(string type, string name) : TerraformProvisionableConstruct(type, name)
{

    /// <inheritdoc/>
    protected override string GetConstructTypeLabel() => "resource";

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"{Type}.{Name}");

    /// <inheritdoc/>
    public override string Resolve(ITerraformContext? context = null)
    {
        context ??= TerraformContext.Temporary(this);
        var sb = new System.Text.StringBuilder();

        sb.AppendLine($"{context.Indent}resource \"{Type}\" \"{Name}\" {{");

        using (context.PushIndent())
        {
            // Meta-arguments first
            WriteMetaArguments(sb, context);

            // Regular properties
            WriteProperties(sb, context);
        }

        sb.AppendLine($"{context.Indent}}}");

        return sb.ToString();
    }
}
