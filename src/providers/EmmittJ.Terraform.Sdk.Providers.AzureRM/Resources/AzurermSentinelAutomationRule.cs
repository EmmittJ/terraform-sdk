using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for action_incident in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAutomationRuleActionIncidentBlock
{
    /// <summary>
    /// The classification attribute.
    /// </summary>
    [TerraformPropertyName("classification")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Classification { get; set; }

    /// <summary>
    /// The classification_comment attribute.
    /// </summary>
    [TerraformPropertyName("classification_comment")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClassificationComment { get; set; }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Labels { get; set; }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    [TerraformPropertyName("order")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Order { get; set; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OwnerId { get; set; }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [TerraformPropertyName("severity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Severity { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Status { get; set; }

}

/// <summary>
/// Block type for action_incident_task in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAutomationRuleActionIncidentTaskBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    [TerraformPropertyName("order")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Order { get; set; }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    [TerraformPropertyName("title")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Title { get; set; }

}

/// <summary>
/// Block type for action_playbook in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAutomationRuleActionPlaybookBlock
{
    /// <summary>
    /// The logic_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogicAppId is required")]
    [TerraformPropertyName("logic_app_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LogicAppId { get; set; }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    [TerraformPropertyName("order")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Order { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TenantId { get; set; } = default!;

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAutomationRuleTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    [TerraformPropertyName("condition_json")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConditionJson { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    [TerraformPropertyName("expiration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Expiration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformPropertyName("log_analytics_workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    [TerraformPropertyName("order")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Order { get; set; }

    /// <summary>
    /// The triggers_on attribute.
    /// </summary>
    [TerraformPropertyName("triggers_on")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TriggersOn { get; set; }

    /// <summary>
    /// The triggers_when attribute.
    /// </summary>
    [TerraformPropertyName("triggers_when")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TriggersWhen { get; set; }

    /// <summary>
    /// Block for action_incident.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("action_incident")]
    public TerraformList<TerraformBlock<AzurermSentinelAutomationRuleActionIncidentBlock>>? ActionIncident { get; set; }

    /// <summary>
    /// Block for action_incident_task.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("action_incident_task")]
    public TerraformList<TerraformBlock<AzurermSentinelAutomationRuleActionIncidentTaskBlock>>? ActionIncidentTask { get; set; }

    /// <summary>
    /// Block for action_playbook.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("action_playbook")]
    public TerraformList<TerraformBlock<AzurermSentinelAutomationRuleActionPlaybookBlock>>? ActionPlaybook { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSentinelAutomationRuleTimeoutsBlock>? Timeouts { get; set; }

}
