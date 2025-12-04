using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_vmwareengine_network_peering Terraform data source.
/// Retrieves information about a google_vmwareengine_network_peering.
/// </summary>
public partial class GoogleVmwareengineNetworkPeeringDataSource(string name) : TerraformDataSource("google_vmwareengine_network_peering", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ID of the Network Peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// User-provided description for this network peering.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// True if custom routes are exported to the peered network; false otherwise.
    /// </summary>
    public TerraformValue<bool> ExportCustomRoutes
        => AsReference("export_custom_routes");

    /// <summary>
    /// True if all subnet routes with a public IP address range are exported; false otherwise.
    /// </summary>
    public TerraformValue<bool> ExportCustomRoutesWithPublicIp
        => AsReference("export_custom_routes_with_public_ip");

    /// <summary>
    /// True if custom routes are imported from the peered network; false otherwise.
    /// </summary>
    public TerraformValue<bool> ImportCustomRoutes
        => AsReference("import_custom_routes");

    /// <summary>
    /// True if custom routes are imported from the peered network; false otherwise.
    /// </summary>
    public TerraformValue<bool> ImportCustomRoutesWithPublicIp
        => AsReference("import_custom_routes_with_public_ip");

    /// <summary>
    /// The relative resource name of the network to peer with a standard VMware Engine network.
    /// The provided network can be a consumer VPC network or another standard VMware Engine network.
    /// </summary>
    public TerraformValue<string> PeerNetwork
        => AsReference("peer_network");

    /// <summary>
    /// The type of the network to peer with the VMware Engine network. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;VMWARE_ENGINE_NETWORK&amp;quot;, &amp;quot;PRIVATE_SERVICES_ACCESS&amp;quot;, &amp;quot;NETAPP_CLOUD_VOLUMES&amp;quot;, &amp;quot;THIRD_PARTY_SERVICE&amp;quot;, &amp;quot;DELL_POWERSCALE&amp;quot;, &amp;quot;GOOGLE_CLOUD_NETAPP_VOLUMES&amp;quot;]
    /// </summary>
    public TerraformValue<string> PeerNetworkType
        => AsReference("peer_network_type");

    /// <summary>
    /// State of the network peering.
    /// This field has a value of &#39;ACTIVE&#39; when there&#39;s a matching configuration in the peer network.
    /// New values may be added to this enum when appropriate.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Details about the current state of the network peering.
    /// </summary>
    public TerraformValue<string> StateDetails
        => AsReference("state_details");

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// The relative resource name of the VMware Engine network. Specify the name in the following form:
    /// projects/{project}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId} where {project}
    /// can either be a project number or a project ID.
    /// </summary>
    public TerraformValue<string> VmwareEngineNetwork
        => AsReference("vmware_engine_network");

    /// <summary>
    /// The canonical name of the VMware Engine network in the form:
    /// projects/{project_number}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId}
    /// </summary>
    public TerraformValue<string> VmwareEngineNetworkCanonical
        => AsReference("vmware_engine_network_canonical");

}
