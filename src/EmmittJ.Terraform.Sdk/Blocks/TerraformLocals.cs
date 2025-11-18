using System.Text;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform locals block containing local values.
/// </summary>
/// <remarks>
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/block/locals"/></para>
/// </remarks>
public class TerraformLocals : TerraformBlock
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

    /// <summary>
    /// Gets a reference to a local value.
    /// Always returns a reference expression (local.{name}) for use in other blocks.
    /// </summary>
    /// <param name="name">The name of the local value.</param>
    /// <returns>A reference expression to the local value.</returns>
    public new TerraformValue<object> this[string name]
    {
        get => TerraformExpression.Identifier($"local.{name}");
        set => base[name] = value;
    }

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier("local");

    /// <summary>
    /// Gets the reference expression for a specific local value.
    /// </summary>
    /// <param name="name">The name of the local value.</param>
    /// <returns>A reference expression to the local value.</returns>
    public TerraformExpression AsReference(string name)
        => TerraformExpression.Identifier($"local.{name}");
}
