# EmmittJ.Aspire.Hosting.Terraform Tests

Comprehensive test suite for the Terraform hosting integration for .NET Aspire.

## Test Structure

This test project follows Aspire's testing patterns and includes:

### TerraformBuilderExtensionsTests
Tests for the builder extension methods:
- `AddTerraformStack()` - Returns the stack resource builder
- `WithTerraformStack()` - Returns the parent builder for chaining
- `WithTerraformWorkingDirectory()` - Sets the working directory
- Validation of arguments and error handling
- Registration of lifecycle hooks

### TerraformStackResourceTests
Tests for the `TerraformStackResource` class:
- Constructor validation
- Property accessors
- Interface implementations
- Annotation support

### TerraformAnnotationsTests
Tests for the `TerraformConfigurationAnnotation`:
- Property getters/setters
- Resource attachment
- Multiple annotations handling

### TerraformEventingSubscriberTests
Tests for the lifecycle hook:
- Stack validation during resource creation
- Error handling for invalid stacks
- Service registration

## Running Tests

```powershell
# Run all tests
dotnet test

# Run specific test class
dotnet test --filter "FullyQualifiedName~TerraformBuilderExtensionsTests"

# Run tests with detailed output
dotnet test --verbosity detailed
```

## Test Coverage

The test suite covers:
- ✅ Builder extension method behavior
- ✅ Resource creation and parent-child relationships
- ✅ Annotation handling
- ✅ Lifecycle hook validation
- ✅ Error handling and edge cases
- ✅ Method chaining patterns
