using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for contact in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiContactBlock : ITerraformBlock
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Email { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Url { get; set; }

}

/// <summary>
/// Block type for import in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiImportBlock : ITerraformBlock
{
    /// <summary>
    /// The content_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentFormat is required")]
    [TerraformPropertyName("content_format")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ContentFormat { get; set; }

    /// <summary>
    /// The content_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentValue is required")]
    [TerraformPropertyName("content_value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ContentValue { get; set; }

}

/// <summary>
/// Block type for license in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiLicenseBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Url { get; set; }

}

/// <summary>
/// Block type for oauth2_authorization in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOauth2AuthorizationBlock : ITerraformBlock
{
    /// <summary>
    /// The authorization_server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationServerName is required")]
    [TerraformPropertyName("authorization_server_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AuthorizationServerName { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformPropertyName("scope")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Scope { get; set; }

}

/// <summary>
/// Block type for openid_authentication in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOpenidAuthenticationBlock : ITerraformBlock
{
    /// <summary>
    /// The bearer_token_sending_methods attribute.
    /// </summary>
    [TerraformPropertyName("bearer_token_sending_methods")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? BearerTokenSendingMethods { get; set; }

    /// <summary>
    /// The openid_provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OpenidProviderName is required")]
    [TerraformPropertyName("openid_provider_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OpenidProviderName { get; set; }

}

/// <summary>
/// Block type for subscription_key_parameter_names in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiSubscriptionKeyParameterNamesBlock : ITerraformBlock
{
    /// <summary>
    /// The header attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Header is required")]
    [TerraformPropertyName("header")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Header { get; set; }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    [TerraformPropertyName("query")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Query { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementApiTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_api_management_api resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermApiManagementApi : TerraformResource
{
    public AzurermApiManagementApi(string name) : base("azurerm_api_management_api", name)
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
    /// The api_type attribute.
    /// </summary>
    [TerraformPropertyName("api_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ApiType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "api_type");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DisplayName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

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
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Path { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "path");

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [TerraformPropertyName("protocols")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> Protocols { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "protocols");

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
    /// The revision_description attribute.
    /// </summary>
    [TerraformPropertyName("revision_description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RevisionDescription { get; set; }

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    [TerraformPropertyName("service_url")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServiceUrl { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_url");

    /// <summary>
    /// The source_api_id attribute.
    /// </summary>
    [TerraformPropertyName("source_api_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceApiId { get; set; }

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    [TerraformPropertyName("subscription_required")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SubscriptionRequired { get; set; }

    /// <summary>
    /// The terms_of_service_url attribute.
    /// </summary>
    [TerraformPropertyName("terms_of_service_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TermsOfServiceUrl { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Version { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    [TerraformPropertyName("version_description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VersionDescription { get; set; }

    /// <summary>
    /// The version_set_id attribute.
    /// </summary>
    [TerraformPropertyName("version_set_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VersionSetId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version_set_id");

    /// <summary>
    /// Block for contact.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Contact block(s) allowed")]
    [TerraformPropertyName("contact")]
    public TerraformList<TerraformBlock<AzurermApiManagementApiContactBlock>>? Contact { get; set; } = new();

    /// <summary>
    /// Block for import.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Import block(s) allowed")]
    [TerraformPropertyName("import")]
    public TerraformList<TerraformBlock<AzurermApiManagementApiImportBlock>>? Import { get; set; } = new();

    /// <summary>
    /// Block for license.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 License block(s) allowed")]
    [TerraformPropertyName("license")]
    public TerraformList<TerraformBlock<AzurermApiManagementApiLicenseBlock>>? License { get; set; } = new();

    /// <summary>
    /// Block for oauth2_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oauth2Authorization block(s) allowed")]
    [TerraformPropertyName("oauth2_authorization")]
    public TerraformList<TerraformBlock<AzurermApiManagementApiOauth2AuthorizationBlock>>? Oauth2Authorization { get; set; } = new();

    /// <summary>
    /// Block for openid_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenidAuthentication block(s) allowed")]
    [TerraformPropertyName("openid_authentication")]
    public TerraformList<TerraformBlock<AzurermApiManagementApiOpenidAuthenticationBlock>>? OpenidAuthentication { get; set; } = new();

    /// <summary>
    /// Block for subscription_key_parameter_names.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubscriptionKeyParameterNames block(s) allowed")]
    [TerraformPropertyName("subscription_key_parameter_names")]
    public TerraformList<TerraformBlock<AzurermApiManagementApiSubscriptionKeyParameterNamesBlock>>? SubscriptionKeyParameterNames { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApiManagementApiTimeoutsBlock>? Timeouts { get; set; } = new();

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

}
