using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformSet<string>? SystemEvents
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "system_events").ResolveNodes(ctx));
        set => SetArgument("system_events", value);
    }

    /// <summary>
    /// The url_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UrlTemplate is required")]
    public required TerraformValue<string> UrlTemplate
    {
        get => new TerraformReference<string>(this, "url_template");
        set => SetArgument("url_template", value);
    }

    /// <summary>
    /// The user_event_pattern attribute.
    /// </summary>
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
    public required TerraformValue<string> EventhubName
    {
        get => new TerraformReference<string>(this, "eventhub_name");
        set => SetArgument("eventhub_name", value);
    }

    /// <summary>
    /// The eventhub_namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubNamespaceName is required")]
    public required TerraformValue<string> EventhubNamespaceName
    {
        get => new TerraformReference<string>(this, "eventhub_namespace_name");
        set => SetArgument("eventhub_namespace_name", value);
    }

    /// <summary>
    /// The system_event_name_filter attribute.
    /// </summary>
    public TerraformList<string>? SystemEventNameFilter
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "system_event_name_filter").ResolveNodes(ctx));
        set => SetArgument("system_event_name_filter", value);
    }

    /// <summary>
    /// The user_event_name_filter attribute.
    /// </summary>
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_web_pubsub_hub Terraform resource.
/// Manages a azurerm_web_pubsub_hub resource.
/// </summary>
public partial class AzurermWebPubsubHub(string name) : TerraformResource("azurerm_web_pubsub_hub", name)
{
    /// <summary>
    /// The anonymous_connections_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AnonymousConnectionsEnabled
    {
        get => new TerraformReference<bool>(this, "anonymous_connections_enabled");
        set => SetArgument("anonymous_connections_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The web_pubsub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebPubsubId is required")]
    public required TerraformValue<string> WebPubsubId
    {
        get => new TerraformReference<string>(this, "web_pubsub_id");
        set => SetArgument("web_pubsub_id", value);
    }

    /// <summary>
    /// EventHandler block (nesting mode: list).
    /// </summary>
    public AzurermWebPubsubHubEventHandlerBlock? EventHandler
    {
        get => GetArgument<AzurermWebPubsubHubEventHandlerBlock>("event_handler");
        set => SetArgument("event_handler", value);
    }

    /// <summary>
    /// EventListener block (nesting mode: list).
    /// </summary>
    public AzurermWebPubsubHubEventListenerBlock? EventListener
    {
        get => GetArgument<AzurermWebPubsubHubEventListenerBlock>("event_listener");
        set => SetArgument("event_listener", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermWebPubsubHubTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermWebPubsubHubTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
