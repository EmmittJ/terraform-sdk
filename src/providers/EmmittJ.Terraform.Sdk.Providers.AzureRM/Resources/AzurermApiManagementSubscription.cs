using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementSubscriptionTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_api_management_subscription resource.
/// </summary>
public class AzurermApiManagementSubscription : TerraformResource
{
    public AzurermApiManagementSubscription(string name) : base("azurerm_api_management_subscription", name)
    {
    }

    /// <summary>
    /// The allow_tracing attribute.
    /// </summary>
    [TerraformPropertyName("allow_tracing")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowTracing { get; set; }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [TerraformPropertyName("api_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApiId { get; set; }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    [TerraformPropertyName("api_management_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApiManagementName { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_key")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PrimaryKey { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_key");

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    [TerraformPropertyName("product_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProductId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_key")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SecondaryKey { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_key");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? State { get; set; }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [TerraformPropertyName("subscription_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SubscriptionId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subscription_id");

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [TerraformPropertyName("user_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApiManagementSubscriptionTimeoutsBlock>? Timeouts { get; set; } = new();

}
