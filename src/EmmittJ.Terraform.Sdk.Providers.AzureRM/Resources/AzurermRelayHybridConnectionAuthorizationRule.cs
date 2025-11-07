using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_relay_hybrid_connection_authorization_rule resource.
/// </summary>
public class AzurermRelayHybridConnectionAuthorizationRule : TerraformResource
{
    public AzurermRelayHybridConnectionAuthorizationRule(string name) : base("azurerm_relay_hybrid_connection_authorization_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("primary_connection_string");
        this.DeclareOutput("primary_key");
        this.DeclareOutput("secondary_connection_string");
        this.DeclareOutput("secondary_key");
    }

    /// <summary>
    /// The hybrid_connection_name attribute.
    /// </summary>
    public TerraformProperty<string>? HybridConnectionName
    {
        get => GetProperty<TerraformProperty<string>>("hybrid_connection_name");
        set => this.WithProperty("hybrid_connection_name", value);
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
    /// The namespace_name attribute.
    /// </summary>
    public TerraformProperty<string>? NamespaceName
    {
        get => GetProperty<TerraformProperty<string>>("namespace_name");
        set => this.WithProperty("namespace_name", value);
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
    /// The send attribute.
    /// </summary>
    public TerraformProperty<bool>? Send
    {
        get => GetProperty<TerraformProperty<bool>>("send");
        set => this.WithProperty("send", value);
    }

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformExpression PrimaryConnectionString => this["primary_connection_string"];

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformExpression PrimaryKey => this["primary_key"];

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformExpression SecondaryConnectionString => this["secondary_connection_string"];

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformExpression SecondaryKey => this["secondary_key"];

}
