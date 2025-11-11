using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_vmwareengine_network_peering.
/// </summary>
public class GoogleVmwareengineNetworkPeeringDataSource : TerraformDataSource
{
    public GoogleVmwareengineNetworkPeeringDataSource(string name) : base("google_vmwareengine_network_peering", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ID of the Network Peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// User-provided description for this network peering.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// True if custom routes are exported to the peered network; false otherwise.
    /// </summary>
    [TerraformPropertyName("export_custom_routes")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ExportCustomRoutes => new TerraformReference(this, "export_custom_routes");

    /// <summary>
    /// True if all subnet routes with a public IP address range are exported; false otherwise.
    /// </summary>
    [TerraformPropertyName("export_custom_routes_with_public_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ExportCustomRoutesWithPublicIp => new TerraformReference(this, "export_custom_routes_with_public_ip");

    /// <summary>
    /// True if custom routes are imported from the peered network; false otherwise.
    /// </summary>
    [TerraformPropertyName("import_custom_routes")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ImportCustomRoutes => new TerraformReference(this, "import_custom_routes");

    /// <summary>
    /// True if custom routes are imported from the peered network; false otherwise.
    /// </summary>
    [TerraformPropertyName("import_custom_routes_with_public_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ImportCustomRoutesWithPublicIp => new TerraformReference(this, "import_custom_routes_with_public_ip");

    /// <summary>
    /// The relative resource name of the network to peer with a standard VMware Engine network.
    /// The provided network can be a consumer VPC network or another standard VMware Engine network.
    /// </summary>
    [TerraformPropertyName("peer_network")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PeerNetwork => new TerraformReference(this, "peer_network");

    /// <summary>
    /// The type of the network to peer with the VMware Engine network. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;VMWARE_ENGINE_NETWORK&amp;quot;, &amp;quot;PRIVATE_SERVICES_ACCESS&amp;quot;, &amp;quot;NETAPP_CLOUD_VOLUMES&amp;quot;, &amp;quot;THIRD_PARTY_SERVICE&amp;quot;, &amp;quot;DELL_POWERSCALE&amp;quot;, &amp;quot;GOOGLE_CLOUD_NETAPP_VOLUMES&amp;quot;]
    /// </summary>
    [TerraformPropertyName("peer_network_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PeerNetworkType => new TerraformReference(this, "peer_network_type");

    /// <summary>
    /// State of the network peering.
    /// This field has a value of &#39;ACTIVE&#39; when there&#39;s a matching configuration in the peer network.
    /// New values may be added to this enum when appropriate.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// Details about the current state of the network peering.
    /// </summary>
    [TerraformPropertyName("state_details")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StateDetails => new TerraformReference(this, "state_details");

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uid => new TerraformReference(this, "uid");

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

    /// <summary>
    /// The relative resource name of the VMware Engine network. Specify the name in the following form:
    /// projects/{project}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId} where {project}
    /// can either be a project number or a project ID.
    /// </summary>
    [TerraformPropertyName("vmware_engine_network")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VmwareEngineNetwork => new TerraformReference(this, "vmware_engine_network");

    /// <summary>
    /// The canonical name of the VMware Engine network in the form:
    /// projects/{project_number}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId}
    /// </summary>
    [TerraformPropertyName("vmware_engine_network_canonical")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VmwareEngineNetworkCanonical => new TerraformReference(this, "vmware_engine_network_canonical");

}
