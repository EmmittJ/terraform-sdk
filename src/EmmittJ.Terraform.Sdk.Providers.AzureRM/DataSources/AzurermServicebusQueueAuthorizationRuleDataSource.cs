using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_servicebus_queue_authorization_rule.
/// </summary>
public class AzurermServicebusQueueAuthorizationRuleDataSource : TerraformDataSource
{
    public AzurermServicebusQueueAuthorizationRuleDataSource(string name) : base("azurerm_servicebus_queue_authorization_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("listen");
        this.DeclareOutput("manage");
        this.DeclareOutput("primary_connection_string");
        this.DeclareOutput("primary_connection_string_alias");
        this.DeclareOutput("primary_key");
        this.DeclareOutput("secondary_connection_string");
        this.DeclareOutput("secondary_connection_string_alias");
        this.DeclareOutput("secondary_key");
        this.DeclareOutput("send");
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    public TerraformProperty<string>? NamespaceName
    {
        get => GetProperty<TerraformProperty<string>>("namespace_name");
        set => this.WithProperty("namespace_name", value);
    }

    /// <summary>
    /// The queue_id attribute.
    /// </summary>
    public TerraformProperty<string>? QueueId
    {
        get => GetProperty<TerraformProperty<string>>("queue_id");
        set => this.WithProperty("queue_id", value);
    }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    public TerraformProperty<string>? QueueName
    {
        get => GetProperty<TerraformProperty<string>>("queue_name");
        set => this.WithProperty("queue_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
