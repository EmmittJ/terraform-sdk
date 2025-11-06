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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The volume_group_id attribute.
    /// </summary>
    public string? VolumeGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("volume_group_id")?.Value;
        set => this.WithProperty("volume_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
