using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBillingMpaAccountScopeDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("billing_account_name");
        SetOutput("customer_name");
        SetOutput("id");
    }

    /// <summary>
    /// The billing_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingAccountName is required")]
    public required TerraformProperty<string> BillingAccountName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("billing_account_name");
        set => SetProperty("billing_account_name", value);
    }

    /// <summary>
    /// The customer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerName is required")]
    public required TerraformProperty<string> CustomerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_name");
        set => SetProperty("customer_name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBillingMpaAccountScopeDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
