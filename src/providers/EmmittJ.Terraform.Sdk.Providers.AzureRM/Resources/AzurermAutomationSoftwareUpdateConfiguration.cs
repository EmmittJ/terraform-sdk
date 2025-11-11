using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for linux in .
/// Nesting mode: list
/// </summary>
public partial class AzurermAutomationSoftwareUpdateConfigurationLinuxBlock : TerraformBlockBase
{
    /// <summary>
    /// The classifications_included attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClassificationsIncluded is required")]
    [TerraformProperty("classifications_included")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? ClassificationsIncluded { get; set; }

    /// <summary>
    /// The excluded_packages attribute.
    /// </summary>
    [TerraformProperty("excluded_packages")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ExcludedPackages { get; set; }

    /// <summary>
    /// The included_packages attribute.
    /// </summary>
    [TerraformProperty("included_packages")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? IncludedPackages { get; set; }

    /// <summary>
    /// The reboot attribute.
    /// </summary>
    [TerraformProperty("reboot")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Reboot { get; set; }

}

/// <summary>
/// Block type for post_task in .
/// Nesting mode: list
/// </summary>
public partial class AzurermAutomationSoftwareUpdateConfigurationPostTaskBlock : TerraformBlockBase
{
    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformProperty("source")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Source { get; set; }

}

/// <summary>
/// Block type for pre_task in .
/// Nesting mode: list
/// </summary>
public partial class AzurermAutomationSoftwareUpdateConfigurationPreTaskBlock : TerraformBlockBase
{
    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformProperty("source")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Source { get; set; }

}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermAutomationSoftwareUpdateConfigurationScheduleBlock : TerraformBlockBase
{
    /// <summary>
    /// The advanced_month_days attribute.
    /// </summary>
    [TerraformProperty("advanced_month_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<double>? AdvancedMonthDays { get; set; }

    /// <summary>
    /// The advanced_week_days attribute.
    /// </summary>
    [TerraformProperty("advanced_week_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AdvancedWeekDays { get; set; }


    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The expiry_time attribute.
    /// </summary>
    [TerraformProperty("expiry_time")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ExpiryTime { get; set; }

    /// <summary>
    /// The expiry_time_offset_minutes attribute.
    /// </summary>
    [TerraformProperty("expiry_time_offset_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ExpiryTimeOffsetMinutes { get; set; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformProperty("frequency")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Frequency { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformProperty("interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Interval { get; set; }

    /// <summary>
    /// The is_enabled attribute.
    /// </summary>
    [TerraformProperty("is_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IsEnabled { get; set; }


    /// <summary>
    /// The next_run attribute.
    /// </summary>
    [TerraformProperty("next_run")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NextRun { get; set; }

    /// <summary>
    /// The next_run_offset_minutes attribute.
    /// </summary>
    [TerraformProperty("next_run_offset_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? NextRunOffsetMinutes { get; set; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformProperty("start_time")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StartTime { get; set; }

    /// <summary>
    /// The start_time_offset_minutes attribute.
    /// </summary>
    [TerraformProperty("start_time_offset_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? StartTimeOffsetMinutes { get; set; }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformProperty("time_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TimeZone { get; set; }

}

/// <summary>
/// Block type for target in .
/// Nesting mode: list
/// </summary>
public partial class AzurermAutomationSoftwareUpdateConfigurationTargetBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAutomationSoftwareUpdateConfigurationTimeoutsBlock : TerraformBlockBase
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
/// Block type for windows in .
/// Nesting mode: list
/// </summary>
public partial class AzurermAutomationSoftwareUpdateConfigurationWindowsBlock : TerraformBlockBase
{
    /// <summary>
    /// The classifications_included attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClassificationsIncluded is required")]
    [TerraformProperty("classifications_included")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? ClassificationsIncluded { get; set; }

    /// <summary>
    /// The excluded_knowledge_base_numbers attribute.
    /// </summary>
    [TerraformProperty("excluded_knowledge_base_numbers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ExcludedKnowledgeBaseNumbers { get; set; }

    /// <summary>
    /// The included_knowledge_base_numbers attribute.
    /// </summary>
    [TerraformProperty("included_knowledge_base_numbers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? IncludedKnowledgeBaseNumbers { get; set; }

    /// <summary>
    /// The reboot attribute.
    /// </summary>
    [TerraformProperty("reboot")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Reboot { get; set; }

}

/// <summary>
/// Manages a azurerm_automation_software_update_configuration resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermAutomationSoftwareUpdateConfiguration : TerraformResource
{
    public AzurermAutomationSoftwareUpdateConfiguration(string name) : base("azurerm_automation_software_update_configuration", name)
    {
    }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    [TerraformProperty("automation_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AutomationAccountId { get; set; }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [TerraformProperty("duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Duration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The non_azure_computer_names attribute.
    /// </summary>
    [TerraformProperty("non_azure_computer_names")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? NonAzureComputerNames { get; set; }

    /// <summary>
    /// The virtual_machine_ids attribute.
    /// </summary>
    [TerraformProperty("virtual_machine_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? VirtualMachineIds { get; set; }

    /// <summary>
    /// Block for linux.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Linux block(s) allowed")]
    [TerraformProperty("linux")]
    public partial TerraformList<TerraformBlock<AzurermAutomationSoftwareUpdateConfigurationLinuxBlock>>? Linux { get; set; }

    /// <summary>
    /// Block for post_task.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostTask block(s) allowed")]
    [TerraformProperty("post_task")]
    public partial TerraformList<TerraformBlock<AzurermAutomationSoftwareUpdateConfigurationPostTaskBlock>>? PostTask { get; set; }

    /// <summary>
    /// Block for pre_task.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreTask block(s) allowed")]
    [TerraformProperty("pre_task")]
    public partial TerraformList<TerraformBlock<AzurermAutomationSoftwareUpdateConfigurationPreTaskBlock>>? PreTask { get; set; }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformProperty("schedule")]
    public partial TerraformList<TerraformBlock<AzurermAutomationSoftwareUpdateConfigurationScheduleBlock>>? Schedule { get; set; }

    /// <summary>
    /// Block for target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    [TerraformProperty("target")]
    public partial TerraformList<TerraformBlock<AzurermAutomationSoftwareUpdateConfigurationTargetBlock>>? Target { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermAutomationSoftwareUpdateConfigurationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for windows.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Windows block(s) allowed")]
    [TerraformProperty("windows")]
    public partial TerraformList<TerraformBlock<AzurermAutomationSoftwareUpdateConfigurationWindowsBlock>>? Windows { get; set; }

    /// <summary>
    /// The error_code attribute.
    /// </summary>
    [TerraformProperty("error_code")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ErrorCode { get; }

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    [TerraformProperty("error_message")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ErrorMessage { get; }

}
