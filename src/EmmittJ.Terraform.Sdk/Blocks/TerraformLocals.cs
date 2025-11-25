using System.Text;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform locals block containing local values.
/// </summary>
/// <remarks>
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/block/locals"/></para>
/// </remarks>
public class TerraformLocals : TerraformBlock, ITerraformNamedReferenceable
{
    /// <summary>
    /// Gets the block type keyword for locals.
    /// </summary>
    public override string BlockType => "locals";

    /// <summary>
    /// Gets the block labels (locals blocks have none).
    /// </summary>
    public override string[] BlockLabels => [];

    /// <summary>
    /// Initializes a new instance of TerraformLocals.
    /// </summary>
    public TerraformLocals() { }

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier("local");

    /// <inheritdoc/>
    public TerraformExpression AsReference(string name)
        => TerraformExpression.Identifier($"local.{name}");
}
