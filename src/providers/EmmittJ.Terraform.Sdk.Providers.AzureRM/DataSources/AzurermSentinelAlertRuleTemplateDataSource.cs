using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleTemplateDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DisplayName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformPropertyName("log_analytics_workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSentinelAlertRuleTemplateDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The nrt_template attribute.
    /// </summary>
    [TerraformPropertyName("nrt_template")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NrtTemplate => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "nrt_template");

    /// <summary>
    /// The scheduled_template attribute.
    /// </summary>
    [TerraformPropertyName("scheduled_template")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ScheduledTemplate => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "scheduled_template");

    /// <summary>
    /// The security_incident_template attribute.
    /// </summary>
    [TerraformPropertyName("security_incident_template")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SecurityIncidentTemplate => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "security_incident_template");

}
