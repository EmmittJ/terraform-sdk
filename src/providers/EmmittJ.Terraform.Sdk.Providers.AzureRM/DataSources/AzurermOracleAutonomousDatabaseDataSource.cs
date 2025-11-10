using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleAutonomousDatabaseDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    public TerraformBlock<AzurermOracleAutonomousDatabaseDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The actual_used_data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformPropertyName("actual_used_data_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ActualUsedDataStorageSizeInTbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "actual_used_data_storage_size_in_tbs");

    /// <summary>
    /// The allocated_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformPropertyName("allocated_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AllocatedStorageSizeInTbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "allocated_storage_size_in_tbs");

    /// <summary>
    /// The allowed_ips attribute.
    /// </summary>
    [TerraformPropertyName("allowed_ips")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<double>>> AllowedIps => new TerraformReferenceProperty<List<TerraformProperty<double>>>(ResourceAddress, "allowed_ips");

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
    /// The autonomous_database_id attribute.
    /// </summary>
    [TerraformPropertyName("autonomous_database_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AutonomousDatabaseId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "autonomous_database_id");

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
    /// The cpu_core_count attribute.
    /// </summary>
    [TerraformPropertyName("cpu_core_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CpuCoreCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "cpu_core_count");

    /// <summary>
    /// The data_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DataStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "data_storage_size_in_gbs");

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DataStorageSizeInTbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "data_storage_size_in_tbs");

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("db_node_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DbNodeStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "db_node_storage_size_in_gbs");

    /// <summary>
    /// The db_version attribute.
    /// </summary>
    [TerraformPropertyName("db_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DbVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_version");

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
    /// The in_memory_area_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("in_memory_area_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> InMemoryAreaInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "in_memory_area_in_gbs");

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LifecycleDetails => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lifecycle_details");

    /// <summary>
    /// The local_adg_auto_failover_max_data_loss_limit attribute.
    /// </summary>
    [TerraformPropertyName("local_adg_auto_failover_max_data_loss_limit")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> LocalAdgAutoFailoverMaxDataLossLimit => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "local_adg_auto_failover_max_data_loss_limit");

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
    /// The memory_per_oracle_compute_unit_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("memory_per_oracle_compute_unit_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MemoryPerOracleComputeUnitInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "memory_per_oracle_compute_unit_in_gbs");

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
    /// The next_long_term_backup_time_stamp attribute.
    /// </summary>
    [TerraformPropertyName("next_long_term_backup_time_stamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NextLongTermBackupTimeStamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "next_long_term_backup_time_stamp");

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
    /// The peer_db_id attribute.
    /// </summary>
    [TerraformPropertyName("peer_db_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PeerDbId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "peer_db_id");

    /// <summary>
    /// The peer_db_ids attribute.
    /// </summary>
    [TerraformPropertyName("peer_db_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> PeerDbIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "peer_db_ids");

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
    /// The private_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("private_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_endpoint");

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
    /// The time_created attribute.
    /// </summary>
    [TerraformPropertyName("time_created")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeCreated => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_created");

    /// <summary>
    /// The time_data_guard_role_changed attribute.
    /// </summary>
    [TerraformPropertyName("time_data_guard_role_changed")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeDataGuardRoleChanged => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_data_guard_role_changed");

    /// <summary>
    /// The time_deletion_of_free_autonomous_database attribute.
    /// </summary>
    [TerraformPropertyName("time_deletion_of_free_autonomous_database")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeDeletionOfFreeAutonomousDatabase => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_deletion_of_free_autonomous_database");

    /// <summary>
    /// The time_local_data_guard_enabled_on attribute.
    /// </summary>
    [TerraformPropertyName("time_local_data_guard_enabled_on")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeLocalDataGuardEnabledOn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_local_data_guard_enabled_on");

    /// <summary>
    /// The time_maintenance_begin attribute.
    /// </summary>
    [TerraformPropertyName("time_maintenance_begin")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeMaintenanceBegin => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_maintenance_begin");

    /// <summary>
    /// The time_maintenance_end attribute.
    /// </summary>
    [TerraformPropertyName("time_maintenance_end")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeMaintenanceEnd => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_maintenance_end");

    /// <summary>
    /// The time_of_last_failover attribute.
    /// </summary>
    [TerraformPropertyName("time_of_last_failover")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeOfLastFailover => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_of_last_failover");

    /// <summary>
    /// The time_of_last_refresh attribute.
    /// </summary>
    [TerraformPropertyName("time_of_last_refresh")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeOfLastRefresh => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_of_last_refresh");

    /// <summary>
    /// The time_of_last_refresh_point attribute.
    /// </summary>
    [TerraformPropertyName("time_of_last_refresh_point")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeOfLastRefreshPoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_of_last_refresh_point");

    /// <summary>
    /// The time_of_last_switchover attribute.
    /// </summary>
    [TerraformPropertyName("time_of_last_switchover")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeOfLastSwitchover => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_of_last_switchover");

    /// <summary>
    /// The time_reclamation_of_free_autonomous_database attribute.
    /// </summary>
    [TerraformPropertyName("time_reclamation_of_free_autonomous_database")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeReclamationOfFreeAutonomousDatabase => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_reclamation_of_free_autonomous_database");

    /// <summary>
    /// The used_data_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("used_data_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> UsedDataStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "used_data_storage_size_in_gbs");

    /// <summary>
    /// The used_data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformPropertyName("used_data_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> UsedDataStorageSizeInTbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "used_data_storage_size_in_tbs");

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VirtualNetworkId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "virtual_network_id");

}
