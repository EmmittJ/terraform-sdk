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
        set => SetProperty("day", value);
    }

    /// <summary>
    /// The occurrence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Occurrence is required")]
    public required TerraformProperty<double> Occurrence
    {
        set => SetProperty("occurrence", value);
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
        SetOutput("automation_account_name");
        SetOutput("description");
        SetOutput("expiry_time");
        SetOutput("frequency");
        SetOutput("id");
        SetOutput("interval");
        SetOutput("month_days");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("start_time");
        SetOutput("timezone");
        SetOutput("week_days");
    }

    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountName is required")]
    public required TerraformProperty<string> AutomationAccountName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("automation_account_name");
        set => SetProperty("automation_account_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The expiry_time attribute.
    /// </summary>
    public TerraformProperty<string> ExpiryTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("expiry_time");
        set => SetProperty("expiry_time", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformProperty<string> Frequency
    {
        get => GetRequiredOutput<TerraformProperty<string>>("frequency");
        set => SetProperty("frequency", value);
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
    /// The interval attribute.
    /// </summary>
    public TerraformProperty<double> Interval
    {
        get => GetRequiredOutput<TerraformProperty<double>>("interval");
        set => SetProperty("interval", value);
    }

    /// <summary>
    /// The month_days attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>> MonthDays
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<double>>>("month_days");
        set => SetProperty("month_days", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformProperty<string> StartTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("start_time");
        set => SetProperty("start_time", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformProperty<string> Timezone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("timezone");
        set => SetProperty("timezone", value);
    }

    /// <summary>
    /// The week_days attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> WeekDays
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("week_days");
        set => SetProperty("week_days", value);
    }

    /// <summary>
    /// Block for monthly_occurrence.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonthlyOccurrence block(s) allowed")]
    public List<AzurermAutomationScheduleMonthlyOccurrenceBlock>? MonthlyOccurrence
    {
        set => SetProperty("monthly_occurrence", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAutomationScheduleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
