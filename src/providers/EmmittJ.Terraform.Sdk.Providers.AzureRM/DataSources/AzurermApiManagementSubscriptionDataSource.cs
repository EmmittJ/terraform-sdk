using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApiManagementSubscriptionDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_api_management_subscription.
/// </summary>
public partial class AzurermApiManagementSubscriptionDataSource : TerraformDataSource
{
    public AzurermApiManagementSubscriptionDataSource(string name) : base("azurerm_api_management_subscription", name)
    {
    }

    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementId is required")]
    [TerraformProperty("api_management_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApiManagementId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    [TerraformProperty("subscription_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SubscriptionId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermApiManagementSubscriptionDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The allow_tracing attribute.
    /// </summary>
    [TerraformProperty("allow_tracing")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AllowTracing { get; }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [TerraformProperty("api_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ApiId { get; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformProperty("primary_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryKey { get; }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    [TerraformProperty("product_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ProductId { get; }

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    [TerraformProperty("secondary_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryKey { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [TerraformProperty("user_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UserId { get; }

}
