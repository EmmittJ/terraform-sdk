using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for arm_role_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupArmRoleReceiverBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The role_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    public required TerraformProperty<string> RoleId
    {
        get => GetProperty<TerraformProperty<string>>("role_id");
        set => WithProperty("role_id", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    public TerraformProperty<bool>? UseCommonAlertSchema
    {
        get => GetProperty<TerraformProperty<bool>>("use_common_alert_schema");
        set => WithProperty("use_common_alert_schema", value);
    }

}

/// <summary>
/// Block type for automation_runbook_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupAutomationRunbookReceiverBlock : TerraformBlock
{
    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    public required TerraformProperty<string> AutomationAccountId
    {
        get => GetProperty<TerraformProperty<string>>("automation_account_id");
        set => WithProperty("automation_account_id", value);
    }

    /// <summary>
    /// The is_global_runbook attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsGlobalRunbook is required")]
    public required TerraformProperty<bool> IsGlobalRunbook
    {
        get => GetProperty<TerraformProperty<bool>>("is_global_runbook");
        set => WithProperty("is_global_runbook", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The runbook_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RunbookName is required")]
    public required TerraformProperty<string> RunbookName
    {
        get => GetProperty<TerraformProperty<string>>("runbook_name");
        set => WithProperty("runbook_name", value);
    }

    /// <summary>
    /// The service_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceUri is required")]
    public required TerraformProperty<string> ServiceUri
    {
        get => GetProperty<TerraformProperty<string>>("service_uri");
        set => WithProperty("service_uri", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    public TerraformProperty<bool>? UseCommonAlertSchema
    {
        get => GetProperty<TerraformProperty<bool>>("use_common_alert_schema");
        set => WithProperty("use_common_alert_schema", value);
    }

    /// <summary>
    /// The webhook_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookResourceId is required")]
    public required TerraformProperty<string> WebhookResourceId
    {
        get => GetProperty<TerraformProperty<string>>("webhook_resource_id");
        set => WithProperty("webhook_resource_id", value);
    }

}

/// <summary>
/// Block type for azure_app_push_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupAzureAppPushReceiverBlock : TerraformBlock
{
    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddress is required")]
    public required TerraformProperty<string> EmailAddress
    {
        get => GetProperty<TerraformProperty<string>>("email_address");
        set => WithProperty("email_address", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for azure_function_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupAzureFunctionReceiverBlock : TerraformBlock
{
    /// <summary>
    /// The function_app_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionAppResourceId is required")]
    public required TerraformProperty<string> FunctionAppResourceId
    {
        get => GetProperty<TerraformProperty<string>>("function_app_resource_id");
        set => WithProperty("function_app_resource_id", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformProperty<string> FunctionName
    {
        get => GetProperty<TerraformProperty<string>>("function_name");
        set => WithProperty("function_name", value);
    }

    /// <summary>
    /// The http_trigger_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpTriggerUrl is required")]
    public required TerraformProperty<string> HttpTriggerUrl
    {
        get => GetProperty<TerraformProperty<string>>("http_trigger_url");
        set => WithProperty("http_trigger_url", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    public TerraformProperty<bool>? UseCommonAlertSchema
    {
        get => GetProperty<TerraformProperty<bool>>("use_common_alert_schema");
        set => WithProperty("use_common_alert_schema", value);
    }

}

/// <summary>
/// Block type for email_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupEmailReceiverBlock : TerraformBlock
{
    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddress is required")]
    public required TerraformProperty<string> EmailAddress
    {
        get => GetProperty<TerraformProperty<string>>("email_address");
        set => WithProperty("email_address", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    public TerraformProperty<bool>? UseCommonAlertSchema
    {
        get => GetProperty<TerraformProperty<bool>>("use_common_alert_schema");
        set => WithProperty("use_common_alert_schema", value);
    }

}

/// <summary>
/// Block type for event_hub_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupEventHubReceiverBlock : TerraformBlock
{
    /// <summary>
    /// The event_hub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventHubName is required")]
    public required TerraformProperty<string> EventHubName
    {
        get => GetProperty<TerraformProperty<string>>("event_hub_name");
        set => WithProperty("event_hub_name", value);
    }

    /// <summary>
    /// The event_hub_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventHubNamespace is required")]
    public required TerraformProperty<string> EventHubNamespace
    {
        get => GetProperty<TerraformProperty<string>>("event_hub_namespace");
        set => WithProperty("event_hub_namespace", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubscriptionId
    {
        get => GetProperty<TerraformProperty<string>>("subscription_id");
        set => WithProperty("subscription_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    public TerraformProperty<bool>? UseCommonAlertSchema
    {
        get => GetProperty<TerraformProperty<bool>>("use_common_alert_schema");
        set => WithProperty("use_common_alert_schema", value);
    }

}

/// <summary>
/// Block type for itsm_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupItsmReceiverBlock : TerraformBlock
{
    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    public required TerraformProperty<string> ConnectionId
    {
        get => GetProperty<TerraformProperty<string>>("connection_id");
        set => WithProperty("connection_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformProperty<string> Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => WithProperty("region", value);
    }

    /// <summary>
    /// The ticket_configuration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TicketConfiguration is required")]
    public required TerraformProperty<string> TicketConfiguration
    {
        get => GetProperty<TerraformProperty<string>>("ticket_configuration");
        set => WithProperty("ticket_configuration", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => WithProperty("workspace_id", value);
    }

}

/// <summary>
/// Block type for logic_app_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupLogicAppReceiverBlock : TerraformBlock
{
    /// <summary>
    /// The callback_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CallbackUrl is required")]
    public required TerraformProperty<string> CallbackUrl
    {
        get => GetProperty<TerraformProperty<string>>("callback_url");
        set => WithProperty("callback_url", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformProperty<string> ResourceId
    {
        get => GetProperty<TerraformProperty<string>>("resource_id");
        set => WithProperty("resource_id", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    public TerraformProperty<bool>? UseCommonAlertSchema
    {
        get => GetProperty<TerraformProperty<bool>>("use_common_alert_schema");
        set => WithProperty("use_common_alert_schema", value);
    }

}

/// <summary>
/// Block type for sms_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupSmsReceiverBlock : TerraformBlock
{
    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountryCode is required")]
    public required TerraformProperty<string> CountryCode
    {
        get => GetProperty<TerraformProperty<string>>("country_code");
        set => WithProperty("country_code", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformProperty<string> PhoneNumber
    {
        get => GetProperty<TerraformProperty<string>>("phone_number");
        set => WithProperty("phone_number", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorActionGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for voice_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupVoiceReceiverBlock : TerraformBlock
{
    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountryCode is required")]
    public required TerraformProperty<string> CountryCode
    {
        get => GetProperty<TerraformProperty<string>>("country_code");
        set => WithProperty("country_code", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformProperty<string> PhoneNumber
    {
        get => GetProperty<TerraformProperty<string>>("phone_number");
        set => WithProperty("phone_number", value);
    }

}

/// <summary>
/// Block type for webhook_receiver in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupWebhookReceiverBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The service_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceUri is required")]
    public required TerraformProperty<string> ServiceUri
    {
        get => GetProperty<TerraformProperty<string>>("service_uri");
        set => WithProperty("service_uri", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    public TerraformProperty<bool>? UseCommonAlertSchema
    {
        get => GetProperty<TerraformProperty<bool>>("use_common_alert_schema");
        set => WithProperty("use_common_alert_schema", value);
    }

}

/// <summary>
/// Manages a azurerm_monitor_action_group resource.
/// </summary>
public class AzurermMonitorActionGroup : TerraformResource
{
    public AzurermMonitorActionGroup(string name) : base("azurerm_monitor_action_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShortName is required")]
    public required TerraformProperty<string> ShortName
    {
        get => GetProperty<TerraformProperty<string>>("short_name");
        set => this.WithProperty("short_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for arm_role_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupArmRoleReceiverBlock>? ArmRoleReceiver
    {
        get => GetProperty<List<AzurermMonitorActionGroupArmRoleReceiverBlock>>("arm_role_receiver");
        set => this.WithProperty("arm_role_receiver", value);
    }

    /// <summary>
    /// Block for automation_runbook_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupAutomationRunbookReceiverBlock>? AutomationRunbookReceiver
    {
        get => GetProperty<List<AzurermMonitorActionGroupAutomationRunbookReceiverBlock>>("automation_runbook_receiver");
        set => this.WithProperty("automation_runbook_receiver", value);
    }

    /// <summary>
    /// Block for azure_app_push_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupAzureAppPushReceiverBlock>? AzureAppPushReceiver
    {
        get => GetProperty<List<AzurermMonitorActionGroupAzureAppPushReceiverBlock>>("azure_app_push_receiver");
        set => this.WithProperty("azure_app_push_receiver", value);
    }

    /// <summary>
    /// Block for azure_function_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupAzureFunctionReceiverBlock>? AzureFunctionReceiver
    {
        get => GetProperty<List<AzurermMonitorActionGroupAzureFunctionReceiverBlock>>("azure_function_receiver");
        set => this.WithProperty("azure_function_receiver", value);
    }

    /// <summary>
    /// Block for email_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupEmailReceiverBlock>? EmailReceiver
    {
        get => GetProperty<List<AzurermMonitorActionGroupEmailReceiverBlock>>("email_receiver");
        set => this.WithProperty("email_receiver", value);
    }

    /// <summary>
    /// Block for event_hub_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupEventHubReceiverBlock>? EventHubReceiver
    {
        get => GetProperty<List<AzurermMonitorActionGroupEventHubReceiverBlock>>("event_hub_receiver");
        set => this.WithProperty("event_hub_receiver", value);
    }

    /// <summary>
    /// Block for itsm_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupItsmReceiverBlock>? ItsmReceiver
    {
        get => GetProperty<List<AzurermMonitorActionGroupItsmReceiverBlock>>("itsm_receiver");
        set => this.WithProperty("itsm_receiver", value);
    }

    /// <summary>
    /// Block for logic_app_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupLogicAppReceiverBlock>? LogicAppReceiver
    {
        get => GetProperty<List<AzurermMonitorActionGroupLogicAppReceiverBlock>>("logic_app_receiver");
        set => this.WithProperty("logic_app_receiver", value);
    }

    /// <summary>
    /// Block for sms_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupSmsReceiverBlock>? SmsReceiver
    {
        get => GetProperty<List<AzurermMonitorActionGroupSmsReceiverBlock>>("sms_receiver");
        set => this.WithProperty("sms_receiver", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMonitorActionGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMonitorActionGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for voice_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupVoiceReceiverBlock>? VoiceReceiver
    {
        get => GetProperty<List<AzurermMonitorActionGroupVoiceReceiverBlock>>("voice_receiver");
        set => this.WithProperty("voice_receiver", value);
    }

    /// <summary>
    /// Block for webhook_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupWebhookReceiverBlock>? WebhookReceiver
    {
        get => GetProperty<List<AzurermMonitorActionGroupWebhookReceiverBlock>>("webhook_receiver");
        set => this.WithProperty("webhook_receiver", value);
    }

}
