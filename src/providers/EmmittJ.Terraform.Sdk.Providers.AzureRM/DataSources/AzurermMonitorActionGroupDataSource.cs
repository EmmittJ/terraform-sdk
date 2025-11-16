using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_monitor_action_group Terraform data source.
/// Retrieves information about a azurerm_monitor_action_group.
/// </summary>
public partial class AzurermMonitorActionGroupDataSource(string name) : TerraformDataSource("azurerm_monitor_action_group", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The arm_role_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ArmRoleReceiver
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "arm_role_receiver").ResolveNodes(ctx));
    }

    /// <summary>
    /// The automation_runbook_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutomationRunbookReceiver
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "automation_runbook_receiver").ResolveNodes(ctx));
    }

    /// <summary>
    /// The azure_app_push_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AzureAppPushReceiver
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "azure_app_push_receiver").ResolveNodes(ctx));
    }

    /// <summary>
    /// The azure_function_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AzureFunctionReceiver
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "azure_function_receiver").ResolveNodes(ctx));
    }

    /// <summary>
    /// The email_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EmailReceiver
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "email_receiver").ResolveNodes(ctx));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
    }

    /// <summary>
    /// The event_hub_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EventHubReceiver
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "event_hub_receiver").ResolveNodes(ctx));
    }

    /// <summary>
    /// The itsm_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ItsmReceiver
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "itsm_receiver").ResolveNodes(ctx));
    }

    /// <summary>
    /// The logic_app_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LogicAppReceiver
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "logic_app_receiver").ResolveNodes(ctx));
    }

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    public TerraformValue<string> ShortName
    {
        get => new TerraformReference<string>(this, "short_name");
    }

    /// <summary>
    /// The sms_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SmsReceiver
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "sms_receiver").ResolveNodes(ctx));
    }

    /// <summary>
    /// The voice_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VoiceReceiver
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "voice_receiver").ResolveNodes(ctx));
    }

    /// <summary>
    /// The webhook_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WebhookReceiver
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "webhook_receiver").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorActionGroupDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorActionGroupDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
