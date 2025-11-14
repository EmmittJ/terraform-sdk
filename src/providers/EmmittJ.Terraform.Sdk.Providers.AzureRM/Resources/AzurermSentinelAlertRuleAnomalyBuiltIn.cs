using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_sentinel_alert_rule_anomaly_built_in resource.
/// </summary>
public class AzurermSentinelAlertRuleAnomalyBuiltIn : TerraformResource
{
    public AzurermSentinelAlertRuleAnomalyBuiltIn(string name) : base("azurerm_sentinel_alert_rule_anomaly_built_in", name)
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformArgument("display_name")]
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformArgument("enabled")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformArgument("log_analytics_workspace_id")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => new TerraformReference<string>(this, "log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformArgument("mode")]
    public required TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformArgument("name")]
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSentinelAlertRuleAnomalyBuiltInTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The anomaly_settings_version attribute.
    /// </summary>
    [TerraformArgument("anomaly_settings_version")]
    public TerraformValue<double> AnomalySettingsVersion
    {
        get => new TerraformReference<double>(this, "anomaly_settings_version");
    }

    /// <summary>
    /// The anomaly_version attribute.
    /// </summary>
    [TerraformArgument("anomaly_version")]
    public TerraformValue<string> AnomalyVersion
    {
        get => new TerraformReference<string>(this, "anomaly_version");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [TerraformArgument("frequency")]
    public TerraformValue<string> Frequency
    {
        get => new TerraformReference<string>(this, "frequency");
    }

    /// <summary>
    /// The multi_select_observation attribute.
    /// </summary>
    [TerraformArgument("multi_select_observation")]
    public TerraformList<object> MultiSelectObservation
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "multi_select_observation").ResolveNodes(ctx));
    }

    /// <summary>
    /// The prioritized_exclude_observation attribute.
    /// </summary>
    [TerraformArgument("prioritized_exclude_observation")]
    public TerraformList<object> PrioritizedExcludeObservation
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "prioritized_exclude_observation").ResolveNodes(ctx));
    }

    /// <summary>
    /// The required_data_connector attribute.
    /// </summary>
    [TerraformArgument("required_data_connector")]
    public TerraformList<object> RequiredDataConnector
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "required_data_connector").ResolveNodes(ctx));
    }

    /// <summary>
    /// The settings_definition_id attribute.
    /// </summary>
    [TerraformArgument("settings_definition_id")]
    public TerraformValue<string> SettingsDefinitionId
    {
        get => new TerraformReference<string>(this, "settings_definition_id");
    }

    /// <summary>
    /// The single_select_observation attribute.
    /// </summary>
    [TerraformArgument("single_select_observation")]
    public TerraformList<object> SingleSelectObservation
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "single_select_observation").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tactics attribute.
    /// </summary>
    [TerraformArgument("tactics")]
    public TerraformList<string> Tactics
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "tactics").ResolveNodes(ctx));
    }

    /// <summary>
    /// The techniques attribute.
    /// </summary>
    [TerraformArgument("techniques")]
    public TerraformList<string> Techniques
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "techniques").ResolveNodes(ctx));
    }

    /// <summary>
    /// The threshold_observation attribute.
    /// </summary>
    [TerraformArgument("threshold_observation")]
    public TerraformList<object> ThresholdObservation
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "threshold_observation").ResolveNodes(ctx));
    }

}
