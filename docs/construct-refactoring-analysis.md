# TerraformConstruct Refactoring Analysis

## Question

With the new `TerraformBlock` design (inheriting from `TerraformMap<object>`), do we still need `TerraformConstruct`? Can everything just be blocks/values?

**Current Date:** November 11, 2025

---

## Current Architecture

```
TerraformConstruct (abstract)
├── Property storage (_propertyValues dictionary)
├── HCL serialization (ToHcl, WriteProperties)
├── Reference generation (AsReference)
└── Subclasses:
    ├── NamedTerraformConstruct
    │   └── TerraformProvider
    ├── TerraformOutput
    ├── TerraformVariable
    └── TerraformProvisionableConstruct (abstract)
        ├── TerraformResource
        ├── TerraformDataSource
        └── TerraformEphemeralResource
```

---

## Analysis: Can We Eliminate TerraformConstruct?

### ❌ **NO - TerraformConstruct Serves Different Purposes**

While `TerraformBlock` and `TerraformConstruct` both have property storage, they serve **fundamentally different roles**:

| Aspect                | TerraformBlock                               | TerraformConstruct                                               |
| --------------------- | -------------------------------------------- | ---------------------------------------------------------------- |
| **Purpose**           | Nested configuration objects                 | Top-level Terraform blocks                                       |
| **Serialization**     | Maps to HCL map expression `{ key = value }` | Full block with type and labels `resource "type" "name" { ... }` |
| **Has Block Type**    | No                                           | Yes (`resource`, `data`, `output`, `variable`, `provider`)       |
| **Has Labels**        | No                                           | Yes (resource type/name, variable name, etc.)                    |
| **Resolvable**        | Yes (to TerraformExpression)                 | No (serializes to HCL string directly)                           |
| **Can be referenced** | Via parent construct                         | Yes (`AsReference()` method)                                     |
| **Meta-arguments**    | No                                           | Yes (count, for_each, depends_on, lifecycle, etc.)               |

---

## Key Differences

### 1. **HCL Structure**

**TerraformBlock** (nested configuration):

```hcl
timeouts {
  read = "5m"
  create = "10m"
}
```

→ This is a **nested block** inside a resource, serialized as a map

**TerraformConstruct** (top-level block):

```hcl
resource "azurerm_postgresql_flexible_server_database" "appdb" {
  name      = "appdb"
  server_id = azurerm_postgresql_flexible_server.postgres-server.id

  timeouts {
    read = "5m"
  }
}
```

→ This is a **complete Terraform block** with type, labels, and body

### 2. **Serialization Methods**

**TerraformBlock:**

```csharp
// Resolves to TerraformExpression (MapExpression)
public override TerraformExpression Resolve(ITerraformResolveContext context)
{
    // Returns MapExpression with key-value pairs
}
```

**TerraformConstruct:**

```csharp
// Serializes directly to HCL string with block structure
public virtual string ToHcl(ITerraformContext? context = null)
{
    // Outputs: resource "type" "name" { properties... }
}
```

### 3. **Reference Generation**

**TerraformBlock:**

- No direct references
- Accessed via parent construct: `resource.timeouts.read`
- Not independently addressable in Terraform

**TerraformConstruct:**

- Implements `AsReference()` method
- Generates Terraform identifiers:
  - Resources: `azurerm_postgresql_flexible_server.my_server`
  - Variables: `var.admin_password`
  - Outputs: `output.connection_string`
  - Data sources: `data.azurerm_resource_group.existing`

### 4. **Meta-Arguments**

**TerraformBlock:**

- No meta-arguments
- Just properties defined in the block schema

**TerraformConstruct (via TerraformProvisionableConstruct):**

- `count` - Create multiple instances
- `for_each` - Iterate over a collection
- `depends_on` - Explicit dependencies
- `provider` - Provider configuration
- `lifecycle` - Lifecycle rules (create_before_destroy, etc.)
- `dynamic` blocks - Conditional nested blocks

---

## Concrete Examples

### Example 1: TerraformResource (Construct)

```csharp
var database = new AzurermPostgresqlFlexibleServerDatabase("appdb")
{
    Name = "appdb",
    ServerId = server.Id,

    // Nested block (TerraformBlock)
    Timeouts = new AzurermPostgresqlFlexibleServerDatabaseTimeoutsBlock
    {
        Read = "5m"
    },

    // Meta-argument (only on constructs)
    Count = 3,
    DependsOn = { "azurerm_postgresql_flexible_server.postgres" }
};

// Reference generation (only on constructs)
var ref = database.AsReference();  // → "azurerm_postgresql_flexible_server_database.appdb"
```

**HCL Output:**

```hcl
resource "azurerm_postgresql_flexible_server_database" "appdb" {
  name      = "appdb"
  server_id = azurerm_postgresql_flexible_server.postgres.id
  count     = 3
  depends_on = [azurerm_postgresql_flexible_server.postgres]

  timeouts {
    read = "5m"
  }
}
```

### Example 2: TerraformOutput (Construct)

```csharp
var output = new TerraformOutput("database_connection")
{
    Value = database.Id,
    Description = "PostgreSQL database ID",
    Sensitive = true
};

// Reference
var ref = output.AsReference();  // → "output.database_connection"
```

**HCL Output:**

```hcl
output "database_connection" {
  value       = azurerm_postgresql_flexible_server_database.appdb.id
  description = "PostgreSQL database ID"
  sensitive   = true
}
```

### Example 3: TerraformVariable (Construct)

```csharp
var passwordVar = new TerraformVariable("admin_password")
{
    Type = "string",
    Description = "Administrator password",
    Sensitive = true
};

// Reference
var ref = passwordVar.AsReference();  // → "var.admin_password"
```

**HCL Output:**

```hcl
variable "admin_password" {
  type        = string
  description = "Administrator password"
  sensitive   = true
}
```

---

## What TerraformConstruct Provides That Blocks Don't

### 1. **Block Type & Labels**

```csharp
public abstract class TerraformConstruct
{
    public abstract string BlockType { get; }           // "resource", "output", "variable", etc.
    protected abstract string[] BlockLabels { get; }    // ["type", "name"] or ["name"]
}
```

Blocks don't have this - they're just nested configuration objects.

### 2. **Top-Level Serialization**

```csharp
public virtual string ToHcl(ITerraformContext? context = null)
{
    // Generates: blockType "label1" "label2" { ... }
}
```

Blocks use `Resolve()` to create expressions, not full HCL blocks.

### 3. **Reference Infrastructure**

```csharp
public abstract TerraformExpression AsReference();
```

Each construct type generates appropriate Terraform references:

- `resource.type.name`
- `var.name`
- `output.name`
- `data.type.name`

### 4. **Meta-Arguments (for provisionable constructs)**

```csharp
public abstract class TerraformProvisionableConstruct
{
    public TerraformValue<TerraformExpression>? Count { get; set; }
    public TerraformValue<TerraformExpression>? ForEach { get; set; }
    public List<string> DependsOn { get; }
    public string? Provider { get; set; }
    public TerraformLifecycleConfig? Lifecycle { get; set; }
    public List<TerraformDynamicBlock> DynamicBlocks { get; }
}
```

Blocks don't have meta-arguments - they're just data containers.

---

## Could We Merge Them?

### Option 1: Make TerraformConstruct inherit from TerraformBlock

❌ **Doesn't make sense semantically:**

- Constructs are NOT blocks (they don't resolve to map expressions)
- Constructs serialize to full HCL blocks with type/labels
- Blocks serialize to map expressions for nested configuration

### Option 2: Make TerraformBlock inherit from TerraformConstruct

❌ **Creates wrong relationship:**

- Blocks are nested objects, not top-level constructs
- Blocks don't need `BlockType`, `BlockLabels`, `AsReference()`
- Blocks shouldn't have access to construct infrastructure

### Option 3: Extract common base class

```
PropertyStorageBase (abstract)
├── Protected: SetPropertyValue, GetPropertyValue
└── Subclasses:
    ├── TerraformBlock (inherits from TerraformMap<object>)
    └── TerraformConstruct
```

⚠️ **Problem:** `TerraformBlock` already inherits from `TerraformMap<object>`

- C# doesn't support multiple inheritance
- Would need to use composition instead of inheritance
- Loses benefits of `TerraformMap<object>` infrastructure

---

## Recommendation: Keep Both, But Refine Roles

### ✅ **TerraformConstruct** - Top-level Terraform blocks

**Purpose:** Represents complete Terraform constructs that appear at the root level of `.tf` files

**Responsibilities:**

- Property storage (via `_propertyValues`)
- Block type & label management
- Full HCL serialization (`blockType "labels" { ... }`)
- Reference generation (`AsReference()`)
- Meta-arguments (for resources/data sources)
- Stack registration (add to `TerraformStack`)

**Examples:**

- `TerraformResource` → `resource "type" "name" { ... }`
- `TerraformDataSource` → `data "type" "name" { ... }`
- `TerraformOutput` → `output "name" { ... }`
- `TerraformVariable` → `variable "name" { ... }`
- `TerraformProvider` → `provider "name" { ... }`
- `TerraformModule` → `module "name" { ... }`
- `TerraformLocals` → `locals { ... }`

### ✅ **TerraformBlock** - Nested configuration objects

**Purpose:** Represents nested configuration blocks within resources/data sources

**Responsibilities:**

- Property storage (via inherited `TerraformMap<object>._elements`)
- Resolution to map expressions (via inherited `Resolve()`)
- Property accessor methods for source generator
- Used as property types in resources

**Examples:**

- `TimeoutsBlock` → `timeouts { read = "5m" }`
- `TemplateBlock` → `template { container { ... } }`
- `IngressBlock` → `ingress { from_port = 80 }`

---

## Architecture Clarification

```
Property Storage Pattern:
─────────────────────────

TerraformMap<T>                    TerraformConstruct
└── _elements: Dict<string,        └── _propertyValues: Dict<string,
    TerraformValue<T>>                  object?>
    ↑                                   ↑
    │ inherits                          │ inherits
    │                                   │
TerraformBlock                     TerraformResource
└── Adds property                  TerraformDataSource
    accessor methods               TerraformOutput
    (SetPropertyValue,             TerraformVariable
     GetPropertyValue)             TerraformProvider
                                   etc.

DIFFERENT PURPOSES:
- TerraformBlock: Nested config (resolves to expressions)
- TerraformConstruct: Top-level blocks (serialize to HCL)
```

---

## Potential Optimization: Shared Property Storage Base

If we want to reduce duplication of property accessor methods, we could extract them:

```csharp
/// <summary>
/// Provides property storage infrastructure via dictionary.
/// Used by both blocks (nested) and constructs (top-level).
/// </summary>
public interface IPropertyStorage
{
    protected void SetPropertyValue(string name, object? value);
    protected T? GetPropertyValue<T>(string name);
    protected T GetRequiredPropertyValue<T>(string name);
}
```

**But:**

- C# doesn't allow `protected` members in interfaces (until C# 12)
- Would need to be abstract class, creating multiple inheritance issues
- Current duplication is minimal (3 methods, well-tested)
- Not worth the complexity for ~30 lines of duplicated code

---

## Conclusion

### ✅ **Keep TerraformConstruct**

**Why:**

1. Serves fundamentally different purpose than `TerraformBlock`
2. Provides top-level block serialization with type/labels
3. Manages meta-arguments (count, for_each, depends_on, etc.)
4. Handles reference generation (`AsReference()`)
5. Represents complete Terraform constructs, not nested config

### ✅ **Keep TerraformBlock**

**Why:**

1. Inherits from `TerraformMap<object>` for efficient storage/resolution
2. Represents nested configuration objects
3. Integrates perfectly with existing value system
4. Minimal code (just property accessors)

### ✅ **Accept Minor Duplication**

**Why:**

1. Property accessor methods (~30 lines) duplicated between:
   - `TerraformConstruct._propertyValues`
   - `TerraformBlock` (via `TerraformMap._elements`)
2. Different storage mechanisms (dictionary vs inherited map)
3. Complexity of extracting to shared base outweighs duplication cost
4. Clear separation of concerns is more valuable than DRY here

---

## Summary Table

| Feature               | TerraformBlock                      | TerraformConstruct                     |
| --------------------- | ----------------------------------- | -------------------------------------- |
| **Used for**          | Nested configuration                | Top-level blocks                       |
| **Inherits from**     | `TerraformMap<object>`              | None (base class)                      |
| **Storage**           | `_elements` (inherited)             | `_propertyValues`                      |
| **Serialization**     | `Resolve()` → `TerraformExpression` | `ToHcl()` → HCL string                 |
| **Has block type**    | No                                  | Yes                                    |
| **Has labels**        | No                                  | Yes                                    |
| **Can be referenced** | Via parent                          | Yes (`AsReference()`)                  |
| **Meta-arguments**    | No                                  | Yes (resources/data)                   |
| **Examples**          | `TimeoutsBlock`, `IngressBlock`     | `TerraformResource`, `TerraformOutput` |

---

## UPDATE: Could Constructs Just Produce Expressions?

### The Question

Since `TerraformMapExpression` can already serialize to HCL maps, and there's even a `TerraformBlockExpression` for nested blocks, couldn't constructs just produce expressions instead of having custom `ToHcl()` methods?

### The Missing Piece: Top-Level Block Structure

**Problem:** We need expressions like this:

```hcl
resource "azurerm_postgresql_database" "appdb" {
  name = "mydb"
}
```

But `TerraformMapExpression` produces:

```hcl
{
  name = "mydb"
}
```

**What's missing:** The `resource "type" "name"` header!

### Possible Solution: Create `TerraformConstructExpression`

```csharp
/// <summary>
/// Represents a complete Terraform construct with block type, labels, and body.
/// Example: resource "aws_vpc" "main" { cidr_block = "10.0.0.0/16" }
/// </summary>
public class TerraformConstructExpression : TerraformExpression
{
    private readonly string _blockType;
    private readonly string[] _labels;
    private readonly TerraformMapExpression _body;

    public TerraformConstructExpression(string blockType, string[] labels, TerraformMapExpression body)
    {
        _blockType = blockType;
        _labels = labels;
        _body = body;
    }

    public override string ToHcl(ITerraformContext? context = null)
    {
        context ??= TerraformContext.Temporary(this);

        var sb = new StringBuilder();

        // Build header: resource "type" "name"
        sb.Append($"{context.Indent}{_blockType}");
        foreach (var label in _labels)
        {
            sb.Append($" \"{label}\"");
        }
        sb.AppendLine(" {");

        // Write body
        using (context.PushIndent())
        {
            foreach (var (key, value) in _body)
            {
                sb.AppendLine($"{context.Indent}{key} = {value.ToHcl(context)}");
            }
        }

        sb.AppendLine($"{context.Indent}}}");
        return sb.ToString();
    }
}
```

### Would This Simplify Things?

**Potentially YES:**

```csharp
// Instead of TerraformConstruct with ToHcl() method...
public abstract class TerraformConstruct
{
    public virtual string ToHcl() { /* custom serialization */ }
}

// Could become...
public abstract class TerraformConstruct
{
    public abstract TerraformConstructExpression ToExpression();
}
```

**Then constructs would:**

1. Store properties in `_propertyValues` (same as now)
2. Convert to `TerraformConstructExpression` on demand
3. Let the expression handle HCL serialization

### Benefits:

✅ Constructs become pure data containers
✅ All HCL generation logic in expression layer
✅ Easier to compose (constructs → expressions → HCL)
✅ Cleaner separation of concerns

### Challenges:

⚠️ Meta-arguments (count, for_each, lifecycle) need special handling
⚠️ Dynamic blocks need to be part of the expression
⚠️ Existing code would need refactoring

### Recommendation:

**This is a valid architectural direction** but would require:

1. Creating `TerraformConstructExpression` class
2. Refactoring `TerraformConstruct.ToHcl()` → `ToExpression()`
3. Handling meta-arguments in the expression layer
4. Supporting dynamic blocks in expressions

**Current state is pragmatic:**

- Constructs handle their own serialization (simple, direct)
- Expression layer handles value resolution
- Clear boundary: constructs = top-level, blocks = nested

**Future improvement:**

- Could migrate to expression-based approach incrementally
- Would make constructs more composable
- Aligns better with expression-centric architecture

---

## ADDENDUM: Industry Comparison & Refactoring Recommendation

**Date:** November 11, 2025  
**Goal:** Evaluate whether we can eliminate `TerraformConstruct` by building on `TerraformBlock`

### Key Findings from Industry Leaders

#### 1. **Pulumi (.NET)** - Direct Resource Model

**Architecture:**

```csharp
// Base class for all resources
public class Resource
{
    protected readonly string _type;
    protected readonly string _name;
    public Output<string> Urn { get; }
    // ... constructor registers with engine
}

// Custom resources (have physical infrastructure)
public class CustomResource : Resource
{
    public Output<string> Id { get; }
    // ... CRUD operations managed by provider
}

// Component resources (logical grouping)
public class ComponentResource : Resource
{
    // Aggregates other resources
}

// Outputs are async values
public class Output<T>
{
    // Represents async values with dependencies
}
```

**Key Insights:**

- ✅ **Resources are NOT data containers** - they register with the engine during construction
- ✅ **Properties are `Output<T>`** - async, dependency-tracked values
- ✅ **No separation between "construct" and "block"** - everything is a Resource
- ✅ **Nested configuration is just plain objects** - no special base class needed
- ✅ **Registration happens at construction time** - not serialization time

**Implications for Terraform SDK:**

- We DON'T need a separate construct abstraction
- Resources could just be blocks that know how to register themselves
- Meta-arguments could be properties on the base block class

---

#### 2. **AWS CDK (TypeScript)** - Construct Tree Model

**Architecture:**

```typescript
// Base construct (from constructs library)
export class Construct {
  constructor(scope: Construct, id: string) {
    // Creates tree hierarchy
  }
}

// AWS resource base
export abstract class Resource extends Construct implements IResource {
  public readonly stack: Stack;
  public readonly env: ResourceEnvironment;
  // ... cross-environment logic
}

// CloudFormation resource (L1)
export class CfnResource extends CfnRefElement {
  public readonly cfnResourceType: string;
  protected readonly _cfnProperties: any;
  // ... CloudFormation-specific logic
}
```

**Key Insights:**

- ✅ **Everything is a Construct** - unified tree model
- ✅ **Resources extend Construct** - add AWS-specific behavior
- ✅ **CfnResource is separate** - low-level CloudFormation abstraction
- ✅ **Properties are just TypeScript properties** - no special types needed
- ✅ **Nested configs are plain objects or constructs**

**Implications for Terraform SDK:**

- Constructs serve a PURPOSE beyond serialization (tree building, cross-references)
- We might not need the full tree model for Terraform (less complex than CDK)
- But separation of concerns is valuable

---

#### 3. **Current Terraform SDK** - Dual Model

**Architecture:**

```csharp
// Top-level blocks (resources, outputs, variables, etc.)
public abstract class TerraformConstruct
{
    private readonly Dictionary<string, object?> _propertyValues;
    public abstract string BlockType { get; }
    protected abstract string[] BlockLabels { get; }
    public virtual string ToHcl(ITerraformContext? context = null) { }
}

// Nested configuration objects
public abstract class TerraformBlock : TerraformMap<object>
{
    public string BlockLabel { get; }
    public override TerraformExpression Resolve(ITerraformResolveContext context) { }
}
```

**The Duplication:**

- Both have property storage (different mechanisms)
- Both have SetPropertyValue/GetPropertyValue
- Both serialize to HCL (different formats)
- Constructs generate `resource "type" "name" { }`, blocks generate `{ key = value }`

---

### The Core Question: Can We Unify Them?

**Proposal:** Make `TerraformResource` (and other constructs) extend `TerraformBlock`

```csharp
// PROPOSED: TerraformBlock becomes the base for EVERYTHING
public abstract class TerraformBlock : TerraformMap<object>
{
    // Property storage (already there)
    protected void SetPropertyValue(string name, object? value) { }
    protected T? GetPropertyValue<T>(string name) { }

    // Resolution to expression (already there)
    public override TerraformExpression Resolve(ITerraformResolveContext ctx) { }
}

// PROPOSED: Resources just add metadata and expression generation
public class TerraformResource : TerraformBlock
{
    public string ResourceType { get; }
    public string ResourceName { get; }

    // Meta-arguments (source generator can add these)
    public TerraformValue<int>? Count { get; set; }
    public TerraformValue<object>? ForEach { get; set; }
    public List<string> DependsOn { get; } = new();

    // Override Resolve to return a construct expression instead of just a map
    public override TerraformExpression Resolve(ITerraformResolveContext ctx)
    {
        var body = base.Resolve(ctx); // Gets map expression from properties
        return new TerraformConstructExpression("resource",
            [ResourceType, ResourceName], body);
    }
}

// NEW: Expression type for constructs
public class TerraformConstructExpression : TerraformExpression
{
    private readonly string _blockType;
    private readonly string[] _labels;
    private readonly TerraformMapExpression _body;

    public override string ToHcl(ITerraformContext? ctx)
    {
        // resource "aws_vpc" "main" {
        //   cidr_block = "10.0.0.0/16"
        // }
    }
}
```

---

### ✅ **YES - We Can Eliminate TerraformConstruct!**

**Here's the refactored architecture:**

#### Phase 1: Make TerraformBlock the Foundation

```csharp
/// <summary>
/// Base class for ALL Terraform configuration objects (nested AND top-level).
/// Provides property storage, resolution, and expression generation.
/// </summary>
public abstract class TerraformBlock : TerraformMap<object>
{
    // Property storage (already implemented)
    protected void SetPropertyValue(string name, object? value) { }
    protected T? GetPropertyValue<T>(string name) { }

    // Resolve to expression (already implemented via TerraformMap)
    public override TerraformExpression Resolve(ITerraformResolveContext ctx)
    {
        // Returns TerraformMapExpression
    }
}
```

#### Phase 2: Resources as Specialized Blocks

```csharp
/// <summary>
/// Represents a Terraform resource - a block with type, name, and meta-arguments.
/// </summary>
public class TerraformResource : TerraformBlock
{
    public string ResourceType { get; }
    public string ResourceName { get; }

    public TerraformResource(string type, string name)
    {
        ResourceType = type;
        ResourceName = name;
    }

    // Override Resolve to wrap properties in a construct expression
    public override TerraformExpression Resolve(ITerraformResolveContext ctx)
    {
        var bodyMap = base.Resolve(ctx); // Gets TerraformMapExpression from properties
        return new TerraformConstructExpression("resource",
            [ResourceType, ResourceName], bodyMap);
    }

    // Reference generation
    public TerraformExpression AsReference()
        => TerraformExpression.Identifier($"{ResourceType}.{ResourceName}");
}
```

#### Phase 3: Meta-Arguments via Marker Interfaces + Source Generator

```csharp
/// <summary>
/// Marker interface for constructs that support the 'count' meta-argument.
/// Source generator will add the Count property to implementing types.
/// </summary>
public interface ITerraformHasCount
{
    TerraformValue<int>? Count { get; set; }
}

/// <summary>
/// Marker interface for constructs that support the 'for_each' meta-argument.
/// Source generator will add the ForEach property to implementing types.
/// </summary>
public interface ITerraformHasForEach
{
    TerraformValue<object>? ForEach { get; set; }
}

/// <summary>
/// Marker interface for constructs that support the 'depends_on' meta-argument.
/// Source generator will add the DependsOn property to implementing types.
/// </summary>
public interface ITerraformHasDependsOn
{
    List<string> DependsOn { get; }
}

/// <summary>
/// Marker interface for constructs that support the 'provider' meta-argument.
/// Source generator will add the Provider property to implementing types.
/// </summary>
public interface ITerraformHasProvider
{
    string? Provider { get; set; }
}

/// <summary>
/// Marker interface for constructs that support the 'lifecycle' meta-argument.
/// Source generator will add the Lifecycle property to implementing types.
/// </summary>
public interface ITerraformHasLifecycle
{
    TerraformLifecycleConfig? Lifecycle { get; set; }
}

/// <summary>
/// Marker interface for constructs that support 'dynamic' blocks.
/// Source generator will add the DynamicBlocks property to implementing types.
/// </summary>
public interface ITerraformHasDynamicBlocks
{
    List<TerraformDynamicBlock> DynamicBlocks { get; }
}

/// <summary>
/// Combined interface for all provisionable construct meta-arguments.
/// Resources and data sources implement this to get all meta-arguments.
/// </summary>
public interface ITerraformProvisionableConstruct :
    ITerraformHasCount,
    ITerraformHasForEach,
    ITerraformHasDependsOn,
    ITerraformHasProvider,
    ITerraformHasLifecycle,
    ITerraformHasDynamicBlocks
{
}

// Source generator detects interfaces and generates implementations
public partial class TerraformResource : TerraformBlock, ITerraformProvisionableConstruct
{
    // Generated by source generator based on ITerraformHasCount
    public TerraformValue<int>? Count
    {
        get => GetPropertyValue<TerraformValue<int>?>("count");
        set => SetPropertyValue("count", value);
    }

    // Generated by source generator based on ITerraformHasForEach
    public TerraformValue<object>? ForEach
    {
        get => GetPropertyValue<TerraformValue<object>?>("for_each");
        set => SetPropertyValue("for_each", value);
    }

    // Generated by source generator based on ITerraformHasDependsOn
    public List<string> DependsOn
    {
        get => GetPropertyValue<List<string>?>("depends_on") ?? new();
        set => SetPropertyValue("depends_on", value);
    }

    // Generated by source generator based on ITerraformHasProvider
    public string? Provider
    {
        get => GetPropertyValue<string?>("provider");
        set => SetPropertyValue("provider", value);
    }

    // Generated by source generator based on ITerraformHasLifecycle
    public TerraformLifecycleConfig? Lifecycle
    {
        get => GetPropertyValue<TerraformLifecycleConfig?>("lifecycle");
        set => SetPropertyValue("lifecycle", value);
    }

    // Generated by source generator based on ITerraformHasDynamicBlocks
    public List<TerraformDynamicBlock> DynamicBlocks
    {
        get => GetPropertyValue<List<TerraformDynamicBlock>?>("dynamic_blocks") ?? new();
        set => SetPropertyValue("dynamic_blocks", value);
    }
}

// Data sources might only support a subset
public partial class TerraformDataSource : TerraformBlock,
    ITerraformHasDependsOn,  // Data sources can depend on other resources
    ITerraformHasProvider    // Data sources can specify provider
{
    // Source generator only creates DependsOn and Provider properties
    // because this class only implements those interfaces
}

// Modules can have count/for_each but different lifecycle behavior
public partial class TerraformModule : TerraformBlock,
    ITerraformHasCount,
    ITerraformHasForEach,
    ITerraformHasDependsOn,
    ITerraformHasProvider
{
    // Source generator creates Count, ForEach, DependsOn, Provider
    // but NOT Lifecycle (modules don't support lifecycle blocks)
}
```

**Benefits of Marker Interfaces:**

✅ **Type Safety** - Compiler enforces which constructs support which meta-arguments
✅ **Discoverability** - IntelliSense shows only applicable meta-arguments
✅ **Granular Control** - Each construct can opt into specific meta-arguments
✅ **Source Generator Guidance** - Generator knows exactly what to implement
✅ **Extensibility** - Easy to add new meta-arguments or custom extensions
✅ **Documentation** - Interface names are self-documenting

**Usage Examples:**

```csharp
// Resources get all provisionable meta-arguments
var vpc = new AwsVpc("main")
{
    CidrBlock = "10.0.0.0/16"
};
vpc.Count = 3; // ✅ Allowed - implements ITerraformHasCount
vpc.Lifecycle = new() { CreateBeforeDestroy = true }; // ✅ Allowed

// Data sources get subset of meta-arguments
var existingVpc = new AwsVpcDataSource("existing")
{
    Filter = [new() { Name = "tag:Name", Values = ["prod"] }]
};
existingVpc.DependsOn.Add("aws_vpc.main"); // ✅ Allowed - implements ITerraformHasDependsOn
existingVpc.Count = 2; // ❌ Compile error - data sources don't implement ITerraformHasCount

// Modules get their own subset
var module = new TerraformModule("network", "./modules/network")
{
    Source = "./modules/network"
};
module.ForEach = new Dictionary<string, object> { ["env"] = "prod" }; // ✅ Allowed
module.Lifecycle = new(); // ❌ Compile error - modules don't implement ITerraformHasLifecycle

// Type-safe constraint checking
void ConfigureResourceCount<T>(T resource, int count)
    where T : TerraformBlock, ITerraformHasCount
{
    resource.Count = count; // ✅ Guaranteed to work
}

ConfigureResourceCount(vpc, 5); // ✅ Works
ConfigureResourceCount(existingVpc, 5); // ❌ Compile error - data source doesn't support count
```

**Source Generator Pattern:**

```csharp
// The generator scans for types implementing marker interfaces
// and generates the property implementations automatically

[Generator]
public class MetaArgumentGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        // Find all types implementing meta-argument interfaces
        var candidates = context.SyntaxProvider
            .CreateSyntaxProvider(
                predicate: (node, _) => node is ClassDeclarationSyntax,
                transform: (ctx, _) => GetClassWithMetaInterfaces(ctx))
            .Where(c => c != null);

        // Generate properties for each interface
        context.RegisterSourceOutput(candidates, (ctx, source) =>
        {
            if (source.Implements<ITerraformHasCount>())
                GenerateCountProperty(ctx, source);
            if (source.Implements<ITerraformHasForEach>())
                GenerateForEachProperty(ctx, source);
            // ... etc
        });
    }
}
```

#### Phase 4: HCL Generation via Expressions

```csharp
/// <summary>
/// Expression representing a complete Terraform construct with block type and labels.
/// </summary>
public class TerraformConstructExpression : TerraformExpression
{
    private readonly string _blockType; // "resource", "data", "output", etc.
    private readonly string[] _labels;  // ["aws_vpc", "main"]
    private readonly TerraformMapExpression _body;

    public TerraformConstructExpression(
        string blockType,
        string[] labels,
        TerraformMapExpression body)
    {
        _blockType = blockType;
        _labels = labels;
        _body = body;
    }

    public override string ToHcl(ITerraformContext? context = null)
    {
        context ??= TerraformContext.Temporary(this);
        var sb = new StringBuilder();

        // Header: resource "aws_vpc" "main" {
        sb.Append($"{context.Indent}{_blockType}");
        foreach (var label in _labels)
            sb.Append($" \"{label}\"");
        sb.AppendLine(" {");

        // Body (from map expression)
        using (context.PushIndent())
        {
            foreach (var (key, value) in _body)
            {
                sb.AppendLine($"{context.Indent}{key} = {value.ToHcl(context)}");
            }
        }

        sb.AppendLine($"{context.Indent}}}");
        return sb.ToString();
    }
}
```

#### Phase 5: Stack Integration

```csharp
public class TerraformStack
{
    private readonly List<TerraformBlock> _constructs = new();

    public void Add(TerraformBlock construct)
    {
        _constructs.Add(construct);
    }

    public string ToHcl()
    {
        var sb = new StringBuilder();
        var context = TerraformContext.Root();

        // Everything just resolves to expressions - no special cases needed!
        foreach (var construct in _constructs)
        {
            var expression = construct.Resolve(context);
            sb.AppendLine(expression.ToHcl(context));
        }

        return sb.ToString();
    }
}
```

**Key Insight:**

- ✅ **No type checking needed** - everything is polymorphic via `Resolve()`
- ✅ **Nested blocks resolve to map expressions** - serialized as `{ key = value }`
- ✅ **Top-level constructs resolve to construct expressions** - serialized as `resource "type" "name" { ... }`
- ✅ **Same interface, different behavior** - perfect polymorphism

---

### Benefits of This Approach

#### ✅ **1. Unified Architecture**

- Everything is a `TerraformBlock` - no duality
- Property storage works the same everywhere
- Source generator generates same patterns for all types

#### ✅ **2. Less Code**

- Eliminate `TerraformConstruct` entirely (~200 lines)
- No duplicate property accessor methods
- Single property storage mechanism

#### ✅ **3. Expression-Centric**

- Constructs produce expressions via `Resolve()`
- Expressions handle HCL generation
- Clear separation: data vs. serialization

#### ✅ **4. Perfect Polymorphism**

- **No type checking needed!** Everything just calls `Resolve()`
- Nested blocks return `TerraformMapExpression` → renders as `{ key = value }`
- Top-level constructs return `TerraformConstructExpression` → renders as `resource "type" "name" { ... }`
- Stack serialization is trivial: `foreach (var block in blocks) sb.Append(block.Resolve(ctx).ToHcl())`

#### ✅ **5. Source Generator Power**

- Meta-arguments added via generator
- Count, for_each, depends_on, lifecycle all generated
- No hand-written meta-argument code

#### ✅ **6. Better Composability**

- Blocks can be nested in blocks (already works)
- Blocks can become constructs (just override `Resolve()`)
- Everything resolves to expressions

---

### Migration Path

#### Step 1: Create `TerraformConstructExpression`

- New expression type for top-level blocks
- Takes block type, labels, body (map expression)
- Handles HCL serialization

#### Step 2: Add Metadata to TerraformBlock

```csharp
public abstract class TerraformBlock : TerraformMap<object>
{
    // Override Resolve in derived classes to return appropriate expression type
    // - Nested blocks: return TerraformMapExpression (via base.Resolve())
    // - Top-level constructs: return TerraformConstructExpression
    public abstract override TerraformExpression Resolve(ITerraformResolveContext ctx);

    // Optional reference generation for top-level constructs
    public virtual TerraformExpression? AsReference() => null;
}
```

#### Step 3: Refactor Resources

```csharp
public class TerraformResource : TerraformBlock, ITerraformProvisionableConstruct
{
    public string ResourceType { get; }
    public string ResourceName { get; }

    // Override Resolve to wrap in construct expression
    public override TerraformExpression Resolve(ITerraformResolveContext ctx)
    {
        var bodyMap = base.Resolve(ctx); // Get map from properties
        return new TerraformConstructExpression("resource",
            [ResourceType, ResourceName], bodyMap);
    }

    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"{ResourceType}.{ResourceName}");
}
```

#### Step 4: Update Source Generator

- Detect marker interfaces (ITerraformHasCount, ITerraformHasForEach, etc.)
- Generate property implementations based on which interfaces are present
- Use `[TerraformMetaArgument]` attribute for metadata
- Add to all resource/data source/module classes based on their interface implementations
- Validate that interfaces are only applied to TerraformBlock-derived types

#### Step 5: Update Stack Serialization

- Everything just calls `Resolve()` - no type checking needed
- Nested blocks return `TerraformMapExpression`
- Top-level constructs return `TerraformConstructExpression`
- All expressions have `ToHcl()` - perfect polymorphism

#### Step 6: Remove `TerraformConstruct`

- Delete the class
- Update all references
- Simplify architecture

---

### Comparison to Industry Standards

| Feature              | Pulumi            | AWS CDK                    | Current SDK                        | **Proposed**                          |
| -------------------- | ----------------- | -------------------------- | ---------------------------------- | ------------------------------------- |
| **Base abstraction** | Resource          | Construct                  | TerraformConstruct                 | TerraformBlock                        |
| **Nested configs**   | Plain objects     | Plain objects / Constructs | TerraformBlock                     | TerraformBlock                        |
| **Property storage** | Engine-tracked    | Plain props                | Dictionary                         | Inherited map                         |
| **Serialization**    | Engine            | CloudFormation             | Custom ToHcl()                     | Expression-based                      |
| **Meta-arguments**   | In base class     | In base class              | In TerraformProvisionableConstruct | ✅ **Marker interfaces + source gen** |
| **Reference gen**    | `this` (tracked)  | `.ref`                     | `AsReference()`                    | `AsReference()`                       |
| **Type safety**      | Runtime           | Runtime                    | Runtime                            | ✅ **Compile-time via interfaces**    |
| **Composability**    | Via engine        | Via tree                   | Limited                            | ✅ Excellent                          |
| **Extensibility**    | Provider-specific | L1/L2/L3 patterns          | Limited                            | ✅ **Interface-based**                |

---

### Recommendation: **PROCEED WITH REFACTORING**

**Why:**

1. ✅ **Industry-aligned** - Pulumi and CDK both use unified models
2. ✅ **Source generator ready** - We have the infrastructure to generate meta-arguments
3. ✅ **Expression-centric** - Aligns with the TerraformExpression architecture already in place
4. ✅ **Less code** - Eliminates ~200+ lines of duplicate infrastructure
5. ✅ **Better DX** - Everything works the same way (property storage, resolution, serialization)
6. ✅ **Compile-time safety** - Marker interfaces prevent invalid meta-argument usage at compile time
7. ✅ **Granular control** - Each construct type can opt into specific meta-arguments
8. ✅ **Extensible** - Easy to add new meta-arguments or provider-specific extensions via new interfaces

**Migration is Low-Risk:**

- `TerraformBlock` already has property storage
- `TerraformBlock` already resolves to expressions
- Meta-arguments can be source-generated incrementally
- Backwards compatible (existing code continues working during migration)

**Next Steps:**

1. Create `TerraformConstructExpression` class
2. Define marker interfaces for meta-arguments (ITerraformHasCount, ITerraformHasForEach, etc.)
3. Add `BlockType` and `BlockLabels` to `TerraformBlock` (virtual, nullable)
4. Refactor `TerraformResource` to inherit from `TerraformBlock` and implement `ITerraformProvisionableConstruct`
5. Update source generator to detect marker interfaces and emit property implementations
6. Update `TerraformStack` to use expression-based serialization
7. Deprecate and remove `TerraformConstruct`
8. Update documentation and samples

---

### Advanced Marker Interface Patterns

**Provider-Specific Extensions:**

```csharp
/// <summary>
/// Azure-specific interface for resources that support tags.
/// Applied to provider-generated resource classes (top-level constructs).
/// Source generator adds Tags property to implementing types.
/// </summary>
public interface ITerraformHasAzureTags
{
    TerraformMap<string>? Tags { get; set; }
}

/// <summary>
/// AWS-specific interface for resources that support ignore_changes.
/// Applied to provider-generated resource classes (top-level constructs).
/// </summary>
public interface ITerraformHasAwsIgnoreChanges
{
    List<string> IgnoreChanges { get; }
}

// Provider code generator adds provider-specific interfaces to top-level resources
// ITerraformProvisionableConstruct comes from inheriting TerraformResource
[GeneratedCode("TerraformProviderGenerator", "1.0")]
public partial class AzurermResourceGroup : TerraformResource,  // ← Inherits ITerraformProvisionableConstruct
    ITerraformHasAzureTags  // ← Provider generator adds this for Azure resources with tags
{
    // Resource-specific properties generated from Terraform schema...

    // Count, ForEach, DependsOn, etc. already available from TerraformResource base class
    // Tags property is source-generated based on ITerraformHasAzureTags interface
}

// NOT nested blocks - those don't implement provider-specific interfaces
[GeneratedCode("TerraformProviderGenerator", "1.0")]
public partial class AzurermResourceGroupTimeoutsBlock : TerraformBlock  // ← Just TerraformBlock
{
    // ❌ No ITerraformProvisionableConstruct (it's not a top-level construct)
    // ❌ No ITerraformHasAzureTags (it's not a resource)
    // Just configuration properties from schema
}
```

**Feature-Based Interfaces:**

```csharp
/// <summary>
/// Marks a RESOURCE (top-level construct) as supporting encryption at rest.
/// Provider code generator applies this during resource generation.
/// Not applicable to nested blocks.
/// </summary>
public interface ITerraformHasEncryption
{
    TerraformValue<bool>? EncryptionEnabled { get; set; }
}

/// <summary>
/// Marks a RESOURCE (top-level construct) as supporting high availability.
/// Provider code generator applies this during resource generation.
/// Not applicable to nested blocks.
/// </summary>
public interface ITerraformHasHighAvailability
{
    TerraformValue<bool>? HighAvailabilityEnabled { get; set; }
    TerraformValue<int>? ReplicaCount { get; set; }
}

// Provider code generator adds feature-specific interfaces to appropriate resources
// ITerraformProvisionableConstruct is inherited from TerraformResource base class
[GeneratedCode("TerraformProviderGenerator", "1.0")]
public partial class AzurermPostgresqlFlexibleServer : TerraformResource,  // ← Inherits ITerraformProvisionableConstruct
    ITerraformHasEncryption,      // ← Provider generator adds based on schema
    ITerraformHasHighAvailability // ← Provider generator adds based on schema
{
    // Resource-specific properties from schema...

    // Inherited from TerraformResource (which implements ITerraformProvisionableConstruct):
    // - Count, ForEach, DependsOn, Provider, Lifecycle, DynamicBlocks

    // Source-generated from provider-specific interfaces:
    // - EncryptionEnabled (from ITerraformHasEncryption)
    // - HighAvailabilityEnabled, ReplicaCount (from ITerraformHasHighAvailability)
}
```

**Key Distinction:**

| Type                     | Implements Interfaces   | Generated By            | Example                                    |
| ------------------------ | ----------------------- | ----------------------- | ------------------------------------------ |
| **Top-level constructs** | ✅ Yes                  | Provider code generator | `AzurermResourceGroup`, `AwsVpc`           |
| **Nested blocks**        | ❌ No                   | Provider code generator | `TimeoutsBlock`, `IngressBlock`            |
| **Base classes**         | ✅ Yes (core meta-args) | Manual/framework        | `TerraformResource`, `TerraformDataSource` |

**Why this matters:**

- ✅ **Provider-specific interfaces** = Only on generated **resources** (top-level)
- ✅ **Feature-based interfaces** = Only on generated **resources** (top-level)
- ✅ **Core meta-argument interfaces** = On framework base classes (`TerraformResource`, etc.)
- ❌ **Nested blocks** = Never implement meta-argument interfaces (they're just data)

**Generic Constraint Helpers:**

```csharp
/// <summary>
/// Helper methods for working with meta-arguments in a type-safe way.
/// </summary>
public static class MetaArgumentExtensions
{
    /// <summary>
    /// Sets count on any construct that supports it.
    /// </summary>
    public static T WithCount<T>(this T construct, int count)
        where T : TerraformBlock, ITerraformHasCount
    {
        construct.Count = count;
        return construct;
    }

    /// <summary>
    /// Sets for_each on any construct that supports it.
    /// </summary>
    public static T WithForEach<T>(this T construct, Dictionary<string, object> items)
        where T : TerraformBlock, ITerraformHasForEach
    {
        construct.ForEach = items;
        return construct;
    }

    /// <summary>
    /// Adds dependency on any construct that supports it.
    /// </summary>
    public static T DependingOn<T>(this T construct, params string[] dependencies)
        where T : TerraformBlock, ITerraformHasDependsOn
    {
        foreach (var dep in dependencies)
            construct.DependsOn.Add(dep);
        return construct;
    }
}

// Usage with fluent API:
var vpc = new AwsVpc("main") { CidrBlock = "10.0.0.0/16" }
    .WithCount(3)
    .DependingOn("aws_subnet.private");

var dataSource = new AwsVpcDataSource("existing")
    .DependingOn("aws_vpc.main"); // ✅ Works
    //.WithCount(2); // ❌ Compile error - data sources don't support count
```

**Validation Attributes:**

```csharp
/// <summary>
/// Validates that count and for_each are mutually exclusive.
/// Applied by source generator to classes implementing both interfaces.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
internal class MutuallyExclusiveMetaArgumentsAttribute : Attribute
{
    public string[] Arguments { get; }

    public MutuallyExclusiveMetaArgumentsAttribute(params string[] arguments)
    {
        Arguments = arguments;
    }
}

// Source generator automatically adds validation
[MutuallyExclusiveMetaArguments("count", "for_each")]
public partial class TerraformResource : TerraformBlock, ITerraformProvisionableConstruct
{
    // Generator creates validation logic:
    partial void ValidateMetaArguments()
    {
        if (Count != null && ForEach != null)
            throw new InvalidOperationException(
                "Cannot use both 'count' and 'for_each' on the same resource");
    }
}
```

---

**Decision:** **REFACTOR** - Eliminate `TerraformConstruct`, unify on `TerraformBlock` + `TerraformConstructExpression`

---

**Document Version:** 2.0  
**Last Updated:** November 11, 2025  
**Status:** ✅ Refactoring Recommended - Ready to Implement
