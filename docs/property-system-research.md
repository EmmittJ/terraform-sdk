# Research: Property System Design for Terraform SDK

## Executive Summary

After examining AWS CDK, Pulumi, and Azure SDK implementations, I found that:

1. **None of them use source generators** for property implementations
2. **AWS CDK** uses a Token system with runtime encoding/decoding
3. **Pulumi** uses `Input<T>`/`Output<T>` wrapper types backed by `Task<OutputData<T>>`
4. **Azure SDK** uses T4 templates/code generation (not source generators)
5. **All use simple POCOs** - properties are just regular auto-properties with wrapper types

## Key Findings

### 1. AWS CDK Token System (TypeScript)

**Pattern**: Lazy evaluation with token encoding

```typescript
// Resource interface
export interface IBucket {
  readonly bucketArn: string;      // Can be literal OR token
  readonly bucketName: string;     // Can be literal OR token
  readonly bucketDomainName: string;
}

// Properties are just strings
public readonly bucketArn: string;
public readonly bucketName: string;

// Token wraps IResolvable for lazy evaluation
Token.asString(value)  // Encodes IResolvable into a string
Token.isUnresolved(obj) // Check if contains tokens
```

**How it works**:

1. Properties are declared as primitive types (`string`, `number`, etc.)
2. Values can be:
   - **Literals**: `"my-bucket"` - stored directly
   - **Tokens**: Special encoded strings that represent `IResolvable` objects
3. At synthesis time, tokens are **decoded** and `resolve()` is called
4. **No getter/setter magic** - properties are simple auto-properties

**Key Classes**:

- `IResolvable`: Interface for lazy values
  ```typescript
  interface IResolvable {
    readonly creationStack: string[];
    resolve(context: IResolveContext): any;
    toString(): string;
  }
  ```
- `Token`: Static methods for encoding/decoding
- `Reference`: Implements `IResolvable` for cross-stack references
- `Lazy`: Implements `IResolvable` for deferred computation

**Referencing another resource**:

```typescript
const bucket1 = new Bucket(this, "bucket1", { bucketName: "my-bucket" });

// Reference is just a property access - returns token-encoded string
const app = new ContainerApp(this, "app", {
  // bucket1.bucketName returns a TOKEN (encoded IResolvable)
  containerName: bucket1.bucketName,
});
```

**Benefits**:

- ✅ Simple API - properties are just primitive types
- ✅ No wrapper types in user code
- ✅ Token encoding is invisible to users
- ✅ Works across language boundaries (JSII)

**Drawbacks**:

- ⚠️ Runtime encoding/decoding overhead
- ⚠️ Token encoding is "magic" - harder to debug
- ⚠️ TypeScript-centric (JSII generates other languages)

---

### 2. Pulumi Input/Output System (.NET)

**Pattern**: Input<T> for writes, Output<T> for reads

```csharp
// Resource class
public class Bucket : CustomResource
{
    [Output("arn")]
    public Output<string> Arn { get; private set; }

    [Output("bucketName")]
    public Output<string> BucketName { get; private set; }
}

// Resource args (inputs)
public class BucketArgs : ResourceArgs
{
    [Input("bucketName")]
    public Input<string>? BucketName { get; set; }

    [Input("tags")]
    public InputMap<string>? Tags { get; set; }
}
```

**How it works**:

1. **Resource properties** are `Output<T>` (read-only computed values)
2. **Constructor args** are `Input<T>` (values being set)
3. `Input<T>` implicitly converts from `T` or `Output<T>`
4. `Output<T>` wraps `Task<OutputData<T>>` - async value + metadata

**Key insight**:

```csharp
// Input<T> is just a wrapper around Output<T>
public class Input<T>
{
    private protected Output<T> _outputValue;

    public static implicit operator Input<T>(T value)
        => Output.Create(value);  // Wrap literal

    public static implicit operator Input<T>(Output<T> value)
        => new Input<T>(value);   // Wrap output
}
```

**Referencing another resource**:

```csharp
var bucket1 = new Bucket("bucket1", new BucketArgs
{
    BucketName = "my-bucket"  // string → Input<string> (implicit)
});

var app = new ContainerApp("app", new ContainerAppArgs
{
    // bucket1.BucketName is Output<string>
    // → converts to Input<string> (implicit)
    ContainerName = bucket1.BucketName
});
```

**Serialization**:

- Uses **reflection** at runtime to discover `[Input]` and `[Output]` attributes
- Calls `ToDictionaryAsync()` on `ResourceArgs` to serialize
- No source generators - all runtime reflection

**Benefits**:

- ✅ Clear separation: `Input<T>` for writes, `Output<T>` for reads
- ✅ Async-friendly (`Output<T>` wraps `Task`)
- ✅ Type-safe with generics
- ✅ Implicit conversions make it feel natural

**Drawbacks**:

- ⚠️ Wrapper types everywhere (`Input<string>` vs `string`)
- ⚠️ Reflection overhead at runtime
- ⚠️ Resource args are separate classes (more boilerplate)

---

### 3. Azure SDK Code Generation

**Pattern**: T4 templates generate POCOs at build time

```csharp
// Generated model
public partial class ResourceGroup
{
    public string Name { get; set; }
    public string Location { get; set; }
    public IDictionary<string, string> Tags { get; set; }
}
```

**How it works**:

1. Read TypeSpec/OpenAPI definitions
2. **Generate C# code** using templates (not source generators!)
3. Output regular POCO classes
4. Use `System.Text.Json` for serialization

**No source generators**:

- Azure SDK uses **T4 templates** and **custom code generation**
- Generates full `.cs` files at build time
- **Not** incremental source generators

**Benefits**:

- ✅ Simple POCOs - no wrapper types
- ✅ Standard JSON serialization
- ✅ Mature, battle-tested approach

**Drawbacks**:

- ⚠️ Requires complex code generation infrastructure
- ⚠️ Not suitable for our use case (we have resources, not just DTOs)

---

## Analysis: What Does This Mean for Terraform SDK?

### Option 1: AWS CDK Token Approach (Encoding/Decoding)

**Concept**: Properties are `TerraformValue<T>`, which stores either a literal or an `ITerraformResolvable`. At serialization, decode and resolve.

```csharp
public class AzurermResourceGroup : TerraformResource
{
    // Property is just TerraformValue<string> - no getter/setter magic
    public required TerraformValue<string> Name { get; set; }

    public required TerraformValue<string> Location { get; set; }
}

// Usage
var rg = new AzurermResourceGroup("rg")
{
    Name = "my-rg",      // string → TerraformValue<string> (implicit)
    Location = "eastus"
};

var app = new AzurermApp("app")
{
    // rg.Name returns TerraformValue<string> containing a TerraformReference
    // BUT HOW? Property is auto-property, returns what was SET!
    ResourceGroupName = rg.Name  // ❌ PROBLEM: Returns literal "my-rg", not reference!
};
```

**Fatal flaw**: Auto-properties return what was set, not a reference. We'd need getter/setter logic.

---

### Option 2: Pulumi Input/Output Approach

**Concept**: Resource properties are `Output<T>`, constructor args are `Input<T>`.

```csharp
public class AzurermResourceGroup : TerraformResource
{
    public AzurermResourceGroup(string name, AzurermResourceGroupArgs args)
        : base("azurerm_resource_group", name)
    {
        // Store args, create outputs
        this.Name = Output.Create(args.Name);
        this.Location = Output.Create(args.Location);
    }

    public Output<string> Name { get; private set; }
    public Output<string> Location { get; private set; }
    public Output<string> Id { get; private set; }
}

public class AzurermResourceGroupArgs
{
    [TerraformProperty("name")]
    public Input<string>? Name { get; set; }

    [TerraformProperty("location")]
    public Input<string>? Location { get; set; }
}

// Usage
var rg = new AzurermResourceGroup("rg", new AzurermResourceGroupArgs
{
    Name = "my-rg",
    Location = "eastus"
});

var app = new AzurermApp("app", new AzurermAppArgs
{
    ResourceGroupName = rg.Name  // Output<string> → Input<string> (implicit)
});
```

**Benefits**:

- ✅ Clear separation: args for inputs, outputs for references
- ✅ No getter/setter magic needed
- ✅ Type-safe

**Drawbacks**:

- ⚠️ **Breaking change** - completely different API
- ⚠️ More boilerplate (args classes for every resource)
- ⚠️ Less ergonomic (separate args class)

---

### Option 3: Hybrid - Simple References

**Concept**: Keep current `TerraformValue<T>` but add a way to get references.

```csharp
public class AzurermResourceGroup : TerraformResource
{
    public required TerraformValue<string> Name { get; set; }
    public required TerraformValue<string> Location { get; set; }
}

// Usage
var rg = new AzurermResourceGroup("rg")
{
    Name = "my-rg",
    Location = "eastus"
};

var app = new AzurermApp("app")
{
    // ✅ SOLUTION 1: Explicit method call
    ResourceGroupName = rg.GetReference("name")

    // ✅ SOLUTION 2: Extension method
    ResourceGroupName = rg.Name.AsReference()

    // ✅ SOLUTION 3: Ref() method on resource
    ResourceGroupName = rg.Ref(r => r.Name)
};
```

**Problem**: Still requires explicit "get reference" syntax. Not as clean as just `rg.Name`.

---

### Option 4: Source Generator with Backing Storage

**Concept**: Generate properties that use dictionary backing.

```csharp
// User writes:
public partial class AzurermResourceGroup : TerraformResource
{
    [TerraformProperty("name")]
    public required partial TerraformValue<string> Name { get; set; }
}

// Generator produces:
public partial class AzurermResourceGroup
{
    public required TerraformValue<string> Name
    {
        get => GetStoredValue<string>("name")
               ?? TerraformReference.For<string>(this, "name");
        set => StoreValue("name", value);
    }
}
```

**Problem with `TerraformValue.FromResolvable<string>(new TerraformReference(this, "name"))`**:

- Way too verbose!
- Should be: `TerraformReference.For<string>(this, "name")` or even simpler

**Better design**:

```csharp
// TerraformReference IS a TerraformValue
public class TerraformReference<T> : TerraformValue<T>
{
    public TerraformReference(TerraformResource resource, string attributeName)
        : base(new TerraformReferenceResolvable(resource, attributeName))
    {
    }
}

// Usage in generator:
get => GetStoredValue<string>("name")
       ?? new TerraformReference<string>(this, "name");
```

---

## Recommendation: Simplified Approach

After seeing how CDK and Pulumi work, here's what I recommend:

### Keep It Simple - No Source Generators (Yet)

**Proposed Design**:

```csharp
public class TerraformReference<T> : TerraformValue<T>
{
    private readonly TerraformResource _resource;
    private readonly string _attribute;

    public TerraformReference(TerraformResource resource, string attribute)
        : base(CreateResolvable(resource, attribute))
    {
        _resource = resource;
        _attribute = attribute;
    }

    private static ITerraformResolvable CreateResolvable(
        TerraformResource resource, string attribute)
    {
        return new TerraformReferenceResolvable(resource, attribute);
    }
}

// Resource class
public class AzurermResourceGroup : TerraformResource
{
    [TerraformProperty("name")]
    public required TerraformValue<string> Name { get; set; }

    [TerraformProperty("location")]
    public required TerraformValue<string> Location { get; set; }

    // Computed property - returns reference
    public TerraformReference<string> NameRef =>
        new TerraformReference<string>(this, "name");

    public TerraformReference<string> LocationRef =>
        new TerraformReference<string>(this, "location");

    public TerraformReference<string> Id =>
        new TerraformReference<string>(this, "id");
}

// Usage
var rg = new AzurermResourceGroup("rg")
{
    Name = "my-rg",
    Location = "eastus"
};

var app = new AzurermApp("app")
{
    ResourceGroupName = rg.NameRef,  // Explicit reference
    Location = rg.LocationRef
};
```

**Why this is better**:

1. ✅ No source generators - simpler
2. ✅ Explicit references - clear intent
3. ✅ `TerraformReference<T>` IS a `TerraformValue<T>` - clean type hierarchy
4. ✅ Can be auto-generated in templates
5. ✅ No "magic" - straightforward C#

---

## Alternative: Just Use Methods

Even simpler - no special reference type:

```csharp
public class AzurermResourceGroup : TerraformResource
{
    [TerraformProperty("name")]
    public required TerraformValue<string> Name { get; set; }

    // Reference helper method
    public TerraformValue<T> Ref<T>(string attribute) =>
        TerraformValue.FromResolvable<T>(
            new TerraformReference(this, attribute));
}

// Usage
var app = new AzurermApp("app")
{
    ResourceGroupName = rg.Ref<string>("name"),  // Generic method
    Location = rg.Ref<string>("location")
};
```

**Even simpler - string indexer**:

```csharp
public class TerraformResource
{
    // String indexer returns reference
    public TerraformValue<string> this[string attribute] =>
        TerraformValue.FromResolvable<string>(
            new TerraformReference(this, attribute));
}

// Usage
var app = new AzurermApp("app")
{
    ResourceGroupName = rg["name"],      // ✨ Super clean!
    Location = rg["location"],
    ContainerEnvId = containerEnv["id"]
};
```

This already exists in playground code (`postgresServer["fqdn"]`)!

---

## Final Recommendation

**Use the indexer pattern that's ALREADY in the codebase**:

1. Keep `TerraformValue<T>` for property types
2. Use reflection-based serialization (like Pulumi)
3. Add indexer to `TerraformResource` for references
4. Skip source generators for now (YAGNI)

**Rationale**:

- AWS CDK uses runtime token encoding - works great
- Pulumi uses runtime reflection - works great
- Source generators add complexity without clear benefit
- Indexer syntax (`rg["name"]`) is clean and explicit
- Can optimize later if performance is an issue (spoiler: it won't be)

**Next step**: Improve the indexer implementation to be type-safe and well-documented.
