namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Container for property values in Terraform constructs.
/// Similar to BicepValue&lt;T&gt; in Azure.Provisioning.
/// Supports four states: Unset, Literal, Expression, and Reference.
/// Implements ITerraformResolvable for two-pass resolution.
/// </summary>
public class TerraformValue<T> : ITerraformValue, ITerraformResolvable<TerraformExpression>
{
    private TerraformValueKind _kind = TerraformValueKind.Unset;
    private T? _literalValue;
    private TerraformExpression? _expression;

    /// <inheritdoc/>
    public TerraformValueKind Kind => _kind;

    /// <inheritdoc/>
    public bool IsEmpty => _kind == TerraformValueKind.Unset;

    /// <summary>
    /// Gets the literal value if Kind is Literal.
    /// </summary>
    public T? LiteralValue => _kind == TerraformValueKind.Literal ? _literalValue : default;

    /// <summary>
    /// Creates an unset value.
    /// </summary>
    public TerraformValue()
    {
        _kind = TerraformValueKind.Unset;
    }

    /// <summary>
    /// Creates a value from a literal.
    /// </summary>
    public TerraformValue(T value)
    {
        _kind = TerraformValueKind.Literal;
        _literalValue = value;
    }

    /// <summary>
    /// Creates a value from an expression.
    /// </summary>
    public TerraformValue(TerraformExpression expression)
    {
        _kind = TerraformValueKind.Expression;
        _expression = expression ?? throw new ArgumentNullException(nameof(expression));
    }

    /// <summary>
    /// Creates a value from a reference (TerraformReference is a TerraformExpression).
    /// </summary>
    public TerraformValue(TerraformReference reference)
        : this((TerraformExpression)reference)
    {
    }

    /// <summary>
    /// Creates a computed value (for outputs that are determined by Terraform).
    /// </summary>
    public static TerraformValue<T> Computed()
    {
        // Computed values are unset - they'll be filled in by Terraform
        return new TerraformValue<T>();
    }

    /// <summary>
    /// Clears the value back to unset.
    /// </summary>
    public void Clear()
    {
        _kind = TerraformValueKind.Unset;
        _literalValue = default;
        _expression = null;
    }

    /// <summary>
    /// Preparation phase - prepare nested expressions and track dependencies.
    /// </summary>
    public void Prepare(ITerraformContext context)
    {
        if (_kind == TerraformValueKind.Expression && _expression is ITerraformResolvable<string> resolvable)
        {
            resolvable.Prepare(context);
        }
    }

    /// <summary>
    /// Resolution phase - resolve to a TerraformExpression.
    /// </summary>
    public TerraformExpression Resolve(ITerraformContext? context = null)
    {
        context ??= TerraformContext.Temporary();

        return _kind switch
        {
            TerraformValueKind.Unset => throw new TerraformConfigurationException(
                $"Cannot resolve an unset {typeof(T).Name} value. " +
                "Set the property before calling ToHcl()."),
            TerraformValueKind.Literal => TerraformExpression.Literal(_literalValue),
            TerraformValueKind.Expression => _expression ?? throw new TerraformConfigurationException(
                $"Expression is null for {typeof(T).Name} value."),
            _ => throw new TerraformConfigurationException(
                $"Unknown value kind: {_kind} for {typeof(T).Name} value.")
        };
    }

    // Implicit conversions for ergonomic API
    public static implicit operator TerraformValue<T>(T value)
        => new(value);

    public static implicit operator TerraformValue<T>(TerraformExpression expression)
        => new(expression);

    public static implicit operator TerraformValue<T>(TerraformReference reference)
        => new(reference);
}
