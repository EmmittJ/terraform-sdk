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
    /// Override resolution to handle nested TerraformValue&lt;T&gt; elements.
    /// This preserves unknowns during serialization.
    /// </summary>
    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        // Resolve each element individually - take first node as expression
        var resolvedElements = new List<TerraformSyntaxNode>();
        foreach (var e in _elements)
        {
            var nodes = e.ResolveNodes(context);
            resolvedElements.AddRange(nodes);
        }
        yield return TerraformExpression.List(resolvedElements);
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
        return _producer(context);
    }
}
