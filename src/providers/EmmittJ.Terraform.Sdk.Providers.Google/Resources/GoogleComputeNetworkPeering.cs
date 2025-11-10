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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.WithOutput("state");
        this.WithOutput("state_details");
    }

    /// <summary>
    /// Whether to export the custom routes to the peer network. Defaults to false.
    /// </summary>
    public TerraformProperty<bool>? ExportCustomRoutes
    {
        get => GetProperty<TerraformProperty<bool>>("export_custom_routes");
        set => this.WithProperty("export_custom_routes", value);
    }

    /// <summary>
    /// The export_subnet_routes_with_public_ip attribute.
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
    /// Whether to export the custom routes from the peer network. Defaults to false.
    /// </summary>
    public TerraformProperty<bool>? ImportCustomRoutes
    {
        get => GetProperty<TerraformProperty<bool>>("import_custom_routes");
        set => this.WithProperty("import_custom_routes", value);
    }

    /// <summary>
    /// The import_subnet_routes_with_public_ip attribute.
    /// </summary>
    public TerraformProperty<bool>? ImportSubnetRoutesWithPublicIp
    {
        get => GetProperty<TerraformProperty<bool>>("import_subnet_routes_with_public_ip");
        set => this.WithProperty("import_subnet_routes_with_public_ip", value);
    }

    /// <summary>
    /// Name of the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The primary network of the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetRequiredProperty<TerraformProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// The peer network in the peering. The peer network may belong to a different project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerNetwork is required")]
    public required TerraformProperty<string> PeerNetwork
    {
        get => GetRequiredProperty<TerraformProperty<string>>("peer_network");
        set => this.WithProperty("peer_network", value);
    }

    /// <summary>
    /// Which IP version(s) of traffic and routes are allowed to be imported or exported between peer networks. The default value is IPV4_ONLY. Possible values: [&amp;quot;IPV4_ONLY&amp;quot;, &amp;quot;IPV4_IPV6&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? StackType
    {
        get => GetProperty<TerraformProperty<string>>("stack_type");
        set => this.WithProperty("stack_type", value);
    }

    /// <summary>
    /// The update strategy determines the semantics for updates and deletes to the peering connection configuration. The default value is INDEPENDENT. Possible values: [&amp;quot;INDEPENDENT&amp;quot;, &amp;quot;CONSENSUS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? UpdateStrategy
    {
        get => GetProperty<TerraformProperty<string>>("update_strategy");
        set => this.WithProperty("update_strategy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeNetworkPeeringTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeNetworkPeeringTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
