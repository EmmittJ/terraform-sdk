using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for access_rule in .
/// Nesting mode: set
/// </summary>
public class AzurermHpcCacheAccessPolicyAccessRuleBlock
{
    /// <summary>
    /// The access attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Access is required")]
    [TerraformPropertyName("access")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Access { get; set; }

    /// <summary>
    /// The anonymous_gid attribute.
    /// </summary>
    [TerraformPropertyName("anonymous_gid")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AnonymousGid { get; set; }

    /// <summary>
    /// The anonymous_uid attribute.
    /// </summary>
    [TerraformPropertyName("anonymous_uid")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AnonymousUid { get; set; }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [TerraformPropertyName("filter")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Filter { get; set; }

    /// <summary>
    /// The root_squash_enabled attribute.
    /// </summary>
    [TerraformPropertyName("root_squash_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RootSquashEnabled { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformPropertyName("scope")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Scope { get; set; }

    /// <summary>
    /// The submount_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("submount_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SubmountAccessEnabled { get; set; }

    /// <summary>
    /// The suid_enabled attribute.
    /// </summary>
    [TerraformPropertyName("suid_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SuidEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHpcCacheAccessPolicyTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_hpc_cache_access_policy resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermHpcCacheAccessPolicy : TerraformResource
{
    public AzurermHpcCacheAccessPolicy(string name) : base("azurerm_hpc_cache_access_policy", name)
    {
    }

    /// <summary>
    /// The hpc_cache_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HpcCacheId is required")]
    [TerraformPropertyName("hpc_cache_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HpcCacheId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for access_rule.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AccessRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 AccessRule block(s) allowed")]
    [TerraformPropertyName("access_rule")]
    public TerraformSet<TerraformBlock<AzurermHpcCacheAccessPolicyAccessRuleBlock>>? AccessRule { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermHpcCacheAccessPolicyTimeoutsBlock>? Timeouts { get; set; }

}
