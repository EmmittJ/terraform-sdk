using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_network_peering.
/// </summary>
public class GoogleComputeNetworkPeeringDataSource : TerraformDataSource
{
    public GoogleComputeNetworkPeeringDataSource(string name) : base("google_compute_network_peering", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("export_custom_routes");
        this.DeclareOutput("export_subnet_routes_with_public_ip");
        this.DeclareOutput("import_custom_routes");
        this.DeclareOutput("import_subnet_routes_with_public_ip");
        this.DeclareOutput("peer_network");
        this.DeclareOutput("stack_type");
        this.DeclareOutput("state");
        this.DeclareOutput("state_details");
        this.DeclareOutput("update_strategy");
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
    /// Whether to export the custom routes to the peer network. Defaults to false.
    /// </summary>
    public TerraformExpression ExportCustomRoutes => this["export_custom_routes"];

    /// <summary>
    /// The export_subnet_routes_with_public_ip attribute.
    /// </summary>
    public TerraformExpression ExportSubnetRoutesWithPublicIp => this["export_subnet_routes_with_public_ip"];

    /// <summary>
    /// Whether to export the custom routes from the peer network. Defaults to false.
    /// </summary>
    public TerraformExpression ImportCustomRoutes => this["import_custom_routes"];

    /// <summary>
    /// The import_subnet_routes_with_public_ip attribute.
    /// </summary>
    public TerraformExpression ImportSubnetRoutesWithPublicIp => this["import_subnet_routes_with_public_ip"];

    /// <summary>
    /// The peer network in the peering. The peer network may belong to a different project.
    /// </summary>
    public TerraformExpression PeerNetwork => this["peer_network"];

    /// <summary>
    /// Which IP version(s) of traffic and routes are allowed to be imported or exported between peer networks. The default value is IPV4_ONLY. Possible values: [&amp;quot;IPV4_ONLY&amp;quot;, &amp;quot;IPV4_IPV6&amp;quot;]
    /// </summary>
    public TerraformExpression StackType => this["stack_type"];

    /// <summary>
    /// State for the peering, either ACTIVE or INACTIVE. The peering is ACTIVE when there&#39;s a matching configuration in the peer network.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Details about the current state of the peering.
    /// </summary>
    public TerraformExpression StateDetails => this["state_details"];

    /// <summary>
    /// The update strategy determines the semantics for updates and deletes to the peering connection configuration. The default value is INDEPENDENT. Possible values: [&amp;quot;INDEPENDENT&amp;quot;, &amp;quot;CONSENSUS&amp;quot;]
    /// </summary>
    public TerraformExpression UpdateStrategy => this["update_strategy"];

}
