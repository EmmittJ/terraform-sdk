using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for linux in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationLinuxBlock : TerraformBlock
{
    /// <summary>
    /// The classifications_included attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClassificationsIncluded is required")]
    public List<TerraformProperty<string>>? ClassificationsIncluded
    {
        set => SetProperty("classifications_included", value);
    }

    /// <summary>
    /// The excluded_packages attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ExcludedPackages
    {
        set => SetProperty("excluded_packages", value);
    }

    /// <summary>
    /// The included_packages attribute.
    /// </summary>
    public List<TerraformProperty<string>>? IncludedPackages
    {
        set => SetProperty("included_packages", value);
    }

    /// <summary>
    /// The reboot attribute.
    /// </summary>
    public TerraformProperty<string>? Reboot
    {
        set => SetProperty("reboot", value);
    }

}

/// <summary>
/// Block type for post_task in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationPostTaskBlock : TerraformBlock
{
    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformProperty<string>? Source
    {
        set => SetProperty("source", value);
    }

}

/// <summary>
/// Block type for pre_task in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationPreTaskBlock : TerraformBlock
{
    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformProperty<string>? Source
    {
        set => SetProperty("source", value);
    }

}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationScheduleBlock : TerraformBlock
{
    /// <summary>
    /// The advanced_month_days attribute.
    /// </summary>
    public List<TerraformProperty<double>>? AdvancedMonthDays
    {
        set => SetProperty("advanced_month_days", value);
    }

    /// <summary>
    /// The advanced_week_days attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AdvancedWeekDays
    {
        set => SetProperty("advanced_week_days", value);
    }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformProperty<string>? CreationTime
    {
        set => SetProperty("creation_time", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The expiry_time attribute.
    /// </summary>
    public TerraformProperty<string>? ExpiryTime
    {
        set => SetProperty("expiry_time", value);
    }

    /// <summary>
    /// The expiry_time_offset_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? ExpiryTimeOffsetMinutes
    {
        set => SetProperty("expiry_time_offset_minutes", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformProperty<string> Frequency
    {
        set => SetProperty("frequency", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformProperty<double>? Interval
    {
        set => SetProperty("interval", value);
    }

    /// <summary>
    /// The is_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IsEnabled
    {
        set => SetProperty("is_enabled", value);
    }

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformProperty<string>? LastModifiedTime
    {
        set => SetProperty("last_modified_time", value);
    }

    /// <summary>
    /// The next_run attribute.
    /// </summary>
    public TerraformProperty<string>? NextRun
    {
        set => SetProperty("next_run", value);
    }

    /// <summary>
    /// The next_run_offset_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? NextRunOffsetMinutes
    {
        set => SetProperty("next_run_offset_minutes", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformProperty<string>? StartTime
    {
        set => SetProperty("start_time", value);
    }

    /// <summary>
    /// The start_time_offset_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? StartTimeOffsetMinutes
    {
        set => SetProperty("start_time_offset_minutes", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformProperty<string>? TimeZone
    {
        set => SetProperty("time_zone", value);
    }

}

/// <summary>
/// Block type for target in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationTargetBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for windows in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationWindowsBlock : TerraformBlock
{
    /// <summary>
    /// The classifications_included attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClassificationsIncluded is required")]
    public List<TerraformProperty<string>>? ClassificationsIncluded
    {
        set => SetProperty("classifications_included", value);
    }

    /// <summary>
    /// The excluded_knowledge_base_numbers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ExcludedKnowledgeBaseNumbers
    {
        set => SetProperty("excluded_knowledge_base_numbers", value);
    }

    /// <summary>
    /// The included_knowledge_base_numbers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? IncludedKnowledgeBaseNumbers
    {
        set => SetProperty("included_knowledge_base_numbers", value);
    }

    /// <summary>
    /// The reboot attribute.
    /// </summary>
    public TerraformProperty<string>? Reboot
    {
        set => SetProperty("reboot", value);
    }

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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("error_code");
        SetOutput("error_message");
        SetOutput("automation_account_id");
        SetOutput("duration");
        SetOutput("id");
        SetOutput("name");
        SetOutput("non_azure_computer_names");
        SetOutput("virtual_machine_ids");
    }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    public required TerraformProperty<string> AutomationAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("automation_account_id");
        set => SetProperty("automation_account_id", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformProperty<string> Duration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("duration");
        set => SetProperty("duration", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The non_azure_computer_names attribute.
    /// </summary>
    public List<TerraformProperty<string>> NonAzureComputerNames
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("non_azure_computer_names");
        set => SetProperty("non_azure_computer_names", value);
    }

    /// <summary>
    /// The virtual_machine_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>> VirtualMachineIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("virtual_machine_ids");
        set => SetProperty("virtual_machine_ids", value);
    }

    /// <summary>
    /// Block for linux.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Linux block(s) allowed")]
    public List<AzurermAutomationSoftwareUpdateConfigurationLinuxBlock>? Linux
    {
        set => SetProperty("linux", value);
    }

    /// <summary>
    /// Block for post_task.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostTask block(s) allowed")]
    public List<AzurermAutomationSoftwareUpdateConfigurationPostTaskBlock>? PostTask
    {
        set => SetProperty("post_task", value);
    }

    /// <summary>
    /// Block for pre_task.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreTask block(s) allowed")]
    public List<AzurermAutomationSoftwareUpdateConfigurationPreTaskBlock>? PreTask
    {
        set => SetProperty("pre_task", value);
    }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public List<AzurermAutomationSoftwareUpdateConfigurationScheduleBlock>? Schedule
    {
        set => SetProperty("schedule", value);
    }

    /// <summary>
    /// Block for target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public List<AzurermAutomationSoftwareUpdateConfigurationTargetBlock>? Target
    {
        set => SetProperty("target", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAutomationSoftwareUpdateConfigurationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for windows.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Windows block(s) allowed")]
    public List<AzurermAutomationSoftwareUpdateConfigurationWindowsBlock>? Windows
    {
        set => SetProperty("windows", value);
    }

    /// <summary>
    /// The error_code attribute.
    /// </summary>
    public TerraformExpression ErrorCode => this["error_code"];

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    public TerraformExpression ErrorMessage => this["error_message"];

}
