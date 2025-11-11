using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDigitalTwinsEndpointEventgridTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_digital_twins_endpoint_eventgrid resource.
/// </summary>
public partial class AzurermDigitalTwinsEndpointEventgrid : TerraformResource
{
    public AzurermDigitalTwinsEndpointEventgrid(string name) : base("azurerm_digital_twins_endpoint_eventgrid", name)
    {
    }

    /// <summary>
    /// The dead_letter_storage_secret attribute.
    /// </summary>
    [TerraformProperty("dead_letter_storage_secret")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DeadLetterStorageSecret { get; set; }

    /// <summary>
    /// The digital_twins_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DigitalTwinsId is required")]
    [TerraformProperty("digital_twins_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DigitalTwinsId { get; set; }

    /// <summary>
    /// The eventgrid_topic_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventgridTopicEndpoint is required")]
    [TerraformProperty("eventgrid_topic_endpoint")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EventgridTopicEndpoint { get; set; }

    /// <summary>
    /// The eventgrid_topic_primary_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventgridTopicPrimaryAccessKey is required")]
    [TerraformProperty("eventgrid_topic_primary_access_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EventgridTopicPrimaryAccessKey { get; set; }

    /// <summary>
    /// The eventgrid_topic_secondary_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventgridTopicSecondaryAccessKey is required")]
    [TerraformProperty("eventgrid_topic_secondary_access_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EventgridTopicSecondaryAccessKey { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermDigitalTwinsEndpointEventgridTimeoutsBlock>? Timeouts { get; set; }

}
