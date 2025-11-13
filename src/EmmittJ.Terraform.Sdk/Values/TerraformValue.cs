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
///
/// Changed from struct to class to enable inheritance for collection types (TerraformList, TerraformSet, etc.).
/// This matches Pulumi's Input&lt;T&gt; pattern and enables polymorphic behavior.
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
    /// Gets whether this TerraformValue has a value.
    /// </summary>
    public bool HasValue => _resolvable != null;

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
                "This may indicate a bug in the Terraform SDK.");
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
    /// Implicit conversion from literal value - wrap in a resolvable.
    /// Note: For TerraformExpression specifically, this creates a literal value wrapper.
    /// Use the explicit TerraformExpression->TerraformValue conversion below for expression references.
    /// </summary>
    public static implicit operator TerraformValue<T>(T value)
        => new TerraformValue<T>(new TerraformLiteralValue<T>(value));

    /// <summary>
    /// Direct conversion from TerraformExpression (which implements ITerraformResolvable).
    /// This is explicitly for when T != TerraformExpression to avoid ambiguity.
    /// </summary>
    public static implicit operator TerraformValue<T>(TerraformExpression expression)
        => new TerraformValue<T>(expression);
}

/// <summary>
/// Static helper class for creating TerraformValue instances.
/// </summary>
public static class TerraformValue
{
    /// <summary>
    /// Create a TerraformValue from a literal value.
    /// </summary>
    public static TerraformValue<T> FromLiteral<T>(T? value)
        => new TerraformValue<T>(new TerraformLiteralValue<T>(value));

    /// <summary>
    /// Create a TerraformValue from an expression.
    /// </summary>
    public static TerraformValue<T> FromExpression<T>(TerraformExpression expression)
        => new TerraformValue<T>(expression);
}

/// <summary>
/// Represents a lazy Terraform value that will be computed during resolution.
/// Internal implementation detail used by TerraformValue&lt;T&gt;.Lazy() factory method.
/// </summary>
internal class TerraformLazyValue<T> : TerraformValue<T>
{
    private readonly Func<ITerraformContext, IEnumerable<TerraformSyntaxNode>> _producer;

    public TerraformLazyValue(Func<ITerraformContext, IEnumerable<TerraformSyntaxNode>> producer)
        : base()
    {
        _producer = producer ?? throw new ArgumentNullException(nameof(producer));
    }

    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        return _producer(context);
    }
}
