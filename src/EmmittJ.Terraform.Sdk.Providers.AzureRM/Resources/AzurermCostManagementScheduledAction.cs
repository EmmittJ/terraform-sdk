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
    }

    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    public TerraformProperty<double>? DayOfMonth
    {
        get => GetProperty<TerraformProperty<double>>("day_of_month");
        set => this.WithProperty("day_of_month", value);
    }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    public List<TerraformProperty<string>>? DaysOfWeek
    {
        get => GetProperty<List<TerraformProperty<string>>>("days_of_week");
        set => this.WithProperty("days_of_week", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The email_address_sender attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddressSender is required")]
    public required TerraformProperty<string> EmailAddressSender
    {
        get => GetProperty<TerraformProperty<string>>("email_address_sender");
        set => this.WithProperty("email_address_sender", value);
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddresses is required")]
    public List<TerraformProperty<string>>? EmailAddresses
    {
        get => GetProperty<List<TerraformProperty<string>>>("email_addresses");
        set => this.WithProperty("email_addresses", value);
    }

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailSubject is required")]
    public required TerraformProperty<string> EmailSubject
    {
        get => GetProperty<TerraformProperty<string>>("email_subject");
        set => this.WithProperty("email_subject", value);
    }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndDate is required")]
    public required TerraformProperty<string> EndDate
    {
        get => GetProperty<TerraformProperty<string>>("end_date");
        set => this.WithProperty("end_date", value);
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
    /// The hour_of_day attribute.
    /// </summary>
    public TerraformProperty<double>? HourOfDay
    {
        get => GetProperty<TerraformProperty<double>>("hour_of_day");
        set => this.WithProperty("hour_of_day", value);
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
    /// The message attribute.
    /// </summary>
    public TerraformProperty<string>? Message
    {
        get => GetProperty<TerraformProperty<string>>("message");
        set => this.WithProperty("message", value);
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
    /// The start_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDate is required")]
    public required TerraformProperty<string> StartDate
    {
        get => GetProperty<TerraformProperty<string>>("start_date");
        set => this.WithProperty("start_date", value);
    }

    /// <summary>
    /// The view_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewId is required")]
    public required TerraformProperty<string> ViewId
    {
        get => GetProperty<TerraformProperty<string>>("view_id");
        set => this.WithProperty("view_id", value);
    }

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    public List<TerraformProperty<string>>? WeeksOfMonth
    {
        get => GetProperty<List<TerraformProperty<string>>>("weeks_of_month");
        set => this.WithProperty("weeks_of_month", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCostManagementScheduledActionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermCostManagementScheduledActionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
