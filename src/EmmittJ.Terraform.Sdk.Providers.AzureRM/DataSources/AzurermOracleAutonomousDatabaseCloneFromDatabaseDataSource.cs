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
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.DeclareOutput("actual_used_data_storage_size_in_tb");
        this.DeclareOutput("allocated_storage_size_in_tb");
        this.DeclareOutput("allowed_ip_addresses");
        this.DeclareOutput("auto_scaling_enabled");
        this.DeclareOutput("auto_scaling_for_storage_enabled");
        this.DeclareOutput("available_upgrade_versions");
        this.DeclareOutput("backup_retention_period_in_days");
        this.DeclareOutput("character_set");
        this.DeclareOutput("compute_count");
        this.DeclareOutput("compute_model");
        this.DeclareOutput("connection_strings");
        this.DeclareOutput("cpu_core_count");
        this.DeclareOutput("customer_contacts");
        this.DeclareOutput("data_storage_size_in_gb");
        this.DeclareOutput("data_storage_size_in_tb");
        this.DeclareOutput("database_version");
        this.DeclareOutput("database_workload");
        this.DeclareOutput("display_name");
        this.DeclareOutput("failed_data_recovery_in_seconds");
        this.DeclareOutput("in_memory_area_in_gb");
        this.DeclareOutput("license_model");
        this.DeclareOutput("lifecycle_details");
        this.DeclareOutput("lifecycle_state");
        this.DeclareOutput("local_adg_auto_failover_max_data_loss_limit_in_seconds");
        this.DeclareOutput("local_data_guard_enabled");
        this.DeclareOutput("location");
        this.DeclareOutput("long_term_backup_schedule");
        this.DeclareOutput("memory_per_oracle_compute_unit_in_gb");
        this.DeclareOutput("mtls_connection_required");
        this.DeclareOutput("national_character_set");
        this.DeclareOutput("next_long_term_backup_timestamp");
        this.DeclareOutput("oci_url");
        this.DeclareOutput("ocid");
        this.DeclareOutput("peer_database_ids");
        this.DeclareOutput("preview");
        this.DeclareOutput("preview_version_with_service_terms_accepted");
        this.DeclareOutput("private_endpoint_ip");
        this.DeclareOutput("private_endpoint_label");
        this.DeclareOutput("private_endpoint_url");
        this.DeclareOutput("provisionable_cpus");
        this.DeclareOutput("reconnect_clone_enabled");
        this.DeclareOutput("refreshable_clone");
        this.DeclareOutput("refreshable_status");
        this.DeclareOutput("remote_data_guard_enabled");
        this.DeclareOutput("service_console_url");
        this.DeclareOutput("source_autonomous_database_id");
        this.DeclareOutput("sql_web_developer_url");
        this.DeclareOutput("subnet_id");
        this.DeclareOutput("supported_regions_to_clone_to");
        this.DeclareOutput("tags");
        this.DeclareOutput("time_created_in_utc");
        this.DeclareOutput("time_data_guard_role_changed_in_utc");
        this.DeclareOutput("time_deletion_of_free_autonomous_database_in_utc");
        this.DeclareOutput("time_local_data_guard_enabled_in_utc");
        this.DeclareOutput("time_maintenance_begin_in_utc");
        this.DeclareOutput("time_maintenance_end_in_utc");
        this.DeclareOutput("time_of_last_failover_in_utc");
        this.DeclareOutput("time_of_last_refresh_in_utc");
        this.DeclareOutput("time_of_last_refresh_point_in_utc");
        this.DeclareOutput("time_of_last_switchover_in_utc");
        this.DeclareOutput("time_reclamation_of_free_autonomous_database_in_utc");
        this.DeclareOutput("time_until_reconnect_in_utc");
        this.DeclareOutput("used_data_storage_size_in_gb");
        this.DeclareOutput("used_data_storage_size_in_tb");
        this.DeclareOutput("virtual_network_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermOracleAutonomousDatabaseCloneFromDatabaseDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermOracleAutonomousDatabaseCloneFromDatabaseDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
