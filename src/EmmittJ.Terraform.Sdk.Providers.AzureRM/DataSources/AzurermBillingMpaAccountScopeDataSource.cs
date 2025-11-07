using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_billing_mpa_account_scope.
/// </summary>
public class AzurermBillingMpaAccountScopeDataSource : TerraformDataSource
{
    public AzurermBillingMpaAccountScopeDataSource(string name) : base("azurerm_billing_mpa_account_scope", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The billing_account_name attribute.
    /// </summary>
    public TerraformProperty<string>? BillingAccountName
    {
        get => GetProperty<TerraformProperty<string>>("billing_account_name");
        set => this.WithProperty("billing_account_name", value);
    }

    /// <summary>
    /// The customer_name attribute.
    /// </summary>
    public TerraformProperty<string>? CustomerName
    {
        get => GetProperty<TerraformProperty<string>>("customer_name");
        set => this.WithProperty("customer_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
