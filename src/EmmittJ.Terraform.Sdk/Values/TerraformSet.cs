using System.Collections;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform set attribute that can contain multiple unique unordered elements.
/// Terraform sets are unordered collections that do not allow duplicates.
/// Inherits from TerraformValue&lt;IEnumerable&lt;T&gt;&gt; for clean typing.
/// </summary>
/// <typeparam name="T">The element type (string, double, bool, TerraformBlock&lt;T&gt;, etc.)</typeparam>
public class TerraformSet<T> : TerraformValue<IEnumerable<T>>, IEnumerable
{
    // Internal: Store elements as TerraformValue<T> to preserve unknowns
    private readonly List<TerraformValue<T>> _elements;

    // Parameterless blockor for collection initializer syntax
    public TerraformSet()
        : base()
    {
        _elements = new List<TerraformValue<T>>();
    }

    // Blockor for literal values - enforces uniqueness
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

    // Blockor for mixed TerraformValue<T> elements
    public TerraformSet(IEnumerable<TerraformValue<T>> values)
        : this()
    {
        if (values != null)
        {
            _elements.AddRange(values); // Uniqueness enforced at resolution
        }
    }

    // Blockor for expressions/references
    private TerraformSet(ITerraformResolvable resolvable)
        : base(resolvable)
    {
        _elements = new List<TerraformValue<T>>();
    }

    /// <summary>
    /// Override resolution to handle nested TerraformValue&lt;T&gt; elements.
    /// </summary>
    public override TerraformExpression Resolve(ITerraformContext context)
    {
        var resolvedElements = _elements
            .Select(e => e.Resolve(context))
            .ToList();
        return TerraformExpression.Set((IEnumerable<TerraformExpression>)resolvedElements);
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
    public static new TerraformSet<T> Lazy(Func<ITerraformContext, TerraformExpression> producer)
        => new TerraformLazySet<T>(producer);

    // IEnumerable for collection initializer syntax (non-functional)
    IEnumerator IEnumerable.GetEnumerator()
        => throw new NotSupportedException(
            "TerraformSet cannot be enumerated synchronously. " +
            "Values are resolved during Terraform synthesis.");

    // Static empty set
    public static TerraformSet<T> Empty
        => new TerraformSet<T>();
}

/// <summary>
/// Internal lazy set implementation for deferred resolution.
/// </summary>
internal sealed class TerraformLazySet<T> : TerraformSet<T>
{
    private readonly Func<ITerraformContext, TerraformExpression> _producer;

    public TerraformLazySet(Func<ITerraformContext, TerraformExpression> producer)
        : base()
    {
        _producer = producer ?? throw new ArgumentNullException(nameof(producer));
    }

    public override TerraformExpression Resolve(ITerraformContext context)
    {
        return _producer(context);
    }
}
