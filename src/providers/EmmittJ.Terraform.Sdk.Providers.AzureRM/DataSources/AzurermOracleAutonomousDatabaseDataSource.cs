using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermOracleAutonomousDatabaseDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_oracle_autonomous_database Terraform data source.
/// Retrieves information about a azurerm_oracle_autonomous_database.
/// </summary>
public partial class AzurermOracleAutonomousDatabaseDataSource(string name) : TerraformDataSource("azurerm_oracle_autonomous_database", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The actual_used_data_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformValue<double> ActualUsedDataStorageSizeInTbs
    {
        get => new TerraformReference<double>(this, "actual_used_data_storage_size_in_tbs");
    }

    /// <summary>
    /// The allocated_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformValue<double> AllocatedStorageSizeInTbs
    {
        get => new TerraformReference<double>(this, "allocated_storage_size_in_tbs");
    }

    /// <summary>
    /// The allowed_ips attribute.
    /// </summary>
    public TerraformList<double> AllowedIps
    {
        get => TerraformList<double>.Lazy(ctx => new TerraformReference<TerraformList<double>>(this, "allowed_ips").ResolveNodes(ctx));
    }

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AutoScalingEnabled
    {
        get => new TerraformReference<bool>(this, "auto_scaling_enabled");
    }

    /// <summary>
    /// The auto_scaling_for_storage_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AutoScalingForStorageEnabled
    {
        get => new TerraformReference<bool>(this, "auto_scaling_for_storage_enabled");
    }

    /// <summary>
    /// The autonomous_database_id attribute.
    /// </summary>
    public TerraformValue<string> AutonomousDatabaseId
    {
        get => new TerraformReference<string>(this, "autonomous_database_id");
    }

    /// <summary>
    /// The available_upgrade_versions attribute.
    /// </summary>
    public TerraformList<string> AvailableUpgradeVersions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "available_upgrade_versions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The backup_retention_period_in_days attribute.
    /// </summary>
    public TerraformValue<double> BackupRetentionPeriodInDays
    {
        get => new TerraformReference<double>(this, "backup_retention_period_in_days");
    }

    /// <summary>
    /// The character_set attribute.
    /// </summary>
    public TerraformValue<string> CharacterSet
    {
        get => new TerraformReference<string>(this, "character_set");
    }

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    public TerraformValue<double> ComputeCount
    {
        get => new TerraformReference<double>(this, "compute_count");
    }

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    public TerraformValue<double> CpuCoreCount
    {
        get => new TerraformReference<double>(this, "cpu_core_count");
    }

    /// <summary>
    /// The data_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "data_storage_size_in_gbs");
    }

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInTbs
    {
        get => new TerraformReference<double>(this, "data_storage_size_in_tbs");
    }

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> DbNodeStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "db_node_storage_size_in_gbs");
    }

    /// <summary>
    /// The db_version attribute.
    /// </summary>
    public TerraformValue<string> DbVersion
    {
        get => new TerraformReference<string>(this, "db_version");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The failed_data_recovery_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> FailedDataRecoveryInSeconds
    {
        get => new TerraformReference<double>(this, "failed_data_recovery_in_seconds");
    }

    /// <summary>
    /// The in_memory_area_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> InMemoryAreaInGbs
    {
        get => new TerraformReference<double>(this, "in_memory_area_in_gbs");
    }

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    public TerraformValue<string> LifecycleDetails
    {
        get => new TerraformReference<string>(this, "lifecycle_details");
    }

    /// <summary>
    /// The local_adg_auto_failover_max_data_loss_limit attribute.
    /// </summary>
    public TerraformValue<double> LocalAdgAutoFailoverMaxDataLossLimit
    {
        get => new TerraformReference<double>(this, "local_adg_auto_failover_max_data_loss_limit");
    }

    /// <summary>
    /// The local_data_guard_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LocalDataGuardEnabled
    {
        get => new TerraformReference<bool>(this, "local_data_guard_enabled");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The long_term_backup_schedule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LongTermBackupSchedule
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "long_term_backup_schedule").ResolveNodes(ctx));
    }

    /// <summary>
    /// The memory_per_oracle_compute_unit_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> MemoryPerOracleComputeUnitInGbs
    {
        get => new TerraformReference<double>(this, "memory_per_oracle_compute_unit_in_gbs");
    }

    /// <summary>
    /// The mtls_connection_required attribute.
    /// </summary>
    public TerraformValue<bool> MtlsConnectionRequired
    {
        get => new TerraformReference<bool>(this, "mtls_connection_required");
    }

    /// <summary>
    /// The national_character_set attribute.
    /// </summary>
    public TerraformValue<string> NationalCharacterSet
    {
        get => new TerraformReference<string>(this, "national_character_set");
    }

    /// <summary>
    /// The next_long_term_backup_time_stamp attribute.
    /// </summary>
    public TerraformValue<string> NextLongTermBackupTimeStamp
    {
        get => new TerraformReference<string>(this, "next_long_term_backup_time_stamp");
    }

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    public TerraformValue<string> OciUrl
    {
        get => new TerraformReference<string>(this, "oci_url");
    }

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    public TerraformValue<string> Ocid
    {
        get => new TerraformReference<string>(this, "ocid");
    }

    /// <summary>
    /// The peer_db_id attribute.
    /// </summary>
    public TerraformValue<string> PeerDbId
    {
        get => new TerraformReference<string>(this, "peer_db_id");
    }

    /// <summary>
    /// The peer_db_ids attribute.
    /// </summary>
    public TerraformList<string> PeerDbIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "peer_db_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The preview attribute.
    /// </summary>
    public TerraformValue<bool> Preview
    {
        get => new TerraformReference<bool>(this, "preview");
    }

    /// <summary>
    /// The preview_version_with_service_terms_accepted attribute.
    /// </summary>
    public TerraformValue<bool> PreviewVersionWithServiceTermsAccepted
    {
        get => new TerraformReference<bool>(this, "preview_version_with_service_terms_accepted");
    }

    /// <summary>
    /// The private_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrivateEndpoint
    {
        get => new TerraformReference<string>(this, "private_endpoint");
    }

    /// <summary>
    /// The private_endpoint_ip attribute.
    /// </summary>
    public TerraformValue<string> PrivateEndpointIp
    {
        get => new TerraformReference<string>(this, "private_endpoint_ip");
    }

    /// <summary>
    /// The private_endpoint_label attribute.
    /// </summary>
    public TerraformValue<string> PrivateEndpointLabel
    {
        get => new TerraformReference<string>(this, "private_endpoint_label");
    }

    /// <summary>
    /// The provisionable_cpus attribute.
    /// </summary>
    public TerraformList<double> ProvisionableCpus
    {
        get => TerraformList<double>.Lazy(ctx => new TerraformReference<TerraformList<double>>(this, "provisionable_cpus").ResolveNodes(ctx));
    }

    /// <summary>
    /// The remote_data_guard_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RemoteDataGuardEnabled
    {
        get => new TerraformReference<bool>(this, "remote_data_guard_enabled");
    }

    /// <summary>
    /// The service_console_url attribute.
    /// </summary>
    public TerraformValue<string> ServiceConsoleUrl
    {
        get => new TerraformReference<string>(this, "service_console_url");
    }

    /// <summary>
    /// The sql_web_developer_url attribute.
    /// </summary>
    public TerraformValue<string> SqlWebDeveloperUrl
    {
        get => new TerraformReference<string>(this, "sql_web_developer_url");
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
    }

    /// <summary>
    /// The supported_regions_to_clone_to attribute.
    /// </summary>
    public TerraformList<string> SupportedRegionsToCloneTo
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "supported_regions_to_clone_to").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    public TerraformValue<string> TimeCreated
    {
        get => new TerraformReference<string>(this, "time_created");
    }

    /// <summary>
    /// The time_data_guard_role_changed attribute.
    /// </summary>
    public TerraformValue<string> TimeDataGuardRoleChanged
    {
        get => new TerraformReference<string>(this, "time_data_guard_role_changed");
    }

    /// <summary>
    /// The time_deletion_of_free_autonomous_database attribute.
    /// </summary>
    public TerraformValue<string> TimeDeletionOfFreeAutonomousDatabase
    {
        get => new TerraformReference<string>(this, "time_deletion_of_free_autonomous_database");
    }

    /// <summary>
    /// The time_local_data_guard_enabled_on attribute.
    /// </summary>
    public TerraformValue<string> TimeLocalDataGuardEnabledOn
    {
        get => new TerraformReference<string>(this, "time_local_data_guard_enabled_on");
    }

    /// <summary>
    /// The time_maintenance_begin attribute.
    /// </summary>
    public TerraformValue<string> TimeMaintenanceBegin
    {
        get => new TerraformReference<string>(this, "time_maintenance_begin");
    }

    /// <summary>
    /// The time_maintenance_end attribute.
    /// </summary>
    public TerraformValue<string> TimeMaintenanceEnd
    {
        get => new TerraformReference<string>(this, "time_maintenance_end");
    }

    /// <summary>
    /// The time_of_last_failover attribute.
    /// </summary>
    public TerraformValue<string> TimeOfLastFailover
    {
        get => new TerraformReference<string>(this, "time_of_last_failover");
    }

    /// <summary>
    /// The time_of_last_refresh attribute.
    /// </summary>
    public TerraformValue<string> TimeOfLastRefresh
    {
        get => new TerraformReference<string>(this, "time_of_last_refresh");
    }

    /// <summary>
    /// The time_of_last_refresh_point attribute.
    /// </summary>
    public TerraformValue<string> TimeOfLastRefreshPoint
    {
        get => new TerraformReference<string>(this, "time_of_last_refresh_point");
    }

    /// <summary>
    /// The time_of_last_switchover attribute.
    /// </summary>
    public TerraformValue<string> TimeOfLastSwitchover
    {
        get => new TerraformReference<string>(this, "time_of_last_switchover");
    }

    /// <summary>
    /// The time_reclamation_of_free_autonomous_database attribute.
    /// </summary>
    public TerraformValue<string> TimeReclamationOfFreeAutonomousDatabase
    {
        get => new TerraformReference<string>(this, "time_reclamation_of_free_autonomous_database");
    }

    /// <summary>
    /// The used_data_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> UsedDataStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "used_data_storage_size_in_gbs");
    }

    /// <summary>
    /// The used_data_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformValue<double> UsedDataStorageSizeInTbs
    {
        get => new TerraformReference<double>(this, "used_data_storage_size_in_tbs");
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualNetworkId
    {
        get => new TerraformReference<string>(this, "virtual_network_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOracleAutonomousDatabaseDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOracleAutonomousDatabaseDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
