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
        get => GetProperty<TerraformProperty<string>>("content_type");
        set => WithProperty("content_type", value);
    }

    /// <summary>
    /// The correlation_id attribute.
    /// </summary>
    public TerraformProperty<string>? CorrelationId
    {
        get => GetProperty<TerraformProperty<string>>("correlation_id");
        set => WithProperty("correlation_id", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformProperty<string>? Label
    {
        get => GetProperty<TerraformProperty<string>>("label");
        set => WithProperty("label", value);
    }

    /// <summary>
    /// The message_id attribute.
    /// </summary>
    public TerraformProperty<string>? MessageId
    {
        get => GetProperty<TerraformProperty<string>>("message_id");
        set => WithProperty("message_id", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("properties");
        set => WithProperty("properties", value);
    }

    /// <summary>
    /// The reply_to attribute.
    /// </summary>
    public TerraformProperty<string>? ReplyTo
    {
        get => GetProperty<TerraformProperty<string>>("reply_to");
        set => WithProperty("reply_to", value);
    }

    /// <summary>
    /// The reply_to_session_id attribute.
    /// </summary>
    public TerraformProperty<string>? ReplyToSessionId
    {
        get => GetProperty<TerraformProperty<string>>("reply_to_session_id");
        set => WithProperty("reply_to_session_id", value);
    }

    /// <summary>
    /// The session_id attribute.
    /// </summary>
    public TerraformProperty<string>? SessionId
    {
        get => GetProperty<TerraformProperty<string>>("session_id");
        set => WithProperty("session_id", value);
    }

    /// <summary>
    /// The to attribute.
    /// </summary>
    public TerraformProperty<string>? To
    {
        get => GetProperty<TerraformProperty<string>>("to");
        set => WithProperty("to", value);
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
        this.DeclareOutput("sql_filter_compatibility_level");
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformProperty<string>? Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterType is required")]
    public required TerraformProperty<string> FilterType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("filter_type");
        set => this.WithProperty("filter_type", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The sql_filter attribute.
    /// </summary>
    public TerraformProperty<string>? SqlFilter
    {
        get => GetProperty<TerraformProperty<string>>("sql_filter");
        set => this.WithProperty("sql_filter", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    public required TerraformProperty<string> SubscriptionId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("subscription_id");
        set => this.WithProperty("subscription_id", value);
    }

    /// <summary>
    /// Block for correlation_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorrelationFilter block(s) allowed")]
    public List<AzurermServicebusSubscriptionRuleCorrelationFilterBlock>? CorrelationFilter
    {
        get => GetProperty<List<AzurermServicebusSubscriptionRuleCorrelationFilterBlock>>("correlation_filter");
        set => this.WithProperty("correlation_filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermServicebusSubscriptionRuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermServicebusSubscriptionRuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The sql_filter_compatibility_level attribute.
    /// </summary>
    public TerraformExpression SqlFilterCompatibilityLevel => this["sql_filter_compatibility_level"];

}
