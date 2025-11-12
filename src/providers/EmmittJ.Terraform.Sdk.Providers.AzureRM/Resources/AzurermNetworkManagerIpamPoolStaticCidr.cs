using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetworkManagerIpamPoolStaticCidrTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_network_manager_ipam_pool_static_cidr resource.
/// </summary>
public partial class AzurermNetworkManagerIpamPoolStaticCidr : TerraformResource
{
    public AzurermNetworkManagerIpamPoolStaticCidr(string name) : base("azurerm_network_manager_ipam_pool_static_cidr", name)
    {
    }

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    [TerraformProperty("address_prefixes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AddressPrefixes { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamPoolId is required")]
    [TerraformProperty("ipam_pool_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IpamPoolId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The number_of_ip_addresses_to_allocate attribute.
    /// </summary>
    [TerraformProperty("number_of_ip_addresses_to_allocate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NumberOfIpAddressesToAllocate { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermNetworkManagerIpamPoolStaticCidrTimeoutsBlock Timeouts { get; set; } = new();

}
