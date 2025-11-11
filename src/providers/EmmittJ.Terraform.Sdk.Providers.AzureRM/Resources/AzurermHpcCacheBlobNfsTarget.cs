using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermHpcCacheBlobNfsTargetTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_hpc_cache_blob_nfs_target resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermHpcCacheBlobNfsTarget : TerraformResource
{
    public AzurermHpcCacheBlobNfsTarget(string name) : base("azurerm_hpc_cache_blob_nfs_target", name)
    {
    }

    /// <summary>
    /// The access_policy_name attribute.
    /// </summary>
    [TerraformProperty("access_policy_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccessPolicyName { get; set; }

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
    /// The namespace_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespacePath is required")]
    [TerraformProperty("namespace_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NamespacePath { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The storage_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerId is required")]
    [TerraformProperty("storage_container_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageContainerId { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermHpcCacheBlobNfsTargetTimeoutsBlock>? Timeouts { get; set; }

}
