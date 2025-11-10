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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.WithOutput("create_time");
        this.WithOutput("state");
        this.WithOutput("state_details");
        this.WithOutput("uid");
        this.WithOutput("update_time");
        this.WithOutput("vmware_engine_network_canonical");
    }

    /// <summary>
    /// User-provided description for this network peering.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// True if custom routes are exported to the peered network; false otherwise.
    /// </summary>
    public TerraformProperty<bool>? ExportCustomRoutes
    {
        get => GetProperty<TerraformProperty<bool>>("export_custom_routes");
        set => this.WithProperty("export_custom_routes", value);
    }

    /// <summary>
    /// True if all subnet routes with a public IP address range are exported; false otherwise.
    /// </summary>
    public TerraformProperty<bool>? ExportCustomRoutesWithPublicIp
    {
        get => GetProperty<TerraformProperty<bool>>("export_custom_routes_with_public_ip");
        set => this.WithProperty("export_custom_routes_with_public_ip", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// True if custom routes are imported from the peered network; false otherwise.
    /// </summary>
    public TerraformProperty<bool>? ImportCustomRoutes
    {
        get => GetProperty<TerraformProperty<bool>>("import_custom_routes");
        set => this.WithProperty("import_custom_routes", value);
    }

    /// <summary>
    /// True if custom routes are imported from the peered network; false otherwise.
    /// </summary>
    public TerraformProperty<bool>? ImportCustomRoutesWithPublicIp
    {
        get => GetProperty<TerraformProperty<bool>>("import_custom_routes_with_public_ip");
        set => this.WithProperty("import_custom_routes_with_public_ip", value);
    }

    /// <summary>
    /// The ID of the Network Peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The relative resource name of the network to peer with a standard VMware Engine network.
    /// The provided network can be a consumer VPC network or another standard VMware Engine network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerNetwork is required")]
    public required TerraformProperty<string> PeerNetwork
    {
        get => GetRequiredProperty<TerraformProperty<string>>("peer_network");
        set => this.WithProperty("peer_network", value);
    }

    /// <summary>
    /// The type of the network to peer with the VMware Engine network. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;VMWARE_ENGINE_NETWORK&amp;quot;, &amp;quot;PRIVATE_SERVICES_ACCESS&amp;quot;, &amp;quot;NETAPP_CLOUD_VOLUMES&amp;quot;, &amp;quot;THIRD_PARTY_SERVICE&amp;quot;, &amp;quot;DELL_POWERSCALE&amp;quot;, &amp;quot;GOOGLE_CLOUD_NETAPP_VOLUMES&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerNetworkType is required")]
    public required TerraformProperty<string> PeerNetworkType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("peer_network_type");
        set => this.WithProperty("peer_network_type", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The relative resource name of the VMware Engine network. Specify the name in the following form:
    /// projects/{project}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId} where {project}
    /// can either be a project number or a project ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmwareEngineNetwork is required")]
    public required TerraformProperty<string> VmwareEngineNetwork
    {
        get => GetRequiredProperty<TerraformProperty<string>>("vmware_engine_network");
        set => this.WithProperty("vmware_engine_network", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleVmwareengineNetworkPeeringTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleVmwareengineNetworkPeeringTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
