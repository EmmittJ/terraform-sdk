using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermOracleAutonomousDatabaseCloneFromDatabaseDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_autonomous_database_clone_from_database.
/// </summary>
public partial class AzurermOracleAutonomousDatabaseCloneFromDatabaseDataSource : TerraformDataSource
{
    public AzurermOracleAutonomousDatabaseCloneFromDatabaseDataSource(string name) : base("azurerm_oracle_autonomous_database_clone_from_database", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermOracleAutonomousDatabaseCloneFromDatabaseDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The actual_used_data_storage_size_in_tb attribute.
    /// </summary>
    [TerraformProperty("actual_used_data_storage_size_in_tb")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ActualUsedDataStorageSizeInTb { get; }

    /// <summary>
    /// The allocated_storage_size_in_tb attribute.
    /// </summary>
    [TerraformProperty("allocated_storage_size_in_tb")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> AllocatedStorageSizeInTb { get; }

    /// <summary>
    /// The allowed_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("allowed_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AllowedIpAddresses { get; }

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_scaling_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AutoScalingEnabled { get; }

    /// <summary>
    /// The auto_scaling_for_storage_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_scaling_for_storage_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AutoScalingForStorageEnabled { get; }

    /// <summary>
    /// The available_upgrade_versions attribute.
    /// </summary>
    [TerraformProperty("available_upgrade_versions")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AvailableUpgradeVersions { get; }

    /// <summary>
    /// The backup_retention_period_in_days attribute.
    /// </summary>
    [TerraformProperty("backup_retention_period_in_days")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> BackupRetentionPeriodInDays { get; }

    /// <summary>
    /// The character_set attribute.
    /// </summary>
    [TerraformProperty("character_set")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CharacterSet { get; }

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    [TerraformProperty("compute_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ComputeCount { get; }

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    [TerraformProperty("compute_model")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ComputeModel { get; }

    /// <summary>
    /// The connection_strings attribute.
    /// </summary>
    [TerraformProperty("connection_strings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ConnectionStrings { get; }

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    [TerraformProperty("cpu_core_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> CpuCoreCount { get; }

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    [TerraformProperty("customer_contacts")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> CustomerContacts { get; }

    /// <summary>
    /// The data_storage_size_in_gb attribute.
    /// </summary>
    [TerraformProperty("data_storage_size_in_gb")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DataStorageSizeInGb { get; }

    /// <summary>
    /// The data_storage_size_in_tb attribute.
    /// </summary>
    [TerraformProperty("data_storage_size_in_tb")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DataStorageSizeInTb { get; }

    /// <summary>
    /// The database_version attribute.
    /// </summary>
    [TerraformProperty("database_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DatabaseVersion { get; }

    /// <summary>
    /// The database_workload attribute.
    /// </summary>
    [TerraformProperty("database_workload")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DatabaseWorkload { get; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The failed_data_recovery_in_seconds attribute.
    /// </summary>
    [TerraformProperty("failed_data_recovery_in_seconds")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> FailedDataRecoveryInSeconds { get; }

    /// <summary>
    /// The in_memory_area_in_gb attribute.
    /// </summary>
    [TerraformProperty("in_memory_area_in_gb")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> InMemoryAreaInGb { get; }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformProperty("license_model")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LicenseModel { get; }

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    [TerraformProperty("lifecycle_details")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LifecycleDetails { get; }

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformProperty("lifecycle_state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LifecycleState { get; }

    /// <summary>
    /// The local_adg_auto_failover_max_data_loss_limit_in_seconds attribute.
    /// </summary>
    [TerraformProperty("local_adg_auto_failover_max_data_loss_limit_in_seconds")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> LocalAdgAutoFailoverMaxDataLossLimitInSeconds { get; }

    /// <summary>
    /// The local_data_guard_enabled attribute.
    /// </summary>
    [TerraformProperty("local_data_guard_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> LocalDataGuardEnabled { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The long_term_backup_schedule attribute.
    /// </summary>
    [TerraformProperty("long_term_backup_schedule")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> LongTermBackupSchedule { get; }

    /// <summary>
    /// The memory_per_oracle_compute_unit_in_gb attribute.
    /// </summary>
    [TerraformProperty("memory_per_oracle_compute_unit_in_gb")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MemoryPerOracleComputeUnitInGb { get; }

    /// <summary>
    /// The mtls_connection_required attribute.
    /// </summary>
    [TerraformProperty("mtls_connection_required")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> MtlsConnectionRequired { get; }

    /// <summary>
    /// The national_character_set attribute.
    /// </summary>
    [TerraformProperty("national_character_set")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NationalCharacterSet { get; }

    /// <summary>
    /// The next_long_term_backup_timestamp attribute.
    /// </summary>
    [TerraformProperty("next_long_term_backup_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NextLongTermBackupTimestamp { get; }

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    [TerraformProperty("oci_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OciUrl { get; }

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    [TerraformProperty("ocid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Ocid { get; }

    /// <summary>
    /// The peer_database_ids attribute.
    /// </summary>
    [TerraformProperty("peer_database_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> PeerDatabaseIds { get; }

    /// <summary>
    /// The preview attribute.
    /// </summary>
    [TerraformProperty("preview")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Preview { get; }

    /// <summary>
    /// The preview_version_with_service_terms_accepted attribute.
    /// </summary>
    [TerraformProperty("preview_version_with_service_terms_accepted")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> PreviewVersionWithServiceTermsAccepted { get; }

    /// <summary>
    /// The private_endpoint_ip attribute.
    /// </summary>
    [TerraformProperty("private_endpoint_ip")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrivateEndpointIp { get; }

    /// <summary>
    /// The private_endpoint_label attribute.
    /// </summary>
    [TerraformProperty("private_endpoint_label")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrivateEndpointLabel { get; }

    /// <summary>
    /// The private_endpoint_url attribute.
    /// </summary>
    [TerraformProperty("private_endpoint_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrivateEndpointUrl { get; }

    /// <summary>
    /// The provisionable_cpus attribute.
    /// </summary>
    [TerraformProperty("provisionable_cpus")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<double> ProvisionableCpus { get; }

    /// <summary>
    /// The reconnect_clone_enabled attribute.
    /// </summary>
    [TerraformProperty("reconnect_clone_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ReconnectCloneEnabled { get; }

    /// <summary>
    /// The refreshable_clone attribute.
    /// </summary>
    [TerraformProperty("refreshable_clone")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> RefreshableClone { get; }

    /// <summary>
    /// The refreshable_status attribute.
    /// </summary>
    [TerraformProperty("refreshable_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RefreshableStatus { get; }

    /// <summary>
    /// The remote_data_guard_enabled attribute.
    /// </summary>
    [TerraformProperty("remote_data_guard_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> RemoteDataGuardEnabled { get; }

    /// <summary>
    /// The service_console_url attribute.
    /// </summary>
    [TerraformProperty("service_console_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceConsoleUrl { get; }

    /// <summary>
    /// The source_autonomous_database_id attribute.
    /// </summary>
    [TerraformProperty("source_autonomous_database_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SourceAutonomousDatabaseId { get; }

    /// <summary>
    /// The sql_web_developer_url attribute.
    /// </summary>
    [TerraformProperty("sql_web_developer_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SqlWebDeveloperUrl { get; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SubnetId { get; }

    /// <summary>
    /// The supported_regions_to_clone_to attribute.
    /// </summary>
    [TerraformProperty("supported_regions_to_clone_to")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> SupportedRegionsToCloneTo { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The time_created_in_utc attribute.
    /// </summary>
    [TerraformProperty("time_created_in_utc")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeCreatedInUtc { get; }

    /// <summary>
    /// The time_data_guard_role_changed_in_utc attribute.
    /// </summary>
    [TerraformProperty("time_data_guard_role_changed_in_utc")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeDataGuardRoleChangedInUtc { get; }

    /// <summary>
    /// The time_deletion_of_free_autonomous_database_in_utc attribute.
    /// </summary>
    [TerraformProperty("time_deletion_of_free_autonomous_database_in_utc")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeDeletionOfFreeAutonomousDatabaseInUtc { get; }

    /// <summary>
    /// The time_local_data_guard_enabled_in_utc attribute.
    /// </summary>
    [TerraformProperty("time_local_data_guard_enabled_in_utc")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeLocalDataGuardEnabledInUtc { get; }

    /// <summary>
    /// The time_maintenance_begin_in_utc attribute.
    /// </summary>
    [TerraformProperty("time_maintenance_begin_in_utc")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeMaintenanceBeginInUtc { get; }

    /// <summary>
    /// The time_maintenance_end_in_utc attribute.
    /// </summary>
    [TerraformProperty("time_maintenance_end_in_utc")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeMaintenanceEndInUtc { get; }

    /// <summary>
    /// The time_of_last_failover_in_utc attribute.
    /// </summary>
    [TerraformProperty("time_of_last_failover_in_utc")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeOfLastFailoverInUtc { get; }

    /// <summary>
    /// The time_of_last_refresh_in_utc attribute.
    /// </summary>
    [TerraformProperty("time_of_last_refresh_in_utc")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeOfLastRefreshInUtc { get; }

    /// <summary>
    /// The time_of_last_refresh_point_in_utc attribute.
    /// </summary>
    [TerraformProperty("time_of_last_refresh_point_in_utc")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeOfLastRefreshPointInUtc { get; }

    /// <summary>
    /// The time_of_last_switchover_in_utc attribute.
    /// </summary>
    [TerraformProperty("time_of_last_switchover_in_utc")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeOfLastSwitchoverInUtc { get; }

    /// <summary>
    /// The time_reclamation_of_free_autonomous_database_in_utc attribute.
    /// </summary>
    [TerraformProperty("time_reclamation_of_free_autonomous_database_in_utc")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeReclamationOfFreeAutonomousDatabaseInUtc { get; }

    /// <summary>
    /// The time_until_reconnect_in_utc attribute.
    /// </summary>
    [TerraformProperty("time_until_reconnect_in_utc")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeUntilReconnectInUtc { get; }

    /// <summary>
    /// The used_data_storage_size_in_gb attribute.
    /// </summary>
    [TerraformProperty("used_data_storage_size_in_gb")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> UsedDataStorageSizeInGb { get; }

    /// <summary>
    /// The used_data_storage_size_in_tb attribute.
    /// </summary>
    [TerraformProperty("used_data_storage_size_in_tb")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> UsedDataStorageSizeInTb { get; }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformProperty("virtual_network_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VirtualNetworkId { get; }

}
