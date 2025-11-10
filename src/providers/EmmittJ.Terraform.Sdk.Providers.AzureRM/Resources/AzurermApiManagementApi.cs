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
        set => SetProperty("email", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string>? Url
    {
        set => SetProperty("url", value);
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
        set => SetProperty("content_format", value);
    }

    /// <summary>
    /// The content_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentValue is required")]
    public required TerraformProperty<string> ContentValue
    {
        set => SetProperty("content_value", value);
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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string>? Url
    {
        set => SetProperty("url", value);
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
        set => SetProperty("authorization_server_name", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformProperty<string>? Scope
    {
        set => SetProperty("scope", value);
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
        set => SetProperty("bearer_token_sending_methods", value);
    }

    /// <summary>
    /// The openid_provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OpenidProviderName is required")]
    public required TerraformProperty<string> OpenidProviderName
    {
        set => SetProperty("openid_provider_name", value);
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
        set => SetProperty("header", value);
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformProperty<string> Query
    {
        set => SetProperty("query", value);
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
        SetOutput("is_current");
        SetOutput("is_online");
        SetOutput("api_management_name");
        SetOutput("api_type");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("name");
        SetOutput("path");
        SetOutput("protocols");
        SetOutput("resource_group_name");
        SetOutput("revision");
        SetOutput("revision_description");
        SetOutput("service_url");
        SetOutput("source_api_id");
        SetOutput("subscription_required");
        SetOutput("terms_of_service_url");
        SetOutput("version");
        SetOutput("version_description");
        SetOutput("version_set_id");
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
    /// The api_type attribute.
    /// </summary>
    public TerraformProperty<string> ApiType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_type");
        set => SetProperty("api_type", value);
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
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string> Path
    {
        get => GetRequiredOutput<TerraformProperty<string>>("path");
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Protocols
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("protocols");
        set => SetProperty("protocols", value);
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
    /// The revision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    public required TerraformProperty<string> Revision
    {
        get => GetRequiredOutput<TerraformProperty<string>>("revision");
        set => SetProperty("revision", value);
    }

    /// <summary>
    /// The revision_description attribute.
    /// </summary>
    public TerraformProperty<string> RevisionDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("revision_description");
        set => SetProperty("revision_description", value);
    }

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    public TerraformProperty<string> ServiceUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_url");
        set => SetProperty("service_url", value);
    }

    /// <summary>
    /// The source_api_id attribute.
    /// </summary>
    public TerraformProperty<string> SourceApiId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_api_id");
        set => SetProperty("source_api_id", value);
    }

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    public TerraformProperty<bool> SubscriptionRequired
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("subscription_required");
        set => SetProperty("subscription_required", value);
    }

    /// <summary>
    /// The terms_of_service_url attribute.
    /// </summary>
    public TerraformProperty<string> TermsOfServiceUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("terms_of_service_url");
        set => SetProperty("terms_of_service_url", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    public TerraformProperty<string> VersionDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version_description");
        set => SetProperty("version_description", value);
    }

    /// <summary>
    /// The version_set_id attribute.
    /// </summary>
    public TerraformProperty<string> VersionSetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version_set_id");
        set => SetProperty("version_set_id", value);
    }

    /// <summary>
    /// Block for contact.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Contact block(s) allowed")]
    public List<AzurermApiManagementApiContactBlock>? Contact
    {
        set => SetProperty("contact", value);
    }

    /// <summary>
    /// Block for import.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Import block(s) allowed")]
    public List<AzurermApiManagementApiImportBlock>? Import
    {
        set => SetProperty("import", value);
    }

    /// <summary>
    /// Block for license.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 License block(s) allowed")]
    public List<AzurermApiManagementApiLicenseBlock>? License
    {
        set => SetProperty("license", value);
    }

    /// <summary>
    /// Block for oauth2_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oauth2Authorization block(s) allowed")]
    public List<AzurermApiManagementApiOauth2AuthorizationBlock>? Oauth2Authorization
    {
        set => SetProperty("oauth2_authorization", value);
    }

    /// <summary>
    /// Block for openid_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenidAuthentication block(s) allowed")]
    public List<AzurermApiManagementApiOpenidAuthenticationBlock>? OpenidAuthentication
    {
        set => SetProperty("openid_authentication", value);
    }

    /// <summary>
    /// Block for subscription_key_parameter_names.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubscriptionKeyParameterNames block(s) allowed")]
    public List<AzurermApiManagementApiSubscriptionKeyParameterNamesBlock>? SubscriptionKeyParameterNames
    {
        set => SetProperty("subscription_key_parameter_names", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementApiTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
