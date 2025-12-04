using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSecurityCenterStorageDefender.
/// Nesting mode: single
/// </summary>
public class AzurermSecurityCenterStorageDefenderTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_security_center_storage_defender Terraform resource.
/// Manages a azurerm_security_center_storage_defender resource.
/// </summary>
public partial class AzurermSecurityCenterStorageDefender(string name) : TerraformResource("azurerm_security_center_storage_defender", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The malware_scanning_on_upload_cap_gb_per_month attribute.
    /// </summary>
    public TerraformValue<double>? MalwareScanningOnUploadCapGbPerMonth
    {
        get => GetArgument<TerraformValue<double>>("malware_scanning_on_upload_cap_gb_per_month");
        set => SetArgument("malware_scanning_on_upload_cap_gb_per_month", value);
    }

    /// <summary>
    /// The malware_scanning_on_upload_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? MalwareScanningOnUploadEnabled
    {
        get => GetArgument<TerraformValue<bool>>("malware_scanning_on_upload_enabled");
        set => SetArgument("malware_scanning_on_upload_enabled", value);
    }

    /// <summary>
    /// The override_subscription_settings_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? OverrideSubscriptionSettingsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("override_subscription_settings_enabled");
        set => SetArgument("override_subscription_settings_enabled", value);
    }

    /// <summary>
    /// The scan_results_event_grid_topic_id attribute.
    /// </summary>
    public TerraformValue<string>? ScanResultsEventGridTopicId
    {
        get => GetArgument<TerraformValue<string>>("scan_results_event_grid_topic_id");
        set => SetArgument("scan_results_event_grid_topic_id", value);
    }

    /// <summary>
    /// The sensitive_data_discovery_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SensitiveDataDiscoveryEnabled
    {
        get => GetArgument<TerraformValue<bool>>("sensitive_data_discovery_enabled");
        set => SetArgument("sensitive_data_discovery_enabled", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSecurityCenterStorageDefenderTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSecurityCenterStorageDefenderTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
