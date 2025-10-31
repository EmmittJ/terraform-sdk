namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform data source block.
/// </summary>
public class TerraformDataSource(string type, string name) : TerraformProvisionableConstruct(type, name)
{
    /// <inheritdoc/>
    protected override string BlockType => "data";

    /// <inheritdoc/>
    protected override string[] Labels => [Type, Name];

    /// <inheritdoc/>
    protected override string GetConstructTypeLabel() => "data source";

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"data.{Type}.{Name}");

    /// <inheritdoc/>
    protected override void WriteAdditionalProperties(System.Text.StringBuilder sb, ITerraformContext context)
    {
        // Meta-arguments first
        WriteMetaArguments(sb, context);
    }
}
