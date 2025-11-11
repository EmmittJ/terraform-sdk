using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleAutonomousDatabaseDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    public TerraformBlock<AzurermOracleAutonomousDatabaseDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The actual_used_data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformPropertyName("actual_used_data_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ActualUsedDataStorageSizeInTbs => new TerraformReference(this, "actual_used_data_storage_size_in_tbs");

    /// <summary>
    /// The allocated_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformPropertyName("allocated_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AllocatedStorageSizeInTbs => new TerraformReference(this, "allocated_storage_size_in_tbs");

    /// <summary>
    /// The allowed_ips attribute.
    /// </summary>
    [TerraformPropertyName("allowed_ips")]
    // Output-only attribute - read-only reference
    public TerraformList<double> AllowedIps => new TerraformReference(this, "allowed_ips");

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
    /// The autonomous_database_id attribute.
    /// </summary>
    [TerraformPropertyName("autonomous_database_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AutonomousDatabaseId => new TerraformReference(this, "autonomous_database_id");

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
    /// The cpu_core_count attribute.
    /// </summary>
    [TerraformPropertyName("cpu_core_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> CpuCoreCount => new TerraformReference(this, "cpu_core_count");

    /// <summary>
    /// The data_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DataStorageSizeInGbs => new TerraformReference(this, "data_storage_size_in_gbs");

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DataStorageSizeInTbs => new TerraformReference(this, "data_storage_size_in_tbs");

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("db_node_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DbNodeStorageSizeInGbs => new TerraformReference(this, "db_node_storage_size_in_gbs");

    /// <summary>
    /// The db_version attribute.
    /// </summary>
    [TerraformPropertyName("db_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DbVersion => new TerraformReference(this, "db_version");

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
    /// The in_memory_area_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("in_memory_area_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> InMemoryAreaInGbs => new TerraformReference(this, "in_memory_area_in_gbs");

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_details")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LifecycleDetails => new TerraformReference(this, "lifecycle_details");

    /// <summary>
    /// The local_adg_auto_failover_max_data_loss_limit attribute.
    /// </summary>
    [TerraformPropertyName("local_adg_auto_failover_max_data_loss_limit")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> LocalAdgAutoFailoverMaxDataLossLimit => new TerraformReference(this, "local_adg_auto_failover_max_data_loss_limit");

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
    /// The memory_per_oracle_compute_unit_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("memory_per_oracle_compute_unit_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MemoryPerOracleComputeUnitInGbs => new TerraformReference(this, "memory_per_oracle_compute_unit_in_gbs");

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
    /// The next_long_term_backup_time_stamp attribute.
    /// </summary>
    [TerraformPropertyName("next_long_term_backup_time_stamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NextLongTermBackupTimeStamp => new TerraformReference(this, "next_long_term_backup_time_stamp");

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
    /// The peer_db_id attribute.
    /// </summary>
    [TerraformPropertyName("peer_db_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PeerDbId => new TerraformReference(this, "peer_db_id");

    /// <summary>
    /// The peer_db_ids attribute.
    /// </summary>
    [TerraformPropertyName("peer_db_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> PeerDbIds => new TerraformReference(this, "peer_db_ids");

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
    /// The private_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("private_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateEndpoint => new TerraformReference(this, "private_endpoint");

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
    /// The time_created attribute.
    /// </summary>
    [TerraformPropertyName("time_created")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeCreated => new TerraformReference(this, "time_created");

    /// <summary>
    /// The time_data_guard_role_changed attribute.
    /// </summary>
    [TerraformPropertyName("time_data_guard_role_changed")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeDataGuardRoleChanged => new TerraformReference(this, "time_data_guard_role_changed");

    /// <summary>
    /// The time_deletion_of_free_autonomous_database attribute.
    /// </summary>
    [TerraformPropertyName("time_deletion_of_free_autonomous_database")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeDeletionOfFreeAutonomousDatabase => new TerraformReference(this, "time_deletion_of_free_autonomous_database");

    /// <summary>
    /// The time_local_data_guard_enabled_on attribute.
    /// </summary>
    [TerraformPropertyName("time_local_data_guard_enabled_on")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeLocalDataGuardEnabledOn => new TerraformReference(this, "time_local_data_guard_enabled_on");

    /// <summary>
    /// The time_maintenance_begin attribute.
    /// </summary>
    [TerraformPropertyName("time_maintenance_begin")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeMaintenanceBegin => new TerraformReference(this, "time_maintenance_begin");

    /// <summary>
    /// The time_maintenance_end attribute.
    /// </summary>
    [TerraformPropertyName("time_maintenance_end")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeMaintenanceEnd => new TerraformReference(this, "time_maintenance_end");

    /// <summary>
    /// The time_of_last_failover attribute.
    /// </summary>
    [TerraformPropertyName("time_of_last_failover")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeOfLastFailover => new TerraformReference(this, "time_of_last_failover");

    /// <summary>
    /// The time_of_last_refresh attribute.
    /// </summary>
    [TerraformPropertyName("time_of_last_refresh")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeOfLastRefresh => new TerraformReference(this, "time_of_last_refresh");

    /// <summary>
    /// The time_of_last_refresh_point attribute.
    /// </summary>
    [TerraformPropertyName("time_of_last_refresh_point")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeOfLastRefreshPoint => new TerraformReference(this, "time_of_last_refresh_point");

    /// <summary>
    /// The time_of_last_switchover attribute.
    /// </summary>
    [TerraformPropertyName("time_of_last_switchover")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeOfLastSwitchover => new TerraformReference(this, "time_of_last_switchover");

    /// <summary>
    /// The time_reclamation_of_free_autonomous_database attribute.
    /// </summary>
    [TerraformPropertyName("time_reclamation_of_free_autonomous_database")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeReclamationOfFreeAutonomousDatabase => new TerraformReference(this, "time_reclamation_of_free_autonomous_database");

    /// <summary>
    /// The used_data_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("used_data_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> UsedDataStorageSizeInGbs => new TerraformReference(this, "used_data_storage_size_in_gbs");

    /// <summary>
    /// The used_data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformPropertyName("used_data_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> UsedDataStorageSizeInTbs => new TerraformReference(this, "used_data_storage_size_in_tbs");

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VirtualNetworkId => new TerraformReference(this, "virtual_network_id");

}
