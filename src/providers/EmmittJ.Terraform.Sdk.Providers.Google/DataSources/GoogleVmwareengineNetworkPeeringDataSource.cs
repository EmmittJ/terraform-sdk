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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ID of the Network Peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// User-provided description for this network peering.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// True if custom routes are exported to the peered network; false otherwise.
    /// </summary>
    [TerraformPropertyName("export_custom_routes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ExportCustomRoutes => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "export_custom_routes");

    /// <summary>
    /// True if all subnet routes with a public IP address range are exported; false otherwise.
    /// </summary>
    [TerraformPropertyName("export_custom_routes_with_public_ip")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ExportCustomRoutesWithPublicIp => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "export_custom_routes_with_public_ip");

    /// <summary>
    /// True if custom routes are imported from the peered network; false otherwise.
    /// </summary>
    [TerraformPropertyName("import_custom_routes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ImportCustomRoutes => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "import_custom_routes");

    /// <summary>
    /// True if custom routes are imported from the peered network; false otherwise.
    /// </summary>
    [TerraformPropertyName("import_custom_routes_with_public_ip")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ImportCustomRoutesWithPublicIp => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "import_custom_routes_with_public_ip");

    /// <summary>
    /// The relative resource name of the network to peer with a standard VMware Engine network.
    /// The provided network can be a consumer VPC network or another standard VMware Engine network.
    /// </summary>
    [TerraformPropertyName("peer_network")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PeerNetwork => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "peer_network");

    /// <summary>
    /// The type of the network to peer with the VMware Engine network. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;VMWARE_ENGINE_NETWORK&amp;quot;, &amp;quot;PRIVATE_SERVICES_ACCESS&amp;quot;, &amp;quot;NETAPP_CLOUD_VOLUMES&amp;quot;, &amp;quot;THIRD_PARTY_SERVICE&amp;quot;, &amp;quot;DELL_POWERSCALE&amp;quot;, &amp;quot;GOOGLE_CLOUD_NETAPP_VOLUMES&amp;quot;]
    /// </summary>
    [TerraformPropertyName("peer_network_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PeerNetworkType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "peer_network_type");

    /// <summary>
    /// State of the network peering.
    /// This field has a value of &#39;ACTIVE&#39; when there&#39;s a matching configuration in the peer network.
    /// New values may be added to this enum when appropriate.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// Details about the current state of the network peering.
    /// </summary>
    [TerraformPropertyName("state_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StateDetails => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state_details");

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

    /// <summary>
    /// The relative resource name of the VMware Engine network. Specify the name in the following form:
    /// projects/{project}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId} where {project}
    /// can either be a project number or a project ID.
    /// </summary>
    [TerraformPropertyName("vmware_engine_network")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VmwareEngineNetwork => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vmware_engine_network");

    /// <summary>
    /// The canonical name of the VMware Engine network in the form:
    /// projects/{project_number}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId}
    /// </summary>
    [TerraformPropertyName("vmware_engine_network_canonical")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VmwareEngineNetworkCanonical => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vmware_engine_network_canonical");

}
