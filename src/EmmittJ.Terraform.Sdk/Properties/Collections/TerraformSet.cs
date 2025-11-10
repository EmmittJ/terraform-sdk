using System.Collections;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform set property. Stores unique, unordered values and provides reference semantics.
/// Implements ISet for natural C# collection usage.
/// Unlike List, Set enforces uniqueness and has no guaranteed order.
/// </summary>
/// <typeparam name="TValue">The type of values stored in the set.</typeparam>
/// <remarks>
/// Sets in Terraform are unordered collections of unique values. Common use cases include
/// security group IDs and similar resources where order doesn't matter but uniqueness is required.
/// 
/// Note: Sets have NO indexer because they are unordered.
/// 
/// Example:
/// <code>
/// var sg = new AwsSecurityGroup("web", "main")
/// {
///     Ingress = new HashSet&lt;AwsSecurityGroupIngress&gt;
///     {
///         new() { Protocol = "tcp", FromPort = 80, ToPort = 80 },
///         new() { Protocol = "tcp", FromPort = 443, ToPort = 443 }
///     }
/// };
/// 
/// // Add to set (natural C# usage)
/// sg.Ingress.Add(new() { Protocol = "tcp", FromPort = 22, ToPort = 22 });
/// </code>
/// </remarks>
public class TerraformSet<TValue> : TerraformProperty<ISet<TerraformProperty<TValue>>>,
    ISet<TerraformProperty<TValue>>,
    ITerraformCollection<TerraformProperty<TValue>>,
    ITerraformCollection
{
    private readonly HashSet<TerraformProperty<TValue>> _items = new();

    /// <summary>
    /// Initializes a new Terraform set property.
    /// </summary>
    /// <param name="resourceAddress">The address of the resource.</param>
    /// <param name="attributeName">The name of the attribute.</param>
    public TerraformSet(string resourceAddress, string attributeName)
        : base(resourceAddress, attributeName)
    {
    }

    public int Count => _items.Count;
    public bool IsReadOnly => false;

    public bool Add(TerraformProperty<TValue> item) => _items.Add(item);
    public void Clear() => _items.Clear();
    public bool Contains(TerraformProperty<TValue> item) => _items.Contains(item);
    public void CopyTo(TerraformProperty<TValue>[] array, int arrayIndex) => _items.CopyTo(array, arrayIndex);
    public void ExceptWith(IEnumerable<TerraformProperty<TValue>> other) => _items.ExceptWith(other);
    public IEnumerator<TerraformProperty<TValue>> GetEnumerator() => _items.GetEnumerator();
    public void IntersectWith(IEnumerable<TerraformProperty<TValue>> other) => _items.IntersectWith(other);
    public bool IsProperSubsetOf(IEnumerable<TerraformProperty<TValue>> other) => _items.IsProperSubsetOf(other);
    public bool IsProperSupersetOf(IEnumerable<TerraformProperty<TValue>> other) => _items.IsProperSupersetOf(other);
    public bool IsSubsetOf(IEnumerable<TerraformProperty<TValue>> other) => _items.IsSubsetOf(other);
    public bool IsSupersetOf(IEnumerable<TerraformProperty<TValue>> other) => _items.IsSupersetOf(other);
    public bool Overlaps(IEnumerable<TerraformProperty<TValue>> other) => _items.Overlaps(other);
    public bool Remove(TerraformProperty<TValue> item) => _items.Remove(item);
    public bool SetEquals(IEnumerable<TerraformProperty<TValue>> other) => _items.SetEquals(other);
    public void SymmetricExceptWith(IEnumerable<TerraformProperty<TValue>> other) => _items.SymmetricExceptWith(other);
    public void UnionWith(IEnumerable<TerraformProperty<TValue>> other) => _items.UnionWith(other);
    void ICollection<TerraformProperty<TValue>>.Add(TerraformProperty<TValue> item) => _items.Add(item);
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
    /// Resolution phase - resolves to a Terraform set expression.
    /// Note: Terraform sets are typically rendered as lists with toset() function,
    /// but the semantics are different (unordered, unique).
    /// </summary>
    /// <param name="context">Optional context for resolution.</param>
    /// <returns>A Terraform expression representing the set.</returns>
    public override TerraformExpression Resolve(ITerraformContext? context = null)
    {
        var resolvedItems = _items
            .Select(item => item.Resolve(context))
            .ToArray();

        // TODO: Consider wrapping in toset() function call for explicit set semantics
        // For now, render as list - Terraform will infer set from schema
        return TerraformExpression.List(resolvedItems);
    }

    /// <summary>
    /// Implicit conversion from HashSet&lt;TerraformProperty&lt;TValue&gt;&gt;.
    /// Enables ergonomic set initialization.
    /// </summary>
    /// <param name="values">The set of values to wrap.</param>
    public static implicit operator TerraformSet<TValue>(HashSet<TerraformProperty<TValue>> values)
    {
        var set = new TerraformSet<TValue>("", "");
        foreach (var value in values)
        {
            set.Add(value);
        }
        return set;
    }
}
