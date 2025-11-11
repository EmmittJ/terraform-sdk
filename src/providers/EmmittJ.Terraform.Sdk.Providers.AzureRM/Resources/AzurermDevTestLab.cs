using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDevTestLabTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_dev_test_lab resource.
/// </summary>
public partial class AzurermDevTestLab : TerraformResource
{
    public AzurermDevTestLab(string name) : base("azurerm_dev_test_lab", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermDevTestLabTimeoutsBlock>? Timeouts { get; set; }

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
    /// The premium_data_disk_storage_account_id attribute.
    /// </summary>
    [TerraformProperty("premium_data_disk_storage_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PremiumDataDiskStorageAccountId { get; }

    /// <summary>
    /// The unique_identifier attribute.
    /// </summary>
    [TerraformProperty("unique_identifier")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UniqueIdentifier { get; }

}
