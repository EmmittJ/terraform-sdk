using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "read");
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
    /// The actual_used_data_storage_size_in_tb attribute.
    /// </summary>
    public TerraformValue<double> ActualUsedDataStorageSizeInTb
    {
        get => new TerraformReference<double>(this, "actual_used_data_storage_size_in_tb");
    }

    /// <summary>
    /// The allocated_storage_size_in_tb attribute.
    /// </summary>
    public TerraformValue<double> AllocatedStorageSizeInTb
    {
        get => new TerraformReference<double>(this, "allocated_storage_size_in_tb");
    }

    /// <summary>
    /// The allowed_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> AllowedIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_ip_addresses").ResolveNodes(ctx));
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
    /// The compute_model attribute.
    /// </summary>
    public TerraformValue<string> ComputeModel
    {
        get => new TerraformReference<string>(this, "compute_model");
    }

    /// <summary>
    /// The connection_strings attribute.
    /// </summary>
    public TerraformList<string> ConnectionStrings
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "connection_strings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    public TerraformValue<double> CpuCoreCount
    {
        get => new TerraformReference<double>(this, "cpu_core_count");
    }

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    public TerraformList<string> CustomerContacts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "customer_contacts").ResolveNodes(ctx));
    }

    /// <summary>
    /// The data_storage_size_in_gb attribute.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInGb
    {
        get => new TerraformReference<double>(this, "data_storage_size_in_gb");
    }

    /// <summary>
    /// The data_storage_size_in_tb attribute.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInTb
    {
        get => new TerraformReference<double>(this, "data_storage_size_in_tb");
    }

    /// <summary>
    /// The database_version attribute.
    /// </summary>
    public TerraformValue<string> DatabaseVersion
    {
        get => new TerraformReference<string>(this, "database_version");
    }

    /// <summary>
    /// The database_workload attribute.
    /// </summary>
    public TerraformValue<string> DatabaseWorkload
    {
        get => new TerraformReference<string>(this, "database_workload");
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
    /// The in_memory_area_in_gb attribute.
    /// </summary>
    public TerraformValue<double> InMemoryAreaInGb
    {
        get => new TerraformReference<double>(this, "in_memory_area_in_gb");
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformValue<string> LicenseModel
    {
        get => new TerraformReference<string>(this, "license_model");
    }

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    public TerraformValue<string> LifecycleDetails
    {
        get => new TerraformReference<string>(this, "lifecycle_details");
    }

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    public TerraformValue<string> LifecycleState
    {
        get => new TerraformReference<string>(this, "lifecycle_state");
    }

    /// <summary>
    /// The local_adg_auto_failover_max_data_loss_limit_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> LocalAdgAutoFailoverMaxDataLossLimitInSeconds
    {
        get => new TerraformReference<double>(this, "local_adg_auto_failover_max_data_loss_limit_in_seconds");
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
    /// The memory_per_oracle_compute_unit_in_gb attribute.
    /// </summary>
    public TerraformValue<double> MemoryPerOracleComputeUnitInGb
    {
        get => new TerraformReference<double>(this, "memory_per_oracle_compute_unit_in_gb");
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
    /// The next_long_term_backup_timestamp attribute.
    /// </summary>
    public TerraformValue<string> NextLongTermBackupTimestamp
    {
        get => new TerraformReference<string>(this, "next_long_term_backup_timestamp");
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
    /// The peer_database_ids attribute.
    /// </summary>
    public TerraformList<string> PeerDatabaseIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "peer_database_ids").ResolveNodes(ctx));
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
    /// The private_endpoint_url attribute.
    /// </summary>
    public TerraformValue<string> PrivateEndpointUrl
    {
        get => new TerraformReference<string>(this, "private_endpoint_url");
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
    /// The source_autonomous_database_id attribute.
    /// </summary>
    public TerraformValue<string> SourceAutonomousDatabaseId
    {
        get => new TerraformReference<string>(this, "source_autonomous_database_id");
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
    /// The time_created_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeCreatedInUtc
    {
        get => new TerraformReference<string>(this, "time_created_in_utc");
    }

    /// <summary>
    /// The time_data_guard_role_changed_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeDataGuardRoleChangedInUtc
    {
        get => new TerraformReference<string>(this, "time_data_guard_role_changed_in_utc");
    }

    /// <summary>
    /// The time_deletion_of_free_autonomous_database_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeDeletionOfFreeAutonomousDatabaseInUtc
    {
        get => new TerraformReference<string>(this, "time_deletion_of_free_autonomous_database_in_utc");
    }

    /// <summary>
    /// The time_local_data_guard_enabled_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeLocalDataGuardEnabledInUtc
    {
        get => new TerraformReference<string>(this, "time_local_data_guard_enabled_in_utc");
    }

    /// <summary>
    /// The time_maintenance_begin_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeMaintenanceBeginInUtc
    {
        get => new TerraformReference<string>(this, "time_maintenance_begin_in_utc");
    }

    /// <summary>
    /// The time_maintenance_end_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeMaintenanceEndInUtc
    {
        get => new TerraformReference<string>(this, "time_maintenance_end_in_utc");
    }

    /// <summary>
    /// The time_of_last_failover_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeOfLastFailoverInUtc
    {
        get => new TerraformReference<string>(this, "time_of_last_failover_in_utc");
    }

    /// <summary>
    /// The time_of_last_refresh_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeOfLastRefreshInUtc
    {
        get => new TerraformReference<string>(this, "time_of_last_refresh_in_utc");
    }

    /// <summary>
    /// The time_of_last_refresh_point_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeOfLastRefreshPointInUtc
    {
        get => new TerraformReference<string>(this, "time_of_last_refresh_point_in_utc");
    }

    /// <summary>
    /// The time_of_last_switchover_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeOfLastSwitchoverInUtc
    {
        get => new TerraformReference<string>(this, "time_of_last_switchover_in_utc");
    }

    /// <summary>
    /// The time_reclamation_of_free_autonomous_database_in_utc attribute.
    /// </summary>
    public TerraformValue<string> TimeReclamationOfFreeAutonomousDatabaseInUtc
    {
        get => new TerraformReference<string>(this, "time_reclamation_of_free_autonomous_database_in_utc");
    }

    /// <summary>
    /// The used_data_storage_size_in_gb attribute.
    /// </summary>
    public TerraformValue<double> UsedDataStorageSizeInGb
    {
        get => new TerraformReference<double>(this, "used_data_storage_size_in_gb");
    }

    /// <summary>
    /// The used_data_storage_size_in_tb attribute.
    /// </summary>
    public TerraformValue<double> UsedDataStorageSizeInTb
    {
        get => new TerraformReference<double>(this, "used_data_storage_size_in_tb");
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
    public AzurermOracleAutonomousDatabaseCloneFromBackupDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOracleAutonomousDatabaseCloneFromBackupDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
