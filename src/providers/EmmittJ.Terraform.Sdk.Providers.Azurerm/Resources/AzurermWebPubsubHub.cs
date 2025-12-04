using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for event_handler in AzurermWebPubsubHub.
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
        get => GetArgument<TerraformSet<string>>("system_events");
        set => SetArgument("system_events", value);
    }

    /// <summary>
    /// The url_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UrlTemplate is required")]
    public required TerraformValue<string> UrlTemplate
    {
        get => GetRequiredArgument<TerraformValue<string>>("url_template");
        set => SetArgument("url_template", value);
    }

    /// <summary>
    /// The user_event_pattern attribute.
    /// </summary>
    public TerraformValue<string>? UserEventPattern
    {
        get => GetArgument<TerraformValue<string>>("user_event_pattern");
        set => SetArgument("user_event_pattern", value);
    }

    /// <summary>
    /// Auth block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Auth block(s) allowed")]
    public TerraformList<AzurermWebPubsubHubEventHandlerBlockAuthBlock>? Auth
    {
        get => GetArgument<TerraformList<AzurermWebPubsubHubEventHandlerBlockAuthBlock>>("auth");
        set => SetArgument("auth", value);
    }

}

/// <summary>
/// Block type for auth in AzurermWebPubsubHubEventHandlerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWebPubsubHubEventHandlerBlockAuthBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auth";

    /// <summary>
    /// The managed_identity_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedIdentityId is required")]
    public required TerraformValue<string> ManagedIdentityId
    {
        get => GetRequiredArgument<TerraformValue<string>>("managed_identity_id");
        set => SetArgument("managed_identity_id", value);
    }

}


/// <summary>
/// Block type for event_listener in AzurermWebPubsubHub.
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
        get => GetRequiredArgument<TerraformValue<string>>("eventhub_name");
        set => SetArgument("eventhub_name", value);
    }

    /// <summary>
    /// The eventhub_namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubNamespaceName is required")]
    public required TerraformValue<string> EventhubNamespaceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("eventhub_namespace_name");
        set => SetArgument("eventhub_namespace_name", value);
    }

    /// <summary>
    /// The system_event_name_filter attribute.
    /// </summary>
    public TerraformList<string>? SystemEventNameFilter
    {
        get => GetArgument<TerraformList<string>>("system_event_name_filter");
        set => SetArgument("system_event_name_filter", value);
    }

    /// <summary>
    /// The user_event_name_filter attribute.
    /// </summary>
    public TerraformList<string>? UserEventNameFilter
    {
        get => GetArgument<TerraformList<string>>("user_event_name_filter");
        set => SetArgument("user_event_name_filter", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermWebPubsubHub.
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<bool>>("anonymous_connections_enabled");
        set => SetArgument("anonymous_connections_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The web_pubsub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebPubsubId is required")]
    public required TerraformValue<string> WebPubsubId
    {
        get => GetRequiredArgument<TerraformValue<string>>("web_pubsub_id");
        set => SetArgument("web_pubsub_id", value);
    }

    /// <summary>
    /// EventHandler block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermWebPubsubHubEventHandlerBlock>? EventHandler
    {
        get => GetArgument<TerraformList<AzurermWebPubsubHubEventHandlerBlock>>("event_handler");
        set => SetArgument("event_handler", value);
    }

    /// <summary>
    /// EventListener block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermWebPubsubHubEventListenerBlock>? EventListener
    {
        get => GetArgument<TerraformList<AzurermWebPubsubHubEventListenerBlock>>("event_listener");
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
