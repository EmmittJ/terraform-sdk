using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for linux in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationLinuxBlock : ITerraformBlock
{
    /// <summary>
    /// The classifications_included attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClassificationsIncluded is required")]
    [TerraformPropertyName("classifications_included")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? ClassificationsIncluded { get; set; }

    /// <summary>
    /// The excluded_packages attribute.
    /// </summary>
    [TerraformPropertyName("excluded_packages")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ExcludedPackages { get; set; }

    /// <summary>
    /// The included_packages attribute.
    /// </summary>
    [TerraformPropertyName("included_packages")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? IncludedPackages { get; set; }

    /// <summary>
    /// The reboot attribute.
    /// </summary>
    [TerraformPropertyName("reboot")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Reboot { get; set; }

}

/// <summary>
/// Block type for post_task in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationPostTaskBlock : ITerraformBlock
{
    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Parameters { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformPropertyName("source")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Source { get; set; }

}

/// <summary>
/// Block type for pre_task in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationPreTaskBlock : ITerraformBlock
{
    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Parameters { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformPropertyName("source")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Source { get; set; }

}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationScheduleBlock : ITerraformBlock
{
    /// <summary>
    /// The advanced_month_days attribute.
    /// </summary>
    [TerraformPropertyName("advanced_month_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<double>>>? AdvancedMonthDays { get; set; }

    /// <summary>
    /// The advanced_week_days attribute.
    /// </summary>
    [TerraformPropertyName("advanced_week_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AdvancedWeekDays { get; set; }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "creation_time");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The expiry_time attribute.
    /// </summary>
    [TerraformPropertyName("expiry_time")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ExpiryTime { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "expiry_time");

    /// <summary>
    /// The expiry_time_offset_minutes attribute.
    /// </summary>
    [TerraformPropertyName("expiry_time_offset_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ExpiryTimeOffsetMinutes { get; set; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformPropertyName("frequency")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Frequency { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformPropertyName("interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Interval { get; set; }

    /// <summary>
    /// The is_enabled attribute.
    /// </summary>
    [TerraformPropertyName("is_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsEnabled { get; set; }

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModifiedTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "last_modified_time");

    /// <summary>
    /// The next_run attribute.
    /// </summary>
    [TerraformPropertyName("next_run")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NextRun { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "next_run");

    /// <summary>
    /// The next_run_offset_minutes attribute.
    /// </summary>
    [TerraformPropertyName("next_run_offset_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? NextRunOffsetMinutes { get; set; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StartTime { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "start_time");

    /// <summary>
    /// The start_time_offset_minutes attribute.
    /// </summary>
    [TerraformPropertyName("start_time_offset_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? StartTimeOffsetMinutes { get; set; }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformPropertyName("time_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TimeZone { get; set; }

}

/// <summary>
/// Block type for target in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationTargetBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for windows in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationWindowsBlock : ITerraformBlock
{
    /// <summary>
    /// The classifications_included attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClassificationsIncluded is required")]
    [TerraformPropertyName("classifications_included")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? ClassificationsIncluded { get; set; }

    /// <summary>
    /// The excluded_knowledge_base_numbers attribute.
    /// </summary>
    [TerraformPropertyName("excluded_knowledge_base_numbers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ExcludedKnowledgeBaseNumbers { get; set; }

    /// <summary>
    /// The included_knowledge_base_numbers attribute.
    /// </summary>
    [TerraformPropertyName("included_knowledge_base_numbers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? IncludedKnowledgeBaseNumbers { get; set; }

    /// <summary>
    /// The reboot attribute.
    /// </summary>
    [TerraformPropertyName("reboot")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Reboot { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> AutomationAccountId { get; set; }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [TerraformPropertyName("duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Duration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The non_azure_computer_names attribute.
    /// </summary>
    [TerraformPropertyName("non_azure_computer_names")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? NonAzureComputerNames { get; set; }

    /// <summary>
    /// The virtual_machine_ids attribute.
    /// </summary>
    [TerraformPropertyName("virtual_machine_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? VirtualMachineIds { get; set; }

    /// <summary>
    /// Block for linux.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Linux block(s) allowed")]
    [TerraformPropertyName("linux")]
    public TerraformList<TerraformBlock<AzurermAutomationSoftwareUpdateConfigurationLinuxBlock>>? Linux { get; set; } = new();

    /// <summary>
    /// Block for post_task.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostTask block(s) allowed")]
    [TerraformPropertyName("post_task")]
    public TerraformList<TerraformBlock<AzurermAutomationSoftwareUpdateConfigurationPostTaskBlock>>? PostTask { get; set; } = new();

    /// <summary>
    /// Block for pre_task.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreTask block(s) allowed")]
    [TerraformPropertyName("pre_task")]
    public TerraformList<TerraformBlock<AzurermAutomationSoftwareUpdateConfigurationPreTaskBlock>>? PreTask { get; set; } = new();

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformPropertyName("schedule")]
    public TerraformList<TerraformBlock<AzurermAutomationSoftwareUpdateConfigurationScheduleBlock>>? Schedule { get; set; } = new();

    /// <summary>
    /// Block for target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    [TerraformPropertyName("target")]
    public TerraformList<TerraformBlock<AzurermAutomationSoftwareUpdateConfigurationTargetBlock>>? Target { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAutomationSoftwareUpdateConfigurationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for windows.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Windows block(s) allowed")]
    [TerraformPropertyName("windows")]
    public TerraformList<TerraformBlock<AzurermAutomationSoftwareUpdateConfigurationWindowsBlock>>? Windows { get; set; } = new();

    /// <summary>
    /// The error_code attribute.
    /// </summary>
    [TerraformPropertyName("error_code")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ErrorCode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "error_code");

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    [TerraformPropertyName("error_message")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ErrorMessage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "error_message");

}
