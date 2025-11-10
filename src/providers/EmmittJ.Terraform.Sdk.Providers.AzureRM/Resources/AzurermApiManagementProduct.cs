using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementProductTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_api_management_product resource.
/// </summary>
public class AzurermApiManagementProduct : TerraformResource
{
    public AzurermApiManagementProduct(string name) : base("azurerm_api_management_product", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("api_management_name");
        SetOutput("approval_required");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("product_id");
        SetOutput("published");
        SetOutput("resource_group_name");
        SetOutput("subscription_required");
        SetOutput("subscriptions_limit");
        SetOutput("terms");
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
    /// The approval_required attribute.
    /// </summary>
    public TerraformProperty<bool> ApprovalRequired
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("approval_required");
        set => SetProperty("approval_required", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The product_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductId is required")]
    public required TerraformProperty<string> ProductId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("product_id");
        set => SetProperty("product_id", value);
    }

    /// <summary>
    /// The published attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Published is required")]
    public required TerraformProperty<bool> Published
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("published");
        set => SetProperty("published", value);
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
    /// The subscription_required attribute.
    /// </summary>
    public TerraformProperty<bool> SubscriptionRequired
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("subscription_required");
        set => SetProperty("subscription_required", value);
    }

    /// <summary>
    /// The subscriptions_limit attribute.
    /// </summary>
    public TerraformProperty<double> SubscriptionsLimit
    {
        get => GetRequiredOutput<TerraformProperty<double>>("subscriptions_limit");
        set => SetProperty("subscriptions_limit", value);
    }

    /// <summary>
    /// The terms attribute.
    /// </summary>
    public TerraformProperty<string> Terms
    {
        get => GetRequiredOutput<TerraformProperty<string>>("terms");
        set => SetProperty("terms", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementProductTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
