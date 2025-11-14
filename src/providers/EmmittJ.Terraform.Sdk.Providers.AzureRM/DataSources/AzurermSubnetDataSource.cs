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
public class AzurermSubnetDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_subnet.
/// </summary>
public class AzurermSubnetDataSource : TerraformDataSource
{
    public AzurermSubnetDataSource(string name) : base("azurerm_subnet", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSubnetDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    [TerraformArgument("address_prefix")]
    public TerraformValue<string> AddressPrefix
    {
        get => new TerraformReference<string>(this, "address_prefix");
    }

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    [TerraformArgument("address_prefixes")]
    public TerraformList<string> AddressPrefixes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "address_prefixes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The default_outbound_access_enabled attribute.
    /// </summary>
    [TerraformArgument("default_outbound_access_enabled")]
    public TerraformValue<bool> DefaultOutboundAccessEnabled
    {
        get => new TerraformReference<bool>(this, "default_outbound_access_enabled");
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
    /// The private_endpoint_network_policies attribute.
    /// </summary>
    [TerraformArgument("private_endpoint_network_policies")]
    public TerraformValue<string> PrivateEndpointNetworkPolicies
    {
        get => new TerraformReference<string>(this, "private_endpoint_network_policies");
    }

    /// <summary>
    /// The private_link_service_network_policies_enabled attribute.
    /// </summary>
    [TerraformArgument("private_link_service_network_policies_enabled")]
    public TerraformValue<bool> PrivateLinkServiceNetworkPoliciesEnabled
    {
        get => new TerraformReference<bool>(this, "private_link_service_network_policies_enabled");
    }

    /// <summary>
    /// The route_table_id attribute.
    /// </summary>
    [TerraformArgument("route_table_id")]
    public TerraformValue<string> RouteTableId
    {
        get => new TerraformReference<string>(this, "route_table_id");
    }

    /// <summary>
    /// The service_endpoints attribute.
    /// </summary>
    [TerraformArgument("service_endpoints")]
    public TerraformList<string> ServiceEndpoints
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "service_endpoints").ResolveNodes(ctx));
    }

}
