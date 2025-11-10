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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("id");
        SetOutput("malware_scanning_on_upload_cap_gb_per_month");
        SetOutput("malware_scanning_on_upload_enabled");
        SetOutput("override_subscription_settings_enabled");
        SetOutput("scan_results_event_grid_topic_id");
        SetOutput("sensitive_data_discovery_enabled");
        SetOutput("storage_account_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The malware_scanning_on_upload_cap_gb_per_month attribute.
    /// </summary>
    public TerraformProperty<double> MalwareScanningOnUploadCapGbPerMonth
    {
        get => GetRequiredOutput<TerraformProperty<double>>("malware_scanning_on_upload_cap_gb_per_month");
        set => SetProperty("malware_scanning_on_upload_cap_gb_per_month", value);
    }

    /// <summary>
    /// The malware_scanning_on_upload_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> MalwareScanningOnUploadEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("malware_scanning_on_upload_enabled");
        set => SetProperty("malware_scanning_on_upload_enabled", value);
    }

    /// <summary>
    /// The override_subscription_settings_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> OverrideSubscriptionSettingsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("override_subscription_settings_enabled");
        set => SetProperty("override_subscription_settings_enabled", value);
    }

    /// <summary>
    /// The scan_results_event_grid_topic_id attribute.
    /// </summary>
    public TerraformProperty<string> ScanResultsEventGridTopicId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scan_results_event_grid_topic_id");
        set => SetProperty("scan_results_event_grid_topic_id", value);
    }

    /// <summary>
    /// The sensitive_data_discovery_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SensitiveDataDiscoveryEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("sensitive_data_discovery_enabled");
        set => SetProperty("sensitive_data_discovery_enabled", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_id");
        set => SetProperty("storage_account_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSecurityCenterStorageDefenderTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
