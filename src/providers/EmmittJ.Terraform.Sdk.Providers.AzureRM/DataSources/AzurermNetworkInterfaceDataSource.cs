using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_network_interface Terraform data source.
/// Retrieves information about a azurerm_network_interface.
/// </summary>
public partial class AzurermNetworkInterfaceDataSource(string name) : TerraformDataSource("azurerm_network_interface", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The accelerated_networking_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AcceleratedNetworkingEnabled
    {
        get => new TerraformReference<bool>(this, "accelerated_networking_enabled");
    }

    /// <summary>
    /// The applied_dns_servers attribute.
    /// </summary>
    public TerraformSet<string> AppliedDnsServers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "applied_dns_servers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformSet<string> DnsServers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "dns_servers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The internal_dns_name_label attribute.
    /// </summary>
    public TerraformValue<string> InternalDnsNameLabel
    {
        get => new TerraformReference<string>(this, "internal_dns_name_label");
    }

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ip_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ip_forwarding_enabled attribute.
    /// </summary>
    public TerraformValue<bool> IpForwardingEnabled
    {
        get => new TerraformReference<bool>(this, "ip_forwarding_enabled");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The mac_address attribute.
    /// </summary>
    public TerraformValue<string> MacAddress
    {
        get => new TerraformReference<string>(this, "mac_address");
    }

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkSecurityGroupId
    {
        get => new TerraformReference<string>(this, "network_security_group_id");
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PrivateIpAddress
    {
        get => new TerraformReference<string>(this, "private_ip_address");
    }

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PrivateIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "private_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualMachineId
    {
        get => new TerraformReference<string>(this, "virtual_machine_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkInterfaceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkInterfaceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
