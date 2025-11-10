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
        set => SetProperty("classification", value);
    }

    /// <summary>
    /// The classification_comment attribute.
    /// </summary>
    public TerraformProperty<string>? ClassificationComment
    {
        set => SetProperty("classification_comment", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Labels
    {
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformProperty<double> Order
    {
        set => SetProperty("order", value);
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformProperty<string>? OwnerId
    {
        set => SetProperty("owner_id", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformProperty<string>? Severity
    {
        set => SetProperty("severity", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        set => SetProperty("status", value);
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
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformProperty<double> Order
    {
        set => SetProperty("order", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformProperty<string> Title
    {
        set => SetProperty("title", value);
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
        set => SetProperty("logic_app_id", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformProperty<double> Order
    {
        set => SetProperty("order", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("condition_json");
        SetOutput("display_name");
        SetOutput("enabled");
        SetOutput("expiration");
        SetOutput("id");
        SetOutput("log_analytics_workspace_id");
        SetOutput("name");
        SetOutput("order");
        SetOutput("triggers_on");
        SetOutput("triggers_when");
    }

    /// <summary>
    /// The condition_json attribute.
    /// </summary>
    public TerraformProperty<string> ConditionJson
    {
        get => GetRequiredOutput<TerraformProperty<string>>("condition_json");
        set => SetProperty("condition_json", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    public TerraformProperty<string> Expiration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("expiration");
        set => SetProperty("expiration", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformProperty<double> Order
    {
        get => GetRequiredOutput<TerraformProperty<double>>("order");
        set => SetProperty("order", value);
    }

    /// <summary>
    /// The triggers_on attribute.
    /// </summary>
    public TerraformProperty<string> TriggersOn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("triggers_on");
        set => SetProperty("triggers_on", value);
    }

    /// <summary>
    /// The triggers_when attribute.
    /// </summary>
    public TerraformProperty<string> TriggersWhen
    {
        get => GetRequiredOutput<TerraformProperty<string>>("triggers_when");
        set => SetProperty("triggers_when", value);
    }

    /// <summary>
    /// Block for action_incident.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelAutomationRuleActionIncidentBlock>? ActionIncident
    {
        set => SetProperty("action_incident", value);
    }

    /// <summary>
    /// Block for action_incident_task.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelAutomationRuleActionIncidentTaskBlock>? ActionIncidentTask
    {
        set => SetProperty("action_incident_task", value);
    }

    /// <summary>
    /// Block for action_playbook.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelAutomationRuleActionPlaybookBlock>? ActionPlaybook
    {
        set => SetProperty("action_playbook", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelAutomationRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
