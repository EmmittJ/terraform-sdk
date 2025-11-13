namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Marker interface for blocks that support the 'count' meta-argument.
/// Source generator will add the Count property to implementing types.
/// </summary>
/// <remarks>
/// The count meta-argument accepts a whole number, and creates that many instances of the resource or module.
/// Each instance has a distinct infrastructure object associated with it, and each is separately created,
/// updated, or destroyed when the configuration is applied.
/// </remarks>
public interface ITerraformHasCount
{
    /// <summary>
    /// Gets or sets the count meta-argument value.
    /// </summary>
    TerraformValue<int>? Count { get; set; }
}

/// <summary>
/// Marker interface for blocks that support the 'for_each' meta-argument.
/// Source generator will add the ForEach property to implementing types.
/// </summary>
/// <remarks>
/// The for_each meta-argument accepts a map or a set of strings, and creates an instance for each item in that map or set.
/// Each instance has a distinct infrastructure object associated with it, and each is separately created,
/// updated, or destroyed when the configuration is applied.
/// Note: A block cannot use both count and for_each.
/// </remarks>
public interface ITerraformHasForEach
{
    /// <summary>
    /// Gets or sets the for_each meta-argument value.
    /// </summary>
    TerraformValue<object>? ForEach { get; set; }
}

/// <summary>
/// Marker interface for blocks that support the 'depends_on' meta-argument.
/// Source generator will add the DependsOn property to implementing types.
/// </summary>
/// <remarks>
/// The depends_on meta-argument accepts a list of references to other blocks.
/// Use this meta-argument when a block relies on some other block's behavior but doesn't access
/// any of that block's data in its arguments.
/// </remarks>
public interface ITerraformHasDependsOn
{
    /// <summary>
    /// Gets the list of dependencies for this block.
    /// </summary>
    List<string> DependsOn { get; }
}

/// <summary>
/// Marker interface for blocks that support the 'provider' meta-argument.
/// Source generator will add the Provider property to implementing types.
/// </summary>
/// <remarks>
/// The provider meta-argument specifies which provider configuration to use for a resource or data source,
/// overriding Terraform's default behavior of selecting one based on the resource type name.
/// </remarks>
public interface ITerraformHasProvider
{
    /// <summary>
    /// Gets or sets the provider meta-argument value.
    /// </summary>
    string? Provider { get; set; }
}

/// <summary>
/// Marker interface for blocks that support the 'lifecycle' meta-argument.
/// Source generator will add the Lifecycle property to implementing types.
/// </summary>
/// <remarks>
/// The lifecycle meta-argument allows you to customize the lifecycle behavior of the resource.
/// It supports: create_before_destroy, prevent_destroy, ignore_changes, and replace_triggered_by.
/// </remarks>
public interface ITerraformHasLifecycle
{
    /// <summary>
    /// Gets or sets the lifecycle configuration for this block.
    /// </summary>
    TerraformLifecycleConfig? Lifecycle { get; set; }
}

/// <summary>
/// Marker interface for blocks that support the 'providers' meta-argument.
/// Source generator will add the Providers property to implementing types.
/// </summary>
/// <remarks>
/// The providers meta-argument is used in module blocks to pass provider configurations
/// from the parent module to the child module. It allows you to specify which provider
/// configuration the child module should use for each provider it requires.
/// Maps child provider configuration names to parent provider configuration references.
/// </remarks>
public interface ITerraformHasProviders
{
    /// <summary>
    /// Gets the provider mappings for this module.
    /// Key: child module's provider configuration name
    /// Value: reference to parent module's provider configuration
    /// </summary>
    Dictionary<string, string> Providers { get; }
}
