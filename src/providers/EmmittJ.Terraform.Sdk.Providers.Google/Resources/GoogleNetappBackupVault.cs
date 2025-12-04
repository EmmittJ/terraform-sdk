using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backup_retention_policy in GoogleNetappBackupVault.
/// Nesting mode: list
/// </summary>
public class GoogleNetappBackupVaultBackupRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backup_retention_policy";

    /// <summary>
    /// Minimum retention duration in days for backups in the backup vault.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupMinimumEnforcedRetentionDays is required")]
    public required TerraformValue<double> BackupMinimumEnforcedRetentionDays
    {
        get => GetRequiredArgument<TerraformValue<double>>("backup_minimum_enforced_retention_days");
        set => SetArgument("backup_minimum_enforced_retention_days", value);
    }

    /// <summary>
    /// Indicates if the daily backups are immutable. At least one of daily_backup_immutable, weekly_backup_immutable, monthly_backup_immutable and manual_backup_immutable must be true.
    /// </summary>
    public TerraformValue<bool>? DailyBackupImmutable
    {
        get => GetArgument<TerraformValue<bool>>("daily_backup_immutable");
        set => SetArgument("daily_backup_immutable", value);
    }

    /// <summary>
    /// Indicates if the manual backups are immutable. At least one of daily_backup_immutable, weekly_backup_immutable, monthly_backup_immutable and manual_backup_immutable must be true.
    /// </summary>
    public TerraformValue<bool>? ManualBackupImmutable
    {
        get => GetArgument<TerraformValue<bool>>("manual_backup_immutable");
        set => SetArgument("manual_backup_immutable", value);
    }

    /// <summary>
    /// Indicates if the monthly backups are immutable. At least one of daily_backup_immutable, weekly_backup_immutable, monthly_backup_immutable and manual_backup_immutable must be true.
    /// </summary>
    public TerraformValue<bool>? MonthlyBackupImmutable
    {
        get => GetArgument<TerraformValue<bool>>("monthly_backup_immutable");
        set => SetArgument("monthly_backup_immutable", value);
    }

    /// <summary>
    /// Indicates if the weekly backups are immutable. At least one of daily_backup_immutable, weekly_backup_immutable, monthly_backup_immutable and manual_backup_immutable must be true.
    /// </summary>
    public TerraformValue<bool>? WeeklyBackupImmutable
    {
        get => GetArgument<TerraformValue<bool>>("weekly_backup_immutable");
        set => SetArgument("weekly_backup_immutable", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNetappBackupVault.
/// Nesting mode: single
/// </summary>
public class GoogleNetappBackupVaultTimeoutsBlock : TerraformBlock
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
/// Represents a google_netapp_backup_vault Terraform resource.
/// Manages a google_netapp_backup_vault resource.
/// </summary>
public partial class GoogleNetappBackupVault(string name) : TerraformResource("google_netapp_backup_vault", name)
{
    /// <summary>
    /// Region in which backup is stored.
    /// </summary>
    public TerraformValue<string>? BackupRegion
    {
        get => GetArgument<TerraformValue<string>>("backup_region");
        set => SetArgument("backup_region", value);
    }

    /// <summary>
    /// Type of the backup vault to be created. Default is IN_REGION. Possible values: [&amp;quot;BACKUP_VAULT_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;IN_REGION&amp;quot;, &amp;quot;CROSS_REGION&amp;quot;]
    /// </summary>
    public TerraformValue<string> BackupVaultType
    {
        get => GetArgument<TerraformValue<string>>("backup_vault_type") ?? AsReference("backup_vault_type");
        set => SetArgument("backup_vault_type", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Location (region) of the backup vault.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource name of the backup vault. Needs to be unique per location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Create time of the backup vault. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Name of the Backup vault created in backup region.
    /// </summary>
    public TerraformValue<string> DestinationBackupVault
        => AsReference("destination_backup_vault");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Name of the Backup vault created in source region.
    /// </summary>
    public TerraformValue<string> SourceBackupVault
        => AsReference("source_backup_vault");

    /// <summary>
    /// Region in which the backup vault is created.
    /// </summary>
    public TerraformValue<string> SourceRegion
        => AsReference("source_region");

    /// <summary>
    /// The state of the Backup Vault.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// BackupRetentionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupRetentionPolicy block(s) allowed")]
    public TerraformList<GoogleNetappBackupVaultBackupRetentionPolicyBlock>? BackupRetentionPolicy
    {
        get => GetArgument<TerraformList<GoogleNetappBackupVaultBackupRetentionPolicyBlock>>("backup_retention_policy");
        set => SetArgument("backup_retention_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetappBackupVaultTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetappBackupVaultTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
