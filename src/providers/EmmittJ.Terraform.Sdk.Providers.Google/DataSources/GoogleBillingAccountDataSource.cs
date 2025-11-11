using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_billing_account.
/// </summary>
public class GoogleBillingAccountDataSource : TerraformDataSource
{
    public GoogleBillingAccountDataSource(string name) : base("google_billing_account", name)
    {
    }

    /// <summary>
    /// The billing_account attribute.
    /// </summary>
    [TerraformPropertyName("billing_account")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BillingAccount { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DisplayName { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The lookup_projects attribute.
    /// </summary>
    [TerraformPropertyName("lookup_projects")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LookupProjects { get; set; }

    /// <summary>
    /// The open attribute.
    /// </summary>
    [TerraformPropertyName("open")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Open { get; set; } = default!;

    /// <summary>
    /// The currency_code attribute.
    /// </summary>
    [TerraformPropertyName("currency_code")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CurrencyCode => new TerraformReference(this, "currency_code");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The project_ids attribute.
    /// </summary>
    [TerraformPropertyName("project_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> ProjectIds => new TerraformReference(this, "project_ids");

}
