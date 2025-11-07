using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_network_peering_routes_config resource.
/// </summary>
public class GoogleComputeNetworkPeeringRoutesConfig : TerraformResource
{
    public GoogleComputeNetworkPeeringRoutesConfig(string name) : base("google_compute_network_peering_routes_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Whether to export the custom routes to the peer network.
    /// </summary>
    public TerraformLiteralProperty<bool>? ExportCustomRoutes
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("export_custom_routes");
        set => this.WithProperty("export_custom_routes", value);
    }

    /// <summary>
    /// Whether subnet routes with public IP range are exported.
    /// IPv4 special-use ranges are always exported to peers and
    /// are not controlled by this field.
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
    /// Whether to import the custom routes to the peer network.
    /// </summary>
    public TerraformLiteralProperty<bool>? ImportCustomRoutes
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("import_custom_routes");
        set => this.WithProperty("import_custom_routes", value);
    }

    /// <summary>
    /// Whether subnet routes with public IP range are imported.
    /// IPv4 special-use ranges are always imported from peers and
    /// are not controlled by this field.
    /// </summary>
    public TerraformLiteralProperty<bool>? ImportSubnetRoutesWithPublicIp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("import_subnet_routes_with_public_ip");
        set => this.WithProperty("import_subnet_routes_with_public_ip", value);
    }

    /// <summary>
    /// The name of the primary network for the peering.
    /// </summary>
    public TerraformLiteralProperty<string>? Network
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// Name of the peering.
    /// </summary>
    public TerraformLiteralProperty<string>? Peering
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peering");
        set => this.WithProperty("peering", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

}
