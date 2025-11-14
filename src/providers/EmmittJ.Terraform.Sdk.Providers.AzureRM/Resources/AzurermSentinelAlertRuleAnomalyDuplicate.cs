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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }


    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformArgument("values")]
    public TerraformList<string>? Values
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
    /// The exclude attribute.
    /// </summary>
    [TerraformArgument("exclude")]
    public TerraformValue<string>? Exclude
    {
        get => new TerraformReference<string>(this, "exclude");
        set => SetArgument("exclude", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The prioritize attribute.
    /// </summary>
    [TerraformArgument("prioritize")]
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }


    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformArgument("value")]
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformArgument("value")]
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
    [TerraformArgument("built_in_rule_id")]
    public required TerraformValue<string> BuiltInRuleId
    {
        get => new TerraformReference<string>(this, "built_in_rule_id");
        set => SetArgument("built_in_rule_id", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformArgument("display_name")]
    public required TerraformValue<string> DisplayName
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
    /// Block for multi_select_observation.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("multi_select_observation")]
    public TerraformList<AzurermSentinelAlertRuleAnomalyDuplicateMultiSelectObservationBlock> MultiSelectObservation { get; set; } = new();

    /// <summary>
    /// Block for prioritized_exclude_observation.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("prioritized_exclude_observation")]
    public TerraformList<AzurermSentinelAlertRuleAnomalyDuplicatePrioritizedExcludeObservationBlock> PrioritizedExcludeObservation { get; set; } = new();

    /// <summary>
    /// Block for single_select_observation.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("single_select_observation")]
    public TerraformList<AzurermSentinelAlertRuleAnomalyDuplicateSingleSelectObservationBlock> SingleSelectObservation { get; set; } = new();

    /// <summary>
    /// Block for threshold_observation.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("threshold_observation")]
    public TerraformList<AzurermSentinelAlertRuleAnomalyDuplicateThresholdObservationBlock> ThresholdObservation { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSentinelAlertRuleAnomalyDuplicateTimeoutsBlock Timeouts { get; set; } = new();

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
    /// The is_default_settings attribute.
    /// </summary>
    [TerraformArgument("is_default_settings")]
    public TerraformValue<bool> IsDefaultSettings
    {
        get => new TerraformReference<bool>(this, "is_default_settings");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformArgument("name")]
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
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

}
