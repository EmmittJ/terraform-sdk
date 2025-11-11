using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageContainerDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_storage_container.
/// </summary>
public partial class AzurermStorageContainerDataSource : TerraformDataSource
{
    public AzurermStorageContainerDataSource(string name) : base("azurerm_storage_container", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformProperty("metadata")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Metadata { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformProperty("storage_account_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageAccountId { get; set; }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [TerraformProperty("storage_account_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageAccountName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermStorageContainerDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The container_access_type attribute.
    /// </summary>
    [TerraformProperty("container_access_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ContainerAccessType { get; }

    /// <summary>
    /// The default_encryption_scope attribute.
    /// </summary>
    [TerraformProperty("default_encryption_scope")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DefaultEncryptionScope { get; }

    /// <summary>
    /// The encryption_scope_override_enabled attribute.
    /// </summary>
    [TerraformProperty("encryption_scope_override_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EncryptionScopeOverrideEnabled { get; }

    /// <summary>
    /// The has_immutability_policy attribute.
    /// </summary>
    [TerraformProperty("has_immutability_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> HasImmutabilityPolicy { get; }

    /// <summary>
    /// The has_legal_hold attribute.
    /// </summary>
    [TerraformProperty("has_legal_hold")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> HasLegalHold { get; }

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [TerraformProperty("resource_manager_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceManagerId { get; }

}
