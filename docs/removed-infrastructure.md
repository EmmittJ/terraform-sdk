# Removed Infrastructure - Property System Redesign

**Date**: November 10, 2025  
**Status**: Pre-release - Breaking changes acceptable

## Overview

This document tracks the infrastructure being removed as part of the property system redesign described in `terraform-schema-architecture-analysis.md`. Since this SDK has not been released yet, we can make completely breaking changes without migration concerns.

## Files Being Removed

### 1. `TerraformPropertyCollection.cs`

**Path**: `src/EmmittJ.Terraform.Sdk/Context/TerraformPropertyCollection.cs`

**Purpose**: Shared property storage for constructs and configuration containers. Stored heterogeneous values as `object?` in a dictionary.

**Why Removing**:

- Stores everything as `object?`, losing type safety
- No distinction between settable arguments and read-only attributes
- Can't enforce reference semantics for computed properties
- Mixed concerns: storage + ordering logic

**Used By**:

- `TerraformConstruct` - base class for all constructs
- `TerraformSettings` - Terraform settings configuration
- `TerraformBlock` - nested configuration blocks

**Replacement**: Properties will be generated as strongly-typed `TerraformProperty<T>` fields on resource classes. No shared dictionary storage needed.

---

### 2. `TerraformValueResolver.cs`

**Path**: `src/EmmittJ.Terraform.Sdk/Context/TerraformValueResolver.cs`

**Purpose**: Centralized logic for preparing and resolving any value type. Used pattern matching on runtime types to determine how to handle values.

**Why Removing**:

- Runtime type inspection instead of compile-time type safety
- Complex switch statements for different value types
- Doesn't distinguish between set/get operations
- Can't enforce computed-only semantics

**Used By**:

- `TerraformBlock.Prepare()` and `Resolve()`
- `TerraformConstruct.Prepare()` and `WriteProperties()`
- Any container storing property values

**Replacement**: Expression-based resolution via `ITerraformResolvable<TerraformExpression>`. Each type knows how to resolve itself through polymorphism, no runtime inspection needed.

---

### 3. `TerraformValueResolverTests.cs`

**Path**: `tests/EmmittJ.Terraform.Sdk.Tests/TerraformValueResolverTests.cs`

**Purpose**: Tests for `TerraformValueResolver` class.

**Why Removing**: Testing infrastructure that's being removed.

**Replacement**: New test files for property type hierarchy (see implementation plan Phase 5).

---

## Files Being Modified

### 1. `TerraformConstruct.cs`

**Path**: `src/EmmittJ.Terraform.Sdk/Constructs/TerraformConstruct.cs`

**Current Usage**:

- `_properties` field of type `TerraformPropertyCollection`
- `SetProperty()`, `GetProperty()`, `WriteProperties()` methods
- `Prepare()` calls `TerraformValueResolver.PrepareValue()`

**Changes Needed**:

- Remove `_properties` field
- Remove property accessor methods (`SetProperty`, `GetProperty`, etc.)
- Derived classes will have strongly-typed properties instead
- Update `Prepare()` and `Resolve()` to work with generated properties
- May keep abstract methods for HCL generation

**Impact**: Base class becomes simpler, focused on HCL generation infrastructure.

---

### 2. `TerraformBlock.cs`

**Path**: `src/EmmittJ.Terraform.Sdk/Blocks/TerraformBlock.cs`

**Current Usage**:

- `_properties` field of type `TerraformPropertyCollection`
- `SetProperty()`, `GetProperty()`, `WithProperty()` methods
- `Prepare()` and `Resolve()` use `TerraformValueResolver`

**Changes Needed**:

- Remove `_properties` field
- Remove property accessor methods
- Blocks will be plain C# classes with `TerraformProperty<T>` fields
- Implement `ITerraformResolvable<TerraformExpression>` for resolution
- Code generator will create `Resolve()` implementations

**Impact**: Blocks become plain data classes, strongly typed.

---

### 3. `TerraformSettings.cs`

**Path**: `src/EmmittJ.Terraform.Sdk/Configuration/TerraformSettings.cs`

**Current Usage**:

- `_properties` field of type `TerraformPropertyCollection`

**Changes Needed**:

- Remove `_properties` field
- Add strongly-typed properties for Terraform settings
- Update serialization logic

**Impact**: Configuration becomes strongly typed.

---

## Architecture Changes

### Old Architecture

```
User Code
    ↓
TerraformConstruct.SetProperty(key, object?)
    ↓
TerraformPropertyCollection (stores as object?)
    ↓
TerraformValueResolver.ResolveValue(object?)
    ↓
Runtime type inspection + switch statements
    ↓
HCL String
```

**Problems**:

- Type erasure (`object?` storage)
- Runtime type inspection
- No distinction between arguments and attributes
- Can't enforce read-only semantics
- No reference tracking

### New Architecture

```
User Code
    ↓
Resource.Property (strongly typed TerraformProperty<T>)
    ↓
Polymorphic Resolve() via ITerraformResolvable
    ↓
TerraformExpression (type-safe expression tree)
    ↓
Expression.ToHcl()
    ↓
HCL String
```

**Benefits**:

- Compile-time type safety
- Polymorphic resolution (no runtime inspection)
- Clear distinction: arguments (settable) vs attributes (read-only)
- Reference semantics built-in
- Expression-based (like AWS CDK)

---

## Migration Impact

Since this is **pre-release**, there are no external users to migrate. Internal changes only:

1. **Generated Provider Code**: Will be completely regenerated
2. **Tests**: Old tests will be deleted, new tests created
3. **Playground Examples**: Will be updated to use new API
4. **Documentation**: Will reflect new property system

---

## Timeline

**Phase 1 - Cleanup**:

- Document what's being removed (this file) ✅
- Delete old files
- Update dependent code to compile (may be non-functional)

**Phase 2-6**: Implement new system per implementation plan

---

## Notes

- This removal is **permanent** - no backward compatibility needed
- Old test files will be deleted, not migrated
- Focus on clean implementation of new design, not preserving old patterns
- Code generator will handle most of the migration work
