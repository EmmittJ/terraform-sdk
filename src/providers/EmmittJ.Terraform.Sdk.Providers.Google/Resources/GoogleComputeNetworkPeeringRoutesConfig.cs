using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeNetworkPeeringRoutesConfigTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    public required TerraformValue<bool> ExportCustomRoutes { get; set; }

    /// <summary>
    /// Whether subnet routes with public IP range are exported.
    /// IPv4 special-use ranges are always exported to peers and
    /// are not controlled by this field.
    /// </summary>
    [TerraformPropertyName("export_subnet_routes_with_public_ip")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ExportSubnetRoutesWithPublicIp { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Whether to import the custom routes to the peer network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImportCustomRoutes is required")]
    [TerraformPropertyName("import_custom_routes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> ImportCustomRoutes { get; set; }

    /// <summary>
    /// Whether subnet routes with public IP range are imported.
    /// IPv4 special-use ranges are always imported from peers and
    /// are not controlled by this field.
    /// </summary>
    [TerraformPropertyName("import_subnet_routes_with_public_ip")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ImportSubnetRoutesWithPublicIp { get; set; } = default!;

    /// <summary>
    /// The name of the primary network for the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformPropertyName("network")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Network { get; set; }

    /// <summary>
    /// Name of the peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Peering is required")]
    [TerraformPropertyName("peering")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Peering { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeNetworkPeeringRoutesConfigTimeoutsBlock>? Timeouts { get; set; }

}
