using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementAuthorizationServerTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for token_body_parameter in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementAuthorizationServerTokenBodyParameterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Manages a azurerm_api_management_authorization_server resource.
/// </summary>
public class AzurermApiManagementAuthorizationServer : TerraformResource
{
    public AzurermApiManagementAuthorizationServer(string name) : base("azurerm_api_management_authorization_server", name)
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
    /// The authorization_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationEndpoint is required")]
    [TerraformPropertyName("authorization_endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AuthorizationEndpoint { get; set; }

    /// <summary>
    /// The authorization_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationMethods is required")]
    [TerraformPropertyName("authorization_methods")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> AuthorizationMethods { get; set; }

    /// <summary>
    /// The bearer_token_sending_methods attribute.
    /// </summary>
    [TerraformPropertyName("bearer_token_sending_methods")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? BearerTokenSendingMethods { get; set; }

    /// <summary>
    /// The client_authentication_method attribute.
    /// </summary>
    [TerraformPropertyName("client_authentication_method")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ClientAuthenticationMethod { get; set; }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformPropertyName("client_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// The client_registration_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientRegistrationEndpoint is required")]
    [TerraformPropertyName("client_registration_endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClientRegistrationEndpoint { get; set; }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [TerraformPropertyName("client_secret")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClientSecret { get; set; }

    /// <summary>
    /// The default_scope attribute.
    /// </summary>
    [TerraformPropertyName("default_scope")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultScope { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The grant_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrantTypes is required")]
    [TerraformPropertyName("grant_types")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> GrantTypes { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The resource_owner_password attribute.
    /// </summary>
    [TerraformPropertyName("resource_owner_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResourceOwnerPassword { get; set; }

    /// <summary>
    /// The resource_owner_username attribute.
    /// </summary>
    [TerraformPropertyName("resource_owner_username")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResourceOwnerUsername { get; set; }

    /// <summary>
    /// The support_state attribute.
    /// </summary>
    [TerraformPropertyName("support_state")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SupportState { get; set; }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("token_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TokenEndpoint { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApiManagementAuthorizationServerTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for token_body_parameter.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("token_body_parameter")]
    public TerraformList<TerraformBlock<AzurermApiManagementAuthorizationServerTokenBodyParameterBlock>>? TokenBodyParameter { get; set; }

}
