using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlDatabaseIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    [TerraformProperty("identity_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> IdentityIds { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for import in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlDatabaseImportBlock : TerraformBlockBase
{
    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdministratorLogin is required")]
    [TerraformProperty("administrator_login")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AdministratorLogin { get; set; }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdministratorLoginPassword is required")]
    [TerraformProperty("administrator_login_password")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AdministratorLoginPassword { get; set; }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    [TerraformProperty("authentication_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AuthenticationType { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformProperty("storage_account_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageAccountId { get; set; }

    /// <summary>
    /// The storage_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageKey is required")]
    [TerraformProperty("storage_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageKey { get; set; }

    /// <summary>
    /// The storage_key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageKeyType is required")]
    [TerraformProperty("storage_key_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageKeyType { get; set; }

    /// <summary>
    /// The storage_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    [TerraformProperty("storage_uri")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageUri { get; set; }

}

/// <summary>
/// Block type for long_term_retention_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlDatabaseLongTermRetentionPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The immutable_backups_enabled attribute.
    /// </summary>
    [TerraformProperty("immutable_backups_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ImmutableBackupsEnabled { get; set; }

    /// <summary>
    /// The monthly_retention attribute.
    /// </summary>
    [TerraformProperty("monthly_retention")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MonthlyRetention { get; set; }

    /// <summary>
    /// The week_of_year attribute.
    /// </summary>
    [TerraformProperty("week_of_year")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> WeekOfYear { get; set; }

    /// <summary>
    /// The weekly_retention attribute.
    /// </summary>
    [TerraformProperty("weekly_retention")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> WeeklyRetention { get; set; }

    /// <summary>
    /// The yearly_retention attribute.
    /// </summary>
    [TerraformProperty("yearly_retention")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> YearlyRetention { get; set; }

}

/// <summary>
/// Block type for short_term_retention_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlDatabaseShortTermRetentionPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The backup_interval_in_hours attribute.
    /// </summary>
    [TerraformProperty("backup_interval_in_hours")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> BackupIntervalInHours { get; set; }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionDays is required")]
    [TerraformProperty("retention_days")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> RetentionDays { get; set; }

}

/// <summary>
/// Block type for threat_detection_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlDatabaseThreatDetectionPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The disabled_alerts attribute.
    /// </summary>
    [TerraformProperty("disabled_alerts")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? DisabledAlerts { get; set; }

    /// <summary>
    /// The email_account_admins attribute.
    /// </summary>
    [TerraformProperty("email_account_admins")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EmailAccountAdmins { get; set; }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    [TerraformProperty("email_addresses")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? EmailAddresses { get; set; }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    [TerraformProperty("retention_days")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RetentionDays { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? State { get; set; }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [TerraformProperty("storage_account_access_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageAccountAccessKey { get; set; }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    [TerraformProperty("storage_endpoint")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageEndpoint { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlDatabaseTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_mssql_database resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMssqlDatabase : TerraformResource
{
    public AzurermMssqlDatabase(string name) : base("azurerm_mssql_database", name)
    {
    }

    /// <summary>
    /// The auto_pause_delay_in_minutes attribute.
    /// </summary>
    [TerraformProperty("auto_pause_delay_in_minutes")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> AutoPauseDelayInMinutes { get; set; }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    [TerraformProperty("collation")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Collation { get; set; }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    [TerraformProperty("create_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CreateMode { get; set; }

    /// <summary>
    /// The creation_source_database_id attribute.
    /// </summary>
    [TerraformProperty("creation_source_database_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CreationSourceDatabaseId { get; set; }

    /// <summary>
    /// The elastic_pool_id attribute.
    /// </summary>
    [TerraformProperty("elastic_pool_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ElasticPoolId { get; set; }

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    [TerraformProperty("enclave_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EnclaveType { get; set; }

    /// <summary>
    /// The geo_backup_enabled attribute.
    /// </summary>
    [TerraformProperty("geo_backup_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? GeoBackupEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ledger_enabled attribute.
    /// </summary>
    [TerraformProperty("ledger_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> LedgerEnabled { get; set; }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformProperty("license_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> LicenseType { get; set; }

    /// <summary>
    /// The maintenance_configuration_name attribute.
    /// </summary>
    [TerraformProperty("maintenance_configuration_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MaintenanceConfigurationName { get; set; }

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    [TerraformProperty("max_size_gb")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MaxSizeGb { get; set; }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [TerraformProperty("min_capacity")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MinCapacity { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The read_replica_count attribute.
    /// </summary>
    [TerraformProperty("read_replica_count")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> ReadReplicaCount { get; set; }

    /// <summary>
    /// The read_scale attribute.
    /// </summary>
    [TerraformProperty("read_scale")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> ReadScale { get; set; }

    /// <summary>
    /// The recover_database_id attribute.
    /// </summary>
    [TerraformProperty("recover_database_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RecoverDatabaseId { get; set; }

    /// <summary>
    /// The recovery_point_id attribute.
    /// </summary>
    [TerraformProperty("recovery_point_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RecoveryPointId { get; set; }

    /// <summary>
    /// The restore_dropped_database_id attribute.
    /// </summary>
    [TerraformProperty("restore_dropped_database_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RestoreDroppedDatabaseId { get; set; }

    /// <summary>
    /// The restore_long_term_retention_backup_id attribute.
    /// </summary>
    [TerraformProperty("restore_long_term_retention_backup_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RestoreLongTermRetentionBackupId { get; set; }

    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    [TerraformProperty("restore_point_in_time")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> RestorePointInTime { get; set; }

    /// <summary>
    /// The sample_name attribute.
    /// </summary>
    [TerraformProperty("sample_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SampleName { get; set; }

    /// <summary>
    /// The secondary_type attribute.
    /// </summary>
    [TerraformProperty("secondary_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SecondaryType { get; set; }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformProperty("server_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServerId { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformProperty("storage_account_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageAccountType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The transparent_data_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("transparent_data_encryption_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? TransparentDataEncryptionEnabled { get; set; }

    /// <summary>
    /// The transparent_data_encryption_key_automatic_rotation_enabled attribute.
    /// </summary>
    [TerraformProperty("transparent_data_encryption_key_automatic_rotation_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? TransparentDataEncryptionKeyAutomaticRotationEnabled { get; set; }

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    [TerraformProperty("transparent_data_encryption_key_vault_key_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TransparentDataEncryptionKeyVaultKeyId { get; set; }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformProperty("zone_redundant")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> ZoneRedundant { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<TerraformBlock<AzurermMssqlDatabaseIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for import.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Import block(s) allowed")]
    [TerraformProperty("import")]
    public TerraformList<TerraformBlock<AzurermMssqlDatabaseImportBlock>>? Import { get; set; }

    /// <summary>
    /// Block for long_term_retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LongTermRetentionPolicy block(s) allowed")]
    [TerraformProperty("long_term_retention_policy")]
    public TerraformList<TerraformBlock<AzurermMssqlDatabaseLongTermRetentionPolicyBlock>>? LongTermRetentionPolicy { get; set; }

    /// <summary>
    /// Block for short_term_retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShortTermRetentionPolicy block(s) allowed")]
    [TerraformProperty("short_term_retention_policy")]
    public TerraformList<TerraformBlock<AzurermMssqlDatabaseShortTermRetentionPolicyBlock>>? ShortTermRetentionPolicy { get; set; }

    /// <summary>
    /// Block for threat_detection_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreatDetectionPolicy block(s) allowed")]
    [TerraformProperty("threat_detection_policy")]
    public TerraformList<TerraformBlock<AzurermMssqlDatabaseThreatDetectionPolicyBlock>>? ThreatDetectionPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermMssqlDatabaseTimeoutsBlock>? Timeouts { get; set; }

}
