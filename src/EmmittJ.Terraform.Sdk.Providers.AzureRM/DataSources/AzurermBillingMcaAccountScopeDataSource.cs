using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_billing_mca_account_scope.
/// </summary>
public class AzurermBillingMcaAccountScopeDataSource : TerraformDataSource
{
    public AzurermBillingMcaAccountScopeDataSource(string name) : base("azurerm_billing_mca_account_scope", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The billing_account_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BillingAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("billing_account_name");
        set => this.WithProperty("billing_account_name", value);
    }

    /// <summary>
    /// The billing_profile_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BillingProfileName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("billing_profile_name");
        set => this.WithProperty("billing_profile_name", value);
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
    /// The invoice_section_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InvoiceSectionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("invoice_section_name");
        set => this.WithProperty("invoice_section_name", value);
    }

}
