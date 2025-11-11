using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for arm_role_receiver in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorActionGroupArmRoleReceiverBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The role_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    [TerraformProperty("role_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleId { get; set; }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    [TerraformProperty("use_common_alert_schema")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseCommonAlertSchema { get; set; }

}

/// <summary>
/// Block type for automation_runbook_receiver in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorActionGroupAutomationRunbookReceiverBlock : TerraformBlockBase
{
    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    [TerraformProperty("automation_account_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AutomationAccountId { get; set; }

    /// <summary>
    /// The is_global_runbook attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsGlobalRunbook is required")]
    [TerraformProperty("is_global_runbook")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> IsGlobalRunbook { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The runbook_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RunbookName is required")]
    [TerraformProperty("runbook_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RunbookName { get; set; }

    /// <summary>
    /// The service_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceUri is required")]
    [TerraformProperty("service_uri")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceUri { get; set; }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    [TerraformProperty("use_common_alert_schema")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseCommonAlertSchema { get; set; }

    /// <summary>
    /// The webhook_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookResourceId is required")]
    [TerraformProperty("webhook_resource_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WebhookResourceId { get; set; }

}

/// <summary>
/// Block type for azure_app_push_receiver in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorActionGroupAzureAppPushReceiverBlock : TerraformBlockBase
{
    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddress is required")]
    [TerraformProperty("email_address")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EmailAddress { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for azure_function_receiver in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorActionGroupAzureFunctionReceiverBlock : TerraformBlockBase
{
    /// <summary>
    /// The function_app_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionAppResourceId is required")]
    [TerraformProperty("function_app_resource_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FunctionAppResourceId { get; set; }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    [TerraformProperty("function_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FunctionName { get; set; }

    /// <summary>
    /// The http_trigger_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpTriggerUrl is required")]
    [TerraformProperty("http_trigger_url")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HttpTriggerUrl { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    [TerraformProperty("use_common_alert_schema")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseCommonAlertSchema { get; set; }

}

/// <summary>
/// Block type for email_receiver in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorActionGroupEmailReceiverBlock : TerraformBlockBase
{
    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddress is required")]
    [TerraformProperty("email_address")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EmailAddress { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    [TerraformProperty("use_common_alert_schema")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseCommonAlertSchema { get; set; }

}

/// <summary>
/// Block type for event_hub_receiver in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorActionGroupEventHubReceiverBlock : TerraformBlockBase
{
    /// <summary>
    /// The event_hub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventHubName is required")]
    [TerraformProperty("event_hub_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EventHubName { get; set; }

    /// <summary>
    /// The event_hub_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventHubNamespace is required")]
    [TerraformProperty("event_hub_namespace")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EventHubNamespace { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [TerraformProperty("subscription_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SubscriptionId { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> TenantId { get; set; }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    [TerraformProperty("use_common_alert_schema")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseCommonAlertSchema { get; set; }

}

/// <summary>
/// Block type for itsm_receiver in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorActionGroupItsmReceiverBlock : TerraformBlockBase
{
    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    [TerraformProperty("connection_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConnectionId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    [TerraformProperty("region")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The ticket_configuration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TicketConfiguration is required")]
    [TerraformProperty("ticket_configuration")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TicketConfiguration { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformProperty("workspace_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WorkspaceId { get; set; }

}

/// <summary>
/// Block type for logic_app_receiver in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorActionGroupLogicAppReceiverBlock : TerraformBlockBase
{
    /// <summary>
    /// The callback_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CallbackUrl is required")]
    [TerraformProperty("callback_url")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CallbackUrl { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformProperty("resource_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceId { get; set; }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    [TerraformProperty("use_common_alert_schema")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseCommonAlertSchema { get; set; }

}

/// <summary>
/// Block type for sms_receiver in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorActionGroupSmsReceiverBlock : TerraformBlockBase
{
    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountryCode is required")]
    [TerraformProperty("country_code")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CountryCode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    [TerraformProperty("phone_number")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PhoneNumber { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMonitorActionGroupTimeoutsBlock : TerraformBlockBase
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
/// Block type for voice_receiver in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorActionGroupVoiceReceiverBlock : TerraformBlockBase
{
    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountryCode is required")]
    [TerraformProperty("country_code")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CountryCode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    [TerraformProperty("phone_number")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PhoneNumber { get; set; }

}

/// <summary>
/// Block type for webhook_receiver in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorActionGroupWebhookReceiverBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The service_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceUri is required")]
    [TerraformProperty("service_uri")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceUri { get; set; }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    [TerraformProperty("use_common_alert_schema")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseCommonAlertSchema { get; set; }

}

/// <summary>
/// Manages a azurerm_monitor_action_group resource.
/// </summary>
public partial class AzurermMonitorActionGroup : TerraformResource
{
    public AzurermMonitorActionGroup(string name) : base("azurerm_monitor_action_group", name)
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Location { get; set; }

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
    /// The short_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShortName is required")]
    [TerraformProperty("short_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ShortName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for arm_role_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("arm_role_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupArmRoleReceiverBlock>>? ArmRoleReceiver { get; set; }

    /// <summary>
    /// Block for automation_runbook_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("automation_runbook_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupAutomationRunbookReceiverBlock>>? AutomationRunbookReceiver { get; set; }

    /// <summary>
    /// Block for azure_app_push_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("azure_app_push_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupAzureAppPushReceiverBlock>>? AzureAppPushReceiver { get; set; }

    /// <summary>
    /// Block for azure_function_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("azure_function_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupAzureFunctionReceiverBlock>>? AzureFunctionReceiver { get; set; }

    /// <summary>
    /// Block for email_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("email_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupEmailReceiverBlock>>? EmailReceiver { get; set; }

    /// <summary>
    /// Block for event_hub_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("event_hub_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupEventHubReceiverBlock>>? EventHubReceiver { get; set; }

    /// <summary>
    /// Block for itsm_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("itsm_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupItsmReceiverBlock>>? ItsmReceiver { get; set; }

    /// <summary>
    /// Block for logic_app_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("logic_app_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupLogicAppReceiverBlock>>? LogicAppReceiver { get; set; }

    /// <summary>
    /// Block for sms_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("sms_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupSmsReceiverBlock>>? SmsReceiver { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermMonitorActionGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for voice_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("voice_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupVoiceReceiverBlock>>? VoiceReceiver { get; set; }

    /// <summary>
    /// Block for webhook_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("webhook_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupWebhookReceiverBlock>>? WebhookReceiver { get; set; }

}
