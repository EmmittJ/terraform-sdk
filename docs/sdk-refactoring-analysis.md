# Terraform SDK Refactoring Analysis

## Executive Summary

After major refactoring, the SDK has several opportunities for improvement by reducing reflection usage, unifying naming/tracking systems, eliminating duplicate code, and simplifying the architecture. This document identifies key areas for pruning and optimization.

---

## 🔴 Critical Issues

### 1. **Duplicate TerraformReference Classes**

**Problem:** Three separate reference implementations exist:

- `Resolution/TerraformReference.cs` - Original reflection-based implementation
- `Values/TerraformReference<T>.cs` - Generic typed reference (wraps TerraformReferenceResolvable)
- `Expressions/TerraformReferenceExpression.cs` - Semantic reference for dependency tracking

**Impact:** Confusion, maintenance burden, inconsistent behavior

**Recommendation:**

- **Keep:** `TerraformReferenceExpression.cs` (has dependency tracking)
- **Keep:** `Values/TerraformReference<T>.cs` (typed references for property assignments)
- **DELETE:** `Resolution/TerraformReference.cs` (old, reflection-heavy, superseded)

**Action:** Remove `Resolution/TerraformReference.cs` entirely. Update any usages to use the typed version or expression version.

---

## 📋 Current Interface Analysis

### Existing Marker Interfaces (src/EmmittJ.Terraform.Sdk/Resources/ITerraformMetaArguments.cs)

**Current State:**

- All interfaces are **empty marker interfaces** with commented property signatures
- Source generator creates properties, but interfaces don't expose them
- This forces reflection in validation and extension methods

**Interfaces Found:**

1. **ITerraformHasCount** ✅ Needs property exposure
   - Comment says: `TerraformValue<int>? Count { get; set; }`
   - Used in: TerraformValidator (reflection-based validation)
2. **ITerraformHasForEach** ✅ Needs property exposure
   - Comment says: `TerraformValue<object>? ForEach { get; set; }`
   - Used in: TerraformValidator (reflection-based validation)
3. **ITerraformHasDependsOn** ✅ Needs property exposure
   - Comment says: `List<string> DependsOn { get; }`
   - Currently: No reflection usage found (but should expose for consistency)
4. **ITerraformHasProvider** ✅ Needs property exposure
   - Comment says: `string? Provider { get; set; }`
   - Currently: No reflection usage found (but should expose for consistency)
5. **ITerraformHasLifecycle** ✅ Needs property exposure
   - Comment says: `TerraformLifecycleConfig? Lifecycle { get; set; }`
   - Currently: No reflection usage found (but should expose for consistency)
6. **ITerraformHasDynamicBlocks** ✅ Needs property exposure
   - Comment says: `List<TerraformDynamicBlock> DynamicBlocks { get; }`
   - Used in: TerraformProvisionableConstructExtensions (2 reflection call sites)
7. **ITerraformProvisionableConstruct** - Combined interface
   - Inherits all 6 meta-argument interfaces
   - Should be renamed to `ITerraformProvisionableBlock`

### Reflection Usage Summary

**Files using reflection for meta-arguments:**

1. **TerraformValidator.cs** (lines 56-72)

   ```csharp
   // Uses reflection to access Count and ForEach
   var countProperty = constructType.GetProperty("Count");
   var forEachProperty = constructType.GetProperty("ForEach");
   var count = countProperty?.GetValue(construct);
   var forEach = forEachProperty?.GetValue(construct);
   ```

   **Fix:** Cast to `ITerraformHasCount` and `ITerraformHasForEach` interfaces

2. **TerraformProvisionableConstructExtensions.cs** (lines 29-30, 56-57)

   ```csharp
   // Uses reflection to access DynamicBlocks
   var dynamicBlocksProperty = typeof(TConstruct).GetProperty("DynamicBlocks");
   var dynamicBlocks = dynamicBlocksProperty?.GetValue(construct) as List<TerraformDynamicBlock>;
   ```

   **Fix:** Access through `ITerraformHasDynamicBlocks.DynamicBlocks` property

3. **ValidationError.cs** (lines 57-68)

   ```csharp
   // Uses reflection to get BlockType and ConstructName
   var blockTypeProperty = Construct.GetType().GetProperty("BlockType");
   var nameProperty = Construct.GetType().GetProperty("ConstructName");
   ```

   **Fix:** Use `ITerraformTopLevelBlock` interface (to be created)

4. **DependencyGraph.cs** (lines 200-203)

   ```csharp
   // Uses reflection to get Name property
   var nameProperty = construct.GetType().GetProperty("Name");
   ```

   **Fix:** Use `ITerraformTopLevelBlock.BlockLabels` property

5. **Resolution/TerraformReference.cs** (lines 33-38) - WILL BE DELETED
   ```csharp
   // Uses reflection to get ResourceType/DataSourceType/Name
   var typeProperty = constructType.GetProperty("ResourceType")...
   ```
   **Fix:** Delete this file entirely

---

## 🟡 Major Refactoring Opportunities

### 2. **Unify Block Naming/Type Tracking**

**Problem:** Multiple reflection-heavy access patterns for block names and types, plus legacy "construct" terminology:

**Current State:**

```csharp
// ValidationError.cs - uses reflection AND old "Construct" naming
var blockTypeProperty = Construct.GetType().GetProperty("BlockType");
var nameProperty = Construct.GetType().GetProperty("ConstructName");

// TerraformReference.cs - uses reflection
var typeProperty = constructType.GetProperty("ResourceType")
    ?? constructType.GetProperty("DataSourceType")
    ?? constructType.GetProperty("ConstructType");
var nameProperty = constructType.GetProperty("ResourceName")
    ?? constructType.GetProperty("DataSourceName")
    ?? constructType.GetProperty("Name");

// DependencyGraph.cs - uses reflection
var nameProperty = construct.GetType().GetProperty("Name");
```

**Each block type has different property names:**

- `TerraformResource`: `ResourceType` + `ResourceName`
- `TerraformDataSource`: `DataSourceType` + `DataSourceName`
- `TerraformModule`: `Name` (no type)
- `TerraformVariable`: `Name` (no type)
- `TerraformOutput`: `Name` (no type)

**Recommendation:** Create a unified interface for all top-level blocks and eliminate "construct" terminology.

```csharp
// New interface in Context/ITerraformTopLevelBlock.cs
namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Marker interface for top-level Terraform blocks that have identifiable labels.
/// Provides unified access to block identity without reflection.
/// Aligns with Terraform's configuration syntax terminology.
/// </summary>
/// <remarks>
/// Top-level blocks appear at the root of a Terraform configuration file.
/// Each has a block type keyword and optional labels.
/// For example: resource "aws_instance" "example" { }
/// - Block type: "resource"
/// - Labels: ["aws_instance", "example"]
///
/// This interface applies to: resource, data, module, variable, output, locals, terraform, provider, etc.
/// It does NOT apply to nested blocks like lifecycle, connection, provisioner, etc.
/// </remarks>
public interface ITerraformTopLevelBlock
{
    /// <summary>
    /// Gets the block type keyword (e.g., "resource", "data", "module", "variable", "output").
    /// Used for display and validation messages.
    /// </summary>
    string BlockType { get; }

    /// <summary>
    /// Gets the labels for this top-level block.
    /// For resources: ["aws_instance", "example"] from resource "aws_instance" "example"
    /// For data sources: ["aws_instance", "example"] from data "aws_instance" "example"
    /// For modules/variables/outputs: ["name"] (single label)
    /// </summary>
    string[] BlockLabels { get; }
}
```

**Implementation:**

- `TerraformResource` implements `ITerraformTopLevelBlock`:
  - `BlockType` → `"resource"`
  - `BlockLabels` → `[ResourceType, ResourceName]`
- `TerraformDataSource` implements `ITerraformTopLevelBlock`:
  - `BlockType` → `"data"`
  - `BlockLabels` → `[DataSourceType, DataSourceName]`
- `TerraformModule`, `TerraformVariable`, `TerraformOutput` implement `ITerraformTopLevelBlock`:
  - `BlockType` → `"module"` / `"variable"` / `"output"`
  - `BlockLabels` → `[Name]`

**Benefits:**

- ✅ Eliminates ALL reflection in `ValidationError.GetFormattedMessage()`
- ✅ Eliminates reflection in `DependencyGraph.GetBlockName()`
- ✅ Simplifies reference creation (no reflection needed)
- ✅ Uses Terraform's official terminology (block type + labels)
- ✅ AOT-compatible (no reflection)
- ✅ Faster runtime performance
- ✅ Type-safe
- ✅ Clear intent (only for top-level blocks)

**Additional Cleanup:**

- Rename `ValidationError.Construct` → `ValidationError.Block`
- Rename all `construct` parameters to `block`
- Update display formatting to use proper Terraform syntax (e.g., `resource "aws_instance" "example"`)

**Opportunity to Use ITerraformTopLevelBlock Instead of TerraformBlock:**

Several parts of the codebase currently use `TerraformBlock` where they really only work with top-level blocks:

1. **TerraformStack** - The `_constructs` list and `Add()` method:

   ```csharp
   // Current:
   private readonly List<TerraformBlock> _constructs = [];
   public void Add(TerraformBlock construct) { ... }
   public IReadOnlyList<TerraformBlock> Constructs => _constructs.AsReadOnly();

   // Could be:
   private readonly List<ITerraformTopLevelBlock> _blocks = [];
   public void Add(ITerraformTopLevelBlock block) { ... }
   public IReadOnlyList<ITerraformTopLevelBlock> Blocks => _blocks.AsReadOnly();
   ```

   This makes it clear that TerraformStack only accepts top-level blocks, not nested blocks like lifecycle or timeouts.

2. **TerraformReference** - References can be to top-level blocks OR nested block attributes:

   ```csharp
   // Current:
   private readonly TerraformBlock _block;
   public TerraformReference(TerraformBlock block, string attributeName) { ... }

   // Should stay as TerraformBlock
   ```

   According to Terraform documentation, you CAN reference nested block attributes:

   - `aws_instance.example.ebs_block_device[*].device_name` - references nested block attributes
   - Nested blocks can have exported attributes that are accessible
   - Example: `site_credential` block in azurerm_windows_web_app_slot is exported as an attribute

   **Decision: Keep TerraformReference using TerraformBlock** - it needs to accept both top-level blocks AND potentially nested blocks in the future.

3. **ValidationError** - Validation errors for top-level blocks:

   ```csharp
   // Current:
   public TerraformBlock? Construct { get; }

   // Could be:
   public ITerraformTopLevelBlock? Block { get; }
   ```

   This makes sense because validation errors with reflection are specifically for top-level blocks with names/types.

4. **TerraformValidator** - Only validates top-level blocks:

   ```csharp
   // Current:
   public static ValidationResult Validate(TerraformBlock construct) { ... }

   // Could be:
   public static ValidationResult Validate(ITerraformTopLevelBlock block) { ... }
   ```

**Not Applicable:**

- Nested blocks like `TerraformLifecycleConfig`, `TerraformCloudBlock`, `TerraformBackend`, etc. should continue inheriting from `TerraformBlock`
- These don't have top-level block characteristics (no labels, not added to stack directly)

**Benefits:**

- ✅ Clearer type constraints (compile-time enforcement of what can go in a stack)
- ✅ Better API documentation (shows intent)
- ✅ Enables using `BlockType` and `BlockLabels` properties without casting
- ✅ Prevents accidentally adding nested blocks to stack

---

### 3. **Eliminate Reflection in Meta-Argument Validation**

**Problem:** `TerraformValidator.ValidateMetaArguments()` uses reflection to check Count/ForEach, plus legacy "construct" naming.

**Current Code:**

```csharp
if (construct is Constructs.MetaArguments.ITerraformHasCount &&
    construct is Constructs.MetaArguments.ITerraformHasForEach)
{
    var constructType = construct.GetType();
    var countProperty = constructType.GetProperty("Count");
    var forEachProperty = constructType.GetProperty("ForEach");
    var count = countProperty?.GetValue(construct);
    var forEach = forEachProperty?.GetValue(construct);

    if (count != null && forEach != null) { /* error */ }
}
```

**Recommendation:** Update existing marker interfaces to expose the properties/methods that the source generator creates.

```csharp
// In ITerraformMetaArguments.cs - Update existing interfaces
public interface ITerraformHasCount
{
    /// <summary>
    /// Gets or sets the count meta-argument. Implemented by source generator.
    /// </summary>
    TerraformValue<int>? Count { get; set; }
}

public interface ITerraformHasForEach
{
    /// <summary>
    /// Gets or sets the for_each meta-argument. Implemented by source generator.
    /// </summary>
    TerraformValue<object>? ForEach { get; set; }
}
```

Then validator becomes simple without reflection:

```csharp
private static void ValidateMetaArguments(TerraformBlock block, List<ValidationError> errors)
{
    // Check if block implements both count and for_each
    if (block is ITerraformHasCount hasCount && block is ITerraformHasForEach hasForEach)
    {
        // Direct property access - no reflection needed!
        if (hasCount.Count != null && hasForEach.ForEach != null)
        {
            errors.Add(new ValidationError(
                "Cannot use both 'count' and 'for_each' meta-arguments. They are mutually exclusive.",
                ValidationSeverity.Error,
                block,
                "meta-arguments"));
        }
    }
}
```

**Benefits:**

- ✅ No reflection
- ✅ AOT-compatible
- ✅ Type-safe
- ✅ Direct property access through existing interfaces
- ✅ No new interfaces needed - just expose what source generator already creates
- ✅ Removes "construct" terminology

---

### 4. **Eliminate Reflection in Dynamic Block Extensions**

**Problem:** `TerraformProvisionableConstructExtensions.WithDynamicBlock()` uses reflection, and the naming is outdated ("Construct" vs "Block").

**Current Code:**

```csharp
var dynamicBlocksProperty = typeof(TConstruct).GetProperty("DynamicBlocks");
var dynamicBlocks = dynamicBlocksProperty?.GetValue(construct) as List<TerraformDynamicBlock>;
dynamicBlocks?.Add(dynamicBlock);
```

**Recommendation:**

1. Rename `TerraformProvisionableConstructExtensions` → `TerraformProvisionableBlockExtensions`
2. Update interface to expose property
3. Remove reflection

```csharp
// Update interface
public interface ITerraformHasDynamicBlocks
{
    /// <summary>
    /// Gets the list of dynamic blocks for this block.
    /// </summary>
    List<TerraformDynamicBlock> DynamicBlocks { get; }
}

// Source generator generates:
partial class TerraformResource : ITerraformHasDynamicBlocks
{
    public List<TerraformDynamicBlock> DynamicBlocks { get; } = new();
}
```

Then extensions become simple:

```csharp
// Renamed file: TerraformProvisionableBlockExtensions.cs
public static class TerraformProvisionableBlockExtensions
{
    public static TBlock WithDynamicBlock<TBlock>(
        this TBlock block,
        string blockType,
        TerraformExpression forEach,
        Action<TerraformDynamicBlockBuilder> configure)
        where TBlock : ITerraformHasDynamicBlocks
    {
        var dynamicBlock = new TerraformDynamicBlock(blockType, forEach);
        var builder = new TerraformDynamicBlockBuilder(dynamicBlock, blockType);
        configure(builder);

        block.DynamicBlocks.Add(dynamicBlock);  // No reflection!

        return block;
    }
}
```

**Benefits:**

- ✅ No reflection
- ✅ Cleaner code
- ✅ AOT-compatible
- ✅ Consistent "block" terminology

---

### 5. **Simplify TerraformValueResolver Reflection**

**Problem:** `TerraformValueResolver.ResolveTerraformValue()` uses reflection to call `Resolve()`.

**Current Code:**

```csharp
private static bool IsTerraformValue(object value)
{
    var type = value.GetType();
    return type.IsGenericType &&
           type.GetGenericTypeDefinition() == typeof(TerraformValue<>);
}

private static TerraformExpression ResolveTerraformValue(object terraformValue, ITerraformContext? context)
{
    // Uses reflection to call Resolve method...
}
```

**Recommendation:** Already fixed! The `ITerraformValue` marker interface exists:

```csharp
// Values/ITerraformValue.cs
/// <summary>
/// Marker interface for TerraformValue&lt;T&gt; to enable non-reflection based value resolution.
/// </summary>
public interface ITerraformValue
{
    TerraformExpression Resolve(ITerraformResolveContext context);
}
```

Just update the resolver:

```csharp
public static TerraformExpression ResolveValue(object? value, ITerraformContext? context)
{
    return value switch
    {
        null => TerraformExpression.Raw("null"),
        TerraformExpression expr => expr,

        // Use interface instead of reflection
        ITerraformValue terraformValue => ResolveTerraformValue(terraformValue, context),

        ITerraformResolvable resolvable => ResolveResolvableValue(resolvable, context),
        IDictionary dict => ResolveDictionary(dict, context),
        IEnumerable enumerable and not string => ResolveEnumerable(enumerable, context),
        _ => TerraformExpression.FromObject(value)
    };
}

private static TerraformExpression ResolveTerraformValue(ITerraformValue terraformValue, ITerraformContext? context)
{
    ITerraformResolveContext resolveContext = context is ITerraformResolveContext rc
        ? rc
        : new TerraformResolveContext(context);

    return terraformValue.Resolve(resolveContext);  // No reflection!
}

// Remove IsTerraformValue() method entirely
```

**Benefits:**

- ✅ No reflection
- ✅ Simpler code
- ✅ Faster
- ✅ Uses existing interface

---

---

### 6. **Simplify Public API by Using TerraformValue<T> Instead of TerraformExpression**

**Problem:** Many public APIs expose `TerraformExpression` directly, requiring multiple overloads and making the API less type-safe.

**Current Issues:**

1. **Tf.Functions has many duplicate overloads:**

```csharp
// Current: Two overloads for every function
public static TerraformExpression File(string path) { ... }
public static TerraformExpression File(TerraformExpression path) { ... }

public static TerraformExpression Element(TerraformExpression list, TerraformExpression index) { ... }
public static TerraformExpression Element(TerraformExpression list, int index) { ... }

public static TerraformExpression CidrSubnet(TerraformExpression prefix, int newbits, TerraformExpression netnum) { ... }
public static TerraformExpression CidrSubnet(string prefix, int newbits, int netnum) { ... }
```

2. **TerraformDynamicBlock exposes raw expressions:**

```csharp
public TerraformExpression ForEach { get; set; }  // Should be TerraformValue<object>
public Dictionary<string, TerraformExpression> Content { get; }  // Could be TerraformValue<object>
public List<TerraformExpression> Labels { get; }  // Could be TerraformValue<string>
```

3. **TerraformLifecycleConfig:**

```csharp
public TerraformExpression? ReplaceTriggeredBy { get; set; }  // Could be TerraformValue<object>
```

4. **DynamicBlockValueAccessor:**

```csharp
public TerraformExpression Iterator { get; }  // Could stay as-is (it's an identifier)
public TerraformExpression Key { get; }  // Could stay as-is (it's an identifier)
public TerraformExpression this[string attribute] { get; }  // Could stay as-is (dynamic access)
```

**Recommendation:** Use `TerraformValue<T>` for inputs, return `TerraformValue<T>` from functions.

**Benefits of TerraformValue<T>:**

- Implicit conversions from literals work automatically
- No need for multiple overloads
- Better type safety
- Clearer intent (value vs expression)
- Simpler API surface

**Proposed Changes:**

```csharp
// Tf.Functions - Single overload using TerraformValue<T>
public static TerraformValue<string> File(TerraformValue<string> path)
{
    return TerraformValue<string>.FromExpression(
        TerraformExpressionExtensions.Call("file", path));
}
// Usage: both work thanks to implicit conversion
// Tf.Functions.File("path.txt")
// Tf.Functions.File(someExpression)

public static TerraformValue<T> Element<T>(TerraformValue<object> list, TerraformValue<int> index)
{
    return TerraformValue<T>.FromExpression(
        TerraformExpressionExtensions.Call("element", list, index));
}

public static TerraformValue<string> CidrSubnet(
    TerraformValue<string> prefix,
    TerraformValue<int> newbits,
    TerraformValue<int> netnum)
{
    return TerraformValue<string>.FromExpression(
        TerraformExpressionExtensions.Call("cidrsubnet", prefix, newbits, netnum));
}

// TerraformDynamicBlock - use TerraformValue
public class TerraformDynamicBlock
{
    public TerraformValue<object> ForEach { get; set; }  // Now accepts literals OR expressions
    public Dictionary<string, TerraformValue<object>> Content { get; }  // Type-safe
    public List<TerraformValue<string>> Labels { get; }  // Type-safe
}

// TerraformLifecycleConfig
public class TerraformLifecycleConfig
{
    public TerraformValue<object>? ReplaceTriggeredBy { get; set; }  // Type-safe
}
```

**Impact:**

- **Tf.Functions:** ~30+ duplicate overloads eliminated
- **Cleaner API:** Users don't need to know about `TerraformExpression.Literal()`
- **Type Safety:** Compiler catches type mismatches
- **Better IntelliSense:** Shows expected types clearly

**Special Cases to Keep TerraformExpression:**

- `Tf.Helpers.EachValue`, `Tf.Helpers.EachKey`, `Tf.Helpers.Local()` - these return identifiers, not values
- `TerraformExpression` factory methods (Literal, Identifier, etc.) - these ARE the expression API
- `DynamicBlockValueAccessor` indexer - dynamic attribute access
- Internal resolution methods

**Breaking Change Considerations:**

- This is a **minor breaking change** for advanced users who explicitly use `TerraformExpression`
- Most users benefit from simpler API (implicit conversions just work)
- Migration is straightforward: wrap expressions in `TerraformValue<T>.FromExpression()`

---

## 🟢 Minor Improvements

### 7. **Remove Unused Using Statements**

Several files import `System.Reflection` but may not need it after refactoring:

- `Context/TerraformValueResolver.cs` - Can be removed after fix #5
- Others pending review

### 8. **Consolidate Error Messages and Remove "Construct" Terminology**

Error messages and display names are scattered, and many still use "construct" terminology. With `ITerraformTopLevelBlock`, centralize formatting:

```csharp
// Extension method
public static class TerraformTopLevelBlockExtensions
{
    /// <summary>
    /// Gets a display name in Terraform syntax.
    /// Examples:
    ///   resource "aws_instance" "example"
    ///   variable "region"
    ///   module "vpc"
    /// </summary>
    public static string GetDisplayName(this ITerraformTopLevelBlock block)
    {
        var labels = string.Join(" ", block.BlockLabels.Select(label => $"\"{label}\""));
        return $"{block.BlockType} {labels}";
    }
}
```

Use everywhere instead of reflection-based name building.

**Additional terminology cleanup needed:**

- `ValidationError.Construct` → `ValidationError.Block`
- All parameter names `construct` → `block`
- Method names like `GetConstructName` → `GetBlockName`
- Comments referring to "constructs" → "blocks"
- Interface names with "Construct" → "Block" (e.g., `ITerraformProvisionableConstruct` → leave as-is since it's a marker interface, or consider `ITerraformProvisionableBlock`)

### 9. **Namespace Cleanup**

Some confusion about namespace usage:

- Marker interfaces in `EmmittJ.Terraform.Sdk.Constructs.MetaArguments`
- But blocks in `EmmittJ.Terraform.Sdk.Constructs`
- Most classes in `EmmittJ.Terraform.Sdk` directly

**Recommendation:**

- **Rename:** `Constructs.MetaArguments` → `Blocks.MetaArguments` (align with "block" terminology)
- Keep all other classes in root namespace `EmmittJ.Terraform.Sdk`
- The `Constructs` namespace only has 2 files: `TerraformImportBlock`, `TerraformCheckBlock`
- Move those 2 files to `Blocks/` folder and root namespace
- Update all `using EmmittJ.Terraform.Sdk.Constructs.MetaArguments;` → `using EmmittJ.Terraform.Sdk.Blocks.MetaArguments;`

**Files to update:**

- `Resources/ITerraformMetaArguments.cs` - change namespace
- `Blocks/TerraformImportBlock.cs` - change namespace from `Constructs` to root
- `Blocks/TerraformCheckBlock.cs` - change namespace from `Constructs` to root
- All files with `using Constructs.MetaArguments;`

---

## 📊 Summary of Changes

### Files to Delete

1. ❌ `Resolution/TerraformReference.cs` - Duplicate, reflection-heavy

### Files to Create

1. ✅ `Context/ITerraformTopLevelBlock.cs` - Unified interface for top-level blocks

### Files to Rename

1. 📦 `Resources/TerraformProvisionableConstructExtensions.cs` → `Resources/TerraformProvisionableBlockExtensions.cs`

### Files to Modify (Major)

1. 📝 `TerraformResource.cs` - Implement `ITerraformTopLevelBlock`
2. 📝 `TerraformDataSource.cs` - Implement `ITerraformTopLevelBlock`
3. 📝 `TerraformModule.cs` - Implement `ITerraformTopLevelBlock`
4. 📝 `TerraformVariable.cs` - Implement `ITerraformTopLevelBlock`
5. 📝 `TerraformOutput.cs` - Implement `ITerraformTopLevelBlock`
6. 📝 `ValidationError.cs` - Rename `Construct` → `Block`, use `ITerraformTopLevelBlock` instead of reflection
7. 📝 `DependencyGraph.cs` - Rename methods/params, use `ITerraformTopLevelBlock` instead of reflection
8. 📝 `TerraformValueResolver.cs` - Use `ITerraformValue` interface instead of reflection
9. 📝 `TerraformValidator.cs` - Update meta-argument validation to use interface properties, rename parameters
10. 📝 `ITerraformMetaArguments.cs` - Add property signatures to marker interfaces (Count, ForEach, DynamicBlocks, etc.), change namespace
11. 📝 `TerraformProvisionableBlockExtensions.cs` - Remove reflection, rename classes/params, use interface
12. 📝 `Tf.cs` - Update all `Functions` to use `TerraformValue<T>` instead of `TerraformExpression`, eliminate ~30+ duplicate overloads
13. 📝 `TerraformDynamicBlock.cs` - Change properties to use `TerraformValue<T>`
14. 📝 `TerraformLifecycleConfig.cs` - Change `ReplaceTriggeredBy` to use `TerraformValue<object>`

### Source Generator Changes

1. 📝 Generate `DynamicBlocks` property with public getter
2. 📝 Generate `Count`, `ForEach`, `DependsOn`, etc. properties with public getters/setters
3. 📝 Ensure all source-generated properties match the interface signatures

### Files to Move/Update Namespace

1. 📦 `Resources/ITerraformMetaArguments.cs` - Change namespace from `Constructs.MetaArguments` → `Blocks.MetaArguments`
2. 📦 `Blocks/TerraformImportBlock.cs` - Change namespace from `Constructs` to root `EmmittJ.Terraform.Sdk`
3. 📦 `Blocks/TerraformCheckBlock.cs` - Change namespace from `Constructs` to root `EmmittJ.Terraform.Sdk`

### Global Find/Replace Needed

1. 🔄 `using EmmittJ.Terraform.Sdk.Constructs.MetaArguments;` → `using EmmittJ.Terraform.Sdk.Blocks.MetaArguments;`
2. 🔄 Parameter/variable names: `construct` → `block` (in validation/dependency code)
3. 🔄 Method names: `GetConstructName` → `GetBlockName`, etc.
4. 🔄 Comments: "construct" → "block" where referring to Terraform blocks

---

## 🎯 Impact Metrics

**Reflection Usage:**

- **Before:** ~15+ reflection call sites
- **After:** 0 reflection calls for block name/type/meta-arguments
- **Performance:** Estimated 2-5x faster for validation and dependency analysis
- **AOT:** Fully compatible with Native AOT compilation

**Code Complexity:**

- **Lines Removed:** ~200 (including ~30+ duplicate function overloads)
- **Lines Added:** ~120
- **Net Reduction:** ~80 lines
- **Maintainability:** Significantly improved
- **API Simplicity:** Single overload per function instead of 2-3

**Type Safety:**

- All previously dynamic/reflection access now compile-time checked
- IDE autocomplete works everywhere
- Refactoring tools work correctly
- Function return types are now typed (e.g., `TerraformValue<string>` instead of `TerraformExpression`)

**Terminology Consistency:**

- **Before:** Mixed use of "construct" and "block" terminology
- **After:** Consistent use of official Terraform terminology throughout
  - **Blocks**: Containers for content (have a type and optional labels)
  - **Block types**: Keywords like `resource`, `data`, `variable`, `module`, `output`
  - **Labels**: Identifiers following the block type
  - **Arguments**: Name-value pairs within blocks (not "attributes")
- **Clearer API:** Uses exact Terraform configuration syntax terminology

**API Improvements:**

- **Before:** Users need multiple overloads and explicit `TerraformExpression.Literal()` calls
- **After:** Single overload with implicit conversions, cleaner usage
- **Example:**

  ```csharp
  // Before: Multiple overloads, explicit conversion
  Tf.Functions.File(TerraformExpression.Literal("path.txt"))
  Tf.Functions.File("path.txt")  // Needs separate overload

  // After: One overload, implicit conversion
  Tf.Functions.File("path.txt")  // Just works
  Tf.Functions.File(someExpression)  // Also works
  ```

---

## 🚀 Implementation Priority

### Phase 1: Quick Wins (1-2 hours) ✅ COMPLETE

1. ✅ Delete `Resolution/TerraformReference.cs` (verified no usages)
2. ✅ Fix `TerraformValueResolver` to use `ITerraformValue` interface
3. ✅ Remove unused `using System.Reflection` statements

### Phase 2: Core Refactoring (3-4 hours) ✅ COMPLETE

1. ✅ Create `ITerraformTopLevelBlock` interface
2. ✅ Implement on all top-level blocks (TerraformResource, TerraformDataSource, TerraformModule, TerraformVariable, TerraformOutput)
3. ✅ Update `ValidationError` to use interface and rename `Construct` → `Block`
4. ✅ Update `DependencyGraph` to use interface and rename methods/parameters
5. ✅ Global terminology cleanup: rename "construct" → "block" in parameters, variables (TerraformValidator, ValidationResult)

### Phase 3: Meta-Arguments (2-3 hours) ✅ COMPLETE

1. ✅ Update `ITerraformHasDynamicBlocks` to expose `DynamicBlocks` property
2. ✅ Update `ITerraformHasCount` to expose `Count` property
3. ✅ Update `ITerraformHasForEach` to expose `ForEach` property
4. ✅ Update other meta-argument marker interfaces similarly (DependsOn, Lifecycle, Provider)
5. ✅ Rename `TerraformProvisionableConstructExtensions` → `TerraformProvisionableBlockExtensions` (class name updated in file)
6. ✅ Remove reflection from extensions and validator, update parameter names
7. ⏭️ Update namespaces: `Constructs.MetaArguments` → `Blocks.MetaArguments` (deferred - would affect too many files)

### Phase 4: API Simplification (3-4 hours)

1. Update `ITerraformHasDynamicBlocks` to expose `DynamicBlocks` property
2. Update `ITerraformHasCount` to expose `Count` property
3. Update `ITerraformHasForEach` to expose `ForEach` property
4. Update other meta-argument marker interfaces similarly (DependsOn, Lifecycle, etc.)
5. Rename `TerraformProvisionableConstructExtensions` → `TerraformProvisionableBlockExtensions`
6. Remove reflection from extensions and validator, update parameter names
7. Update namespaces: `Constructs.MetaArguments` → `Blocks.MetaArguments`

### Phase 4: API Simplification (3-4 hours) ✅ COMPLETE

1. ✅ Update `Tf.Functions` to use `TerraformValue<T>` parameters and return types
   - All ~15 functions updated with proper typed overloads
   - `Length` has 4 overloads for `TerraformList<T>`, `TerraformMap<T>`, `TerraformSet<T>`, `TerraformValue<string>`
   - `ToString`, `ToNumber`, `ToBool` use generic `TerraformValue<T>`
   - `ToList`, `ToMap`, `ToSet` have specific collection type overloads
   - `Format` uses `TerraformValue<T>[]` for arguments
   - `Function` has two generic type parameters `<TResult, TArg>`
2. ✅ Remove duplicate overloads - eliminated ~20+ duplicate overloads
3. ✅ Update `TerraformDynamicBlock` to use `ITerraformValue` for ForEach and Content, `TerraformValue<string>` for Labels
4. ✅ Update `TerraformLifecycleConfig.ReplaceTriggeredBy` to use `ITerraformValue`
5. ✅ Update extension methods in `TerraformProvisionableConstructExtensions` to use `ITerraformValue`
6. ✅ Test implicit conversions work correctly - full SDK build successful

### Phase 5: Polish (1 hour)

1. Move files from `Constructs` namespace to appropriate locations
2. Update all `using` statements
3. Add helper extension methods
4. Update documentation and XML comments
5. Final terminology review

**Total Estimated Effort:** 10-14 hours

---

## ⚠️ Breaking Changes

### Minimal Breaking Changes Expected:

- Deleting `Resolution/TerraformReference.cs` only breaks code if it was used directly (unlikely, superseded)
- All other changes are additive or internal
- Source generator changes are transparent to users

### Migration Guide:

If anyone was using `Resolution.TerraformReference`:

```csharp
// Old (delete)
var reference = new TerraformReference(resource, "name");

// New (use typed version)
var reference = new TerraformReference<string>(resource, "name");

// Or use expression
var reference = new TerraformReferenceExpression(resource, "name");
```

**Terminology Changes:**

- Code previously using "construct" now uses official Terraform terminology ("blocks", "labels", "arguments")
- Interface namespace: `Constructs.MetaArguments` → `Blocks.MetaArguments`
- Extension class: `TerraformProvisionableConstructExtensions` → `TerraformProvisionableBlockExtensions`
- Property naming aligned with Terraform docs:
  - "Block type" = keyword like `resource`, `data`, etc.
  - "Labels" = identifiers after block type
  - "Arguments" = name-value pairs in block body (we were correctly using this already)
- These are mostly internal/advanced API changes - basic usage remains the same

**API Simplification Changes:**

- `Tf.Functions.*` methods now accept and return `TerraformValue<T>` instead of `TerraformExpression`
- Duplicate overloads removed - implicit conversions handle both literals and expressions
- `TerraformDynamicBlock` properties use `TerraformValue<T>` instead of `TerraformExpression`
- Migration: Most code continues to work; explicit `TerraformExpression` usage needs `TerraformValue<T>.FromExpression()`
- **Benefit:** Simpler API, better type safety, cleaner code

---

## ✅ Testing Strategy

1. **Unit Tests:** Verify all refactored components
2. **Integration Tests:** Ensure generated code still works
3. **Performance Tests:** Measure reflection elimination impact
4. **AOT Tests:** Verify Native AOT compatibility

---

## 📚 Additional Notes

### Why This Matters

The SDK is used to generate Terraform configurations at runtime. Every reflection call:

- Adds runtime overhead
- Prevents AOT compilation
- Reduces type safety
- Makes code harder to understand
- Complicates debugging

Additionally, inconsistent terminology creates confusion. Terraform's official documentation defines specific terms:

- **Blocks**: Containers with a type keyword, optional labels, and a body
- **Block types**: Keywords like `resource`, `data`, `variable`, `module`, `output`
- **Labels**: Identifiers after the block type (e.g., resource type and name)
- **Arguments**: Name-value pairs within block bodies

Using the exact terminology from HashiCorp's documentation makes the SDK:

- ⚡ Faster (no reflection overhead)
- 🔒 More type-safe (compile-time checking)
- 🎯 AOT-compatible (no dynamic type inspection)
- 📖 Easier to understand (matches official Terraform docs exactly)
- 🐛 Easier to debug (clear, standard terminology)
- 🎓 More intuitive for users familiar with Terraform (same vocabulary)

### Architecture Philosophy

The SDK already has excellent infrastructure with:

- Marker interfaces for meta-arguments
- Source generator for property generation
- Expression system for HCL generation

This refactoring simply **uses that infrastructure better** instead of working around it with reflection.
