using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for multi_select_observation in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSentinelAlertRuleAnomalyDuplicateMultiSelectObservationBlock : TerraformBlockBase
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }


    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? Values { get; set; }

}

/// <summary>
/// Block type for prioritized_exclude_observation in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSentinelAlertRuleAnomalyDuplicatePrioritizedExcludeObservationBlock : TerraformBlockBase
{

    /// <summary>
    /// The exclude attribute.
    /// </summary>
    [TerraformProperty("exclude")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Exclude { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The prioritize attribute.
    /// </summary>
    [TerraformProperty("prioritize")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Prioritize { get; set; }

}

/// <summary>
/// Block type for single_select_observation in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSentinelAlertRuleAnomalyDuplicateSingleSelectObservationBlock : TerraformBlockBase
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }


    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for threshold_observation in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSentinelAlertRuleAnomalyDuplicateThresholdObservationBlock : TerraformBlockBase
{



    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSentinelAlertRuleAnomalyDuplicateTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_sentinel_alert_rule_anomaly_duplicate resource.
/// </summary>
public partial class AzurermSentinelAlertRuleAnomalyDuplicate : TerraformResource
{
    public AzurermSentinelAlertRuleAnomalyDuplicate(string name) : base("azurerm_sentinel_alert_rule_anomaly_duplicate", name)
    {
    }

    /// <summary>
    /// The built_in_rule_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BuiltInRuleId is required")]
    [TerraformProperty("built_in_rule_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BuiltInRuleId { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

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
    /// Block for multi_select_observation.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("multi_select_observation")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleAnomalyDuplicateMultiSelectObservationBlock>>? MultiSelectObservation { get; set; }

    /// <summary>
    /// Block for prioritized_exclude_observation.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("prioritized_exclude_observation")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleAnomalyDuplicatePrioritizedExcludeObservationBlock>>? PrioritizedExcludeObservation { get; set; }

    /// <summary>
    /// Block for single_select_observation.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("single_select_observation")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleAnomalyDuplicateSingleSelectObservationBlock>>? SingleSelectObservation { get; set; }

    /// <summary>
    /// Block for threshold_observation.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("threshold_observation")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleAnomalyDuplicateThresholdObservationBlock>>? ThresholdObservation { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermSentinelAlertRuleAnomalyDuplicateTimeoutsBlock>? Timeouts { get; set; }

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
    /// The is_default_settings attribute.
    /// </summary>
    [TerraformProperty("is_default_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> IsDefaultSettings { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

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

}
