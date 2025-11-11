using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for contact in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementApiContactBlock : TerraformBlockBase
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Email { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Url { get; set; }

}

/// <summary>
/// Block type for import in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementApiImportBlock : TerraformBlockBase
{
    /// <summary>
    /// The content_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentFormat is required")]
    [TerraformProperty("content_format")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ContentFormat { get; set; }

    /// <summary>
    /// The content_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentValue is required")]
    [TerraformProperty("content_value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ContentValue { get; set; }

}

/// <summary>
/// Block type for license in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementApiLicenseBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Url { get; set; }

}

/// <summary>
/// Block type for oauth2_authorization in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementApiOauth2AuthorizationBlock : TerraformBlockBase
{
    /// <summary>
    /// The authorization_server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationServerName is required")]
    [TerraformProperty("authorization_server_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AuthorizationServerName { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformProperty("scope")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Scope { get; set; }

}

/// <summary>
/// Block type for openid_authentication in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementApiOpenidAuthenticationBlock : TerraformBlockBase
{
    /// <summary>
    /// The bearer_token_sending_methods attribute.
    /// </summary>
    [TerraformProperty("bearer_token_sending_methods")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? BearerTokenSendingMethods { get; set; }

    /// <summary>
    /// The openid_provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OpenidProviderName is required")]
    [TerraformProperty("openid_provider_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OpenidProviderName { get; set; }

}

/// <summary>
/// Block type for subscription_key_parameter_names in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementApiSubscriptionKeyParameterNamesBlock : TerraformBlockBase
{
    /// <summary>
    /// The header attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Header is required")]
    [TerraformProperty("header")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Header { get; set; }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    [TerraformProperty("query")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Query { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApiManagementApiTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_api_management_api resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermApiManagementApi : TerraformResource
{
    public AzurermApiManagementApi(string name) : base("azurerm_api_management_api", name)
    {
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    [TerraformProperty("api_management_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApiManagementName { get; set; }

    /// <summary>
    /// The api_type attribute.
    /// </summary>
    [TerraformProperty("api_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ApiType { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Path { get; set; }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [TerraformProperty("protocols")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> Protocols { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    [TerraformProperty("revision")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Revision { get; set; }

    /// <summary>
    /// The revision_description attribute.
    /// </summary>
    [TerraformProperty("revision_description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RevisionDescription { get; set; }

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    [TerraformProperty("service_url")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ServiceUrl { get; set; }

    /// <summary>
    /// The source_api_id attribute.
    /// </summary>
    [TerraformProperty("source_api_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceApiId { get; set; }

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    [TerraformProperty("subscription_required")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SubscriptionRequired { get; set; }

    /// <summary>
    /// The terms_of_service_url attribute.
    /// </summary>
    [TerraformProperty("terms_of_service_url")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TermsOfServiceUrl { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Version { get; set; }

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    [TerraformProperty("version_description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VersionDescription { get; set; }

    /// <summary>
    /// The version_set_id attribute.
    /// </summary>
    [TerraformProperty("version_set_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> VersionSetId { get; set; }

    /// <summary>
    /// Block for contact.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Contact block(s) allowed")]
    [TerraformProperty("contact")]
    public TerraformList<TerraformBlock<AzurermApiManagementApiContactBlock>>? Contact { get; set; }

    /// <summary>
    /// Block for import.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Import block(s) allowed")]
    [TerraformProperty("import")]
    public TerraformList<TerraformBlock<AzurermApiManagementApiImportBlock>>? Import { get; set; }

    /// <summary>
    /// Block for license.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 License block(s) allowed")]
    [TerraformProperty("license")]
    public TerraformList<TerraformBlock<AzurermApiManagementApiLicenseBlock>>? License { get; set; }

    /// <summary>
    /// Block for oauth2_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oauth2Authorization block(s) allowed")]
    [TerraformProperty("oauth2_authorization")]
    public TerraformList<TerraformBlock<AzurermApiManagementApiOauth2AuthorizationBlock>>? Oauth2Authorization { get; set; }

    /// <summary>
    /// Block for openid_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenidAuthentication block(s) allowed")]
    [TerraformProperty("openid_authentication")]
    public TerraformList<TerraformBlock<AzurermApiManagementApiOpenidAuthenticationBlock>>? OpenidAuthentication { get; set; }

    /// <summary>
    /// Block for subscription_key_parameter_names.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubscriptionKeyParameterNames block(s) allowed")]
    [TerraformProperty("subscription_key_parameter_names")]
    public TerraformList<TerraformBlock<AzurermApiManagementApiSubscriptionKeyParameterNamesBlock>>? SubscriptionKeyParameterNames { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermApiManagementApiTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The is_current attribute.
    /// </summary>
    [TerraformProperty("is_current")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> IsCurrent { get; }

    /// <summary>
    /// The is_online attribute.
    /// </summary>
    [TerraformProperty("is_online")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> IsOnline { get; }

}
