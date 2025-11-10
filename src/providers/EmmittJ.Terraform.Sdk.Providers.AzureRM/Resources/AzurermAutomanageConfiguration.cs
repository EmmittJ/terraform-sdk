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
        set => SetProperty("real_time_protection_enabled", value);
    }

    /// <summary>
    /// The scheduled_scan_day attribute.
    /// </summary>
    public TerraformProperty<double>? ScheduledScanDay
    {
        set => SetProperty("scheduled_scan_day", value);
    }

    /// <summary>
    /// The scheduled_scan_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ScheduledScanEnabled
    {
        set => SetProperty("scheduled_scan_enabled", value);
    }

    /// <summary>
    /// The scheduled_scan_time_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? ScheduledScanTimeInMinutes
    {
        set => SetProperty("scheduled_scan_time_in_minutes", value);
    }

    /// <summary>
    /// The scheduled_scan_type attribute.
    /// </summary>
    public TerraformProperty<string>? ScheduledScanType
    {
        set => SetProperty("scheduled_scan_type", value);
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
        set => SetProperty("assignment_type", value);
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
        set => SetProperty("instant_rp_retention_range_in_days", value);
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyName
    {
        set => SetProperty("policy_name", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformProperty<string>? TimeZone
    {
        set => SetProperty("time_zone", value);
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
/// Manages a azurerm_automanage_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermAutomanageConfiguration : TerraformResource
{
    public AzurermAutomanageConfiguration(string name) : base("azurerm_automanage_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("automation_account_enabled");
        SetOutput("boot_diagnostics_enabled");
        SetOutput("defender_for_cloud_enabled");
        SetOutput("guest_configuration_enabled");
        SetOutput("id");
        SetOutput("location");
        SetOutput("log_analytics_enabled");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("status_change_alert_enabled");
        SetOutput("tags");
    }

    /// <summary>
    /// The automation_account_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AutomationAccountEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("automation_account_enabled");
        set => SetProperty("automation_account_enabled", value);
    }

    /// <summary>
    /// The boot_diagnostics_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> BootDiagnosticsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("boot_diagnostics_enabled");
        set => SetProperty("boot_diagnostics_enabled", value);
    }

    /// <summary>
    /// The defender_for_cloud_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DefenderForCloudEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("defender_for_cloud_enabled");
        set => SetProperty("defender_for_cloud_enabled", value);
    }

    /// <summary>
    /// The guest_configuration_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> GuestConfigurationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("guest_configuration_enabled");
        set => SetProperty("guest_configuration_enabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The log_analytics_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> LogAnalyticsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("log_analytics_enabled");
        set => SetProperty("log_analytics_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The status_change_alert_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> StatusChangeAlertEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("status_change_alert_enabled");
        set => SetProperty("status_change_alert_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for antimalware.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Antimalware block(s) allowed")]
    public List<AzurermAutomanageConfigurationAntimalwareBlock>? Antimalware
    {
        set => SetProperty("antimalware", value);
    }

    /// <summary>
    /// Block for azure_security_baseline.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureSecurityBaseline block(s) allowed")]
    public List<AzurermAutomanageConfigurationAzureSecurityBaselineBlock>? AzureSecurityBaseline
    {
        set => SetProperty("azure_security_baseline", value);
    }

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    public List<AzurermAutomanageConfigurationBackupBlock>? Backup
    {
        set => SetProperty("backup", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAutomanageConfigurationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
