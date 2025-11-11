using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_billing_subaccount resource.
/// </summary>
public partial class GoogleBillingSubaccount : TerraformResource
{
    public GoogleBillingSubaccount(string name) : base("google_billing_subaccount", name)
    {
    }

    /// <summary>
    /// The deletion_policy attribute.
    /// </summary>
    [TerraformProperty("deletion_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DeletionPolicy { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The master_billing_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterBillingAccount is required")]
    [TerraformProperty("master_billing_account")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MasterBillingAccount { get; set; }

    /// <summary>
    /// The billing_account_id attribute.
    /// </summary>
    [TerraformProperty("billing_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BillingAccountId { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The open attribute.
    /// </summary>
    [TerraformProperty("open")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Open { get; }

}
