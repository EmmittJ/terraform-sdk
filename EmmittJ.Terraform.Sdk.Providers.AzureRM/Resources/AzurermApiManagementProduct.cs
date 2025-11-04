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
    public string? ApiManagementName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_name")?.Value;
        set => this.WithProperty("api_management_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The approval_required attribute.
    /// </summary>
    public bool? ApprovalRequired
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("approval_required")?.Value;
        set => this.WithProperty("approval_required", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The product_id attribute.
    /// </summary>
    public string? ProductId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("product_id")?.Value;
        set => this.WithProperty("product_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The published attribute.
    /// </summary>
    public bool? Published
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("published")?.Value;
        set => this.WithProperty("published", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The subscription_required attribute.
    /// </summary>
    public bool? SubscriptionRequired
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("subscription_required")?.Value;
        set => this.WithProperty("subscription_required", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The subscriptions_limit attribute.
    /// </summary>
    public double? SubscriptionsLimit
    {
        get => GetProperty<TerraformLiteralProperty<double>>("subscriptions_limit")?.Value;
        set => this.WithProperty("subscriptions_limit", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The terms attribute.
    /// </summary>
    public string? Terms
    {
        get => GetProperty<TerraformLiteralProperty<string>>("terms")?.Value;
        set => this.WithProperty("terms", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
