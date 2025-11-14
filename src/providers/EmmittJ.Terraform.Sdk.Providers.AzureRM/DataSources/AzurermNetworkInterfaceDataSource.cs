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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkInterfaceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_network_interface.
/// </summary>
public class AzurermNetworkInterfaceDataSource : TerraformDataSource
{
    public AzurermNetworkInterfaceDataSource(string name) : base("azurerm_network_interface", name)
    {
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNetworkInterfaceDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The accelerated_networking_enabled attribute.
    /// </summary>
    [TerraformArgument("accelerated_networking_enabled")]
    public TerraformValue<bool> AcceleratedNetworkingEnabled
    {
        get => new TerraformReference<bool>(this, "accelerated_networking_enabled");
    }

    /// <summary>
    /// The applied_dns_servers attribute.
    /// </summary>
    [TerraformArgument("applied_dns_servers")]
    public TerraformSet<string> AppliedDnsServers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "applied_dns_servers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformArgument("dns_servers")]
    public TerraformSet<string> DnsServers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "dns_servers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The internal_dns_name_label attribute.
    /// </summary>
    [TerraformArgument("internal_dns_name_label")]
    public TerraformValue<string> InternalDnsNameLabel
    {
        get => new TerraformReference<string>(this, "internal_dns_name_label");
    }

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    [TerraformArgument("ip_configuration")]
    public TerraformList<object> IpConfiguration
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "ip_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ip_forwarding_enabled attribute.
    /// </summary>
    [TerraformArgument("ip_forwarding_enabled")]
    public TerraformValue<bool> IpForwardingEnabled
    {
        get => new TerraformReference<bool>(this, "ip_forwarding_enabled");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
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
    /// The network_security_group_id attribute.
    /// </summary>
    [TerraformArgument("network_security_group_id")]
    public TerraformValue<string> NetworkSecurityGroupId
    {
        get => new TerraformReference<string>(this, "network_security_group_id");
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
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
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
