using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for notification_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDevTestGlobalVmShutdownScheduleNotificationSettingsBlock() : TerraformBlock("notification_settings")
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Email { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The time_in_minutes attribute.
    /// </summary>
    [TerraformProperty("time_in_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TimeInMinutes { get; set; }

    /// <summary>
    /// The webhook_url attribute.
    /// </summary>
    [TerraformProperty("webhook_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WebhookUrl { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDevTestGlobalVmShutdownScheduleTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_dev_test_global_vm_shutdown_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermDevTestGlobalVmShutdownSchedule : TerraformResource
{
    public AzurermDevTestGlobalVmShutdownSchedule(string name) : base("azurerm_dev_test_global_vm_shutdown_schedule", name)
    {
    }

    /// <summary>
    /// The daily_recurrence_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DailyRecurrenceTime is required")]
    [TerraformProperty("daily_recurrence_time")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DailyRecurrenceTime { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timezone is required")]
    [TerraformProperty("timezone")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Timezone { get; set; }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    [TerraformProperty("virtual_machine_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VirtualMachineId { get; set; }

    /// <summary>
    /// Block for notification_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NotificationSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationSettings block(s) allowed")]
    [TerraformProperty("notification_settings")]
    public required TerraformList<AzurermDevTestGlobalVmShutdownScheduleNotificationSettingsBlock> NotificationSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDevTestGlobalVmShutdownScheduleTimeoutsBlock Timeouts { get; set; } = new();

}
