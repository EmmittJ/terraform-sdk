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
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertV2ActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// The action_groups attribute.
    /// </summary>
    [TerraformArgument("action_groups")]
    public TerraformList<string>? ActionGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "action_groups").ResolveNodes(ctx));
        set => SetArgument("action_groups", value);
    }

    /// <summary>
    /// The custom_properties attribute.
    /// </summary>
    [TerraformArgument("custom_properties")]
    public TerraformMap<string>? CustomProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "custom_properties").ResolveNodes(ctx));
        set => SetArgument("custom_properties", value);
    }

}

/// <summary>
/// Block type for criteria in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertV2CriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "criteria";

    /// <summary>
    /// The metric_measure_column attribute.
    /// </summary>
    [TerraformArgument("metric_measure_column")]
    public TerraformValue<string>? MetricMeasureColumn
    {
        get => new TerraformReference<string>(this, "metric_measure_column");
        set => SetArgument("metric_measure_column", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    [TerraformArgument("operator")]
    public required TerraformValue<string> Operator
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    [TerraformArgument("query")]
    public required TerraformValue<string> Query
    {
        get => new TerraformReference<string>(this, "query");
        set => SetArgument("query", value);
    }

    /// <summary>
    /// The resource_id_column attribute.
    /// </summary>
    [TerraformArgument("resource_id_column")]
    public TerraformValue<string>? ResourceIdColumn
    {
        get => new TerraformReference<string>(this, "resource_id_column");
        set => SetArgument("resource_id_column", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    [TerraformArgument("threshold")]
    public required TerraformValue<double> Threshold
    {
        get => new TerraformReference<double>(this, "threshold");
        set => SetArgument("threshold", value);
    }

    /// <summary>
    /// The time_aggregation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeAggregationMethod is required")]
    [TerraformArgument("time_aggregation_method")]
    public required TerraformValue<string> TimeAggregationMethod
    {
        get => new TerraformReference<string>(this, "time_aggregation_method");
        set => SetArgument("time_aggregation_method", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertV2IdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertV2TimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_monitor_scheduled_query_rules_alert_v2 resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMonitorScheduledQueryRulesAlertV2 : TerraformResource
{
    public AzurermMonitorScheduledQueryRulesAlertV2(string name) : base("azurerm_monitor_scheduled_query_rules_alert_v2", name)
    {
    }

    /// <summary>
    /// The auto_mitigation_enabled attribute.
    /// </summary>
    [TerraformArgument("auto_mitigation_enabled")]
    public TerraformValue<bool>? AutoMitigationEnabled
    {
        get => new TerraformReference<bool>(this, "auto_mitigation_enabled");
        set => SetArgument("auto_mitigation_enabled", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformArgument("display_name")]
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The evaluation_frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluationFrequency is required")]
    [TerraformArgument("evaluation_frequency")]
    public required TerraformValue<string> EvaluationFrequency
    {
        get => new TerraformReference<string>(this, "evaluation_frequency");
        set => SetArgument("evaluation_frequency", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The mute_actions_after_alert_duration attribute.
    /// </summary>
    [TerraformArgument("mute_actions_after_alert_duration")]
    public TerraformValue<string>? MuteActionsAfterAlertDuration
    {
        get => new TerraformReference<string>(this, "mute_actions_after_alert_duration");
        set => SetArgument("mute_actions_after_alert_duration", value);
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
    /// The query_time_range_override attribute.
    /// </summary>
    [TerraformArgument("query_time_range_override")]
    public TerraformValue<string>? QueryTimeRangeOverride
    {
        get => new TerraformReference<string>(this, "query_time_range_override");
        set => SetArgument("query_time_range_override", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    [TerraformArgument("scopes")]
    public TerraformList<string>? Scopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "scopes").ResolveNodes(ctx));
        set => SetArgument("scopes", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    [TerraformArgument("severity")]
    public required TerraformValue<double> Severity
    {
        get => new TerraformReference<double>(this, "severity");
        set => SetArgument("severity", value);
    }

    /// <summary>
    /// The skip_query_validation attribute.
    /// </summary>
    [TerraformArgument("skip_query_validation")]
    public TerraformValue<bool>? SkipQueryValidation
    {
        get => new TerraformReference<bool>(this, "skip_query_validation");
        set => SetArgument("skip_query_validation", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The target_resource_types attribute.
    /// </summary>
    [TerraformArgument("target_resource_types")]
    public TerraformList<string>? TargetResourceTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "target_resource_types").ResolveNodes(ctx));
        set => SetArgument("target_resource_types", value);
    }

    /// <summary>
    /// The window_duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WindowDuration is required")]
    [TerraformArgument("window_duration")]
    public required TerraformValue<string> WindowDuration
    {
        get => new TerraformReference<string>(this, "window_duration");
        set => SetArgument("window_duration", value);
    }

    /// <summary>
    /// The workspace_alerts_storage_enabled attribute.
    /// </summary>
    [TerraformArgument("workspace_alerts_storage_enabled")]
    public TerraformValue<bool>? WorkspaceAlertsStorageEnabled
    {
        get => new TerraformReference<bool>(this, "workspace_alerts_storage_enabled");
        set => SetArgument("workspace_alerts_storage_enabled", value);
    }

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    [TerraformArgument("action")]
    public TerraformList<AzurermMonitorScheduledQueryRulesAlertV2ActionBlock> Action { get; set; } = new();

    /// <summary>
    /// Block for criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Criteria is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Criteria block(s) required")]
    [TerraformArgument("criteria")]
    public required TerraformList<AzurermMonitorScheduledQueryRulesAlertV2CriteriaBlock> Criteria { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermMonitorScheduledQueryRulesAlertV2IdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMonitorScheduledQueryRulesAlertV2TimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The created_with_api_version attribute.
    /// </summary>
    [TerraformArgument("created_with_api_version")]
    public TerraformValue<string> CreatedWithApiVersion
    {
        get => new TerraformReference<string>(this, "created_with_api_version");
    }

    /// <summary>
    /// The is_a_legacy_log_analytics_rule attribute.
    /// </summary>
    [TerraformArgument("is_a_legacy_log_analytics_rule")]
    public TerraformValue<bool> IsALegacyLogAnalyticsRule
    {
        get => new TerraformReference<bool>(this, "is_a_legacy_log_analytics_rule");
    }

    /// <summary>
    /// The is_workspace_alerts_storage_configured attribute.
    /// </summary>
    [TerraformArgument("is_workspace_alerts_storage_configured")]
    public TerraformValue<bool> IsWorkspaceAlertsStorageConfigured
    {
        get => new TerraformReference<bool>(this, "is_workspace_alerts_storage_configured");
    }

}
