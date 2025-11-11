using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_dns_managed_zones.
/// </summary>
public partial class GoogleDnsManagedZonesDataSource : TerraformDataSource
{
    public GoogleDnsManagedZonesDataSource(string name) : base("google_dns_managed_zones", name)
    {
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The managed_zones attribute.
    /// </summary>
    [TerraformProperty("managed_zones")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ManagedZones { get; }

}
