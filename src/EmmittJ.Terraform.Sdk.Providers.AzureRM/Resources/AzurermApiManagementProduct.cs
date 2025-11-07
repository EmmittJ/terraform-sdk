using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApiManagementName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_name");
        set => this.WithProperty("api_management_name", value);
    }

    /// <summary>
    /// The approval_required attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ApprovalRequired
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("approval_required");
        set => this.WithProperty("approval_required", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProductId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("product_id");
        set => this.WithProperty("product_id", value);
    }

    /// <summary>
    /// The published attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Published
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("published");
        set => this.WithProperty("published", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SubscriptionRequired
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("subscription_required");
        set => this.WithProperty("subscription_required", value);
    }

    /// <summary>
    /// The subscriptions_limit attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? SubscriptionsLimit
    {
        get => GetProperty<TerraformLiteralProperty<double>>("subscriptions_limit");
        set => this.WithProperty("subscriptions_limit", value);
    }

    /// <summary>
    /// The terms attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Terms
    {
        get => GetProperty<TerraformLiteralProperty<string>>("terms");
        set => this.WithProperty("terms", value);
    }

}
