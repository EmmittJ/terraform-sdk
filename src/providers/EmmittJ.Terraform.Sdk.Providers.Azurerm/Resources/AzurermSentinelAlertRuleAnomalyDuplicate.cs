using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for multi_select_observation in AzurermSentinelAlertRuleAnomalyDuplicate.
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicateMultiSelectObservationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "multi_select_observation";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The supported_values attribute.
    /// </summary>
    public TerraformList<string> SupportedValues
        => AsReference("supported_values");

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for prioritized_exclude_observation in AzurermSentinelAlertRuleAnomalyDuplicate.
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicatePrioritizedExcludeObservationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "prioritized_exclude_observation";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The exclude attribute.
    /// </summary>
    public TerraformValue<string>? Exclude
    {
        get => GetArgument<TerraformValue<string>>("exclude");
        set => SetArgument("exclude", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The prioritize attribute.
    /// </summary>
    public TerraformValue<string>? Prioritize
    {
        get => GetArgument<TerraformValue<string>>("prioritize");
        set => SetArgument("prioritize", value);
    }

}


/// <summary>
/// Block type for single_select_observation in AzurermSentinelAlertRuleAnomalyDuplicate.
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicateSingleSelectObservationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "single_select_observation";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The supported_values attribute.
    /// </summary>
    public TerraformList<string> SupportedValues
        => AsReference("supported_values");

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for threshold_observation in AzurermSentinelAlertRuleAnomalyDuplicate.
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicateThresholdObservationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "threshold_observation";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<string> Max
        => AsReference("max");

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<string> Min
        => AsReference("min");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSentinelAlertRuleAnomalyDuplicate.
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleAnomalyDuplicateTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_sentinel_alert_rule_anomaly_duplicate Terraform resource.
/// Manages a azurerm_sentinel_alert_rule_anomaly_duplicate resource.
/// </summary>
public partial class AzurermSentinelAlertRuleAnomalyDuplicate(string name) : TerraformResource("azurerm_sentinel_alert_rule_anomaly_duplicate", name)
{
    /// <summary>
    /// The built_in_rule_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BuiltInRuleId is required")]
    public required TerraformValue<string> BuiltInRuleId
    {
        get => GetArgument<TerraformValue<string>>("built_in_rule_id");
        set => SetArgument("built_in_rule_id", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => GetArgument<TerraformValue<string>>("log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
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
    /// The frequency attribute.
    /// </summary>
    public TerraformValue<string> Frequency
        => AsReference("frequency");

    /// <summary>
    /// The is_default_settings attribute.
    /// </summary>
    public TerraformValue<bool> IsDefaultSettings
        => AsReference("is_default_settings");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

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
    /// MultiSelectObservation block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSentinelAlertRuleAnomalyDuplicateMultiSelectObservationBlock>? MultiSelectObservation
    {
        get => GetArgument<TerraformList<AzurermSentinelAlertRuleAnomalyDuplicateMultiSelectObservationBlock>>("multi_select_observation");
        set => SetArgument("multi_select_observation", value);
    }

    /// <summary>
    /// PrioritizedExcludeObservation block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSentinelAlertRuleAnomalyDuplicatePrioritizedExcludeObservationBlock>? PrioritizedExcludeObservation
    {
        get => GetArgument<TerraformList<AzurermSentinelAlertRuleAnomalyDuplicatePrioritizedExcludeObservationBlock>>("prioritized_exclude_observation");
        set => SetArgument("prioritized_exclude_observation", value);
    }

    /// <summary>
    /// SingleSelectObservation block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSentinelAlertRuleAnomalyDuplicateSingleSelectObservationBlock>? SingleSelectObservation
    {
        get => GetArgument<TerraformList<AzurermSentinelAlertRuleAnomalyDuplicateSingleSelectObservationBlock>>("single_select_observation");
        set => SetArgument("single_select_observation", value);
    }

    /// <summary>
    /// ThresholdObservation block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSentinelAlertRuleAnomalyDuplicateThresholdObservationBlock>? ThresholdObservation
    {
        get => GetArgument<TerraformList<AzurermSentinelAlertRuleAnomalyDuplicateThresholdObservationBlock>>("threshold_observation");
        set => SetArgument("threshold_observation", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSentinelAlertRuleAnomalyDuplicateTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSentinelAlertRuleAnomalyDuplicateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
