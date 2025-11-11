using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLogAnalyticsWorkspaceDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_log_analytics_workspace.
/// </summary>
public partial class AzurermLogAnalyticsWorkspaceDataSource : TerraformDataSource
{
    public AzurermLogAnalyticsWorkspaceDataSource(string name) : base("azurerm_log_analytics_workspace", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermLogAnalyticsWorkspaceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The daily_quota_gb attribute.
    /// </summary>
    [TerraformProperty("daily_quota_gb")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DailyQuotaGb { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The primary_shared_key attribute.
    /// </summary>
    [TerraformProperty("primary_shared_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimarySharedKey { get; }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [TerraformProperty("retention_in_days")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> RetentionInDays { get; }

    /// <summary>
    /// The secondary_shared_key attribute.
    /// </summary>
    [TerraformProperty("secondary_shared_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondarySharedKey { get; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Sku { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformProperty("workspace_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> WorkspaceId { get; }

}
