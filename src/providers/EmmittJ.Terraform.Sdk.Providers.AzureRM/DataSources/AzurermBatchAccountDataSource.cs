using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermBatchAccountDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_batch_account.
/// </summary>
public partial class AzurermBatchAccountDataSource : TerraformDataSource
{
    public AzurermBatchAccountDataSource(string name) : base("azurerm_batch_account", name)
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
    public AzurermBatchAccountDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The account_endpoint attribute.
    /// </summary>
    [TerraformProperty("account_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AccountEndpoint { get; }

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    [TerraformProperty("encryption")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Encryption { get; }

    /// <summary>
    /// The key_vault_reference attribute.
    /// </summary>
    [TerraformProperty("key_vault_reference")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> KeyVaultReference { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The pool_allocation_mode attribute.
    /// </summary>
    [TerraformProperty("pool_allocation_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PoolAllocationMode { get; }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformProperty("primary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryAccessKey { get; }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformProperty("secondary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryAccessKey { get; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformProperty("storage_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StorageAccountId { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

}
