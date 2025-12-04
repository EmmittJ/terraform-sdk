using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for action_incident in AzurermSentinelAutomationRule.
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAutomationRuleActionIncidentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action_incident";

    /// <summary>
    /// The classification attribute.
    /// </summary>
    public TerraformValue<string>? Classification
    {
        get => GetArgument<TerraformValue<string>>("classification");
        set => SetArgument("classification", value);
    }

    /// <summary>
    /// The classification_comment attribute.
    /// </summary>
    public TerraformValue<string>? ClassificationComment
    {
        get => GetArgument<TerraformValue<string>>("classification_comment");
        set => SetArgument("classification_comment", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformList<string>? Labels
    {
        get => GetArgument<TerraformList<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformValue<double> Order
    {
        get => GetRequiredArgument<TerraformValue<double>>("order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string>? OwnerId
    {
        get => GetArgument<TerraformValue<string>>("owner_id");
        set => SetArgument("owner_id", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformValue<string>? Severity
    {
        get => GetArgument<TerraformValue<string>>("severity");
        set => SetArgument("severity", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

}


/// <summary>
/// Block type for action_incident_task in AzurermSentinelAutomationRule.
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAutomationRuleActionIncidentTaskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action_incident_task";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformValue<double> Order
    {
        get => GetRequiredArgument<TerraformValue<double>>("order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetRequiredArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

}


/// <summary>
/// Block type for action_playbook in AzurermSentinelAutomationRule.
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAutomationRuleActionPlaybookBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action_playbook";

    /// <summary>
    /// The logic_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogicAppId is required")]
    public required TerraformValue<string> LogicAppId
    {
        get => GetRequiredArgument<TerraformValue<string>>("logic_app_id");
        set => SetArgument("logic_app_id", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformValue<double> Order
    {
        get => GetRequiredArgument<TerraformValue<double>>("order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => GetArgument<TerraformValue<string>>("tenant_id") ?? AsReference("tenant_id");
        set => SetArgument("tenant_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSentinelAutomationRule.
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAutomationRuleTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_sentinel_automation_rule Terraform resource.
/// Manages a azurerm_sentinel_automation_rule resource.
/// </summary>
public partial class AzurermSentinelAutomationRule(string name) : TerraformResource("azurerm_sentinel_automation_rule", name)
{
    /// <summary>
    /// The condition_json attribute.
    /// </summary>
    public TerraformValue<string>? ConditionJson
    {
        get => GetArgument<TerraformValue<string>>("condition_json");
        set => SetArgument("condition_json", value);
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
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    public TerraformValue<string>? Expiration
    {
        get => GetArgument<TerraformValue<string>>("expiration");
        set => SetArgument("expiration", value);
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
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformValue<double> Order
    {
        get => GetRequiredArgument<TerraformValue<double>>("order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The triggers_on attribute.
    /// </summary>
    public TerraformValue<string>? TriggersOn
    {
        get => GetArgument<TerraformValue<string>>("triggers_on");
        set => SetArgument("triggers_on", value);
    }

    /// <summary>
    /// The triggers_when attribute.
    /// </summary>
    public TerraformValue<string>? TriggersWhen
    {
        get => GetArgument<TerraformValue<string>>("triggers_when");
        set => SetArgument("triggers_when", value);
    }

    /// <summary>
    /// ActionIncident block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSentinelAutomationRuleActionIncidentBlock>? ActionIncident
    {
        get => GetArgument<TerraformList<AzurermSentinelAutomationRuleActionIncidentBlock>>("action_incident");
        set => SetArgument("action_incident", value);
    }

    /// <summary>
    /// ActionIncidentTask block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSentinelAutomationRuleActionIncidentTaskBlock>? ActionIncidentTask
    {
        get => GetArgument<TerraformList<AzurermSentinelAutomationRuleActionIncidentTaskBlock>>("action_incident_task");
        set => SetArgument("action_incident_task", value);
    }

    /// <summary>
    /// ActionPlaybook block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSentinelAutomationRuleActionPlaybookBlock>? ActionPlaybook
    {
        get => GetArgument<TerraformList<AzurermSentinelAutomationRuleActionPlaybookBlock>>("action_playbook");
        set => SetArgument("action_playbook", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSentinelAutomationRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSentinelAutomationRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
