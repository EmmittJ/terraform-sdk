---
applyTo: "src/EmmittJ.Terraform.Sdk.SourceGenerators/**"
---

# Source Generator Development

## Adding Source Generator Features

- Source generators are in `src/EmmittJ.Terraform.Sdk.SourceGenerators/`
- Use incremental source generators for performance
- Follow Roslyn best practices for diagnostics and error handling
- Test thoroughly - source generator bugs are hard to debug

## Current Generators

### MetaArgumentGenerator

Generates meta-argument properties for blocks that implement meta-argument interfaces:

- `ITerraformHasCount` → `Count` property
- `ITerraformHasForEach` → `ForEach` property
- `ITerraformHasDependsOn` → `DependsOn` property
- `ITerraformHasProvider` → `Provider` property
- `ITerraformHasLifecycle` → `Lifecycle` property

### TerraformPropertyGenerator

Generates property implementations for classes marked with `[TerraformArgument]`:

- Handles `get`/`set` logic for arguments
- Tracks property changes for resolution phase
- Integrates with `TerraformBlock.SetPropertyValue()` infrastructure

## Best Practices

- ✅ Use `IncrementalGeneratorInitializationContext` for performance
- ✅ Filter syntax nodes early to minimize work
- ✅ Generate diagnostic messages with proper severity
- ✅ Include source locations in diagnostics for better IDE experience
- ✅ Test with multiple compilation scenarios
- ❌ Don't generate code that depends on reflection at runtime
- ❌ Don't assume compilation will succeed - handle partial types gracefully
