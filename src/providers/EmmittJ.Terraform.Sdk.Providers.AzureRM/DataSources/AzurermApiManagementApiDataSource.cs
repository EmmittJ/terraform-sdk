using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementApiDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_api_management_api.
/// </summary>
public class AzurermApiManagementApiDataSource : TerraformDataSource
{
    public AzurermApiManagementApiDataSource(string name) : base("azurerm_api_management_api", name)
    {
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    [TerraformPropertyName("api_management_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApiManagementName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    [TerraformPropertyName("revision")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Revision { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApiManagementApiDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The is_current attribute.
    /// </summary>
    [TerraformPropertyName("is_current")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IsCurrent => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_current");

    /// <summary>
    /// The is_online attribute.
    /// </summary>
    [TerraformPropertyName("is_online")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IsOnline => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_online");

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Path => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "path");

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [TerraformPropertyName("protocols")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Protocols => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "protocols");

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    [TerraformPropertyName("service_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_url");

    /// <summary>
    /// The soap_pass_through attribute.
    /// </summary>
    [TerraformPropertyName("soap_pass_through")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> SoapPassThrough => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "soap_pass_through");

    /// <summary>
    /// The subscription_key_parameter_names attribute.
    /// </summary>
    [TerraformPropertyName("subscription_key_parameter_names")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SubscriptionKeyParameterNames => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "subscription_key_parameter_names");

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    [TerraformPropertyName("subscription_required")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> SubscriptionRequired => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "subscription_required");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

    /// <summary>
    /// The version_set_id attribute.
    /// </summary>
    [TerraformPropertyName("version_set_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VersionSetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version_set_id");

}
