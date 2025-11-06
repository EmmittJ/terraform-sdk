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
    public bool? Active
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("active")?.Value;
        set => this.WithProperty("active", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The billing_account_id attribute.
    /// </summary>
    public string? BillingAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("billing_account_id")?.Value;
        set => this.WithProperty("billing_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The file_format attribute.
    /// </summary>
    public string? FileFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_format")?.Value;
        set => this.WithProperty("file_format", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The recurrence_period_end_date attribute.
    /// </summary>
    public string? RecurrencePeriodEndDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recurrence_period_end_date")?.Value;
        set => this.WithProperty("recurrence_period_end_date", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The recurrence_period_start_date attribute.
    /// </summary>
    public string? RecurrencePeriodStartDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recurrence_period_start_date")?.Value;
        set => this.WithProperty("recurrence_period_start_date", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The recurrence_type attribute.
    /// </summary>
    public string? RecurrenceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recurrence_type")?.Value;
        set => this.WithProperty("recurrence_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
