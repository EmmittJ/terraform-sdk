using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The multi_select_observation attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MultiSelectObservation
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "multi_select_observation").ResolveNodes(ctx));
    }

    /// <summary>
    /// The prioritized_exclude_observation attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrioritizedExcludeObservation
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "prioritized_exclude_observation").ResolveNodes(ctx));
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
    /// The single_select_observation attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SingleSelectObservation
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "single_select_observation").ResolveNodes(ctx));
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
    /// The threshold_observation attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ThresholdObservation
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "threshold_observation").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSentinelAlertRuleAnomalyBuiltInTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSentinelAlertRuleAnomalyBuiltInTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
