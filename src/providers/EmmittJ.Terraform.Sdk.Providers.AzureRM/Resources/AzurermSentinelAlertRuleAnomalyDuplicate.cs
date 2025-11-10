using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for multi_select_observation in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicateMultiSelectObservationBlock : ITerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>("", "description");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The supported_values attribute.
    /// </summary>
    [TerraformPropertyName("supported_values")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SupportedValues => new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "supported_values");

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? Values { get; set; }

}

/// <summary>
/// Block type for prioritized_exclude_observation in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicatePrioritizedExcludeObservationBlock : ITerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>("", "description");

    /// <summary>
    /// The exclude attribute.
    /// </summary>
    [TerraformPropertyName("exclude")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Exclude { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The prioritize attribute.
    /// </summary>
    [TerraformPropertyName("prioritize")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Prioritize { get; set; }

}

/// <summary>
/// Block type for single_select_observation in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicateSingleSelectObservationBlock : ITerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>("", "description");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The supported_values attribute.
    /// </summary>
    [TerraformPropertyName("supported_values")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SupportedValues => new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "supported_values");

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Value { get; set; }

}

/// <summary>
/// Block type for threshold_observation in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicateThresholdObservationBlock : ITerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>("", "description");

    /// <summary>
    /// The max attribute.
    /// </summary>
    [TerraformPropertyName("max")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Max => new TerraformReferenceProperty<TerraformProperty<string>>("", "max");

    /// <summary>
    /// The min attribute.
    /// </summary>
    [TerraformPropertyName("min")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Min => new TerraformReferenceProperty<TerraformProperty<string>>("", "min");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicateTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> BuiltInRuleId { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

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
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformPropertyName("mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Mode { get; set; }

    /// <summary>
    /// Block for multi_select_observation.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("multi_select_observation")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleAnomalyDuplicateMultiSelectObservationBlock>>? MultiSelectObservation { get; set; } = new();

    /// <summary>
    /// Block for prioritized_exclude_observation.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("prioritized_exclude_observation")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleAnomalyDuplicatePrioritizedExcludeObservationBlock>>? PrioritizedExcludeObservation { get; set; } = new();

    /// <summary>
    /// Block for single_select_observation.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("single_select_observation")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleAnomalyDuplicateSingleSelectObservationBlock>>? SingleSelectObservation { get; set; } = new();

    /// <summary>
    /// Block for threshold_observation.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("threshold_observation")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleAnomalyDuplicateThresholdObservationBlock>>? ThresholdObservation { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSentinelAlertRuleAnomalyDuplicateTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The anomaly_settings_version attribute.
    /// </summary>
    [TerraformPropertyName("anomaly_settings_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AnomalySettingsVersion => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "anomaly_settings_version");

    /// <summary>
    /// The anomaly_version attribute.
    /// </summary>
    [TerraformPropertyName("anomaly_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AnomalyVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "anomaly_version");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [TerraformPropertyName("frequency")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Frequency => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "frequency");

    /// <summary>
    /// The is_default_settings attribute.
    /// </summary>
    [TerraformPropertyName("is_default_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IsDefaultSettings => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_default_settings");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The required_data_connector attribute.
    /// </summary>
    [TerraformPropertyName("required_data_connector")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RequiredDataConnector => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "required_data_connector");

    /// <summary>
    /// The settings_definition_id attribute.
    /// </summary>
    [TerraformPropertyName("settings_definition_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SettingsDefinitionId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "settings_definition_id");

    /// <summary>
    /// The tactics attribute.
    /// </summary>
    [TerraformPropertyName("tactics")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Tactics => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "tactics");

    /// <summary>
    /// The techniques attribute.
    /// </summary>
    [TerraformPropertyName("techniques")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Techniques => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "techniques");

}
