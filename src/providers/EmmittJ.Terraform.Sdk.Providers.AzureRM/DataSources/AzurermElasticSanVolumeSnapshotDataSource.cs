using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticSanVolumeSnapshotDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The volume_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeGroupId is required")]
    [TerraformPropertyName("volume_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VolumeGroupId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermElasticSanVolumeSnapshotDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The source_id attribute.
    /// </summary>
    [TerraformPropertyName("source_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_id");

    /// <summary>
    /// The source_volume_size_in_gib attribute.
    /// </summary>
    [TerraformPropertyName("source_volume_size_in_gib")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SourceVolumeSizeInGib => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "source_volume_size_in_gib");

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    [TerraformPropertyName("volume_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VolumeName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "volume_name");

}
