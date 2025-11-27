using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automated_backup_config in GoogleRedisCluster.
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterAutomatedBackupConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "automated_backup_config";

    /// <summary>
    /// How long to keep automated backups before the backups are deleted.
    /// The value should be between 1 day and 365 days. If not specified, the default value is 35 days.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Retention is required")]
    public required TerraformValue<string> Retention
    {
        get => new TerraformReference<string>(this, "retention");
        set => SetArgument("retention", value);
    }

    /// <summary>
    /// FixedFrequencySchedule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FixedFrequencySchedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FixedFrequencySchedule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedFrequencySchedule block(s) allowed")]
    public required TerraformList<GoogleRedisClusterAutomatedBackupConfigBlockFixedFrequencyScheduleBlock> FixedFrequencySchedule
    {
        get => GetRequiredArgument<TerraformList<GoogleRedisClusterAutomatedBackupConfigBlockFixedFrequencyScheduleBlock>>("fixed_frequency_schedule");
        set => SetArgument("fixed_frequency_schedule", value);
    }

}

/// <summary>
/// Block type for fixed_frequency_schedule in GoogleRedisClusterAutomatedBackupConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterAutomatedBackupConfigBlockFixedFrequencyScheduleBlock : TerraformBlock
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
    public required TerraformList<GoogleRedisClusterAutomatedBackupConfigBlockFixedFrequencyScheduleBlockStartTimeBlock> StartTime
    {
        get => GetRequiredArgument<TerraformList<GoogleRedisClusterAutomatedBackupConfigBlockFixedFrequencyScheduleBlockStartTimeBlock>>("start_time");
        set => SetArgument("start_time", value);
    }

}

/// <summary>
/// Block type for start_time in GoogleRedisClusterAutomatedBackupConfigBlockFixedFrequencyScheduleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterAutomatedBackupConfigBlockFixedFrequencyScheduleBlockStartTimeBlock : TerraformBlock
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
        get => new TerraformReference<double>(this, "hours");
        set => SetArgument("hours", value);
    }

}


/// <summary>
/// Block type for cross_cluster_replication_config in GoogleRedisCluster.
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterCrossClusterReplicationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cross_cluster_replication_config";

    /// <summary>
    /// The role of the cluster in cross cluster replication. Supported values are:
    /// 
    /// 1. &#39;CLUSTER_ROLE_UNSPECIFIED&#39;: This is an independent cluster that has never participated in cross cluster replication. It allows both reads and writes.
    /// 
    /// 1. &#39;NONE&#39;: This is an independent cluster that previously participated in cross cluster replication(either as a &#39;PRIMARY&#39; or &#39;SECONDARY&#39; cluster). It allows both reads and writes.
    /// 
    /// 1. &#39;PRIMARY&#39;: This cluster serves as the replication source for secondary clusters that are replicating from it. Any data written to it is automatically replicated to its secondary clusters. It allows both reads and writes.
    /// 
    /// 1. &#39;SECONDARY&#39;: This cluster replicates data from the primary cluster. It allows only reads. Possible values: [&amp;quot;CLUSTER_ROLE_UNSPECIFIED&amp;quot;, &amp;quot;NONE&amp;quot;, &amp;quot;PRIMARY&amp;quot;, &amp;quot;SECONDARY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ClusterRole
    {
        get => new TerraformReference<string>(this, "cluster_role");
        set => SetArgument("cluster_role", value);
    }

    /// <summary>
    /// An output only view of all the member clusters participating in cross cluster replication. This field is populated for all the member clusters irrespective of their cluster role.
    /// </summary>
    public TerraformList<TerraformMap<object>> Membership
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "membership").ResolveNodes(ctx));
    }

    /// <summary>
    /// The last time cross cluster replication config was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// PrimaryCluster block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrimaryCluster block(s) allowed")]
    public TerraformList<GoogleRedisClusterCrossClusterReplicationConfigBlockPrimaryClusterBlock>? PrimaryCluster
    {
        get => GetArgument<TerraformList<GoogleRedisClusterCrossClusterReplicationConfigBlockPrimaryClusterBlock>>("primary_cluster");
        set => SetArgument("primary_cluster", value);
    }

    /// <summary>
    /// SecondaryClusters block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleRedisClusterCrossClusterReplicationConfigBlockSecondaryClustersBlock>? SecondaryClusters
    {
        get => GetArgument<TerraformList<GoogleRedisClusterCrossClusterReplicationConfigBlockSecondaryClustersBlock>>("secondary_clusters");
        set => SetArgument("secondary_clusters", value);
    }

}

/// <summary>
/// Block type for primary_cluster in GoogleRedisClusterCrossClusterReplicationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterCrossClusterReplicationConfigBlockPrimaryClusterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "primary_cluster";

    /// <summary>
    /// The full resource path of the primary cluster in the format: projects/{project}/locations/{region}/clusters/{cluster-id}
    /// </summary>
    public TerraformValue<string>? Cluster
    {
        get => new TerraformReference<string>(this, "cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// The unique id of the primary cluster.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

}

/// <summary>
/// Block type for secondary_clusters in GoogleRedisClusterCrossClusterReplicationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterCrossClusterReplicationConfigBlockSecondaryClustersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secondary_clusters";

    /// <summary>
    /// The full resource path of the secondary cluster in the format: projects/{project}/locations/{region}/clusters/{cluster-id}
    /// </summary>
    public TerraformValue<string>? Cluster
    {
        get => new TerraformReference<string>(this, "cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// The unique id of the secondary cluster.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

}


/// <summary>
/// Block type for gcs_source in GoogleRedisCluster.
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterGcsSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs_source";

    /// <summary>
    /// URIs of the GCS objects to import. Example: gs://bucket1/object1, gs://bucket2/folder2/object2
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uris is required")]
    public required TerraformSet<string> Uris
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "uris").ResolveNodes(ctx));
        set => SetArgument("uris", value);
    }

}


/// <summary>
/// Block type for maintenance_policy in GoogleRedisCluster.
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterMaintenancePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_policy";

    /// <summary>
    /// Output only. The time when the policy was created.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Output only. The time when the policy was last updated.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// WeeklyMaintenanceWindow block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleRedisClusterMaintenancePolicyBlockWeeklyMaintenanceWindowBlock>? WeeklyMaintenanceWindow
    {
        get => GetArgument<TerraformList<GoogleRedisClusterMaintenancePolicyBlockWeeklyMaintenanceWindowBlock>>("weekly_maintenance_window");
        set => SetArgument("weekly_maintenance_window", value);
    }

}

/// <summary>
/// Block type for weekly_maintenance_window in GoogleRedisClusterMaintenancePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterMaintenancePolicyBlockWeeklyMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weekly_maintenance_window";

    /// <summary>
    /// Required. The day of week that maintenance updates occur.
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
        get => new TerraformReference<string>(this, "day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Output only. Duration of the maintenance window.
    /// The current window is fixed at 1 hour.
    /// A duration in seconds with up to nine fractional digits,
    /// terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string> Duration
    {
        get => new TerraformReference<string>(this, "duration");
    }

    /// <summary>
    /// StartTime block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StartTime block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartTime block(s) allowed")]
    public required TerraformList<GoogleRedisClusterMaintenancePolicyBlockWeeklyMaintenanceWindowBlockStartTimeBlock> StartTime
    {
        get => GetRequiredArgument<TerraformList<GoogleRedisClusterMaintenancePolicyBlockWeeklyMaintenanceWindowBlockStartTimeBlock>>("start_time");
        set => SetArgument("start_time", value);
    }

}

/// <summary>
/// Block type for start_time in GoogleRedisClusterMaintenancePolicyBlockWeeklyMaintenanceWindowBlock.
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterMaintenancePolicyBlockWeeklyMaintenanceWindowBlockStartTimeBlock : TerraformBlock
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
        get => new TerraformReference<double>(this, "hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => new TerraformReference<double>(this, "minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => new TerraformReference<double>(this, "nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59.
    /// An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => new TerraformReference<double>(this, "seconds");
        set => SetArgument("seconds", value);
    }

}


/// <summary>
/// Block type for managed_backup_source in GoogleRedisCluster.
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterManagedBackupSourceBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "backup");
        set => SetArgument("backup", value);
    }

}


/// <summary>
/// Block type for persistence_config in GoogleRedisCluster.
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterPersistenceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "persistence_config";

    /// <summary>
    /// Optional. Controls whether Persistence features are enabled. If not provided, the existing value will be used.
    /// 
    /// - DISABLED: 	Persistence (both backup and restore) is disabled for the cluster.
    /// - RDB: RDB based Persistence is enabled.
    /// - AOF: AOF based Persistence is enabled. Possible values: [&amp;quot;PERSISTENCE_MODE_UNSPECIFIED&amp;quot;, &amp;quot;DISABLED&amp;quot;, &amp;quot;RDB&amp;quot;, &amp;quot;AOF&amp;quot;]
    /// </summary>
    public TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// AofConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AofConfig block(s) allowed")]
    public TerraformList<GoogleRedisClusterPersistenceConfigBlockAofConfigBlock>? AofConfig
    {
        get => GetArgument<TerraformList<GoogleRedisClusterPersistenceConfigBlockAofConfigBlock>>("aof_config");
        set => SetArgument("aof_config", value);
    }

    /// <summary>
    /// RdbConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RdbConfig block(s) allowed")]
    public TerraformList<GoogleRedisClusterPersistenceConfigBlockRdbConfigBlock>? RdbConfig
    {
        get => GetArgument<TerraformList<GoogleRedisClusterPersistenceConfigBlockRdbConfigBlock>>("rdb_config");
        set => SetArgument("rdb_config", value);
    }

}

/// <summary>
/// Block type for aof_config in GoogleRedisClusterPersistenceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterPersistenceConfigBlockAofConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aof_config";

    /// <summary>
    /// Optional. Available fsync modes.
    /// 
    /// - NO - Do not explicitly call fsync(). Rely on OS defaults.
    /// - EVERYSEC - Call fsync() once per second in a background thread. A balance between performance and durability.
    /// - ALWAYS - Call fsync() for earch write command. Possible values: [&amp;quot;APPEND_FSYNC_UNSPECIFIED&amp;quot;, &amp;quot;NO&amp;quot;, &amp;quot;EVERYSEC&amp;quot;, &amp;quot;ALWAYS&amp;quot;]
    /// </summary>
    public TerraformValue<string> AppendFsync
    {
        get => new TerraformReference<string>(this, "append_fsync");
        set => SetArgument("append_fsync", value);
    }

}

/// <summary>
/// Block type for rdb_config in GoogleRedisClusterPersistenceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterPersistenceConfigBlockRdbConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rdb_config";

    /// <summary>
    /// Optional. Available snapshot periods for scheduling.
    /// 
    /// - ONE_HOUR:	Snapshot every 1 hour.
    /// - SIX_HOURS:	Snapshot every 6 hours.
    /// - TWELVE_HOURS:	Snapshot every 12 hours.
    /// - TWENTY_FOUR_HOURS:	Snapshot every 24 hours. Possible values: [&amp;quot;SNAPSHOT_PERIOD_UNSPECIFIED&amp;quot;, &amp;quot;ONE_HOUR&amp;quot;, &amp;quot;SIX_HOURS&amp;quot;, &amp;quot;TWELVE_HOURS&amp;quot;, &amp;quot;TWENTY_FOUR_HOURS&amp;quot;]
    /// </summary>
    public TerraformValue<string> RdbSnapshotPeriod
    {
        get => new TerraformReference<string>(this, "rdb_snapshot_period");
        set => SetArgument("rdb_snapshot_period", value);
    }

    /// <summary>
    /// The time that the first snapshot was/will be attempted, and to which
    /// future snapshots will be aligned.
    /// If not provided, the current time will be used.
    /// </summary>
    public TerraformValue<string> RdbSnapshotStartTime
    {
        get => new TerraformReference<string>(this, "rdb_snapshot_start_time");
        set => SetArgument("rdb_snapshot_start_time", value);
    }

}


/// <summary>
/// Block type for psc_configs in GoogleRedisCluster.
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterPscConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "psc_configs";

    /// <summary>
    /// Required. The consumer network where the network address of
    /// the discovery endpoint will be reserved, in the form of
    /// projects/{network_project_id_or_number}/global/networks/{network_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleRedisCluster.
/// Nesting mode: single
/// </summary>
public class GoogleRedisClusterTimeoutsBlock : TerraformBlock
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
/// Block type for zone_distribution_config in GoogleRedisCluster.
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterZoneDistributionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "zone_distribution_config";

    /// <summary>
    /// Immutable. The mode for zone distribution for Memorystore Redis cluster.
    /// If not provided, MULTI_ZONE will be used as default Possible values: [&amp;quot;MULTI_ZONE&amp;quot;, &amp;quot;SINGLE_ZONE&amp;quot;]
    /// </summary>
    public TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// Immutable. The zone for single zone Memorystore Redis cluster.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

}


/// <summary>
/// Represents a google_redis_cluster Terraform resource.
/// Manages a google_redis_cluster resource.
/// </summary>
public partial class GoogleRedisCluster(string name) : TerraformResource("google_redis_cluster", name)
{
    /// <summary>
    /// Optional. The authorization mode of the Redis cluster. If not provided, auth feature is disabled for the cluster. Default value: &amp;quot;AUTH_MODE_DISABLED&amp;quot; Possible values: [&amp;quot;AUTH_MODE_UNSPECIFIED&amp;quot;, &amp;quot;AUTH_MODE_IAM_AUTH&amp;quot;, &amp;quot;AUTH_MODE_DISABLED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? AuthorizationMode
    {
        get => new TerraformReference<string>(this, "authorization_mode");
        set => SetArgument("authorization_mode", value);
    }

    /// <summary>
    /// Optional. Indicates if the cluster is deletion protected or not.
    /// If the value if set to true, any delete cluster operation will fail.
    /// Default value is true.
    /// </summary>
    public TerraformValue<bool>? DeletionProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "deletion_protection_enabled");
        set => SetArgument("deletion_protection_enabled", value);
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
    /// The KMS key used to encrypt the at-rest data of the cluster.
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => new TerraformReference<string>(this, "kms_key");
        set => SetArgument("kms_key", value);
    }

    /// <summary>
    /// This field can be used to trigger self service update to indicate the desired maintenance version. The input to this field can be determined by the available_maintenance_versions field.
    /// *Note*: This field can only be specified when updating an existing cluster to a newer version. Downgrades are currently not supported!
    /// </summary>
    public TerraformValue<string>? MaintenanceVersion
    {
        get => new TerraformReference<string>(this, "maintenance_version");
        set => SetArgument("maintenance_version", value);
    }

    /// <summary>
    /// Unique name of the resource in this scope including project and location using the form:
    /// projects/{projectId}/locations/{locationId}/clusters/{clusterId}
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The nodeType for the Redis cluster.
    /// If not provided, REDIS_HIGHMEM_MEDIUM will be used as default Possible values: [&amp;quot;REDIS_SHARED_CORE_NANO&amp;quot;, &amp;quot;REDIS_HIGHMEM_MEDIUM&amp;quot;, &amp;quot;REDIS_HIGHMEM_XLARGE&amp;quot;, &amp;quot;REDIS_STANDARD_SMALL&amp;quot;]
    /// </summary>
    public TerraformValue<string> NodeType
    {
        get => new TerraformReference<string>(this, "node_type");
        set => SetArgument("node_type", value);
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
    /// Configure Redis Cluster behavior using a subset of native Redis configuration parameters.
    /// Please check Memorystore documentation for the list of supported parameters:
    /// https://cloud.google.com/memorystore/docs/cluster/supported-instance-configurations
    /// </summary>
    public TerraformMap<string>? RedisConfigs
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "redis_configs").ResolveNodes(ctx));
        set => SetArgument("redis_configs", value);
    }

    /// <summary>
    /// The name of the region of the Redis cluster.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Optional. The number of replica nodes per shard.
    /// </summary>
    public TerraformValue<double>? ReplicaCount
    {
        get => new TerraformReference<double>(this, "replica_count");
        set => SetArgument("replica_count", value);
    }

    /// <summary>
    /// Required. Number of shards for the Redis cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShardCount is required")]
    public required TerraformValue<double> ShardCount
    {
        get => new TerraformReference<double>(this, "shard_count");
        set => SetArgument("shard_count", value);
    }

    /// <summary>
    /// Optional. The in-transit encryption for the Redis cluster.
    /// If not provided, encryption is disabled for the cluster. Default value: &amp;quot;TRANSIT_ENCRYPTION_MODE_DISABLED&amp;quot; Possible values: [&amp;quot;TRANSIT_ENCRYPTION_MODE_UNSPECIFIED&amp;quot;, &amp;quot;TRANSIT_ENCRYPTION_MODE_DISABLED&amp;quot;, &amp;quot;TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION&amp;quot;]
    /// </summary>
    public TerraformValue<string>? TransitEncryptionMode
    {
        get => new TerraformReference<string>(this, "transit_encryption_mode");
        set => SetArgument("transit_encryption_mode", value);
    }

    /// <summary>
    /// This field is used to determine the available maintenance versions for the self service update.
    /// </summary>
    public TerraformList<string> AvailableMaintenanceVersions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "available_maintenance_versions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The backup collection full resource name.
    /// Example: projects/{project}/locations/{location}/backupCollections/{collection}
    /// </summary>
    public TerraformValue<string> BackupCollection
    {
        get => new TerraformReference<string>(this, "backup_collection");
    }

    /// <summary>
    /// The timestamp associated with the cluster creation request. A timestamp in
    /// RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional
    /// digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Output only. Endpoints created on each given network,
    /// for Redis clients to connect to the cluster.
    /// Currently only one endpoint is supported.
    /// </summary>
    public TerraformList<TerraformMap<object>> DiscoveryEndpoints
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "discovery_endpoints").ResolveNodes(ctx));
    }

    /// <summary>
    /// This field represents the actual maintenance version of the cluster.
    /// </summary>
    public TerraformValue<string> EffectiveMaintenanceVersion
    {
        get => new TerraformReference<string>(this, "effective_maintenance_version");
    }

    /// <summary>
    /// Upcoming maintenance schedule.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceSchedule
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "maintenance_schedule").ResolveNodes(ctx));
    }

    /// <summary>
    /// Cluster&#39;s Certificate Authority. This field will only be populated if Redis Cluster&#39;s transit_encryption_mode is TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagedServerCa
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "managed_server_ca").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. Redis memory precise size in GB for the entire cluster.
    /// </summary>
    public TerraformValue<double> PreciseSizeGb
    {
        get => new TerraformReference<double>(this, "precise_size_gb");
    }

    /// <summary>
    /// Output only. PSC connections for discovery of the cluster topology and accessing the cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> PscConnections
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "psc_connections").ResolveNodes(ctx));
    }

    /// <summary>
    /// Service attachment details to configure Psc connections.
    /// </summary>
    public TerraformList<TerraformMap<object>> PscServiceAttachments
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "psc_service_attachments").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. Redis memory size in GB for the entire cluster.
    /// </summary>
    public TerraformValue<double> SizeGb
    {
        get => new TerraformReference<double>(this, "size_gb");
    }

    /// <summary>
    /// The current state of this cluster. Can be CREATING, READY, UPDATING, DELETING and SUSPENDED
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// Output only. Additional information about the current state of the cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> StateInfo
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "state_info").ResolveNodes(ctx));
    }

    /// <summary>
    /// System assigned, unique identifier for the cluster.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// AutomatedBackupConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomatedBackupConfig block(s) allowed")]
    public TerraformList<GoogleRedisClusterAutomatedBackupConfigBlock>? AutomatedBackupConfig
    {
        get => GetArgument<TerraformList<GoogleRedisClusterAutomatedBackupConfigBlock>>("automated_backup_config");
        set => SetArgument("automated_backup_config", value);
    }

    /// <summary>
    /// CrossClusterReplicationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CrossClusterReplicationConfig block(s) allowed")]
    public TerraformList<GoogleRedisClusterCrossClusterReplicationConfigBlock>? CrossClusterReplicationConfig
    {
        get => GetArgument<TerraformList<GoogleRedisClusterCrossClusterReplicationConfigBlock>>("cross_cluster_replication_config");
        set => SetArgument("cross_cluster_replication_config", value);
    }

    /// <summary>
    /// GcsSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsSource block(s) allowed")]
    public TerraformList<GoogleRedisClusterGcsSourceBlock>? GcsSource
    {
        get => GetArgument<TerraformList<GoogleRedisClusterGcsSourceBlock>>("gcs_source");
        set => SetArgument("gcs_source", value);
    }

    /// <summary>
    /// MaintenancePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenancePolicy block(s) allowed")]
    public TerraformList<GoogleRedisClusterMaintenancePolicyBlock>? MaintenancePolicy
    {
        get => GetArgument<TerraformList<GoogleRedisClusterMaintenancePolicyBlock>>("maintenance_policy");
        set => SetArgument("maintenance_policy", value);
    }

    /// <summary>
    /// ManagedBackupSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedBackupSource block(s) allowed")]
    public TerraformList<GoogleRedisClusterManagedBackupSourceBlock>? ManagedBackupSource
    {
        get => GetArgument<TerraformList<GoogleRedisClusterManagedBackupSourceBlock>>("managed_backup_source");
        set => SetArgument("managed_backup_source", value);
    }

    /// <summary>
    /// PersistenceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersistenceConfig block(s) allowed")]
    public TerraformList<GoogleRedisClusterPersistenceConfigBlock>? PersistenceConfig
    {
        get => GetArgument<TerraformList<GoogleRedisClusterPersistenceConfigBlock>>("persistence_config");
        set => SetArgument("persistence_config", value);
    }

    /// <summary>
    /// PscConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleRedisClusterPscConfigsBlock>? PscConfigs
    {
        get => GetArgument<TerraformList<GoogleRedisClusterPscConfigsBlock>>("psc_configs");
        set => SetArgument("psc_configs", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleRedisClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleRedisClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// ZoneDistributionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZoneDistributionConfig block(s) allowed")]
    public TerraformList<GoogleRedisClusterZoneDistributionConfigBlock>? ZoneDistributionConfig
    {
        get => GetArgument<TerraformList<GoogleRedisClusterZoneDistributionConfigBlock>>("zone_distribution_config");
        set => SetArgument("zone_distribution_config", value);
    }

}
