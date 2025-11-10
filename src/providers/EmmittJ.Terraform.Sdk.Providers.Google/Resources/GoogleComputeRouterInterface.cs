using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRouterInterfaceTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a google_compute_router_interface resource.
/// </summary>
public class GoogleComputeRouterInterface : TerraformResource
{
    public GoogleComputeRouterInterface(string name) : base("google_compute_router_interface", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name or resource link to the VLAN interconnect for this interface. Changing this forces a new interface to be created. Only one of interconnect_attachment, subnetwork or vpn_tunnel can be specified.
    /// </summary>
    [TerraformPropertyName("interconnect_attachment")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InterconnectAttachment { get; set; }

    /// <summary>
    /// The IP address and range of the interface. The IP range must be in the RFC3927 link-local IP space. Changing this forces a new interface to be created.
    /// </summary>
    [TerraformPropertyName("ip_range")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IpRange { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_range");

    /// <summary>
    /// IP version of this interface.
    /// </summary>
    [TerraformPropertyName("ip_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IpVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_version");

    /// <summary>
    /// A unique name for the interface, required by GCE. Changing this forces a new interface to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The regional private internal IP address that is used to establish BGP sessions to a VM instance acting as a third-party Router Appliance. Changing this forces a new interface to be created.
    /// </summary>
    [TerraformPropertyName("private_ip_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrivateIpAddress { get; set; }

    /// <summary>
    /// The ID of the project in which this interface&#39;s router belongs. If it is not provided, the provider project is used. Changing this forces a new interface to be created.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The name of the interface that is redundant to this interface. Changing this forces a new interface to be created.
    /// </summary>
    [TerraformPropertyName("redundant_interface")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RedundantInterface { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "redundant_interface");

    /// <summary>
    /// The region this interface&#39;s router sits in. If not specified, the project region will be used. Changing this forces a new interface to be created.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The name of the router this interface will be attached to. Changing this forces a new interface to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Router is required")]
    [TerraformPropertyName("router")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Router { get; set; }

    /// <summary>
    /// The URI of the subnetwork resource that this interface belongs to, which must be in the same region as the Cloud Router. Changing this forces a new interface to be created. Only one of subnetwork, interconnect_attachment or vpn_tunnel can be specified.
    /// </summary>
    [TerraformPropertyName("subnetwork")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Subnetwork { get; set; }

    /// <summary>
    /// The name or resource link to the VPN tunnel this interface will be linked to. Changing this forces a new interface to be created. Only one of vpn_tunnel, interconnect_attachment or subnetwork can be specified.
    /// </summary>
    [TerraformPropertyName("vpn_tunnel")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VpnTunnel { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeRouterInterfaceTimeoutsBlock>? Timeouts { get; set; } = new();

}
