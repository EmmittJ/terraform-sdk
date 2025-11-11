using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSecurityCenterStorageDefenderTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_security_center_storage_defender resource.
/// </summary>
public class AzurermSecurityCenterStorageDefender : TerraformResource
{
    public AzurermSecurityCenterStorageDefender(string name) : base("azurerm_security_center_storage_defender", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The malware_scanning_on_upload_cap_gb_per_month attribute.
    /// </summary>
    [TerraformPropertyName("malware_scanning_on_upload_cap_gb_per_month")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MalwareScanningOnUploadCapGbPerMonth { get; set; }

    /// <summary>
    /// The malware_scanning_on_upload_enabled attribute.
    /// </summary>
    [TerraformPropertyName("malware_scanning_on_upload_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MalwareScanningOnUploadEnabled { get; set; }

    /// <summary>
    /// The override_subscription_settings_enabled attribute.
    /// </summary>
    [TerraformPropertyName("override_subscription_settings_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? OverrideSubscriptionSettingsEnabled { get; set; }

    /// <summary>
    /// The scan_results_event_grid_topic_id attribute.
    /// </summary>
    [TerraformPropertyName("scan_results_event_grid_topic_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ScanResultsEventGridTopicId { get; set; }

    /// <summary>
    /// The sensitive_data_discovery_enabled attribute.
    /// </summary>
    [TerraformPropertyName("sensitive_data_discovery_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SensitiveDataDiscoveryEnabled { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformPropertyName("storage_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageAccountId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSecurityCenterStorageDefenderTimeoutsBlock>? Timeouts { get; set; }

}
