using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for action_group in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorSmartDetectorAlertRuleActionGroupBlock : TerraformBlockBase
{
    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    [TerraformProperty("email_subject")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EmailSubject { get; set; }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ids is required")]
    [TerraformProperty("ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Ids { get; set; }

    /// <summary>
    /// The webhook_payload attribute.
    /// </summary>
    [TerraformProperty("webhook_payload")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WebhookPayload { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMonitorSmartDetectorAlertRuleTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_monitor_smart_detector_alert_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMonitorSmartDetectorAlertRule : TerraformResource
{
    public AzurermMonitorSmartDetectorAlertRule(string name) : base("azurerm_monitor_smart_detector_alert_rule", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The detector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DetectorType is required")]
    [TerraformProperty("detector_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DetectorType { get; set; }

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
    public required partial TerraformValue<string> Frequency { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The scope_resource_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeResourceIds is required")]
    [TerraformProperty("scope_resource_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> ScopeResourceIds { get; set; }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    [TerraformProperty("severity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Severity { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The throttling_duration attribute.
    /// </summary>
    [TerraformProperty("throttling_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ThrottlingDuration { get; set; }

    /// <summary>
    /// Block for action_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ActionGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActionGroup block(s) allowed")]
    [TerraformProperty("action_group")]
    public partial TerraformList<TerraformBlock<AzurermMonitorSmartDetectorAlertRuleActionGroupBlock>>? ActionGroup { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermMonitorSmartDetectorAlertRuleTimeoutsBlock>? Timeouts { get; set; }

}
