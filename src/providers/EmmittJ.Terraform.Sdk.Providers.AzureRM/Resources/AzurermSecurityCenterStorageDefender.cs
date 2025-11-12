using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSecurityCenterStorageDefenderTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_security_center_storage_defender resource.
/// </summary>
public partial class AzurermSecurityCenterStorageDefender : TerraformResource
{
    public AzurermSecurityCenterStorageDefender(string name) : base("azurerm_security_center_storage_defender", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The malware_scanning_on_upload_cap_gb_per_month attribute.
    /// </summary>
    [TerraformProperty("malware_scanning_on_upload_cap_gb_per_month")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MalwareScanningOnUploadCapGbPerMonth { get; set; }

    /// <summary>
    /// The malware_scanning_on_upload_enabled attribute.
    /// </summary>
    [TerraformProperty("malware_scanning_on_upload_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MalwareScanningOnUploadEnabled { get; set; }

    /// <summary>
    /// The override_subscription_settings_enabled attribute.
    /// </summary>
    [TerraformProperty("override_subscription_settings_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? OverrideSubscriptionSettingsEnabled { get; set; }

    /// <summary>
    /// The scan_results_event_grid_topic_id attribute.
    /// </summary>
    [TerraformProperty("scan_results_event_grid_topic_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ScanResultsEventGridTopicId { get; set; }

    /// <summary>
    /// The sensitive_data_discovery_enabled attribute.
    /// </summary>
    [TerraformProperty("sensitive_data_discovery_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SensitiveDataDiscoveryEnabled { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformProperty("storage_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSecurityCenterStorageDefenderTimeoutsBlock Timeouts { get; set; } = new();

}
