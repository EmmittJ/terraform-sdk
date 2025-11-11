using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeNetworkPeeringTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_network_peering resource.
/// </summary>
public partial class GoogleComputeNetworkPeering : TerraformResource
{
    public GoogleComputeNetworkPeering(string name) : base("google_compute_network_peering", name)
    {
    }

    /// <summary>
    /// Whether to export the custom routes to the peer network. Defaults to false.
    /// </summary>
    [TerraformProperty("export_custom_routes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ExportCustomRoutes { get; set; }

    /// <summary>
    /// The export_subnet_routes_with_public_ip attribute.
    /// </summary>
    [TerraformProperty("export_subnet_routes_with_public_ip")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ExportSubnetRoutesWithPublicIp { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Whether to export the custom routes from the peer network. Defaults to false.
    /// </summary>
    [TerraformProperty("import_custom_routes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ImportCustomRoutes { get; set; }

    /// <summary>
    /// The import_subnet_routes_with_public_ip attribute.
    /// </summary>
    [TerraformProperty("import_subnet_routes_with_public_ip")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ImportSubnetRoutesWithPublicIp { get; set; }

    /// <summary>
    /// Name of the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The primary network of the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformProperty("network")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Network { get; set; }

    /// <summary>
    /// The peer network in the peering. The peer network may belong to a different project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerNetwork is required")]
    [TerraformProperty("peer_network")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PeerNetwork { get; set; }

    /// <summary>
    /// Which IP version(s) of traffic and routes are allowed to be imported or exported between peer networks. The default value is IPV4_ONLY. Possible values: [&amp;quot;IPV4_ONLY&amp;quot;, &amp;quot;IPV4_IPV6&amp;quot;]
    /// </summary>
    [TerraformProperty("stack_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StackType { get; set; }

    /// <summary>
    /// The update strategy determines the semantics for updates and deletes to the peering connection configuration. The default value is INDEPENDENT. Possible values: [&amp;quot;INDEPENDENT&amp;quot;, &amp;quot;CONSENSUS&amp;quot;]
    /// </summary>
    [TerraformProperty("update_strategy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UpdateStrategy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleComputeNetworkPeeringTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// State for the peering, either ACTIVE or INACTIVE. The peering is ACTIVE when there&#39;s a matching configuration in the peer network.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// Details about the current state of the peering.
    /// </summary>
    [TerraformProperty("state_details")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StateDetails { get; }

}
