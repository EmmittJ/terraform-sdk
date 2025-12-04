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
        get => GetArgument<TerraformValue<string>>("read");
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The base_size_in_tib attribute.
    /// </summary>
    public TerraformValue<double> BaseSizeInTib
        => AsReference("base_size_in_tib");

    /// <summary>
    /// The extended_size_in_tib attribute.
    /// </summary>
    public TerraformValue<double> ExtendedSizeInTib
        => AsReference("extended_size_in_tib");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Sku
        => AsReference("sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The total_iops attribute.
    /// </summary>
    public TerraformValue<double> TotalIops
        => AsReference("total_iops");

    /// <summary>
    /// The total_mbps attribute.
    /// </summary>
    public TerraformValue<double> TotalMbps
        => AsReference("total_mbps");

    /// <summary>
    /// The total_size_in_tib attribute.
    /// </summary>
    public TerraformValue<double> TotalSizeInTib
        => AsReference("total_size_in_tib");

    /// <summary>
    /// The total_volume_size_in_gib attribute.
    /// </summary>
    public TerraformValue<double> TotalVolumeSizeInGib
        => AsReference("total_volume_size_in_gib");

    /// <summary>
    /// The volume_group_count attribute.
    /// </summary>
    public TerraformValue<double> VolumeGroupCount
        => AsReference("volume_group_count");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
        => AsReference("zones");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermElasticSanDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermElasticSanDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
