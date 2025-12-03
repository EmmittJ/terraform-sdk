namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform value that can be a literal or a resolvable token.
/// This is the primary type used for all Terraform resource properties.
///
/// The generic T provides compile-time type safety for what type of value
/// this represents in Terraform (string, double, bool, etc.), but all values
/// ultimately resolve to TerraformExpression for HCL serialization.
///
/// Think of it as: TerraformValue&lt;string&gt; means "a value that represents
/// a string in Terraform", not "a value that IS a string at runtime".
/// </summary>
/// <typeparam name="T">The .NET type this value represents (string, double, bool, etc.) - used for compile-time safety</typeparam>
public class TerraformValue<T> : ITerraformValue
{
    protected readonly ITerraformResolvable? _resolvable;

    /// <summary>
    /// Gets the underlying resolvable for internal use by the SDK.
    /// </summary>
    internal ITerraformResolvable? Resolvable => _resolvable;

    protected TerraformValue()
    {
        _resolvable = null;
    }

    internal TerraformValue(ITerraformResolvable resolvable)
    {
        _resolvable = resolvable ?? throw new ArgumentNullException(nameof(resolvable));
    }

    /// <summary>
    /// Resolve this value to syntax nodes.
    /// Values typically resolve to a single expression node.
    /// </summary>
    /// <param name="context">The resolution context.</param>
    /// <returns>The resolved syntax nodes.</returns>
    public virtual IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        if (_resolvable == null)
        {
            throw new InvalidOperationException(
                $"Cannot resolve {GetType().Name} - no resolvable value was provided. " +
                $"This typically occurs when a TerraformValue is created using the protected parameterless constructor " +
                $"without initializing the underlying resolvable. " +
                $"Ensure values are created using implicit conversions or factory methods.");
        }
        return _resolvable.ResolveNodes(context);
    }

    /// <summary>
    /// Creates a lazy TerraformValue that will be resolved at resolution time.
    /// The producer function is called during resolution to generate the final expression.
    /// </summary>
    /// <param name="producer">A function that produces a TerraformExpression when called with a resolution context.</param>
    /// <returns>A TerraformValue that wraps the lazy producer.</returns>
    public static TerraformValue<T> Lazy(Func<ITerraformContext, IEnumerable<TerraformSyntaxNode>> producer)
        => new TerraformLazyValue<T>(producer);

    /// <summary>
    /// Creates a lazy TerraformValue that wraps an ITerraformResolvable, preserving its identity.
    /// Used when storing values that implement ITerraformHasParent (like TerraformList, TerraformBlock)
    /// so that GetArgument can retrieve the original object with parent tracking intact.
    /// </summary>
    /// <param name="original">The original resolvable object whose identity should be preserved.</param>
    /// <returns>A TerraformValue that wraps the original and preserves identity.</returns>
    public static TerraformValue<T> Lazy(ITerraformResolvable original)
        => new TerraformLazyValue<T>(original);

    /// <summary>
    /// Implicit conversion for primitive values only. This validates at compile/assignment time
    /// that only supported Terraform primitive types are used as literals.
    /// For complex types, use TerraformExpression.Map(), TerraformExpression.List(), or other expression builders.
    /// </summary>
    public static implicit operator TerraformValue<T>(T value)
        => ConvertFrom(value);

    /// <summary>
    /// Creates a TerraformValue from a primitive literal value.
    /// </summary>
    public static TerraformValue<T> ConvertFrom(object? value)
    {
        // Allow null
        if (value is null)
        {
            return TerraformValue<T>.Lazy(TerraformExpression.Literal(value));
        }

        // If already the exact target type, return as-is to preserve identity
        // This allows GetArgument<TerraformList<T>> to return the original list
        if (value is TerraformValue<T> exactMatch)
        {
            return exactMatch;
        }

        // Allow other ITerraformResolvable types - wrap in lazy to resolve later
        if (value is ITerraformResolvable resolvable)
        {
            return TerraformValue<T>.Lazy(resolvable);
        }

        return TerraformValue<T>.Lazy(TerraformExpression.Literal(value));
    }

    /// <summary>
    /// Direct conversion from TerraformExpression (which implements ITerraformResolvable).
    /// </summary>
    public static implicit operator TerraformValue<T>(TerraformExpression expression)
        => ConvertFrom(expression);

    /// <summary>
    /// Creates a TerraformValue from a TerraformExpression.
    /// </summary>
    public static TerraformValue<T> ConvertFrom(TerraformExpression expression)
        => new TerraformValue<T>(expression);

    /// <summary>
    /// Converts this TerraformValue to a lazy TerraformValue of a different type.
    /// This is useful when the underlying value is known to be of a different type
    /// but needs to be treated as such in certain contexts (e.g., casting from string to a more specific type).
    /// /// </summary>
    public TerraformValue<TLazy> AsLazy<TLazy>()
        => TerraformValue<TLazy>.Lazy(this);
}

/// <summary>
/// Represents a lazy Terraform value that will be computed during resolution.
/// Internal implementation detail used by TerraformValue&lt;T&gt;.Lazy() factory method.
/// Optionally preserves the identity of the original object for GetArgument retrieval.
/// </summary>
internal class TerraformLazyValue<T> : TerraformValue<T>
{
    public ITerraformResolvable? Original { get; private set; } = null;
    private readonly Func<ITerraformContext, IEnumerable<TerraformSyntaxNode>> _producer;

    /// <summary>
    /// Creates a lazy value with a custom producer function (no identity preservation).
    /// </summary>
    public TerraformLazyValue(Func<ITerraformContext, IEnumerable<TerraformSyntaxNode>> producer) : base()
    {
        _producer = producer ?? throw new ArgumentNullException(nameof(producer));
    }

    /// <summary>
    /// Creates a lazy value that wraps an ITerraformResolvable, preserving its identity.
    /// Resolution delegates to the original object's ResolveNodes method.
    /// </summary>
    public TerraformLazyValue(ITerraformResolvable original) : this(original.ResolveNodes)
    {
        Original = original ?? throw new ArgumentNullException(nameof(original));
    }

    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        return _producer(context);
    }
}
