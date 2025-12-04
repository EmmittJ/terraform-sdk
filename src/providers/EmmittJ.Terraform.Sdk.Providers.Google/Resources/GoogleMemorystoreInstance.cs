using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automated_backup_config in GoogleMemorystoreInstance.
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceAutomatedBackupConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "automated_backup_config";

    /// <summary>
    /// How long to keep automated backups before the backups are deleted.
    /// The value should be between 1 day and 365 days. If not specified, the default value is 35 days.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;. The default_value is &amp;quot;3024000s&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Retention is required")]
    public required TerraformValue<string> Retention
    {
        get => GetArgument<TerraformValue<string>>("retention");
        set => SetArgument("retention", value);
    }

    /// <summary>
    /// FixedFrequencySchedule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FixedFrequencySchedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FixedFrequencySchedule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedFrequencySchedule block(s) allowed")]
    public required TerraformList<GoogleMemorystoreInstanceAutomatedBackupConfigBlockFixedFrequencyScheduleBlock> FixedFrequencySchedule
    {
        get => GetRequiredArgument<TerraformList<GoogleMemorystoreInstanceAutomatedBackupConfigBlockFixedFrequencyScheduleBlock>>("fixed_frequency_schedule");
        set => SetArgument("fixed_frequency_schedule", value);
    }

}

/// <summary>
/// Block type for fixed_frequency_schedule in GoogleMemorystoreInstanceAutomatedBackupConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceAutomatedBackupConfigBlockFixedFrequencyScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fixed_frequency_schedule";

    /// <summary>
    /// StartTime block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StartTime block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartTime block(s) allowed")]
    public required TerraformList<GoogleMemorystoreInstanceAutomatedBackupConfigBlockFixedFrequencyScheduleBlockStartTimeBlock> StartTime
    {
        get => GetRequiredArgument<TerraformList<GoogleMemorystoreInstanceAutomatedBackupConfigBlockFixedFrequencyScheduleBlockStartTimeBlock>>("start_time");
        set => SetArgument("start_time", value);
    }

}

/// <summary>
/// Block type for start_time in GoogleMemorystoreInstanceAutomatedBackupConfigBlockFixedFrequencyScheduleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceAutomatedBackupConfigBlockFixedFrequencyScheduleBlockStartTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "start_time";

    /// <summary>
    /// Hours of a day in 24 hour format. Must be greater than or equal to 0 and typically must be less than or equal to 23.
    /// An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hours is required")]
    public required TerraformValue<double> Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

}


/// <summary>
/// Block type for cross_instance_replication_config in GoogleMemorystoreInstance.
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceCrossInstanceReplicationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cross_instance_replication_config";

    /// <summary>
    /// The instance role supports the following values:
    /// 1. &#39;INSTANCE_ROLE_UNSPECIFIED&#39;: This is an independent instance that has never participated in cross instance replication. It allows both reads and writes.
    /// 2. &#39;NONE&#39;: This is an independent instance that previously participated in cross instance replication(either as a &#39;PRIMARY&#39; or &#39;SECONDARY&#39; cluster). It allows both reads and writes.
    /// 3. &#39;PRIMARY&#39;: This instance serves as the replication source for secondary instance that are replicating from it. Any data written to it is automatically replicated to its secondary clusters. It allows both reads and writes.
    /// 4. &#39;SECONDARY&#39;: This instance replicates data from the primary instance. It allows only reads. Possible values: [&amp;quot;INSTANCE_ROLE_UNSPECIFIED&amp;quot;, &amp;quot;NONE&amp;quot;, &amp;quot;PRIMARY&amp;quot;, &amp;quot;SECONDARY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? InstanceRole
    {
        get => GetArgument<TerraformValue<string>>("instance_role");
        set => SetArgument("instance_role", value);
    }

    /// <summary>
    /// An output only view of all the member instance participating in cross instance replication. This field is populated for all the member clusters irrespective of their cluster role.
    /// </summary>
    public TerraformList<TerraformMap<object>> Membership
        => AsReference("membership");

    /// <summary>
    /// The last time cross instance replication config was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// PrimaryInstance block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrimaryInstance block(s) allowed")]
    public TerraformList<GoogleMemorystoreInstanceCrossInstanceReplicationConfigBlockPrimaryInstanceBlock>? PrimaryInstance
    {
        get => GetArgument<TerraformList<GoogleMemorystoreInstanceCrossInstanceReplicationConfigBlockPrimaryInstanceBlock>>("primary_instance");
        set => SetArgument("primary_instance", value);
    }

    /// <summary>
    /// SecondaryInstances block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleMemorystoreInstanceCrossInstanceReplicationConfigBlockSecondaryInstancesBlock>? SecondaryInstances
    {
        get => GetArgument<TerraformList<GoogleMemorystoreInstanceCrossInstanceReplicationConfigBlockSecondaryInstancesBlock>>("secondary_instances");
        set => SetArgument("secondary_instances", value);
    }

}

/// <summary>
/// Block type for primary_instance in GoogleMemorystoreInstanceCrossInstanceReplicationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceCrossInstanceReplicationConfigBlockPrimaryInstanceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "primary_instance";

    /// <summary>
    /// The full resource path of the primary instance in the format: projects/{project}/locations/{region}/instances/{instance-id}
    /// </summary>
    public TerraformValue<string>? Instance
    {
        get => GetArgument<TerraformValue<string>>("instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// The unique id of the primary instance.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

}

/// <summary>
/// Block type for secondary_instances in GoogleMemorystoreInstanceCrossInstanceReplicationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceCrossInstanceReplicationConfigBlockSecondaryInstancesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secondary_instances";

    /// <summary>
    /// The full resource path of the Nth instance in the format: projects/{project}/locations/{region}/instance/{instance-id}
    /// </summary>
    public TerraformValue<string>? Instance
    {
        get => GetArgument<TerraformValue<string>>("instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// The unique id of the Nth instance.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

}


/// <summary>
/// Block type for desired_auto_created_endpoints in GoogleMemorystoreInstance.
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceDesiredAutoCreatedEndpointsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "desired_auto_created_endpoints";

    /// <summary>
    /// Required. The consumer network where the IP address resides, in the form of
    /// projects/{project_id}/global/networks/{network_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// Required. The consumer project_id where the forwarding rule is created from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

}


/// <summary>
/// Block type for desired_psc_auto_connections in GoogleMemorystoreInstance.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class GoogleMemorystoreInstanceDesiredPscAutoConnectionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "desired_psc_auto_connections";

    /// <summary>
    /// Required. The consumer network where the IP address resides, in the form of
    /// projects/{project_id}/global/networks/{network_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// Required. The consumer project_id where the forwarding rule is created from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

}


/// <summary>
/// Block type for gcs_source in GoogleMemorystoreInstance.
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceGcsSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs_source";

    /// <summary>
    /// URIs of the GCS objects to import.
    /// Example: gs://bucket1/object1, gs://bucket2/folder2/object2
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uris is required")]
    public required TerraformSet<string> Uris
    {
        get => GetArgument<TerraformSet<string>>("uris");
        set => SetArgument("uris", value);
    }

}


/// <summary>
/// Block type for maintenance_policy in GoogleMemorystoreInstance.
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceMaintenancePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_policy";

    /// <summary>
    /// The time when the policy was created.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The time when the policy was last updated.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// WeeklyMaintenanceWindow block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleMemorystoreInstanceMaintenancePolicyBlockWeeklyMaintenanceWindowBlock>? WeeklyMaintenanceWindow
    {
        get => GetArgument<TerraformList<GoogleMemorystoreInstanceMaintenancePolicyBlockWeeklyMaintenanceWindowBlock>>("weekly_maintenance_window");
        set => SetArgument("weekly_maintenance_window", value);
    }

}

/// <summary>
/// Block type for weekly_maintenance_window in GoogleMemorystoreInstanceMaintenancePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceMaintenancePolicyBlockWeeklyMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weekly_maintenance_window";

    /// <summary>
    /// The day of week that maintenance updates occur.
    /// 
    /// - DAY_OF_WEEK_UNSPECIFIED: The day of the week is unspecified.
    /// - MONDAY: Monday
    /// - TUESDAY: Tuesday
    /// - WEDNESDAY: Wednesday
    /// - THURSDAY: Thursday
    /// - FRIDAY: Friday
    /// - SATURDAY: Saturday
    /// - SUNDAY: Sunday Possible values: [&amp;quot;DAY_OF_WEEK_UNSPECIFIED&amp;quot;, &amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Day is required")]
    public required TerraformValue<string> Day
    {
        get => GetArgument<TerraformValue<string>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Duration of the maintenance window.
    /// The current window is fixed at 1 hour.
    /// A duration in seconds with up to nine fractional digits,
    /// terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string> Duration
        => AsReference("duration");

    /// <summary>
    /// StartTime block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StartTime block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartTime block(s) allowed")]
    public required TerraformList<GoogleMemorystoreInstanceMaintenancePolicyBlockWeeklyMaintenanceWindowBlockStartTimeBlock> StartTime
    {
        get => GetRequiredArgument<TerraformList<GoogleMemorystoreInstanceMaintenancePolicyBlockWeeklyMaintenanceWindowBlockStartTimeBlock>>("start_time");
        set => SetArgument("start_time", value);
    }

}

/// <summary>
/// Block type for start_time in GoogleMemorystoreInstanceMaintenancePolicyBlockWeeklyMaintenanceWindowBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceMaintenancePolicyBlockWeeklyMaintenanceWindowBlockStartTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "start_time";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23.
    /// An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59.
    /// An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}


/// <summary>
/// Block type for managed_backup_source in GoogleMemorystoreInstance.
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceManagedBackupSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_backup_source";

    /// <summary>
    /// Example: &#39;projects/{project}/locations/{location}/backupCollections/{collection}/backups/{backup}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backup is required")]
    public required TerraformValue<string> Backup
    {
        get => GetArgument<TerraformValue<string>>("backup");
        set => SetArgument("backup", value);
    }

}


/// <summary>
/// Block type for persistence_config in GoogleMemorystoreInstance.
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstancePersistenceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "persistence_config";

    /// <summary>
    /// Optional. Current persistence mode. 
    ///  Possible values:
    /// DISABLED
    /// RDB
    /// AOF Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;RDB&amp;quot;, &amp;quot;AOF&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// AofConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AofConfig block(s) allowed")]
    public TerraformList<GoogleMemorystoreInstancePersistenceConfigBlockAofConfigBlock>? AofConfig
    {
        get => GetArgument<TerraformList<GoogleMemorystoreInstancePersistenceConfigBlockAofConfigBlock>>("aof_config");
        set => SetArgument("aof_config", value);
    }

    /// <summary>
    /// RdbConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RdbConfig block(s) allowed")]
    public TerraformList<GoogleMemorystoreInstancePersistenceConfigBlockRdbConfigBlock>? RdbConfig
    {
        get => GetArgument<TerraformList<GoogleMemorystoreInstancePersistenceConfigBlockRdbConfigBlock>>("rdb_config");
        set => SetArgument("rdb_config", value);
    }

}

/// <summary>
/// Block type for aof_config in GoogleMemorystoreInstancePersistenceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstancePersistenceConfigBlockAofConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aof_config";

    /// <summary>
    /// Optional. The fsync mode. 
    ///  Possible values:
    ///  NEVER
    /// EVERY_SEC
    /// ALWAYS
    /// </summary>
    public TerraformValue<string>? AppendFsync
    {
        get => GetArgument<TerraformValue<string>>("append_fsync");
        set => SetArgument("append_fsync", value);
    }

}

/// <summary>
/// Block type for rdb_config in GoogleMemorystoreInstancePersistenceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstancePersistenceConfigBlockRdbConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rdb_config";

    /// <summary>
    /// Optional. Period between RDB snapshots. 
    ///  Possible values:
    ///  ONE_HOUR
    /// SIX_HOURS
    /// TWELVE_HOURS
    /// TWENTY_FOUR_HOURS
    /// </summary>
    public TerraformValue<string>? RdbSnapshotPeriod
    {
        get => GetArgument<TerraformValue<string>>("rdb_snapshot_period");
        set => SetArgument("rdb_snapshot_period", value);
    }

    /// <summary>
    /// Optional. Time that the first snapshot was/will be attempted, and to which future
    /// snapshots will be aligned. If not provided, the current time will be
    /// used.
    /// </summary>
    public TerraformValue<string>? RdbSnapshotStartTime
    {
        get => GetArgument<TerraformValue<string>>("rdb_snapshot_start_time");
        set => SetArgument("rdb_snapshot_start_time", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleMemorystoreInstance.
/// Nesting mode: single
/// </summary>
public class GoogleMemorystoreInstanceTimeoutsBlock : TerraformBlock
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
/// Block type for zone_distribution_config in GoogleMemorystoreInstance.
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceZoneDistributionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "zone_distribution_config";

    /// <summary>
    /// Optional. Current zone distribution mode. Defaults to MULTI_ZONE. 
    ///  Possible values:
    ///  MULTI_ZONE
    /// SINGLE_ZONE Possible values: [&amp;quot;MULTI_ZONE&amp;quot;, &amp;quot;SINGLE_ZONE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// Optional. Defines zone where all resources will be allocated with SINGLE_ZONE mode.
    /// Ignored for MULTI_ZONE mode.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => GetArgument<TerraformValue<string>>("zone");
        set => SetArgument("zone", value);
    }

}


/// <summary>
/// Represents a google_memorystore_instance Terraform resource.
/// Manages a google_memorystore_instance resource.
/// </summary>
public partial class GoogleMemorystoreInstance(string name) : TerraformResource("google_memorystore_instance", name)
{
    /// <summary>
    /// Optional. Immutable. Authorization mode of the instance. Possible values:
    ///  AUTH_DISABLED
    /// IAM_AUTH
    /// </summary>
    public TerraformValue<string>? AuthorizationMode
    {
        get => GetArgument<TerraformValue<string>>("authorization_mode");
        set => SetArgument("authorization_mode", value);
    }

    /// <summary>
    /// Optional. If set to true deletion of the instance will fail.
    /// </summary>
    public TerraformValue<bool>? DeletionProtectionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection_enabled");
        set => SetArgument("deletion_protection_enabled", value);
    }

    /// <summary>
    /// Optional. User-provided engine configurations for the instance.
    /// </summary>
    public TerraformMap<string>? EngineConfigs
    {
        get => GetArgument<TerraformMap<string>>("engine_configs");
        set => SetArgument("engine_configs", value);
    }

    /// <summary>
    /// Optional. Engine version of the instance.
    /// </summary>
    public TerraformValue<string>? EngineVersion
    {
        get => GetArgument<TerraformValue<string>>("engine_version");
        set => SetArgument("engine_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Required. The ID to use for the instance, which will become the final component of
    /// the instance&#39;s resource name.
    /// 
    /// This value is subject to the following restrictions:
    /// 
    /// * Must be 4-63 characters in length
    /// * Must begin with a letter or digit
    /// * Must contain only lowercase letters, digits, and hyphens
    /// * Must not end with a hyphen
    /// * Must be unique within a location
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => GetArgument<TerraformValue<string>>("instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// The KMS key used to encrypt the at-rest data of the cluster
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => GetArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

    /// <summary>
    /// Optional. Labels to represent user-provided metadata. 
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. See documentation for resource type &#39;memorystore.googleapis.com/CertificateAuthority&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// This field can be used to trigger self service update to indicate the desired maintenance version. The input to this field can be determined by the available_maintenance_versions field.
    /// *Note*: This field can only be specified when updating an existing cluster to a newer version. Downgrades are currently not supported!
    /// </summary>
    public TerraformValue<string>? MaintenanceVersion
    {
        get => GetArgument<TerraformValue<string>>("maintenance_version");
        set => SetArgument("maintenance_version", value);
    }

    /// <summary>
    /// Optional. cluster or cluster-disabled. 
    ///  Possible values:
    ///  CLUSTER
    ///  CLUSTER_DISABLED Possible values: [&amp;quot;CLUSTER&amp;quot;, &amp;quot;CLUSTER_DISABLED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// Optional. Machine type for individual nodes of the instance. 
    ///  Possible values:
    ///  SHARED_CORE_NANO
    /// HIGHMEM_MEDIUM
    /// HIGHMEM_XLARGE
    /// STANDARD_SMALL
    /// </summary>
    public TerraformValue<string>? NodeType
    {
        get => GetArgument<TerraformValue<string>>("node_type");
        set => SetArgument("node_type", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Optional. Number of replica nodes per shard. If omitted the default is 0 replicas.
    /// </summary>
    public TerraformValue<double>? ReplicaCount
    {
        get => GetArgument<TerraformValue<double>>("replica_count");
        set => SetArgument("replica_count", value);
    }

    /// <summary>
    /// Required. Number of shards for the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShardCount is required")]
    public required TerraformValue<double> ShardCount
    {
        get => GetArgument<TerraformValue<double>>("shard_count");
        set => SetArgument("shard_count", value);
    }

    /// <summary>
    /// Optional. Immutable. In-transit encryption mode of the instance. 
    ///  Possible values:
    ///  TRANSIT_ENCRYPTION_DISABLED
    /// SERVER_AUTHENTICATION
    /// </summary>
    public TerraformValue<string>? TransitEncryptionMode
    {
        get => GetArgument<TerraformValue<string>>("transit_encryption_mode");
        set => SetArgument("transit_encryption_mode", value);
    }

    /// <summary>
    /// This field is used to determine the available maintenance versions for the self service update.
    /// </summary>
    public TerraformList<string> AvailableMaintenanceVersions
        => AsReference("available_maintenance_versions");

    /// <summary>
    /// The backup collection full resource name.
    /// Example: projects/{project}/locations/{location}/backupCollections/{collection}
    /// </summary>
    public TerraformValue<string> BackupCollection
        => AsReference("backup_collection");

    /// <summary>
    /// Output only. Creation timestamp of the instance.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Deprecated. Output only. Endpoints clients can connect to the instance through.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformList<TerraformMap<object>> DiscoveryEndpoints
        => AsReference("discovery_endpoints");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// This field represents the actual maintenance version of the cluster.
    /// </summary>
    public TerraformValue<string> EffectiveMaintenanceVersion
        => AsReference("effective_maintenance_version");

    /// <summary>
    /// Endpoints for the instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> Endpoints
        => AsReference("endpoints");

    /// <summary>
    /// Upcoming maintenance schedule.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceSchedule
        => AsReference("maintenance_schedule");

    /// <summary>
    /// Instance&#39;s Certificate Authority. This field will only be populated if instance&#39;s transit_encryption_mode is SERVER_AUTHENTICATION
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagedServerCa
        => AsReference("managed_server_ca");

    /// <summary>
    /// Identifier. Unique name of the instance.
    /// Format: projects/{project}/locations/{location}/instances/{instance}
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Represents configuration for nodes of the instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> NodeConfig
        => AsReference("node_config");

    /// <summary>
    /// Configuration of a service attachment of the cluster, for creating PSC connections.
    /// </summary>
    public TerraformList<TerraformMap<object>> PscAttachmentDetails
        => AsReference("psc_attachment_details");

    /// <summary>
    /// Output only. User inputs and resource details of the auto-created PSC connections.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformList<TerraformMap<object>> PscAutoConnections
        => AsReference("psc_auto_connections");

    /// <summary>
    /// Output only. Current state of the instance. 
    ///  Possible values:
    ///  CREATING
    /// ACTIVE
    /// UPDATING
    /// DELETING
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Additional information about the state of the instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> StateInfo
        => AsReference("state_info");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Output only. System assigned, unique identifier for the instance.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Output only. Latest update timestamp of the instance.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// AutomatedBackupConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomatedBackupConfig block(s) allowed")]
    public TerraformList<GoogleMemorystoreInstanceAutomatedBackupConfigBlock>? AutomatedBackupConfig
    {
        get => GetArgument<TerraformList<GoogleMemorystoreInstanceAutomatedBackupConfigBlock>>("automated_backup_config");
        set => SetArgument("automated_backup_config", value);
    }

    /// <summary>
    /// CrossInstanceReplicationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CrossInstanceReplicationConfig block(s) allowed")]
    public TerraformList<GoogleMemorystoreInstanceCrossInstanceReplicationConfigBlock>? CrossInstanceReplicationConfig
    {
        get => GetArgument<TerraformList<GoogleMemorystoreInstanceCrossInstanceReplicationConfigBlock>>("cross_instance_replication_config");
        set => SetArgument("cross_instance_replication_config", value);
    }

    /// <summary>
    /// DesiredAutoCreatedEndpoints block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleMemorystoreInstanceDesiredAutoCreatedEndpointsBlock>? DesiredAutoCreatedEndpoints
    {
        get => GetArgument<TerraformList<GoogleMemorystoreInstanceDesiredAutoCreatedEndpointsBlock>>("desired_auto_created_endpoints");
        set => SetArgument("desired_auto_created_endpoints", value);
    }

    /// <summary>
    /// DesiredPscAutoConnections block (nesting mode: list).
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public TerraformList<GoogleMemorystoreInstanceDesiredPscAutoConnectionsBlock>? DesiredPscAutoConnections
    {
        get => GetArgument<TerraformList<GoogleMemorystoreInstanceDesiredPscAutoConnectionsBlock>>("desired_psc_auto_connections");
        set => SetArgument("desired_psc_auto_connections", value);
    }

    /// <summary>
    /// GcsSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsSource block(s) allowed")]
    public TerraformList<GoogleMemorystoreInstanceGcsSourceBlock>? GcsSource
    {
        get => GetArgument<TerraformList<GoogleMemorystoreInstanceGcsSourceBlock>>("gcs_source");
        set => SetArgument("gcs_source", value);
    }

    /// <summary>
    /// MaintenancePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenancePolicy block(s) allowed")]
    public TerraformList<GoogleMemorystoreInstanceMaintenancePolicyBlock>? MaintenancePolicy
    {
        get => GetArgument<TerraformList<GoogleMemorystoreInstanceMaintenancePolicyBlock>>("maintenance_policy");
        set => SetArgument("maintenance_policy", value);
    }

    /// <summary>
    /// ManagedBackupSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedBackupSource block(s) allowed")]
    public TerraformList<GoogleMemorystoreInstanceManagedBackupSourceBlock>? ManagedBackupSource
    {
        get => GetArgument<TerraformList<GoogleMemorystoreInstanceManagedBackupSourceBlock>>("managed_backup_source");
        set => SetArgument("managed_backup_source", value);
    }

    /// <summary>
    /// PersistenceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersistenceConfig block(s) allowed")]
    public TerraformList<GoogleMemorystoreInstancePersistenceConfigBlock>? PersistenceConfig
    {
        get => GetArgument<TerraformList<GoogleMemorystoreInstancePersistenceConfigBlock>>("persistence_config");
        set => SetArgument("persistence_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleMemorystoreInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleMemorystoreInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// ZoneDistributionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZoneDistributionConfig block(s) allowed")]
    public TerraformList<GoogleMemorystoreInstanceZoneDistributionConfigBlock>? ZoneDistributionConfig
    {
        get => GetArgument<TerraformList<GoogleMemorystoreInstanceZoneDistributionConfigBlock>>("zone_distribution_config");
        set => SetArgument("zone_distribution_config", value);
    }

}
