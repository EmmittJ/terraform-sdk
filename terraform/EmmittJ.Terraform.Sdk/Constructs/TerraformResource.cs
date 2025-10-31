namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform resource block.
/// </summary>
public class TerraformResource(string type, string name) : TerraformProvisionableConstruct(type, name)
{
    /// <inheritdoc/>
    protected override string BlockType => "resource";

    /// <inheritdoc/>
    protected override string[] Labels => [Type, Name];

    /// <inheritdoc/>
    protected override string GetConstructTypeLabel() => "resource";

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"{Type}.{Name}");

    /// <inheritdoc/>
    protected override void WriteAdditionalProperties(System.Text.StringBuilder sb, ITerraformContext context)
    {
        // Meta-arguments first
        WriteMetaArguments(sb, context);
    }
}
