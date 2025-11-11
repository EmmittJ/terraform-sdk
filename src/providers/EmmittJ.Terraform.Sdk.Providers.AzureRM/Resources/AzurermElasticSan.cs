using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public partial class AzurermElasticSanSkuBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformProperty("tier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Tier { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermElasticSanTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_elastic_san resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermElasticSan : TerraformResource
{
    public AzurermElasticSan(string name) : base("azurerm_elastic_san", name)
    {
    }

    /// <summary>
    /// The base_size_in_tib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseSizeInTib is required")]
    [TerraformProperty("base_size_in_tib")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> BaseSizeInTib { get; set; }

    /// <summary>
    /// The extended_size_in_tib attribute.
    /// </summary>
    [TerraformProperty("extended_size_in_tib")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ExtendedSizeInTib { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Zones { get; set; }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformProperty("sku")]
    public partial TerraformList<TerraformBlock<AzurermElasticSanSkuBlock>>? Sku { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermElasticSanTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The total_iops attribute.
    /// </summary>
    [TerraformProperty("total_iops")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TotalIops { get; }

    /// <summary>
    /// The total_mbps attribute.
    /// </summary>
    [TerraformProperty("total_mbps")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TotalMbps { get; }

    /// <summary>
    /// The total_size_in_tib attribute.
    /// </summary>
    [TerraformProperty("total_size_in_tib")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TotalSizeInTib { get; }

    /// <summary>
    /// The total_volume_size_in_gib attribute.
    /// </summary>
    [TerraformProperty("total_volume_size_in_gib")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TotalVolumeSizeInGib { get; }

    /// <summary>
    /// The volume_group_count attribute.
    /// </summary>
    [TerraformProperty("volume_group_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> VolumeGroupCount { get; }

}
