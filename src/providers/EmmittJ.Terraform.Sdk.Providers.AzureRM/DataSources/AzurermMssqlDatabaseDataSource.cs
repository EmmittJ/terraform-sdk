using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "read");
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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformValue<string> ServerId
    {
        get => new TerraformReference<string>(this, "server_id");
        set => SetArgument("server_id", value);
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformValue<string> Collation
    {
        get => new TerraformReference<string>(this, "collation");
    }

    /// <summary>
    /// The elastic_pool_id attribute.
    /// </summary>
    public TerraformValue<string> ElasticPoolId
    {
        get => new TerraformReference<string>(this, "elastic_pool_id");
    }

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    public TerraformValue<string> EnclaveType
    {
        get => new TerraformReference<string>(this, "enclave_type");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string> LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
    }

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    public TerraformValue<double> MaxSizeGb
    {
        get => new TerraformReference<double>(this, "max_size_gb");
    }

    /// <summary>
    /// The read_replica_count attribute.
    /// </summary>
    public TerraformValue<double> ReadReplicaCount
    {
        get => new TerraformReference<double>(this, "read_replica_count");
    }

    /// <summary>
    /// The read_scale attribute.
    /// </summary>
    public TerraformValue<bool> ReadScale
    {
        get => new TerraformReference<bool>(this, "read_scale");
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountType
    {
        get => new TerraformReference<string>(this, "storage_account_type");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The transparent_data_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TransparentDataEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "transparent_data_encryption_enabled");
    }

    /// <summary>
    /// The transparent_data_encryption_key_automatic_rotation_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TransparentDataEncryptionKeyAutomaticRotationEnabled
    {
        get => new TerraformReference<bool>(this, "transparent_data_encryption_key_automatic_rotation_enabled");
    }

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string> TransparentDataEncryptionKeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "transparent_data_encryption_key_vault_key_id");
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformValue<bool> ZoneRedundant
    {
        get => new TerraformReference<bool>(this, "zone_redundant");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlDatabaseDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlDatabaseDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
