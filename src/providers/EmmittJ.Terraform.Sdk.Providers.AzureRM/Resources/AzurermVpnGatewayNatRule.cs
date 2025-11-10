using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for external_mapping in .
/// Nesting mode: list
/// </summary>
public class AzurermVpnGatewayNatRuleExternalMappingBlock : ITerraformBlock
{
    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressSpace is required")]
    [TerraformPropertyName("address_space")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AddressSpace { get; set; }

    /// <summary>
    /// The port_range attribute.
    /// </summary>
    [TerraformPropertyName("port_range")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PortRange { get; set; }

}

/// <summary>
/// Block type for internal_mapping in .
/// Nesting mode: list
/// </summary>
public class AzurermVpnGatewayNatRuleInternalMappingBlock : ITerraformBlock
{
    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressSpace is required")]
    [TerraformPropertyName("address_space")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AddressSpace { get; set; }

    /// <summary>
    /// The port_range attribute.
    /// </summary>
    [TerraformPropertyName("port_range")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PortRange { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVpnGatewayNatRuleTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_vpn_gateway_nat_rule resource.
/// </summary>
public class AzurermVpnGatewayNatRule : TerraformResource
{
    public AzurermVpnGatewayNatRule(string name) : base("azurerm_vpn_gateway_nat_rule", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ip_configuration_id attribute.
    /// </summary>
    [TerraformPropertyName("ip_configuration_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IpConfigurationId { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Mode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnGatewayId is required")]
    [TerraformPropertyName("vpn_gateway_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VpnGatewayId { get; set; }

    /// <summary>
    /// Block for external_mapping.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("external_mapping")]
    public TerraformList<TerraformBlock<AzurermVpnGatewayNatRuleExternalMappingBlock>>? ExternalMapping { get; set; } = new();

    /// <summary>
    /// Block for internal_mapping.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("internal_mapping")]
    public TerraformList<TerraformBlock<AzurermVpnGatewayNatRuleInternalMappingBlock>>? InternalMapping { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVpnGatewayNatRuleTimeoutsBlock>? Timeouts { get; set; } = new();

}
