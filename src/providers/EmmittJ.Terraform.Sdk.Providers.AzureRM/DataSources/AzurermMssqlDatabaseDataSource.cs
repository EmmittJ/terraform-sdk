using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlDatabaseDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformPropertyName("server_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServerId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlDatabaseDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    [TerraformPropertyName("collation")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Collation => new TerraformReference(this, "collation");

    /// <summary>
    /// The elastic_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("elastic_pool_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ElasticPoolId => new TerraformReference(this, "elastic_pool_id");

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    [TerraformPropertyName("enclave_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EnclaveType => new TerraformReference(this, "enclave_type");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformPropertyName("license_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LicenseType => new TerraformReference(this, "license_type");

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("max_size_gb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxSizeGb => new TerraformReference(this, "max_size_gb");

    /// <summary>
    /// The read_replica_count attribute.
    /// </summary>
    [TerraformPropertyName("read_replica_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ReadReplicaCount => new TerraformReference(this, "read_replica_count");

    /// <summary>
    /// The read_scale attribute.
    /// </summary>
    [TerraformPropertyName("read_scale")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ReadScale => new TerraformReference(this, "read_scale");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SkuName => new TerraformReference(this, "sku_name");

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageAccountType => new TerraformReference(this, "storage_account_type");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The transparent_data_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("transparent_data_encryption_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> TransparentDataEncryptionEnabled => new TerraformReference(this, "transparent_data_encryption_enabled");

    /// <summary>
    /// The transparent_data_encryption_key_automatic_rotation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("transparent_data_encryption_key_automatic_rotation_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> TransparentDataEncryptionKeyAutomaticRotationEnabled => new TerraformReference(this, "transparent_data_encryption_key_automatic_rotation_enabled");

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    [TerraformPropertyName("transparent_data_encryption_key_vault_key_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TransparentDataEncryptionKeyVaultKeyId => new TerraformReference(this, "transparent_data_encryption_key_vault_key_id");

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformPropertyName("zone_redundant")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ZoneRedundant => new TerraformReference(this, "zone_redundant");

}
