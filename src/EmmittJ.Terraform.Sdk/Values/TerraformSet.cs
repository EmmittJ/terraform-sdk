namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform set argument that can contain multiple unique unordered elements.
/// Terraform sets are unordered collections that do not allow duplicates.
/// </summary>
/// <typeparam name="T">The element type (string, double, bool, TerraformBlock, etc.)</typeparam>
/// <remarks>
/// <para>
/// Note: Uniqueness for literal values is enforced at construction time using <see cref="Enumerable.Distinct{TSource}(IEnumerable{TSource})"/>.
/// For TerraformValue elements containing references or expressions, uniqueness is enforced at resolution time by Terraform.
/// </para>
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/expressions/types#set"/></para>
/// </remarks>
public class TerraformSet<T> : TerraformEnumerable<T>
{
    /// <summary>
    /// Initializes a new empty set for collection initializer syntax.
    /// </summary>
    public TerraformSet()
        : base()
    {
    }

    /// <summary>
    /// Initializes a set from literal values, enforcing uniqueness.
    /// </summary>
    /// <param name="values">The literal values to add (duplicates are removed).</param>
    public TerraformSet(IEnumerable<T> values)
        : base(values?.Distinct())
    {
    }

    /// <summary>
    /// Initializes a set from TerraformValue elements.
    /// Uniqueness is enforced at resolution time by Terraform.
    /// </summary>
    /// <param name="values">The TerraformValue elements to add.</param>
    public TerraformSet(IEnumerable<TerraformValue<T>> values)
        : base(values)
    {
    }

    /// <summary>
    /// Initializes a set from a resolvable expression.
    /// </summary>
    /// <param name="resolvable">The resolvable to wrap.</param>
    private TerraformSet(ITerraformResolvable resolvable)
        : base(resolvable)
    {
    }

    /// <summary>
    /// Resolves this set to syntax nodes.
    /// If elements are TerraformBlocks, returns them directly as multiple nested blocks.
    /// Otherwise wraps elements in a set expression.
    /// </summary>
    /// <param name="context">The resolution context.</param>
    /// <returns>The resolved syntax nodes.</returns>
    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        var formatted = ResolveElementNodes(context).ToList();

        // Check if T is a TerraformBlock type - if so, resolve as multiple nested blocks
        // Otherwise, resolve as a set expression
        if (typeof(TerraformBlock).IsAssignableFrom(typeof(T)))
        {
            foreach (var node in formatted)
            {
                yield return node;
            }
        }
        else
        {
            yield return TerraformExpression.Set(formatted);
        }
    }

    /// <summary>
    /// Implicit conversion from a HashSet.
    /// </summary>
    public static implicit operator TerraformSet<T>(HashSet<T> value)
        => new TerraformSet<T>(value);

    /// <summary>
    /// Implicit conversion from a List (duplicates are removed).
    /// </summary>
    public static implicit operator TerraformSet<T>(List<T> value)
        => new TerraformSet<T>(value);

    /// <summary>
    /// Implicit conversion from an array (duplicates are removed).
    /// </summary>
    public static implicit operator TerraformSet<T>(T[] value)
        => new TerraformSet<T>(value);

    /// <summary>
    /// Implicit conversion from a list of TerraformValue elements.
    /// </summary>
    public static implicit operator TerraformSet<T>(List<TerraformValue<T>> values)
        => new TerraformSet<T>(values);

    /// <summary>
    /// Implicit conversion from TerraformExpression.
    /// </summary>
    public static implicit operator TerraformSet<T>(TerraformExpression expression)
        => new TerraformSet<T>(expression);

    /// <summary>
    /// Creates a lazy TerraformSet that will be resolved at resolution time.
    /// The producer function is called during resolution to generate the final expression.
    /// </summary>
    /// <param name="producer">A function that produces syntax nodes when called with a resolution context.</param>
    /// <returns>A TerraformSet that wraps the lazy producer.</returns>
    public static new TerraformSet<T> Lazy(Func<ITerraformContext, IEnumerable<TerraformSyntaxNode>> producer)
        => new TerraformLazySet<T>(producer);

    /// <summary>
    /// Gets an empty set.
    /// </summary>
    public static TerraformSet<T> Empty => new TerraformSet<T>();

    /// <summary>
    /// Converts this TerraformSet to a lazy TerraformSet of a different type.
    /// This is useful when the underlying value is known to be of a different type
    /// but needs to be treated as such in certain contexts.
    /// </summary>
    /// <typeparam name="TLazy">The target element type.</typeparam>
    /// <returns>A lazy TerraformSet of the target type.</returns>
    public new TerraformSet<TLazy> AsLazy<TLazy>()
        => TerraformSet<TLazy>.Lazy(ResolveNodes);
}

/// <summary>
/// Internal lazy set implementation for deferred resolution.
/// Unlike <see cref="TerraformLazyValue{T}"/>, this type does not preserve identity
/// because lazy sets are created for deferred evaluation, not for wrapping stored values.
/// </summary>
internal sealed class TerraformLazySet<T> : TerraformSet<T>
{
    private readonly Func<ITerraformContext, IEnumerable<TerraformSyntaxNode>> _producer;

    /// <summary>
    /// Creates a lazy set with a custom producer function.
    /// </summary>
    /// <param name="producer">The function that produces syntax nodes during resolution.</param>
    public TerraformLazySet(Func<ITerraformContext, IEnumerable<TerraformSyntaxNode>> producer)
        : base()
    {
        _producer = producer ?? throw new ArgumentNullException(nameof(producer));
    }

    /// <summary>
    /// Resolves this lazy set to syntax nodes.
    /// If lineage is present, resolves to a reference expression.
    /// Otherwise, invokes the producer function.
    /// </summary>
    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        if (Lineage is not null)
        {
            return [Lineage.BuildExpression()];
        }
        return _producer(context);
    }
}
