using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlDatabaseDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformPropertyName("server_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServerId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlDatabaseDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The collation attribute.
    /// </summary>
    [TerraformPropertyName("collation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Collation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "collation");

    /// <summary>
    /// The elastic_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("elastic_pool_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ElasticPoolId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "elastic_pool_id");

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    [TerraformPropertyName("enclave_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EnclaveType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "enclave_type");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformPropertyName("license_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LicenseType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "license_type");

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("max_size_gb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxSizeGb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_size_gb");

    /// <summary>
    /// The read_replica_count attribute.
    /// </summary>
    [TerraformPropertyName("read_replica_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ReadReplicaCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "read_replica_count");

    /// <summary>
    /// The read_scale attribute.
    /// </summary>
    [TerraformPropertyName("read_scale")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ReadScale => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "read_scale");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SkuName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku_name");

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageAccountType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_account_type");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The transparent_data_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("transparent_data_encryption_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> TransparentDataEncryptionEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "transparent_data_encryption_enabled");

    /// <summary>
    /// The transparent_data_encryption_key_automatic_rotation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("transparent_data_encryption_key_automatic_rotation_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> TransparentDataEncryptionKeyAutomaticRotationEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "transparent_data_encryption_key_automatic_rotation_enabled");

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    [TerraformPropertyName("transparent_data_encryption_key_vault_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TransparentDataEncryptionKeyVaultKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transparent_data_encryption_key_vault_key_id");

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformPropertyName("zone_redundant")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ZoneRedundant => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "zone_redundant");

}
