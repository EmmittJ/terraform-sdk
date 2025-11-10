using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_billing_subaccount resource.
/// </summary>
public class GoogleBillingSubaccount : TerraformResource
{
    public GoogleBillingSubaccount(string name) : base("google_billing_subaccount", name)
    {
    }

    /// <summary>
    /// The deletion_policy attribute.
    /// </summary>
    [TerraformPropertyName("deletion_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeletionPolicy { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The master_billing_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterBillingAccount is required")]
    [TerraformPropertyName("master_billing_account")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MasterBillingAccount { get; set; }

    /// <summary>
    /// The billing_account_id attribute.
    /// </summary>
    [TerraformPropertyName("billing_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BillingAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "billing_account_id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The open attribute.
    /// </summary>
    [TerraformPropertyName("open")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Open => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "open");

}
