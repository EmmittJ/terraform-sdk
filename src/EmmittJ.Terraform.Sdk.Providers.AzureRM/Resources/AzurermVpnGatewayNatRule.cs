using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for external_mapping in .
/// Nesting mode: list
/// </summary>
public class AzurermVpnGatewayNatRuleExternalMappingBlock : TerraformBlock
{
    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressSpace is required")]
    public required TerraformProperty<string> AddressSpace
    {
        get => GetProperty<TerraformProperty<string>>("address_space");
        set => WithProperty("address_space", value);
    }

    /// <summary>
    /// The port_range attribute.
    /// </summary>
    public TerraformProperty<string>? PortRange
    {
        get => GetProperty<TerraformProperty<string>>("port_range");
        set => WithProperty("port_range", value);
    }

}

/// <summary>
/// Block type for internal_mapping in .
/// Nesting mode: list
/// </summary>
public class AzurermVpnGatewayNatRuleInternalMappingBlock : TerraformBlock
{
    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressSpace is required")]
    public required TerraformProperty<string> AddressSpace
    {
        get => GetProperty<TerraformProperty<string>>("address_space");
        set => WithProperty("address_space", value);
    }

    /// <summary>
    /// The port_range attribute.
    /// </summary>
    public TerraformProperty<string>? PortRange
    {
        get => GetProperty<TerraformProperty<string>>("port_range");
        set => WithProperty("port_range", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVpnGatewayNatRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_vpn_gateway_nat_rule resource.
/// </summary>
public class AzurermVpnGatewayNatRule : TerraformResource
{
    public AzurermVpnGatewayNatRule(string name) : base("azurerm_vpn_gateway_nat_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ip_configuration_id attribute.
    /// </summary>
    public TerraformProperty<string>? IpConfigurationId
    {
        get => GetProperty<TerraformProperty<string>>("ip_configuration_id");
        set => this.WithProperty("ip_configuration_id", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => this.WithProperty("mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnGatewayId is required")]
    public required TerraformProperty<string> VpnGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("vpn_gateway_id");
        set => this.WithProperty("vpn_gateway_id", value);
    }

    /// <summary>
    /// Block for external_mapping.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVpnGatewayNatRuleExternalMappingBlock>? ExternalMapping
    {
        get => GetProperty<List<AzurermVpnGatewayNatRuleExternalMappingBlock>>("external_mapping");
        set => this.WithProperty("external_mapping", value);
    }

    /// <summary>
    /// Block for internal_mapping.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVpnGatewayNatRuleInternalMappingBlock>? InternalMapping
    {
        get => GetProperty<List<AzurermVpnGatewayNatRuleInternalMappingBlock>>("internal_mapping");
        set => this.WithProperty("internal_mapping", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVpnGatewayNatRuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVpnGatewayNatRuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
