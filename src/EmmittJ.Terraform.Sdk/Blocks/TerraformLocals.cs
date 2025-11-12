namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform locals block containing local values.
/// </summary>
public class TerraformLocals : TerraformBlock, ITerraformTopLevelBlock
{
    /// <summary>
    /// Gets the block type keyword for locals.
    /// </summary>
    public string BlockType => "locals";

    /// <summary>
    /// Gets the block labels for this locals block (none).
    /// </summary>
    public string[] BlockLabels => [];

    public TerraformLocals() : base("") { }

    /// <summary>
    /// Sets a local value for serialization.
    /// </summary>
    /// <param name="name">The local value name.</param>
    /// <param name="value">The value to set.</param>
    public void Set(string name, object value)
    {
        SetPropertyValue(name, value);
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

    /// <summary>
    /// Resolves to a TerraformBlockExpression representing the locals block.
    /// </summary>
    public override TerraformExpression Resolve(ITerraformContext ctx)
    {
        // Get map expression from properties (via base.Resolve())
        var bodyMap = base.Resolve(ctx);

        // Wrap in block expression with "locals" block type and no labels
        return new TerraformBlockExpression("locals", [], bodyMap);
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
