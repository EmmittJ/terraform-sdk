using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSubnetDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_subnet.
/// </summary>
public partial class AzurermSubnetDataSource : TerraformDataSource
{
    public AzurermSubnetDataSource(string name) : base("azurerm_subnet", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The virtual_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkName is required")]
    [TerraformProperty("virtual_network_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VirtualNetworkName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermSubnetDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    [TerraformProperty("address_prefix")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AddressPrefix { get; }

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    [TerraformProperty("address_prefixes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AddressPrefixes { get; }

    /// <summary>
    /// The default_outbound_access_enabled attribute.
    /// </summary>
    [TerraformProperty("default_outbound_access_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DefaultOutboundAccessEnabled { get; }

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    [TerraformProperty("network_security_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NetworkSecurityGroupId { get; }

    /// <summary>
    /// The private_endpoint_network_policies attribute.
    /// </summary>
    [TerraformProperty("private_endpoint_network_policies")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateEndpointNetworkPolicies { get; }

    /// <summary>
    /// The private_link_service_network_policies_enabled attribute.
    /// </summary>
    [TerraformProperty("private_link_service_network_policies_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> PrivateLinkServiceNetworkPoliciesEnabled { get; }

    /// <summary>
    /// The route_table_id attribute.
    /// </summary>
    [TerraformProperty("route_table_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RouteTableId { get; }

    /// <summary>
    /// The service_endpoints attribute.
    /// </summary>
    [TerraformProperty("service_endpoints")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ServiceEndpoints { get; }

}
