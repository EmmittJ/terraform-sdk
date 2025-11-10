using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for contact in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiContactBlock : TerraformBlock
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformProperty<string>? Email
    {
        get => GetProperty<TerraformProperty<string>>("email");
        set => WithProperty("email", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string>? Url
    {
        get => GetProperty<TerraformProperty<string>>("url");
        set => WithProperty("url", value);
    }

}

/// <summary>
/// Block type for import in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiImportBlock : TerraformBlock
{
    /// <summary>
    /// The content_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentFormat is required")]
    public required TerraformProperty<string> ContentFormat
    {
        get => GetProperty<TerraformProperty<string>>("content_format");
        set => WithProperty("content_format", value);
    }

    /// <summary>
    /// The content_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentValue is required")]
    public required TerraformProperty<string> ContentValue
    {
        get => GetProperty<TerraformProperty<string>>("content_value");
        set => WithProperty("content_value", value);
    }

}

/// <summary>
/// Block type for license in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiLicenseBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string>? Url
    {
        get => GetProperty<TerraformProperty<string>>("url");
        set => WithProperty("url", value);
    }

}

/// <summary>
/// Block type for oauth2_authorization in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOauth2AuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// The authorization_server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationServerName is required")]
    public required TerraformProperty<string> AuthorizationServerName
    {
        get => GetProperty<TerraformProperty<string>>("authorization_server_name");
        set => WithProperty("authorization_server_name", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformProperty<string>? Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
        set => WithProperty("scope", value);
    }

}

/// <summary>
/// Block type for openid_authentication in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOpenidAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// The bearer_token_sending_methods attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? BearerTokenSendingMethods
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("bearer_token_sending_methods");
        set => WithProperty("bearer_token_sending_methods", value);
    }

    /// <summary>
    /// The openid_provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OpenidProviderName is required")]
    public required TerraformProperty<string> OpenidProviderName
    {
        get => GetProperty<TerraformProperty<string>>("openid_provider_name");
        set => WithProperty("openid_provider_name", value);
    }

}

/// <summary>
/// Block type for subscription_key_parameter_names in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiSubscriptionKeyParameterNamesBlock : TerraformBlock
{
    /// <summary>
    /// The header attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Header is required")]
    public required TerraformProperty<string> Header
    {
        get => GetProperty<TerraformProperty<string>>("header");
        set => WithProperty("header", value);
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformProperty<string> Query
    {
        get => GetProperty<TerraformProperty<string>>("query");
        set => WithProperty("query", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementApiTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_api_management_api resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermApiManagementApi : TerraformResource
{
    public AzurermApiManagementApi(string name) : base("azurerm_api_management_api", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("is_current");
        this.DeclareOutput("is_online");
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
    /// The api_type attribute.
    /// </summary>
    public TerraformProperty<string>? ApiType
    {
        get => GetProperty<TerraformProperty<string>>("api_type");
        set => this.WithProperty("api_type", value);
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
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => this.WithProperty("path", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Protocols
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("protocols");
        set => this.WithProperty("protocols", value);
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
    /// The revision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    public required TerraformProperty<string> Revision
    {
        get => GetProperty<TerraformProperty<string>>("revision");
        set => this.WithProperty("revision", value);
    }

    /// <summary>
    /// The revision_description attribute.
    /// </summary>
    public TerraformProperty<string>? RevisionDescription
    {
        get => GetProperty<TerraformProperty<string>>("revision_description");
        set => this.WithProperty("revision_description", value);
    }

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceUrl
    {
        get => GetProperty<TerraformProperty<string>>("service_url");
        set => this.WithProperty("service_url", value);
    }

    /// <summary>
    /// The source_api_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceApiId
    {
        get => GetProperty<TerraformProperty<string>>("source_api_id");
        set => this.WithProperty("source_api_id", value);
    }

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    public TerraformProperty<bool>? SubscriptionRequired
    {
        get => GetProperty<TerraformProperty<bool>>("subscription_required");
        set => this.WithProperty("subscription_required", value);
    }

    /// <summary>
    /// The terms_of_service_url attribute.
    /// </summary>
    public TerraformProperty<string>? TermsOfServiceUrl
    {
        get => GetProperty<TerraformProperty<string>>("terms_of_service_url");
        set => this.WithProperty("terms_of_service_url", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    public TerraformProperty<string>? VersionDescription
    {
        get => GetProperty<TerraformProperty<string>>("version_description");
        set => this.WithProperty("version_description", value);
    }

    /// <summary>
    /// The version_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? VersionSetId
    {
        get => GetProperty<TerraformProperty<string>>("version_set_id");
        set => this.WithProperty("version_set_id", value);
    }

    /// <summary>
    /// Block for contact.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Contact block(s) allowed")]
    public List<AzurermApiManagementApiContactBlock>? Contact
    {
        get => GetProperty<List<AzurermApiManagementApiContactBlock>>("contact");
        set => this.WithProperty("contact", value);
    }

    /// <summary>
    /// Block for import.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Import block(s) allowed")]
    public List<AzurermApiManagementApiImportBlock>? Import
    {
        get => GetProperty<List<AzurermApiManagementApiImportBlock>>("import");
        set => this.WithProperty("import", value);
    }

    /// <summary>
    /// Block for license.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 License block(s) allowed")]
    public List<AzurermApiManagementApiLicenseBlock>? License
    {
        get => GetProperty<List<AzurermApiManagementApiLicenseBlock>>("license");
        set => this.WithProperty("license", value);
    }

    /// <summary>
    /// Block for oauth2_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oauth2Authorization block(s) allowed")]
    public List<AzurermApiManagementApiOauth2AuthorizationBlock>? Oauth2Authorization
    {
        get => GetProperty<List<AzurermApiManagementApiOauth2AuthorizationBlock>>("oauth2_authorization");
        set => this.WithProperty("oauth2_authorization", value);
    }

    /// <summary>
    /// Block for openid_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenidAuthentication block(s) allowed")]
    public List<AzurermApiManagementApiOpenidAuthenticationBlock>? OpenidAuthentication
    {
        get => GetProperty<List<AzurermApiManagementApiOpenidAuthenticationBlock>>("openid_authentication");
        set => this.WithProperty("openid_authentication", value);
    }

    /// <summary>
    /// Block for subscription_key_parameter_names.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubscriptionKeyParameterNames block(s) allowed")]
    public List<AzurermApiManagementApiSubscriptionKeyParameterNamesBlock>? SubscriptionKeyParameterNames
    {
        get => GetProperty<List<AzurermApiManagementApiSubscriptionKeyParameterNamesBlock>>("subscription_key_parameter_names");
        set => this.WithProperty("subscription_key_parameter_names", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementApiTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermApiManagementApiTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The is_current attribute.
    /// </summary>
    public TerraformExpression IsCurrent => this["is_current"];

    /// <summary>
    /// The is_online attribute.
    /// </summary>
    public TerraformExpression IsOnline => this["is_online"];

}
