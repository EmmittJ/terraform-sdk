using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMssqlDatabaseDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermMssqlDatabaseDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_mssql_database Terraform data source.
/// Retrieves information about a azurerm_mssql_database.
/// </summary>
public partial class AzurermMssqlDatabaseDataSource(string name) : TerraformDataSource("azurerm_mssql_database", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformValue<string> ServerId
    {
        get => GetArgument<TerraformValue<string>>("server_id");
        set => SetArgument("server_id", value);
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformValue<string> Collation
        => AsReference("collation");

    /// <summary>
    /// The elastic_pool_id attribute.
    /// </summary>
    public TerraformValue<string> ElasticPoolId
        => AsReference("elastic_pool_id");

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    public TerraformValue<string> EnclaveType
        => AsReference("enclave_type");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string> LicenseType
        => AsReference("license_type");

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    public TerraformValue<double> MaxSizeGb
        => AsReference("max_size_gb");

    /// <summary>
    /// The read_replica_count attribute.
    /// </summary>
    public TerraformValue<double> ReadReplicaCount
        => AsReference("read_replica_count");

    /// <summary>
    /// The read_scale attribute.
    /// </summary>
    public TerraformValue<bool> ReadScale
        => AsReference("read_scale");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
        => AsReference("sku_name");

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountType
        => AsReference("storage_account_type");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The transparent_data_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TransparentDataEncryptionEnabled
        => AsReference("transparent_data_encryption_enabled");

    /// <summary>
    /// The transparent_data_encryption_key_automatic_rotation_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TransparentDataEncryptionKeyAutomaticRotationEnabled
        => AsReference("transparent_data_encryption_key_automatic_rotation_enabled");

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string> TransparentDataEncryptionKeyVaultKeyId
        => AsReference("transparent_data_encryption_key_vault_key_id");

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformValue<bool> ZoneRedundant
        => AsReference("zone_redundant");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlDatabaseDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlDatabaseDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
