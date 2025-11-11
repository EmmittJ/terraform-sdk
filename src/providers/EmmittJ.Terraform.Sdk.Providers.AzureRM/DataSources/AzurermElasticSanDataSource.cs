using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticSanDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermElasticSanDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The base_size_in_tib attribute.
    /// </summary>
    [TerraformPropertyName("base_size_in_tib")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> BaseSizeInTib => new TerraformReference(this, "base_size_in_tib");

    /// <summary>
    /// The extended_size_in_tib attribute.
    /// </summary>
    [TerraformPropertyName("extended_size_in_tib")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ExtendedSizeInTib => new TerraformReference(this, "extended_size_in_tib");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Sku => new TerraformReference(this, "sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The total_iops attribute.
    /// </summary>
    [TerraformPropertyName("total_iops")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TotalIops => new TerraformReference(this, "total_iops");

    /// <summary>
    /// The total_mbps attribute.
    /// </summary>
    [TerraformPropertyName("total_mbps")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TotalMbps => new TerraformReference(this, "total_mbps");

    /// <summary>
    /// The total_size_in_tib attribute.
    /// </summary>
    [TerraformPropertyName("total_size_in_tib")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TotalSizeInTib => new TerraformReference(this, "total_size_in_tib");

    /// <summary>
    /// The total_volume_size_in_gib attribute.
    /// </summary>
    [TerraformPropertyName("total_volume_size_in_gib")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TotalVolumeSizeInGib => new TerraformReference(this, "total_volume_size_in_gib");

    /// <summary>
    /// The volume_group_count attribute.
    /// </summary>
    [TerraformPropertyName("volume_group_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> VolumeGroupCount => new TerraformReference(this, "volume_group_count");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Zones => new TerraformReference(this, "zones");

}
