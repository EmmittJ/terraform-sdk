using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSentinelAlertRuleMsSecurityIncident.
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleMsSecurityIncidentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_sentinel_alert_rule_ms_security_incident Terraform resource.
/// Manages a azurerm_sentinel_alert_rule_ms_security_incident resource.
/// </summary>
public partial class AzurermSentinelAlertRuleMsSecurityIncident(string name) : TerraformResource("azurerm_sentinel_alert_rule_ms_security_incident", name)
{
    /// <summary>
    /// The alert_rule_template_guid attribute.
    /// </summary>
    public TerraformValue<string>? AlertRuleTemplateGuid
    {
        get => GetArgument<TerraformValue<string>>("alert_rule_template_guid");
        set => SetArgument("alert_rule_template_guid", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The display_name_exclude_filter attribute.
    /// </summary>
    public TerraformSet<string>? DisplayNameExcludeFilter
    {
        get => GetArgument<TerraformSet<string>>("display_name_exclude_filter");
        set => SetArgument("display_name_exclude_filter", value);
    }

    /// <summary>
    /// The display_name_filter attribute.
    /// </summary>
    public TerraformSet<string>? DisplayNameFilter
    {
        get => GetArgument<TerraformSet<string>>("display_name_filter");
        set => SetArgument("display_name_filter", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The product_filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductFilter is required")]
    public required TerraformValue<string> ProductFilter
    {
        get => GetRequiredArgument<TerraformValue<string>>("product_filter");
        set => SetArgument("product_filter", value);
    }

    /// <summary>
    /// The severity_filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SeverityFilter is required")]
    public required TerraformSet<string> SeverityFilter
    {
        get => GetRequiredArgument<TerraformSet<string>>("severity_filter");
        set => SetArgument("severity_filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSentinelAlertRuleMsSecurityIncidentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSentinelAlertRuleMsSecurityIncidentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
