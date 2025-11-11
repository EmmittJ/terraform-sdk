using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBackupPolicyVmBackupBlock : TerraformBlockBase
{
    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformProperty("frequency")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Frequency { get; set; }

    /// <summary>
    /// The hour_duration attribute.
    /// </summary>
    [TerraformProperty("hour_duration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? HourDuration { get; set; }

    /// <summary>
    /// The hour_interval attribute.
    /// </summary>
    [TerraformProperty("hour_interval")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? HourInterval { get; set; }

    /// <summary>
    /// The time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Time is required")]
    [TerraformProperty("time")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Time { get; set; }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    [TerraformProperty("weekdays")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Weekdays { get; set; }

}

/// <summary>
/// Block type for instant_restore_resource_group in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBackupPolicyVmInstantRestoreResourceGroupBlock : TerraformBlockBase
{
    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    [TerraformProperty("prefix")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Prefix { get; set; }

    /// <summary>
    /// The suffix attribute.
    /// </summary>
    [TerraformProperty("suffix")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Suffix { get; set; }

}

/// <summary>
/// Block type for retention_daily in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBackupPolicyVmRetentionDailyBlock : TerraformBlockBase
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
public partial class AzurermBackupPolicyVmRetentionMonthlyBlock : TerraformBlockBase
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
public partial class AzurermBackupPolicyVmRetentionWeeklyBlock : TerraformBlockBase
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
public partial class AzurermBackupPolicyVmRetentionYearlyBlock : TerraformBlockBase
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
/// Block type for tiering_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBackupPolicyVmTieringPolicyBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermBackupPolicyVmTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_backup_policy_vm resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermBackupPolicyVm : TerraformResource
{
    public AzurermBackupPolicyVm(string name) : base("azurerm_backup_policy_vm", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instant_restore_retention_days attribute.
    /// </summary>
    [TerraformProperty("instant_restore_retention_days")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> InstantRestoreRetentionDays { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [TerraformProperty("policy_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PolicyType { get; set; }

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
    public TerraformList<TerraformBlock<AzurermBackupPolicyVmBackupBlock>>? Backup { get; set; }

    /// <summary>
    /// Block for instant_restore_resource_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstantRestoreResourceGroup block(s) allowed")]
    [TerraformProperty("instant_restore_resource_group")]
    public TerraformList<TerraformBlock<AzurermBackupPolicyVmInstantRestoreResourceGroupBlock>>? InstantRestoreResourceGroup { get; set; }

    /// <summary>
    /// Block for retention_daily.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionDaily block(s) allowed")]
    [TerraformProperty("retention_daily")]
    public TerraformList<TerraformBlock<AzurermBackupPolicyVmRetentionDailyBlock>>? RetentionDaily { get; set; }

    /// <summary>
    /// Block for retention_monthly.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionMonthly block(s) allowed")]
    [TerraformProperty("retention_monthly")]
    public TerraformList<TerraformBlock<AzurermBackupPolicyVmRetentionMonthlyBlock>>? RetentionMonthly { get; set; }

    /// <summary>
    /// Block for retention_weekly.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionWeekly block(s) allowed")]
    [TerraformProperty("retention_weekly")]
    public TerraformList<TerraformBlock<AzurermBackupPolicyVmRetentionWeeklyBlock>>? RetentionWeekly { get; set; }

    /// <summary>
    /// Block for retention_yearly.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionYearly block(s) allowed")]
    [TerraformProperty("retention_yearly")]
    public TerraformList<TerraformBlock<AzurermBackupPolicyVmRetentionYearlyBlock>>? RetentionYearly { get; set; }

    /// <summary>
    /// Block for tiering_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TieringPolicy block(s) allowed")]
    [TerraformProperty("tiering_policy")]
    public TerraformList<TerraformBlock<AzurermBackupPolicyVmTieringPolicyBlock>>? TieringPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermBackupPolicyVmTimeoutsBlock>? Timeouts { get; set; }

}
