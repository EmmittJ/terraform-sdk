using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeRouterInterfaceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_compute_router_interface resource.
/// </summary>
public partial class GoogleComputeRouterInterface : TerraformResource
{
    public GoogleComputeRouterInterface(string name) : base("google_compute_router_interface", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name or resource link to the VLAN interconnect for this interface. Changing this forces a new interface to be created. Only one of interconnect_attachment, subnetwork or vpn_tunnel can be specified.
    /// </summary>
    [TerraformProperty("interconnect_attachment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InterconnectAttachment { get; set; }

    /// <summary>
    /// The IP address and range of the interface. The IP range must be in the RFC3927 link-local IP space. Changing this forces a new interface to be created.
    /// </summary>
    [TerraformProperty("ip_range")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IpRange { get; set; }

    /// <summary>
    /// IP version of this interface.
    /// </summary>
    [TerraformProperty("ip_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IpVersion { get; set; }

    /// <summary>
    /// A unique name for the interface, required by GCE. Changing this forces a new interface to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The regional private internal IP address that is used to establish BGP sessions to a VM instance acting as a third-party Router Appliance. Changing this forces a new interface to be created.
    /// </summary>
    [TerraformProperty("private_ip_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrivateIpAddress { get; set; }

    /// <summary>
    /// The ID of the project in which this interface&#39;s router belongs. If it is not provided, the provider project is used. Changing this forces a new interface to be created.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The name of the interface that is redundant to this interface. Changing this forces a new interface to be created.
    /// </summary>
    [TerraformProperty("redundant_interface")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RedundantInterface { get; set; }

    /// <summary>
    /// The region this interface&#39;s router sits in. If not specified, the project region will be used. Changing this forces a new interface to be created.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The name of the router this interface will be attached to. Changing this forces a new interface to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Router is required")]
    [TerraformProperty("router")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Router { get; set; }

    /// <summary>
    /// The URI of the subnetwork resource that this interface belongs to, which must be in the same region as the Cloud Router. Changing this forces a new interface to be created. Only one of subnetwork, interconnect_attachment or vpn_tunnel can be specified.
    /// </summary>
    [TerraformProperty("subnetwork")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Subnetwork { get; set; }

    /// <summary>
    /// The name or resource link to the VPN tunnel this interface will be linked to. Changing this forces a new interface to be created. Only one of vpn_tunnel, interconnect_attachment or subnetwork can be specified.
    /// </summary>
    [TerraformProperty("vpn_tunnel")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VpnTunnel { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleComputeRouterInterfaceTimeoutsBlock>? Timeouts { get; set; }

}
