using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for properties in GoogleOracleDatabaseAutonomousDatabase.
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseAutonomousDatabasePropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "properties";

    /// <summary>
    /// The amount of storage currently being used for user and system data, in
    /// terabytes.
    /// </summary>
    public TerraformValue<double> ActualUsedDataStorageSizeTb
        => AsReference("actual_used_data_storage_size_tb");

    /// <summary>
    /// The amount of storage currently allocated for the database tables and
    /// billed for, rounded up in terabytes.
    /// </summary>
    public TerraformValue<double> AllocatedStorageSizeTb
        => AsReference("allocated_storage_size_tb");

    /// <summary>
    /// Oracle APEX Application Development.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/AutonomousDatabaseApex
    /// </summary>
    public TerraformList<TerraformMap<object>> ApexDetails
        => AsReference("apex_details");

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
    public TerraformValue<bool> ArePrimaryAllowlistedIpsUsed
        => AsReference("are_primary_allowlisted_ips_used");

    /// <summary>
    /// The Autonomous Container Database OCID.
    /// </summary>
    public TerraformValue<string> AutonomousContainerDatabaseId
        => AsReference("autonomous_container_database_id");

    /// <summary>
    /// The list of available Oracle Database upgrade versions for an Autonomous
    /// Database.
    /// </summary>
    public TerraformList<string> AvailableUpgradeVersions
        => AsReference("available_upgrade_versions");

    /// <summary>
    /// The retention period for the Autonomous Database. This field is specified
    /// in days, can range from 1 day to 60 days, and has a default value of
    /// 60 days.
    /// </summary>
    public TerraformValue<double> BackupRetentionPeriodDays
    {
        get => GetArgument<TerraformValue<double>>("backup_retention_period_days") ?? AsReference("backup_retention_period_days");
        set => SetArgument("backup_retention_period_days", value);
    }

    /// <summary>
    /// The character set for the Autonomous Database. The default is AL32UTF8.
    /// </summary>
    public TerraformValue<string>? CharacterSet
    {
        get => GetArgument<TerraformValue<string>>("character_set");
        set => SetArgument("character_set", value);
    }

    /// <summary>
    /// The number of compute servers for the Autonomous Database.
    /// </summary>
    public TerraformValue<double> ComputeCount
    {
        get => GetArgument<TerraformValue<double>>("compute_count") ?? AsReference("compute_count");
        set => SetArgument("compute_count", value);
    }

    /// <summary>
    /// The connection string used to connect to the Autonomous Database.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/AutonomousDatabaseConnectionStrings
    /// </summary>
    public TerraformList<TerraformMap<object>> ConnectionStrings
        => AsReference("connection_strings");

    /// <summary>
    /// The URLs for accessing Oracle Application Express (APEX) and SQL Developer
    /// Web with a browser from a Compute instance.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/AutonomousDatabaseConnectionUrls
    /// </summary>
    public TerraformList<TerraformMap<object>> ConnectionUrls
        => AsReference("connection_urls");

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
    public TerraformValue<string> DataSafeState
        => AsReference("data_safe_state");

    /// <summary>
    /// The size of the data stored in the database, in gigabytes.
    /// </summary>
    public TerraformValue<double> DataStorageSizeGb
    {
        get => GetArgument<TerraformValue<double>>("data_storage_size_gb") ?? AsReference("data_storage_size_gb");
        set => SetArgument("data_storage_size_gb", value);
    }

    /// <summary>
    /// The size of the data stored in the database, in terabytes.
    /// </summary>
    public TerraformValue<double> DataStorageSizeTb
    {
        get => GetArgument<TerraformValue<double>>("data_storage_size_tb") ?? AsReference("data_storage_size_tb");
        set => SetArgument("data_storage_size_tb", value);
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
    public TerraformValue<string> DatabaseManagementState
        => AsReference("database_management_state");

    /// <summary>
    /// The edition of the Autonomous Databases. 
    ///  Possible values:
    ///  DATABASE_EDITION_UNSPECIFIED
    /// STANDARD_EDITION
    /// ENTERPRISE_EDITION
    /// </summary>
    public TerraformValue<string>? DbEdition
    {
        get => GetArgument<TerraformValue<string>>("db_edition");
        set => SetArgument("db_edition", value);
    }

    /// <summary>
    /// The Oracle Database version for the Autonomous Database.
    /// </summary>
    public TerraformValue<string>? DbVersion
    {
        get => GetArgument<TerraformValue<string>>("db_version");
        set => SetArgument("db_version", value);
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
    public required TerraformValue<string> DbWorkload
    {
        get => GetRequiredArgument<TerraformValue<string>>("db_workload");
        set => SetArgument("db_workload", value);
    }

    /// <summary>
    /// This field indicates the number of seconds of data loss during a Data
    /// Guard failover.
    /// </summary>
    public TerraformValue<string> FailedDataRecoveryDuration
        => AsReference("failed_data_recovery_duration");

    /// <summary>
    /// This field indicates if auto scaling is enabled for the Autonomous Database
    /// CPU core count.
    /// </summary>
    public TerraformValue<bool>? IsAutoScalingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("is_auto_scaling_enabled");
        set => SetArgument("is_auto_scaling_enabled", value);
    }

    /// <summary>
    /// This field indicates whether the Autonomous Database has local (in-region)
    /// Data Guard enabled.
    /// </summary>
    public TerraformValue<bool> IsLocalDataGuardEnabled
        => AsReference("is_local_data_guard_enabled");

    /// <summary>
    /// This field indicates if auto scaling is enabled for the Autonomous Database
    /// storage.
    /// </summary>
    public TerraformValue<bool> IsStorageAutoScalingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("is_storage_auto_scaling_enabled") ?? AsReference("is_storage_auto_scaling_enabled");
        set => SetArgument("is_storage_auto_scaling_enabled", value);
    }

    /// <summary>
    /// The license type used for the Autonomous Database. 
    ///  Possible values:
    ///  LICENSE_TYPE_UNSPECIFIED
    /// LICENSE_INCLUDED
    /// BRING_YOUR_OWN_LICENSE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseType is required")]
    public required TerraformValue<string> LicenseType
    {
        get => GetRequiredArgument<TerraformValue<string>>("license_type");
        set => SetArgument("license_type", value);
    }

    /// <summary>
    /// The details of the current lifestyle state of the Autonomous Database.
    /// </summary>
    public TerraformValue<string> LifecycleDetails
        => AsReference("lifecycle_details");

    /// <summary>
    /// This field indicates the maximum data loss limit for an Autonomous
    /// Database, in seconds.
    /// </summary>
    public TerraformValue<double> LocalAdgAutoFailoverMaxDataLossLimit
        => AsReference("local_adg_auto_failover_max_data_loss_limit");

    /// <summary>
    /// This field indicates the local disaster recovery (DR) type of an
    /// Autonomous Database. 
    ///  Possible values:
    ///  LOCAL_DISASTER_RECOVERY_TYPE_UNSPECIFIED
    /// ADG
    /// BACKUP_BASED
    /// </summary>
    public TerraformValue<string> LocalDisasterRecoveryType
        => AsReference("local_disaster_recovery_type");

    /// <summary>
    /// Autonomous Data Guard standby database details.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/AutonomousDatabaseStandbySummary
    /// </summary>
    public TerraformList<TerraformMap<object>> LocalStandbyDb
        => AsReference("local_standby_db");

    /// <summary>
    /// The date and time when maintenance will begin.
    /// </summary>
    public TerraformValue<string> MaintenanceBeginTime
        => AsReference("maintenance_begin_time");

    /// <summary>
    /// The date and time when maintenance will end.
    /// </summary>
    public TerraformValue<string> MaintenanceEndTime
        => AsReference("maintenance_end_time");

    /// <summary>
    /// The maintenance schedule of the Autonomous Database. 
    ///  Possible values:
    ///  MAINTENANCE_SCHEDULE_TYPE_UNSPECIFIED
    /// EARLY
    /// REGULAR
    /// </summary>
    public TerraformValue<string> MaintenanceScheduleType
    {
        get => GetArgument<TerraformValue<string>>("maintenance_schedule_type") ?? AsReference("maintenance_schedule_type");
        set => SetArgument("maintenance_schedule_type", value);
    }

    /// <summary>
    /// The amount of memory enabled per ECPU, in gigabytes.
    /// </summary>
    public TerraformValue<double> MemoryPerOracleComputeUnitGbs
        => AsReference("memory_per_oracle_compute_unit_gbs");

    /// <summary>
    /// The memory assigned to in-memory tables in an Autonomous Database.
    /// </summary>
    public TerraformValue<double> MemoryTableGbs
        => AsReference("memory_table_gbs");

    /// <summary>
    /// This field specifies if the Autonomous Database requires mTLS connections.
    /// </summary>
    public TerraformValue<bool>? MtlsConnectionRequired
    {
        get => GetArgument<TerraformValue<bool>>("mtls_connection_required");
        set => SetArgument("mtls_connection_required", value);
    }

    /// <summary>
    /// The national character set for the Autonomous Database. The default is
    /// AL16UTF16.
    /// </summary>
    public TerraformValue<string>? NCharacterSet
    {
        get => GetArgument<TerraformValue<string>>("n_character_set");
        set => SetArgument("n_character_set", value);
    }

    /// <summary>
    /// The long term backup schedule of the Autonomous Database.
    /// </summary>
    public TerraformValue<string> NextLongTermBackupTime
        => AsReference("next_long_term_backup_time");

    /// <summary>
    /// The Oracle Cloud Infrastructure link for the Autonomous Database.
    /// </summary>
    public TerraformValue<string> OciUrl
        => AsReference("oci_url");

    /// <summary>
    /// OCID of the Autonomous Database.
    /// https://docs.oracle.com/en-us/iaas/Content/General/Concepts/identifiers.htm#Oracle
    /// </summary>
    public TerraformValue<string> Ocid
        => AsReference("ocid");

    /// <summary>
    /// This field indicates the current mode of the Autonomous Database. 
    ///  Possible values:
    ///  OPEN_MODE_UNSPECIFIED
    /// READ_ONLY
    /// READ_WRITE
    /// </summary>
    public TerraformValue<string> OpenMode
        => AsReference("open_mode");

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
    public TerraformValue<string> OperationsInsightsState
    {
        get => GetArgument<TerraformValue<string>>("operations_insights_state") ?? AsReference("operations_insights_state");
        set => SetArgument("operations_insights_state", value);
    }

    /// <summary>
    /// The list of OCIDs of standby databases located in Autonomous Data Guard
    /// remote regions that are associated with the source database.
    /// </summary>
    public TerraformList<string> PeerDbIds
        => AsReference("peer_db_ids");

    /// <summary>
    /// The permission level of the Autonomous Database. 
    ///  Possible values:
    ///  PERMISSION_LEVEL_UNSPECIFIED
    /// RESTRICTED
    /// UNRESTRICTED
    /// </summary>
    public TerraformValue<string> PermissionLevel
        => AsReference("permission_level");

    /// <summary>
    /// The private endpoint for the Autonomous Database.
    /// </summary>
    public TerraformValue<string> PrivateEndpoint
        => AsReference("private_endpoint");

    /// <summary>
    /// The private endpoint IP address for the Autonomous Database.
    /// </summary>
    public TerraformValue<string> PrivateEndpointIp
    {
        get => GetArgument<TerraformValue<string>>("private_endpoint_ip") ?? AsReference("private_endpoint_ip");
        set => SetArgument("private_endpoint_ip", value);
    }

    /// <summary>
    /// The private endpoint label for the Autonomous Database.
    /// </summary>
    public TerraformValue<string> PrivateEndpointLabel
    {
        get => GetArgument<TerraformValue<string>>("private_endpoint_label") ?? AsReference("private_endpoint_label");
        set => SetArgument("private_endpoint_label", value);
    }

    /// <summary>
    /// The refresh mode of the cloned Autonomous Database. 
    ///  Possible values:
    ///  REFRESHABLE_MODE_UNSPECIFIED
    /// AUTOMATIC
    /// MANUAL
    /// </summary>
    public TerraformValue<string> RefreshableMode
        => AsReference("refreshable_mode");

    /// <summary>
    /// The refresh State of the clone. 
    ///  Possible values:
    ///  REFRESHABLE_STATE_UNSPECIFIED
    /// REFRESHING
    /// NOT_REFRESHING
    /// </summary>
    public TerraformValue<string> RefreshableState
        => AsReference("refreshable_state");

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
    public TerraformValue<string> Role
        => AsReference("role");

    /// <summary>
    /// The list and details of the scheduled operations of the Autonomous
    /// Database.
    /// </summary>
    public TerraformList<TerraformMap<object>> ScheduledOperationDetails
        => AsReference("scheduled_operation_details");

    /// <summary>
    /// The SQL Web Developer URL for the Autonomous Database.
    /// </summary>
    public TerraformValue<string> SqlWebDeveloperUrl
        => AsReference("sql_web_developer_url");

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
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The list of available regions that can be used to create a clone for the
    /// Autonomous Database.
    /// </summary>
    public TerraformList<string> SupportedCloneRegions
        => AsReference("supported_clone_regions");

    /// <summary>
    /// The storage space used by automatic backups of Autonomous Database, in
    /// gigabytes.
    /// </summary>
    public TerraformValue<double> TotalAutoBackupStorageSizeGbs
        => AsReference("total_auto_backup_storage_size_gbs");

    /// <summary>
    /// The storage space used by Autonomous Database, in gigabytes.
    /// </summary>
    public TerraformValue<double> UsedDataStorageSizeTbs
        => AsReference("used_data_storage_size_tbs");

    /// <summary>
    /// CustomerContacts block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleOracleDatabaseAutonomousDatabasePropertiesBlockCustomerContactsBlock>? CustomerContacts
    {
        get => GetArgument<TerraformList<GoogleOracleDatabaseAutonomousDatabasePropertiesBlockCustomerContactsBlock>>("customer_contacts");
        set => SetArgument("customer_contacts", value);
    }

}

/// <summary>
/// Block type for customer_contacts in GoogleOracleDatabaseAutonomousDatabasePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseAutonomousDatabasePropertiesBlockCustomerContactsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customer_contacts";

    /// <summary>
    /// The email address used by Oracle to send notifications regarding databases
    /// and infrastructure.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => GetRequiredArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleOracleDatabaseAutonomousDatabase.
/// Nesting mode: single
/// </summary>
public class GoogleOracleDatabaseAutonomousDatabaseTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_oracle_database_autonomous_database Terraform resource.
/// Manages a google_oracle_database_autonomous_database resource.
/// </summary>
public partial class GoogleOracleDatabaseAutonomousDatabase(string name) : TerraformResource("google_oracle_database_autonomous_database", name)
{
    /// <summary>
    /// The password for the default ADMIN user.
    /// </summary>
    public TerraformValue<string>? AdminPassword
    {
        get => GetArgument<TerraformValue<string>>("admin_password");
        set => SetArgument("admin_password", value);
    }

    /// <summary>
    /// The ID of the Autonomous Database to create. This value is restricted
    /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
    /// characters in length. The value must start with a letter and end with
    /// a letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDatabaseId is required")]
    public required TerraformValue<string> AutonomousDatabaseId
    {
        get => GetRequiredArgument<TerraformValue<string>>("autonomous_database_id");
        set => SetArgument("autonomous_database_id", value);
    }

    /// <summary>
    /// The subnet CIDR range for the Autonmous Database.
    /// </summary>
    public TerraformValue<string>? Cidr
    {
        get => GetArgument<TerraformValue<string>>("cidr");
        set => SetArgument("cidr", value);
    }

    /// <summary>
    /// The name of the Autonomous Database. The database name must be unique in
    /// the project. The name must begin with a letter and can
    /// contain a maximum of 30 alphanumeric characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetRequiredArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// Whether or not to allow Terraform to destroy the instance. Unless this field is set to false in Terraform state, a terraform destroy or terraform apply that would delete the instance will fail.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// The display name for the Autonomous Database. The name does not have to
    /// be unique within your project.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name") ?? AsReference("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The labels or tags associated with the Autonomous Database. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. See documentation for resource type &#39;oracledatabase.googleapis.com/AutonomousDatabaseBackup&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of the VPC network used by the Autonomous Database.
    /// Format: projects/{project}/global/networks/{network}
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The name of the OdbNetwork associated with the Autonomous Database.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}
    /// It is optional but if specified, this should match the parent ODBNetwork of
    /// the odb_subnet and backup_odb_subnet.
    /// </summary>
    public TerraformValue<string> OdbNetwork
    {
        get => GetArgument<TerraformValue<string>>("odb_network") ?? AsReference("odb_network");
        set => SetArgument("odb_network", value);
    }

    /// <summary>
    /// The name of the OdbSubnet associated with the Autonomous Database for
    /// IP allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    public TerraformValue<string> OdbSubnet
    {
        get => GetArgument<TerraformValue<string>>("odb_subnet") ?? AsReference("odb_subnet");
        set => SetArgument("odb_subnet", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The date and time that the Autonomous Database was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The ID of the subscription entitlement associated with the Autonomous
    /// Database.
    /// </summary>
    public TerraformValue<string> EntitlementId
        => AsReference("entitlement_id");

    /// <summary>
    /// Identifier. The name of the Autonomous Database resource in the following format:
    /// projects/{project}/locations/{region}/autonomousDatabases/{autonomous_database}
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Properties block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Properties is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Properties block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    public required TerraformList<GoogleOracleDatabaseAutonomousDatabasePropertiesBlock> Properties
    {
        get => GetRequiredArgument<TerraformList<GoogleOracleDatabaseAutonomousDatabasePropertiesBlock>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleOracleDatabaseAutonomousDatabaseTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleOracleDatabaseAutonomousDatabaseTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
