using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_security_center_storage_defender resource.
/// </summary>
public class AzurermSecurityCenterStorageDefender : TerraformResource
{
    public AzurermSecurityCenterStorageDefender(string name) : base("azurerm_security_center_storage_defender", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The malware_scanning_on_upload_cap_gb_per_month attribute.
    /// </summary>
    public double? MalwareScanningOnUploadCapGbPerMonth
    {
        get => GetProperty<TerraformLiteralProperty<double>>("malware_scanning_on_upload_cap_gb_per_month")?.Value;
        set => this.WithProperty("malware_scanning_on_upload_cap_gb_per_month", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The malware_scanning_on_upload_enabled attribute.
    /// </summary>
    public bool? MalwareScanningOnUploadEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("malware_scanning_on_upload_enabled")?.Value;
        set => this.WithProperty("malware_scanning_on_upload_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The override_subscription_settings_enabled attribute.
    /// </summary>
    public bool? OverrideSubscriptionSettingsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("override_subscription_settings_enabled")?.Value;
        set => this.WithProperty("override_subscription_settings_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The scan_results_event_grid_topic_id attribute.
    /// </summary>
    public string? ScanResultsEventGridTopicId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scan_results_event_grid_topic_id")?.Value;
        set => this.WithProperty("scan_results_event_grid_topic_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sensitive_data_discovery_enabled attribute.
    /// </summary>
    public bool? SensitiveDataDiscoveryEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sensitive_data_discovery_enabled")?.Value;
        set => this.WithProperty("sensitive_data_discovery_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public string? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id")?.Value;
        set => this.WithProperty("storage_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
