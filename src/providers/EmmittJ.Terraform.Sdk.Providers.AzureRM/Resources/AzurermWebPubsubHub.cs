using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for event_handler in .
/// Nesting mode: list
/// </summary>
public class AzurermWebPubsubHubEventHandlerBlock : ITerraformBlock
{
    /// <summary>
    /// The system_events attribute.
    /// </summary>
    [TerraformPropertyName("system_events")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SystemEvents { get; set; }

    /// <summary>
    /// The url_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UrlTemplate is required")]
    [TerraformPropertyName("url_template")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UrlTemplate { get; set; }

    /// <summary>
    /// The user_event_pattern attribute.
    /// </summary>
    [TerraformPropertyName("user_event_pattern")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserEventPattern { get; set; }

}

/// <summary>
/// Block type for event_listener in .
/// Nesting mode: list
/// </summary>
public class AzurermWebPubsubHubEventListenerBlock : ITerraformBlock
{
    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubName is required")]
    [TerraformPropertyName("eventhub_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EventhubName { get; set; }

    /// <summary>
    /// The eventhub_namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubNamespaceName is required")]
    [TerraformPropertyName("eventhub_namespace_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EventhubNamespaceName { get; set; }

    /// <summary>
    /// The system_event_name_filter attribute.
    /// </summary>
    [TerraformPropertyName("system_event_name_filter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SystemEventNameFilter { get; set; }

    /// <summary>
    /// The user_event_name_filter attribute.
    /// </summary>
    [TerraformPropertyName("user_event_name_filter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? UserEventNameFilter { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWebPubsubHubTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_web_pubsub_hub resource.
/// </summary>
public class AzurermWebPubsubHub : TerraformResource
{
    public AzurermWebPubsubHub(string name) : base("azurerm_web_pubsub_hub", name)
    {
    }

    /// <summary>
    /// The anonymous_connections_enabled attribute.
    /// </summary>
    [TerraformPropertyName("anonymous_connections_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AnonymousConnectionsEnabled { get; set; }

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
    /// The web_pubsub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebPubsubId is required")]
    [TerraformPropertyName("web_pubsub_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WebPubsubId { get; set; }

    /// <summary>
    /// Block for event_handler.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("event_handler")]
    public TerraformList<TerraformBlock<AzurermWebPubsubHubEventHandlerBlock>>? EventHandler { get; set; } = new();

    /// <summary>
    /// Block for event_listener.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("event_listener")]
    public TerraformList<TerraformBlock<AzurermWebPubsubHubEventListenerBlock>>? EventListener { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermWebPubsubHubTimeoutsBlock>? Timeouts { get; set; } = new();

}
