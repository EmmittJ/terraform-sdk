using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeRouterInterface.
/// Nesting mode: single
/// </summary>
public class GoogleComputeRouterInterfaceTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_compute_router_interface Terraform resource.
/// Manages a google_compute_router_interface resource.
/// </summary>
public partial class GoogleComputeRouterInterface(string name) : TerraformResource("google_compute_router_interface", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name or resource link to the VLAN interconnect for this interface. Changing this forces a new interface to be created. Only one of interconnect_attachment, subnetwork or vpn_tunnel can be specified.
    /// </summary>
    public TerraformValue<string>? InterconnectAttachment
    {
        get => new TerraformReference<string>(this, "interconnect_attachment");
        set => SetArgument("interconnect_attachment", value);
    }

    /// <summary>
    /// The IP address and range of the interface. The IP range must be in the RFC3927 link-local IP space. Changing this forces a new interface to be created.
    /// </summary>
    public TerraformValue<string> IpRange
    {
        get => new TerraformReference<string>(this, "ip_range");
        set => SetArgument("ip_range", value);
    }

    /// <summary>
    /// IP version of this interface.
    /// </summary>
    public TerraformValue<string> IpVersion
    {
        get => new TerraformReference<string>(this, "ip_version");
        set => SetArgument("ip_version", value);
    }

    /// <summary>
    /// A unique name for the interface, required by GCE. Changing this forces a new interface to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The regional private internal IP address that is used to establish BGP sessions to a VM instance acting as a third-party Router Appliance. Changing this forces a new interface to be created.
    /// </summary>
    public TerraformValue<string>? PrivateIpAddress
    {
        get => new TerraformReference<string>(this, "private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The ID of the project in which this interface&#39;s router belongs. If it is not provided, the provider project is used. Changing this forces a new interface to be created.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The name of the interface that is redundant to this interface. Changing this forces a new interface to be created.
    /// </summary>
    public TerraformValue<string> RedundantInterface
    {
        get => new TerraformReference<string>(this, "redundant_interface");
        set => SetArgument("redundant_interface", value);
    }

    /// <summary>
    /// The region this interface&#39;s router sits in. If not specified, the project region will be used. Changing this forces a new interface to be created.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The name of the router this interface will be attached to. Changing this forces a new interface to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Router is required")]
    public required TerraformValue<string> Router
    {
        get => new TerraformReference<string>(this, "router");
        set => SetArgument("router", value);
    }

    /// <summary>
    /// The URI of the subnetwork resource that this interface belongs to, which must be in the same region as the Cloud Router. Changing this forces a new interface to be created. Only one of subnetwork, interconnect_attachment or vpn_tunnel can be specified.
    /// </summary>
    public TerraformValue<string>? Subnetwork
    {
        get => new TerraformReference<string>(this, "subnetwork");
        set => SetArgument("subnetwork", value);
    }

    /// <summary>
    /// The name or resource link to the VPN tunnel this interface will be linked to. Changing this forces a new interface to be created. Only one of vpn_tunnel, interconnect_attachment or subnetwork can be specified.
    /// </summary>
    public TerraformValue<string>? VpnTunnel
    {
        get => new TerraformReference<string>(this, "vpn_tunnel");
        set => SetArgument("vpn_tunnel", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeRouterInterfaceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeRouterInterfaceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
