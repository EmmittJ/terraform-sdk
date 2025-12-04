using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermElasticSanVolumeSnapshotDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermElasticSanVolumeSnapshotDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_elastic_san_volume_snapshot Terraform data source.
/// Retrieves information about a azurerm_elastic_san_volume_snapshot.
/// </summary>
public partial class AzurermElasticSanVolumeSnapshotDataSource(string name) : TerraformDataSource("azurerm_elastic_san_volume_snapshot", name)
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
    /// The volume_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeGroupId is required")]
    public required TerraformValue<string> VolumeGroupId
    {
        get => GetArgument<TerraformValue<string>>("volume_group_id");
        set => SetArgument("volume_group_id", value);
    }

    /// <summary>
    /// The source_id attribute.
    /// </summary>
    public TerraformValue<string> SourceId
        => AsReference("source_id");

    /// <summary>
    /// The source_volume_size_in_gib attribute.
    /// </summary>
    public TerraformValue<double> SourceVolumeSizeInGib
        => AsReference("source_volume_size_in_gib");

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    public TerraformValue<string> VolumeName
        => AsReference("volume_name");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermElasticSanVolumeSnapshotDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermElasticSanVolumeSnapshotDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
