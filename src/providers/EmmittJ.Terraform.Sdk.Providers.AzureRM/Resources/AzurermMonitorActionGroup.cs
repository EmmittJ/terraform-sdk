using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for arm_role_receiver in .
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
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The role_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    [TerraformArgument("role_id")]
    public required TerraformValue<string> RoleId
    {
        get => new TerraformReference<string>(this, "role_id");
        set => SetArgument("role_id", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    [TerraformArgument("use_common_alert_schema")]
    public TerraformValue<bool>? UseCommonAlertSchema
    {
        get => new TerraformReference<bool>(this, "use_common_alert_schema");
        set => SetArgument("use_common_alert_schema", value);
    }

}

/// <summary>
/// Block type for automation_runbook_receiver in .
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
    [TerraformArgument("automation_account_id")]
    public required TerraformValue<string> AutomationAccountId
    {
        get => new TerraformReference<string>(this, "automation_account_id");
        set => SetArgument("automation_account_id", value);
    }

    /// <summary>
    /// The is_global_runbook attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsGlobalRunbook is required")]
    [TerraformArgument("is_global_runbook")]
    public required TerraformValue<bool> IsGlobalRunbook
    {
        get => new TerraformReference<bool>(this, "is_global_runbook");
        set => SetArgument("is_global_runbook", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The runbook_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RunbookName is required")]
    [TerraformArgument("runbook_name")]
    public required TerraformValue<string> RunbookName
    {
        get => new TerraformReference<string>(this, "runbook_name");
        set => SetArgument("runbook_name", value);
    }

    /// <summary>
    /// The service_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceUri is required")]
    [TerraformArgument("service_uri")]
    public required TerraformValue<string> ServiceUri
    {
        get => new TerraformReference<string>(this, "service_uri");
        set => SetArgument("service_uri", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    [TerraformArgument("use_common_alert_schema")]
    public TerraformValue<bool>? UseCommonAlertSchema
    {
        get => new TerraformReference<bool>(this, "use_common_alert_schema");
        set => SetArgument("use_common_alert_schema", value);
    }

    /// <summary>
    /// The webhook_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebhookResourceId is required")]
    [TerraformArgument("webhook_resource_id")]
    public required TerraformValue<string> WebhookResourceId
    {
        get => new TerraformReference<string>(this, "webhook_resource_id");
        set => SetArgument("webhook_resource_id", value);
    }

}

/// <summary>
/// Block type for azure_app_push_receiver in .
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
    [TerraformArgument("email_address")]
    public required TerraformValue<string> EmailAddress
    {
        get => new TerraformReference<string>(this, "email_address");
        set => SetArgument("email_address", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for azure_function_receiver in .
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
    [TerraformArgument("function_app_resource_id")]
    public required TerraformValue<string> FunctionAppResourceId
    {
        get => new TerraformReference<string>(this, "function_app_resource_id");
        set => SetArgument("function_app_resource_id", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    [TerraformArgument("function_name")]
    public required TerraformValue<string> FunctionName
    {
        get => new TerraformReference<string>(this, "function_name");
        set => SetArgument("function_name", value);
    }

    /// <summary>
    /// The http_trigger_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpTriggerUrl is required")]
    [TerraformArgument("http_trigger_url")]
    public required TerraformValue<string> HttpTriggerUrl
    {
        get => new TerraformReference<string>(this, "http_trigger_url");
        set => SetArgument("http_trigger_url", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    [TerraformArgument("use_common_alert_schema")]
    public TerraformValue<bool>? UseCommonAlertSchema
    {
        get => new TerraformReference<bool>(this, "use_common_alert_schema");
        set => SetArgument("use_common_alert_schema", value);
    }

}

/// <summary>
/// Block type for email_receiver in .
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
    [TerraformArgument("email_address")]
    public required TerraformValue<string> EmailAddress
    {
        get => new TerraformReference<string>(this, "email_address");
        set => SetArgument("email_address", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    [TerraformArgument("use_common_alert_schema")]
    public TerraformValue<bool>? UseCommonAlertSchema
    {
        get => new TerraformReference<bool>(this, "use_common_alert_schema");
        set => SetArgument("use_common_alert_schema", value);
    }

}

/// <summary>
/// Block type for event_hub_receiver in .
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
    [TerraformArgument("event_hub_name")]
    public required TerraformValue<string> EventHubName
    {
        get => new TerraformReference<string>(this, "event_hub_name");
        set => SetArgument("event_hub_name", value);
    }

    /// <summary>
    /// The event_hub_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventHubNamespace is required")]
    [TerraformArgument("event_hub_namespace")]
    public required TerraformValue<string> EventHubNamespace
    {
        get => new TerraformReference<string>(this, "event_hub_namespace");
        set => SetArgument("event_hub_namespace", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [TerraformArgument("subscription_id")]
    public TerraformValue<string> SubscriptionId
    {
        get => new TerraformReference<string>(this, "subscription_id");
        set => SetArgument("subscription_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformArgument("tenant_id")]
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
        set => SetArgument("tenant_id", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    [TerraformArgument("use_common_alert_schema")]
    public TerraformValue<bool>? UseCommonAlertSchema
    {
        get => new TerraformReference<bool>(this, "use_common_alert_schema");
        set => SetArgument("use_common_alert_schema", value);
    }

}

/// <summary>
/// Block type for itsm_receiver in .
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
    [TerraformArgument("connection_id")]
    public required TerraformValue<string> ConnectionId
    {
        get => new TerraformReference<string>(this, "connection_id");
        set => SetArgument("connection_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    [TerraformArgument("region")]
    public required TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The ticket_configuration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TicketConfiguration is required")]
    [TerraformArgument("ticket_configuration")]
    public required TerraformValue<string> TicketConfiguration
    {
        get => new TerraformReference<string>(this, "ticket_configuration");
        set => SetArgument("ticket_configuration", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformArgument("workspace_id")]
    public required TerraformValue<string> WorkspaceId
    {
        get => new TerraformReference<string>(this, "workspace_id");
        set => SetArgument("workspace_id", value);
    }

}

/// <summary>
/// Block type for logic_app_receiver in .
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
    [TerraformArgument("callback_url")]
    public required TerraformValue<string> CallbackUrl
    {
        get => new TerraformReference<string>(this, "callback_url");
        set => SetArgument("callback_url", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformArgument("resource_id")]
    public required TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    [TerraformArgument("use_common_alert_schema")]
    public TerraformValue<bool>? UseCommonAlertSchema
    {
        get => new TerraformReference<bool>(this, "use_common_alert_schema");
        set => SetArgument("use_common_alert_schema", value);
    }

}

/// <summary>
/// Block type for sms_receiver in .
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
    [TerraformArgument("country_code")]
    public required TerraformValue<string> CountryCode
    {
        get => new TerraformReference<string>(this, "country_code");
        set => SetArgument("country_code", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    [TerraformArgument("phone_number")]
    public required TerraformValue<string> PhoneNumber
    {
        get => new TerraformReference<string>(this, "phone_number");
        set => SetArgument("phone_number", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for voice_receiver in .
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
    [TerraformArgument("country_code")]
    public required TerraformValue<string> CountryCode
    {
        get => new TerraformReference<string>(this, "country_code");
        set => SetArgument("country_code", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    [TerraformArgument("phone_number")]
    public required TerraformValue<string> PhoneNumber
    {
        get => new TerraformReference<string>(this, "phone_number");
        set => SetArgument("phone_number", value);
    }

}

/// <summary>
/// Block type for webhook_receiver in .
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
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The service_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceUri is required")]
    [TerraformArgument("service_uri")]
    public required TerraformValue<string> ServiceUri
    {
        get => new TerraformReference<string>(this, "service_uri");
        set => SetArgument("service_uri", value);
    }

    /// <summary>
    /// The use_common_alert_schema attribute.
    /// </summary>
    [TerraformArgument("use_common_alert_schema")]
    public TerraformValue<bool>? UseCommonAlertSchema
    {
        get => new TerraformReference<bool>(this, "use_common_alert_schema");
        set => SetArgument("use_common_alert_schema", value);
    }

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
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShortName is required")]
    [TerraformArgument("short_name")]
    public required TerraformValue<string> ShortName
    {
        get => new TerraformReference<string>(this, "short_name");
        set => SetArgument("short_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for arm_role_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("arm_role_receiver")]
    public TerraformList<AzurermMonitorActionGroupArmRoleReceiverBlock> ArmRoleReceiver { get; set; } = new();

    /// <summary>
    /// Block for automation_runbook_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("automation_runbook_receiver")]
    public TerraformList<AzurermMonitorActionGroupAutomationRunbookReceiverBlock> AutomationRunbookReceiver { get; set; } = new();

    /// <summary>
    /// Block for azure_app_push_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("azure_app_push_receiver")]
    public TerraformList<AzurermMonitorActionGroupAzureAppPushReceiverBlock> AzureAppPushReceiver { get; set; } = new();

    /// <summary>
    /// Block for azure_function_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("azure_function_receiver")]
    public TerraformList<AzurermMonitorActionGroupAzureFunctionReceiverBlock> AzureFunctionReceiver { get; set; } = new();

    /// <summary>
    /// Block for email_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("email_receiver")]
    public TerraformList<AzurermMonitorActionGroupEmailReceiverBlock> EmailReceiver { get; set; } = new();

    /// <summary>
    /// Block for event_hub_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("event_hub_receiver")]
    public TerraformList<AzurermMonitorActionGroupEventHubReceiverBlock> EventHubReceiver { get; set; } = new();

    /// <summary>
    /// Block for itsm_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("itsm_receiver")]
    public TerraformList<AzurermMonitorActionGroupItsmReceiverBlock> ItsmReceiver { get; set; } = new();

    /// <summary>
    /// Block for logic_app_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("logic_app_receiver")]
    public TerraformList<AzurermMonitorActionGroupLogicAppReceiverBlock> LogicAppReceiver { get; set; } = new();

    /// <summary>
    /// Block for sms_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("sms_receiver")]
    public TerraformList<AzurermMonitorActionGroupSmsReceiverBlock> SmsReceiver { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMonitorActionGroupTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for voice_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("voice_receiver")]
    public TerraformList<AzurermMonitorActionGroupVoiceReceiverBlock> VoiceReceiver { get; set; } = new();

    /// <summary>
    /// Block for webhook_receiver.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("webhook_receiver")]
    public TerraformList<AzurermMonitorActionGroupWebhookReceiverBlock> WebhookReceiver { get; set; } = new();

}
