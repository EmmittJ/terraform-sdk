using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_mssql_database.
/// </summary>
public class AzurermMssqlDatabaseDataSource : TerraformDataSource
{
    public AzurermMssqlDatabaseDataSource(string name) : base("azurerm_mssql_database", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformArgument("server_id")]
    public required TerraformValue<string> ServerId
    {
        get => new TerraformReference<string>(this, "server_id");
        set => SetArgument("server_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMssqlDatabaseDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The collation attribute.
    /// </summary>
    [TerraformArgument("collation")]
    public TerraformValue<string> Collation
    {
        get => new TerraformReference<string>(this, "collation");
    }

    /// <summary>
    /// The elastic_pool_id attribute.
    /// </summary>
    [TerraformArgument("elastic_pool_id")]
    public TerraformValue<string> ElasticPoolId
    {
        get => new TerraformReference<string>(this, "elastic_pool_id");
    }

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    [TerraformArgument("enclave_type")]
    public TerraformValue<string> EnclaveType
    {
        get => new TerraformReference<string>(this, "enclave_type");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformList<object> Identity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformArgument("license_type")]
    public TerraformValue<string> LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
    }

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    [TerraformArgument("max_size_gb")]
    public TerraformValue<double> MaxSizeGb
    {
        get => new TerraformReference<double>(this, "max_size_gb");
    }

    /// <summary>
    /// The read_replica_count attribute.
    /// </summary>
    [TerraformArgument("read_replica_count")]
    public TerraformValue<double> ReadReplicaCount
    {
        get => new TerraformReference<double>(this, "read_replica_count");
    }

    /// <summary>
    /// The read_scale attribute.
    /// </summary>
    [TerraformArgument("read_scale")]
    public TerraformValue<bool> ReadScale
    {
        get => new TerraformReference<bool>(this, "read_scale");
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformArgument("sku_name")]
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformArgument("storage_account_type")]
    public TerraformValue<string> StorageAccountType
    {
        get => new TerraformReference<string>(this, "storage_account_type");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The transparent_data_encryption_enabled attribute.
    /// </summary>
    [TerraformArgument("transparent_data_encryption_enabled")]
    public TerraformValue<bool> TransparentDataEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "transparent_data_encryption_enabled");
    }

    /// <summary>
    /// The transparent_data_encryption_key_automatic_rotation_enabled attribute.
    /// </summary>
    [TerraformArgument("transparent_data_encryption_key_automatic_rotation_enabled")]
    public TerraformValue<bool> TransparentDataEncryptionKeyAutomaticRotationEnabled
    {
        get => new TerraformReference<bool>(this, "transparent_data_encryption_key_automatic_rotation_enabled");
    }

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    [TerraformArgument("transparent_data_encryption_key_vault_key_id")]
    public TerraformValue<string> TransparentDataEncryptionKeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "transparent_data_encryption_key_vault_key_id");
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformArgument("zone_redundant")]
    public TerraformValue<bool> ZoneRedundant
    {
        get => new TerraformReference<bool>(this, "zone_redundant");
    }

}
