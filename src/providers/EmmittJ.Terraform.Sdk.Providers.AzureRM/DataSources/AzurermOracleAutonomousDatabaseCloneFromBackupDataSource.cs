using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleAutonomousDatabaseCloneFromBackupDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermOracleAutonomousDatabaseCloneFromBackupDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The actual_used_data_storage_size_in_tb attribute.
    /// </summary>
    [TerraformPropertyName("actual_used_data_storage_size_in_tb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ActualUsedDataStorageSizeInTb => new TerraformReference(this, "actual_used_data_storage_size_in_tb");

    /// <summary>
    /// The allocated_storage_size_in_tb attribute.
    /// </summary>
    [TerraformPropertyName("allocated_storage_size_in_tb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AllocatedStorageSizeInTb => new TerraformReference(this, "allocated_storage_size_in_tb");

    /// <summary>
    /// The allowed_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("allowed_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AllowedIpAddresses => new TerraformReference(this, "allowed_ip_addresses");

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_scaling_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AutoScalingEnabled => new TerraformReference(this, "auto_scaling_enabled");

    /// <summary>
    /// The auto_scaling_for_storage_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_scaling_for_storage_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AutoScalingForStorageEnabled => new TerraformReference(this, "auto_scaling_for_storage_enabled");

    /// <summary>
    /// The available_upgrade_versions attribute.
    /// </summary>
    [TerraformPropertyName("available_upgrade_versions")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AvailableUpgradeVersions => new TerraformReference(this, "available_upgrade_versions");

    /// <summary>
    /// The backup_retention_period_in_days attribute.
    /// </summary>
    [TerraformPropertyName("backup_retention_period_in_days")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> BackupRetentionPeriodInDays => new TerraformReference(this, "backup_retention_period_in_days");

    /// <summary>
    /// The character_set attribute.
    /// </summary>
    [TerraformPropertyName("character_set")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CharacterSet => new TerraformReference(this, "character_set");

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    [TerraformPropertyName("compute_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ComputeCount => new TerraformReference(this, "compute_count");

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    [TerraformPropertyName("compute_model")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ComputeModel => new TerraformReference(this, "compute_model");

    /// <summary>
    /// The connection_strings attribute.
    /// </summary>
    [TerraformPropertyName("connection_strings")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ConnectionStrings => new TerraformReference(this, "connection_strings");

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    [TerraformPropertyName("cpu_core_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> CpuCoreCount => new TerraformReference(this, "cpu_core_count");

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    [TerraformPropertyName("customer_contacts")]
    // Output-only attribute - read-only reference
    public TerraformList<string> CustomerContacts => new TerraformReference(this, "customer_contacts");

    /// <summary>
    /// The data_storage_size_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_gb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DataStorageSizeInGb => new TerraformReference(this, "data_storage_size_in_gb");

    /// <summary>
    /// The data_storage_size_in_tb attribute.
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_tb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DataStorageSizeInTb => new TerraformReference(this, "data_storage_size_in_tb");

    /// <summary>
    /// The database_version attribute.
    /// </summary>
    [TerraformPropertyName("database_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DatabaseVersion => new TerraformReference(this, "database_version");

    /// <summary>
    /// The database_workload attribute.
    /// </summary>
    [TerraformPropertyName("database_workload")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DatabaseWorkload => new TerraformReference(this, "database_workload");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// The failed_data_recovery_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("failed_data_recovery_in_seconds")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> FailedDataRecoveryInSeconds => new TerraformReference(this, "failed_data_recovery_in_seconds");

    /// <summary>
    /// The in_memory_area_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("in_memory_area_in_gb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> InMemoryAreaInGb => new TerraformReference(this, "in_memory_area_in_gb");

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformPropertyName("license_model")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LicenseModel => new TerraformReference(this, "license_model");

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_details")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LifecycleDetails => new TerraformReference(this, "lifecycle_details");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LifecycleState => new TerraformReference(this, "lifecycle_state");

    /// <summary>
    /// The local_adg_auto_failover_max_data_loss_limit_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("local_adg_auto_failover_max_data_loss_limit_in_seconds")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> LocalAdgAutoFailoverMaxDataLossLimitInSeconds => new TerraformReference(this, "local_adg_auto_failover_max_data_loss_limit_in_seconds");

    /// <summary>
    /// The local_data_guard_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_data_guard_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> LocalDataGuardEnabled => new TerraformReference(this, "local_data_guard_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The long_term_backup_schedule attribute.
    /// </summary>
    [TerraformPropertyName("long_term_backup_schedule")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LongTermBackupSchedule => new TerraformReference(this, "long_term_backup_schedule");

    /// <summary>
    /// The memory_per_oracle_compute_unit_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("memory_per_oracle_compute_unit_in_gb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MemoryPerOracleComputeUnitInGb => new TerraformReference(this, "memory_per_oracle_compute_unit_in_gb");

    /// <summary>
    /// The mtls_connection_required attribute.
    /// </summary>
    [TerraformPropertyName("mtls_connection_required")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> MtlsConnectionRequired => new TerraformReference(this, "mtls_connection_required");

    /// <summary>
    /// The national_character_set attribute.
    /// </summary>
    [TerraformPropertyName("national_character_set")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NationalCharacterSet => new TerraformReference(this, "national_character_set");

    /// <summary>
    /// The next_long_term_backup_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("next_long_term_backup_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NextLongTermBackupTimestamp => new TerraformReference(this, "next_long_term_backup_timestamp");

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    [TerraformPropertyName("oci_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OciUrl => new TerraformReference(this, "oci_url");

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ocid => new TerraformReference(this, "ocid");

    /// <summary>
    /// The peer_database_ids attribute.
    /// </summary>
    [TerraformPropertyName("peer_database_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> PeerDatabaseIds => new TerraformReference(this, "peer_database_ids");

    /// <summary>
    /// The preview attribute.
    /// </summary>
    [TerraformPropertyName("preview")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Preview => new TerraformReference(this, "preview");

    /// <summary>
    /// The preview_version_with_service_terms_accepted attribute.
    /// </summary>
    [TerraformPropertyName("preview_version_with_service_terms_accepted")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PreviewVersionWithServiceTermsAccepted => new TerraformReference(this, "preview_version_with_service_terms_accepted");

    /// <summary>
    /// The private_endpoint_ip attribute.
    /// </summary>
    [TerraformPropertyName("private_endpoint_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateEndpointIp => new TerraformReference(this, "private_endpoint_ip");

    /// <summary>
    /// The private_endpoint_label attribute.
    /// </summary>
    [TerraformPropertyName("private_endpoint_label")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateEndpointLabel => new TerraformReference(this, "private_endpoint_label");

    /// <summary>
    /// The private_endpoint_url attribute.
    /// </summary>
    [TerraformPropertyName("private_endpoint_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateEndpointUrl => new TerraformReference(this, "private_endpoint_url");

    /// <summary>
    /// The provisionable_cpus attribute.
    /// </summary>
    [TerraformPropertyName("provisionable_cpus")]
    // Output-only attribute - read-only reference
    public TerraformList<double> ProvisionableCpus => new TerraformReference(this, "provisionable_cpus");

    /// <summary>
    /// The remote_data_guard_enabled attribute.
    /// </summary>
    [TerraformPropertyName("remote_data_guard_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> RemoteDataGuardEnabled => new TerraformReference(this, "remote_data_guard_enabled");

    /// <summary>
    /// The service_console_url attribute.
    /// </summary>
    [TerraformPropertyName("service_console_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceConsoleUrl => new TerraformReference(this, "service_console_url");

    /// <summary>
    /// The source_autonomous_database_id attribute.
    /// </summary>
    [TerraformPropertyName("source_autonomous_database_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceAutonomousDatabaseId => new TerraformReference(this, "source_autonomous_database_id");

    /// <summary>
    /// The sql_web_developer_url attribute.
    /// </summary>
    [TerraformPropertyName("sql_web_developer_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SqlWebDeveloperUrl => new TerraformReference(this, "sql_web_developer_url");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SubnetId => new TerraformReference(this, "subnet_id");

    /// <summary>
    /// The supported_regions_to_clone_to attribute.
    /// </summary>
    [TerraformPropertyName("supported_regions_to_clone_to")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SupportedRegionsToCloneTo => new TerraformReference(this, "supported_regions_to_clone_to");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The time_created_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_created_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeCreatedInUtc => new TerraformReference(this, "time_created_in_utc");

    /// <summary>
    /// The time_data_guard_role_changed_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_data_guard_role_changed_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeDataGuardRoleChangedInUtc => new TerraformReference(this, "time_data_guard_role_changed_in_utc");

    /// <summary>
    /// The time_deletion_of_free_autonomous_database_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_deletion_of_free_autonomous_database_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeDeletionOfFreeAutonomousDatabaseInUtc => new TerraformReference(this, "time_deletion_of_free_autonomous_database_in_utc");

    /// <summary>
    /// The time_local_data_guard_enabled_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_local_data_guard_enabled_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeLocalDataGuardEnabledInUtc => new TerraformReference(this, "time_local_data_guard_enabled_in_utc");

    /// <summary>
    /// The time_maintenance_begin_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_maintenance_begin_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeMaintenanceBeginInUtc => new TerraformReference(this, "time_maintenance_begin_in_utc");

    /// <summary>
    /// The time_maintenance_end_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_maintenance_end_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeMaintenanceEndInUtc => new TerraformReference(this, "time_maintenance_end_in_utc");

    /// <summary>
    /// The time_of_last_failover_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_of_last_failover_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeOfLastFailoverInUtc => new TerraformReference(this, "time_of_last_failover_in_utc");

    /// <summary>
    /// The time_of_last_refresh_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_of_last_refresh_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeOfLastRefreshInUtc => new TerraformReference(this, "time_of_last_refresh_in_utc");

    /// <summary>
    /// The time_of_last_refresh_point_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_of_last_refresh_point_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeOfLastRefreshPointInUtc => new TerraformReference(this, "time_of_last_refresh_point_in_utc");

    /// <summary>
    /// The time_of_last_switchover_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_of_last_switchover_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeOfLastSwitchoverInUtc => new TerraformReference(this, "time_of_last_switchover_in_utc");

    /// <summary>
    /// The time_reclamation_of_free_autonomous_database_in_utc attribute.
    /// </summary>
    [TerraformPropertyName("time_reclamation_of_free_autonomous_database_in_utc")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeReclamationOfFreeAutonomousDatabaseInUtc => new TerraformReference(this, "time_reclamation_of_free_autonomous_database_in_utc");

    /// <summary>
    /// The used_data_storage_size_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("used_data_storage_size_in_gb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> UsedDataStorageSizeInGb => new TerraformReference(this, "used_data_storage_size_in_gb");

    /// <summary>
    /// The used_data_storage_size_in_tb attribute.
    /// </summary>
    [TerraformPropertyName("used_data_storage_size_in_tb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> UsedDataStorageSizeInTb => new TerraformReference(this, "used_data_storage_size_in_tb");

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VirtualNetworkId => new TerraformReference(this, "virtual_network_id");

}
