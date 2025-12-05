using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSentinelAlertRuleAnomalyBuiltIn.
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleAnomalyBuiltInTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_sentinel_alert_rule_anomaly_built_in Terraform resource.
/// Manages a azurerm_sentinel_alert_rule_anomaly_built_in resource.
/// </summary>
public partial class AzurermSentinelAlertRuleAnomalyBuiltIn(string name) : TerraformResource("azurerm_sentinel_alert_rule_anomaly_built_in", name)
{
    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name") ?? CreateReference("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
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
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => GetRequiredArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The anomaly_settings_version attribute.
    /// </summary>
    public TerraformValue<double> AnomalySettingsVersion
        => CreateReference("anomaly_settings_version");

    /// <summary>
    /// The anomaly_version attribute.
    /// </summary>
    public TerraformValue<string> AnomalyVersion
        => CreateReference("anomaly_version");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformValue<string> Frequency
        => CreateReference("frequency");

    /// <summary>
    /// The multi_select_observation attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MultiSelectObservation
        => CreateReference("multi_select_observation");

    /// <summary>
    /// The prioritized_exclude_observation attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrioritizedExcludeObservation
        => CreateReference("prioritized_exclude_observation");

    /// <summary>
    /// The required_data_connector attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RequiredDataConnector
        => CreateReference("required_data_connector");

    /// <summary>
    /// The settings_definition_id attribute.
    /// </summary>
    public TerraformValue<string> SettingsDefinitionId
        => CreateReference("settings_definition_id");

    /// <summary>
    /// The single_select_observation attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SingleSelectObservation
        => CreateReference("single_select_observation");

    /// <summary>
    /// The tactics attribute.
    /// </summary>
    public TerraformList<string> Tactics
        => CreateReference("tactics");

    /// <summary>
    /// The techniques attribute.
    /// </summary>
    public TerraformList<string> Techniques
        => CreateReference("techniques");

    /// <summary>
    /// The threshold_observation attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ThresholdObservation
        => CreateReference("threshold_observation");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSentinelAlertRuleAnomalyBuiltInTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSentinelAlertRuleAnomalyBuiltInTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
