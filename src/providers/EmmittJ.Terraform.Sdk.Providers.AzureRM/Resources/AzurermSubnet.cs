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
/// Block type for delegation in .
/// Nesting mode: list
/// </summary>
public class AzurermSubnetDelegationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delegation";

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

}

/// <summary>
/// Block type for ip_address_pool in .
/// Nesting mode: list
/// </summary>
public class AzurermSubnetIpAddressPoolBlock : TerraformBlock
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
public class AzurermSubnetTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_subnet resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSubnet : TerraformResource
{
    public AzurermSubnet(string name) : base("azurerm_subnet", name)
    {
    }

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    [TerraformArgument("address_prefixes")]
    public TerraformList<string>? AddressPrefixes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "address_prefixes").ResolveNodes(ctx));
        set => SetArgument("address_prefixes", value);
    }

    /// <summary>
    /// The default_outbound_access_enabled attribute.
    /// </summary>
    [TerraformArgument("default_outbound_access_enabled")]
    public TerraformValue<bool>? DefaultOutboundAccessEnabled
    {
        get => new TerraformReference<bool>(this, "default_outbound_access_enabled");
        set => SetArgument("default_outbound_access_enabled", value);
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
    /// The private_endpoint_network_policies attribute.
    /// </summary>
    [TerraformArgument("private_endpoint_network_policies")]
    public TerraformValue<string>? PrivateEndpointNetworkPolicies
    {
        get => new TerraformReference<string>(this, "private_endpoint_network_policies");
        set => SetArgument("private_endpoint_network_policies", value);
    }

    /// <summary>
    /// The private_link_service_network_policies_enabled attribute.
    /// </summary>
    [TerraformArgument("private_link_service_network_policies_enabled")]
    public TerraformValue<bool>? PrivateLinkServiceNetworkPoliciesEnabled
    {
        get => new TerraformReference<bool>(this, "private_link_service_network_policies_enabled");
        set => SetArgument("private_link_service_network_policies_enabled", value);
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
    /// The service_endpoint_policy_ids attribute.
    /// </summary>
    [TerraformArgument("service_endpoint_policy_ids")]
    public TerraformSet<string>? ServiceEndpointPolicyIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "service_endpoint_policy_ids").ResolveNodes(ctx));
        set => SetArgument("service_endpoint_policy_ids", value);
    }

    /// <summary>
    /// The service_endpoints attribute.
    /// </summary>
    [TerraformArgument("service_endpoints")]
    public TerraformSet<string>? ServiceEndpoints
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "service_endpoints").ResolveNodes(ctx));
        set => SetArgument("service_endpoints", value);
    }

    /// <summary>
    /// The sharing_scope attribute.
    /// </summary>
    [TerraformArgument("sharing_scope")]
    public TerraformValue<string>? SharingScope
    {
        get => new TerraformReference<string>(this, "sharing_scope");
        set => SetArgument("sharing_scope", value);
    }

    /// <summary>
    /// The virtual_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkName is required")]
    [TerraformArgument("virtual_network_name")]
    public required TerraformValue<string> VirtualNetworkName
    {
        get => new TerraformReference<string>(this, "virtual_network_name");
        set => SetArgument("virtual_network_name", value);
    }

    /// <summary>
    /// Block for delegation.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("delegation")]
    public TerraformList<AzurermSubnetDelegationBlock> Delegation { get; set; } = new();

    /// <summary>
    /// Block for ip_address_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpAddressPool block(s) allowed")]
    [TerraformArgument("ip_address_pool")]
    public TerraformList<AzurermSubnetIpAddressPoolBlock> IpAddressPool { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSubnetTimeoutsBlock Timeouts { get; set; } = new();

}
