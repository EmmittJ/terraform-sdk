using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeNetworkPeeringRoutesConfigTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_network_peering_routes_config resource.
/// </summary>
public class GoogleComputeNetworkPeeringRoutesConfig : TerraformResource
{
    public GoogleComputeNetworkPeeringRoutesConfig(string name) : base("google_compute_network_peering_routes_config", name)
    {
    }

    /// <summary>
    /// Whether to export the custom routes to the peer network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportCustomRoutes is required")]
    [TerraformPropertyName("export_custom_routes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> ExportCustomRoutes { get; set; }

    /// <summary>
    /// Whether subnet routes with public IP range are exported.
    /// IPv4 special-use ranges are always exported to peers and
    /// are not controlled by this field.
    /// </summary>
    [TerraformPropertyName("export_subnet_routes_with_public_ip")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ExportSubnetRoutesWithPublicIp { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "export_subnet_routes_with_public_ip");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Whether to import the custom routes to the peer network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImportCustomRoutes is required")]
    [TerraformPropertyName("import_custom_routes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> ImportCustomRoutes { get; set; }

    /// <summary>
    /// Whether subnet routes with public IP range are imported.
    /// IPv4 special-use ranges are always imported from peers and
    /// are not controlled by this field.
    /// </summary>
    [TerraformPropertyName("import_subnet_routes_with_public_ip")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ImportSubnetRoutesWithPublicIp { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "import_subnet_routes_with_public_ip");

    /// <summary>
    /// The name of the primary network for the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformPropertyName("network")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Network { get; set; }

    /// <summary>
    /// Name of the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Peering is required")]
    [TerraformPropertyName("peering")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Peering { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeNetworkPeeringRoutesConfigTimeoutsBlock>? Timeouts { get; set; } = new();

}
