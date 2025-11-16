---
applyTo: "**/tests/**"
---

# Testing Guidelines

## 🧪 Test Organization

- Tests mirror the `src/` structure in `tests/`
- Use xUnit with Verify.Xunit for snapshot testing
- Test files should end with `Tests.cs` (e.g., `TerraformResourceTests.cs`)
- See `tests/TEST_INVENTORY.md` for comprehensive test categorization

## Test Style

- ❌ **Do NOT emit** "Arrange", "Act", or "Assert" comments
- ✅ Copy existing style from nearby test files for naming and capitalization
- ✅ **Always use object initializer syntax** for resource properties instead of separate assignment statements
- ✅ Use descriptive test method names that explain what's being tested
- ❌ **Do NOT leave newly-added tests commented out** - all tests should build and pass
- ❌ **Do NOT use** `Directory.SetCurrentDirectory()` - causes side effects in concurrent execution

### Object Initializer Pattern

```csharp
// ✅ Good: Use object initializer syntax
var resource = new TerraformResource("aws_instance", "example")
{
    ["ami"] = "ami-12345678",
    ["instance_type"] = "t2.micro",
    ["tags"] = new TerraformMap<object>
    {
        ["Name"] = "Example"
    },
    Count = 3,
    Provider = "aws.us_west_2"
};

// ❌ Bad: Separate assignment statements
var resource = new TerraformResource("aws_instance", "example");
resource["ami"] = "ami-12345678";
resource["instance_type"] = "t2.micro";
resource.Count = 3;
```

## Running Tests

**Prerequisites**: Build first with `dotnet build` from repository root

```powershell
# Run all tests in a specific project (exclude long-running tests)
dotnet test tests/EmmittJ.Terraform.Sdk.Tests/EmmittJ.Terraform.Sdk.Tests.csproj

# Run a specific test
dotnet test tests/EmmittJ.Terraform.Sdk.Tests/EmmittJ.Terraform.Sdk.Tests.csproj --filter "FullyQualifiedName~TerraformResourceTests.CanCreateBasicResource"

# Run tests by class name
dotnet test tests/EmmittJ.Terraform.Sdk.Tests/EmmittJ.Terraform.Sdk.Tests.csproj --filter "ClassName~TerraformResourceTests"
```

## Snapshot Testing with Verify

- Snapshot files are stored in `Snapshots/` directories within test projects
- After updating tests that generate new output, accept snapshots:
  ```powershell
  dotnet verify accept -y
  ```
- The `verify` tool is available globally as part of the development setup
