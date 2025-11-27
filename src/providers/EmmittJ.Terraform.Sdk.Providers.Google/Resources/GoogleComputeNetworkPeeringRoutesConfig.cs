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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<bool>(this, "export_custom_routes");
        set => SetArgument("export_custom_routes", value);
    }

    /// <summary>
    /// Whether subnet routes with public IP range are exported.
    /// IPv4 special-use ranges are always exported to peers and
    /// are not controlled by this field.
    /// </summary>
    public TerraformValue<bool> ExportSubnetRoutesWithPublicIp
    {
        get => new TerraformReference<bool>(this, "export_subnet_routes_with_public_ip");
        set => SetArgument("export_subnet_routes_with_public_ip", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Whether to import the custom routes to the peer network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImportCustomRoutes is required")]
    public required TerraformValue<bool> ImportCustomRoutes
    {
        get => new TerraformReference<bool>(this, "import_custom_routes");
        set => SetArgument("import_custom_routes", value);
    }

    /// <summary>
    /// Whether subnet routes with public IP range are imported.
    /// IPv4 special-use ranges are always imported from peers and
    /// are not controlled by this field.
    /// </summary>
    public TerraformValue<bool> ImportSubnetRoutesWithPublicIp
    {
        get => new TerraformReference<bool>(this, "import_subnet_routes_with_public_ip");
        set => SetArgument("import_subnet_routes_with_public_ip", value);
    }

    /// <summary>
    /// The name of the primary network for the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// Name of the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Peering is required")]
    public required TerraformValue<string> Peering
    {
        get => new TerraformReference<string>(this, "peering");
        set => SetArgument("peering", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
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
