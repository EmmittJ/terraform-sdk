using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLogAnalyticsStorageInsightsTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_log_analytics_storage_insights resource.
/// </summary>
public partial class AzurermLogAnalyticsStorageInsights : TerraformResource
{
    public AzurermLogAnalyticsStorageInsights(string name) : base("azurerm_log_analytics_storage_insights", name)
    {
    }

    /// <summary>
    /// The blob_container_names attribute.
    /// </summary>
    [TerraformProperty("blob_container_names")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? BlobContainerNames { get; set; }

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
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformProperty("storage_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountId { get; set; }

    /// <summary>
    /// The storage_account_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountKey is required")]
    [TerraformProperty("storage_account_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountKey { get; set; }

    /// <summary>
    /// The table_names attribute.
    /// </summary>
    [TerraformProperty("table_names")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? TableNames { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformProperty("workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermLogAnalyticsStorageInsightsTimeoutsBlock Timeouts { get; set; } = new();

}
