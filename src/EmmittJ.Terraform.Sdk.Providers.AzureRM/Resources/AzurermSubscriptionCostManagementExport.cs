using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_subscription_cost_management_export resource.
/// </summary>
public class AzurermSubscriptionCostManagementExport : TerraformResource
{
    public AzurermSubscriptionCostManagementExport(string name) : base("azurerm_subscription_cost_management_export", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    public TerraformProperty<bool>? Active
    {
        get => GetProperty<TerraformProperty<bool>>("active");
        set => this.WithProperty("active", value);
    }

    /// <summary>
    /// The file_format attribute.
    /// </summary>
    public TerraformProperty<string>? FileFormat
    {
        get => GetProperty<TerraformProperty<string>>("file_format");
        set => this.WithProperty("file_format", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The recurrence_period_end_date attribute.
    /// </summary>
    public TerraformProperty<string>? RecurrencePeriodEndDate
    {
        get => GetProperty<TerraformProperty<string>>("recurrence_period_end_date");
        set => this.WithProperty("recurrence_period_end_date", value);
    }

    /// <summary>
    /// The recurrence_period_start_date attribute.
    /// </summary>
    public TerraformProperty<string>? RecurrencePeriodStartDate
    {
        get => GetProperty<TerraformProperty<string>>("recurrence_period_start_date");
        set => this.WithProperty("recurrence_period_start_date", value);
    }

    /// <summary>
    /// The recurrence_type attribute.
    /// </summary>
    public TerraformProperty<string>? RecurrenceType
    {
        get => GetProperty<TerraformProperty<string>>("recurrence_type");
        set => this.WithProperty("recurrence_type", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubscriptionId
    {
        get => GetProperty<TerraformProperty<string>>("subscription_id");
        set => this.WithProperty("subscription_id", value);
    }

}
