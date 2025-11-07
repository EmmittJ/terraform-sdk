using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformLiteralProperty<string>? ApiManagementName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_name");
        set => this.WithProperty("api_management_name", value);
    }

    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AuthorizationEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorization_endpoint");
        set => this.WithProperty("authorization_endpoint", value);
    }

    /// <summary>
    /// The authorization_methods attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? AuthorizationMethods
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("authorization_methods");
        set => this.WithProperty("authorization_methods", value);
    }

    /// <summary>
    /// The bearer_token_sending_methods attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? BearerTokenSendingMethods
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("bearer_token_sending_methods");
        set => this.WithProperty("bearer_token_sending_methods", value);
    }

    /// <summary>
    /// The client_authentication_method attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? ClientAuthenticationMethod
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("client_authentication_method");
        set => this.WithProperty("client_authentication_method", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_id");
        set => this.WithProperty("client_id", value);
    }

    /// <summary>
    /// The client_registration_endpoint attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClientRegistrationEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_registration_endpoint");
        set => this.WithProperty("client_registration_endpoint", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClientSecret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_secret");
        set => this.WithProperty("client_secret", value);
    }

    /// <summary>
    /// The default_scope attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_scope");
        set => this.WithProperty("default_scope", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The grant_types attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? GrantTypes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("grant_types");
        set => this.WithProperty("grant_types", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The resource_owner_password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceOwnerPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_owner_password");
        set => this.WithProperty("resource_owner_password", value);
    }

    /// <summary>
    /// The resource_owner_username attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceOwnerUsername
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_owner_username");
        set => this.WithProperty("resource_owner_username", value);
    }

    /// <summary>
    /// The support_state attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SupportState
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("support_state");
        set => this.WithProperty("support_state", value);
    }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TokenEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("token_endpoint");
        set => this.WithProperty("token_endpoint", value);
    }

}
