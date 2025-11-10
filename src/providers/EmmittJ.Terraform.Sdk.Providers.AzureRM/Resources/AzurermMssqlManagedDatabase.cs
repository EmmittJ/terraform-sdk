using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for long_term_retention_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlManagedDatabaseLongTermRetentionPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The immutable_backups_enabled attribute.
    /// </summary>
    [TerraformPropertyName("immutable_backups_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ImmutableBackupsEnabled { get; set; }

    /// <summary>
    /// The monthly_retention attribute.
    /// </summary>
    [TerraformPropertyName("monthly_retention")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MonthlyRetention { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "monthly_retention");

    /// <summary>
    /// The week_of_year attribute.
    /// </summary>
    [TerraformPropertyName("week_of_year")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> WeekOfYear { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "week_of_year");

    /// <summary>
    /// The weekly_retention attribute.
    /// </summary>
    [TerraformPropertyName("weekly_retention")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> WeeklyRetention { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "weekly_retention");

    /// <summary>
    /// The yearly_retention attribute.
    /// </summary>
    [TerraformPropertyName("yearly_retention")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> YearlyRetention { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "yearly_retention");

}

/// <summary>
/// Block type for point_in_time_restore in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlManagedDatabasePointInTimeRestoreBlock : ITerraformBlock
{
    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestorePointInTime is required")]
    [TerraformPropertyName("restore_point_in_time")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RestorePointInTime { get; set; }

    /// <summary>
    /// The source_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDatabaseId is required")]
    [TerraformPropertyName("source_database_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceDatabaseId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlManagedDatabaseTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    [TerraformPropertyName("managed_instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ManagedInstanceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The short_term_retention_days attribute.
    /// </summary>
    [TerraformPropertyName("short_term_retention_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ShortTermRetentionDays { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for long_term_retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LongTermRetentionPolicy block(s) allowed")]
    [TerraformPropertyName("long_term_retention_policy")]
    public TerraformList<TerraformBlock<AzurermMssqlManagedDatabaseLongTermRetentionPolicyBlock>>? LongTermRetentionPolicy { get; set; } = new();

    /// <summary>
    /// Block for point_in_time_restore.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PointInTimeRestore block(s) allowed")]
    [TerraformPropertyName("point_in_time_restore")]
    public TerraformList<TerraformBlock<AzurermMssqlManagedDatabasePointInTimeRestoreBlock>>? PointInTimeRestore { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlManagedDatabaseTimeoutsBlock>? Timeouts { get; set; } = new();

}
