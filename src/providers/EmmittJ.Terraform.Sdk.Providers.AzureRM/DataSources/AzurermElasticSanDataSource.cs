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
public class AzurermElasticSanDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_elastic_san.
/// </summary>
public class AzurermElasticSanDataSource : TerraformDataSource
{
    public AzurermElasticSanDataSource(string name) : base("azurerm_elastic_san", name)
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
    public AzurermElasticSanDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The base_size_in_tib attribute.
    /// </summary>
    [TerraformArgument("base_size_in_tib")]
    public TerraformValue<double> BaseSizeInTib
    {
        get => new TerraformReference<double>(this, "base_size_in_tib");
    }

    /// <summary>
    /// The extended_size_in_tib attribute.
    /// </summary>
    [TerraformArgument("extended_size_in_tib")]
    public TerraformValue<double> ExtendedSizeInTib
    {
        get => new TerraformReference<double>(this, "extended_size_in_tib");
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
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformList<object> Sku
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "sku").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The total_iops attribute.
    /// </summary>
    [TerraformArgument("total_iops")]
    public TerraformValue<double> TotalIops
    {
        get => new TerraformReference<double>(this, "total_iops");
    }

    /// <summary>
    /// The total_mbps attribute.
    /// </summary>
    [TerraformArgument("total_mbps")]
    public TerraformValue<double> TotalMbps
    {
        get => new TerraformReference<double>(this, "total_mbps");
    }

    /// <summary>
    /// The total_size_in_tib attribute.
    /// </summary>
    [TerraformArgument("total_size_in_tib")]
    public TerraformValue<double> TotalSizeInTib
    {
        get => new TerraformReference<double>(this, "total_size_in_tib");
    }

    /// <summary>
    /// The total_volume_size_in_gib attribute.
    /// </summary>
    [TerraformArgument("total_volume_size_in_gib")]
    public TerraformValue<double> TotalVolumeSizeInGib
    {
        get => new TerraformReference<double>(this, "total_volume_size_in_gib");
    }

    /// <summary>
    /// The volume_group_count attribute.
    /// </summary>
    [TerraformArgument("volume_group_count")]
    public TerraformValue<double> VolumeGroupCount
    {
        get => new TerraformReference<double>(this, "volume_group_count");
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformArgument("zones")]
    public TerraformList<string> Zones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "zones").ResolveNodes(ctx));
    }

}
