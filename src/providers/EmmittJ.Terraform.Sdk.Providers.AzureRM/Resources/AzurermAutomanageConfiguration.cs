using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for antimalware in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomanageConfigurationAntimalwareBlock
{
    /// <summary>
    /// The real_time_protection_enabled attribute.
    /// </summary>
    [TerraformPropertyName("real_time_protection_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RealTimeProtectionEnabled { get; set; }

    /// <summary>
    /// The scheduled_scan_day attribute.
    /// </summary>
    [TerraformPropertyName("scheduled_scan_day")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ScheduledScanDay { get; set; }

    /// <summary>
    /// The scheduled_scan_enabled attribute.
    /// </summary>
    [TerraformPropertyName("scheduled_scan_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ScheduledScanEnabled { get; set; }

    /// <summary>
    /// The scheduled_scan_time_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("scheduled_scan_time_in_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ScheduledScanTimeInMinutes { get; set; }

    /// <summary>
    /// The scheduled_scan_type attribute.
    /// </summary>
    [TerraformPropertyName("scheduled_scan_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ScheduledScanType { get; set; }

}

/// <summary>
/// Block type for azure_security_baseline in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomanageConfigurationAzureSecurityBaselineBlock
{
    /// <summary>
    /// The assignment_type attribute.
    /// </summary>
    [TerraformPropertyName("assignment_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AssignmentType { get; set; }

}

/// <summary>
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomanageConfigurationBackupBlock
{
    /// <summary>
    /// The instant_rp_retention_range_in_days attribute.
    /// </summary>
    [TerraformPropertyName("instant_rp_retention_range_in_days")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? InstantRpRetentionRangeInDays { get; set; }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    [TerraformPropertyName("policy_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PolicyName { get; set; }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformPropertyName("time_zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TimeZone { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomanageConfigurationTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    [TerraformPropertyName("automation_account_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutomationAccountEnabled { get; set; }

    /// <summary>
    /// The boot_diagnostics_enabled attribute.
    /// </summary>
    [TerraformPropertyName("boot_diagnostics_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? BootDiagnosticsEnabled { get; set; }

    /// <summary>
    /// The defender_for_cloud_enabled attribute.
    /// </summary>
    [TerraformPropertyName("defender_for_cloud_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DefenderForCloudEnabled { get; set; }

    /// <summary>
    /// The guest_configuration_enabled attribute.
    /// </summary>
    [TerraformPropertyName("guest_configuration_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? GuestConfigurationEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The log_analytics_enabled attribute.
    /// </summary>
    [TerraformPropertyName("log_analytics_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LogAnalyticsEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The status_change_alert_enabled attribute.
    /// </summary>
    [TerraformPropertyName("status_change_alert_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? StatusChangeAlertEnabled { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for antimalware.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Antimalware block(s) allowed")]
    [TerraformPropertyName("antimalware")]
    public TerraformList<TerraformBlock<AzurermAutomanageConfigurationAntimalwareBlock>>? Antimalware { get; set; }

    /// <summary>
    /// Block for azure_security_baseline.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureSecurityBaseline block(s) allowed")]
    [TerraformPropertyName("azure_security_baseline")]
    public TerraformList<TerraformBlock<AzurermAutomanageConfigurationAzureSecurityBaselineBlock>>? AzureSecurityBaseline { get; set; }

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    [TerraformPropertyName("backup")]
    public TerraformList<TerraformBlock<AzurermAutomanageConfigurationBackupBlock>>? Backup { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAutomanageConfigurationTimeoutsBlock>? Timeouts { get; set; }

}
