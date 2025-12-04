using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermOracleAutonomousDatabaseCloneFromBackupDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermOracleAutonomousDatabaseCloneFromBackupDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_oracle_autonomous_database_clone_from_backup Terraform data source.
/// Retrieves information about a azurerm_oracle_autonomous_database_clone_from_backup.
/// </summary>
public partial class AzurermOracleAutonomousDatabaseCloneFromBackupDataSource(string name) : TerraformDataSource("azurerm_oracle_autonomous_database_clone_from_backup", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
        => AsReference("actual_used_data_storage_size_in_tb");

    /// <summary>
    /// The allocated_storage_size_in_tb attribute.
    /// </summary>
    public TerraformValue<double> AllocatedStorageSizeInTb
        => AsReference("allocated_storage_size_in_tb");

    /// <summary>
    /// The allowed_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> AllowedIpAddresses
        => AsReference("allowed_ip_addresses");

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AutoScalingEnabled
        => AsReference("auto_scaling_enabled");

    /// <summary>
    /// The auto_scaling_for_storage_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AutoScalingForStorageEnabled
        => AsReference("auto_scaling_for_storage_enabled");

    /// <summary>
    /// The available_upgrade_versions attribute.
    /// </summary>
    public TerraformList<string> AvailableUpgradeVersions
        => AsReference("available_upgrade_versions");

    /// <summary>
    /// The backup_retention_period_in_days attribute.
    /// </summary>
    public TerraformValue<double> BackupRetentionPeriodInDays
        => AsReference("backup_retention_period_in_days");

    /// <summary>
    /// The character_set attribute.
    /// </summary>
    public TerraformValue<string> CharacterSet
        => AsReference("character_set");

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    public TerraformValue<double> ComputeCount
        => AsReference("compute_count");

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    public TerraformValue<string> ComputeModel
        => AsReference("compute_model");

    /// <summary>
    /// The connection_strings attribute.
    /// </summary>
    public TerraformList<string> ConnectionStrings
        => AsReference("connection_strings");

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    public TerraformValue<double> CpuCoreCount
        => AsReference("cpu_core_count");

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    public TerraformList<string> CustomerContacts
        => AsReference("customer_contacts");

    /// <summary>
    /// The data_storage_size_in_gb attribute.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInGb
        => AsReference("data_storage_size_in_gb");

    /// <summary>
    /// The data_storage_size_in_tb attribute.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInTb
        => AsReference("data_storage_size_in_tb");

    /// <summary>
    /// The database_version attribute.
    /// </summary>
    public TerraformValue<string> DatabaseVersion
        => AsReference("database_version");

    /// <summary>
    /// The database_workload attribute.
    /// </summary>
    public TerraformValue<string> DatabaseWorkload
        => AsReference("database_workload");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The failed_data_recovery_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> FailedDataRecoveryInSeconds
        => AsReference("failed_data_recovery_in_seconds");

    /// <summary>
    /// The in_memory_area_in_gb attribute.
    /// </summary>
    public TerraformValue<double> InMemoryAreaInGb
        => AsReference("in_memory_area_in_gb");

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformValue<string> LicenseModel
        => AsReference("license_model");

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    public TerraformValue<string> LifecycleDetails
        => AsReference("lifecycle_details");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    public TerraformValue<string> LifecycleState
        => AsReference("lifecycle_state");

    /// <summary>
    /// The local_adg_auto_failover_max_data_loss_limit_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> LocalAdgAutoFailoverMaxDataLossLimitInSeconds
        => AsReference("local_adg_auto_failover_max_data_loss_limit_in_seconds");

    /// <summary>
    /// The local_data_guard_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LocalDataGuardEnabled
        => AsReference("local_data_guard_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The long_term_backup_schedule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LongTermBackupSchedule
        => AsReference("long_term_backup_schedule");

    /// <summary>
    /// The memory_per_oracle_compute_unit_in_gb attribute.
    /// </summary>
    public TerraformValue<double> MemoryPerOracleComputeUnitInGb
        => AsReference("memory_per_oracle_compute_unit_in_gb");

    /// <summary>
    /// The mtls_connection_required attribute.
    /// </summary>
    public TerraformValue<bool> MtlsConnectionRequired
        => AsReference("mtls_connection_required");

    /// <summary>
    /// The national_character_set attribute.
    /// </summary>
    public TerraformValue<string> NationalCharacterSet
        => AsReference("national_character_set");

    /// <summary>
    /// The next_long_term_backup_timestamp attribute.
    /// </summary>
    public TerraformValue<string> NextLongTermBackupTimestamp
        => AsReference("next_long_term_backup_timestamp");

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    public TerraformValue<string> OciUrl
        => AsReference("oci_url");

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    public TerraformValue<string> Ocid
        => AsReference("ocid");

    /// <summary>
    /// The peer_database_ids attribute.
    /// </summary>
    public TerraformList<string> PeerDatabaseIds
        => AsReference("peer_database_ids");

    /// <summary>
    /// The preview attribute.
    /// </summary>
    public TerraformValue<bool> Preview
        => AsReference("preview");

    /// <summary>
    /// The preview_version_with_service_terms_accepted attribute.
    /// </summary>
    public TerraformValue<bool> PreviewVersionWithServiceTermsAccepted
        => AsReference("preview_version_with_service_terms_accepted");

    /// <summary>
    /// The private_endpoint_ip attribute.
    /// </summary>
    public TerraformValue<string> PrivateEndpointIp
        => AsReference("private_endpoint_ip");

    /// <summary>
    /// The private_endpoint_label attribute.
    /// </summary>
    public TerraformValue<string> PrivateEndpointLabel
        => AsReference("private_endpoint_label");

    /// <summary>
    /// The private_endpoint_url attribute.
    /// </summary>
    public TerraformValue<string> PrivateEndpointUrl
        => AsReference("private_endpoint_url");

    /// <summary>
    /// The provisionable_cpus attribute.
    /// </summary>
    public TerraformList<double> ProvisionableCpus
        => AsReference("provisionable_cpus");

    /// <summary>
    /// The remote_data_guard_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RemoteDataGuardEnabled
        => AsReference("remote_data_guard_enabled");

    /// <summary>
    /// The service_console_url attribute.
    /// </summary>
    public TerraformValue<string> ServiceConsoleUrl
        => AsReference("service_console_url");

    /// <summary>
    /// The source_autonomous_database_id attribute.
    /// </summary>
    public TerraformValue<string> SourceAutonomousDatabaseId
        => AsReference("source_autonomous_database_id");

    /// <summary>
    /// The sql_web_developer_url attribute.
    /// </summary>
    public TerraformValue<string> SqlWebDeveloperUrl
        => AsReference("sql_web_developer_url");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
        => AsReference("subnet_id");

    /// <summary>
    /// The supported_regions_to_clone_to attribute.
    /// </summary>
    public TerraformList<string> SupportedRegionsToCloneTo
        => AsReference("supported_regions_to_clone_to");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The time_created_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeCreatedInUtc
        => AsReference("time_created_in_utc");

    /// <summary>
    /// The time_data_guard_role_changed_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeDataGuardRoleChangedInUtc
        => AsReference("time_data_guard_role_changed_in_utc");

    /// <summary>
    /// The time_deletion_of_free_autonomous_database_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeDeletionOfFreeAutonomousDatabaseInUtc
        => AsReference("time_deletion_of_free_autonomous_database_in_utc");

    /// <summary>
    /// The time_local_data_guard_enabled_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeLocalDataGuardEnabledInUtc
        => AsReference("time_local_data_guard_enabled_in_utc");

    /// <summary>
    /// The time_maintenance_begin_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeMaintenanceBeginInUtc
        => AsReference("time_maintenance_begin_in_utc");

    /// <summary>
    /// The time_maintenance_end_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeMaintenanceEndInUtc
        => AsReference("time_maintenance_end_in_utc");

    /// <summary>
    /// The time_of_last_failover_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeOfLastFailoverInUtc
        => AsReference("time_of_last_failover_in_utc");

    /// <summary>
    /// The time_of_last_refresh_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeOfLastRefreshInUtc
        => AsReference("time_of_last_refresh_in_utc");

    /// <summary>
    /// The time_of_last_refresh_point_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeOfLastRefreshPointInUtc
        => AsReference("time_of_last_refresh_point_in_utc");

    /// <summary>
    /// The time_of_last_switchover_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeOfLastSwitchoverInUtc
        => AsReference("time_of_last_switchover_in_utc");

    /// <summary>
    /// The time_reclamation_of_free_autonomous_database_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeReclamationOfFreeAutonomousDatabaseInUtc
        => AsReference("time_reclamation_of_free_autonomous_database_in_utc");

    /// <summary>
    /// The used_data_storage_size_in_gb attribute.
    /// </summary>
    public TerraformValue<double> UsedDataStorageSizeInGb
        => AsReference("used_data_storage_size_in_gb");

    /// <summary>
    /// The used_data_storage_size_in_tb attribute.
    /// </summary>
    public TerraformValue<double> UsedDataStorageSizeInTb
        => AsReference("used_data_storage_size_in_tb");

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualNetworkId
        => AsReference("virtual_network_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOracleAutonomousDatabaseCloneFromBackupDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOracleAutonomousDatabaseCloneFromBackupDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
