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
    public TerraformProperty<string>? AlertRuleTemplateGuid
    {
        get => GetProperty<TerraformProperty<string>>("alert_rule_template_guid");
        set => this.WithProperty("alert_rule_template_guid", value);
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
    /// The display_name_exclude_filter attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? DisplayNameExcludeFilter
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("display_name_exclude_filter");
        set => this.WithProperty("display_name_exclude_filter", value);
    }

    /// <summary>
    /// The display_name_filter attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? DisplayNameFilter
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("display_name_filter");
        set => this.WithProperty("display_name_filter", value);
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
    /// The product_filter attribute.
    /// </summary>
    public TerraformProperty<string>? ProductFilter
    {
        get => GetProperty<TerraformProperty<string>>("product_filter");
        set => this.WithProperty("product_filter", value);
    }

    /// <summary>
    /// The severity_filter attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SeverityFilter
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("severity_filter");
        set => this.WithProperty("severity_filter", value);
    }

}
