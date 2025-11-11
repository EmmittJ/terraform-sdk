using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSubnetDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The virtual_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkName is required")]
    [TerraformPropertyName("virtual_network_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VirtualNetworkName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSubnetDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    [TerraformPropertyName("address_prefix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AddressPrefix => new TerraformReference(this, "address_prefix");

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    [TerraformPropertyName("address_prefixes")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AddressPrefixes => new TerraformReference(this, "address_prefixes");

    /// <summary>
    /// The default_outbound_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("default_outbound_access_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DefaultOutboundAccessEnabled => new TerraformReference(this, "default_outbound_access_enabled");

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("network_security_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkSecurityGroupId => new TerraformReference(this, "network_security_group_id");

    /// <summary>
    /// The private_endpoint_network_policies attribute.
    /// </summary>
    [TerraformPropertyName("private_endpoint_network_policies")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateEndpointNetworkPolicies => new TerraformReference(this, "private_endpoint_network_policies");

    /// <summary>
    /// The private_link_service_network_policies_enabled attribute.
    /// </summary>
    [TerraformPropertyName("private_link_service_network_policies_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PrivateLinkServiceNetworkPoliciesEnabled => new TerraformReference(this, "private_link_service_network_policies_enabled");

    /// <summary>
    /// The route_table_id attribute.
    /// </summary>
    [TerraformPropertyName("route_table_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RouteTableId => new TerraformReference(this, "route_table_id");

    /// <summary>
    /// The service_endpoints attribute.
    /// </summary>
    [TerraformPropertyName("service_endpoints")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ServiceEndpoints => new TerraformReference(this, "service_endpoints");

}
