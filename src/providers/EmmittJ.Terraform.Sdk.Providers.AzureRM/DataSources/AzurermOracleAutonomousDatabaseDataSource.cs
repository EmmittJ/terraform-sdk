using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermOracleAutonomousDatabaseDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_autonomous_database.
/// </summary>
public partial class AzurermOracleAutonomousDatabaseDataSource : TerraformDataSource
{
    public AzurermOracleAutonomousDatabaseDataSource(string name) : base("azurerm_oracle_autonomous_database", name)
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
    public TerraformBlock<AzurermOracleAutonomousDatabaseDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The actual_used_data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformProperty("actual_used_data_storage_size_in_tbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ActualUsedDataStorageSizeInTbs { get; }

    /// <summary>
    /// The allocated_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformProperty("allocated_storage_size_in_tbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> AllocatedStorageSizeInTbs { get; }

    /// <summary>
    /// The allowed_ips attribute.
    /// </summary>
    [TerraformProperty("allowed_ips")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<double> AllowedIps { get; }

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
    /// The autonomous_database_id attribute.
    /// </summary>
    [TerraformProperty("autonomous_database_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AutonomousDatabaseId { get; }

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
    /// The cpu_core_count attribute.
    /// </summary>
    [TerraformProperty("cpu_core_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> CpuCoreCount { get; }

    /// <summary>
    /// The data_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformProperty("data_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DataStorageSizeInGbs { get; }

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformProperty("data_storage_size_in_tbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DataStorageSizeInTbs { get; }

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformProperty("db_node_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DbNodeStorageSizeInGbs { get; }

    /// <summary>
    /// The db_version attribute.
    /// </summary>
    [TerraformProperty("db_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DbVersion { get; }

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
    /// The in_memory_area_in_gbs attribute.
    /// </summary>
    [TerraformProperty("in_memory_area_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> InMemoryAreaInGbs { get; }

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    [TerraformProperty("lifecycle_details")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LifecycleDetails { get; }

    /// <summary>
    /// The local_adg_auto_failover_max_data_loss_limit attribute.
    /// </summary>
    [TerraformProperty("local_adg_auto_failover_max_data_loss_limit")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> LocalAdgAutoFailoverMaxDataLossLimit { get; }

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
    /// The memory_per_oracle_compute_unit_in_gbs attribute.
    /// </summary>
    [TerraformProperty("memory_per_oracle_compute_unit_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MemoryPerOracleComputeUnitInGbs { get; }

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
    /// The next_long_term_backup_time_stamp attribute.
    /// </summary>
    [TerraformProperty("next_long_term_backup_time_stamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NextLongTermBackupTimeStamp { get; }

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
    /// The peer_db_id attribute.
    /// </summary>
    [TerraformProperty("peer_db_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PeerDbId { get; }

    /// <summary>
    /// The peer_db_ids attribute.
    /// </summary>
    [TerraformProperty("peer_db_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> PeerDbIds { get; }

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
    /// The private_endpoint attribute.
    /// </summary>
    [TerraformProperty("private_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrivateEndpoint { get; }

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
    /// The provisionable_cpus attribute.
    /// </summary>
    [TerraformProperty("provisionable_cpus")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<double> ProvisionableCpus { get; }

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
    /// The time_created attribute.
    /// </summary>
    [TerraformProperty("time_created")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeCreated { get; }

    /// <summary>
    /// The time_data_guard_role_changed attribute.
    /// </summary>
    [TerraformProperty("time_data_guard_role_changed")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeDataGuardRoleChanged { get; }

    /// <summary>
    /// The time_deletion_of_free_autonomous_database attribute.
    /// </summary>
    [TerraformProperty("time_deletion_of_free_autonomous_database")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeDeletionOfFreeAutonomousDatabase { get; }

    /// <summary>
    /// The time_local_data_guard_enabled_on attribute.
    /// </summary>
    [TerraformProperty("time_local_data_guard_enabled_on")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeLocalDataGuardEnabledOn { get; }

    /// <summary>
    /// The time_maintenance_begin attribute.
    /// </summary>
    [TerraformProperty("time_maintenance_begin")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeMaintenanceBegin { get; }

    /// <summary>
    /// The time_maintenance_end attribute.
    /// </summary>
    [TerraformProperty("time_maintenance_end")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeMaintenanceEnd { get; }

    /// <summary>
    /// The time_of_last_failover attribute.
    /// </summary>
    [TerraformProperty("time_of_last_failover")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeOfLastFailover { get; }

    /// <summary>
    /// The time_of_last_refresh attribute.
    /// </summary>
    [TerraformProperty("time_of_last_refresh")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeOfLastRefresh { get; }

    /// <summary>
    /// The time_of_last_refresh_point attribute.
    /// </summary>
    [TerraformProperty("time_of_last_refresh_point")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeOfLastRefreshPoint { get; }

    /// <summary>
    /// The time_of_last_switchover attribute.
    /// </summary>
    [TerraformProperty("time_of_last_switchover")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeOfLastSwitchover { get; }

    /// <summary>
    /// The time_reclamation_of_free_autonomous_database attribute.
    /// </summary>
    [TerraformProperty("time_reclamation_of_free_autonomous_database")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeReclamationOfFreeAutonomousDatabase { get; }

    /// <summary>
    /// The used_data_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformProperty("used_data_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> UsedDataStorageSizeInGbs { get; }

    /// <summary>
    /// The used_data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformProperty("used_data_storage_size_in_tbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> UsedDataStorageSizeInTbs { get; }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformProperty("virtual_network_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VirtualNetworkId { get; }

}
