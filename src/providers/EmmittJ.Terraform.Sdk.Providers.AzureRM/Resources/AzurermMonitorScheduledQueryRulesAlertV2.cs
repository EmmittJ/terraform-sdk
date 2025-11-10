using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertV2ActionBlock : TerraformBlock
{
    /// <summary>
    /// The action_groups attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ActionGroups
    {
        get => GetProperty<List<TerraformProperty<string>>>("action_groups");
        set => WithProperty("action_groups", value);
    }

    /// <summary>
    /// The custom_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? CustomProperties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("custom_properties");
        set => WithProperty("custom_properties", value);
    }

}

/// <summary>
/// Block type for criteria in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertV2CriteriaBlock : TerraformBlock
{
    /// <summary>
    /// The metric_measure_column attribute.
    /// </summary>
    public TerraformProperty<string>? MetricMeasureColumn
    {
        get => GetProperty<TerraformProperty<string>>("metric_measure_column");
        set => WithProperty("metric_measure_column", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    public required TerraformProperty<string> Operator
    {
        get => GetRequiredProperty<TerraformProperty<string>>("operator");
        set => WithProperty("operator", value);
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformProperty<string> Query
    {
        get => GetRequiredProperty<TerraformProperty<string>>("query");
        set => WithProperty("query", value);
    }

    /// <summary>
    /// The resource_id_column attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceIdColumn
    {
        get => GetProperty<TerraformProperty<string>>("resource_id_column");
        set => WithProperty("resource_id_column", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformProperty<double> Threshold
    {
        get => GetRequiredProperty<TerraformProperty<double>>("threshold");
        set => WithProperty("threshold", value);
    }

    /// <summary>
    /// The time_aggregation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeAggregationMethod is required")]
    public required TerraformProperty<string> TimeAggregationMethod
    {
        get => GetRequiredProperty<TerraformProperty<string>>("time_aggregation_method");
        set => WithProperty("time_aggregation_method", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertV2IdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertV2TimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("created_with_api_version");
        this.WithOutput("is_a_legacy_log_analytics_rule");
        this.WithOutput("is_workspace_alerts_storage_configured");
    }

    /// <summary>
    /// The auto_mitigation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoMitigationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("auto_mitigation_enabled");
        set => this.WithProperty("auto_mitigation_enabled", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The evaluation_frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluationFrequency is required")]
    public required TerraformProperty<string> EvaluationFrequency
    {
        get => GetRequiredProperty<TerraformProperty<string>>("evaluation_frequency");
        set => this.WithProperty("evaluation_frequency", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The mute_actions_after_alert_duration attribute.
    /// </summary>
    public TerraformProperty<string>? MuteActionsAfterAlertDuration
    {
        get => GetProperty<TerraformProperty<string>>("mute_actions_after_alert_duration");
        set => this.WithProperty("mute_actions_after_alert_duration", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The query_time_range_override attribute.
    /// </summary>
    public TerraformProperty<string>? QueryTimeRangeOverride
    {
        get => GetProperty<TerraformProperty<string>>("query_time_range_override");
        set => this.WithProperty("query_time_range_override", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public List<TerraformProperty<string>>? Scopes
    {
        get => GetProperty<List<TerraformProperty<string>>>("scopes");
        set => this.WithProperty("scopes", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    public required TerraformProperty<double> Severity
    {
        get => GetRequiredProperty<TerraformProperty<double>>("severity");
        set => this.WithProperty("severity", value);
    }

    /// <summary>
    /// The skip_query_validation attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipQueryValidation
    {
        get => GetProperty<TerraformProperty<bool>>("skip_query_validation");
        set => this.WithProperty("skip_query_validation", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The target_resource_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TargetResourceTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("target_resource_types");
        set => this.WithProperty("target_resource_types", value);
    }

    /// <summary>
    /// The window_duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WindowDuration is required")]
    public required TerraformProperty<string> WindowDuration
    {
        get => GetRequiredProperty<TerraformProperty<string>>("window_duration");
        set => this.WithProperty("window_duration", value);
    }

    /// <summary>
    /// The workspace_alerts_storage_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? WorkspaceAlertsStorageEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("workspace_alerts_storage_enabled");
        set => this.WithProperty("workspace_alerts_storage_enabled", value);
    }

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public List<AzurermMonitorScheduledQueryRulesAlertV2ActionBlock>? Action
    {
        get => GetProperty<List<AzurermMonitorScheduledQueryRulesAlertV2ActionBlock>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// Block for criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Criteria block(s) required")]
    public List<AzurermMonitorScheduledQueryRulesAlertV2CriteriaBlock>? Criteria
    {
        get => GetProperty<List<AzurermMonitorScheduledQueryRulesAlertV2CriteriaBlock>>("criteria");
        set => this.WithProperty("criteria", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermMonitorScheduledQueryRulesAlertV2IdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermMonitorScheduledQueryRulesAlertV2IdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMonitorScheduledQueryRulesAlertV2TimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMonitorScheduledQueryRulesAlertV2TimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The created_with_api_version attribute.
    /// </summary>
    public TerraformExpression CreatedWithApiVersion => this["created_with_api_version"];

    /// <summary>
    /// The is_a_legacy_log_analytics_rule attribute.
    /// </summary>
    public TerraformExpression IsALegacyLogAnalyticsRule => this["is_a_legacy_log_analytics_rule"];

    /// <summary>
    /// The is_workspace_alerts_storage_configured attribute.
    /// </summary>
    public TerraformExpression IsWorkspaceAlertsStorageConfigured => this["is_workspace_alerts_storage_configured"];

}
