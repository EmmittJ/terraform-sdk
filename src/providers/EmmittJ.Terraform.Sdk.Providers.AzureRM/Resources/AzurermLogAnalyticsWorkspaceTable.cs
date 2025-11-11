using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLogAnalyticsWorkspaceTableTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_log_analytics_workspace_table resource.
/// </summary>
public partial class AzurermLogAnalyticsWorkspaceTable : TerraformResource
{
    public AzurermLogAnalyticsWorkspaceTable(string name) : base("azurerm_log_analytics_workspace_table", name)
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
    /// The plan attribute.
    /// </summary>
    [TerraformProperty("plan")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Plan { get; set; }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [TerraformProperty("retention_in_days")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RetentionInDays { get; set; }

    /// <summary>
    /// The total_retention_in_days attribute.
    /// </summary>
    [TerraformProperty("total_retention_in_days")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? TotalRetentionInDays { get; set; }

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
    public TerraformBlock<AzurermLogAnalyticsWorkspaceTableTimeoutsBlock>? Timeouts { get; set; }

}
