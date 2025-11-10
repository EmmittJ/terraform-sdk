using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_dns_managed_zones.
/// </summary>
public class GoogleDnsManagedZonesDataSource : TerraformDataSource
{
    public GoogleDnsManagedZonesDataSource(string name) : base("google_dns_managed_zones", name)
    {
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The managed_zones attribute.
    /// </summary>
    [TerraformPropertyName("managed_zones")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ManagedZones => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "managed_zones");

}
