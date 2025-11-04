using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_monitor_scheduled_query_rules_alert_v2 resource.
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertV2 : TerraformResource
{
    public AzurermMonitorScheduledQueryRulesAlertV2(string name) : base("azurerm_monitor_scheduled_query_rules_alert_v2", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("created_with_api_version");
        this.DeclareOutput("is_a_legacy_log_analytics_rule");
        this.DeclareOutput("is_workspace_alerts_storage_configured");
    }

    /// <summary>
    /// The auto_mitigation_enabled attribute.
    /// </summary>
    public bool? AutoMitigationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_mitigation_enabled")?.Value;
        set => this.WithProperty("auto_mitigation_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The evaluation_frequency attribute.
    /// </summary>
    public string? EvaluationFrequency
    {
        get => GetProperty<TerraformLiteralProperty<string>>("evaluation_frequency")?.Value;
        set => this.WithProperty("evaluation_frequency", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The mute_actions_after_alert_duration attribute.
    /// </summary>
    public string? MuteActionsAfterAlertDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mute_actions_after_alert_duration")?.Value;
        set => this.WithProperty("mute_actions_after_alert_duration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The query_time_range_override attribute.
    /// </summary>
    public string? QueryTimeRangeOverride
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query_time_range_override")?.Value;
        set => this.WithProperty("query_time_range_override", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    public List<string>? Scopes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("scopes")?.Value;
        set => this.WithProperty("scopes", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public double? Severity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("severity")?.Value;
        set => this.WithProperty("severity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The skip_query_validation attribute.
    /// </summary>
    public bool? SkipQueryValidation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_query_validation")?.Value;
        set => this.WithProperty("skip_query_validation", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The target_resource_types attribute.
    /// </summary>
    public List<string>? TargetResourceTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("target_resource_types")?.Value;
        set => this.WithProperty("target_resource_types", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The window_duration attribute.
    /// </summary>
    public string? WindowDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("window_duration")?.Value;
        set => this.WithProperty("window_duration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workspace_alerts_storage_enabled attribute.
    /// </summary>
    public bool? WorkspaceAlertsStorageEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("workspace_alerts_storage_enabled")?.Value;
        set => this.WithProperty("workspace_alerts_storage_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
