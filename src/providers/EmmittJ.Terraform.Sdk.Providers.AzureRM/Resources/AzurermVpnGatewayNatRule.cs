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
        set => SetProperty("address_space", value);
    }

    /// <summary>
    /// The port_range attribute.
    /// </summary>
    public TerraformProperty<string>? PortRange
    {
        set => SetProperty("port_range", value);
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
        set => SetProperty("address_space", value);
    }

    /// <summary>
    /// The port_range attribute.
    /// </summary>
    public TerraformProperty<string>? PortRange
    {
        set => SetProperty("port_range", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("id");
        SetOutput("ip_configuration_id");
        SetOutput("mode");
        SetOutput("name");
        SetOutput("type");
        SetOutput("vpn_gateway_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ip_configuration_id attribute.
    /// </summary>
    public TerraformProperty<string> IpConfigurationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_configuration_id");
        set => SetProperty("ip_configuration_id", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string> Mode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mode");
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnGatewayId is required")]
    public required TerraformProperty<string> VpnGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpn_gateway_id");
        set => SetProperty("vpn_gateway_id", value);
    }

    /// <summary>
    /// Block for external_mapping.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVpnGatewayNatRuleExternalMappingBlock>? ExternalMapping
    {
        set => SetProperty("external_mapping", value);
    }

    /// <summary>
    /// Block for internal_mapping.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVpnGatewayNatRuleInternalMappingBlock>? InternalMapping
    {
        set => SetProperty("internal_mapping", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVpnGatewayNatRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
