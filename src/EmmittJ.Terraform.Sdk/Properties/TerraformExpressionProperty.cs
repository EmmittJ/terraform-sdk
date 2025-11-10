namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform property that resolves to an expression.
/// Used for advanced scenarios like conditional expressions, function calls, etc.
/// </summary>
/// <typeparam name="TValue">The expected type of the value when resolved.</typeparam>
/// <remarks>
/// This property type stores a Terraform expression and resolves to that expression.
/// Used for advanced scenarios where the value is computed via Terraform expressions.
/// 
/// Usage patterns:
/// <code>
/// // Conditional expression
/// instance.InstanceType = new TerraformExpressionProperty&lt;string&gt;(
///     TerraformExpression.Conditional(
///         TerraformExpression.Identifier("var.is_production"),
///         TerraformExpression.Literal("t3.large"),
///         TerraformExpression.Literal("t3.micro")
///     )
/// );
/// 
/// // Function call
/// instance.Tags = new TerraformExpressionProperty&lt;Dictionary&lt;string, string&gt;&gt;(
///     TerraformExpression.FunctionCall("merge",
///         TerraformExpression.Identifier("var.common_tags"),
///         TerraformExpression.Object(new Dictionary&lt;string, TerraformExpression&gt; {
///             ["Name"] = TerraformExpression.Literal("my-instance")
///         })
///     )
/// );
/// </code>
/// </remarks>
public class TerraformExpressionProperty<TValue> : TerraformProperty<TValue>, ITerraformExpression
{
    private readonly TerraformExpression _expression;

    /// <summary>
    /// Initializes a new expression property with a resource address, attribute name, and expression.
    /// </summary>
    /// <param name="resourceAddress">The address of the resource.</param>
    /// <param name="attributeName">The name of the attribute.</param>
    /// <param name="expression">The Terraform expression to store.</param>
    public TerraformExpressionProperty(string resourceAddress, string attributeName, TerraformExpression expression)
        : base(resourceAddress, attributeName)
    {
        _expression = expression;
    }

    /// <summary>
    /// Preparation phase - prepares the stored expression.
    /// </summary>
    /// <param name="context">The context for dependency tracking.</param>
    public override void Prepare(ITerraformContext context)
    {
        if (_expression is ITerraformPreparable preparable)
        {
            preparable.Prepare(context);
        }
    }

    /// <summary>
    /// Resolution phase - returns the stored expression.
    /// </summary>
    /// <param name="context">Optional context for resolution.</param>
    /// <returns>The stored Terraform expression.</returns>
    public override TerraformExpression Resolve(ITerraformContext? context = null)
    {
        return _expression;
    }

    /// <summary>
    /// Implicit conversion from TerraformExpression.
    /// Enables ergonomic property assignment from expressions.
    /// </summary>
    /// <param name="expression">The expression to wrap.</param>
    public static implicit operator TerraformExpressionProperty<TValue>(TerraformExpression expression)
    {
        return new TerraformExpressionProperty<TValue>("", "", expression);
    }
}
