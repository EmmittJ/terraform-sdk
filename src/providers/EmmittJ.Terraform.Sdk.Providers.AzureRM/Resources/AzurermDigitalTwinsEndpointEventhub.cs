using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDigitalTwinsEndpointEventhubTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_digital_twins_endpoint_eventhub resource.
/// </summary>
public partial class AzurermDigitalTwinsEndpointEventhub : TerraformResource
{
    public AzurermDigitalTwinsEndpointEventhub(string name) : base("azurerm_digital_twins_endpoint_eventhub", name)
    {
    }

    /// <summary>
    /// The dead_letter_storage_secret attribute.
    /// </summary>
    [TerraformProperty("dead_letter_storage_secret")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeadLetterStorageSecret { get; set; }

    /// <summary>
    /// The digital_twins_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DigitalTwinsId is required")]
    [TerraformProperty("digital_twins_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DigitalTwinsId { get; set; }

    /// <summary>
    /// The eventhub_primary_connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubPrimaryConnectionString is required")]
    [TerraformProperty("eventhub_primary_connection_string")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EventhubPrimaryConnectionString { get; set; }

    /// <summary>
    /// The eventhub_secondary_connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubSecondaryConnectionString is required")]
    [TerraformProperty("eventhub_secondary_connection_string")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EventhubSecondaryConnectionString { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDigitalTwinsEndpointEventhubTimeoutsBlock Timeouts { get; set; } = new();

}
