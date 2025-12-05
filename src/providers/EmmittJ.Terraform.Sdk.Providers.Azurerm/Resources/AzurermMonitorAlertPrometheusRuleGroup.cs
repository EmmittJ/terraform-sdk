using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for rule in AzurermMonitorAlertPrometheusRuleGroup.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertPrometheusRuleGroupRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The alert attribute.
    /// </summary>
    public TerraformValue<string>? Alert
    {
        get => GetArgument<TerraformValue<string>>("alert");
        set => SetArgument("alert", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
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
    /// The expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => GetRequiredArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// The for attribute.
    /// </summary>
    public TerraformValue<string>? ForAttribute
    {
        get => GetArgument<TerraformValue<string>>("for");
        set => SetArgument("for", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The record attribute.
    /// </summary>
    public TerraformValue<string>? Record
    {
        get => GetArgument<TerraformValue<string>>("record");
        set => SetArgument("record", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformValue<double>? Severity
    {
        get => GetArgument<TerraformValue<double>>("severity");
        set => SetArgument("severity", value);
    }

    /// <summary>
    /// Action block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Action block(s) allowed")]
    public TerraformList<AzurermMonitorAlertPrometheusRuleGroupRuleBlockActionBlock>? Action
    {
        get => GetArgument<TerraformList<AzurermMonitorAlertPrometheusRuleGroupRuleBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// AlertResolution block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlertResolution block(s) allowed")]
    public TerraformList<AzurermMonitorAlertPrometheusRuleGroupRuleBlockAlertResolutionBlock>? AlertResolution
    {
        get => GetArgument<TerraformList<AzurermMonitorAlertPrometheusRuleGroupRuleBlockAlertResolutionBlock>>("alert_resolution");
        set => SetArgument("alert_resolution", value);
    }

}

/// <summary>
/// Block type for action in AzurermMonitorAlertPrometheusRuleGroupRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertPrometheusRuleGroupRuleBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// The action_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionGroupId is required")]
    public required TerraformValue<string> ActionGroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("action_group_id");
        set => SetArgument("action_group_id", value);
    }

    /// <summary>
    /// The action_properties attribute.
    /// </summary>
    public TerraformMap<string>? ActionProperties
    {
        get => GetArgument<TerraformMap<string>>("action_properties");
        set => SetArgument("action_properties", value);
    }

}

/// <summary>
/// Block type for alert_resolution in AzurermMonitorAlertPrometheusRuleGroupRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertPrometheusRuleGroupRuleBlockAlertResolutionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "alert_resolution";

    /// <summary>
    /// The auto_resolved attribute.
    /// </summary>
    public TerraformValue<bool>? AutoResolved
    {
        get => GetArgument<TerraformValue<bool>>("auto_resolved");
        set => SetArgument("auto_resolved", value);
    }

    /// <summary>
    /// The time_to_resolve attribute.
    /// </summary>
    public TerraformValue<string>? TimeToResolve
    {
        get => GetArgument<TerraformValue<string>>("time_to_resolve");
        set => SetArgument("time_to_resolve", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMonitorAlertPrometheusRuleGroup.
/// Nesting mode: single
/// </summary>
public class AzurermMonitorAlertPrometheusRuleGroupTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_monitor_alert_prometheus_rule_group Terraform resource.
/// Manages a azurerm_monitor_alert_prometheus_rule_group resource.
/// </summary>
public partial class AzurermMonitorAlertPrometheusRuleGroup(string name) : TerraformResource("azurerm_monitor_alert_prometheus_rule_group", name)
{
    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public TerraformValue<string>? ClusterName
    {
        get => GetArgument<TerraformValue<string>>("cluster_name");
        set => SetArgument("cluster_name", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformValue<string>? Interval
    {
        get => GetArgument<TerraformValue<string>>("interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The rule_group_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RuleGroupEnabled
    {
        get => GetArgument<TerraformValue<bool>>("rule_group_enabled");
        set => SetArgument("rule_group_enabled", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public TerraformList<string>? Scopes
    {
        get => GetArgument<TerraformList<string>>("scopes");
        set => SetArgument("scopes", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Rule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    public required TerraformList<AzurermMonitorAlertPrometheusRuleGroupRuleBlock> Rule
    {
        get => GetRequiredArgument<TerraformList<AzurermMonitorAlertPrometheusRuleGroupRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorAlertPrometheusRuleGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorAlertPrometheusRuleGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
