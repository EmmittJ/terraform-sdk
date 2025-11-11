using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLogAnalyticsLinkedStorageAccountTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_log_analytics_linked_storage_account resource.
/// </summary>
public partial class AzurermLogAnalyticsLinkedStorageAccount : TerraformResource
{
    public AzurermLogAnalyticsLinkedStorageAccount(string name) : base("azurerm_log_analytics_linked_storage_account", name)
    {
    }

    /// <summary>
    /// The data_source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceType is required")]
    [TerraformProperty("data_source_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DataSourceType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The storage_account_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountIds is required")]
    [TerraformProperty("storage_account_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> StorageAccountIds { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformProperty("workspace_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// The workspace_resource_id attribute.
    /// </summary>
    [TerraformProperty("workspace_resource_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> WorkspaceResourceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermLogAnalyticsLinkedStorageAccountTimeoutsBlock>? Timeouts { get; set; }

}
