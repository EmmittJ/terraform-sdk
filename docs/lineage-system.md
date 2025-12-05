# Unified Lineage System

## Overview

The Lineage System is a fundamental redesign of how terraform-sdk tracks the origin and path of values within a Terraform configuration. Instead of scattered parent tracking (`ParentBlock`, `ParentAttributeName`) and explicit reference creation (`.Ref()`), every value carries an immutable lineage that describes exactly where it came from.

## Design Goals

1. **Natural Syntax**: Enable `containerApp.Ingress[0].Fqdn` to work naturally without ceremony
2. **Eliminate AsReference()**: Values automatically know if they should emit as references
3. **Immutable Paths**: Lineage is immutable - extending creates a new lineage
4. **Stack as Root**: All lineages start from `TerraformStack` - the universal parent
5. **Single Source of Truth**: Lineage replaces `ParentBlock`, `ParentAttributeName`, and `TerraformReference<T>`

## Core Types

### TerraformLineage

An immutable record that tracks where a value came from:

```csharp
public sealed record TerraformLineage(
    TerraformStack Stack,
    ImmutableArray<TerraformPathSegment> Path)
{
    // Extend the path with a new segment
    public TerraformLineage WithMember(string name) =>
        this with { Path = Path.Add(new MemberSegment(name)) };

    public TerraformLineage WithIndex(int index) =>
        this with { Path = Path.Add(new IndexSegment(index)) };

    public TerraformLineage WithKey(string key) =>
        this with { Path = Path.Add(new KeySegment(key)) };

    // Build the HCL reference expression
    public TerraformExpression BuildExpression() { ... }
}
```

### TerraformPathSegment

Abstract record with concrete segment types:

```csharp
public abstract record TerraformPathSegment
{
    // Renders to HCL syntax
    public abstract string ToHcl();
}

// First segment: "aws_vpc", "var", "local", "data.aws_ami"
public sealed record IdentifierSegment(string Identifier) : TerraformPathSegment
{
    public override string ToHcl() => Identifier;
}

// Dot access: .id, .tags, .ingress
public sealed record MemberSegment(string Name) : TerraformPathSegment
{
    public override string ToHcl() => $".{Name}";
}

// Numeric index: [0], [1]
public sealed record IndexSegment(int Index) : TerraformPathSegment
{
    public override string ToHcl() => $"[{Index}]";
}

// String key: ["key"], ["us-west-2"]
public sealed record KeySegment(string Key) : TerraformPathSegment
{
    public override string ToHcl() => $"[\"{Key}\"]";
}
```

## Lineage Flow

### 1. Block Added to Stack

When a block is added to a `TerraformStack`, it receives its initial lineage:

```csharp
// TerraformStack.Add()
public T Add<T>(T block) where T : TerraformBlock
{
    // Set initial lineage: aws_vpc.main
    block.Lineage = new TerraformLineage(this, [
        new IdentifierSegment($"{block.BlockType}.{block.ResourceName}")
    ]);
    _blocks.Add(block);
    return block;
}
```

### 2. Accessing Properties

Property getters return values with extended lineage:

```csharp
// Generated property getter (from mustache template)
public TerraformValue<string> Id
{
    get
    {
        var value = GetArgument<TerraformValue<string>>("id");
        // Extend lineage: aws_vpc.main.id
        return value?.WithLineage(Lineage?.WithMember("id"));
    }
}
```

### 3. Accessing List Elements

List indexers extend lineage with the index:

```csharp
// TerraformList<T> indexer
public T this[int index]
{
    get
    {
        var item = _items[index];
        // Extend lineage: aws_vpc.main.ingress[0]
        return item.WithLineage(Lineage?.WithIndex(index));
    }
}
```

### 4. Resolution

When a value with lineage is resolved, it emits a reference expression:

```csharp
// TerraformValue<T>.ResolveNodes()
public override IEnumerable<TerraformExpression> ResolveNodes(ITerraformContext context)
{
    if (Lineage is not null)
    {
        // Emit as reference: aws_vpc.main.id
        yield return Lineage.BuildExpression();
    }
    else
    {
        // Emit as literal
        yield return TerraformExpression.Literal(_value);
    }
}
```

## Example Usage

### Before (Current System)

```csharp
var vpc = stack.Add(new AwsVpc("main"));

// Lots of ceremony to create references
var vpcIdRef = vpc.Ref("id");  // or vpc["id"]
var ingressRef = vpc.Ingress.Index(0, x => x.Fqdn);

// Assign to another resource
subnet["vpc_id"] = vpcIdRef;
```

### After (Lineage System)

```csharp
var vpc = stack.Add(new AwsVpc("main"));
// vpc.Lineage = TerraformLineage(stack, [IdentifierSegment("aws_vpc.main")])

// Natural property access - lineage flows automatically
var vpcId = vpc.Id;
// vpcId.Lineage = TerraformLineage(stack, [IdentifierSegment("aws_vpc.main"), MemberSegment("id")])

var fqdn = vpc.Ingress[0].Fqdn;
// fqdn.Lineage = TerraformLineage(stack, [
//     IdentifierSegment("aws_vpc.main"),
//     MemberSegment("ingress"),
//     IndexSegment(0),
//     MemberSegment("fqdn")
// ])

// Direct assignment - value knows it's a reference
subnet["vpc_id"] = vpcId;  // Resolves to: aws_vpc.main.id
```

## Implementation Plan

### Phase 1: Core Infrastructure

**TerraformValue<T>** - Add lineage support:

- Add `Lineage` property (get/set)
- Update `ResolveNodes()` to emit reference expression when lineaged
- Add `WithLineage()` method to create a copy with lineage set

### Phase 2: TerraformBlock Updates

**TerraformBlock** - Central lineage management:

- Add `Lineage` property (inherited from TerraformValue via TerraformMap)
- Add `ReferenceIdentifier` virtual property (e.g., "aws_vpc.main", "var.region")
- Add `CreateReference(string attributeName)` helper for generated property getters
- Remove `ITerraformHasParent`, `ITerraformReferenceable` interfaces
- Remove `ParentBlock`, `ParentAttributeName` properties
- Remove `AsReference()` methods

### Phase 3: Block Type ReferenceIdentifiers

Each block type overrides `ReferenceIdentifier`:

- `TerraformResource` → `{ResourceType}.{ResourceName}` (e.g., "aws_vpc.main")
- `TerraformDataSource` → `data.{DataSourceType}.{DataSourceName}` (e.g., "data.aws_ami.ubuntu")
- `TerraformVariable` → `var.{Name}` (e.g., "var.region")
- `TerraformLocals` → `local` (then member access for each local)
- `TerraformModule` → `module.{Name}` (e.g., "module.vpc")
- `TerraformOutput` → `output.{Name}` (rarely referenced directly)
- `TerraformProvider` → provider reference
- `TerraformEphemeralResource` → `ephemeral.{ResourceType}.{ResourceName}`

### Phase 4: Stack Sets Lineage

**TerraformStack.Add()** - Initialize lineage:

```csharp
public T Add<T>(T block) where T : TerraformBlock
{
    block.Lineage = new TerraformLineage(this, block.ReferenceIdentifier);
    _blocks.Add(block);
    return block;
}
```

### Phase 5: Template Updates

**\_argument.mustache** - Generated property getters use lineage:

- Computed attributes: `get => CreateReference("{{TerraformName}}")`
- Optional+computed: `get => GetArgument<T>("name") ?? CreateReference("name")`

### Phase 6: Cleanup

Delete obsolete types:

- `TerraformReference<T>` - replaced by lineaged values
- `TerraformIndexedBlockReference` - replaced by lineage indexing
- `ITerraformHasParent` - replaced by Lineage property
- `ITerraformReferenceable` - replaced by ReferenceIdentifier
- `TerraformReferenceExpression` - if unused
- Parent tracking in `TerraformMap.SetArgument()` and `TerraformList`

### Phase 7: Test Updates

Update tests to use new patterns:

- Replace `resource.AsReference("id")` with `resource["id"]` (returns lineaged value)
- For base `TerraformResource` is a `TerraformBlock`, so `resource["id"]` works directly.

## Key Insight: TerraformMap Already Stores Lineaged Values

Since `TerraformMap<T>` stores `TerraformValue<T>` objects, and `TerraformValue<T>` carries lineage, no special indexer logic is needed. When a lineaged value is stored and later resolved, it automatically emits as a reference.

## HCL Output Examples

| Lineage Path                                                                                                              | HCL Output                                       |
| ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------ |
| `[IdentifierSegment("aws_vpc.main")]`                                                                                     | `aws_vpc.main`                                   |
| `[IdentifierSegment("aws_vpc.main"), MemberSegment("id")]`                                                                | `aws_vpc.main.id`                                |
| `[IdentifierSegment("var"), MemberSegment("region")]`                                                                     | `var.region`                                     |
| `[IdentifierSegment("aws_instance.web"), MemberSegment("ebs_block_device"), IndexSegment(0), MemberSegment("volume_id")]` | `aws_instance.web.ebs_block_device[0].volume_id` |
| `[IdentifierSegment("local"), MemberSegment("tags"), KeySegment("Environment")]`                                          | `local.tags["Environment"]`                      |

## Benefits

1. **Zero Ceremony**: No `.Ref()`, no `["prop"]` syntax required
2. **Type Safety**: Lineage carries through the type system
3. **Immutability**: Thread-safe, no mutation surprises
4. **Debuggability**: Full path visible in debugger
5. **Simplicity**: One concept replaces three (`ParentBlock`, `ParentAttributeName`, `TerraformReference<T>`)
