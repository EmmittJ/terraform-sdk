using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for namespace_junction in .
/// Nesting mode: set
/// </summary>
public partial class AzurermHpcCacheNfsTargetNamespaceJunctionBlock : TerraformBlockBase
{
    /// <summary>
    /// The access_policy_name attribute.
    /// </summary>
    [TerraformProperty("access_policy_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccessPolicyName { get; set; }

    /// <summary>
    /// The namespace_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespacePath is required")]
    [TerraformProperty("namespace_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NamespacePath { get; set; }

    /// <summary>
    /// The nfs_export attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NfsExport is required")]
    [TerraformProperty("nfs_export")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NfsExport { get; set; }

    /// <summary>
    /// The target_path attribute.
    /// </summary>
    [TerraformProperty("target_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetPath { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermHpcCacheNfsTargetTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_hpc_cache_nfs_target resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermHpcCacheNfsTarget : TerraformResource
{
    public AzurermHpcCacheNfsTarget(string name) : base("azurerm_hpc_cache_nfs_target", name)
    {
    }

    /// <summary>
    /// The cache_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CacheName is required")]
    [TerraformProperty("cache_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CacheName { get; set; }

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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The target_host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetHostName is required")]
    [TerraformProperty("target_host_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetHostName { get; set; }

    /// <summary>
    /// The usage_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UsageModel is required")]
    [TerraformProperty("usage_model")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UsageModel { get; set; }

    /// <summary>
    /// The verification_timer_in_seconds attribute.
    /// </summary>
    [TerraformProperty("verification_timer_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? VerificationTimerInSeconds { get; set; }

    /// <summary>
    /// The write_back_timer_in_seconds attribute.
    /// </summary>
    [TerraformProperty("write_back_timer_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? WriteBackTimerInSeconds { get; set; }

    /// <summary>
    /// Block for namespace_junction.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceJunction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NamespaceJunction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 NamespaceJunction block(s) allowed")]
    [TerraformProperty("namespace_junction")]
    public partial TerraformSet<TerraformBlock<AzurermHpcCacheNfsTargetNamespaceJunctionBlock>>? NamespaceJunction { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermHpcCacheNfsTargetTimeoutsBlock>? Timeouts { get; set; }

}
