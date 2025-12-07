using System.Collections;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform list argument that can contain multiple ordered elements.
/// Terraform lists are ordered collections that allow duplicates.
/// Inherits from TerraformValue&lt;IEnumerable&lt;T&gt;&gt; for clean typing.
/// </summary>
/// <typeparam name="T">The element type (string, double, bool, TerraformBlock&lt;T&gt;, etc.)</typeparam>
public class TerraformList<T> : TerraformValue<IEnumerable<T>>, IEnumerable
{
    // Internal: Store elements as TerraformValue<T> to preserve unknowns (Pulumi pattern)
    private readonly List<TerraformValue<T>> _elements;

    // Parameterless constructor for collection initializer syntax
    public TerraformList()
        : base()
    {
        _elements = new List<TerraformValue<T>>();
    }

    // Constructor for literal values
    public TerraformList(IEnumerable<T> values)
        : this()
    {
        if (values != null)
        {
            foreach (var value in values)
            {
                _elements.Add(value);
            }
        }
    }

    // Constructor for mixed TerraformValue<T> elements (unknowns)
    public TerraformList(IEnumerable<TerraformValue<T>> values)
        : this()
    {
        if (values != null)
        {
            _elements.AddRange(values);
        }
    }

    // Constructor for expressions/references
    private TerraformList(ITerraformResolvable resolvable)
        : base(resolvable)
    {
        _elements = new List<TerraformValue<T>>();
    }

    /// <summary>
    /// Sets the lineage on this list and returns it.
    /// Unlike primitive values, lists are mutable so we set lineage in place.
    /// </summary>
    /// <param name="lineage">The lineage to attach.</param>
    /// <returns>This list with the lineage set.</returns>
    public override TerraformValue<IEnumerable<T>> WithLineage(TerraformLineage? lineage)
    {
        Lineage = lineage;
        return this;
    }

    /// <summary>
    /// Override resolution to handle nested elements.
    /// If elements are TerraformBlocks, returns them directly as multiple blocks.
    /// Otherwise wraps elements in a list expression.
    /// </summary>
    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        var resolved = new List<TerraformSyntaxNode>();
        foreach (var element in _elements)
        {
            var nodes = element.ResolveNodes(context);
            resolved.AddRange(nodes);
        }
        var formatted = context.Formatter.Format(resolved);

        // Check if T is a TerraformBlock type - if so, resolve as multiple nested blocks
        // Otherwise, resolve as a list expression
        var elementType = typeof(T);
        if (typeof(TerraformBlock).IsAssignableFrom(elementType))
        {
            foreach (var node in formatted)
            {
                yield return node;
            }
        }
        else
        {
            yield return TerraformExpression.List(resolved);
        }
    }

    // Add method for collection initializer syntax
    public void Add(T value)
    {
        _elements.Add(value);
    }

    // Add method for adding TerraformValue<T> directly
    public void Add(TerraformValue<T> value)
    {
        _elements.Add(value);
    }

    /// <summary>
    /// Gets the element at the specified index with lineage attached.
    /// When this list has lineage, the returned element will have extended lineage
    /// that includes the index (e.g., "resource.ingress[0]").
    /// For value types, returns a COPY with lineage attached.
    /// For blocks, sets lineage directly (blocks resolve their own content, lineage is for references).
    /// </summary>
    /// <param name="index">The zero-based index of the element to get.</param>
    /// <returns>The element at the specified index with lineage attached.</returns>
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= _elements.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range. List has {_elements.Count} elements.");
            }

            var element = _elements[index];

            // If the element is a lazy value wrapping an original T, get the original
            T? result = element switch
            {
                TerraformLazyValue<T> { Original: T original } => original,
                T directValue => directValue,
                _ => default
            };

            // If this list has lineage, attach it to the element
            if (Lineage is not null && result is ITerraformValue terraformValue)
            {
                var lineageForIndex = Lineage.WithIndex(index);

                // For blocks, set lineage directly (blocks resolve their own content, lineage is for reference building)
                // For other values, return a COPY with lineage to preserve original for source rendering
                if (result is TerraformBlock block)
                {
                    block.Lineage = lineageForIndex;
                    return result;
                }

                return (T)terraformValue.WithLineage(lineageForIndex);
            }

            return result ?? throw new InvalidOperationException(
                $"Cannot retrieve element at index {index}. The element was not stored as type {typeof(T).Name}.");
        }
    }

    // Implicit conversions from .NET collections
    public static implicit operator TerraformList<T>(List<T> value)
        => new TerraformList<T>(value);

    public static implicit operator TerraformList<T>(T[] value)
        => new TerraformList<T>(value);

    // Accept mixed TerraformValue<T> elements (for unknowns/references)
    public static implicit operator TerraformList<T>(List<TerraformValue<T>> values)
        => new TerraformList<T>(values);

    // Implicit conversion from TerraformExpression
    public static implicit operator TerraformList<T>(TerraformExpression expression)
        => new TerraformList<T>(expression);

    /// <summary>
    /// Creates a lazy TerraformList that will be resolved at resolution time.
    /// The producer function is called during resolution to generate the final expression.
    /// </summary>
    /// <param name="producer">A function that produces a TerraformExpression when called with a resolution context.</param>
    /// <returns>A TerraformList that wraps the lazy producer.</returns>
    public static new TerraformList<T> Lazy(Func<ITerraformContext, IEnumerable<TerraformSyntaxNode>> producer)
        => new TerraformLazyList<T>(producer);

    // IEnumerable for collection initializer syntax (non-functional)
    IEnumerator IEnumerable.GetEnumerator()
        => throw new NotSupportedException(
            "TerraformList cannot be enumerated synchronously. " +
            "Values are resolved during Terraform synthesis.");

    // Static empty list
    public static TerraformList<T> Empty
        => new TerraformList<T>();

    /// <summary>
    /// Converts this TerraformList to a lazy TerraformList of a different type.
    /// This is useful when the underlying value is known to be of a different type
    /// but needs to be treated as such in certain contexts (e.g., casting from string to a more specific type).
    /// /// </summary>
    public new TerraformList<TLazy> AsLazy<TLazy>()
        => TerraformList<TLazy>.Lazy(ResolveNodes);
}

/// <summary>
/// Internal lazy list implementation for deferred resolution.
/// </summary>
internal sealed class TerraformLazyList<T> : TerraformList<T>
{
    private readonly Func<ITerraformContext, IEnumerable<TerraformSyntaxNode>> _producer;

    public TerraformLazyList(Func<ITerraformContext, IEnumerable<TerraformSyntaxNode>> producer)
        : base()
    {
        _producer = producer ?? throw new ArgumentNullException(nameof(producer));
    }

    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        // Check lineage first - if present, resolve to reference
        if (Lineage is not null)
        {
            return [Lineage.BuildExpression()];
        }

        return _producer(context);
    }

    /// <summary>
    /// Sets the lineage on this lazy list and returns it.
    /// </summary>
    public override TerraformValue<IEnumerable<T>> WithLineage(TerraformLineage? lineage)
    {
        Lineage = lineage;
        return this;
    }
}
