using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusQueueAuthorizationRuleTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_servicebus_queue_authorization_rule resource.
/// </summary>
public class AzurermServicebusQueueAuthorizationRule : TerraformResource
{
    public AzurermServicebusQueueAuthorizationRule(string name) : base("azurerm_servicebus_queue_authorization_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("primary_connection_string");
        SetOutput("primary_connection_string_alias");
        SetOutput("primary_key");
        SetOutput("secondary_connection_string");
        SetOutput("secondary_connection_string_alias");
        SetOutput("secondary_key");
        SetOutput("id");
        SetOutput("listen");
        SetOutput("manage");
        SetOutput("name");
        SetOutput("queue_id");
        SetOutput("send");
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
    /// The listen attribute.
    /// </summary>
    public TerraformProperty<bool> Listen
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("listen");
        set => SetProperty("listen", value);
    }

    /// <summary>
    /// The manage attribute.
    /// </summary>
    public TerraformProperty<bool> Manage
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("manage");
        set => SetProperty("manage", value);
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
    /// The queue_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueId is required")]
    public required TerraformProperty<string> QueueId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("queue_id");
        set => SetProperty("queue_id", value);
    }

    /// <summary>
    /// The send attribute.
    /// </summary>
    public TerraformProperty<bool> Send
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("send");
        set => SetProperty("send", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermServicebusQueueAuthorizationRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformExpression PrimaryConnectionString => this["primary_connection_string"];

    /// <summary>
    /// The primary_connection_string_alias attribute.
    /// </summary>
    public TerraformExpression PrimaryConnectionStringAlias => this["primary_connection_string_alias"];

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformExpression PrimaryKey => this["primary_key"];

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformExpression SecondaryConnectionString => this["secondary_connection_string"];

    /// <summary>
    /// The secondary_connection_string_alias attribute.
    /// </summary>
    public TerraformExpression SecondaryConnectionStringAlias => this["secondary_connection_string_alias"];

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformExpression SecondaryKey => this["secondary_key"];

}
