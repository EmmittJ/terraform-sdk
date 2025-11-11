using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_network.
/// </summary>
public partial class GoogleComputeNetworkDataSource : TerraformDataSource
{
    public GoogleComputeNetworkDataSource(string name) : base("google_compute_network", name)
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
    /// The network_profile attribute.
    /// </summary>
    [TerraformProperty("network_profile")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NetworkProfile { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The gateway_ipv4 attribute.
    /// </summary>
    [TerraformProperty("gateway_ipv4")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GatewayIpv4 { get; }

    /// <summary>
    /// The internal_ipv6_range attribute.
    /// </summary>
    [TerraformProperty("internal_ipv6_range")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InternalIpv6Range { get; }

    /// <summary>
    /// The network_id attribute.
    /// </summary>
    [TerraformProperty("network_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> NetworkId { get; }

    /// <summary>
    /// The numeric_id attribute.
    /// </summary>
    [TerraformProperty("numeric_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NumericId { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The subnetworks_self_links attribute.
    /// </summary>
    [TerraformProperty("subnetworks_self_links")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> SubnetworksSelfLinks { get; }

}
