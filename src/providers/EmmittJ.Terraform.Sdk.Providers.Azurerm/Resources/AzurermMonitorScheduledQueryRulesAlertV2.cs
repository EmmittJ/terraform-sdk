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
        get => GetArgument<TerraformList<string>>("action_groups");
        set => SetArgument("action_groups", value);
    }

    /// <summary>
    /// The custom_properties attribute.
    /// </summary>
    public TerraformMap<string>? CustomProperties
    {
        get => GetArgument<TerraformMap<string>>("custom_properties");
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
        get => GetArgument<TerraformValue<string>>("metric_measure_column");
        set => SetArgument("metric_measure_column", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformValue<string> Query
    {
        get => GetRequiredArgument<TerraformValue<string>>("query");
        set => SetArgument("query", value);
    }

    /// <summary>
    /// The resource_id_column attribute.
    /// </summary>
    public TerraformValue<string>? ResourceIdColumn
    {
        get => GetArgument<TerraformValue<string>>("resource_id_column");
        set => SetArgument("resource_id_column", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformValue<double> Threshold
    {
        get => GetRequiredArgument<TerraformValue<double>>("threshold");
        set => SetArgument("threshold", value);
    }

    /// <summary>
    /// The time_aggregation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeAggregationMethod is required")]
    public required TerraformValue<string> TimeAggregationMethod
    {
        get => GetRequiredArgument<TerraformValue<string>>("time_aggregation_method");
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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

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
        get => GetRequiredArgument<TerraformValue<double>>("minimum_failing_periods_to_trigger_alert");
        set => SetArgument("minimum_failing_periods_to_trigger_alert", value);
    }

    /// <summary>
    /// The number_of_evaluation_periods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfEvaluationPeriods is required")]
    public required TerraformValue<double> NumberOfEvaluationPeriods
    {
        get => GetRequiredArgument<TerraformValue<double>>("number_of_evaluation_periods");
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
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => CreateReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => CreateReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
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
        get => GetArgument<TerraformValue<bool>>("auto_mitigation_enabled");
        set => SetArgument("auto_mitigation_enabled", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The evaluation_frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluationFrequency is required")]
    public required TerraformValue<string> EvaluationFrequency
    {
        get => GetRequiredArgument<TerraformValue<string>>("evaluation_frequency");
        set => SetArgument("evaluation_frequency", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The mute_actions_after_alert_duration attribute.
    /// </summary>
    public TerraformValue<string>? MuteActionsAfterAlertDuration
    {
        get => GetArgument<TerraformValue<string>>("mute_actions_after_alert_duration");
        set => SetArgument("mute_actions_after_alert_duration", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The query_time_range_override attribute.
    /// </summary>
    public TerraformValue<string>? QueryTimeRangeOverride
    {
        get => GetArgument<TerraformValue<string>>("query_time_range_override");
        set => SetArgument("query_time_range_override", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public TerraformList<string>? Scopes
    {
        get => GetArgument<TerraformList<string>>("scopes");
        set => SetArgument("scopes", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    public required TerraformValue<double> Severity
    {
        get => GetRequiredArgument<TerraformValue<double>>("severity");
        set => SetArgument("severity", value);
    }

    /// <summary>
    /// The skip_query_validation attribute.
    /// </summary>
    public TerraformValue<bool>? SkipQueryValidation
    {
        get => GetArgument<TerraformValue<bool>>("skip_query_validation");
        set => SetArgument("skip_query_validation", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The target_resource_types attribute.
    /// </summary>
    public TerraformList<string>? TargetResourceTypes
    {
        get => GetArgument<TerraformList<string>>("target_resource_types");
        set => SetArgument("target_resource_types", value);
    }

    /// <summary>
    /// The window_duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WindowDuration is required")]
    public required TerraformValue<string> WindowDuration
    {
        get => GetRequiredArgument<TerraformValue<string>>("window_duration");
        set => SetArgument("window_duration", value);
    }

    /// <summary>
    /// The workspace_alerts_storage_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? WorkspaceAlertsStorageEnabled
    {
        get => GetArgument<TerraformValue<bool>>("workspace_alerts_storage_enabled");
        set => SetArgument("workspace_alerts_storage_enabled", value);
    }

    /// <summary>
    /// The created_with_api_version attribute.
    /// </summary>
    public TerraformValue<string> CreatedWithApiVersion
        => CreateReference("created_with_api_version");

    /// <summary>
    /// The is_a_legacy_log_analytics_rule attribute.
    /// </summary>
    public TerraformValue<bool> IsALegacyLogAnalyticsRule
        => CreateReference("is_a_legacy_log_analytics_rule");

    /// <summary>
    /// The is_workspace_alerts_storage_configured attribute.
    /// </summary>
    public TerraformValue<bool> IsWorkspaceAlertsStorageConfigured
        => CreateReference("is_workspace_alerts_storage_configured");

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
