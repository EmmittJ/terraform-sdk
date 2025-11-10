using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNotificationHubAuthorizationRuleTimeoutsBlock : TerraformBlock
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
        SetOutput("primary_access_key");
        SetOutput("primary_connection_string");
        SetOutput("secondary_access_key");
        SetOutput("secondary_connection_string");
        SetOutput("id");
        SetOutput("listen");
        SetOutput("manage");
        SetOutput("name");
        SetOutput("namespace_name");
        SetOutput("notification_hub_name");
        SetOutput("resource_group_name");
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
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    public required TerraformProperty<string> NamespaceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("namespace_name");
        set => SetProperty("namespace_name", value);
    }

    /// <summary>
    /// The notification_hub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationHubName is required")]
    public required TerraformProperty<string> NotificationHubName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("notification_hub_name");
        set => SetProperty("notification_hub_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
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
    public AzurermNotificationHubAuthorizationRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
