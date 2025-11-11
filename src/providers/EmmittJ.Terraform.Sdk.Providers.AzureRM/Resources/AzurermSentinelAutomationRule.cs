using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for action_incident in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSentinelAutomationRuleActionIncidentBlock : TerraformBlockBase
{
    /// <summary>
    /// The classification attribute.
    /// </summary>
    [TerraformProperty("classification")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Classification { get; set; }

    /// <summary>
    /// The classification_comment attribute.
    /// </summary>
    [TerraformProperty("classification_comment")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ClassificationComment { get; set; }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Labels { get; set; }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    [TerraformProperty("order")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Order { get; set; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OwnerId { get; set; }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [TerraformProperty("severity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Severity { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Status { get; set; }

}

/// <summary>
/// Block type for action_incident_task in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSentinelAutomationRuleActionIncidentTaskBlock : TerraformBlockBase
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    [TerraformProperty("order")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Order { get; set; }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    [TerraformProperty("title")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Title { get; set; }

}

/// <summary>
/// Block type for action_playbook in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSentinelAutomationRuleActionPlaybookBlock : TerraformBlockBase
{
    /// <summary>
    /// The logic_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogicAppId is required")]
    [TerraformProperty("logic_app_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LogicAppId { get; set; }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    [TerraformProperty("order")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Order { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> TenantId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSentinelAutomationRuleTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_sentinel_automation_rule resource.
/// </summary>
public partial class AzurermSentinelAutomationRule : TerraformResource
{
    public AzurermSentinelAutomationRule(string name) : base("azurerm_sentinel_automation_rule", name)
    {
    }

    /// <summary>
    /// The condition_json attribute.
    /// </summary>
    [TerraformProperty("condition_json")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConditionJson { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    [TerraformProperty("expiration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Expiration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformProperty("log_analytics_workspace_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    [TerraformProperty("order")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Order { get; set; }

    /// <summary>
    /// The triggers_on attribute.
    /// </summary>
    [TerraformProperty("triggers_on")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TriggersOn { get; set; }

    /// <summary>
    /// The triggers_when attribute.
    /// </summary>
    [TerraformProperty("triggers_when")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TriggersWhen { get; set; }

    /// <summary>
    /// Block for action_incident.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("action_incident")]
    public TerraformList<TerraformBlock<AzurermSentinelAutomationRuleActionIncidentBlock>>? ActionIncident { get; set; }

    /// <summary>
    /// Block for action_incident_task.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("action_incident_task")]
    public TerraformList<TerraformBlock<AzurermSentinelAutomationRuleActionIncidentTaskBlock>>? ActionIncidentTask { get; set; }

    /// <summary>
    /// Block for action_playbook.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("action_playbook")]
    public TerraformList<TerraformBlock<AzurermSentinelAutomationRuleActionPlaybookBlock>>? ActionPlaybook { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermSentinelAutomationRuleTimeoutsBlock>? Timeouts { get; set; }

}
