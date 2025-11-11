using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermElasticSanDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_elastic_san.
/// </summary>
public partial class AzurermElasticSanDataSource : TerraformDataSource
{
    public AzurermElasticSanDataSource(string name) : base("azurerm_elastic_san", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermElasticSanDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The base_size_in_tib attribute.
    /// </summary>
    [TerraformProperty("base_size_in_tib")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> BaseSizeInTib { get; }

    /// <summary>
    /// The extended_size_in_tib attribute.
    /// </summary>
    [TerraformProperty("extended_size_in_tib")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ExtendedSizeInTib { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Sku { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The total_iops attribute.
    /// </summary>
    [TerraformProperty("total_iops")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> TotalIops { get; }

    /// <summary>
    /// The total_mbps attribute.
    /// </summary>
    [TerraformProperty("total_mbps")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> TotalMbps { get; }

    /// <summary>
    /// The total_size_in_tib attribute.
    /// </summary>
    [TerraformProperty("total_size_in_tib")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> TotalSizeInTib { get; }

    /// <summary>
    /// The total_volume_size_in_gib attribute.
    /// </summary>
    [TerraformProperty("total_volume_size_in_gib")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> TotalVolumeSizeInGib { get; }

    /// <summary>
    /// The volume_group_count attribute.
    /// </summary>
    [TerraformProperty("volume_group_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> VolumeGroupCount { get; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Zones { get; }

}
