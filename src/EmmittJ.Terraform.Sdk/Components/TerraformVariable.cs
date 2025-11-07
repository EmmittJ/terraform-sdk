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
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value, priority: 0);  // description first
    }

    /// <summary>
    /// Gets or sets the default value.
    /// Can be a literal value or an expression.
    /// </summary>
    public TerraformProperty? Default
    {
        get => GetProperty<TerraformProperty>("default");
        set => this.WithProperty("default", value, priority: 2);  // default after type
    }

    /// <summary>
    /// Gets or sets the type constraint (e.g., "string", "list(string)").
    /// </summary>
    public TerraformTypeProperty? Type
    {
        get => GetProperty<TerraformTypeProperty>("type");
        set => this.WithProperty("type", value, priority: 1);  // type second
    }

    /// <summary>
    /// Gets or sets whether the variable is sensitive.
    /// </summary>
    public TerraformProperty<bool>? Sensitive
    {
        get => GetProperty<TerraformProperty<bool>>("sensitive");
        set => this.WithProperty("sensitive", value, priority: 3);  // sensitive last
    }

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"var.{Name}");
}
