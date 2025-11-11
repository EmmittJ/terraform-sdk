namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform variable declaration.
/// </summary>
public class TerraformVariable(string name) : TerraformConstruct
{
    /// <summary>
    /// Gets the name of the variable.
    /// </summary>
    public string Name { get; } = name ?? throw new ArgumentNullException(nameof(name));

    /// <inheritdoc/>
    public override string BlockType => "variable";

    /// <inheritdoc/>
    protected override string[] BlockLabels => [Name];

    /// <summary>
    /// Gets or sets the description of the variable.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetPropertyValue<TerraformValue<string>?>("description");
        set => SetPropertyValue("description", value);
    }

    /// <summary>
    /// Gets or sets the default value.
    /// Can be a literal value or an expression.
    /// </summary>
    public TerraformValue<object>? Default
    {
        get => GetPropertyValue<TerraformValue<object>?>("default");
        set => SetPropertyValue("default", value);
    }

    /// <summary>
    /// Gets or sets the type constraint (e.g., "string", "list(string)").
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetPropertyValue<TerraformValue<string>?>("type");
        set => SetPropertyValue("type", value);
    }

    /// <summary>
    /// Gets or sets whether the variable is sensitive.
    /// </summary>
    public TerraformValue<bool>? Sensitive
    {
        get => GetPropertyValue<TerraformValue<bool>?>("sensitive");
        set => SetPropertyValue("sensitive", value);
    }

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"var.{Name}");

    /// <summary>
    /// Implicit conversion to TerraformExpression for natural reference usage.
    /// Allows using variables directly in expressions without calling AsReference().
    /// </summary>
    /// <param name="variable">The variable to convert.</param>
    /// <returns>A TerraformExpression representing the variable reference.</returns>
    public static implicit operator TerraformExpression(TerraformVariable variable)
        => variable.AsReference();
}
