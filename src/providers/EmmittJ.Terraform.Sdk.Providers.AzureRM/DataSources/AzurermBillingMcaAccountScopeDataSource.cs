using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermBillingMcaAccountScopeDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_billing_mca_account_scope.
/// </summary>
public partial class AzurermBillingMcaAccountScopeDataSource : TerraformDataSource
{
    public AzurermBillingMcaAccountScopeDataSource(string name) : base("azurerm_billing_mca_account_scope", name)
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
    /// The billing_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingProfileName is required")]
    [TerraformProperty("billing_profile_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BillingProfileName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The invoice_section_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InvoiceSectionName is required")]
    [TerraformProperty("invoice_section_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InvoiceSectionName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermBillingMcaAccountScopeDataSourceTimeoutsBlock Timeouts { get; set; } = new();

}
