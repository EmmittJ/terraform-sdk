using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleSpannerBackupScheduleEncryptionConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The encryption type of backups created by the backup schedule.
    /// Possible values are USE_DATABASE_ENCRYPTION, GOOGLE_DEFAULT_ENCRYPTION, or CUSTOMER_MANAGED_ENCRYPTION.
    /// If you use CUSTOMER_MANAGED_ENCRYPTION, you must specify a kmsKeyName.
    /// If your backup type is incremental-backup, the encryption type must be GOOGLE_DEFAULT_ENCRYPTION. Possible values: [&amp;quot;USE_DATABASE_ENCRYPTION&amp;quot;, &amp;quot;GOOGLE_DEFAULT_ENCRYPTION&amp;quot;, &amp;quot;CUSTOMER_MANAGED_ENCRYPTION&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionType is required")]
    [TerraformProperty("encryption_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EncryptionType { get; set; }

    /// <summary>
    /// The resource name of the Cloud KMS key to use for encryption.
    /// Format: &#39;projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{cryptoKey}&#39;
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyName { get; set; }

    /// <summary>
    /// Fully qualified name of the KMS keys to use to encrypt this database. The keys must exist
    /// in the same locations as the Spanner Database.
    /// </summary>
    [TerraformProperty("kms_key_names")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? KmsKeyNames { get; set; }

}

/// <summary>
/// Block type for full_backup_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleSpannerBackupScheduleFullBackupSpecBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for incremental_backup_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleSpannerBackupScheduleIncrementalBackupSpecBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleSpannerBackupScheduleSpecBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleSpannerBackupScheduleTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_spanner_backup_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleSpannerBackupSchedule : TerraformResource
{
    public GoogleSpannerBackupSchedule(string name) : base("google_spanner_backup_schedule", name)
    {
    }

    /// <summary>
    /// The database to create the backup schedule on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    [TerraformProperty("database")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Database { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance to create the database on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformProperty("instance")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// A unique identifier for the backup schedule, which cannot be changed after
    /// the backup schedule is created. Values are of the form [a-z][-a-z0-9]*[a-z0-9].
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// At what relative time in the future, compared to its creation time, the backup should be deleted, e.g. keep backups for 7 days.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &#39;3.5s&#39;.
    /// You can set this to a value up to 366 days.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionDuration is required")]
    [TerraformProperty("retention_duration")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RetentionDuration { get; set; }

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    [TerraformProperty("encryption_config")]
    public partial TerraformList<TerraformBlock<GoogleSpannerBackupScheduleEncryptionConfigBlock>>? EncryptionConfig { get; set; }

    /// <summary>
    /// Block for full_backup_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FullBackupSpec block(s) allowed")]
    [TerraformProperty("full_backup_spec")]
    public partial TerraformList<TerraformBlock<GoogleSpannerBackupScheduleFullBackupSpecBlock>>? FullBackupSpec { get; set; }

    /// <summary>
    /// Block for incremental_backup_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncrementalBackupSpec block(s) allowed")]
    [TerraformProperty("incremental_backup_spec")]
    public partial TerraformList<TerraformBlock<GoogleSpannerBackupScheduleIncrementalBackupSpecBlock>>? IncrementalBackupSpec { get; set; }

    /// <summary>
    /// Block for spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    [TerraformProperty("spec")]
    public partial TerraformList<TerraformBlock<GoogleSpannerBackupScheduleSpecBlock>>? Spec { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleSpannerBackupScheduleTimeoutsBlock>? Timeouts { get; set; }

}
