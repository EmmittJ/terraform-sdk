using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageContainerImmutabilityPolicyTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_storage_container_immutability_policy resource.
/// </summary>
public partial class AzurermStorageContainerImmutabilityPolicy : TerraformResource
{
    public AzurermStorageContainerImmutabilityPolicy(string name) : base("azurerm_storage_container_immutability_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The immutability_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImmutabilityPeriodInDays is required")]
    [TerraformProperty("immutability_period_in_days")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> ImmutabilityPeriodInDays { get; set; }

    /// <summary>
    /// The locked attribute.
    /// </summary>
    [TerraformProperty("locked")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Locked { get; set; }

    /// <summary>
    /// The protected_append_writes_all_enabled attribute.
    /// </summary>
    [TerraformProperty("protected_append_writes_all_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ProtectedAppendWritesAllEnabled { get; set; }

    /// <summary>
    /// The protected_append_writes_enabled attribute.
    /// </summary>
    [TerraformProperty("protected_append_writes_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ProtectedAppendWritesEnabled { get; set; }

    /// <summary>
    /// The storage_container_resource_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerResourceManagerId is required")]
    [TerraformProperty("storage_container_resource_manager_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageContainerResourceManagerId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermStorageContainerImmutabilityPolicyTimeoutsBlock>? Timeouts { get; set; }

}
