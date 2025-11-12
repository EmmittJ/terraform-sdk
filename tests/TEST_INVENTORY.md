# Test Suite Inventory

**Status:** Tests temporarily removed during TerraformBlock → TerraformBlock refactoring
**Date:** November 12, 2025
**Reason:** Converting from fluent API (.WithProperty) to map indexer syntax (resource["property"] = value)

## Test File Categories

### Core Block Types (11 files)

These test the fundamental Terraform block types and their HCL generation:

1. **TerraformResourceTests.cs** - Resource blocks (aws_vpc, aws_instance, etc.)

   - Basic resource declaration
   - Properties and meta-arguments
   - Resource references and outputs
   - Count and for_each
   - Provider assignment
   - DependsOn relationships

2. **TerraformDataSourceTests.cs** - Data source blocks

   - Data source declaration
   - Property setting
   - Output references

3. **TerraformModuleTests.cs** - Module blocks

   - Module source and version
   - Input variables
   - Output references
   - Local vs remote modules

4. **TerraformProviderTests.cs** - Provider configuration blocks

   - Provider configuration
   - Aliases
   - Multiple provider instances
   - References to variables

5. **TerraformLocalTests.cs** - Locals blocks

   - Local value definitions
   - Expressions
   - References to other locals

6. **TerraformOutputTests.cs** - Output blocks

   - Output declarations
   - Value expressions
   - Sensitive outputs
   - Descriptions

7. **TerraformVariableTests.cs** - Variable blocks

   - Variable declarations
   - Types and defaults
   - Validation rules
   - Descriptions

8. **TerraformBackendTests.cs** - Backend configuration

   - Backend type and configuration
   - Remote state

9. **TerraformSettingsTests.cs** - Terraform settings block

   - Required version
   - Required providers
   - Experiments

10. **TerraformImportBlockTests.cs** - Import blocks

    - Import declarations
    - ID and to references

11. **TerraformMovedBlockTests.cs** - Moved blocks
    - Refactoring declarations
    - From and to references

### Advanced Features (8 files)

12. **TerraformDynamicBlockTests.cs** - Dynamic block generation

    - Dynamic nested blocks
    - for_each in dynamic blocks
    - Content expressions

13. **TerraformCheckBlockTests.cs** - Check blocks (assertions)

    - Data source checks
    - Assert conditions
    - Error messages

14. **LifecycleTests.cs** - Lifecycle meta-argument

    - create_before_destroy
    - prevent_destroy
    - ignore_changes
    - replace_triggered_by

15. **LifecycleConditionTests.cs** - Lifecycle with preconditions/postconditions

    - Precondition assertions
    - Postcondition assertions
    - Error messages

16. **TerraformProviderMetaTests.cs** - Provider meta-arguments

    - provider assignment
    - Configuration details

17. **TerraformCloudConfigTests.cs** - Terraform Cloud configuration

    - Organization
    - Workspaces
    - Cloud backend

18. **ValidationTests.cs** - Validation rules and constraints

    - Circular dependency detection
    - Required property validation
    - Type validation

19. **TerraformValidationTests.cs** - Variable validation blocks
    - Validation rules
    - Condition expressions
    - Error messages

### Expression System (5 files)

20. **TerraformExpressionTests.cs** - Expression types and generation

    - Literal expressions
    - Identifiers
    - Function calls
    - Interpolation
    - Raw HCL

21. **TerraformSplatExpressionTests.cs** - Splat expressions (\*)

    - Full splat (resource[*].attribute)
    - Attribute access
    - Nested splats

22. **TerraformBlockExpressionTests.cs** - Block expression type

    - Block type, labels, and body
    - Resolution to HCL

23. **TfTests.cs** - Tf helper functions

    - Functions.CidrSubnet
    - Functions.Format
    - Functions.Merge
    - Helpers.EachValue
    - Complex nested expressions

24. **TerraformValueTests.cs** - TerraformValue<T> wrapper type
    - Implicit conversions
    - Resolution
    - Generic type handling

### Value Resolution & Context (3 files)

25. **TerraformValueResolverTests.cs** - Value resolution system

    - Resolving primitives
    - Resolving references
    - Resolving collections
    - Context handling

26. **TerraformResolvableTests.cs** - ITerraformResolvable interface

    - Resolve implementation
    - Context propagation

27. **TerraformStackTests.cs** - Stack/configuration management
    - Adding blocks to stack
    - ToHcl() generation
    - Multiple blocks
    - Complete configurations

### Integration (2 files)

28. **TerraformIntegrationTests.cs** - End-to-end scenarios

    - Complete infrastructure examples
    - Multi-resource configurations
    - Cross-references

29. **MapPropertyIntegrationTests.cs** - Dictionary/map property handling
    - Nested maps
    - Complex property structures
    - Type conversions

### API Features (4 files)

33. **EnhancedApiTests.cs** - Enhanced fluent API features

    - Priority-based property ordering (REMOVED with fluent API)
    - Dictionary implicit conversion
    - Mixed type dictionaries

34. **DictionaryInterfaceTests.cs** - IDictionary implementation

    - TerraformMap<T> as dictionary
    - Add/Remove/Contains
    - Enumeration

35. **DictionaryInterfaceUsageExamples.cs** - Dictionary usage patterns

    - Real-world dictionary scenarios

36. **FromObjectTests.cs** - Object-to-Terraform conversion
    - C# object → Terraform map
    - Nested objects
    - Collections

### Infrastructure & Utilities (4 files)

37. **DependencyGraphTests.cs** - Dependency tracking

    - Graph blockion
    - Circular detection
    - Topological sorting

38. **TerraformValidatorTests.cs** - Validation framework

    - Custom validators
    - Built-in validations
    - Error reporting

39. **ModuleInitializer.cs** - Test infrastructure setup

    - Verifier configuration
    - Test helpers

40. **DictionaryInterfaceUsageExamples.cs** - Usage pattern examples

## Test Infrastructure

### Frameworks Used

- **xUnit** - Test framework
- **Verify** - Snapshot testing for HCL output verification

### Test Patterns

1. **Snapshot Tests** - Most tests use `return Verify(config.ToHcl())` to verify generated HCL
2. **Assertion Tests** - Unit tests with direct assertions
3. **Integration Tests** - Full stack tests with multiple components

## Conversion Status

### Fully Converted to Map Syntax (4 files)

- ✅ TerraformResourceTests.cs
- ✅ TerraformModuleTests.cs
- ✅ TerraformProviderTests.cs
- ✅ TerraformLocalTests.cs

### Partially Converted (13 files)

Automated regex conversion completed, may need manual fixes:

- TfTests.cs
- ValidationTests.cs
- TerraformStackTests.cs
- TerraformOutputTests.cs
- TerraformIntegrationTests.cs
- TerraformDynamicBlockTests.cs
- TerraformDataSourceTests.cs
- TerraformSettingsTests.cs
- MapPropertyIntegrationTests.cs
- TerraformSplatExpressionTests.cs
- TerraformValidatorTests.cs
- TerraformValueResolverTests.cs
- EnhancedApiTests.cs (2 tests commented out - priority feature removed)

### Not Yet Converted (~23 files)

Still using fluent API syntax:

- QuickStartExample.cs (complex, needs manual conversion)
- TerraformVariableTests.cs
- TerraformValueTests.cs
- TerraformValidationTests.cs
- TerraformResolvableTests.cs
- TerraformProviderMetaTests.cs
- TerraformMovedBlockTests.cs
- TerraformImportBlockTests.cs
- TerraformExpressionTests.cs
- TerraformBlockExpressionTests.cs
- TerraformCloudConfigTests.cs
- TerraformCheckBlockTests.cs
- TerraformBackendTests.cs
- QuickStartTests.cs
- LifecycleTests.cs
- LifecycleConditionTests.cs
- FromObjectTests.cs
- DictionaryInterfaceUsageExamples.cs
- DictionaryInterfaceTests.cs
- DependencyGraphTests.cs
- GeneratedResourceExample.cs

## Rebuild Strategy

When recreating tests after refactoring:

1. **Start with Core Blocks** - Resource, DataSource, Module, Provider, Local, Output, Variable
2. **Add Expression Tests** - Ensure expression system works
3. **Stack & Resolution** - ToHcl() and context propagation
4. **Advanced Features** - Dynamic blocks, lifecycle, validation
5. **Integration** - Full scenarios
6. **Edge Cases** - Complex nesting, circular deps, etc.

## Key Testing Focus Areas

### Must Have

- ✅ Basic block HCL generation
- ✅ Property setting via map indexer
- ✅ References between blocks
- ✅ Meta-arguments (count, for_each, depends_on, provider, lifecycle)
- ✅ Expression types (literals, identifiers, functions, interpolation)

### Important

- Stack composition
- Dependency tracking
- Validation
- Complex scenarios (multiple resources, cross-references)

### Nice to Have

- Advanced dynamic blocks
- Check blocks
- Cloud/backend configuration
- Terraform 1.5+ features

## Notes

- All tests use Verify library for snapshot testing of HCL output
- Snapshot files stored in `__snapshots__` directories
- Tests verify both correctness and formatting of generated HCL
- Current error count: 164 compilation errors (down from 277)
- Main issue: Fluent API methods still in use, need conversion to map indexer syntax
