using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "read");
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
    /// The volume_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeGroupId is required")]
    public required TerraformValue<string> VolumeGroupId
    {
        get => new TerraformReference<string>(this, "volume_group_id");
        set => SetArgument("volume_group_id", value);
    }

    /// <summary>
    /// The source_id attribute.
    /// </summary>
    public TerraformValue<string> SourceId
    {
        get => new TerraformReference<string>(this, "source_id");
    }

    /// <summary>
    /// The source_volume_size_in_gib attribute.
    /// </summary>
    public TerraformValue<double> SourceVolumeSizeInGib
    {
        get => new TerraformReference<double>(this, "source_volume_size_in_gib");
    }

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    public TerraformValue<string> VolumeName
    {
        get => new TerraformReference<string>(this, "volume_name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermElasticSanVolumeSnapshotDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermElasticSanVolumeSnapshotDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
