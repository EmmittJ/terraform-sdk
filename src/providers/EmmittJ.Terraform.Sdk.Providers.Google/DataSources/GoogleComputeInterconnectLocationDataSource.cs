using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_interconnect_location.
/// </summary>
public class GoogleComputeInterconnectLocationDataSource : TerraformDataSource
{
    public GoogleComputeInterconnectLocationDataSource(string name) : base("google_compute_interconnect_location", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The address attribute.
    /// </summary>
    [TerraformPropertyName("address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Address => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "address");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformPropertyName("city")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> City => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "city");

    /// <summary>
    /// The continent attribute.
    /// </summary>
    [TerraformPropertyName("continent")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Continent => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "continent");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The facility_provider attribute.
    /// </summary>
    [TerraformPropertyName("facility_provider")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FacilityProvider => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "facility_provider");

    /// <summary>
    /// The facility_provider_facility_id attribute.
    /// </summary>
    [TerraformPropertyName("facility_provider_facility_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FacilityProviderFacilityId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "facility_provider_facility_id");

    /// <summary>
    /// The peeringdb_facility_id attribute.
    /// </summary>
    [TerraformPropertyName("peeringdb_facility_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PeeringdbFacilityId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "peeringdb_facility_id");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
