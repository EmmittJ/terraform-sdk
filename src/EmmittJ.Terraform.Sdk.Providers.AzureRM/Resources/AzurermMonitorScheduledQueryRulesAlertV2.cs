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
    public TerraformLiteralProperty<bool>? AutoMitigationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_mitigation_enabled");
        set => this.WithProperty("auto_mitigation_enabled", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The evaluation_frequency attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EvaluationFrequency
    {
        get => GetProperty<TerraformLiteralProperty<string>>("evaluation_frequency");
        set => this.WithProperty("evaluation_frequency", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The mute_actions_after_alert_duration attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MuteActionsAfterAlertDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mute_actions_after_alert_duration");
        set => this.WithProperty("mute_actions_after_alert_duration", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The query_time_range_override attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? QueryTimeRangeOverride
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query_time_range_override");
        set => this.WithProperty("query_time_range_override", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Scopes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("scopes");
        set => this.WithProperty("scopes", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Severity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("severity");
        set => this.WithProperty("severity", value);
    }

    /// <summary>
    /// The skip_query_validation attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SkipQueryValidation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_query_validation");
        set => this.WithProperty("skip_query_validation", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The target_resource_types attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? TargetResourceTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("target_resource_types");
        set => this.WithProperty("target_resource_types", value);
    }

    /// <summary>
    /// The window_duration attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WindowDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("window_duration");
        set => this.WithProperty("window_duration", value);
    }

    /// <summary>
    /// The workspace_alerts_storage_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? WorkspaceAlertsStorageEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("workspace_alerts_storage_enabled");
        set => this.WithProperty("workspace_alerts_storage_enabled", value);
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
