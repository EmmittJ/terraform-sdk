using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleTemplateDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_sentinel_alert_rule_template.
/// </summary>
public class AzurermSentinelAlertRuleTemplateDataSource : TerraformDataSource
{
    public AzurermSentinelAlertRuleTemplateDataSource(string name) : base("azurerm_sentinel_alert_rule_template", name)
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DisplayName { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformPropertyName("log_analytics_workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSentinelAlertRuleTemplateDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The nrt_template attribute.
    /// </summary>
    [TerraformPropertyName("nrt_template")]
    // Output-only attribute - read-only reference
    public TerraformList<object> NrtTemplate => new TerraformReference(this, "nrt_template");

    /// <summary>
    /// The scheduled_template attribute.
    /// </summary>
    [TerraformPropertyName("scheduled_template")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ScheduledTemplate => new TerraformReference(this, "scheduled_template");

    /// <summary>
    /// The security_incident_template attribute.
    /// </summary>
    [TerraformPropertyName("security_incident_template")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SecurityIncidentTemplate => new TerraformReference(this, "security_incident_template");

}
