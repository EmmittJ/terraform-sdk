using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The malware_scanning_on_upload_cap_gb_per_month attribute.
    /// </summary>
    [TerraformArgument("malware_scanning_on_upload_cap_gb_per_month")]
    public TerraformValue<double>? MalwareScanningOnUploadCapGbPerMonth
    {
        get => new TerraformReference<double>(this, "malware_scanning_on_upload_cap_gb_per_month");
        set => SetArgument("malware_scanning_on_upload_cap_gb_per_month", value);
    }

    /// <summary>
    /// The malware_scanning_on_upload_enabled attribute.
    /// </summary>
    [TerraformArgument("malware_scanning_on_upload_enabled")]
    public TerraformValue<bool>? MalwareScanningOnUploadEnabled
    {
        get => new TerraformReference<bool>(this, "malware_scanning_on_upload_enabled");
        set => SetArgument("malware_scanning_on_upload_enabled", value);
    }

    /// <summary>
    /// The override_subscription_settings_enabled attribute.
    /// </summary>
    [TerraformArgument("override_subscription_settings_enabled")]
    public TerraformValue<bool>? OverrideSubscriptionSettingsEnabled
    {
        get => new TerraformReference<bool>(this, "override_subscription_settings_enabled");
        set => SetArgument("override_subscription_settings_enabled", value);
    }

    /// <summary>
    /// The scan_results_event_grid_topic_id attribute.
    /// </summary>
    [TerraformArgument("scan_results_event_grid_topic_id")]
    public TerraformValue<string>? ScanResultsEventGridTopicId
    {
        get => new TerraformReference<string>(this, "scan_results_event_grid_topic_id");
        set => SetArgument("scan_results_event_grid_topic_id", value);
    }

    /// <summary>
    /// The sensitive_data_discovery_enabled attribute.
    /// </summary>
    [TerraformArgument("sensitive_data_discovery_enabled")]
    public TerraformValue<bool>? SensitiveDataDiscoveryEnabled
    {
        get => new TerraformReference<bool>(this, "sensitive_data_discovery_enabled");
        set => SetArgument("sensitive_data_discovery_enabled", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformArgument("storage_account_id")]
    public required TerraformValue<string> StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSecurityCenterStorageDefenderTimeoutsBlock Timeouts { get; set; } = new();

}
