using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorActionGroupDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMonitorActionGroupDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arm_role_receiver attribute.
    /// </summary>
    [TerraformPropertyName("arm_role_receiver")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ArmRoleReceiver => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "arm_role_receiver");

    /// <summary>
    /// The automation_runbook_receiver attribute.
    /// </summary>
    [TerraformPropertyName("automation_runbook_receiver")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AutomationRunbookReceiver => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "automation_runbook_receiver");

    /// <summary>
    /// The azure_app_push_receiver attribute.
    /// </summary>
    [TerraformPropertyName("azure_app_push_receiver")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AzureAppPushReceiver => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "azure_app_push_receiver");

    /// <summary>
    /// The azure_function_receiver attribute.
    /// </summary>
    [TerraformPropertyName("azure_function_receiver")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AzureFunctionReceiver => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "azure_function_receiver");

    /// <summary>
    /// The email_receiver attribute.
    /// </summary>
    [TerraformPropertyName("email_receiver")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EmailReceiver => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "email_receiver");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Enabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enabled");

    /// <summary>
    /// The event_hub_receiver attribute.
    /// </summary>
    [TerraformPropertyName("event_hub_receiver")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EventHubReceiver => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "event_hub_receiver");

    /// <summary>
    /// The itsm_receiver attribute.
    /// </summary>
    [TerraformPropertyName("itsm_receiver")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ItsmReceiver => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "itsm_receiver");

    /// <summary>
    /// The logic_app_receiver attribute.
    /// </summary>
    [TerraformPropertyName("logic_app_receiver")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LogicAppReceiver => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "logic_app_receiver");

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    [TerraformPropertyName("short_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ShortName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "short_name");

    /// <summary>
    /// The sms_receiver attribute.
    /// </summary>
    [TerraformPropertyName("sms_receiver")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SmsReceiver => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "sms_receiver");

    /// <summary>
    /// The voice_receiver attribute.
    /// </summary>
    [TerraformPropertyName("voice_receiver")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> VoiceReceiver => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "voice_receiver");

    /// <summary>
    /// The webhook_receiver attribute.
    /// </summary>
    [TerraformPropertyName("webhook_receiver")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> WebhookReceiver => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "webhook_receiver");

}
