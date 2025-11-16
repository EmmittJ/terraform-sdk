using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for ddos_protection_plan in .
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
        get => new TerraformReference<bool>(this, "enable");
        set => SetArgument("enable", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

}

/// <summary>
/// Block type for encryption in .
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
        get => new TerraformReference<string>(this, "enforcement");
        set => SetArgument("enforcement", value);
    }

}

/// <summary>
/// Block type for ip_address_pool in .
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
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allocated_ip_address_prefixes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The number_of_ip_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfIpAddresses is required")]
    public required TerraformValue<string> NumberOfIpAddresses
    {
        get => new TerraformReference<string>(this, "number_of_ip_addresses");
        set => SetArgument("number_of_ip_addresses", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "address_space").ResolveNodes(ctx));
        set => SetArgument("address_space", value);
    }

    /// <summary>
    /// The bgp_community attribute.
    /// </summary>
    public TerraformValue<string>? BgpCommunity
    {
        get => new TerraformReference<string>(this, "bgp_community");
        set => SetArgument("bgp_community", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformList<string> DnsServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dns_servers").ResolveNodes(ctx));
        set => SetArgument("dns_servers", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformValue<string>? EdgeZone
    {
        get => new TerraformReference<string>(this, "edge_zone");
        set => SetArgument("edge_zone", value);
    }

    /// <summary>
    /// The flow_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? FlowTimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "flow_timeout_in_minutes");
        set => SetArgument("flow_timeout_in_minutes", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The private_endpoint_vnet_policies attribute.
    /// </summary>
    public TerraformValue<string>? PrivateEndpointVnetPolicies
    {
        get => new TerraformReference<string>(this, "private_endpoint_vnet_policies");
        set => SetArgument("private_endpoint_vnet_policies", value);
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
    /// The subnet attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Subnet
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "subnet").ResolveNodes(ctx));
        set => SetArgument("subnet", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The guid attribute.
    /// </summary>
    public TerraformValue<string> Guid
    {
        get => new TerraformReference<string>(this, "guid");
    }

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
