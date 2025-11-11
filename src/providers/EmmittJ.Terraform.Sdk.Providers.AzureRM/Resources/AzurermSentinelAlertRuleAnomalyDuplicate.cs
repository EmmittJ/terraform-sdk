using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for multi_select_observation in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicateMultiSelectObservationBlock
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }


    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Values { get; set; }

}

/// <summary>
/// Block type for prioritized_exclude_observation in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicatePrioritizedExcludeObservationBlock
{

    /// <summary>
    /// The exclude attribute.
    /// </summary>
    [TerraformPropertyName("exclude")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Exclude { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The prioritize attribute.
    /// </summary>
    [TerraformPropertyName("prioritize")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Prioritize { get; set; }

}

/// <summary>
/// Block type for single_select_observation in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicateSingleSelectObservationBlock
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }


    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for threshold_observation in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicateThresholdObservationBlock
{



    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicateTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_sentinel_alert_rule_anomaly_duplicate resource.
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicate : TerraformResource
{
    public AzurermSentinelAlertRuleAnomalyDuplicate(string name) : base("azurerm_sentinel_alert_rule_anomaly_duplicate", name)
    {
    }

    /// <summary>
    /// The built_in_rule_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BuiltInRuleId is required")]
    [TerraformPropertyName("built_in_rule_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BuiltInRuleId { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

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
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformPropertyName("mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Mode { get; set; }

    /// <summary>
    /// Block for multi_select_observation.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("multi_select_observation")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleAnomalyDuplicateMultiSelectObservationBlock>>? MultiSelectObservation { get; set; }

    /// <summary>
    /// Block for prioritized_exclude_observation.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("prioritized_exclude_observation")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleAnomalyDuplicatePrioritizedExcludeObservationBlock>>? PrioritizedExcludeObservation { get; set; }

    /// <summary>
    /// Block for single_select_observation.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("single_select_observation")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleAnomalyDuplicateSingleSelectObservationBlock>>? SingleSelectObservation { get; set; }

    /// <summary>
    /// Block for threshold_observation.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("threshold_observation")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleAnomalyDuplicateThresholdObservationBlock>>? ThresholdObservation { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSentinelAlertRuleAnomalyDuplicateTimeoutsBlock>? Timeouts { get; set; }

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
    /// The frequency attribute.
    /// </summary>
    [TerraformPropertyName("frequency")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Frequency => new TerraformReference(this, "frequency");

    /// <summary>
    /// The is_default_settings attribute.
    /// </summary>
    [TerraformPropertyName("is_default_settings")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IsDefaultSettings => new TerraformReference(this, "is_default_settings");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

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

}
