using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataFactoryIntegrationRuntimeAzureTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_data_factory_integration_runtime_azure resource.
/// </summary>
public partial class AzurermDataFactoryIntegrationRuntimeAzure : TerraformResource
{
    public AzurermDataFactoryIntegrationRuntimeAzure(string name) : base("azurerm_data_factory_integration_runtime_azure", name)
    {
    }

    /// <summary>
    /// The cleanup_enabled attribute.
    /// </summary>
    [TerraformProperty("cleanup_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CleanupEnabled { get; set; }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    [TerraformProperty("compute_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ComputeType { get; set; }

    /// <summary>
    /// The core_count attribute.
    /// </summary>
    [TerraformProperty("core_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? CoreCount { get; set; }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformProperty("data_factory_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataFactoryId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

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
    /// The time_to_live_min attribute.
    /// </summary>
    [TerraformProperty("time_to_live_min")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TimeToLiveMin { get; set; }

    /// <summary>
    /// The virtual_network_enabled attribute.
    /// </summary>
    [TerraformProperty("virtual_network_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? VirtualNetworkEnabled { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDataFactoryIntegrationRuntimeAzureTimeoutsBlock Timeouts { get; set; } = new();

}
