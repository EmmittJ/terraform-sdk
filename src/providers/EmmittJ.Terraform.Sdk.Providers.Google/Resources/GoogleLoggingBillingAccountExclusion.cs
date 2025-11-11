using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_logging_billing_account_exclusion resource.
/// </summary>
public partial class GoogleLoggingBillingAccountExclusion : TerraformResource
{
    public GoogleLoggingBillingAccountExclusion(string name) : base("google_logging_billing_account_exclusion", name)
    {
    }

    /// <summary>
    /// The billing_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingAccount is required")]
    [TerraformProperty("billing_account")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BillingAccount { get; set; }

    /// <summary>
    /// A human-readable description.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Whether this exclusion rule should be disabled or not. This defaults to false.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// The filter to apply when excluding logs. Only log entries that match the filter are excluded.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [TerraformProperty("filter")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the logging exclusion.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

}
