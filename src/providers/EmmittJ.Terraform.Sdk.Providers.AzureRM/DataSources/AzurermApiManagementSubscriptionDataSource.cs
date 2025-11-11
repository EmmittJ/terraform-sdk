using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementSubscriptionDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_api_management_subscription.
/// </summary>
public class AzurermApiManagementSubscriptionDataSource : TerraformDataSource
{
    public AzurermApiManagementSubscriptionDataSource(string name) : base("azurerm_api_management_subscription", name)
    {
    }

    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementId is required")]
    [TerraformPropertyName("api_management_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApiManagementId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    [TerraformPropertyName("subscription_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SubscriptionId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApiManagementSubscriptionDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The allow_tracing attribute.
    /// </summary>
    [TerraformPropertyName("allow_tracing")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AllowTracing => new TerraformReference(this, "allow_tracing");

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [TerraformPropertyName("api_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ApiId => new TerraformReference(this, "api_id");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryKey => new TerraformReference(this, "primary_key");

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    [TerraformPropertyName("product_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProductId => new TerraformReference(this, "product_id");

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryKey => new TerraformReference(this, "secondary_key");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [TerraformPropertyName("user_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserId => new TerraformReference(this, "user_id");

}
