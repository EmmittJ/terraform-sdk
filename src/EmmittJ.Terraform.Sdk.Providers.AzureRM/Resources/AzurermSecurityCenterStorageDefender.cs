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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The malware_scanning_on_upload_cap_gb_per_month attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MalwareScanningOnUploadCapGbPerMonth
    {
        get => GetProperty<TerraformLiteralProperty<double>>("malware_scanning_on_upload_cap_gb_per_month");
        set => this.WithProperty("malware_scanning_on_upload_cap_gb_per_month", value);
    }

    /// <summary>
    /// The malware_scanning_on_upload_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? MalwareScanningOnUploadEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("malware_scanning_on_upload_enabled");
        set => this.WithProperty("malware_scanning_on_upload_enabled", value);
    }

    /// <summary>
    /// The override_subscription_settings_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? OverrideSubscriptionSettingsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("override_subscription_settings_enabled");
        set => this.WithProperty("override_subscription_settings_enabled", value);
    }

    /// <summary>
    /// The scan_results_event_grid_topic_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ScanResultsEventGridTopicId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scan_results_event_grid_topic_id");
        set => this.WithProperty("scan_results_event_grid_topic_id", value);
    }

    /// <summary>
    /// The sensitive_data_discovery_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SensitiveDataDiscoveryEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sensitive_data_discovery_enabled");
        set => this.WithProperty("sensitive_data_discovery_enabled", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

}
