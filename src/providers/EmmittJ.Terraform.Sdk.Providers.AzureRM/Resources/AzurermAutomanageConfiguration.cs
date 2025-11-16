using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for antimalware in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomanageConfigurationAntimalwareBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "antimalware";

    /// <summary>
    /// The real_time_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RealTimeProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "real_time_protection_enabled");
        set => SetArgument("real_time_protection_enabled", value);
    }

    /// <summary>
    /// The scheduled_scan_day attribute.
    /// </summary>
    public TerraformValue<double>? ScheduledScanDay
    {
        get => new TerraformReference<double>(this, "scheduled_scan_day");
        set => SetArgument("scheduled_scan_day", value);
    }

    /// <summary>
    /// The scheduled_scan_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ScheduledScanEnabled
    {
        get => new TerraformReference<bool>(this, "scheduled_scan_enabled");
        set => SetArgument("scheduled_scan_enabled", value);
    }

    /// <summary>
    /// The scheduled_scan_time_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? ScheduledScanTimeInMinutes
    {
        get => new TerraformReference<double>(this, "scheduled_scan_time_in_minutes");
        set => SetArgument("scheduled_scan_time_in_minutes", value);
    }

    /// <summary>
    /// The scheduled_scan_type attribute.
    /// </summary>
    public TerraformValue<string>? ScheduledScanType
    {
        get => new TerraformReference<string>(this, "scheduled_scan_type");
        set => SetArgument("scheduled_scan_type", value);
    }

}

/// <summary>
/// Block type for azure_security_baseline in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomanageConfigurationAzureSecurityBaselineBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_security_baseline";

    /// <summary>
    /// The assignment_type attribute.
    /// </summary>
    public TerraformValue<string>? AssignmentType
    {
        get => new TerraformReference<string>(this, "assignment_type");
        set => SetArgument("assignment_type", value);
    }

}

/// <summary>
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomanageConfigurationBackupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backup";

    /// <summary>
    /// The instant_rp_retention_range_in_days attribute.
    /// </summary>
    public TerraformValue<double>? InstantRpRetentionRangeInDays
    {
        get => new TerraformReference<double>(this, "instant_rp_retention_range_in_days");
        set => SetArgument("instant_rp_retention_range_in_days", value);
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    public TerraformValue<string>? PolicyName
    {
        get => new TerraformReference<string>(this, "policy_name");
        set => SetArgument("policy_name", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformValue<string>? TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
        set => SetArgument("time_zone", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomanageConfigurationTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_automanage_configuration Terraform resource.
/// Manages a azurerm_automanage_configuration resource.
/// </summary>
public partial class AzurermAutomanageConfiguration(string name) : TerraformResource("azurerm_automanage_configuration", name)
{
    /// <summary>
    /// The automation_account_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutomationAccountEnabled
    {
        get => new TerraformReference<bool>(this, "automation_account_enabled");
        set => SetArgument("automation_account_enabled", value);
    }

    /// <summary>
    /// The boot_diagnostics_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? BootDiagnosticsEnabled
    {
        get => new TerraformReference<bool>(this, "boot_diagnostics_enabled");
        set => SetArgument("boot_diagnostics_enabled", value);
    }

    /// <summary>
    /// The defender_for_cloud_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DefenderForCloudEnabled
    {
        get => new TerraformReference<bool>(this, "defender_for_cloud_enabled");
        set => SetArgument("defender_for_cloud_enabled", value);
    }

    /// <summary>
    /// The guest_configuration_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? GuestConfigurationEnabled
    {
        get => new TerraformReference<bool>(this, "guest_configuration_enabled");
        set => SetArgument("guest_configuration_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The log_analytics_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LogAnalyticsEnabled
    {
        get => new TerraformReference<bool>(this, "log_analytics_enabled");
        set => SetArgument("log_analytics_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The status_change_alert_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? StatusChangeAlertEnabled
    {
        get => new TerraformReference<bool>(this, "status_change_alert_enabled");
        set => SetArgument("status_change_alert_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Antimalware block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Antimalware block(s) allowed")]
    public AzurermAutomanageConfigurationAntimalwareBlock? Antimalware
    {
        get => GetArgument<AzurermAutomanageConfigurationAntimalwareBlock>("antimalware");
        set => SetArgument("antimalware", value);
    }

    /// <summary>
    /// AzureSecurityBaseline block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureSecurityBaseline block(s) allowed")]
    public AzurermAutomanageConfigurationAzureSecurityBaselineBlock? AzureSecurityBaseline
    {
        get => GetArgument<AzurermAutomanageConfigurationAzureSecurityBaselineBlock>("azure_security_baseline");
        set => SetArgument("azure_security_baseline", value);
    }

    /// <summary>
    /// Backup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    public AzurermAutomanageConfigurationBackupBlock? Backup
    {
        get => GetArgument<AzurermAutomanageConfigurationBackupBlock>("backup");
        set => SetArgument("backup", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAutomanageConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAutomanageConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
