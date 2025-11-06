using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_oracle_autonomous_database.
/// </summary>
public class AzurermOracleAutonomousDatabaseDataSource : TerraformDataSource
{
    public AzurermOracleAutonomousDatabaseDataSource(string name) : base("azurerm_oracle_autonomous_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("actual_used_data_storage_size_in_tbs");
        this.DeclareOutput("allocated_storage_size_in_tbs");
        this.DeclareOutput("allowed_ips");
        this.DeclareOutput("auto_scaling_enabled");
        this.DeclareOutput("auto_scaling_for_storage_enabled");
        this.DeclareOutput("autonomous_database_id");
        this.DeclareOutput("available_upgrade_versions");
        this.DeclareOutput("backup_retention_period_in_days");
        this.DeclareOutput("character_set");
        this.DeclareOutput("compute_count");
        this.DeclareOutput("cpu_core_count");
        this.DeclareOutput("data_storage_size_in_gbs");
        this.DeclareOutput("data_storage_size_in_tbs");
        this.DeclareOutput("db_node_storage_size_in_gbs");
        this.DeclareOutput("db_version");
        this.DeclareOutput("display_name");
        this.DeclareOutput("failed_data_recovery_in_seconds");
        this.DeclareOutput("in_memory_area_in_gbs");
        this.DeclareOutput("lifecycle_details");
        this.DeclareOutput("local_adg_auto_failover_max_data_loss_limit");
        this.DeclareOutput("local_data_guard_enabled");
        this.DeclareOutput("location");
        this.DeclareOutput("long_term_backup_schedule");
        this.DeclareOutput("memory_per_oracle_compute_unit_in_gbs");
        this.DeclareOutput("mtls_connection_required");
        this.DeclareOutput("national_character_set");
        this.DeclareOutput("next_long_term_backup_time_stamp");
        this.DeclareOutput("oci_url");
        this.DeclareOutput("ocid");
        this.DeclareOutput("peer_db_id");
        this.DeclareOutput("peer_db_ids");
        this.DeclareOutput("preview");
        this.DeclareOutput("preview_version_with_service_terms_accepted");
        this.DeclareOutput("private_endpoint");
        this.DeclareOutput("private_endpoint_ip");
        this.DeclareOutput("private_endpoint_label");
        this.DeclareOutput("provisionable_cpus");
        this.DeclareOutput("remote_data_guard_enabled");
        this.DeclareOutput("service_console_url");
        this.DeclareOutput("sql_web_developer_url");
        this.DeclareOutput("subnet_id");
        this.DeclareOutput("supported_regions_to_clone_to");
        this.DeclareOutput("tags");
        this.DeclareOutput("time_created");
        this.DeclareOutput("time_data_guard_role_changed");
        this.DeclareOutput("time_deletion_of_free_autonomous_database");
        this.DeclareOutput("time_local_data_guard_enabled_on");
        this.DeclareOutput("time_maintenance_begin");
        this.DeclareOutput("time_maintenance_end");
        this.DeclareOutput("time_of_last_failover");
        this.DeclareOutput("time_of_last_refresh");
        this.DeclareOutput("time_of_last_refresh_point");
        this.DeclareOutput("time_of_last_switchover");
        this.DeclareOutput("time_reclamation_of_free_autonomous_database");
        this.DeclareOutput("used_data_storage_size_in_gbs");
        this.DeclareOutput("used_data_storage_size_in_tbs");
        this.DeclareOutput("virtual_network_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The actual_used_data_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformExpression ActualUsedDataStorageSizeInTbs => this["actual_used_data_storage_size_in_tbs"];

    /// <summary>
    /// The allocated_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformExpression AllocatedStorageSizeInTbs => this["allocated_storage_size_in_tbs"];

    /// <summary>
    /// The allowed_ips attribute.
    /// </summary>
    public TerraformExpression AllowedIps => this["allowed_ips"];

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    public TerraformExpression AutoScalingEnabled => this["auto_scaling_enabled"];

    /// <summary>
    /// The auto_scaling_for_storage_enabled attribute.
    /// </summary>
    public TerraformExpression AutoScalingForStorageEnabled => this["auto_scaling_for_storage_enabled"];

    /// <summary>
    /// The autonomous_database_id attribute.
    /// </summary>
    public TerraformExpression AutonomousDatabaseId => this["autonomous_database_id"];

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
    /// The cpu_core_count attribute.
    /// </summary>
    public TerraformExpression CpuCoreCount => this["cpu_core_count"];

    /// <summary>
    /// The data_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformExpression DataStorageSizeInGbs => this["data_storage_size_in_gbs"];

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformExpression DataStorageSizeInTbs => this["data_storage_size_in_tbs"];

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformExpression DbNodeStorageSizeInGbs => this["db_node_storage_size_in_gbs"];

    /// <summary>
    /// The db_version attribute.
    /// </summary>
    public TerraformExpression DbVersion => this["db_version"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The failed_data_recovery_in_seconds attribute.
    /// </summary>
    public TerraformExpression FailedDataRecoveryInSeconds => this["failed_data_recovery_in_seconds"];

    /// <summary>
    /// The in_memory_area_in_gbs attribute.
    /// </summary>
    public TerraformExpression InMemoryAreaInGbs => this["in_memory_area_in_gbs"];

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    public TerraformExpression LifecycleDetails => this["lifecycle_details"];

    /// <summary>
    /// The local_adg_auto_failover_max_data_loss_limit attribute.
    /// </summary>
    public TerraformExpression LocalAdgAutoFailoverMaxDataLossLimit => this["local_adg_auto_failover_max_data_loss_limit"];

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
    /// The memory_per_oracle_compute_unit_in_gbs attribute.
    /// </summary>
    public TerraformExpression MemoryPerOracleComputeUnitInGbs => this["memory_per_oracle_compute_unit_in_gbs"];

    /// <summary>
    /// The mtls_connection_required attribute.
    /// </summary>
    public TerraformExpression MtlsConnectionRequired => this["mtls_connection_required"];

    /// <summary>
    /// The national_character_set attribute.
    /// </summary>
    public TerraformExpression NationalCharacterSet => this["national_character_set"];

    /// <summary>
    /// The next_long_term_backup_time_stamp attribute.
    /// </summary>
    public TerraformExpression NextLongTermBackupTimeStamp => this["next_long_term_backup_time_stamp"];

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    public TerraformExpression OciUrl => this["oci_url"];

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    public TerraformExpression Ocid => this["ocid"];

    /// <summary>
    /// The peer_db_id attribute.
    /// </summary>
    public TerraformExpression PeerDbId => this["peer_db_id"];

    /// <summary>
    /// The peer_db_ids attribute.
    /// </summary>
    public TerraformExpression PeerDbIds => this["peer_db_ids"];

    /// <summary>
    /// The preview attribute.
    /// </summary>
    public TerraformExpression Preview => this["preview"];

    /// <summary>
    /// The preview_version_with_service_terms_accepted attribute.
    /// </summary>
    public TerraformExpression PreviewVersionWithServiceTermsAccepted => this["preview_version_with_service_terms_accepted"];

    /// <summary>
    /// The private_endpoint attribute.
    /// </summary>
    public TerraformExpression PrivateEndpoint => this["private_endpoint"];

    /// <summary>
    /// The private_endpoint_ip attribute.
    /// </summary>
    public TerraformExpression PrivateEndpointIp => this["private_endpoint_ip"];

    /// <summary>
    /// The private_endpoint_label attribute.
    /// </summary>
    public TerraformExpression PrivateEndpointLabel => this["private_endpoint_label"];

    /// <summary>
    /// The provisionable_cpus attribute.
    /// </summary>
    public TerraformExpression ProvisionableCpus => this["provisionable_cpus"];

    /// <summary>
    /// The remote_data_guard_enabled attribute.
    /// </summary>
    public TerraformExpression RemoteDataGuardEnabled => this["remote_data_guard_enabled"];

    /// <summary>
    /// The service_console_url attribute.
    /// </summary>
    public TerraformExpression ServiceConsoleUrl => this["service_console_url"];

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
    /// The time_created attribute.
    /// </summary>
    public TerraformExpression TimeCreated => this["time_created"];

    /// <summary>
    /// The time_data_guard_role_changed attribute.
    /// </summary>
    public TerraformExpression TimeDataGuardRoleChanged => this["time_data_guard_role_changed"];

    /// <summary>
    /// The time_deletion_of_free_autonomous_database attribute.
    /// </summary>
    public TerraformExpression TimeDeletionOfFreeAutonomousDatabase => this["time_deletion_of_free_autonomous_database"];

    /// <summary>
    /// The time_local_data_guard_enabled_on attribute.
    /// </summary>
    public TerraformExpression TimeLocalDataGuardEnabledOn => this["time_local_data_guard_enabled_on"];

    /// <summary>
    /// The time_maintenance_begin attribute.
    /// </summary>
    public TerraformExpression TimeMaintenanceBegin => this["time_maintenance_begin"];

    /// <summary>
    /// The time_maintenance_end attribute.
    /// </summary>
    public TerraformExpression TimeMaintenanceEnd => this["time_maintenance_end"];

    /// <summary>
    /// The time_of_last_failover attribute.
    /// </summary>
    public TerraformExpression TimeOfLastFailover => this["time_of_last_failover"];

    /// <summary>
    /// The time_of_last_refresh attribute.
    /// </summary>
    public TerraformExpression TimeOfLastRefresh => this["time_of_last_refresh"];

    /// <summary>
    /// The time_of_last_refresh_point attribute.
    /// </summary>
    public TerraformExpression TimeOfLastRefreshPoint => this["time_of_last_refresh_point"];

    /// <summary>
    /// The time_of_last_switchover attribute.
    /// </summary>
    public TerraformExpression TimeOfLastSwitchover => this["time_of_last_switchover"];

    /// <summary>
    /// The time_reclamation_of_free_autonomous_database attribute.
    /// </summary>
    public TerraformExpression TimeReclamationOfFreeAutonomousDatabase => this["time_reclamation_of_free_autonomous_database"];

    /// <summary>
    /// The used_data_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformExpression UsedDataStorageSizeInGbs => this["used_data_storage_size_in_gbs"];

    /// <summary>
    /// The used_data_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformExpression UsedDataStorageSizeInTbs => this["used_data_storage_size_in_tbs"];

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformExpression VirtualNetworkId => this["virtual_network_id"];

}
