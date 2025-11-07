using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformProperty<List<string>>? DaysOfWeek
    {
        get => GetProperty<TerraformProperty<List<string>>>("days_of_week");
        set => this.WithProperty("days_of_week", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The email_address_sender attribute.
    /// </summary>
    public TerraformProperty<string>? EmailAddressSender
    {
        get => GetProperty<TerraformProperty<string>>("email_address_sender");
        set => this.WithProperty("email_address_sender", value);
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    public TerraformProperty<List<string>>? EmailAddresses
    {
        get => GetProperty<TerraformProperty<List<string>>>("email_addresses");
        set => this.WithProperty("email_addresses", value);
    }

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    public TerraformProperty<string>? EmailSubject
    {
        get => GetProperty<TerraformProperty<string>>("email_subject");
        set => this.WithProperty("email_subject", value);
    }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    public TerraformProperty<string>? EndDate
    {
        get => GetProperty<TerraformProperty<string>>("end_date");
        set => this.WithProperty("end_date", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformProperty<string>? Frequency
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    public TerraformProperty<string>? StartDate
    {
        get => GetProperty<TerraformProperty<string>>("start_date");
        set => this.WithProperty("start_date", value);
    }

    /// <summary>
    /// The view_id attribute.
    /// </summary>
    public TerraformProperty<string>? ViewId
    {
        get => GetProperty<TerraformProperty<string>>("view_id");
        set => this.WithProperty("view_id", value);
    }

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    public TerraformProperty<List<string>>? WeeksOfMonth
    {
        get => GetProperty<TerraformProperty<List<string>>>("weeks_of_month");
        set => this.WithProperty("weeks_of_month", value);
    }

}
