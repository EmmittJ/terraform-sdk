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
        set => SetProperty("primary", value);
    }

    /// <summary>
    /// The secondary attribute.
    /// </summary>
    public TerraformProperty<string>? Secondary
    {
        set => SetProperty("secondary", value);
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
        set => SetProperty("dh_group", value);
    }

    /// <summary>
    /// The ike_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeEncryption is required")]
    public required TerraformProperty<string> IkeEncryption
    {
        set => SetProperty("ike_encryption", value);
    }

    /// <summary>
    /// The ike_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeIntegrity is required")]
    public required TerraformProperty<string> IkeIntegrity
    {
        set => SetProperty("ike_integrity", value);
    }

    /// <summary>
    /// The ipsec_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecEncryption is required")]
    public required TerraformProperty<string> IpsecEncryption
    {
        set => SetProperty("ipsec_encryption", value);
    }

    /// <summary>
    /// The ipsec_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecIntegrity is required")]
    public required TerraformProperty<string> IpsecIntegrity
    {
        set => SetProperty("ipsec_integrity", value);
    }

    /// <summary>
    /// The pfs_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfsGroup is required")]
    public required TerraformProperty<string> PfsGroup
    {
        set => SetProperty("pfs_group", value);
    }

    /// <summary>
    /// The sa_datasize attribute.
    /// </summary>
    public TerraformProperty<double>? SaDatasize
    {
        set => SetProperty("sa_datasize", value);
    }

    /// <summary>
    /// The sa_lifetime attribute.
    /// </summary>
    public TerraformProperty<double>? SaLifetime
    {
        set => SetProperty("sa_lifetime", value);
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
        set => SetProperty("local_address_cidrs", value);
    }

    /// <summary>
    /// The remote_address_cidrs attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteAddressCidrs is required")]
    public List<TerraformProperty<string>>? RemoteAddressCidrs
    {
        set => SetProperty("remote_address_cidrs", value);
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
        SetOutput("authorization_key");
        SetOutput("connection_mode");
        SetOutput("connection_protocol");
        SetOutput("dpd_timeout_seconds");
        SetOutput("egress_nat_rule_ids");
        SetOutput("enable_bgp");
        SetOutput("express_route_circuit_id");
        SetOutput("express_route_gateway_bypass");
        SetOutput("id");
        SetOutput("ingress_nat_rule_ids");
        SetOutput("local_azure_ip_address_enabled");
        SetOutput("local_network_gateway_id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("peer_virtual_network_gateway_id");
        SetOutput("private_link_fast_path_enabled");
        SetOutput("resource_group_name");
        SetOutput("routing_weight");
        SetOutput("shared_key");
        SetOutput("tags");
        SetOutput("type");
        SetOutput("use_policy_based_traffic_selectors");
        SetOutput("virtual_network_gateway_id");
    }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    public TerraformProperty<string> AuthorizationKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authorization_key");
        set => SetProperty("authorization_key", value);
    }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    public TerraformProperty<string> ConnectionMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_mode");
        set => SetProperty("connection_mode", value);
    }

    /// <summary>
    /// The connection_protocol attribute.
    /// </summary>
    public TerraformProperty<string> ConnectionProtocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_protocol");
        set => SetProperty("connection_protocol", value);
    }

    /// <summary>
    /// The dpd_timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double> DpdTimeoutSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("dpd_timeout_seconds");
        set => SetProperty("dpd_timeout_seconds", value);
    }

    /// <summary>
    /// The egress_nat_rule_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> EgressNatRuleIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("egress_nat_rule_ids");
        set => SetProperty("egress_nat_rule_ids", value);
    }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    public TerraformProperty<bool> EnableBgp
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_bgp");
        set => SetProperty("enable_bgp", value);
    }

    /// <summary>
    /// The express_route_circuit_id attribute.
    /// </summary>
    public TerraformProperty<string> ExpressRouteCircuitId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("express_route_circuit_id");
        set => SetProperty("express_route_circuit_id", value);
    }

    /// <summary>
    /// The express_route_gateway_bypass attribute.
    /// </summary>
    public TerraformProperty<bool> ExpressRouteGatewayBypass
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("express_route_gateway_bypass");
        set => SetProperty("express_route_gateway_bypass", value);
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
    /// The ingress_nat_rule_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> IngressNatRuleIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("ingress_nat_rule_ids");
        set => SetProperty("ingress_nat_rule_ids", value);
    }

    /// <summary>
    /// The local_azure_ip_address_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> LocalAzureIpAddressEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("local_azure_ip_address_enabled");
        set => SetProperty("local_azure_ip_address_enabled", value);
    }

    /// <summary>
    /// The local_network_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string> LocalNetworkGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("local_network_gateway_id");
        set => SetProperty("local_network_gateway_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The peer_virtual_network_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string> PeerVirtualNetworkGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peer_virtual_network_gateway_id");
        set => SetProperty("peer_virtual_network_gateway_id", value);
    }

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PrivateLinkFastPathEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("private_link_fast_path_enabled");
        set => SetProperty("private_link_fast_path_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    public TerraformProperty<double> RoutingWeight
    {
        get => GetRequiredOutput<TerraformProperty<double>>("routing_weight");
        set => SetProperty("routing_weight", value);
    }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    public TerraformProperty<string> SharedKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("shared_key");
        set => SetProperty("shared_key", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The use_policy_based_traffic_selectors attribute.
    /// </summary>
    public TerraformProperty<bool> UsePolicyBasedTrafficSelectors
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("use_policy_based_traffic_selectors");
        set => SetProperty("use_policy_based_traffic_selectors", value);
    }

    /// <summary>
    /// The virtual_network_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkGatewayId is required")]
    public required TerraformProperty<string> VirtualNetworkGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_network_gateway_id");
        set => SetProperty("virtual_network_gateway_id", value);
    }

    /// <summary>
    /// Block for custom_bgp_addresses.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomBgpAddresses block(s) allowed")]
    public List<AzurermVirtualNetworkGatewayConnectionCustomBgpAddressesBlock>? CustomBgpAddresses
    {
        set => SetProperty("custom_bgp_addresses", value);
    }

    /// <summary>
    /// Block for ipsec_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpsecPolicy block(s) allowed")]
    public List<AzurermVirtualNetworkGatewayConnectionIpsecPolicyBlock>? IpsecPolicy
    {
        set => SetProperty("ipsec_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualNetworkGatewayConnectionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for traffic_selector_policy.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVirtualNetworkGatewayConnectionTrafficSelectorPolicyBlock>? TrafficSelectorPolicy
    {
        set => SetProperty("traffic_selector_policy", value);
    }

}
