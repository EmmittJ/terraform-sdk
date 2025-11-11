using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlElasticpoolDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mssql_elasticpool.
/// </summary>
public partial class AzurermMssqlElasticpoolDataSource : TerraformDataSource
{
    public AzurermMssqlElasticpoolDataSource(string name) : base("azurerm_mssql_elasticpool", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    [TerraformProperty("server_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServerName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermMssqlElasticpoolDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    [TerraformProperty("enclave_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EnclaveType { get; }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformProperty("license_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LicenseType { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The max_size_bytes attribute.
    /// </summary>
    [TerraformProperty("max_size_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MaxSizeBytes { get; }

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    [TerraformProperty("max_size_gb")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MaxSizeGb { get; }

    /// <summary>
    /// The per_db_max_capacity attribute.
    /// </summary>
    [TerraformProperty("per_db_max_capacity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> PerDbMaxCapacity { get; }

    /// <summary>
    /// The per_db_min_capacity attribute.
    /// </summary>
    [TerraformProperty("per_db_min_capacity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> PerDbMinCapacity { get; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Sku { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformProperty("zone_redundant")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ZoneRedundant { get; }

}
