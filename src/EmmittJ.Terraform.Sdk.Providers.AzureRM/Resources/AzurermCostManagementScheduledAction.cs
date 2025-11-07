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
    public TerraformLiteralProperty<double>? DayOfMonth
    {
        get => GetProperty<TerraformLiteralProperty<double>>("day_of_month");
        set => this.WithProperty("day_of_month", value);
    }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? DaysOfWeek
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("days_of_week");
        set => this.WithProperty("days_of_week", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The email_address_sender attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EmailAddressSender
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_address_sender");
        set => this.WithProperty("email_address_sender", value);
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? EmailAddresses
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("email_addresses");
        set => this.WithProperty("email_addresses", value);
    }

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EmailSubject
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_subject");
        set => this.WithProperty("email_subject", value);
    }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EndDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_date");
        set => this.WithProperty("end_date", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Frequency
    {
        get => GetProperty<TerraformLiteralProperty<string>>("frequency");
        set => this.WithProperty("frequency", value);
    }

    /// <summary>
    /// The hour_of_day attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? HourOfDay
    {
        get => GetProperty<TerraformLiteralProperty<double>>("hour_of_day");
        set => this.WithProperty("hour_of_day", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The message attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Message
    {
        get => GetProperty<TerraformLiteralProperty<string>>("message");
        set => this.WithProperty("message", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StartDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_date");
        set => this.WithProperty("start_date", value);
    }

    /// <summary>
    /// The view_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ViewId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("view_id");
        set => this.WithProperty("view_id", value);
    }

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? WeeksOfMonth
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("weeks_of_month");
        set => this.WithProperty("weeks_of_month", value);
    }

}
