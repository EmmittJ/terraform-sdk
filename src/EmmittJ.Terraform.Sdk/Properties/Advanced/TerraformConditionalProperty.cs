namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform conditional expression property.
/// Resolves to a ternary conditional: condition ? true_value : false_value
/// </summary>
/// <typeparam name="TValue">The expected type of the value when resolved.</typeparam>
/// <remarks>
/// This property type provides a type-safe way to create conditional expressions in Terraform.
/// 
/// Usage:
/// <code>
/// // Conditional instance type based on environment
/// instance.InstanceType = new TerraformConditionalProperty&lt;string&gt;(
///     TerraformExpression.Identifier("var.is_production"),
///     TerraformExpression.Literal("t3.large"),
///     TerraformExpression.Literal("t3.micro")
/// );
/// // Generates: instance_type = var.is_production ? "t3.large" : "t3.micro"
/// 
/// // Using with property references
/// instance.InstanceType = new TerraformConditionalProperty&lt;string&gt;(
///     someCondition,
///     otherInstance.InstanceType,  // Reference to another property
///     "t3.nano"
/// );
/// </code>
/// </remarks>
public class TerraformConditionalProperty<TValue> : TerraformProperty<TValue>
{
    private readonly TerraformProperty<bool> _condition;
    private readonly TerraformProperty<TValue> _trueValue;
    private readonly TerraformProperty<TValue> _falseValue;

    /// <summary>
    /// Initializes a new conditional property.
    /// </summary>
    /// <param name="condition">The condition expression (must resolve to boolean).</param>
    /// <param name="trueValue">The value to use when condition is true.</param>
    /// <param name="falseValue">The value to use when condition is false.</param>
    public TerraformConditionalProperty(
        TerraformProperty<bool> condition,
        TerraformProperty<TValue> trueValue,
        TerraformProperty<TValue> falseValue)
        : base("", "")
    {
        _condition = condition ?? throw new ArgumentNullException(nameof(condition));
        _trueValue = trueValue ?? throw new ArgumentNullException(nameof(trueValue));
        _falseValue = falseValue ?? throw new ArgumentNullException(nameof(falseValue));
    }

    /// <summary>
    /// Initializes a new conditional property with expression-based arguments.
    /// </summary>
    /// <param name="condition">The condition expression.</param>
    /// <param name="trueValue">The expression for true case.</param>
    /// <param name="falseValue">The expression for false case.</param>
    public TerraformConditionalProperty(
        TerraformExpression condition,
        TerraformExpression trueValue,
        TerraformExpression falseValue)
        : base("", "")
    {
        _condition = new TerraformExpressionProperty<bool>("", "", condition);
        _trueValue = new TerraformExpressionProperty<TValue>("", "", trueValue);
        _falseValue = new TerraformExpressionProperty<TValue>("", "", falseValue);
    }

    /// <summary>
    /// Preparation phase - prepares all nested values.
    /// </summary>
    /// <param name="context">The context for dependency tracking.</param>
    public override void Prepare(ITerraformContext context)
    {
        if (_condition is ITerraformPreparable conditionPreparable)
        {
            conditionPreparable.Prepare(context);
        }

        if (_trueValue is ITerraformPreparable truePreparable)
        {
            truePreparable.Prepare(context);
        }

        if (_falseValue is ITerraformPreparable falsePreparable)
        {
            falsePreparable.Prepare(context);
        }
    }

    /// <summary>
    /// Resolution phase - resolves to a conditional expression.
    /// </summary>
    /// <param name="context">Optional context for resolution.</param>
    /// <returns>A Terraform conditional expression.</returns>
    public override TerraformExpression Resolve(ITerraformContext? context = null)
    {
        var conditionExpr = _condition.Resolve(context);
        var trueExpr = _trueValue.Resolve(context);
        var falseExpr = _falseValue.Resolve(context);

        return TerraformExpression.Conditional(conditionExpr, trueExpr, falseExpr);
    }
}
