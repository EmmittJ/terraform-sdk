using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMonitorActionGroupDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The arm_role_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ArmRoleReceiver
        => AsReference("arm_role_receiver");

    /// <summary>
    /// The automation_runbook_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutomationRunbookReceiver
        => AsReference("automation_runbook_receiver");

    /// <summary>
    /// The azure_app_push_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AzureAppPushReceiver
        => AsReference("azure_app_push_receiver");

    /// <summary>
    /// The azure_function_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AzureFunctionReceiver
        => AsReference("azure_function_receiver");

    /// <summary>
    /// The email_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EmailReceiver
        => AsReference("email_receiver");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
        => AsReference("enabled");

    /// <summary>
    /// The event_hub_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EventHubReceiver
        => AsReference("event_hub_receiver");

    /// <summary>
    /// The itsm_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ItsmReceiver
        => AsReference("itsm_receiver");

    /// <summary>
    /// The logic_app_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LogicAppReceiver
        => AsReference("logic_app_receiver");

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    public TerraformValue<string> ShortName
        => AsReference("short_name");

    /// <summary>
    /// The sms_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SmsReceiver
        => AsReference("sms_receiver");

    /// <summary>
    /// The voice_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VoiceReceiver
        => AsReference("voice_receiver");

    /// <summary>
    /// The webhook_receiver attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WebhookReceiver
        => AsReference("webhook_receiver");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorActionGroupDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorActionGroupDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
