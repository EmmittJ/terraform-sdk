using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlDatabaseIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    [TerraformPropertyName("identity_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for import in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlDatabaseImportBlock : ITerraformBlock
{
    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdministratorLogin is required")]
    [TerraformPropertyName("administrator_login")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AdministratorLogin { get; set; }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdministratorLoginPassword is required")]
    [TerraformPropertyName("administrator_login_password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AdministratorLoginPassword { get; set; }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    [TerraformPropertyName("authentication_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AuthenticationType { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageAccountId { get; set; }

    /// <summary>
    /// The storage_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageKey is required")]
    [TerraformPropertyName("storage_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageKey { get; set; }

    /// <summary>
    /// The storage_key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageKeyType is required")]
    [TerraformPropertyName("storage_key_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageKeyType { get; set; }

    /// <summary>
    /// The storage_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    [TerraformPropertyName("storage_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageUri { get; set; }

}

/// <summary>
/// Block type for long_term_retention_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlDatabaseLongTermRetentionPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The immutable_backups_enabled attribute.
    /// </summary>
    [TerraformPropertyName("immutable_backups_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ImmutableBackupsEnabled { get; set; }

    /// <summary>
    /// The monthly_retention attribute.
    /// </summary>
    [TerraformPropertyName("monthly_retention")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MonthlyRetention { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "monthly_retention");

    /// <summary>
    /// The week_of_year attribute.
    /// </summary>
    [TerraformPropertyName("week_of_year")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> WeekOfYear { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "week_of_year");

    /// <summary>
    /// The weekly_retention attribute.
    /// </summary>
    [TerraformPropertyName("weekly_retention")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> WeeklyRetention { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "weekly_retention");

    /// <summary>
    /// The yearly_retention attribute.
    /// </summary>
    [TerraformPropertyName("yearly_retention")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> YearlyRetention { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "yearly_retention");

}

/// <summary>
/// Block type for short_term_retention_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlDatabaseShortTermRetentionPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The backup_interval_in_hours attribute.
    /// </summary>
    [TerraformPropertyName("backup_interval_in_hours")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> BackupIntervalInHours { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "backup_interval_in_hours");

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionDays is required")]
    [TerraformPropertyName("retention_days")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> RetentionDays { get; set; }

}

/// <summary>
/// Block type for threat_detection_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlDatabaseThreatDetectionPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The disabled_alerts attribute.
    /// </summary>
    [TerraformPropertyName("disabled_alerts")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? DisabledAlerts { get; set; }

    /// <summary>
    /// The email_account_admins attribute.
    /// </summary>
    [TerraformPropertyName("email_account_admins")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EmailAccountAdmins { get; set; }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    [TerraformPropertyName("email_addresses")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? EmailAddresses { get; set; }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    [TerraformPropertyName("retention_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetentionDays { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? State { get; set; }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_access_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageAccountAccessKey { get; set; }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("storage_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageEndpoint { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlDatabaseTimeoutsBlock : ITerraformBlock
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
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("auto_pause_delay_in_minutes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> AutoPauseDelayInMinutes { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "auto_pause_delay_in_minutes");

    /// <summary>
    /// The collation attribute.
    /// </summary>
    [TerraformPropertyName("collation")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Collation { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "collation");

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    [TerraformPropertyName("create_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CreateMode { get; set; }

    /// <summary>
    /// The creation_source_database_id attribute.
    /// </summary>
    [TerraformPropertyName("creation_source_database_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CreationSourceDatabaseId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_source_database_id");

    /// <summary>
    /// The elastic_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("elastic_pool_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ElasticPoolId { get; set; }

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    [TerraformPropertyName("enclave_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EnclaveType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "enclave_type");

    /// <summary>
    /// The geo_backup_enabled attribute.
    /// </summary>
    [TerraformPropertyName("geo_backup_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? GeoBackupEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ledger_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ledger_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> LedgerEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "ledger_enabled");

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformPropertyName("license_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LicenseType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "license_type");

    /// <summary>
    /// The maintenance_configuration_name attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_configuration_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MaintenanceConfigurationName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "maintenance_configuration_name");

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("max_size_gb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxSizeGb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_size_gb");

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [TerraformPropertyName("min_capacity")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MinCapacity { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "min_capacity");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The read_replica_count attribute.
    /// </summary>
    [TerraformPropertyName("read_replica_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ReadReplicaCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "read_replica_count");

    /// <summary>
    /// The read_scale attribute.
    /// </summary>
    [TerraformPropertyName("read_scale")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ReadScale { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "read_scale");

    /// <summary>
    /// The recover_database_id attribute.
    /// </summary>
    [TerraformPropertyName("recover_database_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RecoverDatabaseId { get; set; }

    /// <summary>
    /// The recovery_point_id attribute.
    /// </summary>
    [TerraformPropertyName("recovery_point_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RecoveryPointId { get; set; }

    /// <summary>
    /// The restore_dropped_database_id attribute.
    /// </summary>
    [TerraformPropertyName("restore_dropped_database_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RestoreDroppedDatabaseId { get; set; }

    /// <summary>
    /// The restore_long_term_retention_backup_id attribute.
    /// </summary>
    [TerraformPropertyName("restore_long_term_retention_backup_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RestoreLongTermRetentionBackupId { get; set; }

    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    [TerraformPropertyName("restore_point_in_time")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RestorePointInTime { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "restore_point_in_time");

    /// <summary>
    /// The sample_name attribute.
    /// </summary>
    [TerraformPropertyName("sample_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SampleName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sample_name");

    /// <summary>
    /// The secondary_type attribute.
    /// </summary>
    [TerraformPropertyName("secondary_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SecondaryType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_type");

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformPropertyName("server_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServerId { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SkuName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku_name");

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageAccountType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The transparent_data_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("transparent_data_encryption_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TransparentDataEncryptionEnabled { get; set; }

    /// <summary>
    /// The transparent_data_encryption_key_automatic_rotation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("transparent_data_encryption_key_automatic_rotation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TransparentDataEncryptionKeyAutomaticRotationEnabled { get; set; }

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    [TerraformPropertyName("transparent_data_encryption_key_vault_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TransparentDataEncryptionKeyVaultKeyId { get; set; }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformPropertyName("zone_redundant")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ZoneRedundant { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "zone_redundant");

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermMssqlDatabaseIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for import.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Import block(s) allowed")]
    [TerraformPropertyName("import")]
    public TerraformList<TerraformBlock<AzurermMssqlDatabaseImportBlock>>? Import { get; set; } = new();

    /// <summary>
    /// Block for long_term_retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LongTermRetentionPolicy block(s) allowed")]
    [TerraformPropertyName("long_term_retention_policy")]
    public TerraformList<TerraformBlock<AzurermMssqlDatabaseLongTermRetentionPolicyBlock>>? LongTermRetentionPolicy { get; set; } = new();

    /// <summary>
    /// Block for short_term_retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShortTermRetentionPolicy block(s) allowed")]
    [TerraformPropertyName("short_term_retention_policy")]
    public TerraformList<TerraformBlock<AzurermMssqlDatabaseShortTermRetentionPolicyBlock>>? ShortTermRetentionPolicy { get; set; } = new();

    /// <summary>
    /// Block for threat_detection_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreatDetectionPolicy block(s) allowed")]
    [TerraformPropertyName("threat_detection_policy")]
    public TerraformList<TerraformBlock<AzurermMssqlDatabaseThreatDetectionPolicyBlock>>? ThreatDetectionPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlDatabaseTimeoutsBlock>? Timeouts { get; set; } = new();

}
