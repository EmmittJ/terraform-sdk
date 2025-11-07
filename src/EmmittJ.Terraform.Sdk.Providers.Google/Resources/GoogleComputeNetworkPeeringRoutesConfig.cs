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
    public TerraformProperty<bool>? ExportCustomRoutes
    {
        get => GetProperty<TerraformProperty<bool>>("export_custom_routes");
        set => this.WithProperty("export_custom_routes", value);
    }

    /// <summary>
    /// Whether subnet routes with public IP range are exported.
    /// IPv4 special-use ranges are always exported to peers and
    /// are not controlled by this field.
    /// </summary>
    public TerraformProperty<bool>? ExportSubnetRoutesWithPublicIp
    {
        get => GetProperty<TerraformProperty<bool>>("export_subnet_routes_with_public_ip");
        set => this.WithProperty("export_subnet_routes_with_public_ip", value);
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
    /// Whether to import the custom routes to the peer network.
    /// </summary>
    public TerraformProperty<bool>? ImportCustomRoutes
    {
        get => GetProperty<TerraformProperty<bool>>("import_custom_routes");
        set => this.WithProperty("import_custom_routes", value);
    }

    /// <summary>
    /// Whether subnet routes with public IP range are imported.
    /// IPv4 special-use ranges are always imported from peers and
    /// are not controlled by this field.
    /// </summary>
    public TerraformProperty<bool>? ImportSubnetRoutesWithPublicIp
    {
        get => GetProperty<TerraformProperty<bool>>("import_subnet_routes_with_public_ip");
        set => this.WithProperty("import_subnet_routes_with_public_ip", value);
    }

    /// <summary>
    /// The name of the primary network for the peering.
    /// </summary>
    public TerraformProperty<string>? Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// Name of the peering.
    /// </summary>
    public TerraformProperty<string>? Peering
    {
        get => GetProperty<TerraformProperty<string>>("peering");
        set => this.WithProperty("peering", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

}
