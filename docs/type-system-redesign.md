# Terraform SDK Type System Redesign

## Problem Statement

The current type system is overly complicated with multiple property types (`TerraformLiteralProperty<T>`, `TerraformExpressionProperty<T>`, `TerraformReferenceProperty<T>`) that create friction for users. The goal is to support a simple, ergonomic API like:

```csharp
// Should "just work" - accept literals
containerApp.Name = "my-app";
containerApp.Capacity = 2;

// Should "just work" - accept references
containerApp.ResourceGroupName = resourceGroup.Name;

// Should "just work" - accept expressions
containerApp.ContainerAppEnvironmentId = TerraformExpression.Identifier("azurerm_container_app_environment.container-env.id");

// Should "just work" - accept variables
containerApp.AdministratorPassword = passwordVar.AsReference();
```

## Type System Flow

The new design has a clear three-layer architecture:

```
User Code (Compile-Time)
    ↓
    Uses: TerraformValue<T> (where T = string, double, bool, etc.)
    │
    ├─ Accepts: T (literal value) via implicit conversion
    ├─ Accepts: ITerraformResolvable via implicit conversion
    └─ Accepts: TerraformExpression via implicit conversion

Resolution Phase (Runtime)
    ↓
    TerraformValue<T>.Resolve(context) → TerraformExpression
    │
    ├─ TerraformLiteralValue<T>.Resolve() → LiteralExpression<T>
    ├─ TerraformReference.Resolve() → IdentifierExpression
    ├─ TerraformLazyValue.Resolve() → TerraformExpression (from producer)
    └─ TerraformExpression.Resolve() → itself (already an expression)

Serialization Phase (Runtime)
    ↓
    TerraformExpression.ToHcl(context) → string (HCL code)
    │
    ├─ Prepare(context) - track dependencies, validate structure
    └─ ToHcl(context) - serialize to HCL string
```

**Key Insight**: Everything resolves to `TerraformExpression`, which is the unified representation of all HCL expressions. The generic `T` in `TerraformValue<T>` is ONLY for compile-time type safety when assigning values.

## AWS CDK's Solution

AWS CDK solves this with a **Token system** that provides:

### Key Concepts

1. **`IResolvable` Interface** - The base contract for anything that can be lazily resolved

   ```typescript
   interface IResolvable {
     resolve(context: IResolveContext): any;
     toString(): string;
     readonly creationStack: string[];
   }
   ```

2. **`Token` Static Class** - Provides encoding/decoding of resolvables into primitive types

   ```typescript
   Token.asString(value); // Returns string, encoding token if needed
   Token.asNumber(value); // Returns number, encoding token if needed
   Token.asList(value); // Returns string[], encoding token if needed
   ```

3. **Type Union Pattern** - Properties accept primitives OR resolvables

   ```typescript
   readonly bucketName: string;  // Can be literal "my-bucket" OR Token.asString(...)
   readonly capacity: number;    // Can be literal 5 OR Token.asNumber(...)
   ```

4. **Intrinsic Class** - Wraps values that resolve to themselves
   ```typescript
   class Intrinsic implements IResolvable {
     constructor(private value: any) {}
     resolve(_context: IResolveContext) {
       return this.value;
     }
   }
   ```

### How It Works

1. User provides **either** a primitive value OR a resolvable
2. Properties store the value as-is (string/number/etc)
3. During synthesis, `resolve()` walks the tree:
   - Primitives pass through unchanged
   - Encoded tokens are decoded and `resolve()` is called recursively
4. Final output is pure primitives ready for serialization

### Benefits

- **Simple API**: Properties are just `string`, `int`, `bool`, etc.
- **No wrapper types**: No `TerraformProperty<T>` in user-facing API
- **Type safety**: C# compiler enforces correct types
- **Flexibility**: Accepts literals, references, expressions seamlessly
- **Two-phase**: Prepare phase for dependencies, resolve phase for values

## Proposed Terraform SDK Design

### Core Interfaces

```csharp
/// <summary>
/// Base interface for anything that can be resolved to a TerraformExpression during synthesis.
/// All resolvables produce expressions that can be serialized to HCL.
/// </summary>
public interface ITerraformResolvable
{
    /// <summary>
    /// Resolve this object to a TerraformExpression.
    /// Called during the ToHcl phase.
    /// </summary>
    TerraformExpression Resolve(ITerraformResolveContext context);
}

/// <summary>
/// Context provided during Terraform value resolution.
/// </summary>
public interface ITerraformResolveContext
{
    /// <summary>
    /// The current scope being resolved.
    /// </summary>
    TerraformConstruct Scope { get; }
}
```

### TerraformValue<T> - The Core Type

```csharp
/// <summary>
/// Represents a Terraform value that can be a literal or a resolvable token.
/// This is the primary type used for all Terraform resource properties.
///
/// The generic T provides compile-time type safety for what type of value
/// this represents in Terraform (string, double, bool, etc.), but all values
/// ultimately resolve to TerraformExpression for HCL serialization.
///
/// Think of it as: TerraformValue&lt;string&gt; means "a value that represents
/// a string in Terraform", not "a value that IS a string at runtime".
/// </summary>
/// <typeparam name="T">The .NET type this value represents (string, double, bool, etc.) - used for compile-time safety</typeparam>
public readonly struct TerraformValue<T>
{
    private readonly ITerraformResolvable _resolvable;

    private TerraformValue(ITerraformResolvable resolvable)
    {
        _resolvable = resolvable ?? throw new ArgumentNullException(nameof(resolvable));
    }

    /// <summary>
    /// Resolve this value to a TerraformExpression.
    /// Note: Always returns TerraformExpression regardless of T.
    /// </summary>
    internal TerraformExpression Resolve(ITerraformResolveContext context)
    {
        return _resolvable.Resolve(context);
    }

    // Implicit conversion from literal value - wrap in a resolvable
    public static implicit operator TerraformValue<T>(T value)
        => new TerraformValue<T>(new TerraformLiteralValue<T>(value));

    // Implicit conversion from any resolvable
    public static implicit operator TerraformValue<T>(ITerraformResolvable resolvable)
        => new TerraformValue<T>(resolvable);

    // Direct conversion from TerraformExpression (which implements ITerraformResolvable)
    public static implicit operator TerraformValue<T>(TerraformExpression expression)
        => new TerraformValue<T>(expression);
}

/// <summary>
/// Static helper class for creating TerraformValue instances.
/// </summary>
public static class TerraformValue
{
    /// <summary>
    /// Create a TerraformValue from a literal value.
    /// </summary>
    public static TerraformValue<T> FromLiteral<T>(T value)
        => value;

    /// <summary>
    /// Create a TerraformValue from any resolvable.
    /// </summary>
    public static TerraformValue<T> FromResolvable<T>(ITerraformResolvable resolvable)
        => resolvable;

    /// <summary>
    /// Create a TerraformValue from an expression.
    /// </summary>
    public static TerraformValue<T> FromExpression<T>(TerraformExpression expression)
        => expression;
}
```

### Resolvable Implementations

````csharp
/// <summary>
/// Wraps a literal value and resolves it to a LiteralExpression.
/// Used internally by TerraformValue when a literal is assigned.
/// </summary>
internal class TerraformLiteralValue<T> : ITerraformResolvable
{
    private readonly T? _value;

    public TerraformLiteralValue(T? value)
    {
        _value = value;
    }

    public TerraformExpression Resolve(ITerraformResolveContext context)
    {
        return TerraformExpression.Literal(_value);
    }
}

/// <summary>
/// Represents a lazy Terraform value that will be computed during resolution.
/// The producer function must return a TerraformExpression.
/// </summary>
public class TerraformLazyValue : ITerraformResolvable
{
    private readonly Func<ITerraformResolveContext, TerraformExpression> _producer;

    public TerraformLazyValue(Func<ITerraformResolveContext, TerraformExpression> producer)
    {
        _producer = producer ?? throw new ArgumentNullException(nameof(producer));
    }

    public TerraformExpression Resolve(ITerraformResolveContext context)
    {
        return _producer(context);
    }
}
```### Resource Property Pattern

Properties use `TerraformValue<T>` which accepts literals or resolvables via implicit conversion:

```csharp
public class AzurermContainerApp : TerraformResource
{
    public AzurermContainerApp(string name) : base("azurerm_container_app", name) { }

    // Required string property - accepts literal OR resolvable via implicit conversion
    [TerraformPropertyName("name")]
    public required TerraformValue<string> Name { get; set; }

    // Number property - accepts literal OR resolvable
    [TerraformPropertyName("capacity")]
    public TerraformValue<double>? Capacity { get; set; }

    // Optional string property
    [TerraformPropertyName("resource_group_name")]
    public TerraformValue<string>? ResourceGroupName { get; set; }

    // Computed properties return TerraformReference which resolves to TerraformExpression
    [TerraformPropertyName("id")]
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    // Complex property (nested block) - regular POCO
    [TerraformPropertyName("template")]
    public AzurermContainerAppTemplateBlock? Template { get; set; }
}

public class AzurermContainerAppTemplateBlock
{
    [TerraformPropertyName("max_replicas")]
    public TerraformValue<double>? MaxReplicas { get; set; }

    [TerraformPropertyName("min_replicas")]
    public TerraformValue<double>? MinReplicas { get; set; }
}
````

### TerraformReference (Represents References to Other Resources)

```csharp
/// <summary>
/// Represents a reference to a Terraform resource attribute.
/// Resolves to a TerraformExpression (identifier) during synthesis.
/// </summary>
public class TerraformReference : ITerraformResolvable
{
    private readonly TerraformConstruct _construct;
    private readonly string _attributeName;

    public TerraformReference(TerraformConstruct construct, string attributeName)
    {
        _construct = construct ?? throw new ArgumentNullException(nameof(construct));
        _attributeName = attributeName ?? throw new ArgumentNullException(nameof(attributeName));
    }

    public TerraformExpression Resolve(ITerraformResolveContext context)
    {
        // Create an identifier expression for this reference
        // Will be serialized to HCL like: azurerm_resource_group.rg.name
        return TerraformExpression.Identifier(
            $"{_construct.ConstructType}.{_construct.ConstructName}.{_attributeName}"
        );
    }
}
```

### TerraformExpression (Base Class for All Expressions)

The `TerraformExpression` class is the base for all HCL expressions. It implements `ITerraformSerializable` which provides two-phase synthesis:

```csharp
/// <summary>
/// Base class for all Terraform expressions (AST nodes).
/// Expressions are syntax trees that can be rendered to HCL strings.
/// Implements ITerraformSerializable to support two-phase resolution (Prepare → ToHcl).
/// </summary>
public abstract class TerraformExpression : ITerraformSerializable
{
    /// <summary>
    /// Preparation phase - prepares nested expressions and records dependencies.
    /// </summary>
    public virtual void Prepare(ITerraformContext context)
    {
        // Base implementation does nothing - leaf expressions don't need preparation
    }

    /// <summary>
    /// Converts expression to HCL string with optional context for indentation.
    /// </summary>
    public abstract string ToHcl(ITerraformContext? context = null);

    // Factory methods for creating expressions
    public static TerraformExpression Literal<T>(T value) => new LiteralExpression<T>(value);
    public static TerraformExpression Identifier<T>(T value, Func<T, string>? resolver = null)
        => new TerraformIdentifierExpression<T>(value, resolver);

    // ... many more factory methods and operators
}
```

**Key Points:**

- `TerraformExpression` does NOT need to implement `ITerraformResolvable` - it IS the resolved output
- Expressions are already the final form that gets serialized to HCL
- The two phases are: `Prepare()` (track dependencies) → `ToHcl()` (serialize)

## Expression System Validation

Let's verify the expression system makes sense with the new design:

### Current Expression Architecture ✅

The existing `TerraformExpression` class hierarchy is **perfect** for our needs:

1. **Base Class**: `TerraformExpression : ITerraformSerializable`

   - Abstract base for all HCL expressions (literals, identifiers, operations, etc.)
   - Two-phase: `Prepare(context)` → `ToHcl(context)`
   - Does NOT implement `ITerraformResolvable` because it IS the final resolved form

2. **Concrete Expression Types** (all inherit from `TerraformExpression`):

   - `LiteralExpression<T>` - primitive values (string, int, bool, etc.)
   - `IdentifierExpression` - references like `var.region` or `aws_vpc.main.id`
   - `BinaryExpression` - operations like `a + b`, `x == y`
   - `ConditionalExpression` - ternary `condition ? true_val : false_val`
   - `ForExpression` - list/map comprehensions `[for x in list : x.id]`
   - `FunctionCallExpression` - built-in functions `length(var.list)`
   - `MemberAccessExpression` - attribute access `resource.attribute`
   - `IndexExpression` - indexing `list[0]`, `map["key"]`
   - `StringInterpolationExpression` - `"prefix-${var.name}-suffix"`
   - And more...

3. **Factory Methods**: `TerraformExpression` has static factory methods

   ```csharp
   TerraformExpression.Literal(42)
   TerraformExpression.Identifier("var.region")
   TerraformExpression.ForList(collection, item => item["id"])
   ```

4. **Implicit Conversions**: `TerraformExpression` has implicit operators

   ```csharp
   TerraformExpression expr = "hello";  // → Literal("hello")
   TerraformExpression expr = 42;       // → Literal(42)
   TerraformExpression expr = true;     // → Literal(true)
   ```

5. **Operator Overloads**: Expressions support arithmetic and comparison
   ```csharp
   var sum = expr1 + expr2;        // → BinaryExpression(Add)
   var comparison = expr1 == expr2; // → BinaryExpression(Equal)
   ```

### How It Integrates with TerraformValue<T> ✅

The integration is clean and logical:

```csharp
// Property definition
public TerraformValue<string> Name { get; set; }

// Assignment scenarios:
Name = "literal";                    // → TerraformLiteralValue<string> → LiteralExpression<string>
Name = resourceGroup.NameReference;  // → TerraformReference → IdentifierExpression
Name = TerraformExpression.Interpolate("prefix-", var, "-suffix"); // → StringInterpolationExpression

// Resolution flow:
TerraformValue<string>.Resolve(context)
    → ITerraformResolvable.Resolve(context)
    → TerraformExpression (one of the concrete types above)
    → TerraformExpression.ToHcl(context)
    → string (HCL code)
```

### Why This Design Works ✅

1. **Separation of Concerns**:

   - `TerraformValue<T>` = compile-time type safety wrapper
   - `ITerraformResolvable` = runtime resolution contract
   - `TerraformExpression` = HCL expression AST
   - Clear responsibilities, no overlap

2. **Natural Flow**:

   - User assigns value → `TerraformValue<T>` wraps it in resolvable
   - Synthesis calls `Resolve()` → produces `TerraformExpression`
   - Expression tree calls `ToHcl()` → produces HCL string
   - Each step has a single responsibility

3. **Extensibility**:

   - Add new expression types by inheriting `TerraformExpression`
   - Add new resolvable types by implementing `ITerraformResolvable`
   - `TerraformValue<T>` accepts them all via implicit conversion

4. **Type Safety**:
   - `TerraformValue<string>` only accepts string-compatible values (compile-time)
   - All resolvables produce `TerraformExpression` (runtime)
   - HCL generation is unified through `ToHcl()` (serialization)

### Conclusion ✅

The expression system is **well-designed and doesn't need changes**. It:

- Already has the right abstractions (`TerraformExpression` as base, concrete types inherit)
- Already has the right lifecycle (`Prepare` → `ToHcl`)
- Already has rich expression support (operators, functions, comprehensions, etc.)
- Integrates perfectly with the new `TerraformValue<T>` system

**No changes needed to the expression system!** We just need to implement:

1. `ITerraformResolvable` interface (non-generic, returns `TerraformExpression`)
2. `TerraformValue<T>` struct (wraps resolvables, provides type safety)
3. Helper resolvables (`TerraformLiteralValue<T>`, `TerraformReference`, `TerraformLazyValue`)

### Usage Examples

````csharp
// Example 1: Simple literal values - implicit conversion from T to TerraformValue<T>
var containerApp = new AzurermContainerApp("my-app")
{
    Name = "aspire-my-app",      // string → TerraformValue<string> (literal)
    Capacity = 2,                // int → TerraformValue<double> (literal)
    ResourceGroupName = "my-rg"  // string → TerraformValue<string> (literal)
};

// Example 2: Reference another resource - implicit conversion from IResolvable<T>
var resourceGroup = new AzurermResourceGroup("rg")
{
    Name = "aspire-rg",
    Location = "eastus"
};

var containerApp = new AzurermContainerApp("my-app")
{
    Name = "aspire-my-app",
    // resourceGroup.Name returns TerraformValue<string> containing TerraformReference
    // TerraformReference resolves to IdentifierExpression
    // which implicitly converts to TerraformValue<string>
    ResourceGroupName = resourceGroup.Name
};

// Example 3: Use a variable
var passwordVar = new TerraformVariable("admin_password")
{
    Type = "string",
    Sensitive = true
};

var postgres = new AzurermPostgresqlFlexibleServer("db")
{
    Name = "my-db",
    // AsReference() returns TerraformReference<string> which implicitly converts
    AdministratorPassword = passwordVar.AsReference()
};

// Example 4: Use expressions - implicit conversion from TerraformExpression
var containerApp = new AzurermContainerApp("my-app")
{
    // TerraformExpression implements ITerraformResolvable, so implicit conversion works
    Name = TerraformExpression.Interpolate("aspire-", Tf.Var("environment"), "-app"),
    ContainerAppEnvironmentId = TerraformExpression.Identifier("azurerm_container_app_environment.env.id")
};

// Example 5: Conditional expressions - no wrapping needed
var containerApp = new AzurermContainerApp("my-app")
{
    // Directly assign expression - implicit conversion handles it
    InstanceType = TerraformExpression.Conditional(
        Tf.Var("is_production"),
        TerraformExpression.Literal("Standard_D2s_v3"),
        TerraformExpression.Literal("Standard_B1s")
    )
};

// Example 6: Lazy values
var containerApp = new AzurermContainerApp("my-app")
{
    Name = new TerraformLazyValue<string>(ctx =>
    {
        // Computed at resolution time
        return $"app-{ctx.Scope.ConstructName}";
    })
};
```

## Implementation Plan - Progress Update

**Status**: ✅ **COMPLETE! All collection wrapper types implemented and working!**

### Summary of Completed Work:

**Phase 1: Foundation** ✅ Complete
- Converted `TerraformValue<T>` from `readonly struct` to `class`
- Made constructor and field `protected` to enable inheritance
- Made `Resolve()` method `virtual` for polymorphic overriding

**Phase 2: Collection Types** ✅ Complete
- Implemented `TerraformList<T>` - inherits from `TerraformValue<IEnumerable<T>>`
- Implemented `TerraformSet<T>` - inherits from `TerraformValue<IEnumerable<T>>`
- Implemented `TerraformMap<T>` - inherits from `TerraformValue<IDictionary<string, T>>`
- Implemented `TerraformBlock<T>` - inherits from `TerraformMap<object>` (heterogeneous maps)

**Phase 3: Expression Factories** ✅ Complete
- Added `Set(IEnumerable<TerraformExpression>)` factory method
- Added `Map(IEnumerable<KeyValuePair<string, TerraformExpression>>)` factory method
- `List()` factory method already existed

**Phase 4: Serialization** ✅ Complete
- No changes needed! Existing `WriteProperties()` handles all collection types via polymorphism
- `IsTerraformValue()` correctly identifies all types (checks for generic `TerraformValue<>`)
- `ResolveTerraformValue()` calls polymorphic `Resolve()` method

**Phase 5: Provider Generation** ✅ Complete - **272 ERRORS RESOLVED!**
- ✅ SDK project builds successfully
- ✅ Providers regenerated successfully
- ✅ **All 4 provider libraries compile with ZERO errors:**
  - AWS: 1561 resources, 630 data sources ✅
  - AzureRM: 1120 resources, 399 data sources ✅
  - Google: 1125 resources, 387 data sources ✅
  - AzureAD: 53 resources, 20 data sources ✅

### Design Validation

✅ **The inheritance-based design is validated!**
- All collection types inherit from `TerraformValue<T>` and integrate seamlessly
- No special-casing needed in serialization - polymorphism handles everything
- TerraformBlock<T> leveraging TerraformMap<object> infrastructure works perfectly
- Generated provider code compiles without modification

### Lessons Learned:

1. **Class vs Struct**: Converting to class was essential for inheritance
2. **No Interface Conversions**: C# doesn't allow implicit conversions from interfaces (`IEnumerable<T>`, `IDictionary<string,T>`)
   - Solution: Only provide conversions from concrete types (`List<T>`, `T[]`, `Dictionary<string,T>`)
3. **Ambiguous Method Calls**: Need explicit cast to `IEnumerable<TerraformExpression>` when calling factory methods that have both params and IEnumerable overloads
4. **Polymorphism FTW**: Existing serialization code "just works" with new types via polymorphic `Resolve()` calls

### Next Steps (Future Work):

1. **Update Playground**: Playground code uses old API - needs migration to new collection types
2. **Add Usage Examples**: Create comprehensive examples showing collection usage patterns
3. **Performance Testing**: Measure impact of class vs struct (likely negligible)
4. **Documentation**: Add XML docs with usage examples for collection types

---

## Completed Implementation

### Original Blocker: Missing Collection Wrapper Types

**Problem (RESOLVED)**: Generated provider code referenced collection wrapper types that hadn't been implemented yet:
- ❌ `TerraformList<T>` - **NOW IMPLEMENTED ✅**
- ❌ `TerraformSet<T>` - **NOW IMPLEMENTED ✅**
- ❌ `TerraformMap<T>` - **NOW IMPLEMENTED ✅**
- ❌ `TerraformBlock<T>` - **NOW IMPLEMENTED ✅**

**Template Code Generating These** (`TemplateHelpers.cs` lines 130-132):
```csharp
"list" => $"TerraformList<TerraformBlock<{block.ClassName}>>",
"set" => $"TerraformSet<TerraformBlock<{block.ClassName}>>",
"map" => $"TerraformMap<TerraformBlock<{block.ClassName}>>",
```

**Example Errors (ALL RESOLVED)**:
```
error CS0246: The type or namespace name 'TerraformSet<>' could not be found ❌ → ✅ FIXED
error CS0246: The type or namespace name 'TerraformList<>' could not be found ❌ → ✅ FIXED
error CS0246: The type or namespace name 'TerraformBlock<>' could not be found ❌ → ✅ FIXED
error CS0246: The type or namespace name 'TerraformMap<>' could not be found ❌ → ✅ FIXED
```

**Impact**: ✅ All 4 generated provider projects compile successfully (from 272 errors to ZERO)

---

## Original Implementation Plan

### Completed Work:

1. **Phase 1-2 (Foundation)**: ✅ Already completed before this work session
   - ITerraformResolvable, ITerraformResolveContext interfaces created
   - TerraformValue<T> struct implemented with implicit conversions
   - TerraformLiteralValue<T>, TerraformReference, TerraformLazyValue implemented
   - TerraformExpression implements ITerraformResolvable

2. **Phase 3 (Serialization)**: ✅ Complete
   - Updated TerraformConstruct.WriteProperties() to handle TerraformValue<T>
   - Removed TerraformProperty<T> handling (old classes already deleted)
   - Updated TerraformProvisionableConstruct to use TerraformValueResolver
   - Updated TerraformValueResolver to remove TerraformProperty references
   - Fixed TerraformSettings, TerraformProvider, TerraformImportBlock, TerraformMovedBlock, TerraformCheckBlock
   - SDK builds successfully ✅

3. **Phase 5 (Code Generation)**: ⚠️ Templates Updated, Providers Generated, **But Won't Compile**
   - MapTerraformTypeToCSharp already returns TerraformValue<T> for primitives
   - Updated TerraformConstruct.mustache to use TerraformReference for computed properties
   - Changed computed property generation from `new TerraformReferenceProperty<T>(this, "name")` to `new TerraformReference(this, "name")`
   - AppHost project builds successfully ✅
   - **Provider generation executed successfully:**
     - AWS: 1561 resources, 630 data sources
     - AzureRM: 1120 resources, 399 data sources
     - Google: 1125 resources, 387 data sources
     - AzureAD: 53 resources, 20 data sources
   - **⚠️ Generated providers fail to compile with 272 errors**

### Current Blocker: Missing Collection Wrapper Types

Generated provider code references collection wrapper types that **haven't been implemented yet**:
- `TerraformList<T>` - for list attributes (e.g., `TerraformList<string>`, `TerraformList<TerraformBlock<T>>`)
- `TerraformSet<T>` - for set attributes
- `TerraformMap<T>` - for map attributes
- `TerraformBlock<T>` - for nested block types

**Template Code Generating These** (`TemplateHelpers.cs` lines 130-132):
```csharp
"list" => $"TerraformList<TerraformBlock<{block.ClassName}>>",
"set" => $"TerraformSet<TerraformBlock<{block.ClassName}>>",
"map" => $"TerraformMap<TerraformBlock<{block.ClassName}>>",
```

**Example Errors**:
```
error CS0246: The type or namespace name 'TerraformSet<>' could not be found
error CS0246: The type or namespace name 'TerraformList<>' could not be found
error CS0246: The type or namespace name 'TerraformBlock<>' could not be found
error CS0246: The type or namespace name 'TerraformMap<>' could not be found
```

**Impact**: All 4 generated provider projects cannot compile (272 errors in AzureAD alone, smallest provider).

### Next Steps:

**STEP 1: Convert TerraformValue<T> from struct to class** ✅ **COMPLETE**
- ✅ Changed `public readonly struct TerraformValue<T>` to `public class TerraformValue<T>` in `src/EmmittJ.Terraform.Sdk/Values/TerraformValue.cs`
- ✅ Made constructor `protected` (allow inheritance)
- ✅ Made `_resolvable` field `protected readonly` (allow derived classes to access)
- ✅ Made `Resolve()` method `virtual` (allow overriding in derived classes)
- ✅ Removed nullable `ITerraformResolvable?` → use `ITerraformResolvable` (null checks via constructor)
- **Rationale**:
  - Structs cannot be inherited from in C# (blocks inheritance-based design)
  - Classes enable collection types to inherit from `TerraformValue<T>`
  - Matches Pulumi's proven `Input<T>` pattern (which is a class)
  - Reference semantics more appropriate for wrapper types (avoid copying overhead)
  - Natural nullability (`TerraformValue<string>?` is clearer than nullable struct)
- **Impact**:
  - All existing code continues to work (same API surface)
  - Enables collection types (TerraformList, TerraformSet, TerraformMap, TerraformBlock) to inherit
  - No breaking changes to generated provider code

**STEP 2: Implement collection wrapper types with inheritance** ✅ **COMPLETE**
- ✅ Created `TerraformList<T>` in `src/EmmittJ.Terraform.Sdk/Values/TerraformList.cs`
  - Inherits from `TerraformValue<IEnumerable<T>>`
  - Stores nested `TerraformValue<T>` elements internally to preserve unknowns
  - Overrides `Resolve()` for element-by-element resolution
  - Implements `IEnumerable` for collection initializer syntax
  - Implicit conversions from `List<T>`, `T[]`, `IEnumerable<T>`
- ✅ Created `TerraformSet<T>` in `src/EmmittJ.Terraform.Sdk/Values/TerraformSet.cs`
  - Inherits from `TerraformValue<IEnumerable<T>>`
  - Enforces uniqueness with `Distinct()`
  - Same pattern as TerraformList with set semantics
- ✅ Created `TerraformMap<T>` in `src/EmmittJ.Terraform.Sdk/Values/TerraformMap.cs`
  - Inherits from `TerraformValue<IDictionary<string, T>>`
  - String-keyed maps (Terraform requirement)
  - Stores nested `TerraformValue<T>` values internally
- ✅ Created `TerraformBlock<T>` in `src/EmmittJ.Terraform.Sdk/Values/TerraformBlock.cs`
  - **Inherits from `TerraformMap<object>`** (heterogeneous values)
  - Uses reflection to extract POCO properties at resolution time
  - KEY INSIGHT: Blocks ARE maps in HCL, so we leverage map infrastructure!

**Inheritance Hierarchy**:
```
TerraformValue<T> (base class)
├── TerraformList<T> : TerraformValue<IEnumerable<T>>
├── TerraformSet<T> : TerraformValue<IEnumerable<T>>
├── TerraformMap<T> : TerraformValue<IDictionary<string, T>>
│   └── TerraformBlock<T> : TerraformMap<object>
```

**Why TerraformBlock<T> inherits from TerraformMap<object>**:
- Blocks are semantically maps in HCL (key-value structures)
- Keys are property names (strings), values are heterogeneous (different types) → hence `object`
- Resolution extracts property values via reflection and builds a map expression
- Eliminates special-casing in serialization - blocks resolve like maps!

**STEP 3: Add expression factory methods** ✅ **COMPLETE**
- ✅ Added `Set(IEnumerable<TerraformExpression>)` factory method to `TerraformExpression`
- ✅ Added `Map(IEnumerable<KeyValuePair<string, TerraformExpression>>)` factory method
- Note: `List()` methods already existed
- Note: Sets use same HCL syntax as lists (type system distinguishes them)

**STEP 4: Update serialization** ✅ **COMPLETE**
- ✅ No changes needed! Existing `WriteProperties()` in `TerraformConstruct` already handles all collection types
- `IsTerraformValue()` checks for generic `TerraformValue<>` which matches all collection types (they inherit from it)
- `ResolveTerraformValue()` calls the polymorphic `Resolve()` method we overrode in each collection type
- **This confirms the design is correct**: Collections inherit from `TerraformValue<T>` and integrate seamlessly

**STEP 5: Test compilation** ✅ **COMPLETE - ALL 272 ERRORS RESOLVED!**
- ✅ SDK project builds successfully
- ✅ All 4 providers regenerated successfully:
  - AWS: 1561 resources, 630 data sources ✅ **ZERO ERRORS**
  - AzureRM: 1120 resources, 399 data sources ✅ **ZERO ERRORS**
  - Google: 1125 resources, 387 data sources ✅ **ZERO ERRORS**
  - AzureAD: 53 resources, 20 data sources ✅ **ZERO ERRORS**
- **Impact**: From **272 compilation errors** to **ZERO** - all missing collection types now found!

**Then Continue**:
- Phase 6: Cleanup old code
- Phase 7: Update tests and examples
- Phase 8: Performance testing

---

## Collection Wrapper Types Design

### Overview

The generated provider code uses collection wrapper types for Terraform list, set, and map attributes. These types **inherit from `TerraformValue<T>`** and provide specialized handling for collections.

**KEY DESIGN DECISION**: Collection types inherit from `TerraformValue<IEnumerable<T>>` or `TerraformValue<IDictionary<string,T>>` for clean external typing, while **internally** storing nested structures to preserve unknowns (following Pulumi's proven pattern).

**CRITICAL INSIGHT**: **Terraform blocks are semantically maps** with string keys (property names) and heterogeneous values (mixed types). Therefore, `TerraformBlock<T>` inherits from `TerraformMap<object>` to leverage map infrastructure while maintaining type safety via the generic POCO wrapper.

### Usage Patterns in Generated Code

```csharp
// Primitive collections (from Terraform schema ["list", "string"])
public TerraformList<string>? Tags { get; set; }
public TerraformSet<string>? AllowedMemberTypes { get; set; }
public TerraformMap<string>? Labels { get; set; }

// Block types - blocks are maps of properties (heterogeneous values)
public TerraformBlock<ConfigBlock>? Config { get; set; }           // single block (map)
public TerraformList<TerraformBlock<RuleBlock>>? Rules { get; set; } // list of blocks (list of maps)
public TerraformSet<TerraformBlock<RoleBlock>>? Roles { get; set; }  // set of blocks (set of maps)
public TerraformMap<TerraformBlock<SettingBlock>>? Settings { get; set; } // map of blocks (map of maps)
```

### Design Principles

1. **Inherit from TerraformValue<T>**: Collection types are classes that extend `TerraformValue<T>` (enables code reuse, polymorphism)
2. **Clean External Type**: Inherit from `TerraformValue<IEnumerable<T>>` NOT `TerraformValue<List<TerraformValue<T>>>` (simpler, clearer intent)
3. **Preserve Nested Structure Internally**: Like Pulumi's `Input<ImmutableArray<Input<T>>>`, store elements as `List<TerraformValue<T>>` internally
4. **Type Safety**: Generic `T` provides compile-time safety for element types
5. **Flexible Assignment**: Accept .NET collections (List<T>, T[], Dictionary<K,V>) via implicit conversions
6. **Resolution**: Override `Resolve()` to handle element-by-element resolution, preserving unknowns
7. **Collection Initializers**: Implement `IEnumerable` (non-generic) for collection initializer syntax support
8. **Nullable**: All collection properties are nullable (user may not set them)
9. **Blocks are Maps**: `TerraformBlock<T>` inherits from `TerraformMap<object>` because blocks are heterogeneous maps

### TerraformList<T> - For Terraform Lists

```csharp
/// <summary>
/// Represents a Terraform list attribute that can contain multiple ordered elements.
/// Terraform lists are ordered collections that allow duplicates.
/// Inherits from TerraformValue&lt;IEnumerable&lt;T&gt;&gt; for clean typing.
/// </summary>
/// <typeparam name="T">The element type (string, double, bool, TerraformBlock&lt;T&gt;, etc.)</typeparam>
public sealed class TerraformList<T> : TerraformValue<IEnumerable<T>>, IEnumerable
{
    // Internal: Store elements as TerraformValue<T> to preserve unknowns (Pulumi pattern)
    private readonly List<TerraformValue<T>>? _elements;

    // Constructor for literal values
    public TerraformList(IEnumerable<T> values)
        : base(new TerraformListLiteralValue<T>(values))
    {
        _elements = values?.Select(v => (TerraformValue<T>)v).ToList();
    }

    // Constructor for mixed TerraformValue<T> elements (unknowns)
    public TerraformList(IEnumerable<TerraformValue<T>> values)
        : base(new TerraformListMixedValue<T>(values))
    {
        _elements = values?.ToList();
    }

    // Constructor for expressions/references
    protected TerraformList(ITerraformResolvable resolvable)
        : base(resolvable)
    {
        _elements = null;
    }

    /// <summary>
    /// Override resolution to handle nested TerraformValue&lt;T&gt; elements.
    /// This preserves unknowns during serialization.
    /// </summary>
    public override TerraformExpression Resolve(ITerraformResolveContext context)
    {
        // If we have elements, resolve each individually
        if (_elements != null)
        {
            var resolvedElements = _elements
                .Select(e => e.Resolve(context))
                .ToList();
            return TerraformExpression.List(resolvedElements);
        }

        // Otherwise, delegate to base (handles expressions/references)
        return base.Resolve(context);
    }

    // Implicit conversions from .NET collections
    public static implicit operator TerraformList<T>(List<T> value)
        => new TerraformList<T>(value);

    public static implicit operator TerraformList<T>(T[] value)
        => new TerraformList<T>(value);

    // Accept IEnumerable<T> for flexibility
    public static implicit operator TerraformList<T>(IEnumerable<T> value)
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
        => new TerraformList<T>(Enumerable.Empty<T>());
}

/// <summary>
/// Internal resolvable for literal list values (fallback).
/// Prefer using TerraformList constructor with elements for better unknown handling.
/// </summary>
internal class TerraformListLiteralValue<T> : ITerraformResolvable
{
    private readonly IEnumerable<T>? _values;

    public TerraformListLiteralValue(IEnumerable<T>? values)
    {
        _values = values;
    }

    public TerraformExpression Resolve(ITerraformResolveContext context)
    {
        if (_values == null)
        {
            return TerraformExpression.List(); // Empty list
        }

        var elements = _values.Select(v =>
        {
            // Handle TerraformBlock<T> and other complex types
            if (v is ITerraformSerializable serializable)
            {
                return serializable as TerraformExpression
                    ?? throw new InvalidOperationException(
                        $"Serializable type {v.GetType()} is not a TerraformExpression");
            }
            else
            {
                // Primitive type - create literal
                return TerraformExpression.Literal(v);
            }
        }).ToList();

        return TerraformExpression.List(elements);
    }
}

/// <summary>
/// Internal resolvable for mixed TerraformValue&lt;T&gt; elements.
/// Used when list contains both literals and unknowns/references.
/// </summary>
internal class TerraformListMixedValue<T> : ITerraformResolvable
{
    private readonly IEnumerable<TerraformValue<T>> _values;

    public TerraformListMixedValue(IEnumerable<TerraformValue<T>> values)
    {
        _values = values ?? throw new ArgumentNullException(nameof(values));
    }

    public TerraformExpression Resolve(ITerraformResolveContext context)
    {
        var elements = _values
            .Select(v => v.Resolve(context))
            .ToList();

        return TerraformExpression.List(elements);
    }
}
```

### TerraformSet<T> - For Terraform Sets

```csharp
/// <summary>
/// Represents a Terraform set attribute that can contain multiple unique unordered elements.
/// Terraform sets are unordered collections that do not allow duplicates.
/// Inherits from TerraformValue&lt;IEnumerable&lt;T&gt;&gt; for clean typing.
/// </summary>
/// <typeparam name="T">The element type (string, double, bool, TerraformBlock&lt;T&gt;, etc.)</typeparam>
public sealed class TerraformSet<T> : TerraformValue<IEnumerable<T>>, IEnumerable
{
    // Internal: Store elements as TerraformValue<T> to preserve unknowns
    private readonly List<TerraformValue<T>>? _elements;

    // Constructor for literal values - enforces uniqueness
    public TerraformSet(IEnumerable<T> values)
        : base(new TerraformSetLiteralValue<T>(values))
    {
        _elements = values?.Distinct().Select(v => (TerraformValue<T>)v).ToList();
    }

    // Constructor for mixed TerraformValue<T> elements
    public TerraformSet(IEnumerable<TerraformValue<T>> values)
        : base(new TerraformSetMixedValue<T>(values))
    {
        _elements = values?.ToList(); // Uniqueness enforced at resolution
    }

    // Constructor for expressions/references
    protected TerraformSet(ITerraformResolvable resolvable)
        : base(resolvable)
    {
        _elements = null;
    }

    /// <summary>
    /// Override resolution to handle nested TerraformValue&lt;T&gt; elements.
    /// </summary>
    public override TerraformExpression Resolve(ITerraformResolveContext context)
    {
        if (_elements != null)
        {
            var resolvedElements = _elements
                .Select(e => e.Resolve(context))
                .ToList();
            return TerraformExpression.Set(resolvedElements);
        }

        return base.Resolve(context);
    }

    // Implicit conversions - enforce uniqueness with Distinct()
    public static implicit operator TerraformSet<T>(HashSet<T> value)
        => new TerraformSet<T>(value);

    public static implicit operator TerraformSet<T>(List<T> value)
        => new TerraformSet<T>(value.Distinct());

    public static implicit operator TerraformSet<T>(T[] value)
        => new TerraformSet<T>(value.Distinct());

    public static implicit operator TerraformSet<T>(IEnumerable<T> value)
        => new TerraformSet<T>(value.Distinct());

    // Accept mixed TerraformValue<T> elements
    public static implicit operator TerraformSet<T>(List<TerraformValue<T>> values)
        => new TerraformSet<T>(values);

    // Implicit conversion from TerraformExpression
    public static implicit operator TerraformSet<T>(TerraformExpression expression)
        => new TerraformSet<T>(expression);

    // Implicit conversion from TerraformReference
    public static implicit operator TerraformSet<T>(TerraformReference reference)
        => new TerraformSet<T>(reference);

    // IEnumerable for collection initializer syntax (non-functional)
    IEnumerator IEnumerable.GetEnumerator()
        => throw new NotSupportedException(
            "TerraformSet cannot be enumerated synchronously. " +
            "Values are resolved during Terraform synthesis.");

    // Static empty set
    public static TerraformSet<T> Empty
        => new TerraformSet<T>(Enumerable.Empty<T>());
}

/// <summary>
/// Internal resolvable for literal set values.
/// </summary>
internal class TerraformSetLiteralValue<T> : ITerraformResolvable
{
    private readonly IEnumerable<T>? _values;

    public TerraformSetLiteralValue(IEnumerable<T>? values)
    {
        _values = values?.Distinct(); // Enforce uniqueness
    }

    public TerraformExpression Resolve(ITerraformResolveContext context)
    {
        if (_values == null)
        {
            return TerraformExpression.Set(); // Empty set
        var elements = _values.Select(v =>
        {
            if (v is ITerraformSerializable serializable)
            {
                return serializable as TerraformExpression
                    ?? throw new InvalidOperationException(
                        $"Serializable type {v.GetType()} is not a TerraformExpression");
            }
            else
            {
                return TerraformExpression.Literal(v);
            }
        }).ToList();

        return TerraformExpression.Set(elements);
    }
}

/// <summary>
/// Internal resolvable for mixed TerraformValue&lt;T&gt; elements in sets.
/// </summary>
internal class TerraformSetMixedValue<T> : ITerraformResolvable
{
    private readonly IEnumerable<TerraformValue<T>> _values;

    public TerraformSetMixedValue(IEnumerable<TerraformValue<T>> values)
    {
        _values = values ?? throw new ArgumentNullException(nameof(values));
    }

    public TerraformExpression Resolve(ITerraformResolveContext context)
    {
        var elements = _values
            .Select(v => v.Resolve(context))
            .ToList();

        return TerraformExpression.Set(elements);
    }
}
```

### TerraformMap<T> - For Terraform Maps

```csharp
/// <summary>
/// Represents a Terraform map attribute with string keys and typed values.
/// Terraform maps are key-value collections where keys must be strings.
/// Inherits from TerraformValue&lt;IDictionary&lt;string, T&gt;&gt; for clean typing.
/// </summary>
/// <typeparam name="T">The value type (string, double, bool, TerraformBlock&lt;T&gt;, etc.)</typeparam>
public sealed class TerraformMap<T> : TerraformValue<IDictionary<string, T>>, IEnumerable
{
    // Internal: Store values as TerraformValue<T> to preserve unknowns
    private readonly Dictionary<string, TerraformValue<T>>? _elements;

    // Constructor for literal values
    public TerraformMap(IDictionary<string, T> values)
        : base(new TerraformMapLiteralValue<T>(values))
    {
        _elements = values?.ToDictionary(
            kvp => kvp.Key,
            kvp => (TerraformValue<T>)kvp.Value);
    }

    // Constructor for mixed TerraformValue<T> values
    public TerraformMap(IDictionary<string, TerraformValue<T>> values)
        : base(new TerraformMapMixedValue<T>(values))
    {
        _elements = values != null
            ? new Dictionary<string, TerraformValue<T>>(values)
            : null;
    }

    // Constructor for expressions/references
    protected TerraformMap(ITerraformResolvable resolvable)
        : base(resolvable)
    {
        _elements = null;
    }

    /// <summary>
    /// Override resolution to handle nested TerraformValue&lt;T&gt; values.
    /// </summary>
    public override TerraformExpression Resolve(ITerraformResolveContext context)
    {
        if (_elements != null)
        {
            var resolvedPairs = _elements.Select(kvp =>
                new KeyValuePair<string, TerraformExpression>(
                    kvp.Key,
                    kvp.Value.Resolve(context)
                ));

            return TerraformExpression.Map(resolvedPairs);
        }

        return base.Resolve(context);
    }

    // Implicit conversion from Dictionary
    public static implicit operator TerraformMap<T>(Dictionary<string, T> value)
        => new TerraformMap<T>(value);

    public static implicit operator TerraformMap<T>(IDictionary<string, T> value)
        => new TerraformMap<T>(value);

    // Accept mixed TerraformValue<T> values
    public static implicit operator TerraformMap<T>(Dictionary<string, TerraformValue<T>> values)
        => new TerraformMap<T>(values);

    // Implicit conversion from TerraformExpression
    public static implicit operator TerraformMap<T>(TerraformExpression expression)
        => new TerraformMap<T>(expression);

    // Implicit conversion from TerraformReference
    public static implicit operator TerraformMap<T>(TerraformReference reference)
        => new TerraformMap<T>(reference);

    // IEnumerable for collection initializer syntax (non-functional)
    IEnumerator IEnumerable.GetEnumerator()
        => throw new NotSupportedException(
            "TerraformMap cannot be enumerated synchronously. " +
            "Values are resolved during Terraform synthesis.");

    // Static empty map
    public static TerraformMap<T> Empty
        => new TerraformMap<T>(new Dictionary<string, T>());
}

/// <summary>
/// Internal resolvable for literal map values.
/// </summary>
internal class TerraformMapLiteralValue<T> : ITerraformResolvable
{
    private readonly IDictionary<string, T>? _values;

    public TerraformMapLiteralValue(IDictionary<string, T>? values)
    {
        _values = values;
    }

    public TerraformExpression Resolve(ITerraformResolveContext context)
    {
        if (_values == null || _values.Count == 0)
        {
            return TerraformExpression.Map(); // Empty map
        }

        var pairs = _values.Select(kvp =>
        {
            TerraformExpression valueExpr;
            if (kvp.Value is ITerraformSerializable serializable)
            {
                valueExpr = serializable as TerraformExpression
                    ?? throw new InvalidOperationException(
                        $"Serializable type {kvp.Value.GetType()} is not a TerraformExpression");
            }
            else
            {
                valueExpr = TerraformExpression.Literal(kvp.Value);
            }

            return new KeyValuePair<string, TerraformExpression>(kvp.Key, valueExpr);
        });

        return TerraformExpression.Map(pairs);
    }
}

/// <summary>
/// Internal resolvable for mixed TerraformValue&lt;T&gt; values in maps.
/// </summary>
internal class TerraformMapMixedValue<T> : ITerraformResolvable
{
    private readonly IDictionary<string, TerraformValue<T>> _values;

    public TerraformMapMixedValue(IDictionary<string, TerraformValue<T>> values)
    {
        _values = values ?? throw new ArgumentNullException(nameof(values));
    }

    public TerraformExpression Resolve(ITerraformResolveContext context)
    {
        var pairs = _values.Select(kvp =>
            new KeyValuePair<string, TerraformExpression>(
                kvp.Key,
                kvp.Value.Resolve(context)
            ));

        return TerraformExpression.Map(pairs);
    }
}
```

### TerraformBlock<T> - For Nested Blocks (Specialized Map)

**KEY INSIGHT**: A Terraform block is semantically a **map with string keys** (property names) and **heterogeneous values** (different types per property). It could inherit from or leverage the `TerraformMap` infrastructure!

**Design Options**:

#### Option A: Inherit from TerraformMap (Simpler, More Consistent)

```csharp
/// <summary>
/// Represents a Terraform nested block as a specialized map of properties.
/// Blocks are maps where keys are property names and values are heterogeneous types.
/// Inherits from TerraformMap to reuse map resolution infrastructure.
/// </summary>
/// <typeparam name="T">The block class type (e.g., AzurermContainerAppTemplateBlock)</typeparam>
public sealed class TerraformBlock<T> : TerraformMap<object> where T : class
{
    private readonly T? _block;

    public TerraformBlock(T? block)
        : base(CreateMapFromBlock(block))
    {
        _block = block;
    }

    /// <summary>
    /// Gets the underlying block instance for direct property access.
    /// </summary>
    public T? Value => _block;

    /// <summary>
    /// Convert block's properties to a map for resolution.
    /// Uses reflection to extract property values.
    /// </summary>
    private static Dictionary<string, object> CreateMapFromBlock(T? block)
    {
        if (block == null) return new Dictionary<string, object>();

        var map = new Dictionary<string, object>();
        var properties = typeof(T).GetProperties();

        foreach (var prop in properties)
        {
            var attr = prop.GetCustomAttribute<TerraformPropertyNameAttribute>();
            if (attr != null)
            {
                var value = prop.GetValue(block);
                if (value != null)
                {
                    map[attr.Name] = value;
                }
            }
        }

        return map;
    }

    /// <summary>
    /// Override resolution to handle nested TerraformValue&lt;T&gt; properties correctly.
    /// </summary>
    public override TerraformExpression Resolve(ITerraformResolveContext context)
    {
        if (_block == null)
            return TerraformExpression.Map(); // Empty block

        // Resolve each property individually
        var resolvedPairs = new List<KeyValuePair<string, TerraformExpression>>();
        var properties = typeof(T).GetProperties();

        foreach (var prop in properties)
        {
            var attr = prop.GetCustomAttribute<TerraformPropertyNameAttribute>();
            if (attr == null) continue;

            var value = prop.GetValue(_block);
            if (value == null) continue;

            // Handle TerraformValue<T>, TerraformList<T>, etc. via resolution
            TerraformExpression resolvedValue;
            if (value is ITerraformResolvable resolvable)
            {
                resolvedValue = resolvable.Resolve(context);
            }
            else if (value.GetType().IsGenericType)
            {
                // Try to resolve via reflection (for TerraformValue<T>, etc.)
                var resolveMethod = value.GetType().GetMethod("Resolve");
                if (resolveMethod != null)
                {
                    resolvedValue = (TerraformExpression)resolveMethod.Invoke(value, new[] { context });
                }
                else
                {
                    resolvedValue = TerraformExpression.Literal(value);
                }
            }
            else
            {
                resolvedValue = TerraformExpression.Literal(value);
            }

            resolvedPairs.Add(new KeyValuePair<string, TerraformExpression>(
                attr.Name,
                resolvedValue
            ));
        }

        return TerraformExpression.Map(resolvedPairs);
    }

    // Implicit conversion from block instance
    public static implicit operator TerraformBlock<T>(T? block)
        => new TerraformBlock<T>(block);

    // Allow accessing the block directly
    public static implicit operator T?(TerraformBlock<T> wrapper)
        => wrapper._block;
}
```

#### Option B: Standalone with Shared Resolution Logic (Current Approach)

Keep `TerraformBlock<T>` separate but recognize it resolves to the same `TerraformExpression.Map()` as `TerraformMap<T>`. The serialization logic is identical - both are maps of key-value pairs.

**Recommendation**: **Use Option A** - Inherit from `TerraformMap<object>`

**Benefits**:
1. ✅ **Code Reuse**: Leverages existing map infrastructure
2. ✅ **Semantic Accuracy**: Blocks ARE maps in HCL
3. ✅ **Consistent Resolution**: All maps (typed and blocks) use same resolution path
4. ✅ **Simpler Serialization**: `WriteProperties()` just calls `Resolve()` - no special-casing needed
5. ✅ **Type Safety Preserved**: Generic `T` ensures strong typing at compile time

**Tradeoffs**:
- ⚠️ Base type is `TerraformMap<object>` (heterogeneous values) vs `TerraformMap<T>` (homogeneous)
- ✅ But this accurately reflects that blocks have mixed property types!

**HCL Equivalence**:
```hcl
# A map
labels = {
  environment = "prod"
  team        = "platform"
}

# A block (also a map!)
template {
  max_replicas = 10
  min_replicas = 1
  container {
    name  = "app"
    image = "nginx"
  }
}
```

Both are key-value structures that resolve to map expressions in the AST!
            "TerraformBlock resolution is handled by TerraformConstruct.WriteProperties. " +
            "Blocks should not be directly resolved to expressions.");
    }

    // Implicit conversion from block instance
    public static implicit operator TerraformBlock<T>(T? block)
        => new TerraformBlock<T>(block);

    // Allow accessing the block directly
    public static implicit operator T?(TerraformBlock<T> wrapper)
        => wrapper._block;
}
```

### Expression System Updates

Need to add factory methods to `TerraformExpression` for collections:

```csharp
public abstract class TerraformExpression : ITerraformSerializable, ITerraformResolvable
{
    // Existing methods...

    // Collection factory methods
    public static TerraformExpression List(IEnumerable<TerraformExpression>? elements = null)
        => new TerraformListExpression(elements ?? Enumerable.Empty<TerraformExpression>());

    public static TerraformExpression Set(IEnumerable<TerraformExpression>? elements = null)
        => new TerraformSetExpression(elements ?? Enumerable.Empty<TerraformExpression>());

    public static TerraformExpression Map(IEnumerable<KeyValuePair<string, TerraformExpression>>? pairs = null)
        => new TerraformMapExpression(pairs ?? Enumerable.Empty<KeyValuePair<string, TerraformExpression>>());
}
```

### Usage Examples

```csharp
// Example 1: Simple list of strings
var app = new AzurermApplication("app")
{
    Tags = new() { "production", "web" }, // TerraformList<string> → List<string>
    // Or using array:
    // Tags = new[] { "production", "web" }
};

// Example 2: Set of strings (required)
var appRole = new AzurermApplicationAppRoleBlock
{
    AllowedMemberTypes = new() { "User", "Application" }, // TerraformSet<string> → HashSet<string>
    // Or using list (will be treated as set):
    // AllowedMemberTypes = new List<string> { "User", "Application" }
};

// Example 3: Map of strings
var resource = new SomeResource("res")
{
    Labels = new()
    {
        ["environment"] = "prod",
        ["team"] = "platform"
    } // TerraformMap<string> → Dictionary<string, string>
};

// Example 4: Single nested block
var containerApp = new AzurermContainerApp("app")
{
    Template = new AzurermContainerAppTemplateBlock  // Block → TerraformBlock<T>
    {
        MaxReplicas = 10,
        MinReplicas = 1
    }
};

// Example 5: List of blocks
var policy = new AzurermSomePolicy("policy")
{
    Rules = new List<TerraformBlock<RuleBlock>>
    {
        new RuleBlock { Name = "rule1", Enabled = true },
        new RuleBlock { Name = "rule2", Enabled = false }
    }
};

// Example 6: Using references
var app = new AzurermApplication("app")
{
    Tags = otherApp.Tags  // TerraformList<string> → TerraformList<string>
};

// Example 7: Using expressions
var app = new AzurermApplication("app")
{
    Tags = TerraformExpression.Function("concat",
        TerraformExpression.Literal(new[] { "base" }),
        Tf.Var("additional_tags")
    )  // TerraformExpression → TerraformList<string>
};
```

### Key Implementation Notes

1. **TerraformBlock<T> is special**: It doesn't resolve to an expression directly. Instead, the serialization system (TerraformConstruct.WriteProperties) handles blocks by iterating their properties, similar to how it handles resources.

2. **Primitive vs Block collections**:
   - `TerraformList<string>` resolves to `TerraformExpression.List([literals])`
   - `TerraformList<TerraformBlock<T>>` doesn't resolve the blocks - the serialization system unwraps and serializes each block

3. **Nullable by default**: All collection properties are nullable (`TerraformList<T>?`) because they're optional attributes

4. **Type safety maintained**: The generic `T` ensures compile-time safety:
   ```csharp
   TerraformList<string> tags = new List<string> { "a", "b" }; // ✅ OK
   TerraformList<string> tags = new List<int> { 1, 2 };       // ❌ Compile error
   ```

5. **Resolution happens during serialization**: Just like `TerraformValue<T>`, these collections are resolved during the `WriteProperties()` phase when generating HCL

### Files to Create

1. `src/EmmittJ.Terraform.Sdk/Values/TerraformList.cs` - TerraformList<T> struct + TerraformListLiteralValue<T>
2. `src/EmmittJ.Terraform.Sdk/Values/TerraformSet.cs` - TerraformSet<T> struct + TerraformSetLiteralValue<T>
3. `src/EmmittJ.Terraform.Sdk/Values/TerraformMap.cs` - TerraformMap<T> struct + TerraformMapLiteralValue<T>
4. `src/EmmittJ.Terraform.Sdk/Values/TerraformBlock.cs` - TerraformBlock<T> struct

### Files to Modify

1. `src/EmmittJ.Terraform.Sdk/Expressions/TerraformExpression.cs` - Add List(), Set(), Map() factory methods
2. `src/EmmittJ.Terraform.Sdk/Constructs/TerraformConstruct.cs` - Update WriteProperties() to handle collection types
3. Potentially add new expression classes: `TerraformListExpression`, `TerraformSetExpression` (if they don't exist)

### Testing Strategy

1. **Unit tests for each collection type**:
   - Test implicit conversions from .NET collections
   - Test resolution to TerraformExpression
   - Test nullable scenarios
   - Test empty collections

2. **Integration tests**:
   - Test generated resources with collection properties
   - Test serialization to HCL
   - Test block nesting (blocks containing collections)

3. **End-to-end tests**:
   - Generate providers and verify compilation
   - Create resources with all collection types
   - Verify HCL output is correct

Since the library isn't released yet, we can make breaking changes without concern. This plan is organized by dependency order - each phase builds on the previous one.

### Phase 1: Core Resolvable System (Foundation)

**Goal**: Create the new resolution infrastructure alongside existing property system.

**Files to Create**:
1. `src/EmmittJ.Terraform.Sdk/Resolution/ITerraformResolvable.cs`
   ```csharp
   public interface ITerraformResolvable
   {
       TerraformExpression Resolve(ITerraformResolveContext context);
   }
   ```

2. `src/EmmittJ.Terraform.Sdk/Resolution/ITerraformResolveContext.cs`
   ```csharp
   public interface ITerraformResolveContext
   {
       TerraformStack Scope { get; }
       // Add other context as needed
   }
   ```

3. `src/EmmittJ.Terraform.Sdk/Resolution/TerraformLiteralValue.cs`
   ```csharp
   internal class TerraformLiteralValue<T> : ITerraformResolvable
   {
       private readonly T? _value;
       public TerraformExpression Resolve(ITerraformResolveContext context)
           => TerraformExpression.Literal(_value);
   }
   ```

4. `src/EmmittJ.Terraform.Sdk/Resolution/TerraformLazyValue.cs`
   ```csharp
   public class TerraformLazyValue : ITerraformResolvable
   {
       private readonly Func<ITerraformResolveContext, TerraformExpression> _producer;
       public TerraformExpression Resolve(ITerraformResolveContext context)
           => _producer(context);
   }
   ```

5. `src/EmmittJ.Terraform.Sdk/Resolution/TerraformReference.cs`
   ```csharp
   public class TerraformReference : ITerraformResolvable
   {
       private readonly TerraformConstruct _construct;
       private readonly string _attributeName;
       public TerraformExpression Resolve(ITerraformResolveContext context)
           => TerraformExpression.Identifier($"{_construct.ConstructType}.{_construct.ConstructName}.{_attributeName}");
   }
   ```

**Testing**: Unit tests for each resolvable type, verify they produce correct `TerraformExpression`.

**Estimated Time**: 1-2 days

---

### Phase 2: TerraformValue<T> Struct (Core Type)

**Goal**: Create the new property value wrapper with full implicit conversion support.

**Files to Create**:
1. `src/EmmittJ.Terraform.Sdk/Values/TerraformValue.cs`
   ```csharp
   public readonly struct TerraformValue<T>
   {
       private readonly ITerraformResolvable _resolvable;

       // Constructor, Resolve method, implicit operators
       public static implicit operator TerraformValue<T>(T value)
           => new TerraformValue<T>(new TerraformLiteralValue<T>(value));
       public static implicit operator TerraformValue<T>(ITerraformResolvable resolvable)
           => new TerraformValue<T>(resolvable);
       public static implicit operator TerraformValue<T>(TerraformExpression expression)
           => new TerraformValue<T>(expression);
   }
   ```

**Critical Decision**: Should `TerraformExpression` implement `ITerraformResolvable`?
- ✅ **YES** - Expressions can be directly assigned to `TerraformValue<T>` via implicit conversion
- This makes the API much more ergonomic and eliminates the need for explicit wrapping

**Implementation**: Update `TerraformExpression` to implement `ITerraformResolvable`:
```csharp
public abstract class TerraformExpression : ITerraformSerializable, ITerraformResolvable
{
    /// <summary>
    /// Expressions resolve to themselves - they are already the final form.
    /// </summary>
    public virtual TerraformExpression Resolve(ITerraformResolveContext context) => this;

    // Existing methods remain unchanged
    public virtual void Prepare(ITerraformContext context) { }
    public abstract string ToHcl(ITerraformContext? context = null);
}
```

This means:
- `TerraformExpression.Literal("hello")` can be directly assigned to `TerraformValue<string>`
- `TerraformExpression.Conditional(...)` can be directly assigned to `TerraformValue<T>`
- No need for `TerraformValue<T>.FromExpression(expr)` - implicit conversion handles it

**Testing**:
- Test implicit conversions from T, ITerraformResolvable, TerraformExpression
- Test resolution produces correct expressions
- Test nullable scenarios

**Estimated Time**: 2-3 days

---

### Phase 3: Update Resource Base Classes (Serialization)

**Goal**: Update `TerraformProvisionableConstruct` to handle both old and new property systems during transition.

**Files to Modify**:
1. `src/EmmittJ.Terraform.Sdk/Expressions/TerraformExpression.cs`
   - Add `ITerraformResolvable` interface implementation
   - Add `Resolve(ITerraformResolveContext context)` method that returns `this`

**Example Implementation**:
```csharp
public abstract class TerraformExpression : ITerraformSerializable, ITerraformResolvable
{
    /// <summary>
    /// Expressions resolve to themselves - they are already the final form.
    /// </summary>
    public virtual TerraformExpression Resolve(ITerraformResolveContext context) => this;

    // Existing methods unchanged
    public virtual void Prepare(ITerraformContext context) { }
    public abstract string ToHcl(ITerraformContext? context = null);
    // ... rest of existing implementation
}
```

**Example Implementation**:
```csharp
protected virtual void WriteProperties(StringBuilder sb, ITerraformContext context)
{
    var properties = GetType().GetProperties();
    foreach (var prop in properties)
    {
        var attr = prop.GetCustomAttribute<TerraformPropertyNameAttribute>();
        if (attr == null) continue;

        var value = prop.GetValue(this);
        if (value == null) continue;

        // Handle new TerraformValue<T> system
        if (value.GetType().IsGenericType &&
            value.GetType().GetGenericTypeDefinition() == typeof(TerraformValue<>))
        {
            var resolveMethod = value.GetType().GetMethod("Resolve", BindingFlags.Instance | BindingFlags.NonPublic);
            var expression = (TerraformExpression)resolveMethod.Invoke(value, new[] { context });
            // Write expression...
        }
        // Handle old TerraformProperty<T> system
        else if (value is TerraformProperty oldProp)
        {
            var expression = oldProp.Resolve(context);
            // Write expression...
        }
    }
}
```

**Testing**:
- Test resources with old properties still work
- Test resources with new TerraformValue<T> properties work
- Test mixed resources work during transition

**Estimated Time**: 1 day

---

### Phase 5: Update Provider Code Generation (Bulk Update)

**Goal**: Regenerate all provider resources to use `TerraformValue<T>` instead of `TerraformProperty<T>`.

**Current Pattern** (to find and replace):
```csharp
public class AzurermContainerApp : TerraformResource
{
    [TerraformPropertyName("name")]
    public required TerraformProperty<string> Name { get; set; }
}
```

**New Pattern**:
```csharp
public class AzurermContainerApp : TerraformResource
{
    [TerraformPropertyName("name")]
    public required TerraformValue<string> Name { get; set; }
}
```

**Approach**:
1. **Update code generation templates**: Modify `TemplateHelpers.cs` to emit `TerraformValue<T>` instead of `TerraformProperty<T>`
2. **Run `aspire publish`**: This will regenerate all provider resources automatically

**Files to Modify**:
1. `src/EmmittJ.Terraform.Sdk.AppHost/Templates/TemplateHelpers.cs`
   - Update `GetPropertyWrapper()` method to replace `TerraformProperty<` with `TerraformValue<`
   - Update any type mapping logic that references the old property types

**Code Change Required**:
```csharp
public static string GetPropertyWrapper(PropertyModel property)
{
    // Replace TerraformProperty<T> with TerraformValue<T>
    var csharpType = property.CSharpType;

    // Handle direct property types
    if (csharpType.StartsWith("TerraformProperty<"))
    {
        csharpType = csharpType.Replace("TerraformProperty<", "TerraformValue<");
    }

    // Handle collection types like List<TerraformProperty<int>>
    csharpType = csharpType.Replace("TerraformProperty<", "TerraformValue<");

    return csharpType;
}

public static string GetInnerType(string csharpType)
{
    // Update to handle TerraformValue<T> instead of TerraformProperty<T>
    if (csharpType.StartsWith("TerraformValue<") && csharpType.EndsWith(">"))
    {
        return csharpType.Substring("TerraformValue<".Length, csharpType.Length - "TerraformValue<".Length - 1);
    }
    return csharpType;
}
```

**Provider Projects to Update** (automatically via `aspire publish`):
- `src/providers/EmmittJ.Terraform.Sdk.Providers.Aws/`
- `src/providers/EmmittJ.Terraform.Sdk.Providers.AzureRM/`
- `src/providers/EmmittJ.Terraform.Sdk.Providers.AzureAD/`
- `src/providers/EmmittJ.Terraform.Sdk.Providers.Google/`

**Special Cases**:
- **Computed properties** (resource outputs): Change to return `TerraformReference` wrapped in `TerraformValue<T>`
  ```csharp
  // OLD
  public TerraformReferenceProperty<string> Id => new(this, "id");

  // NEW
  public TerraformValue<string> Id => new TerraformReference(this, "id");
  ```
  **Template Update**: In `TerraformConstruct.mustache`, update the `OutputAttributes` section

- **Block properties**: The block wrapper types stay the same, but properties **inside** block classes use `TerraformValue<T>`
  ```csharp
  // The block property itself - wrapper type unchanged
  [TerraformPropertyName("template")]
  public TerraformBlock<AzurermContainerAppTemplateBlock>? Template { get; set; }

  // But inside the block class, properties use TerraformValue<T>
  public class AzurermContainerAppTemplateBlock
  {
      [TerraformPropertyName("max_replicas")]
      public TerraformValue<double>? MaxReplicas { get; set; }  // Uses TerraformValue<T>
  }
  ```
  **Note**: Block wrapper types (`TerraformBlock<T>`, `TerraformList<TerraformBlock<T>>`) are separate from the property system. The properties **inside** block classes go through the same `GetPropertyWrapper()` logic, so they'll automatically get updated to `TerraformValue<T>` when you update the template helper.

**Execution Steps**:
1. Update `TemplateHelpers.cs` with the code changes above - this will update both resource properties AND properties inside block classes
2. Update computed property generation in mustache templates (`OutputAttributes` section)
3. Run `aspire publish` from repository root
4. Verify generated code in all 4 provider projects
5. Commit regenerated providers
**Testing**:
- Compile all provider projects after regeneration
- Run existing integration tests
- Manually test common resource scenarios
- Verify implicit conversions work for literals, references, and expressions

**Estimated Time**: 2-3 days
- 1 day: Update templates and verify code generation
- 1 day: Run `aspire publish`, verify output, fix any template issues
- 0.5-1 day: Testing and validation

---

### Phase 6: Remove Old Property System (Cleanup)

**Goal**: Delete obsolete property types once all code is migrated.

**Files to Delete**:
1. `src/EmmittJ.Terraform.Sdk/Properties/TerraformLiteralProperty.cs`
2. `src/EmmittJ.Terraform.Sdk/Properties/TerraformExpressionProperty.cs`
3. `src/EmmittJ.Terraform.Sdk/Properties/TerraformReferenceProperty.cs`
4. `src/EmmittJ.Terraform.Sdk/Properties/ITerraformExpression.cs` (if no longer needed)

**Files to Modify**:
1. `src/EmmittJ.Terraform.Sdk/Properties/TerraformProperty.cs` - potentially delete if only used as base
2. Remove dual-system handling from `TerraformProvisionableConstruct.WriteProperties()`

**Verification**:
- Ensure no references to deleted types remain
- Grep for: `TerraformLiteralProperty`, `TerraformExpressionProperty`, `TerraformReferenceProperty`
- Full solution rebuild with no errors

**Estimated Time**: 1 day

---

### Phase 7: Update Tests and Examples (Validation)

**Goal**: Update all tests and example code to use new system.

**Test Projects to Update**:
- `tests/EmmittJ.Terraform.Sdk.Tests/`
- `tests/EmmittJ.Aspire.Hosting.Terraform.Tests/`

**Example Projects to Update**:
- `playground/azure-container-apps/`

**Updates Needed**:
1. Change property assignments to use new implicit conversions
2. Update reference access patterns (use `TerraformReference` or computed properties)
3. Update expression building examples
4. Add new test cases for:
   - Implicit conversions
   - Lazy values
   - Reference types
   - Mixed scenarios

**Documentation to Update**:
- `README.md` - update examples
- `playground/README.md` - update playground examples
- Add migration guide (even though not released, good for internal reference)

**Estimated Time**: 3-4 days

---

### Phase 8: Performance Testing and Optimization (Polish)

**Goal**: Ensure new system performs well and optimize if needed.

**Performance Concerns**:
1. **Struct copying**: `TerraformValue<T>` is a struct - measure copy overhead
2. **Reflection overhead**: Property resolution uses reflection - consider caching
3. **Resolution phase**: Measure time to resolve large resource graphs

**Optimization Strategies**:
1. **Cached property info**: Build property descriptor cache at startup
2. **Source generators**: Consider generating resolution code to avoid reflection
3. **Benchmarks**: Use BenchmarkDotNet to compare old vs new system

**Testing**:
- Load test with large configurations (100+ resources)
- Memory profiling
- CPU profiling during resolution phase

**Estimated Time**: 2-3 days

---

### Total Estimated Time: 15-21 days

### Risk Mitigation

1. **Breaking Changes**: Not a concern since library isn't released
2. **Incomplete Migration**: Keep both systems working in Phase 3-4 until fully migrated
3. **Performance Regression**: Benchmark before/after, optimize if needed
4. **Expression System Issues**: Expression system stays unchanged - low risk

### Success Criteria

✅ All provider resources use `TerraformValue<T>`
✅ Old property system code deleted
✅ All tests passing
✅ Example projects working
✅ Performance equivalent or better
✅ Type safety maintained (no `object?` in user-facing API)
✅ Compilation errors for incorrect type assignments

## Key Benefits

1. **Compile-Time Type Safety**: `TerraformValue<string>` can only accept string literals or resolvables - wrong types = compiler error
2. **Minimal Storage**: Only stores a single `ITerraformResolvable` field - no boolean flags or duplicate storage
3. **Simple API**: Properties accept literals via implicit conversion - just works naturally
4. **Flexible**: Seamlessly accepts literals, references, expressions via implicit conversions
5. **Conceptually Correct**: Everything in HCL IS an expression, so resolving to `TerraformExpression` makes sense
6. **Two-Phase**: Maintains prepare/resolve phases for dependency tracking
7. **Powerful Expressions**: `TerraformExpression` system remains fully functional and type-safe
8. **Uniform Handling**: All values go through the same resolution path - simpler implementation

## Comparison: Before vs After

### Before (Current Complex System)

```csharp
public class AzurermContainerApp : TerraformResource
{
    [TerraformPropertyName("name")]
    public required TerraformProperty<string> Name { get; set; }

    [TerraformPropertyName("capacity")]
    public TerraformProperty<double>? Capacity { get; set; }
}

// Usage - requires understanding of property types
var app = new AzurermContainerApp("app")
{
    Name = "my-app",  // Implicit conversion from string to TerraformLiteralProperty<string>
    Capacity = 2      // Implicit conversion from int to TerraformLiteralProperty<double>
};

// Using references is awkward - what types are involved?
app.ResourceGroupName = resourceGroup.Name;
````

### After (Generic TerraformValue System)

```csharp
public class AzurermContainerApp : TerraformResource
{
    [TerraformPropertyName("name")]
    public required TerraformValue<string> Name { get; set; }

    [TerraformPropertyName("capacity")]
    public TerraformValue<double>? Capacity { get; set; }

    // Computed property returns TerraformValue containing TerraformReference
    public TerraformValue<string> Id => new TerraformReference<string>(this, "id");
}

// Usage - clean and type-safe
var app = new AzurermContainerApp("app")
{
    Name = "my-app",                    // string → TerraformValue<string> (implicit)
    Capacity = 2,                       // int → TerraformValue<double> (implicit)
    ResourceGroupName = resourceGroup.Name  // TerraformValue<string> → TerraformValue<string>
};
```

## Technical Details

### Type-Safe Resolution

No `object?` or boxing needed - everything is generic:

````csharp
public class TerraformResolveContext : ITerraformResolveContext
{
    public TerraformConstruct Scope { get; }

    public T Resolve<T>(TerraformValue<T> value)
    {
        // Resolve the TerraformValue to get the final value
        return value.Resolve(this);
    }
}
```### Property Serialization

During HCL serialization, resolve each property:

```csharp
protected virtual void WriteProperties(StringBuilder sb, ITerraformContext context)
{
    var resolveContext = new TerraformResolveContext(this);
    var properties = GetType().GetProperties();

    foreach (var prop in properties)
    {
        var attr = prop.GetCustomAttribute<TerraformPropertyNameAttribute>();
        if (attr == null) continue;

        var value = prop.GetValue(this);
        if (value == null) continue;

        // Check if this is a TerraformValue<T>
        if (IsNullableTerraformValue(prop.PropertyType, out var valueType))
        {
            // Resolve the TerraformValue<T> generically
            var resolved = ResolveValue(value, valueType, resolveContext);

            if (resolved != null)
            {
                sb.Append($"  {attr.Name} = ");
                SerializeValue(resolved, sb, context);
                sb.AppendLine();
            }
        }
        else
        {
            // Plain property (like nested blocks)
            sb.Append($"  {attr.Name} = ");
            SerializeValue(value, sb, context);
            sb.AppendLine();
        }
    }
}

private object? ResolveValue(object terraformValue, Type valueType, ITerraformResolveContext context)
{
    // Use reflection to call TerraformValue<T>.Resolve(context)
    var resolveMethod = terraformValue.GetType().GetMethod("Resolve",
        BindingFlags.Instance | BindingFlags.NonPublic);
    return resolveMethod?.Invoke(terraformValue, new object[] { context });
}
````

### Alternative: Source Generator Approach

To avoid reflection, use source generators to create type-safe serialization:

```csharp
// Generated code for AzurermContainerApp
partial class AzurermContainerApp
{
    protected override void WriteProperties(StringBuilder sb, ITerraformContext context)
    {
        var resolveContext = new TerraformResolveContext(this);

        // Generated: resolve and write Name
        if (Name != null)
        {
            var resolvedName = resolveContext.Resolve(Name);
            sb.Append($"  name = ");
            SerializeValue(resolvedName, sb, context);
            sb.AppendLine();
        }

        // Generated: resolve and write Capacity
        if (Capacity != null)
        {
            var resolvedCapacity = resolveContext.Resolve(Capacity.Value);
            sb.Append($"  capacity = ");
            SerializeValue(resolvedCapacity, sb, context);
            sb.AppendLine();
        }

        // ... etc for all properties
    }
}
```

## Migration Path

The migration is straightforward - properties change type but usage stays similar:

### Old Code

```csharp
public class AzurermContainerApp : TerraformResource
{
    public required TerraformProperty<string> Name { get; set; }
    public TerraformProperty<double>? Capacity { get; set; }
}

var app = new AzurermContainerApp("app")
{
    Name = "my-app",
    Capacity = 2,
    ResourceGroupName = rg.Name
};
```

### New Code

```csharp
public class AzurermContainerApp : TerraformResource
{
    public required TerraformValue<string> Name { get; set; }
    public TerraformValue<double>? Capacity { get; set; }
}

var app = new AzurermContainerApp("app")
{
    Name = "my-app",       // Same syntax - implicit conversion
    Capacity = 2,          // Same syntax - implicit conversion
    ResourceGroupName = rg.Name  // Same syntax - works naturally
};
```

The main changes:

1. `TerraformProperty<T>` → `TerraformValue<T>` in property declarations
2. Expression usage changes slightly:
   - Old: Pass expression directly (various implicit conversions)
   - New: Use `TerraformValue<T>.FromExpression(expr)`
3. Computed properties return `TerraformValue<T>` instead of creating properties on-the-fly

## Conclusion

This redesign eliminates the complexity of the current property system while maintaining:

- ✅ **Full type safety** - Generic `TerraformValue<T>` with no `object?` anywhere
- ✅ **Minimal storage** - Only one `ITerraformResolvable` field, no flags or duplicate data
- ✅ **Two-phase synthesis** - Prepare → Resolve → ToHcl
- ✅ **Support for literals, references, variables, and expressions** - All via implicit conversions
- ✅ **Powerful expression system** - `TerraformExpression` remains unchanged and type-safe
- ✅ **Clean, ergonomic API** - Just works naturally
- ✅ **Compile-time safety** - Wrong types caught by compiler

### Key Design Decisions

1. **`ITerraformResolvable` is non-generic** - Returns `TerraformExpression`, the unified HCL representation
2. **`TerraformValue<T>` is generic** - Provides compile-time type safety for user assignments
3. **`TerraformExpression` is unchanged** - Already has perfect design as HCL AST
4. **Literals wrapped immediately** - No special handling, all values go through same resolution path
5. **Three-layer architecture** - User API → Resolution → Serialization

The type system is now simple, powerful, and easy to understand!
The pattern is **inspired by AWS CDK** but improved with C# generics to avoid `object?` and runtime type checking. Everything is type-safe at compile time.

---

## Quick Reference - Key Code Patterns

### Property Declarations

```csharp
// Simple value properties
[TerraformPropertyName("name")]
public required TerraformValue<string> Name { get; set; }

[TerraformPropertyName("capacity")]
public TerraformValue<double>? Capacity { get; set; }

[TerraformPropertyName("enabled")]
public TerraformValue<bool>? Enabled { get; set; }

// Nested block properties (POCOs - no TerraformValue wrapper)
[TerraformPropertyName("template")]
public AzurermContainerAppTemplateBlock? Template { get; set; }
```

### Property Assignments

```csharp
// Literal values - implicit conversion
resource.Name = "my-resource";
resource.Capacity = 42;
resource.Enabled = true;

// References - implicit conversion from TerraformReference
resource.ResourceGroupName = resourceGroup.NameReference;

// Expressions - implicit conversion from TerraformExpression
resource.Location = TerraformExpression.Conditional(
    Tf.Var("use_east"),
    "eastus",
    "westus"
);

// Lazy values - implicit conversion from ITerraformResolvable
resource.ComputedName = new TerraformLazyValue(ctx =>
    TerraformExpression.Interpolate("prefix-", ctx.Scope.Name)
);
```

### Reference Pattern

```csharp
// Computed property returns TerraformReference wrapped in TerraformValue
public TerraformValue<string> Id => new TerraformReference(this, "id");

// Usage - implicit conversion makes it seamless
otherResource.VpcId = vpc.Id;
```

### Custom Resolvables

```csharp
public class MyCustomResolvable : ITerraformResolvable
{
    public TerraformExpression Resolve(ITerraformResolveContext context)
    {
        // Build your expression based on context
        return TerraformExpression.Identifier($"custom.{context.Scope.Name}");
    }
}

// Usage - implicit conversion
resource.CustomValue = new MyCustomResolvable();
```

### Resolution Flow (Internal)

```csharp
// Inside TerraformProvisionableConstruct.WriteProperties()
var value = property.GetValue(resource); // TerraformValue<T>
var resolveMethod = value.GetType().GetMethod("Resolve", ...);
var expression = (TerraformExpression)resolveMethod.Invoke(value, new[] { context });
var hcl = expression.ToHcl(context);
```
