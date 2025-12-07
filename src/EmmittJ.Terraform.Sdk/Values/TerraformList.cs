namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform list argument that can contain multiple ordered elements.
/// Terraform lists are ordered collections that allow duplicates.
/// </summary>
/// <typeparam name="T">The element type (string, double, bool, TerraformBlock, etc.)</typeparam>
/// <remarks>
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/expressions/types#list"/></para>
/// </remarks>
public class TerraformList<T> : TerraformEnumerable<T>
{
    /// <summary>
    /// Initializes a new empty list for collection initializer syntax.
    /// </summary>
    public TerraformList()
        : base()
    {
    }

    /// <summary>
    /// Initializes a list from literal values.
    /// </summary>
    /// <param name="values">The literal values to add.</param>
    public TerraformList(IEnumerable<T> values)
        : base(values)
    {
    }

    /// <summary>
    /// Initializes a list from TerraformValue elements (for unknowns/references).
    /// </summary>
    /// <param name="values">The TerraformValue elements to add.</param>
    public TerraformList(IEnumerable<TerraformValue<T>> values)
        : base(values)
    {
    }

    /// <summary>
    /// Initializes a list from a resolvable expression.
    /// </summary>
    /// <param name="resolvable">The resolvable to wrap.</param>
    private TerraformList(ITerraformResolvable resolvable)
        : base(resolvable)
    {
    }

    /// <summary>
    /// Resolves this list to syntax nodes.
    /// If elements are TerraformBlocks, returns them directly as multiple nested blocks.
    /// Otherwise wraps elements in a list expression.
    /// </summary>
    /// <param name="context">The resolution context.</param>
    /// <returns>The resolved syntax nodes.</returns>
    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        var formatted = ResolveElementNodes(context).ToList();

        // Check if T is a TerraformBlock type - if so, resolve as multiple nested blocks
        // Otherwise, resolve as a list expression
        if (typeof(TerraformBlock).IsAssignableFrom(typeof(T)))
        {
            foreach (var node in formatted)
            {
                yield return node;
            }
        }
        else
        {
            yield return TerraformExpression.List(formatted);
        }
    }

    /// <summary>
    /// Implicit conversion from a .NET List.
    /// </summary>
    public static implicit operator TerraformList<T>(List<T> value)
        => new TerraformList<T>(value);

    /// <summary>
    /// Implicit conversion from an array.
    /// </summary>
    public static implicit operator TerraformList<T>(T[] value)
        => new TerraformList<T>(value);

    /// <summary>
    /// Implicit conversion from a list of TerraformValue elements (for unknowns/references).
    /// </summary>
    public static implicit operator TerraformList<T>(List<TerraformValue<T>> values)
        => new TerraformList<T>(values);

    /// <summary>
    /// Implicit conversion from TerraformExpression.
    /// </summary>
    public static implicit operator TerraformList<T>(TerraformExpression expression)
        => new TerraformList<T>(expression);

    /// <summary>
    /// Creates a lazy TerraformList that will be resolved at resolution time.
    /// The producer function is called during resolution to generate the final expression.
    /// </summary>
    /// <param name="producer">A function that produces syntax nodes when called with a resolution context.</param>
    /// <returns>A TerraformList that wraps the lazy producer.</returns>
    public static new TerraformList<T> Lazy(Func<ITerraformContext, IEnumerable<TerraformSyntaxNode>> producer)
        => new TerraformLazyList<T>(producer);

    /// <summary>
    /// Gets an empty list.
    /// </summary>
    public static TerraformList<T> Empty => new TerraformList<T>();

    /// <summary>
    /// Converts this TerraformList to a lazy TerraformList of a different type.
    /// This is useful when the underlying value is known to be of a different type
    /// but needs to be treated as such in certain contexts.
    /// </summary>
    /// <typeparam name="TLazy">The target element type.</typeparam>
    /// <returns>A lazy TerraformList of the target type.</returns>
    public new TerraformList<TLazy> AsLazy<TLazy>()
        => TerraformList<TLazy>.Lazy(ResolveNodes);
}

/// <summary>
/// Internal lazy list implementation for deferred resolution.
/// Unlike <see cref="TerraformLazyValue{T}"/>, this type does not preserve identity
/// because lazy lists are created for deferred evaluation, not for wrapping stored values.
/// </summary>
internal sealed class TerraformLazyList<T> : TerraformList<T>
{
    private readonly Func<ITerraformContext, IEnumerable<TerraformSyntaxNode>> _producer;

    /// <summary>
    /// Creates a lazy list with a custom producer function.
    /// </summary>
    /// <param name="producer">The function that produces syntax nodes during resolution.</param>
    public TerraformLazyList(Func<ITerraformContext, IEnumerable<TerraformSyntaxNode>> producer)
        : base()
    {
        _producer = producer ?? throw new ArgumentNullException(nameof(producer));
    }

    /// <summary>
    /// Resolves this lazy list to syntax nodes.
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
