using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for bgp_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermLocalNetworkGatewayBgpSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bgp_settings";

    /// <summary>
    /// The asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Asn is required")]
    public required TerraformValue<double> Asn
    {
        get => new TerraformReference<double>(this, "asn");
        set => SetArgument("asn", value);
    }

    /// <summary>
    /// The bgp_peering_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BgpPeeringAddress is required")]
    public required TerraformValue<string> BgpPeeringAddress
    {
        get => new TerraformReference<string>(this, "bgp_peering_address");
        set => SetArgument("bgp_peering_address", value);
    }

    /// <summary>
    /// The peer_weight attribute.
    /// </summary>
    public TerraformValue<double>? PeerWeight
    {
        get => new TerraformReference<double>(this, "peer_weight");
        set => SetArgument("peer_weight", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLocalNetworkGatewayTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_local_network_gateway Terraform resource.
/// Manages a azurerm_local_network_gateway resource.
/// </summary>
public partial class AzurermLocalNetworkGateway(string name) : TerraformResource("azurerm_local_network_gateway", name)
{
    /// <summary>
    /// The address_space attribute.
    /// </summary>
    public TerraformList<string>? AddressSpace
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "address_space").ResolveNodes(ctx));
        set => SetArgument("address_space", value);
    }

    /// <summary>
    /// The gateway_address attribute.
    /// </summary>
    public TerraformValue<string>? GatewayAddress
    {
        get => new TerraformReference<string>(this, "gateway_address");
        set => SetArgument("gateway_address", value);
    }

    /// <summary>
    /// The gateway_fqdn attribute.
    /// </summary>
    public TerraformValue<string>? GatewayFqdn
    {
        get => new TerraformReference<string>(this, "gateway_fqdn");
        set => SetArgument("gateway_fqdn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// BgpSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BgpSettings block(s) allowed")]
    public AzurermLocalNetworkGatewayBgpSettingsBlock? BgpSettings
    {
        get => GetArgument<AzurermLocalNetworkGatewayBgpSettingsBlock>("bgp_settings");
        set => SetArgument("bgp_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLocalNetworkGatewayTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLocalNetworkGatewayTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
