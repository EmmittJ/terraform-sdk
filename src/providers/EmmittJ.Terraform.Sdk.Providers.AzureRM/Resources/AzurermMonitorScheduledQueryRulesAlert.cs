using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorScheduledQueryRulesAlertActionBlock : TerraformBlockBase
{
    /// <summary>
    /// The action_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionGroup is required")]
    [TerraformProperty("action_group")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> ActionGroup { get; set; }

    /// <summary>
    /// The custom_webhook_payload attribute.
    /// </summary>
    [TerraformProperty("custom_webhook_payload")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomWebhookPayload { get; set; }

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    [TerraformProperty("email_subject")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EmailSubject { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMonitorScheduledQueryRulesAlertTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for trigger in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorScheduledQueryRulesAlertTriggerBlock : TerraformBlockBase
{
    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    [TerraformProperty("operator")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Operator { get; set; }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    [TerraformProperty("threshold")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Threshold { get; set; }

}

/// <summary>
/// Manages a azurerm_monitor_scheduled_query_rules_alert resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMonitorScheduledQueryRulesAlert : TerraformResource
{
    public AzurermMonitorScheduledQueryRulesAlert(string name) : base("azurerm_monitor_scheduled_query_rules_alert", name)
    {
    }

    /// <summary>
    /// The authorized_resource_ids attribute.
    /// </summary>
    [TerraformProperty("authorized_resource_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AuthorizedResourceIds { get; set; }

    /// <summary>
    /// The auto_mitigation_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_mitigation_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoMitigationEnabled { get; set; }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceId is required")]
    [TerraformProperty("data_source_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataSourceId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformProperty("frequency")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Frequency { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    [TerraformProperty("query")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Query { get; set; }

    /// <summary>
    /// The query_type attribute.
    /// </summary>
    [TerraformProperty("query_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? QueryType { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [TerraformProperty("severity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Severity { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The throttling attribute.
    /// </summary>
    [TerraformProperty("throttling")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Throttling { get; set; }

    /// <summary>
    /// The time_window attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeWindow is required")]
    [TerraformProperty("time_window")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> TimeWindow { get; set; }

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    [TerraformProperty("action")]
    public partial TerraformList<TerraformBlock<AzurermMonitorScheduledQueryRulesAlertActionBlock>>? Action { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermMonitorScheduledQueryRulesAlertTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for trigger.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Trigger is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Trigger block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trigger block(s) allowed")]
    [TerraformProperty("trigger")]
    public partial TerraformList<TerraformBlock<AzurermMonitorScheduledQueryRulesAlertTriggerBlock>>? Trigger { get; set; }

}
