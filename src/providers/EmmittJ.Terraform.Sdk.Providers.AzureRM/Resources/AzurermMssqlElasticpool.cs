using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for per_database_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlElasticpoolPerDatabaseSettingsBlock() : TerraformBlock("per_database_settings")
{
    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    [TerraformProperty("max_capacity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaxCapacity { get; set; }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    [TerraformProperty("min_capacity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MinCapacity { get; set; }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlElasticpoolSkuBlock() : TerraformBlock("sku")
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    [TerraformProperty("capacity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Capacity { get; set; }

    /// <summary>
    /// The family attribute.
    /// </summary>
    [TerraformProperty("family")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Family { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    [TerraformProperty("tier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Tier { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlElasticpoolTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_mssql_elasticpool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMssqlElasticpool : TerraformResource
{
    public AzurermMssqlElasticpool(string name) : base("azurerm_mssql_elasticpool", name)
    {
    }

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    [TerraformProperty("enclave_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EnclaveType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformProperty("license_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LicenseType { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The maintenance_configuration_name attribute.
    /// </summary>
    [TerraformProperty("maintenance_configuration_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaintenanceConfigurationName { get; set; }

    /// <summary>
    /// The max_size_bytes attribute.
    /// </summary>
    [TerraformProperty("max_size_bytes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxSizeBytes { get; set; }

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    [TerraformProperty("max_size_gb")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxSizeGb { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    [TerraformProperty("server_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServerName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformProperty("zone_redundant")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ZoneRedundant { get; set; }

    /// <summary>
    /// Block for per_database_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PerDatabaseSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PerDatabaseSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerDatabaseSettings block(s) allowed")]
    [TerraformProperty("per_database_settings")]
    public required TerraformList<AzurermMssqlElasticpoolPerDatabaseSettingsBlock> PerDatabaseSettings { get; set; } = new();

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformProperty("sku")]
    public required TerraformList<AzurermMssqlElasticpoolSkuBlock> Sku { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMssqlElasticpoolTimeoutsBlock Timeouts { get; set; } = new();

}
