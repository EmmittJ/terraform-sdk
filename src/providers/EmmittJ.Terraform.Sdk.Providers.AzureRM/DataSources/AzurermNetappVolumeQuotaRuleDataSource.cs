using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappVolumeQuotaRuleDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_netapp_volume_quota_rule.
/// </summary>
public class AzurermNetappVolumeQuotaRuleDataSource : TerraformDataSource
{
    public AzurermNetappVolumeQuotaRuleDataSource(string name) : base("azurerm_netapp_volume_quota_rule", name)
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
    /// The volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeId is required")]
    [TerraformPropertyName("volume_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VolumeId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermNetappVolumeQuotaRuleDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The quota_size_in_kib attribute.
    /// </summary>
    [TerraformPropertyName("quota_size_in_kib")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> QuotaSizeInKib => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "quota_size_in_kib");

    /// <summary>
    /// The quota_target attribute.
    /// </summary>
    [TerraformPropertyName("quota_target")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> QuotaTarget => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "quota_target");

    /// <summary>
    /// The quota_type attribute.
    /// </summary>
    [TerraformPropertyName("quota_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> QuotaType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "quota_type");

}
