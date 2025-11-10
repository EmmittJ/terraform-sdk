using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCostManagementScheduledActionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_cost_management_scheduled_action resource.
/// </summary>
public class AzurermCostManagementScheduledAction : TerraformResource
{
    public AzurermCostManagementScheduledAction(string name) : base("azurerm_cost_management_scheduled_action", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("day_of_month");
        SetOutput("days_of_week");
        SetOutput("display_name");
        SetOutput("email_address_sender");
        SetOutput("email_addresses");
        SetOutput("email_subject");
        SetOutput("end_date");
        SetOutput("frequency");
        SetOutput("hour_of_day");
        SetOutput("id");
        SetOutput("message");
        SetOutput("name");
        SetOutput("start_date");
        SetOutput("view_id");
        SetOutput("weeks_of_month");
    }

    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    public TerraformProperty<double> DayOfMonth
    {
        get => GetRequiredOutput<TerraformProperty<double>>("day_of_month");
        set => SetProperty("day_of_month", value);
    }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    public List<TerraformProperty<string>> DaysOfWeek
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("days_of_week");
        set => SetProperty("days_of_week", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The email_address_sender attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddressSender is required")]
    public required TerraformProperty<string> EmailAddressSender
    {
        get => GetRequiredOutput<TerraformProperty<string>>("email_address_sender");
        set => SetProperty("email_address_sender", value);
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddresses is required")]
    public List<TerraformProperty<string>> EmailAddresses
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("email_addresses");
        set => SetProperty("email_addresses", value);
    }

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailSubject is required")]
    public required TerraformProperty<string> EmailSubject
    {
        get => GetRequiredOutput<TerraformProperty<string>>("email_subject");
        set => SetProperty("email_subject", value);
    }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndDate is required")]
    public required TerraformProperty<string> EndDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("end_date");
        set => SetProperty("end_date", value);
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
    /// The hour_of_day attribute.
    /// </summary>
    public TerraformProperty<double> HourOfDay
    {
        get => GetRequiredOutput<TerraformProperty<double>>("hour_of_day");
        set => SetProperty("hour_of_day", value);
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
    /// The message attribute.
    /// </summary>
    public TerraformProperty<string> Message
    {
        get => GetRequiredOutput<TerraformProperty<string>>("message");
        set => SetProperty("message", value);
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
    /// The start_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDate is required")]
    public required TerraformProperty<string> StartDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("start_date");
        set => SetProperty("start_date", value);
    }

    /// <summary>
    /// The view_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewId is required")]
    public required TerraformProperty<string> ViewId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("view_id");
        set => SetProperty("view_id", value);
    }

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    public List<TerraformProperty<string>> WeeksOfMonth
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("weeks_of_month");
        set => SetProperty("weeks_of_month", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCostManagementScheduledActionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
