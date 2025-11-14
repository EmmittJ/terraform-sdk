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
/// Block type for correlation_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermServicebusSubscriptionRuleCorrelationFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "correlation_filter";

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformArgument("content_type")]
    public TerraformValue<string>? ContentType
    {
        get => new TerraformReference<string>(this, "content_type");
        set => SetArgument("content_type", value);
    }

    /// <summary>
    /// The correlation_id attribute.
    /// </summary>
    [TerraformArgument("correlation_id")]
    public TerraformValue<string>? CorrelationId
    {
        get => new TerraformReference<string>(this, "correlation_id");
        set => SetArgument("correlation_id", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    [TerraformArgument("label")]
    public TerraformValue<string>? Label
    {
        get => new TerraformReference<string>(this, "label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The message_id attribute.
    /// </summary>
    [TerraformArgument("message_id")]
    public TerraformValue<string>? MessageId
    {
        get => new TerraformReference<string>(this, "message_id");
        set => SetArgument("message_id", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    [TerraformArgument("properties")]
    public TerraformMap<string>? Properties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "properties").ResolveNodes(ctx));
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// The reply_to attribute.
    /// </summary>
    [TerraformArgument("reply_to")]
    public TerraformValue<string>? ReplyTo
    {
        get => new TerraformReference<string>(this, "reply_to");
        set => SetArgument("reply_to", value);
    }

    /// <summary>
    /// The reply_to_session_id attribute.
    /// </summary>
    [TerraformArgument("reply_to_session_id")]
    public TerraformValue<string>? ReplyToSessionId
    {
        get => new TerraformReference<string>(this, "reply_to_session_id");
        set => SetArgument("reply_to_session_id", value);
    }

    /// <summary>
    /// The session_id attribute.
    /// </summary>
    [TerraformArgument("session_id")]
    public TerraformValue<string>? SessionId
    {
        get => new TerraformReference<string>(this, "session_id");
        set => SetArgument("session_id", value);
    }

    /// <summary>
    /// The to attribute.
    /// </summary>
    [TerraformArgument("to")]
    public TerraformValue<string>? To
    {
        get => new TerraformReference<string>(this, "to");
        set => SetArgument("to", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusSubscriptionRuleTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_servicebus_subscription_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermServicebusSubscriptionRule : TerraformResource
{
    public AzurermServicebusSubscriptionRule(string name) : base("azurerm_servicebus_subscription_rule", name)
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [TerraformArgument("action")]
    public TerraformValue<string>? Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterType is required")]
    [TerraformArgument("filter_type")]
    public required TerraformValue<string> FilterType
    {
        get => new TerraformReference<string>(this, "filter_type");
        set => SetArgument("filter_type", value);
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
    /// The sql_filter attribute.
    /// </summary>
    [TerraformArgument("sql_filter")]
    public TerraformValue<string>? SqlFilter
    {
        get => new TerraformReference<string>(this, "sql_filter");
        set => SetArgument("sql_filter", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    [TerraformArgument("subscription_id")]
    public required TerraformValue<string> SubscriptionId
    {
        get => new TerraformReference<string>(this, "subscription_id");
        set => SetArgument("subscription_id", value);
    }

    /// <summary>
    /// Block for correlation_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorrelationFilter block(s) allowed")]
    [TerraformArgument("correlation_filter")]
    public TerraformList<AzurermServicebusSubscriptionRuleCorrelationFilterBlock> CorrelationFilter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermServicebusSubscriptionRuleTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The sql_filter_compatibility_level attribute.
    /// </summary>
    [TerraformArgument("sql_filter_compatibility_level")]
    public TerraformValue<double> SqlFilterCompatibilityLevel
    {
        get => new TerraformReference<double>(this, "sql_filter_compatibility_level");
    }

}
