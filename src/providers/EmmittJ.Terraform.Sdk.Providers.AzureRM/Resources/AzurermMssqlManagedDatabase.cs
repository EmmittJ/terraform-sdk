using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for long_term_retention_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlManagedDatabaseLongTermRetentionPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The immutable_backups_enabled attribute.
    /// </summary>
    [TerraformProperty("immutable_backups_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ImmutableBackupsEnabled { get; set; }

    /// <summary>
    /// The monthly_retention attribute.
    /// </summary>
    [TerraformProperty("monthly_retention")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MonthlyRetention { get; set; }

    /// <summary>
    /// The week_of_year attribute.
    /// </summary>
    [TerraformProperty("week_of_year")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> WeekOfYear { get; set; }

    /// <summary>
    /// The weekly_retention attribute.
    /// </summary>
    [TerraformProperty("weekly_retention")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> WeeklyRetention { get; set; }

    /// <summary>
    /// The yearly_retention attribute.
    /// </summary>
    [TerraformProperty("yearly_retention")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> YearlyRetention { get; set; }

}

/// <summary>
/// Block type for point_in_time_restore in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlManagedDatabasePointInTimeRestoreBlock : TerraformBlockBase
{
    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestorePointInTime is required")]
    [TerraformProperty("restore_point_in_time")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RestorePointInTime { get; set; }

    /// <summary>
    /// The source_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDatabaseId is required")]
    [TerraformProperty("source_database_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceDatabaseId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlManagedDatabaseTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_mssql_managed_database resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMssqlManagedDatabase : TerraformResource
{
    public AzurermMssqlManagedDatabase(string name) : base("azurerm_mssql_managed_database", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    [TerraformProperty("managed_instance_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ManagedInstanceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The short_term_retention_days attribute.
    /// </summary>
    [TerraformProperty("short_term_retention_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ShortTermRetentionDays { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for long_term_retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LongTermRetentionPolicy block(s) allowed")]
    [TerraformProperty("long_term_retention_policy")]
    public partial TerraformList<TerraformBlock<AzurermMssqlManagedDatabaseLongTermRetentionPolicyBlock>>? LongTermRetentionPolicy { get; set; }

    /// <summary>
    /// Block for point_in_time_restore.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PointInTimeRestore block(s) allowed")]
    [TerraformProperty("point_in_time_restore")]
    public partial TerraformList<TerraformBlock<AzurermMssqlManagedDatabasePointInTimeRestoreBlock>>? PointInTimeRestore { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermMssqlManagedDatabaseTimeoutsBlock>? Timeouts { get; set; }

}
