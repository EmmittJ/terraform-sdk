using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleAutonomousDatabaseCloneFromBackupDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_autonomous_database_clone_from_backup.
/// </summary>
public class AzurermOracleAutonomousDatabaseCloneFromBackupDataSource : TerraformDataSource
{
    public AzurermOracleAutonomousDatabaseCloneFromBackupDataSource(string name) : base("azurerm_oracle_autonomous_database_clone_from_backup", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermOracleAutonomousDatabaseCloneFromBackupDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The actual_used_data_storage_size_in_tb attribute.
    /// </summary>
    [TerraformPropertyName("actual_used_data_storage_size_in_tb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ActualUsedDataStorageSizeInTb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "actual_used_data_storage_size_in_tb");

    /// <summary>
    /// The allocated_storage_size_in_tb attribute.
    /// </summary>
    [TerraformPropertyName("allocated_storage_size_in_tb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AllocatedStorageSizeInTb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "allocated_storage_size_in_tb");

    /// <summary>
    /// The allowed_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("allowed_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AllowedIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "allowed_ip_addresses");

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_scaling_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AutoScalingEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "auto_scaling_enabled");

    /// <summary>
    /// The auto_scaling_for_storage_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_scaling_for_storage_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AutoScalingForStorageEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "auto_scaling_for_storage_enabled");

    /// <summary>
    /// The available_upgrade_versions attribute.
    /// </summary>
    [TerraformPropertyName("available_upgrade_versions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AvailableUpgradeVersions => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "available_upgrade_versions");

    /// <summary>
    /// The backup_retention_period_in_days attribute.
    /// </summary>
    [TerraformPropertyName("backup_retention_period_in_days")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> BackupRetentionPeriodInDays => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "backup_retention_period_in_days");

    /// <summary>
    /// The character_set attribute.
    /// </summary>
    [TerraformPropertyName("character_set")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CharacterSet => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "character_set");

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    [TerraformPropertyName("compute_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ComputeCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "compute_count");

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    [TerraformPropertyName("compute_model")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ComputeModel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "compute_model");

    /// <summary>
    /// The connection_strings attribute.
    /// </summary>
    [TerraformPropertyName("connection_strings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ConnectionStrings => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "connection_strings");

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    [TerraformPropertyName("cpu_core_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CpuCoreCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "cpu_core_count");

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    [TerraformPropertyName("customer_contacts")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> CustomerContacts => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "customer_contacts");

    /// <summary>
    /// The data_storage_size_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_gb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DataStorageSizeInGb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "data_storage_size_in_gb");

    /// <summary>
    /// The data_storage_size_in_tb attribute.
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_tb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DataStorageSizeInTb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "data_storage_size_in_tb");

    /// <summary>
    /// The database_version attribute.
    /// </summary>
    [TerraformPropertyName("database_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DatabaseVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "database_version");

    /// <summary>
    /// The database_workload attribute.
    /// </summary>
    [TerraformPropertyName("database_workload")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DatabaseWorkload => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "database_workload");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The failed_data_recovery_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("failed_data_recovery_in_seconds")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> FailedDataRecoveryInSeconds => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "failed_data_recovery_in_seconds");

    /// <summary>
    /// The in_memory_area_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("in_memory_area_in_gb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> InMemoryAreaInGb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "in_memory_area_in_gb");

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformPropertyName("license_model")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LicenseModel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "license_model");

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LifecycleDetails => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lifecycle_details");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LifecycleState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lifecycle_state");

    /// <summary>
    /// The local_adg_auto_failover_max_data_loss_limit_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("local_adg_auto_failover_max_data_loss_limit_in_seconds")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> LocalAdgAutoFailoverMaxDataLossLimitInSeconds => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "local_adg_auto_failover_max_data_loss_limit_in_seconds");

    /// <summary>
    /// The local_data_guard_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_data_guard_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> LocalDataGuardEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "local_data_guard_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The long_term_backup_schedule attribute.
    /// </summary>
    [TerraformPropertyName("long_term_backup_schedule")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LongTermBackupSchedule => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "long_term_backup_schedule");

    /// <summary>
    /// The memory_per_oracle_compute_unit_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("memory_per_oracle_compute_unit_in_gb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MemoryPerOracleComputeUnitInGb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "memory_per_oracle_compute_unit_in_gb");

    /// <summary>
    /// The mtls_connection_required attribute.
    /// </summary>
    [TerraformPropertyName("mtls_connection_required")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> MtlsConnectionRequired => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "mtls_connection_required");

    /// <summary>
    /// The national_character_set attribute.
    /// </summary>
    [TerraformPropertyName("national_character_set")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NationalCharacterSet => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "national_character_set");

    /// <summary>
    /// The next_long_term_backup_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("next_long_term_backup_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NextLongTermBackupTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "next_long_term_backup_timestamp");

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    [TerraformPropertyName("oci_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oci_url");

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ocid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ocid");

    /// <summary>
    /// The peer_database_ids attribute.
    /// </summary>
    [TerraformPropertyName("peer_database_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> PeerDatabaseIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "peer_database_ids");

    /// <summary>
    /// The preview attribute.
    /// </summary>
    [TerraformPropertyName("preview")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Preview => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "preview");

    /// <summary>
    /// The preview_version_with_service_terms_accepted attribute.
    /// </summary>
    [TerraformPropertyName("preview_version_with_service_terms_accepted")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PreviewVersionWithServiceTermsAccepted => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "preview_version_with_service_terms_accepted");

    /// <summary>
    /// The private_endpoint_ip attribute.
    /// </summary>
    [TerraformPropertyName("private_endpoint_ip")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateEndpointIp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_endpoint_ip");

    /// <summary>
    /// The private_endpoint_label attribute.
    /// </summary>
    [TerraformPropertyName("private_endpoint_label")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateEndpointLabel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_endpoint_label");

    /// <summary>
    /// The private_endpoint_url attribute.
    /// </summary>
    [TerraformPropertyName("private_endpoint_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateEndpointUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_endpoint_url");

    /// <summary>
    /// The provisionable_cpus attribute.
    /// </summary>
    [TerraformPropertyName("provisionable_cpus")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<double>>> ProvisionableCpus => new TerraformReferenceProperty<List<TerraformProperty<double>>>(ResourceAddress, "provisionable_cpus");

    /// <summary>
    /// The remote_data_guard_enabled attribute.
    /// </summary>
    [TerraformPropertyName("remote_data_guard_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> RemoteDataGuardEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "remote_data_guard_enabled");

    /// <summary>
    /// The service_console_url attribute.
    /// </summary>
    [TerraformPropertyName("service_console_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceConsoleUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_console_url");

    /// <summary>
    /// The source_autonomous_database_id attribute.
    /// </summary>
    [TerraformPropertyName("source_autonomous_database_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceAutonomousDatabaseId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_autonomous_database_id");

    /// <summary>
    /// The sql_web_developer_url attribute.
    /// </summary>
    [TerraformPropertyName("sql_web_developer_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SqlWebDeveloperUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sql_web_developer_url");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SubnetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnet_id");

    /// <summary>
    /// The supported_regions_to_clone_to attribute.
    /// </summary>
    [TerraformPropertyName("supported_regions_to_clone_to")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SupportedRegionsToCloneTo => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "supported_regions_to_clone_to");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The time_created_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_created_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeCreatedInUtc => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_created_in_utc");

    /// <summary>
    /// The time_data_guard_role_changed_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_data_guard_role_changed_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeDataGuardRoleChangedInUtc => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_data_guard_role_changed_in_utc");

    /// <summary>
    /// The time_deletion_of_free_autonomous_database_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_deletion_of_free_autonomous_database_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeDeletionOfFreeAutonomousDatabaseInUtc => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_deletion_of_free_autonomous_database_in_utc");

    /// <summary>
    /// The time_local_data_guard_enabled_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_local_data_guard_enabled_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeLocalDataGuardEnabledInUtc => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_local_data_guard_enabled_in_utc");

    /// <summary>
    /// The time_maintenance_begin_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_maintenance_begin_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeMaintenanceBeginInUtc => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_maintenance_begin_in_utc");

    /// <summary>
    /// The time_maintenance_end_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_maintenance_end_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeMaintenanceEndInUtc => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_maintenance_end_in_utc");

    /// <summary>
    /// The time_of_last_failover_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_of_last_failover_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeOfLastFailoverInUtc => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_of_last_failover_in_utc");

    /// <summary>
    /// The time_of_last_refresh_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_of_last_refresh_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeOfLastRefreshInUtc => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_of_last_refresh_in_utc");

    /// <summary>
    /// The time_of_last_refresh_point_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_of_last_refresh_point_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeOfLastRefreshPointInUtc => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_of_last_refresh_point_in_utc");

    /// <summary>
    /// The time_of_last_switchover_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_of_last_switchover_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeOfLastSwitchoverInUtc => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_of_last_switchover_in_utc");

    /// <summary>
    /// The time_reclamation_of_free_autonomous_database_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_reclamation_of_free_autonomous_database_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeReclamationOfFreeAutonomousDatabaseInUtc => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_reclamation_of_free_autonomous_database_in_utc");

    /// <summary>
    /// The used_data_storage_size_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("used_data_storage_size_in_gb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> UsedDataStorageSizeInGb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "used_data_storage_size_in_gb");

    /// <summary>
    /// The used_data_storage_size_in_tb attribute.
    /// </summary>
    [TerraformPropertyName("used_data_storage_size_in_tb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> UsedDataStorageSizeInTb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "used_data_storage_size_in_tb");

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VirtualNetworkId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "virtual_network_id");

}
