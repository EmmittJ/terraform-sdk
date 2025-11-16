using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "alert_rule_template_guid");
        set => SetArgument("alert_rule_template_guid", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The display_name_exclude_filter attribute.
    /// </summary>
    public TerraformSet<string>? DisplayNameExcludeFilter
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "display_name_exclude_filter").ResolveNodes(ctx));
        set => SetArgument("display_name_exclude_filter", value);
    }

    /// <summary>
    /// The display_name_filter attribute.
    /// </summary>
    public TerraformSet<string>? DisplayNameFilter
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "display_name_filter").ResolveNodes(ctx));
        set => SetArgument("display_name_filter", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => new TerraformReference<string>(this, "log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The product_filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductFilter is required")]
    public required TerraformValue<string> ProductFilter
    {
        get => new TerraformReference<string>(this, "product_filter");
        set => SetArgument("product_filter", value);
    }

    /// <summary>
    /// The severity_filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SeverityFilter is required")]
    public required TerraformSet<string> SeverityFilter
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "severity_filter").ResolveNodes(ctx));
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
