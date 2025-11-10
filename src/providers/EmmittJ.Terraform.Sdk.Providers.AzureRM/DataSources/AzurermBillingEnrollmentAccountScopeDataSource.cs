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
        set => SetProperty("read", value);
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
        SetOutput("billing_account_name");
        SetOutput("enrollment_account_name");
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
    /// The enrollment_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnrollmentAccountName is required")]
    public required TerraformProperty<string> EnrollmentAccountName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("enrollment_account_name");
        set => SetProperty("enrollment_account_name", value);
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
    public AzurermBillingEnrollmentAccountScopeDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
