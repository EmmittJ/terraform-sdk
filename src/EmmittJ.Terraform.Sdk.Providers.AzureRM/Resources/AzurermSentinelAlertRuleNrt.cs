using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_sentinel_alert_rule_nrt resource.
/// </summary>
public class AzurermSentinelAlertRuleNrt : TerraformResource
{
    public AzurermSentinelAlertRuleNrt(string name) : base("azurerm_sentinel_alert_rule_nrt", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The alert_rule_template_guid attribute.
    /// </summary>
    public TerraformProperty<string>? AlertRuleTemplateGuid
    {
        get => GetProperty<TerraformProperty<string>>("alert_rule_template_guid");
        set => this.WithProperty("alert_rule_template_guid", value);
    }

    /// <summary>
    /// The alert_rule_template_version attribute.
    /// </summary>
    public TerraformProperty<string>? AlertRuleTemplateVersion
    {
        get => GetProperty<TerraformProperty<string>>("alert_rule_template_version");
        set => this.WithProperty("alert_rule_template_version", value);
    }

    /// <summary>
    /// The custom_details attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? CustomDetails
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("custom_details");
        set => this.WithProperty("custom_details", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("log_analytics_workspace_id");
        set => this.WithProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    public TerraformProperty<string>? Query
    {
        get => GetProperty<TerraformProperty<string>>("query");
        set => this.WithProperty("query", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformProperty<string>? Severity
    {
        get => GetProperty<TerraformProperty<string>>("severity");
        set => this.WithProperty("severity", value);
    }

    /// <summary>
    /// The suppression_duration attribute.
    /// </summary>
    public TerraformProperty<string>? SuppressionDuration
    {
        get => GetProperty<TerraformProperty<string>>("suppression_duration");
        set => this.WithProperty("suppression_duration", value);
    }

    /// <summary>
    /// The suppression_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SuppressionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("suppression_enabled");
        set => this.WithProperty("suppression_enabled", value);
    }

    /// <summary>
    /// The tactics attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Tactics
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("tactics");
        set => this.WithProperty("tactics", value);
    }

    /// <summary>
    /// The techniques attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Techniques
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("techniques");
        set => this.WithProperty("techniques", value);
    }

}
