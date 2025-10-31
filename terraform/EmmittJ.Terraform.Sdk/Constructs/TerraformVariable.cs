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
    protected override string BlockType => "variable";

    /// <inheritdoc/>
    protected override string[] Labels => [Name];

    /// <summary>
    /// Gets or sets the description of the variable.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => WithPropertyInternal("description", value, priority: 0);  // description first
    }

    /// <summary>
    /// Gets or sets the default value.
    /// Can be a literal value or an expression.
    /// </summary>
    public TerraformProperty? Default
    {
        get => GetProperty<TerraformProperty>("default");
        set => WithPropertyInternal("default", value, priority: 2);  // default after type
    }

    /// <summary>
    /// Gets or sets the type constraint (e.g., "string", "list(string)").
    /// </summary>
    public TerraformTypeProperty? Type
    {
        get => GetProperty<TerraformTypeProperty>("type");
        set => WithPropertyInternal("type", value, priority: 1);  // type second
    }

    /// <summary>
    /// Gets or sets whether the variable is sensitive.
    /// </summary>
    public TerraformLiteralProperty<bool>? Sensitive
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sensitive");
        set => WithPropertyInternal("sensitive", value, priority: 3);  // sensitive last
    }

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"var.{Name}");
}
