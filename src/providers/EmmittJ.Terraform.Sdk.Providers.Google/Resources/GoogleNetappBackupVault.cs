using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backup_retention_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleNetappBackupVaultBackupRetentionPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// Minimum retention duration in days for backups in the backup vault.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupMinimumEnforcedRetentionDays is required")]
    [TerraformPropertyName("backup_minimum_enforced_retention_days")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> BackupMinimumEnforcedRetentionDays { get; set; }

    /// <summary>
    /// Indicates if the daily backups are immutable. At least one of daily_backup_immutable, weekly_backup_immutable, monthly_backup_immutable and manual_backup_immutable must be true.
    /// </summary>
    [TerraformPropertyName("daily_backup_immutable")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DailyBackupImmutable { get; set; }

    /// <summary>
    /// Indicates if the manual backups are immutable. At least one of daily_backup_immutable, weekly_backup_immutable, monthly_backup_immutable and manual_backup_immutable must be true.
    /// </summary>
    [TerraformPropertyName("manual_backup_immutable")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ManualBackupImmutable { get; set; }

    /// <summary>
    /// Indicates if the monthly backups are immutable. At least one of daily_backup_immutable, weekly_backup_immutable, monthly_backup_immutable and manual_backup_immutable must be true.
    /// </summary>
    [TerraformPropertyName("monthly_backup_immutable")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MonthlyBackupImmutable { get; set; }

    /// <summary>
    /// Indicates if the weekly backups are immutable. At least one of daily_backup_immutable, weekly_backup_immutable, monthly_backup_immutable and manual_backup_immutable must be true.
    /// </summary>
    [TerraformPropertyName("weekly_backup_immutable")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WeeklyBackupImmutable { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetappBackupVaultTimeoutsBlock : ITerraformBlock
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
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_netapp_backup_vault resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetappBackupVault : TerraformResource
{
    public GoogleNetappBackupVault(string name) : base("google_netapp_backup_vault", name)
    {
    }

    /// <summary>
    /// Region in which backup is stored.
    /// </summary>
    [TerraformPropertyName("backup_region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BackupRegion { get; set; }

    /// <summary>
    /// Type of the backup vault to be created. Default is IN_REGION. Possible values: [&amp;quot;BACKUP_VAULT_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;IN_REGION&amp;quot;, &amp;quot;CROSS_REGION&amp;quot;]
    /// </summary>
    [TerraformPropertyName("backup_vault_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BackupVaultType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "backup_vault_type");

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Location (region) of the backup vault.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The resource name of the backup vault. Needs to be unique per location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for backup_retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupRetentionPolicy block(s) allowed")]
    [TerraformPropertyName("backup_retention_policy")]
    public TerraformList<TerraformBlock<GoogleNetappBackupVaultBackupRetentionPolicyBlock>>? BackupRetentionPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNetappBackupVaultTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Create time of the backup vault. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Name of the Backup vault created in backup region.
    /// </summary>
    [TerraformPropertyName("destination_backup_vault")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DestinationBackupVault => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "destination_backup_vault");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Name of the Backup vault created in source region.
    /// </summary>
    [TerraformPropertyName("source_backup_vault")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceBackupVault => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_backup_vault");

    /// <summary>
    /// Region in which the backup vault is created.
    /// </summary>
    [TerraformPropertyName("source_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceRegion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_region");

    /// <summary>
    /// The state of the Backup Vault.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
