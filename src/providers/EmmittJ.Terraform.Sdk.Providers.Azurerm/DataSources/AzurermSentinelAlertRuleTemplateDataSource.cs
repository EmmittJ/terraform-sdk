using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSentinelAlertRuleTemplateDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleTemplateDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_sentinel_alert_rule_template Terraform data source.
/// Retrieves information about a azurerm_sentinel_alert_rule_template.
/// </summary>
public partial class AzurermSentinelAlertRuleTemplateDataSource(string name) : TerraformDataSource("azurerm_sentinel_alert_rule_template", name)
{
    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => GetArgument<TerraformValue<string>>("log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The nrt_template attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NrtTemplate
        => AsReference("nrt_template");

    /// <summary>
    /// The scheduled_template attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ScheduledTemplate
        => AsReference("scheduled_template");

    /// <summary>
    /// The security_incident_template attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SecurityIncidentTemplate
        => AsReference("security_incident_template");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSentinelAlertRuleTemplateDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSentinelAlertRuleTemplateDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
