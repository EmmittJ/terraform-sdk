using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for source in AzurermSentinelAlertRuleFusion.
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleFusionSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
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
    /// SubType block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSentinelAlertRuleFusionSourceBlockSubTypeBlock>? SubType
    {
        get => GetArgument<TerraformList<AzurermSentinelAlertRuleFusionSourceBlockSubTypeBlock>>("sub_type");
        set => SetArgument("sub_type", value);
    }

}

/// <summary>
/// Block type for sub_type in AzurermSentinelAlertRuleFusionSourceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleFusionSourceBlockSubTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sub_type";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
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
    /// The severities_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SeveritiesAllowed is required")]
    public required TerraformSet<string> SeveritiesAllowed
    {
        get => GetRequiredArgument<TerraformSet<string>>("severities_allowed");
        set => SetArgument("severities_allowed", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSentinelAlertRuleFusion.
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleFusionTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_sentinel_alert_rule_fusion Terraform resource.
/// Manages a azurerm_sentinel_alert_rule_fusion resource.
/// </summary>
public partial class AzurermSentinelAlertRuleFusion(string name) : TerraformResource("azurerm_sentinel_alert_rule_fusion", name)
{
    /// <summary>
    /// The alert_rule_template_guid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlertRuleTemplateGuid is required")]
    public required TerraformValue<string> AlertRuleTemplateGuid
    {
        get => GetRequiredArgument<TerraformValue<string>>("alert_rule_template_guid");
        set => SetArgument("alert_rule_template_guid", value);
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
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSentinelAlertRuleFusionSourceBlock>? Source
    {
        get => GetArgument<TerraformList<AzurermSentinelAlertRuleFusionSourceBlock>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSentinelAlertRuleFusionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSentinelAlertRuleFusionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
