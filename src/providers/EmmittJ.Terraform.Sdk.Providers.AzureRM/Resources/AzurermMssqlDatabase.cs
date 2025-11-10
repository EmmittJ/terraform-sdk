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
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("administrator_login", value);
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdministratorLoginPassword is required")]
    public required TerraformProperty<string> AdministratorLoginPassword
    {
        set => SetProperty("administrator_login_password", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    public required TerraformProperty<string> AuthenticationType
    {
        set => SetProperty("authentication_type", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountId
    {
        set => SetProperty("storage_account_id", value);
    }

    /// <summary>
    /// The storage_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageKey is required")]
    public required TerraformProperty<string> StorageKey
    {
        set => SetProperty("storage_key", value);
    }

    /// <summary>
    /// The storage_key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageKeyType is required")]
    public required TerraformProperty<string> StorageKeyType
    {
        set => SetProperty("storage_key_type", value);
    }

    /// <summary>
    /// The storage_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    public required TerraformProperty<string> StorageUri
    {
        set => SetProperty("storage_uri", value);
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
        set => SetProperty("immutable_backups_enabled", value);
    }

    /// <summary>
    /// The monthly_retention attribute.
    /// </summary>
    public TerraformProperty<string>? MonthlyRetention
    {
        set => SetProperty("monthly_retention", value);
    }

    /// <summary>
    /// The week_of_year attribute.
    /// </summary>
    public TerraformProperty<double>? WeekOfYear
    {
        set => SetProperty("week_of_year", value);
    }

    /// <summary>
    /// The weekly_retention attribute.
    /// </summary>
    public TerraformProperty<string>? WeeklyRetention
    {
        set => SetProperty("weekly_retention", value);
    }

    /// <summary>
    /// The yearly_retention attribute.
    /// </summary>
    public TerraformProperty<string>? YearlyRetention
    {
        set => SetProperty("yearly_retention", value);
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
        set => SetProperty("backup_interval_in_hours", value);
    }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionDays is required")]
    public required TerraformProperty<double> RetentionDays
    {
        set => SetProperty("retention_days", value);
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
        set => SetProperty("disabled_alerts", value);
    }

    /// <summary>
    /// The email_account_admins attribute.
    /// </summary>
    public TerraformProperty<string>? EmailAccountAdmins
    {
        set => SetProperty("email_account_admins", value);
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? EmailAddresses
    {
        set => SetProperty("email_addresses", value);
    }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionDays
    {
        set => SetProperty("retention_days", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string>? State
    {
        set => SetProperty("state", value);
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountAccessKey
    {
        set => SetProperty("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? StorageEndpoint
    {
        set => SetProperty("storage_endpoint", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_mssql_database resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMssqlDatabase : TerraformResource
{
    public AzurermMssqlDatabase(string name) : base("azurerm_mssql_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("auto_pause_delay_in_minutes");
        SetOutput("collation");
        SetOutput("create_mode");
        SetOutput("creation_source_database_id");
        SetOutput("elastic_pool_id");
        SetOutput("enclave_type");
        SetOutput("geo_backup_enabled");
        SetOutput("id");
        SetOutput("ledger_enabled");
        SetOutput("license_type");
        SetOutput("maintenance_configuration_name");
        SetOutput("max_size_gb");
        SetOutput("min_capacity");
        SetOutput("name");
        SetOutput("read_replica_count");
        SetOutput("read_scale");
        SetOutput("recover_database_id");
        SetOutput("recovery_point_id");
        SetOutput("restore_dropped_database_id");
        SetOutput("restore_long_term_retention_backup_id");
        SetOutput("restore_point_in_time");
        SetOutput("sample_name");
        SetOutput("secondary_type");
        SetOutput("server_id");
        SetOutput("sku_name");
        SetOutput("storage_account_type");
        SetOutput("tags");
        SetOutput("transparent_data_encryption_enabled");
        SetOutput("transparent_data_encryption_key_automatic_rotation_enabled");
        SetOutput("transparent_data_encryption_key_vault_key_id");
        SetOutput("zone_redundant");
    }

    /// <summary>
    /// The auto_pause_delay_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double> AutoPauseDelayInMinutes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("auto_pause_delay_in_minutes");
        set => SetProperty("auto_pause_delay_in_minutes", value);
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformProperty<string> Collation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("collation");
        set => SetProperty("collation", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformProperty<string> CreateMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("create_mode");
        set => SetProperty("create_mode", value);
    }

    /// <summary>
    /// The creation_source_database_id attribute.
    /// </summary>
    public TerraformProperty<string> CreationSourceDatabaseId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("creation_source_database_id");
        set => SetProperty("creation_source_database_id", value);
    }

    /// <summary>
    /// The elastic_pool_id attribute.
    /// </summary>
    public TerraformProperty<string> ElasticPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("elastic_pool_id");
        set => SetProperty("elastic_pool_id", value);
    }

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    public TerraformProperty<string> EnclaveType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("enclave_type");
        set => SetProperty("enclave_type", value);
    }

    /// <summary>
    /// The geo_backup_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> GeoBackupEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("geo_backup_enabled");
        set => SetProperty("geo_backup_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ledger_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> LedgerEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ledger_enabled");
        set => SetProperty("ledger_enabled", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformProperty<string> LicenseType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("license_type");
        set => SetProperty("license_type", value);
    }

    /// <summary>
    /// The maintenance_configuration_name attribute.
    /// </summary>
    public TerraformProperty<string> MaintenanceConfigurationName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("maintenance_configuration_name");
        set => SetProperty("maintenance_configuration_name", value);
    }

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    public TerraformProperty<double> MaxSizeGb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_size_gb");
        set => SetProperty("max_size_gb", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    public TerraformProperty<double> MinCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_capacity");
        set => SetProperty("min_capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The read_replica_count attribute.
    /// </summary>
    public TerraformProperty<double> ReadReplicaCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("read_replica_count");
        set => SetProperty("read_replica_count", value);
    }

    /// <summary>
    /// The read_scale attribute.
    /// </summary>
    public TerraformProperty<bool> ReadScale
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("read_scale");
        set => SetProperty("read_scale", value);
    }

    /// <summary>
    /// The recover_database_id attribute.
    /// </summary>
    public TerraformProperty<string> RecoverDatabaseId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recover_database_id");
        set => SetProperty("recover_database_id", value);
    }

    /// <summary>
    /// The recovery_point_id attribute.
    /// </summary>
    public TerraformProperty<string> RecoveryPointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recovery_point_id");
        set => SetProperty("recovery_point_id", value);
    }

    /// <summary>
    /// The restore_dropped_database_id attribute.
    /// </summary>
    public TerraformProperty<string> RestoreDroppedDatabaseId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("restore_dropped_database_id");
        set => SetProperty("restore_dropped_database_id", value);
    }

    /// <summary>
    /// The restore_long_term_retention_backup_id attribute.
    /// </summary>
    public TerraformProperty<string> RestoreLongTermRetentionBackupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("restore_long_term_retention_backup_id");
        set => SetProperty("restore_long_term_retention_backup_id", value);
    }

    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    public TerraformProperty<string> RestorePointInTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("restore_point_in_time");
        set => SetProperty("restore_point_in_time", value);
    }

    /// <summary>
    /// The sample_name attribute.
    /// </summary>
    public TerraformProperty<string> SampleName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sample_name");
        set => SetProperty("sample_name", value);
    }

    /// <summary>
    /// The secondary_type attribute.
    /// </summary>
    public TerraformProperty<string> SecondaryType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secondary_type");
        set => SetProperty("secondary_type", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformProperty<string> ServerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server_id");
        set => SetProperty("server_id", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string> SkuName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_name");
        set => SetProperty("sku_name", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformProperty<string> StorageAccountType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_type");
        set => SetProperty("storage_account_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The transparent_data_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> TransparentDataEncryptionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("transparent_data_encryption_enabled");
        set => SetProperty("transparent_data_encryption_enabled", value);
    }

    /// <summary>
    /// The transparent_data_encryption_key_automatic_rotation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> TransparentDataEncryptionKeyAutomaticRotationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("transparent_data_encryption_key_automatic_rotation_enabled");
        set => SetProperty("transparent_data_encryption_key_automatic_rotation_enabled", value);
    }

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string> TransparentDataEncryptionKeyVaultKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transparent_data_encryption_key_vault_key_id");
        set => SetProperty("transparent_data_encryption_key_vault_key_id", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformProperty<bool> ZoneRedundant
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("zone_redundant");
        set => SetProperty("zone_redundant", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermMssqlDatabaseIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for import.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Import block(s) allowed")]
    public List<AzurermMssqlDatabaseImportBlock>? Import
    {
        set => SetProperty("import", value);
    }

    /// <summary>
    /// Block for long_term_retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LongTermRetentionPolicy block(s) allowed")]
    public List<AzurermMssqlDatabaseLongTermRetentionPolicyBlock>? LongTermRetentionPolicy
    {
        set => SetProperty("long_term_retention_policy", value);
    }

    /// <summary>
    /// Block for short_term_retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShortTermRetentionPolicy block(s) allowed")]
    public List<AzurermMssqlDatabaseShortTermRetentionPolicyBlock>? ShortTermRetentionPolicy
    {
        set => SetProperty("short_term_retention_policy", value);
    }

    /// <summary>
    /// Block for threat_detection_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreatDetectionPolicy block(s) allowed")]
    public List<AzurermMssqlDatabaseThreatDetectionPolicyBlock>? ThreatDetectionPolicy
    {
        set => SetProperty("threat_detection_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlDatabaseTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
