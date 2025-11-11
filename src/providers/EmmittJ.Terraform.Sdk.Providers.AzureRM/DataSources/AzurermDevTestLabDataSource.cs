using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDevTestLabDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_dev_test_lab.
/// </summary>
public partial class AzurermDevTestLabDataSource : TerraformDataSource
{
    public AzurermDevTestLabDataSource(string name) : base("azurerm_dev_test_lab", name)
    {
    }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermDevTestLabDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The artifacts_storage_account_id attribute.
    /// </summary>
    [TerraformProperty("artifacts_storage_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ArtifactsStorageAccountId { get; }

    /// <summary>
    /// The default_premium_storage_account_id attribute.
    /// </summary>
    [TerraformProperty("default_premium_storage_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultPremiumStorageAccountId { get; }

    /// <summary>
    /// The default_storage_account_id attribute.
    /// </summary>
    [TerraformProperty("default_storage_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultStorageAccountId { get; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KeyVaultId { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The premium_data_disk_storage_account_id attribute.
    /// </summary>
    [TerraformProperty("premium_data_disk_storage_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PremiumDataDiskStorageAccountId { get; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformProperty("storage_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StorageType { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The unique_identifier attribute.
    /// </summary>
    [TerraformProperty("unique_identifier")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UniqueIdentifier { get; }

}
