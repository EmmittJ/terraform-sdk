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
        set => SetProperty("system_events", value);
    }

    /// <summary>
    /// The url_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UrlTemplate is required")]
    public required TerraformProperty<string> UrlTemplate
    {
        set => SetProperty("url_template", value);
    }

    /// <summary>
    /// The user_event_pattern attribute.
    /// </summary>
    public TerraformProperty<string>? UserEventPattern
    {
        set => SetProperty("user_event_pattern", value);
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
        set => SetProperty("eventhub_name", value);
    }

    /// <summary>
    /// The eventhub_namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubNamespaceName is required")]
    public required TerraformProperty<string> EventhubNamespaceName
    {
        set => SetProperty("eventhub_namespace_name", value);
    }

    /// <summary>
    /// The system_event_name_filter attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SystemEventNameFilter
    {
        set => SetProperty("system_event_name_filter", value);
    }

    /// <summary>
    /// The user_event_name_filter attribute.
    /// </summary>
    public List<TerraformProperty<string>>? UserEventNameFilter
    {
        set => SetProperty("user_event_name_filter", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("anonymous_connections_enabled");
        SetOutput("id");
        SetOutput("name");
        SetOutput("web_pubsub_id");
    }

    /// <summary>
    /// The anonymous_connections_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AnonymousConnectionsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("anonymous_connections_enabled");
        set => SetProperty("anonymous_connections_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The web_pubsub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebPubsubId is required")]
    public required TerraformProperty<string> WebPubsubId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("web_pubsub_id");
        set => SetProperty("web_pubsub_id", value);
    }

    /// <summary>
    /// Block for event_handler.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermWebPubsubHubEventHandlerBlock>? EventHandler
    {
        set => SetProperty("event_handler", value);
    }

    /// <summary>
    /// Block for event_listener.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermWebPubsubHubEventListenerBlock>? EventListener
    {
        set => SetProperty("event_listener", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermWebPubsubHubTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
