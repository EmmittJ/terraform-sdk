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
/// Block type for notification_settings in .
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
    [TerraformArgument("email")]
    public TerraformValue<string>? Email
    {
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformArgument("enabled")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The time_in_minutes attribute.
    /// </summary>
    [TerraformArgument("time_in_minutes")]
    public TerraformValue<double>? TimeInMinutes
    {
        get => new TerraformReference<double>(this, "time_in_minutes");
        set => SetArgument("time_in_minutes", value);
    }

    /// <summary>
    /// The webhook_url attribute.
    /// </summary>
    [TerraformArgument("webhook_url")]
    public TerraformValue<string>? WebhookUrl
    {
        get => new TerraformReference<string>(this, "webhook_url");
        set => SetArgument("webhook_url", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
/// Manages a azurerm_dev_test_global_vm_shutdown_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDevTestGlobalVmShutdownSchedule : TerraformResource
{
    public AzurermDevTestGlobalVmShutdownSchedule(string name) : base("azurerm_dev_test_global_vm_shutdown_schedule", name)
    {
    }

    /// <summary>
    /// The daily_recurrence_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DailyRecurrenceTime is required")]
    [TerraformArgument("daily_recurrence_time")]
    public required TerraformValue<string> DailyRecurrenceTime
    {
        get => new TerraformReference<string>(this, "daily_recurrence_time");
        set => SetArgument("daily_recurrence_time", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The timezone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timezone is required")]
    [TerraformArgument("timezone")]
    public required TerraformValue<string> Timezone
    {
        get => new TerraformReference<string>(this, "timezone");
        set => SetArgument("timezone", value);
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    [TerraformArgument("virtual_machine_id")]
    public required TerraformValue<string> VirtualMachineId
    {
        get => new TerraformReference<string>(this, "virtual_machine_id");
        set => SetArgument("virtual_machine_id", value);
    }

    /// <summary>
    /// Block for notification_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NotificationSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationSettings block(s) allowed")]
    [TerraformArgument("notification_settings")]
    public required TerraformList<AzurermDevTestGlobalVmShutdownScheduleNotificationSettingsBlock> NotificationSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDevTestGlobalVmShutdownScheduleTimeoutsBlock Timeouts { get; set; } = new();

}
