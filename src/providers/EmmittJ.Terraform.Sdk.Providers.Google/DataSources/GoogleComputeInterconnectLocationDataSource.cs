using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_interconnect_location.
/// </summary>
public partial class GoogleComputeInterconnectLocationDataSource : TerraformDataSource
{
    public GoogleComputeInterconnectLocationDataSource(string name) : base("google_compute_interconnect_location", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The address attribute.
    /// </summary>
    [TerraformProperty("address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Address { get; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AvailabilityZone { get; }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformProperty("city")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> City { get; }

    /// <summary>
    /// The continent attribute.
    /// </summary>
    [TerraformProperty("continent")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Continent { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The facility_provider attribute.
    /// </summary>
    [TerraformProperty("facility_provider")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FacilityProvider { get; }

    /// <summary>
    /// The facility_provider_facility_id attribute.
    /// </summary>
    [TerraformProperty("facility_provider_facility_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FacilityProviderFacilityId { get; }

    /// <summary>
    /// The peeringdb_facility_id attribute.
    /// </summary>
    [TerraformProperty("peeringdb_facility_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PeeringdbFacilityId { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
