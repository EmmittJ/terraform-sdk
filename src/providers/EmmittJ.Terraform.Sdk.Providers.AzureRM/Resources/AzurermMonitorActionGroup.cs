using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for arm_role_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupArmRoleReceiverBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The role_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    [TerraformPropertyName("role_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleId { get; set; }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    [TerraformPropertyName("use_common_alert_schema")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseCommonAlertSchema { get; set; }

}

/// <summary>
/// Block type for automation_runbook_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupAutomationRunbookReceiverBlock : ITerraformBlock
{
    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    [TerraformPropertyName("automation_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AutomationAccountId { get; set; }

    /// <summary>
    /// The is_global_runbook attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsGlobalRunbook is required")]
    [TerraformPropertyName("is_global_runbook")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> IsGlobalRunbook { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The runbook_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RunbookName is required")]
    [TerraformPropertyName("runbook_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RunbookName { get; set; }

    /// <summary>
    /// The service_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceUri is required")]
    [TerraformPropertyName("service_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceUri { get; set; }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    [TerraformPropertyName("use_common_alert_schema")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseCommonAlertSchema { get; set; }

    /// <summary>
    /// The webhook_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookResourceId is required")]
    [TerraformPropertyName("webhook_resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WebhookResourceId { get; set; }

}

/// <summary>
/// Block type for azure_app_push_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupAzureAppPushReceiverBlock : ITerraformBlock
{
    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddress is required")]
    [TerraformPropertyName("email_address")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EmailAddress { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for azure_function_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupAzureFunctionReceiverBlock : ITerraformBlock
{
    /// <summary>
    /// The function_app_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionAppResourceId is required")]
    [TerraformPropertyName("function_app_resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FunctionAppResourceId { get; set; }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    [TerraformPropertyName("function_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FunctionName { get; set; }

    /// <summary>
    /// The http_trigger_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpTriggerUrl is required")]
    [TerraformPropertyName("http_trigger_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HttpTriggerUrl { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    [TerraformPropertyName("use_common_alert_schema")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseCommonAlertSchema { get; set; }

}

/// <summary>
/// Block type for email_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupEmailReceiverBlock : ITerraformBlock
{
    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddress is required")]
    [TerraformPropertyName("email_address")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EmailAddress { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    [TerraformPropertyName("use_common_alert_schema")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseCommonAlertSchema { get; set; }

}

/// <summary>
/// Block type for event_hub_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupEventHubReceiverBlock : ITerraformBlock
{
    /// <summary>
    /// The event_hub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventHubName is required")]
    [TerraformPropertyName("event_hub_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EventHubName { get; set; }

    /// <summary>
    /// The event_hub_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventHubNamespace is required")]
    [TerraformPropertyName("event_hub_namespace")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EventHubNamespace { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [TerraformPropertyName("subscription_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SubscriptionId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "subscription_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TenantId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    [TerraformPropertyName("use_common_alert_schema")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseCommonAlertSchema { get; set; }

}

/// <summary>
/// Block type for itsm_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupItsmReceiverBlock : ITerraformBlock
{
    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    [TerraformPropertyName("connection_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConnectionId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    [TerraformPropertyName("region")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Region { get; set; }

    /// <summary>
    /// The ticket_configuration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TicketConfiguration is required")]
    [TerraformPropertyName("ticket_configuration")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TicketConfiguration { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformPropertyName("workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WorkspaceId { get; set; }

}

/// <summary>
/// Block type for logic_app_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupLogicAppReceiverBlock : ITerraformBlock
{
    /// <summary>
    /// The callback_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CallbackUrl is required")]
    [TerraformPropertyName("callback_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CallbackUrl { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformPropertyName("resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceId { get; set; }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    [TerraformPropertyName("use_common_alert_schema")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseCommonAlertSchema { get; set; }

}

/// <summary>
/// Block type for sms_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupSmsReceiverBlock : ITerraformBlock
{
    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountryCode is required")]
    [TerraformPropertyName("country_code")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CountryCode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    [TerraformPropertyName("phone_number")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PhoneNumber { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorActionGroupTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for voice_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupVoiceReceiverBlock : ITerraformBlock
{
    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountryCode is required")]
    [TerraformPropertyName("country_code")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CountryCode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    [TerraformPropertyName("phone_number")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PhoneNumber { get; set; }

}

/// <summary>
/// Block type for webhook_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupWebhookReceiverBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The service_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceUri is required")]
    [TerraformPropertyName("service_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceUri { get; set; }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    [TerraformPropertyName("use_common_alert_schema")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseCommonAlertSchema { get; set; }

}

/// <summary>
/// Manages a azurerm_monitor_action_group resource.
/// </summary>
public class AzurermMonitorActionGroup : TerraformResource
{
    public AzurermMonitorActionGroup(string name) : base("azurerm_monitor_action_group", name)
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

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
    /// The short_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShortName is required")]
    [TerraformPropertyName("short_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ShortName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for arm_role_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("arm_role_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupArmRoleReceiverBlock>>? ArmRoleReceiver { get; set; } = new();

    /// <summary>
    /// Block for automation_runbook_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("automation_runbook_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupAutomationRunbookReceiverBlock>>? AutomationRunbookReceiver { get; set; } = new();

    /// <summary>
    /// Block for azure_app_push_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("azure_app_push_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupAzureAppPushReceiverBlock>>? AzureAppPushReceiver { get; set; } = new();

    /// <summary>
    /// Block for azure_function_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("azure_function_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupAzureFunctionReceiverBlock>>? AzureFunctionReceiver { get; set; } = new();

    /// <summary>
    /// Block for email_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("email_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupEmailReceiverBlock>>? EmailReceiver { get; set; } = new();

    /// <summary>
    /// Block for event_hub_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("event_hub_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupEventHubReceiverBlock>>? EventHubReceiver { get; set; } = new();

    /// <summary>
    /// Block for itsm_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("itsm_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupItsmReceiverBlock>>? ItsmReceiver { get; set; } = new();

    /// <summary>
    /// Block for logic_app_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("logic_app_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupLogicAppReceiverBlock>>? LogicAppReceiver { get; set; } = new();

    /// <summary>
    /// Block for sms_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("sms_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupSmsReceiverBlock>>? SmsReceiver { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMonitorActionGroupTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for voice_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("voice_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupVoiceReceiverBlock>>? VoiceReceiver { get; set; } = new();

    /// <summary>
    /// Block for webhook_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("webhook_receiver")]
    public TerraformList<TerraformBlock<AzurermMonitorActionGroupWebhookReceiverBlock>>? WebhookReceiver { get; set; } = new();

}
