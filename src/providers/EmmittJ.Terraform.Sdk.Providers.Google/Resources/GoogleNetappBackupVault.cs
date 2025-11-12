using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backup_retention_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetappBackupVaultBackupRetentionPolicyBlock() : TerraformBlock("backup_retention_policy")
{
    /// <summary>
    /// Minimum retention duration in days for backups in the backup vault.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupMinimumEnforcedRetentionDays is required")]
    [TerraformProperty("backup_minimum_enforced_retention_days")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> BackupMinimumEnforcedRetentionDays { get; set; }

    /// <summary>
    /// Indicates if the daily backups are immutable. At least one of daily_backup_immutable, weekly_backup_immutable, monthly_backup_immutable and manual_backup_immutable must be true.
    /// </summary>
    [TerraformProperty("daily_backup_immutable")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DailyBackupImmutable { get; set; }

    /// <summary>
    /// Indicates if the manual backups are immutable. At least one of daily_backup_immutable, weekly_backup_immutable, monthly_backup_immutable and manual_backup_immutable must be true.
    /// </summary>
    [TerraformProperty("manual_backup_immutable")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ManualBackupImmutable { get; set; }

    /// <summary>
    /// Indicates if the monthly backups are immutable. At least one of daily_backup_immutable, weekly_backup_immutable, monthly_backup_immutable and manual_backup_immutable must be true.
    /// </summary>
    [TerraformProperty("monthly_backup_immutable")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MonthlyBackupImmutable { get; set; }

    /// <summary>
    /// Indicates if the weekly backups are immutable. At least one of daily_backup_immutable, weekly_backup_immutable, monthly_backup_immutable and manual_backup_immutable must be true.
    /// </summary>
    [TerraformProperty("weekly_backup_immutable")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WeeklyBackupImmutable { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetappBackupVaultTimeoutsBlock() : TerraformBlock("timeouts")
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
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_netapp_backup_vault resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleNetappBackupVault : TerraformResource
{
    public GoogleNetappBackupVault(string name) : base("google_netapp_backup_vault", name)
    {
    }

    /// <summary>
    /// Region in which backup is stored.
    /// </summary>
    [TerraformProperty("backup_region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BackupRegion { get; set; }

    /// <summary>
    /// Type of the backup vault to be created. Default is IN_REGION. Possible values: [&amp;quot;BACKUP_VAULT_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;IN_REGION&amp;quot;, &amp;quot;CROSS_REGION&amp;quot;]
    /// </summary>
    [TerraformProperty("backup_vault_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> BackupVaultType { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Location (region) of the backup vault.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The resource name of the backup vault. Needs to be unique per location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for backup_retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupRetentionPolicy block(s) allowed")]
    [TerraformProperty("backup_retention_policy")]
    public TerraformList<GoogleNetappBackupVaultBackupRetentionPolicyBlock> BackupRetentionPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleNetappBackupVaultTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Create time of the backup vault. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Name of the Backup vault created in backup region.
    /// </summary>
    [TerraformProperty("destination_backup_vault")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DestinationBackupVault { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Name of the Backup vault created in source region.
    /// </summary>
    [TerraformProperty("source_backup_vault")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceBackupVault { get; }

    /// <summary>
    /// Region in which the backup vault is created.
    /// </summary>
    [TerraformProperty("source_region")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceRegion { get; }

    /// <summary>
    /// The state of the Backup Vault.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
