using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_network_peering resource.
/// </summary>
public class GoogleComputeNetworkPeering : TerraformResource
{
    public GoogleComputeNetworkPeering(string name) : base("google_compute_network_peering", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("state");
        this.DeclareOutput("state_details");
    }

    /// <summary>
    /// Whether to export the custom routes to the peer network. Defaults to false.
    /// </summary>
    public TerraformLiteralProperty<bool>? ExportCustomRoutes
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("export_custom_routes");
        set => this.WithProperty("export_custom_routes", value);
    }

    /// <summary>
    /// The export_subnet_routes_with_public_ip attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ExportSubnetRoutesWithPublicIp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("export_subnet_routes_with_public_ip");
        set => this.WithProperty("export_subnet_routes_with_public_ip", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Whether to export the custom routes from the peer network. Defaults to false.
    /// </summary>
    public TerraformLiteralProperty<bool>? ImportCustomRoutes
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("import_custom_routes");
        set => this.WithProperty("import_custom_routes", value);
    }

    /// <summary>
    /// The import_subnet_routes_with_public_ip attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ImportSubnetRoutesWithPublicIp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("import_subnet_routes_with_public_ip");
        set => this.WithProperty("import_subnet_routes_with_public_ip", value);
    }

    /// <summary>
    /// Name of the peering.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The primary network of the peering.
    /// </summary>
    public TerraformLiteralProperty<string>? Network
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// The peer network in the peering. The peer network may belong to a different project.
    /// </summary>
    public TerraformLiteralProperty<string>? PeerNetwork
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peer_network");
        set => this.WithProperty("peer_network", value);
    }

    /// <summary>
    /// Which IP version(s) of traffic and routes are allowed to be imported or exported between peer networks. The default value is IPV4_ONLY. Possible values: [&amp;quot;IPV4_ONLY&amp;quot;, &amp;quot;IPV4_IPV6&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? StackType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stack_type");
        set => this.WithProperty("stack_type", value);
    }

    /// <summary>
    /// The update strategy determines the semantics for updates and deletes to the peering connection configuration. The default value is INDEPENDENT. Possible values: [&amp;quot;INDEPENDENT&amp;quot;, &amp;quot;CONSENSUS&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? UpdateStrategy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("update_strategy");
        set => this.WithProperty("update_strategy", value);
    }

    /// <summary>
    /// State for the peering, either ACTIVE or INACTIVE. The peering is ACTIVE when there&#39;s a matching configuration in the peer network.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Details about the current state of the peering.
    /// </summary>
    public TerraformExpression StateDetails => this["state_details"];

}
