using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementAuthorizationServerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for token_body_parameter in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementAuthorizationServerTokenBodyParameterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Manages a azurerm_api_management_authorization_server resource.
/// </summary>
public class AzurermApiManagementAuthorizationServer : TerraformResource
{
    public AzurermApiManagementAuthorizationServer(string name) : base("azurerm_api_management_authorization_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformProperty<string> ApiManagementName
    {
        get => GetProperty<TerraformProperty<string>>("api_management_name");
        set => this.WithProperty("api_management_name", value);
    }

    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationEndpoint is required")]
    public required TerraformProperty<string> AuthorizationEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("authorization_endpoint");
        set => this.WithProperty("authorization_endpoint", value);
    }

    /// <summary>
    /// The authorization_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationMethods is required")]
    public HashSet<TerraformProperty<string>>? AuthorizationMethods
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("authorization_methods");
        set => this.WithProperty("authorization_methods", value);
    }

    /// <summary>
    /// The bearer_token_sending_methods attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? BearerTokenSendingMethods
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("bearer_token_sending_methods");
        set => this.WithProperty("bearer_token_sending_methods", value);
    }

    /// <summary>
    /// The client_authentication_method attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ClientAuthenticationMethod
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("client_authentication_method");
        set => this.WithProperty("client_authentication_method", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformProperty<string> ClientId
    {
        get => GetProperty<TerraformProperty<string>>("client_id");
        set => this.WithProperty("client_id", value);
    }

    /// <summary>
    /// The client_registration_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientRegistrationEndpoint is required")]
    public required TerraformProperty<string> ClientRegistrationEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("client_registration_endpoint");
        set => this.WithProperty("client_registration_endpoint", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformProperty<string>? ClientSecret
    {
        get => GetProperty<TerraformProperty<string>>("client_secret");
        set => this.WithProperty("client_secret", value);
    }

    /// <summary>
    /// The default_scope attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultScope
    {
        get => GetProperty<TerraformProperty<string>>("default_scope");
        set => this.WithProperty("default_scope", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The grant_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrantTypes is required")]
    public HashSet<TerraformProperty<string>>? GrantTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("grant_types");
        set => this.WithProperty("grant_types", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The resource_owner_password attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceOwnerPassword
    {
        get => GetProperty<TerraformProperty<string>>("resource_owner_password");
        set => this.WithProperty("resource_owner_password", value);
    }

    /// <summary>
    /// The resource_owner_username attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceOwnerUsername
    {
        get => GetProperty<TerraformProperty<string>>("resource_owner_username");
        set => this.WithProperty("resource_owner_username", value);
    }

    /// <summary>
    /// The support_state attribute.
    /// </summary>
    public TerraformProperty<bool>? SupportState
    {
        get => GetProperty<TerraformProperty<bool>>("support_state");
        set => this.WithProperty("support_state", value);
    }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? TokenEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("token_endpoint");
        set => this.WithProperty("token_endpoint", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementAuthorizationServerTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermApiManagementAuthorizationServerTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for token_body_parameter.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApiManagementAuthorizationServerTokenBodyParameterBlock>? TokenBodyParameter
    {
        get => GetProperty<List<AzurermApiManagementAuthorizationServerTokenBodyParameterBlock>>("token_body_parameter");
        set => this.WithProperty("token_body_parameter", value);
    }

}
