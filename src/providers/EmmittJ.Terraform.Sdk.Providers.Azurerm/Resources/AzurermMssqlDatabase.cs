using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermMssqlDatabase.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlDatabaseIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    public required TerraformSet<string> IdentityIds
    {
        get => GetRequiredArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for import in AzurermMssqlDatabase.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlDatabaseImportBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "import";

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdministratorLogin is required")]
    public required TerraformValue<string> AdministratorLogin
    {
        get => GetRequiredArgument<TerraformValue<string>>("administrator_login");
        set => SetArgument("administrator_login", value);
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdministratorLoginPassword is required")]
    public required TerraformValue<string> AdministratorLoginPassword
    {
        get => GetRequiredArgument<TerraformValue<string>>("administrator_login_password");
        set => SetArgument("administrator_login_password", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    public required TerraformValue<string> AuthenticationType
    {
        get => GetRequiredArgument<TerraformValue<string>>("authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountId
    {
        get => GetArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The storage_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageKey is required")]
    public required TerraformValue<string> StorageKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_key");
        set => SetArgument("storage_key", value);
    }

    /// <summary>
    /// The storage_key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageKeyType is required")]
    public required TerraformValue<string> StorageKeyType
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_key_type");
        set => SetArgument("storage_key_type", value);
    }

    /// <summary>
    /// The storage_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    public required TerraformValue<string> StorageUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_uri");
        set => SetArgument("storage_uri", value);
    }

}


/// <summary>
/// Block type for long_term_retention_policy in AzurermMssqlDatabase.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlDatabaseLongTermRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "long_term_retention_policy";

    /// <summary>
    /// The immutable_backups_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ImmutableBackupsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("immutable_backups_enabled");
        set => SetArgument("immutable_backups_enabled", value);
    }

    /// <summary>
    /// The monthly_retention attribute.
    /// </summary>
    public TerraformValue<string> MonthlyRetention
    {
        get => GetArgument<TerraformValue<string>>("monthly_retention") ?? AsReference("monthly_retention");
        set => SetArgument("monthly_retention", value);
    }

    /// <summary>
    /// The week_of_year attribute.
    /// </summary>
    public TerraformValue<double> WeekOfYear
    {
        get => GetArgument<TerraformValue<double>>("week_of_year") ?? AsReference("week_of_year");
        set => SetArgument("week_of_year", value);
    }

    /// <summary>
    /// The weekly_retention attribute.
    /// </summary>
    public TerraformValue<string> WeeklyRetention
    {
        get => GetArgument<TerraformValue<string>>("weekly_retention") ?? AsReference("weekly_retention");
        set => SetArgument("weekly_retention", value);
    }

    /// <summary>
    /// The yearly_retention attribute.
    /// </summary>
    public TerraformValue<string> YearlyRetention
    {
        get => GetArgument<TerraformValue<string>>("yearly_retention") ?? AsReference("yearly_retention");
        set => SetArgument("yearly_retention", value);
    }

}


/// <summary>
/// Block type for short_term_retention_policy in AzurermMssqlDatabase.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlDatabaseShortTermRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "short_term_retention_policy";

    /// <summary>
    /// The backup_interval_in_hours attribute.
    /// </summary>
    public TerraformValue<double> BackupIntervalInHours
    {
        get => GetArgument<TerraformValue<double>>("backup_interval_in_hours") ?? AsReference("backup_interval_in_hours");
        set => SetArgument("backup_interval_in_hours", value);
    }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionDays is required")]
    public required TerraformValue<double> RetentionDays
    {
        get => GetRequiredArgument<TerraformValue<double>>("retention_days");
        set => SetArgument("retention_days", value);
    }

}


/// <summary>
/// Block type for threat_detection_policy in AzurermMssqlDatabase.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlDatabaseThreatDetectionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "threat_detection_policy";

    /// <summary>
    /// The disabled_alerts attribute.
    /// </summary>
    public TerraformSet<string>? DisabledAlerts
    {
        get => GetArgument<TerraformSet<string>>("disabled_alerts");
        set => SetArgument("disabled_alerts", value);
    }

    /// <summary>
    /// The email_account_admins attribute.
    /// </summary>
    public TerraformValue<string>? EmailAccountAdmins
    {
        get => GetArgument<TerraformValue<string>>("email_account_admins");
        set => SetArgument("email_account_admins", value);
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    public TerraformSet<string>? EmailAddresses
    {
        get => GetArgument<TerraformSet<string>>("email_addresses");
        set => SetArgument("email_addresses", value);
    }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    public TerraformValue<double>? RetentionDays
    {
        get => GetArgument<TerraformValue<double>>("retention_days");
        set => SetArgument("retention_days", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => GetArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountAccessKey
    {
        get => GetArgument<TerraformValue<string>>("storage_account_access_key");
        set => SetArgument("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? StorageEndpoint
    {
        get => GetArgument<TerraformValue<string>>("storage_endpoint");
        set => SetArgument("storage_endpoint", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMssqlDatabase.
/// Nesting mode: single
/// </summary>
public class AzurermMssqlDatabaseTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
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
/// Represents a azurerm_mssql_database Terraform resource.
/// Manages a azurerm_mssql_database resource.
/// </summary>
public partial class AzurermMssqlDatabase(string name) : TerraformResource("azurerm_mssql_database", name)
{
    /// <summary>
    /// The auto_pause_delay_in_minutes attribute.
    /// </summary>
    public TerraformValue<double> AutoPauseDelayInMinutes
    {
        get => GetArgument<TerraformValue<double>>("auto_pause_delay_in_minutes") ?? AsReference("auto_pause_delay_in_minutes");
        set => SetArgument("auto_pause_delay_in_minutes", value);
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformValue<string> Collation
    {
        get => GetArgument<TerraformValue<string>>("collation") ?? AsReference("collation");
        set => SetArgument("collation", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformValue<string>? CreateMode
    {
        get => GetArgument<TerraformValue<string>>("create_mode");
        set => SetArgument("create_mode", value);
    }

    /// <summary>
    /// The creation_source_database_id attribute.
    /// </summary>
    public TerraformValue<string> CreationSourceDatabaseId
    {
        get => GetArgument<TerraformValue<string>>("creation_source_database_id") ?? AsReference("creation_source_database_id");
        set => SetArgument("creation_source_database_id", value);
    }

    /// <summary>
    /// The elastic_pool_id attribute.
    /// </summary>
    public TerraformValue<string>? ElasticPoolId
    {
        get => GetArgument<TerraformValue<string>>("elastic_pool_id");
        set => SetArgument("elastic_pool_id", value);
    }

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    public TerraformValue<string> EnclaveType
    {
        get => GetArgument<TerraformValue<string>>("enclave_type") ?? AsReference("enclave_type");
        set => SetArgument("enclave_type", value);
    }

    /// <summary>
    /// The geo_backup_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? GeoBackupEnabled
    {
        get => GetArgument<TerraformValue<bool>>("geo_backup_enabled");
        set => SetArgument("geo_backup_enabled", value);
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
    /// The ledger_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LedgerEnabled
    {
        get => GetArgument<TerraformValue<bool>>("ledger_enabled") ?? AsReference("ledger_enabled");
        set => SetArgument("ledger_enabled", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string> LicenseType
    {
        get => GetArgument<TerraformValue<string>>("license_type") ?? AsReference("license_type");
        set => SetArgument("license_type", value);
    }

    /// <summary>
    /// The maintenance_configuration_name attribute.
    /// </summary>
    public TerraformValue<string> MaintenanceConfigurationName
    {
        get => GetArgument<TerraformValue<string>>("maintenance_configuration_name") ?? AsReference("maintenance_configuration_name");
        set => SetArgument("maintenance_configuration_name", value);
    }

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    public TerraformValue<double> MaxSizeGb
    {
        get => GetArgument<TerraformValue<double>>("max_size_gb") ?? AsReference("max_size_gb");
        set => SetArgument("max_size_gb", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    public TerraformValue<double> MinCapacity
    {
        get => GetArgument<TerraformValue<double>>("min_capacity") ?? AsReference("min_capacity");
        set => SetArgument("min_capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The read_replica_count attribute.
    /// </summary>
    public TerraformValue<double> ReadReplicaCount
    {
        get => GetArgument<TerraformValue<double>>("read_replica_count") ?? AsReference("read_replica_count");
        set => SetArgument("read_replica_count", value);
    }

    /// <summary>
    /// The read_scale attribute.
    /// </summary>
    public TerraformValue<bool> ReadScale
    {
        get => GetArgument<TerraformValue<bool>>("read_scale") ?? AsReference("read_scale");
        set => SetArgument("read_scale", value);
    }

    /// <summary>
    /// The recover_database_id attribute.
    /// </summary>
    public TerraformValue<string>? RecoverDatabaseId
    {
        get => GetArgument<TerraformValue<string>>("recover_database_id");
        set => SetArgument("recover_database_id", value);
    }

    /// <summary>
    /// The recovery_point_id attribute.
    /// </summary>
    public TerraformValue<string>? RecoveryPointId
    {
        get => GetArgument<TerraformValue<string>>("recovery_point_id");
        set => SetArgument("recovery_point_id", value);
    }

    /// <summary>
    /// The restore_dropped_database_id attribute.
    /// </summary>
    public TerraformValue<string>? RestoreDroppedDatabaseId
    {
        get => GetArgument<TerraformValue<string>>("restore_dropped_database_id");
        set => SetArgument("restore_dropped_database_id", value);
    }

    /// <summary>
    /// The restore_long_term_retention_backup_id attribute.
    /// </summary>
    public TerraformValue<string>? RestoreLongTermRetentionBackupId
    {
        get => GetArgument<TerraformValue<string>>("restore_long_term_retention_backup_id");
        set => SetArgument("restore_long_term_retention_backup_id", value);
    }

    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    public TerraformValue<string> RestorePointInTime
    {
        get => GetArgument<TerraformValue<string>>("restore_point_in_time") ?? AsReference("restore_point_in_time");
        set => SetArgument("restore_point_in_time", value);
    }

    /// <summary>
    /// The sample_name attribute.
    /// </summary>
    public TerraformValue<string> SampleName
    {
        get => GetArgument<TerraformValue<string>>("sample_name") ?? AsReference("sample_name");
        set => SetArgument("sample_name", value);
    }

    /// <summary>
    /// The secondary_type attribute.
    /// </summary>
    public TerraformValue<string> SecondaryType
    {
        get => GetArgument<TerraformValue<string>>("secondary_type") ?? AsReference("secondary_type");
        set => SetArgument("secondary_type", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformValue<string> ServerId
    {
        get => GetRequiredArgument<TerraformValue<string>>("server_id");
        set => SetArgument("server_id", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
    {
        get => GetArgument<TerraformValue<string>>("sku_name") ?? AsReference("sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountType
    {
        get => GetArgument<TerraformValue<string>>("storage_account_type");
        set => SetArgument("storage_account_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The transparent_data_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TransparentDataEncryptionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("transparent_data_encryption_enabled");
        set => SetArgument("transparent_data_encryption_enabled", value);
    }

    /// <summary>
    /// The transparent_data_encryption_key_automatic_rotation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TransparentDataEncryptionKeyAutomaticRotationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("transparent_data_encryption_key_automatic_rotation_enabled");
        set => SetArgument("transparent_data_encryption_key_automatic_rotation_enabled", value);
    }

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string>? TransparentDataEncryptionKeyVaultKeyId
    {
        get => GetArgument<TerraformValue<string>>("transparent_data_encryption_key_vault_key_id");
        set => SetArgument("transparent_data_encryption_key_vault_key_id", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformValue<bool> ZoneRedundant
    {
        get => GetArgument<TerraformValue<bool>>("zone_redundant") ?? AsReference("zone_redundant");
        set => SetArgument("zone_redundant", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermMssqlDatabaseIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermMssqlDatabaseIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Import block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Import block(s) allowed")]
    public TerraformList<AzurermMssqlDatabaseImportBlock>? Import
    {
        get => GetArgument<TerraformList<AzurermMssqlDatabaseImportBlock>>("import");
        set => SetArgument("import", value);
    }

    /// <summary>
    /// LongTermRetentionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LongTermRetentionPolicy block(s) allowed")]
    public TerraformList<AzurermMssqlDatabaseLongTermRetentionPolicyBlock>? LongTermRetentionPolicy
    {
        get => GetArgument<TerraformList<AzurermMssqlDatabaseLongTermRetentionPolicyBlock>>("long_term_retention_policy");
        set => SetArgument("long_term_retention_policy", value);
    }

    /// <summary>
    /// ShortTermRetentionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShortTermRetentionPolicy block(s) allowed")]
    public TerraformList<AzurermMssqlDatabaseShortTermRetentionPolicyBlock>? ShortTermRetentionPolicy
    {
        get => GetArgument<TerraformList<AzurermMssqlDatabaseShortTermRetentionPolicyBlock>>("short_term_retention_policy");
        set => SetArgument("short_term_retention_policy", value);
    }

    /// <summary>
    /// ThreatDetectionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreatDetectionPolicy block(s) allowed")]
    public TerraformList<AzurermMssqlDatabaseThreatDetectionPolicyBlock>? ThreatDetectionPolicy
    {
        get => GetArgument<TerraformList<AzurermMssqlDatabaseThreatDetectionPolicyBlock>>("threat_detection_policy");
        set => SetArgument("threat_detection_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlDatabaseTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlDatabaseTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
