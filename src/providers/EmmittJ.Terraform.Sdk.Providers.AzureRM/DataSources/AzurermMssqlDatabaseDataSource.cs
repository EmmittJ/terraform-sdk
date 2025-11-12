using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlDatabaseDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mssql_database.
/// </summary>
public partial class AzurermMssqlDatabaseDataSource : TerraformDataSource
{
    public AzurermMssqlDatabaseDataSource(string name) : base("azurerm_mssql_database", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformProperty("server_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServerId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMssqlDatabaseDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The collation attribute.
    /// </summary>
    [TerraformProperty("collation")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Collation { get; }

    /// <summary>
    /// The elastic_pool_id attribute.
    /// </summary>
    [TerraformProperty("elastic_pool_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ElasticPoolId { get; }

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    [TerraformProperty("enclave_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EnclaveType { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identity { get; }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformProperty("license_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LicenseType { get; }

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    [TerraformProperty("max_size_gb")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxSizeGb { get; }

    /// <summary>
    /// The read_replica_count attribute.
    /// </summary>
    [TerraformProperty("read_replica_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ReadReplicaCount { get; }

    /// <summary>
    /// The read_scale attribute.
    /// </summary>
    [TerraformProperty("read_scale")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ReadScale { get; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SkuName { get; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformProperty("storage_account_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StorageAccountType { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The transparent_data_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("transparent_data_encryption_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> TransparentDataEncryptionEnabled { get; }

    /// <summary>
    /// The transparent_data_encryption_key_automatic_rotation_enabled attribute.
    /// </summary>
    [TerraformProperty("transparent_data_encryption_key_automatic_rotation_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> TransparentDataEncryptionKeyAutomaticRotationEnabled { get; }

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    [TerraformProperty("transparent_data_encryption_key_vault_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TransparentDataEncryptionKeyVaultKeyId { get; }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformProperty("zone_redundant")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ZoneRedundant { get; }

}
