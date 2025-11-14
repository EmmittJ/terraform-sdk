using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("address_space")]
    public required TerraformValue<string> AddressSpace
    {
        get => new TerraformReference<string>(this, "address_space");
        set => SetArgument("address_space", value);
    }

    /// <summary>
    /// The port_range attribute.
    /// </summary>
    [TerraformArgument("port_range")]
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
    [TerraformArgument("address_space")]
    public required TerraformValue<string> AddressSpace
    {
        get => new TerraformReference<string>(this, "address_space");
        set => SetArgument("address_space", value);
    }

    /// <summary>
    /// The port_range attribute.
    /// </summary>
    [TerraformArgument("port_range")]
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_configuration_id attribute.
    /// </summary>
    [TerraformArgument("ip_configuration_id")]
    public TerraformValue<string>? IpConfigurationId
    {
        get => new TerraformReference<string>(this, "ip_configuration_id");
        set => SetArgument("ip_configuration_id", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformArgument("mode")]
    public TerraformValue<string>? Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformArgument("type")]
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnGatewayId is required")]
    [TerraformArgument("vpn_gateway_id")]
    public required TerraformValue<string> VpnGatewayId
    {
        get => new TerraformReference<string>(this, "vpn_gateway_id");
        set => SetArgument("vpn_gateway_id", value);
    }

    /// <summary>
    /// Block for external_mapping.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("external_mapping")]
    public TerraformList<AzurermVpnGatewayNatRuleExternalMappingBlock> ExternalMapping { get; set; } = new();

    /// <summary>
    /// Block for internal_mapping.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("internal_mapping")]
    public TerraformList<AzurermVpnGatewayNatRuleInternalMappingBlock> InternalMapping { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVpnGatewayNatRuleTimeoutsBlock Timeouts { get; set; } = new();

}
