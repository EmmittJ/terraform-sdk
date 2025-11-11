using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_vmwareengine_network_peering.
/// </summary>
public partial class GoogleVmwareengineNetworkPeeringDataSource : TerraformDataSource
{
    public GoogleVmwareengineNetworkPeeringDataSource(string name) : base("google_vmwareengine_network_peering", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID of the Network Peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// User-provided description for this network peering.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// True if custom routes are exported to the peered network; false otherwise.
    /// </summary>
    [TerraformProperty("export_custom_routes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ExportCustomRoutes { get; }

    /// <summary>
    /// True if all subnet routes with a public IP address range are exported; false otherwise.
    /// </summary>
    [TerraformProperty("export_custom_routes_with_public_ip")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ExportCustomRoutesWithPublicIp { get; }

    /// <summary>
    /// True if custom routes are imported from the peered network; false otherwise.
    /// </summary>
    [TerraformProperty("import_custom_routes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ImportCustomRoutes { get; }

    /// <summary>
    /// True if custom routes are imported from the peered network; false otherwise.
    /// </summary>
    [TerraformProperty("import_custom_routes_with_public_ip")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ImportCustomRoutesWithPublicIp { get; }

    /// <summary>
    /// The relative resource name of the network to peer with a standard VMware Engine network.
    /// The provided network can be a consumer VPC network or another standard VMware Engine network.
    /// </summary>
    [TerraformProperty("peer_network")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PeerNetwork { get; }

    /// <summary>
    /// The type of the network to peer with the VMware Engine network. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;VMWARE_ENGINE_NETWORK&amp;quot;, &amp;quot;PRIVATE_SERVICES_ACCESS&amp;quot;, &amp;quot;NETAPP_CLOUD_VOLUMES&amp;quot;, &amp;quot;THIRD_PARTY_SERVICE&amp;quot;, &amp;quot;DELL_POWERSCALE&amp;quot;, &amp;quot;GOOGLE_CLOUD_NETAPP_VOLUMES&amp;quot;]
    /// </summary>
    [TerraformProperty("peer_network_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PeerNetworkType { get; }

    /// <summary>
    /// State of the network peering.
    /// This field has a value of &#39;ACTIVE&#39; when there&#39;s a matching configuration in the peer network.
    /// New values may be added to this enum when appropriate.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// Details about the current state of the network peering.
    /// </summary>
    [TerraformProperty("state_details")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StateDetails { get; }

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uid { get; }

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

    /// <summary>
    /// The relative resource name of the VMware Engine network. Specify the name in the following form:
    /// projects/{project}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId} where {project}
    /// can either be a project number or a project ID.
    /// </summary>
    [TerraformProperty("vmware_engine_network")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VmwareEngineNetwork { get; }

    /// <summary>
    /// The canonical name of the VMware Engine network in the form:
    /// projects/{project_number}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId}
    /// </summary>
    [TerraformProperty("vmware_engine_network_canonical")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VmwareEngineNetworkCanonical { get; }

}
