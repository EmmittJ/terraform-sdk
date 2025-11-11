using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_billing_account.
/// </summary>
public partial class GoogleBillingAccountDataSource : TerraformDataSource
{
    public GoogleBillingAccountDataSource(string name) : base("google_billing_account", name)
    {
    }

    /// <summary>
    /// The billing_account attribute.
    /// </summary>
    [TerraformProperty("billing_account")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BillingAccount { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The lookup_projects attribute.
    /// </summary>
    [TerraformProperty("lookup_projects")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? LookupProjects { get; set; }

    /// <summary>
    /// The open attribute.
    /// </summary>
    [TerraformProperty("open")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> Open { get; set; }

    /// <summary>
    /// The currency_code attribute.
    /// </summary>
    [TerraformProperty("currency_code")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CurrencyCode { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The project_ids attribute.
    /// </summary>
    [TerraformProperty("project_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> ProjectIds { get; }

}
