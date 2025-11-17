using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for action in AzurermMonitorScheduledQueryRulesAlertV2.
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
    public TerraformList<string>? ActionGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "action_groups").ResolveNodes(ctx));
        set => SetArgument("action_groups", value);
    }

    /// <summary>
    /// The custom_properties attribute.
    /// </summary>
    public TerraformMap<string>? CustomProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "custom_properties").ResolveNodes(ctx));
        set => SetArgument("custom_properties", value);
    }

}


/// <summary>
/// Block type for criteria in AzurermMonitorScheduledQueryRulesAlertV2.
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
    public TerraformValue<string>? MetricMeasureColumn
    {
        get => new TerraformReference<string>(this, "metric_measure_column");
        set => SetArgument("metric_measure_column", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformValue<string> Query
    {
        get => new TerraformReference<string>(this, "query");
        set => SetArgument("query", value);
    }

    /// <summary>
    /// The resource_id_column attribute.
    /// </summary>
    public TerraformValue<string>? ResourceIdColumn
    {
        get => new TerraformReference<string>(this, "resource_id_column");
        set => SetArgument("resource_id_column", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformValue<double> Threshold
    {
        get => new TerraformReference<double>(this, "threshold");
        set => SetArgument("threshold", value);
    }

    /// <summary>
    /// The time_aggregation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeAggregationMethod is required")]
    public required TerraformValue<string> TimeAggregationMethod
    {
        get => new TerraformReference<string>(this, "time_aggregation_method");
        set => SetArgument("time_aggregation_method", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorScheduledQueryRulesAlertV2CriteriaBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AzurermMonitorScheduledQueryRulesAlertV2CriteriaBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// FailingPeriods block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FailingPeriods block(s) allowed")]
    public TerraformList<AzurermMonitorScheduledQueryRulesAlertV2CriteriaBlockFailingPeriodsBlock>? FailingPeriods
    {
        get => GetArgument<TerraformList<AzurermMonitorScheduledQueryRulesAlertV2CriteriaBlockFailingPeriodsBlock>>("failing_periods");
        set => SetArgument("failing_periods", value);
    }

}

/// <summary>
/// Block type for dimension in AzurermMonitorScheduledQueryRulesAlertV2CriteriaBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertV2CriteriaBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

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
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
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
/// Block type for failing_periods in AzurermMonitorScheduledQueryRulesAlertV2CriteriaBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertV2CriteriaBlockFailingPeriodsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "failing_periods";

    /// <summary>
    /// The minimum_failing_periods_to_trigger_alert attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumFailingPeriodsToTriggerAlert is required")]
    public required TerraformValue<double> MinimumFailingPeriodsToTriggerAlert
    {
        get => new TerraformReference<double>(this, "minimum_failing_periods_to_trigger_alert");
        set => SetArgument("minimum_failing_periods_to_trigger_alert", value);
    }

    /// <summary>
    /// The number_of_evaluation_periods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfEvaluationPeriods is required")]
    public required TerraformValue<double> NumberOfEvaluationPeriods
    {
        get => new TerraformReference<double>(this, "number_of_evaluation_periods");
        set => SetArgument("number_of_evaluation_periods", value);
    }

}


/// <summary>
/// Block type for identity in AzurermMonitorScheduledQueryRulesAlertV2.
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
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMonitorScheduledQueryRulesAlertV2.
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
/// Represents a azurerm_monitor_scheduled_query_rules_alert_v2 Terraform resource.
/// Manages a azurerm_monitor_scheduled_query_rules_alert_v2 resource.
/// </summary>
public partial class AzurermMonitorScheduledQueryRulesAlertV2(string name) : TerraformResource("azurerm_monitor_scheduled_query_rules_alert_v2", name)
{
    /// <summary>
    /// The auto_mitigation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutoMitigationEnabled
    {
        get => new TerraformReference<bool>(this, "auto_mitigation_enabled");
        set => SetArgument("auto_mitigation_enabled", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The evaluation_frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluationFrequency is required")]
    public required TerraformValue<string> EvaluationFrequency
    {
        get => new TerraformReference<string>(this, "evaluation_frequency");
        set => SetArgument("evaluation_frequency", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The mute_actions_after_alert_duration attribute.
    /// </summary>
    public TerraformValue<string>? MuteActionsAfterAlertDuration
    {
        get => new TerraformReference<string>(this, "mute_actions_after_alert_duration");
        set => SetArgument("mute_actions_after_alert_duration", value);
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
    /// The query_time_range_override attribute.
    /// </summary>
    public TerraformValue<string>? QueryTimeRangeOverride
    {
        get => new TerraformReference<string>(this, "query_time_range_override");
        set => SetArgument("query_time_range_override", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public TerraformList<string>? Scopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "scopes").ResolveNodes(ctx));
        set => SetArgument("scopes", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    public required TerraformValue<double> Severity
    {
        get => new TerraformReference<double>(this, "severity");
        set => SetArgument("severity", value);
    }

    /// <summary>
    /// The skip_query_validation attribute.
    /// </summary>
    public TerraformValue<bool>? SkipQueryValidation
    {
        get => new TerraformReference<bool>(this, "skip_query_validation");
        set => SetArgument("skip_query_validation", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The target_resource_types attribute.
    /// </summary>
    public TerraformList<string>? TargetResourceTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "target_resource_types").ResolveNodes(ctx));
        set => SetArgument("target_resource_types", value);
    }

    /// <summary>
    /// The window_duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WindowDuration is required")]
    public required TerraformValue<string> WindowDuration
    {
        get => new TerraformReference<string>(this, "window_duration");
        set => SetArgument("window_duration", value);
    }

    /// <summary>
    /// The workspace_alerts_storage_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? WorkspaceAlertsStorageEnabled
    {
        get => new TerraformReference<bool>(this, "workspace_alerts_storage_enabled");
        set => SetArgument("workspace_alerts_storage_enabled", value);
    }

    /// <summary>
    /// The created_with_api_version attribute.
    /// </summary>
    public TerraformValue<string> CreatedWithApiVersion
    {
        get => new TerraformReference<string>(this, "created_with_api_version");
    }

    /// <summary>
    /// The is_a_legacy_log_analytics_rule attribute.
    /// </summary>
    public TerraformValue<bool> IsALegacyLogAnalyticsRule
    {
        get => new TerraformReference<bool>(this, "is_a_legacy_log_analytics_rule");
    }

    /// <summary>
    /// The is_workspace_alerts_storage_configured attribute.
    /// </summary>
    public TerraformValue<bool> IsWorkspaceAlertsStorageConfigured
    {
        get => new TerraformReference<bool>(this, "is_workspace_alerts_storage_configured");
    }

    /// <summary>
    /// Action block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public TerraformList<AzurermMonitorScheduledQueryRulesAlertV2ActionBlock>? Action
    {
        get => GetArgument<TerraformList<AzurermMonitorScheduledQueryRulesAlertV2ActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Criteria block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Criteria is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Criteria block(s) required")]
    public required TerraformList<AzurermMonitorScheduledQueryRulesAlertV2CriteriaBlock> Criteria
    {
        get => GetRequiredArgument<TerraformList<AzurermMonitorScheduledQueryRulesAlertV2CriteriaBlock>>("criteria");
        set => SetArgument("criteria", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermMonitorScheduledQueryRulesAlertV2IdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermMonitorScheduledQueryRulesAlertV2IdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorScheduledQueryRulesAlertV2TimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorScheduledQueryRulesAlertV2TimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
