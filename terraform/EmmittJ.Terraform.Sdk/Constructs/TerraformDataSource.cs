namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform data source block.
/// </summary>
public class TerraformDataSource(string type, string name) : TerraformProvisionableConstruct(type, name)
{

    /// <inheritdoc/>
    protected override string GetConstructTypeLabel() => "data source";

    /// <inheritdoc/>
    public override TerraformExpression GetReferenceExpression()
        => TerraformExpression.Identifier($"data.{Type}.{Name}");

    /// <inheritdoc/>
    public override string ToHcl(int indent = 0)
    {
        var indentStr = new string(' ', indent * 2);
        var innerIndent = new string(' ', (indent + 1) * 2);
        var sb = new System.Text.StringBuilder();

        sb.AppendLine($"{indentStr}data \"{Type}\" \"{Name}\" {{");

        // Meta-arguments first
        WriteMetaArguments(sb, innerIndent);

        // Regular properties
        WriteProperties(sb, innerIndent);

        sb.AppendLine($"{indentStr}}}");

        return sb.ToString();
    }
}
