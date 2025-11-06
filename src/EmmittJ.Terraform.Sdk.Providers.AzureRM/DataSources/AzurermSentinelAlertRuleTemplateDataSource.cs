using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_sentinel_alert_rule_template.
/// </summary>
public class AzurermSentinelAlertRuleTemplateDataSource : TerraformDataSource
{
    public AzurermSentinelAlertRuleTemplateDataSource(string name) : base("azurerm_sentinel_alert_rule_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("nrt_template");
        this.DeclareOutput("scheduled_template");
        this.DeclareOutput("security_incident_template");
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
    /// The nrt_template attribute.
    /// </summary>
    public TerraformExpression NrtTemplate => this["nrt_template"];

    /// <summary>
    /// The scheduled_template attribute.
    /// </summary>
    public TerraformExpression ScheduledTemplate => this["scheduled_template"];

    /// <summary>
    /// The security_incident_template attribute.
    /// </summary>
    public TerraformExpression SecurityIncidentTemplate => this["security_incident_template"];

}
