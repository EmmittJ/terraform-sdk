using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusTopicAuthorizationRuleDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_servicebus_topic_authorization_rule.
/// </summary>
public class AzurermServicebusTopicAuthorizationRuleDataSource : TerraformDataSource
{
    public AzurermServicebusTopicAuthorizationRuleDataSource(string name) : base("azurerm_servicebus_topic_authorization_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("listen");
        SetOutput("manage");
        SetOutput("primary_connection_string");
        SetOutput("primary_connection_string_alias");
        SetOutput("primary_key");
        SetOutput("secondary_connection_string");
        SetOutput("secondary_connection_string_alias");
        SetOutput("secondary_key");
        SetOutput("send");
        SetOutput("id");
        SetOutput("name");
        SetOutput("namespace_name");
        SetOutput("queue_name");
        SetOutput("resource_group_name");
        SetOutput("topic_id");
        SetOutput("topic_name");
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
    /// The namespace_name attribute.
    /// </summary>
    public TerraformProperty<string> NamespaceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("namespace_name");
        set => SetProperty("namespace_name", value);
    }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    public TerraformProperty<string> QueueName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("queue_name");
        set => SetProperty("queue_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The topic_id attribute.
    /// </summary>
    public TerraformProperty<string> TopicId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("topic_id");
        set => SetProperty("topic_id", value);
    }

    /// <summary>
    /// The topic_name attribute.
    /// </summary>
    public TerraformProperty<string> TopicName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("topic_name");
        set => SetProperty("topic_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermServicebusTopicAuthorizationRuleDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The listen attribute.
    /// </summary>
    public TerraformExpression Listen => this["listen"];

    /// <summary>
    /// The manage attribute.
    /// </summary>
    public TerraformExpression Manage => this["manage"];

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

    /// <summary>
    /// The send attribute.
    /// </summary>
    public TerraformExpression Send => this["send"];

}
