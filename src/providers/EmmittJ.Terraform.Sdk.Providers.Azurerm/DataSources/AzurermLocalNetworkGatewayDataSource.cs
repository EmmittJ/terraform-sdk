using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermLocalNetworkGatewayDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermLocalNetworkGatewayDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_local_network_gateway Terraform data source.
/// Retrieves information about a azurerm_local_network_gateway.
/// </summary>
public partial class AzurermLocalNetworkGatewayDataSource(string name) : TerraformDataSource("azurerm_local_network_gateway", name)
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
    /// The address_space attribute.
    /// </summary>
    public TerraformList<string> AddressSpace
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "address_space").ResolveNodes(ctx));
    }

    /// <summary>
    /// The bgp_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BgpSettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "bgp_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The gateway_address attribute.
    /// </summary>
    public TerraformValue<string> GatewayAddress
    {
        get => new TerraformReference<string>(this, "gateway_address");
    }

    /// <summary>
    /// The gateway_fqdn attribute.
    /// </summary>
    public TerraformValue<string> GatewayFqdn
    {
        get => new TerraformReference<string>(this, "gateway_fqdn");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLocalNetworkGatewayDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLocalNetworkGatewayDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
