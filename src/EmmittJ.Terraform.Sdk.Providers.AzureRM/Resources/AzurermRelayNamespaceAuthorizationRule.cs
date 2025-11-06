using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_relay_namespace_authorization_rule resource.
/// </summary>
public class AzurermRelayNamespaceAuthorizationRule : TerraformResource
{
    public AzurermRelayNamespaceAuthorizationRule(string name) : base("azurerm_relay_namespace_authorization_rule", name)
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
    /// The namespace_name attribute.
    /// </summary>
    public string? NamespaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace_name")?.Value;
        set => this.WithProperty("namespace_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
