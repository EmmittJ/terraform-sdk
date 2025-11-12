using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for antimalware in .
/// Nesting mode: list
/// </summary>
public partial class AzurermAutomanageConfigurationAntimalwareBlock() : TerraformBlock("antimalware")
{
    /// <summary>
    /// The real_time_protection_enabled attribute.
    /// </summary>
    [TerraformProperty("real_time_protection_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RealTimeProtectionEnabled { get; set; }

    /// <summary>
    /// The scheduled_scan_day attribute.
    /// </summary>
    [TerraformProperty("scheduled_scan_day")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ScheduledScanDay { get; set; }

    /// <summary>
    /// The scheduled_scan_enabled attribute.
    /// </summary>
    [TerraformProperty("scheduled_scan_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ScheduledScanEnabled { get; set; }

    /// <summary>
    /// The scheduled_scan_time_in_minutes attribute.
    /// </summary>
    [TerraformProperty("scheduled_scan_time_in_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ScheduledScanTimeInMinutes { get; set; }

    /// <summary>
    /// The scheduled_scan_type attribute.
    /// </summary>
    [TerraformProperty("scheduled_scan_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ScheduledScanType { get; set; }

}

/// <summary>
/// Block type for azure_security_baseline in .
/// Nesting mode: list
/// </summary>
public partial class AzurermAutomanageConfigurationAzureSecurityBaselineBlock() : TerraformBlock("azure_security_baseline")
{
    /// <summary>
    /// The assignment_type attribute.
    /// </summary>
    [TerraformProperty("assignment_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AssignmentType { get; set; }

}

/// <summary>
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public partial class AzurermAutomanageConfigurationBackupBlock() : TerraformBlock("backup")
{
    /// <summary>
    /// The instant_rp_retention_range_in_days attribute.
    /// </summary>
    [TerraformProperty("instant_rp_retention_range_in_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? InstantRpRetentionRangeInDays { get; set; }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    [TerraformProperty("policy_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PolicyName { get; set; }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformProperty("time_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TimeZone { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAutomanageConfigurationTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_automanage_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermAutomanageConfiguration : TerraformResource
{
    public AzurermAutomanageConfiguration(string name) : base("azurerm_automanage_configuration", name)
    {
    }

    /// <summary>
    /// The automation_account_enabled attribute.
    /// </summary>
    [TerraformProperty("automation_account_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutomationAccountEnabled { get; set; }

    /// <summary>
    /// The boot_diagnostics_enabled attribute.
    /// </summary>
    [TerraformProperty("boot_diagnostics_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BootDiagnosticsEnabled { get; set; }

    /// <summary>
    /// The defender_for_cloud_enabled attribute.
    /// </summary>
    [TerraformProperty("defender_for_cloud_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DefenderForCloudEnabled { get; set; }

    /// <summary>
    /// The guest_configuration_enabled attribute.
    /// </summary>
    [TerraformProperty("guest_configuration_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? GuestConfigurationEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The log_analytics_enabled attribute.
    /// </summary>
    [TerraformProperty("log_analytics_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LogAnalyticsEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The status_change_alert_enabled attribute.
    /// </summary>
    [TerraformProperty("status_change_alert_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? StatusChangeAlertEnabled { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for antimalware.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Antimalware block(s) allowed")]
    [TerraformProperty("antimalware")]
    public TerraformList<AzurermAutomanageConfigurationAntimalwareBlock> Antimalware { get; set; } = new();

    /// <summary>
    /// Block for azure_security_baseline.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureSecurityBaseline block(s) allowed")]
    [TerraformProperty("azure_security_baseline")]
    public TerraformList<AzurermAutomanageConfigurationAzureSecurityBaselineBlock> AzureSecurityBaseline { get; set; } = new();

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    [TerraformProperty("backup")]
    public TerraformList<AzurermAutomanageConfigurationBackupBlock> Backup { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermAutomanageConfigurationTimeoutsBlock Timeouts { get; set; } = new();

}
