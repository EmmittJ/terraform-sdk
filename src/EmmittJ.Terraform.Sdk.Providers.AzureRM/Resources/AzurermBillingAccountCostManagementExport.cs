using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_billing_account_cost_management_export resource.
/// </summary>
public class AzurermBillingAccountCostManagementExport : TerraformResource
{
    public AzurermBillingAccountCostManagementExport(string name) : base("azurerm_billing_account_cost_management_export", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Active
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("active");
        set => this.WithProperty("active", value);
    }

    /// <summary>
    /// The billing_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BillingAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("billing_account_id");
        set => this.WithProperty("billing_account_id", value);
    }

    /// <summary>
    /// The file_format attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FileFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_format");
        set => this.WithProperty("file_format", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The recurrence_period_end_date attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RecurrencePeriodEndDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recurrence_period_end_date");
        set => this.WithProperty("recurrence_period_end_date", value);
    }

    /// <summary>
    /// The recurrence_period_start_date attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RecurrencePeriodStartDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recurrence_period_start_date");
        set => this.WithProperty("recurrence_period_start_date", value);
    }

    /// <summary>
    /// The recurrence_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RecurrenceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recurrence_type");
        set => this.WithProperty("recurrence_type", value);
    }

}
