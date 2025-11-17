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
        get => new TerraformReference<double>(this, "batch_size");
        set => SetArgument("batch_size", value);
    }

    /// <summary>
    /// The message_count attribute.
    /// </summary>
    public TerraformValue<double>? MessageCount
    {
        get => new TerraformReference<double>(this, "message_count");
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
        get => new TerraformReference<string>(this, "end_time");
        set => SetArgument("end_time", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<double> Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformValue<string>? TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
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
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "hours").ResolveNodes(ctx));
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// The minutes attribute.
    /// </summary>
    public TerraformSet<double>? Minutes
    {
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "minutes").ResolveNodes(ctx));
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// The month_days attribute.
    /// </summary>
    public TerraformSet<double>? MonthDays
    {
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "month_days").ResolveNodes(ctx));
        set => SetArgument("month_days", value);
    }

    /// <summary>
    /// The week_days attribute.
    /// </summary>
    public TerraformSet<string>? WeekDays
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "week_days").ResolveNodes(ctx));
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
        get => new TerraformReference<double>(this, "week");
        set => SetArgument("week", value);
    }

    /// <summary>
    /// The weekday attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weekday is required")]
    public required TerraformValue<string> Weekday
    {
        get => new TerraformReference<string>(this, "weekday");
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
        get => new TerraformReference<string>(this, "batch_group_name");
        set => SetArgument("batch_group_name", value);
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
    /// The integration_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationAccountName is required")]
    public required TerraformValue<string> IntegrationAccountName
    {
        get => new TerraformReference<string>(this, "integration_account_name");
        set => SetArgument("integration_account_name", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformMap<string>? Metadata
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "metadata").ResolveNodes(ctx));
        set => SetArgument("metadata", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
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
