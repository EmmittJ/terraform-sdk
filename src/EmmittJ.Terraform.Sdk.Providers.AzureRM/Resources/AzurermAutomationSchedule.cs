using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for monthly_occurrence in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationScheduleMonthlyOccurrenceBlock : TerraformBlock
{
    /// <summary>
    /// The day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Day is required")]
    public required TerraformProperty<string> Day
    {
        get => GetProperty<TerraformProperty<string>>("day");
        set => WithProperty("day", value);
    }

    /// <summary>
    /// The occurrence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Occurrence is required")]
    public required TerraformProperty<double> Occurrence
    {
        get => GetProperty<TerraformProperty<double>>("occurrence");
        set => WithProperty("occurrence", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationScheduleTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_automation_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermAutomationSchedule : TerraformResource
{
    public AzurermAutomationSchedule(string name) : base("azurerm_automation_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountName is required")]
    public required TerraformProperty<string> AutomationAccountName
    {
        get => GetProperty<TerraformProperty<string>>("automation_account_name");
        set => this.WithProperty("automation_account_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The expiry_time attribute.
    /// </summary>
    public TerraformProperty<string>? ExpiryTime
    {
        get => GetProperty<TerraformProperty<string>>("expiry_time");
        set => this.WithProperty("expiry_time", value);
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
    public TerraformProperty<double>? Interval
    {
        get => GetProperty<TerraformProperty<double>>("interval");
        set => this.WithProperty("interval", value);
    }

    /// <summary>
    /// The month_days attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>>? MonthDays
    {
        get => GetProperty<HashSet<TerraformProperty<double>>>("month_days");
        set => this.WithProperty("month_days", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
    /// The timezone attribute.
    /// </summary>
    public TerraformProperty<string>? Timezone
    {
        get => GetProperty<TerraformProperty<string>>("timezone");
        set => this.WithProperty("timezone", value);
    }

    /// <summary>
    /// The week_days attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? WeekDays
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("week_days");
        set => this.WithProperty("week_days", value);
    }

    /// <summary>
    /// Block for monthly_occurrence.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonthlyOccurrence block(s) allowed")]
    public List<AzurermAutomationScheduleMonthlyOccurrenceBlock>? MonthlyOccurrence
    {
        get => GetProperty<List<AzurermAutomationScheduleMonthlyOccurrenceBlock>>("monthly_occurrence");
        set => this.WithProperty("monthly_occurrence", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAutomationScheduleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAutomationScheduleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
