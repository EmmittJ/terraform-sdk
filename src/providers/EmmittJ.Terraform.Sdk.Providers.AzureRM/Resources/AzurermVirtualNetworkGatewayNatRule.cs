using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for external_mapping in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualNetworkGatewayNatRuleExternalMappingBlock : TerraformBlockBase
{
    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressSpace is required")]
    [TerraformProperty("address_space")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AddressSpace { get; set; }

    /// <summary>
    /// The port_range attribute.
    /// </summary>
    [TerraformProperty("port_range")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PortRange { get; set; }

}

/// <summary>
/// Block type for internal_mapping in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualNetworkGatewayNatRuleInternalMappingBlock : TerraformBlockBase
{
    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressSpace is required")]
    [TerraformProperty("address_space")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AddressSpace { get; set; }

    /// <summary>
    /// The port_range attribute.
    /// </summary>
    [TerraformProperty("port_range")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PortRange { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualNetworkGatewayNatRuleTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_virtual_network_gateway_nat_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermVirtualNetworkGatewayNatRule : TerraformResource
{
    public AzurermVirtualNetworkGatewayNatRule(string name) : base("azurerm_virtual_network_gateway_nat_rule", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ip_configuration_id attribute.
    /// </summary>
    [TerraformProperty("ip_configuration_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IpConfigurationId { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Mode { get; set; }

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
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The virtual_network_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkGatewayId is required")]
    [TerraformProperty("virtual_network_gateway_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VirtualNetworkGatewayId { get; set; }

    /// <summary>
    /// Block for external_mapping.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalMapping is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExternalMapping block(s) required")]
    [TerraformProperty("external_mapping")]
    public partial TerraformList<TerraformBlock<AzurermVirtualNetworkGatewayNatRuleExternalMappingBlock>>? ExternalMapping { get; set; }

    /// <summary>
    /// Block for internal_mapping.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InternalMapping is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InternalMapping block(s) required")]
    [TerraformProperty("internal_mapping")]
    public partial TerraformList<TerraformBlock<AzurermVirtualNetworkGatewayNatRuleInternalMappingBlock>>? InternalMapping { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermVirtualNetworkGatewayNatRuleTimeoutsBlock>? Timeouts { get; set; }

}
