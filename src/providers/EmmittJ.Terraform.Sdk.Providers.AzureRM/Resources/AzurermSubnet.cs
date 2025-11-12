using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for delegation in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSubnetDelegationBlock() : TerraformBlock("delegation")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for ip_address_pool in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSubnetIpAddressPoolBlock() : TerraformBlock("ip_address_pool")
{

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The number_of_ip_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfIpAddresses is required")]
    [TerraformProperty("number_of_ip_addresses")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NumberOfIpAddresses { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSubnetTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_subnet resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSubnet : TerraformResource
{
    public AzurermSubnet(string name) : base("azurerm_subnet", name)
    {
    }

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    [TerraformProperty("address_prefixes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AddressPrefixes { get; set; }

    /// <summary>
    /// The default_outbound_access_enabled attribute.
    /// </summary>
    [TerraformProperty("default_outbound_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DefaultOutboundAccessEnabled { get; set; }

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
    /// The private_endpoint_network_policies attribute.
    /// </summary>
    [TerraformProperty("private_endpoint_network_policies")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrivateEndpointNetworkPolicies { get; set; }

    /// <summary>
    /// The private_link_service_network_policies_enabled attribute.
    /// </summary>
    [TerraformProperty("private_link_service_network_policies_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PrivateLinkServiceNetworkPoliciesEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The service_endpoint_policy_ids attribute.
    /// </summary>
    [TerraformProperty("service_endpoint_policy_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ServiceEndpointPolicyIds { get; set; }

    /// <summary>
    /// The service_endpoints attribute.
    /// </summary>
    [TerraformProperty("service_endpoints")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ServiceEndpoints { get; set; }

    /// <summary>
    /// The sharing_scope attribute.
    /// </summary>
    [TerraformProperty("sharing_scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SharingScope { get; set; }

    /// <summary>
    /// The virtual_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkName is required")]
    [TerraformProperty("virtual_network_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VirtualNetworkName { get; set; }

    /// <summary>
    /// Block for delegation.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("delegation")]
    public TerraformList<AzurermSubnetDelegationBlock> Delegation { get; set; } = new();

    /// <summary>
    /// Block for ip_address_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpAddressPool block(s) allowed")]
    [TerraformProperty("ip_address_pool")]
    public TerraformList<AzurermSubnetIpAddressPoolBlock> IpAddressPool { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSubnetTimeoutsBlock Timeouts { get; set; } = new();

}
