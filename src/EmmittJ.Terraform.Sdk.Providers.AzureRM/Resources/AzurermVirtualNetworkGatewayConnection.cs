using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_bgp_addresses in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayConnectionCustomBgpAddressesBlock : TerraformBlock
{
    /// <summary>
    /// The primary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Primary is required")]
    public required TerraformProperty<string> Primary
    {
        get => GetProperty<TerraformProperty<string>>("primary");
        set => WithProperty("primary", value);
    }

    /// <summary>
    /// The secondary attribute.
    /// </summary>
    public TerraformProperty<string>? Secondary
    {
        get => GetProperty<TerraformProperty<string>>("secondary");
        set => WithProperty("secondary", value);
    }

}

/// <summary>
/// Block type for ipsec_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayConnectionIpsecPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The dh_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DhGroup is required")]
    public required TerraformProperty<string> DhGroup
    {
        get => GetProperty<TerraformProperty<string>>("dh_group");
        set => WithProperty("dh_group", value);
    }

    /// <summary>
    /// The ike_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeEncryption is required")]
    public required TerraformProperty<string> IkeEncryption
    {
        get => GetProperty<TerraformProperty<string>>("ike_encryption");
        set => WithProperty("ike_encryption", value);
    }

    /// <summary>
    /// The ike_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeIntegrity is required")]
    public required TerraformProperty<string> IkeIntegrity
    {
        get => GetProperty<TerraformProperty<string>>("ike_integrity");
        set => WithProperty("ike_integrity", value);
    }

    /// <summary>
    /// The ipsec_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecEncryption is required")]
    public required TerraformProperty<string> IpsecEncryption
    {
        get => GetProperty<TerraformProperty<string>>("ipsec_encryption");
        set => WithProperty("ipsec_encryption", value);
    }

    /// <summary>
    /// The ipsec_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecIntegrity is required")]
    public required TerraformProperty<string> IpsecIntegrity
    {
        get => GetProperty<TerraformProperty<string>>("ipsec_integrity");
        set => WithProperty("ipsec_integrity", value);
    }

    /// <summary>
    /// The pfs_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfsGroup is required")]
    public required TerraformProperty<string> PfsGroup
    {
        get => GetProperty<TerraformProperty<string>>("pfs_group");
        set => WithProperty("pfs_group", value);
    }

    /// <summary>
    /// The sa_datasize attribute.
    /// </summary>
    public TerraformProperty<double>? SaDatasize
    {
        get => GetProperty<TerraformProperty<double>>("sa_datasize");
        set => WithProperty("sa_datasize", value);
    }

    /// <summary>
    /// The sa_lifetime attribute.
    /// </summary>
    public TerraformProperty<double>? SaLifetime
    {
        get => GetProperty<TerraformProperty<double>>("sa_lifetime");
        set => WithProperty("sa_lifetime", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkGatewayConnectionTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
/// Block type for traffic_selector_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayConnectionTrafficSelectorPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The local_address_cidrs attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalAddressCidrs is required")]
    public List<TerraformProperty<string>>? LocalAddressCidrs
    {
        get => GetProperty<List<TerraformProperty<string>>>("local_address_cidrs");
        set => WithProperty("local_address_cidrs", value);
    }

    /// <summary>
    /// The remote_address_cidrs attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteAddressCidrs is required")]
    public List<TerraformProperty<string>>? RemoteAddressCidrs
    {
        get => GetProperty<List<TerraformProperty<string>>>("remote_address_cidrs");
        set => WithProperty("remote_address_cidrs", value);
    }

}

/// <summary>
/// Manages a azurerm_virtual_network_gateway_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVirtualNetworkGatewayConnection : TerraformResource
{
    public AzurermVirtualNetworkGatewayConnection(string name) : base("azurerm_virtual_network_gateway_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    public TerraformProperty<string>? AuthorizationKey
    {
        get => GetProperty<TerraformProperty<string>>("authorization_key");
        set => this.WithProperty("authorization_key", value);
    }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionMode
    {
        get => GetProperty<TerraformProperty<string>>("connection_mode");
        set => this.WithProperty("connection_mode", value);
    }

    /// <summary>
    /// The connection_protocol attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionProtocol
    {
        get => GetProperty<TerraformProperty<string>>("connection_protocol");
        set => this.WithProperty("connection_protocol", value);
    }

    /// <summary>
    /// The dpd_timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? DpdTimeoutSeconds
    {
        get => GetProperty<TerraformProperty<double>>("dpd_timeout_seconds");
        set => this.WithProperty("dpd_timeout_seconds", value);
    }

    /// <summary>
    /// The egress_nat_rule_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? EgressNatRuleIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("egress_nat_rule_ids");
        set => this.WithProperty("egress_nat_rule_ids", value);
    }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableBgp
    {
        get => GetProperty<TerraformProperty<bool>>("enable_bgp");
        set => this.WithProperty("enable_bgp", value);
    }

    /// <summary>
    /// The express_route_circuit_id attribute.
    /// </summary>
    public TerraformProperty<string>? ExpressRouteCircuitId
    {
        get => GetProperty<TerraformProperty<string>>("express_route_circuit_id");
        set => this.WithProperty("express_route_circuit_id", value);
    }

    /// <summary>
    /// The express_route_gateway_bypass attribute.
    /// </summary>
    public TerraformProperty<bool>? ExpressRouteGatewayBypass
    {
        get => GetProperty<TerraformProperty<bool>>("express_route_gateway_bypass");
        set => this.WithProperty("express_route_gateway_bypass", value);
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
    /// The ingress_nat_rule_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IngressNatRuleIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("ingress_nat_rule_ids");
        set => this.WithProperty("ingress_nat_rule_ids", value);
    }

    /// <summary>
    /// The local_azure_ip_address_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalAzureIpAddressEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_azure_ip_address_enabled");
        set => this.WithProperty("local_azure_ip_address_enabled", value);
    }

    /// <summary>
    /// The local_network_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? LocalNetworkGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("local_network_gateway_id");
        set => this.WithProperty("local_network_gateway_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The peer_virtual_network_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? PeerVirtualNetworkGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("peer_virtual_network_gateway_id");
        set => this.WithProperty("peer_virtual_network_gateway_id", value);
    }

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PrivateLinkFastPathEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("private_link_fast_path_enabled");
        set => this.WithProperty("private_link_fast_path_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    public TerraformProperty<double>? RoutingWeight
    {
        get => GetProperty<TerraformProperty<double>>("routing_weight");
        set => this.WithProperty("routing_weight", value);
    }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    public TerraformProperty<string>? SharedKey
    {
        get => GetProperty<TerraformProperty<string>>("shared_key");
        set => this.WithProperty("shared_key", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The use_policy_based_traffic_selectors attribute.
    /// </summary>
    public TerraformProperty<bool>? UsePolicyBasedTrafficSelectors
    {
        get => GetProperty<TerraformProperty<bool>>("use_policy_based_traffic_selectors");
        set => this.WithProperty("use_policy_based_traffic_selectors", value);
    }

    /// <summary>
    /// The virtual_network_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkGatewayId is required")]
    public required TerraformProperty<string> VirtualNetworkGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_network_gateway_id");
        set => this.WithProperty("virtual_network_gateway_id", value);
    }

    /// <summary>
    /// Block for custom_bgp_addresses.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomBgpAddresses block(s) allowed")]
    public List<AzurermVirtualNetworkGatewayConnectionCustomBgpAddressesBlock>? CustomBgpAddresses
    {
        get => GetProperty<List<AzurermVirtualNetworkGatewayConnectionCustomBgpAddressesBlock>>("custom_bgp_addresses");
        set => this.WithProperty("custom_bgp_addresses", value);
    }

    /// <summary>
    /// Block for ipsec_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpsecPolicy block(s) allowed")]
    public List<AzurermVirtualNetworkGatewayConnectionIpsecPolicyBlock>? IpsecPolicy
    {
        get => GetProperty<List<AzurermVirtualNetworkGatewayConnectionIpsecPolicyBlock>>("ipsec_policy");
        set => this.WithProperty("ipsec_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualNetworkGatewayConnectionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVirtualNetworkGatewayConnectionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for traffic_selector_policy.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVirtualNetworkGatewayConnectionTrafficSelectorPolicyBlock>? TrafficSelectorPolicy
    {
        get => GetProperty<List<AzurermVirtualNetworkGatewayConnectionTrafficSelectorPolicyBlock>>("traffic_selector_policy");
        set => this.WithProperty("traffic_selector_policy", value);
    }

}
