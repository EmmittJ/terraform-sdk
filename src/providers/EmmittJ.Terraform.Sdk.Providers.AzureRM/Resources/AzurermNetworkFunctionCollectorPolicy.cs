using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ipfx_emission in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNetworkFunctionCollectorPolicyIpfxEmissionBlock() : TerraformBlock("ipfx_emission")
{
    /// <summary>
    /// The destination_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationTypes is required")]
    [TerraformProperty("destination_types")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? DestinationTypes { get; set; }

}

/// <summary>
/// Block type for ipfx_ingestion in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNetworkFunctionCollectorPolicyIpfxIngestionBlock() : TerraformBlock("ipfx_ingestion")
{
    /// <summary>
    /// The source_resource_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceResourceIds is required")]
    [TerraformProperty("source_resource_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> SourceResourceIds { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetworkFunctionCollectorPolicyTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_network_function_collector_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermNetworkFunctionCollectorPolicy : TerraformResource
{
    public AzurermNetworkFunctionCollectorPolicy(string name) : base("azurerm_network_function_collector_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The traffic_collector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficCollectorId is required")]
    [TerraformProperty("traffic_collector_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TrafficCollectorId { get; set; }

    /// <summary>
    /// Block for ipfx_emission.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpfxEmission is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpfxEmission block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpfxEmission block(s) allowed")]
    [TerraformProperty("ipfx_emission")]
    public required TerraformList<AzurermNetworkFunctionCollectorPolicyIpfxEmissionBlock> IpfxEmission { get; set; } = new();

    /// <summary>
    /// Block for ipfx_ingestion.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpfxIngestion is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpfxIngestion block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpfxIngestion block(s) allowed")]
    [TerraformProperty("ipfx_ingestion")]
    public required TerraformList<AzurermNetworkFunctionCollectorPolicyIpfxIngestionBlock> IpfxIngestion { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermNetworkFunctionCollectorPolicyTimeoutsBlock Timeouts { get; set; } = new();

}
