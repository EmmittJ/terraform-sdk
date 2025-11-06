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
    public double? DayOfMonth
    {
        get => GetProperty<TerraformLiteralProperty<double>>("day_of_month")?.Value;
        set => this.WithProperty("day_of_month", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    public List<string>? DaysOfWeek
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("days_of_week")?.Value;
        set => this.WithProperty("days_of_week", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The email_address_sender attribute.
    /// </summary>
    public string? EmailAddressSender
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_address_sender")?.Value;
        set => this.WithProperty("email_address_sender", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    public List<string>? EmailAddresses
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("email_addresses")?.Value;
        set => this.WithProperty("email_addresses", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    public string? EmailSubject
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_subject")?.Value;
        set => this.WithProperty("email_subject", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    public string? EndDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_date")?.Value;
        set => this.WithProperty("end_date", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public string? Frequency
    {
        get => GetProperty<TerraformLiteralProperty<string>>("frequency")?.Value;
        set => this.WithProperty("frequency", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hour_of_day attribute.
    /// </summary>
    public double? HourOfDay
    {
        get => GetProperty<TerraformLiteralProperty<double>>("hour_of_day")?.Value;
        set => this.WithProperty("hour_of_day", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The message attribute.
    /// </summary>
    public string? Message
    {
        get => GetProperty<TerraformLiteralProperty<string>>("message")?.Value;
        set => this.WithProperty("message", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    public string? StartDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_date")?.Value;
        set => this.WithProperty("start_date", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The view_id attribute.
    /// </summary>
    public string? ViewId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("view_id")?.Value;
        set => this.WithProperty("view_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    public List<string>? WeeksOfMonth
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("weeks_of_month")?.Value;
        set => this.WithProperty("weeks_of_month", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

}
