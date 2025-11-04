using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name or resource link to the VLAN interconnect for this interface. Changing this forces a new interface to be created. Only one of interconnect_attachment, subnetwork or vpn_tunnel can be specified.
    /// </summary>
    public string? InterconnectAttachment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("interconnect_attachment")?.Value;
        set => this.WithProperty("interconnect_attachment", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The IP address and range of the interface. The IP range must be in the RFC3927 link-local IP space. Changing this forces a new interface to be created.
    /// </summary>
    public string? IpRange
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_range")?.Value;
        set => this.WithProperty("ip_range", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// IP version of this interface.
    /// </summary>
    public string? IpVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_version")?.Value;
        set => this.WithProperty("ip_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A unique name for the interface, required by GCE. Changing this forces a new interface to be created.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The regional private internal IP address that is used to establish BGP sessions to a VM instance acting as a third-party Router Appliance. Changing this forces a new interface to be created.
    /// </summary>
    public string? PrivateIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_ip_address")?.Value;
        set => this.WithProperty("private_ip_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the project in which this interface&#39;s router belongs. If it is not provided, the provider project is used. Changing this forces a new interface to be created.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the interface that is redundant to this interface. Changing this forces a new interface to be created.
    /// </summary>
    public string? RedundantInterface
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redundant_interface")?.Value;
        set => this.WithProperty("redundant_interface", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The region this interface&#39;s router sits in. If not specified, the project region will be used. Changing this forces a new interface to be created.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the router this interface will be attached to. Changing this forces a new interface to be created.
    /// </summary>
    public string? Router
    {
        get => GetProperty<TerraformLiteralProperty<string>>("router")?.Value;
        set => this.WithProperty("router", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The URI of the subnetwork resource that this interface belongs to, which must be in the same region as the Cloud Router. Changing this forces a new interface to be created. Only one of subnetwork, interconnect_attachment or vpn_tunnel can be specified.
    /// </summary>
    public string? Subnetwork
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnetwork")?.Value;
        set => this.WithProperty("subnetwork", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name or resource link to the VPN tunnel this interface will be linked to. Changing this forces a new interface to be created. Only one of vpn_tunnel, interconnect_attachment or subnetwork can be specified.
    /// </summary>
    public string? VpnTunnel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpn_tunnel")?.Value;
        set => this.WithProperty("vpn_tunnel", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
