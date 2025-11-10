using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_config in .
/// Nesting mode: list
/// </summary>
public class GoogleSpannerBackupScheduleEncryptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// The encryption type of backups created by the backup schedule.
    /// Possible values are USE_DATABASE_ENCRYPTION, GOOGLE_DEFAULT_ENCRYPTION, or CUSTOMER_MANAGED_ENCRYPTION.
    /// If you use CUSTOMER_MANAGED_ENCRYPTION, you must specify a kmsKeyName.
    /// If your backup type is incremental-backup, the encryption type must be GOOGLE_DEFAULT_ENCRYPTION. Possible values: [&amp;quot;USE_DATABASE_ENCRYPTION&amp;quot;, &amp;quot;GOOGLE_DEFAULT_ENCRYPTION&amp;quot;, &amp;quot;CUSTOMER_MANAGED_ENCRYPTION&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionType is required")]
    public required TerraformProperty<string> EncryptionType
    {
        get => GetProperty<TerraformProperty<string>>("encryption_type");
        set => WithProperty("encryption_type", value);
    }

    /// <summary>
    /// The resource name of the Cloud KMS key to use for encryption.
    /// Format: &#39;projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{cryptoKey}&#39;
    /// </summary>
    public TerraformProperty<string>? KmsKeyName
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_name");
        set => WithProperty("kms_key_name", value);
    }

    /// <summary>
    /// Fully qualified name of the KMS keys to use to encrypt this database. The keys must exist
    /// in the same locations as the Spanner Database.
    /// </summary>
    public List<TerraformProperty<string>>? KmsKeyNames
    {
        get => GetProperty<List<TerraformProperty<string>>>("kms_key_names");
        set => WithProperty("kms_key_names", value);
    }

}

/// <summary>
/// Block type for full_backup_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleSpannerBackupScheduleFullBackupSpecBlock : TerraformBlock
{
}

/// <summary>
/// Block type for incremental_backup_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleSpannerBackupScheduleIncrementalBackupSpecBlock : TerraformBlock
{
}

/// <summary>
/// Block type for spec in .
/// Nesting mode: list
/// </summary>
public class GoogleSpannerBackupScheduleSpecBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSpannerBackupScheduleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_spanner_backup_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleSpannerBackupSchedule : TerraformResource
{
    public GoogleSpannerBackupSchedule(string name) : base("google_spanner_backup_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The database to create the backup schedule on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformProperty<string> Database
    {
        get => GetProperty<TerraformProperty<string>>("database");
        set => this.WithProperty("database", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instance to create the database on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        get => GetProperty<TerraformProperty<string>>("instance");
        set => this.WithProperty("instance", value);
    }

    /// <summary>
    /// A unique identifier for the backup schedule, which cannot be changed after
    /// the backup schedule is created. Values are of the form [a-z][-a-z0-9]*[a-z0-9].
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// At what relative time in the future, compared to its creation time, the backup should be deleted, e.g. keep backups for 7 days.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &#39;3.5s&#39;.
    /// You can set this to a value up to 366 days.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionDuration is required")]
    public required TerraformProperty<string> RetentionDuration
    {
        get => GetProperty<TerraformProperty<string>>("retention_duration");
        set => this.WithProperty("retention_duration", value);
    }

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public List<GoogleSpannerBackupScheduleEncryptionConfigBlock>? EncryptionConfig
    {
        get => GetProperty<List<GoogleSpannerBackupScheduleEncryptionConfigBlock>>("encryption_config");
        set => this.WithProperty("encryption_config", value);
    }

    /// <summary>
    /// Block for full_backup_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FullBackupSpec block(s) allowed")]
    public List<GoogleSpannerBackupScheduleFullBackupSpecBlock>? FullBackupSpec
    {
        get => GetProperty<List<GoogleSpannerBackupScheduleFullBackupSpecBlock>>("full_backup_spec");
        set => this.WithProperty("full_backup_spec", value);
    }

    /// <summary>
    /// Block for incremental_backup_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncrementalBackupSpec block(s) allowed")]
    public List<GoogleSpannerBackupScheduleIncrementalBackupSpecBlock>? IncrementalBackupSpec
    {
        get => GetProperty<List<GoogleSpannerBackupScheduleIncrementalBackupSpecBlock>>("incremental_backup_spec");
        set => this.WithProperty("incremental_backup_spec", value);
    }

    /// <summary>
    /// Block for spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    public List<GoogleSpannerBackupScheduleSpecBlock>? Spec
    {
        get => GetProperty<List<GoogleSpannerBackupScheduleSpecBlock>>("spec");
        set => this.WithProperty("spec", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSpannerBackupScheduleTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleSpannerBackupScheduleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
