using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSentinelAlertRuleTemplateDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_sentinel_alert_rule_template.
/// </summary>
public partial class AzurermSentinelAlertRuleTemplateDataSource : TerraformDataSource
{
    public AzurermSentinelAlertRuleTemplateDataSource(string name) : base("azurerm_sentinel_alert_rule_template", name)
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformProperty("log_analytics_workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSentinelAlertRuleTemplateDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The nrt_template attribute.
    /// </summary>
    [TerraformProperty("nrt_template")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> NrtTemplate { get; }

    /// <summary>
    /// The scheduled_template attribute.
    /// </summary>
    [TerraformProperty("scheduled_template")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ScheduledTemplate { get; }

    /// <summary>
    /// The security_incident_template attribute.
    /// </summary>
    [TerraformProperty("security_incident_template")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SecurityIncidentTemplate { get; }

}
