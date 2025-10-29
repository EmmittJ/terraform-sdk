namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform resource block.
/// </summary>
public class TerraformResource(string type, string name) : TerraformProvisionableConstruct(type, name)
{

    /// <inheritdoc/>
    protected override string GetConstructTypeLabel() => "resource";

    /// <inheritdoc/>
    public override TerraformExpression GetReferenceExpression()
        => TerraformExpression.Identifier($"{Type}.{Name}");

    /// <inheritdoc/>
    public override string ToHcl(int indent = 0)
    {
        var indentStr = new string(' ', indent * 2);
        var innerIndent = new string(' ', (indent + 1) * 2);
        var sb = new System.Text.StringBuilder();

        sb.AppendLine($"{indentStr}resource \"{Type}\" \"{Name}\" {{");

        // Meta-arguments first
        WriteMetaArguments(sb, innerIndent);

        // Regular properties
        WriteProperties(sb, innerIndent);

        sb.AppendLine($"{indentStr}}}");

        return sb.ToString();
    }
}
