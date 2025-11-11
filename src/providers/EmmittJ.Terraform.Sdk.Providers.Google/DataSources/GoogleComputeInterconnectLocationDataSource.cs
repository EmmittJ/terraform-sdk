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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The address attribute.
    /// </summary>
    [TerraformPropertyName("address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Address => new TerraformReference(this, "address");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AvailabilityZone => new TerraformReference(this, "availability_zone");

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformPropertyName("city")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> City => new TerraformReference(this, "city");

    /// <summary>
    /// The continent attribute.
    /// </summary>
    [TerraformPropertyName("continent")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Continent => new TerraformReference(this, "continent");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The facility_provider attribute.
    /// </summary>
    [TerraformPropertyName("facility_provider")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FacilityProvider => new TerraformReference(this, "facility_provider");

    /// <summary>
    /// The facility_provider_facility_id attribute.
    /// </summary>
    [TerraformPropertyName("facility_provider_facility_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FacilityProviderFacilityId => new TerraformReference(this, "facility_provider_facility_id");

    /// <summary>
    /// The peeringdb_facility_id attribute.
    /// </summary>
    [TerraformPropertyName("peeringdb_facility_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PeeringdbFacilityId => new TerraformReference(this, "peeringdb_facility_id");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
