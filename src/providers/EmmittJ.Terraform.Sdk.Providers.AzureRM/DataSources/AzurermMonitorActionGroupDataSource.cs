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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorActionGroupDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMonitorActionGroupDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arm_role_receiver attribute.
    /// </summary>
    [TerraformArgument("arm_role_receiver")]
    public TerraformList<object> ArmRoleReceiver
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "arm_role_receiver").ResolveNodes(ctx));
    }

    /// <summary>
    /// The automation_runbook_receiver attribute.
    /// </summary>
    [TerraformArgument("automation_runbook_receiver")]
    public TerraformList<object> AutomationRunbookReceiver
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "automation_runbook_receiver").ResolveNodes(ctx));
    }

    /// <summary>
    /// The azure_app_push_receiver attribute.
    /// </summary>
    [TerraformArgument("azure_app_push_receiver")]
    public TerraformList<object> AzureAppPushReceiver
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "azure_app_push_receiver").ResolveNodes(ctx));
    }

    /// <summary>
    /// The azure_function_receiver attribute.
    /// </summary>
    [TerraformArgument("azure_function_receiver")]
    public TerraformList<object> AzureFunctionReceiver
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "azure_function_receiver").ResolveNodes(ctx));
    }

    /// <summary>
    /// The email_receiver attribute.
    /// </summary>
    [TerraformArgument("email_receiver")]
    public TerraformList<object> EmailReceiver
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "email_receiver").ResolveNodes(ctx));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
    }

    /// <summary>
    /// The event_hub_receiver attribute.
    /// </summary>
    [TerraformArgument("event_hub_receiver")]
    public TerraformList<object> EventHubReceiver
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "event_hub_receiver").ResolveNodes(ctx));
    }

    /// <summary>
    /// The itsm_receiver attribute.
    /// </summary>
    [TerraformArgument("itsm_receiver")]
    public TerraformList<object> ItsmReceiver
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "itsm_receiver").ResolveNodes(ctx));
    }

    /// <summary>
    /// The logic_app_receiver attribute.
    /// </summary>
    [TerraformArgument("logic_app_receiver")]
    public TerraformList<object> LogicAppReceiver
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "logic_app_receiver").ResolveNodes(ctx));
    }

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    [TerraformArgument("short_name")]
    public TerraformValue<string> ShortName
    {
        get => new TerraformReference<string>(this, "short_name");
    }

    /// <summary>
    /// The sms_receiver attribute.
    /// </summary>
    [TerraformArgument("sms_receiver")]
    public TerraformList<object> SmsReceiver
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "sms_receiver").ResolveNodes(ctx));
    }

    /// <summary>
    /// The voice_receiver attribute.
    /// </summary>
    [TerraformArgument("voice_receiver")]
    public TerraformList<object> VoiceReceiver
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "voice_receiver").ResolveNodes(ctx));
    }

    /// <summary>
    /// The webhook_receiver attribute.
    /// </summary>
    [TerraformArgument("webhook_receiver")]
    public TerraformList<object> WebhookReceiver
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "webhook_receiver").ResolveNodes(ctx));
    }

}
