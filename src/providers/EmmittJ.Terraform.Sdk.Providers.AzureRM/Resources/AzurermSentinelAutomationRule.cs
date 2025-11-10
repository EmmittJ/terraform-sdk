using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for action_incident in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAutomationRuleActionIncidentBlock : TerraformBlock
{
    /// <summary>
    /// The classification attribute.
    /// </summary>
    public TerraformProperty<string>? Classification
    {
        get => GetProperty<TerraformProperty<string>>("classification");
        set => WithProperty("classification", value);
    }

    /// <summary>
    /// The classification_comment attribute.
    /// </summary>
    public TerraformProperty<string>? ClassificationComment
    {
        get => GetProperty<TerraformProperty<string>>("classification_comment");
        set => WithProperty("classification_comment", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Labels
    {
        get => GetProperty<List<TerraformProperty<string>>>("labels");
        set => WithProperty("labels", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformProperty<double> Order
    {
        get => GetRequiredProperty<TerraformProperty<double>>("order");
        set => WithProperty("order", value);
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformProperty<string>? OwnerId
    {
        get => GetProperty<TerraformProperty<string>>("owner_id");
        set => WithProperty("owner_id", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformProperty<string>? Severity
    {
        get => GetProperty<TerraformProperty<string>>("severity");
        set => WithProperty("severity", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => WithProperty("status", value);
    }

}

/// <summary>
/// Block type for action_incident_task in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAutomationRuleActionIncidentTaskBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformProperty<double> Order
    {
        get => GetRequiredProperty<TerraformProperty<double>>("order");
        set => WithProperty("order", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformProperty<string> Title
    {
        get => GetRequiredProperty<TerraformProperty<string>>("title");
        set => WithProperty("title", value);
    }

}

/// <summary>
/// Block type for action_playbook in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAutomationRuleActionPlaybookBlock : TerraformBlock
{
    /// <summary>
    /// The logic_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogicAppId is required")]
    public required TerraformProperty<string> LogicAppId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("logic_app_id");
        set => WithProperty("logic_app_id", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformProperty<double> Order
    {
        get => GetRequiredProperty<TerraformProperty<double>>("order");
        set => WithProperty("order", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAutomationRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_sentinel_automation_rule resource.
/// </summary>
public class AzurermSentinelAutomationRule : TerraformResource
{
    public AzurermSentinelAutomationRule(string name) : base("azurerm_sentinel_automation_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The condition_json attribute.
    /// </summary>
    public TerraformProperty<string>? ConditionJson
    {
        get => GetProperty<TerraformProperty<string>>("condition_json");
        set => this.WithProperty("condition_json", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    public TerraformProperty<string>? Expiration
    {
        get => GetProperty<TerraformProperty<string>>("expiration");
        set => this.WithProperty("expiration", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformProperty<string> LogAnalyticsWorkspaceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("log_analytics_workspace_id");
        set => this.WithProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformProperty<double> Order
    {
        get => GetRequiredProperty<TerraformProperty<double>>("order");
        set => this.WithProperty("order", value);
    }

    /// <summary>
    /// The triggers_on attribute.
    /// </summary>
    public TerraformProperty<string>? TriggersOn
    {
        get => GetProperty<TerraformProperty<string>>("triggers_on");
        set => this.WithProperty("triggers_on", value);
    }

    /// <summary>
    /// The triggers_when attribute.
    /// </summary>
    public TerraformProperty<string>? TriggersWhen
    {
        get => GetProperty<TerraformProperty<string>>("triggers_when");
        set => this.WithProperty("triggers_when", value);
    }

    /// <summary>
    /// Block for action_incident.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelAutomationRuleActionIncidentBlock>? ActionIncident
    {
        get => GetProperty<List<AzurermSentinelAutomationRuleActionIncidentBlock>>("action_incident");
        set => this.WithProperty("action_incident", value);
    }

    /// <summary>
    /// Block for action_incident_task.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelAutomationRuleActionIncidentTaskBlock>? ActionIncidentTask
    {
        get => GetProperty<List<AzurermSentinelAutomationRuleActionIncidentTaskBlock>>("action_incident_task");
        set => this.WithProperty("action_incident_task", value);
    }

    /// <summary>
    /// Block for action_playbook.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelAutomationRuleActionPlaybookBlock>? ActionPlaybook
    {
        get => GetProperty<List<AzurermSentinelAutomationRuleActionPlaybookBlock>>("action_playbook");
        set => this.WithProperty("action_playbook", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelAutomationRuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSentinelAutomationRuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
