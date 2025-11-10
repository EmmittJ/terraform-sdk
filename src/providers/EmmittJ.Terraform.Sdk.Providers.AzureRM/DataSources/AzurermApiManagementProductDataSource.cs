using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementProductDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_api_management_product.
/// </summary>
public class AzurermApiManagementProductDataSource : TerraformDataSource
{
    public AzurermApiManagementProductDataSource(string name) : base("azurerm_api_management_product", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("approval_required");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("published");
        SetOutput("subscription_required");
        SetOutput("subscriptions_limit");
        SetOutput("terms");
        SetOutput("api_management_name");
        SetOutput("id");
        SetOutput("product_id");
        SetOutput("resource_group_name");
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementProductDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The approval_required attribute.
    /// </summary>
    public TerraformExpression ApprovalRequired => this["approval_required"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The published attribute.
    /// </summary>
    public TerraformExpression Published => this["published"];

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    public TerraformExpression SubscriptionRequired => this["subscription_required"];

    /// <summary>
    /// The subscriptions_limit attribute.
    /// </summary>
    public TerraformExpression SubscriptionsLimit => this["subscriptions_limit"];

    /// <summary>
    /// The terms attribute.
    /// </summary>
    public TerraformExpression Terms => this["terms"];

}
