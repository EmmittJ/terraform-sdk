using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for properties in GoogleOracleDatabaseDbSystem.
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseDbSystemPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "properties";

    /// <summary>
    /// The number of CPU cores to enable for the DbSystem.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeCount is required")]
    public required TerraformValue<double> ComputeCount
    {
        get => GetArgument<TerraformValue<double>>("compute_count");
        set => SetArgument("compute_count", value);
    }

    /// <summary>
    /// The compute model of the DbSystem.
    /// Possible values:
    /// ECPU
    /// OCPU
    /// </summary>
    public TerraformValue<string>? ComputeModel
    {
        get => GetArgument<TerraformValue<string>>("compute_model");
        set => SetArgument("compute_model", value);
    }

    /// <summary>
    /// The data storage size in GB that is currently available to DbSystems.
    /// </summary>
    public TerraformValue<double>? DataStorageSizeGb
    {
        get => GetArgument<TerraformValue<double>>("data_storage_size_gb");
        set => SetArgument("data_storage_size_gb", value);
    }

    /// <summary>
    /// The database edition of the DbSystem.
    /// Possible values:
    /// STANDARD_EDITION
    /// ENTERPRISE_EDITION
    /// ENTERPRISE_EDITION_HIGH_PERFORMANCE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseEdition is required")]
    public required TerraformValue<string> DatabaseEdition
    {
        get => GetArgument<TerraformValue<string>>("database_edition");
        set => SetArgument("database_edition", value);
    }

    /// <summary>
    /// The host domain name of the DbSystem.
    /// </summary>
    public TerraformValue<string>? Domain
    {
        get => GetArgument<TerraformValue<string>>("domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The hostname of the DbSystem.
    /// </summary>
    public TerraformValue<string> Hostname
        => AsReference("hostname");

    /// <summary>
    /// Prefix for DB System host names.
    /// </summary>
    public TerraformValue<string>? HostnamePrefix
    {
        get => GetArgument<TerraformValue<string>>("hostname_prefix");
        set => SetArgument("hostname_prefix", value);
    }

    /// <summary>
    /// The initial data storage size in GB.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialDataStorageSizeGb is required")]
    public required TerraformValue<double> InitialDataStorageSizeGb
    {
        get => GetArgument<TerraformValue<double>>("initial_data_storage_size_gb");
        set => SetArgument("initial_data_storage_size_gb", value);
    }

    /// <summary>
    /// The license model of the DbSystem.
    /// Possible values:
    /// LICENSE_INCLUDED
    /// BRING_YOUR_OWN_LICENSE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseModel is required")]
    public required TerraformValue<string> LicenseModel
    {
        get => GetArgument<TerraformValue<string>>("license_model");
        set => SetArgument("license_model", value);
    }

    /// <summary>
    /// State of the DbSystem.
    /// Possible values:
    /// PROVISIONING
    /// AVAILABLE
    /// UPDATING
    /// TERMINATING
    /// TERMINATED
    /// FAILED
    /// MIGRATED
    /// MAINTENANCE_IN_PROGRESS
    /// NEEDS_ATTENTION
    /// UPGRADING
    /// </summary>
    public TerraformValue<string> LifecycleState
        => AsReference("lifecycle_state");

    /// <summary>
    /// The memory size in GB.
    /// </summary>
    public TerraformValue<double>? MemorySizeGb
    {
        get => GetArgument<TerraformValue<double>>("memory_size_gb");
        set => SetArgument("memory_size_gb", value);
    }

    /// <summary>
    /// The number of nodes in the DbSystem.
    /// </summary>
    public TerraformValue<double>? NodeCount
    {
        get => GetArgument<TerraformValue<double>>("node_count");
        set => SetArgument("node_count", value);
    }

    /// <summary>
    /// OCID of the DbSystem.
    /// </summary>
    public TerraformValue<string> Ocid
        => AsReference("ocid");

    /// <summary>
    /// The private IP address of the DbSystem.
    /// </summary>
    public TerraformValue<string>? PrivateIp
    {
        get => GetArgument<TerraformValue<string>>("private_ip");
        set => SetArgument("private_ip", value);
    }

    /// <summary>
    /// The reco/redo storage size in GB.
    /// </summary>
    public TerraformValue<double>? RecoStorageSizeGb
    {
        get => GetArgument<TerraformValue<double>>("reco_storage_size_gb");
        set => SetArgument("reco_storage_size_gb", value);
    }

    /// <summary>
    /// Shape of DB System.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shape is required")]
    public required TerraformValue<string> Shape
    {
        get => GetArgument<TerraformValue<string>>("shape");
        set => SetArgument("shape", value);
    }

    /// <summary>
    /// SSH public keys to be stored with the DbSystem.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeys is required")]
    public TerraformList<string>? SshPublicKeys
    {
        get => GetArgument<TerraformList<string>>("ssh_public_keys");
        set => SetArgument("ssh_public_keys", value);
    }

    /// <summary>
    /// DataCollectionOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCollectionOptions block(s) allowed")]
    public TerraformList<GoogleOracleDatabaseDbSystemPropertiesBlockDataCollectionOptionsBlock>? DataCollectionOptions
    {
        get => GetArgument<TerraformList<GoogleOracleDatabaseDbSystemPropertiesBlockDataCollectionOptionsBlock>>("data_collection_options");
        set => SetArgument("data_collection_options", value);
    }

    /// <summary>
    /// DbHome block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DbHome block(s) allowed")]
    public TerraformList<GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlock>? DbHome
    {
        get => GetArgument<TerraformList<GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlock>>("db_home");
        set => SetArgument("db_home", value);
    }

    /// <summary>
    /// DbSystemOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DbSystemOptions block(s) allowed")]
    public TerraformList<GoogleOracleDatabaseDbSystemPropertiesBlockDbSystemOptionsBlock>? DbSystemOptions
    {
        get => GetArgument<TerraformList<GoogleOracleDatabaseDbSystemPropertiesBlockDbSystemOptionsBlock>>("db_system_options");
        set => SetArgument("db_system_options", value);
    }

    /// <summary>
    /// TimeZone block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeZone block(s) allowed")]
    public TerraformList<GoogleOracleDatabaseDbSystemPropertiesBlockTimeZoneBlock>? TimeZone
    {
        get => GetArgument<TerraformList<GoogleOracleDatabaseDbSystemPropertiesBlockTimeZoneBlock>>("time_zone");
        set => SetArgument("time_zone", value);
    }

}

/// <summary>
/// Block type for data_collection_options in GoogleOracleDatabaseDbSystemPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseDbSystemPropertiesBlockDataCollectionOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_collection_options";

    /// <summary>
    /// Indicates whether to enable data collection for diagnostics.
    /// </summary>
    public TerraformValue<bool>? IsDiagnosticsEventsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("is_diagnostics_events_enabled");
        set => SetArgument("is_diagnostics_events_enabled", value);
    }

    /// <summary>
    /// Indicates whether to enable incident logs and trace collection.
    /// </summary>
    public TerraformValue<bool>? IsIncidentLogsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("is_incident_logs_enabled");
        set => SetArgument("is_incident_logs_enabled", value);
    }

}

/// <summary>
/// Block type for db_home in GoogleOracleDatabaseDbSystemPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "db_home";

    /// <summary>
    /// A valid Oracle Database version. For a list of supported versions, use the
    /// ListDbVersions operation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbVersion is required")]
    public required TerraformValue<string> DbVersion
    {
        get => GetArgument<TerraformValue<string>>("db_version");
        set => SetArgument("db_version", value);
    }

    /// <summary>
    /// The display name for the Database Home. The name does not have to
    /// be unique within your project.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Whether unified auditing is enabled for the Database Home.
    /// </summary>
    public TerraformValue<bool>? IsUnifiedAuditingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("is_unified_auditing_enabled");
        set => SetArgument("is_unified_auditing_enabled", value);
    }

    /// <summary>
    /// Database block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Database block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Database block(s) allowed")]
    public required TerraformList<GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlockDatabaseBlock> Database
    {
        get => GetRequiredArgument<TerraformList<GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlockDatabaseBlock>>("database");
        set => SetArgument("database", value);
    }

}

/// <summary>
/// Block type for database in GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlockDatabaseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "database";

    /// <summary>
    /// The password for the default ADMIN user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminPassword is required")]
    public required TerraformValue<string> AdminPassword
    {
        get => GetArgument<TerraformValue<string>>("admin_password");
        set => SetArgument("admin_password", value);
    }

    /// <summary>
    /// The character set for the database. The default is AL32UTF8.
    /// </summary>
    public TerraformValue<string>? CharacterSet
    {
        get => GetArgument<TerraformValue<string>>("character_set");
        set => SetArgument("character_set", value);
    }

    /// <summary>
    /// The date and time that the Database was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The database ID of the Database.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseId is required")]
    public required TerraformValue<string> DatabaseId
    {
        get => GetArgument<TerraformValue<string>>("database_id");
        set => SetArgument("database_id", value);
    }

    /// <summary>
    /// The name of the DbHome resource associated with the Database.
    /// </summary>
    public TerraformValue<string>? DbHomeName
    {
        get => GetArgument<TerraformValue<string>>("db_home_name");
        set => SetArgument("db_home_name", value);
    }

    /// <summary>
    /// The database name. The name must begin with an alphabetic character and can
    /// contain a maximum of eight alphanumeric characters. Special characters are
    /// not permitted.
    /// </summary>
    public TerraformValue<string>? DbName
    {
        get => GetArgument<TerraformValue<string>>("db_name");
        set => SetArgument("db_name", value);
    }

    /// <summary>
    /// The DB_UNIQUE_NAME of the Oracle Database being backed up.
    /// </summary>
    public TerraformValue<string>? DbUniqueName
    {
        get => GetArgument<TerraformValue<string>>("db_unique_name");
        set => SetArgument("db_unique_name", value);
    }

    /// <summary>
    /// The GCP Oracle zone where the Database is created.
    /// </summary>
    public TerraformValue<string>? GcpOracleZone
    {
        get => GetArgument<TerraformValue<string>>("gcp_oracle_zone");
        set => SetArgument("gcp_oracle_zone", value);
    }

    /// <summary>
    /// Identifier. The name of the Database resource in the following format:
    /// projects/{project}/locations/{region}/databases/{database}
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The national character set for the database. The default is AL16UTF16.
    /// </summary>
    public TerraformValue<string>? NcharacterSet
    {
        get => GetArgument<TerraformValue<string>>("ncharacter_set");
        set => SetArgument("ncharacter_set", value);
    }

    /// <summary>
    /// HTTPS link to OCI resources exposed to Customer via UI Interface.
    /// </summary>
    public TerraformValue<string> OciUrl
        => AsReference("oci_url");

    /// <summary>
    /// The Status of Operations Insights for this Database.
    /// Possible values:
    /// ENABLING
    /// ENABLED
    /// DISABLING
    /// NOT_ENABLED
    /// FAILED_ENABLING
    /// FAILED_DISABLING
    /// </summary>
    public TerraformValue<string> OpsInsightsStatus
        => AsReference("ops_insights_status");

    /// <summary>
    /// The TDE wallet password for the database.
    /// </summary>
    public TerraformValue<string>? TdeWalletPassword
    {
        get => GetArgument<TerraformValue<string>>("tde_wallet_password");
        set => SetArgument("tde_wallet_password", value);
    }

    /// <summary>
    /// Properties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    public TerraformList<GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlockDatabaseBlockPropertiesBlock>? Properties
    {
        get => GetArgument<TerraformList<GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlockDatabaseBlockPropertiesBlock>>("properties");
        set => SetArgument("properties", value);
    }

}

/// <summary>
/// Block type for properties in GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlockDatabaseBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlockDatabaseBlockPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "properties";

    /// <summary>
    /// The Oracle Database version.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbVersion is required")]
    public required TerraformValue<string> DbVersion
    {
        get => GetArgument<TerraformValue<string>>("db_version");
        set => SetArgument("db_version", value);
    }

    /// <summary>
    /// State of the Database.
    /// Possible values:
    /// PROVISIONING
    /// AVAILABLE
    /// UPDATING
    /// BACKUP_IN_PROGRESS
    /// UPGRADING
    /// CONVERTING
    /// TERMINATING
    /// TERMINATED
    /// RESTORE_FAILED
    /// FAILED
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// DatabaseManagementConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DatabaseManagementConfig block(s) allowed")]
    public TerraformList<GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlockDatabaseBlockPropertiesBlockDatabaseManagementConfigBlock>? DatabaseManagementConfig
    {
        get => GetArgument<TerraformList<GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlockDatabaseBlockPropertiesBlockDatabaseManagementConfigBlock>>("database_management_config");
        set => SetArgument("database_management_config", value);
    }

    /// <summary>
    /// DbBackupConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DbBackupConfig block(s) allowed")]
    public TerraformList<GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlockDatabaseBlockPropertiesBlockDbBackupConfigBlock>? DbBackupConfig
    {
        get => GetArgument<TerraformList<GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlockDatabaseBlockPropertiesBlockDbBackupConfigBlock>>("db_backup_config");
        set => SetArgument("db_backup_config", value);
    }

}

/// <summary>
/// Block type for database_management_config in GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlockDatabaseBlockPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlockDatabaseBlockPropertiesBlockDatabaseManagementConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "database_management_config";

    /// <summary>
    /// The status of the Database Management service.
    /// Possible values:
    /// ENABLING
    /// ENABLED
    /// DISABLING
    /// DISABLED
    /// UPDATING
    /// FAILED_ENABLING
    /// FAILED_DISABLING
    /// FAILED_UPDATING
    /// </summary>
    public TerraformValue<string> ManagementState
        => AsReference("management_state");

    /// <summary>
    /// The Database Management type.
    /// Possible values:
    /// BASIC
    /// ADVANCED
    /// </summary>
    public TerraformValue<string> ManagementType
        => AsReference("management_type");

}

/// <summary>
/// Block type for db_backup_config in GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlockDatabaseBlockPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlockDatabaseBlockPropertiesBlockDbBackupConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "db_backup_config";

    /// <summary>
    /// If set to true, enables automatic backups on the database.
    /// </summary>
    public TerraformValue<bool>? AutoBackupEnabled
    {
        get => GetArgument<TerraformValue<bool>>("auto_backup_enabled");
        set => SetArgument("auto_backup_enabled", value);
    }

    /// <summary>
    /// Possible values:
    /// MONDAY
    /// TUESDAY
    /// WEDNESDAY
    /// THURSDAY
    /// FRIDAY
    /// SATURDAY
    /// SUNDAY
    /// </summary>
    public TerraformValue<string>? AutoFullBackupDay
    {
        get => GetArgument<TerraformValue<string>>("auto_full_backup_day");
        set => SetArgument("auto_full_backup_day", value);
    }

    /// <summary>
    /// The window in which the full backup should be performed on the database.
    /// If no value is provided, the default is anytime.
    /// Possible values:
    /// SLOT_ONE
    /// SLOT_TWO
    /// SLOT_THREE
    /// SLOT_FOUR
    /// SLOT_FIVE
    /// SLOT_SIX
    /// SLOT_SEVEN
    /// SLOT_EIGHT
    /// SLOT_NINE
    /// SLOT_TEN
    /// SLOT_ELEVEN
    /// SLOT_TWELVE
    /// </summary>
    public TerraformValue<string>? AutoFullBackupWindow
    {
        get => GetArgument<TerraformValue<string>>("auto_full_backup_window");
        set => SetArgument("auto_full_backup_window", value);
    }

    /// <summary>
    /// The window in which the incremental backup should be performed on the
    /// database. If no value is provided, the default is anytime except the auto
    /// full backup day.
    /// Possible values:
    /// SLOT_ONE
    /// SLOT_TWO
    /// SLOT_THREE
    /// SLOT_FOUR
    /// SLOT_FIVE
    /// SLOT_SIX
    /// SLOT_SEVEN
    /// SLOT_EIGHT
    /// SLOT_NINE
    /// SLOT_TEN
    /// SLOT_ELEVEN
    /// SLOT_TWELVE
    /// </summary>
    public TerraformValue<string>? AutoIncrementalBackupWindow
    {
        get => GetArgument<TerraformValue<string>>("auto_incremental_backup_window");
        set => SetArgument("auto_incremental_backup_window", value);
    }

    /// <summary>
    /// This defines when the backups will be deleted after Database termination.
    /// Possible values:
    /// DELETE_IMMEDIATELY
    /// DELETE_AFTER_RETENTION_PERIOD
    /// </summary>
    public TerraformValue<string>? BackupDeletionPolicy
    {
        get => GetArgument<TerraformValue<string>>("backup_deletion_policy");
        set => SetArgument("backup_deletion_policy", value);
    }

    /// <summary>
    /// The number of days an automatic backup is retained before being
    /// automatically deleted. This value determines the earliest point in time to
    /// which a database can be restored. Min: 1, Max: 60.
    /// </summary>
    public TerraformValue<double>? RetentionPeriodDays
    {
        get => GetArgument<TerraformValue<double>>("retention_period_days");
        set => SetArgument("retention_period_days", value);
    }

    /// <summary>
    /// BackupDestinationDetails block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlockDatabaseBlockPropertiesBlockDbBackupConfigBlockBackupDestinationDetailsBlock>? BackupDestinationDetails
    {
        get => GetArgument<TerraformList<GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlockDatabaseBlockPropertiesBlockDbBackupConfigBlockBackupDestinationDetailsBlock>>("backup_destination_details");
        set => SetArgument("backup_destination_details", value);
    }

}

/// <summary>
/// Block type for backup_destination_details in GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlockDatabaseBlockPropertiesBlockDbBackupConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseDbSystemPropertiesBlockDbHomeBlockDatabaseBlockPropertiesBlockDbBackupConfigBlockBackupDestinationDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backup_destination_details";

    /// <summary>
    /// The type of the database backup destination.
    /// Possible values:
    /// NFS
    /// RECOVERY_APPLIANCE
    /// OBJECT_STORE
    /// LOCAL
    /// DBRS
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for db_system_options in GoogleOracleDatabaseDbSystemPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseDbSystemPropertiesBlockDbSystemOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "db_system_options";

    /// <summary>
    /// The storage option used in DB system.
    /// Possible values:
    /// ASM
    /// LVM
    /// </summary>
    public TerraformValue<string>? StorageManagement
    {
        get => GetArgument<TerraformValue<string>>("storage_management");
        set => SetArgument("storage_management", value);
    }

}

/// <summary>
/// Block type for time_zone in GoogleOracleDatabaseDbSystemPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseDbSystemPropertiesBlockTimeZoneBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_zone";

    /// <summary>
    /// IANA Time Zone Database time zone. For example &amp;quot;America/New_York&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleOracleDatabaseDbSystem.
/// Nesting mode: single
/// </summary>
public class GoogleOracleDatabaseDbSystemTimeoutsBlock : TerraformBlock
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
/// Represents a google_oracle_database_db_system Terraform resource.
/// Manages a google_oracle_database_db_system resource.
/// </summary>
public partial class GoogleOracleDatabaseDbSystem(string name) : TerraformResource("google_oracle_database_db_system", name)
{
    /// <summary>
    /// The ID of the DbSystem to create. This value is
    /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
    /// 63 characters in length. The value must start with a letter and end with a
    /// letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbSystemId is required")]
    public required TerraformValue<string> DbSystemId
    {
        get => GetArgument<TerraformValue<string>>("db_system_id");
        set => SetArgument("db_system_id", value);
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
    /// The display name for the System db. The name does not have to
    /// be unique within your project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The GCP Oracle zone where Oracle DbSystem is hosted.
    /// Example: us-east4-b-r2.
    /// If not specified, the system will pick a zone based on availability.
    /// </summary>
    public TerraformValue<string>? GcpOracleZone
    {
        get => GetArgument<TerraformValue<string>>("gcp_oracle_zone");
        set => SetArgument("gcp_oracle_zone", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The labels or tags associated with the DbSystem.
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of the OdbNetwork associated with the DbSystem.
    /// Format: projects/{project}/locations/{location}/odbNetworks/{odb_network}
    /// It is optional but if specified, this should match the parent ODBNetwork of
    /// the OdbSubnet.
    /// </summary>
    public TerraformValue<string>? OdbNetwork
    {
        get => GetArgument<TerraformValue<string>>("odb_network");
        set => SetArgument("odb_network", value);
    }

    /// <summary>
    /// The name of the OdbSubnet associated with the DbSystem for IP
    /// allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OdbSubnet is required")]
    public required TerraformValue<string> OdbSubnet
    {
        get => GetArgument<TerraformValue<string>>("odb_subnet");
        set => SetArgument("odb_subnet", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The date and time that the DbSystem was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The ID of the subscription entitlement associated with the DbSystem
    /// </summary>
    public TerraformValue<string> EntitlementId
        => AsReference("entitlement_id");

    /// <summary>
    /// Identifier. The name of the DbSystem resource in the following format:
    /// projects/{project}/locations/{region}/dbSystems/{db_system}
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// HTTPS link to OCI resources exposed to Customer via UI Interface.
    /// </summary>
    public TerraformValue<string> OciUrl
        => AsReference("oci_url");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Properties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    public TerraformList<GoogleOracleDatabaseDbSystemPropertiesBlock>? Properties
    {
        get => GetArgument<TerraformList<GoogleOracleDatabaseDbSystemPropertiesBlock>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleOracleDatabaseDbSystemTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleOracleDatabaseDbSystemTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
