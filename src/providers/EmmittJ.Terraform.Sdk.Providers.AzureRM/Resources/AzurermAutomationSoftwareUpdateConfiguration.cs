using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for linux in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationLinuxBlock
{
    /// <summary>
    /// The classifications_included attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClassificationsIncluded is required")]
    [TerraformPropertyName("classifications_included")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? ClassificationsIncluded { get; set; }

    /// <summary>
    /// The excluded_packages attribute.
    /// </summary>
    [TerraformPropertyName("excluded_packages")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ExcludedPackages { get; set; }

    /// <summary>
    /// The included_packages attribute.
    /// </summary>
    [TerraformPropertyName("included_packages")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? IncludedPackages { get; set; }

    /// <summary>
    /// The reboot attribute.
    /// </summary>
    [TerraformPropertyName("reboot")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Reboot { get; set; }

}

/// <summary>
/// Block type for post_task in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationPostTaskBlock
{
    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformPropertyName("source")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Source { get; set; }

}

/// <summary>
/// Block type for pre_task in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationPreTaskBlock
{
    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformPropertyName("source")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Source { get; set; }

}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationScheduleBlock
{
    /// <summary>
    /// The advanced_month_days attribute.
    /// </summary>
    [TerraformPropertyName("advanced_month_days")]
    // Optional argument - user may or may not set a value
    public TerraformList<double>? AdvancedMonthDays { get; set; }

    /// <summary>
    /// The advanced_week_days attribute.
    /// </summary>
    [TerraformPropertyName("advanced_week_days")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? AdvancedWeekDays { get; set; }


    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The expiry_time attribute.
    /// </summary>
    [TerraformPropertyName("expiry_time")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ExpiryTime { get; set; } = default!;

    /// <summary>
    /// The expiry_time_offset_minutes attribute.
    /// </summary>
    [TerraformPropertyName("expiry_time_offset_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ExpiryTimeOffsetMinutes { get; set; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformPropertyName("frequency")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Frequency { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformPropertyName("interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Interval { get; set; }

    /// <summary>
    /// The is_enabled attribute.
    /// </summary>
    [TerraformPropertyName("is_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IsEnabled { get; set; }


    /// <summary>
    /// The next_run attribute.
    /// </summary>
    [TerraformPropertyName("next_run")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NextRun { get; set; } = default!;

    /// <summary>
    /// The next_run_offset_minutes attribute.
    /// </summary>
    [TerraformPropertyName("next_run_offset_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? NextRunOffsetMinutes { get; set; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StartTime { get; set; } = default!;

    /// <summary>
    /// The start_time_offset_minutes attribute.
    /// </summary>
    [TerraformPropertyName("start_time_offset_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? StartTimeOffsetMinutes { get; set; }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformPropertyName("time_zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TimeZone { get; set; }

}

/// <summary>
/// Block type for target in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationTargetBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for windows in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationWindowsBlock
{
    /// <summary>
    /// The classifications_included attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClassificationsIncluded is required")]
    [TerraformPropertyName("classifications_included")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? ClassificationsIncluded { get; set; }

    /// <summary>
    /// The excluded_knowledge_base_numbers attribute.
    /// </summary>
    [TerraformPropertyName("excluded_knowledge_base_numbers")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ExcludedKnowledgeBaseNumbers { get; set; }

    /// <summary>
    /// The included_knowledge_base_numbers attribute.
    /// </summary>
    [TerraformPropertyName("included_knowledge_base_numbers")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? IncludedKnowledgeBaseNumbers { get; set; }

    /// <summary>
    /// The reboot attribute.
    /// </summary>
    [TerraformPropertyName("reboot")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Reboot { get; set; }

}

/// <summary>
/// Manages a azurerm_automation_software_update_configuration resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermAutomationSoftwareUpdateConfiguration : TerraformResource
{
    public AzurermAutomationSoftwareUpdateConfiguration(string name) : base("azurerm_automation_software_update_configuration", name)
    {
    }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    [TerraformPropertyName("automation_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AutomationAccountId { get; set; }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [TerraformPropertyName("duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Duration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The non_azure_computer_names attribute.
    /// </summary>
    [TerraformPropertyName("non_azure_computer_names")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? NonAzureComputerNames { get; set; }

    /// <summary>
    /// The virtual_machine_ids attribute.
    /// </summary>
    [TerraformPropertyName("virtual_machine_ids")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? VirtualMachineIds { get; set; }

    /// <summary>
    /// Block for linux.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Linux block(s) allowed")]
    [TerraformPropertyName("linux")]
    public TerraformList<TerraformBlock<AzurermAutomationSoftwareUpdateConfigurationLinuxBlock>>? Linux { get; set; }

    /// <summary>
    /// Block for post_task.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostTask block(s) allowed")]
    [TerraformPropertyName("post_task")]
    public TerraformList<TerraformBlock<AzurermAutomationSoftwareUpdateConfigurationPostTaskBlock>>? PostTask { get; set; }

    /// <summary>
    /// Block for pre_task.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreTask block(s) allowed")]
    [TerraformPropertyName("pre_task")]
    public TerraformList<TerraformBlock<AzurermAutomationSoftwareUpdateConfigurationPreTaskBlock>>? PreTask { get; set; }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformPropertyName("schedule")]
    public TerraformList<TerraformBlock<AzurermAutomationSoftwareUpdateConfigurationScheduleBlock>>? Schedule { get; set; }

    /// <summary>
    /// Block for target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    [TerraformPropertyName("target")]
    public TerraformList<TerraformBlock<AzurermAutomationSoftwareUpdateConfigurationTargetBlock>>? Target { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAutomationSoftwareUpdateConfigurationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for windows.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Windows block(s) allowed")]
    [TerraformPropertyName("windows")]
    public TerraformList<TerraformBlock<AzurermAutomationSoftwareUpdateConfigurationWindowsBlock>>? Windows { get; set; }

    /// <summary>
    /// The error_code attribute.
    /// </summary>
    [TerraformPropertyName("error_code")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ErrorCode => new TerraformReference(this, "error_code");

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    [TerraformPropertyName("error_message")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ErrorMessage => new TerraformReference(this, "error_message");

}
