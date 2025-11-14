using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for ip_configuration in .
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
    [TerraformArgument("gateway_load_balancer_frontend_ip_configuration_id")]
    public TerraformValue<string> GatewayLoadBalancerFrontendIpConfigurationId
    {
        get => new TerraformReference<string>(this, "gateway_load_balancer_frontend_ip_configuration_id");
        set => SetArgument("gateway_load_balancer_frontend_ip_configuration_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    [TerraformArgument("primary")]
    public TerraformValue<bool> Primary
    {
        get => new TerraformReference<bool>(this, "primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformArgument("private_ip_address")]
    public TerraformValue<string> PrivateIpAddress
    {
        get => new TerraformReference<string>(this, "private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateIpAddressAllocation is required")]
    [TerraformArgument("private_ip_address_allocation")]
    public required TerraformValue<string> PrivateIpAddressAllocation
    {
        get => new TerraformReference<string>(this, "private_ip_address_allocation");
        set => SetArgument("private_ip_address_allocation", value);
    }

    /// <summary>
    /// The private_ip_address_version attribute.
    /// </summary>
    [TerraformArgument("private_ip_address_version")]
    public TerraformValue<string>? PrivateIpAddressVersion
    {
        get => new TerraformReference<string>(this, "private_ip_address_version");
        set => SetArgument("private_ip_address_version", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformArgument("public_ip_address_id")]
    public TerraformValue<string>? PublicIpAddressId
    {
        get => new TerraformReference<string>(this, "public_ip_address_id");
        set => SetArgument("public_ip_address_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformArgument("subnet_id")]
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_network_interface resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermNetworkInterface : TerraformResource
{
    public AzurermNetworkInterface(string name) : base("azurerm_network_interface", name)
    {
    }

    /// <summary>
    /// The accelerated_networking_enabled attribute.
    /// </summary>
    [TerraformArgument("accelerated_networking_enabled")]
    public TerraformValue<bool>? AcceleratedNetworkingEnabled
    {
        get => new TerraformReference<bool>(this, "accelerated_networking_enabled");
        set => SetArgument("accelerated_networking_enabled", value);
    }

    /// <summary>
    /// The auxiliary_mode attribute.
    /// </summary>
    [TerraformArgument("auxiliary_mode")]
    public TerraformValue<string>? AuxiliaryMode
    {
        get => new TerraformReference<string>(this, "auxiliary_mode");
        set => SetArgument("auxiliary_mode", value);
    }

    /// <summary>
    /// The auxiliary_sku attribute.
    /// </summary>
    [TerraformArgument("auxiliary_sku")]
    public TerraformValue<string>? AuxiliarySku
    {
        get => new TerraformReference<string>(this, "auxiliary_sku");
        set => SetArgument("auxiliary_sku", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformArgument("dns_servers")]
    public TerraformList<string>? DnsServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dns_servers").ResolveNodes(ctx));
        set => SetArgument("dns_servers", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformArgument("edge_zone")]
    public TerraformValue<string>? EdgeZone
    {
        get => new TerraformReference<string>(this, "edge_zone");
        set => SetArgument("edge_zone", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The internal_dns_name_label attribute.
    /// </summary>
    [TerraformArgument("internal_dns_name_label")]
    public TerraformValue<string>? InternalDnsNameLabel
    {
        get => new TerraformReference<string>(this, "internal_dns_name_label");
        set => SetArgument("internal_dns_name_label", value);
    }

    /// <summary>
    /// The ip_forwarding_enabled attribute.
    /// </summary>
    [TerraformArgument("ip_forwarding_enabled")]
    public TerraformValue<bool>? IpForwardingEnabled
    {
        get => new TerraformReference<bool>(this, "ip_forwarding_enabled");
        set => SetArgument("ip_forwarding_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpConfiguration block(s) required")]
    [TerraformArgument("ip_configuration")]
    public required TerraformList<AzurermNetworkInterfaceIpConfigurationBlock> IpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNetworkInterfaceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The applied_dns_servers attribute.
    /// </summary>
    [TerraformArgument("applied_dns_servers")]
    public TerraformList<string> AppliedDnsServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "applied_dns_servers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The internal_domain_name_suffix attribute.
    /// </summary>
    [TerraformArgument("internal_domain_name_suffix")]
    public TerraformValue<string> InternalDomainNameSuffix
    {
        get => new TerraformReference<string>(this, "internal_domain_name_suffix");
    }

    /// <summary>
    /// The mac_address attribute.
    /// </summary>
    [TerraformArgument("mac_address")]
    public TerraformValue<string> MacAddress
    {
        get => new TerraformReference<string>(this, "mac_address");
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformArgument("private_ip_address")]
    public TerraformValue<string> PrivateIpAddress
    {
        get => new TerraformReference<string>(this, "private_ip_address");
    }

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("private_ip_addresses")]
    public TerraformList<string> PrivateIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "private_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [TerraformArgument("virtual_machine_id")]
    public TerraformValue<string> VirtualMachineId
    {
        get => new TerraformReference<string>(this, "virtual_machine_id");
    }

}
