using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermElasticSanVolumeSnapshotDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_elastic_san_volume_snapshot.
/// </summary>
public partial class AzurermElasticSanVolumeSnapshotDataSource : TerraformDataSource
{
    public AzurermElasticSanVolumeSnapshotDataSource(string name) : base("azurerm_elastic_san_volume_snapshot", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The volume_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeGroupId is required")]
    [TerraformProperty("volume_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VolumeGroupId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermElasticSanVolumeSnapshotDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The source_id attribute.
    /// </summary>
    [TerraformProperty("source_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceId { get; }

    /// <summary>
    /// The source_volume_size_in_gib attribute.
    /// </summary>
    [TerraformProperty("source_volume_size_in_gib")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> SourceVolumeSizeInGib { get; }

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    [TerraformProperty("volume_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VolumeName { get; }

}
