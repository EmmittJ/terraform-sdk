# Source Generator Design for Terraform SDK

## Problem Statement

Current issues with the reflection-based approach:

1. **Duplicate properties**: Resources need both `Name` (setter) and `NameReference` (getter for references)
2. **Runtime reflection**: Property discovery happens during serialization
3. **Unclear semantics**: When does `resourceGroup.Name` give a reference vs a value?

## Proposed Solution: Source Generator with Getter/Setter Semantics

### Key Insight: Leverage C# Property Behavior

In Terraform/HCL, resource attributes serve two purposes:

1. **Setting values** (write): `resource "azurerm_resource_group" "rg" { name = "foo" }`
2. **Referencing values** (read): `resource "azurerm_app" "app" { resource_group_name = azurerm_resource_group.rg.name }`

Map this to C# properties:

- **Setter** = stores value for serialization (write mode)
- **Getter** = returns reference for cross-resource usage (read mode)

### Design Pattern

#### User-Written Code (Partial Class)

```csharp
namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

public partial class AzurermResourceGroup : TerraformResource
{
    public AzurermResourceGroup(string name) : base("azurerm_resource_group", name) { }

    [TerraformProperty("name")]
    public required partial TerraformValue<string> Name { get; set; }

    [TerraformProperty("location")]
    public required partial TerraformValue<string> Location { get; set; }

    [TerraformProperty("tags")]
    public partial TerraformMap<string>? Tags { get; set; }

    // Computed-only properties (no setter)
    [TerraformProperty("id")]
    public partial TerraformValue<string> Id { get; }
}
```

#### Source-Generated Code

```csharp
// Generated in: AzurermResourceGroup.g.cs
namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

public partial class AzurermResourceGroup
{
    // Writeable property (has both get and set)
    public required TerraformValue<string> Name
    {
        // Getter ALWAYS returns a reference (for cross-resource usage)
        // This is the key insight: getter doesn't return stored value, it returns a reference
        get => new TerraformReference<string>(this, "name");

        // Setter stores VALUE (for serialization)
        set => SetPropertyValue("name", value);
    }

    // Value accessor - retrieves the actual stored value (rare, for advanced scenarios)
    public TerraformValue<string> NameValue
    {
        get => GetRequiredPropertyValue<TerraformValue<string>>("name");
    }

    public required TerraformValue<string> Location
    {
        // Getter ALWAYS returns reference - never the stored value
        get => new TerraformReference<string>(this, "location");
        set => SetPropertyValue("location", value);
    }

    // Value accessor for Location
    public TerraformValue<string> LocationValue
    {
        get => GetRequiredPropertyValue<TerraformValue<string>>("location");
    }

    public TerraformMap<string>? Tags
    {
        // Getter ALWAYS returns reference - even for nullable/optional properties
        // The nullable type signature just indicates "optional at API level"
        get => new TerraformReference<string>(this, "tags");
        set => SetPropertyValue("tags", value);
    }

    // Value accessor for optional property - returns null if not set
    public TerraformMap<string>? TagsValue
    {
        get => GetPropertyValue<TerraformMap<string>?>("tags");
    }

    // Computed-only property (getter only, no setter)
    public TerraformValue<string> Id
    {
        // Computed properties also just return references
        // No value accessor since this is computed-only (no value was SET)
        get => new TerraformReference<string>(this, "id");
    }
}
```

**Key Design Decision**: The getter **ALWAYS** returns a `TerraformReference<T>`, never the stored value. The stored value (from the setter) is only used during serialization in `WriteProperties()`. This enables the natural Terraform syntax where `rg.Name` always gives you a reference to `azurerm_resource_group.rg.name`.

**Value Accessor Properties**: For properties with setters, the generator also creates a `{PropertyName}Value` accessor that retrieves the actual stored value. This is useful in rare scenarios where you need to inspect what was set, but the main property getter always returns a reference.

**Why TerraformReference<T> (not a factory method)**:

- `TerraformReference<T>` inherits from `TerraformValue<T>` - clean type hierarchy
- No verbose factory methods like `TerraformValue.FromResolvable<string>(...)`
- Simple, readable generated code: `new TerraformReference<string>(this, "name")`

### Base Class Changes

```csharp
public abstract class TerraformResource : TerraformProvisionableConstruct
{
    // Internal storage for property values SET by user (via setters)
    // Key = terraform attribute name ("name", "location", etc.)
    // Value = TerraformValue<T> that was assigned
    private readonly Dictionary<string, object?> _propertyValues = new();

    // Called by source-generated setters to store values
    protected void SetPropertyValue(string terraformName, object? value)
    {
        _propertyValues[terraformName] = value;
    }

    // Called by source-generated *Value accessors to retrieve stored values
    // Returns null if the property was never set
    protected T? GetPropertyValue<T>(string terraformName)
    {
        return _propertyValues.TryGetValue(terraformName, out var value)
            ? (T?)value
            : default;
    }

    // Called by source-generated *Value accessors for required properties
    // Throws if the property was never set
    protected T GetRequiredPropertyValue<T>(string terraformName)
    {
        if (!_propertyValues.TryGetValue(terraformName, out var value))
        {
            throw new InvalidOperationException(
                $"Required property '{terraformName}' has not been set.");
        }
        return (T)value!;
    }

    // NOTE: Main property getters ALWAYS return new TerraformReference<T>.
    // Only *Value accessors use GetPropertyValue() to retrieve stored values.

    // Serialization - iterate stored properties and serialize them
    protected override void WriteProperties(StringBuilder sb, ITerraformContext context)
    {
        var resolveContext = new TerraformResolveContext(this);

        foreach (var (terraformName, value) in _propertyValues)
        {
            if (value == null) continue;

            // Resolve the STORED value (not the reference!) to an expression
            TerraformExpression expression;

            if (value is ITerraformResolvable resolvable)
            {
                // TerraformValue<T>, TerraformList<T>, etc. implement ITerraformResolvable
                expression = resolvable.Resolve(resolveContext);
            }
            else
            {
                // Fallback for non-resolvable values (shouldn't happen with typed properties)
                expression = TerraformExpression.Literal(value);
            }

            // Write to HCL
            sb.AppendLine($"{context.Indent}{terraformName} = {expression.ToHcl(context)}");
        }

        WriteMetaArguments(sb, context);
    }
}
```

**Important**: The dictionary stores **what was SET**, not what is **GET**. This separation is crucial for the design to work.

## Usage Examples

### Example 1: Simple Resource with References

```csharp
// Create resource group
var resourceGroup = new AzurermResourceGroup("rg")
{
    Name = "my-rg",        // Setter stores literal value
    Location = "eastus"    // Setter stores literal value
};

// Reference resource group name in another resource
var app = new AzurermContainerApp("app")
{
    // Getter returns reference - generates: azurerm_resource_group.rg.name
    ResourceGroupName = resourceGroup.Name,

    // Getter returns reference - generates: azurerm_resource_group.rg.location
    Location = resourceGroup.Location
};

// Accessing the stored value (rare scenario)
var storedName = resourceGroup.NameValue;  // Returns TerraformValue<string> with "my-rg"
var storedLocation = resourceGroup.LocationValue;  // Returns TerraformValue<string> with "eastus"
```

**Generated HCL:**

```hcl
resource "azurerm_resource_group" "rg" {
  name     = "my-rg"
  location = "eastus"
}

resource "azurerm_container_app" "app" {
  resource_group_name = azurerm_resource_group.rg.name
  location            = azurerm_resource_group.rg.location
}
```

### Example 2: Computed Properties (No Setter)

```csharp
var rg = new AzurermResourceGroup("rg")
{
    Name = "my-rg",
    Location = "eastus"
};

// Id is computed-only - getter returns reference
var output = new TerraformOutput("rg_id")
{
    Value = rg.Id  // Generates: azurerm_resource_group.rg.id
};
```

### Example 3: Using Expressions

```csharp
var rg = new AzurermResourceGroup("rg")
{
    // Can still use expressions explicitly
    Name = TerraformExpression.Interpolate("rg-", Tf.Var("environment")),
    Location = "eastus"
};
```

### Example 4: Conditional Values

```csharp
var isProd = Tf.Var("is_production");

var rg = new AzurermResourceGroup("rg")
{
    Name = "my-rg",
    // Setter stores the conditional expression
    Location = TerraformExpression.Conditional(isProd, "eastus", "westus")
};
```

## Source Generator Implementation

### 1. Marker Attribute

```csharp
namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Marks a property as a Terraform attribute that should be source-generated.
/// </summary>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class TerraformPropertyAttribute : Attribute
{
    public string Name { get; }

    public TerraformPropertyAttribute(string name)
    {
        Name = name;
    }
}
```

### 2. Generator Logic

```csharp
[Generator]
public class TerraformResourceGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        // Find all partial classes inheriting from TerraformResource
        var resourceClasses = context.SyntaxProvider
            .CreateSyntaxProvider(
                predicate: (node, _) => IsCandidateClass(node),
                transform: (ctx, _) => GetClassDeclaration(ctx))
            .Where(c => c != null);

        // Generate property implementations
        context.RegisterSourceOutput(resourceClasses, GeneratePropertyImplementations);
    }

    private bool IsCandidateClass(SyntaxNode node)
    {
        return node is ClassDeclarationSyntax cls
            && cls.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword));
    }

    private void GeneratePropertyImplementations(
        SourceProductionContext context,
        ClassDeclarationSyntax classDeclaration)
    {
        // Find properties with [TerraformProperty] attribute
        var properties = classDeclaration.Members
            .OfType<PropertyDeclarationSyntax>()
            .Where(p => HasTerraformPropertyAttribute(p));

        var code = new StringBuilder();
        code.AppendLine("namespace " + GetNamespace(classDeclaration) + ";");
        code.AppendLine();
        code.AppendLine($"public partial class {classDeclaration.Identifier.Text}");
        code.AppendLine("{");

        foreach (var property in properties)
        {
            GenerateProperty(code, property);
        }

        code.AppendLine("}");

        context.AddSource(
            $"{classDeclaration.Identifier.Text}.g.cs",
            code.ToString());
    }

    private void GenerateProperty(StringBuilder code, PropertyDeclarationSyntax property)
    {
        var propertyName = property.Identifier.Text;
        var terraformName = GetTerraformName(property);
        var propertyType = property.Type.ToString();
        var hasSet = property.AccessorList?.Accessors.Any(a => a.IsKind(SyntaxKind.SetAccessorDeclaration)) ?? false;
        var isRequired = property.Modifiers.Any(m => m.IsKind(SyntaxKind.RequiredKeyword));
        var isNullable = propertyType.EndsWith("?");

        // Generate property with getter/setter
        var requiredModifier = isRequired ? "required " : "";
        code.AppendLine($"    public {requiredModifier}{propertyType} {propertyName}");
        code.AppendLine("    {");

        // Getter always returns reference
        if (isNullable)
        {
            code.AppendLine($"        get => GetPropertyValue<{propertyType.TrimEnd('?')}?>(\"{terraformName}\")");
            code.AppendLine($"               ?? TerraformValue.FromResolvable<{propertyType.TrimEnd('?')}>(new TerraformReference(this, \"{terraformName}\"));");
        }
        else
        {
            code.AppendLine($"        get => GetPropertyValue<{propertyType}>(\"{terraformName}\")");
            code.AppendLine($"               ?? TerraformValue.FromResolvable<{propertyType}>(new TerraformReference(this, \"{terraformName}\"));");
        }

        // Setter stores value (if property has setter)
        if (hasSet)
        {
            code.AppendLine($"        set => SetPropertyValue(\"{terraformName}\", value);");
        }

        code.AppendLine("    }");
        code.AppendLine();
    }
}
```

## Benefits

### ✅ **Natural Syntax**

```csharp
// Before: Confusing - which property to use?
ResourceGroupName = rg.Name            // Wrong! Stores literal "my-rg"
ResourceGroupName = rg.NameReference   // Correct - generates reference

// After: Obvious - getter always returns reference
ResourceGroupName = rg.Name  // Always correct! Getter returns reference
```

### ✅ **No Duplicate Properties**

```csharp
// Before: Every property needs TWO declarations
public TerraformValue<string> Name { get; set; }
public TerraformValue<string> NameReference => new TerraformReference(this, "name");

// After: Single declaration
[TerraformProperty("name")]
public partial TerraformValue<string> Name { get; set; }
```

### ✅ **Zero Runtime Reflection**

- Properties implemented at compile-time via source generator
- Serialization reads from dictionary, no reflection needed
- Better performance, easier to trim/AOT

### ✅ **Compile-Time Safety**

- Type-safe property access (IntelliSense works)
- Required properties enforced by compiler
- No string-based property access

### ✅ **Clearer Semantics**

- **Get** = reference to this resource's attribute (for cross-resource refs)
- **Set** = store value for this resource (for serialization)
- **{Property}Value** = access the stored value (rare, for inspection/debugging)
- **No setter** = computed-only attribute (read-only reference, no value accessor)

## Migration Path

### Phase 1: Add Source Generator Infrastructure

1. Create `EmmittJ.Terraform.Sdk.SourceGenerators` project
2. Implement `TerraformPropertyAttribute`
3. Add dictionary storage to `TerraformResource`
4. Update `WriteProperties()` to use dictionary

### Phase 2: Convert Code Generation Templates

1. Update mustache templates to emit `partial` classes
2. Add `[TerraformProperty("name")]` attributes
3. Mark properties as `partial`
4. Remove manual property implementations

### Phase 3: Regenerate Providers

1. Run `aspire publish` to regenerate all providers
2. Source generator automatically creates implementations
3. Test that getters return references, setters store values

### Phase 4: Cleanup

1. Remove `TerraformPropertyNameAttribute` (replaced by `TerraformPropertyAttribute`)
2. Remove reflection-based property discovery
3. Update documentation

## Potential Challenges

### 1. Nullable Reference Types

**Question**: What does nullable mean for properties when getter always returns a reference?

**Answer**: The nullable type `TerraformValue<string>?` indicates whether the property is **optional at the API level**, not whether the getter can return null.

```csharp
// Optional property - nullable type signature
[TerraformProperty("tags")]
public partial TerraformMap<string>? Tags { get; set; }

// Generated code:
public TerraformMap<string>? Tags
{
    // Getter ALWAYS returns a reference (non-null)
    // The ? in the signature just means "this property is optional to SET"
    get => new TerraformReference<string>(this, "tags");

    // Setter stores value (or null if not set)
    set => SetPropertyValue("tags", value);
}
```

**How it works**:

- Getter signature is `TerraformMap<string>?` but implementation returns non-null `TerraformReference`
- C# allows this because `TerraformReference<string>` is assignable to `TerraformMap<string>?`
- Users can reference `rg.Tags` anywhere (always get a valid reference)
- Serialization only outputs tags if `SetPropertyValue("tags", ...)` was called with non-null value

**Alternative approach** (if C# nullable warnings are an issue):

```csharp
// Make getter explicitly non-nullable
public TerraformMap<string>? Tags
{
    get => new TerraformReference<string>(this, "tags")!;  // ! suppresses warning
    set => SetPropertyValue("tags", value);
}
```

### 2. Required Properties Initialization

**Issue**: Required properties need values in object initializer, but getter returns reference.

**Current Code (works)**:

```csharp
var rg = new AzurermResourceGroup("rg")
{
    Name = "my-rg",  // Setter called during initialization
    Location = "eastus"
};

// Later, getter returns reference
var app = new AzurermApp("app")
{
    ResourceGroupName = rg.Name  // Getter returns reference
};
```

**This pattern WORKS because**:

- Object initializer syntax calls **setter** (`Name = "my-rg"`)
- Property access after initialization calls **getter** (`rg.Name`)
- C# separates these two operations naturally!

### 3. Self-References

**Issue**: Can a resource reference its own properties?

```csharp
var rg = new AzurermResourceGroup("rg")
{
    Name = "my-rg",
    // Can we use rg.Name here? NO - rg not yet initialized!
    Tags = new() { ["name"] = rg.Name }  // ❌ Compile error
};
```

**Solution**: This is already a limitation - can't use `this` in object initializer. Not a new problem.

## Unified Design for All Terraform Constructs

The source generator pattern works for ALL Terraform construct types, not just resources. Here's how it applies across the board:

### Construct Type Overview

| Construct Type  | Base Class            | Has Properties?  | Reference Pattern                           | Example                    |
| --------------- | --------------------- | ---------------- | ------------------------------------------- | -------------------------- |
| **Resource**    | `TerraformResource`   | ✅ Yes           | `azurerm_resource_group.rg.name`            | `AzurermResourceGroup`     |
| **Data Source** | `TerraformDataSource` | ✅ Yes           | `data.azurerm_resource_group.existing.name` | `DataAzurermResourceGroup` |
| **Output**      | `TerraformOutput`     | ✅ Yes (limited) | `output.my_output` (not typical)            | `TerraformOutput`          |
| **Variable**    | `TerraformVariable`   | ✅ Yes (limited) | `var.my_var`                                | `TerraformVariable`        |
| **Local**       | `TerraformLocal`      | ✅ Yes           | `local.my_value`                            | `TerraformLocal`           |
| **Provider**    | `TerraformProvider`   | ✅ Yes           | N/A (providers aren't referenced)           | `AzurermProvider`          |

### Common Base Class: TerraformConstruct

All constructs inherit from `TerraformConstruct`, which should provide the property storage infrastructure:

```csharp
public abstract class TerraformConstruct
{
    // Internal storage for property values SET by user (via setters)
    private readonly Dictionary<string, object?> _propertyValues = new();

    // Called by source-generated setters to store values
    protected void SetPropertyValue(string terraformName, object? value)
    {
        _propertyValues[terraformName] = value;
    }

    // Gets the internal property values dictionary for serialization
    internal IReadOnlyDictionary<string, object?> PropertyValues => _propertyValues;

    // Serialization uses stored values
    protected virtual void WriteProperties(StringBuilder sb, ITerraformContext context)
    {
        var resolveContext = new TerraformResolveContext(this);

        foreach (var (terraformName, value) in _propertyValues)
        {
            if (value == null) continue;

            TerraformExpression expression;
            if (value is ITerraformResolvable resolvable)
            {
                expression = resolvable.Resolve(resolveContext);
            }
            else
            {
                expression = TerraformExpression.Literal(value);
            }

            sb.AppendLine($"{context.Indent}{terraformName} = {expression.ToHcl(context)}");
        }
    }
}
```

### 1. Resources (Already Covered)

```csharp
// User code
public partial class AzurermResourceGroup : TerraformResource
{
    [TerraformProperty("name")]
    public required partial TerraformValue<string> Name { get; set; }

    [TerraformPropertyName("max_inactive_revisions")]
    public TerraformValue<double>? MaxInactiveRevisions { get; set; }
}

// Generated code
public partial class AzurermResourceGroup
{
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetPropertyValue("name", value);
    }

    public TerraformValue<string> NameValue
    {
        get => GetRequiredPropertyValue<TerraformValue<string>>("name")
    }

    public required TerraformValue<string> MaxInactiveRevisions
    {
        get => new TerraformReference<string>(this, "max_inactive_revisions");
        set => SetPropertyValue("max_inactive_revisions", value);
    }

    public TerraformValue<string> MaxInactiveRevisionsValue
    {
        get => GetPropertyValue<TerraformValue<string>>("max_inactive_revisions")
    }
}
```

### 2. Data Sources (Same Pattern as Resources)

Data sources work EXACTLY the same as resources - they have properties that can be referenced:

```csharp
// User code
public partial class DataAzurermResourceGroup : TerraformDataSource
{
    public DataAzurermResourceGroup(string name) : base("azurerm_resource_group", name) { }

    // Filter properties (writable)
    [TerraformProperty("name")]
    public required partial TerraformValue<string> Name { get; set; }

    // Computed properties (read-only references)
    [TerraformProperty("location")]
    public partial TerraformValue<string> Location { get; }

    [TerraformProperty("tags")]
    public partial TerraformMap<string> Tags { get; }
}

// Generated code
public partial class DataAzurermResourceGroup
{
    // Writable property (filter)
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetPropertyValue("name", value);
    }

    // Value accessor for the filter property
    public TerraformValue<string> NameValue
    {
        get => GetRequiredPropertyValue<TerraformValue<string>>("name");
    }

    // Read-only computed properties (no setters, no value accessors)
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    public TerraformMap<string> Tags
    {
        get => new TerraformReference<string>(this, "tags");
    }
}

// Usage
var existingRg = new DataAzurermResourceGroup("existing")
{
    Name = "my-existing-rg"  // Filter: which resource group to look up
};

var app = new AzurermContainerApp("app")
{
    Location = existingRg.Location,  // Reference computed attribute
    ResourceGroupName = existingRg.Name  // Reference the name
};
```

**Key difference from resources**: Data sources have both filter properties (writable, used in lookup) and computed properties (read-only, populated by Terraform).

### 3. Variables (Implicit Reference Conversion)

Variables should work like resources - accessing the variable itself should give you a reference:

```csharp
public class TerraformVariable : TerraformConstruct
{
    public string Name { get; }

    public TerraformVariable(string name)
    {
        Name = name;
    }

    // Declaration properties use manual implementation (fixed schema)
    [TerraformProperty("description")]
    public TerraformValue<string>? Description
    {
        get => GetPropertyValue<TerraformValue<string>?>("description");
        set => SetPropertyValue("description", value);
    }

    [TerraformProperty("default")]
    public TerraformValue<object>? Default
    {
        get => GetPropertyValue<TerraformValue<object>?>("default");
        set => SetPropertyValue("default", value);
    }

    [TerraformProperty("type")]
    public TerraformValue<string>? Type
    {
        get => GetPropertyValue<TerraformValue<string>?>("type");
        set => SetPropertyValue("type", value);
    }

    [TerraformProperty("sensitive")]
    public TerraformValue<bool>? Sensitive
    {
        get => GetPropertyValue<TerraformValue<bool>?>("sensitive");
        set => SetPropertyValue("sensitive", value);
    }

    // Implicit conversion to reference - makes variable usage natural
    public static implicit operator TerraformExpression(TerraformVariable variable)
        => TerraformExpression.Identifier($"var.{variable.Name}");
}

// Usage - MUCH cleaner!
var envVar = new TerraformVariable("environment")
{
    Description = "The deployment environment",
    Type = "string",
    Default = "dev"
};

var rg = new AzurermResourceGroup("rg")
{
    // Variable implicitly converts to reference - just use it directly!
    Name = TerraformExpression.Interpolate("rg-", envVar)  // No .AsReference() needed!
};

// Or even simpler if TerraformExpression.Interpolate accepts TerraformExpression params:
var rg2 = new AzurermResourceGroup("rg2")
{
    Name = $"rg-{envVar}"  // Implicit conversion makes this natural
};
```

**Key Insight**: Use C# implicit conversion operators so variables "just work" as references without explicit `.AsReference()` calls.

**Recommendation**: Variables DON'T need source generator (fixed schema), but DO need implicit conversion operator for natural reference usage.

### 4. Outputs (Implicit Reference Conversion)

Outputs work the same as variables - use implicit conversion for natural reference usage:

```csharp
public class TerraformOutput : TerraformConstruct
{
    public string Name { get; }

    public TerraformOutput(string name)
    {
        Name = name;
    }

    // Declaration properties use manual implementation
    [TerraformProperty("value")]
    public TerraformValue<object>? Value
    {
        get => GetPropertyValue<TerraformValue<object>?>("value");
        set => SetPropertyValue("value", value);
    }

    [TerraformProperty("description")]
    public TerraformValue<string>? Description
    {
        get => GetPropertyValue<TerraformValue<string>?>("description");
        set => SetPropertyValue("description", value);
    }

    [TerraformProperty("sensitive")]
    public TerraformValue<bool>? Sensitive
    {
        get => GetPropertyValue<TerraformValue<bool>?>("sensitive");
        set => SetPropertyValue("sensitive", value);
    }

    // Implicit conversion for module outputs context
    public static implicit operator TerraformExpression(TerraformOutput output)
        => TerraformExpression.Identifier($"module.{output.Name}");  // or output.{Name} depending on context
}

// Usage
var output = new TerraformOutput("api_fqdn")
{
    Value = containerApp.Fqdn,
    Description = "The FQDN of the API",
    Sensitive = false
};

// If used in module context, implicit conversion provides reference
var anotherResource = new SomeResource("res")
{
    Fqdn = output  // Implicitly converts to reference
};
```

**Note**: Outputs are typically only used for declaration (not referencing), but if needed in module contexts, implicit conversion provides consistency.

**Recommendation**: Outputs DON'T need source generator (fixed schema), optionally add implicit conversion if output referencing is needed.

### 5. Locals (Dictionary Pattern with Reference Indexer)

Locals remain dictionary-based but the indexer already returns a reference - this is the right pattern:

```csharp
public class TerraformLocal : TerraformConstruct
{
    // Dynamic dictionary of local values
    private readonly Dictionary<string, object> _locals = new();

    // Setter - stores the value for serialization
    public void Set(string name, object value)
    {
        SetPropertyValue(name, value);  // Use base class storage
    }

    // Indexer - ALWAYS returns reference (consistent with resources!)
    public TerraformExpression this[string name]
    {
        get => TerraformExpression.Identifier($"local.{name}");
    }
}

// Usage - already correct!
var locals = new TerraformLocal();
locals.Set("common_tags", new TerraformMap<string>
{
    ["environment"] = "production",
    ["managed_by"] = "terraform"
});

var rg = new AzurermResourceGroup("rg")
{
    Tags = locals["common_tags"]  // Indexer returns reference - perfect!
};
```

**Analysis**: Locals already have the right pattern - setter stores value, getter (indexer) returns reference. This matches the resource property pattern exactly!

**Recommendation**: Locals DON'T need source generator - they already work correctly. Just ensure they use base class `SetPropertyValue()` for storage.

### 6. Providers (Properties Only, No References)

Providers have configuration properties but aren't referenced like resources:

```csharp
// Generated provider class (DOES benefit from source generator)
public partial class AzurermProvider : TerraformProvider
{
    [TerraformProperty("features")]
    public partial AzurermProviderFeatures Features { get; set; }

    [TerraformProperty("subscription_id")]
    public partial TerraformValue<string>? SubscriptionId { get; set; }

    [TerraformProperty("client_id")]
    public partial TerraformValue<string>? ClientId { get; set; }
}

// Source-generated code
public partial class AzurermProvider
{
    // Properties use source generator for consistency
    // BUT: Getters don't return references (providers aren't referenced!)
    // So what should the getter return?

    public AzurermProviderFeatures Features
    {
        // Option 1: Return stored value (if exists), else create dummy
        get => GetPropertyValue<AzurermProviderFeatures>("features")
               ?? new AzurermProviderFeatures();

        set => SetPropertyValue("features", value);
    }

    public TerraformValue<string>? SubscriptionId
    {
        // Option 2: Always return reference (for consistency, even though useless)
        get => new TerraformReference<string>(this, "subscription_id");

        set => SetPropertyValue("subscription_id", value);
    }
}
```

**Analysis**: Providers have properties but they're NEVER referenced in HCL (you don't write `azurerm_provider.main.subscription_id`). The getter behavior is unclear.

**Recommendation**: Providers CAN use source generator for consistency, but the getter pattern is different:

- **Option A**: Return stored value (break from reference pattern)
- **Option B**: Return reference (useless but consistent)
- **Option C**: Don't use source generator, hand-write properties

**Suggested approach**: Use source generator but make getter return stored value for providers:

```csharp
// Custom generator behavior for TerraformProvider base class
if (baseClass == "TerraformProvider")
{
    // Providers: getter returns stored value (not reference)
    code.AppendLine($"        get => GetPropertyValue<{propertyType}>(\"{terraformName}\");");
}
else
{
    // Resources/DataSources: getter returns reference
    code.AppendLine($"        get => new TerraformReference<{innerType}>(this, \"{terraformName}\");");
}
```

### Summary: Which Constructs Need Source Generators?

| Construct Type  | Use Source Generator? | Reference Pattern           | Implementation Strategy                         |
| --------------- | --------------------- | --------------------------- | ----------------------------------------------- |
| **Resource**    | ✅ YES                | Property getter (reference) | Source-generated properties return references   |
| **Data Source** | ✅ YES                | Property getter (reference) | Source-generated properties return references   |
| **Provider**    | ✅ YES                | N/A (not referenced)        | Source-generated properties return stored value |
| **Variable**    | ❌ NO                 | Implicit conversion         | Hand-written, implicit operator to expression   |
| **Output**      | ❌ NO                 | Implicit conversion         | Hand-written, implicit operator to expression   |
| **Local**       | ❌ NO                 | Indexer (reference)         | Hand-written indexer returns reference          |

### Updated Source Generator Logic

```csharp
private void GenerateProperty(StringBuilder code, PropertyDeclarationSyntax property, INamedTypeSymbol classSymbol)
{
    var propertyName = property.Identifier.Text;
    var terraformName = GetTerraformName(property);
    var propertyType = property.Type.ToString();
    var hasSet = property.AccessorList?.Accessors.Any(a => a.IsKind(SyntaxKind.SetAccessorDeclaration)) ?? false;
    var isRequired = property.Modifiers.Any(m => m.IsKind(SyntaxKind.RequiredKeyword));
    var isNullable = propertyType.EndsWith("?");

    // Determine base class to decide getter behavior
    var baseClass = GetBaseClass(classSymbol);
    var shouldReturnReference = baseClass == "TerraformResource" || baseClass == "TerraformDataSource";

    // Generate main property
    var requiredModifier = isRequired ? "required " : "";
    code.AppendLine($"    public {requiredModifier}{propertyType} {propertyName}");
    code.AppendLine("    {");

    // Getter behavior depends on construct type
    if (shouldReturnReference)
    {
        // Resources and DataSources: getter returns reference
        var innerType = ExtractGenericType(propertyType);
        code.AppendLine($"        get => new TerraformReference<{innerType}>(this, \"{terraformName}\");");
    }
    else
    {
        // Providers: getter returns stored value
        code.AppendLine($"        get => GetPropertyValue<{propertyType}>(\"{terraformName}\");");
    }

    // Setter stores value (if property has setter)
    if (hasSet)
    {
        code.AppendLine($"        set => SetPropertyValue(\"{terraformName}\", value);");
    }

    code.AppendLine("    }");
    code.AppendLine();

    // Generate value accessor property (only for properties with setters)
    if (hasSet && shouldReturnReference)
    {
        code.AppendLine($"    public {propertyType} {propertyName}Value");
        code.AppendLine("    {");

        if (isRequired)
        {
            // Required properties use GetRequiredPropertyValue (throws if not set)
            code.AppendLine($"        get => GetRequiredPropertyValue<{propertyType}>(\"{terraformName}\");");
        }
        else
        {
            // Optional properties use GetPropertyValue (returns null if not set)
            code.AppendLine($"        get => GetPropertyValue<{propertyType}>(\"{terraformName}\");");
        }

        code.AppendLine("    }");
        code.AppendLine();
    }
}
```

## Conclusion

### Unified Reference Pattern Across All Constructs

All Terraform constructs now follow a **consistent pattern**: accessing them gives you a reference automatically, no manual conversion needed!

```csharp
// Resources & Data Sources: Property access returns reference
var app = new AzurermContainerApp("app")
{
    ResourceGroupName = resourceGroup.Name,  // ✅ Property getter returns reference
    Location = dataSource.Location           // ✅ Property getter returns reference
};

// Variables: Implicit conversion to reference
var rg = new AzurermResourceGroup("rg")
{
    Name = TerraformExpression.Interpolate("rg-", envVar)  // ✅ Implicit conversion
};

// Locals: Indexer returns reference
var app2 = new AzurermContainerApp("app2")
{
    Tags = locals["common_tags"]  // ✅ Indexer returns reference
};
```

### Source Generator Benefits

- ✅ Eliminates runtime reflection
- ✅ Clearer getter/setter semantics (get=reference, set=value)
- ✅ No duplicate properties
- ✅ Compile-time code generation
- ✅ Maintains type safety and IntelliSense
- ✅ Natural C# syntax across ALL construct types

### Implementation Strategy

**Source Generator (for many properties)**:

- ✅ Resources (property getters return references)
- ✅ Data Sources (property getters return references)
- ✅ Providers (property getters return stored values - not referenced)

**Hand-Written (for fixed schema)**:

- ✅ Variables (implicit conversion operator → reference)
- ✅ Outputs (implicit conversion operator → reference)
- ✅ Locals (indexer → reference)

**Recommendation**: Implement source generator for Resources, DataSources, and Providers. Use implicit conversion operators and indexers for Variables, Outputs, and Locals to maintain consistent "just use it" semantics across all construct types!
