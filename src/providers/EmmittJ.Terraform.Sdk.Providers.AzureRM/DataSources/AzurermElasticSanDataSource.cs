using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticSanDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_elastic_san.
/// </summary>
public class AzurermElasticSanDataSource : TerraformDataSource
{
    public AzurermElasticSanDataSource(string name) : base("azurerm_elastic_san", name)
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermElasticSanDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The base_size_in_tib attribute.
    /// </summary>
    [TerraformPropertyName("base_size_in_tib")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> BaseSizeInTib => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "base_size_in_tib");

    /// <summary>
    /// The extended_size_in_tib attribute.
    /// </summary>
    [TerraformPropertyName("extended_size_in_tib")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ExtendedSizeInTib => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "extended_size_in_tib");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Sku => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

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

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Zones => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "zones");

}
