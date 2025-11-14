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
public class AzurermNetworkServiceTagsDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_network_service_tags.
/// </summary>
public class AzurermNetworkServiceTagsDataSource : TerraformDataSource
{
    public AzurermNetworkServiceTagsDataSource(string name) : base("azurerm_network_service_tags", name)
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The location_filter attribute.
    /// </summary>
    [TerraformArgument("location_filter")]
    public TerraformValue<string>? LocationFilter
    {
        get => new TerraformReference<string>(this, "location_filter");
        set => SetArgument("location_filter", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformArgument("service")]
    public required TerraformValue<string> Service
    {
        get => new TerraformReference<string>(this, "service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNetworkServiceTagsDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    [TerraformArgument("address_prefixes")]
    public TerraformList<string> AddressPrefixes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "address_prefixes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ipv4_cidrs attribute.
    /// </summary>
    [TerraformArgument("ipv4_cidrs")]
    public TerraformList<string> Ipv4Cidrs
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ipv4_cidrs").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ipv6_cidrs attribute.
    /// </summary>
    [TerraformArgument("ipv6_cidrs")]
    public TerraformList<string> Ipv6Cidrs
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ipv6_cidrs").ResolveNodes(ctx));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformArgument("name")]
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

}
