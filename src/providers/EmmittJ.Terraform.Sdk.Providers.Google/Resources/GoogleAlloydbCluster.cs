using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automated_backup_policy in GoogleAlloydbCluster.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterAutomatedBackupPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "automated_backup_policy";

    /// <summary>
    /// The length of the time window during which a backup can be taken. If a backup does not succeed within this time window, it will be canceled and considered failed.
    /// 
    /// The backup window must be at least 5 minutes long. There is no upper bound on the window. If not set, it will default to 1 hour.
    /// 
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string> BackupWindow
    {
        get => new TerraformReference<string>(this, "backup_window");
        set => SetArgument("backup_window", value);
    }

    /// <summary>
    /// Whether automated backups are enabled.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Labels to apply to backups created using this configuration.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location where the backup will be stored. Currently, the only supported option is to store the backup in the same region as the cluster.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// EncryptionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public TerraformList<GoogleAlloydbClusterAutomatedBackupPolicyBlockEncryptionConfigBlock>? EncryptionConfig
    {
        get => GetArgument<TerraformList<GoogleAlloydbClusterAutomatedBackupPolicyBlockEncryptionConfigBlock>>("encryption_config");
        set => SetArgument("encryption_config", value);
    }

    /// <summary>
    /// QuantityBasedRetention block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QuantityBasedRetention block(s) allowed")]
    public TerraformList<GoogleAlloydbClusterAutomatedBackupPolicyBlockQuantityBasedRetentionBlock>? QuantityBasedRetention
    {
        get => GetArgument<TerraformList<GoogleAlloydbClusterAutomatedBackupPolicyBlockQuantityBasedRetentionBlock>>("quantity_based_retention");
        set => SetArgument("quantity_based_retention", value);
    }

    /// <summary>
    /// TimeBasedRetention block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeBasedRetention block(s) allowed")]
    public TerraformList<GoogleAlloydbClusterAutomatedBackupPolicyBlockTimeBasedRetentionBlock>? TimeBasedRetention
    {
        get => GetArgument<TerraformList<GoogleAlloydbClusterAutomatedBackupPolicyBlockTimeBasedRetentionBlock>>("time_based_retention");
        set => SetArgument("time_based_retention", value);
    }

    /// <summary>
    /// WeeklySchedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WeeklySchedule block(s) allowed")]
    public TerraformList<GoogleAlloydbClusterAutomatedBackupPolicyBlockWeeklyScheduleBlock>? WeeklySchedule
    {
        get => GetArgument<TerraformList<GoogleAlloydbClusterAutomatedBackupPolicyBlockWeeklyScheduleBlock>>("weekly_schedule");
        set => SetArgument("weekly_schedule", value);
    }

}

/// <summary>
/// Block type for encryption_config in GoogleAlloydbClusterAutomatedBackupPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterAutomatedBackupPolicyBlockEncryptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_config";

    /// <summary>
    /// The fully-qualified resource name of the KMS key. Each Cloud KMS key is regionalized and has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME].
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

}

/// <summary>
/// Block type for quantity_based_retention in GoogleAlloydbClusterAutomatedBackupPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterAutomatedBackupPolicyBlockQuantityBasedRetentionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "quantity_based_retention";

    /// <summary>
    /// The number of backups to retain.
    /// </summary>
    public TerraformValue<double>? CountAttribute
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

}

/// <summary>
/// Block type for time_based_retention in GoogleAlloydbClusterAutomatedBackupPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterAutomatedBackupPolicyBlockTimeBasedRetentionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_based_retention";

    /// <summary>
    /// The retention period.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? RetentionPeriod
    {
        get => new TerraformReference<string>(this, "retention_period");
        set => SetArgument("retention_period", value);
    }

}

/// <summary>
/// Block type for weekly_schedule in GoogleAlloydbClusterAutomatedBackupPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterAutomatedBackupPolicyBlockWeeklyScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weekly_schedule";

    /// <summary>
    /// The days of the week to perform a backup. At least one day of the week must be provided. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformList<string>? DaysOfWeek
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "days_of_week").ResolveNodes(ctx));
        set => SetArgument("days_of_week", value);
    }

    /// <summary>
    /// StartTimes block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTimes is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StartTimes block(s) required")]
    public required TerraformList<GoogleAlloydbClusterAutomatedBackupPolicyBlockWeeklyScheduleBlockStartTimesBlock> StartTimes
    {
        get => GetRequiredArgument<TerraformList<GoogleAlloydbClusterAutomatedBackupPolicyBlockWeeklyScheduleBlockStartTimesBlock>>("start_times");
        set => SetArgument("start_times", value);
    }

}

/// <summary>
/// Block type for start_times in GoogleAlloydbClusterAutomatedBackupPolicyBlockWeeklyScheduleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterAutomatedBackupPolicyBlockWeeklyScheduleBlockStartTimesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "start_times";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => new TerraformReference<double>(this, "hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Currently, only the value 0 is supported.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => new TerraformReference<double>(this, "minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Currently, only the value 0 is supported.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => new TerraformReference<double>(this, "nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Currently, only the value 0 is supported.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => new TerraformReference<double>(this, "seconds");
        set => SetArgument("seconds", value);
    }

}


/// <summary>
/// Block type for continuous_backup_config in GoogleAlloydbCluster.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterContinuousBackupConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "continuous_backup_config";

    /// <summary>
    /// Whether continuous backup recovery is enabled. If not set, defaults to true.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The numbers of days that are eligible to restore from using PITR. To support the entire recovery window, backups and logs are retained for one day more than the recovery window.
    /// 
    /// If not set, defaults to 14 days.
    /// </summary>
    public TerraformValue<double> RecoveryWindowDays
    {
        get => new TerraformReference<double>(this, "recovery_window_days");
        set => SetArgument("recovery_window_days", value);
    }

    /// <summary>
    /// EncryptionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public TerraformList<GoogleAlloydbClusterContinuousBackupConfigBlockEncryptionConfigBlock>? EncryptionConfig
    {
        get => GetArgument<TerraformList<GoogleAlloydbClusterContinuousBackupConfigBlockEncryptionConfigBlock>>("encryption_config");
        set => SetArgument("encryption_config", value);
    }

}

/// <summary>
/// Block type for encryption_config in GoogleAlloydbClusterContinuousBackupConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterContinuousBackupConfigBlockEncryptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_config";

    /// <summary>
    /// The fully-qualified resource name of the KMS key. Each Cloud KMS key is regionalized and has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME].
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

}


/// <summary>
/// Block type for encryption_config in GoogleAlloydbCluster.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterEncryptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_config";

    /// <summary>
    /// The fully-qualified resource name of the KMS key. Each Cloud KMS key is regionalized and has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME].
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

}


/// <summary>
/// Block type for initial_user in GoogleAlloydbCluster.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterInitialUserBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "initial_user";

    /// <summary>
    /// The initial password for the user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The database username.
    /// </summary>
    public TerraformValue<string>? User
    {
        get => new TerraformReference<string>(this, "user");
        set => SetArgument("user", value);
    }

}


/// <summary>
/// Block type for maintenance_update_policy in GoogleAlloydbCluster.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterMaintenanceUpdatePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_update_policy";

    /// <summary>
    /// MaintenanceWindows block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAlloydbClusterMaintenanceUpdatePolicyBlockMaintenanceWindowsBlock>? MaintenanceWindows
    {
        get => GetArgument<TerraformList<GoogleAlloydbClusterMaintenanceUpdatePolicyBlockMaintenanceWindowsBlock>>("maintenance_windows");
        set => SetArgument("maintenance_windows", value);
    }

}

/// <summary>
/// Block type for maintenance_windows in GoogleAlloydbClusterMaintenanceUpdatePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterMaintenanceUpdatePolicyBlockMaintenanceWindowsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_windows";

    /// <summary>
    /// Preferred day of the week for maintenance, e.g. MONDAY, TUESDAY, etc. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Day is required")]
    public required TerraformValue<string> Day
    {
        get => new TerraformReference<string>(this, "day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// StartTime block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StartTime block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartTime block(s) allowed")]
    public required TerraformList<GoogleAlloydbClusterMaintenanceUpdatePolicyBlockMaintenanceWindowsBlockStartTimeBlock> StartTime
    {
        get => GetRequiredArgument<TerraformList<GoogleAlloydbClusterMaintenanceUpdatePolicyBlockMaintenanceWindowsBlockStartTimeBlock>>("start_time");
        set => SetArgument("start_time", value);
    }

}

/// <summary>
/// Block type for start_time in GoogleAlloydbClusterMaintenanceUpdatePolicyBlockMaintenanceWindowsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterMaintenanceUpdatePolicyBlockMaintenanceWindowsBlockStartTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "start_time";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hours is required")]
    public required TerraformValue<double> Hours
    {
        get => new TerraformReference<double>(this, "hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Currently, only the value 0 is supported.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => new TerraformReference<double>(this, "minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Currently, only the value 0 is supported.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => new TerraformReference<double>(this, "nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Currently, only the value 0 is supported.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => new TerraformReference<double>(this, "seconds");
        set => SetArgument("seconds", value);
    }

}


/// <summary>
/// Block type for network_config in GoogleAlloydbCluster.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_config";

    /// <summary>
    /// The name of the allocated IP range for the private IP AlloyDB cluster. For example: &amp;quot;google-managed-services-default&amp;quot;.
    /// If set, the instance IPs for this cluster will be created in the allocated range.
    /// </summary>
    public TerraformValue<string>? AllocatedIpRange
    {
        get => new TerraformReference<string>(this, "allocated_ip_range");
        set => SetArgument("allocated_ip_range", value);
    }

    /// <summary>
    /// The resource link for the VPC network in which cluster resources are created and from which they are accessible via Private IP. The network must belong to the same project as the cluster.
    /// It is specified in the form: &amp;quot;projects/{projectNumber}/global/networks/{network_id}&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

}


/// <summary>
/// Block type for psc_config in GoogleAlloydbCluster.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterPscConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "psc_config";

    /// <summary>
    /// Create an instance that allows connections from Private Service Connect endpoints to the instance.
    /// </summary>
    public TerraformValue<bool>? PscEnabled
    {
        get => new TerraformReference<bool>(this, "psc_enabled");
        set => SetArgument("psc_enabled", value);
    }

    /// <summary>
    /// The project number that needs to be allowlisted on the network attachment to enable outbound connectivity, if the network attachment is configured to ACCEPT_MANUAL connections.
    /// In case the network attachment is configured to ACCEPT_AUTOMATIC, this project number does not need to be allowlisted explicitly.
    /// </summary>
    public TerraformValue<double> ServiceOwnedProjectNumber
    {
        get => new TerraformReference<double>(this, "service_owned_project_number");
    }

}


/// <summary>
/// Block type for restore_backup_source in GoogleAlloydbCluster.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterRestoreBackupSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "restore_backup_source";

    /// <summary>
    /// The name of the backup that this cluster is restored from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupName is required")]
    public required TerraformValue<string> BackupName
    {
        get => new TerraformReference<string>(this, "backup_name");
        set => SetArgument("backup_name", value);
    }

}


/// <summary>
/// Block type for restore_continuous_backup_source in GoogleAlloydbCluster.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterRestoreContinuousBackupSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "restore_continuous_backup_source";

    /// <summary>
    /// The name of the source cluster that this cluster is restored from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformValue<string> Cluster
    {
        get => new TerraformReference<string>(this, "cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// The point in time that this cluster is restored to, in RFC 3339 format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PointInTime is required")]
    public required TerraformValue<string> PointInTime
    {
        get => new TerraformReference<string>(this, "point_in_time");
        set => SetArgument("point_in_time", value);
    }

}


/// <summary>
/// Block type for secondary_config in GoogleAlloydbCluster.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterSecondaryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secondary_config";

    /// <summary>
    /// Name of the primary cluster must be in the format
    /// &#39;projects/{project}/locations/{location}/clusters/{cluster_id}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryClusterName is required")]
    public required TerraformValue<string> PrimaryClusterName
    {
        get => new TerraformReference<string>(this, "primary_cluster_name");
        set => SetArgument("primary_cluster_name", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleAlloydbCluster.
/// Nesting mode: single
/// </summary>
public class GoogleAlloydbClusterTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_alloydb_cluster Terraform resource.
/// Manages a google_alloydb_cluster resource.
/// </summary>
public partial class GoogleAlloydbCluster(string name) : TerraformResource("google_alloydb_cluster", name)
{
    /// <summary>
    /// Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels. https://google.aip.dev/128
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "annotations").ResolveNodes(ctx));
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The ID of the alloydb cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The type of cluster. If not set, defaults to PRIMARY. Default value: &amp;quot;PRIMARY&amp;quot; Possible values: [&amp;quot;PRIMARY&amp;quot;, &amp;quot;SECONDARY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ClusterType
    {
        get => new TerraformReference<string>(this, "cluster_type");
        set => SetArgument("cluster_type", value);
    }

    /// <summary>
    /// The database engine major version. This is an optional field and it&#39;s populated at the Cluster creation time.
    /// Note: Changing this field to a higer version results in upgrading the AlloyDB cluster which is an irreversible change.
    /// </summary>
    public TerraformValue<string> DatabaseVersion
    {
        get => new TerraformReference<string>(this, "database_version");
        set => SetArgument("database_version", value);
    }

    /// <summary>
    /// Policy to determine if the cluster should be deleted forcefully.
    /// Deleting a cluster forcefully, deletes the cluster and all its associated instances within the cluster.
    /// Deleting a Secondary cluster with a secondary instance REQUIRES setting deletion_policy = &amp;quot;FORCE&amp;quot; otherwise an error is returned. This is needed as there is no support to delete just the secondary instance, and the only way to delete secondary instance is to delete the associated secondary cluster forcefully which also deletes the secondary instance.
    /// Possible values: DEFAULT, FORCE
    /// </summary>
    public TerraformValue<string>? DeletionPolicy
    {
        get => new TerraformReference<string>(this, "deletion_policy");
        set => SetArgument("deletion_policy", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the cluster.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the cluster will fail.
    /// When the field is set to false, deleting the cluster is allowed.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// User-settable and human-readable display name for the Cluster.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    public TerraformValue<string>? Etag
    {
        get => new TerraformReference<string>(this, "etag");
        set => SetArgument("etag", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// User-defined labels for the alloydb cluster.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location where the alloydb cluster should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Set to true to skip awaiting on the major version upgrade of the cluster.
    /// Possible values: true, false
    /// Default value: &amp;quot;true&amp;quot;
    /// </summary>
    public TerraformValue<bool>? SkipAwaitMajorVersionUpgrade
    {
        get => new TerraformReference<bool>(this, "skip_await_major_version_upgrade");
        set => SetArgument("skip_await_major_version_upgrade", value);
    }

    /// <summary>
    /// The subscrition type of cluster. Possible values: [&amp;quot;TRIAL&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    public TerraformValue<string> SubscriptionType
    {
        get => new TerraformReference<string>(this, "subscription_type");
        set => SetArgument("subscription_type", value);
    }

    /// <summary>
    /// Cluster created from backup.
    /// </summary>
    public TerraformList<TerraformMap<object>> BackupSource
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "backup_source").ResolveNodes(ctx));
    }

    /// <summary>
    /// ContinuousBackupInfo describes the continuous backup properties of a cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> ContinuousBackupInfo
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "continuous_backup_info").ResolveNodes(ctx));
    }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_annotations").ResolveNodes(ctx));
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// EncryptionInfo describes the encryption information of a cluster or a backup.
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionInfo
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "encryption_info").ResolveNodes(ctx));
    }

    /// <summary>
    /// Cluster created via DMS migration.
    /// </summary>
    public TerraformList<TerraformMap<object>> MigrationSource
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "migration_source").ResolveNodes(ctx));
    }

    /// <summary>
    /// The name of the cluster resource.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Output only. Reconciling (https://google.aip.dev/128#reconciliation).
    /// Set to true if the current state of Cluster does not match the user&#39;s intended state, and the service is actively updating the resource to reconcile them.
    /// This can happen due to user-triggered updates or system actions like failover or maintenance.
    /// </summary>
    public TerraformValue<bool> Reconciling
    {
        get => new TerraformReference<bool>(this, "reconciling");
    }

    /// <summary>
    /// Output only. The current serving state of the cluster.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Contains information and all metadata related to TRIAL clusters.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrialMetadata
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "trial_metadata").ResolveNodes(ctx));
    }

    /// <summary>
    /// The system-generated UID of the resource.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// AutomatedBackupPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomatedBackupPolicy block(s) allowed")]
    public TerraformList<GoogleAlloydbClusterAutomatedBackupPolicyBlock>? AutomatedBackupPolicy
    {
        get => GetArgument<TerraformList<GoogleAlloydbClusterAutomatedBackupPolicyBlock>>("automated_backup_policy");
        set => SetArgument("automated_backup_policy", value);
    }

    /// <summary>
    /// ContinuousBackupConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContinuousBackupConfig block(s) allowed")]
    public TerraformList<GoogleAlloydbClusterContinuousBackupConfigBlock>? ContinuousBackupConfig
    {
        get => GetArgument<TerraformList<GoogleAlloydbClusterContinuousBackupConfigBlock>>("continuous_backup_config");
        set => SetArgument("continuous_backup_config", value);
    }

    /// <summary>
    /// EncryptionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public TerraformList<GoogleAlloydbClusterEncryptionConfigBlock>? EncryptionConfig
    {
        get => GetArgument<TerraformList<GoogleAlloydbClusterEncryptionConfigBlock>>("encryption_config");
        set => SetArgument("encryption_config", value);
    }

    /// <summary>
    /// InitialUser block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialUser block(s) allowed")]
    public TerraformList<GoogleAlloydbClusterInitialUserBlock>? InitialUser
    {
        get => GetArgument<TerraformList<GoogleAlloydbClusterInitialUserBlock>>("initial_user");
        set => SetArgument("initial_user", value);
    }

    /// <summary>
    /// MaintenanceUpdatePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceUpdatePolicy block(s) allowed")]
    public TerraformList<GoogleAlloydbClusterMaintenanceUpdatePolicyBlock>? MaintenanceUpdatePolicy
    {
        get => GetArgument<TerraformList<GoogleAlloydbClusterMaintenanceUpdatePolicyBlock>>("maintenance_update_policy");
        set => SetArgument("maintenance_update_policy", value);
    }

    /// <summary>
    /// NetworkConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public TerraformList<GoogleAlloydbClusterNetworkConfigBlock>? NetworkConfig
    {
        get => GetArgument<TerraformList<GoogleAlloydbClusterNetworkConfigBlock>>("network_config");
        set => SetArgument("network_config", value);
    }

    /// <summary>
    /// PscConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscConfig block(s) allowed")]
    public TerraformList<GoogleAlloydbClusterPscConfigBlock>? PscConfig
    {
        get => GetArgument<TerraformList<GoogleAlloydbClusterPscConfigBlock>>("psc_config");
        set => SetArgument("psc_config", value);
    }

    /// <summary>
    /// RestoreBackupSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreBackupSource block(s) allowed")]
    public TerraformList<GoogleAlloydbClusterRestoreBackupSourceBlock>? RestoreBackupSource
    {
        get => GetArgument<TerraformList<GoogleAlloydbClusterRestoreBackupSourceBlock>>("restore_backup_source");
        set => SetArgument("restore_backup_source", value);
    }

    /// <summary>
    /// RestoreContinuousBackupSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreContinuousBackupSource block(s) allowed")]
    public TerraformList<GoogleAlloydbClusterRestoreContinuousBackupSourceBlock>? RestoreContinuousBackupSource
    {
        get => GetArgument<TerraformList<GoogleAlloydbClusterRestoreContinuousBackupSourceBlock>>("restore_continuous_backup_source");
        set => SetArgument("restore_continuous_backup_source", value);
    }

    /// <summary>
    /// SecondaryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecondaryConfig block(s) allowed")]
    public TerraformList<GoogleAlloydbClusterSecondaryConfigBlock>? SecondaryConfig
    {
        get => GetArgument<TerraformList<GoogleAlloydbClusterSecondaryConfigBlock>>("secondary_config");
        set => SetArgument("secondary_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAlloydbClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAlloydbClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
