namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform ephemeral resource block.
/// Ephemeral resources are used for temporary credentials, tokens, and secrets
/// that don't persist in the Terraform state file.
/// </summary>
public class TerraformEphemeralResource(string type, string name) : TerraformProvisionableConstruct(type, name)
{
    /// <inheritdoc/>
    public override string BlockType => "ephemeral";

    /// <inheritdoc/>
    protected override string[] BlockLabels => [ConstructType, ConstructName];

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"{ConstructType}.{ConstructName}");

    /// <inheritdoc/>
    protected override void WriteAdditionalProperties(System.Text.StringBuilder sb, ITerraformContext context)
    {
        // Ephemeral resources don't support meta-arguments like lifecycle, provisioners, etc.
        // They are short-lived and don't persist in state
    }
}
