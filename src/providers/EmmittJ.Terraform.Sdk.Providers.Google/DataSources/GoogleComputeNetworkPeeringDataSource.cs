using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeNetworkPeeringDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a google_compute_network_peering.
/// </summary>
public class GoogleComputeNetworkPeeringDataSource : TerraformDataSource
{
    public GoogleComputeNetworkPeeringDataSource(string name) : base("google_compute_network_peering", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Name of the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The primary network of the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformPropertyName("network")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Network { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeNetworkPeeringDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Whether to export the custom routes to the peer network. Defaults to false.
    /// </summary>
    [TerraformPropertyName("export_custom_routes")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ExportCustomRoutes => new TerraformReference(this, "export_custom_routes");

    /// <summary>
    /// The export_subnet_routes_with_public_ip attribute.
    /// </summary>
    [TerraformPropertyName("export_subnet_routes_with_public_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ExportSubnetRoutesWithPublicIp => new TerraformReference(this, "export_subnet_routes_with_public_ip");

    /// <summary>
    /// Whether to export the custom routes from the peer network. Defaults to false.
    /// </summary>
    [TerraformPropertyName("import_custom_routes")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ImportCustomRoutes => new TerraformReference(this, "import_custom_routes");

    /// <summary>
    /// The import_subnet_routes_with_public_ip attribute.
    /// </summary>
    [TerraformPropertyName("import_subnet_routes_with_public_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ImportSubnetRoutesWithPublicIp => new TerraformReference(this, "import_subnet_routes_with_public_ip");

    /// <summary>
    /// The peer network in the peering. The peer network may belong to a different project.
    /// </summary>
    [TerraformPropertyName("peer_network")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PeerNetwork => new TerraformReference(this, "peer_network");

    /// <summary>
    /// Which IP version(s) of traffic and routes are allowed to be imported or exported between peer networks. The default value is IPV4_ONLY. Possible values: [&amp;quot;IPV4_ONLY&amp;quot;, &amp;quot;IPV4_IPV6&amp;quot;]
    /// </summary>
    [TerraformPropertyName("stack_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StackType => new TerraformReference(this, "stack_type");

    /// <summary>
    /// State for the peering, either ACTIVE or INACTIVE. The peering is ACTIVE when there&#39;s a matching configuration in the peer network.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// Details about the current state of the peering.
    /// </summary>
    [TerraformPropertyName("state_details")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StateDetails => new TerraformReference(this, "state_details");

    /// <summary>
    /// The update strategy determines the semantics for updates and deletes to the peering connection configuration. The default value is INDEPENDENT. Possible values: [&amp;quot;INDEPENDENT&amp;quot;, &amp;quot;CONSENSUS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("update_strategy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateStrategy => new TerraformReference(this, "update_strategy");

}
