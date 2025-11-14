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
    [TerraformArgument("real_time_protection_enabled")]
    public TerraformValue<bool>? RealTimeProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "real_time_protection_enabled");
        set => SetArgument("real_time_protection_enabled", value);
    }

    /// <summary>
    /// The scheduled_scan_day attribute.
    /// </summary>
    [TerraformArgument("scheduled_scan_day")]
    public TerraformValue<double>? ScheduledScanDay
    {
        get => new TerraformReference<double>(this, "scheduled_scan_day");
        set => SetArgument("scheduled_scan_day", value);
    }

    /// <summary>
    /// The scheduled_scan_enabled attribute.
    /// </summary>
    [TerraformArgument("scheduled_scan_enabled")]
    public TerraformValue<bool>? ScheduledScanEnabled
    {
        get => new TerraformReference<bool>(this, "scheduled_scan_enabled");
        set => SetArgument("scheduled_scan_enabled", value);
    }

    /// <summary>
    /// The scheduled_scan_time_in_minutes attribute.
    /// </summary>
    [TerraformArgument("scheduled_scan_time_in_minutes")]
    public TerraformValue<double>? ScheduledScanTimeInMinutes
    {
        get => new TerraformReference<double>(this, "scheduled_scan_time_in_minutes");
        set => SetArgument("scheduled_scan_time_in_minutes", value);
    }

    /// <summary>
    /// The scheduled_scan_type attribute.
    /// </summary>
    [TerraformArgument("scheduled_scan_type")]
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
    [TerraformArgument("assignment_type")]
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
    [TerraformArgument("instant_rp_retention_range_in_days")]
    public TerraformValue<double>? InstantRpRetentionRangeInDays
    {
        get => new TerraformReference<double>(this, "instant_rp_retention_range_in_days");
        set => SetArgument("instant_rp_retention_range_in_days", value);
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    [TerraformArgument("policy_name")]
    public TerraformValue<string>? PolicyName
    {
        get => new TerraformReference<string>(this, "policy_name");
        set => SetArgument("policy_name", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformArgument("time_zone")]
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
/// Manages a azurerm_automanage_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermAutomanageConfiguration : TerraformResource
{
    public AzurermAutomanageConfiguration(string name) : base("azurerm_automanage_configuration", name)
    {
    }

    /// <summary>
    /// The automation_account_enabled attribute.
    /// </summary>
    [TerraformArgument("automation_account_enabled")]
    public TerraformValue<bool>? AutomationAccountEnabled
    {
        get => new TerraformReference<bool>(this, "automation_account_enabled");
        set => SetArgument("automation_account_enabled", value);
    }

    /// <summary>
    /// The boot_diagnostics_enabled attribute.
    /// </summary>
    [TerraformArgument("boot_diagnostics_enabled")]
    public TerraformValue<bool>? BootDiagnosticsEnabled
    {
        get => new TerraformReference<bool>(this, "boot_diagnostics_enabled");
        set => SetArgument("boot_diagnostics_enabled", value);
    }

    /// <summary>
    /// The defender_for_cloud_enabled attribute.
    /// </summary>
    [TerraformArgument("defender_for_cloud_enabled")]
    public TerraformValue<bool>? DefenderForCloudEnabled
    {
        get => new TerraformReference<bool>(this, "defender_for_cloud_enabled");
        set => SetArgument("defender_for_cloud_enabled", value);
    }

    /// <summary>
    /// The guest_configuration_enabled attribute.
    /// </summary>
    [TerraformArgument("guest_configuration_enabled")]
    public TerraformValue<bool>? GuestConfigurationEnabled
    {
        get => new TerraformReference<bool>(this, "guest_configuration_enabled");
        set => SetArgument("guest_configuration_enabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The log_analytics_enabled attribute.
    /// </summary>
    [TerraformArgument("log_analytics_enabled")]
    public TerraformValue<bool>? LogAnalyticsEnabled
    {
        get => new TerraformReference<bool>(this, "log_analytics_enabled");
        set => SetArgument("log_analytics_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The status_change_alert_enabled attribute.
    /// </summary>
    [TerraformArgument("status_change_alert_enabled")]
    public TerraformValue<bool>? StatusChangeAlertEnabled
    {
        get => new TerraformReference<bool>(this, "status_change_alert_enabled");
        set => SetArgument("status_change_alert_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for antimalware.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Antimalware block(s) allowed")]
    [TerraformArgument("antimalware")]
    public TerraformList<AzurermAutomanageConfigurationAntimalwareBlock> Antimalware { get; set; } = new();

    /// <summary>
    /// Block for azure_security_baseline.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureSecurityBaseline block(s) allowed")]
    [TerraformArgument("azure_security_baseline")]
    public TerraformList<AzurermAutomanageConfigurationAzureSecurityBaselineBlock> AzureSecurityBaseline { get; set; } = new();

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    [TerraformArgument("backup")]
    public TerraformList<AzurermAutomanageConfigurationBackupBlock> Backup { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAutomanageConfigurationTimeoutsBlock Timeouts { get; set; } = new();

}
