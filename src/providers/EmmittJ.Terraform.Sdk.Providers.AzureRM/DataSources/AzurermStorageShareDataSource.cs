using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for acl in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStorageShareDataSourceAclBlock : TerraformBlockBase
{


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageShareDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_storage_share.
/// </summary>
public partial class AzurermStorageShareDataSource : TerraformDataSource
{
    public AzurermStorageShareDataSource(string name) : base("azurerm_storage_share", name)
    {
    }

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
    [TerraformProperty("storage_account_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageAccountName { get; set; }

    /// <summary>
    /// Block for acl.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("acl")]
    public partial TerraformList<TerraformBlock<AzurermStorageShareDataSourceAclBlock>>? Acl { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermStorageShareDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The quota attribute.
    /// </summary>
    [TerraformProperty("quota")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Quota { get; }

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [TerraformProperty("resource_manager_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceManagerId { get; }

}
