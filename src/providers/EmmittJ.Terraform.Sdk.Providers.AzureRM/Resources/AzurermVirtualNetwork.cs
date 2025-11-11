using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ddos_protection_plan in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualNetworkDdosProtectionPlanBlock : TerraformBlockBase
{
    /// <summary>
    /// The enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enable is required")]
    [TerraformProperty("enable")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enable { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Id { get; set; }

}

/// <summary>
/// Block type for encryption in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualNetworkEncryptionBlock : TerraformBlockBase
{
    /// <summary>
    /// The enforcement attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enforcement is required")]
    [TerraformProperty("enforcement")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Enforcement { get; set; }

}

/// <summary>
/// Block type for ip_address_pool in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualNetworkIpAddressPoolBlock : TerraformBlockBase
{

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The number_of_ip_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfIpAddresses is required")]
    [TerraformProperty("number_of_ip_addresses")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NumberOfIpAddresses { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualNetworkTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_virtual_network resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermVirtualNetwork : TerraformResource
{
    public AzurermVirtualNetwork(string name) : base("azurerm_virtual_network", name)
    {
    }

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [TerraformProperty("address_space")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AddressSpace { get; set; }

    /// <summary>
    /// The bgp_community attribute.
    /// </summary>
    [TerraformProperty("bgp_community")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BgpCommunity { get; set; }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformProperty("dns_servers")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> DnsServers { get; set; }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformProperty("edge_zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EdgeZone { get; set; }

    /// <summary>
    /// The flow_timeout_in_minutes attribute.
    /// </summary>
    [TerraformProperty("flow_timeout_in_minutes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? FlowTimeoutInMinutes { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The private_endpoint_vnet_policies attribute.
    /// </summary>
    [TerraformProperty("private_endpoint_vnet_policies")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrivateEndpointVnetPolicies { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The subnet attribute.
    /// </summary>
    [TerraformProperty("subnet")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<object> Subnet { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for ddos_protection_plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DdosProtectionPlan block(s) allowed")]
    [TerraformProperty("ddos_protection_plan")]
    public TerraformList<TerraformBlock<AzurermVirtualNetworkDdosProtectionPlanBlock>>? DdosProtectionPlan { get; set; }

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    [TerraformProperty("encryption")]
    public TerraformList<TerraformBlock<AzurermVirtualNetworkEncryptionBlock>>? Encryption { get; set; }

    /// <summary>
    /// Block for ip_address_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 IpAddressPool block(s) allowed")]
    [TerraformProperty("ip_address_pool")]
    public TerraformList<TerraformBlock<AzurermVirtualNetworkIpAddressPoolBlock>>? IpAddressPool { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermVirtualNetworkTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The guid attribute.
    /// </summary>
    [TerraformProperty("guid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Guid { get; }

}
