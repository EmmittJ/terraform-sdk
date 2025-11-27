using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeNetworkPeering.
/// Nesting mode: single
/// </summary>
public class GoogleComputeNetworkPeeringTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_network_peering Terraform resource.
/// Manages a google_compute_network_peering resource.
/// </summary>
public partial class GoogleComputeNetworkPeering(string name) : TerraformResource("google_compute_network_peering", name)
{
    /// <summary>
    /// Whether to export the custom routes to the peer network. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? ExportCustomRoutes
    {
        get => new TerraformReference<bool>(this, "export_custom_routes");
        set => SetArgument("export_custom_routes", value);
    }

    /// <summary>
    /// The export_subnet_routes_with_public_ip attribute.
    /// </summary>
    public TerraformValue<bool>? ExportSubnetRoutesWithPublicIp
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
    /// Whether to export the custom routes from the peer network. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? ImportCustomRoutes
    {
        get => new TerraformReference<bool>(this, "import_custom_routes");
        set => SetArgument("import_custom_routes", value);
    }

    /// <summary>
    /// The import_subnet_routes_with_public_ip attribute.
    /// </summary>
    public TerraformValue<bool>? ImportSubnetRoutesWithPublicIp
    {
        get => new TerraformReference<bool>(this, "import_subnet_routes_with_public_ip");
        set => SetArgument("import_subnet_routes_with_public_ip", value);
    }

    /// <summary>
    /// Name of the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The primary network of the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The peer network in the peering. The peer network may belong to a different project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerNetwork is required")]
    public required TerraformValue<string> PeerNetwork
    {
        get => new TerraformReference<string>(this, "peer_network");
        set => SetArgument("peer_network", value);
    }

    /// <summary>
    /// Which IP version(s) of traffic and routes are allowed to be imported or exported between peer networks. The default value is IPV4_ONLY. Possible values: [&amp;quot;IPV4_ONLY&amp;quot;, &amp;quot;IPV4_IPV6&amp;quot;]
    /// </summary>
    public TerraformValue<string>? StackType
    {
        get => new TerraformReference<string>(this, "stack_type");
        set => SetArgument("stack_type", value);
    }

    /// <summary>
    /// The update strategy determines the semantics for updates and deletes to the peering connection configuration. The default value is INDEPENDENT. Possible values: [&amp;quot;INDEPENDENT&amp;quot;, &amp;quot;CONSENSUS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? UpdateStrategy
    {
        get => new TerraformReference<string>(this, "update_strategy");
        set => SetArgument("update_strategy", value);
    }

    /// <summary>
    /// State for the peering, either ACTIVE or INACTIVE. The peering is ACTIVE when there&#39;s a matching configuration in the peer network.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// Details about the current state of the peering.
    /// </summary>
    public TerraformValue<string> StateDetails
    {
        get => new TerraformReference<string>(this, "state_details");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeNetworkPeeringTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeNetworkPeeringTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
