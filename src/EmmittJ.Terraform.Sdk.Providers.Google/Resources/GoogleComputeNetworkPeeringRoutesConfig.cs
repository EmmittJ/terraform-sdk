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
    public bool? ExportCustomRoutes
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("export_custom_routes")?.Value;
        set => this.WithProperty("export_custom_routes", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Whether subnet routes with public IP range are exported.
    /// IPv4 special-use ranges are always exported to peers and
    /// are not controlled by this field.
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
    /// Whether to import the custom routes to the peer network.
    /// </summary>
    public bool? ImportCustomRoutes
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("import_custom_routes")?.Value;
        set => this.WithProperty("import_custom_routes", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Whether subnet routes with public IP range are imported.
    /// IPv4 special-use ranges are always imported from peers and
    /// are not controlled by this field.
    /// </summary>
    public bool? ImportSubnetRoutesWithPublicIp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("import_subnet_routes_with_public_ip")?.Value;
        set => this.WithProperty("import_subnet_routes_with_public_ip", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The name of the primary network for the peering.
    /// </summary>
    public string? Network
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network")?.Value;
        set => this.WithProperty("network", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the peering.
    /// </summary>
    public string? Peering
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peering")?.Value;
        set => this.WithProperty("peering", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
