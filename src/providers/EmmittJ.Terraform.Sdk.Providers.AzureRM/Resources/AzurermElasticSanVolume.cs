using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for create_source in .
/// Nesting mode: list
/// </summary>
public partial class AzurermElasticSanVolumeCreateSourceBlock() : TerraformBlock("create_source")
{
    /// <summary>
    /// The source_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceId is required")]
    [TerraformProperty("source_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceId { get; set; }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceType is required")]
    [TerraformProperty("source_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermElasticSanVolumeTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_elastic_san_volume resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermElasticSanVolume : TerraformResource
{
    public AzurermElasticSanVolume(string name) : base("azurerm_elastic_san_volume", name)
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
    /// The size_in_gib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeInGib is required")]
    [TerraformProperty("size_in_gib")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> SizeInGib { get; set; }

    /// <summary>
    /// The volume_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeGroupId is required")]
    [TerraformProperty("volume_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VolumeGroupId { get; set; }

    /// <summary>
    /// Block for create_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreateSource block(s) allowed")]
    [TerraformProperty("create_source")]
    public TerraformList<AzurermElasticSanVolumeCreateSourceBlock> CreateSource { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermElasticSanVolumeTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The target_iqn attribute.
    /// </summary>
    [TerraformProperty("target_iqn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TargetIqn { get; }

    /// <summary>
    /// The target_portal_hostname attribute.
    /// </summary>
    [TerraformProperty("target_portal_hostname")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TargetPortalHostname { get; }

    /// <summary>
    /// The target_portal_port attribute.
    /// </summary>
    [TerraformProperty("target_portal_port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TargetPortalPort { get; }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [TerraformProperty("volume_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VolumeId { get; }

}
