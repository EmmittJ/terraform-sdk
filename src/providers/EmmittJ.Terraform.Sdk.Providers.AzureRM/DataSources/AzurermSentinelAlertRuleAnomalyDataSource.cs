using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    public TerraformBlock<AzurermSentinelAlertRuleAnomalyDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

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
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Enabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enabled");

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [TerraformPropertyName("frequency")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Frequency => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "frequency");

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Mode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mode");

    /// <summary>
    /// The multi_select_observation attribute.
    /// </summary>
    [TerraformPropertyName("multi_select_observation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MultiSelectObservation => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "multi_select_observation");

    /// <summary>
    /// The prioritized_exclude_observation attribute.
    /// </summary>
    [TerraformPropertyName("prioritized_exclude_observation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PrioritizedExcludeObservation => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "prioritized_exclude_observation");

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
    /// The single_select_observation attribute.
    /// </summary>
    [TerraformPropertyName("single_select_observation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SingleSelectObservation => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "single_select_observation");

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

    /// <summary>
    /// The threshold_observation attribute.
    /// </summary>
    [TerraformPropertyName("threshold_observation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ThresholdObservation => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "threshold_observation");

}
