using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for delegation in .
/// Nesting mode: list
/// </summary>
public class AzurermSubnetDelegationBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for ip_address_pool in .
/// Nesting mode: list
/// </summary>
public class AzurermSubnetIpAddressPoolBlock : ITerraformBlock
{
    /// <summary>
    /// The allocated_ip_address_prefixes attribute.
    /// </summary>
    [TerraformPropertyName("allocated_ip_address_prefixes")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AllocatedIpAddressPrefixes => new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "allocated_ip_address_prefixes");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// The number_of_ip_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfIpAddresses is required")]
    [TerraformPropertyName("number_of_ip_addresses")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NumberOfIpAddresses { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSubnetTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("address_prefixes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AddressPrefixes { get; set; }

    /// <summary>
    /// The default_outbound_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("default_outbound_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DefaultOutboundAccessEnabled { get; set; }

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
    /// The private_endpoint_network_policies attribute.
    /// </summary>
    [TerraformPropertyName("private_endpoint_network_policies")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrivateEndpointNetworkPolicies { get; set; }

    /// <summary>
    /// The private_link_service_network_policies_enabled attribute.
    /// </summary>
    [TerraformPropertyName("private_link_service_network_policies_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PrivateLinkServiceNetworkPoliciesEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The service_endpoint_policy_ids attribute.
    /// </summary>
    [TerraformPropertyName("service_endpoint_policy_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ServiceEndpointPolicyIds { get; set; }

    /// <summary>
    /// The service_endpoints attribute.
    /// </summary>
    [TerraformPropertyName("service_endpoints")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ServiceEndpoints { get; set; }

    /// <summary>
    /// The sharing_scope attribute.
    /// </summary>
    [TerraformPropertyName("sharing_scope")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SharingScope { get; set; }

    /// <summary>
    /// The virtual_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkName is required")]
    [TerraformPropertyName("virtual_network_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VirtualNetworkName { get; set; }

    /// <summary>
    /// Block for delegation.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("delegation")]
    public TerraformList<TerraformBlock<AzurermSubnetDelegationBlock>>? Delegation { get; set; } = new();

    /// <summary>
    /// Block for ip_address_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpAddressPool block(s) allowed")]
    [TerraformPropertyName("ip_address_pool")]
    public TerraformList<TerraformBlock<AzurermSubnetIpAddressPoolBlock>>? IpAddressPool { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSubnetTimeoutsBlock>? Timeouts { get; set; } = new();

}
