namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform resource block.
/// </summary>
public class TerraformResource(string type, string name) : TerraformProvisionableConstruct(type, name)
{
    /// <inheritdoc/>
    protected override string BlockType => "resource";

    /// <inheritdoc/>
    protected override string[] BlockLabels => [ConstructType, ConstructName];

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"{ConstructType}.{ConstructName}");

    /// <inheritdoc/>
    protected override void WriteAdditionalProperties(System.Text.StringBuilder sb, ITerraformContext context)
    {
        // Meta-arguments first
        WriteMetaArguments(sb, context);
    }
}
