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
    [TerraformPropertyName("description")]
    public TerraformProperty<string>? Description { get; set; }

    /// <summary>
    /// Gets or sets the default value.
    /// Can be a literal value or an expression.
    /// </summary>
    [TerraformPropertyName("default")]
    public TerraformProperty<TerraformExpression>? Default { get; set; }

    /// <summary>
    /// Gets or sets the type constraint (e.g., "string", "list(string)").
    /// </summary>
    [TerraformPropertyName("type")]
    public TerraformProperty<string>? Type { get; set; }

    /// <summary>
    /// Gets or sets whether the variable is sensitive.
    /// </summary>
    [TerraformPropertyName("sensitive")]
    public TerraformProperty<bool>? Sensitive { get; set; }

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"var.{Name}");
}
