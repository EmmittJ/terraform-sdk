using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for notification_settings in AzurermDevTestGlobalVmShutdownSchedule.
/// Nesting mode: list
/// </summary>
public class AzurermDevTestGlobalVmShutdownScheduleNotificationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_settings";

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string>? Email
    {
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The time_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? TimeInMinutes
    {
        get => new TerraformReference<double>(this, "time_in_minutes");
        set => SetArgument("time_in_minutes", value);
    }

    /// <summary>
    /// The webhook_url attribute.
    /// </summary>
    public TerraformValue<string>? WebhookUrl
    {
        get => new TerraformReference<string>(this, "webhook_url");
        set => SetArgument("webhook_url", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDevTestGlobalVmShutdownSchedule.
/// Nesting mode: single
/// </summary>
public class AzurermDevTestGlobalVmShutdownScheduleTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_dev_test_global_vm_shutdown_schedule Terraform resource.
/// Manages a azurerm_dev_test_global_vm_shutdown_schedule resource.
/// </summary>
public partial class AzurermDevTestGlobalVmShutdownSchedule(string name) : TerraformResource("azurerm_dev_test_global_vm_shutdown_schedule", name)
{
    /// <summary>
    /// The daily_recurrence_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DailyRecurrenceTime is required")]
    public required TerraformValue<string> DailyRecurrenceTime
    {
        get => new TerraformReference<string>(this, "daily_recurrence_time");
        set => SetArgument("daily_recurrence_time", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timezone is required")]
    public required TerraformValue<string> Timezone
    {
        get => new TerraformReference<string>(this, "timezone");
        set => SetArgument("timezone", value);
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    public required TerraformValue<string> VirtualMachineId
    {
        get => new TerraformReference<string>(this, "virtual_machine_id");
        set => SetArgument("virtual_machine_id", value);
    }

    /// <summary>
    /// NotificationSettings block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NotificationSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationSettings block(s) allowed")]
    public required TerraformList<AzurermDevTestGlobalVmShutdownScheduleNotificationSettingsBlock> NotificationSettings
    {
        get => GetRequiredArgument<TerraformList<AzurermDevTestGlobalVmShutdownScheduleNotificationSettingsBlock>>("notification_settings");
        set => SetArgument("notification_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDevTestGlobalVmShutdownScheduleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDevTestGlobalVmShutdownScheduleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
