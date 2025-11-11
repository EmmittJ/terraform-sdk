using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermBillingEnrollmentAccountScopeDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_billing_enrollment_account_scope.
/// </summary>
public partial class AzurermBillingEnrollmentAccountScopeDataSource : TerraformDataSource
{
    public AzurermBillingEnrollmentAccountScopeDataSource(string name) : base("azurerm_billing_enrollment_account_scope", name)
    {
    }

    /// <summary>
    /// The billing_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingAccountName is required")]
    [TerraformProperty("billing_account_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BillingAccountName { get; set; }

    /// <summary>
    /// The enrollment_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnrollmentAccountName is required")]
    [TerraformProperty("enrollment_account_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EnrollmentAccountName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermBillingEnrollmentAccountScopeDataSourceTimeoutsBlock>? Timeouts { get; set; }

}
