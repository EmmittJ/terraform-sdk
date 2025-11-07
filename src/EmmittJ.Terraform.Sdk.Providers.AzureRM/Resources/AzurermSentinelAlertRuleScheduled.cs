using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_sentinel_alert_rule_scheduled resource.
/// </summary>
public class AzurermSentinelAlertRuleScheduled : TerraformResource
{
    public AzurermSentinelAlertRuleScheduled(string name) : base("azurerm_sentinel_alert_rule_scheduled", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The alert_rule_template_guid attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AlertRuleTemplateGuid
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alert_rule_template_guid");
        set => this.WithProperty("alert_rule_template_guid", value);
    }

    /// <summary>
    /// The alert_rule_template_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AlertRuleTemplateVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alert_rule_template_version");
        set => this.WithProperty("alert_rule_template_version", value);
    }

    /// <summary>
    /// The custom_details attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? CustomDetails
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("custom_details");
        set => this.WithProperty("custom_details", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_analytics_workspace_id");
        set => this.WithProperty("log_analytics_workspace_id", value);
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
    /// The query attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Query
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query");
        set => this.WithProperty("query", value);
    }

    /// <summary>
    /// The query_frequency attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? QueryFrequency
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query_frequency");
        set => this.WithProperty("query_frequency", value);
    }

    /// <summary>
    /// The query_period attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? QueryPeriod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query_period");
        set => this.WithProperty("query_period", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Severity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("severity");
        set => this.WithProperty("severity", value);
    }

    /// <summary>
    /// The suppression_duration attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SuppressionDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("suppression_duration");
        set => this.WithProperty("suppression_duration", value);
    }

    /// <summary>
    /// The suppression_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SuppressionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("suppression_enabled");
        set => this.WithProperty("suppression_enabled", value);
    }

    /// <summary>
    /// The tactics attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Tactics
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tactics");
        set => this.WithProperty("tactics", value);
    }

    /// <summary>
    /// The techniques attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Techniques
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("techniques");
        set => this.WithProperty("techniques", value);
    }

    /// <summary>
    /// The trigger_operator attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TriggerOperator
    {
        get => GetProperty<TerraformLiteralProperty<string>>("trigger_operator");
        set => this.WithProperty("trigger_operator", value);
    }

    /// <summary>
    /// The trigger_threshold attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? TriggerThreshold
    {
        get => GetProperty<TerraformLiteralProperty<double>>("trigger_threshold");
        set => this.WithProperty("trigger_threshold", value);
    }

}
