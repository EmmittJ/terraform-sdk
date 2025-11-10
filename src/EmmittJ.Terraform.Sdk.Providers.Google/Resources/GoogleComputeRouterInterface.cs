using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRouterInterfaceTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_compute_router_interface resource.
/// </summary>
public class GoogleComputeRouterInterface : TerraformResource
{
    public GoogleComputeRouterInterface(string name) : base("google_compute_router_interface", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The name or resource link to the VLAN interconnect for this interface. Changing this forces a new interface to be created. Only one of interconnect_attachment, subnetwork or vpn_tunnel can be specified.
    /// </summary>
    public TerraformProperty<string>? InterconnectAttachment
    {
        get => GetProperty<TerraformProperty<string>>("interconnect_attachment");
        set => this.WithProperty("interconnect_attachment", value);
    }

    /// <summary>
    /// The IP address and range of the interface. The IP range must be in the RFC3927 link-local IP space. Changing this forces a new interface to be created.
    /// </summary>
    public TerraformProperty<string>? IpRange
    {
        get => GetProperty<TerraformProperty<string>>("ip_range");
        set => this.WithProperty("ip_range", value);
    }

    /// <summary>
    /// IP version of this interface.
    /// </summary>
    public TerraformProperty<string>? IpVersion
    {
        get => GetProperty<TerraformProperty<string>>("ip_version");
        set => this.WithProperty("ip_version", value);
    }

    /// <summary>
    /// A unique name for the interface, required by GCE. Changing this forces a new interface to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The regional private internal IP address that is used to establish BGP sessions to a VM instance acting as a third-party Router Appliance. Changing this forces a new interface to be created.
    /// </summary>
    public TerraformProperty<string>? PrivateIpAddress
    {
        get => GetProperty<TerraformProperty<string>>("private_ip_address");
        set => this.WithProperty("private_ip_address", value);
    }

    /// <summary>
    /// The ID of the project in which this interface&#39;s router belongs. If it is not provided, the provider project is used. Changing this forces a new interface to be created.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The name of the interface that is redundant to this interface. Changing this forces a new interface to be created.
    /// </summary>
    public TerraformProperty<string>? RedundantInterface
    {
        get => GetProperty<TerraformProperty<string>>("redundant_interface");
        set => this.WithProperty("redundant_interface", value);
    }

    /// <summary>
    /// The region this interface&#39;s router sits in. If not specified, the project region will be used. Changing this forces a new interface to be created.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The name of the router this interface will be attached to. Changing this forces a new interface to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Router is required")]
    public required TerraformProperty<string> Router
    {
        get => GetProperty<TerraformProperty<string>>("router");
        set => this.WithProperty("router", value);
    }

    /// <summary>
    /// The URI of the subnetwork resource that this interface belongs to, which must be in the same region as the Cloud Router. Changing this forces a new interface to be created. Only one of subnetwork, interconnect_attachment or vpn_tunnel can be specified.
    /// </summary>
    public TerraformProperty<string>? Subnetwork
    {
        get => GetProperty<TerraformProperty<string>>("subnetwork");
        set => this.WithProperty("subnetwork", value);
    }

    /// <summary>
    /// The name or resource link to the VPN tunnel this interface will be linked to. Changing this forces a new interface to be created. Only one of vpn_tunnel, interconnect_attachment or subnetwork can be specified.
    /// </summary>
    public TerraformProperty<string>? VpnTunnel
    {
        get => GetProperty<TerraformProperty<string>>("vpn_tunnel");
        set => this.WithProperty("vpn_tunnel", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeRouterInterfaceTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeRouterInterfaceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
