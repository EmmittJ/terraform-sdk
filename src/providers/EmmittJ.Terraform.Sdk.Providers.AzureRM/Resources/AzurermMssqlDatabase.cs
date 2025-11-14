using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("identity_ids")]
    public required TerraformSet<string> IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
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
    [TerraformArgument("administrator_login")]
    public required TerraformValue<string> AdministratorLogin
    {
        get => new TerraformReference<string>(this, "administrator_login");
        set => SetArgument("administrator_login", value);
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdministratorLoginPassword is required")]
    [TerraformArgument("administrator_login_password")]
    public required TerraformValue<string> AdministratorLoginPassword
    {
        get => new TerraformReference<string>(this, "administrator_login_password");
        set => SetArgument("administrator_login_password", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    [TerraformArgument("authentication_type")]
    public required TerraformValue<string> AuthenticationType
    {
        get => new TerraformReference<string>(this, "authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformArgument("storage_account_id")]
    public TerraformValue<string>? StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The storage_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageKey is required")]
    [TerraformArgument("storage_key")]
    public required TerraformValue<string> StorageKey
    {
        get => new TerraformReference<string>(this, "storage_key");
        set => SetArgument("storage_key", value);
    }

    /// <summary>
    /// The storage_key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageKeyType is required")]
    [TerraformArgument("storage_key_type")]
    public required TerraformValue<string> StorageKeyType
    {
        get => new TerraformReference<string>(this, "storage_key_type");
        set => SetArgument("storage_key_type", value);
    }

    /// <summary>
    /// The storage_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    [TerraformArgument("storage_uri")]
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
    [TerraformArgument("immutable_backups_enabled")]
    public TerraformValue<bool>? ImmutableBackupsEnabled
    {
        get => new TerraformReference<bool>(this, "immutable_backups_enabled");
        set => SetArgument("immutable_backups_enabled", value);
    }

    /// <summary>
    /// The monthly_retention attribute.
    /// </summary>
    [TerraformArgument("monthly_retention")]
    public TerraformValue<string> MonthlyRetention
    {
        get => new TerraformReference<string>(this, "monthly_retention");
        set => SetArgument("monthly_retention", value);
    }

    /// <summary>
    /// The week_of_year attribute.
    /// </summary>
    [TerraformArgument("week_of_year")]
    public TerraformValue<double> WeekOfYear
    {
        get => new TerraformReference<double>(this, "week_of_year");
        set => SetArgument("week_of_year", value);
    }

    /// <summary>
    /// The weekly_retention attribute.
    /// </summary>
    [TerraformArgument("weekly_retention")]
    public TerraformValue<string> WeeklyRetention
    {
        get => new TerraformReference<string>(this, "weekly_retention");
        set => SetArgument("weekly_retention", value);
    }

    /// <summary>
    /// The yearly_retention attribute.
    /// </summary>
    [TerraformArgument("yearly_retention")]
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
    [TerraformArgument("backup_interval_in_hours")]
    public TerraformValue<double> BackupIntervalInHours
    {
        get => new TerraformReference<double>(this, "backup_interval_in_hours");
        set => SetArgument("backup_interval_in_hours", value);
    }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionDays is required")]
    [TerraformArgument("retention_days")]
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
    [TerraformArgument("disabled_alerts")]
    public TerraformSet<string>? DisabledAlerts
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "disabled_alerts").ResolveNodes(ctx));
        set => SetArgument("disabled_alerts", value);
    }

    /// <summary>
    /// The email_account_admins attribute.
    /// </summary>
    [TerraformArgument("email_account_admins")]
    public TerraformValue<string>? EmailAccountAdmins
    {
        get => new TerraformReference<string>(this, "email_account_admins");
        set => SetArgument("email_account_admins", value);
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    [TerraformArgument("email_addresses")]
    public TerraformSet<string>? EmailAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "email_addresses").ResolveNodes(ctx));
        set => SetArgument("email_addresses", value);
    }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    [TerraformArgument("retention_days")]
    public TerraformValue<double>? RetentionDays
    {
        get => new TerraformReference<double>(this, "retention_days");
        set => SetArgument("retention_days", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformArgument("state")]
    public TerraformValue<string>? State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [TerraformArgument("storage_account_access_key")]
    public TerraformValue<string>? StorageAccountAccessKey
    {
        get => new TerraformReference<string>(this, "storage_account_access_key");
        set => SetArgument("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    [TerraformArgument("storage_endpoint")]
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The auto_pause_delay_in_minutes attribute.
    /// </summary>
    [TerraformArgument("auto_pause_delay_in_minutes")]
    public TerraformValue<double> AutoPauseDelayInMinutes
    {
        get => new TerraformReference<double>(this, "auto_pause_delay_in_minutes");
        set => SetArgument("auto_pause_delay_in_minutes", value);
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    [TerraformArgument("collation")]
    public TerraformValue<string> Collation
    {
        get => new TerraformReference<string>(this, "collation");
        set => SetArgument("collation", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    [TerraformArgument("create_mode")]
    public TerraformValue<string>? CreateMode
    {
        get => new TerraformReference<string>(this, "create_mode");
        set => SetArgument("create_mode", value);
    }

    /// <summary>
    /// The creation_source_database_id attribute.
    /// </summary>
    [TerraformArgument("creation_source_database_id")]
    public TerraformValue<string> CreationSourceDatabaseId
    {
        get => new TerraformReference<string>(this, "creation_source_database_id");
        set => SetArgument("creation_source_database_id", value);
    }

    /// <summary>
    /// The elastic_pool_id attribute.
    /// </summary>
    [TerraformArgument("elastic_pool_id")]
    public TerraformValue<string>? ElasticPoolId
    {
        get => new TerraformReference<string>(this, "elastic_pool_id");
        set => SetArgument("elastic_pool_id", value);
    }

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    [TerraformArgument("enclave_type")]
    public TerraformValue<string> EnclaveType
    {
        get => new TerraformReference<string>(this, "enclave_type");
        set => SetArgument("enclave_type", value);
    }

    /// <summary>
    /// The geo_backup_enabled attribute.
    /// </summary>
    [TerraformArgument("geo_backup_enabled")]
    public TerraformValue<bool>? GeoBackupEnabled
    {
        get => new TerraformReference<bool>(this, "geo_backup_enabled");
        set => SetArgument("geo_backup_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ledger_enabled attribute.
    /// </summary>
    [TerraformArgument("ledger_enabled")]
    public TerraformValue<bool> LedgerEnabled
    {
        get => new TerraformReference<bool>(this, "ledger_enabled");
        set => SetArgument("ledger_enabled", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformArgument("license_type")]
    public TerraformValue<string> LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
        set => SetArgument("license_type", value);
    }

    /// <summary>
    /// The maintenance_configuration_name attribute.
    /// </summary>
    [TerraformArgument("maintenance_configuration_name")]
    public TerraformValue<string> MaintenanceConfigurationName
    {
        get => new TerraformReference<string>(this, "maintenance_configuration_name");
        set => SetArgument("maintenance_configuration_name", value);
    }

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    [TerraformArgument("max_size_gb")]
    public TerraformValue<double> MaxSizeGb
    {
        get => new TerraformReference<double>(this, "max_size_gb");
        set => SetArgument("max_size_gb", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [TerraformArgument("min_capacity")]
    public TerraformValue<double> MinCapacity
    {
        get => new TerraformReference<double>(this, "min_capacity");
        set => SetArgument("min_capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The read_replica_count attribute.
    /// </summary>
    [TerraformArgument("read_replica_count")]
    public TerraformValue<double> ReadReplicaCount
    {
        get => new TerraformReference<double>(this, "read_replica_count");
        set => SetArgument("read_replica_count", value);
    }

    /// <summary>
    /// The read_scale attribute.
    /// </summary>
    [TerraformArgument("read_scale")]
    public TerraformValue<bool> ReadScale
    {
        get => new TerraformReference<bool>(this, "read_scale");
        set => SetArgument("read_scale", value);
    }

    /// <summary>
    /// The recover_database_id attribute.
    /// </summary>
    [TerraformArgument("recover_database_id")]
    public TerraformValue<string>? RecoverDatabaseId
    {
        get => new TerraformReference<string>(this, "recover_database_id");
        set => SetArgument("recover_database_id", value);
    }

    /// <summary>
    /// The recovery_point_id attribute.
    /// </summary>
    [TerraformArgument("recovery_point_id")]
    public TerraformValue<string>? RecoveryPointId
    {
        get => new TerraformReference<string>(this, "recovery_point_id");
        set => SetArgument("recovery_point_id", value);
    }

    /// <summary>
    /// The restore_dropped_database_id attribute.
    /// </summary>
    [TerraformArgument("restore_dropped_database_id")]
    public TerraformValue<string>? RestoreDroppedDatabaseId
    {
        get => new TerraformReference<string>(this, "restore_dropped_database_id");
        set => SetArgument("restore_dropped_database_id", value);
    }

    /// <summary>
    /// The restore_long_term_retention_backup_id attribute.
    /// </summary>
    [TerraformArgument("restore_long_term_retention_backup_id")]
    public TerraformValue<string>? RestoreLongTermRetentionBackupId
    {
        get => new TerraformReference<string>(this, "restore_long_term_retention_backup_id");
        set => SetArgument("restore_long_term_retention_backup_id", value);
    }

    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    [TerraformArgument("restore_point_in_time")]
    public TerraformValue<string> RestorePointInTime
    {
        get => new TerraformReference<string>(this, "restore_point_in_time");
        set => SetArgument("restore_point_in_time", value);
    }

    /// <summary>
    /// The sample_name attribute.
    /// </summary>
    [TerraformArgument("sample_name")]
    public TerraformValue<string> SampleName
    {
        get => new TerraformReference<string>(this, "sample_name");
        set => SetArgument("sample_name", value);
    }

    /// <summary>
    /// The secondary_type attribute.
    /// </summary>
    [TerraformArgument("secondary_type")]
    public TerraformValue<string> SecondaryType
    {
        get => new TerraformReference<string>(this, "secondary_type");
        set => SetArgument("secondary_type", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformArgument("server_id")]
    public required TerraformValue<string> ServerId
    {
        get => new TerraformReference<string>(this, "server_id");
        set => SetArgument("server_id", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformArgument("sku_name")]
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformArgument("storage_account_type")]
    public TerraformValue<string>? StorageAccountType
    {
        get => new TerraformReference<string>(this, "storage_account_type");
        set => SetArgument("storage_account_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The transparent_data_encryption_enabled attribute.
    /// </summary>
    [TerraformArgument("transparent_data_encryption_enabled")]
    public TerraformValue<bool>? TransparentDataEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "transparent_data_encryption_enabled");
        set => SetArgument("transparent_data_encryption_enabled", value);
    }

    /// <summary>
    /// The transparent_data_encryption_key_automatic_rotation_enabled attribute.
    /// </summary>
    [TerraformArgument("transparent_data_encryption_key_automatic_rotation_enabled")]
    public TerraformValue<bool>? TransparentDataEncryptionKeyAutomaticRotationEnabled
    {
        get => new TerraformReference<bool>(this, "transparent_data_encryption_key_automatic_rotation_enabled");
        set => SetArgument("transparent_data_encryption_key_automatic_rotation_enabled", value);
    }

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    [TerraformArgument("transparent_data_encryption_key_vault_key_id")]
    public TerraformValue<string>? TransparentDataEncryptionKeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "transparent_data_encryption_key_vault_key_id");
        set => SetArgument("transparent_data_encryption_key_vault_key_id", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformArgument("zone_redundant")]
    public TerraformValue<bool> ZoneRedundant
    {
        get => new TerraformReference<bool>(this, "zone_redundant");
        set => SetArgument("zone_redundant", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermMssqlDatabaseIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for import.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Import block(s) allowed")]
    [TerraformArgument("import")]
    public TerraformList<AzurermMssqlDatabaseImportBlock> Import { get; set; } = new();

    /// <summary>
    /// Block for long_term_retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LongTermRetentionPolicy block(s) allowed")]
    [TerraformArgument("long_term_retention_policy")]
    public TerraformList<AzurermMssqlDatabaseLongTermRetentionPolicyBlock> LongTermRetentionPolicy { get; set; } = new();

    /// <summary>
    /// Block for short_term_retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShortTermRetentionPolicy block(s) allowed")]
    [TerraformArgument("short_term_retention_policy")]
    public TerraformList<AzurermMssqlDatabaseShortTermRetentionPolicyBlock> ShortTermRetentionPolicy { get; set; } = new();

    /// <summary>
    /// Block for threat_detection_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreatDetectionPolicy block(s) allowed")]
    [TerraformArgument("threat_detection_policy")]
    public TerraformList<AzurermMssqlDatabaseThreatDetectionPolicyBlock> ThreatDetectionPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMssqlDatabaseTimeoutsBlock Timeouts { get; set; } = new();

}
