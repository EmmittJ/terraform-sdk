using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVmwareengineNetworkPeeringTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_vmwareengine_network_peering resource.
/// </summary>
public class GoogleVmwareengineNetworkPeering : TerraformResource
{
    public GoogleVmwareengineNetworkPeering(string name) : base("google_vmwareengine_network_peering", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("state");
        SetOutput("state_details");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("vmware_engine_network_canonical");
        SetOutput("description");
        SetOutput("export_custom_routes");
        SetOutput("export_custom_routes_with_public_ip");
        SetOutput("id");
        SetOutput("import_custom_routes");
        SetOutput("import_custom_routes_with_public_ip");
        SetOutput("name");
        SetOutput("peer_network");
        SetOutput("peer_network_type");
        SetOutput("project");
        SetOutput("vmware_engine_network");
    }

    /// <summary>
    /// User-provided description for this network peering.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// True if custom routes are exported to the peered network; false otherwise.
    /// </summary>
    public TerraformProperty<bool> ExportCustomRoutes
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("export_custom_routes");
        set => SetProperty("export_custom_routes", value);
    }

    /// <summary>
    /// True if all subnet routes with a public IP address range are exported; false otherwise.
    /// </summary>
    public TerraformProperty<bool> ExportCustomRoutesWithPublicIp
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("export_custom_routes_with_public_ip");
        set => SetProperty("export_custom_routes_with_public_ip", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// True if custom routes are imported from the peered network; false otherwise.
    /// </summary>
    public TerraformProperty<bool> ImportCustomRoutes
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("import_custom_routes");
        set => SetProperty("import_custom_routes", value);
    }

    /// <summary>
    /// True if custom routes are imported from the peered network; false otherwise.
    /// </summary>
    public TerraformProperty<bool> ImportCustomRoutesWithPublicIp
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("import_custom_routes_with_public_ip");
        set => SetProperty("import_custom_routes_with_public_ip", value);
    }

    /// <summary>
    /// The ID of the Network Peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The relative resource name of the network to peer with a standard VMware Engine network.
    /// The provided network can be a consumer VPC network or another standard VMware Engine network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerNetwork is required")]
    public required TerraformProperty<string> PeerNetwork
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peer_network");
        set => SetProperty("peer_network", value);
    }

    /// <summary>
    /// The type of the network to peer with the VMware Engine network. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;VMWARE_ENGINE_NETWORK&amp;quot;, &amp;quot;PRIVATE_SERVICES_ACCESS&amp;quot;, &amp;quot;NETAPP_CLOUD_VOLUMES&amp;quot;, &amp;quot;THIRD_PARTY_SERVICE&amp;quot;, &amp;quot;DELL_POWERSCALE&amp;quot;, &amp;quot;GOOGLE_CLOUD_NETAPP_VOLUMES&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerNetworkType is required")]
    public required TerraformProperty<string> PeerNetworkType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peer_network_type");
        set => SetProperty("peer_network_type", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The relative resource name of the VMware Engine network. Specify the name in the following form:
    /// projects/{project}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId} where {project}
    /// can either be a project number or a project ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmwareEngineNetwork is required")]
    public required TerraformProperty<string> VmwareEngineNetwork
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vmware_engine_network");
        set => SetProperty("vmware_engine_network", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleVmwareengineNetworkPeeringTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// State of the network peering.
    /// This field has a value of &#39;ACTIVE&#39; when there&#39;s a matching configuration in the peer network.
    /// New values may be added to this enum when appropriate.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Details about the current state of the network peering.
    /// </summary>
    public TerraformExpression StateDetails => this["state_details"];

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// The canonical name of the VMware Engine network in the form:
    /// projects/{project_number}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId}
    /// </summary>
    public TerraformExpression VmwareEngineNetworkCanonical => this["vmware_engine_network_canonical"];

}
