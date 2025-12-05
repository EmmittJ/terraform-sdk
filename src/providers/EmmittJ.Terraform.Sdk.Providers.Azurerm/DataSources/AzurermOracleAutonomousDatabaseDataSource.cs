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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The actual_used_data_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformValue<double> ActualUsedDataStorageSizeInTbs
        => CreateReference("actual_used_data_storage_size_in_tbs");

    /// <summary>
    /// The allocated_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformValue<double> AllocatedStorageSizeInTbs
        => CreateReference("allocated_storage_size_in_tbs");

    /// <summary>
    /// The allowed_ips attribute.
    /// </summary>
    public TerraformList<double> AllowedIps
        => CreateReference("allowed_ips");

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AutoScalingEnabled
        => CreateReference("auto_scaling_enabled");

    /// <summary>
    /// The auto_scaling_for_storage_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AutoScalingForStorageEnabled
        => CreateReference("auto_scaling_for_storage_enabled");

    /// <summary>
    /// The autonomous_database_id attribute.
    /// </summary>
    public TerraformValue<string> AutonomousDatabaseId
        => CreateReference("autonomous_database_id");

    /// <summary>
    /// The available_upgrade_versions attribute.
    /// </summary>
    public TerraformList<string> AvailableUpgradeVersions
        => CreateReference("available_upgrade_versions");

    /// <summary>
    /// The backup_retention_period_in_days attribute.
    /// </summary>
    public TerraformValue<double> BackupRetentionPeriodInDays
        => CreateReference("backup_retention_period_in_days");

    /// <summary>
    /// The character_set attribute.
    /// </summary>
    public TerraformValue<string> CharacterSet
        => CreateReference("character_set");

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    public TerraformValue<double> ComputeCount
        => CreateReference("compute_count");

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    public TerraformValue<double> CpuCoreCount
        => CreateReference("cpu_core_count");

    /// <summary>
    /// The data_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInGbs
        => CreateReference("data_storage_size_in_gbs");

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInTbs
        => CreateReference("data_storage_size_in_tbs");

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> DbNodeStorageSizeInGbs
        => CreateReference("db_node_storage_size_in_gbs");

    /// <summary>
    /// The db_version attribute.
    /// </summary>
    public TerraformValue<string> DbVersion
        => CreateReference("db_version");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => CreateReference("display_name");

    /// <summary>
    /// The failed_data_recovery_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> FailedDataRecoveryInSeconds
        => CreateReference("failed_data_recovery_in_seconds");

    /// <summary>
    /// The in_memory_area_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> InMemoryAreaInGbs
        => CreateReference("in_memory_area_in_gbs");

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    public TerraformValue<string> LifecycleDetails
        => CreateReference("lifecycle_details");

    /// <summary>
    /// The local_adg_auto_failover_max_data_loss_limit attribute.
    /// </summary>
    public TerraformValue<double> LocalAdgAutoFailoverMaxDataLossLimit
        => CreateReference("local_adg_auto_failover_max_data_loss_limit");

    /// <summary>
    /// The local_data_guard_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LocalDataGuardEnabled
        => CreateReference("local_data_guard_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The long_term_backup_schedule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LongTermBackupSchedule
        => CreateReference("long_term_backup_schedule");

    /// <summary>
    /// The memory_per_oracle_compute_unit_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> MemoryPerOracleComputeUnitInGbs
        => CreateReference("memory_per_oracle_compute_unit_in_gbs");

    /// <summary>
    /// The mtls_connection_required attribute.
    /// </summary>
    public TerraformValue<bool> MtlsConnectionRequired
        => CreateReference("mtls_connection_required");

    /// <summary>
    /// The national_character_set attribute.
    /// </summary>
    public TerraformValue<string> NationalCharacterSet
        => CreateReference("national_character_set");

    /// <summary>
    /// The next_long_term_backup_time_stamp attribute.
    /// </summary>
    public TerraformValue<string> NextLongTermBackupTimeStamp
        => CreateReference("next_long_term_backup_time_stamp");

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    public TerraformValue<string> OciUrl
        => CreateReference("oci_url");

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    public TerraformValue<string> Ocid
        => CreateReference("ocid");

    /// <summary>
    /// The peer_db_id attribute.
    /// </summary>
    public TerraformValue<string> PeerDbId
        => CreateReference("peer_db_id");

    /// <summary>
    /// The peer_db_ids attribute.
    /// </summary>
    public TerraformList<string> PeerDbIds
        => CreateReference("peer_db_ids");

    /// <summary>
    /// The preview attribute.
    /// </summary>
    public TerraformValue<bool> Preview
        => CreateReference("preview");

    /// <summary>
    /// The preview_version_with_service_terms_accepted attribute.
    /// </summary>
    public TerraformValue<bool> PreviewVersionWithServiceTermsAccepted
        => CreateReference("preview_version_with_service_terms_accepted");

    /// <summary>
    /// The private_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrivateEndpoint
        => CreateReference("private_endpoint");

    /// <summary>
    /// The private_endpoint_ip attribute.
    /// </summary>
    public TerraformValue<string> PrivateEndpointIp
        => CreateReference("private_endpoint_ip");

    /// <summary>
    /// The private_endpoint_label attribute.
    /// </summary>
    public TerraformValue<string> PrivateEndpointLabel
        => CreateReference("private_endpoint_label");

    /// <summary>
    /// The provisionable_cpus attribute.
    /// </summary>
    public TerraformList<double> ProvisionableCpus
        => CreateReference("provisionable_cpus");

    /// <summary>
    /// The remote_data_guard_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RemoteDataGuardEnabled
        => CreateReference("remote_data_guard_enabled");

    /// <summary>
    /// The service_console_url attribute.
    /// </summary>
    public TerraformValue<string> ServiceConsoleUrl
        => CreateReference("service_console_url");

    /// <summary>
    /// The sql_web_developer_url attribute.
    /// </summary>
    public TerraformValue<string> SqlWebDeveloperUrl
        => CreateReference("sql_web_developer_url");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
        => CreateReference("subnet_id");

    /// <summary>
    /// The supported_regions_to_clone_to attribute.
    /// </summary>
    public TerraformList<string> SupportedRegionsToCloneTo
        => CreateReference("supported_regions_to_clone_to");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    public TerraformValue<string> TimeCreated
        => CreateReference("time_created");

    /// <summary>
    /// The time_data_guard_role_changed attribute.
    /// </summary>
    public TerraformValue<string> TimeDataGuardRoleChanged
        => CreateReference("time_data_guard_role_changed");

    /// <summary>
    /// The time_deletion_of_free_autonomous_database attribute.
    /// </summary>
    public TerraformValue<string> TimeDeletionOfFreeAutonomousDatabase
        => CreateReference("time_deletion_of_free_autonomous_database");

    /// <summary>
    /// The time_local_data_guard_enabled_on attribute.
    /// </summary>
    public TerraformValue<string> TimeLocalDataGuardEnabledOn
        => CreateReference("time_local_data_guard_enabled_on");

    /// <summary>
    /// The time_maintenance_begin attribute.
    /// </summary>
    public TerraformValue<string> TimeMaintenanceBegin
        => CreateReference("time_maintenance_begin");

    /// <summary>
    /// The time_maintenance_end attribute.
    /// </summary>
    public TerraformValue<string> TimeMaintenanceEnd
        => CreateReference("time_maintenance_end");

    /// <summary>
    /// The time_of_last_failover attribute.
    /// </summary>
    public TerraformValue<string> TimeOfLastFailover
        => CreateReference("time_of_last_failover");

    /// <summary>
    /// The time_of_last_refresh attribute.
    /// </summary>
    public TerraformValue<string> TimeOfLastRefresh
        => CreateReference("time_of_last_refresh");

    /// <summary>
    /// The time_of_last_refresh_point attribute.
    /// </summary>
    public TerraformValue<string> TimeOfLastRefreshPoint
        => CreateReference("time_of_last_refresh_point");

    /// <summary>
    /// The time_of_last_switchover attribute.
    /// </summary>
    public TerraformValue<string> TimeOfLastSwitchover
        => CreateReference("time_of_last_switchover");

    /// <summary>
    /// The time_reclamation_of_free_autonomous_database attribute.
    /// </summary>
    public TerraformValue<string> TimeReclamationOfFreeAutonomousDatabase
        => CreateReference("time_reclamation_of_free_autonomous_database");

    /// <summary>
    /// The used_data_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> UsedDataStorageSizeInGbs
        => CreateReference("used_data_storage_size_in_gbs");

    /// <summary>
    /// The used_data_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformValue<double> UsedDataStorageSizeInTbs
        => CreateReference("used_data_storage_size_in_tbs");

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualNetworkId
        => CreateReference("virtual_network_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOracleAutonomousDatabaseDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOracleAutonomousDatabaseDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
