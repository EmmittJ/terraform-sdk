using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementSubscriptionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_api_management_subscription resource.
/// </summary>
public class AzurermApiManagementSubscription : TerraformResource
{
    public AzurermApiManagementSubscription(string name) : base("azurerm_api_management_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("allow_tracing");
        SetOutput("api_id");
        SetOutput("api_management_name");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("primary_key");
        SetOutput("product_id");
        SetOutput("resource_group_name");
        SetOutput("secondary_key");
        SetOutput("state");
        SetOutput("subscription_id");
        SetOutput("user_id");
    }

    /// <summary>
    /// The allow_tracing attribute.
    /// </summary>
    public TerraformProperty<bool> AllowTracing
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_tracing");
        set => SetProperty("allow_tracing", value);
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    public TerraformProperty<string> ApiId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_id");
        set => SetProperty("api_id", value);
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformProperty<string> ApiManagementName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_management_name");
        set => SetProperty("api_management_name", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The primary_key attribute.
    /// </summary>
    public TerraformProperty<string> PrimaryKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("primary_key");
        set => SetProperty("primary_key", value);
    }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    public TerraformProperty<string> ProductId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("product_id");
        set => SetProperty("product_id", value);
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
    /// The secondary_key attribute.
    /// </summary>
    public TerraformProperty<string> SecondaryKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secondary_key");
        set => SetProperty("secondary_key", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string> State
    {
        get => GetRequiredOutput<TerraformProperty<string>>("state");
        set => SetProperty("state", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public TerraformProperty<string> SubscriptionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subscription_id");
        set => SetProperty("subscription_id", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    public TerraformProperty<string> UserId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_id");
        set => SetProperty("user_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementSubscriptionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
