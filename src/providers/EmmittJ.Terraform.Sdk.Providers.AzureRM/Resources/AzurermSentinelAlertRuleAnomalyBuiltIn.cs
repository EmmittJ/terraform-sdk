using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSentinelAlertRuleAnomalyBuiltInTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_sentinel_alert_rule_anomaly_built_in resource.
/// </summary>
public partial class AzurermSentinelAlertRuleAnomalyBuiltIn : TerraformResource
{
    public AzurermSentinelAlertRuleAnomalyBuiltIn(string name) : base("azurerm_sentinel_alert_rule_anomaly_built_in", name)
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformProperty("log_analytics_workspace_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformProperty("mode")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Mode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermSentinelAlertRuleAnomalyBuiltInTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The anomaly_settings_version attribute.
    /// </summary>
    [TerraformProperty("anomaly_settings_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> AnomalySettingsVersion { get; }

    /// <summary>
    /// The anomaly_version attribute.
    /// </summary>
    [TerraformProperty("anomaly_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AnomalyVersion { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [TerraformProperty("frequency")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Frequency { get; }

    /// <summary>
    /// The multi_select_observation attribute.
    /// </summary>
    [TerraformProperty("multi_select_observation")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MultiSelectObservation { get; }

    /// <summary>
    /// The prioritized_exclude_observation attribute.
    /// </summary>
    [TerraformProperty("prioritized_exclude_observation")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PrioritizedExcludeObservation { get; }

    /// <summary>
    /// The required_data_connector attribute.
    /// </summary>
    [TerraformProperty("required_data_connector")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RequiredDataConnector { get; }

    /// <summary>
    /// The settings_definition_id attribute.
    /// </summary>
    [TerraformProperty("settings_definition_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SettingsDefinitionId { get; }

    /// <summary>
    /// The single_select_observation attribute.
    /// </summary>
    [TerraformProperty("single_select_observation")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SingleSelectObservation { get; }

    /// <summary>
    /// The tactics attribute.
    /// </summary>
    [TerraformProperty("tactics")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Tactics { get; }

    /// <summary>
    /// The techniques attribute.
    /// </summary>
    [TerraformProperty("techniques")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Techniques { get; }

    /// <summary>
    /// The threshold_observation attribute.
    /// </summary>
    [TerraformProperty("threshold_observation")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ThresholdObservation { get; }

}
