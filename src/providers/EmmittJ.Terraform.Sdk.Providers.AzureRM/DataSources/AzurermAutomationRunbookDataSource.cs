using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationRunbookDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_automation_runbook.
/// </summary>
public class AzurermAutomationRunbookDataSource : TerraformDataSource
{
    public AzurermAutomationRunbookDataSource(string name) : base("azurerm_automation_runbook", name)
    {
    }

    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountName is required")]
    [TerraformPropertyName("automation_account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AutomationAccountName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAutomationRunbookDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The content attribute.
    /// </summary>
    [TerraformPropertyName("content")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Content => new TerraformReference(this, "content");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The log_activity_trace_level attribute.
    /// </summary>
    [TerraformPropertyName("log_activity_trace_level")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> LogActivityTraceLevel => new TerraformReference(this, "log_activity_trace_level");

    /// <summary>
    /// The log_progress attribute.
    /// </summary>
    [TerraformPropertyName("log_progress")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> LogProgress => new TerraformReference(this, "log_progress");

    /// <summary>
    /// The log_verbose attribute.
    /// </summary>
    [TerraformPropertyName("log_verbose")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> LogVerbose => new TerraformReference(this, "log_verbose");

    /// <summary>
    /// The runbook_type attribute.
    /// </summary>
    [TerraformPropertyName("runbook_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RunbookType => new TerraformReference(this, "runbook_type");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
