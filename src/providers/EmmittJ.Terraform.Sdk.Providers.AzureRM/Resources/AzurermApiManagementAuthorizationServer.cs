using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApiManagementAuthorizationServerTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for token_body_parameter in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementAuthorizationServerTokenBodyParameterBlock() : TerraformBlock("token_body_parameter")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Manages a azurerm_api_management_authorization_server resource.
/// </summary>
public partial class AzurermApiManagementAuthorizationServer : TerraformResource
{
    public AzurermApiManagementAuthorizationServer(string name) : base("azurerm_api_management_authorization_server", name)
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
    /// The authorization_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationEndpoint is required")]
    [TerraformProperty("authorization_endpoint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthorizationEndpoint { get; set; }

    /// <summary>
    /// The authorization_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationMethods is required")]
    [TerraformProperty("authorization_methods")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> AuthorizationMethods { get; set; }

    /// <summary>
    /// The bearer_token_sending_methods attribute.
    /// </summary>
    [TerraformProperty("bearer_token_sending_methods")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? BearerTokenSendingMethods { get; set; }

    /// <summary>
    /// The client_authentication_method attribute.
    /// </summary>
    [TerraformProperty("client_authentication_method")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ClientAuthenticationMethod { get; set; }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformProperty("client_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// The client_registration_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientRegistrationEndpoint is required")]
    [TerraformProperty("client_registration_endpoint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClientRegistrationEndpoint { get; set; }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [TerraformProperty("client_secret")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientSecret { get; set; }

    /// <summary>
    /// The default_scope attribute.
    /// </summary>
    [TerraformProperty("default_scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultScope { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The grant_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrantTypes is required")]
    [TerraformProperty("grant_types")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> GrantTypes { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The resource_owner_password attribute.
    /// </summary>
    [TerraformProperty("resource_owner_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResourceOwnerPassword { get; set; }

    /// <summary>
    /// The resource_owner_username attribute.
    /// </summary>
    [TerraformProperty("resource_owner_username")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResourceOwnerUsername { get; set; }

    /// <summary>
    /// The support_state attribute.
    /// </summary>
    [TerraformProperty("support_state")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SupportState { get; set; }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    [TerraformProperty("token_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TokenEndpoint { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermApiManagementAuthorizationServerTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for token_body_parameter.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("token_body_parameter")]
    public TerraformList<AzurermApiManagementAuthorizationServerTokenBodyParameterBlock> TokenBodyParameter { get; set; } = new();

}
