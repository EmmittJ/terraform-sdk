using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ip_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNetworkInterfaceIpConfigurationBlock() : TerraformBlock("ip_configuration")
{
    /// <summary>
    /// The gateway_load_balancer_frontend_ip_configuration_id attribute.
    /// </summary>
    [TerraformProperty("gateway_load_balancer_frontend_ip_configuration_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> GatewayLoadBalancerFrontendIpConfigurationId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    [TerraformProperty("primary")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Primary { get; set; }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformProperty("private_ip_address")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PrivateIpAddress { get; set; }

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateIpAddressAllocation is required")]
    [TerraformProperty("private_ip_address_allocation")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrivateIpAddressAllocation { get; set; }

    /// <summary>
    /// The private_ip_address_version attribute.
    /// </summary>
    [TerraformProperty("private_ip_address_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrivateIpAddressVersion { get; set; }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformProperty("public_ip_address_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PublicIpAddressId { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubnetId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetworkInterfaceTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_network_interface resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermNetworkInterface : TerraformResource
{
    public AzurermNetworkInterface(string name) : base("azurerm_network_interface", name)
    {
    }

    /// <summary>
    /// The accelerated_networking_enabled attribute.
    /// </summary>
    [TerraformProperty("accelerated_networking_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AcceleratedNetworkingEnabled { get; set; }

    /// <summary>
    /// The auxiliary_mode attribute.
    /// </summary>
    [TerraformProperty("auxiliary_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuxiliaryMode { get; set; }

    /// <summary>
    /// The auxiliary_sku attribute.
    /// </summary>
    [TerraformProperty("auxiliary_sku")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuxiliarySku { get; set; }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformProperty("dns_servers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? DnsServers { get; set; }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformProperty("edge_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EdgeZone { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The internal_dns_name_label attribute.
    /// </summary>
    [TerraformProperty("internal_dns_name_label")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InternalDnsNameLabel { get; set; }

    /// <summary>
    /// The ip_forwarding_enabled attribute.
    /// </summary>
    [TerraformProperty("ip_forwarding_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IpForwardingEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpConfiguration block(s) required")]
    [TerraformProperty("ip_configuration")]
    public required TerraformList<AzurermNetworkInterfaceIpConfigurationBlock> IpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermNetworkInterfaceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The applied_dns_servers attribute.
    /// </summary>
    [TerraformProperty("applied_dns_servers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AppliedDnsServers { get; }

    /// <summary>
    /// The internal_domain_name_suffix attribute.
    /// </summary>
    [TerraformProperty("internal_domain_name_suffix")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InternalDomainNameSuffix { get; }

    /// <summary>
    /// The mac_address attribute.
    /// </summary>
    [TerraformProperty("mac_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MacAddress { get; }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformProperty("private_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateIpAddress { get; }

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("private_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> PrivateIpAddresses { get; }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [TerraformProperty("virtual_machine_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VirtualMachineId { get; }

}
