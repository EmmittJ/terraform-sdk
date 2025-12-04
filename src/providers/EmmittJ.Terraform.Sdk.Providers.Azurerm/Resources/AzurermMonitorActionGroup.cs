using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for arm_role_receiver in AzurermMonitorActionGroup.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupArmRoleReceiverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "arm_role_receiver";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The role_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    public required TerraformValue<string> RoleId
    {
        get => GetArgument<TerraformValue<string>>("role_id");
        set => SetArgument("role_id", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    public TerraformValue<bool>? UseCommonAlertSchema
    {
        get => GetArgument<TerraformValue<bool>>("use_common_alert_schema");
        set => SetArgument("use_common_alert_schema", value);
    }

}


/// <summary>
/// Block type for automation_runbook_receiver in AzurermMonitorActionGroup.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupAutomationRunbookReceiverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "automation_runbook_receiver";

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    public required TerraformValue<string> AutomationAccountId
    {
        get => GetArgument<TerraformValue<string>>("automation_account_id");
        set => SetArgument("automation_account_id", value);
    }

    /// <summary>
    /// The is_global_runbook attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsGlobalRunbook is required")]
    public required TerraformValue<bool> IsGlobalRunbook
    {
        get => GetArgument<TerraformValue<bool>>("is_global_runbook");
        set => SetArgument("is_global_runbook", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The runbook_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RunbookName is required")]
    public required TerraformValue<string> RunbookName
    {
        get => GetArgument<TerraformValue<string>>("runbook_name");
        set => SetArgument("runbook_name", value);
    }

    /// <summary>
    /// The service_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceUri is required")]
    public required TerraformValue<string> ServiceUri
    {
        get => GetArgument<TerraformValue<string>>("service_uri");
        set => SetArgument("service_uri", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    public TerraformValue<bool>? UseCommonAlertSchema
    {
        get => GetArgument<TerraformValue<bool>>("use_common_alert_schema");
        set => SetArgument("use_common_alert_schema", value);
    }

    /// <summary>
    /// The webhook_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookResourceId is required")]
    public required TerraformValue<string> WebhookResourceId
    {
        get => GetArgument<TerraformValue<string>>("webhook_resource_id");
        set => SetArgument("webhook_resource_id", value);
    }

}


/// <summary>
/// Block type for azure_app_push_receiver in AzurermMonitorActionGroup.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupAzureAppPushReceiverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_app_push_receiver";

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddress is required")]
    public required TerraformValue<string> EmailAddress
    {
        get => GetArgument<TerraformValue<string>>("email_address");
        set => SetArgument("email_address", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for azure_function_receiver in AzurermMonitorActionGroup.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupAzureFunctionReceiverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_function_receiver";

    /// <summary>
    /// The function_app_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionAppResourceId is required")]
    public required TerraformValue<string> FunctionAppResourceId
    {
        get => GetArgument<TerraformValue<string>>("function_app_resource_id");
        set => SetArgument("function_app_resource_id", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformValue<string> FunctionName
    {
        get => GetArgument<TerraformValue<string>>("function_name");
        set => SetArgument("function_name", value);
    }

    /// <summary>
    /// The http_trigger_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpTriggerUrl is required")]
    public required TerraformValue<string> HttpTriggerUrl
    {
        get => GetArgument<TerraformValue<string>>("http_trigger_url");
        set => SetArgument("http_trigger_url", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    public TerraformValue<bool>? UseCommonAlertSchema
    {
        get => GetArgument<TerraformValue<bool>>("use_common_alert_schema");
        set => SetArgument("use_common_alert_schema", value);
    }

}


/// <summary>
/// Block type for email_receiver in AzurermMonitorActionGroup.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupEmailReceiverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "email_receiver";

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddress is required")]
    public required TerraformValue<string> EmailAddress
    {
        get => GetArgument<TerraformValue<string>>("email_address");
        set => SetArgument("email_address", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    public TerraformValue<bool>? UseCommonAlertSchema
    {
        get => GetArgument<TerraformValue<bool>>("use_common_alert_schema");
        set => SetArgument("use_common_alert_schema", value);
    }

}


/// <summary>
/// Block type for event_hub_receiver in AzurermMonitorActionGroup.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupEventHubReceiverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_hub_receiver";

    /// <summary>
    /// The event_hub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventHubName is required")]
    public required TerraformValue<string> EventHubName
    {
        get => GetArgument<TerraformValue<string>>("event_hub_name");
        set => SetArgument("event_hub_name", value);
    }

    /// <summary>
    /// The event_hub_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventHubNamespace is required")]
    public required TerraformValue<string> EventHubNamespace
    {
        get => GetArgument<TerraformValue<string>>("event_hub_namespace");
        set => SetArgument("event_hub_namespace", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public TerraformValue<string>? SubscriptionId
    {
        get => GetArgument<TerraformValue<string>>("subscription_id");
        set => SetArgument("subscription_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string>? TenantId
    {
        get => GetArgument<TerraformValue<string>>("tenant_id");
        set => SetArgument("tenant_id", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    public TerraformValue<bool>? UseCommonAlertSchema
    {
        get => GetArgument<TerraformValue<bool>>("use_common_alert_schema");
        set => SetArgument("use_common_alert_schema", value);
    }

}


/// <summary>
/// Block type for itsm_receiver in AzurermMonitorActionGroup.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupItsmReceiverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "itsm_receiver";

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    public required TerraformValue<string> ConnectionId
    {
        get => GetArgument<TerraformValue<string>>("connection_id");
        set => SetArgument("connection_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The ticket_configuration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TicketConfiguration is required")]
    public required TerraformValue<string> TicketConfiguration
    {
        get => GetArgument<TerraformValue<string>>("ticket_configuration");
        set => SetArgument("ticket_configuration", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => GetArgument<TerraformValue<string>>("workspace_id");
        set => SetArgument("workspace_id", value);
    }

}


/// <summary>
/// Block type for logic_app_receiver in AzurermMonitorActionGroup.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupLogicAppReceiverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logic_app_receiver";

    /// <summary>
    /// The callback_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CallbackUrl is required")]
    public required TerraformValue<string> CallbackUrl
    {
        get => GetArgument<TerraformValue<string>>("callback_url");
        set => SetArgument("callback_url", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformValue<string> ResourceId
    {
        get => GetArgument<TerraformValue<string>>("resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    public TerraformValue<bool>? UseCommonAlertSchema
    {
        get => GetArgument<TerraformValue<bool>>("use_common_alert_schema");
        set => SetArgument("use_common_alert_schema", value);
    }

}


/// <summary>
/// Block type for sms_receiver in AzurermMonitorActionGroup.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupSmsReceiverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sms_receiver";

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountryCode is required")]
    public required TerraformValue<string> CountryCode
    {
        get => GetArgument<TerraformValue<string>>("country_code");
        set => SetArgument("country_code", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformValue<string> PhoneNumber
    {
        get => GetArgument<TerraformValue<string>>("phone_number");
        set => SetArgument("phone_number", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMonitorActionGroup.
/// Nesting mode: single
/// </summary>
public class AzurermMonitorActionGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for voice_receiver in AzurermMonitorActionGroup.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupVoiceReceiverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "voice_receiver";

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountryCode is required")]
    public required TerraformValue<string> CountryCode
    {
        get => GetArgument<TerraformValue<string>>("country_code");
        set => SetArgument("country_code", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformValue<string> PhoneNumber
    {
        get => GetArgument<TerraformValue<string>>("phone_number");
        set => SetArgument("phone_number", value);
    }

}


/// <summary>
/// Block type for webhook_receiver in AzurermMonitorActionGroup.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupWebhookReceiverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "webhook_receiver";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The service_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceUri is required")]
    public required TerraformValue<string> ServiceUri
    {
        get => GetArgument<TerraformValue<string>>("service_uri");
        set => SetArgument("service_uri", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    public TerraformValue<bool>? UseCommonAlertSchema
    {
        get => GetArgument<TerraformValue<bool>>("use_common_alert_schema");
        set => SetArgument("use_common_alert_schema", value);
    }

    /// <summary>
    /// AadAuth block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AadAuth block(s) allowed")]
    public TerraformList<AzurermMonitorActionGroupWebhookReceiverBlockAadAuthBlock>? AadAuth
    {
        get => GetArgument<TerraformList<AzurermMonitorActionGroupWebhookReceiverBlockAadAuthBlock>>("aad_auth");
        set => SetArgument("aad_auth", value);
    }

}

/// <summary>
/// Block type for aad_auth in AzurermMonitorActionGroupWebhookReceiverBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorActionGroupWebhookReceiverBlockAadAuthBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aad_auth";

    /// <summary>
    /// The identifier_uri attribute.
    /// </summary>
    public TerraformValue<string>? IdentifierUri
    {
        get => GetArgument<TerraformValue<string>>("identifier_uri");
        set => SetArgument("identifier_uri", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    public required TerraformValue<string> ObjectId
    {
        get => GetArgument<TerraformValue<string>>("object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string>? TenantId
    {
        get => GetArgument<TerraformValue<string>>("tenant_id");
        set => SetArgument("tenant_id", value);
    }

}


/// <summary>
/// Represents a azurerm_monitor_action_group Terraform resource.
/// Manages a azurerm_monitor_action_group resource.
/// </summary>
public partial class AzurermMonitorActionGroup(string name) : TerraformResource("azurerm_monitor_action_group", name)
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShortName is required")]
    public required TerraformValue<string> ShortName
    {
        get => GetArgument<TerraformValue<string>>("short_name");
        set => SetArgument("short_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// ArmRoleReceiver block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorActionGroupArmRoleReceiverBlock>? ArmRoleReceiver
    {
        get => GetArgument<TerraformList<AzurermMonitorActionGroupArmRoleReceiverBlock>>("arm_role_receiver");
        set => SetArgument("arm_role_receiver", value);
    }

    /// <summary>
    /// AutomationRunbookReceiver block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorActionGroupAutomationRunbookReceiverBlock>? AutomationRunbookReceiver
    {
        get => GetArgument<TerraformList<AzurermMonitorActionGroupAutomationRunbookReceiverBlock>>("automation_runbook_receiver");
        set => SetArgument("automation_runbook_receiver", value);
    }

    /// <summary>
    /// AzureAppPushReceiver block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorActionGroupAzureAppPushReceiverBlock>? AzureAppPushReceiver
    {
        get => GetArgument<TerraformList<AzurermMonitorActionGroupAzureAppPushReceiverBlock>>("azure_app_push_receiver");
        set => SetArgument("azure_app_push_receiver", value);
    }

    /// <summary>
    /// AzureFunctionReceiver block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorActionGroupAzureFunctionReceiverBlock>? AzureFunctionReceiver
    {
        get => GetArgument<TerraformList<AzurermMonitorActionGroupAzureFunctionReceiverBlock>>("azure_function_receiver");
        set => SetArgument("azure_function_receiver", value);
    }

    /// <summary>
    /// EmailReceiver block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorActionGroupEmailReceiverBlock>? EmailReceiver
    {
        get => GetArgument<TerraformList<AzurermMonitorActionGroupEmailReceiverBlock>>("email_receiver");
        set => SetArgument("email_receiver", value);
    }

    /// <summary>
    /// EventHubReceiver block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorActionGroupEventHubReceiverBlock>? EventHubReceiver
    {
        get => GetArgument<TerraformList<AzurermMonitorActionGroupEventHubReceiverBlock>>("event_hub_receiver");
        set => SetArgument("event_hub_receiver", value);
    }

    /// <summary>
    /// ItsmReceiver block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorActionGroupItsmReceiverBlock>? ItsmReceiver
    {
        get => GetArgument<TerraformList<AzurermMonitorActionGroupItsmReceiverBlock>>("itsm_receiver");
        set => SetArgument("itsm_receiver", value);
    }

    /// <summary>
    /// LogicAppReceiver block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorActionGroupLogicAppReceiverBlock>? LogicAppReceiver
    {
        get => GetArgument<TerraformList<AzurermMonitorActionGroupLogicAppReceiverBlock>>("logic_app_receiver");
        set => SetArgument("logic_app_receiver", value);
    }

    /// <summary>
    /// SmsReceiver block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorActionGroupSmsReceiverBlock>? SmsReceiver
    {
        get => GetArgument<TerraformList<AzurermMonitorActionGroupSmsReceiverBlock>>("sms_receiver");
        set => SetArgument("sms_receiver", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorActionGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorActionGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VoiceReceiver block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorActionGroupVoiceReceiverBlock>? VoiceReceiver
    {
        get => GetArgument<TerraformList<AzurermMonitorActionGroupVoiceReceiverBlock>>("voice_receiver");
        set => SetArgument("voice_receiver", value);
    }

    /// <summary>
    /// WebhookReceiver block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorActionGroupWebhookReceiverBlock>? WebhookReceiver
    {
        get => GetArgument<TerraformList<AzurermMonitorActionGroupWebhookReceiverBlock>>("webhook_receiver");
        set => SetArgument("webhook_receiver", value);
    }

}
