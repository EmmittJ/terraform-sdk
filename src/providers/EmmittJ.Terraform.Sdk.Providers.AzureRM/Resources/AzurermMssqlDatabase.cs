using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlDatabaseIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    [TerraformPropertyName("identity_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> IdentityIds { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for import in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlDatabaseImportBlock
{
    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdministratorLogin is required")]
    [TerraformPropertyName("administrator_login")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AdministratorLogin { get; set; }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdministratorLoginPassword is required")]
    [TerraformPropertyName("administrator_login_password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AdministratorLoginPassword { get; set; }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    [TerraformPropertyName("authentication_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AuthenticationType { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageAccountId { get; set; }

    /// <summary>
    /// The storage_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageKey is required")]
    [TerraformPropertyName("storage_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageKey { get; set; }

    /// <summary>
    /// The storage_key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageKeyType is required")]
    [TerraformPropertyName("storage_key_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageKeyType { get; set; }

    /// <summary>
    /// The storage_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    [TerraformPropertyName("storage_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageUri { get; set; }

}

/// <summary>
/// Block type for long_term_retention_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlDatabaseLongTermRetentionPolicyBlock
{
    /// <summary>
    /// The immutable_backups_enabled attribute.
    /// </summary>
    [TerraformPropertyName("immutable_backups_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ImmutableBackupsEnabled { get; set; }

    /// <summary>
    /// The monthly_retention attribute.
    /// </summary>
    [TerraformPropertyName("monthly_retention")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MonthlyRetention { get; set; } = default!;

    /// <summary>
    /// The week_of_year attribute.
    /// </summary>
    [TerraformPropertyName("week_of_year")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> WeekOfYear { get; set; } = default!;

    /// <summary>
    /// The weekly_retention attribute.
    /// </summary>
    [TerraformPropertyName("weekly_retention")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> WeeklyRetention { get; set; } = default!;

    /// <summary>
    /// The yearly_retention attribute.
    /// </summary>
    [TerraformPropertyName("yearly_retention")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> YearlyRetention { get; set; } = default!;

}

/// <summary>
/// Block type for short_term_retention_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlDatabaseShortTermRetentionPolicyBlock
{
    /// <summary>
    /// The backup_interval_in_hours attribute.
    /// </summary>
    [TerraformPropertyName("backup_interval_in_hours")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> BackupIntervalInHours { get; set; } = default!;

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionDays is required")]
    [TerraformPropertyName("retention_days")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> RetentionDays { get; set; }

}

/// <summary>
/// Block type for threat_detection_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlDatabaseThreatDetectionPolicyBlock
{
    /// <summary>
    /// The disabled_alerts attribute.
    /// </summary>
    [TerraformPropertyName("disabled_alerts")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? DisabledAlerts { get; set; }

    /// <summary>
    /// The email_account_admins attribute.
    /// </summary>
    [TerraformPropertyName("email_account_admins")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EmailAccountAdmins { get; set; }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    [TerraformPropertyName("email_addresses")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? EmailAddresses { get; set; }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    [TerraformPropertyName("retention_days")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RetentionDays { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? State { get; set; }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_access_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageAccountAccessKey { get; set; }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("storage_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageEndpoint { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlDatabaseTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> AutoPauseDelayInMinutes { get; set; } = default!;

    /// <summary>
    /// The collation attribute.
    /// </summary>
    [TerraformPropertyName("collation")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Collation { get; set; } = default!;

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    [TerraformPropertyName("create_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CreateMode { get; set; }

    /// <summary>
    /// The creation_source_database_id attribute.
    /// </summary>
    [TerraformPropertyName("creation_source_database_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CreationSourceDatabaseId { get; set; } = default!;

    /// <summary>
    /// The elastic_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("elastic_pool_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ElasticPoolId { get; set; }

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    [TerraformPropertyName("enclave_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EnclaveType { get; set; } = default!;

    /// <summary>
    /// The geo_backup_enabled attribute.
    /// </summary>
    [TerraformPropertyName("geo_backup_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? GeoBackupEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ledger_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ledger_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> LedgerEnabled { get; set; } = default!;

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformPropertyName("license_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LicenseType { get; set; } = default!;

    /// <summary>
    /// The maintenance_configuration_name attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_configuration_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MaintenanceConfigurationName { get; set; } = default!;

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("max_size_gb")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxSizeGb { get; set; } = default!;

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [TerraformPropertyName("min_capacity")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MinCapacity { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The read_replica_count attribute.
    /// </summary>
    [TerraformPropertyName("read_replica_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ReadReplicaCount { get; set; } = default!;

    /// <summary>
    /// The read_scale attribute.
    /// </summary>
    [TerraformPropertyName("read_scale")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ReadScale { get; set; } = default!;

    /// <summary>
    /// The recover_database_id attribute.
    /// </summary>
    [TerraformPropertyName("recover_database_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RecoverDatabaseId { get; set; }

    /// <summary>
    /// The recovery_point_id attribute.
    /// </summary>
    [TerraformPropertyName("recovery_point_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RecoveryPointId { get; set; }

    /// <summary>
    /// The restore_dropped_database_id attribute.
    /// </summary>
    [TerraformPropertyName("restore_dropped_database_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RestoreDroppedDatabaseId { get; set; }

    /// <summary>
    /// The restore_long_term_retention_backup_id attribute.
    /// </summary>
    [TerraformPropertyName("restore_long_term_retention_backup_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RestoreLongTermRetentionBackupId { get; set; }

    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    [TerraformPropertyName("restore_point_in_time")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RestorePointInTime { get; set; } = default!;

    /// <summary>
    /// The sample_name attribute.
    /// </summary>
    [TerraformPropertyName("sample_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SampleName { get; set; } = default!;

    /// <summary>
    /// The secondary_type attribute.
    /// </summary>
    [TerraformPropertyName("secondary_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SecondaryType { get; set; } = default!;

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformPropertyName("server_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServerId { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SkuName { get; set; } = default!;

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageAccountType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The transparent_data_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("transparent_data_encryption_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TransparentDataEncryptionEnabled { get; set; }

    /// <summary>
    /// The transparent_data_encryption_key_automatic_rotation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("transparent_data_encryption_key_automatic_rotation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TransparentDataEncryptionKeyAutomaticRotationEnabled { get; set; }

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    [TerraformPropertyName("transparent_data_encryption_key_vault_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TransparentDataEncryptionKeyVaultKeyId { get; set; }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformPropertyName("zone_redundant")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ZoneRedundant { get; set; } = default!;

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermMssqlDatabaseIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for import.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Import block(s) allowed")]
    [TerraformPropertyName("import")]
    public TerraformList<TerraformBlock<AzurermMssqlDatabaseImportBlock>>? Import { get; set; }

    /// <summary>
    /// Block for long_term_retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LongTermRetentionPolicy block(s) allowed")]
    [TerraformPropertyName("long_term_retention_policy")]
    public TerraformList<TerraformBlock<AzurermMssqlDatabaseLongTermRetentionPolicyBlock>>? LongTermRetentionPolicy { get; set; }

    /// <summary>
    /// Block for short_term_retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShortTermRetentionPolicy block(s) allowed")]
    [TerraformPropertyName("short_term_retention_policy")]
    public TerraformList<TerraformBlock<AzurermMssqlDatabaseShortTermRetentionPolicyBlock>>? ShortTermRetentionPolicy { get; set; }

    /// <summary>
    /// Block for threat_detection_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreatDetectionPolicy block(s) allowed")]
    [TerraformPropertyName("threat_detection_policy")]
    public TerraformList<TerraformBlock<AzurermMssqlDatabaseThreatDetectionPolicyBlock>>? ThreatDetectionPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlDatabaseTimeoutsBlock>? Timeouts { get; set; }

}
