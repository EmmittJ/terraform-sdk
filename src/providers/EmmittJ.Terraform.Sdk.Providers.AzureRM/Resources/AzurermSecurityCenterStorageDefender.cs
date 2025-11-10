using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSecurityCenterStorageDefenderTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The malware_scanning_on_upload_cap_gb_per_month attribute.
    /// </summary>
    public TerraformProperty<double>? MalwareScanningOnUploadCapGbPerMonth
    {
        get => GetProperty<TerraformProperty<double>>("malware_scanning_on_upload_cap_gb_per_month");
        set => this.WithProperty("malware_scanning_on_upload_cap_gb_per_month", value);
    }

    /// <summary>
    /// The malware_scanning_on_upload_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MalwareScanningOnUploadEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("malware_scanning_on_upload_enabled");
        set => this.WithProperty("malware_scanning_on_upload_enabled", value);
    }

    /// <summary>
    /// The override_subscription_settings_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? OverrideSubscriptionSettingsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("override_subscription_settings_enabled");
        set => this.WithProperty("override_subscription_settings_enabled", value);
    }

    /// <summary>
    /// The scan_results_event_grid_topic_id attribute.
    /// </summary>
    public TerraformProperty<string>? ScanResultsEventGridTopicId
    {
        get => GetProperty<TerraformProperty<string>>("scan_results_event_grid_topic_id");
        set => this.WithProperty("scan_results_event_grid_topic_id", value);
    }

    /// <summary>
    /// The sensitive_data_discovery_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SensitiveDataDiscoveryEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("sensitive_data_discovery_enabled");
        set => this.WithProperty("sensitive_data_discovery_enabled", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSecurityCenterStorageDefenderTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSecurityCenterStorageDefenderTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
