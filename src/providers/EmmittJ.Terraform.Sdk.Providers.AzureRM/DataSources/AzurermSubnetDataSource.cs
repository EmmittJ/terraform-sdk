using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_subnet Terraform data source.
/// Retrieves information about a azurerm_subnet.
/// </summary>
public partial class AzurermSubnetDataSource(string name) : TerraformDataSource("azurerm_subnet", name)
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
    /// The virtual_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkName is required")]
    public required TerraformValue<string> VirtualNetworkName
    {
        get => new TerraformReference<string>(this, "virtual_network_name");
        set => SetArgument("virtual_network_name", value);
    }

    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    public TerraformValue<string> AddressPrefix
    {
        get => new TerraformReference<string>(this, "address_prefix");
    }

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    public TerraformList<string> AddressPrefixes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "address_prefixes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The default_outbound_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DefaultOutboundAccessEnabled
    {
        get => new TerraformReference<bool>(this, "default_outbound_access_enabled");
    }

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkSecurityGroupId
    {
        get => new TerraformReference<string>(this, "network_security_group_id");
    }

    /// <summary>
    /// The private_endpoint_network_policies attribute.
    /// </summary>
    public TerraformValue<string> PrivateEndpointNetworkPolicies
    {
        get => new TerraformReference<string>(this, "private_endpoint_network_policies");
    }

    /// <summary>
    /// The private_link_service_network_policies_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PrivateLinkServiceNetworkPoliciesEnabled
    {
        get => new TerraformReference<bool>(this, "private_link_service_network_policies_enabled");
    }

    /// <summary>
    /// The route_table_id attribute.
    /// </summary>
    public TerraformValue<string> RouteTableId
    {
        get => new TerraformReference<string>(this, "route_table_id");
    }

    /// <summary>
    /// The service_endpoints attribute.
    /// </summary>
    public TerraformList<string> ServiceEndpoints
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "service_endpoints").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSubnetDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSubnetDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
