using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeNetworkPeeringDataSource.
/// Nesting mode: single
/// </summary>
public class GoogleComputeNetworkPeeringDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a google_compute_network_peering Terraform data source.
/// Retrieves information about a google_compute_network_peering.
/// </summary>
public partial class GoogleComputeNetworkPeeringDataSource(string name) : TerraformDataSource("google_compute_network_peering", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The primary network of the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// Whether to export the custom routes to the peer network. Defaults to false.
    /// </summary>
    public TerraformValue<bool> ExportCustomRoutes
        => AsReference("export_custom_routes");

    /// <summary>
    /// The export_subnet_routes_with_public_ip attribute.
    /// </summary>
    public TerraformValue<bool> ExportSubnetRoutesWithPublicIp
        => AsReference("export_subnet_routes_with_public_ip");

    /// <summary>
    /// Whether to export the custom routes from the peer network. Defaults to false.
    /// </summary>
    public TerraformValue<bool> ImportCustomRoutes
        => AsReference("import_custom_routes");

    /// <summary>
    /// The import_subnet_routes_with_public_ip attribute.
    /// </summary>
    public TerraformValue<bool> ImportSubnetRoutesWithPublicIp
        => AsReference("import_subnet_routes_with_public_ip");

    /// <summary>
    /// The peer network in the peering. The peer network may belong to a different project.
    /// </summary>
    public TerraformValue<string> PeerNetwork
        => AsReference("peer_network");

    /// <summary>
    /// Which IP version(s) of traffic and routes are allowed to be imported or exported between peer networks. The default value is IPV4_ONLY. Possible values: [&amp;quot;IPV4_ONLY&amp;quot;, &amp;quot;IPV4_IPV6&amp;quot;]
    /// </summary>
    public TerraformValue<string> StackType
        => AsReference("stack_type");

    /// <summary>
    /// State for the peering, either ACTIVE or INACTIVE. The peering is ACTIVE when there&#39;s a matching configuration in the peer network.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Details about the current state of the peering.
    /// </summary>
    public TerraformValue<string> StateDetails
        => AsReference("state_details");

    /// <summary>
    /// The update strategy determines the semantics for updates and deletes to the peering connection configuration. The default value is INDEPENDENT. Possible values: [&amp;quot;INDEPENDENT&amp;quot;, &amp;quot;CONSENSUS&amp;quot;]
    /// </summary>
    public TerraformValue<string> UpdateStrategy
        => AsReference("update_strategy");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeNetworkPeeringDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeNetworkPeeringDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
