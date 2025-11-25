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
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/block/variable"/></para>
/// </remarks>
public partial class TerraformVariable : TerraformBlock, ITerraformReferenceable
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
        get => GetArgument<TerraformValue<string>?>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Gets or sets the default value.
    /// Can be a literal value or an expression.
    /// </summary>
    public TerraformValue<object>? Default
    {
        get => GetArgument<TerraformValue<object>?>("default");
        set => SetArgument("default", value);
    }

    /// <summary>
    /// Gets or sets the type constraint for this variable.
    /// Use <see cref="TerraformTypeExpression"/> static properties and methods to construct types.
    /// </summary>
    /// <example>
    /// <code>
    /// // Primitive types
    /// var v1 = new TerraformVariable("name") { Type = TerraformTypeExpression.String };
    /// // Renders as: type = string
    ///
    /// // Collection types
    /// var v2 = new TerraformVariable("items") { Type = TerraformTypeExpression.List(TerraformTypeExpression.String) };
    /// // Renders as: type = list(string)
    ///
    /// // Object types
    /// var v3 = new TerraformVariable("config") {
    ///     Type = TerraformTypeExpression.Object(
    ///         ("name", TerraformTypeExpression.String),
    ///         ("count", TerraformTypeExpression.Number)
    ///     )
    /// };
    /// // Renders as: type = object({ name = string, count = number })
    ///
    /// // String shorthand (implicit conversion)
    /// var v4 = new TerraformVariable("tags") { Type = "map(string)" };
    /// </code>
    /// </example>
    /// <remarks>
    /// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/expressions/types"/></para>
    /// </remarks>
    public TerraformTypeExpression? Type
    {
        get => GetArgument<TerraformTypeExpression?>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Gets or sets whether the variable is sensitive.
    /// </summary>
    public TerraformValue<bool>? Sensitive
    {
        get => GetArgument<TerraformValue<bool>?>("sensitive");
        set => SetArgument("sensitive", value);
    }

    /// <summary>
    /// Gets or sets whether the variable can be null.
    /// When false, the variable must have a non-null value.
    /// Default: true
    /// </summary>
    public TerraformValue<bool>? Nullable
    {
        get => GetArgument<TerraformValue<bool>?>("nullable");
        set => SetArgument("nullable", value);
    }

    /// <summary>
    /// Gets or sets whether the variable is ephemeral.
    /// Ephemeral variables are available during runtime but omitted from state and plan files.
    /// Available in Terraform v1.10 and later.
    /// Default: false
    /// </summary>
    public TerraformValue<bool>? Ephemeral
    {
        get => GetArgument<TerraformValue<bool>?>("ephemeral");
        set => SetArgument("ephemeral", value);
    }

    /// <summary>
    /// Gets the list of validation blocks for this variable.
    /// Each validation block contains a condition and error_message.
    /// </summary>
    public TerraformList<TerraformConditionBlock> Validations
    {
        get => GetArgument<TerraformList<TerraformConditionBlock>?>("validation") ?? new TerraformList<TerraformConditionBlock>();
        set => SetArgument("validation", value);
    }

    /// <summary>
    /// Generates a reference to this variable.
    /// </summary>
    /// <returns>A reference to this variable.</returns>
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
        var validationBlock = new TerraformConditionBlock("validation")
        {
            Condition = TerraformExpression.Raw(condition),
            ErrorMessage = errorMessage
        };
        validations.Add(validationBlock);
        Validations = validations;
        return this;
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

