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
    public TerraformProperty<string>? Name
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
    public TerraformProperty<string>? ServerId
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
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

}
