using System.Collections;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform list attribute that can contain multiple ordered elements.
/// Terraform lists are ordered collections that allow duplicates.
/// Inherits from TerraformValue&lt;IEnumerable&lt;T&gt;&gt; for clean typing.
/// </summary>
/// <typeparam name="T">The element type (string, double, bool, TerraformBlock&lt;T&gt;, etc.)</typeparam>
public sealed class TerraformList<T> : TerraformValue<IEnumerable<T>>, IEnumerable
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
    public override TerraformExpression Resolve(ITerraformResolveContext context)
    {
        // Resolve each element individually
        var resolvedElements = _elements
            .Select(e => e.Resolve(context))
            .ToList();
        return TerraformExpression.List((IEnumerable<TerraformExpression>)resolvedElements);
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

    // Implicit conversion from TerraformReference (for referencing other lists)
    public static implicit operator TerraformList<T>(TerraformReference reference)
        => new TerraformList<T>(reference);

    // IEnumerable for collection initializer syntax (non-functional)
    IEnumerator IEnumerable.GetEnumerator()
        => throw new NotSupportedException(
            "TerraformList cannot be enumerated synchronously. " +
            "Values are resolved during Terraform synthesis.");

    // Static empty list
    public static TerraformList<T> Empty
        => new TerraformList<T>();
}
