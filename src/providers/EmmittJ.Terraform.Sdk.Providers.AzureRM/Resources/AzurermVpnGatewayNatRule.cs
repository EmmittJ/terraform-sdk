using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for external_mapping in .
/// Nesting mode: list
/// </summary>
public class AzurermVpnGatewayNatRuleExternalMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "external_mapping";

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressSpace is required")]
    public required TerraformValue<string> AddressSpace
    {
        get => new TerraformReference<string>(this, "address_space");
        set => SetArgument("address_space", value);
    }

    /// <summary>
    /// The port_range attribute.
    /// </summary>
    public TerraformValue<string>? PortRange
    {
        get => new TerraformReference<string>(this, "port_range");
        set => SetArgument("port_range", value);
    }

}

/// <summary>
/// Block type for internal_mapping in .
/// Nesting mode: list
/// </summary>
public class AzurermVpnGatewayNatRuleInternalMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "internal_mapping";

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressSpace is required")]
    public required TerraformValue<string> AddressSpace
    {
        get => new TerraformReference<string>(this, "address_space");
        set => SetArgument("address_space", value);
    }

    /// <summary>
    /// The port_range attribute.
    /// </summary>
    public TerraformValue<string>? PortRange
    {
        get => new TerraformReference<string>(this, "port_range");
        set => SetArgument("port_range", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVpnGatewayNatRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_vpn_gateway_nat_rule Terraform resource.
/// Manages a azurerm_vpn_gateway_nat_rule resource.
/// </summary>
public partial class AzurermVpnGatewayNatRule(string name) : TerraformResource("azurerm_vpn_gateway_nat_rule", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_configuration_id attribute.
    /// </summary>
    public TerraformValue<string>? IpConfigurationId
    {
        get => new TerraformReference<string>(this, "ip_configuration_id");
        set => SetArgument("ip_configuration_id", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnGatewayId is required")]
    public required TerraformValue<string> VpnGatewayId
    {
        get => new TerraformReference<string>(this, "vpn_gateway_id");
        set => SetArgument("vpn_gateway_id", value);
    }

    /// <summary>
    /// ExternalMapping block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVpnGatewayNatRuleExternalMappingBlock>? ExternalMapping
    {
        get => GetArgument<TerraformList<AzurermVpnGatewayNatRuleExternalMappingBlock>>("external_mapping");
        set => SetArgument("external_mapping", value);
    }

    /// <summary>
    /// InternalMapping block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVpnGatewayNatRuleInternalMappingBlock>? InternalMapping
    {
        get => GetArgument<TerraformList<AzurermVpnGatewayNatRuleInternalMappingBlock>>("internal_mapping");
        set => SetArgument("internal_mapping", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVpnGatewayNatRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVpnGatewayNatRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
