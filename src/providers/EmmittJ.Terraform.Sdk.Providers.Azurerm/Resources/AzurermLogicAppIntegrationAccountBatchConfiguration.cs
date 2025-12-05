using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for release_criteria in AzurermLogicAppIntegrationAccountBatchConfiguration.
/// Nesting mode: list
/// </summary>
public class AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "release_criteria";

    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    public TerraformValue<double>? BatchSize
    {
        get => GetArgument<TerraformValue<double>>("batch_size");
        set => SetArgument("batch_size", value);
    }

    /// <summary>
    /// The message_count attribute.
    /// </summary>
    public TerraformValue<double>? MessageCount
    {
        get => GetArgument<TerraformValue<double>>("message_count");
        set => SetArgument("message_count", value);
    }

    /// <summary>
    /// Recurrence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Recurrence block(s) allowed")]
    public TerraformList<AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlockRecurrenceBlock>? Recurrence
    {
        get => GetArgument<TerraformList<AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlockRecurrenceBlock>>("recurrence");
        set => SetArgument("recurrence", value);
    }

}

/// <summary>
/// Block type for recurrence in AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlockRecurrenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recurrence";

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformValue<string>? EndTime
    {
        get => GetArgument<TerraformValue<string>>("end_time");
        set => SetArgument("end_time", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<double> Interval
    {
        get => GetRequiredArgument<TerraformValue<double>>("interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
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
    /// Schedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public TerraformList<AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlockRecurrenceBlockScheduleBlock>? Schedule
    {
        get => GetArgument<TerraformList<AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlockRecurrenceBlockScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

}

/// <summary>
/// Block type for schedule in AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlockRecurrenceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlockRecurrenceBlockScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// The hours attribute.
    /// </summary>
    public TerraformSet<double>? Hours
    {
        get => GetArgument<TerraformSet<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// The minutes attribute.
    /// </summary>
    public TerraformSet<double>? Minutes
    {
        get => GetArgument<TerraformSet<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// The month_days attribute.
    /// </summary>
    public TerraformSet<double>? MonthDays
    {
        get => GetArgument<TerraformSet<double>>("month_days");
        set => SetArgument("month_days", value);
    }

    /// <summary>
    /// The week_days attribute.
    /// </summary>
    public TerraformSet<string>? WeekDays
    {
        get => GetArgument<TerraformSet<string>>("week_days");
        set => SetArgument("week_days", value);
    }

    /// <summary>
    /// Monthly block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlockRecurrenceBlockScheduleBlockMonthlyBlock>? Monthly
    {
        get => GetArgument<TerraformSet<AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlockRecurrenceBlockScheduleBlockMonthlyBlock>>("monthly");
        set => SetArgument("monthly", value);
    }

}

/// <summary>
/// Block type for monthly in AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlockRecurrenceBlockScheduleBlock.
/// Nesting mode: set
/// </summary>
public class AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlockRecurrenceBlockScheduleBlockMonthlyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monthly";

    /// <summary>
    /// The week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Week is required")]
    public required TerraformValue<double> Week
    {
        get => GetRequiredArgument<TerraformValue<double>>("week");
        set => SetArgument("week", value);
    }

    /// <summary>
    /// The weekday attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weekday is required")]
    public required TerraformValue<string> Weekday
    {
        get => GetRequiredArgument<TerraformValue<string>>("weekday");
        set => SetArgument("weekday", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermLogicAppIntegrationAccountBatchConfiguration.
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppIntegrationAccountBatchConfigurationTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_logic_app_integration_account_batch_configuration Terraform resource.
/// Manages a azurerm_logic_app_integration_account_batch_configuration resource.
/// </summary>
public partial class AzurermLogicAppIntegrationAccountBatchConfiguration(string name) : TerraformResource("azurerm_logic_app_integration_account_batch_configuration", name)
{
    /// <summary>
    /// The batch_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BatchGroupName is required")]
    public required TerraformValue<string> BatchGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("batch_group_name");
        set => SetArgument("batch_group_name", value);
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
    /// The integration_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationAccountName is required")]
    public required TerraformValue<string> IntegrationAccountName
    {
        get => GetRequiredArgument<TerraformValue<string>>("integration_account_name");
        set => SetArgument("integration_account_name", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformMap<string>? Metadata
    {
        get => GetArgument<TerraformMap<string>>("metadata");
        set => SetArgument("metadata", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// ReleaseCriteria block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseCriteria is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReleaseCriteria block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReleaseCriteria block(s) allowed")]
    public required TerraformList<AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlock> ReleaseCriteria
    {
        get => GetRequiredArgument<TerraformList<AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlock>>("release_criteria");
        set => SetArgument("release_criteria", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLogicAppIntegrationAccountBatchConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLogicAppIntegrationAccountBatchConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
