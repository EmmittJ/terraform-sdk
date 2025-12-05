using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for linux in AzurermAutomationSoftwareUpdateConfiguration.
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
        get => GetArgument<TerraformList<string>>("classifications_included");
        set => SetArgument("classifications_included", value);
    }

    /// <summary>
    /// The excluded_packages attribute.
    /// </summary>
    public TerraformList<string>? ExcludedPackages
    {
        get => GetArgument<TerraformList<string>>("excluded_packages");
        set => SetArgument("excluded_packages", value);
    }

    /// <summary>
    /// The included_packages attribute.
    /// </summary>
    public TerraformList<string>? IncludedPackages
    {
        get => GetArgument<TerraformList<string>>("included_packages");
        set => SetArgument("included_packages", value);
    }

    /// <summary>
    /// The reboot attribute.
    /// </summary>
    public TerraformValue<string>? Reboot
    {
        get => GetArgument<TerraformValue<string>>("reboot");
        set => SetArgument("reboot", value);
    }

}


/// <summary>
/// Block type for post_task in AzurermAutomationSoftwareUpdateConfiguration.
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
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformValue<string>? Source
    {
        get => GetArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

}


/// <summary>
/// Block type for pre_task in AzurermAutomationSoftwareUpdateConfiguration.
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
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformValue<string>? Source
    {
        get => GetArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

}


/// <summary>
/// Block type for schedule in AzurermAutomationSoftwareUpdateConfiguration.
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
        get => GetArgument<TerraformList<double>>("advanced_month_days");
        set => SetArgument("advanced_month_days", value);
    }

    /// <summary>
    /// The advanced_week_days attribute.
    /// </summary>
    public TerraformList<string>? AdvancedWeekDays
    {
        get => GetArgument<TerraformList<string>>("advanced_week_days");
        set => SetArgument("advanced_week_days", value);
    }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
        => CreateReference("creation_time");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The expiry_time attribute.
    /// </summary>
    public TerraformValue<string> ExpiryTime
    {
        get => GetArgument<TerraformValue<string>>("expiry_time") ?? CreateReference("expiry_time");
        set => SetArgument("expiry_time", value);
    }

    /// <summary>
    /// The expiry_time_offset_minutes attribute.
    /// </summary>
    public TerraformValue<double>? ExpiryTimeOffsetMinutes
    {
        get => GetArgument<TerraformValue<double>>("expiry_time_offset_minutes");
        set => SetArgument("expiry_time_offset_minutes", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformValue<string> Frequency
    {
        get => GetRequiredArgument<TerraformValue<string>>("frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformValue<double>? Interval
    {
        get => GetArgument<TerraformValue<double>>("interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The is_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("is_enabled");
        set => SetArgument("is_enabled", value);
    }

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedTime
        => CreateReference("last_modified_time");

    /// <summary>
    /// The next_run attribute.
    /// </summary>
    public TerraformValue<string> NextRun
    {
        get => GetArgument<TerraformValue<string>>("next_run") ?? CreateReference("next_run");
        set => SetArgument("next_run", value);
    }

    /// <summary>
    /// The next_run_offset_minutes attribute.
    /// </summary>
    public TerraformValue<double>? NextRunOffsetMinutes
    {
        get => GetArgument<TerraformValue<double>>("next_run_offset_minutes");
        set => SetArgument("next_run_offset_minutes", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string> StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time") ?? CreateReference("start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The start_time_offset_minutes attribute.
    /// </summary>
    public TerraformValue<double>? StartTimeOffsetMinutes
    {
        get => GetArgument<TerraformValue<double>>("start_time_offset_minutes");
        set => SetArgument("start_time_offset_minutes", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformValue<string>? TimeZone
    {
        get => GetArgument<TerraformValue<string>>("time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// MonthlyOccurrence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonthlyOccurrence block(s) allowed")]
    public TerraformList<AzurermAutomationSoftwareUpdateConfigurationScheduleBlockMonthlyOccurrenceBlock>? MonthlyOccurrence
    {
        get => GetArgument<TerraformList<AzurermAutomationSoftwareUpdateConfigurationScheduleBlockMonthlyOccurrenceBlock>>("monthly_occurrence");
        set => SetArgument("monthly_occurrence", value);
    }

}

/// <summary>
/// Block type for monthly_occurrence in AzurermAutomationSoftwareUpdateConfigurationScheduleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationScheduleBlockMonthlyOccurrenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monthly_occurrence";

    /// <summary>
    /// The day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Day is required")]
    public required TerraformValue<string> Day
    {
        get => GetRequiredArgument<TerraformValue<string>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// The occurrence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Occurrence is required")]
    public required TerraformValue<double> Occurrence
    {
        get => GetRequiredArgument<TerraformValue<double>>("occurrence");
        set => SetArgument("occurrence", value);
    }

}


/// <summary>
/// Block type for target in AzurermAutomationSoftwareUpdateConfiguration.
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target";

    /// <summary>
    /// AzureQuery block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermAutomationSoftwareUpdateConfigurationTargetBlockAzureQueryBlock>? AzureQuery
    {
        get => GetArgument<TerraformList<AzurermAutomationSoftwareUpdateConfigurationTargetBlockAzureQueryBlock>>("azure_query");
        set => SetArgument("azure_query", value);
    }

    /// <summary>
    /// NonAzureQuery block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermAutomationSoftwareUpdateConfigurationTargetBlockNonAzureQueryBlock>? NonAzureQuery
    {
        get => GetArgument<TerraformList<AzurermAutomationSoftwareUpdateConfigurationTargetBlockNonAzureQueryBlock>>("non_azure_query");
        set => SetArgument("non_azure_query", value);
    }

}

/// <summary>
/// Block type for azure_query in AzurermAutomationSoftwareUpdateConfigurationTargetBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationTargetBlockAzureQueryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_query";

    /// <summary>
    /// The locations attribute.
    /// </summary>
    public TerraformList<string>? Locations
    {
        get => GetArgument<TerraformList<string>>("locations");
        set => SetArgument("locations", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformList<string>? Scope
    {
        get => GetArgument<TerraformList<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The tag_filter attribute.
    /// </summary>
    public TerraformValue<string>? TagFilter
    {
        get => GetArgument<TerraformValue<string>>("tag_filter");
        set => SetArgument("tag_filter", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermAutomationSoftwareUpdateConfigurationTargetBlockAzureQueryBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AzurermAutomationSoftwareUpdateConfigurationTargetBlockAzureQueryBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for tags in AzurermAutomationSoftwareUpdateConfigurationTargetBlockAzureQueryBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationTargetBlockAzureQueryBlockTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tags";

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tag is required")]
    public required TerraformValue<string> Tag
    {
        get => GetRequiredArgument<TerraformValue<string>>("tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for non_azure_query in AzurermAutomationSoftwareUpdateConfigurationTargetBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSoftwareUpdateConfigurationTargetBlockNonAzureQueryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "non_azure_query";

    /// <summary>
    /// The function_alias attribute.
    /// </summary>
    public TerraformValue<string>? FunctionAlias
    {
        get => GetArgument<TerraformValue<string>>("function_alias");
        set => SetArgument("function_alias", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformValue<string>? WorkspaceId
    {
        get => GetArgument<TerraformValue<string>>("workspace_id");
        set => SetArgument("workspace_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermAutomationSoftwareUpdateConfiguration.
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for windows in AzurermAutomationSoftwareUpdateConfiguration.
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
        get => GetArgument<TerraformList<string>>("classifications_included");
        set => SetArgument("classifications_included", value);
    }

    /// <summary>
    /// The excluded_knowledge_base_numbers attribute.
    /// </summary>
    public TerraformList<string>? ExcludedKnowledgeBaseNumbers
    {
        get => GetArgument<TerraformList<string>>("excluded_knowledge_base_numbers");
        set => SetArgument("excluded_knowledge_base_numbers", value);
    }

    /// <summary>
    /// The included_knowledge_base_numbers attribute.
    /// </summary>
    public TerraformList<string>? IncludedKnowledgeBaseNumbers
    {
        get => GetArgument<TerraformList<string>>("included_knowledge_base_numbers");
        set => SetArgument("included_knowledge_base_numbers", value);
    }

    /// <summary>
    /// The reboot attribute.
    /// </summary>
    public TerraformValue<string>? Reboot
    {
        get => GetArgument<TerraformValue<string>>("reboot");
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
        get => GetRequiredArgument<TerraformValue<string>>("automation_account_id");
        set => SetArgument("automation_account_id", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformValue<string>? Duration
    {
        get => GetArgument<TerraformValue<string>>("duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The non_azure_computer_names attribute.
    /// </summary>
    public TerraformList<string>? NonAzureComputerNames
    {
        get => GetArgument<TerraformList<string>>("non_azure_computer_names");
        set => SetArgument("non_azure_computer_names", value);
    }

    /// <summary>
    /// The virtual_machine_ids attribute.
    /// </summary>
    public TerraformList<string>? VirtualMachineIds
    {
        get => GetArgument<TerraformList<string>>("virtual_machine_ids");
        set => SetArgument("virtual_machine_ids", value);
    }

    /// <summary>
    /// The error_code attribute.
    /// </summary>
    public TerraformValue<string> ErrorCode
        => CreateReference("error_code");

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    public TerraformValue<string> ErrorMessage
        => CreateReference("error_message");

    /// <summary>
    /// Linux block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Linux block(s) allowed")]
    public TerraformList<AzurermAutomationSoftwareUpdateConfigurationLinuxBlock>? Linux
    {
        get => GetArgument<TerraformList<AzurermAutomationSoftwareUpdateConfigurationLinuxBlock>>("linux");
        set => SetArgument("linux", value);
    }

    /// <summary>
    /// PostTask block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostTask block(s) allowed")]
    public TerraformList<AzurermAutomationSoftwareUpdateConfigurationPostTaskBlock>? PostTask
    {
        get => GetArgument<TerraformList<AzurermAutomationSoftwareUpdateConfigurationPostTaskBlock>>("post_task");
        set => SetArgument("post_task", value);
    }

    /// <summary>
    /// PreTask block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreTask block(s) allowed")]
    public TerraformList<AzurermAutomationSoftwareUpdateConfigurationPreTaskBlock>? PreTask
    {
        get => GetArgument<TerraformList<AzurermAutomationSoftwareUpdateConfigurationPreTaskBlock>>("pre_task");
        set => SetArgument("pre_task", value);
    }

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public required TerraformList<AzurermAutomationSoftwareUpdateConfigurationScheduleBlock> Schedule
    {
        get => GetRequiredArgument<TerraformList<AzurermAutomationSoftwareUpdateConfigurationScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// Target block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public TerraformList<AzurermAutomationSoftwareUpdateConfigurationTargetBlock>? Target
    {
        get => GetArgument<TerraformList<AzurermAutomationSoftwareUpdateConfigurationTargetBlock>>("target");
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
    public TerraformList<AzurermAutomationSoftwareUpdateConfigurationWindowsBlock>? Windows
    {
        get => GetArgument<TerraformList<AzurermAutomationSoftwareUpdateConfigurationWindowsBlock>>("windows");
        set => SetArgument("windows", value);
    }

}
