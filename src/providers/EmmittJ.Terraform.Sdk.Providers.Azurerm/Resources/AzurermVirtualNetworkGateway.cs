using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for bgp_settings in AzurermVirtualNetworkGateway.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayBgpSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bgp_settings";

    /// <summary>
    /// The asn attribute.
    /// </summary>
    public TerraformValue<double>? Asn
    {
        get => GetArgument<TerraformValue<double>>("asn");
        set => SetArgument("asn", value);
    }

    /// <summary>
    /// The peer_weight attribute.
    /// </summary>
    public TerraformValue<double>? PeerWeight
    {
        get => GetArgument<TerraformValue<double>>("peer_weight");
        set => SetArgument("peer_weight", value);
    }

    /// <summary>
    /// PeeringAddresses block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 PeeringAddresses block(s) allowed")]
    public TerraformList<AzurermVirtualNetworkGatewayBgpSettingsBlockPeeringAddressesBlock>? PeeringAddresses
    {
        get => GetArgument<TerraformList<AzurermVirtualNetworkGatewayBgpSettingsBlockPeeringAddressesBlock>>("peering_addresses");
        set => SetArgument("peering_addresses", value);
    }

}

/// <summary>
/// Block type for peering_addresses in AzurermVirtualNetworkGatewayBgpSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayBgpSettingsBlockPeeringAddressesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "peering_addresses";

    /// <summary>
    /// The apipa_addresses attribute.
    /// </summary>
    public TerraformList<string>? ApipaAddresses
    {
        get => GetArgument<TerraformList<string>>("apipa_addresses");
        set => SetArgument("apipa_addresses", value);
    }

    /// <summary>
    /// The default_addresses attribute.
    /// </summary>
    public TerraformList<string> DefaultAddresses
        => AsReference("default_addresses");

    /// <summary>
    /// The ip_configuration_name attribute.
    /// </summary>
    public TerraformValue<string>? IpConfigurationName
    {
        get => GetArgument<TerraformValue<string>>("ip_configuration_name");
        set => SetArgument("ip_configuration_name", value);
    }

    /// <summary>
    /// The tunnel_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> TunnelIpAddresses
        => AsReference("tunnel_ip_addresses");

}


/// <summary>
/// Block type for custom_route in AzurermVirtualNetworkGateway.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayCustomRouteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_route";

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    public TerraformSet<string>? AddressPrefixes
    {
        get => GetArgument<TerraformSet<string>>("address_prefixes");
        set => SetArgument("address_prefixes", value);
    }

}


/// <summary>
/// Block type for ip_configuration in AzurermVirtualNetworkGateway.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_configuration";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    public TerraformValue<string>? PrivateIpAddressAllocation
    {
        get => GetArgument<TerraformValue<string>>("private_ip_address_allocation");
        set => SetArgument("private_ip_address_allocation", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformValue<string>? PublicIpAddressId
    {
        get => GetArgument<TerraformValue<string>>("public_ip_address_id");
        set => SetArgument("public_ip_address_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for policy_group in AzurermVirtualNetworkGateway.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayPolicyGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_group";

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    public TerraformValue<bool>? IsDefault
    {
        get => GetArgument<TerraformValue<bool>>("is_default");
        set => SetArgument("is_default", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// PolicyMember block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyMember is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PolicyMember block(s) required")]
    public required TerraformList<AzurermVirtualNetworkGatewayPolicyGroupBlockPolicyMemberBlock> PolicyMember
    {
        get => GetRequiredArgument<TerraformList<AzurermVirtualNetworkGatewayPolicyGroupBlockPolicyMemberBlock>>("policy_member");
        set => SetArgument("policy_member", value);
    }

}

/// <summary>
/// Block type for policy_member in AzurermVirtualNetworkGatewayPolicyGroupBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayPolicyGroupBlockPolicyMemberBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_member";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermVirtualNetworkGateway.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkGatewayTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for vpn_client_configuration in AzurermVirtualNetworkGateway.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayVpnClientConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpn_client_configuration";

    /// <summary>
    /// The aad_audience attribute.
    /// </summary>
    public TerraformValue<string>? AadAudience
    {
        get => GetArgument<TerraformValue<string>>("aad_audience");
        set => SetArgument("aad_audience", value);
    }

    /// <summary>
    /// The aad_issuer attribute.
    /// </summary>
    public TerraformValue<string>? AadIssuer
    {
        get => GetArgument<TerraformValue<string>>("aad_issuer");
        set => SetArgument("aad_issuer", value);
    }

    /// <summary>
    /// The aad_tenant attribute.
    /// </summary>
    public TerraformValue<string>? AadTenant
    {
        get => GetArgument<TerraformValue<string>>("aad_tenant");
        set => SetArgument("aad_tenant", value);
    }

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressSpace is required")]
    public TerraformList<string>? AddressSpace
    {
        get => GetArgument<TerraformList<string>>("address_space");
        set => SetArgument("address_space", value);
    }

    /// <summary>
    /// The radius_server_address attribute.
    /// </summary>
    public TerraformValue<string>? RadiusServerAddress
    {
        get => GetArgument<TerraformValue<string>>("radius_server_address");
        set => SetArgument("radius_server_address", value);
    }

    /// <summary>
    /// The radius_server_secret attribute.
    /// </summary>
    public TerraformValue<string>? RadiusServerSecret
    {
        get => GetArgument<TerraformValue<string>>("radius_server_secret");
        set => SetArgument("radius_server_secret", value);
    }

    /// <summary>
    /// The vpn_auth_types attribute.
    /// </summary>
    public TerraformSet<string>? VpnAuthTypes
    {
        get => GetArgument<TerraformSet<string>>("vpn_auth_types");
        set => SetArgument("vpn_auth_types", value);
    }

    /// <summary>
    /// The vpn_client_protocols attribute.
    /// </summary>
    public TerraformSet<string>? VpnClientProtocols
    {
        get => GetArgument<TerraformSet<string>>("vpn_client_protocols");
        set => SetArgument("vpn_client_protocols", value);
    }

    /// <summary>
    /// IpsecPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpsecPolicy block(s) allowed")]
    public TerraformList<AzurermVirtualNetworkGatewayVpnClientConfigurationBlockIpsecPolicyBlock>? IpsecPolicy
    {
        get => GetArgument<TerraformList<AzurermVirtualNetworkGatewayVpnClientConfigurationBlockIpsecPolicyBlock>>("ipsec_policy");
        set => SetArgument("ipsec_policy", value);
    }

    /// <summary>
    /// RadiusServer block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVirtualNetworkGatewayVpnClientConfigurationBlockRadiusServerBlock>? RadiusServer
    {
        get => GetArgument<TerraformList<AzurermVirtualNetworkGatewayVpnClientConfigurationBlockRadiusServerBlock>>("radius_server");
        set => SetArgument("radius_server", value);
    }

    /// <summary>
    /// RevokedCertificate block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermVirtualNetworkGatewayVpnClientConfigurationBlockRevokedCertificateBlock>? RevokedCertificate
    {
        get => GetArgument<TerraformSet<AzurermVirtualNetworkGatewayVpnClientConfigurationBlockRevokedCertificateBlock>>("revoked_certificate");
        set => SetArgument("revoked_certificate", value);
    }

    /// <summary>
    /// RootCertificate block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermVirtualNetworkGatewayVpnClientConfigurationBlockRootCertificateBlock>? RootCertificate
    {
        get => GetArgument<TerraformSet<AzurermVirtualNetworkGatewayVpnClientConfigurationBlockRootCertificateBlock>>("root_certificate");
        set => SetArgument("root_certificate", value);
    }

    /// <summary>
    /// VirtualNetworkGatewayClientConnection block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVirtualNetworkGatewayVpnClientConfigurationBlockVirtualNetworkGatewayClientConnectionBlock>? VirtualNetworkGatewayClientConnection
    {
        get => GetArgument<TerraformList<AzurermVirtualNetworkGatewayVpnClientConfigurationBlockVirtualNetworkGatewayClientConnectionBlock>>("virtual_network_gateway_client_connection");
        set => SetArgument("virtual_network_gateway_client_connection", value);
    }

}

/// <summary>
/// Block type for ipsec_policy in AzurermVirtualNetworkGatewayVpnClientConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayVpnClientConfigurationBlockIpsecPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ipsec_policy";

    /// <summary>
    /// The dh_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DhGroup is required")]
    public required TerraformValue<string> DhGroup
    {
        get => GetArgument<TerraformValue<string>>("dh_group");
        set => SetArgument("dh_group", value);
    }

    /// <summary>
    /// The ike_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeEncryption is required")]
    public required TerraformValue<string> IkeEncryption
    {
        get => GetArgument<TerraformValue<string>>("ike_encryption");
        set => SetArgument("ike_encryption", value);
    }

    /// <summary>
    /// The ike_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeIntegrity is required")]
    public required TerraformValue<string> IkeIntegrity
    {
        get => GetArgument<TerraformValue<string>>("ike_integrity");
        set => SetArgument("ike_integrity", value);
    }

    /// <summary>
    /// The ipsec_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecEncryption is required")]
    public required TerraformValue<string> IpsecEncryption
    {
        get => GetArgument<TerraformValue<string>>("ipsec_encryption");
        set => SetArgument("ipsec_encryption", value);
    }

    /// <summary>
    /// The ipsec_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecIntegrity is required")]
    public required TerraformValue<string> IpsecIntegrity
    {
        get => GetArgument<TerraformValue<string>>("ipsec_integrity");
        set => SetArgument("ipsec_integrity", value);
    }

    /// <summary>
    /// The pfs_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfsGroup is required")]
    public required TerraformValue<string> PfsGroup
    {
        get => GetArgument<TerraformValue<string>>("pfs_group");
        set => SetArgument("pfs_group", value);
    }

    /// <summary>
    /// The sa_data_size_in_kilobytes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SaDataSizeInKilobytes is required")]
    public required TerraformValue<double> SaDataSizeInKilobytes
    {
        get => GetArgument<TerraformValue<double>>("sa_data_size_in_kilobytes");
        set => SetArgument("sa_data_size_in_kilobytes", value);
    }

    /// <summary>
    /// The sa_lifetime_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SaLifetimeInSeconds is required")]
    public required TerraformValue<double> SaLifetimeInSeconds
    {
        get => GetArgument<TerraformValue<double>>("sa_lifetime_in_seconds");
        set => SetArgument("sa_lifetime_in_seconds", value);
    }

}

/// <summary>
/// Block type for radius_server in AzurermVirtualNetworkGatewayVpnClientConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayVpnClientConfigurationBlockRadiusServerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "radius_server";

    /// <summary>
    /// The address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Address is required")]
    public required TerraformValue<string> Address
    {
        get => GetArgument<TerraformValue<string>>("address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// The score attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Score is required")]
    public required TerraformValue<double> Score
    {
        get => GetArgument<TerraformValue<double>>("score");
        set => SetArgument("score", value);
    }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformValue<string> Secret
    {
        get => GetArgument<TerraformValue<string>>("secret");
        set => SetArgument("secret", value);
    }

}

/// <summary>
/// Block type for revoked_certificate in AzurermVirtualNetworkGatewayVpnClientConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AzurermVirtualNetworkGatewayVpnClientConfigurationBlockRevokedCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "revoked_certificate";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thumbprint is required")]
    public required TerraformValue<string> Thumbprint
    {
        get => GetArgument<TerraformValue<string>>("thumbprint");
        set => SetArgument("thumbprint", value);
    }

}

/// <summary>
/// Block type for root_certificate in AzurermVirtualNetworkGatewayVpnClientConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AzurermVirtualNetworkGatewayVpnClientConfigurationBlockRootCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "root_certificate";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_cert_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicCertData is required")]
    public required TerraformValue<string> PublicCertData
    {
        get => GetArgument<TerraformValue<string>>("public_cert_data");
        set => SetArgument("public_cert_data", value);
    }

}

/// <summary>
/// Block type for virtual_network_gateway_client_connection in AzurermVirtualNetworkGatewayVpnClientConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayVpnClientConfigurationBlockVirtualNetworkGatewayClientConnectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_network_gateway_client_connection";

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefixes is required")]
    public TerraformList<string>? AddressPrefixes
    {
        get => GetArgument<TerraformList<string>>("address_prefixes");
        set => SetArgument("address_prefixes", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The policy_group_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyGroupNames is required")]
    public TerraformList<string>? PolicyGroupNames
    {
        get => GetArgument<TerraformList<string>>("policy_group_names");
        set => SetArgument("policy_group_names", value);
    }

}


/// <summary>
/// Represents a azurerm_virtual_network_gateway Terraform resource.
/// Manages a azurerm_virtual_network_gateway resource.
/// </summary>
public partial class AzurermVirtualNetworkGateway(string name) : TerraformResource("azurerm_virtual_network_gateway", name)
{
    /// <summary>
    /// The active_active attribute.
    /// </summary>
    public TerraformValue<bool>? ActiveActive
    {
        get => GetArgument<TerraformValue<bool>>("active_active");
        set => SetArgument("active_active", value);
    }

    /// <summary>
    /// The bgp_route_translation_for_nat_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? BgpRouteTranslationForNatEnabled
    {
        get => GetArgument<TerraformValue<bool>>("bgp_route_translation_for_nat_enabled");
        set => SetArgument("bgp_route_translation_for_nat_enabled", value);
    }

    /// <summary>
    /// The default_local_network_gateway_id attribute.
    /// </summary>
    public TerraformValue<string>? DefaultLocalNetworkGatewayId
    {
        get => GetArgument<TerraformValue<string>>("default_local_network_gateway_id");
        set => SetArgument("default_local_network_gateway_id", value);
    }

    /// <summary>
    /// The dns_forwarding_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DnsForwardingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("dns_forwarding_enabled");
        set => SetArgument("dns_forwarding_enabled", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformValue<string>? EdgeZone
    {
        get => GetArgument<TerraformValue<string>>("edge_zone");
        set => SetArgument("edge_zone", value);
    }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    public TerraformValue<bool>? EnableBgp
    {
        get => GetArgument<TerraformValue<bool>>("enable_bgp");
        set => SetArgument("enable_bgp", value);
    }

    /// <summary>
    /// The generation attribute.
    /// </summary>
    public TerraformValue<string>? Generation
    {
        get => GetArgument<TerraformValue<string>>("generation");
        set => SetArgument("generation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_sec_replay_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IpSecReplayProtectionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("ip_sec_replay_protection_enabled");
        set => SetArgument("ip_sec_replay_protection_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_ip_address_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PrivateIpAddressEnabled
    {
        get => GetArgument<TerraformValue<bool>>("private_ip_address_enabled");
        set => SetArgument("private_ip_address_enabled", value);
    }

    /// <summary>
    /// The remote_vnet_traffic_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RemoteVnetTrafficEnabled
    {
        get => GetArgument<TerraformValue<bool>>("remote_vnet_traffic_enabled");
        set => SetArgument("remote_vnet_traffic_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => GetArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The virtual_wan_traffic_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? VirtualWanTrafficEnabled
    {
        get => GetArgument<TerraformValue<bool>>("virtual_wan_traffic_enabled");
        set => SetArgument("virtual_wan_traffic_enabled", value);
    }

    /// <summary>
    /// The vpn_type attribute.
    /// </summary>
    public TerraformValue<string>? VpnType
    {
        get => GetArgument<TerraformValue<string>>("vpn_type");
        set => SetArgument("vpn_type", value);
    }

    /// <summary>
    /// BgpSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BgpSettings block(s) allowed")]
    public TerraformList<AzurermVirtualNetworkGatewayBgpSettingsBlock>? BgpSettings
    {
        get => GetArgument<TerraformList<AzurermVirtualNetworkGatewayBgpSettingsBlock>>("bgp_settings");
        set => SetArgument("bgp_settings", value);
    }

    /// <summary>
    /// CustomRoute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomRoute block(s) allowed")]
    public TerraformList<AzurermVirtualNetworkGatewayCustomRouteBlock>? CustomRoute
    {
        get => GetArgument<TerraformList<AzurermVirtualNetworkGatewayCustomRouteBlock>>("custom_route");
        set => SetArgument("custom_route", value);
    }

    /// <summary>
    /// IpConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 IpConfiguration block(s) allowed")]
    public required TerraformList<AzurermVirtualNetworkGatewayIpConfigurationBlock> IpConfiguration
    {
        get => GetRequiredArgument<TerraformList<AzurermVirtualNetworkGatewayIpConfigurationBlock>>("ip_configuration");
        set => SetArgument("ip_configuration", value);
    }

    /// <summary>
    /// PolicyGroup block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVirtualNetworkGatewayPolicyGroupBlock>? PolicyGroup
    {
        get => GetArgument<TerraformList<AzurermVirtualNetworkGatewayPolicyGroupBlock>>("policy_group");
        set => SetArgument("policy_group", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualNetworkGatewayTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualNetworkGatewayTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VpnClientConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpnClientConfiguration block(s) allowed")]
    public TerraformList<AzurermVirtualNetworkGatewayVpnClientConfigurationBlock>? VpnClientConfiguration
    {
        get => GetArgument<TerraformList<AzurermVirtualNetworkGatewayVpnClientConfigurationBlock>>("vpn_client_configuration");
        set => SetArgument("vpn_client_configuration", value);
    }

}
