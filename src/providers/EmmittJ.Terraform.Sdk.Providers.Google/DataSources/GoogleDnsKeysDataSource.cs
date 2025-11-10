using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_dns_keys.
/// </summary>
public class GoogleDnsKeysDataSource : TerraformDataSource
{
    public GoogleDnsKeysDataSource(string name) : base("google_dns_keys", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The managed_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedZone is required")]
    [TerraformPropertyName("managed_zone")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ManagedZone { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The key_signing_keys attribute.
    /// </summary>
    [TerraformPropertyName("key_signing_keys")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> KeySigningKeys => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "key_signing_keys");

    /// <summary>
    /// The zone_signing_keys attribute.
    /// </summary>
    [TerraformPropertyName("zone_signing_keys")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ZoneSigningKeys => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "zone_signing_keys");

}
