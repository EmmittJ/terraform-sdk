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
public class AzurermElasticSanVolumeSnapshotDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_elastic_san_volume_snapshot.
/// </summary>
public class AzurermElasticSanVolumeSnapshotDataSource : TerraformDataSource
{
    public AzurermElasticSanVolumeSnapshotDataSource(string name) : base("azurerm_elastic_san_volume_snapshot", name)
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
    /// The volume_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeGroupId is required")]
    [TerraformArgument("volume_group_id")]
    public required TerraformValue<string> VolumeGroupId
    {
        get => new TerraformReference<string>(this, "volume_group_id");
        set => SetArgument("volume_group_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermElasticSanVolumeSnapshotDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The source_id attribute.
    /// </summary>
    [TerraformArgument("source_id")]
    public TerraformValue<string> SourceId
    {
        get => new TerraformReference<string>(this, "source_id");
    }

    /// <summary>
    /// The source_volume_size_in_gib attribute.
    /// </summary>
    [TerraformArgument("source_volume_size_in_gib")]
    public TerraformValue<double> SourceVolumeSizeInGib
    {
        get => new TerraformReference<double>(this, "source_volume_size_in_gib");
    }

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    [TerraformArgument("volume_name")]
    public TerraformValue<string> VolumeName
    {
        get => new TerraformReference<string>(this, "volume_name");
    }

}
