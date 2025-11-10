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
        get => GetProperty<List<TerraformProperty<string>>>("classifications_included");
        set => WithProperty("classifications_included", value);
    }

    /// <summary>
    /// The excluded_packages attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ExcludedPackages
    {
        get => GetProperty<List<TerraformProperty<string>>>("excluded_packages");
        set => WithProperty("excluded_packages", value);
    }

    /// <summary>
    /// The included_packages attribute.
    /// </summary>
    public List<TerraformProperty<string>>? IncludedPackages
    {
        get => GetProperty<List<TerraformProperty<string>>>("included_packages");
        set => WithProperty("included_packages", value);
    }

    /// <summary>
    /// The reboot attribute.
    /// </summary>
    public TerraformProperty<string>? Reboot
    {
        get => GetProperty<TerraformProperty<string>>("reboot");
        set => WithProperty("reboot", value);
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
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => WithProperty("parameters", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformProperty<string>? Source
    {
        get => GetProperty<TerraformProperty<string>>("source");
        set => WithProperty("source", value);
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
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => WithProperty("parameters", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformProperty<string>? Source
    {
        get => GetProperty<TerraformProperty<string>>("source");
        set => WithProperty("source", value);
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
        get => GetProperty<List<TerraformProperty<double>>>("advanced_month_days");
        set => WithProperty("advanced_month_days", value);
    }

    /// <summary>
    /// The advanced_week_days attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AdvancedWeekDays
    {
        get => GetProperty<List<TerraformProperty<string>>>("advanced_week_days");
        set => WithProperty("advanced_week_days", value);
    }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformProperty<string>? CreationTime
    {
        get => GetProperty<TerraformProperty<string>>("creation_time");
        set => WithProperty("creation_time", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The expiry_time attribute.
    /// </summary>
    public TerraformProperty<string>? ExpiryTime
    {
        get => GetProperty<TerraformProperty<string>>("expiry_time");
        set => WithProperty("expiry_time", value);
    }

    /// <summary>
    /// The expiry_time_offset_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? ExpiryTimeOffsetMinutes
    {
        get => GetProperty<TerraformProperty<double>>("expiry_time_offset_minutes");
        set => WithProperty("expiry_time_offset_minutes", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformProperty<string> Frequency
    {
        get => GetRequiredProperty<TerraformProperty<string>>("frequency");
        set => WithProperty("frequency", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformProperty<double>? Interval
    {
        get => GetProperty<TerraformProperty<double>>("interval");
        set => WithProperty("interval", value);
    }

    /// <summary>
    /// The is_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("is_enabled");
        set => WithProperty("is_enabled", value);
    }

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformProperty<string>? LastModifiedTime
    {
        get => GetProperty<TerraformProperty<string>>("last_modified_time");
        set => WithProperty("last_modified_time", value);
    }

    /// <summary>
    /// The next_run attribute.
    /// </summary>
    public TerraformProperty<string>? NextRun
    {
        get => GetProperty<TerraformProperty<string>>("next_run");
        set => WithProperty("next_run", value);
    }

    /// <summary>
    /// The next_run_offset_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? NextRunOffsetMinutes
    {
        get => GetProperty<TerraformProperty<double>>("next_run_offset_minutes");
        set => WithProperty("next_run_offset_minutes", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformProperty<string>? StartTime
    {
        get => GetProperty<TerraformProperty<string>>("start_time");
        set => WithProperty("start_time", value);
    }

    /// <summary>
    /// The start_time_offset_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? StartTimeOffsetMinutes
    {
        get => GetProperty<TerraformProperty<double>>("start_time_offset_minutes");
        set => WithProperty("start_time_offset_minutes", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformProperty<string>? TimeZone
    {
        get => GetProperty<TerraformProperty<string>>("time_zone");
        set => WithProperty("time_zone", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        get => GetProperty<List<TerraformProperty<string>>>("classifications_included");
        set => WithProperty("classifications_included", value);
    }

    /// <summary>
    /// The excluded_knowledge_base_numbers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ExcludedKnowledgeBaseNumbers
    {
        get => GetProperty<List<TerraformProperty<string>>>("excluded_knowledge_base_numbers");
        set => WithProperty("excluded_knowledge_base_numbers", value);
    }

    /// <summary>
    /// The included_knowledge_base_numbers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? IncludedKnowledgeBaseNumbers
    {
        get => GetProperty<List<TerraformProperty<string>>>("included_knowledge_base_numbers");
        set => WithProperty("included_knowledge_base_numbers", value);
    }

    /// <summary>
    /// The reboot attribute.
    /// </summary>
    public TerraformProperty<string>? Reboot
    {
        get => GetProperty<TerraformProperty<string>>("reboot");
        set => WithProperty("reboot", value);
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
        this.WithOutput("error_code");
        this.WithOutput("error_message");
    }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    public required TerraformProperty<string> AutomationAccountId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("automation_account_id");
        set => this.WithProperty("automation_account_id", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformProperty<string>? Duration
    {
        get => GetProperty<TerraformProperty<string>>("duration");
        set => this.WithProperty("duration", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The non_azure_computer_names attribute.
    /// </summary>
    public List<TerraformProperty<string>>? NonAzureComputerNames
    {
        get => GetProperty<List<TerraformProperty<string>>>("non_azure_computer_names");
        set => this.WithProperty("non_azure_computer_names", value);
    }

    /// <summary>
    /// The virtual_machine_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? VirtualMachineIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("virtual_machine_ids");
        set => this.WithProperty("virtual_machine_ids", value);
    }

    /// <summary>
    /// Block for linux.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Linux block(s) allowed")]
    public List<AzurermAutomationSoftwareUpdateConfigurationLinuxBlock>? Linux
    {
        get => GetProperty<List<AzurermAutomationSoftwareUpdateConfigurationLinuxBlock>>("linux");
        set => this.WithProperty("linux", value);
    }

    /// <summary>
    /// Block for post_task.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostTask block(s) allowed")]
    public List<AzurermAutomationSoftwareUpdateConfigurationPostTaskBlock>? PostTask
    {
        get => GetProperty<List<AzurermAutomationSoftwareUpdateConfigurationPostTaskBlock>>("post_task");
        set => this.WithProperty("post_task", value);
    }

    /// <summary>
    /// Block for pre_task.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreTask block(s) allowed")]
    public List<AzurermAutomationSoftwareUpdateConfigurationPreTaskBlock>? PreTask
    {
        get => GetProperty<List<AzurermAutomationSoftwareUpdateConfigurationPreTaskBlock>>("pre_task");
        set => this.WithProperty("pre_task", value);
    }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public List<AzurermAutomationSoftwareUpdateConfigurationScheduleBlock>? Schedule
    {
        get => GetProperty<List<AzurermAutomationSoftwareUpdateConfigurationScheduleBlock>>("schedule");
        set => this.WithProperty("schedule", value);
    }

    /// <summary>
    /// Block for target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public List<AzurermAutomationSoftwareUpdateConfigurationTargetBlock>? Target
    {
        get => GetProperty<List<AzurermAutomationSoftwareUpdateConfigurationTargetBlock>>("target");
        set => this.WithProperty("target", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAutomationSoftwareUpdateConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAutomationSoftwareUpdateConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for windows.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Windows block(s) allowed")]
    public List<AzurermAutomationSoftwareUpdateConfigurationWindowsBlock>? Windows
    {
        get => GetProperty<List<AzurermAutomationSoftwareUpdateConfigurationWindowsBlock>>("windows");
        set => this.WithProperty("windows", value);
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
