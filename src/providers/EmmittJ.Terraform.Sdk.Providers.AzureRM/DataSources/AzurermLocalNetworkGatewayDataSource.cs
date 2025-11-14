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
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_local_network_gateway.
/// </summary>
public class AzurermLocalNetworkGatewayDataSource : TerraformDataSource
{
    public AzurermLocalNetworkGatewayDataSource(string name) : base("azurerm_local_network_gateway", name)
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermLocalNetworkGatewayDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [TerraformArgument("address_space")]
    public TerraformList<string> AddressSpace
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "address_space").ResolveNodes(ctx));
    }

    /// <summary>
    /// The bgp_settings attribute.
    /// </summary>
    [TerraformArgument("bgp_settings")]
    public TerraformList<object> BgpSettings
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "bgp_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The gateway_address attribute.
    /// </summary>
    [TerraformArgument("gateway_address")]
    public TerraformValue<string> GatewayAddress
    {
        get => new TerraformReference<string>(this, "gateway_address");
    }

    /// <summary>
    /// The gateway_fqdn attribute.
    /// </summary>
    [TerraformArgument("gateway_fqdn")]
    public TerraformValue<string> GatewayFqdn
    {
        get => new TerraformReference<string>(this, "gateway_fqdn");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

}
