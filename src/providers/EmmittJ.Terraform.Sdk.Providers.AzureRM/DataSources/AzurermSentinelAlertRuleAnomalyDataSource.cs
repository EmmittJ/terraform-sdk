using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_sentinel_alert_rule_anomaly.
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDataSource : TerraformDataSource
{
    public AzurermSentinelAlertRuleAnomalyDataSource(string name) : base("azurerm_sentinel_alert_rule_anomaly", name)
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
    public TerraformBlock<AzurermSentinelAlertRuleAnomalyDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The anomaly_settings_version attribute.
    /// </summary>
    [TerraformPropertyName("anomaly_settings_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AnomalySettingsVersion => new TerraformReference(this, "anomaly_settings_version");

    /// <summary>
    /// The anomaly_version attribute.
    /// </summary>
    [TerraformPropertyName("anomaly_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AnomalyVersion => new TerraformReference(this, "anomaly_version");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Enabled => new TerraformReference(this, "enabled");

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [TerraformPropertyName("frequency")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Frequency => new TerraformReference(this, "frequency");

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Mode => new TerraformReference(this, "mode");

    /// <summary>
    /// The multi_select_observation attribute.
    /// </summary>
    [TerraformPropertyName("multi_select_observation")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MultiSelectObservation => new TerraformReference(this, "multi_select_observation");

    /// <summary>
    /// The prioritized_exclude_observation attribute.
    /// </summary>
    [TerraformPropertyName("prioritized_exclude_observation")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PrioritizedExcludeObservation => new TerraformReference(this, "prioritized_exclude_observation");

    /// <summary>
    /// The required_data_connector attribute.
    /// </summary>
    [TerraformPropertyName("required_data_connector")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RequiredDataConnector => new TerraformReference(this, "required_data_connector");

    /// <summary>
    /// The settings_definition_id attribute.
    /// </summary>
    [TerraformPropertyName("settings_definition_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SettingsDefinitionId => new TerraformReference(this, "settings_definition_id");

    /// <summary>
    /// The single_select_observation attribute.
    /// </summary>
    [TerraformPropertyName("single_select_observation")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SingleSelectObservation => new TerraformReference(this, "single_select_observation");

    /// <summary>
    /// The tactics attribute.
    /// </summary>
    [TerraformPropertyName("tactics")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Tactics => new TerraformReference(this, "tactics");

    /// <summary>
    /// The techniques attribute.
    /// </summary>
    [TerraformPropertyName("techniques")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Techniques => new TerraformReference(this, "techniques");

    /// <summary>
    /// The threshold_observation attribute.
    /// </summary>
    [TerraformPropertyName("threshold_observation")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ThresholdObservation => new TerraformReference(this, "threshold_observation");

}
