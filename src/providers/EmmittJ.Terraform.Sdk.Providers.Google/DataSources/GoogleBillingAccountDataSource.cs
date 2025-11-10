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
    public TerraformProperty<TerraformProperty<string>>? BillingAccount { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DisplayName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The lookup_projects attribute.
    /// </summary>
    [TerraformPropertyName("lookup_projects")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LookupProjects { get; set; }

    /// <summary>
    /// The open attribute.
    /// </summary>
    [TerraformPropertyName("open")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Open { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "open");

    /// <summary>
    /// The currency_code attribute.
    /// </summary>
    [TerraformPropertyName("currency_code")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CurrencyCode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "currency_code");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The project_ids attribute.
    /// </summary>
    [TerraformPropertyName("project_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> ProjectIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "project_ids");

}
