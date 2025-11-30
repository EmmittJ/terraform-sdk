using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for monthly_occurrence in AzurermAutomationSchedule.
/// Nesting mode: list
/// </summary>
public class AzurermAutomationScheduleMonthlyOccurrenceBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// The occurrence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Occurrence is required")]
    public required TerraformValue<double> Occurrence
    {
        get => new TerraformReference<double>(this, "occurrence");
        set => SetArgument("occurrence", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermAutomationSchedule.
/// Nesting mode: single
/// </summary>
public class AzurermAutomationScheduleTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_automation_schedule Terraform resource.
/// Manages a azurerm_automation_schedule resource.
/// </summary>
public partial class AzurermAutomationSchedule(string name) : TerraformResource("azurerm_automation_schedule", name)
{
    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountName is required")]
    public required TerraformValue<string> AutomationAccountName
    {
        get => new TerraformReference<string>(this, "automation_account_name");
        set => SetArgument("automation_account_name", value);
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
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformValue<string> Frequency
    {
        get => new TerraformReference<string>(this, "frequency");
        set => SetArgument("frequency", value);
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
    /// The interval attribute.
    /// </summary>
    public TerraformValue<double> Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
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
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformValue<string>? Timezone
    {
        get => new TerraformReference<string>(this, "timezone");
        set => SetArgument("timezone", value);
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
    /// MonthlyOccurrence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonthlyOccurrence block(s) allowed")]
    public TerraformList<AzurermAutomationScheduleMonthlyOccurrenceBlock>? MonthlyOccurrence
    {
        get => GetArgument<TerraformList<AzurermAutomationScheduleMonthlyOccurrenceBlock>>("monthly_occurrence");
        set => SetArgument("monthly_occurrence", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAutomationScheduleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAutomationScheduleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
