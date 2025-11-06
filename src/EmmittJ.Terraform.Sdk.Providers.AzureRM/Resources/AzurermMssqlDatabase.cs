using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public double? AutoPauseDelayInMinutes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("auto_pause_delay_in_minutes")?.Value;
        set => this.WithProperty("auto_pause_delay_in_minutes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public string? Collation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("collation")?.Value;
        set => this.WithProperty("collation", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public string? CreateMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("create_mode")?.Value;
        set => this.WithProperty("create_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The creation_source_database_id attribute.
    /// </summary>
    public string? CreationSourceDatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("creation_source_database_id")?.Value;
        set => this.WithProperty("creation_source_database_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The elastic_pool_id attribute.
    /// </summary>
    public string? ElasticPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("elastic_pool_id")?.Value;
        set => this.WithProperty("elastic_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    public string? EnclaveType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("enclave_type")?.Value;
        set => this.WithProperty("enclave_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The geo_backup_enabled attribute.
    /// </summary>
    public bool? GeoBackupEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("geo_backup_enabled")?.Value;
        set => this.WithProperty("geo_backup_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ledger_enabled attribute.
    /// </summary>
    public bool? LedgerEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ledger_enabled")?.Value;
        set => this.WithProperty("ledger_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public string? LicenseType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_type")?.Value;
        set => this.WithProperty("license_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The maintenance_configuration_name attribute.
    /// </summary>
    public string? MaintenanceConfigurationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("maintenance_configuration_name")?.Value;
        set => this.WithProperty("maintenance_configuration_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    public double? MaxSizeGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_size_gb")?.Value;
        set => this.WithProperty("max_size_gb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    public double? MinCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_capacity")?.Value;
        set => this.WithProperty("min_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The read_replica_count attribute.
    /// </summary>
    public double? ReadReplicaCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("read_replica_count")?.Value;
        set => this.WithProperty("read_replica_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The read_scale attribute.
    /// </summary>
    public bool? ReadScale
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("read_scale")?.Value;
        set => this.WithProperty("read_scale", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The recover_database_id attribute.
    /// </summary>
    public string? RecoverDatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recover_database_id")?.Value;
        set => this.WithProperty("recover_database_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The recovery_point_id attribute.
    /// </summary>
    public string? RecoveryPointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_point_id")?.Value;
        set => this.WithProperty("recovery_point_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The restore_dropped_database_id attribute.
    /// </summary>
    public string? RestoreDroppedDatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("restore_dropped_database_id")?.Value;
        set => this.WithProperty("restore_dropped_database_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The restore_long_term_retention_backup_id attribute.
    /// </summary>
    public string? RestoreLongTermRetentionBackupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("restore_long_term_retention_backup_id")?.Value;
        set => this.WithProperty("restore_long_term_retention_backup_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    public string? RestorePointInTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("restore_point_in_time")?.Value;
        set => this.WithProperty("restore_point_in_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sample_name attribute.
    /// </summary>
    public string? SampleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sample_name")?.Value;
        set => this.WithProperty("sample_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The secondary_type attribute.
    /// </summary>
    public string? SecondaryType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secondary_type")?.Value;
        set => this.WithProperty("secondary_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    public string? ServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_id")?.Value;
        set => this.WithProperty("server_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public string? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name")?.Value;
        set => this.WithProperty("sku_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public string? StorageAccountType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_type")?.Value;
        set => this.WithProperty("storage_account_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The transparent_data_encryption_enabled attribute.
    /// </summary>
    public bool? TransparentDataEncryptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("transparent_data_encryption_enabled")?.Value;
        set => this.WithProperty("transparent_data_encryption_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The transparent_data_encryption_key_automatic_rotation_enabled attribute.
    /// </summary>
    public bool? TransparentDataEncryptionKeyAutomaticRotationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("transparent_data_encryption_key_automatic_rotation_enabled")?.Value;
        set => this.WithProperty("transparent_data_encryption_key_automatic_rotation_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    public string? TransparentDataEncryptionKeyVaultKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transparent_data_encryption_key_vault_key_id")?.Value;
        set => this.WithProperty("transparent_data_encryption_key_vault_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public bool? ZoneRedundant
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("zone_redundant")?.Value;
        set => this.WithProperty("zone_redundant", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
