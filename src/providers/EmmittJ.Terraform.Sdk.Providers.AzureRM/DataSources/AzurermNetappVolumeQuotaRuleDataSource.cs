using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetappVolumeQuotaRuleDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_netapp_volume_quota_rule.
/// </summary>
public partial class AzurermNetappVolumeQuotaRuleDataSource : TerraformDataSource
{
    public AzurermNetappVolumeQuotaRuleDataSource(string name) : base("azurerm_netapp_volume_quota_rule", name)
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
    /// The volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeId is required")]
    [TerraformProperty("volume_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VolumeId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermNetappVolumeQuotaRuleDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The quota_size_in_kib attribute.
    /// </summary>
    [TerraformProperty("quota_size_in_kib")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> QuotaSizeInKib { get; }

    /// <summary>
    /// The quota_target attribute.
    /// </summary>
    [TerraformProperty("quota_target")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> QuotaTarget { get; }

    /// <summary>
    /// The quota_type attribute.
    /// </summary>
    [TerraformProperty("quota_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> QuotaType { get; }

}
