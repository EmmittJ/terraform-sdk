namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform resource block.
/// </summary>
public class TerraformResource(string type, string name) : TerraformProvisionableConstruct(type, name)
{
    /// <inheritdoc/>
    public override string BlockType => "resource";

    /// <inheritdoc/>
    protected override string[] BlockLabels => [ConstructType, ConstructName];

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"{ConstructType}.{ConstructName}");

    /// <inheritdoc/>
    protected override void WriteProperties(System.Text.StringBuilder sb, ITerraformContext context)
    {
        // Call base to write all regular properties
        base.WriteProperties(sb, context);

        // Then write meta-arguments
        WriteMetaArguments(sb, context);
    }
}
