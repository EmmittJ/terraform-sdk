using System.Text;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform variable declaration - a top-level block for input values.
/// Inherits from TerraformBlock to reuse property storage and expression infrastructure.
/// </summary>
/// <remarks>
/// Input variables let you customize aspects of Terraform modules without altering
/// the module's own source code. This functionality allows you to share modules across
/// different Terraform configurations, making your module composable and reusable.
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/values/variables"/></para>
/// </remarks>
public partial class TerraformVariable : TerraformBlock
{
    /// <summary>
    /// Gets the name of the variable.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the block type keyword for variables.
    /// </summary>
    public override string BlockType => "variable";

    /// <summary>
    /// Gets the block labels (just the variable name).
    /// </summary>
    public override string[] BlockLabels => [Name];

    /// <summary>
    /// Initializes a new instance of TerraformVariable.
    /// </summary>
    /// <param name="name">The variable name.</param>
    public TerraformVariable(string name)
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
    /// Gets or sets whether the variable can be null.
    /// When false, the variable must have a non-null value.
    /// Default: true
    /// </summary>
    public TerraformValue<bool>? Nullable
    {
        get => GetPropertyValue<TerraformValue<bool>?>("nullable");
        set => SetPropertyValue("nullable", value);
    }

    /// <summary>
    /// Gets or sets whether the variable is ephemeral.
    /// Ephemeral variables are available during runtime but omitted from state and plan files.
    /// Available in Terraform v1.10 and later.
    /// Default: false
    /// </summary>
    public TerraformValue<bool>? Ephemeral
    {
        get => GetPropertyValue<TerraformValue<bool>?>("ephemeral");
        set => SetPropertyValue("ephemeral", value);
    }

    /// <summary>
    /// Gets the list of validation blocks for this variable.
    /// Each validation block contains a condition and error_message.
    /// </summary>
    public TerraformList<TerraformConditionBlock> Validations
    {
        get => GetPropertyValue<TerraformList<TerraformConditionBlock>?>("validation") ?? new TerraformList<TerraformConditionBlock>();
        set => SetPropertyValue("validation", value);
    }

    /// <summary>
    /// Generates a reference to this variable (e.g., "var.region").
    /// Used when referencing this variable's value in other parts of the configuration.
    /// </summary>
    /// <returns>An identifier expression for this variable.</returns>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"var.{Name}");

    /// <summary>
    /// Adds a validation block to this variable.
    /// </summary>
    /// <param name="condition">The condition expression that must evaluate to true.</param>
    /// <param name="errorMessage">The error message to display if the condition is false.</param>
    /// <returns>This variable instance for fluent chaining.</returns>
    public TerraformVariable AddValidation(string condition, string errorMessage)
    {
        var validations = Validations;
        validations.Add(new TerraformConditionBlock("validation", condition, errorMessage));
        Validations = validations;
        return this;
    }

    /// <summary>
    /// Resolves this variable to a top-level block node.
    /// </summary>
    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        var children = base.ResolveNodes(context).ToList();
        yield return new TerraformBlockNode(BlockType, BlockLabels, children);
    }

    /// <summary>
    /// Implicit conversion to TerraformExpression for natural reference usage.
    /// Allows using variables directly in expressions without calling AsReference().
    /// </summary>
    /// <param name="variable">The variable to convert.</param>
    /// <returns>A TerraformExpression representing the variable reference.</returns>
    public static implicit operator TerraformExpression(TerraformVariable variable)
        => variable.AsReference();
}
