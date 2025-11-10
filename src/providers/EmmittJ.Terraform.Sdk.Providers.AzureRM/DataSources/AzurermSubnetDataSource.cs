using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSubnetDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The virtual_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkName is required")]
    [TerraformPropertyName("virtual_network_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VirtualNetworkName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSubnetDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    [TerraformPropertyName("address_prefix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AddressPrefix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "address_prefix");

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    [TerraformPropertyName("address_prefixes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AddressPrefixes => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "address_prefixes");

    /// <summary>
    /// The default_outbound_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("default_outbound_access_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DefaultOutboundAccessEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "default_outbound_access_enabled");

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("network_security_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkSecurityGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_security_group_id");

    /// <summary>
    /// The private_endpoint_network_policies attribute.
    /// </summary>
    [TerraformPropertyName("private_endpoint_network_policies")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateEndpointNetworkPolicies => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_endpoint_network_policies");

    /// <summary>
    /// The private_link_service_network_policies_enabled attribute.
    /// </summary>
    [TerraformPropertyName("private_link_service_network_policies_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PrivateLinkServiceNetworkPoliciesEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "private_link_service_network_policies_enabled");

    /// <summary>
    /// The route_table_id attribute.
    /// </summary>
    [TerraformPropertyName("route_table_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RouteTableId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "route_table_id");

    /// <summary>
    /// The service_endpoints attribute.
    /// </summary>
    [TerraformPropertyName("service_endpoints")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ServiceEndpoints => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "service_endpoints");

}
