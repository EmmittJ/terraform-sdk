using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for event_handler in .
/// Nesting mode: list
/// </summary>
public partial class AzurermWebPubsubHubEventHandlerBlock() : TerraformBlock("event_handler")
{
    /// <summary>
    /// The system_events attribute.
    /// </summary>
    [TerraformProperty("system_events")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SystemEvents { get; set; }

    /// <summary>
    /// The url_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UrlTemplate is required")]
    [TerraformProperty("url_template")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UrlTemplate { get; set; }

    /// <summary>
    /// The user_event_pattern attribute.
    /// </summary>
    [TerraformProperty("user_event_pattern")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserEventPattern { get; set; }

}

/// <summary>
/// Block type for event_listener in .
/// Nesting mode: list
/// </summary>
public partial class AzurermWebPubsubHubEventListenerBlock() : TerraformBlock("event_listener")
{
    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubName is required")]
    [TerraformProperty("eventhub_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EventhubName { get; set; }

    /// <summary>
    /// The eventhub_namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubNamespaceName is required")]
    [TerraformProperty("eventhub_namespace_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EventhubNamespaceName { get; set; }

    /// <summary>
    /// The system_event_name_filter attribute.
    /// </summary>
    [TerraformProperty("system_event_name_filter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SystemEventNameFilter { get; set; }

    /// <summary>
    /// The user_event_name_filter attribute.
    /// </summary>
    [TerraformProperty("user_event_name_filter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? UserEventNameFilter { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermWebPubsubHubTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_web_pubsub_hub resource.
/// </summary>
public partial class AzurermWebPubsubHub : TerraformResource
{
    public AzurermWebPubsubHub(string name) : base("azurerm_web_pubsub_hub", name)
    {
    }

    /// <summary>
    /// The anonymous_connections_enabled attribute.
    /// </summary>
    [TerraformProperty("anonymous_connections_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AnonymousConnectionsEnabled { get; set; }

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
    /// The web_pubsub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebPubsubId is required")]
    [TerraformProperty("web_pubsub_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WebPubsubId { get; set; }

    /// <summary>
    /// Block for event_handler.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("event_handler")]
    public TerraformList<AzurermWebPubsubHubEventHandlerBlock> EventHandler { get; set; } = new();

    /// <summary>
    /// Block for event_listener.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("event_listener")]
    public TerraformList<AzurermWebPubsubHubEventListenerBlock> EventListener { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermWebPubsubHubTimeoutsBlock Timeouts { get; set; } = new();

}
