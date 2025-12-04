using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSentinelAlertRuleAnomalyDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_sentinel_alert_rule_anomaly Terraform data source.
/// Retrieves information about a azurerm_sentinel_alert_rule_anomaly.
/// </summary>
public partial class AzurermSentinelAlertRuleAnomalyDataSource(string name) : TerraformDataSource("azurerm_sentinel_alert_rule_anomaly", name)
{
    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name") ?? AsReference("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? AsReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The anomaly_settings_version attribute.
    /// </summary>
    public TerraformValue<double> AnomalySettingsVersion
        => AsReference("anomaly_settings_version");

    /// <summary>
    /// The anomaly_version attribute.
    /// </summary>
    public TerraformValue<string> AnomalyVersion
        => AsReference("anomaly_version");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
        => AsReference("enabled");

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformValue<string> Frequency
        => AsReference("frequency");

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string> Mode
        => AsReference("mode");

    /// <summary>
    /// The multi_select_observation attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MultiSelectObservation
        => AsReference("multi_select_observation");

    /// <summary>
    /// The prioritized_exclude_observation attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrioritizedExcludeObservation
        => AsReference("prioritized_exclude_observation");

    /// <summary>
    /// The required_data_connector attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RequiredDataConnector
        => AsReference("required_data_connector");

    /// <summary>
    /// The settings_definition_id attribute.
    /// </summary>
    public TerraformValue<string> SettingsDefinitionId
        => AsReference("settings_definition_id");

    /// <summary>
    /// The single_select_observation attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SingleSelectObservation
        => AsReference("single_select_observation");

    /// <summary>
    /// The tactics attribute.
    /// </summary>
    public TerraformList<string> Tactics
        => AsReference("tactics");

    /// <summary>
    /// The techniques attribute.
    /// </summary>
    public TerraformList<string> Techniques
        => AsReference("techniques");

    /// <summary>
    /// The threshold_observation attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ThresholdObservation
        => AsReference("threshold_observation");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSentinelAlertRuleAnomalyDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSentinelAlertRuleAnomalyDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
