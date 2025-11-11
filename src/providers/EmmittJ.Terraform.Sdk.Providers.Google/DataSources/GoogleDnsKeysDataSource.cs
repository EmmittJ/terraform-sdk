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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The managed_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedZone is required")]
    [TerraformPropertyName("managed_zone")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ManagedZone { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The key_signing_keys attribute.
    /// </summary>
    [TerraformPropertyName("key_signing_keys")]
    // Output-only attribute - read-only reference
    public TerraformList<object> KeySigningKeys => new TerraformReference(this, "key_signing_keys");

    /// <summary>
    /// The zone_signing_keys attribute.
    /// </summary>
    [TerraformPropertyName("zone_signing_keys")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ZoneSigningKeys => new TerraformReference(this, "zone_signing_keys");

}
