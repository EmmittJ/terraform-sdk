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
    public string? ApiManagementName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_name")?.Value;
        set => this.WithProperty("api_management_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    public string? AuthorizationEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorization_endpoint")?.Value;
        set => this.WithProperty("authorization_endpoint", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The authorization_methods attribute.
    /// </summary>
    public HashSet<string>? AuthorizationMethods
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("authorization_methods")?.Value;
        set => this.WithProperty("authorization_methods", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The bearer_token_sending_methods attribute.
    /// </summary>
    public HashSet<string>? BearerTokenSendingMethods
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("bearer_token_sending_methods")?.Value;
        set => this.WithProperty("bearer_token_sending_methods", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The client_authentication_method attribute.
    /// </summary>
    public HashSet<string>? ClientAuthenticationMethod
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("client_authentication_method")?.Value;
        set => this.WithProperty("client_authentication_method", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public string? ClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_id")?.Value;
        set => this.WithProperty("client_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The client_registration_endpoint attribute.
    /// </summary>
    public string? ClientRegistrationEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_registration_endpoint")?.Value;
        set => this.WithProperty("client_registration_endpoint", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public string? ClientSecret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_secret")?.Value;
        set => this.WithProperty("client_secret", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_scope attribute.
    /// </summary>
    public string? DefaultScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_scope")?.Value;
        set => this.WithProperty("default_scope", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The grant_types attribute.
    /// </summary>
    public HashSet<string>? GrantTypes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("grant_types")?.Value;
        set => this.WithProperty("grant_types", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_owner_password attribute.
    /// </summary>
    public string? ResourceOwnerPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_owner_password")?.Value;
        set => this.WithProperty("resource_owner_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_owner_username attribute.
    /// </summary>
    public string? ResourceOwnerUsername
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_owner_username")?.Value;
        set => this.WithProperty("resource_owner_username", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The support_state attribute.
    /// </summary>
    public bool? SupportState
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("support_state")?.Value;
        set => this.WithProperty("support_state", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    public string? TokenEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("token_endpoint")?.Value;
        set => this.WithProperty("token_endpoint", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
