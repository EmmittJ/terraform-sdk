using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for ddos_protection_plan in AzurermVirtualNetwork.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkDdosProtectionPlanBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ddos_protection_plan";

    /// <summary>
    /// The enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enable is required")]
    public required TerraformValue<bool> Enable
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enable");
        set => SetArgument("enable", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

}


/// <summary>
/// Block type for encryption in AzurermVirtualNetwork.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption";

    /// <summary>
    /// The enforcement attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enforcement is required")]
    public required TerraformValue<string> Enforcement
    {
        get => GetRequiredArgument<TerraformValue<string>>("enforcement");
        set => SetArgument("enforcement", value);
    }

}


/// <summary>
/// Block type for ip_address_pool in AzurermVirtualNetwork.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkIpAddressPoolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_address_pool";

    /// <summary>
    /// The allocated_ip_address_prefixes attribute.
    /// </summary>
    public TerraformList<string> AllocatedIpAddressPrefixes
        => AsReference("allocated_ip_address_prefixes");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The number_of_ip_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfIpAddresses is required")]
    public required TerraformValue<string> NumberOfIpAddresses
    {
        get => GetRequiredArgument<TerraformValue<string>>("number_of_ip_addresses");
        set => SetArgument("number_of_ip_addresses", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermVirtualNetwork.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_virtual_network Terraform resource.
/// Manages a azurerm_virtual_network resource.
/// </summary>
public partial class AzurermVirtualNetwork(string name) : TerraformResource("azurerm_virtual_network", name)
{
    /// <summary>
    /// The address_space attribute.
    /// </summary>
    public TerraformSet<string>? AddressSpace
    {
        get => GetArgument<TerraformSet<string>>("address_space");
        set => SetArgument("address_space", value);
    }

    /// <summary>
    /// The bgp_community attribute.
    /// </summary>
    public TerraformValue<string>? BgpCommunity
    {
        get => GetArgument<TerraformValue<string>>("bgp_community");
        set => SetArgument("bgp_community", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformList<string> DnsServers
    {
        get => GetArgument<TerraformList<string>>("dns_servers") ?? AsReference("dns_servers");
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
    /// The flow_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? FlowTimeoutInMinutes
    {
        get => GetArgument<TerraformValue<double>>("flow_timeout_in_minutes");
        set => SetArgument("flow_timeout_in_minutes", value);
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
    /// The private_endpoint_vnet_policies attribute.
    /// </summary>
    public TerraformValue<string>? PrivateEndpointVnetPolicies
    {
        get => GetArgument<TerraformValue<string>>("private_endpoint_vnet_policies");
        set => SetArgument("private_endpoint_vnet_policies", value);
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
    /// The subnet attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Subnet
    {
        get => GetArgument<TerraformSet<TerraformMap<object>>>("subnet") ?? AsReference("subnet");
        set => SetArgument("subnet", value);
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
    /// The guid attribute.
    /// </summary>
    public TerraformValue<string> Guid
        => AsReference("guid");

    /// <summary>
    /// DdosProtectionPlan block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DdosProtectionPlan block(s) allowed")]
    public TerraformList<AzurermVirtualNetworkDdosProtectionPlanBlock>? DdosProtectionPlan
    {
        get => GetArgument<TerraformList<AzurermVirtualNetworkDdosProtectionPlanBlock>>("ddos_protection_plan");
        set => SetArgument("ddos_protection_plan", value);
    }

    /// <summary>
    /// Encryption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    public TerraformList<AzurermVirtualNetworkEncryptionBlock>? Encryption
    {
        get => GetArgument<TerraformList<AzurermVirtualNetworkEncryptionBlock>>("encryption");
        set => SetArgument("encryption", value);
    }

    /// <summary>
    /// IpAddressPool block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 IpAddressPool block(s) allowed")]
    public TerraformList<AzurermVirtualNetworkIpAddressPoolBlock>? IpAddressPool
    {
        get => GetArgument<TerraformList<AzurermVirtualNetworkIpAddressPoolBlock>>("ip_address_pool");
        set => SetArgument("ip_address_pool", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualNetworkTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualNetworkTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
