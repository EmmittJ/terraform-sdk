using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_global_address.
/// </summary>
public partial class GoogleComputeGlobalAddressDataSource : TerraformDataSource
{
    public GoogleComputeGlobalAddressDataSource(string name) : base("google_compute_global_address", name)
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
    /// The address_type attribute.
    /// </summary>
    [TerraformProperty("address_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AddressType { get; }

    /// <summary>
    /// The network attribute.
    /// </summary>
    [TerraformProperty("network")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Network { get; }

    /// <summary>
    /// The network_tier attribute.
    /// </summary>
    [TerraformProperty("network_tier")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NetworkTier { get; }

    /// <summary>
    /// The prefix_length attribute.
    /// </summary>
    [TerraformProperty("prefix_length")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> PrefixLength { get; }

    /// <summary>
    /// The purpose attribute.
    /// </summary>
    [TerraformProperty("purpose")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Purpose { get; }

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

    /// <summary>
    /// The subnetwork attribute.
    /// </summary>
    [TerraformProperty("subnetwork")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Subnetwork { get; }

    /// <summary>
    /// The users attribute.
    /// </summary>
    [TerraformProperty("users")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Users { get; }

}
