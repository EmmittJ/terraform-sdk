using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLogAnalyticsWorkspaceTableDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_log_analytics_workspace_table.
/// </summary>
public partial class AzurermLogAnalyticsWorkspaceTableDataSource : TerraformDataSource
{
    public AzurermLogAnalyticsWorkspaceTableDataSource(string name) : base("azurerm_log_analytics_workspace_table", name)
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
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformProperty("workspace_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermLogAnalyticsWorkspaceTableDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The plan attribute.
    /// </summary>
    [TerraformProperty("plan")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Plan { get; }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [TerraformProperty("retention_in_days")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> RetentionInDays { get; }

    /// <summary>
    /// The total_retention_in_days attribute.
    /// </summary>
    [TerraformProperty("total_retention_in_days")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> TotalRetentionInDays { get; }

}
