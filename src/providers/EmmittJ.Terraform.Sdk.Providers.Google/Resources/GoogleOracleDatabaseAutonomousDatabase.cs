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
    {
        get => new TerraformReference<double>(this, "actual_used_data_storage_size_tb");
    }

    /// <summary>
    /// The amount of storage currently allocated for the database tables and
    /// billed for, rounded up in terabytes.
    /// </summary>
    public TerraformValue<double> AllocatedStorageSizeTb
    {
        get => new TerraformReference<double>(this, "allocated_storage_size_tb");
    }

    /// <summary>
    /// Oracle APEX Application Development.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/AutonomousDatabaseApex
    /// </summary>
    public TerraformList<TerraformMap<object>> ApexDetails
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "apex_details").ResolveNodes(ctx));
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
    public TerraformValue<bool> ArePrimaryAllowlistedIpsUsed
    {
        get => new TerraformReference<bool>(this, "are_primary_allowlisted_ips_used");
    }

    /// <summary>
    /// The Autonomous Container Database OCID.
    /// </summary>
    public TerraformValue<string> AutonomousContainerDatabaseId
    {
        get => new TerraformReference<string>(this, "autonomous_container_database_id");
    }

    /// <summary>
    /// The list of available Oracle Database upgrade versions for an Autonomous
    /// Database.
    /// </summary>
    public TerraformList<string> AvailableUpgradeVersions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "available_upgrade_versions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The retention period for the Autonomous Database. This field is specified
    /// in days, can range from 1 day to 60 days, and has a default value of
    /// 60 days.
    /// </summary>
    public TerraformValue<double> BackupRetentionPeriodDays
    {
        get => new TerraformReference<double>(this, "backup_retention_period_days");
        set => SetArgument("backup_retention_period_days", value);
    }

    /// <summary>
    /// The character set for the Autonomous Database. The default is AL32UTF8.
    /// </summary>
    public TerraformValue<string>? CharacterSet
    {
        get => new TerraformReference<string>(this, "character_set");
        set => SetArgument("character_set", value);
    }

    /// <summary>
    /// The number of compute servers for the Autonomous Database.
    /// </summary>
    public TerraformValue<double> ComputeCount
    {
        get => new TerraformReference<double>(this, "compute_count");
        set => SetArgument("compute_count", value);
    }

    /// <summary>
    /// The connection string used to connect to the Autonomous Database.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/AutonomousDatabaseConnectionStrings
    /// </summary>
    public TerraformList<TerraformMap<object>> ConnectionStrings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "connection_strings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The URLs for accessing Oracle Application Express (APEX) and SQL Developer
    /// Web with a browser from a Compute instance.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/AutonomousDatabaseConnectionUrls
    /// </summary>
    public TerraformList<TerraformMap<object>> ConnectionUrls
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "connection_urls").ResolveNodes(ctx));
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
    public TerraformValue<string> DataSafeState
    {
        get => new TerraformReference<string>(this, "data_safe_state");
    }

    /// <summary>
    /// The size of the data stored in the database, in gigabytes.
    /// </summary>
    public TerraformValue<double> DataStorageSizeGb
    {
        get => new TerraformReference<double>(this, "data_storage_size_gb");
        set => SetArgument("data_storage_size_gb", value);
    }

    /// <summary>
    /// The size of the data stored in the database, in terabytes.
    /// </summary>
    public TerraformValue<double> DataStorageSizeTb
    {
        get => new TerraformReference<double>(this, "data_storage_size_tb");
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
    {
        get => new TerraformReference<string>(this, "database_management_state");
    }

    /// <summary>
    /// The edition of the Autonomous Databases. 
    ///  Possible values:
    ///  DATABASE_EDITION_UNSPECIFIED
    /// STANDARD_EDITION
    /// ENTERPRISE_EDITION
    /// </summary>
    public TerraformValue<string>? DbEdition
    {
        get => new TerraformReference<string>(this, "db_edition");
        set => SetArgument("db_edition", value);
    }

    /// <summary>
    /// The Oracle Database version for the Autonomous Database.
    /// </summary>
    public TerraformValue<string>? DbVersion
    {
        get => new TerraformReference<string>(this, "db_version");
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
        get => new TerraformReference<string>(this, "db_workload");
        set => SetArgument("db_workload", value);
    }

    /// <summary>
    /// This field indicates the number of seconds of data loss during a Data
    /// Guard failover.
    /// </summary>
    public TerraformValue<string> FailedDataRecoveryDuration
    {
        get => new TerraformReference<string>(this, "failed_data_recovery_duration");
    }

    /// <summary>
    /// This field indicates if auto scaling is enabled for the Autonomous Database
    /// CPU core count.
    /// </summary>
    public TerraformValue<bool>? IsAutoScalingEnabled
    {
        get => new TerraformReference<bool>(this, "is_auto_scaling_enabled");
        set => SetArgument("is_auto_scaling_enabled", value);
    }

    /// <summary>
    /// This field indicates whether the Autonomous Database has local (in-region)
    /// Data Guard enabled.
    /// </summary>
    public TerraformValue<bool> IsLocalDataGuardEnabled
    {
        get => new TerraformReference<bool>(this, "is_local_data_guard_enabled");
    }

    /// <summary>
    /// This field indicates if auto scaling is enabled for the Autonomous Database
    /// storage.
    /// </summary>
    public TerraformValue<bool> IsStorageAutoScalingEnabled
    {
        get => new TerraformReference<bool>(this, "is_storage_auto_scaling_enabled");
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
        get => new TerraformReference<string>(this, "license_type");
        set => SetArgument("license_type", value);
    }

    /// <summary>
    /// The details of the current lifestyle state of the Autonomous Database.
    /// </summary>
    public TerraformValue<string> LifecycleDetails
    {
        get => new TerraformReference<string>(this, "lifecycle_details");
    }

    /// <summary>
    /// This field indicates the maximum data loss limit for an Autonomous
    /// Database, in seconds.
    /// </summary>
    public TerraformValue<double> LocalAdgAutoFailoverMaxDataLossLimit
    {
        get => new TerraformReference<double>(this, "local_adg_auto_failover_max_data_loss_limit");
    }

    /// <summary>
    /// This field indicates the local disaster recovery (DR) type of an
    /// Autonomous Database. 
    ///  Possible values:
    ///  LOCAL_DISASTER_RECOVERY_TYPE_UNSPECIFIED
    /// ADG
    /// BACKUP_BASED
    /// </summary>
    public TerraformValue<string> LocalDisasterRecoveryType
    {
        get => new TerraformReference<string>(this, "local_disaster_recovery_type");
    }

    /// <summary>
    /// Autonomous Data Guard standby database details.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/AutonomousDatabaseStandbySummary
    /// </summary>
    public TerraformList<TerraformMap<object>> LocalStandbyDb
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "local_standby_db").ResolveNodes(ctx));
    }

    /// <summary>
    /// The date and time when maintenance will begin.
    /// </summary>
    public TerraformValue<string> MaintenanceBeginTime
    {
        get => new TerraformReference<string>(this, "maintenance_begin_time");
    }

    /// <summary>
    /// The date and time when maintenance will end.
    /// </summary>
    public TerraformValue<string> MaintenanceEndTime
    {
        get => new TerraformReference<string>(this, "maintenance_end_time");
    }

    /// <summary>
    /// The maintenance schedule of the Autonomous Database. 
    ///  Possible values:
    ///  MAINTENANCE_SCHEDULE_TYPE_UNSPECIFIED
    /// EARLY
    /// REGULAR
    /// </summary>
    public TerraformValue<string> MaintenanceScheduleType
    {
        get => new TerraformReference<string>(this, "maintenance_schedule_type");
        set => SetArgument("maintenance_schedule_type", value);
    }

    /// <summary>
    /// The amount of memory enabled per ECPU, in gigabytes.
    /// </summary>
    public TerraformValue<double> MemoryPerOracleComputeUnitGbs
    {
        get => new TerraformReference<double>(this, "memory_per_oracle_compute_unit_gbs");
    }

    /// <summary>
    /// The memory assigned to in-memory tables in an Autonomous Database.
    /// </summary>
    public TerraformValue<double> MemoryTableGbs
    {
        get => new TerraformReference<double>(this, "memory_table_gbs");
    }

    /// <summary>
    /// This field specifies if the Autonomous Database requires mTLS connections.
    /// </summary>
    public TerraformValue<bool>? MtlsConnectionRequired
    {
        get => new TerraformReference<bool>(this, "mtls_connection_required");
        set => SetArgument("mtls_connection_required", value);
    }

    /// <summary>
    /// The national character set for the Autonomous Database. The default is
    /// AL16UTF16.
    /// </summary>
    public TerraformValue<string>? NCharacterSet
    {
        get => new TerraformReference<string>(this, "n_character_set");
        set => SetArgument("n_character_set", value);
    }

    /// <summary>
    /// The long term backup schedule of the Autonomous Database.
    /// </summary>
    public TerraformValue<string> NextLongTermBackupTime
    {
        get => new TerraformReference<string>(this, "next_long_term_backup_time");
    }

    /// <summary>
    /// The Oracle Cloud Infrastructure link for the Autonomous Database.
    /// </summary>
    public TerraformValue<string> OciUrl
    {
        get => new TerraformReference<string>(this, "oci_url");
    }

    /// <summary>
    /// OCID of the Autonomous Database.
    /// https://docs.oracle.com/en-us/iaas/Content/General/Concepts/identifiers.htm#Oracle
    /// </summary>
    public TerraformValue<string> Ocid
    {
        get => new TerraformReference<string>(this, "ocid");
    }

    /// <summary>
    /// This field indicates the current mode of the Autonomous Database. 
    ///  Possible values:
    ///  OPEN_MODE_UNSPECIFIED
    /// READ_ONLY
    /// READ_WRITE
    /// </summary>
    public TerraformValue<string> OpenMode
    {
        get => new TerraformReference<string>(this, "open_mode");
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
    public TerraformValue<string> OperationsInsightsState
    {
        get => new TerraformReference<string>(this, "operations_insights_state");
        set => SetArgument("operations_insights_state", value);
    }

    /// <summary>
    /// The list of OCIDs of standby databases located in Autonomous Data Guard
    /// remote regions that are associated with the source database.
    /// </summary>
    public TerraformList<string> PeerDbIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "peer_db_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The permission level of the Autonomous Database. 
    ///  Possible values:
    ///  PERMISSION_LEVEL_UNSPECIFIED
    /// RESTRICTED
    /// UNRESTRICTED
    /// </summary>
    public TerraformValue<string> PermissionLevel
    {
        get => new TerraformReference<string>(this, "permission_level");
    }

    /// <summary>
    /// The private endpoint for the Autonomous Database.
    /// </summary>
    public TerraformValue<string> PrivateEndpoint
    {
        get => new TerraformReference<string>(this, "private_endpoint");
    }

    /// <summary>
    /// The private endpoint IP address for the Autonomous Database.
    /// </summary>
    public TerraformValue<string> PrivateEndpointIp
    {
        get => new TerraformReference<string>(this, "private_endpoint_ip");
        set => SetArgument("private_endpoint_ip", value);
    }

    /// <summary>
    /// The private endpoint label for the Autonomous Database.
    /// </summary>
    public TerraformValue<string> PrivateEndpointLabel
    {
        get => new TerraformReference<string>(this, "private_endpoint_label");
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
    {
        get => new TerraformReference<string>(this, "refreshable_mode");
    }

    /// <summary>
    /// The refresh State of the clone. 
    ///  Possible values:
    ///  REFRESHABLE_STATE_UNSPECIFIED
    /// REFRESHING
    /// NOT_REFRESHING
    /// </summary>
    public TerraformValue<string> RefreshableState
    {
        get => new TerraformReference<string>(this, "refreshable_state");
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
    public TerraformValue<string> Role
    {
        get => new TerraformReference<string>(this, "role");
    }

    /// <summary>
    /// The list and details of the scheduled operations of the Autonomous
    /// Database.
    /// </summary>
    public TerraformList<TerraformMap<object>> ScheduledOperationDetails
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "scheduled_operation_details").ResolveNodes(ctx));
    }

    /// <summary>
    /// The SQL Web Developer URL for the Autonomous Database.
    /// </summary>
    public TerraformValue<string> SqlWebDeveloperUrl
    {
        get => new TerraformReference<string>(this, "sql_web_developer_url");
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
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The list of available regions that can be used to create a clone for the
    /// Autonomous Database.
    /// </summary>
    public TerraformList<string> SupportedCloneRegions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "supported_clone_regions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The storage space used by automatic backups of Autonomous Database, in
    /// gigabytes.
    /// </summary>
    public TerraformValue<double> TotalAutoBackupStorageSizeGbs
    {
        get => new TerraformReference<double>(this, "total_auto_backup_storage_size_gbs");
    }

    /// <summary>
    /// The storage space used by Autonomous Database, in gigabytes.
    /// </summary>
    public TerraformValue<double> UsedDataStorageSizeTbs
    {
        get => new TerraformReference<double>(this, "used_data_storage_size_tbs");
    }

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
        get => new TerraformReference<string>(this, "email");
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "admin_password");
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
        get => new TerraformReference<string>(this, "autonomous_database_id");
        set => SetArgument("autonomous_database_id", value);
    }

    /// <summary>
    /// The subnet CIDR range for the Autonmous Database.
    /// </summary>
    public TerraformValue<string>? Cidr
    {
        get => new TerraformReference<string>(this, "cidr");
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
        get => new TerraformReference<string>(this, "database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// Whether or not to allow Terraform to destroy the instance. Unless this field is set to false in Terraform state, a terraform destroy or terraform apply that would delete the instance will fail.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// The display name for the Autonomous Database. The name does not have to
    /// be unique within your project.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
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
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. See documentation for resource type &#39;oracledatabase.googleapis.com/AutonomousDatabaseBackup&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of the VPC network used by the Autonomous Database.
    /// Format: projects/{project}/global/networks/{network}
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => new TerraformReference<string>(this, "network");
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
        get => new TerraformReference<string>(this, "odb_network");
        set => SetArgument("odb_network", value);
    }

    /// <summary>
    /// The name of the OdbSubnet associated with the Autonomous Database for
    /// IP allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    public TerraformValue<string> OdbSubnet
    {
        get => new TerraformReference<string>(this, "odb_subnet");
        set => SetArgument("odb_subnet", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The date and time that the Autonomous Database was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ID of the subscription entitlement associated with the Autonomous
    /// Database.
    /// </summary>
    public TerraformValue<string> EntitlementId
    {
        get => new TerraformReference<string>(this, "entitlement_id");
    }

    /// <summary>
    /// Identifier. The name of the Autonomous Database resource in the following format:
    /// projects/{project}/locations/{region}/autonomousDatabases/{autonomous_database}
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

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
