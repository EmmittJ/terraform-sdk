using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApiManagementProductDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_api_management_product.
/// </summary>
public partial class AzurermApiManagementProductDataSource : TerraformDataSource
{
    public AzurermApiManagementProductDataSource(string name) : base("azurerm_api_management_product", name)
    {
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    [TerraformProperty("api_management_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApiManagementName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductId is required")]
    [TerraformProperty("product_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProductId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermApiManagementProductDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The approval_required attribute.
    /// </summary>
    [TerraformProperty("approval_required")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ApprovalRequired { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The published attribute.
    /// </summary>
    [TerraformProperty("published")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Published { get; }

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    [TerraformProperty("subscription_required")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> SubscriptionRequired { get; }

    /// <summary>
    /// The subscriptions_limit attribute.
    /// </summary>
    [TerraformProperty("subscriptions_limit")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> SubscriptionsLimit { get; }

    /// <summary>
    /// The terms attribute.
    /// </summary>
    [TerraformProperty("terms")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Terms { get; }

}
