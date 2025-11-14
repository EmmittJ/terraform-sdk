using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleAutonomousDatabaseDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_autonomous_database.
/// </summary>
public class AzurermOracleAutonomousDatabaseDataSource : TerraformDataSource
{
    public AzurermOracleAutonomousDatabaseDataSource(string name) : base("azurerm_oracle_autonomous_database", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermOracleAutonomousDatabaseDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The actual_used_data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformArgument("actual_used_data_storage_size_in_tbs")]
    public TerraformValue<double> ActualUsedDataStorageSizeInTbs
    {
        get => new TerraformReference<double>(this, "actual_used_data_storage_size_in_tbs");
    }

    /// <summary>
    /// The allocated_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformArgument("allocated_storage_size_in_tbs")]
    public TerraformValue<double> AllocatedStorageSizeInTbs
    {
        get => new TerraformReference<double>(this, "allocated_storage_size_in_tbs");
    }

    /// <summary>
    /// The allowed_ips attribute.
    /// </summary>
    [TerraformArgument("allowed_ips")]
    public TerraformList<double> AllowedIps
    {
        get => TerraformList<double>.Lazy(ctx => new TerraformReference<TerraformList<double>>(this, "allowed_ips").ResolveNodes(ctx));
    }

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    [TerraformArgument("auto_scaling_enabled")]
    public TerraformValue<bool> AutoScalingEnabled
    {
        get => new TerraformReference<bool>(this, "auto_scaling_enabled");
    }

    /// <summary>
    /// The auto_scaling_for_storage_enabled attribute.
    /// </summary>
    [TerraformArgument("auto_scaling_for_storage_enabled")]
    public TerraformValue<bool> AutoScalingForStorageEnabled
    {
        get => new TerraformReference<bool>(this, "auto_scaling_for_storage_enabled");
    }

    /// <summary>
    /// The autonomous_database_id attribute.
    /// </summary>
    [TerraformArgument("autonomous_database_id")]
    public TerraformValue<string> AutonomousDatabaseId
    {
        get => new TerraformReference<string>(this, "autonomous_database_id");
    }

    /// <summary>
    /// The available_upgrade_versions attribute.
    /// </summary>
    [TerraformArgument("available_upgrade_versions")]
    public TerraformList<string> AvailableUpgradeVersions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "available_upgrade_versions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The backup_retention_period_in_days attribute.
    /// </summary>
    [TerraformArgument("backup_retention_period_in_days")]
    public TerraformValue<double> BackupRetentionPeriodInDays
    {
        get => new TerraformReference<double>(this, "backup_retention_period_in_days");
    }

    /// <summary>
    /// The character_set attribute.
    /// </summary>
    [TerraformArgument("character_set")]
    public TerraformValue<string> CharacterSet
    {
        get => new TerraformReference<string>(this, "character_set");
    }

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    [TerraformArgument("compute_count")]
    public TerraformValue<double> ComputeCount
    {
        get => new TerraformReference<double>(this, "compute_count");
    }

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    [TerraformArgument("cpu_core_count")]
    public TerraformValue<double> CpuCoreCount
    {
        get => new TerraformReference<double>(this, "cpu_core_count");
    }

    /// <summary>
    /// The data_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformArgument("data_storage_size_in_gbs")]
    public TerraformValue<double> DataStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "data_storage_size_in_gbs");
    }

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformArgument("data_storage_size_in_tbs")]
    public TerraformValue<double> DataStorageSizeInTbs
    {
        get => new TerraformReference<double>(this, "data_storage_size_in_tbs");
    }

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformArgument("db_node_storage_size_in_gbs")]
    public TerraformValue<double> DbNodeStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "db_node_storage_size_in_gbs");
    }

    /// <summary>
    /// The db_version attribute.
    /// </summary>
    [TerraformArgument("db_version")]
    public TerraformValue<string> DbVersion
    {
        get => new TerraformReference<string>(this, "db_version");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformArgument("display_name")]
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The failed_data_recovery_in_seconds attribute.
    /// </summary>
    [TerraformArgument("failed_data_recovery_in_seconds")]
    public TerraformValue<double> FailedDataRecoveryInSeconds
    {
        get => new TerraformReference<double>(this, "failed_data_recovery_in_seconds");
    }

    /// <summary>
    /// The in_memory_area_in_gbs attribute.
    /// </summary>
    [TerraformArgument("in_memory_area_in_gbs")]
    public TerraformValue<double> InMemoryAreaInGbs
    {
        get => new TerraformReference<double>(this, "in_memory_area_in_gbs");
    }

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    [TerraformArgument("lifecycle_details")]
    public TerraformValue<string> LifecycleDetails
    {
        get => new TerraformReference<string>(this, "lifecycle_details");
    }

    /// <summary>
    /// The local_adg_auto_failover_max_data_loss_limit attribute.
    /// </summary>
    [TerraformArgument("local_adg_auto_failover_max_data_loss_limit")]
    public TerraformValue<double> LocalAdgAutoFailoverMaxDataLossLimit
    {
        get => new TerraformReference<double>(this, "local_adg_auto_failover_max_data_loss_limit");
    }

    /// <summary>
    /// The local_data_guard_enabled attribute.
    /// </summary>
    [TerraformArgument("local_data_guard_enabled")]
    public TerraformValue<bool> LocalDataGuardEnabled
    {
        get => new TerraformReference<bool>(this, "local_data_guard_enabled");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The long_term_backup_schedule attribute.
    /// </summary>
    [TerraformArgument("long_term_backup_schedule")]
    public TerraformList<object> LongTermBackupSchedule
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "long_term_backup_schedule").ResolveNodes(ctx));
    }

    /// <summary>
    /// The memory_per_oracle_compute_unit_in_gbs attribute.
    /// </summary>
    [TerraformArgument("memory_per_oracle_compute_unit_in_gbs")]
    public TerraformValue<double> MemoryPerOracleComputeUnitInGbs
    {
        get => new TerraformReference<double>(this, "memory_per_oracle_compute_unit_in_gbs");
    }

    /// <summary>
    /// The mtls_connection_required attribute.
    /// </summary>
    [TerraformArgument("mtls_connection_required")]
    public TerraformValue<bool> MtlsConnectionRequired
    {
        get => new TerraformReference<bool>(this, "mtls_connection_required");
    }

    /// <summary>
    /// The national_character_set attribute.
    /// </summary>
    [TerraformArgument("national_character_set")]
    public TerraformValue<string> NationalCharacterSet
    {
        get => new TerraformReference<string>(this, "national_character_set");
    }

    /// <summary>
    /// The next_long_term_backup_time_stamp attribute.
    /// </summary>
    [TerraformArgument("next_long_term_backup_time_stamp")]
    public TerraformValue<string> NextLongTermBackupTimeStamp
    {
        get => new TerraformReference<string>(this, "next_long_term_backup_time_stamp");
    }

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    [TerraformArgument("oci_url")]
    public TerraformValue<string> OciUrl
    {
        get => new TerraformReference<string>(this, "oci_url");
    }

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    [TerraformArgument("ocid")]
    public TerraformValue<string> Ocid
    {
        get => new TerraformReference<string>(this, "ocid");
    }

    /// <summary>
    /// The peer_db_id attribute.
    /// </summary>
    [TerraformArgument("peer_db_id")]
    public TerraformValue<string> PeerDbId
    {
        get => new TerraformReference<string>(this, "peer_db_id");
    }

    /// <summary>
    /// The peer_db_ids attribute.
    /// </summary>
    [TerraformArgument("peer_db_ids")]
    public TerraformList<string> PeerDbIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "peer_db_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The preview attribute.
    /// </summary>
    [TerraformArgument("preview")]
    public TerraformValue<bool> Preview
    {
        get => new TerraformReference<bool>(this, "preview");
    }

    /// <summary>
    /// The preview_version_with_service_terms_accepted attribute.
    /// </summary>
    [TerraformArgument("preview_version_with_service_terms_accepted")]
    public TerraformValue<bool> PreviewVersionWithServiceTermsAccepted
    {
        get => new TerraformReference<bool>(this, "preview_version_with_service_terms_accepted");
    }

    /// <summary>
    /// The private_endpoint attribute.
    /// </summary>
    [TerraformArgument("private_endpoint")]
    public TerraformValue<string> PrivateEndpoint
    {
        get => new TerraformReference<string>(this, "private_endpoint");
    }

    /// <summary>
    /// The private_endpoint_ip attribute.
    /// </summary>
    [TerraformArgument("private_endpoint_ip")]
    public TerraformValue<string> PrivateEndpointIp
    {
        get => new TerraformReference<string>(this, "private_endpoint_ip");
    }

    /// <summary>
    /// The private_endpoint_label attribute.
    /// </summary>
    [TerraformArgument("private_endpoint_label")]
    public TerraformValue<string> PrivateEndpointLabel
    {
        get => new TerraformReference<string>(this, "private_endpoint_label");
    }

    /// <summary>
    /// The provisionable_cpus attribute.
    /// </summary>
    [TerraformArgument("provisionable_cpus")]
    public TerraformList<double> ProvisionableCpus
    {
        get => TerraformList<double>.Lazy(ctx => new TerraformReference<TerraformList<double>>(this, "provisionable_cpus").ResolveNodes(ctx));
    }

    /// <summary>
    /// The remote_data_guard_enabled attribute.
    /// </summary>
    [TerraformArgument("remote_data_guard_enabled")]
    public TerraformValue<bool> RemoteDataGuardEnabled
    {
        get => new TerraformReference<bool>(this, "remote_data_guard_enabled");
    }

    /// <summary>
    /// The service_console_url attribute.
    /// </summary>
    [TerraformArgument("service_console_url")]
    public TerraformValue<string> ServiceConsoleUrl
    {
        get => new TerraformReference<string>(this, "service_console_url");
    }

    /// <summary>
    /// The sql_web_developer_url attribute.
    /// </summary>
    [TerraformArgument("sql_web_developer_url")]
    public TerraformValue<string> SqlWebDeveloperUrl
    {
        get => new TerraformReference<string>(this, "sql_web_developer_url");
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformArgument("subnet_id")]
    public TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
    }

    /// <summary>
    /// The supported_regions_to_clone_to attribute.
    /// </summary>
    [TerraformArgument("supported_regions_to_clone_to")]
    public TerraformList<string> SupportedRegionsToCloneTo
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "supported_regions_to_clone_to").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    [TerraformArgument("time_created")]
    public TerraformValue<string> TimeCreated
    {
        get => new TerraformReference<string>(this, "time_created");
    }

    /// <summary>
    /// The time_data_guard_role_changed attribute.
    /// </summary>
    [TerraformArgument("time_data_guard_role_changed")]
    public TerraformValue<string> TimeDataGuardRoleChanged
    {
        get => new TerraformReference<string>(this, "time_data_guard_role_changed");
    }

    /// <summary>
    /// The time_deletion_of_free_autonomous_database attribute.
    /// </summary>
    [TerraformArgument("time_deletion_of_free_autonomous_database")]
    public TerraformValue<string> TimeDeletionOfFreeAutonomousDatabase
    {
        get => new TerraformReference<string>(this, "time_deletion_of_free_autonomous_database");
    }

    /// <summary>
    /// The time_local_data_guard_enabled_on attribute.
    /// </summary>
    [TerraformArgument("time_local_data_guard_enabled_on")]
    public TerraformValue<string> TimeLocalDataGuardEnabledOn
    {
        get => new TerraformReference<string>(this, "time_local_data_guard_enabled_on");
    }

    /// <summary>
    /// The time_maintenance_begin attribute.
    /// </summary>
    [TerraformArgument("time_maintenance_begin")]
    public TerraformValue<string> TimeMaintenanceBegin
    {
        get => new TerraformReference<string>(this, "time_maintenance_begin");
    }

    /// <summary>
    /// The time_maintenance_end attribute.
    /// </summary>
    [TerraformArgument("time_maintenance_end")]
    public TerraformValue<string> TimeMaintenanceEnd
    {
        get => new TerraformReference<string>(this, "time_maintenance_end");
    }

    /// <summary>
    /// The time_of_last_failover attribute.
    /// </summary>
    [TerraformArgument("time_of_last_failover")]
    public TerraformValue<string> TimeOfLastFailover
    {
        get => new TerraformReference<string>(this, "time_of_last_failover");
    }

    /// <summary>
    /// The time_of_last_refresh attribute.
    /// </summary>
    [TerraformArgument("time_of_last_refresh")]
    public TerraformValue<string> TimeOfLastRefresh
    {
        get => new TerraformReference<string>(this, "time_of_last_refresh");
    }

    /// <summary>
    /// The time_of_last_refresh_point attribute.
    /// </summary>
    [TerraformArgument("time_of_last_refresh_point")]
    public TerraformValue<string> TimeOfLastRefreshPoint
    {
        get => new TerraformReference<string>(this, "time_of_last_refresh_point");
    }

    /// <summary>
    /// The time_of_last_switchover attribute.
    /// </summary>
    [TerraformArgument("time_of_last_switchover")]
    public TerraformValue<string> TimeOfLastSwitchover
    {
        get => new TerraformReference<string>(this, "time_of_last_switchover");
    }

    /// <summary>
    /// The time_reclamation_of_free_autonomous_database attribute.
    /// </summary>
    [TerraformArgument("time_reclamation_of_free_autonomous_database")]
    public TerraformValue<string> TimeReclamationOfFreeAutonomousDatabase
    {
        get => new TerraformReference<string>(this, "time_reclamation_of_free_autonomous_database");
    }

    /// <summary>
    /// The used_data_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformArgument("used_data_storage_size_in_gbs")]
    public TerraformValue<double> UsedDataStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "used_data_storage_size_in_gbs");
    }

    /// <summary>
    /// The used_data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformArgument("used_data_storage_size_in_tbs")]
    public TerraformValue<double> UsedDataStorageSizeInTbs
    {
        get => new TerraformReference<double>(this, "used_data_storage_size_in_tbs");
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformArgument("virtual_network_id")]
    public TerraformValue<string> VirtualNetworkId
    {
        get => new TerraformReference<string>(this, "virtual_network_id");
    }

}
