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
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The base_size_in_tib attribute.
    /// </summary>
    public TerraformValue<double> BaseSizeInTib
        => CreateReference("base_size_in_tib");

    /// <summary>
    /// The extended_size_in_tib attribute.
    /// </summary>
    public TerraformValue<double> ExtendedSizeInTib
        => CreateReference("extended_size_in_tib");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Sku
        => CreateReference("sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The total_iops attribute.
    /// </summary>
    public TerraformValue<double> TotalIops
        => CreateReference("total_iops");

    /// <summary>
    /// The total_mbps attribute.
    /// </summary>
    public TerraformValue<double> TotalMbps
        => CreateReference("total_mbps");

    /// <summary>
    /// The total_size_in_tib attribute.
    /// </summary>
    public TerraformValue<double> TotalSizeInTib
        => CreateReference("total_size_in_tib");

    /// <summary>
    /// The total_volume_size_in_gib attribute.
    /// </summary>
    public TerraformValue<double> TotalVolumeSizeInGib
        => CreateReference("total_volume_size_in_gib");

    /// <summary>
    /// The volume_group_count attribute.
    /// </summary>
    public TerraformValue<double> VolumeGroupCount
        => CreateReference("volume_group_count");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
        => CreateReference("zones");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermElasticSanDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermElasticSanDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
