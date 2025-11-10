using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleAutonomousDatabaseCloneFromDatabaseDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_autonomous_database_clone_from_database.
/// </summary>
public class AzurermOracleAutonomousDatabaseCloneFromDatabaseDataSource : TerraformDataSource
{
    public AzurermOracleAutonomousDatabaseCloneFromDatabaseDataSource(string name) : base("azurerm_oracle_autonomous_database_clone_from_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("actual_used_data_storage_size_in_tb");
        SetOutput("allocated_storage_size_in_tb");
        SetOutput("allowed_ip_addresses");
        SetOutput("auto_scaling_enabled");
        SetOutput("auto_scaling_for_storage_enabled");
        SetOutput("available_upgrade_versions");
        SetOutput("backup_retention_period_in_days");
        SetOutput("character_set");
        SetOutput("compute_count");
        SetOutput("compute_model");
        SetOutput("connection_strings");
        SetOutput("cpu_core_count");
        SetOutput("customer_contacts");
        SetOutput("data_storage_size_in_gb");
        SetOutput("data_storage_size_in_tb");
        SetOutput("database_version");
        SetOutput("database_workload");
        SetOutput("display_name");
        SetOutput("failed_data_recovery_in_seconds");
        SetOutput("in_memory_area_in_gb");
        SetOutput("license_model");
        SetOutput("lifecycle_details");
        SetOutput("lifecycle_state");
        SetOutput("local_adg_auto_failover_max_data_loss_limit_in_seconds");
        SetOutput("local_data_guard_enabled");
        SetOutput("location");
        SetOutput("long_term_backup_schedule");
        SetOutput("memory_per_oracle_compute_unit_in_gb");
        SetOutput("mtls_connection_required");
        SetOutput("national_character_set");
        SetOutput("next_long_term_backup_timestamp");
        SetOutput("oci_url");
        SetOutput("ocid");
        SetOutput("peer_database_ids");
        SetOutput("preview");
        SetOutput("preview_version_with_service_terms_accepted");
        SetOutput("private_endpoint_ip");
        SetOutput("private_endpoint_label");
        SetOutput("private_endpoint_url");
        SetOutput("provisionable_cpus");
        SetOutput("reconnect_clone_enabled");
        SetOutput("refreshable_clone");
        SetOutput("refreshable_status");
        SetOutput("remote_data_guard_enabled");
        SetOutput("service_console_url");
        SetOutput("source_autonomous_database_id");
        SetOutput("sql_web_developer_url");
        SetOutput("subnet_id");
        SetOutput("supported_regions_to_clone_to");
        SetOutput("tags");
        SetOutput("time_created_in_utc");
        SetOutput("time_data_guard_role_changed_in_utc");
        SetOutput("time_deletion_of_free_autonomous_database_in_utc");
        SetOutput("time_local_data_guard_enabled_in_utc");
        SetOutput("time_maintenance_begin_in_utc");
        SetOutput("time_maintenance_end_in_utc");
        SetOutput("time_of_last_failover_in_utc");
        SetOutput("time_of_last_refresh_in_utc");
        SetOutput("time_of_last_refresh_point_in_utc");
        SetOutput("time_of_last_switchover_in_utc");
        SetOutput("time_reclamation_of_free_autonomous_database_in_utc");
        SetOutput("time_until_reconnect_in_utc");
        SetOutput("used_data_storage_size_in_gb");
        SetOutput("used_data_storage_size_in_tb");
        SetOutput("virtual_network_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermOracleAutonomousDatabaseCloneFromDatabaseDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The actual_used_data_storage_size_in_tb attribute.
    /// </summary>
    public TerraformExpression ActualUsedDataStorageSizeInTb => this["actual_used_data_storage_size_in_tb"];

    /// <summary>
    /// The allocated_storage_size_in_tb attribute.
    /// </summary>
    public TerraformExpression AllocatedStorageSizeInTb => this["allocated_storage_size_in_tb"];

    /// <summary>
    /// The allowed_ip_addresses attribute.
    /// </summary>
    public TerraformExpression AllowedIpAddresses => this["allowed_ip_addresses"];

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    public TerraformExpression AutoScalingEnabled => this["auto_scaling_enabled"];

    /// <summary>
    /// The auto_scaling_for_storage_enabled attribute.
    /// </summary>
    public TerraformExpression AutoScalingForStorageEnabled => this["auto_scaling_for_storage_enabled"];

    /// <summary>
    /// The available_upgrade_versions attribute.
    /// </summary>
    public TerraformExpression AvailableUpgradeVersions => this["available_upgrade_versions"];

    /// <summary>
    /// The backup_retention_period_in_days attribute.
    /// </summary>
    public TerraformExpression BackupRetentionPeriodInDays => this["backup_retention_period_in_days"];

    /// <summary>
    /// The character_set attribute.
    /// </summary>
    public TerraformExpression CharacterSet => this["character_set"];

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    public TerraformExpression ComputeCount => this["compute_count"];

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    public TerraformExpression ComputeModel => this["compute_model"];

    /// <summary>
    /// The connection_strings attribute.
    /// </summary>
    public TerraformExpression ConnectionStrings => this["connection_strings"];

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    public TerraformExpression CpuCoreCount => this["cpu_core_count"];

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    public TerraformExpression CustomerContacts => this["customer_contacts"];

    /// <summary>
    /// The data_storage_size_in_gb attribute.
    /// </summary>
    public TerraformExpression DataStorageSizeInGb => this["data_storage_size_in_gb"];

    /// <summary>
    /// The data_storage_size_in_tb attribute.
    /// </summary>
    public TerraformExpression DataStorageSizeInTb => this["data_storage_size_in_tb"];

    /// <summary>
    /// The database_version attribute.
    /// </summary>
    public TerraformExpression DatabaseVersion => this["database_version"];

    /// <summary>
    /// The database_workload attribute.
    /// </summary>
    public TerraformExpression DatabaseWorkload => this["database_workload"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The failed_data_recovery_in_seconds attribute.
    /// </summary>
    public TerraformExpression FailedDataRecoveryInSeconds => this["failed_data_recovery_in_seconds"];

    /// <summary>
    /// The in_memory_area_in_gb attribute.
    /// </summary>
    public TerraformExpression InMemoryAreaInGb => this["in_memory_area_in_gb"];

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformExpression LicenseModel => this["license_model"];

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    public TerraformExpression LifecycleDetails => this["lifecycle_details"];

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    public TerraformExpression LifecycleState => this["lifecycle_state"];

    /// <summary>
    /// The local_adg_auto_failover_max_data_loss_limit_in_seconds attribute.
    /// </summary>
    public TerraformExpression LocalAdgAutoFailoverMaxDataLossLimitInSeconds => this["local_adg_auto_failover_max_data_loss_limit_in_seconds"];

    /// <summary>
    /// The local_data_guard_enabled attribute.
    /// </summary>
    public TerraformExpression LocalDataGuardEnabled => this["local_data_guard_enabled"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The long_term_backup_schedule attribute.
    /// </summary>
    public TerraformExpression LongTermBackupSchedule => this["long_term_backup_schedule"];

    /// <summary>
    /// The memory_per_oracle_compute_unit_in_gb attribute.
    /// </summary>
    public TerraformExpression MemoryPerOracleComputeUnitInGb => this["memory_per_oracle_compute_unit_in_gb"];

    /// <summary>
    /// The mtls_connection_required attribute.
    /// </summary>
    public TerraformExpression MtlsConnectionRequired => this["mtls_connection_required"];

    /// <summary>
    /// The national_character_set attribute.
    /// </summary>
    public TerraformExpression NationalCharacterSet => this["national_character_set"];

    /// <summary>
    /// The next_long_term_backup_timestamp attribute.
    /// </summary>
    public TerraformExpression NextLongTermBackupTimestamp => this["next_long_term_backup_timestamp"];

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    public TerraformExpression OciUrl => this["oci_url"];

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    public TerraformExpression Ocid => this["ocid"];

    /// <summary>
    /// The peer_database_ids attribute.
    /// </summary>
    public TerraformExpression PeerDatabaseIds => this["peer_database_ids"];

    /// <summary>
    /// The preview attribute.
    /// </summary>
    public TerraformExpression Preview => this["preview"];

    /// <summary>
    /// The preview_version_with_service_terms_accepted attribute.
    /// </summary>
    public TerraformExpression PreviewVersionWithServiceTermsAccepted => this["preview_version_with_service_terms_accepted"];

    /// <summary>
    /// The private_endpoint_ip attribute.
    /// </summary>
    public TerraformExpression PrivateEndpointIp => this["private_endpoint_ip"];

    /// <summary>
    /// The private_endpoint_label attribute.
    /// </summary>
    public TerraformExpression PrivateEndpointLabel => this["private_endpoint_label"];

    /// <summary>
    /// The private_endpoint_url attribute.
    /// </summary>
    public TerraformExpression PrivateEndpointUrl => this["private_endpoint_url"];

    /// <summary>
    /// The provisionable_cpus attribute.
    /// </summary>
    public TerraformExpression ProvisionableCpus => this["provisionable_cpus"];

    /// <summary>
    /// The reconnect_clone_enabled attribute.
    /// </summary>
    public TerraformExpression ReconnectCloneEnabled => this["reconnect_clone_enabled"];

    /// <summary>
    /// The refreshable_clone attribute.
    /// </summary>
    public TerraformExpression RefreshableClone => this["refreshable_clone"];

    /// <summary>
    /// The refreshable_status attribute.
    /// </summary>
    public TerraformExpression RefreshableStatus => this["refreshable_status"];

    /// <summary>
    /// The remote_data_guard_enabled attribute.
    /// </summary>
    public TerraformExpression RemoteDataGuardEnabled => this["remote_data_guard_enabled"];

    /// <summary>
    /// The service_console_url attribute.
    /// </summary>
    public TerraformExpression ServiceConsoleUrl => this["service_console_url"];

    /// <summary>
    /// The source_autonomous_database_id attribute.
    /// </summary>
    public TerraformExpression SourceAutonomousDatabaseId => this["source_autonomous_database_id"];

    /// <summary>
    /// The sql_web_developer_url attribute.
    /// </summary>
    public TerraformExpression SqlWebDeveloperUrl => this["sql_web_developer_url"];

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformExpression SubnetId => this["subnet_id"];

    /// <summary>
    /// The supported_regions_to_clone_to attribute.
    /// </summary>
    public TerraformExpression SupportedRegionsToCloneTo => this["supported_regions_to_clone_to"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The time_created_in_utc attribute.
    /// </summary>
    public TerraformExpression TimeCreatedInUtc => this["time_created_in_utc"];

    /// <summary>
    /// The time_data_guard_role_changed_in_utc attribute.
    /// </summary>
    public TerraformExpression TimeDataGuardRoleChangedInUtc => this["time_data_guard_role_changed_in_utc"];

    /// <summary>
    /// The time_deletion_of_free_autonomous_database_in_utc attribute.
    /// </summary>
    public TerraformExpression TimeDeletionOfFreeAutonomousDatabaseInUtc => this["time_deletion_of_free_autonomous_database_in_utc"];

    /// <summary>
    /// The time_local_data_guard_enabled_in_utc attribute.
    /// </summary>
    public TerraformExpression TimeLocalDataGuardEnabledInUtc => this["time_local_data_guard_enabled_in_utc"];

    /// <summary>
    /// The time_maintenance_begin_in_utc attribute.
    /// </summary>
    public TerraformExpression TimeMaintenanceBeginInUtc => this["time_maintenance_begin_in_utc"];

    /// <summary>
    /// The time_maintenance_end_in_utc attribute.
    /// </summary>
    public TerraformExpression TimeMaintenanceEndInUtc => this["time_maintenance_end_in_utc"];

    /// <summary>
    /// The time_of_last_failover_in_utc attribute.
    /// </summary>
    public TerraformExpression TimeOfLastFailoverInUtc => this["time_of_last_failover_in_utc"];

    /// <summary>
    /// The time_of_last_refresh_in_utc attribute.
    /// </summary>
    public TerraformExpression TimeOfLastRefreshInUtc => this["time_of_last_refresh_in_utc"];

    /// <summary>
    /// The time_of_last_refresh_point_in_utc attribute.
    /// </summary>
    public TerraformExpression TimeOfLastRefreshPointInUtc => this["time_of_last_refresh_point_in_utc"];

    /// <summary>
    /// The time_of_last_switchover_in_utc attribute.
    /// </summary>
    public TerraformExpression TimeOfLastSwitchoverInUtc => this["time_of_last_switchover_in_utc"];

    /// <summary>
    /// The time_reclamation_of_free_autonomous_database_in_utc attribute.
    /// </summary>
    public TerraformExpression TimeReclamationOfFreeAutonomousDatabaseInUtc => this["time_reclamation_of_free_autonomous_database_in_utc"];

    /// <summary>
    /// The time_until_reconnect_in_utc attribute.
    /// </summary>
    public TerraformExpression TimeUntilReconnectInUtc => this["time_until_reconnect_in_utc"];

    /// <summary>
    /// The used_data_storage_size_in_gb attribute.
    /// </summary>
    public TerraformExpression UsedDataStorageSizeInGb => this["used_data_storage_size_in_gb"];

    /// <summary>
    /// The used_data_storage_size_in_tb attribute.
    /// </summary>
    public TerraformExpression UsedDataStorageSizeInTb => this["used_data_storage_size_in_tb"];

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformExpression VirtualNetworkId => this["virtual_network_id"];

}
