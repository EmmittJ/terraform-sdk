using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlDatabaseIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for import in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlDatabaseImportBlock : TerraformBlock
{
    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdministratorLogin is required")]
    public required TerraformProperty<string> AdministratorLogin
    {
        get => GetProperty<TerraformProperty<string>>("administrator_login");
        set => WithProperty("administrator_login", value);
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdministratorLoginPassword is required")]
    public required TerraformProperty<string> AdministratorLoginPassword
    {
        get => GetProperty<TerraformProperty<string>>("administrator_login_password");
        set => WithProperty("administrator_login_password", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    public required TerraformProperty<string> AuthenticationType
    {
        get => GetProperty<TerraformProperty<string>>("authentication_type");
        set => WithProperty("authentication_type", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_id");
        set => WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// The storage_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageKey is required")]
    public required TerraformProperty<string> StorageKey
    {
        get => GetProperty<TerraformProperty<string>>("storage_key");
        set => WithProperty("storage_key", value);
    }

    /// <summary>
    /// The storage_key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageKeyType is required")]
    public required TerraformProperty<string> StorageKeyType
    {
        get => GetProperty<TerraformProperty<string>>("storage_key_type");
        set => WithProperty("storage_key_type", value);
    }

    /// <summary>
    /// The storage_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    public required TerraformProperty<string> StorageUri
    {
        get => GetProperty<TerraformProperty<string>>("storage_uri");
        set => WithProperty("storage_uri", value);
    }

}

/// <summary>
/// Block type for long_term_retention_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlDatabaseLongTermRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The immutable_backups_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ImmutableBackupsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("immutable_backups_enabled");
        set => WithProperty("immutable_backups_enabled", value);
    }

    /// <summary>
    /// The monthly_retention attribute.
    /// </summary>
    public TerraformProperty<string>? MonthlyRetention
    {
        get => GetProperty<TerraformProperty<string>>("monthly_retention");
        set => WithProperty("monthly_retention", value);
    }

    /// <summary>
    /// The week_of_year attribute.
    /// </summary>
    public TerraformProperty<double>? WeekOfYear
    {
        get => GetProperty<TerraformProperty<double>>("week_of_year");
        set => WithProperty("week_of_year", value);
    }

    /// <summary>
    /// The weekly_retention attribute.
    /// </summary>
    public TerraformProperty<string>? WeeklyRetention
    {
        get => GetProperty<TerraformProperty<string>>("weekly_retention");
        set => WithProperty("weekly_retention", value);
    }

    /// <summary>
    /// The yearly_retention attribute.
    /// </summary>
    public TerraformProperty<string>? YearlyRetention
    {
        get => GetProperty<TerraformProperty<string>>("yearly_retention");
        set => WithProperty("yearly_retention", value);
    }

}

/// <summary>
/// Block type for short_term_retention_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlDatabaseShortTermRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The backup_interval_in_hours attribute.
    /// </summary>
    public TerraformProperty<double>? BackupIntervalInHours
    {
        get => GetProperty<TerraformProperty<double>>("backup_interval_in_hours");
        set => WithProperty("backup_interval_in_hours", value);
    }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionDays is required")]
    public required TerraformProperty<double> RetentionDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_days");
        set => WithProperty("retention_days", value);
    }

}

/// <summary>
/// Block type for threat_detection_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlDatabaseThreatDetectionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The disabled_alerts attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DisabledAlerts
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("disabled_alerts");
        set => WithProperty("disabled_alerts", value);
    }

    /// <summary>
    /// The email_account_admins attribute.
    /// </summary>
    public TerraformProperty<string>? EmailAccountAdmins
    {
        get => GetProperty<TerraformProperty<string>>("email_account_admins");
        set => WithProperty("email_account_admins", value);
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? EmailAddresses
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("email_addresses");
        set => WithProperty("email_addresses", value);
    }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_days");
        set => WithProperty("retention_days", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => WithProperty("state", value);
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountAccessKey
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_access_key");
        set => WithProperty("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? StorageEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("storage_endpoint");
        set => WithProperty("storage_endpoint", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlDatabaseTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
/// Manages a azurerm_mssql_database resource.
/// </summary>
public class AzurermMssqlDatabase : TerraformResource
{
    public AzurermMssqlDatabase(string name) : base("azurerm_mssql_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The auto_pause_delay_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? AutoPauseDelayInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("auto_pause_delay_in_minutes");
        set => this.WithProperty("auto_pause_delay_in_minutes", value);
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformProperty<string>? Collation
    {
        get => GetProperty<TerraformProperty<string>>("collation");
        set => this.WithProperty("collation", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformProperty<string>? CreateMode
    {
        get => GetProperty<TerraformProperty<string>>("create_mode");
        set => this.WithProperty("create_mode", value);
    }

    /// <summary>
    /// The creation_source_database_id attribute.
    /// </summary>
    public TerraformProperty<string>? CreationSourceDatabaseId
    {
        get => GetProperty<TerraformProperty<string>>("creation_source_database_id");
        set => this.WithProperty("creation_source_database_id", value);
    }

    /// <summary>
    /// The elastic_pool_id attribute.
    /// </summary>
    public TerraformProperty<string>? ElasticPoolId
    {
        get => GetProperty<TerraformProperty<string>>("elastic_pool_id");
        set => this.WithProperty("elastic_pool_id", value);
    }

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    public TerraformProperty<string>? EnclaveType
    {
        get => GetProperty<TerraformProperty<string>>("enclave_type");
        set => this.WithProperty("enclave_type", value);
    }

    /// <summary>
    /// The geo_backup_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? GeoBackupEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("geo_backup_enabled");
        set => this.WithProperty("geo_backup_enabled", value);
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
    /// The ledger_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LedgerEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ledger_enabled");
        set => this.WithProperty("ledger_enabled", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformProperty<string>? LicenseType
    {
        get => GetProperty<TerraformProperty<string>>("license_type");
        set => this.WithProperty("license_type", value);
    }

    /// <summary>
    /// The maintenance_configuration_name attribute.
    /// </summary>
    public TerraformProperty<string>? MaintenanceConfigurationName
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_configuration_name");
        set => this.WithProperty("maintenance_configuration_name", value);
    }

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? MaxSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("max_size_gb");
        set => this.WithProperty("max_size_gb", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? MinCapacity
    {
        get => GetProperty<TerraformProperty<double>>("min_capacity");
        set => this.WithProperty("min_capacity", value);
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
    /// The read_replica_count attribute.
    /// </summary>
    public TerraformProperty<double>? ReadReplicaCount
    {
        get => GetProperty<TerraformProperty<double>>("read_replica_count");
        set => this.WithProperty("read_replica_count", value);
    }

    /// <summary>
    /// The read_scale attribute.
    /// </summary>
    public TerraformProperty<bool>? ReadScale
    {
        get => GetProperty<TerraformProperty<bool>>("read_scale");
        set => this.WithProperty("read_scale", value);
    }

    /// <summary>
    /// The recover_database_id attribute.
    /// </summary>
    public TerraformProperty<string>? RecoverDatabaseId
    {
        get => GetProperty<TerraformProperty<string>>("recover_database_id");
        set => this.WithProperty("recover_database_id", value);
    }

    /// <summary>
    /// The recovery_point_id attribute.
    /// </summary>
    public TerraformProperty<string>? RecoveryPointId
    {
        get => GetProperty<TerraformProperty<string>>("recovery_point_id");
        set => this.WithProperty("recovery_point_id", value);
    }

    /// <summary>
    /// The restore_dropped_database_id attribute.
    /// </summary>
    public TerraformProperty<string>? RestoreDroppedDatabaseId
    {
        get => GetProperty<TerraformProperty<string>>("restore_dropped_database_id");
        set => this.WithProperty("restore_dropped_database_id", value);
    }

    /// <summary>
    /// The restore_long_term_retention_backup_id attribute.
    /// </summary>
    public TerraformProperty<string>? RestoreLongTermRetentionBackupId
    {
        get => GetProperty<TerraformProperty<string>>("restore_long_term_retention_backup_id");
        set => this.WithProperty("restore_long_term_retention_backup_id", value);
    }

    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    public TerraformProperty<string>? RestorePointInTime
    {
        get => GetProperty<TerraformProperty<string>>("restore_point_in_time");
        set => this.WithProperty("restore_point_in_time", value);
    }

    /// <summary>
    /// The sample_name attribute.
    /// </summary>
    public TerraformProperty<string>? SampleName
    {
        get => GetProperty<TerraformProperty<string>>("sample_name");
        set => this.WithProperty("sample_name", value);
    }

    /// <summary>
    /// The secondary_type attribute.
    /// </summary>
    public TerraformProperty<string>? SecondaryType
    {
        get => GetProperty<TerraformProperty<string>>("secondary_type");
        set => this.WithProperty("secondary_type", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformProperty<string> ServerId
    {
        get => GetProperty<TerraformProperty<string>>("server_id");
        set => this.WithProperty("server_id", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountType
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_type");
        set => this.WithProperty("storage_account_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The transparent_data_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TransparentDataEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("transparent_data_encryption_enabled");
        set => this.WithProperty("transparent_data_encryption_enabled", value);
    }

    /// <summary>
    /// The transparent_data_encryption_key_automatic_rotation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TransparentDataEncryptionKeyAutomaticRotationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("transparent_data_encryption_key_automatic_rotation_enabled");
        set => this.WithProperty("transparent_data_encryption_key_automatic_rotation_enabled", value);
    }

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? TransparentDataEncryptionKeyVaultKeyId
    {
        get => GetProperty<TerraformProperty<string>>("transparent_data_encryption_key_vault_key_id");
        set => this.WithProperty("transparent_data_encryption_key_vault_key_id", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformProperty<bool>? ZoneRedundant
    {
        get => GetProperty<TerraformProperty<bool>>("zone_redundant");
        set => this.WithProperty("zone_redundant", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermMssqlDatabaseIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermMssqlDatabaseIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for import.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Import block(s) allowed")]
    public List<AzurermMssqlDatabaseImportBlock>? Import
    {
        get => GetProperty<List<AzurermMssqlDatabaseImportBlock>>("import");
        set => this.WithProperty("import", value);
    }

    /// <summary>
    /// Block for long_term_retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LongTermRetentionPolicy block(s) allowed")]
    public List<AzurermMssqlDatabaseLongTermRetentionPolicyBlock>? LongTermRetentionPolicy
    {
        get => GetProperty<List<AzurermMssqlDatabaseLongTermRetentionPolicyBlock>>("long_term_retention_policy");
        set => this.WithProperty("long_term_retention_policy", value);
    }

    /// <summary>
    /// Block for short_term_retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShortTermRetentionPolicy block(s) allowed")]
    public List<AzurermMssqlDatabaseShortTermRetentionPolicyBlock>? ShortTermRetentionPolicy
    {
        get => GetProperty<List<AzurermMssqlDatabaseShortTermRetentionPolicyBlock>>("short_term_retention_policy");
        set => this.WithProperty("short_term_retention_policy", value);
    }

    /// <summary>
    /// Block for threat_detection_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreatDetectionPolicy block(s) allowed")]
    public List<AzurermMssqlDatabaseThreatDetectionPolicyBlock>? ThreatDetectionPolicy
    {
        get => GetProperty<List<AzurermMssqlDatabaseThreatDetectionPolicyBlock>>("threat_detection_policy");
        set => this.WithProperty("threat_detection_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlDatabaseTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMssqlDatabaseTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
