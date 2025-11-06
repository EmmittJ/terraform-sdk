using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_sentinel_alert_rule_threat_intelligence resource.
/// </summary>
public class AzurermSentinelAlertRuleThreatIntelligence : TerraformResource
{
    public AzurermSentinelAlertRuleThreatIntelligence(string name) : base("azurerm_sentinel_alert_rule_threat_intelligence", name)
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

}
