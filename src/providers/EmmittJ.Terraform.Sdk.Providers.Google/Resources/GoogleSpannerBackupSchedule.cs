using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_config in GoogleSpannerBackupSchedule.
/// Nesting mode: list
/// </summary>
public class GoogleSpannerBackupScheduleEncryptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_config";

    /// <summary>
    /// The encryption type of backups created by the backup schedule.
    /// Possible values are USE_DATABASE_ENCRYPTION, GOOGLE_DEFAULT_ENCRYPTION, or CUSTOMER_MANAGED_ENCRYPTION.
    /// If you use CUSTOMER_MANAGED_ENCRYPTION, you must specify a kmsKeyName.
    /// If your backup type is incremental-backup, the encryption type must be GOOGLE_DEFAULT_ENCRYPTION. Possible values: [&amp;quot;USE_DATABASE_ENCRYPTION&amp;quot;, &amp;quot;GOOGLE_DEFAULT_ENCRYPTION&amp;quot;, &amp;quot;CUSTOMER_MANAGED_ENCRYPTION&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionType is required")]
    public required TerraformValue<string> EncryptionType
    {
        get => GetRequiredArgument<TerraformValue<string>>("encryption_type");
        set => SetArgument("encryption_type", value);
    }

    /// <summary>
    /// The resource name of the Cloud KMS key to use for encryption.
    /// Format: &#39;projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{cryptoKey}&#39;
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => GetArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// Fully qualified name of the KMS keys to use to encrypt this database. The keys must exist
    /// in the same locations as the Spanner Database.
    /// </summary>
    public TerraformList<string>? KmsKeyNames
    {
        get => GetArgument<TerraformList<string>>("kms_key_names");
        set => SetArgument("kms_key_names", value);
    }

}


/// <summary>
/// Block type for full_backup_spec in GoogleSpannerBackupSchedule.
/// Nesting mode: list
/// </summary>
public class GoogleSpannerBackupScheduleFullBackupSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "full_backup_spec";

}


/// <summary>
/// Block type for incremental_backup_spec in GoogleSpannerBackupSchedule.
/// Nesting mode: list
/// </summary>
public class GoogleSpannerBackupScheduleIncrementalBackupSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "incremental_backup_spec";

}


/// <summary>
/// Block type for spec in GoogleSpannerBackupSchedule.
/// Nesting mode: list
/// </summary>
public class GoogleSpannerBackupScheduleSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spec";

    /// <summary>
    /// CronSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CronSpec block(s) allowed")]
    public TerraformList<GoogleSpannerBackupScheduleSpecBlockCronSpecBlock>? CronSpec
    {
        get => GetArgument<TerraformList<GoogleSpannerBackupScheduleSpecBlockCronSpecBlock>>("cron_spec");
        set => SetArgument("cron_spec", value);
    }

}

/// <summary>
/// Block type for cron_spec in GoogleSpannerBackupScheduleSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSpannerBackupScheduleSpecBlockCronSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cron_spec";

    /// <summary>
    /// Textual representation of the crontab. User can customize the
    /// backup frequency and the backup version time using the cron
    /// expression. The version time must be in UTC timzeone.
    /// The backup will contain an externally consistent copy of the
    /// database at the version time. Allowed frequencies are 12 hour, 1 day,
    /// 1 week and 1 month. Examples of valid cron specifications:
    ///   0 2/12 * * * : every 12 hours at (2, 14) hours past midnight in UTC.
    ///   0 2,14 * * * : every 12 hours at (2,14) hours past midnight in UTC.
    ///   0 2 * * *    : once a day at 2 past midnight in UTC.
    ///   0 2 * * 0    : once a week every Sunday at 2 past midnight in UTC.
    ///   0 2 8 * *    : once a month on 8th day at 2 past midnight in UTC.
    /// </summary>
    public TerraformValue<string>? Text
    {
        get => GetArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleSpannerBackupSchedule.
/// Nesting mode: single
/// </summary>
public class GoogleSpannerBackupScheduleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_spanner_backup_schedule Terraform resource.
/// Manages a google_spanner_backup_schedule resource.
/// </summary>
public partial class GoogleSpannerBackupSchedule(string name) : TerraformResource("google_spanner_backup_schedule", name)
{
    /// <summary>
    /// The database to create the backup schedule on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetRequiredArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance to create the database on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformValue<string> Instance
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// A unique identifier for the backup schedule, which cannot be changed after
    /// the backup schedule is created. Values are of the form [a-z][-a-z0-9]*[a-z0-9].
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// At what relative time in the future, compared to its creation time, the backup should be deleted, e.g. keep backups for 7 days.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &#39;3.5s&#39;.
    /// You can set this to a value up to 366 days.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionDuration is required")]
    public required TerraformValue<string> RetentionDuration
    {
        get => GetRequiredArgument<TerraformValue<string>>("retention_duration");
        set => SetArgument("retention_duration", value);
    }

    /// <summary>
    /// EncryptionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public TerraformList<GoogleSpannerBackupScheduleEncryptionConfigBlock>? EncryptionConfig
    {
        get => GetArgument<TerraformList<GoogleSpannerBackupScheduleEncryptionConfigBlock>>("encryption_config");
        set => SetArgument("encryption_config", value);
    }

    /// <summary>
    /// FullBackupSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FullBackupSpec block(s) allowed")]
    public TerraformList<GoogleSpannerBackupScheduleFullBackupSpecBlock>? FullBackupSpec
    {
        get => GetArgument<TerraformList<GoogleSpannerBackupScheduleFullBackupSpecBlock>>("full_backup_spec");
        set => SetArgument("full_backup_spec", value);
    }

    /// <summary>
    /// IncrementalBackupSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncrementalBackupSpec block(s) allowed")]
    public TerraformList<GoogleSpannerBackupScheduleIncrementalBackupSpecBlock>? IncrementalBackupSpec
    {
        get => GetArgument<TerraformList<GoogleSpannerBackupScheduleIncrementalBackupSpecBlock>>("incremental_backup_spec");
        set => SetArgument("incremental_backup_spec", value);
    }

    /// <summary>
    /// Spec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    public TerraformList<GoogleSpannerBackupScheduleSpecBlock>? Spec
    {
        get => GetArgument<TerraformList<GoogleSpannerBackupScheduleSpecBlock>>("spec");
        set => SetArgument("spec", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSpannerBackupScheduleTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSpannerBackupScheduleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
