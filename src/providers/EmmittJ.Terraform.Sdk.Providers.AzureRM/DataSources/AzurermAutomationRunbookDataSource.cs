using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationRunbookDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> AutomationAccountName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAutomationRunbookDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The content attribute.
    /// </summary>
    [TerraformPropertyName("content")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Content => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The log_activity_trace_level attribute.
    /// </summary>
    [TerraformPropertyName("log_activity_trace_level")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> LogActivityTraceLevel => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "log_activity_trace_level");

    /// <summary>
    /// The log_progress attribute.
    /// </summary>
    [TerraformPropertyName("log_progress")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> LogProgress => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "log_progress");

    /// <summary>
    /// The log_verbose attribute.
    /// </summary>
    [TerraformPropertyName("log_verbose")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> LogVerbose => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "log_verbose");

    /// <summary>
    /// The runbook_type attribute.
    /// </summary>
    [TerraformPropertyName("runbook_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RunbookType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "runbook_type");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

}
