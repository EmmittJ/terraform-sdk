using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeNetworkPeeringTimeoutsBlock : TerraformBlock
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
        SetOutput("state");
        SetOutput("state_details");
        SetOutput("export_custom_routes");
        SetOutput("export_subnet_routes_with_public_ip");
        SetOutput("id");
        SetOutput("import_custom_routes");
        SetOutput("import_subnet_routes_with_public_ip");
        SetOutput("name");
        SetOutput("network");
        SetOutput("peer_network");
        SetOutput("stack_type");
        SetOutput("update_strategy");
    }

    /// <summary>
    /// Whether to export the custom routes to the peer network. Defaults to false.
    /// </summary>
    public TerraformProperty<bool> ExportCustomRoutes
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("export_custom_routes");
        set => SetProperty("export_custom_routes", value);
    }

    /// <summary>
    /// The export_subnet_routes_with_public_ip attribute.
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
    /// Whether to export the custom routes from the peer network. Defaults to false.
    /// </summary>
    public TerraformProperty<bool> ImportCustomRoutes
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("import_custom_routes");
        set => SetProperty("import_custom_routes", value);
    }

    /// <summary>
    /// The import_subnet_routes_with_public_ip attribute.
    /// </summary>
    public TerraformProperty<bool> ImportSubnetRoutesWithPublicIp
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("import_subnet_routes_with_public_ip");
        set => SetProperty("import_subnet_routes_with_public_ip", value);
    }

    /// <summary>
    /// Name of the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The primary network of the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network");
        set => SetProperty("network", value);
    }

    /// <summary>
    /// The peer network in the peering. The peer network may belong to a different project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerNetwork is required")]
    public required TerraformProperty<string> PeerNetwork
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peer_network");
        set => SetProperty("peer_network", value);
    }

    /// <summary>
    /// Which IP version(s) of traffic and routes are allowed to be imported or exported between peer networks. The default value is IPV4_ONLY. Possible values: [&amp;quot;IPV4_ONLY&amp;quot;, &amp;quot;IPV4_IPV6&amp;quot;]
    /// </summary>
    public TerraformProperty<string> StackType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stack_type");
        set => SetProperty("stack_type", value);
    }

    /// <summary>
    /// The update strategy determines the semantics for updates and deletes to the peering connection configuration. The default value is INDEPENDENT. Possible values: [&amp;quot;INDEPENDENT&amp;quot;, &amp;quot;CONSENSUS&amp;quot;]
    /// </summary>
    public TerraformProperty<string> UpdateStrategy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("update_strategy");
        set => SetProperty("update_strategy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeNetworkPeeringTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
