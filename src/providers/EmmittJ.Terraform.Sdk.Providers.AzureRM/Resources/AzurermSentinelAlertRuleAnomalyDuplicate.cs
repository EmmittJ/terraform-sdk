using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for multi_select_observation in .
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
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The supported_values attribute.
    /// </summary>
    public TerraformList<string> SupportedValues
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "supported_values").ResolveNodes(ctx));
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for prioritized_exclude_observation in .
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
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The exclude attribute.
    /// </summary>
    public TerraformValue<string>? Exclude
    {
        get => new TerraformReference<string>(this, "exclude");
        set => SetArgument("exclude", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The prioritize attribute.
    /// </summary>
    public TerraformValue<string>? Prioritize
    {
        get => new TerraformReference<string>(this, "prioritize");
        set => SetArgument("prioritize", value);
    }

}

/// <summary>
/// Block type for single_select_observation in .
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
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The supported_values attribute.
    /// </summary>
    public TerraformList<string> SupportedValues
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "supported_values").ResolveNodes(ctx));
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for threshold_observation in .
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
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<string> Max
    {
        get => new TerraformReference<string>(this, "max");
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<string> Min
    {
        get => new TerraformReference<string>(this, "min");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "built_in_rule_id");
        set => SetArgument("built_in_rule_id", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => new TerraformReference<string>(this, "log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The anomaly_settings_version attribute.
    /// </summary>
    public TerraformValue<double> AnomalySettingsVersion
    {
        get => new TerraformReference<double>(this, "anomaly_settings_version");
    }

    /// <summary>
    /// The anomaly_version attribute.
    /// </summary>
    public TerraformValue<string> AnomalyVersion
    {
        get => new TerraformReference<string>(this, "anomaly_version");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformValue<string> Frequency
    {
        get => new TerraformReference<string>(this, "frequency");
    }

    /// <summary>
    /// The is_default_settings attribute.
    /// </summary>
    public TerraformValue<bool> IsDefaultSettings
    {
        get => new TerraformReference<bool>(this, "is_default_settings");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The required_data_connector attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RequiredDataConnector
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "required_data_connector").ResolveNodes(ctx));
    }

    /// <summary>
    /// The settings_definition_id attribute.
    /// </summary>
    public TerraformValue<string> SettingsDefinitionId
    {
        get => new TerraformReference<string>(this, "settings_definition_id");
    }

    /// <summary>
    /// The tactics attribute.
    /// </summary>
    public TerraformList<string> Tactics
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "tactics").ResolveNodes(ctx));
    }

    /// <summary>
    /// The techniques attribute.
    /// </summary>
    public TerraformList<string> Techniques
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "techniques").ResolveNodes(ctx));
    }

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
