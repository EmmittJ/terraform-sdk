using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticSanVolumeSnapshotDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_elastic_san_volume_snapshot.
/// </summary>
public class AzurermElasticSanVolumeSnapshotDataSource : TerraformDataSource
{
    public AzurermElasticSanVolumeSnapshotDataSource(string name) : base("azurerm_elastic_san_volume_snapshot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("source_id");
        this.WithOutput("source_volume_size_in_gib");
        this.WithOutput("volume_name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The volume_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeGroupId is required")]
    public required TerraformProperty<string> VolumeGroupId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("volume_group_id");
        set => this.WithProperty("volume_group_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermElasticSanVolumeSnapshotDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermElasticSanVolumeSnapshotDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The source_id attribute.
    /// </summary>
    public TerraformExpression SourceId => this["source_id"];

    /// <summary>
    /// The source_volume_size_in_gib attribute.
    /// </summary>
    public TerraformExpression SourceVolumeSizeInGib => this["source_volume_size_in_gib"];

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    public TerraformExpression VolumeName => this["volume_name"];

}
