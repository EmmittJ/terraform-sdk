using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_notification_hub_authorization_rule resource.
/// </summary>
public class AzurermNotificationHubAuthorizationRule : TerraformResource
{
    public AzurermNotificationHubAuthorizationRule(string name) : base("azurerm_notification_hub_authorization_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("primary_access_key");
        this.DeclareOutput("primary_connection_string");
        this.DeclareOutput("secondary_access_key");
        this.DeclareOutput("secondary_connection_string");
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
    /// The notification_hub_name attribute.
    /// </summary>
    public TerraformProperty<string>? NotificationHubName
    {
        get => GetProperty<TerraformProperty<string>>("notification_hub_name");
        set => this.WithProperty("notification_hub_name", value);
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
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformExpression PrimaryAccessKey => this["primary_access_key"];

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformExpression PrimaryConnectionString => this["primary_connection_string"];

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformExpression SecondaryAccessKey => this["secondary_access_key"];

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformExpression SecondaryConnectionString => this["secondary_connection_string"];

}
