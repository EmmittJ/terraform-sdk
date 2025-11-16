using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for linux in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationLinuxBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linux";

    /// <summary>
    /// The classifications_included attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClassificationsIncluded is required")]
    public TerraformList<string>? ClassificationsIncluded
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "classifications_included").ResolveNodes(ctx));
        set => SetArgument("classifications_included", value);
    }

    /// <summary>
    /// The excluded_packages attribute.
    /// </summary>
    public TerraformList<string>? ExcludedPackages
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excluded_packages").ResolveNodes(ctx));
        set => SetArgument("excluded_packages", value);
    }

    /// <summary>
    /// The included_packages attribute.
    /// </summary>
    public TerraformList<string>? IncludedPackages
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "included_packages").ResolveNodes(ctx));
        set => SetArgument("included_packages", value);
    }

    /// <summary>
    /// The reboot attribute.
    /// </summary>
    public TerraformValue<string>? Reboot
    {
        get => new TerraformReference<string>(this, "reboot");
        set => SetArgument("reboot", value);
    }

}

/// <summary>
/// Block type for post_task in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationPostTaskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "post_task";

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformValue<string>? Source
    {
        get => new TerraformReference<string>(this, "source");
        set => SetArgument("source", value);
    }

}

/// <summary>
/// Block type for pre_task in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationPreTaskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pre_task";

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformValue<string>? Source
    {
        get => new TerraformReference<string>(this, "source");
        set => SetArgument("source", value);
    }

}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// The advanced_month_days attribute.
    /// </summary>
    public TerraformList<double>? AdvancedMonthDays
    {
        get => TerraformList<double>.Lazy(ctx => new TerraformReference<TerraformList<double>>(this, "advanced_month_days").ResolveNodes(ctx));
        set => SetArgument("advanced_month_days", value);
    }

    /// <summary>
    /// The advanced_week_days attribute.
    /// </summary>
    public TerraformList<string>? AdvancedWeekDays
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "advanced_week_days").ResolveNodes(ctx));
        set => SetArgument("advanced_week_days", value);
    }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
    {
        get => new TerraformReference<string>(this, "creation_time");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The expiry_time attribute.
    /// </summary>
    public TerraformValue<string> ExpiryTime
    {
        get => new TerraformReference<string>(this, "expiry_time");
        set => SetArgument("expiry_time", value);
    }

    /// <summary>
    /// The expiry_time_offset_minutes attribute.
    /// </summary>
    public TerraformValue<double>? ExpiryTimeOffsetMinutes
    {
        get => new TerraformReference<double>(this, "expiry_time_offset_minutes");
        set => SetArgument("expiry_time_offset_minutes", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformValue<string> Frequency
    {
        get => new TerraformReference<string>(this, "frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformValue<double>? Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The is_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IsEnabled
    {
        get => new TerraformReference<bool>(this, "is_enabled");
        set => SetArgument("is_enabled", value);
    }

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedTime
    {
        get => new TerraformReference<string>(this, "last_modified_time");
    }

    /// <summary>
    /// The next_run attribute.
    /// </summary>
    public TerraformValue<string> NextRun
    {
        get => new TerraformReference<string>(this, "next_run");
        set => SetArgument("next_run", value);
    }

    /// <summary>
    /// The next_run_offset_minutes attribute.
    /// </summary>
    public TerraformValue<double>? NextRunOffsetMinutes
    {
        get => new TerraformReference<double>(this, "next_run_offset_minutes");
        set => SetArgument("next_run_offset_minutes", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The start_time_offset_minutes attribute.
    /// </summary>
    public TerraformValue<double>? StartTimeOffsetMinutes
    {
        get => new TerraformReference<double>(this, "start_time_offset_minutes");
        set => SetArgument("start_time_offset_minutes", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformValue<string>? TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
        set => SetArgument("time_zone", value);
    }

}

/// <summary>
/// Block type for target in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target";

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationTimeoutsBlock : TerraformBlock
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
/// Block type for windows in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationWindowsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "windows";

    /// <summary>
    /// The classifications_included attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClassificationsIncluded is required")]
    public TerraformList<string>? ClassificationsIncluded
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "classifications_included").ResolveNodes(ctx));
        set => SetArgument("classifications_included", value);
    }

    /// <summary>
    /// The excluded_knowledge_base_numbers attribute.
    /// </summary>
    public TerraformList<string>? ExcludedKnowledgeBaseNumbers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excluded_knowledge_base_numbers").ResolveNodes(ctx));
        set => SetArgument("excluded_knowledge_base_numbers", value);
    }

    /// <summary>
    /// The included_knowledge_base_numbers attribute.
    /// </summary>
    public TerraformList<string>? IncludedKnowledgeBaseNumbers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "included_knowledge_base_numbers").ResolveNodes(ctx));
        set => SetArgument("included_knowledge_base_numbers", value);
    }

    /// <summary>
    /// The reboot attribute.
    /// </summary>
    public TerraformValue<string>? Reboot
    {
        get => new TerraformReference<string>(this, "reboot");
        set => SetArgument("reboot", value);
    }

}

/// <summary>
/// Represents a azurerm_automation_software_update_configuration Terraform resource.
/// Manages a azurerm_automation_software_update_configuration resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermAutomationSoftwareUpdateConfiguration(string name) : TerraformResource("azurerm_automation_software_update_configuration", name)
{
    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    public required TerraformValue<string> AutomationAccountId
    {
        get => new TerraformReference<string>(this, "automation_account_id");
        set => SetArgument("automation_account_id", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformValue<string>? Duration
    {
        get => new TerraformReference<string>(this, "duration");
        set => SetArgument("duration", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The non_azure_computer_names attribute.
    /// </summary>
    public TerraformList<string>? NonAzureComputerNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "non_azure_computer_names").ResolveNodes(ctx));
        set => SetArgument("non_azure_computer_names", value);
    }

    /// <summary>
    /// The virtual_machine_ids attribute.
    /// </summary>
    public TerraformList<string>? VirtualMachineIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "virtual_machine_ids").ResolveNodes(ctx));
        set => SetArgument("virtual_machine_ids", value);
    }

    /// <summary>
    /// Linux block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Linux block(s) allowed")]
    public AzurermAutomationSoftwareUpdateConfigurationLinuxBlock? Linux
    {
        get => GetArgument<AzurermAutomationSoftwareUpdateConfigurationLinuxBlock>("linux");
        set => SetArgument("linux", value);
    }

    /// <summary>
    /// PostTask block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostTask block(s) allowed")]
    public AzurermAutomationSoftwareUpdateConfigurationPostTaskBlock? PostTask
    {
        get => GetArgument<AzurermAutomationSoftwareUpdateConfigurationPostTaskBlock>("post_task");
        set => SetArgument("post_task", value);
    }

    /// <summary>
    /// PreTask block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreTask block(s) allowed")]
    public AzurermAutomationSoftwareUpdateConfigurationPreTaskBlock? PreTask
    {
        get => GetArgument<AzurermAutomationSoftwareUpdateConfigurationPreTaskBlock>("pre_task");
        set => SetArgument("pre_task", value);
    }

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public required AzurermAutomationSoftwareUpdateConfigurationScheduleBlock Schedule
    {
        get => GetRequiredArgument<AzurermAutomationSoftwareUpdateConfigurationScheduleBlock>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// Target block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public AzurermAutomationSoftwareUpdateConfigurationTargetBlock? Target
    {
        get => GetArgument<AzurermAutomationSoftwareUpdateConfigurationTargetBlock>("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAutomationSoftwareUpdateConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAutomationSoftwareUpdateConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Windows block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Windows block(s) allowed")]
    public AzurermAutomationSoftwareUpdateConfigurationWindowsBlock? Windows
    {
        get => GetArgument<AzurermAutomationSoftwareUpdateConfigurationWindowsBlock>("windows");
        set => SetArgument("windows", value);
    }

}
