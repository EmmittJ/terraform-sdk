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
    public string? AlertRuleTemplateGuid
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alert_rule_template_guid")?.Value;
        set => this.WithProperty("alert_rule_template_guid", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The alert_rule_template_version attribute.
    /// </summary>
    public string? AlertRuleTemplateVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alert_rule_template_version")?.Value;
        set => this.WithProperty("alert_rule_template_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_details attribute.
    /// </summary>
    public Dictionary<string, string>? CustomDetails
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("custom_details")?.Value;
        set => this.WithProperty("custom_details", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public string? LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_analytics_workspace_id")?.Value;
        set => this.WithProperty("log_analytics_workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The query attribute.
    /// </summary>
    public string? Query
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query")?.Value;
        set => this.WithProperty("query", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public string? Severity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("severity")?.Value;
        set => this.WithProperty("severity", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The suppression_duration attribute.
    /// </summary>
    public string? SuppressionDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("suppression_duration")?.Value;
        set => this.WithProperty("suppression_duration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The suppression_enabled attribute.
    /// </summary>
    public bool? SuppressionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("suppression_enabled")?.Value;
        set => this.WithProperty("suppression_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The tactics attribute.
    /// </summary>
    public HashSet<string>? Tactics
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tactics")?.Value;
        set => this.WithProperty("tactics", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The techniques attribute.
    /// </summary>
    public HashSet<string>? Techniques
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("techniques")?.Value;
        set => this.WithProperty("techniques", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

}
