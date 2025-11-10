using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermLogicAppTriggerRecurrenceScheduleBlock : TerraformBlock
{
    /// <summary>
    /// The at_these_hours attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>>? AtTheseHours
    {
        get => GetProperty<HashSet<TerraformProperty<double>>>("at_these_hours");
        set => WithProperty("at_these_hours", value);
    }

    /// <summary>
    /// The at_these_minutes attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>>? AtTheseMinutes
    {
        get => GetProperty<HashSet<TerraformProperty<double>>>("at_these_minutes");
        set => WithProperty("at_these_minutes", value);
    }

    /// <summary>
    /// The on_these_days attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? OnTheseDays
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("on_these_days");
        set => WithProperty("on_these_days", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppTriggerRecurrenceTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_logic_app_trigger_recurrence resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermLogicAppTriggerRecurrence : TerraformResource
{
    public AzurermLogicAppTriggerRecurrence(string name) : base("azurerm_logic_app_trigger_recurrence", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformProperty<string> Frequency
    {
        get => GetProperty<TerraformProperty<string>>("frequency");
        set => this.WithProperty("frequency", value);
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
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformProperty<double> Interval
    {
        get => GetProperty<TerraformProperty<double>>("interval");
        set => this.WithProperty("interval", value);
    }

    /// <summary>
    /// The logic_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogicAppId is required")]
    public required TerraformProperty<string> LogicAppId
    {
        get => GetProperty<TerraformProperty<string>>("logic_app_id");
        set => this.WithProperty("logic_app_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformProperty<string>? StartTime
    {
        get => GetProperty<TerraformProperty<string>>("start_time");
        set => this.WithProperty("start_time", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformProperty<string>? TimeZone
    {
        get => GetProperty<TerraformProperty<string>>("time_zone");
        set => this.WithProperty("time_zone", value);
    }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public List<AzurermLogicAppTriggerRecurrenceScheduleBlock>? Schedule
    {
        get => GetProperty<List<AzurermLogicAppTriggerRecurrenceScheduleBlock>>("schedule");
        set => this.WithProperty("schedule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogicAppTriggerRecurrenceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermLogicAppTriggerRecurrenceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
