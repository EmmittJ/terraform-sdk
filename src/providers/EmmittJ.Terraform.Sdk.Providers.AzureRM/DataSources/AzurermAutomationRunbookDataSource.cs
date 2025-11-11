using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAutomationRunbookDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_automation_runbook.
/// </summary>
public partial class AzurermAutomationRunbookDataSource : TerraformDataSource
{
    public AzurermAutomationRunbookDataSource(string name) : base("azurerm_automation_runbook", name)
    {
    }

    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountName is required")]
    [TerraformProperty("automation_account_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AutomationAccountName { get; set; }

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
    public TerraformBlock<AzurermAutomationRunbookDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The content attribute.
    /// </summary>
    [TerraformProperty("content")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Content { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The log_activity_trace_level attribute.
    /// </summary>
    [TerraformProperty("log_activity_trace_level")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> LogActivityTraceLevel { get; }

    /// <summary>
    /// The log_progress attribute.
    /// </summary>
    [TerraformProperty("log_progress")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> LogProgress { get; }

    /// <summary>
    /// The log_verbose attribute.
    /// </summary>
    [TerraformProperty("log_verbose")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> LogVerbose { get; }

    /// <summary>
    /// The runbook_type attribute.
    /// </summary>
    [TerraformProperty("runbook_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RunbookType { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

}
