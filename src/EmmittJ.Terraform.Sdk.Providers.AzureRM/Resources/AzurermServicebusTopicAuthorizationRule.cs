using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_servicebus_topic_authorization_rule resource.
/// </summary>
public class AzurermServicebusTopicAuthorizationRule : TerraformResource
{
    public AzurermServicebusTopicAuthorizationRule(string name) : base("azurerm_servicebus_topic_authorization_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("primary_connection_string");
        this.DeclareOutput("primary_connection_string_alias");
        this.DeclareOutput("primary_key");
        this.DeclareOutput("secondary_connection_string");
        this.DeclareOutput("secondary_connection_string_alias");
        this.DeclareOutput("secondary_key");
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
    /// The listen attribute.
    /// </summary>
    public TerraformProperty<bool>? Listen
    {
        get => GetProperty<TerraformProperty<bool>>("listen");
        set => this.WithProperty("listen", value);
    }

    /// <summary>
    /// The manage attribute.
    /// </summary>
    public TerraformProperty<bool>? Manage
    {
        get => GetProperty<TerraformProperty<bool>>("manage");
        set => this.WithProperty("manage", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The send attribute.
    /// </summary>
    public TerraformProperty<bool>? Send
    {
        get => GetProperty<TerraformProperty<bool>>("send");
        set => this.WithProperty("send", value);
    }

    /// <summary>
    /// The topic_id attribute.
    /// </summary>
    public TerraformProperty<string>? TopicId
    {
        get => GetProperty<TerraformProperty<string>>("topic_id");
        set => this.WithProperty("topic_id", value);
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
