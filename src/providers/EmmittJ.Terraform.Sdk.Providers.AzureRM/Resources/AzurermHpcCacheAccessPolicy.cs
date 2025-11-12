using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for access_rule in .
/// Nesting mode: set
/// </summary>
public partial class AzurermHpcCacheAccessPolicyAccessRuleBlock() : TerraformBlock("access_rule")
{
    /// <summary>
    /// The access attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Access is required")]
    [TerraformProperty("access")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Access { get; set; }

    /// <summary>
    /// The anonymous_gid attribute.
    /// </summary>
    [TerraformProperty("anonymous_gid")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AnonymousGid { get; set; }

    /// <summary>
    /// The anonymous_uid attribute.
    /// </summary>
    [TerraformProperty("anonymous_uid")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AnonymousUid { get; set; }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [TerraformProperty("filter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Filter { get; set; }

    /// <summary>
    /// The root_squash_enabled attribute.
    /// </summary>
    [TerraformProperty("root_squash_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RootSquashEnabled { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformProperty("scope")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Scope { get; set; }

    /// <summary>
    /// The submount_access_enabled attribute.
    /// </summary>
    [TerraformProperty("submount_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SubmountAccessEnabled { get; set; }

    /// <summary>
    /// The suid_enabled attribute.
    /// </summary>
    [TerraformProperty("suid_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SuidEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermHpcCacheAccessPolicyTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_hpc_cache_access_policy resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermHpcCacheAccessPolicy : TerraformResource
{
    public AzurermHpcCacheAccessPolicy(string name) : base("azurerm_hpc_cache_access_policy", name)
    {
    }

    /// <summary>
    /// The hpc_cache_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HpcCacheId is required")]
    [TerraformProperty("hpc_cache_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HpcCacheId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for access_rule.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AccessRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 AccessRule block(s) allowed")]
    [TerraformProperty("access_rule")]
    public required TerraformSet<AzurermHpcCacheAccessPolicyAccessRuleBlock> AccessRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermHpcCacheAccessPolicyTimeoutsBlock Timeouts { get; set; } = new();

}
