using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBillingMcaAccountScopeDataSourceTimeoutsBlock : TerraformBlock
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
        SetOutput("billing_account_name");
        SetOutput("billing_profile_name");
        SetOutput("id");
        SetOutput("invoice_section_name");
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
    /// The billing_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingProfileName is required")]
    public required TerraformProperty<string> BillingProfileName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("billing_profile_name");
        set => SetProperty("billing_profile_name", value);
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
    /// The invoice_section_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InvoiceSectionName is required")]
    public required TerraformProperty<string> InvoiceSectionName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("invoice_section_name");
        set => SetProperty("invoice_section_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBillingMcaAccountScopeDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
