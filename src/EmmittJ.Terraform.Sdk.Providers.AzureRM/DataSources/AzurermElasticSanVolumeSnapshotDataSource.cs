using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("source_id");
        this.DeclareOutput("source_volume_size_in_gib");
        this.DeclareOutput("volume_name");
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The volume_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeGroupId
    {
        get => GetProperty<TerraformProperty<string>>("volume_group_id");
        set => this.WithProperty("volume_group_id", value);
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
