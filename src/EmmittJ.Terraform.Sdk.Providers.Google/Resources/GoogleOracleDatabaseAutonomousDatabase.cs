using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for properties in .
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseAutonomousDatabasePropertiesBlock : TerraformBlock
{
    /// <summary>
    /// The amount of storage currently being used for user and system data, in
    /// terabytes.
    /// </summary>
    public TerraformProperty<double>? ActualUsedDataStorageSizeTb
    {
        get => GetProperty<TerraformProperty<double>>("actual_used_data_storage_size_tb");
        set => WithProperty("actual_used_data_storage_size_tb", value);
    }

    /// <summary>
    /// The amount of storage currently allocated for the database tables and
    /// billed for, rounded up in terabytes.
    /// </summary>
    public TerraformProperty<double>? AllocatedStorageSizeTb
    {
        get => GetProperty<TerraformProperty<double>>("allocated_storage_size_tb");
        set => WithProperty("allocated_storage_size_tb", value);
    }

    /// <summary>
    /// Oracle APEX Application Development.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/AutonomousDatabaseApex
    /// </summary>
    public List<TerraformProperty<object>>? ApexDetails
    {
        get => GetProperty<List<TerraformProperty<object>>>("apex_details");
        set => WithProperty("apex_details", value);
    }

    /// <summary>
    /// This field indicates the status of Data Guard and Access control for the
    /// Autonomous Database. The field&#39;s value is null if Data Guard is disabled
    /// or Access Control is disabled. The field&#39;s value is TRUE if both Data Guard
    /// and Access Control are enabled, and the Autonomous Database is using
    /// primary IP access control list (ACL) for standby. The field&#39;s value is
    /// FALSE if both Data Guard and Access Control are enabled, and the Autonomous
    /// Database is using a different IP access control list (ACL) for standby
    /// compared to primary.
    /// </summary>
    public TerraformProperty<bool>? ArePrimaryAllowlistedIpsUsed
    {
        get => GetProperty<TerraformProperty<bool>>("are_primary_allowlisted_ips_used");
        set => WithProperty("are_primary_allowlisted_ips_used", value);
    }

    /// <summary>
    /// The Autonomous Container Database OCID.
    /// </summary>
    public TerraformProperty<string>? AutonomousContainerDatabaseId
    {
        get => GetProperty<TerraformProperty<string>>("autonomous_container_database_id");
        set => WithProperty("autonomous_container_database_id", value);
    }

    /// <summary>
    /// The list of available Oracle Database upgrade versions for an Autonomous
    /// Database.
    /// </summary>
    public List<TerraformProperty<string>>? AvailableUpgradeVersions
    {
        get => GetProperty<List<TerraformProperty<string>>>("available_upgrade_versions");
        set => WithProperty("available_upgrade_versions", value);
    }

    /// <summary>
    /// The retention period for the Autonomous Database. This field is specified
    /// in days, can range from 1 day to 60 days, and has a default value of
    /// 60 days.
    /// </summary>
    public TerraformProperty<double>? BackupRetentionPeriodDays
    {
        get => GetProperty<TerraformProperty<double>>("backup_retention_period_days");
        set => WithProperty("backup_retention_period_days", value);
    }

    /// <summary>
    /// The character set for the Autonomous Database. The default is AL32UTF8.
    /// </summary>
    public TerraformProperty<string>? CharacterSet
    {
        get => GetProperty<TerraformProperty<string>>("character_set");
        set => WithProperty("character_set", value);
    }

    /// <summary>
    /// The number of compute servers for the Autonomous Database.
    /// </summary>
    public TerraformProperty<double>? ComputeCount
    {
        get => GetProperty<TerraformProperty<double>>("compute_count");
        set => WithProperty("compute_count", value);
    }

    /// <summary>
    /// The connection string used to connect to the Autonomous Database.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/AutonomousDatabaseConnectionStrings
    /// </summary>
    public List<TerraformProperty<object>>? ConnectionStrings
    {
        get => GetProperty<List<TerraformProperty<object>>>("connection_strings");
        set => WithProperty("connection_strings", value);
    }

    /// <summary>
    /// The URLs for accessing Oracle Application Express (APEX) and SQL Developer
    /// Web with a browser from a Compute instance.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/AutonomousDatabaseConnectionUrls
    /// </summary>
    public List<TerraformProperty<object>>? ConnectionUrls
    {
        get => GetProperty<List<TerraformProperty<object>>>("connection_urls");
        set => WithProperty("connection_urls", value);
    }

    /// <summary>
    /// The current state of the Data Safe registration for the
    /// Autonomous Database. 
    ///  Possible values:
    ///  DATA_SAFE_STATE_UNSPECIFIED
    /// REGISTERING
    /// REGISTERED
    /// DEREGISTERING
    /// NOT_REGISTERED
    /// FAILED
    /// </summary>
    public TerraformProperty<string>? DataSafeState
    {
        get => GetProperty<TerraformProperty<string>>("data_safe_state");
        set => WithProperty("data_safe_state", value);
    }

    /// <summary>
    /// The size of the data stored in the database, in gigabytes.
    /// </summary>
    public TerraformProperty<double>? DataStorageSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("data_storage_size_gb");
        set => WithProperty("data_storage_size_gb", value);
    }

    /// <summary>
    /// The size of the data stored in the database, in terabytes.
    /// </summary>
    public TerraformProperty<double>? DataStorageSizeTb
    {
        get => GetProperty<TerraformProperty<double>>("data_storage_size_tb");
        set => WithProperty("data_storage_size_tb", value);
    }

    /// <summary>
    /// The current state of database management for the Autonomous Database. 
    ///  Possible values:
    ///  DATABASE_MANAGEMENT_STATE_UNSPECIFIED
    /// ENABLING
    /// ENABLED
    /// DISABLING
    /// NOT_ENABLED
    /// FAILED_ENABLING
    /// FAILED_DISABLING
    /// </summary>
    public TerraformProperty<string>? DatabaseManagementState
    {
        get => GetProperty<TerraformProperty<string>>("database_management_state");
        set => WithProperty("database_management_state", value);
    }

    /// <summary>
    /// The edition of the Autonomous Databases. 
    ///  Possible values:
    ///  DATABASE_EDITION_UNSPECIFIED
    /// STANDARD_EDITION
    /// ENTERPRISE_EDITION
    /// </summary>
    public TerraformProperty<string>? DbEdition
    {
        get => GetProperty<TerraformProperty<string>>("db_edition");
        set => WithProperty("db_edition", value);
    }

    /// <summary>
    /// The Oracle Database version for the Autonomous Database.
    /// </summary>
    public TerraformProperty<string>? DbVersion
    {
        get => GetProperty<TerraformProperty<string>>("db_version");
        set => WithProperty("db_version", value);
    }

    /// <summary>
    /// Possible values:
    ///  DB_WORKLOAD_UNSPECIFIED
    /// OLTP
    /// DW
    /// AJD
    /// APEX
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbWorkload is required")]
    public required TerraformProperty<string> DbWorkload
    {
        get => GetProperty<TerraformProperty<string>>("db_workload");
        set => WithProperty("db_workload", value);
    }

    /// <summary>
    /// This field indicates the number of seconds of data loss during a Data
    /// Guard failover.
    /// </summary>
    public TerraformProperty<string>? FailedDataRecoveryDuration
    {
        get => GetProperty<TerraformProperty<string>>("failed_data_recovery_duration");
        set => WithProperty("failed_data_recovery_duration", value);
    }

    /// <summary>
    /// This field indicates if auto scaling is enabled for the Autonomous Database
    /// CPU core count.
    /// </summary>
    public TerraformProperty<bool>? IsAutoScalingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("is_auto_scaling_enabled");
        set => WithProperty("is_auto_scaling_enabled", value);
    }

    /// <summary>
    /// This field indicates whether the Autonomous Database has local (in-region)
    /// Data Guard enabled.
    /// </summary>
    public TerraformProperty<bool>? IsLocalDataGuardEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("is_local_data_guard_enabled");
        set => WithProperty("is_local_data_guard_enabled", value);
    }

    /// <summary>
    /// This field indicates if auto scaling is enabled for the Autonomous Database
    /// storage.
    /// </summary>
    public TerraformProperty<bool>? IsStorageAutoScalingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("is_storage_auto_scaling_enabled");
        set => WithProperty("is_storage_auto_scaling_enabled", value);
    }

    /// <summary>
    /// The license type used for the Autonomous Database. 
    ///  Possible values:
    ///  LICENSE_TYPE_UNSPECIFIED
    /// LICENSE_INCLUDED
    /// BRING_YOUR_OWN_LICENSE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseType is required")]
    public required TerraformProperty<string> LicenseType
    {
        get => GetProperty<TerraformProperty<string>>("license_type");
        set => WithProperty("license_type", value);
    }

    /// <summary>
    /// The details of the current lifestyle state of the Autonomous Database.
    /// </summary>
    public TerraformProperty<string>? LifecycleDetails
    {
        get => GetProperty<TerraformProperty<string>>("lifecycle_details");
        set => WithProperty("lifecycle_details", value);
    }

    /// <summary>
    /// This field indicates the maximum data loss limit for an Autonomous
    /// Database, in seconds.
    /// </summary>
    public TerraformProperty<double>? LocalAdgAutoFailoverMaxDataLossLimit
    {
        get => GetProperty<TerraformProperty<double>>("local_adg_auto_failover_max_data_loss_limit");
        set => WithProperty("local_adg_auto_failover_max_data_loss_limit", value);
    }

    /// <summary>
    /// This field indicates the local disaster recovery (DR) type of an
    /// Autonomous Database. 
    ///  Possible values:
    ///  LOCAL_DISASTER_RECOVERY_TYPE_UNSPECIFIED
    /// ADG
    /// BACKUP_BASED
    /// </summary>
    public TerraformProperty<string>? LocalDisasterRecoveryType
    {
        get => GetProperty<TerraformProperty<string>>("local_disaster_recovery_type");
        set => WithProperty("local_disaster_recovery_type", value);
    }

    /// <summary>
    /// Autonomous Data Guard standby database details.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/AutonomousDatabaseStandbySummary
    /// </summary>
    public List<TerraformProperty<object>>? LocalStandbyDb
    {
        get => GetProperty<List<TerraformProperty<object>>>("local_standby_db");
        set => WithProperty("local_standby_db", value);
    }

    /// <summary>
    /// The date and time when maintenance will begin.
    /// </summary>
    public TerraformProperty<string>? MaintenanceBeginTime
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_begin_time");
        set => WithProperty("maintenance_begin_time", value);
    }

    /// <summary>
    /// The date and time when maintenance will end.
    /// </summary>
    public TerraformProperty<string>? MaintenanceEndTime
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_end_time");
        set => WithProperty("maintenance_end_time", value);
    }

    /// <summary>
    /// The maintenance schedule of the Autonomous Database. 
    ///  Possible values:
    ///  MAINTENANCE_SCHEDULE_TYPE_UNSPECIFIED
    /// EARLY
    /// REGULAR
    /// </summary>
    public TerraformProperty<string>? MaintenanceScheduleType
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_schedule_type");
        set => WithProperty("maintenance_schedule_type", value);
    }

    /// <summary>
    /// The amount of memory enabled per ECPU, in gigabytes.
    /// </summary>
    public TerraformProperty<double>? MemoryPerOracleComputeUnitGbs
    {
        get => GetProperty<TerraformProperty<double>>("memory_per_oracle_compute_unit_gbs");
        set => WithProperty("memory_per_oracle_compute_unit_gbs", value);
    }

    /// <summary>
    /// The memory assigned to in-memory tables in an Autonomous Database.
    /// </summary>
    public TerraformProperty<double>? MemoryTableGbs
    {
        get => GetProperty<TerraformProperty<double>>("memory_table_gbs");
        set => WithProperty("memory_table_gbs", value);
    }

    /// <summary>
    /// This field specifies if the Autonomous Database requires mTLS connections.
    /// </summary>
    public TerraformProperty<bool>? MtlsConnectionRequired
    {
        get => GetProperty<TerraformProperty<bool>>("mtls_connection_required");
        set => WithProperty("mtls_connection_required", value);
    }

    /// <summary>
    /// The national character set for the Autonomous Database. The default is
    /// AL16UTF16.
    /// </summary>
    public TerraformProperty<string>? NCharacterSet
    {
        get => GetProperty<TerraformProperty<string>>("n_character_set");
        set => WithProperty("n_character_set", value);
    }

    /// <summary>
    /// The long term backup schedule of the Autonomous Database.
    /// </summary>
    public TerraformProperty<string>? NextLongTermBackupTime
    {
        get => GetProperty<TerraformProperty<string>>("next_long_term_backup_time");
        set => WithProperty("next_long_term_backup_time", value);
    }

    /// <summary>
    /// The Oracle Cloud Infrastructure link for the Autonomous Database.
    /// </summary>
    public TerraformProperty<string>? OciUrl
    {
        get => GetProperty<TerraformProperty<string>>("oci_url");
        set => WithProperty("oci_url", value);
    }

    /// <summary>
    /// OCID of the Autonomous Database.
    /// https://docs.oracle.com/en-us/iaas/Content/General/Concepts/identifiers.htm#Oracle
    /// </summary>
    public TerraformProperty<string>? Ocid
    {
        get => GetProperty<TerraformProperty<string>>("ocid");
        set => WithProperty("ocid", value);
    }

    /// <summary>
    /// This field indicates the current mode of the Autonomous Database. 
    ///  Possible values:
    ///  OPEN_MODE_UNSPECIFIED
    /// READ_ONLY
    /// READ_WRITE
    /// </summary>
    public TerraformProperty<string>? OpenMode
    {
        get => GetProperty<TerraformProperty<string>>("open_mode");
        set => WithProperty("open_mode", value);
    }

    /// <summary>
    /// Possible values:
    ///  OPERATIONS_INSIGHTS_STATE_UNSPECIFIED
    /// ENABLING
    /// ENABLED
    /// DISABLING
    /// NOT_ENABLED
    /// FAILED_ENABLING
    /// FAILED_DISABLING
    /// </summary>
    public TerraformProperty<string>? OperationsInsightsState
    {
        get => GetProperty<TerraformProperty<string>>("operations_insights_state");
        set => WithProperty("operations_insights_state", value);
    }

    /// <summary>
    /// The list of OCIDs of standby databases located in Autonomous Data Guard
    /// remote regions that are associated with the source database.
    /// </summary>
    public List<TerraformProperty<string>>? PeerDbIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("peer_db_ids");
        set => WithProperty("peer_db_ids", value);
    }

    /// <summary>
    /// The permission level of the Autonomous Database. 
    ///  Possible values:
    ///  PERMISSION_LEVEL_UNSPECIFIED
    /// RESTRICTED
    /// UNRESTRICTED
    /// </summary>
    public TerraformProperty<string>? PermissionLevel
    {
        get => GetProperty<TerraformProperty<string>>("permission_level");
        set => WithProperty("permission_level", value);
    }

    /// <summary>
    /// The private endpoint for the Autonomous Database.
    /// </summary>
    public TerraformProperty<string>? PrivateEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("private_endpoint");
        set => WithProperty("private_endpoint", value);
    }

    /// <summary>
    /// The private endpoint IP address for the Autonomous Database.
    /// </summary>
    public TerraformProperty<string>? PrivateEndpointIp
    {
        get => GetProperty<TerraformProperty<string>>("private_endpoint_ip");
        set => WithProperty("private_endpoint_ip", value);
    }

    /// <summary>
    /// The private endpoint label for the Autonomous Database.
    /// </summary>
    public TerraformProperty<string>? PrivateEndpointLabel
    {
        get => GetProperty<TerraformProperty<string>>("private_endpoint_label");
        set => WithProperty("private_endpoint_label", value);
    }

    /// <summary>
    /// The refresh mode of the cloned Autonomous Database. 
    ///  Possible values:
    ///  REFRESHABLE_MODE_UNSPECIFIED
    /// AUTOMATIC
    /// MANUAL
    /// </summary>
    public TerraformProperty<string>? RefreshableMode
    {
        get => GetProperty<TerraformProperty<string>>("refreshable_mode");
        set => WithProperty("refreshable_mode", value);
    }

    /// <summary>
    /// The refresh State of the clone. 
    ///  Possible values:
    ///  REFRESHABLE_STATE_UNSPECIFIED
    /// REFRESHING
    /// NOT_REFRESHING
    /// </summary>
    public TerraformProperty<string>? RefreshableState
    {
        get => GetProperty<TerraformProperty<string>>("refreshable_state");
        set => WithProperty("refreshable_state", value);
    }

    /// <summary>
    /// The Data Guard role of the Autonomous Database. 
    ///  Possible values:
    ///  ROLE_UNSPECIFIED
    /// PRIMARY
    /// STANDBY
    /// DISABLED_STANDBY
    /// BACKUP_COPY
    /// SNAPSHOT_STANDBY
    /// </summary>
    public TerraformProperty<string>? Role
    {
        get => GetProperty<TerraformProperty<string>>("role");
        set => WithProperty("role", value);
    }

    /// <summary>
    /// The list and details of the scheduled operations of the Autonomous
    /// Database.
    /// </summary>
    public List<TerraformProperty<object>>? ScheduledOperationDetails
    {
        get => GetProperty<List<TerraformProperty<object>>>("scheduled_operation_details");
        set => WithProperty("scheduled_operation_details", value);
    }

    /// <summary>
    /// The SQL Web Developer URL for the Autonomous Database.
    /// </summary>
    public TerraformProperty<string>? SqlWebDeveloperUrl
    {
        get => GetProperty<TerraformProperty<string>>("sql_web_developer_url");
        set => WithProperty("sql_web_developer_url", value);
    }

    /// <summary>
    /// Possible values:
    ///  STATE_UNSPECIFIED
    /// PROVISIONING
    /// AVAILABLE
    /// STOPPING
    /// STOPPED
    /// STARTING
    /// TERMINATING
    /// TERMINATED
    /// UNAVAILABLE
    /// RESTORE_IN_PROGRESS
    /// RESTORE_FAILED
    /// BACKUP_IN_PROGRESS
    /// SCALE_IN_PROGRESS
    /// AVAILABLE_NEEDS_ATTENTION
    /// UPDATING
    /// MAINTENANCE_IN_PROGRESS
    /// RESTARTING
    /// RECREATING
    /// ROLE_CHANGE_IN_PROGRESS
    /// UPGRADING
    /// INACCESSIBLE
    /// STANDBY
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => WithProperty("state", value);
    }

    /// <summary>
    /// The list of available regions that can be used to create a clone for the
    /// Autonomous Database.
    /// </summary>
    public List<TerraformProperty<string>>? SupportedCloneRegions
    {
        get => GetProperty<List<TerraformProperty<string>>>("supported_clone_regions");
        set => WithProperty("supported_clone_regions", value);
    }

    /// <summary>
    /// The storage space used by automatic backups of Autonomous Database, in
    /// gigabytes.
    /// </summary>
    public TerraformProperty<double>? TotalAutoBackupStorageSizeGbs
    {
        get => GetProperty<TerraformProperty<double>>("total_auto_backup_storage_size_gbs");
        set => WithProperty("total_auto_backup_storage_size_gbs", value);
    }

    /// <summary>
    /// The storage space used by Autonomous Database, in gigabytes.
    /// </summary>
    public TerraformProperty<double>? UsedDataStorageSizeTbs
    {
        get => GetProperty<TerraformProperty<double>>("used_data_storage_size_tbs");
        set => WithProperty("used_data_storage_size_tbs", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleOracleDatabaseAutonomousDatabaseTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_oracle_database_autonomous_database resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleOracleDatabaseAutonomousDatabase : TerraformResource
{
    public GoogleOracleDatabaseAutonomousDatabase(string name) : base("google_oracle_database_autonomous_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("entitlement_id");
        this.DeclareOutput("name");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// The password for the default ADMIN user.
    /// </summary>
    public TerraformProperty<string>? AdminPassword
    {
        get => GetProperty<TerraformProperty<string>>("admin_password");
        set => this.WithProperty("admin_password", value);
    }

    /// <summary>
    /// The ID of the Autonomous Database to create. This value is restricted
    /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
    /// characters in length. The value must start with a letter and end with
    /// a letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDatabaseId is required")]
    public required TerraformProperty<string> AutonomousDatabaseId
    {
        get => GetProperty<TerraformProperty<string>>("autonomous_database_id");
        set => this.WithProperty("autonomous_database_id", value);
    }

    /// <summary>
    /// The subnet CIDR range for the Autonmous Database.
    /// </summary>
    public TerraformProperty<string>? Cidr
    {
        get => GetProperty<TerraformProperty<string>>("cidr");
        set => this.WithProperty("cidr", value);
    }

    /// <summary>
    /// The name of the Autonomous Database. The database name must be unique in
    /// the project. The name must begin with a letter and can
    /// contain a maximum of 30 alphanumeric characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformProperty<string> Database
    {
        get => GetProperty<TerraformProperty<string>>("database");
        set => this.WithProperty("database", value);
    }

    /// <summary>
    /// Whether or not to allow Terraform to destroy the instance. Unless this field is set to false in Terraform state, a terraform destroy or terraform apply that would delete the instance will fail.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// The display name for the Autonomous Database. The name does not have to
    /// be unique within your project.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The labels or tags associated with the Autonomous Database. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. See documentation for resource type &#39;oracledatabase.googleapis.com/AutonomousDatabaseBackup&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name of the VPC network used by the Autonomous Database.
    /// Format: projects/{project}/global/networks/{network}
    /// </summary>
    public TerraformProperty<string>? Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// The name of the OdbNetwork associated with the Autonomous Database.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}
    /// It is optional but if specified, this should match the parent ODBNetwork of
    /// the odb_subnet and backup_odb_subnet.
    /// </summary>
    public TerraformProperty<string>? OdbNetwork
    {
        get => GetProperty<TerraformProperty<string>>("odb_network");
        set => this.WithProperty("odb_network", value);
    }

    /// <summary>
    /// The name of the OdbSubnet associated with the Autonomous Database for
    /// IP allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    public TerraformProperty<string>? OdbSubnet
    {
        get => GetProperty<TerraformProperty<string>>("odb_subnet");
        set => this.WithProperty("odb_subnet", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Properties block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    public List<GoogleOracleDatabaseAutonomousDatabasePropertiesBlock>? Properties
    {
        get => GetProperty<List<GoogleOracleDatabaseAutonomousDatabasePropertiesBlock>>("properties");
        set => this.WithProperty("properties", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleOracleDatabaseAutonomousDatabaseTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleOracleDatabaseAutonomousDatabaseTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The date and time that the Autonomous Database was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The ID of the subscription entitlement associated with the Autonomous
    /// Database.
    /// </summary>
    public TerraformExpression EntitlementId => this["entitlement_id"];

    /// <summary>
    /// Identifier. The name of the Autonomous Database resource in the following format:
    /// projects/{project}/locations/{region}/autonomousDatabases/{autonomous_database}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
