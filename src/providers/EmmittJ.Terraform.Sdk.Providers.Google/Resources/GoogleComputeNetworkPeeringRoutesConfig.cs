using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeNetworkPeeringRoutesConfigTimeoutsBlock : TerraformBlock
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
        SetOutput("export_custom_routes");
        SetOutput("export_subnet_routes_with_public_ip");
        SetOutput("id");
        SetOutput("import_custom_routes");
        SetOutput("import_subnet_routes_with_public_ip");
        SetOutput("network");
        SetOutput("peering");
        SetOutput("project");
    }

    /// <summary>
    /// Whether to export the custom routes to the peer network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportCustomRoutes is required")]
    public required TerraformProperty<bool> ExportCustomRoutes
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("export_custom_routes");
        set => SetProperty("export_custom_routes", value);
    }

    /// <summary>
    /// Whether subnet routes with public IP range are exported.
    /// IPv4 special-use ranges are always exported to peers and
    /// are not controlled by this field.
    /// </summary>
    public TerraformProperty<bool> ExportSubnetRoutesWithPublicIp
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("export_subnet_routes_with_public_ip");
        set => SetProperty("export_subnet_routes_with_public_ip", value);
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
    /// Whether to import the custom routes to the peer network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImportCustomRoutes is required")]
    public required TerraformProperty<bool> ImportCustomRoutes
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("import_custom_routes");
        set => SetProperty("import_custom_routes", value);
    }

    /// <summary>
    /// Whether subnet routes with public IP range are imported.
    /// IPv4 special-use ranges are always imported from peers and
    /// are not controlled by this field.
    /// </summary>
    public TerraformProperty<bool> ImportSubnetRoutesWithPublicIp
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("import_subnet_routes_with_public_ip");
        set => SetProperty("import_subnet_routes_with_public_ip", value);
    }

    /// <summary>
    /// The name of the primary network for the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network");
        set => SetProperty("network", value);
    }

    /// <summary>
    /// Name of the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Peering is required")]
    public required TerraformProperty<string> Peering
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peering");
        set => SetProperty("peering", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeNetworkPeeringRoutesConfigTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
