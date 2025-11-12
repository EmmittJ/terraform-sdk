namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform variable declaration - a top-level construct for input values.
/// Inherits from TerraformBlock to reuse property storage and expression infrastructure.
/// </summary>
/// <remarks>
/// Input variables let you customize aspects of Terraform modules without altering
/// the module's own source code. This functionality allows you to share modules across
/// different Terraform configurations, making your module composable and reusable.
/// </remarks>
public partial class TerraformVariable : TerraformBlock
{
    /// <summary>
    /// Gets the name of the variable.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Initializes a new instance of TerraformVariable.
    /// </summary>
    /// <param name="name">The variable name.</param>
    public TerraformVariable(string name) : base("")
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

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

    /// <summary>
    /// Resolves to a TerraformConstructExpression representing the variable block.
    /// Overrides the base Resolve() to return a construct expression instead of a map expression.
    /// </summary>
    /// <param name="ctx">The resolution context.</param>
    /// <returns>A TerraformConstructExpression with block type "variable" and label [name].</returns>
    public override TerraformExpression Resolve(ITerraformResolveContext ctx)
    {
        // Get map expression from properties (via base.Resolve())
        var bodyMap = base.Resolve(ctx);

        // Wrap in construct expression with variable name
        return new TerraformConstructExpression("variable", [Name], bodyMap);
    }

    /// <summary>
    /// Generates a reference to this variable (e.g., "var.region").
    /// Used when referencing this variable's value in other parts of the configuration.
    /// </summary>
    /// <returns>An identifier expression for this variable.</returns>
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
