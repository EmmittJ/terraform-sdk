using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermOracleAutonomousDatabaseCloneFromDatabaseDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermOracleAutonomousDatabaseCloneFromDatabaseDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_oracle_autonomous_database_clone_from_database Terraform data source.
/// Retrieves information about a azurerm_oracle_autonomous_database_clone_from_database.
/// </summary>
public partial class AzurermOracleAutonomousDatabaseCloneFromDatabaseDataSource(string name) : TerraformDataSource("azurerm_oracle_autonomous_database_clone_from_database", name)
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
    /// The actual_used_data_storage_size_in_tb attribute.
    /// </summary>
    public TerraformValue<double> ActualUsedDataStorageSizeInTb
        => CreateReference("actual_used_data_storage_size_in_tb");

    /// <summary>
    /// The allocated_storage_size_in_tb attribute.
    /// </summary>
    public TerraformValue<double> AllocatedStorageSizeInTb
        => CreateReference("allocated_storage_size_in_tb");

    /// <summary>
    /// The allowed_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> AllowedIpAddresses
        => CreateReference("allowed_ip_addresses");

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
    /// The compute_model attribute.
    /// </summary>
    public TerraformValue<string> ComputeModel
        => CreateReference("compute_model");

    /// <summary>
    /// The connection_strings attribute.
    /// </summary>
    public TerraformList<string> ConnectionStrings
        => CreateReference("connection_strings");

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    public TerraformValue<double> CpuCoreCount
        => CreateReference("cpu_core_count");

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    public TerraformList<string> CustomerContacts
        => CreateReference("customer_contacts");

    /// <summary>
    /// The data_storage_size_in_gb attribute.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInGb
        => CreateReference("data_storage_size_in_gb");

    /// <summary>
    /// The data_storage_size_in_tb attribute.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInTb
        => CreateReference("data_storage_size_in_tb");

    /// <summary>
    /// The database_version attribute.
    /// </summary>
    public TerraformValue<string> DatabaseVersion
        => CreateReference("database_version");

    /// <summary>
    /// The database_workload attribute.
    /// </summary>
    public TerraformValue<string> DatabaseWorkload
        => CreateReference("database_workload");

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
    /// The in_memory_area_in_gb attribute.
    /// </summary>
    public TerraformValue<double> InMemoryAreaInGb
        => CreateReference("in_memory_area_in_gb");

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformValue<string> LicenseModel
        => CreateReference("license_model");

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    public TerraformValue<string> LifecycleDetails
        => CreateReference("lifecycle_details");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    public TerraformValue<string> LifecycleState
        => CreateReference("lifecycle_state");

    /// <summary>
    /// The local_adg_auto_failover_max_data_loss_limit_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> LocalAdgAutoFailoverMaxDataLossLimitInSeconds
        => CreateReference("local_adg_auto_failover_max_data_loss_limit_in_seconds");

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
    /// The memory_per_oracle_compute_unit_in_gb attribute.
    /// </summary>
    public TerraformValue<double> MemoryPerOracleComputeUnitInGb
        => CreateReference("memory_per_oracle_compute_unit_in_gb");

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
    /// The next_long_term_backup_timestamp attribute.
    /// </summary>
    public TerraformValue<string> NextLongTermBackupTimestamp
        => CreateReference("next_long_term_backup_timestamp");

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
    /// The peer_database_ids attribute.
    /// </summary>
    public TerraformList<string> PeerDatabaseIds
        => CreateReference("peer_database_ids");

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
    /// The private_endpoint_url attribute.
    /// </summary>
    public TerraformValue<string> PrivateEndpointUrl
        => CreateReference("private_endpoint_url");

    /// <summary>
    /// The provisionable_cpus attribute.
    /// </summary>
    public TerraformList<double> ProvisionableCpus
        => CreateReference("provisionable_cpus");

    /// <summary>
    /// The reconnect_clone_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ReconnectCloneEnabled
        => CreateReference("reconnect_clone_enabled");

    /// <summary>
    /// The refreshable_clone attribute.
    /// </summary>
    public TerraformValue<bool> RefreshableClone
        => CreateReference("refreshable_clone");

    /// <summary>
    /// The refreshable_status attribute.
    /// </summary>
    public TerraformValue<string> RefreshableStatus
        => CreateReference("refreshable_status");

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
    /// The source_autonomous_database_id attribute.
    /// </summary>
    public TerraformValue<string> SourceAutonomousDatabaseId
        => CreateReference("source_autonomous_database_id");

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
    /// The time_created_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeCreatedInUtc
        => CreateReference("time_created_in_utc");

    /// <summary>
    /// The time_data_guard_role_changed_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeDataGuardRoleChangedInUtc
        => CreateReference("time_data_guard_role_changed_in_utc");

    /// <summary>
    /// The time_deletion_of_free_autonomous_database_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeDeletionOfFreeAutonomousDatabaseInUtc
        => CreateReference("time_deletion_of_free_autonomous_database_in_utc");

    /// <summary>
    /// The time_local_data_guard_enabled_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeLocalDataGuardEnabledInUtc
        => CreateReference("time_local_data_guard_enabled_in_utc");

    /// <summary>
    /// The time_maintenance_begin_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeMaintenanceBeginInUtc
        => CreateReference("time_maintenance_begin_in_utc");

    /// <summary>
    /// The time_maintenance_end_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeMaintenanceEndInUtc
        => CreateReference("time_maintenance_end_in_utc");

    /// <summary>
    /// The time_of_last_failover_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeOfLastFailoverInUtc
        => CreateReference("time_of_last_failover_in_utc");

    /// <summary>
    /// The time_of_last_refresh_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeOfLastRefreshInUtc
        => CreateReference("time_of_last_refresh_in_utc");

    /// <summary>
    /// The time_of_last_refresh_point_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeOfLastRefreshPointInUtc
        => CreateReference("time_of_last_refresh_point_in_utc");

    /// <summary>
    /// The time_of_last_switchover_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeOfLastSwitchoverInUtc
        => CreateReference("time_of_last_switchover_in_utc");

    /// <summary>
    /// The time_reclamation_of_free_autonomous_database_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeReclamationOfFreeAutonomousDatabaseInUtc
        => CreateReference("time_reclamation_of_free_autonomous_database_in_utc");

    /// <summary>
    /// The time_until_reconnect_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeUntilReconnectInUtc
        => CreateReference("time_until_reconnect_in_utc");

    /// <summary>
    /// The used_data_storage_size_in_gb attribute.
    /// </summary>
    public TerraformValue<double> UsedDataStorageSizeInGb
        => CreateReference("used_data_storage_size_in_gb");

    /// <summary>
    /// The used_data_storage_size_in_tb attribute.
    /// </summary>
    public TerraformValue<double> UsedDataStorageSizeInTb
        => CreateReference("used_data_storage_size_in_tb");

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualNetworkId
        => CreateReference("virtual_network_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOracleAutonomousDatabaseCloneFromDatabaseDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOracleAutonomousDatabaseCloneFromDatabaseDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
