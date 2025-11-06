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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The listen attribute.
    /// </summary>
    public bool? Listen
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("listen")?.Value;
        set => this.WithProperty("listen", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The manage attribute.
    /// </summary>
    public bool? Manage
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("manage")?.Value;
        set => this.WithProperty("manage", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The send attribute.
    /// </summary>
    public bool? Send
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("send")?.Value;
        set => this.WithProperty("send", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The topic_id attribute.
    /// </summary>
    public string? TopicId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("topic_id")?.Value;
        set => this.WithProperty("topic_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
