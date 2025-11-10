using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for antimalware in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomanageConfigurationAntimalwareBlock : TerraformBlock
{
    /// <summary>
    /// The real_time_protection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RealTimeProtectionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("real_time_protection_enabled");
        set => WithProperty("real_time_protection_enabled", value);
    }

    /// <summary>
    /// The scheduled_scan_day attribute.
    /// </summary>
    public TerraformProperty<double>? ScheduledScanDay
    {
        get => GetProperty<TerraformProperty<double>>("scheduled_scan_day");
        set => WithProperty("scheduled_scan_day", value);
    }

    /// <summary>
    /// The scheduled_scan_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ScheduledScanEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("scheduled_scan_enabled");
        set => WithProperty("scheduled_scan_enabled", value);
    }

    /// <summary>
    /// The scheduled_scan_time_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? ScheduledScanTimeInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("scheduled_scan_time_in_minutes");
        set => WithProperty("scheduled_scan_time_in_minutes", value);
    }

    /// <summary>
    /// The scheduled_scan_type attribute.
    /// </summary>
    public TerraformProperty<string>? ScheduledScanType
    {
        get => GetProperty<TerraformProperty<string>>("scheduled_scan_type");
        set => WithProperty("scheduled_scan_type", value);
    }

}

/// <summary>
/// Block type for azure_security_baseline in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomanageConfigurationAzureSecurityBaselineBlock : TerraformBlock
{
    /// <summary>
    /// The assignment_type attribute.
    /// </summary>
    public TerraformProperty<string>? AssignmentType
    {
        get => GetProperty<TerraformProperty<string>>("assignment_type");
        set => WithProperty("assignment_type", value);
    }

}

/// <summary>
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomanageConfigurationBackupBlock : TerraformBlock
{
    /// <summary>
    /// The instant_rp_retention_range_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? InstantRpRetentionRangeInDays
    {
        get => GetProperty<TerraformProperty<double>>("instant_rp_retention_range_in_days");
        set => WithProperty("instant_rp_retention_range_in_days", value);
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyName
    {
        get => GetProperty<TerraformProperty<string>>("policy_name");
        set => WithProperty("policy_name", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformProperty<string>? TimeZone
    {
        get => GetProperty<TerraformProperty<string>>("time_zone");
        set => WithProperty("time_zone", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomanageConfigurationTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_automanage_configuration resource.
/// </summary>
public class AzurermAutomanageConfiguration : TerraformResource
{
    public AzurermAutomanageConfiguration(string name) : base("azurerm_automanage_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The automation_account_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutomationAccountEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("automation_account_enabled");
        set => this.WithProperty("automation_account_enabled", value);
    }

    /// <summary>
    /// The boot_diagnostics_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BootDiagnosticsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("boot_diagnostics_enabled");
        set => this.WithProperty("boot_diagnostics_enabled", value);
    }

    /// <summary>
    /// The defender_for_cloud_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DefenderForCloudEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("defender_for_cloud_enabled");
        set => this.WithProperty("defender_for_cloud_enabled", value);
    }

    /// <summary>
    /// The guest_configuration_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? GuestConfigurationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("guest_configuration_enabled");
        set => this.WithProperty("guest_configuration_enabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The log_analytics_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LogAnalyticsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("log_analytics_enabled");
        set => this.WithProperty("log_analytics_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The status_change_alert_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? StatusChangeAlertEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("status_change_alert_enabled");
        set => this.WithProperty("status_change_alert_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for antimalware.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Antimalware block(s) allowed")]
    public List<AzurermAutomanageConfigurationAntimalwareBlock>? Antimalware
    {
        get => GetProperty<List<AzurermAutomanageConfigurationAntimalwareBlock>>("antimalware");
        set => this.WithProperty("antimalware", value);
    }

    /// <summary>
    /// Block for azure_security_baseline.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureSecurityBaseline block(s) allowed")]
    public List<AzurermAutomanageConfigurationAzureSecurityBaselineBlock>? AzureSecurityBaseline
    {
        get => GetProperty<List<AzurermAutomanageConfigurationAzureSecurityBaselineBlock>>("azure_security_baseline");
        set => this.WithProperty("azure_security_baseline", value);
    }

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    public List<AzurermAutomanageConfigurationBackupBlock>? Backup
    {
        get => GetProperty<List<AzurermAutomanageConfigurationBackupBlock>>("backup");
        set => this.WithProperty("backup", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAutomanageConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAutomanageConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
