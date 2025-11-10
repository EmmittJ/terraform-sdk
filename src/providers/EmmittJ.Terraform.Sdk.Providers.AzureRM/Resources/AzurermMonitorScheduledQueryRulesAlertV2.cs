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
        set => SetProperty("action_groups", value);
    }

    /// <summary>
    /// The custom_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? CustomProperties
    {
        set => SetProperty("custom_properties", value);
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
        set => SetProperty("metric_measure_column", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    public required TerraformProperty<string> Operator
    {
        set => SetProperty("operator", value);
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformProperty<string> Query
    {
        set => SetProperty("query", value);
    }

    /// <summary>
    /// The resource_id_column attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceIdColumn
    {
        set => SetProperty("resource_id_column", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformProperty<double> Threshold
    {
        set => SetProperty("threshold", value);
    }

    /// <summary>
    /// The time_aggregation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeAggregationMethod is required")]
    public required TerraformProperty<string> TimeAggregationMethod
    {
        set => SetProperty("time_aggregation_method", value);
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
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("created_with_api_version");
        SetOutput("is_a_legacy_log_analytics_rule");
        SetOutput("is_workspace_alerts_storage_configured");
        SetOutput("auto_mitigation_enabled");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("enabled");
        SetOutput("evaluation_frequency");
        SetOutput("id");
        SetOutput("location");
        SetOutput("mute_actions_after_alert_duration");
        SetOutput("name");
        SetOutput("query_time_range_override");
        SetOutput("resource_group_name");
        SetOutput("scopes");
        SetOutput("severity");
        SetOutput("skip_query_validation");
        SetOutput("tags");
        SetOutput("target_resource_types");
        SetOutput("window_duration");
        SetOutput("workspace_alerts_storage_enabled");
    }

    /// <summary>
    /// The auto_mitigation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AutoMitigationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_mitigation_enabled");
        set => SetProperty("auto_mitigation_enabled", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The evaluation_frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluationFrequency is required")]
    public required TerraformProperty<string> EvaluationFrequency
    {
        get => GetRequiredOutput<TerraformProperty<string>>("evaluation_frequency");
        set => SetProperty("evaluation_frequency", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The mute_actions_after_alert_duration attribute.
    /// </summary>
    public TerraformProperty<string> MuteActionsAfterAlertDuration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mute_actions_after_alert_duration");
        set => SetProperty("mute_actions_after_alert_duration", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The query_time_range_override attribute.
    /// </summary>
    public TerraformProperty<string> QueryTimeRangeOverride
    {
        get => GetRequiredOutput<TerraformProperty<string>>("query_time_range_override");
        set => SetProperty("query_time_range_override", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public List<TerraformProperty<string>> Scopes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("scopes");
        set => SetProperty("scopes", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    public required TerraformProperty<double> Severity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("severity");
        set => SetProperty("severity", value);
    }

    /// <summary>
    /// The skip_query_validation attribute.
    /// </summary>
    public TerraformProperty<bool> SkipQueryValidation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_query_validation");
        set => SetProperty("skip_query_validation", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The target_resource_types attribute.
    /// </summary>
    public List<TerraformProperty<string>> TargetResourceTypes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("target_resource_types");
        set => SetProperty("target_resource_types", value);
    }

    /// <summary>
    /// The window_duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WindowDuration is required")]
    public required TerraformProperty<string> WindowDuration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("window_duration");
        set => SetProperty("window_duration", value);
    }

    /// <summary>
    /// The workspace_alerts_storage_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> WorkspaceAlertsStorageEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("workspace_alerts_storage_enabled");
        set => SetProperty("workspace_alerts_storage_enabled", value);
    }

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public List<AzurermMonitorScheduledQueryRulesAlertV2ActionBlock>? Action
    {
        set => SetProperty("action", value);
    }

    /// <summary>
    /// Block for criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Criteria is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Criteria block(s) required")]
    public List<AzurermMonitorScheduledQueryRulesAlertV2CriteriaBlock>? Criteria
    {
        set => SetProperty("criteria", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermMonitorScheduledQueryRulesAlertV2IdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMonitorScheduledQueryRulesAlertV2TimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
