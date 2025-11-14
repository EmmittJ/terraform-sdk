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
    [TerraformArgument("enable")]
    public required TerraformValue<bool> Enable
    {
        get => new TerraformReference<bool>(this, "enable");
        set => SetArgument("enable", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformArgument("id")]
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
    [TerraformArgument("enforcement")]
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
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformArgument("id")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The number_of_ip_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfIpAddresses is required")]
    [TerraformArgument("number_of_ip_addresses")]
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
/// Manages a azurerm_virtual_network resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVirtualNetwork : TerraformResource
{
    public AzurermVirtualNetwork(string name) : base("azurerm_virtual_network", name)
    {
    }

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [TerraformArgument("address_space")]
    public TerraformSet<string>? AddressSpace
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "address_space").ResolveNodes(ctx));
        set => SetArgument("address_space", value);
    }

    /// <summary>
    /// The bgp_community attribute.
    /// </summary>
    [TerraformArgument("bgp_community")]
    public TerraformValue<string>? BgpCommunity
    {
        get => new TerraformReference<string>(this, "bgp_community");
        set => SetArgument("bgp_community", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformArgument("dns_servers")]
    public TerraformList<string> DnsServers
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
    /// The flow_timeout_in_minutes attribute.
    /// </summary>
    [TerraformArgument("flow_timeout_in_minutes")]
    public TerraformValue<double>? FlowTimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "flow_timeout_in_minutes");
        set => SetArgument("flow_timeout_in_minutes", value);
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
    /// The private_endpoint_vnet_policies attribute.
    /// </summary>
    [TerraformArgument("private_endpoint_vnet_policies")]
    public TerraformValue<string>? PrivateEndpointVnetPolicies
    {
        get => new TerraformReference<string>(this, "private_endpoint_vnet_policies");
        set => SetArgument("private_endpoint_vnet_policies", value);
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
    /// The subnet attribute.
    /// </summary>
    [TerraformArgument("subnet")]
    public TerraformSet<object> Subnet
    {
        get => TerraformSet<object>.Lazy(ctx => new TerraformReference<TerraformSet<object>>(this, "subnet").ResolveNodes(ctx));
        set => SetArgument("subnet", value);
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
    /// Block for ddos_protection_plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DdosProtectionPlan block(s) allowed")]
    [TerraformArgument("ddos_protection_plan")]
    public TerraformList<AzurermVirtualNetworkDdosProtectionPlanBlock> DdosProtectionPlan { get; set; } = new();

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    [TerraformArgument("encryption")]
    public TerraformList<AzurermVirtualNetworkEncryptionBlock> Encryption { get; set; } = new();

    /// <summary>
    /// Block for ip_address_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 IpAddressPool block(s) allowed")]
    [TerraformArgument("ip_address_pool")]
    public TerraformList<AzurermVirtualNetworkIpAddressPoolBlock> IpAddressPool { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVirtualNetworkTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The guid attribute.
    /// </summary>
    [TerraformArgument("guid")]
    public TerraformValue<string> Guid
    {
        get => new TerraformReference<string>(this, "guid");
    }

}
