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
- ✅ Use descriptive test method names that explain what's being tested
- ❌ **Do NOT leave newly-added tests commented out** - all tests should build and pass
- ❌ **Do NOT use** `Directory.SetCurrentDirectory()` - causes side effects in concurrent execution

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
