using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("create_time");
        this.DeclareOutput("state");
        this.DeclareOutput("state_details");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
        this.DeclareOutput("vmware_engine_network_canonical");
    }

    /// <summary>
    /// User-provided description for this network peering.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// True if custom routes are exported to the peered network; false otherwise.
    /// </summary>
    public bool? ExportCustomRoutes
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("export_custom_routes")?.Value;
        set => this.WithProperty("export_custom_routes", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// True if all subnet routes with a public IP address range are exported; false otherwise.
    /// </summary>
    public bool? ExportCustomRoutesWithPublicIp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("export_custom_routes_with_public_ip")?.Value;
        set => this.WithProperty("export_custom_routes_with_public_ip", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// True if custom routes are imported from the peered network; false otherwise.
    /// </summary>
    public bool? ImportCustomRoutes
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("import_custom_routes")?.Value;
        set => this.WithProperty("import_custom_routes", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// True if custom routes are imported from the peered network; false otherwise.
    /// </summary>
    public bool? ImportCustomRoutesWithPublicIp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("import_custom_routes_with_public_ip")?.Value;
        set => this.WithProperty("import_custom_routes_with_public_ip", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ID of the Network Peering.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The relative resource name of the network to peer with a standard VMware Engine network.
    /// The provided network can be a consumer VPC network or another standard VMware Engine network.
    /// </summary>
    public string? PeerNetwork
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peer_network")?.Value;
        set => this.WithProperty("peer_network", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type of the network to peer with the VMware Engine network. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;VMWARE_ENGINE_NETWORK&amp;quot;, &amp;quot;PRIVATE_SERVICES_ACCESS&amp;quot;, &amp;quot;NETAPP_CLOUD_VOLUMES&amp;quot;, &amp;quot;THIRD_PARTY_SERVICE&amp;quot;, &amp;quot;DELL_POWERSCALE&amp;quot;, &amp;quot;GOOGLE_CLOUD_NETAPP_VOLUMES&amp;quot;]
    /// </summary>
    public string? PeerNetworkType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peer_network_type")?.Value;
        set => this.WithProperty("peer_network_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The relative resource name of the VMware Engine network. Specify the name in the following form:
    /// projects/{project}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId} where {project}
    /// can either be a project number or a project ID.
    /// </summary>
    public string? VmwareEngineNetwork
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vmware_engine_network")?.Value;
        set => this.WithProperty("vmware_engine_network", value == null ? null : new TerraformLiteralProperty<string>(value));
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
