namespace EmmittJ.Terraform.Sdk.Constructs.MetaArguments;

/// <summary>
/// Marker interface for constructs that support the 'count' meta-argument.
/// Source generator will add the Count property to implementing types.
/// </summary>
/// <remarks>
/// The count meta-argument accepts a whole number, and creates that many instances of the resource or module.
/// Each instance has a distinct infrastructure object associated with it, and each is separately created,
/// updated, or destroyed when the configuration is applied.
/// </remarks>
public interface ITerraformHasCount
{
    // Property will be source-generated:
    // TerraformValue<int>? Count { get; set; }
}

/// <summary>
/// Marker interface for constructs that support the 'for_each' meta-argument.
/// Source generator will add the ForEach property to implementing types.
/// </summary>
/// <remarks>
/// The for_each meta-argument accepts a map or a set of strings, and creates an instance for each item in that map or set.
/// Each instance has a distinct infrastructure object associated with it, and each is separately created,
/// updated, or destroyed when the configuration is applied.
/// Note: A construct cannot use both count and for_each.
/// </remarks>
public interface ITerraformHasForEach
{
    // Property will be source-generated:
    // TerraformValue<object>? ForEach { get; set; }
}

/// <summary>
/// Marker interface for constructs that support the 'depends_on' meta-argument.
/// Source generator will add the DependsOn property to implementing types.
/// </summary>
/// <remarks>
/// The depends_on meta-argument accepts a list of references to other constructs.
/// Use this meta-argument when a construct relies on some other construct's behavior but doesn't access
/// any of that construct's data in its arguments.
/// </remarks>
public interface ITerraformHasDependsOn
{
    // Property will be source-generated:
    // List<string> DependsOn { get; }
}

/// <summary>
/// Marker interface for constructs that support the 'provider' meta-argument.
/// Source generator will add the Provider property to implementing types.
/// </summary>
/// <remarks>
/// The provider meta-argument specifies which provider configuration to use for a resource or data source,
/// overriding Terraform's default behavior of selecting one based on the resource type name.
/// </remarks>
public interface ITerraformHasProvider
{
    // Property will be source-generated:
    // string? Provider { get; set; }
}

/// <summary>
/// Marker interface for constructs that support the 'lifecycle' meta-argument.
/// Source generator will add the Lifecycle property to implementing types.
/// </summary>
/// <remarks>
/// The lifecycle meta-argument allows you to customize the lifecycle behavior of the resource.
/// It supports: create_before_destroy, prevent_destroy, ignore_changes, and replace_triggered_by.
/// </remarks>
public interface ITerraformHasLifecycle
{
    // Property will be source-generated:
    // TerraformLifecycleConfig? Lifecycle { get; set; }
}

/// <summary>
/// Marker interface for constructs that support 'dynamic' blocks.
/// Source generator will add the DynamicBlocks property to implementing types.
/// </summary>
/// <remarks>
/// Dynamic blocks allow you to construct repeatable nested blocks dynamically based on a complex value.
/// They are particularly useful when you need to generate multiple similar nested blocks programmatically.
/// </remarks>
public interface ITerraformHasDynamicBlocks
{
    // Property will be source-generated:
    // List<TerraformDynamicBlock> DynamicBlocks { get; }
}

/// <summary>
/// Combined interface for all provisionable construct meta-arguments.
/// Implemented by TerraformResource to get all meta-arguments.
/// </summary>
/// <remarks>
/// This interface is a convenience that combines all the individual meta-argument interfaces.
/// Resources support all of these meta-arguments, while data sources support only a subset.
/// </remarks>
public interface ITerraformProvisionableConstruct :
    ITerraformHasCount,
    ITerraformHasForEach,
    ITerraformHasDependsOn,
    ITerraformHasProvider,
    ITerraformHasLifecycle,
    ITerraformHasDynamicBlocks
{
}
