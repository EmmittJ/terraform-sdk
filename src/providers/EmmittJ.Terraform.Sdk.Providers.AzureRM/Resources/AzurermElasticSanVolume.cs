using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for create_source in .
/// Nesting mode: list
/// </summary>
public class AzurermElasticSanVolumeCreateSourceBlock : ITerraformBlock
{
    /// <summary>
    /// The source_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceId is required")]
    [TerraformPropertyName("source_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceId { get; set; }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceType is required")]
    [TerraformPropertyName("source_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticSanVolumeTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_elastic_san_volume resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermElasticSanVolume : TerraformResource
{
    public AzurermElasticSanVolume(string name) : base("azurerm_elastic_san_volume", name)
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
    /// The size_in_gib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeInGib is required")]
    [TerraformPropertyName("size_in_gib")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> SizeInGib { get; set; }

    /// <summary>
    /// The volume_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeGroupId is required")]
    [TerraformPropertyName("volume_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VolumeGroupId { get; set; }

    /// <summary>
    /// Block for create_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreateSource block(s) allowed")]
    [TerraformPropertyName("create_source")]
    public TerraformList<TerraformBlock<AzurermElasticSanVolumeCreateSourceBlock>>? CreateSource { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermElasticSanVolumeTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The target_iqn attribute.
    /// </summary>
    [TerraformPropertyName("target_iqn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TargetIqn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "target_iqn");

    /// <summary>
    /// The target_portal_hostname attribute.
    /// </summary>
    [TerraformPropertyName("target_portal_hostname")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TargetPortalHostname => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "target_portal_hostname");

    /// <summary>
    /// The target_portal_port attribute.
    /// </summary>
    [TerraformPropertyName("target_portal_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TargetPortalPort => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "target_portal_port");

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [TerraformPropertyName("volume_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VolumeId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "volume_id");

}
