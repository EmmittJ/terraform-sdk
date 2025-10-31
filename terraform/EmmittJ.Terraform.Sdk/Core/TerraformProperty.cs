using System.Collections.Generic;
using System.Linq;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Base class for property values in Terraform constructs.
/// Participates in two-phase resolution (Prepare and Resolve).
/// Replaces TerraformValue&lt;T&gt; with a polymorphic design.
/// </summary>
public abstract class TerraformProperty : ITerraformResolvable<TerraformExpression>
{
    /// <summary>
    /// Gets or sets the priority for property ordering in HCL output.
    /// Lower numbers render first. Null (default) means alphabetical ordering at the end.
    /// </summary>
    public int? Priority { get; set; }

    /// <summary>
    /// Preparation phase - prepare nested expressions and track dependencies.
    /// </summary>
    public abstract void Prepare(ITerraformContext context);

    /// <summary>
    /// Resolution phase - resolve to HCL string.
    /// </summary>
    public abstract TerraformExpression Resolve(ITerraformContext? context = null);

    /// <summary>
    /// Implicit conversion from literal values to LiteralProperty.
    /// </summary>
    public static implicit operator TerraformProperty(string value)
        => new TerraformLiteralProperty<string>(value);

    /// <summary>
    /// Implicit conversion from literal values to LiteralProperty.
    /// </summary>
    public static implicit operator TerraformProperty(int value)
        => new TerraformLiteralProperty<int>(value);

    /// <summary>
    /// Implicit conversion from literal values to LiteralProperty.
    /// </summary>
    public static implicit operator TerraformProperty(bool value)
        => new TerraformLiteralProperty<bool>(value);

    /// <summary>
    /// Implicit conversion from literal values to LiteralProperty.
    /// </summary>
    public static implicit operator TerraformProperty(double value)
        => new TerraformLiteralProperty<double>(value);

    /// <summary>
    /// Implicit conversion from expressions to ExpressionProperty.
    /// </summary>
    public static implicit operator TerraformProperty(TerraformExpression expression)
        => new TerraformExpressionProperty(expression);

    /// <summary>
    /// Implicit conversion from string array to ExpressionProperty (list).
    /// </summary>
    public static implicit operator TerraformProperty(string[] values)
        => new TerraformExpressionProperty(values);

    /// <summary>
    /// Implicit conversion from int array to ExpressionProperty (list).
    /// </summary>
    public static implicit operator TerraformProperty(int[] values)
        => new TerraformExpressionProperty(values);

    /// <summary>
    /// Implicit conversion from List<string> to ExpressionProperty (list).
    /// </summary>
    public static implicit operator TerraformProperty(List<string> values)
        => new TerraformExpressionProperty(TerraformExpression.List(values.Select(TerraformExpression.Literal).ToArray()));
}

/// <summary>
/// Literal property value - wraps a .NET value.
/// No preparation needed since there are no dependencies.
/// </summary>
public sealed class TerraformLiteralProperty<T> : TerraformProperty
{
    private readonly T _value;

    /// <summary>
    /// Gets the literal value.
    /// </summary>
    public T Value => _value;

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformLiteralProperty{T}"/> class.
    /// </summary>
    public TerraformLiteralProperty(T value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    /// <inheritdoc/>
    public override void Prepare(ITerraformContext context)
    {
        // Literals don't need preparation - no dependencies
    }

    /// <inheritdoc/>
    public override TerraformExpression Resolve(ITerraformContext? context = null)
    {
        return TerraformExpression.Literal(_value);
    }

    /// <summary>
    /// Implicit conversion from T to TerraformLiteralProperty<T>.
    /// </summary>
    public static implicit operator TerraformLiteralProperty<T>(T value)
        => new TerraformLiteralProperty<T>(value);
}

/// <summary>
/// Expression property value - wraps a TerraformExpression.
/// Delegates preparation to the wrapped expression.
/// </summary>
public sealed class TerraformExpressionProperty : TerraformProperty
{
    private readonly TerraformExpression _expression;

    /// <summary>
    /// Gets the expression.
    /// </summary>
    public TerraformExpression Expression => _expression;

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformExpressionProperty"/> class.
    /// </summary>
    public TerraformExpressionProperty(TerraformExpression expression)
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
    public override TerraformExpression Resolve(ITerraformContext? context = null)
    {
        return _expression;
    }
}

/// <summary>
/// Type property value - wraps a Terraform type constraint.
/// Types are rendered without quotes (e.g., string, list(string), map(number)).
/// See: https://developer.hashicorp.com/terraform/language/expressions/types
/// </summary>
public sealed class TerraformTypeProperty : TerraformProperty
{
    private readonly string _typeConstraint;

    /// <summary>
    /// Gets the type constraint string.
    /// </summary>
    public string TypeConstraint => _typeConstraint;

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformTypeProperty"/> class.
    /// </summary>
    /// <param name="typeConstraint">The type constraint (e.g., "string", "list(string)", "map(number)").</param>
    public TerraformTypeProperty(string typeConstraint)
    {
        _typeConstraint = typeConstraint ?? throw new ArgumentNullException(nameof(typeConstraint));
    }

    /// <inheritdoc/>
    public override void Prepare(ITerraformContext context)
    {
        // Type constraints don't need preparation - no dependencies
    }

    /// <inheritdoc/>
    public override TerraformExpression Resolve(ITerraformContext? context = null)
    {
        // Return a type identifier expression (renders without quotes)
        return TerraformExpression.Identifier(_typeConstraint);
    }

    /// <summary>
    /// Implicit conversion from string to TerraformTypeProperty.
    /// </summary>
    public static implicit operator TerraformTypeProperty?(string? typeConstraint)
        => typeConstraint != null ? new TerraformTypeProperty(typeConstraint) : null;
}
