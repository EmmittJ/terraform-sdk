using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBillingEnrollmentAccountScopeDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_billing_enrollment_account_scope.
/// </summary>
public class AzurermBillingEnrollmentAccountScopeDataSource : TerraformDataSource
{
    public AzurermBillingEnrollmentAccountScopeDataSource(string name) : base("azurerm_billing_enrollment_account_scope", name)
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
        get => GetProperty<TerraformProperty<string>>("billing_account_name");
        set => this.WithProperty("billing_account_name", value);
    }

    /// <summary>
    /// The enrollment_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnrollmentAccountName is required")]
    public required TerraformProperty<string> EnrollmentAccountName
    {
        get => GetProperty<TerraformProperty<string>>("enrollment_account_name");
        set => this.WithProperty("enrollment_account_name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBillingEnrollmentAccountScopeDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermBillingEnrollmentAccountScopeDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
