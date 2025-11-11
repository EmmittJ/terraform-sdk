using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMonitorActionGroupDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_monitor_action_group.
/// </summary>
public partial class AzurermMonitorActionGroupDataSource : TerraformDataSource
{
    public AzurermMonitorActionGroupDataSource(string name) : base("azurerm_monitor_action_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermMonitorActionGroupDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arm_role_receiver attribute.
    /// </summary>
    [TerraformProperty("arm_role_receiver")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ArmRoleReceiver { get; }

    /// <summary>
    /// The automation_runbook_receiver attribute.
    /// </summary>
    [TerraformProperty("automation_runbook_receiver")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AutomationRunbookReceiver { get; }

    /// <summary>
    /// The azure_app_push_receiver attribute.
    /// </summary>
    [TerraformProperty("azure_app_push_receiver")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AzureAppPushReceiver { get; }

    /// <summary>
    /// The azure_function_receiver attribute.
    /// </summary>
    [TerraformProperty("azure_function_receiver")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AzureFunctionReceiver { get; }

    /// <summary>
    /// The email_receiver attribute.
    /// </summary>
    [TerraformProperty("email_receiver")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> EmailReceiver { get; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Enabled { get; }

    /// <summary>
    /// The event_hub_receiver attribute.
    /// </summary>
    [TerraformProperty("event_hub_receiver")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> EventHubReceiver { get; }

    /// <summary>
    /// The itsm_receiver attribute.
    /// </summary>
    [TerraformProperty("itsm_receiver")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ItsmReceiver { get; }

    /// <summary>
    /// The logic_app_receiver attribute.
    /// </summary>
    [TerraformProperty("logic_app_receiver")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> LogicAppReceiver { get; }

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    [TerraformProperty("short_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ShortName { get; }

    /// <summary>
    /// The sms_receiver attribute.
    /// </summary>
    [TerraformProperty("sms_receiver")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SmsReceiver { get; }

    /// <summary>
    /// The voice_receiver attribute.
    /// </summary>
    [TerraformProperty("voice_receiver")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> VoiceReceiver { get; }

    /// <summary>
    /// The webhook_receiver attribute.
    /// </summary>
    [TerraformProperty("webhook_receiver")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> WebhookReceiver { get; }

}
