using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermBillingMpaAccountScopeDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_billing_mpa_account_scope.
/// </summary>
public partial class AzurermBillingMpaAccountScopeDataSource : TerraformDataSource
{
    public AzurermBillingMpaAccountScopeDataSource(string name) : base("azurerm_billing_mpa_account_scope", name)
    {
    }

    /// <summary>
    /// The billing_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingAccountName is required")]
    [TerraformProperty("billing_account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BillingAccountName { get; set; }

    /// <summary>
    /// The customer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerName is required")]
    [TerraformProperty("customer_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CustomerName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermBillingMpaAccountScopeDataSourceTimeoutsBlock Timeouts { get; set; } = new();

}
