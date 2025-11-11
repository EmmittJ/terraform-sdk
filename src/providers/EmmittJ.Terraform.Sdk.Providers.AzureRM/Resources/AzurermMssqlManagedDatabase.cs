using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for long_term_retention_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlManagedDatabaseLongTermRetentionPolicyBlock
{
    /// <summary>
    /// The immutable_backups_enabled attribute.
    /// </summary>
    [TerraformPropertyName("immutable_backups_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ImmutableBackupsEnabled { get; set; }

    /// <summary>
    /// The monthly_retention attribute.
    /// </summary>
    [TerraformPropertyName("monthly_retention")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MonthlyRetention { get; set; } = default!;

    /// <summary>
    /// The week_of_year attribute.
    /// </summary>
    [TerraformPropertyName("week_of_year")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> WeekOfYear { get; set; } = default!;

    /// <summary>
    /// The weekly_retention attribute.
    /// </summary>
    [TerraformPropertyName("weekly_retention")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> WeeklyRetention { get; set; } = default!;

    /// <summary>
    /// The yearly_retention attribute.
    /// </summary>
    [TerraformPropertyName("yearly_retention")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> YearlyRetention { get; set; } = default!;

}

/// <summary>
/// Block type for point_in_time_restore in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlManagedDatabasePointInTimeRestoreBlock
{
    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestorePointInTime is required")]
    [TerraformPropertyName("restore_point_in_time")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RestorePointInTime { get; set; }

    /// <summary>
    /// The source_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDatabaseId is required")]
    [TerraformPropertyName("source_database_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceDatabaseId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlManagedDatabaseTimeoutsBlock
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
/// Manages a azurerm_mssql_managed_database resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMssqlManagedDatabase : TerraformResource
{
    public AzurermMssqlManagedDatabase(string name) : base("azurerm_mssql_managed_database", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    [TerraformPropertyName("managed_instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ManagedInstanceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The short_term_retention_days attribute.
    /// </summary>
    [TerraformPropertyName("short_term_retention_days")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ShortTermRetentionDays { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for long_term_retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LongTermRetentionPolicy block(s) allowed")]
    [TerraformPropertyName("long_term_retention_policy")]
    public TerraformList<TerraformBlock<AzurermMssqlManagedDatabaseLongTermRetentionPolicyBlock>>? LongTermRetentionPolicy { get; set; }

    /// <summary>
    /// Block for point_in_time_restore.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PointInTimeRestore block(s) allowed")]
    [TerraformPropertyName("point_in_time_restore")]
    public TerraformList<TerraformBlock<AzurermMssqlManagedDatabasePointInTimeRestoreBlock>>? PointInTimeRestore { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlManagedDatabaseTimeoutsBlock>? Timeouts { get; set; }

}
