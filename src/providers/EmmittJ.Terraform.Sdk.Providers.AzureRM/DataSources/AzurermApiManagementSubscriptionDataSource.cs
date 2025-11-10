using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementSubscriptionDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> ApiManagementId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    [TerraformPropertyName("subscription_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubscriptionId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApiManagementSubscriptionDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The allow_tracing attribute.
    /// </summary>
    [TerraformPropertyName("allow_tracing")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AllowTracing => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "allow_tracing");

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [TerraformPropertyName("api_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApiId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "api_id");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_key");

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    [TerraformPropertyName("product_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProductId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "product_id");

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_key");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [TerraformPropertyName("user_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_id");

}
