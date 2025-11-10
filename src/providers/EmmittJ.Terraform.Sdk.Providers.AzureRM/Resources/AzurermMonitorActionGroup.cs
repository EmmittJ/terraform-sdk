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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The role_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    public required TerraformProperty<string> RoleId
    {
        set => SetProperty("role_id", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    public TerraformProperty<bool>? UseCommonAlertSchema
    {
        set => SetProperty("use_common_alert_schema", value);
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
        set => SetProperty("automation_account_id", value);
    }

    /// <summary>
    /// The is_global_runbook attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsGlobalRunbook is required")]
    public required TerraformProperty<bool> IsGlobalRunbook
    {
        set => SetProperty("is_global_runbook", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The runbook_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RunbookName is required")]
    public required TerraformProperty<string> RunbookName
    {
        set => SetProperty("runbook_name", value);
    }

    /// <summary>
    /// The service_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceUri is required")]
    public required TerraformProperty<string> ServiceUri
    {
        set => SetProperty("service_uri", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    public TerraformProperty<bool>? UseCommonAlertSchema
    {
        set => SetProperty("use_common_alert_schema", value);
    }

    /// <summary>
    /// The webhook_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookResourceId is required")]
    public required TerraformProperty<string> WebhookResourceId
    {
        set => SetProperty("webhook_resource_id", value);
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
        set => SetProperty("email_address", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
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
        set => SetProperty("function_app_resource_id", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformProperty<string> FunctionName
    {
        set => SetProperty("function_name", value);
    }

    /// <summary>
    /// The http_trigger_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpTriggerUrl is required")]
    public required TerraformProperty<string> HttpTriggerUrl
    {
        set => SetProperty("http_trigger_url", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    public TerraformProperty<bool>? UseCommonAlertSchema
    {
        set => SetProperty("use_common_alert_schema", value);
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
        set => SetProperty("email_address", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    public TerraformProperty<bool>? UseCommonAlertSchema
    {
        set => SetProperty("use_common_alert_schema", value);
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
        set => SetProperty("event_hub_name", value);
    }

    /// <summary>
    /// The event_hub_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventHubNamespace is required")]
    public required TerraformProperty<string> EventHubNamespace
    {
        set => SetProperty("event_hub_namespace", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubscriptionId
    {
        set => SetProperty("subscription_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    public TerraformProperty<bool>? UseCommonAlertSchema
    {
        set => SetProperty("use_common_alert_schema", value);
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
        set => SetProperty("connection_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformProperty<string> Region
    {
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The ticket_configuration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TicketConfiguration is required")]
    public required TerraformProperty<string> TicketConfiguration
    {
        set => SetProperty("ticket_configuration", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        set => SetProperty("workspace_id", value);
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
        set => SetProperty("callback_url", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformProperty<string> ResourceId
    {
        set => SetProperty("resource_id", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    public TerraformProperty<bool>? UseCommonAlertSchema
    {
        set => SetProperty("use_common_alert_schema", value);
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
        set => SetProperty("country_code", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformProperty<string> PhoneNumber
    {
        set => SetProperty("phone_number", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("country_code", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformProperty<string> PhoneNumber
    {
        set => SetProperty("phone_number", value);
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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The service_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceUri is required")]
    public required TerraformProperty<string> ServiceUri
    {
        set => SetProperty("service_uri", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    public TerraformProperty<bool>? UseCommonAlertSchema
    {
        set => SetProperty("use_common_alert_schema", value);
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
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("short_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShortName is required")]
    public required TerraformProperty<string> ShortName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("short_name");
        set => SetProperty("short_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for arm_role_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupArmRoleReceiverBlock>? ArmRoleReceiver
    {
        set => SetProperty("arm_role_receiver", value);
    }

    /// <summary>
    /// Block for automation_runbook_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupAutomationRunbookReceiverBlock>? AutomationRunbookReceiver
    {
        set => SetProperty("automation_runbook_receiver", value);
    }

    /// <summary>
    /// Block for azure_app_push_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupAzureAppPushReceiverBlock>? AzureAppPushReceiver
    {
        set => SetProperty("azure_app_push_receiver", value);
    }

    /// <summary>
    /// Block for azure_function_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupAzureFunctionReceiverBlock>? AzureFunctionReceiver
    {
        set => SetProperty("azure_function_receiver", value);
    }

    /// <summary>
    /// Block for email_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupEmailReceiverBlock>? EmailReceiver
    {
        set => SetProperty("email_receiver", value);
    }

    /// <summary>
    /// Block for event_hub_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupEventHubReceiverBlock>? EventHubReceiver
    {
        set => SetProperty("event_hub_receiver", value);
    }

    /// <summary>
    /// Block for itsm_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupItsmReceiverBlock>? ItsmReceiver
    {
        set => SetProperty("itsm_receiver", value);
    }

    /// <summary>
    /// Block for logic_app_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupLogicAppReceiverBlock>? LogicAppReceiver
    {
        set => SetProperty("logic_app_receiver", value);
    }

    /// <summary>
    /// Block for sms_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupSmsReceiverBlock>? SmsReceiver
    {
        set => SetProperty("sms_receiver", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMonitorActionGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for voice_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupVoiceReceiverBlock>? VoiceReceiver
    {
        set => SetProperty("voice_receiver", value);
    }

    /// <summary>
    /// Block for webhook_receiver.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorActionGroupWebhookReceiverBlock>? WebhookReceiver
    {
        set => SetProperty("webhook_receiver", value);
    }

}
