using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for external_mapping in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVpnGatewayNatRuleExternalMappingBlock : TerraformBlockBase
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
public partial class AzurermVpnGatewayNatRuleInternalMappingBlock : TerraformBlockBase
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
public partial class AzurermVpnGatewayNatRuleTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_vpn_gateway_nat_rule resource.
/// </summary>
public partial class AzurermVpnGatewayNatRule : TerraformResource
{
    public AzurermVpnGatewayNatRule(string name) : base("azurerm_vpn_gateway_nat_rule", name)
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
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnGatewayId is required")]
    [TerraformProperty("vpn_gateway_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VpnGatewayId { get; set; }

    /// <summary>
    /// Block for external_mapping.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("external_mapping")]
    public partial TerraformList<TerraformBlock<AzurermVpnGatewayNatRuleExternalMappingBlock>>? ExternalMapping { get; set; }

    /// <summary>
    /// Block for internal_mapping.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("internal_mapping")]
    public partial TerraformList<TerraformBlock<AzurermVpnGatewayNatRuleInternalMappingBlock>>? InternalMapping { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermVpnGatewayNatRuleTimeoutsBlock>? Timeouts { get; set; }

}
