using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyFileShareBackupBlock : ITerraformBlock
{
    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformPropertyName("frequency")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Frequency { get; set; }

    /// <summary>
    /// The time attribute.
    /// </summary>
    [TerraformPropertyName("time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Time { get; set; }

}

/// <summary>
/// Block type for retention_daily in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyFileShareRetentionDailyBlock : ITerraformBlock
{
    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformPropertyName("count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Count { get; set; }

}

/// <summary>
/// Block type for retention_monthly in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyFileShareRetentionMonthlyBlock : ITerraformBlock
{
    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformPropertyName("count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Count { get; set; }

    /// <summary>
    /// The days attribute.
    /// </summary>
    [TerraformPropertyName("days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<double>>>? Days { get; set; }

    /// <summary>
    /// The include_last_days attribute.
    /// </summary>
    [TerraformPropertyName("include_last_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeLastDays { get; set; }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    [TerraformPropertyName("weekdays")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Weekdays { get; set; }

    /// <summary>
    /// The weeks attribute.
    /// </summary>
    [TerraformPropertyName("weeks")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Weeks { get; set; }

}

/// <summary>
/// Block type for retention_weekly in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyFileShareRetentionWeeklyBlock : ITerraformBlock
{
    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformPropertyName("count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Count { get; set; }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weekdays is required")]
    [TerraformPropertyName("weekdays")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Weekdays { get; set; }

}

/// <summary>
/// Block type for retention_yearly in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyFileShareRetentionYearlyBlock : ITerraformBlock
{
    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformPropertyName("count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Count { get; set; }

    /// <summary>
    /// The days attribute.
    /// </summary>
    [TerraformPropertyName("days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<double>>>? Days { get; set; }

    /// <summary>
    /// The include_last_days attribute.
    /// </summary>
    [TerraformPropertyName("include_last_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeLastDays { get; set; }

    /// <summary>
    /// The months attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Months is required")]
    [TerraformPropertyName("months")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Months { get; set; }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    [TerraformPropertyName("weekdays")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Weekdays { get; set; }

    /// <summary>
    /// The weeks attribute.
    /// </summary>
    [TerraformPropertyName("weeks")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Weeks { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBackupPolicyFileShareTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_backup_policy_file_share resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermBackupPolicyFileShare : TerraformResource
{
    public AzurermBackupPolicyFileShare(string name) : base("azurerm_backup_policy_file_share", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    [TerraformPropertyName("recovery_vault_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RecoveryVaultName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformPropertyName("timezone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Timezone { get; set; }

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Backup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    [TerraformPropertyName("backup")]
    public TerraformList<TerraformBlock<AzurermBackupPolicyFileShareBackupBlock>>? Backup { get; set; } = new();

    /// <summary>
    /// Block for retention_daily.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionDaily is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RetentionDaily block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionDaily block(s) allowed")]
    [TerraformPropertyName("retention_daily")]
    public TerraformList<TerraformBlock<AzurermBackupPolicyFileShareRetentionDailyBlock>>? RetentionDaily { get; set; } = new();

    /// <summary>
    /// Block for retention_monthly.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionMonthly block(s) allowed")]
    [TerraformPropertyName("retention_monthly")]
    public TerraformList<TerraformBlock<AzurermBackupPolicyFileShareRetentionMonthlyBlock>>? RetentionMonthly { get; set; } = new();

    /// <summary>
    /// Block for retention_weekly.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionWeekly block(s) allowed")]
    [TerraformPropertyName("retention_weekly")]
    public TerraformList<TerraformBlock<AzurermBackupPolicyFileShareRetentionWeeklyBlock>>? RetentionWeekly { get; set; } = new();

    /// <summary>
    /// Block for retention_yearly.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionYearly block(s) allowed")]
    [TerraformPropertyName("retention_yearly")]
    public TerraformList<TerraformBlock<AzurermBackupPolicyFileShareRetentionYearlyBlock>>? RetentionYearly { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermBackupPolicyFileShareTimeoutsBlock>? Timeouts { get; set; } = new();

}
