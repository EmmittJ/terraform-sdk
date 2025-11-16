using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in .
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for import in .
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
        get => new TerraformReference<string>(this, "administrator_login");
        set => SetArgument("administrator_login", value);
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdministratorLoginPassword is required")]
    public required TerraformValue<string> AdministratorLoginPassword
    {
        get => new TerraformReference<string>(this, "administrator_login_password");
        set => SetArgument("administrator_login_password", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    public required TerraformValue<string> AuthenticationType
    {
        get => new TerraformReference<string>(this, "authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The storage_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageKey is required")]
    public required TerraformValue<string> StorageKey
    {
        get => new TerraformReference<string>(this, "storage_key");
        set => SetArgument("storage_key", value);
    }

    /// <summary>
    /// The storage_key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageKeyType is required")]
    public required TerraformValue<string> StorageKeyType
    {
        get => new TerraformReference<string>(this, "storage_key_type");
        set => SetArgument("storage_key_type", value);
    }

    /// <summary>
    /// The storage_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    public required TerraformValue<string> StorageUri
    {
        get => new TerraformReference<string>(this, "storage_uri");
        set => SetArgument("storage_uri", value);
    }

}

/// <summary>
/// Block type for long_term_retention_policy in .
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
        get => new TerraformReference<bool>(this, "immutable_backups_enabled");
        set => SetArgument("immutable_backups_enabled", value);
    }

    /// <summary>
    /// The monthly_retention attribute.
    /// </summary>
    public TerraformValue<string> MonthlyRetention
    {
        get => new TerraformReference<string>(this, "monthly_retention");
        set => SetArgument("monthly_retention", value);
    }

    /// <summary>
    /// The week_of_year attribute.
    /// </summary>
    public TerraformValue<double> WeekOfYear
    {
        get => new TerraformReference<double>(this, "week_of_year");
        set => SetArgument("week_of_year", value);
    }

    /// <summary>
    /// The weekly_retention attribute.
    /// </summary>
    public TerraformValue<string> WeeklyRetention
    {
        get => new TerraformReference<string>(this, "weekly_retention");
        set => SetArgument("weekly_retention", value);
    }

    /// <summary>
    /// The yearly_retention attribute.
    /// </summary>
    public TerraformValue<string> YearlyRetention
    {
        get => new TerraformReference<string>(this, "yearly_retention");
        set => SetArgument("yearly_retention", value);
    }

}

/// <summary>
/// Block type for short_term_retention_policy in .
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
        get => new TerraformReference<double>(this, "backup_interval_in_hours");
        set => SetArgument("backup_interval_in_hours", value);
    }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionDays is required")]
    public required TerraformValue<double> RetentionDays
    {
        get => new TerraformReference<double>(this, "retention_days");
        set => SetArgument("retention_days", value);
    }

}

/// <summary>
/// Block type for threat_detection_policy in .
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "disabled_alerts").ResolveNodes(ctx));
        set => SetArgument("disabled_alerts", value);
    }

    /// <summary>
    /// The email_account_admins attribute.
    /// </summary>
    public TerraformValue<string>? EmailAccountAdmins
    {
        get => new TerraformReference<string>(this, "email_account_admins");
        set => SetArgument("email_account_admins", value);
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    public TerraformSet<string>? EmailAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "email_addresses").ResolveNodes(ctx));
        set => SetArgument("email_addresses", value);
    }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    public TerraformValue<double>? RetentionDays
    {
        get => new TerraformReference<double>(this, "retention_days");
        set => SetArgument("retention_days", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountAccessKey
    {
        get => new TerraformReference<string>(this, "storage_account_access_key");
        set => SetArgument("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? StorageEndpoint
    {
        get => new TerraformReference<string>(this, "storage_endpoint");
        set => SetArgument("storage_endpoint", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
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
        get => new TerraformReference<double>(this, "auto_pause_delay_in_minutes");
        set => SetArgument("auto_pause_delay_in_minutes", value);
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformValue<string> Collation
    {
        get => new TerraformReference<string>(this, "collation");
        set => SetArgument("collation", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformValue<string>? CreateMode
    {
        get => new TerraformReference<string>(this, "create_mode");
        set => SetArgument("create_mode", value);
    }

    /// <summary>
    /// The creation_source_database_id attribute.
    /// </summary>
    public TerraformValue<string> CreationSourceDatabaseId
    {
        get => new TerraformReference<string>(this, "creation_source_database_id");
        set => SetArgument("creation_source_database_id", value);
    }

    /// <summary>
    /// The elastic_pool_id attribute.
    /// </summary>
    public TerraformValue<string>? ElasticPoolId
    {
        get => new TerraformReference<string>(this, "elastic_pool_id");
        set => SetArgument("elastic_pool_id", value);
    }

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    public TerraformValue<string> EnclaveType
    {
        get => new TerraformReference<string>(this, "enclave_type");
        set => SetArgument("enclave_type", value);
    }

    /// <summary>
    /// The geo_backup_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? GeoBackupEnabled
    {
        get => new TerraformReference<bool>(this, "geo_backup_enabled");
        set => SetArgument("geo_backup_enabled", value);
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
    /// The ledger_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LedgerEnabled
    {
        get => new TerraformReference<bool>(this, "ledger_enabled");
        set => SetArgument("ledger_enabled", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string> LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
        set => SetArgument("license_type", value);
    }

    /// <summary>
    /// The maintenance_configuration_name attribute.
    /// </summary>
    public TerraformValue<string> MaintenanceConfigurationName
    {
        get => new TerraformReference<string>(this, "maintenance_configuration_name");
        set => SetArgument("maintenance_configuration_name", value);
    }

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    public TerraformValue<double> MaxSizeGb
    {
        get => new TerraformReference<double>(this, "max_size_gb");
        set => SetArgument("max_size_gb", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    public TerraformValue<double> MinCapacity
    {
        get => new TerraformReference<double>(this, "min_capacity");
        set => SetArgument("min_capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The read_replica_count attribute.
    /// </summary>
    public TerraformValue<double> ReadReplicaCount
    {
        get => new TerraformReference<double>(this, "read_replica_count");
        set => SetArgument("read_replica_count", value);
    }

    /// <summary>
    /// The read_scale attribute.
    /// </summary>
    public TerraformValue<bool> ReadScale
    {
        get => new TerraformReference<bool>(this, "read_scale");
        set => SetArgument("read_scale", value);
    }

    /// <summary>
    /// The recover_database_id attribute.
    /// </summary>
    public TerraformValue<string>? RecoverDatabaseId
    {
        get => new TerraformReference<string>(this, "recover_database_id");
        set => SetArgument("recover_database_id", value);
    }

    /// <summary>
    /// The recovery_point_id attribute.
    /// </summary>
    public TerraformValue<string>? RecoveryPointId
    {
        get => new TerraformReference<string>(this, "recovery_point_id");
        set => SetArgument("recovery_point_id", value);
    }

    /// <summary>
    /// The restore_dropped_database_id attribute.
    /// </summary>
    public TerraformValue<string>? RestoreDroppedDatabaseId
    {
        get => new TerraformReference<string>(this, "restore_dropped_database_id");
        set => SetArgument("restore_dropped_database_id", value);
    }

    /// <summary>
    /// The restore_long_term_retention_backup_id attribute.
    /// </summary>
    public TerraformValue<string>? RestoreLongTermRetentionBackupId
    {
        get => new TerraformReference<string>(this, "restore_long_term_retention_backup_id");
        set => SetArgument("restore_long_term_retention_backup_id", value);
    }

    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    public TerraformValue<string> RestorePointInTime
    {
        get => new TerraformReference<string>(this, "restore_point_in_time");
        set => SetArgument("restore_point_in_time", value);
    }

    /// <summary>
    /// The sample_name attribute.
    /// </summary>
    public TerraformValue<string> SampleName
    {
        get => new TerraformReference<string>(this, "sample_name");
        set => SetArgument("sample_name", value);
    }

    /// <summary>
    /// The secondary_type attribute.
    /// </summary>
    public TerraformValue<string> SecondaryType
    {
        get => new TerraformReference<string>(this, "secondary_type");
        set => SetArgument("secondary_type", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformValue<string> ServerId
    {
        get => new TerraformReference<string>(this, "server_id");
        set => SetArgument("server_id", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountType
    {
        get => new TerraformReference<string>(this, "storage_account_type");
        set => SetArgument("storage_account_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The transparent_data_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TransparentDataEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "transparent_data_encryption_enabled");
        set => SetArgument("transparent_data_encryption_enabled", value);
    }

    /// <summary>
    /// The transparent_data_encryption_key_automatic_rotation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TransparentDataEncryptionKeyAutomaticRotationEnabled
    {
        get => new TerraformReference<bool>(this, "transparent_data_encryption_key_automatic_rotation_enabled");
        set => SetArgument("transparent_data_encryption_key_automatic_rotation_enabled", value);
    }

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string>? TransparentDataEncryptionKeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "transparent_data_encryption_key_vault_key_id");
        set => SetArgument("transparent_data_encryption_key_vault_key_id", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformValue<bool> ZoneRedundant
    {
        get => new TerraformReference<bool>(this, "zone_redundant");
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
