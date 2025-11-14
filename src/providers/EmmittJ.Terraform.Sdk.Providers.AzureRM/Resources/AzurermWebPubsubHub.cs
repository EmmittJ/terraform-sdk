using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for event_handler in .
/// Nesting mode: list
/// </summary>
public class AzurermWebPubsubHubEventHandlerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_handler";

    /// <summary>
    /// The system_events attribute.
    /// </summary>
    [TerraformArgument("system_events")]
    public TerraformSet<string>? SystemEvents
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "system_events").ResolveNodes(ctx));
        set => SetArgument("system_events", value);
    }

    /// <summary>
    /// The url_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UrlTemplate is required")]
    [TerraformArgument("url_template")]
    public required TerraformValue<string> UrlTemplate
    {
        get => new TerraformReference<string>(this, "url_template");
        set => SetArgument("url_template", value);
    }

    /// <summary>
    /// The user_event_pattern attribute.
    /// </summary>
    [TerraformArgument("user_event_pattern")]
    public TerraformValue<string>? UserEventPattern
    {
        get => new TerraformReference<string>(this, "user_event_pattern");
        set => SetArgument("user_event_pattern", value);
    }

}

/// <summary>
/// Block type for event_listener in .
/// Nesting mode: list
/// </summary>
public class AzurermWebPubsubHubEventListenerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_listener";

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubName is required")]
    [TerraformArgument("eventhub_name")]
    public required TerraformValue<string> EventhubName
    {
        get => new TerraformReference<string>(this, "eventhub_name");
        set => SetArgument("eventhub_name", value);
    }

    /// <summary>
    /// The eventhub_namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubNamespaceName is required")]
    [TerraformArgument("eventhub_namespace_name")]
    public required TerraformValue<string> EventhubNamespaceName
    {
        get => new TerraformReference<string>(this, "eventhub_namespace_name");
        set => SetArgument("eventhub_namespace_name", value);
    }

    /// <summary>
    /// The system_event_name_filter attribute.
    /// </summary>
    [TerraformArgument("system_event_name_filter")]
    public TerraformList<string>? SystemEventNameFilter
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "system_event_name_filter").ResolveNodes(ctx));
        set => SetArgument("system_event_name_filter", value);
    }

    /// <summary>
    /// The user_event_name_filter attribute.
    /// </summary>
    [TerraformArgument("user_event_name_filter")]
    public TerraformList<string>? UserEventNameFilter
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "user_event_name_filter").ResolveNodes(ctx));
        set => SetArgument("user_event_name_filter", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWebPubsubHubTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

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
    [TerraformArgument("anonymous_connections_enabled")]
    public TerraformValue<bool>? AnonymousConnectionsEnabled
    {
        get => new TerraformReference<bool>(this, "anonymous_connections_enabled");
        set => SetArgument("anonymous_connections_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The web_pubsub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebPubsubId is required")]
    [TerraformArgument("web_pubsub_id")]
    public required TerraformValue<string> WebPubsubId
    {
        get => new TerraformReference<string>(this, "web_pubsub_id");
        set => SetArgument("web_pubsub_id", value);
    }

    /// <summary>
    /// Block for event_handler.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("event_handler")]
    public TerraformList<AzurermWebPubsubHubEventHandlerBlock> EventHandler { get; set; } = new();

    /// <summary>
    /// Block for event_listener.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("event_listener")]
    public TerraformList<AzurermWebPubsubHubEventListenerBlock> EventListener { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermWebPubsubHubTimeoutsBlock Timeouts { get; set; } = new();

}
