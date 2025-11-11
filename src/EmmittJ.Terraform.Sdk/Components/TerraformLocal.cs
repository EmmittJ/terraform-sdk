namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform locals block containing local values.
/// </summary>
public class TerraformLocal : TerraformConstruct
{
    /// <inheritdoc/>
    public override string BlockType => "locals";

    /// <inheritdoc/>
    protected override string[] BlockLabels => Array.Empty<string>();

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
    /// Always returns a reference expression (local.{name}) for use in other constructs.
    /// </summary>
    /// <param name="name">The name of the local value.</param>
    /// <returns>A reference expression to the local value.</returns>
    public TerraformExpression this[string name]
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
}
