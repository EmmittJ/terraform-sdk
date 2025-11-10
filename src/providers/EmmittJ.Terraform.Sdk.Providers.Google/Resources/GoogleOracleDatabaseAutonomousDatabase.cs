using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for properties in .
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseAutonomousDatabasePropertiesBlock : ITerraformBlock
{
    /// <summary>
    /// The amount of storage currently being used for user and system data, in
    /// terabytes.
    /// </summary>
    [TerraformPropertyName("actual_used_data_storage_size_tb")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ActualUsedDataStorageSizeTb => new TerraformReferenceProperty<TerraformProperty<double>>("", "actual_used_data_storage_size_tb");

    /// <summary>
    /// The amount of storage currently allocated for the database tables and
    /// billed for, rounded up in terabytes.
    /// </summary>
    [TerraformPropertyName("allocated_storage_size_tb")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AllocatedStorageSizeTb => new TerraformReferenceProperty<TerraformProperty<double>>("", "allocated_storage_size_tb");

    /// <summary>
    /// Oracle APEX Application Development.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/AutonomousDatabaseApex
    /// </summary>
    [TerraformPropertyName("apex_details")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ApexDetails => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "apex_details");

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
    [TerraformPropertyName("are_primary_allowlisted_ips_used")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ArePrimaryAllowlistedIpsUsed => new TerraformReferenceProperty<TerraformProperty<bool>>("", "are_primary_allowlisted_ips_used");

    /// <summary>
    /// The Autonomous Container Database OCID.
    /// </summary>
    [TerraformPropertyName("autonomous_container_database_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AutonomousContainerDatabaseId => new TerraformReferenceProperty<TerraformProperty<string>>("", "autonomous_container_database_id");

    /// <summary>
    /// The list of available Oracle Database upgrade versions for an Autonomous
    /// Database.
    /// </summary>
    [TerraformPropertyName("available_upgrade_versions")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AvailableUpgradeVersions => new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "available_upgrade_versions");

    /// <summary>
    /// The retention period for the Autonomous Database. This field is specified
    /// in days, can range from 1 day to 60 days, and has a default value of
    /// 60 days.
    /// </summary>
    [TerraformPropertyName("backup_retention_period_days")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> BackupRetentionPeriodDays { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "backup_retention_period_days");

    /// <summary>
    /// The character set for the Autonomous Database. The default is AL32UTF8.
    /// </summary>
    [TerraformPropertyName("character_set")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CharacterSet { get; set; }

    /// <summary>
    /// The number of compute servers for the Autonomous Database.
    /// </summary>
    [TerraformPropertyName("compute_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ComputeCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "compute_count");

    /// <summary>
    /// The connection string used to connect to the Autonomous Database.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/AutonomousDatabaseConnectionStrings
    /// </summary>
    [TerraformPropertyName("connection_strings")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ConnectionStrings => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "connection_strings");

    /// <summary>
    /// The URLs for accessing Oracle Application Express (APEX) and SQL Developer
    /// Web with a browser from a Compute instance.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/AutonomousDatabaseConnectionUrls
    /// </summary>
    [TerraformPropertyName("connection_urls")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ConnectionUrls => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "connection_urls");

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
    [TerraformPropertyName("data_safe_state")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DataSafeState => new TerraformReferenceProperty<TerraformProperty<string>>("", "data_safe_state");

    /// <summary>
    /// The size of the data stored in the database, in gigabytes.
    /// </summary>
    [TerraformPropertyName("data_storage_size_gb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DataStorageSizeGb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "data_storage_size_gb");

    /// <summary>
    /// The size of the data stored in the database, in terabytes.
    /// </summary>
    [TerraformPropertyName("data_storage_size_tb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DataStorageSizeTb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "data_storage_size_tb");

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
    [TerraformPropertyName("database_management_state")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DatabaseManagementState => new TerraformReferenceProperty<TerraformProperty<string>>("", "database_management_state");

    /// <summary>
    /// The edition of the Autonomous Databases. 
    ///  Possible values:
    ///  DATABASE_EDITION_UNSPECIFIED
    /// STANDARD_EDITION
    /// ENTERPRISE_EDITION
    /// </summary>
    [TerraformPropertyName("db_edition")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DbEdition { get; set; }

    /// <summary>
    /// The Oracle Database version for the Autonomous Database.
    /// </summary>
    [TerraformPropertyName("db_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DbVersion { get; set; }

    /// <summary>
    /// Possible values:
    ///  DB_WORKLOAD_UNSPECIFIED
    /// OLTP
    /// DW
    /// AJD
    /// APEX
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbWorkload is required")]
    [TerraformPropertyName("db_workload")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DbWorkload { get; set; }

    /// <summary>
    /// This field indicates the number of seconds of data loss during a Data
    /// Guard failover.
    /// </summary>
    [TerraformPropertyName("failed_data_recovery_duration")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FailedDataRecoveryDuration => new TerraformReferenceProperty<TerraformProperty<string>>("", "failed_data_recovery_duration");

    /// <summary>
    /// This field indicates if auto scaling is enabled for the Autonomous Database
    /// CPU core count.
    /// </summary>
    [TerraformPropertyName("is_auto_scaling_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsAutoScalingEnabled { get; set; }

    /// <summary>
    /// This field indicates whether the Autonomous Database has local (in-region)
    /// Data Guard enabled.
    /// </summary>
    [TerraformPropertyName("is_local_data_guard_enabled")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IsLocalDataGuardEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>("", "is_local_data_guard_enabled");

    /// <summary>
    /// This field indicates if auto scaling is enabled for the Autonomous Database
    /// storage.
    /// </summary>
    [TerraformPropertyName("is_storage_auto_scaling_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> IsStorageAutoScalingEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "is_storage_auto_scaling_enabled");

    /// <summary>
    /// The license type used for the Autonomous Database. 
    ///  Possible values:
    ///  LICENSE_TYPE_UNSPECIFIED
    /// LICENSE_INCLUDED
    /// BRING_YOUR_OWN_LICENSE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseType is required")]
    [TerraformPropertyName("license_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LicenseType { get; set; }

    /// <summary>
    /// The details of the current lifestyle state of the Autonomous Database.
    /// </summary>
    [TerraformPropertyName("lifecycle_details")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LifecycleDetails => new TerraformReferenceProperty<TerraformProperty<string>>("", "lifecycle_details");

    /// <summary>
    /// This field indicates the maximum data loss limit for an Autonomous
    /// Database, in seconds.
    /// </summary>
    [TerraformPropertyName("local_adg_auto_failover_max_data_loss_limit")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> LocalAdgAutoFailoverMaxDataLossLimit => new TerraformReferenceProperty<TerraformProperty<double>>("", "local_adg_auto_failover_max_data_loss_limit");

    /// <summary>
    /// This field indicates the local disaster recovery (DR) type of an
    /// Autonomous Database. 
    ///  Possible values:
    ///  LOCAL_DISASTER_RECOVERY_TYPE_UNSPECIFIED
    /// ADG
    /// BACKUP_BASED
    /// </summary>
    [TerraformPropertyName("local_disaster_recovery_type")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LocalDisasterRecoveryType => new TerraformReferenceProperty<TerraformProperty<string>>("", "local_disaster_recovery_type");

    /// <summary>
    /// Autonomous Data Guard standby database details.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/AutonomousDatabaseStandbySummary
    /// </summary>
    [TerraformPropertyName("local_standby_db")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LocalStandbyDb => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "local_standby_db");

    /// <summary>
    /// The date and time when maintenance will begin.
    /// </summary>
    [TerraformPropertyName("maintenance_begin_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MaintenanceBeginTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "maintenance_begin_time");

    /// <summary>
    /// The date and time when maintenance will end.
    /// </summary>
    [TerraformPropertyName("maintenance_end_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MaintenanceEndTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "maintenance_end_time");

    /// <summary>
    /// The maintenance schedule of the Autonomous Database. 
    ///  Possible values:
    ///  MAINTENANCE_SCHEDULE_TYPE_UNSPECIFIED
    /// EARLY
    /// REGULAR
    /// </summary>
    [TerraformPropertyName("maintenance_schedule_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MaintenanceScheduleType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "maintenance_schedule_type");

    /// <summary>
    /// The amount of memory enabled per ECPU, in gigabytes.
    /// </summary>
    [TerraformPropertyName("memory_per_oracle_compute_unit_gbs")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MemoryPerOracleComputeUnitGbs => new TerraformReferenceProperty<TerraformProperty<double>>("", "memory_per_oracle_compute_unit_gbs");

    /// <summary>
    /// The memory assigned to in-memory tables in an Autonomous Database.
    /// </summary>
    [TerraformPropertyName("memory_table_gbs")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MemoryTableGbs => new TerraformReferenceProperty<TerraformProperty<double>>("", "memory_table_gbs");

    /// <summary>
    /// This field specifies if the Autonomous Database requires mTLS connections.
    /// </summary>
    [TerraformPropertyName("mtls_connection_required")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MtlsConnectionRequired { get; set; }

    /// <summary>
    /// The national character set for the Autonomous Database. The default is
    /// AL16UTF16.
    /// </summary>
    [TerraformPropertyName("n_character_set")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NCharacterSet { get; set; }

    /// <summary>
    /// The long term backup schedule of the Autonomous Database.
    /// </summary>
    [TerraformPropertyName("next_long_term_backup_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NextLongTermBackupTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "next_long_term_backup_time");

    /// <summary>
    /// The Oracle Cloud Infrastructure link for the Autonomous Database.
    /// </summary>
    [TerraformPropertyName("oci_url")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciUrl => new TerraformReferenceProperty<TerraformProperty<string>>("", "oci_url");

    /// <summary>
    /// OCID of the Autonomous Database.
    /// https://docs.oracle.com/en-us/iaas/Content/General/Concepts/identifiers.htm#Oracle
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ocid => new TerraformReferenceProperty<TerraformProperty<string>>("", "ocid");

    /// <summary>
    /// This field indicates the current mode of the Autonomous Database. 
    ///  Possible values:
    ///  OPEN_MODE_UNSPECIFIED
    /// READ_ONLY
    /// READ_WRITE
    /// </summary>
    [TerraformPropertyName("open_mode")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OpenMode => new TerraformReferenceProperty<TerraformProperty<string>>("", "open_mode");

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
    [TerraformPropertyName("operations_insights_state")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OperationsInsightsState { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "operations_insights_state");

    /// <summary>
    /// The list of OCIDs of standby databases located in Autonomous Data Guard
    /// remote regions that are associated with the source database.
    /// </summary>
    [TerraformPropertyName("peer_db_ids")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> PeerDbIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "peer_db_ids");

    /// <summary>
    /// The permission level of the Autonomous Database. 
    ///  Possible values:
    ///  PERMISSION_LEVEL_UNSPECIFIED
    /// RESTRICTED
    /// UNRESTRICTED
    /// </summary>
    [TerraformPropertyName("permission_level")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PermissionLevel => new TerraformReferenceProperty<TerraformProperty<string>>("", "permission_level");

    /// <summary>
    /// The private endpoint for the Autonomous Database.
    /// </summary>
    [TerraformPropertyName("private_endpoint")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>("", "private_endpoint");

    /// <summary>
    /// The private endpoint IP address for the Autonomous Database.
    /// </summary>
    [TerraformPropertyName("private_endpoint_ip")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PrivateEndpointIp { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "private_endpoint_ip");

    /// <summary>
    /// The private endpoint label for the Autonomous Database.
    /// </summary>
    [TerraformPropertyName("private_endpoint_label")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PrivateEndpointLabel { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "private_endpoint_label");

    /// <summary>
    /// The refresh mode of the cloned Autonomous Database. 
    ///  Possible values:
    ///  REFRESHABLE_MODE_UNSPECIFIED
    /// AUTOMATIC
    /// MANUAL
    /// </summary>
    [TerraformPropertyName("refreshable_mode")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RefreshableMode => new TerraformReferenceProperty<TerraformProperty<string>>("", "refreshable_mode");

    /// <summary>
    /// The refresh State of the clone. 
    ///  Possible values:
    ///  REFRESHABLE_STATE_UNSPECIFIED
    /// REFRESHING
    /// NOT_REFRESHING
    /// </summary>
    [TerraformPropertyName("refreshable_state")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RefreshableState => new TerraformReferenceProperty<TerraformProperty<string>>("", "refreshable_state");

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
    [TerraformPropertyName("role")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Role => new TerraformReferenceProperty<TerraformProperty<string>>("", "role");

    /// <summary>
    /// The list and details of the scheduled operations of the Autonomous
    /// Database.
    /// </summary>
    [TerraformPropertyName("scheduled_operation_details")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ScheduledOperationDetails => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "scheduled_operation_details");

    /// <summary>
    /// The SQL Web Developer URL for the Autonomous Database.
    /// </summary>
    [TerraformPropertyName("sql_web_developer_url")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SqlWebDeveloperUrl => new TerraformReferenceProperty<TerraformProperty<string>>("", "sql_web_developer_url");

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
    [TerraformPropertyName("state")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>("", "state");

    /// <summary>
    /// The list of available regions that can be used to create a clone for the
    /// Autonomous Database.
    /// </summary>
    [TerraformPropertyName("supported_clone_regions")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SupportedCloneRegions => new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "supported_clone_regions");

    /// <summary>
    /// The storage space used by automatic backups of Autonomous Database, in
    /// gigabytes.
    /// </summary>
    [TerraformPropertyName("total_auto_backup_storage_size_gbs")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalAutoBackupStorageSizeGbs => new TerraformReferenceProperty<TerraformProperty<double>>("", "total_auto_backup_storage_size_gbs");

    /// <summary>
    /// The storage space used by Autonomous Database, in gigabytes.
    /// </summary>
    [TerraformPropertyName("used_data_storage_size_tbs")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> UsedDataStorageSizeTbs => new TerraformReferenceProperty<TerraformProperty<double>>("", "used_data_storage_size_tbs");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleOracleDatabaseAutonomousDatabaseTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_oracle_database_autonomous_database resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleOracleDatabaseAutonomousDatabase : TerraformResource
{
    public GoogleOracleDatabaseAutonomousDatabase(string name) : base("google_oracle_database_autonomous_database", name)
    {
    }

    /// <summary>
    /// The password for the default ADMIN user.
    /// </summary>
    [TerraformPropertyName("admin_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdminPassword { get; set; }

    /// <summary>
    /// The ID of the Autonomous Database to create. This value is restricted
    /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
    /// characters in length. The value must start with a letter and end with
    /// a letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDatabaseId is required")]
    [TerraformPropertyName("autonomous_database_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AutonomousDatabaseId { get; set; }

    /// <summary>
    /// The subnet CIDR range for the Autonmous Database.
    /// </summary>
    [TerraformPropertyName("cidr")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Cidr { get; set; }

    /// <summary>
    /// The name of the Autonomous Database. The database name must be unique in
    /// the project. The name must begin with a letter and can
    /// contain a maximum of 30 alphanumeric characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    [TerraformPropertyName("database")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Database { get; set; }

    /// <summary>
    /// Whether or not to allow Terraform to destroy the instance. Unless this field is set to false in Terraform state, a terraform destroy or terraform apply that would delete the instance will fail.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeletionProtection { get; set; }

    /// <summary>
    /// The display name for the Autonomous Database. The name does not have to
    /// be unique within your project.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DisplayName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The labels or tags associated with the Autonomous Database. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. See documentation for resource type &#39;oracledatabase.googleapis.com/AutonomousDatabaseBackup&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name of the VPC network used by the Autonomous Database.
    /// Format: projects/{project}/global/networks/{network}
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Network { get; set; }

    /// <summary>
    /// The name of the OdbNetwork associated with the Autonomous Database.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}
    /// It is optional but if specified, this should match the parent ODBNetwork of
    /// the odb_subnet and backup_odb_subnet.
    /// </summary>
    [TerraformPropertyName("odb_network")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OdbNetwork { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "odb_network");

    /// <summary>
    /// The name of the OdbSubnet associated with the Autonomous Database for
    /// IP allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    [TerraformPropertyName("odb_subnet")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OdbSubnet { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "odb_subnet");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Properties is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Properties block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    [TerraformPropertyName("properties")]
    public TerraformList<TerraformBlock<GoogleOracleDatabaseAutonomousDatabasePropertiesBlock>>? Properties { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleOracleDatabaseAutonomousDatabaseTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The date and time that the Autonomous Database was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The ID of the subscription entitlement associated with the Autonomous
    /// Database.
    /// </summary>
    [TerraformPropertyName("entitlement_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EntitlementId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "entitlement_id");

    /// <summary>
    /// Identifier. The name of the Autonomous Database resource in the following format:
    /// projects/{project}/locations/{region}/autonomousDatabases/{autonomous_database}
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
