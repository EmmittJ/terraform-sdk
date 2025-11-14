using System.Text;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform locals block containing local values.
/// </summary>
/// <remarks>
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/values/locals"/></para>
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

    public TerraformLocals() { }

    /// <summary>
    /// Sets a local value for serialization.
    /// </summary>
    /// <param name="name">The local value name.</param>
    /// <param name="value">The value to set.</param>
    public void Set(string name, object value)
    {
        SetArgument(name, value);
    }

    /// <summary>
    /// Gets a reference to a local value.
    /// Always returns a reference expression (local.{name}) for use in other blocks.
    /// </summary>
    /// <param name="name">The name of the local value.</param>
    /// <returns>A reference expression to the local value.</returns>
    public new TerraformExpression this[string name]
    {
        get => TerraformExpression.Identifier($"local.{name}");
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

    /// <summary>
    /// Resolves this locals block to a top-level block node.
    /// </summary>
    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        var children = base.ResolveNodes(context).ToList();
        yield return new TerraformBlockNode(BlockType, BlockLabels, children);
    }
}
