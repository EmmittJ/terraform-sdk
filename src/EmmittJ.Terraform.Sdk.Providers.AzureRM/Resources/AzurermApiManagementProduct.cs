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
    public TerraformProperty<string>? ApiManagementName
    {
        get => GetProperty<TerraformProperty<string>>("api_management_name");
        set => this.WithProperty("api_management_name", value);
    }

    /// <summary>
    /// The approval_required attribute.
    /// </summary>
    public TerraformProperty<bool>? ApprovalRequired
    {
        get => GetProperty<TerraformProperty<bool>>("approval_required");
        set => this.WithProperty("approval_required", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The product_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProductId
    {
        get => GetProperty<TerraformProperty<string>>("product_id");
        set => this.WithProperty("product_id", value);
    }

    /// <summary>
    /// The published attribute.
    /// </summary>
    public TerraformProperty<bool>? Published
    {
        get => GetProperty<TerraformProperty<bool>>("published");
        set => this.WithProperty("published", value);
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
    /// The subscription_required attribute.
    /// </summary>
    public TerraformProperty<bool>? SubscriptionRequired
    {
        get => GetProperty<TerraformProperty<bool>>("subscription_required");
        set => this.WithProperty("subscription_required", value);
    }

    /// <summary>
    /// The subscriptions_limit attribute.
    /// </summary>
    public TerraformProperty<double>? SubscriptionsLimit
    {
        get => GetProperty<TerraformProperty<double>>("subscriptions_limit");
        set => this.WithProperty("subscriptions_limit", value);
    }

    /// <summary>
    /// The terms attribute.
    /// </summary>
    public TerraformProperty<string>? Terms
    {
        get => GetProperty<TerraformProperty<string>>("terms");
        set => this.WithProperty("terms", value);
    }

}
