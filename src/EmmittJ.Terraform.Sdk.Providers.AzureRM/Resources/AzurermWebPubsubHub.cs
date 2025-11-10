using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for event_handler in .
/// Nesting mode: list
/// </summary>
public class AzurermWebPubsubHubEventHandlerBlock : TerraformBlock
{
    /// <summary>
    /// The system_events attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SystemEvents
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("system_events");
        set => WithProperty("system_events", value);
    }

    /// <summary>
    /// The url_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UrlTemplate is required")]
    public required TerraformProperty<string> UrlTemplate
    {
        get => GetProperty<TerraformProperty<string>>("url_template");
        set => WithProperty("url_template", value);
    }

    /// <summary>
    /// The user_event_pattern attribute.
    /// </summary>
    public TerraformProperty<string>? UserEventPattern
    {
        get => GetProperty<TerraformProperty<string>>("user_event_pattern");
        set => WithProperty("user_event_pattern", value);
    }

}

/// <summary>
/// Block type for event_listener in .
/// Nesting mode: list
/// </summary>
public class AzurermWebPubsubHubEventListenerBlock : TerraformBlock
{
    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubName is required")]
    public required TerraformProperty<string> EventhubName
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_name");
        set => WithProperty("eventhub_name", value);
    }

    /// <summary>
    /// The eventhub_namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubNamespaceName is required")]
    public required TerraformProperty<string> EventhubNamespaceName
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_namespace_name");
        set => WithProperty("eventhub_namespace_name", value);
    }

    /// <summary>
    /// The system_event_name_filter attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SystemEventNameFilter
    {
        get => GetProperty<List<TerraformProperty<string>>>("system_event_name_filter");
        set => WithProperty("system_event_name_filter", value);
    }

    /// <summary>
    /// The user_event_name_filter attribute.
    /// </summary>
    public List<TerraformProperty<string>>? UserEventNameFilter
    {
        get => GetProperty<List<TerraformProperty<string>>>("user_event_name_filter");
        set => WithProperty("user_event_name_filter", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWebPubsubHubTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_web_pubsub_hub resource.
/// </summary>
public class AzurermWebPubsubHub : TerraformResource
{
    public AzurermWebPubsubHub(string name) : base("azurerm_web_pubsub_hub", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The anonymous_connections_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AnonymousConnectionsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("anonymous_connections_enabled");
        set => this.WithProperty("anonymous_connections_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The web_pubsub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebPubsubId is required")]
    public required TerraformProperty<string> WebPubsubId
    {
        get => GetProperty<TerraformProperty<string>>("web_pubsub_id");
        set => this.WithProperty("web_pubsub_id", value);
    }

    /// <summary>
    /// Block for event_handler.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermWebPubsubHubEventHandlerBlock>? EventHandler
    {
        get => GetProperty<List<AzurermWebPubsubHubEventHandlerBlock>>("event_handler");
        set => this.WithProperty("event_handler", value);
    }

    /// <summary>
    /// Block for event_listener.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermWebPubsubHubEventListenerBlock>? EventListener
    {
        get => GetProperty<List<AzurermWebPubsubHubEventListenerBlock>>("event_listener");
        set => this.WithProperty("event_listener", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermWebPubsubHubTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermWebPubsubHubTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
