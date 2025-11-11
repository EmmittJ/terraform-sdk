using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticSanVolumeSnapshotDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The volume_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeGroupId is required")]
    [TerraformPropertyName("volume_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VolumeGroupId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermElasticSanVolumeSnapshotDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The source_id attribute.
    /// </summary>
    [TerraformPropertyName("source_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceId => new TerraformReference(this, "source_id");

    /// <summary>
    /// The source_volume_size_in_gib attribute.
    /// </summary>
    [TerraformPropertyName("source_volume_size_in_gib")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SourceVolumeSizeInGib => new TerraformReference(this, "source_volume_size_in_gib");

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    [TerraformPropertyName("volume_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VolumeName => new TerraformReference(this, "volume_name");

}
