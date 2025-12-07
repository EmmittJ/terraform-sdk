using System.Collections;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Abstract base class for Terraform enumerable collections (lists and sets).
/// Provides shared infrastructure for ordered (list) and unordered (set) collections
/// including element storage, Add methods, indexer access, and lazy evaluation.
/// </summary>
/// <typeparam name="T">The element type (string, double, bool, TerraformBlock, etc.)</typeparam>
/// <remarks>
/// <para>
/// This base class consolidates common functionality between <see cref="TerraformList{T}"/>
/// and <see cref="TerraformSet{T}"/>, reducing code duplication while allowing each
/// derived class to implement its specific resolution behavior.
/// </para>
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/expressions/types#collection-types"/></para>
/// </remarks>
public abstract class TerraformEnumerable<T> : TerraformValue<IEnumerable<T>>, IEnumerable
{
    /// <summary>
    /// Internal storage for elements as TerraformValue&lt;T&gt; to preserve unknowns and references.
    /// </summary>
    protected readonly List<TerraformValue<T>> _elements;

    /// <summary>
    /// Initializes a new empty enumerable for collection initializer syntax.
    /// </summary>
    protected TerraformEnumerable()
        : base()
    {
        _elements = new List<TerraformValue<T>>();
    }

    /// <summary>
    /// Initializes an enumerable from literal values.
    /// </summary>
    /// <param name="values">The literal values to add.</param>
    protected TerraformEnumerable(IEnumerable<T>? values)
        : this()
    {
        if (values is not null)
        {
            foreach (var value in values)
            {
                _elements.Add(value);
            }
        }
    }

    /// <summary>
    /// Initializes an enumerable from TerraformValue elements.
    /// </summary>
    /// <param name="values">The TerraformValue elements to add.</param>
    protected TerraformEnumerable(IEnumerable<TerraformValue<T>>? values)
        : this()
    {
        if (values is not null)
        {
            _elements.AddRange(values);
        }
    }

    /// <summary>
    /// Initializes an enumerable from a resolvable expression.
    /// </summary>
    /// <param name="resolvable">The resolvable to wrap.</param>
    protected TerraformEnumerable(ITerraformResolvable resolvable)
        : base(resolvable)
    {
        _elements = new List<TerraformValue<T>>();
    }

    /// <summary>
    /// Gets the number of elements in this collection.
    /// </summary>
    public int Count => _elements.Count;

    /// <summary>
    /// Sets the lineage on this enumerable and returns it.
    /// Unlike primitive values, enumerables are mutable so we set lineage in place.
    /// </summary>
    /// <param name="lineage">The lineage to attach.</param>
    /// <returns>This enumerable with the lineage set.</returns>
    public override TerraformValue<IEnumerable<T>> WithLineage(TerraformLineage? lineage)
    {
        Lineage = lineage;
        return this;
    }

    /// <summary>
    /// Gets the element at the specified index with lineage attached.
    /// When this enumerable has lineage, the returned element will have extended lineage
    /// that includes the index (e.g., "resource.ingress[0]").
    /// For value types, returns a COPY with lineage attached.
    /// For blocks, sets lineage directly (blocks resolve their own content, lineage is for references).
    /// </summary>
    /// <param name="index">The zero-based index of the element to get.</param>
    /// <returns>The element at the specified index with lineage attached.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when index is out of range.</exception>
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= _elements.Count)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(index),
                    $"Index {index} is out of range. Collection has {_elements.Count} elements.");
            }

            var element = _elements[index];

            // If the element is a lazy value wrapping an original T, get the original
            T? result = element switch
            {
                TerraformLazyValue<T> { Original: T original } => original,
                T directValue => directValue,
                _ => default
            };

            // If this enumerable has lineage, attach it to the element
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

    /// <summary>
    /// Adds a literal value to the collection.
    /// </summary>
    /// <param name="value">The value to add.</param>
    public void Add(T value)
    {
        _elements.Add(value);
    }

    /// <summary>
    /// Adds a TerraformValue to the collection.
    /// </summary>
    /// <param name="value">The TerraformValue to add.</param>
    public void Add(TerraformValue<T> value)
    {
        _elements.Add(value);
    }

    /// <summary>
    /// Resolves elements to syntax nodes and applies formatting.
    /// Derived classes use this to get the resolved element nodes.
    /// </summary>
    /// <param name="context">The resolution context.</param>
    /// <returns>The resolved and formatted element nodes.</returns>
    protected IEnumerable<TerraformSyntaxNode> ResolveElementNodes(ITerraformContext context)
    {
        var resolved = new List<TerraformSyntaxNode>();
        foreach (var element in _elements)
        {
            var nodes = element.ResolveNodes(context);
            resolved.AddRange(nodes);
        }
        return context.Formatter.Format(resolved);
    }

    /// <summary>
    /// Returns an enumerator that throws - TerraformEnumerable cannot be enumerated synchronously.
    /// Values are resolved during Terraform synthesis.
    /// </summary>
    /// <exception cref="NotSupportedException">Always thrown.</exception>
    IEnumerator IEnumerable.GetEnumerator()
        => throw new NotSupportedException(
            $"{GetType().Name} cannot be enumerated synchronously. " +
            "Values are resolved during Terraform synthesis.");
}
