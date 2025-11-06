using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_sentinel_alert_rule_ms_security_incident resource.
/// </summary>
public class AzurermSentinelAlertRuleMsSecurityIncident : TerraformResource
{
    public AzurermSentinelAlertRuleMsSecurityIncident(string name) : base("azurerm_sentinel_alert_rule_ms_security_incident", name)
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
    /// The display_name_exclude_filter attribute.
    /// </summary>
    public HashSet<string>? DisplayNameExcludeFilter
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("display_name_exclude_filter")?.Value;
        set => this.WithProperty("display_name_exclude_filter", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The display_name_filter attribute.
    /// </summary>
    public HashSet<string>? DisplayNameFilter
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("display_name_filter")?.Value;
        set => this.WithProperty("display_name_filter", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The product_filter attribute.
    /// </summary>
    public string? ProductFilter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("product_filter")?.Value;
        set => this.WithProperty("product_filter", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The severity_filter attribute.
    /// </summary>
    public HashSet<string>? SeverityFilter
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("severity_filter")?.Value;
        set => this.WithProperty("severity_filter", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

}
