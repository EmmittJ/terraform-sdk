using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for ip_configuration in AzurermNetworkInterface.
/// Nesting mode: list
/// </summary>
public class AzurermNetworkInterfaceIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_configuration";

    /// <summary>
    /// The gateway_load_balancer_frontend_ip_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> GatewayLoadBalancerFrontendIpConfigurationId
    {
        get => GetArgument<TerraformValue<string>>("gateway_load_balancer_frontend_ip_configuration_id") ?? AsReference("gateway_load_balancer_frontend_ip_configuration_id");
        set => SetArgument("gateway_load_balancer_frontend_ip_configuration_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    public TerraformValue<bool> Primary
    {
        get => GetArgument<TerraformValue<bool>>("primary") ?? AsReference("primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PrivateIpAddress
    {
        get => GetArgument<TerraformValue<string>>("private_ip_address") ?? AsReference("private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateIpAddressAllocation is required")]
    public required TerraformValue<string> PrivateIpAddressAllocation
    {
        get => GetRequiredArgument<TerraformValue<string>>("private_ip_address_allocation");
        set => SetArgument("private_ip_address_allocation", value);
    }

    /// <summary>
    /// The private_ip_address_version attribute.
    /// </summary>
    public TerraformValue<string>? PrivateIpAddressVersion
    {
        get => GetArgument<TerraformValue<string>>("private_ip_address_version");
        set => SetArgument("private_ip_address_version", value);
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
    public TerraformValue<string>? SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermNetworkInterface.
/// Nesting mode: single
/// </summary>
public class AzurermNetworkInterfaceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_network_interface Terraform resource.
/// Manages a azurerm_network_interface resource.
/// </summary>
public partial class AzurermNetworkInterface(string name) : TerraformResource("azurerm_network_interface", name)
{
    /// <summary>
    /// The accelerated_networking_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AcceleratedNetworkingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("accelerated_networking_enabled");
        set => SetArgument("accelerated_networking_enabled", value);
    }

    /// <summary>
    /// The auxiliary_mode attribute.
    /// </summary>
    public TerraformValue<string>? AuxiliaryMode
    {
        get => GetArgument<TerraformValue<string>>("auxiliary_mode");
        set => SetArgument("auxiliary_mode", value);
    }

    /// <summary>
    /// The auxiliary_sku attribute.
    /// </summary>
    public TerraformValue<string>? AuxiliarySku
    {
        get => GetArgument<TerraformValue<string>>("auxiliary_sku");
        set => SetArgument("auxiliary_sku", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformList<string>? DnsServers
    {
        get => GetArgument<TerraformList<string>>("dns_servers");
        set => SetArgument("dns_servers", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The internal_dns_name_label attribute.
    /// </summary>
    public TerraformValue<string>? InternalDnsNameLabel
    {
        get => GetArgument<TerraformValue<string>>("internal_dns_name_label");
        set => SetArgument("internal_dns_name_label", value);
    }

    /// <summary>
    /// The ip_forwarding_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IpForwardingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("ip_forwarding_enabled");
        set => SetArgument("ip_forwarding_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
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
    /// The applied_dns_servers attribute.
    /// </summary>
    public TerraformList<string> AppliedDnsServers
        => AsReference("applied_dns_servers");

    /// <summary>
    /// The internal_domain_name_suffix attribute.
    /// </summary>
    public TerraformValue<string> InternalDomainNameSuffix
        => AsReference("internal_domain_name_suffix");

    /// <summary>
    /// The mac_address attribute.
    /// </summary>
    public TerraformValue<string> MacAddress
        => AsReference("mac_address");

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PrivateIpAddress
        => AsReference("private_ip_address");

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PrivateIpAddresses
        => AsReference("private_ip_addresses");

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualMachineId
        => AsReference("virtual_machine_id");

    /// <summary>
    /// IpConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpConfiguration block(s) required")]
    public required TerraformList<AzurermNetworkInterfaceIpConfigurationBlock> IpConfiguration
    {
        get => GetRequiredArgument<TerraformList<AzurermNetworkInterfaceIpConfigurationBlock>>("ip_configuration");
        set => SetArgument("ip_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkInterfaceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkInterfaceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
