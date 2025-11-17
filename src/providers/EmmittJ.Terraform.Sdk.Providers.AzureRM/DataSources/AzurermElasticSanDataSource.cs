using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermElasticSanDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_elastic_san Terraform data source.
/// Retrieves information about a azurerm_elastic_san.
/// </summary>
public partial class AzurermElasticSanDataSource(string name) : TerraformDataSource("azurerm_elastic_san", name)
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
    /// The base_size_in_tib attribute.
    /// </summary>
    public TerraformValue<double> BaseSizeInTib
    {
        get => new TerraformReference<double>(this, "base_size_in_tib");
    }

    /// <summary>
    /// The extended_size_in_tib attribute.
    /// </summary>
    public TerraformValue<double> ExtendedSizeInTib
    {
        get => new TerraformReference<double>(this, "extended_size_in_tib");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Sku
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "sku").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The total_iops attribute.
    /// </summary>
    public TerraformValue<double> TotalIops
    {
        get => new TerraformReference<double>(this, "total_iops");
    }

    /// <summary>
    /// The total_mbps attribute.
    /// </summary>
    public TerraformValue<double> TotalMbps
    {
        get => new TerraformReference<double>(this, "total_mbps");
    }

    /// <summary>
    /// The total_size_in_tib attribute.
    /// </summary>
    public TerraformValue<double> TotalSizeInTib
    {
        get => new TerraformReference<double>(this, "total_size_in_tib");
    }

    /// <summary>
    /// The total_volume_size_in_gib attribute.
    /// </summary>
    public TerraformValue<double> TotalVolumeSizeInGib
    {
        get => new TerraformReference<double>(this, "total_volume_size_in_gib");
    }

    /// <summary>
    /// The volume_group_count attribute.
    /// </summary>
    public TerraformValue<double> VolumeGroupCount
    {
        get => new TerraformReference<double>(this, "volume_group_count");
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "zones").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermElasticSanDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermElasticSanDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
