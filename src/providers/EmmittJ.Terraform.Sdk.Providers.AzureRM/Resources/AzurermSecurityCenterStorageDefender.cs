using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSecurityCenterStorageDefenderTimeoutsBlock : ITerraformBlock
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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The malware_scanning_on_upload_cap_gb_per_month attribute.
    /// </summary>
    [TerraformPropertyName("malware_scanning_on_upload_cap_gb_per_month")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MalwareScanningOnUploadCapGbPerMonth { get; set; }

    /// <summary>
    /// The malware_scanning_on_upload_enabled attribute.
    /// </summary>
    [TerraformPropertyName("malware_scanning_on_upload_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MalwareScanningOnUploadEnabled { get; set; }

    /// <summary>
    /// The override_subscription_settings_enabled attribute.
    /// </summary>
    [TerraformPropertyName("override_subscription_settings_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? OverrideSubscriptionSettingsEnabled { get; set; }

    /// <summary>
    /// The scan_results_event_grid_topic_id attribute.
    /// </summary>
    [TerraformPropertyName("scan_results_event_grid_topic_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ScanResultsEventGridTopicId { get; set; }

    /// <summary>
    /// The sensitive_data_discovery_enabled attribute.
    /// </summary>
    [TerraformPropertyName("sensitive_data_discovery_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SensitiveDataDiscoveryEnabled { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformPropertyName("storage_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageAccountId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSecurityCenterStorageDefenderTimeoutsBlock>? Timeouts { get; set; } = new();

}
