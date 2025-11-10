using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlDatabaseDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("collation");
        SetOutput("elastic_pool_id");
        SetOutput("enclave_type");
        SetOutput("identity");
        SetOutput("license_type");
        SetOutput("max_size_gb");
        SetOutput("read_replica_count");
        SetOutput("read_scale");
        SetOutput("sku_name");
        SetOutput("storage_account_type");
        SetOutput("tags");
        SetOutput("transparent_data_encryption_enabled");
        SetOutput("transparent_data_encryption_key_automatic_rotation_enabled");
        SetOutput("transparent_data_encryption_key_vault_key_id");
        SetOutput("zone_redundant");
        SetOutput("id");
        SetOutput("name");
        SetOutput("server_id");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlDatabaseDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
