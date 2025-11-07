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
    public TerraformLiteralProperty<double>? AutoPauseDelayInMinutes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("auto_pause_delay_in_minutes");
        set => this.WithProperty("auto_pause_delay_in_minutes", value);
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Collation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("collation");
        set => this.WithProperty("collation", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CreateMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("create_mode");
        set => this.WithProperty("create_mode", value);
    }

    /// <summary>
    /// The creation_source_database_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CreationSourceDatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("creation_source_database_id");
        set => this.WithProperty("creation_source_database_id", value);
    }

    /// <summary>
    /// The elastic_pool_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ElasticPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("elastic_pool_id");
        set => this.WithProperty("elastic_pool_id", value);
    }

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EnclaveType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("enclave_type");
        set => this.WithProperty("enclave_type", value);
    }

    /// <summary>
    /// The geo_backup_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? GeoBackupEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("geo_backup_enabled");
        set => this.WithProperty("geo_backup_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ledger_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? LedgerEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ledger_enabled");
        set => this.WithProperty("ledger_enabled", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LicenseType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_type");
        set => this.WithProperty("license_type", value);
    }

    /// <summary>
    /// The maintenance_configuration_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MaintenanceConfigurationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("maintenance_configuration_name");
        set => this.WithProperty("maintenance_configuration_name", value);
    }

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxSizeGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_size_gb");
        set => this.WithProperty("max_size_gb", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MinCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_capacity");
        set => this.WithProperty("min_capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The read_replica_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ReadReplicaCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("read_replica_count");
        set => this.WithProperty("read_replica_count", value);
    }

    /// <summary>
    /// The read_scale attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ReadScale
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("read_scale");
        set => this.WithProperty("read_scale", value);
    }

    /// <summary>
    /// The recover_database_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RecoverDatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recover_database_id");
        set => this.WithProperty("recover_database_id", value);
    }

    /// <summary>
    /// The recovery_point_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RecoveryPointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_point_id");
        set => this.WithProperty("recovery_point_id", value);
    }

    /// <summary>
    /// The restore_dropped_database_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RestoreDroppedDatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("restore_dropped_database_id");
        set => this.WithProperty("restore_dropped_database_id", value);
    }

    /// <summary>
    /// The restore_long_term_retention_backup_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RestoreLongTermRetentionBackupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("restore_long_term_retention_backup_id");
        set => this.WithProperty("restore_long_term_retention_backup_id", value);
    }

    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RestorePointInTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("restore_point_in_time");
        set => this.WithProperty("restore_point_in_time", value);
    }

    /// <summary>
    /// The sample_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SampleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sample_name");
        set => this.WithProperty("sample_name", value);
    }

    /// <summary>
    /// The secondary_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecondaryType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secondary_type");
        set => this.WithProperty("secondary_type", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_id");
        set => this.WithProperty("server_id", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageAccountType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_type");
        set => this.WithProperty("storage_account_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The transparent_data_encryption_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? TransparentDataEncryptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("transparent_data_encryption_enabled");
        set => this.WithProperty("transparent_data_encryption_enabled", value);
    }

    /// <summary>
    /// The transparent_data_encryption_key_automatic_rotation_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? TransparentDataEncryptionKeyAutomaticRotationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("transparent_data_encryption_key_automatic_rotation_enabled");
        set => this.WithProperty("transparent_data_encryption_key_automatic_rotation_enabled", value);
    }

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TransparentDataEncryptionKeyVaultKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transparent_data_encryption_key_vault_key_id");
        set => this.WithProperty("transparent_data_encryption_key_vault_key_id", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ZoneRedundant
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("zone_redundant");
        set => this.WithProperty("zone_redundant", value);
    }

}
