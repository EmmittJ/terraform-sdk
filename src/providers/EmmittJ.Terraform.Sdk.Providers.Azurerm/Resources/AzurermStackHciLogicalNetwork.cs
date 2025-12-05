using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for subnet in AzurermStackHciLogicalNetwork.
/// Nesting mode: list
/// </summary>
public class AzurermStackHciLogicalNetworkSubnetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subnet";

    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    public TerraformValue<string>? AddressPrefix
    {
        get => GetArgument<TerraformValue<string>>("address_prefix");
        set => SetArgument("address_prefix", value);
    }

    /// <summary>
    /// The ip_allocation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAllocationMethod is required")]
    public required TerraformValue<string> IpAllocationMethod
    {
        get => GetRequiredArgument<TerraformValue<string>>("ip_allocation_method");
        set => SetArgument("ip_allocation_method", value);
    }

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    public TerraformValue<double>? VlanId
    {
        get => GetArgument<TerraformValue<double>>("vlan_id");
        set => SetArgument("vlan_id", value);
    }

    /// <summary>
    /// IpPool block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermStackHciLogicalNetworkSubnetBlockIpPoolBlock>? IpPool
    {
        get => GetArgument<TerraformList<AzurermStackHciLogicalNetworkSubnetBlockIpPoolBlock>>("ip_pool");
        set => SetArgument("ip_pool", value);
    }

    /// <summary>
    /// Route block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Route block(s) allowed")]
    public TerraformList<AzurermStackHciLogicalNetworkSubnetBlockRouteBlock>? Route
    {
        get => GetArgument<TerraformList<AzurermStackHciLogicalNetworkSubnetBlockRouteBlock>>("route");
        set => SetArgument("route", value);
    }

}

/// <summary>
/// Block type for ip_pool in AzurermStackHciLogicalNetworkSubnetBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStackHciLogicalNetworkSubnetBlockIpPoolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_pool";

    /// <summary>
    /// The end attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "End is required")]
    public required TerraformValue<string> End
    {
        get => GetRequiredArgument<TerraformValue<string>>("end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    public required TerraformValue<string> Start
    {
        get => GetRequiredArgument<TerraformValue<string>>("start");
        set => SetArgument("start", value);
    }

}

/// <summary>
/// Block type for route in AzurermStackHciLogicalNetworkSubnetBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStackHciLogicalNetworkSubnetBlockRouteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "route";

    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefix is required")]
    public required TerraformValue<string> AddressPrefix
    {
        get => GetRequiredArgument<TerraformValue<string>>("address_prefix");
        set => SetArgument("address_prefix", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The next_hop_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NextHopIpAddress is required")]
    public required TerraformValue<string> NextHopIpAddress
    {
        get => GetRequiredArgument<TerraformValue<string>>("next_hop_ip_address");
        set => SetArgument("next_hop_ip_address", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermStackHciLogicalNetwork.
/// Nesting mode: single
/// </summary>
public class AzurermStackHciLogicalNetworkTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_stack_hci_logical_network Terraform resource.
/// Manages a azurerm_stack_hci_logical_network resource.
/// </summary>
public partial class AzurermStackHciLogicalNetwork(string name) : TerraformResource("azurerm_stack_hci_logical_network", name)
{
    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomLocationId is required")]
    public required TerraformValue<string> CustomLocationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("custom_location_id");
        set => SetArgument("custom_location_id", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
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
    /// The virtual_switch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualSwitchName is required")]
    public required TerraformValue<string> VirtualSwitchName
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_switch_name");
        set => SetArgument("virtual_switch_name", value);
    }

    /// <summary>
    /// Subnet block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnet is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Subnet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Subnet block(s) allowed")]
    public required TerraformList<AzurermStackHciLogicalNetworkSubnetBlock> Subnet
    {
        get => GetRequiredArgument<TerraformList<AzurermStackHciLogicalNetworkSubnetBlock>>("subnet");
        set => SetArgument("subnet", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStackHciLogicalNetworkTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStackHciLogicalNetworkTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
