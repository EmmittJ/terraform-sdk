using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for correlation_filter in AzurermServicebusSubscriptionRule.
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
    public TerraformValue<string>? ContentType
    {
        get => GetArgument<TerraformValue<string>>("content_type");
        set => SetArgument("content_type", value);
    }

    /// <summary>
    /// The correlation_id attribute.
    /// </summary>
    public TerraformValue<string>? CorrelationId
    {
        get => GetArgument<TerraformValue<string>>("correlation_id");
        set => SetArgument("correlation_id", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformValue<string>? Label
    {
        get => GetArgument<TerraformValue<string>>("label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The message_id attribute.
    /// </summary>
    public TerraformValue<string>? MessageId
    {
        get => GetArgument<TerraformValue<string>>("message_id");
        set => SetArgument("message_id", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// The reply_to attribute.
    /// </summary>
    public TerraformValue<string>? ReplyTo
    {
        get => GetArgument<TerraformValue<string>>("reply_to");
        set => SetArgument("reply_to", value);
    }

    /// <summary>
    /// The reply_to_session_id attribute.
    /// </summary>
    public TerraformValue<string>? ReplyToSessionId
    {
        get => GetArgument<TerraformValue<string>>("reply_to_session_id");
        set => SetArgument("reply_to_session_id", value);
    }

    /// <summary>
    /// The session_id attribute.
    /// </summary>
    public TerraformValue<string>? SessionId
    {
        get => GetArgument<TerraformValue<string>>("session_id");
        set => SetArgument("session_id", value);
    }

    /// <summary>
    /// The to attribute.
    /// </summary>
    public TerraformValue<string>? To
    {
        get => GetArgument<TerraformValue<string>>("to");
        set => SetArgument("to", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermServicebusSubscriptionRule.
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
/// Represents a azurerm_servicebus_subscription_rule Terraform resource.
/// Manages a azurerm_servicebus_subscription_rule resource.
/// </summary>
public partial class AzurermServicebusSubscriptionRule(string name) : TerraformResource("azurerm_servicebus_subscription_rule", name)
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformValue<string>? Action
    {
        get => GetArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterType is required")]
    public required TerraformValue<string> FilterType
    {
        get => GetArgument<TerraformValue<string>>("filter_type");
        set => SetArgument("filter_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The sql_filter attribute.
    /// </summary>
    public TerraformValue<string>? SqlFilter
    {
        get => GetArgument<TerraformValue<string>>("sql_filter");
        set => SetArgument("sql_filter", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    public required TerraformValue<string> SubscriptionId
    {
        get => GetArgument<TerraformValue<string>>("subscription_id");
        set => SetArgument("subscription_id", value);
    }

    /// <summary>
    /// The sql_filter_compatibility_level attribute.
    /// </summary>
    public TerraformValue<double> SqlFilterCompatibilityLevel
        => AsReference("sql_filter_compatibility_level");

    /// <summary>
    /// CorrelationFilter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorrelationFilter block(s) allowed")]
    public TerraformList<AzurermServicebusSubscriptionRuleCorrelationFilterBlock>? CorrelationFilter
    {
        get => GetArgument<TerraformList<AzurermServicebusSubscriptionRuleCorrelationFilterBlock>>("correlation_filter");
        set => SetArgument("correlation_filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermServicebusSubscriptionRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermServicebusSubscriptionRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
