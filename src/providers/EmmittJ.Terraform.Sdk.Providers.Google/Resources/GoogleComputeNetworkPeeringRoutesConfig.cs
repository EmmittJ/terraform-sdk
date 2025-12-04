using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeNetworkPeeringRoutesConfig.
/// Nesting mode: single
/// </summary>
public class GoogleComputeNetworkPeeringRoutesConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_network_peering_routes_config Terraform resource.
/// Manages a google_compute_network_peering_routes_config resource.
/// </summary>
public partial class GoogleComputeNetworkPeeringRoutesConfig(string name) : TerraformResource("google_compute_network_peering_routes_config", name)
{
    /// <summary>
    /// Whether to export the custom routes to the peer network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportCustomRoutes is required")]
    public required TerraformValue<bool> ExportCustomRoutes
    {
        get => GetArgument<TerraformValue<bool>>("export_custom_routes");
        set => SetArgument("export_custom_routes", value);
    }

    /// <summary>
    /// Whether subnet routes with public IP range are exported.
    /// IPv4 special-use ranges are always exported to peers and
    /// are not controlled by this field.
    /// </summary>
    public TerraformValue<bool>? ExportSubnetRoutesWithPublicIp
    {
        get => GetArgument<TerraformValue<bool>>("export_subnet_routes_with_public_ip");
        set => SetArgument("export_subnet_routes_with_public_ip", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Whether to import the custom routes to the peer network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImportCustomRoutes is required")]
    public required TerraformValue<bool> ImportCustomRoutes
    {
        get => GetArgument<TerraformValue<bool>>("import_custom_routes");
        set => SetArgument("import_custom_routes", value);
    }

    /// <summary>
    /// Whether subnet routes with public IP range are imported.
    /// IPv4 special-use ranges are always imported from peers and
    /// are not controlled by this field.
    /// </summary>
    public TerraformValue<bool>? ImportSubnetRoutesWithPublicIp
    {
        get => GetArgument<TerraformValue<bool>>("import_subnet_routes_with_public_ip");
        set => SetArgument("import_subnet_routes_with_public_ip", value);
    }

    /// <summary>
    /// The name of the primary network for the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// Name of the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Peering is required")]
    public required TerraformValue<string> Peering
    {
        get => GetArgument<TerraformValue<string>>("peering");
        set => SetArgument("peering", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeNetworkPeeringRoutesConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeNetworkPeeringRoutesConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
