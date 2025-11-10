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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
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
        SetOutput("api_management_name");
        SetOutput("authorization_endpoint");
        SetOutput("authorization_methods");
        SetOutput("bearer_token_sending_methods");
        SetOutput("client_authentication_method");
        SetOutput("client_id");
        SetOutput("client_registration_endpoint");
        SetOutput("client_secret");
        SetOutput("default_scope");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("grant_types");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("resource_owner_password");
        SetOutput("resource_owner_username");
        SetOutput("support_state");
        SetOutput("token_endpoint");
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformProperty<string> ApiManagementName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_management_name");
        set => SetProperty("api_management_name", value);
    }

    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationEndpoint is required")]
    public required TerraformProperty<string> AuthorizationEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authorization_endpoint");
        set => SetProperty("authorization_endpoint", value);
    }

    /// <summary>
    /// The authorization_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationMethods is required")]
    public HashSet<TerraformProperty<string>> AuthorizationMethods
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("authorization_methods");
        set => SetProperty("authorization_methods", value);
    }

    /// <summary>
    /// The bearer_token_sending_methods attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> BearerTokenSendingMethods
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("bearer_token_sending_methods");
        set => SetProperty("bearer_token_sending_methods", value);
    }

    /// <summary>
    /// The client_authentication_method attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ClientAuthenticationMethod
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("client_authentication_method");
        set => SetProperty("client_authentication_method", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformProperty<string> ClientId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_id");
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The client_registration_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientRegistrationEndpoint is required")]
    public required TerraformProperty<string> ClientRegistrationEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_registration_endpoint");
        set => SetProperty("client_registration_endpoint", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformProperty<string> ClientSecret
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_secret");
        set => SetProperty("client_secret", value);
    }

    /// <summary>
    /// The default_scope attribute.
    /// </summary>
    public TerraformProperty<string> DefaultScope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_scope");
        set => SetProperty("default_scope", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The grant_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrantTypes is required")]
    public HashSet<TerraformProperty<string>> GrantTypes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("grant_types");
        set => SetProperty("grant_types", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The resource_owner_password attribute.
    /// </summary>
    public TerraformProperty<string> ResourceOwnerPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_owner_password");
        set => SetProperty("resource_owner_password", value);
    }

    /// <summary>
    /// The resource_owner_username attribute.
    /// </summary>
    public TerraformProperty<string> ResourceOwnerUsername
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_owner_username");
        set => SetProperty("resource_owner_username", value);
    }

    /// <summary>
    /// The support_state attribute.
    /// </summary>
    public TerraformProperty<bool> SupportState
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("support_state");
        set => SetProperty("support_state", value);
    }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    public TerraformProperty<string> TokenEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("token_endpoint");
        set => SetProperty("token_endpoint", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementAuthorizationServerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for token_body_parameter.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApiManagementAuthorizationServerTokenBodyParameterBlock>? TokenBodyParameter
    {
        set => SetProperty("token_body_parameter", value);
    }

}
