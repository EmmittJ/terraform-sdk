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
    public bool? ExportCustomRoutes
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("export_custom_routes")?.Value;
        set => this.WithProperty("export_custom_routes", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The export_subnet_routes_with_public_ip attribute.
    /// </summary>
    public bool? ExportSubnetRoutesWithPublicIp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("export_subnet_routes_with_public_ip")?.Value;
        set => this.WithProperty("export_subnet_routes_with_public_ip", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// Whether to export the custom routes from the peer network. Defaults to false.
    /// </summary>
    public bool? ImportCustomRoutes
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("import_custom_routes")?.Value;
        set => this.WithProperty("import_custom_routes", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The import_subnet_routes_with_public_ip attribute.
    /// </summary>
    public bool? ImportSubnetRoutesWithPublicIp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("import_subnet_routes_with_public_ip")?.Value;
        set => this.WithProperty("import_subnet_routes_with_public_ip", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Name of the peering.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The primary network of the peering.
    /// </summary>
    public string? Network
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network")?.Value;
        set => this.WithProperty("network", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The peer network in the peering. The peer network may belong to a different project.
    /// </summary>
    public string? PeerNetwork
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peer_network")?.Value;
        set => this.WithProperty("peer_network", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Which IP version(s) of traffic and routes are allowed to be imported or exported between peer networks. The default value is IPV4_ONLY. Possible values: [&amp;quot;IPV4_ONLY&amp;quot;, &amp;quot;IPV4_IPV6&amp;quot;]
    /// </summary>
    public string? StackType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stack_type")?.Value;
        set => this.WithProperty("stack_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The update strategy determines the semantics for updates and deletes to the peering connection configuration. The default value is INDEPENDENT. Possible values: [&amp;quot;INDEPENDENT&amp;quot;, &amp;quot;CONSENSUS&amp;quot;]
    /// </summary>
    public string? UpdateStrategy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("update_strategy")?.Value;
        set => this.WithProperty("update_strategy", value == null ? null : new TerraformLiteralProperty<string>(value));
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
