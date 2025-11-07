using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_mssql_database.
/// </summary>
public class AzurermMssqlDatabaseDataSource : TerraformDataSource
{
    public AzurermMssqlDatabaseDataSource(string name) : base("azurerm_mssql_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("collation");
        this.DeclareOutput("elastic_pool_id");
        this.DeclareOutput("enclave_type");
        this.DeclareOutput("identity");
        this.DeclareOutput("license_type");
        this.DeclareOutput("max_size_gb");
        this.DeclareOutput("read_replica_count");
        this.DeclareOutput("read_scale");
        this.DeclareOutput("sku_name");
        this.DeclareOutput("storage_account_type");
        this.DeclareOutput("tags");
        this.DeclareOutput("transparent_data_encryption_enabled");
        this.DeclareOutput("transparent_data_encryption_key_automatic_rotation_enabled");
        this.DeclareOutput("transparent_data_encryption_key_vault_key_id");
        this.DeclareOutput("zone_redundant");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The collation attribute.
    /// </summary>
    public TerraformExpression Collation => this["collation"];

    /// <summary>
    /// The elastic_pool_id attribute.
    /// </summary>
    public TerraformExpression ElasticPoolId => this["elastic_pool_id"];

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    public TerraformExpression EnclaveType => this["enclave_type"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformExpression LicenseType => this["license_type"];

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    public TerraformExpression MaxSizeGb => this["max_size_gb"];

    /// <summary>
    /// The read_replica_count attribute.
    /// </summary>
    public TerraformExpression ReadReplicaCount => this["read_replica_count"];

    /// <summary>
    /// The read_scale attribute.
    /// </summary>
    public TerraformExpression ReadScale => this["read_scale"];

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformExpression SkuName => this["sku_name"];

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformExpression StorageAccountType => this["storage_account_type"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The transparent_data_encryption_enabled attribute.
    /// </summary>
    public TerraformExpression TransparentDataEncryptionEnabled => this["transparent_data_encryption_enabled"];

    /// <summary>
    /// The transparent_data_encryption_key_automatic_rotation_enabled attribute.
    /// </summary>
    public TerraformExpression TransparentDataEncryptionKeyAutomaticRotationEnabled => this["transparent_data_encryption_key_automatic_rotation_enabled"];

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    public TerraformExpression TransparentDataEncryptionKeyVaultKeyId => this["transparent_data_encryption_key_vault_key_id"];

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformExpression ZoneRedundant => this["zone_redundant"];

}
