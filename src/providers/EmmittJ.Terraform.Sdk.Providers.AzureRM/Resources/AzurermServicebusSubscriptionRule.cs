using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for correlation_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermServicebusSubscriptionRuleCorrelationFilterBlock : TerraformBlock
{
    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformProperty<string>? ContentType
    {
        set => SetProperty("content_type", value);
    }

    /// <summary>
    /// The correlation_id attribute.
    /// </summary>
    public TerraformProperty<string>? CorrelationId
    {
        set => SetProperty("correlation_id", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformProperty<string>? Label
    {
        set => SetProperty("label", value);
    }

    /// <summary>
    /// The message_id attribute.
    /// </summary>
    public TerraformProperty<string>? MessageId
    {
        set => SetProperty("message_id", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        set => SetProperty("properties", value);
    }

    /// <summary>
    /// The reply_to attribute.
    /// </summary>
    public TerraformProperty<string>? ReplyTo
    {
        set => SetProperty("reply_to", value);
    }

    /// <summary>
    /// The reply_to_session_id attribute.
    /// </summary>
    public TerraformProperty<string>? ReplyToSessionId
    {
        set => SetProperty("reply_to_session_id", value);
    }

    /// <summary>
    /// The session_id attribute.
    /// </summary>
    public TerraformProperty<string>? SessionId
    {
        set => SetProperty("session_id", value);
    }

    /// <summary>
    /// The to attribute.
    /// </summary>
    public TerraformProperty<string>? To
    {
        set => SetProperty("to", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusSubscriptionRuleTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_servicebus_subscription_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermServicebusSubscriptionRule : TerraformResource
{
    public AzurermServicebusSubscriptionRule(string name) : base("azurerm_servicebus_subscription_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("sql_filter_compatibility_level");
        SetOutput("action");
        SetOutput("filter_type");
        SetOutput("id");
        SetOutput("name");
        SetOutput("sql_filter");
        SetOutput("subscription_id");
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformProperty<string> Action
    {
        get => GetRequiredOutput<TerraformProperty<string>>("action");
        set => SetProperty("action", value);
    }

    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterType is required")]
    public required TerraformProperty<string> FilterType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filter_type");
        set => SetProperty("filter_type", value);
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
    /// The sql_filter attribute.
    /// </summary>
    public TerraformProperty<string> SqlFilter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sql_filter");
        set => SetProperty("sql_filter", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    public required TerraformProperty<string> SubscriptionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subscription_id");
        set => SetProperty("subscription_id", value);
    }

    /// <summary>
    /// Block for correlation_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorrelationFilter block(s) allowed")]
    public List<AzurermServicebusSubscriptionRuleCorrelationFilterBlock>? CorrelationFilter
    {
        set => SetProperty("correlation_filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermServicebusSubscriptionRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The sql_filter_compatibility_level attribute.
    /// </summary>
    public TerraformExpression SqlFilterCompatibilityLevel => this["sql_filter_compatibility_level"];

}
