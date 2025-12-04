using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApiManagementAuthorizationServer.
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementAuthorizationServerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for token_body_parameter in AzurermApiManagementAuthorizationServer.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementAuthorizationServerTokenBodyParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "token_body_parameter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a azurerm_api_management_authorization_server Terraform resource.
/// Manages a azurerm_api_management_authorization_server resource.
/// </summary>
public partial class AzurermApiManagementAuthorizationServer(string name) : TerraformResource("azurerm_api_management_authorization_server", name)
{
    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformValue<string> ApiManagementName
    {
        get => GetRequiredArgument<TerraformValue<string>>("api_management_name");
        set => SetArgument("api_management_name", value);
    }

    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationEndpoint is required")]
    public required TerraformValue<string> AuthorizationEndpoint
    {
        get => GetRequiredArgument<TerraformValue<string>>("authorization_endpoint");
        set => SetArgument("authorization_endpoint", value);
    }

    /// <summary>
    /// The authorization_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationMethods is required")]
    public required TerraformSet<string> AuthorizationMethods
    {
        get => GetRequiredArgument<TerraformSet<string>>("authorization_methods");
        set => SetArgument("authorization_methods", value);
    }

    /// <summary>
    /// The bearer_token_sending_methods attribute.
    /// </summary>
    public TerraformSet<string>? BearerTokenSendingMethods
    {
        get => GetArgument<TerraformSet<string>>("bearer_token_sending_methods");
        set => SetArgument("bearer_token_sending_methods", value);
    }

    /// <summary>
    /// The client_authentication_method attribute.
    /// </summary>
    public TerraformSet<string>? ClientAuthenticationMethod
    {
        get => GetArgument<TerraformSet<string>>("client_authentication_method");
        set => SetArgument("client_authentication_method", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_registration_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientRegistrationEndpoint is required")]
    public required TerraformValue<string> ClientRegistrationEndpoint
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_registration_endpoint");
        set => SetArgument("client_registration_endpoint", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The default_scope attribute.
    /// </summary>
    public TerraformValue<string>? DefaultScope
    {
        get => GetArgument<TerraformValue<string>>("default_scope");
        set => SetArgument("default_scope", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The grant_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrantTypes is required")]
    public required TerraformSet<string> GrantTypes
    {
        get => GetRequiredArgument<TerraformSet<string>>("grant_types");
        set => SetArgument("grant_types", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The resource_owner_password attribute.
    /// </summary>
    public TerraformValue<string>? ResourceOwnerPassword
    {
        get => GetArgument<TerraformValue<string>>("resource_owner_password");
        set => SetArgument("resource_owner_password", value);
    }

    /// <summary>
    /// The resource_owner_username attribute.
    /// </summary>
    public TerraformValue<string>? ResourceOwnerUsername
    {
        get => GetArgument<TerraformValue<string>>("resource_owner_username");
        set => SetArgument("resource_owner_username", value);
    }

    /// <summary>
    /// The support_state attribute.
    /// </summary>
    public TerraformValue<bool>? SupportState
    {
        get => GetArgument<TerraformValue<bool>>("support_state");
        set => SetArgument("support_state", value);
    }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? TokenEndpoint
    {
        get => GetArgument<TerraformValue<string>>("token_endpoint");
        set => SetArgument("token_endpoint", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementAuthorizationServerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementAuthorizationServerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TokenBodyParameter block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementAuthorizationServerTokenBodyParameterBlock>? TokenBodyParameter
    {
        get => GetArgument<TerraformList<AzurermApiManagementAuthorizationServerTokenBodyParameterBlock>>("token_body_parameter");
        set => SetArgument("token_body_parameter", value);
    }

}
