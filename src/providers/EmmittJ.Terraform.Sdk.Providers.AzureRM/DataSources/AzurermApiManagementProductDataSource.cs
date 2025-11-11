using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementProductDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_api_management_product.
/// </summary>
public class AzurermApiManagementProductDataSource : TerraformDataSource
{
    public AzurermApiManagementProductDataSource(string name) : base("azurerm_api_management_product", name)
    {
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    [TerraformPropertyName("api_management_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApiManagementName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductId is required")]
    [TerraformPropertyName("product_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ProductId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApiManagementProductDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The approval_required attribute.
    /// </summary>
    [TerraformPropertyName("approval_required")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ApprovalRequired => new TerraformReference(this, "approval_required");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// The published attribute.
    /// </summary>
    [TerraformPropertyName("published")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Published => new TerraformReference(this, "published");

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    [TerraformPropertyName("subscription_required")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SubscriptionRequired => new TerraformReference(this, "subscription_required");

    /// <summary>
    /// The subscriptions_limit attribute.
    /// </summary>
    [TerraformPropertyName("subscriptions_limit")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SubscriptionsLimit => new TerraformReference(this, "subscriptions_limit");

    /// <summary>
    /// The terms attribute.
    /// </summary>
    [TerraformPropertyName("terms")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Terms => new TerraformReference(this, "terms");

}
