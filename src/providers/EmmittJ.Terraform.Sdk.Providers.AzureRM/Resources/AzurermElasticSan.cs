using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermElasticSanSkuBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformPropertyName("tier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Tier { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticSanTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_elastic_san resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermElasticSan : TerraformResource
{
    public AzurermElasticSan(string name) : base("azurerm_elastic_san", name)
    {
    }

    /// <summary>
    /// The base_size_in_tib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseSizeInTib is required")]
    [TerraformPropertyName("base_size_in_tib")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> BaseSizeInTib { get; set; }

    /// <summary>
    /// The extended_size_in_tib attribute.
    /// </summary>
    [TerraformPropertyName("extended_size_in_tib")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ExtendedSizeInTib { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Zones { get; set; }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformPropertyName("sku")]
    public TerraformList<TerraformBlock<AzurermElasticSanSkuBlock>>? Sku { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermElasticSanTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The total_iops attribute.
    /// </summary>
    [TerraformPropertyName("total_iops")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalIops => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_iops");

    /// <summary>
    /// The total_mbps attribute.
    /// </summary>
    [TerraformPropertyName("total_mbps")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalMbps => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_mbps");

    /// <summary>
    /// The total_size_in_tib attribute.
    /// </summary>
    [TerraformPropertyName("total_size_in_tib")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalSizeInTib => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_size_in_tib");

    /// <summary>
    /// The total_volume_size_in_gib attribute.
    /// </summary>
    [TerraformPropertyName("total_volume_size_in_gib")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalVolumeSizeInGib => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_volume_size_in_gib");

    /// <summary>
    /// The volume_group_count attribute.
    /// </summary>
    [TerraformPropertyName("volume_group_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> VolumeGroupCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "volume_group_count");

}
