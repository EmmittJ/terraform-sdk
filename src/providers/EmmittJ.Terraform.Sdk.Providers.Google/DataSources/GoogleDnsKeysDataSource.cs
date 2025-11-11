using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_dns_keys.
/// </summary>
public partial class GoogleDnsKeysDataSource : TerraformDataSource
{
    public GoogleDnsKeysDataSource(string name) : base("google_dns_keys", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The managed_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedZone is required")]
    [TerraformProperty("managed_zone")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ManagedZone { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The key_signing_keys attribute.
    /// </summary>
    [TerraformProperty("key_signing_keys")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> KeySigningKeys { get; }

    /// <summary>
    /// The zone_signing_keys attribute.
    /// </summary>
    [TerraformProperty("zone_signing_keys")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ZoneSigningKeys { get; }

}
