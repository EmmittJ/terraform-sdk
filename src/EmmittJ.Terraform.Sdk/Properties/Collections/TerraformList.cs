using System.Collections;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform list property. Stores a list of values and provides reference semantics.
/// Implements IList for natural C# collection usage.
/// </summary>
/// <typeparam name="TValue">The type of values stored in the list.</typeparam>
/// <remarks>
/// Note on Indexer Behavior:
/// - Getter creates a NEW TerraformReferenceProperty instance on each access
/// - This represents the Terraform expression: list[index]
/// - For caching reference instances, store the result in a variable
///
/// Example:
/// <code>
/// var securityGroups = instance.SecurityGroups;  // TerraformList&lt;string&gt;
/// var firstSg = securityGroups[0];  // TerraformReferenceProperty - represents instance.security_groups[0]
///
/// // Cache if used multiple times
/// var sgRef = instance.SecurityGroups[0];
/// rule1.SecurityGroupId = sgRef;
/// rule2.SecurityGroupId = sgRef;  // Same reference instance
/// </code>
/// </remarks>
public class TerraformList<TValue> : TerraformProperty<IList<TerraformProperty<TValue>>>,
    IList<TerraformProperty<TValue>>,
    ITerraformCollection<TerraformProperty<TValue>>,
    ITerraformCollection
{
    private readonly List<TerraformProperty<TValue>> _items = new();

    /// <summary>
    /// Initializes a new Terraform list property.
    /// </summary>
    /// <param name="resourceAddress">The address of the resource.</param>
    /// <param name="attributeName">The name of the attribute.</param>
    public TerraformList(string resourceAddress, string attributeName)
        : base(resourceAddress, attributeName)
    {
    }

    /// <summary>
    /// Gets or sets the element at the specified index.
    /// </summary>
    /// <param name="index">The zero-based index of the element.</param>
    /// <returns>
    /// Getter: A NEW TerraformReferenceProperty instance representing the indexed element reference.
    /// Note: Creates a new instance on each access - cache if used frequently.
    /// </returns>
    /// <remarks>
    /// The getter returns a reference to the indexed property (e.g., instance.security_groups[0]),
    /// NOT the actual value. This matches Terraform's reference semantics.
    /// </remarks>
    public TerraformProperty<TValue> this[int index]
    {
        get => new TerraformReferenceProperty<TValue, IList<TerraformProperty<TValue>>, int>(
            this,
            new TerraformLiteralProperty<int>("", "") { Value = index }
        );
        set => _items[index] = value;
    }

    public int Count => _items.Count;
    public bool IsReadOnly => false;

    public void Add(TerraformProperty<TValue> item) => _items.Add(item);
    public void Clear() => _items.Clear();
    public bool Contains(TerraformProperty<TValue> item) => _items.Contains(item);
    public void CopyTo(TerraformProperty<TValue>[] array, int arrayIndex) => _items.CopyTo(array, arrayIndex);
    public IEnumerator<TerraformProperty<TValue>> GetEnumerator() => _items.GetEnumerator();
    public int IndexOf(TerraformProperty<TValue> item) => _items.IndexOf(item);
    public void Insert(int index, TerraformProperty<TValue> item) => _items.Insert(index, item);
    public bool Remove(TerraformProperty<TValue> item) => _items.Remove(item);
    public void RemoveAt(int index) => _items.RemoveAt(index);
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <summary>
    /// Preparation phase - prepares all nested preparable items.
    /// </summary>
    /// <param name="context">The context for dependency tracking.</param>
    public override void Prepare(ITerraformContext context)
    {
        foreach (var item in _items)
        {
            if (item is ITerraformPreparable preparable)
            {
                preparable.Prepare(context);
            }
        }
    }

    /// <summary>
    /// Resolution phase - resolves to a Terraform list expression.
    /// </summary>
    /// <param name="context">Optional context for resolution.</param>
    /// <returns>A Terraform list expression containing all resolved items.</returns>
    public override TerraformExpression Resolve(ITerraformContext? context = null)
    {
        var resolvedItems = _items
            .Select(item => item.Resolve(context))
            .ToArray();

        return TerraformExpression.List(resolvedItems);
    }

    /// <summary>
    /// Implicit conversion from List&lt;TerraformProperty&lt;TValue&gt;&gt;.
    /// Enables ergonomic collection initialization.
    /// </summary>
    /// <param name="values">The list of values to wrap.</param>
    public static implicit operator TerraformList<TValue>(List<TerraformProperty<TValue>> values)
    {
        var list = new TerraformList<TValue>("", "");
        foreach (var value in values)
        {
            list.Add(value);
        }
        return list;
    }
}
