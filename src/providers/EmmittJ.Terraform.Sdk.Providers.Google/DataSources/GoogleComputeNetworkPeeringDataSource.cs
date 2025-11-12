using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeNetworkPeeringDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a google_compute_network_peering.
/// </summary>
public partial class GoogleComputeNetworkPeeringDataSource : TerraformDataSource
{
    public GoogleComputeNetworkPeeringDataSource(string name) : base("google_compute_network_peering", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleComputeNetworkPeeringDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Whether to export the custom routes to the peer network. Defaults to false.
    /// </summary>
    [TerraformProperty("export_custom_routes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ExportCustomRoutes { get; }

    /// <summary>
    /// The export_subnet_routes_with_public_ip attribute.
    /// </summary>
    [TerraformProperty("export_subnet_routes_with_public_ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ExportSubnetRoutesWithPublicIp { get; }

    /// <summary>
    /// Whether to export the custom routes from the peer network. Defaults to false.
    /// </summary>
    [TerraformProperty("import_custom_routes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ImportCustomRoutes { get; }

    /// <summary>
    /// The import_subnet_routes_with_public_ip attribute.
    /// </summary>
    [TerraformProperty("import_subnet_routes_with_public_ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ImportSubnetRoutesWithPublicIp { get; }

    /// <summary>
    /// The peer network in the peering. The peer network may belong to a different project.
    /// </summary>
    [TerraformProperty("peer_network")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PeerNetwork { get; }

    /// <summary>
    /// Which IP version(s) of traffic and routes are allowed to be imported or exported between peer networks. The default value is IPV4_ONLY. Possible values: [&amp;quot;IPV4_ONLY&amp;quot;, &amp;quot;IPV4_IPV6&amp;quot;]
    /// </summary>
    [TerraformProperty("stack_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StackType { get; }

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

    /// <summary>
    /// The update strategy determines the semantics for updates and deletes to the peering connection configuration. The default value is INDEPENDENT. Possible values: [&amp;quot;INDEPENDENT&amp;quot;, &amp;quot;CONSENSUS&amp;quot;]
    /// </summary>
    [TerraformProperty("update_strategy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateStrategy { get; }

}
