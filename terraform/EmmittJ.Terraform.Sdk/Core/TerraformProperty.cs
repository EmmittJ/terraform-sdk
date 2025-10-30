using System.Collections.Generic;
using System.Linq;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Base class for property values in Terraform constructs.
/// Participates in two-phase resolution (Prepare and Resolve).
/// Replaces TerraformValue&lt;T&gt; with a polymorphic design.
/// </summary>
public abstract class TerraformProperty : ITerraformResolvable<string>
{
    /// <summary>
    /// Preparation phase - prepare nested expressions and track dependencies.
    /// </summary>
    public abstract void Prepare(ITerraformContext context);

    /// <summary>
    /// Resolution phase - resolve to HCL string.
    /// </summary>
    public abstract string Resolve(ITerraformContext? context = null);

    /// <summary>
    /// Convert to expression for use in other expressions.
    /// </summary>
    public abstract TerraformExpression ToExpression();

    /// <summary>
    /// Implicit conversion from literal values to LiteralProperty.
    /// </summary>
    public static implicit operator TerraformProperty(string value)
        => new LiteralProperty<string>(value);

    /// <summary>
    /// Implicit conversion from literal values to LiteralProperty.
    /// </summary>
    public static implicit operator TerraformProperty(int value)
        => new LiteralProperty<int>(value);

    /// <summary>
    /// Implicit conversion from literal values to LiteralProperty.
    /// </summary>
    public static implicit operator TerraformProperty(bool value)
        => new LiteralProperty<bool>(value);

    /// <summary>
    /// Implicit conversion from literal values to LiteralProperty.
    /// </summary>
    public static implicit operator TerraformProperty(double value)
        => new LiteralProperty<double>(value);

    /// <summary>
    /// Implicit conversion from expressions to ExpressionProperty.
    /// </summary>
    public static implicit operator TerraformProperty(TerraformExpression expression)
        => new ExpressionProperty(expression);

    /// <summary>
    /// Implicit conversion from string array to ExpressionProperty (list).
    /// </summary>
    public static implicit operator TerraformProperty(string[] values)
        => new ExpressionProperty(values);

    /// <summary>
    /// Implicit conversion from int array to ExpressionProperty (list).
    /// </summary>
    public static implicit operator TerraformProperty(int[] values)
        => new ExpressionProperty(values);

    /// <summary>
    /// Implicit conversion from List<string> to ExpressionProperty (list).
    /// </summary>
    public static implicit operator TerraformProperty(List<string> values)
        => new ExpressionProperty(TerraformExpression.List(values.Select(TerraformExpression.Literal).ToArray()));
}

/// <summary>
/// Literal property value - wraps a .NET value.
/// No preparation needed since there are no dependencies.
/// </summary>
public sealed class LiteralProperty<T> : TerraformProperty
{
    private readonly T _value;

    /// <summary>
    /// Gets the literal value.
    /// </summary>
    public T Value => _value;

    /// <summary>
    /// Initializes a new instance of the <see cref="LiteralProperty{T}"/> class.
    /// </summary>
    public LiteralProperty(T value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    /// <inheritdoc/>
    public override void Prepare(ITerraformContext context)
    {
        // Literals don't need preparation - no dependencies
    }

    /// <inheritdoc/>
    public override string Resolve(ITerraformContext? context = null)
    {
        return ToExpression().ToHcl(context ?? TerraformContext.Temporary());
    }

    /// <inheritdoc/>
    public override TerraformExpression ToExpression()
    {
        return TerraformExpression.Literal(_value);
    }
}

/// <summary>
/// Expression property value - wraps a TerraformExpression.
/// Delegates preparation to the wrapped expression.
/// </summary>
public sealed class ExpressionProperty : TerraformProperty
{
    private readonly TerraformExpression _expression;

    /// <summary>
    /// Gets the expression.
    /// </summary>
    public TerraformExpression Expression => _expression;

    /// <summary>
    /// Initializes a new instance of the <see cref="ExpressionProperty"/> class.
    /// </summary>
    public ExpressionProperty(TerraformExpression expression)
    {
        _expression = expression ?? throw new ArgumentNullException(nameof(expression));
    }

    /// <inheritdoc/>
    public override void Prepare(ITerraformContext context)
    {
        // Delegate preparation to the expression
        if (_expression is ITerraformPreparable preparable)
        {
            preparable.Prepare(context);
        }
    }

    /// <inheritdoc/>
    public override string Resolve(ITerraformContext? context = null)
    {
        return _expression.ToHcl(context ?? TerraformContext.Temporary());
    }

    /// <inheritdoc/>
    public override TerraformExpression ToExpression()
    {
        return _expression;
    }
}
