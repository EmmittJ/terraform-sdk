using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorActionGroupDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_monitor_action_group.
/// </summary>
public class AzurermMonitorActionGroupDataSource : TerraformDataSource
{
    public AzurermMonitorActionGroupDataSource(string name) : base("azurerm_monitor_action_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMonitorActionGroupDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arm_role_receiver attribute.
    /// </summary>
    [TerraformPropertyName("arm_role_receiver")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ArmRoleReceiver => new TerraformReference(this, "arm_role_receiver");

    /// <summary>
    /// The automation_runbook_receiver attribute.
    /// </summary>
    [TerraformPropertyName("automation_runbook_receiver")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AutomationRunbookReceiver => new TerraformReference(this, "automation_runbook_receiver");

    /// <summary>
    /// The azure_app_push_receiver attribute.
    /// </summary>
    [TerraformPropertyName("azure_app_push_receiver")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AzureAppPushReceiver => new TerraformReference(this, "azure_app_push_receiver");

    /// <summary>
    /// The azure_function_receiver attribute.
    /// </summary>
    [TerraformPropertyName("azure_function_receiver")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AzureFunctionReceiver => new TerraformReference(this, "azure_function_receiver");

    /// <summary>
    /// The email_receiver attribute.
    /// </summary>
    [TerraformPropertyName("email_receiver")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EmailReceiver => new TerraformReference(this, "email_receiver");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Enabled => new TerraformReference(this, "enabled");

    /// <summary>
    /// The event_hub_receiver attribute.
    /// </summary>
    [TerraformPropertyName("event_hub_receiver")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EventHubReceiver => new TerraformReference(this, "event_hub_receiver");

    /// <summary>
    /// The itsm_receiver attribute.
    /// </summary>
    [TerraformPropertyName("itsm_receiver")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ItsmReceiver => new TerraformReference(this, "itsm_receiver");

    /// <summary>
    /// The logic_app_receiver attribute.
    /// </summary>
    [TerraformPropertyName("logic_app_receiver")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LogicAppReceiver => new TerraformReference(this, "logic_app_receiver");

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    [TerraformPropertyName("short_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ShortName => new TerraformReference(this, "short_name");

    /// <summary>
    /// The sms_receiver attribute.
    /// </summary>
    [TerraformPropertyName("sms_receiver")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SmsReceiver => new TerraformReference(this, "sms_receiver");

    /// <summary>
    /// The voice_receiver attribute.
    /// </summary>
    [TerraformPropertyName("voice_receiver")]
    // Output-only attribute - read-only reference
    public TerraformList<object> VoiceReceiver => new TerraformReference(this, "voice_receiver");

    /// <summary>
    /// The webhook_receiver attribute.
    /// </summary>
    [TerraformPropertyName("webhook_receiver")]
    // Output-only attribute - read-only reference
    public TerraformList<object> WebhookReceiver => new TerraformReference(this, "webhook_receiver");

}
