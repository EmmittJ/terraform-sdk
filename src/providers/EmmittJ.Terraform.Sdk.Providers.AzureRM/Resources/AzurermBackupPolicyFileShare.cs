using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBackupPolicyFileShareBackupBlock : TerraformBlockBase
{
    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformProperty("frequency")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Frequency { get; set; }

    /// <summary>
    /// The time attribute.
    /// </summary>
    [TerraformProperty("time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Time { get; set; }

}

/// <summary>
/// Block type for retention_daily in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBackupPolicyFileShareRetentionDailyBlock : TerraformBlockBase
{
    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformProperty("count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Count { get; set; }

}

/// <summary>
/// Block type for retention_monthly in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBackupPolicyFileShareRetentionMonthlyBlock : TerraformBlockBase
{
    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformProperty("count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Count { get; set; }

    /// <summary>
    /// The days attribute.
    /// </summary>
    [TerraformProperty("days")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<double>? Days { get; set; }

    /// <summary>
    /// The include_last_days attribute.
    /// </summary>
    [TerraformProperty("include_last_days")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IncludeLastDays { get; set; }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    [TerraformProperty("weekdays")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Weekdays { get; set; }

    /// <summary>
    /// The weeks attribute.
    /// </summary>
    [TerraformProperty("weeks")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Weeks { get; set; }

}

/// <summary>
/// Block type for retention_weekly in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBackupPolicyFileShareRetentionWeeklyBlock : TerraformBlockBase
{
    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformProperty("count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Count { get; set; }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weekdays is required")]
    [TerraformProperty("weekdays")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Weekdays { get; set; }

}

/// <summary>
/// Block type for retention_yearly in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBackupPolicyFileShareRetentionYearlyBlock : TerraformBlockBase
{
    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformProperty("count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Count { get; set; }

    /// <summary>
    /// The days attribute.
    /// </summary>
    [TerraformProperty("days")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<double>? Days { get; set; }

    /// <summary>
    /// The include_last_days attribute.
    /// </summary>
    [TerraformProperty("include_last_days")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IncludeLastDays { get; set; }

    /// <summary>
    /// The months attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Months is required")]
    [TerraformProperty("months")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Months { get; set; }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    [TerraformProperty("weekdays")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Weekdays { get; set; }

    /// <summary>
    /// The weeks attribute.
    /// </summary>
    [TerraformProperty("weeks")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Weeks { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermBackupPolicyFileShareTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_backup_policy_file_share resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermBackupPolicyFileShare : TerraformResource
{
    public AzurermBackupPolicyFileShare(string name) : base("azurerm_backup_policy_file_share", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    [TerraformProperty("recovery_vault_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RecoveryVaultName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformProperty("timezone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Timezone { get; set; }

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Backup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    [TerraformProperty("backup")]
    public TerraformList<TerraformBlock<AzurermBackupPolicyFileShareBackupBlock>>? Backup { get; set; }

    /// <summary>
    /// Block for retention_daily.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionDaily is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RetentionDaily block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionDaily block(s) allowed")]
    [TerraformProperty("retention_daily")]
    public TerraformList<TerraformBlock<AzurermBackupPolicyFileShareRetentionDailyBlock>>? RetentionDaily { get; set; }

    /// <summary>
    /// Block for retention_monthly.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionMonthly block(s) allowed")]
    [TerraformProperty("retention_monthly")]
    public TerraformList<TerraformBlock<AzurermBackupPolicyFileShareRetentionMonthlyBlock>>? RetentionMonthly { get; set; }

    /// <summary>
    /// Block for retention_weekly.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionWeekly block(s) allowed")]
    [TerraformProperty("retention_weekly")]
    public TerraformList<TerraformBlock<AzurermBackupPolicyFileShareRetentionWeeklyBlock>>? RetentionWeekly { get; set; }

    /// <summary>
    /// Block for retention_yearly.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionYearly block(s) allowed")]
    [TerraformProperty("retention_yearly")]
    public TerraformList<TerraformBlock<AzurermBackupPolicyFileShareRetentionYearlyBlock>>? RetentionYearly { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermBackupPolicyFileShareTimeoutsBlock>? Timeouts { get; set; }

}
