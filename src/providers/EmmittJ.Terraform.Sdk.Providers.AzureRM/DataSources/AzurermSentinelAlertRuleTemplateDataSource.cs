using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleTemplateDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("nrt_template");
        SetOutput("scheduled_template");
        SetOutput("security_incident_template");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("log_analytics_workspace_id");
        SetOutput("name");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformProperty<string> LogAnalyticsWorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_analytics_workspace_id");
        set => SetProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelAlertRuleTemplateDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
