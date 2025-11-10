using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlElasticpoolDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mssql_elasticpool.
/// </summary>
public class AzurermMssqlElasticpoolDataSource : TerraformDataSource
{
    public AzurermMssqlElasticpoolDataSource(string name) : base("azurerm_mssql_elasticpool", name)
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    [TerraformPropertyName("server_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServerName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlElasticpoolDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    [TerraformPropertyName("enclave_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EnclaveType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "enclave_type");

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformPropertyName("license_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LicenseType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "license_type");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The max_size_bytes attribute.
    /// </summary>
    [TerraformPropertyName("max_size_bytes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxSizeBytes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_size_bytes");

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("max_size_gb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxSizeGb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_size_gb");

    /// <summary>
    /// The per_db_max_capacity attribute.
    /// </summary>
    [TerraformPropertyName("per_db_max_capacity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PerDbMaxCapacity => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "per_db_max_capacity");

    /// <summary>
    /// The per_db_min_capacity attribute.
    /// </summary>
    [TerraformPropertyName("per_db_min_capacity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PerDbMinCapacity => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "per_db_min_capacity");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Sku => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformPropertyName("zone_redundant")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ZoneRedundant => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "zone_redundant");

}
