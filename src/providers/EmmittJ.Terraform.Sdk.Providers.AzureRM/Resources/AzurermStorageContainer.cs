using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageContainerTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_storage_container resource.
/// </summary>
public partial class AzurermStorageContainer : TerraformResource
{
    public AzurermStorageContainer(string name) : base("azurerm_storage_container", name)
    {
    }

    /// <summary>
    /// The container_access_type attribute.
    /// </summary>
    [TerraformProperty("container_access_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContainerAccessType { get; set; }

    /// <summary>
    /// The default_encryption_scope attribute.
    /// </summary>
    [TerraformProperty("default_encryption_scope")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DefaultEncryptionScope { get; set; }

    /// <summary>
    /// The encryption_scope_override_enabled attribute.
    /// </summary>
    [TerraformProperty("encryption_scope_override_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EncryptionScopeOverrideEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformProperty("metadata")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Metadata { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformProperty("storage_account_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageAccountId { get; set; }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("storage_account_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageAccountName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermStorageContainerTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The has_immutability_policy attribute.
    /// </summary>
    [TerraformProperty("has_immutability_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> HasImmutabilityPolicy { get; }

    /// <summary>
    /// The has_legal_hold attribute.
    /// </summary>
    [TerraformProperty("has_legal_hold")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> HasLegalHold { get; }

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [TerraformProperty("resource_manager_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceManagerId { get; }

}
