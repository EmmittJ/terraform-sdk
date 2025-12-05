using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSubnetDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
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
    /// The virtual_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkName is required")]
    public required TerraformValue<string> VirtualNetworkName
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_network_name");
        set => SetArgument("virtual_network_name", value);
    }

    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    public TerraformValue<string> AddressPrefix
        => CreateReference("address_prefix");

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    public TerraformList<string> AddressPrefixes
        => CreateReference("address_prefixes");

    /// <summary>
    /// The default_outbound_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DefaultOutboundAccessEnabled
        => CreateReference("default_outbound_access_enabled");

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkSecurityGroupId
        => CreateReference("network_security_group_id");

    /// <summary>
    /// The private_endpoint_network_policies attribute.
    /// </summary>
    public TerraformValue<string> PrivateEndpointNetworkPolicies
        => CreateReference("private_endpoint_network_policies");

    /// <summary>
    /// The private_link_service_network_policies_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PrivateLinkServiceNetworkPoliciesEnabled
        => CreateReference("private_link_service_network_policies_enabled");

    /// <summary>
    /// The route_table_id attribute.
    /// </summary>
    public TerraformValue<string> RouteTableId
        => CreateReference("route_table_id");

    /// <summary>
    /// The service_endpoints attribute.
    /// </summary>
    public TerraformList<string> ServiceEndpoints
        => CreateReference("service_endpoints");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSubnetDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSubnetDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
