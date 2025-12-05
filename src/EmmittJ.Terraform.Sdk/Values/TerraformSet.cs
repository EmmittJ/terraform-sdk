using System.Collections;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform set argument that can contain multiple unique unordered elements.
/// Terraform sets are unordered collections that do not allow duplicates.
/// Inherits from TerraformValue&lt;IEnumerable&lt;T&gt;&gt; for clean typing.
/// </summary>
/// <typeparam name="T">The element type (string, double, bool, TerraformBlock&lt;T&gt;, etc.)</typeparam>
public class TerraformSet<T> : TerraformValue<IEnumerable<T>>, IEnumerable
{
    // Internal: Store elements as TerraformValue<T> to preserve unknowns
    private readonly List<TerraformValue<T>> _elements;

    // Parameterless constructor for collection initializer syntax
    public TerraformSet()
        : base()
    {
        _elements = new List<TerraformValue<T>>();
    }

    // Constructor for literal values - enforces uniqueness
    public TerraformSet(IEnumerable<T> values)
        : this()
    {
        if (values != null)
        {
            foreach (var value in values.Distinct())
            {
                _elements.Add(value);
            }
        }
    }

    // Constructor for mixed TerraformValue<T> elements
    public TerraformSet(IEnumerable<TerraformValue<T>> values)
        : this()
    {
        if (values != null)
        {
            _elements.AddRange(values); // Uniqueness enforced at resolution
        }
    }

    // Constructor for expressions/references
    private TerraformSet(ITerraformResolvable resolvable)
        : base(resolvable)
    {
        _elements = new List<TerraformValue<T>>();
    }

    /// <summary>
    /// Copy constructor for creating a copy of an existing set.
    /// Used by <see cref="WithLineage"/> to create copies with lineage attached.
    /// </summary>
    /// <param name="other">The set to copy.</param>
    /// <param name="isCopy">Marker to disambiguate from other constructors.</param>
    private TerraformSet(TerraformSet<T> other, bool isCopy)
        : base()
    {
        _ = isCopy; // Marker parameter for disambiguation
        _elements = new List<TerraformValue<T>>(other._elements);
    }

    /// <summary>
    /// Creates a copy of this set with the specified lineage attached.
    /// </summary>
    /// <param name="lineage">The lineage to attach to the copy.</param>
    /// <returns>A new <see cref="TerraformSet{T}"/> with the specified lineage.</returns>
    public override TerraformValue<IEnumerable<T>> WithLineage(TerraformLineage? lineage)
    {
        var copy = new TerraformSet<T>(this, isCopy: true);
        copy.Lineage = lineage;
        return copy;
    }

    /// <summary>
    /// Override resolution to handle nested TerraformValue&lt;T&gt; elements.
    /// If elements are TerraformBlocks, returns them directly as multiple blocks.
    /// Otherwise wraps elements in a set expression.
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
        // Otherwise, resolve as a set expression
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
            yield return TerraformExpression.Set(resolved);
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
    /// When this set has lineage, the returned element will have extended lineage
    /// that includes the index (e.g., "resource.identity_ids[0]").
    /// For value types, returns a COPY with lineage attached.
    /// For blocks, sets lineage directly (blocks resolve their own content, lineage is for references).
    /// </summary>
    /// <remarks>
    /// Note: Sets are unordered in Terraform, so index-based access should be used
    /// carefully. This is primarily useful for accessing elements in generated code
    /// where the order is known at definition time.
    /// </remarks>
    /// <param name="index">The zero-based index of the element to get.</param>
    /// <returns>The element at the specified index with lineage attached.</returns>
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= _elements.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range. Set has {_elements.Count} elements.");
            }

            var element = _elements[index];

            // If the element is a lazy value wrapping an original T, get the original
            T? result = element switch
            {
                TerraformLazyValue<T> { Original: T original } => original,
                T directValue => directValue,
                _ => default
            };

            // If this set has lineage, attach it to the element
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

    // Implicit conversions - enforce uniqueness with Distinct()
    public static implicit operator TerraformSet<T>(HashSet<T> value)
        => new TerraformSet<T>(value);

    public static implicit operator TerraformSet<T>(List<T> value)
        => new TerraformSet<T>(value.Distinct());

    public static implicit operator TerraformSet<T>(T[] value)
        => new TerraformSet<T>(value.Distinct());

    // Accept mixed TerraformValue<T> elements
    public static implicit operator TerraformSet<T>(List<TerraformValue<T>> values)
        => new TerraformSet<T>(values);

    // Implicit conversion from TerraformExpression
    public static implicit operator TerraformSet<T>(TerraformExpression expression)
        => new TerraformSet<T>(expression);

    /// <summary>
    /// Creates a lazy TerraformSet that will be resolved at resolution time.
    /// The producer function is called during resolution to generate the final expression.
    /// </summary>
    /// <param name="producer">A function that produces a TerraformExpression when called with a resolution context.</param>
    /// <returns>A TerraformSet that wraps the lazy producer.</returns>
    public static new TerraformSet<T> Lazy(Func<ITerraformContext, IEnumerable<TerraformSyntaxNode>> producer)
        => new TerraformLazySet<T>(producer);

    // IEnumerable for collection initializer syntax (non-functional)
    IEnumerator IEnumerable.GetEnumerator()
        => throw new NotSupportedException(
            "TerraformSet cannot be enumerated synchronously. " +
            "Values are resolved during Terraform synthesis.");

    // Static empty set
    public static TerraformSet<T> Empty
        => new TerraformSet<T>();

    /// <summary>
    /// Converts this TerraformSet to a lazy TerraformSet of a different type.
    /// This is useful when the underlying value is known to be of a different type
    /// but needs to be treated as such in certain contexts (e.g., casting from string to a more specific type).
    /// /// </summary>
    public new TerraformSet<TLazy> AsLazy<TLazy>()
        => TerraformSet<TLazy>.Lazy(ResolveNodes);
}

/// <summary>
/// Internal lazy set implementation for deferred resolution.
/// </summary>
internal sealed class TerraformLazySet<T> : TerraformSet<T>
{
    private readonly Func<ITerraformContext, IEnumerable<TerraformSyntaxNode>> _producer;

    public TerraformLazySet(Func<ITerraformContext, IEnumerable<TerraformSyntaxNode>> producer)
        : base()
    {
        _producer = producer ?? throw new ArgumentNullException(nameof(producer));
    }

    /// <summary>
    /// Copy constructor for creating a copy with lineage.
    /// </summary>
    /// <param name="other">The set to copy.</param>
    /// <param name="isCopy">Marker to disambiguate from other constructors.</param>
    private TerraformLazySet(TerraformLazySet<T> other, bool isCopy)
        : base()
    {
        _ = isCopy; // Marker parameter for disambiguation
        _producer = other._producer;
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
    /// Creates a copy of this lazy set with the specified lineage attached.
    /// </summary>
    public override TerraformValue<IEnumerable<T>> WithLineage(TerraformLineage? lineage)
    {
        var copy = new TerraformLazySet<T>(this, isCopy: true);
        copy.Lineage = lineage;
        return copy;
    }
}
