using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for action_incident in .
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
    [TerraformArgument("classification")]
    public TerraformValue<string>? Classification
    {
        get => new TerraformReference<string>(this, "classification");
        set => SetArgument("classification", value);
    }

    /// <summary>
    /// The classification_comment attribute.
    /// </summary>
    [TerraformArgument("classification_comment")]
    public TerraformValue<string>? ClassificationComment
    {
        get => new TerraformReference<string>(this, "classification_comment");
        set => SetArgument("classification_comment", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    [TerraformArgument("labels")]
    public TerraformList<string>? Labels
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    [TerraformArgument("order")]
    public required TerraformValue<double> Order
    {
        get => new TerraformReference<double>(this, "order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformArgument("owner_id")]
    public TerraformValue<string>? OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
        set => SetArgument("owner_id", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [TerraformArgument("severity")]
    public TerraformValue<string>? Severity
    {
        get => new TerraformReference<string>(this, "severity");
        set => SetArgument("severity", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformArgument("status")]
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

}

/// <summary>
/// Block type for action_incident_task in .
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
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    [TerraformArgument("order")]
    public required TerraformValue<double> Order
    {
        get => new TerraformReference<double>(this, "order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    [TerraformArgument("title")]
    public required TerraformValue<string> Title
    {
        get => new TerraformReference<string>(this, "title");
        set => SetArgument("title", value);
    }

}

/// <summary>
/// Block type for action_playbook in .
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
    [TerraformArgument("logic_app_id")]
    public required TerraformValue<string> LogicAppId
    {
        get => new TerraformReference<string>(this, "logic_app_id");
        set => SetArgument("logic_app_id", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    [TerraformArgument("order")]
    public required TerraformValue<double> Order
    {
        get => new TerraformReference<double>(this, "order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformArgument("tenant_id")]
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
        set => SetArgument("tenant_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_sentinel_automation_rule resource.
/// </summary>
public class AzurermSentinelAutomationRule : TerraformResource
{
    public AzurermSentinelAutomationRule(string name) : base("azurerm_sentinel_automation_rule", name)
    {
    }

    /// <summary>
    /// The condition_json attribute.
    /// </summary>
    [TerraformArgument("condition_json")]
    public TerraformValue<string>? ConditionJson
    {
        get => new TerraformReference<string>(this, "condition_json");
        set => SetArgument("condition_json", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformArgument("display_name")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    [TerraformArgument("expiration")]
    public TerraformValue<string>? Expiration
    {
        get => new TerraformReference<string>(this, "expiration");
        set => SetArgument("expiration", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformArgument("log_analytics_workspace_id")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => new TerraformReference<string>(this, "log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    [TerraformArgument("order")]
    public required TerraformValue<double> Order
    {
        get => new TerraformReference<double>(this, "order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The triggers_on attribute.
    /// </summary>
    [TerraformArgument("triggers_on")]
    public TerraformValue<string>? TriggersOn
    {
        get => new TerraformReference<string>(this, "triggers_on");
        set => SetArgument("triggers_on", value);
    }

    /// <summary>
    /// The triggers_when attribute.
    /// </summary>
    [TerraformArgument("triggers_when")]
    public TerraformValue<string>? TriggersWhen
    {
        get => new TerraformReference<string>(this, "triggers_when");
        set => SetArgument("triggers_when", value);
    }

    /// <summary>
    /// Block for action_incident.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("action_incident")]
    public TerraformList<AzurermSentinelAutomationRuleActionIncidentBlock> ActionIncident { get; set; } = new();

    /// <summary>
    /// Block for action_incident_task.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("action_incident_task")]
    public TerraformList<AzurermSentinelAutomationRuleActionIncidentTaskBlock> ActionIncidentTask { get; set; } = new();

    /// <summary>
    /// Block for action_playbook.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("action_playbook")]
    public TerraformList<AzurermSentinelAutomationRuleActionPlaybookBlock> ActionPlaybook { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSentinelAutomationRuleTimeoutsBlock Timeouts { get; set; } = new();

}
