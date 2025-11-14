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
    [TerraformArgument("classifications_included")]
    public TerraformList<string>? ClassificationsIncluded
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "classifications_included").ResolveNodes(ctx));
        set => SetArgument("classifications_included", value);
    }

    /// <summary>
    /// The excluded_packages attribute.
    /// </summary>
    [TerraformArgument("excluded_packages")]
    public TerraformList<string>? ExcludedPackages
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excluded_packages").ResolveNodes(ctx));
        set => SetArgument("excluded_packages", value);
    }

    /// <summary>
    /// The included_packages attribute.
    /// </summary>
    [TerraformArgument("included_packages")]
    public TerraformList<string>? IncludedPackages
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "included_packages").ResolveNodes(ctx));
        set => SetArgument("included_packages", value);
    }

    /// <summary>
    /// The reboot attribute.
    /// </summary>
    [TerraformArgument("reboot")]
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
    [TerraformArgument("parameters")]
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformArgument("source")]
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
    [TerraformArgument("parameters")]
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformArgument("source")]
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
    [TerraformArgument("advanced_month_days")]
    public TerraformList<double>? AdvancedMonthDays
    {
        get => TerraformList<double>.Lazy(ctx => new TerraformReference<TerraformList<double>>(this, "advanced_month_days").ResolveNodes(ctx));
        set => SetArgument("advanced_month_days", value);
    }

    /// <summary>
    /// The advanced_week_days attribute.
    /// </summary>
    [TerraformArgument("advanced_week_days")]
    public TerraformList<string>? AdvancedWeekDays
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "advanced_week_days").ResolveNodes(ctx));
        set => SetArgument("advanced_week_days", value);
    }


    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The expiry_time attribute.
    /// </summary>
    [TerraformArgument("expiry_time")]
    public TerraformValue<string> ExpiryTime
    {
        get => new TerraformReference<string>(this, "expiry_time");
        set => SetArgument("expiry_time", value);
    }

    /// <summary>
    /// The expiry_time_offset_minutes attribute.
    /// </summary>
    [TerraformArgument("expiry_time_offset_minutes")]
    public TerraformValue<double>? ExpiryTimeOffsetMinutes
    {
        get => new TerraformReference<double>(this, "expiry_time_offset_minutes");
        set => SetArgument("expiry_time_offset_minutes", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformArgument("frequency")]
    public required TerraformValue<string> Frequency
    {
        get => new TerraformReference<string>(this, "frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformArgument("interval")]
    public TerraformValue<double>? Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The is_enabled attribute.
    /// </summary>
    [TerraformArgument("is_enabled")]
    public TerraformValue<bool>? IsEnabled
    {
        get => new TerraformReference<bool>(this, "is_enabled");
        set => SetArgument("is_enabled", value);
    }


    /// <summary>
    /// The next_run attribute.
    /// </summary>
    [TerraformArgument("next_run")]
    public TerraformValue<string> NextRun
    {
        get => new TerraformReference<string>(this, "next_run");
        set => SetArgument("next_run", value);
    }

    /// <summary>
    /// The next_run_offset_minutes attribute.
    /// </summary>
    [TerraformArgument("next_run_offset_minutes")]
    public TerraformValue<double>? NextRunOffsetMinutes
    {
        get => new TerraformReference<double>(this, "next_run_offset_minutes");
        set => SetArgument("next_run_offset_minutes", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformArgument("start_time")]
    public TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The start_time_offset_minutes attribute.
    /// </summary>
    [TerraformArgument("start_time_offset_minutes")]
    public TerraformValue<double>? StartTimeOffsetMinutes
    {
        get => new TerraformReference<double>(this, "start_time_offset_minutes");
        set => SetArgument("start_time_offset_minutes", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformArgument("time_zone")]
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
    [TerraformArgument("classifications_included")]
    public TerraformList<string>? ClassificationsIncluded
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "classifications_included").ResolveNodes(ctx));
        set => SetArgument("classifications_included", value);
    }

    /// <summary>
    /// The excluded_knowledge_base_numbers attribute.
    /// </summary>
    [TerraformArgument("excluded_knowledge_base_numbers")]
    public TerraformList<string>? ExcludedKnowledgeBaseNumbers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excluded_knowledge_base_numbers").ResolveNodes(ctx));
        set => SetArgument("excluded_knowledge_base_numbers", value);
    }

    /// <summary>
    /// The included_knowledge_base_numbers attribute.
    /// </summary>
    [TerraformArgument("included_knowledge_base_numbers")]
    public TerraformList<string>? IncludedKnowledgeBaseNumbers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "included_knowledge_base_numbers").ResolveNodes(ctx));
        set => SetArgument("included_knowledge_base_numbers", value);
    }

    /// <summary>
    /// The reboot attribute.
    /// </summary>
    [TerraformArgument("reboot")]
    public TerraformValue<string>? Reboot
    {
        get => new TerraformReference<string>(this, "reboot");
        set => SetArgument("reboot", value);
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
    }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    [TerraformArgument("automation_account_id")]
    public required TerraformValue<string> AutomationAccountId
    {
        get => new TerraformReference<string>(this, "automation_account_id");
        set => SetArgument("automation_account_id", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [TerraformArgument("duration")]
    public TerraformValue<string>? Duration
    {
        get => new TerraformReference<string>(this, "duration");
        set => SetArgument("duration", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The non_azure_computer_names attribute.
    /// </summary>
    [TerraformArgument("non_azure_computer_names")]
    public TerraformList<string>? NonAzureComputerNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "non_azure_computer_names").ResolveNodes(ctx));
        set => SetArgument("non_azure_computer_names", value);
    }

    /// <summary>
    /// The virtual_machine_ids attribute.
    /// </summary>
    [TerraformArgument("virtual_machine_ids")]
    public TerraformList<string>? VirtualMachineIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "virtual_machine_ids").ResolveNodes(ctx));
        set => SetArgument("virtual_machine_ids", value);
    }

    /// <summary>
    /// Block for linux.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Linux block(s) allowed")]
    [TerraformArgument("linux")]
    public TerraformList<AzurermAutomationSoftwareUpdateConfigurationLinuxBlock> Linux { get; set; } = new();

    /// <summary>
    /// Block for post_task.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostTask block(s) allowed")]
    [TerraformArgument("post_task")]
    public TerraformList<AzurermAutomationSoftwareUpdateConfigurationPostTaskBlock> PostTask { get; set; } = new();

    /// <summary>
    /// Block for pre_task.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreTask block(s) allowed")]
    [TerraformArgument("pre_task")]
    public TerraformList<AzurermAutomationSoftwareUpdateConfigurationPreTaskBlock> PreTask { get; set; } = new();

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformArgument("schedule")]
    public required TerraformList<AzurermAutomationSoftwareUpdateConfigurationScheduleBlock> Schedule { get; set; } = new();

    /// <summary>
    /// Block for target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    [TerraformArgument("target")]
    public TerraformList<AzurermAutomationSoftwareUpdateConfigurationTargetBlock> Target { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAutomationSoftwareUpdateConfigurationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for windows.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Windows block(s) allowed")]
    [TerraformArgument("windows")]
    public TerraformList<AzurermAutomationSoftwareUpdateConfigurationWindowsBlock> Windows { get; set; } = new();

    /// <summary>
    /// The error_code attribute.
    /// </summary>
    [TerraformArgument("error_code")]
    public TerraformValue<string> ErrorCode
    {
        get => new TerraformReference<string>(this, "error_code");
    }

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    [TerraformArgument("error_message")]
    public TerraformValue<string> ErrorMessage
    {
        get => new TerraformReference<string>(this, "error_message");
    }

}
