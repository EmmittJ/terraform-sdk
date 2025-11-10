using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ddos_protection_plan in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkDdosProtectionPlanBlock : ITerraformBlock
{
    /// <summary>
    /// The enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enable is required")]
    [TerraformPropertyName("enable")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enable { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

}

/// <summary>
/// Block type for encryption in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkEncryptionBlock : ITerraformBlock
{
    /// <summary>
    /// The enforcement attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enforcement is required")]
    [TerraformPropertyName("enforcement")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Enforcement { get; set; }

}

/// <summary>
/// Block type for ip_address_pool in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkIpAddressPoolBlock : ITerraformBlock
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
public class AzurermVirtualNetworkTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_virtual_network resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVirtualNetwork : TerraformResource
{
    public AzurermVirtualNetwork(string name) : base("azurerm_virtual_network", name)
    {
    }

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [TerraformPropertyName("address_space")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AddressSpace { get; set; }

    /// <summary>
    /// The bgp_community attribute.
    /// </summary>
    [TerraformPropertyName("bgp_community")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BgpCommunity { get; set; }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformPropertyName("dns_servers")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> DnsServers { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "dns_servers");

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformPropertyName("edge_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EdgeZone { get; set; }

    /// <summary>
    /// The flow_timeout_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("flow_timeout_in_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? FlowTimeoutInMinutes { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The private_endpoint_vnet_policies attribute.
    /// </summary>
    [TerraformPropertyName("private_endpoint_vnet_policies")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrivateEndpointVnetPolicies { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The subnet attribute.
    /// </summary>
    [TerraformPropertyName("subnet")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<object>>> Subnet { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "subnet");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for ddos_protection_plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DdosProtectionPlan block(s) allowed")]
    [TerraformPropertyName("ddos_protection_plan")]
    public TerraformList<TerraformBlock<AzurermVirtualNetworkDdosProtectionPlanBlock>>? DdosProtectionPlan { get; set; } = new();

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    [TerraformPropertyName("encryption")]
    public TerraformList<TerraformBlock<AzurermVirtualNetworkEncryptionBlock>>? Encryption { get; set; } = new();

    /// <summary>
    /// Block for ip_address_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 IpAddressPool block(s) allowed")]
    [TerraformPropertyName("ip_address_pool")]
    public TerraformList<TerraformBlock<AzurermVirtualNetworkIpAddressPoolBlock>>? IpAddressPool { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVirtualNetworkTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The guid attribute.
    /// </summary>
    [TerraformPropertyName("guid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Guid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "guid");

}
