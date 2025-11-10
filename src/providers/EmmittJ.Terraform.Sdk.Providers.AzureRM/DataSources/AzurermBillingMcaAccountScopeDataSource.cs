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
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
    }

    /// <summary>
    /// The billing_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingAccountName is required")]
    public required TerraformProperty<string> BillingAccountName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("billing_account_name");
        set => this.WithProperty("billing_account_name", value);
    }

    /// <summary>
    /// The billing_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingProfileName is required")]
    public required TerraformProperty<string> BillingProfileName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("billing_profile_name");
        set => this.WithProperty("billing_profile_name", value);
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
    /// The invoice_section_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InvoiceSectionName is required")]
    public required TerraformProperty<string> InvoiceSectionName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("invoice_section_name");
        set => this.WithProperty("invoice_section_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBillingMcaAccountScopeDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermBillingMcaAccountScopeDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
