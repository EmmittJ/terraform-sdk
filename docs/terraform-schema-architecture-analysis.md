# Terraform Schema Architecture Analysis

## Reference Documentation

This analysis is based on the following authoritative sources:

**Terraform Language Documentation:**

- [Configuration Syntax](https://developer.hashicorp.com/terraform/language/syntax/configuration) - Official HCL syntax reference
- [Attributes as Blocks](https://developer.hashicorp.com/terraform/language/attr-as-blocks) - Nested attribute vs block patterns

**Go Plugin Framework Schema:**

- [Data Source Schema](https://pkg.go.dev/github.com/hashicorp/terraform-plugin-framework/datasource/schema) - Schema types and patterns
- [Resource Schema](https://pkg.go.dev/github.com/hashicorp/terraform-plugin-framework/resource/schema) - Same patterns as data sources

These links can be referenced at any time for clarification on Terraform's official behavior and schema architecture.

## Executive Summary

After reviewing HashiCorp's official documentation and the Go plugin framework implementation, I've identified critical architectural issues with our current native collections approach. The fundamental problem is that **we've conflated Terraform's distinct concepts of Arguments, Attributes, and Blocks into a single property system**, which causes serious problems for reference semantics and state management.

## Key Findings

### 1. Terraform's Fundamental Distinctions

Terraform has **two distinct schema elements** with **different access patterns**:

#### **Arguments** (Configurable Properties)

- **Definition**: Values that practitioners **can configure** in their HCL files
- **Syntax**: Uses `=` assignment operator
- **Access Pattern**:
  - **Set by value/expression**: User writes `ami = "ami-12345"` or `ami = var.ami_id`
  - **Get by reference**: Other resources reference `aws_instance.web.ami`
- **Examples**: `ami`, `instance_type`, `security_groups`, `tags`
- **Schema Properties**: `Required` or `Optional` (with or without `Computed`)

#### **Attributes** (Computed-Only Properties)

- **Definition**: Values that the **provider computes** and returns after resource creation
- **Syntax**: Referenced without assignment (read-only)
- **Access Pattern**:
  - **Cannot be set**: No setter, read-only
  - **Get by reference only**: Returns `TerraformExpression` representing `aws_instance.web.id`
- **Examples**: `id`, `arn`, `private_ip` (resource-computed values)
- **Schema Properties**: `Computed = true` AND NOT `Optional` or `Required`

#### **Blocks** (Nested Configuration Structures)

- **Definition**: Structural containers for **nested configuration**, NOT simple attributes
- **Syntax**: Curly brace syntax **without `=` operator**
- **Access Pattern**: Can contain both arguments and attributes
- **Examples**: `ebs_block_device { ... }`, `network_interface { ... }`
- **Key Distinction**: Blocks are **configuration structures**, not values

**The Critical Distinction**: Arguments support **both setting (input) and getting (reference)**, while Attributes support **only getting (reference)**. This isn't about different types, but about different capabilities.

### 2. The Critical Reference Problem

**The Issue You Identified Is Real:**

When accessing nested values in Terraform expressions, the behavior differs fundamentally between attributes and blocks:

```hcl
# For a LIST ATTRIBUTE (e.g., security_groups):
resource "aws_instance" "web" {
  security_groups = ["sg-1", "sg-2"]  # ← Argument (input)
}

# Referencing it returns a REFERENCE to the entire list:
aws_instance.web.security_groups        # → List reference (can be iterated, indexed)
aws_instance.web.security_groups[0]     # → "sg-1"

# For a LIST BLOCK (e.g., ebs_block_device):
resource "aws_instance" "web" {
  ebs_block_device {
    volume_size = 8
  }
  ebs_block_device {
    volume_size = 16
  }
}

# Referencing it returns a LIST OF OBJECTS:
aws_instance.web.ebs_block_device        # → List of block objects
aws_instance.web.ebs_block_device[0]     # → First block object
aws_instance.web.ebs_block_device[0].volume_size  # → 8
```

**What Makes This Complex:**

1. **Arguments** need dual semantics:
   - **Setting**: Accept literal values, expressions, or references for configuration
   - **Getting**: Return **Terraform expression references** for use in other resources
2. **Attributes** need single semantics:
   - **Getting only**: Return **Terraform expression references** (no setting allowed)
3. **Our current approach** doesn't distinguish between set/get operations, making it impossible to:
   - Know when we're **configuring** a value (should store it for serialization)
   - Know when we're **referencing** a value (should generate an expression reference)
   - Prevent setting read-only computed attributes

### 3. Go Plugin Framework's Solution

The Terraform Plugin Framework for Go handles this with **distinct schema types**:

#### Attribute Types

```go
// Simple attributes
schema.StringAttribute {
    Required: true,         // Input argument
    Optional: true,         // Input argument
    Computed: true,         // Output attribute
}

// Collection attributes (still single values, just collection-typed)
schema.ListAttribute {
    ElementType: types.StringType,
    Computed: true,         // Output attribute (list)
    Optional: true,         // Or input argument (list)
}
```

#### Nested Attribute Types (Protocol 6+)

```go
// Nested attributes = collections of OBJECTS defined inline
schema.ListNestedAttribute {
    NestedObject: schema.NestedAttributeObject {
        Attributes: map[string]schema.Attribute {
            "volume_size": schema.Int64Attribute{},
            "volume_type": schema.StringAttribute{},
        },
    },
}
```

**Key Point**: `ListNestedAttribute` is **still an attribute**, just with nested structure. It's used for collections of objects that are **logically attributes** (often computed outputs).

#### Block Types (Legacy Compatibility)

```go
// Blocks = structural configuration elements
schema.ListNestedBlock {
    NestedObject: schema.NestedBlockObject {
        Attributes: map[string]schema.Attribute {
            "volume_size": schema.Int64Attribute{},
        },
        Blocks: map[string]schema.Block {
            // Can contain further nested blocks!
        },
    },
}
```

**Key Point**: Blocks are **primarily for backwards compatibility** with older provider schemas. The framework **recommends using `NestedAttribute` instead** for new providers. However, **blocks remain widely used in production** - major providers like AWS, Azure, and Google Cloud extensively use block syntax for nested configuration, making block support essential rather than optional.

### 4. Attribute vs Block Usage Guidelines

From HashiCorp's documentation:

> **Prefer NestedAttribute over Block.** Blocks should typically be used for configuration compatibility with previously existing schemas from an older Terraform Plugin SDK. Efforts should be made to convert from Block to NestedAttribute as a breaking change for practitioners.

**Why this matters for us:**

- **Attributes** (including nested attributes) use **`=` assignment syntax** → easier to work with expressions
- **Blocks** use **no `=` operator** → traditional HCL block syntax
- **Attributes** support direct expression assignment: `tags = merge(var.common_tags, {...})`
- **Blocks** require **dynamic block expressions** for iteration: `dynamic "ebs_block_device" { ... }`
- **Reality**: Despite being "legacy," blocks are **extensively used** in major providers and will continue to be for the foreseeable future due to backwards compatibility requirements

## Implications for Our SDK

### Problems with Current Architecture

The current `TerraformPropertyCollection` and `TerraformValueResolver` system has fundamental issues:

1. **No Distinction Between Set and Get Operations**

   - Properties are stored as `object?` in `TerraformPropertyCollection`
   - When you access a property, we don't know if you're:
     - **Reading for serialization** (need the literal value)
     - **Reading for reference** (need an expression like `aws_instance.web.id`)
   - No way to enforce read-only semantics for computed-only attributes

2. **Can't Prevent Invalid Sets**

   - Computed-only attributes (like `id`, `arn`) should be read-only
   - Current design allows setting any property: `instance.Id = "bad"`
   - No compile-time or runtime enforcement

3. **Reference Semantics Are Broken**

   - When accessing `instance.SecurityGroups`, should return:
     - The **literal list** user configured? (for HCL serialization during Prepare)
     - A **reference expression** `aws_instance.web.security_groups`? (for use in other resources)
   - Current design can't distinguish these cases

4. **Mixed Input/Output Confusion**
   - `List<TerraformProperty<string>>` could be:
     - An **argument** (user sets it, others reference it)
     - An **attribute** (provider computes it, others reference it)
   - These need different access patterns but use the same storage

**Solution**: Complete redesign with proper type hierarchy.

### New Architecture

#### 1. Type Hierarchy for Properties

After careful review of Terraform's reference semantics and collection behavior, we need specialized collection types that can:

1. Store literal collection values (for serialization)
2. Return references when accessed (for expressions)
3. Support indexing that returns property references (not raw values)
4. Implement standard collection interfaces for natural C# usage

**Base Type - All Properties**:

```csharp
/// <summary>
/// Base class for all Terraform properties. Represents a reference to a Terraform value.
/// Can be subclassed to add specific behaviors (literal values, expressions, etc.).
/// </summary>
public class TerraformProperty<TValue> : ITerraformResolvable<TerraformExpression>
{
    protected readonly string _resourceAddress;
    protected readonly string _attributeName;

    internal TerraformProperty(string resourceAddress, string attributeName)
    {
        _resourceAddress = resourceAddress;
        _attributeName = attributeName;
    }

    // ITerraformResolvable implementation - resolve to identifier expression
    public virtual void Prepare(ITerraformContext context)
    {
        // Nothing to prepare for a pure reference
    }

    public virtual TerraformExpression Resolve(ITerraformContext? context = null)
    {
        // By default, resolves to an identifier reference
        return TerraformExpression.Identifier($"{_resourceAddress}.{_attributeName}");
    }

    // Implicit conversion to expression (calls Resolve internally)
    public static implicit operator TerraformExpression(TerraformProperty<TValue> prop)
        => prop.Resolve();
}

/// <summary>
/// Represents a Terraform property that can store a literal value.
/// Used for arguments that can be set by the user.
/// </summary>
public class TerraformLiteralProperty<TValue> : TerraformProperty<TValue>, ITerraformLiteral<TValue>, ITerraformLiteral
{
    private TValue? _value;

    internal TerraformLiteralProperty(string resourceAddress, string attributeName)
        : base(resourceAddress, attributeName)
    {
    }

    // Public property for value access - allows both get and internal set
    public TValue? Value 
    { 
        get => _value;
        internal set => _value = value; 
    }

    // Implement ITerraformLiteral<TValue> - type-safe access
    TValue? ITerraformLiteral<TValue>.Value => _value;

    // Override Prepare to handle nested preparables
    public override void Prepare(ITerraformContext context)
    {
        // Prepare nested preparable values if TValue contains them
        if (_value is ITerraformPreparable preparable)
        {
            preparable.Prepare(context);
        }
    }

    // Implicit conversion from literal value - for setting
    public static implicit operator TerraformLiteralProperty<TValue>(TValue? value)
    {
        var prop = new TerraformLiteralProperty<TValue>("", "");
        prop._value = value;
        return prop;
    }
}

/// <summary>
/// Represents a Terraform property that resolves to an expression.
/// Used for advanced scenarios like conditional expressions, function calls, etc.
/// </summary>
public class TerraformExpressionProperty<TValue> : TerraformProperty<TValue>, ITerraformExpression
{
    private readonly TerraformExpression _expression;

    public TerraformExpressionProperty(string resourceAddress, string attributeName, TerraformExpression expression)
        : base(resourceAddress, attributeName)
    {
        _expression = expression;
    }

    // Override Prepare to handle the expression
    public override void Prepare(ITerraformContext context)
    {
        if (_expression is ITerraformPreparable preparable)
        {
            preparable.Prepare(context);
        }
    }

    // Override Resolve to return the stored expression
    public override TerraformExpression Resolve(ITerraformContext? context = null)
    {
        return _expression;
    }

    // Implicit conversion from expression - for setting
    public static implicit operator TerraformExpressionProperty<TValue>(TerraformExpression expression)
    {
        return new TerraformExpressionProperty<TValue>("", "", expression);
    }
}

/// <summary>
/// Represents a reference to another Terraform property.
/// Used for indexers and nested property access - doesn't store values, just references.
/// Note: Creates new instances on each access to maintain reference semantics.
/// For frequently accessed properties, consider caching the reference.
/// </summary>
public class TerraformReferenceProperty<TValue, TSource, TIndex> : TerraformProperty<TValue>
{
    private readonly TerraformProperty<TSource>? _sourceProperty;
    private readonly TerraformProperty<TIndex>? _indexProperty;

    // Constructor for direct references (computed attributes)
    public TerraformReferenceProperty(string resourceAddress, string attributeName)
        : base(resourceAddress, attributeName)
    {
    }

    // Constructor for indexed/nested references (indexers)
    public TerraformReferenceProperty(
        TerraformProperty<TSource> sourceProperty,
        TerraformProperty<TIndex> indexProperty)
        : base("", "")
    {
        _sourceProperty = sourceProperty;
        _indexProperty = indexProperty;
    }

    // Nothing to prepare - this is just a reference
    public override void Prepare(ITerraformContext context)
    {
        // Pure reference, nothing to prepare
    }

    // Resolves to the reference path
    public override TerraformExpression Resolve(ITerraformContext? context = null)
    {
        if (_sourceProperty is not null && _indexProperty is not null)
        {
            // Resolve the source property first, then append the index
            var sourceExpr = _sourceProperty.Resolve(context);
            var indexExpr = _indexProperty.Resolve(context);
            return TerraformExpression.Identifier($"{sourceExpr.ToString()}[{indexExpr.ToString()}]");
        }

        return TerraformExpression.Identifier($"{_resourceAddress}.{_attributeName}");
    }
}

/// <summary>
/// Represents a Terraform list property. Stores a list of values and provides reference semantics.
/// Implements IList for natural C# collection usage.
/// 
/// Note on Indexer Behavior:
/// - Getter creates a NEW TerraformReferenceProperty instance on each access
/// - This represents the Terraform expression: list[index]
/// - For caching reference instances, store the result in a variable
/// 
/// Example:
/// <code>
/// var securityGroups = instance.SecurityGroups;  // TerraformList&lt;string&gt;
/// var firstSg = securityGroups[0];  // TerraformReferenceProperty - represents instance.security_groups[0]
/// </code>
/// </summary>
public class TerraformList<TValue> : TerraformProperty<IList<TerraformProperty<TValue>>>,
    IList<TerraformProperty<TValue>>,
    ITerraformCollection<TerraformProperty<TValue>>,
    ITerraformCollection
{
    private readonly List<TerraformProperty<TValue>> _items = new();

    public TerraformList(string resourceAddress, string attributeName)
        : base(resourceAddress, attributeName)
    {
    }

    // Indexer returns REFERENCE to the indexed property
    // This matches Terraform semantics: instance.security_groups[0] → reference expression
    // NOTE: Creates a new reference instance on each access - cache if needed
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

    // Override Prepare to handle nested preparables
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

    // Implicit conversion from List<TerraformProperty<TValue>>
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

/// <summary>
/// Represents a Terraform map property. Stores key-value pairs and provides reference semantics.
/// Implements IDictionary for natural C# dictionary usage.
/// 
/// Note on Indexer Behavior:
/// - Getter creates a NEW TerraformReferenceProperty instance on each access
/// - This represents the Terraform expression: map["key"]
/// - For caching reference instances, store the result in a variable
/// 
/// Example:
/// <code>
/// var tags = instance.Tags;  // TerraformMap&lt;string&gt;
/// var nameTag = tags["Name"];  // TerraformReferenceProperty - represents instance.tags["Name"]
/// </code>
/// </summary>
public class TerraformMap<TValue> : TerraformProperty<IDictionary<string, TerraformProperty<TValue>>>,
    IDictionary<string, TerraformProperty<TValue>>,
    ITerraformCollection<TerraformProperty<TValue>>,
    ITerraformCollection
{
    private readonly Dictionary<string, TerraformProperty<TValue>> _items = new();

    public TerraformMap(string resourceAddress, string attributeName)
        : base(resourceAddress, attributeName)
    {
    }

    // Indexer returns REFERENCE to the keyed property
    // This matches Terraform semantics: instance.tags["Name"] → reference expression
    // NOTE: Creates a new reference instance on each access - cache if needed
    public TerraformProperty<TValue> this[string key]
    {
        get => new TerraformReferenceProperty<TValue, IDictionary<string, TerraformProperty<TValue>>, string>(
            this,
            new TerraformLiteralProperty<string>("", "") { Value = key }
        );
        set => _items[key] = value;
    }

    public ICollection<string> Keys => _items.Keys;
    public ICollection<TerraformProperty<TValue>> Values => _items.Values;
    public int Count => _items.Count;
    public bool IsReadOnly => false;
    public void Add(string key, TerraformProperty<TValue> value) => _items.Add(key, value);
    public void Add(KeyValuePair<string, TerraformProperty<TValue>> item) => _items.Add(item.Key, item.Value);
    public void Clear() => _items.Clear();
    public bool Contains(KeyValuePair<string, TerraformProperty<TValue>> item) => _items.Contains(item);
    public bool ContainsKey(string key) => _items.ContainsKey(key);
    public void CopyTo(KeyValuePair<string, TerraformProperty<TValue>>[] array, int arrayIndex) =>
        ((IDictionary<string, TerraformProperty<TValue>>)_items).CopyTo(array, arrayIndex);
    public IEnumerator<KeyValuePair<string, TerraformProperty<TValue>>> GetEnumerator() => _items.GetEnumerator();
    public bool Remove(string key) => _items.Remove(key);
    public bool Remove(KeyValuePair<string, TerraformProperty<TValue>> item) => ((IDictionary<string, TerraformProperty<TValue>>)_items).Remove(item);
    public bool TryGetValue(string key, out TerraformProperty<TValue> value) => _items.TryGetValue(key, out value!);
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    // Explicit implementation for ITerraformCollection<T> to avoid conflicts
    IEnumerator<TerraformProperty<TValue>> IEnumerable<TerraformProperty<TValue>>.GetEnumerator() => _items.Values.GetEnumerator();

    // Override Prepare to handle nested preparables
    public override void Prepare(ITerraformContext context)
    {
        foreach (var value in _items.Values)
        {
            if (value is ITerraformPreparable preparable)
            {
                preparable.Prepare(context);
            }
        }
    }

    // Implicit conversion from Dictionary<string, TerraformProperty<TValue>>
    public static implicit operator TerraformMap<TValue>(Dictionary<string, TerraformProperty<TValue>> values)
    {
        var map = new TerraformMap<TValue>("", "");
        foreach (var kvp in values)
        {
            map.Add(kvp.Key, kvp.Value);
        }
        return map;
    }
}

/// <summary>
/// Represents a Terraform set property. Stores unique, unordered values and provides reference semantics.
/// Implements ISet for natural C# collection usage.
/// Unlike List, Set enforces uniqueness and has no guaranteed order.
/// </summary>
public class TerraformSet<TValue> : TerraformProperty<ISet<TerraformProperty<TValue>>>, ISet<TerraformProperty<TValue>>
{
    private readonly HashSet<TerraformProperty<TValue>> _items = new();

    public TerraformSet(string resourceAddress, string attributeName)
        : base(resourceAddress, attributeName)
    {
    }

    // Note: Sets don't have indexers since they're unordered
    // Reference to the whole set via the property itself

    public int Count => _items.Count;
    public bool IsReadOnly => false;
    public bool Add(TerraformProperty<TValue> item) => _items.Add(item);
    void ICollection<TerraformProperty<TValue>>.Add(TerraformProperty<TValue> item) => _items.Add(item);
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
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    // Internal access for serialization
    internal ISet<TerraformProperty<TValue>> GetValue() => _items;

    // Override Prepare to handle nested preparables
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

    // Implicit conversion from HashSet<TerraformProperty<TValue>>
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
```

**Why We Need `TerraformList<TValue>`, `TerraformSet<TValue>`, and `TerraformMap<TValue>`:**

1. **Indexer Returns Reference (List/Map only)**:
   - **Get**: `list[0]` or `map["key"]` returns `TerraformReferenceProperty<TValue>`
   - **Set**: `list[0] = value` or `map["key"] = value` stores the literal value for serialization
   - Reference resolution is deferred until `Resolve()` is called
   - Index/key can be a literal or expression (future: `list[var.index]`)
2. **Set Semantics**:
   - **Unordered**: No indexer (sets have no guaranteed order)
   - **Unique**: Automatically enforces uniqueness
   - **Usage**: `security_group_ids = toset(["sg-1", "sg-2"])`
3. **Natural Collection Operations**: Methods like `Add()`, `Remove()`, `Count` work as expected

4. **Serialization**: Internal `GetValue()` provides literal collection for HCL generation

5. **Type Safety**: Collections explicitly store `TerraformProperty<TValue>` elements

6. **Lazy Resolution**: Reference path is built when needed, supporting dynamic indexing

**What This Solves:**

✅ **Problem 1 - Indexer Reference Semantics**:

- **CRITICAL FIX**: `instance.SecurityGroups[0]` → returns `TerraformProperty<string>` (reference to `aws_instance.web.security_groups[0]`)
- Clean, explicit type: `TerraformList<string>` stores `List<TerraformProperty<string>>`

✅ **Problem 2 - Natural C# Usage**:

- Custom collection types (`TerraformList<TValue>`, `TerraformSet<TValue>`, `TerraformMap<TValue>`) provide proper reference semantics
- Standard collection methods work: `Add()`, `Remove()`, `Contains()`, enumeration
- Standard LINQ works on the collection: `instance.SecurityGroups.Where(...)`, `instance.Tags.Select(...)`
- Collection initializers work with implicit conversions from `List<TerraformProperty<TValue>>`, `HashSet<TerraformProperty<TValue>>`, etc.

✅ **Problem 3 - Reference Semantics**:

- Passing `instance.SecurityGroups` to another resource resolves to `aws_instance.web.security_groups`
- Accessing indexed items via indexer properly generates indexed references: `list[0]` → reference expression

✅ **Problem 4 - Type System Coverage**:

- `TerraformProperty<T>` - base class for all properties
- `TerraformLiteralProperty<T>` - stores literal values for arguments
- `TerraformExpressionProperty<T>` - stores expression values
- `TerraformReferenceProperty<T>` - pure references (indexers, computed attributes)
- `TerraformList<TValue>` - list collections (stores `List<TerraformProperty<TValue>>`, indexer returns `TerraformReferenceProperty<TValue>`)
- `TerraformMap<TValue>` - map collections (stores `Dictionary<string, TerraformProperty<TValue>>`, indexer returns `TerraformReferenceProperty<TValue>`)
- `TerraformBlock` - nested configuration structures

This covers all Terraform schema types from the documentation.

### Gap Analysis

After reviewing the design against HashiCorp's complete schema type system, the following gaps have been identified:

#### ✅ Covered Types:

- **String, Bool, Number** - via `TerraformProperty<T>` / `TerraformLiteralProperty<T>`
- **List** - via `TerraformList<TValue>` (ordered collections)
- **Set** - via `TerraformSet<TValue>` (unordered, unique collections)
- **Map** - via `TerraformMap<TValue>` (key-value pairs, all values same type)
- **Expressions** - via `TerraformExpressionProperty<T>`
- **References** - via `TerraformReferenceProperty<T, TSource, TIndex>`

### 2. Usage Patterns & Examples

#### **Pattern 1: Arguments (Configurable Properties)**

Arguments can be set by users and referenced by other resources:

```csharp
// Generated property on resource class
public class AwsInstance : TerraformResource
{
    // Backing field stores the literal property
    private TerraformLiteralProperty<string> _ami;
    
    // Property exposes as base type for flexibility
    public TerraformProperty<string> Ami
    {
        get => _ami;
        set
        {
            // Accept literal values via implicit conversion
            if (value is TerraformLiteralProperty<string> literal)
            {
                _ami = literal;
            }
            else
            {
                // Wrap other property types as needed
                _ami = new TerraformLiteralProperty<string>(ResourceAddress, "ami") 
                { 
                    Value = ((ITerraformLiteral<string>)value).Value 
                };
            }
        }
    }
}

// User code - setting literal value
instance.Ami = "ami-12345";  // Implicit conversion to TerraformLiteralProperty<string>

// User code - referencing another resource
otherInstance.Ami = instance.Ami;  // References aws_instance.web.ami
```

#### **Pattern 2: Attributes (Computed-Only Properties)**

Attributes are read-only, computed by the provider:

```csharp
public class AwsInstance : TerraformResource
{
    // Computed attributes use TerraformReferenceProperty - no setter!
    public TerraformProperty<string> Id => 
        new TerraformReferenceProperty<string, object, object>(ResourceAddress, "id");
    
    public TerraformProperty<string> Arn => 
        new TerraformReferenceProperty<string, object, object>(ResourceAddress, "arn");
    
    public TerraformProperty<string> PrivateIp => 
        new TerraformReferenceProperty<string, object, object>(ResourceAddress, "private_ip");
}

// User code - can only read, not set
var instanceId = instance.Id;  // Returns reference to aws_instance.web.id
// instance.Id = "bad";  // ❌ Compile error - no setter!

// Pass to another resource
securityGroupRule.SourceSecurityGroupId = instance.PrimaryNetworkInterface.Id;
```

#### **Pattern 3: Collection Properties with Indexing**

Collections support both literal values and reference semantics:

```csharp
public class AwsInstance : TerraformResource
{
    private TerraformList<string> _securityGroups;
    
    public TerraformList<string> SecurityGroups
    {
        get => _securityGroups;
        set => _securityGroups = value;
    }
}

// User code - setting literal values
instance.SecurityGroups = new TerraformList<string>
{
    "sg-12345",  // Implicit conversion to TerraformLiteralProperty<string>
    "sg-67890"
};

// User code - accessing indexed elements (creates reference)
var firstSg = instance.SecurityGroups[0];  // TerraformReferenceProperty → aws_instance.web.security_groups[0]

// User code - using in another resource
otherInstance.SecurityGroups = instance.SecurityGroups;  // References entire list

// Cache reference if used multiple times
var sgRef = instance.SecurityGroups[0];
rule1.SecurityGroupId = sgRef;
rule2.SecurityGroupId = sgRef;  // Same reference instance
```

#### **Pattern 4: Conditional Expressions**

For advanced scenarios like conditionals, add explicit support:

```csharp
/// <summary>
/// Represents a Terraform conditional expression: condition ? true_val : false_val
/// </summary>
public class TerraformConditionalProperty<TValue> : TerraformProperty<TValue>
{
    private readonly TerraformProperty<bool> _condition;
    private readonly TerraformProperty<TValue> _trueValue;
    private readonly TerraformProperty<TValue> _falseValue;

    public TerraformConditionalProperty(
        TerraformProperty<bool> condition,
        TerraformProperty<TValue> trueValue,
        TerraformProperty<TValue> falseValue)
        : base("", "")
    {
        _condition = condition;
        _trueValue = trueValue;
        _falseValue = falseValue;
    }

    public override void Prepare(ITerraformContext context)
    {
        _condition.Prepare(context);
        _trueValue.Prepare(context);
        _falseValue.Prepare(context);
    }

    public override TerraformExpression Resolve(ITerraformContext? context = null)
    {
        var condExpr = _condition.Resolve(context);
        var trueExpr = _trueValue.Resolve(context);
        var falseExpr = _falseValue.Resolve(context);
        return TerraformExpression.Conditional(condExpr, trueExpr, falseExpr);
    }
}

// Usage
instance.InstanceType = new TerraformConditionalProperty<string>(
    TerraformExpression.Var("is_production"),
    "t3.large",
    "t3.micro"
);
// Generates: instance_type = var.is_production ? "t3.large" : "t3.micro"
```

#### **Pattern 5: Function Calls**

Support for Terraform built-in functions:

```csharp
/// <summary>
/// Represents a Terraform function call expression
/// </summary>
public class TerraformFunctionProperty<TValue> : TerraformProperty<TValue>
{
    private readonly string _functionName;
    private readonly TerraformProperty[] _arguments;

    public TerraformFunctionProperty(string functionName, params TerraformProperty[] arguments)
        : base("", "")
    {
        _functionName = functionName;
        _arguments = arguments;
    }

    public override void Prepare(ITerraformContext context)
    {
        foreach (var arg in _arguments)
        {
            arg?.Prepare(context);
        }
    }

    public override TerraformExpression Resolve(ITerraformContext? context = null)
    {
        var argExprs = _arguments.Select(a => a.Resolve(context)).ToArray();
        return TerraformExpression.FunctionCall(_functionName, argExprs);
    }
}

// Usage examples
instance.Tags = new TerraformFunctionProperty<IDictionary<string, string>>(
    "merge",
    TerraformExpression.Var("common_tags"),
    new TerraformMap<string> { ["Name"] = "my-instance" }
);
// Generates: tags = merge(var.common_tags, { Name = "my-instance" })

instance.SubnetId = new TerraformFunctionProperty<string>(
    "element",
    subnet.Ids,
    0
);
// Generates: subnet_id = element(aws_subnet.main.ids, 0)
```

### 3. Comparison: Collection of Properties vs Property of Collection

**Current Design: `TerraformList<TValue>` stores `List<TerraformProperty<TValue>>`**

✅ **Advantages:**
- Each element can be a literal, expression, or reference independently
- Indexer returns proper reference: `list[0]` → `TerraformReferenceProperty<TValue>`
- Supports heterogeneous element sources: `["literal", var.some_var, other.resource.id]`
- Natural C# collection manipulation

❌ **Disadvantages:**
- More complex type signatures
- New reference instance created on each indexer access (requires caching for performance)
- More memory overhead

**Alternative: `TerraformProperty<List<TValue>>` (simpler, like CDK)**

✅ **Advantages:**
- Simpler type: single property wrapping entire collection
- Single resolution point
- Like AWS CDK's `Token.asList()`

❌ **Disadvantages:**
- Can't have mixed literal/expression elements
- Indexing returns `TValue`, not a reference
- Loses per-element flexibility
- Less natural C# collection usage

**Recommendation**: Keep current design (`TerraformList<TValue>`) for **Arguments and user-settable collections**. The flexibility is worth the complexity. For **computed list attributes**, consider simpler `TerraformProperty<List<string>>` since they're read-only anyway.

### 4. Key Improvements Summary

✅ **Fixed Issues:**
1. ✅ Added public `Value` property with internal setter to `TerraformLiteralProperty<T>`
2. ✅ Fixed syntax errors in `TerraformReferenceProperty<T>` (removed duplicate declaration, fixed if statement)
3. ✅ Added XML documentation explaining indexer behavior (creates new instances)
4. ✅ Added usage pattern examples showing Arguments vs Attributes
5. ✅ Added `TerraformConditionalProperty<T>` for conditional expressions
6. ✅ Added `TerraformFunctionProperty<T>` for function calls

📋 **Remaining Considerations:**
1. Consider reference caching mechanism if performance becomes an issue
2. Add builder/fluent API for complex expressions
3. Document serialization strategy (how `Prepare()` and `Resolve()` work together)
4. Add validation for read-only attributes (prevent setting in generated code)
5. Consider code generator strategies for distinguishing Arguments vs Attributes in generated resource classes

#### ❌ Still Missing (from Go Plugin Framework):

1. **Block Support** - `schema.ListNestedBlock`, `schema.SetNestedBlock`, `schema.SingleNestedBlock`

   - **Critical**: Blocks use different syntax (no `=` operator) and are extensively used in production
   - **Examples**: `ebs_block_device { ... }`, `network_interface { ... }`, `ingress { ... }`
   - **Serialization**: Blocks serialize differently than attributes (no `=`, repeat block label)
   - **Priority**: HIGH - blocks are pervasive in AWS, Azure, GCP providers
   - **Solution**: See "Block System Design" section below ✅

2. **Computed-Only Attribute Distinction**
   - **Current**: No way to mark attributes as read-only/computed-only
   - **Schema**: `Computed: true` without `Optional` or `Required`
   - **Examples**: `id`, `arn`, `private_ip` - provider sets these, user cannot
   - **Need**: Consider `TerraformComputedProperty<TValue>` that prevents setting
   - **Priority**: MEDIUM - prevents user errors and improves API clarity

#### ✅ Already Solved (via existing patterns):

1. **Object Type** - `schema.ObjectAttribute`

   - **Known schemas**: Generate C# classes with typed properties
   - **Unknown schemas**: Use `TerraformMap<object>`
   - **No special type needed** ✅

2. **SingleNestedAttribute** - `schema.SingleNestedAttribute`

   - **Solution**: Generated C# class inheriting from `TerraformProperty<T>` or containing nested properties
   - **Example**: `public NetworkConfig Network { get; set; }` where `NetworkConfig` is generated class
   - **No special type needed** ✅

3. **SetNestedAttribute** - `schema.SetNestedAttribute`

   - **Solution**: `TerraformSet<TNestedClass>` where `TNestedClass` is generated
   - **Already supported** ✅

4. **MapNestedAttribute** - `schema.MapNestedAttribute`

   - **Solution**: `TerraformMap<TNestedClass>` where `TNestedClass` is generated
   - **Already supported** ✅

5. **ListNestedAttribute** - `schema.ListNestedAttribute`

   - **Solution**: `TerraformList<TNestedClass>` where `TNestedClass` is generated
   - **Already supported** ✅

6. **Dynamic Type** - `schema.DynamicAttribute`

   - **Solution**: `TerraformProperty<object>` or `TerraformMap<object>` for runtime-typed data
   - **Trade-off**: No compile-time safety for truly dynamic data (acceptable)
   - **Already supported** ✅

7. **Tuple Type** - `types.TupleType`

   - **Solution**: Generated C# classes for known schemas, or `TerraformList<object>` for rare cases
   - **Rare in practice** - most providers don't use tuples
   - **Already supported** ✅

8. **Number Type Precision** - Int64 vs Float64
   - **Schema Types**: `schema.Int64Attribute`, `schema.Float64Attribute`
   - **Solution**: Use `TerraformProperty<int>`, `TerraformProperty<long>`, `TerraformProperty<double>` based on schema
   - **Code generation** picks correct C# numeric type from schema metadata
   - **Already supported** ✅

#### � Updated Design Priorities:

1. **CRITICAL - Block Support**:

   - Must implement `TerraformBlock` base class
   - Must handle block vs attribute serialization differences
   - Major providers (AWS, Azure, GCP) extensively use blocks
   - Example: AWS security group `ingress { ... }` blocks

2. **HIGH - Computed-Only Properties**:

   - Consider `TerraformComputedProperty<TValue>` (read-only, no setter)
   - Or use property generation patterns (private setter, etc.)
   - Prevents accidental assignment to computed fields

3. **LOW - Everything Else**:
   - Nested attributes: ✅ solved via generated classes + existing collections
   - Dynamic/Object types: ✅ solved via `object` type parameter
   - Tuples: ✅ rare, handled via generated classes or `List<object>`
   - Number precision: ✅ use int/long/double based on schema

````

**Generated Code for Arguments**:

```csharp
public class AwsInstance : TerraformResource
{
    // Simple argument
    public TerraformProperty<string> Ami { get; set; }

    // List argument - TerraformList<string> stores List<TerraformProperty<string>> internally
    public TerraformList<string> SecurityGroups { get; set; }

    // Map argument - TerraformMap<string> stores Dictionary<string, TerraformProperty<string>> internally
    public TerraformMap<string> Tags { get; set; }

    // Usage:
    // Simple property
    instance.Ami = "ami-12345";  // Implicit conversion to TerraformLiteralProperty<string>

    // List - natural C# collection operations
    instance.SecurityGroups = new List<TerraformProperty<string>>
    {
        "sg-1",  // Implicit conversion to TerraformProperty<string>
        "sg-2"
    };
    instance.SecurityGroups.Add("sg-3");  // Add implicitly converts to TerraformProperty<string>

    // Map - natural C# dictionary operations
    instance.Tags = new Dictionary<string, TerraformProperty<string>>
    {
        ["Name"] = "web",  // Implicit conversion to TerraformProperty<string>
        ["Env"] = "prod"
    };
    instance.Tags.Add("Owner", "team-a");  // Implicit conversion

    // Getting references - indexer returns TerraformProperty<TValue> directly!
    var amiRef = instance.Ami;  // TerraformProperty<string>
    var sgRef = instance.SecurityGroups[0];  // TerraformProperty<string> - reference to index 0!
    var tagRef = instance.Tags["Name"];  // TerraformProperty<string> - reference to "Name" key!
}
````

**Generated Code for Attributes** (Computed-only):

```csharp
public class AwsInstance : TerraformResource
{
    // ATTRIBUTE: Read-only, returns TerraformReferenceProperty<T> (no setter!)
    // Uses TerraformReferenceProperty<T> - pure reference, no literal storage
    public TerraformProperty<string> Id
        => new TerraformReferenceProperty<string>(TerraformAddress, "id");

    // Usage:
    // instance.Id = "bad";  // ❌ Compile error - no setter!
    // var ref = instance.Id;  // ✅ Gets TerraformProperty<string> (actual type: TerraformReferenceProperty)
    // var expr = instance.Id.Resolve();  // ✅ Returns TerraformExpression.Identifier("aws_instance.web.id")
}
```

**Generated Code for Optional + Computed**:

```csharp
public class AwsInstance : TerraformResource
{
    // Can be set by user OR computed by provider
    public TerraformProperty<Dictionary<string, string>> Tags { get; set; }

    // Usage:
    // instance.Tags = new Dictionary<string, string> { ["key"] = "value" };  // Set literal
    // var ref = instance.Tags;  // Get reference (whether set or computed)
}
```

**Advanced Usage with Expressions**:

```csharp
public class AwsInstance : TerraformResource
{
    public TerraformProperty<Dictionary<string, string>> Tags { get; set; }

    // Usage:
    // Set with a literal
    instance.Tags = new Dictionary<string, string> { ["key"] = "value" };

    // Set with an expression (e.g., merge function)
    instance.Tags = TerraformExpression.FunctionCall("merge",
        TerraformExpression.Variable("var.common_tags"),
        new Dictionary<string, string> { ["Name"] = "web" }
    );
    // → Implicitly converts to TerraformExpressionProperty<Dictionary<string, string>>
}
```

**Key Benefits**:

- **Single base type** `TerraformProperty<T>` used everywhere (getters and setters)
- **Subclasses for behavior**:
  - `TerraformLiteralProperty<T>` stores literal values (arguments)
  - `TerraformExpressionProperty<T>` stores expressions (advanced usage)
  - `TerraformReferenceProperty<T>` pure references (computed attributes, indexers)
- **Implicit conversions** make it ergonomic
- **Type safety**: Computed attributes can't be set (no setter)
- **Users work with base type** - specific subclass is implementation detail
- **Internal serialization** uses `GetValue()` during `Prepare()` for literal properties
- **Clear semantics**: `TerraformReferenceProperty` never stores values, only resolves to reference paths

#### 2. Distinguish Nested Attributes from Blocks

**Nested Attributes** (Preferred for new schemas):

```csharp
// Generated from schema.ListNestedAttribute
public class AwsSecurityGroupRule : TerraformNestedAttribute
{
    public TerraformProperty<string> Protocol { get; set; }
    public TerraformProperty<int> FromPort { get; set; }
    public TerraformProperty<int> ToPort { get; set; }
}

public class AwsSecurityGroup : TerraformResource
{
    // Collection of nested attribute objects
    public List<AwsSecurityGroupRule> IngressRules { get; set; }

    // When serialized to HCL:
    // ingress = [
    //   { protocol = "tcp", from_port = 80, to_port = 80 },
    //   { protocol = "tcp", from_port = 443, to_port = 443 }
    // ]
}
```

**Blocks** (Widely used in production providers):

```csharp
// Generated from schema.ListNestedBlock
public class AwsInstanceEbsBlockDevice : TerraformBlock
{
    public TerraformProperty<int> VolumeSize { get; set; }
    public TerraformProperty<string> VolumeType { get; set; }
}

public class AwsInstance : TerraformResource
{
    // Collection of blocks
    public List<AwsInstanceEbsBlockDevice> EbsBlockDevice { get; set; }

    // When serialized to HCL:
    // ebs_block_device {
    //   volume_size = 8
    //   volume_type = "gp3"
    // }
    // ebs_block_device {
    //   volume_size = 16
    //   volume_type = "io1"
    // }
}
```

**Note**: While the Terraform plugin framework documentation labels blocks as "legacy," they remain a critical pattern in real-world provider schemas. Major providers (AWS, Azure, GCP) extensively use blocks for nested configuration, making robust block support essential for SDK compatibility.

#### 3. Reference Semantics

**For Computed Attributes (read-only):**

```csharp
var instance = new AwsInstance("web", "main")
{
    Ami = "ami-12345",  // Implicit conversion from string to TerraformLiteralProperty<string>
};

// Reference the computed ID attribute (returns base TerraformProperty<string>):
TerraformProperty<string> idRef = instance.Id;

// Use in another resource (implicit conversion to TerraformExpression):
var volume = new AwsEbsVolume("data", "main")
{
    AvailabilityZone = instance.AvailabilityZone  // TerraformProperty<string> → TerraformExpression
};

// Generated HCL:
// availability_zone = aws_instance.web.availability_zone
```

**For Arguments (read-write with reference):**

```csharp
var instance = new AwsInstance("web", "main")
{
    SecurityGroups = new List<string> { "sg-1", "sg-2" }  // Implicit conversion to TerraformList<string>
};

// Modify using standard collection methods:
instance.SecurityGroups.Add("sg-3");
instance.SecurityGroups[0] = "sg-updated";  // Modifies literal value

// Get reference for use in expressions:
var firstSgRef = instance.SecurityGroups.GetReference(0);  // TerraformProperty<string>

// Use reference in another resource:
var anotherInstance = new AwsInstance("web2", "main")
{
    // Use the whole list reference
    SecurityGroups = instance.SecurityGroups  // Passes TerraformList<string> - will resolve to reference!
};

// Generated HCL for first instance:
// security_groups = ["sg-updated", "sg-2", "sg-3"]

// Generated HCL for second instance:
// security_groups = aws_instance.web.security_groups
```

**For Nested Collection Access:**

```csharp
var instance = new AwsInstance("web", "main")
{
    SecurityGroups = new List<string> { "sg-1", "sg-2", "sg-3" }
};

// Get reference: indexer getter returns REFERENCE, not literal value
TerraformProperty<string> firstSgRef = instance.SecurityGroups[0];  // Reference expression!

// Set literal value: indexer setter stores the value
instance.SecurityGroups[0] = "sg-updated";  // Modifies stored value

// Use reference in expression:
var rule = new AwsSecurityGroupRule("allow", "main")
{
    SourceSecurityGroupId = instance.SecurityGroups[0]  // aws_instance.web.security_groups[0]
};

// Generated HCL:
// source_security_group_id = aws_instance.web.security_groups[0]
```

**For Maps:**

```csharp
var instance = new AwsInstance("web", "main")
{
    Tags = new Dictionary<string, string>
    {
        ["Name"] = "web-server",
        ["Environment"] = "prod"
    }
};

// Get reference: indexer getter returns REFERENCE, not literal value
TerraformProperty<string> nameRef = instance.Tags["Name"];  // Reference expression!

// Set/modify literal value: indexer setter stores the value
instance.Tags["Owner"] = "team-a";
instance.Tags.Remove("Environment");

// Use reference in another resource:
var volume = new AwsEbsVolume("data", "main")
{
    Tags = new Dictionary<string, string>
    {
        ["InstanceName"] = instance.Tags["Name"]  // aws_instance.web.tags["Name"] - REFERENCE!
    }
};

// Generated HCL:
// tags = {
//   InstanceName = aws_instance.web.tags["Name"]
// }
```

**For Nested Attributes (List of Objects):**

```csharp
var sg = new AwsSecurityGroup("web", "main")
{
    IngressRules = new List<AwsSecurityGroupRule>
    {
        new() { Protocol = "tcp", FromPort = 80, ToPort = 80 },
        new() { Protocol = "tcp", FromPort = 443, ToPort = 443 }
    }
};

// Reference a computed nested attribute:
var firstRuleId = sg.IngressRules[0].Id;
// → TerraformExpression("aws_security_group.web.ingress[0].id")
```

## Recommended Architecture Changes

### Phase 1: Implement Type Hierarchy

1. **Create `TerraformProperty<TValue>` hierarchy**:

   ```csharp
   // Base property type - represents any Terraform property reference
   public class TerraformProperty<TValue> : ITerraformResolvable<TerraformExpression>
   {
       protected string _address;
       protected string _name;

       // Resolves to identifier expression
       public virtual TerraformExpression Resolve(ITerraformContext? context = null);

       // Implicit conversion to expression
       public static implicit operator TerraformExpression(TerraformProperty<TValue> prop);

       // Indexers for collections
       public TerraformProperty<TElement> this[int index];
       public TerraformProperty<TMapValue> this[string key];
   }

   // Subclass for literal values (arguments)
   public class TerraformLiteralProperty<TValue> : TerraformProperty<TValue>
   {
       private TValue? _value;

       // Implicit conversion FROM literal value (for setting)
       public static implicit operator TerraformLiteralProperty<TValue>(TValue? value);

       // Internal access for serialization
       internal TValue? GetValue();
   }

   // Subclass for expression values (advanced usage)
   public class TerraformExpressionProperty<TValue> : TerraformProperty<TValue>
   {
       private TerraformExpression _expression;

       // Implicit conversion FROM expression (for setting)
       public static implicit operator TerraformExpressionProperty<TValue>(TerraformExpression expr);

       // Override Resolve to return stored expression
       public override TerraformExpression Resolve(ITerraformContext? context = null);
   }
   ```

2. **Update Schema Parser**:

   ```csharp
   SchemaAttribute attr = ...;

   if (attr.Required || (attr.Optional && !attr.Computed))
   {
       // Generate: public TerraformProperty<string> Ami { get; set; }
       // User can set literal (converts to TerraformLiteralProperty), get returns base type
   }
   else if (attr.Computed && !attr.Optional && !attr.Required)
   {
       // Generate: public TerraformProperty<string> Id => new(...);
       // Read-only property, uses base TerraformProperty directly (no literal storage)
   }
   else if ((attr.Optional || attr.Required) && attr.Computed)
   {
       // Generate: public TerraformProperty<string> Tags { get; set; }
       // Can set literal/expression, or reference
   }
   ```

3. **Update Code Generation Templates**:

   ```mustache
   {{#IsArgument}}
   /// <summary>{{Description}}</summary>
   public TerraformProperty<{{Type}}> {{Name}} { get; set; }
   {{/IsArgument}}

   {{#IsComputedOnly}}
   /// <summary>{{Description}}</summary>
   public TerraformProperty<{{Type}}> {{Name}}
       => new TerraformProperty<{{Type}}>(TerraformAddress, "{{AttributeName}}");
   {{/IsComputedOnly}}
   ```

### Phase 2: Separate Nested Attributes from Blocks

1. **Create Distinct Base Classes**:

   ```csharp
   // For nested attribute objects (use attributes-as-blocks pattern)
   public abstract class TerraformNestedAttribute
   {
       // Contains only arguments/attributes, no nested blocks
       // Serializes to object syntax: { key = value, ... }
   }

   // For block structures (legacy pattern)
   public abstract class TerraformBlock
   {
       // Can contain attributes AND nested blocks
       // Serializes to block syntax: block_type { ... }
   }
   ```

2. **Schema Detection**:
   ```csharp
   if (schema has ListNestedAttribute)
   {
       // Generate TerraformNestedAttribute-derived class
       // Use in List<T> properties with = assignment syntax
   }
   else if (schema has ListNestedBlock)
   {
       // Generate TerraformBlock-derived class
       // Use in List<T> properties with block syntax (no = operator)
       // Still widely used in AWS, Azure, GCP providers despite "legacy" label
   }
   ```

### Phase 3: Update Serialization

1. **During `Prepare()` - Access Internal Values**:

   ```csharp
   public override void Prepare(ITerraformContext context)
   {
       foreach (var (key, value) in _properties.GetOrderedProperties())
       {
           if (value is TerraformLiteralProperty<string> strProp)
           {
               var literalValue = strProp.GetValue();  // Internal method on TerraformLiteralProperty
               // Serialize literalValue to HCL
           }
           else if (value is TerraformLiteralProperty<List<string>> listProp)
           {
               var literalList = listProp.GetValue();  // Internal method on TerraformLiteralProperty
               // Serialize literalList to HCL
           }
           else if (value is TerraformExpressionProperty<string> exprProp)
           {
               var expr = exprProp.Resolve(context);  // Get expression
               // Serialize expression to HCL
           }
           // ... handle other types
       }
   }
   ```

2. **User Code - Works with Base Type**:

   ```csharp
   var instance = new AwsInstance("web", "main")
   {
       Ami = "ami-12345",  // Implicit conversion to TerraformLiteralProperty<string>
       SecurityGroups = new List<string> { "sg-1" }  // Implicit conversion to TerraformLiteralProperty<List<string>>
   };

   // User always gets base type:
   var amiRef = instance.Ami;  // TerraformProperty<string> (actual type: TerraformLiteralProperty)
   var sgRef = instance.SecurityGroups;  // TerraformProperty<List<string>> (actual type: TerraformLiteralProperty)

   // Use in other resources:
   var other = new AwsInstance("web2", "main")
   {
       Ami = instance.Ami,  // Reference to aws_instance.web.ami
       SecurityGroups = instance.SecurityGroups  // Reference to aws_instance.web.security_groups
   };

   // Advanced: Use expressions
   var advanced = new AwsInstance("web3", "main")
   {
       // Implicit conversion to TerraformExpressionProperty<string>
       Ami = TerraformExpression.FunctionCall("data.aws_ami.latest.id")
   };
   ```

## Implementation Plan

Since this library hasn't been released yet, we can implement this cleanly without migration concerns:

### Phase 1: Core Types

1. **Delete** old `TerraformPropertyCollection` and related infrastructure
2. **Implement** new type hierarchy:
   - `TerraformProperty<TValue>` - base class with indexers, `Resolve()`, implicit conversions
   - `TerraformLiteralProperty<TValue>` - stores literal values with `GetValue()`
   - `TerraformExpressionProperty<TValue>` - stores expressions, overrides `Resolve()`

### Phase 2: Code Generation

1. **Update schema parser** to detect Required/Optional/Computed patterns
2. **Update templates** to generate:
   - Arguments: `public TerraformProperty<T> PropertyName { get; set; }`
   - Computed-only: `public TerraformProperty<T> PropertyName => new(Address, "name");`
3. **Regenerate all provider code** (AWS, Azure, etc.)

### Phase 3: Serialization

1. **Update `TerraformConstruct.Prepare()`** to handle new property types:
   - `TerraformLiteralProperty<T>` → serialize via `GetValue()`
   - `TerraformExpressionProperty<T>` → serialize via `Resolve()`
   - Base `TerraformProperty<T>` (from other resources) → serialize via `Resolve()`
2. **Delete** old `TerraformValueResolver` complexity

### Phase 4: Testing

1. Create unit tests for type hierarchy
2. Test implicit conversions
3. Test indexer behavior
4. Test serialization of all property types
5. Validate generated HCL output

## Conclusion

The solution is a **type hierarchy with a single base type and implicit conversions**:

- **`TerraformProperty<TValue>`**: Base type used for ALL properties (getters and setters)
- **`TerraformLiteralProperty<TValue>`**: Subclass that stores literal values
- **`TerraformExpressionProperty<TValue>`**: Subclass that stores expressions

**Key Benefits**:

1. ✅ **Single base type** - `TerraformProperty<T>` used everywhere (simplifies getters/setters)
2. ✅ **Type safety** - computed attributes use read-only property (no setter)
3. ✅ **Ergonomic** - implicit conversions automatically select correct subclass
4. ✅ **Extensible** - easy to add new property types (e.g., `TerraformExpressionProperty<T>`)
5. ✅ **Internal access** - serialization uses `GetValue()` for literals, `Resolve()` for expressions
6. ✅ **Reference semantics** - indexers and nested access work correctly
7. ✅ **No user confusion** - users always work with base `TerraformProperty<T>` type
8. ✅ **Expression support** - can set properties using `TerraformExpression` for advanced scenarios

This approach properly models Terraform's behavior where:

- **Arguments**: Can be set (literal/expression) and referenced - uses `TerraformProperty<T>` with setter
- **Attributes**: Can only be referenced - uses `TerraformProperty<T>` without setter (read-only property)
- **Advanced usage**: Can use expressions via `TerraformExpressionProperty<T>` implicit conversion

The type system enforces the correct semantics while keeping the API simple and intuitive. Using the base type everywhere makes property declarations uniform and easy to work with.

## Block System Design

### Overview

Blocks can be implemented using the **existing property system** - blocks are just another type of `TerraformProperty`! We use marker interfaces for clean type checking.

### Key Insight

**Blocks are properties that wrap nested objects.** Just like we have:

- `TerraformProperty<string>` for string values
- `TerraformList<T>` for list collections
- `TerraformMap<T>` for map collections

We can have:

- `TerraformBlock<T>` for single nested blocks
- `TerraformBlockList<T>` for list of blocks (or just use `TerraformList<TerraformBlock<T>>`)
- `TerraformBlockSet<T>` for set of blocks (or just use `TerraformSet<TerraformBlock<T>>`)

### Design: Block as Property Type with Minimal Custom Interfaces

We leverage native .NET interfaces and only add minimal custom markers where needed:

**Custom Terraform Interfaces (minimal set):**

```csharp
/// <summary>
/// Marker interface for block properties.
/// Distinguishes blocks from regular attributes for serialization.
/// </summary>
public interface ITerraformBlock
{
    // Pure marker - serialization checks this to use block syntax (no = operator)
}

/// <summary>
/// Marker interface for expression properties.
/// Indicates property should be serialized via Resolve() rather than literal value.
/// </summary>
public interface ITerraformExpression
{
    // Pure marker - expressions use Resolve() from base TerraformProperty
}
```

**Collections Use Native .NET Interfaces:**

- `TerraformList<T>` implements `IList<T>`, `ICollection<T>`, `IEnumerable<T>`
- `TerraformSet<T>` implements `ISet<T>`, `ICollection<T>`, `IEnumerable<T>`
- `TerraformMap<T>` implements `IDictionary<string, T>`, `ICollection<KeyValuePair<string, T>>`, `IEnumerable<KeyValuePair<string, T>>`

**Why We Still Need Custom Collection Types:**

1. ✅ **Indexer returns reference** - `list[0]` must return `TerraformReferenceProperty<T>`, not `T`
2. ✅ **Reference tracking** - Need to track resource address for reference resolution
3. ✅ **Implicit conversions** - Smooth ergonomics from `List<T>` → `TerraformList<T>`
4. ✅ **Native interfaces** - Full LINQ support via standard collection interfaces

**Implementation:**

````csharp
/// <summary>
/// Represents a Terraform block - a nested configuration structure.
/// Serializes without the = operator (block syntax).
/// </summary>
public class TerraformBlock<TValue> : TerraformProperty<TValue>, ITerraformBlock
    where TValue : class, new()
{
    private TValue? _value;

    public TerraformBlock(string resourceAddress, string blockName)
        : base(resourceAddress, blockName)
    {
    }

    // Internal access for serialization
    internal TValue? GetValue() => _value;

    // Override Prepare to handle nested preparables
    public override void Prepare(ITerraformContext context)
    {
        if (_value is ITerraformPreparable preparable)
        {
            preparable.Prepare(context);
        }
    }

    // Implicit conversion from nested object
    public static implicit operator TerraformBlock<TValue>(TValue? value)
    {
        var block = new TerraformBlock<TValue>("", "");
        block._value = value;
        return block;
    }
}

### Generated Code Examples

#### Single Nested Block

```csharp
// Schema: schema.SingleNestedBlock
// Generated nested class (plain C# class, no special base)
public class AwsInstanceRootBlockDevice
{
    public TerraformProperty<int> VolumeSize { get; set; }
    public TerraformProperty<string> VolumeType { get; set; }
    public TerraformProperty<bool> DeleteOnTermination { get; set; }
}

public class AwsInstance : TerraformResource
{
    // Block property - type indicates it's a block!
    public TerraformBlock<AwsInstanceRootBlockDevice>? RootBlockDevice { get; set; }
}

// Usage:
var instance = new AwsInstance("web", "main")
{
    RootBlockDevice = new AwsInstanceRootBlockDevice  // Implicit conversion to TerraformBlock<T>
    {
        VolumeSize = 30,
        VolumeType = "gp3"
    }
};

// Serializes to:
// resource "aws_instance" "web" {
//   root_block_device {
//     volume_size          = 30
//     volume_type          = "gp3"
//   }
// }
````

#### List Nested Block

```csharp
// Schema: schema.ListNestedBlock
public class AwsInstanceEbsBlockDevice
{
    public TerraformProperty<string> DeviceName { get; set; }
    public TerraformProperty<int> VolumeSize { get; set; }
    public TerraformProperty<string> VolumeType { get; set; }
}

public class AwsInstance : TerraformResource
{
    // List of blocks - uses TerraformList to provide reference semantics
    // TerraformList<T> implements IList<T> for natural C# usage
    public TerraformList<AwsInstanceEbsBlockDevice>? EbsBlockDevice { get; set; }
}

// Usage:
var instance = new AwsInstance("web", "main")
{
    // Implicit conversion from List<T> to TerraformList<T>
    EbsBlockDevice = new List<AwsInstanceEbsBlockDevice>
    {
        new() { DeviceName = "/dev/sdf", VolumeSize = 100, VolumeType = "gp3" },
        new() { DeviceName = "/dev/sdg", VolumeSize = 200, VolumeType = "io1" }
    }
};

// Natural collection operations work because TerraformList implements IList<T>
instance.EbsBlockDevice.Add(new() { DeviceName = "/dev/sdh", VolumeSize = 50 });

// Serializes to:
// resource "aws_instance" "web" {
//   ebs_block_device {
//     device_name = "/dev/sdf"
//     volume_size = 100
//     volume_type = "gp3"
//   }
//   ebs_block_device {
//     device_name = "/dev/sdg"
//     volume_size = 200
//     volume_type = "io1"
//   }
//   ebs_block_device {
//     device_name = "/dev/sdh"
//     volume_size = 50
//   }
// }
```

#### Set Nested Block

```csharp
// Schema: schema.SetNestedBlock
public class AwsSecurityGroupIngress
{
    public TerraformProperty<string> Protocol { get; set; }
    public TerraformProperty<int> FromPort { get; set; }
    public TerraformProperty<int> ToPort { get; set; }
    public TerraformList<string> CidrBlocks { get; set; }
}

public class AwsSecurityGroup : TerraformResource
{
    // Set of blocks - uses TerraformSet to provide reference semantics
    // TerraformSet<T> implements ISet<T> for natural C# usage
    public TerraformSet<AwsSecurityGroupIngress>? Ingress { get; set; }
}

// Usage:
var sg = new AwsSecurityGroup("web", "main")
{
    // Implicit conversion from HashSet<T> to TerraformSet<T>
    Ingress = new HashSet<AwsSecurityGroupIngress>
    {
        new() { Protocol = "tcp", FromPort = 80, ToPort = 80, CidrBlocks = new() { "0.0.0.0/0" } },
        new() { Protocol = "tcp", FromPort = 443, ToPort = 443, CidrBlocks = new() { "0.0.0.0/0" } }
    }
};

// Natural set operations work because TerraformSet implements ISet<T>
sg.Ingress.Add(new() { Protocol = "tcp", FromPort = 22, ToPort = 22 });

// Serializes to:
// resource "aws_security_group" "web" {
//   ingress {
//     protocol    = "tcp"
//     from_port   = 80
//     to_port     = 80
//     cidr_blocks = ["0.0.0.0/0"]
//   }
//   ingress {
//     protocol    = "tcp"
//     from_port   = 443
//     to_port     = 443
//     cidr_blocks = ["0.0.0.0/0"]
//   }
//   ingress {
//     protocol    = "tcp"
//     from_port   = 22
//     to_port     = 22
//   }
// }
```

### Serialization Logic

**Key Insight from AWS CDK and Azure SDK:**

- **AWS CDK**: Uses `IResolvable.resolve()` - everything resolves to JSON-serializable values
- **Azure SDK**: Uses `IJsonModel<T>.Write()` - types serialize themselves
- **Both avoid reflection** by having a clear resolution/serialization contract

**Our Approach - Everything Resolves to `TerraformExpression`:**

We leverage the existing resolution chain:

1. `TerraformProperty<T>` → resolves to → `TerraformExpression`
2. `TerraformExpression` → serializes to → `string` (HCL output)

```csharp
/// <summary>
/// Interface for Terraform values that can be resolved to expressions.
/// </summary>
public interface ITerraformResolvable<out T>
{
    /// <summary>
    /// Resolve this value to a Terraform expression.
    /// </summary>
    T Resolve(ITerraformContext? context = null);
}

/// <summary>
/// Represents a Terraform expression that can be serialized to HCL.
/// Terminal node in the resolution chain - knows how to serialize to string.
/// </summary>
public abstract class TerraformExpression
{
    public abstract string ToHcl();

    public static TerraformExpression Literal(object value) => new LiteralExpression(value);
    public static TerraformExpression Identifier(string name) => new IdentifierExpression(name);
    public static TerraformExpression FunctionCall(string name, params TerraformExpression[] args)
        => new FunctionCallExpression(name, args);
    // ... other expression types
}

public class LiteralExpression : TerraformExpression
{
    private readonly object _value;

    public override string ToHcl()
    {
        return _value switch
        {
            string s => $"\"{s}\"",
            int i => i.ToString(),
            bool b => b.ToString().ToLower(),
            IEnumerable<TerraformExpression> list => $"[{string.Join(", ", list.Select(e => e.ToHcl()))}]",
            _ => _value.ToString()
        };
    }
}

public class IdentifierExpression : TerraformExpression
{
    private readonly string _identifier;

    public override string ToHcl() => _identifier;
}

public class FunctionCallExpression : TerraformExpression
{
    private readonly string _functionName;
    private readonly TerraformExpression[] _args;

    public override string ToHcl()
        => $"{_functionName}({string.Join(", ", _args.Select(a => a.ToHcl()))})";
}

/// <summary>
/// Implementation in TerraformProperty types.
/// Everything resolves to TerraformExpression.
/// The context handles formatting, indentation, and final HCL output.
/// </summary>
public class TerraformProperty<TValue> : ITerraformResolvable<TerraformExpression>
{
    protected readonly string _resourceAddress;
    protected readonly string _attributeName;

    public virtual TerraformExpression Resolve(ITerraformContext? context = null)
    {
        // Base implementation - resolve to reference expression
        return TerraformExpression.Identifier($"{_resourceAddress}.{_attributeName}");
    }
}

public class TerraformLiteralProperty<TValue> : TerraformProperty<TValue>
{
    private TValue? _value;

    public override TerraformExpression Resolve(ITerraformContext? context = null)
    {
        if (_value is null)
        {
            return TerraformExpression.Literal(null);
        }

        // Resolve literal value to expression
        return TerraformExpression.Literal(_value);
    }
}

public class TerraformList<TValue> : TerraformProperty<IList<TerraformProperty<TValue>>>,
    IList<TerraformProperty<TValue>>
{
    private readonly List<TerraformProperty<TValue>> _items = new();

    public override TerraformExpression Resolve(ITerraformContext? context = null)
    {
        // Resolve to list expression
        var resolvedItems = _items.Select(item => item.Resolve(context)).ToList();
        return TerraformExpression.List(resolvedItems);
    }
}

public class TerraformBlock<TValue> : TerraformProperty<TValue>, ITerraformBlock
    where TValue : class, ITerraformResolvable<TerraformExpression>, new()
{
    private TValue? _value;

    public override TerraformExpression Resolve(ITerraformContext? context = null)
    {
        if (_value is null)
        {
            return TerraformExpression.Literal(null);
        }

        // Blocks resolve to their nested object's expression
        // The nested object knows how to resolve its properties
        return _value.Resolve(context);
    }
}
```

---

## Document Revision History

### November 10, 2025 - Architecture Review & Improvements

Based on comparison with AWS CDK and Azure SDK for .NET patterns, the following improvements were made to the base type architecture:

#### ✅ **Issues Fixed:**

1. **`TerraformLiteralProperty<T>` Value Access**
   - **Problem**: Value was only accessible via explicit interface implementation, no public setter
   - **Fix**: Added public `Value` property with internal setter for proper mutability
   - **Impact**: Enables proper value assignment and retrieval

2. **`TerraformReferenceProperty<T>` Syntax Errors**
   - **Problem**: Duplicate class declaration and malformed if statement
   - **Fix**: Removed duplicate declaration, fixed conditional logic
   - **Impact**: Code now compiles correctly

3. **Collection Indexer Behavior Documentation**
   - **Problem**: Unclear that indexers create new reference instances on each access
   - **Fix**: Added comprehensive XML documentation with examples and caching guidance
   - **Impact**: Developers understand performance implications and caching strategies

#### ✅ **Enhancements Added:**

4. **Usage Pattern Documentation**
   - Added Pattern 1: Arguments (configurable properties)
   - Added Pattern 2: Attributes (computed-only properties)
   - Added Pattern 3: Collection properties with indexing
   - Added Pattern 4: Conditional expressions
   - Added Pattern 5: Function calls

5. **Advanced Expression Support**
   - Added `TerraformConditionalProperty<T>` for ternary expressions
   - Added `TerraformFunctionProperty<T>` for Terraform function calls
   - Enables: `condition ? value1 : value2` and `merge(map1, map2)` patterns

6. **Architecture Comparison**
   - Documented trade-offs: Collection-of-Properties vs Property-of-Collection
   - Compared with AWS CDK's Token/Lazy system
   - Compared with Azure SDK's simpler REST model
   - Justified design decisions specific to Terraform's expression DSL

#### 📋 **Key Insights:**

- **AWS CDK Pattern Match**: Lazy resolution via `Resolve()` mirrors CDK's `IResolvable.resolve()`
- **Azure SDK Difference**: Azure uses simpler plain CLR types because REST APIs don't need expression semantics
- **Design Validation**: Current approach is correct for Terraform's unique requirements (expressions, references, deferred resolution)
- **Performance Consideration**: Indexer creates new instances - cache frequently accessed references

#### 🎯 **Remaining Work:**

1. Implement reference caching mechanism if performance testing shows need
2. Build fluent API for complex expression composition
3. Document serialization pipeline (`Prepare()` → `Resolve()` → HCL generation)
4. Add code generator support for distinguishing Arguments vs Attributes
5. Test cross-resource reference scenarios extensively

The architecture is fundamentally sound and follows proven patterns from successful IaC SDKs while adapting appropriately to Terraform's specific requirements.

/// <summary>
/// Generated nested block classes resolve to object expressions.
/// </summary>
public class AwsInstanceRootBlockDevice : ITerraformResolvable<TerraformExpression>
{
    public TerraformProperty<int> VolumeSize { get; set; }
    public TerraformProperty<string> VolumeType { get; set; }
    public TerraformProperty<bool> DeleteOnTermination { get; set; }

    public TerraformExpression Resolve(ITerraformContext? context = null)
    {
        // Resolve to an object expression containing all properties
        var properties = new Dictionary<string, TerraformExpression>();

        if (VolumeSize is not null)
        {
            properties["volume_size"] = VolumeSize.Resolve(context);
        }
        if (VolumeType is not null)
        {
            properties["volume_type"] = VolumeType.Resolve(context);
        }
        if (DeleteOnTermination is not null)
        {
            properties["delete_on_termination"] = DeleteOnTermination.Resolve(context);
        }

        return TerraformExpression.Object(properties);
    }
}

/// <summary>
/// Resources resolve to their complete structure.
/// </summary>
public class AwsInstance : TerraformResource, ITerraformResolvable<TerraformExpression>
{
    public TerraformProperty<string> Ami { get; set; }
    public TerraformList<string> SecurityGroups { get; set; }
    public TerraformBlock<AwsInstanceRootBlockDevice>? RootBlockDevice { get; set; }

    public TerraformExpression Resolve(ITerraformContext? context = null)
    {
        // Resource resolves to its complete configuration as an object expression
        var properties = new Dictionary<string, TerraformExpression>();

        if (Ami is not null)
        {
            properties["ami"] = Ami.Resolve(context);
        }
        if (SecurityGroups is not null)
        {
            properties["security_groups"] = SecurityGroups.Resolve(context);
        }
        if (RootBlockDevice is not null)
        {
            properties["root_block_device"] = RootBlockDevice.Resolve(context);
        }

        return TerraformExpression.Resource("aws_instance", Name, properties);
    }
}
```

**Benefits of Expression-Based Resolution:**

1. ✅ **No reflection** - everything resolves through `Resolve()` chain
2. ✅ **Single serialization point** - only `TerraformExpression.ToHcl()` produces strings
3. ✅ **Type-safe** - compiler ensures all types implement `ITerraformResolvable<TerraformExpression>`
4. ✅ **Composable** - expressions can contain other expressions
5. ✅ **Testable** - can test resolution at any level
6. ✅ **Industry standard** - matches AWS CDK's token resolution pattern
7. ✅ **Performance** - no reflection, single-pass resolution
8. ✅ **Code generation friendly** - generator emits `Resolve()` implementation for each class
9. ✅ **Clean separation** - resolution logic separate from serialization logic

**Code Generation Pattern:**

```csharp
// For each resource/nested block class, generate Resolve method:
public TerraformExpression Resolve(ITerraformContext? context = null)
{
    var properties = new Dictionary<string, TerraformExpression>();

{{#each properties}}
    if ({{PropertyName}} is not null)
    {
        properties["{{attribute_name}}"] = {{PropertyName}}.Resolve(context);
    }
{{/each}}

    return TerraformExpression.Object(properties);
}
```

**Serialization Flow:**

```
User Code
    ↓
TerraformResource.Resolve()
    ↓
Dictionary<string, TerraformExpression>
    ↓
TerraformExpression.Object(properties)
    ↓
TerraformExpression.ToHcl()
    ↓
HCL String Output
```

No reflection needed - everything follows the resolution chain!

### Reference Semantics for Blocks

Blocks support the same reference semantics as other properties:

```csharp
var instance = new AwsInstance("web", "main")
{
    EbsBlockDevice = new TerraformList<TerraformBlock<AwsInstanceEbsBlockDevice>>("aws_instance.web", "ebs_block_device")
    {
        new AwsInstanceEbsBlockDevice { DeviceName = "/dev/sdf", VolumeSize = 100 }
    }
};

// Access block via indexer - returns TerraformReferenceProperty
var firstBlock = instance.EbsBlockDevice[0];
// Type: TerraformReferenceProperty<TerraformBlock<AwsInstanceEbsBlockDevice>>

// To access nested properties, we'd need to "unwrap" the block
// This could be done via code generation or dynamic access patterns

// Use entire block collection in another resource
var template = new AwsLaunchTemplate("web", "main")
{
    BlockDeviceMappings = instance.EbsBlockDevice  // Reference to entire list
};
```

### Nested Blocks (Blocks within Blocks)

```csharp
public class AwsLaunchTemplateBlockDeviceMapping
{
    public TerraformProperty<string> DeviceName { get; set; }

    // Nested block within a block!
    public TerraformBlock<AwsLaunchTemplateEbs>? Ebs { get; set; }
}

public class AwsLaunchTemplateEbs
{
    public TerraformProperty<int> VolumeSize { get; set; }
    public TerraformProperty<string> VolumeType { get; set; }
}

public class AwsLaunchTemplate : TerraformResource
{
    public TerraformList<TerraformBlock<AwsLaunchTemplateBlockDeviceMapping>>? BlockDeviceMappings { get; set; }
}

// Usage:
var template = new AwsLaunchTemplate("web", "main")
{
    BlockDeviceMappings = new TerraformList<TerraformBlock<AwsLaunchTemplateBlockDeviceMapping>>("", "")
    {
        new AwsLaunchTemplateBlockDeviceMapping
        {
            DeviceName = "/dev/sdf",
            Ebs = new AwsLaunchTemplateEbs
            {
                VolumeSize = 100,
                VolumeType = "gp3"
            }
        }
    }
};

// Serializes to:
// resource "aws_launch_template" "web" {
//   block_device_mappings {
//     device_name = "/dev/sdf"
//     ebs {
//       volume_size = 100
//       volume_type = "gp3"
//     }
//   }
// }
```

### Benefits of This Approach

1. ✅ **Type-based detection** - `TerraformBlock<T>` type tells serializer to use block syntax
2. ✅ **No metadata tracking** - no `MarkAsBlock()`, no dictionaries to maintain
3. ✅ **No marker interfaces** - nested classes are plain C# classes
4. ✅ **Reuses existing collections** - `TerraformList<TerraformBlock<T>>` for list of blocks
5. ✅ **Consistent pattern** - blocks are just another property type like `TerraformList`, `TerraformMap`
6. ✅ **Type safety** - generic parameter ensures type of nested object
7. ✅ **Natural C# syntax** - implicit conversion makes usage clean
8. ✅ **Serializer knows what to do** - type inspection determines serialization strategy

### Comparison: Block vs Nested Attribute

```csharp
// NESTED ATTRIBUTE (schema.ListNestedAttribute)
// Uses TerraformList<T> directly (no TerraformBlock wrapper)
public class AwsSecurityGroupRule
{
    public TerraformProperty<string> Protocol { get; set; }
}
public TerraformList<AwsSecurityGroupRule> IngressRules { get; set; }

// Serializes to (with = operator):
// ingress_rules = [
//   { protocol = "tcp", from_port = 80 },
//   { protocol = "tcp", from_port = 443 }
// ]

// BLOCK (schema.ListNestedBlock)
// Uses TerraformList<TerraformBlock<T>> (wrapped in TerraformBlock)
public class AwsSecurityGroupIngress
{
    public TerraformProperty<string> Protocol { get; set; }
}
public TerraformList<TerraformBlock<AwsSecurityGroupIngress>> Ingress { get; set; }

// Serializes to (no = operator, repeated blocks):
// ingress {
//   protocol  = "tcp"
//   from_port = 80
// }
// ingress {
//   protocol  = "tcp"
//   from_port = 443
// }
```

### Summary

Blocks are **solved as a property type**:

- ✅ `TerraformBlock<T>` wraps nested objects
- ✅ Type inspection determines serialization (block vs attribute syntax)
- ✅ No metadata, no marker interfaces needed
- ✅ `TerraformList<TerraformBlock<T>>` for list of blocks
- ✅ `TerraformSet<TerraformBlock<T>>` for set of blocks
- ✅ Nested blocks work via `TerraformBlock<T>` properties within nested classes
- ✅ Completely consistent with existing property type pattern!
