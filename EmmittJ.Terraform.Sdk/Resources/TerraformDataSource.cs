namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform data source block.
/// </summary>
public class TerraformDataSource(string type, string name) : TerraformProvisionableConstruct(type, name)
{
    /// <inheritdoc/>
    public override string BlockType => "data";

    /// <inheritdoc/>
    protected override string[] BlockLabels => [ConstructType, ConstructName];

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"data.{ConstructType}.{ConstructName}");

    /// <inheritdoc/>
    protected override void WriteAdditionalProperties(System.Text.StringBuilder sb, ITerraformContext context)
    {
        // Meta-arguments first
        WriteMetaArguments(sb, context);
    }
}
