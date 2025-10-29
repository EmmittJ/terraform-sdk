namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Container for property values in Terraform constructs.
/// Similar to BicepValue&lt;T&gt; in Azure.Provisioning.
/// Supports four states: Unset, Literal, Expression, and Reference.
/// </summary>
public class TerraformValue<T> : ITerraformValue
{
    private TerraformValueKind _kind = TerraformValueKind.Unset;
    private T? _literalValue;
    private TerraformExpression? _expression;
    private TerraformReference? _reference;

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
    /// Creates a value from a reference.
    /// </summary>
    public TerraformValue(TerraformReference reference)
    {
        _kind = TerraformValueKind.Reference;
        _reference = reference ?? throw new ArgumentNullException(nameof(reference));
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
        _reference = null;
    }

    /// <inheritdoc/>
    public TerraformExpression Compile()
    {
        return _kind switch
        {
            TerraformValueKind.Unset => throw new InvalidOperationException("Cannot compile an unset value"),
            TerraformValueKind.Literal => TerraformExpression.Literal(_literalValue),
            TerraformValueKind.Expression when _expression is not null => _expression,
            TerraformValueKind.Expression => throw new InvalidOperationException("Expression value is null"),
            TerraformValueKind.Reference when _reference is not null => _reference.ToExpression(),
            TerraformValueKind.Reference => throw new InvalidOperationException("Reference value is null"),
            _ => throw new InvalidOperationException($"Unknown value kind: {_kind}")
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
