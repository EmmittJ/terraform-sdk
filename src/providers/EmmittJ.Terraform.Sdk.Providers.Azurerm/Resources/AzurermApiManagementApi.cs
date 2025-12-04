using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for contact in AzurermApiManagementApi.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiContactBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "contact";

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string>? Email
    {
        get => GetArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string>? Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}


/// <summary>
/// Block type for import in AzurermApiManagementApi.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiImportBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "import";

    /// <summary>
    /// The content_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentFormat is required")]
    public required TerraformValue<string> ContentFormat
    {
        get => GetArgument<TerraformValue<string>>("content_format");
        set => SetArgument("content_format", value);
    }

    /// <summary>
    /// The content_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentValue is required")]
    public required TerraformValue<string> ContentValue
    {
        get => GetArgument<TerraformValue<string>>("content_value");
        set => SetArgument("content_value", value);
    }

    /// <summary>
    /// WsdlSelector block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WsdlSelector block(s) allowed")]
    public TerraformList<AzurermApiManagementApiImportBlockWsdlSelectorBlock>? WsdlSelector
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiImportBlockWsdlSelectorBlock>>("wsdl_selector");
        set => SetArgument("wsdl_selector", value);
    }

}

/// <summary>
/// Block type for wsdl_selector in AzurermApiManagementApiImportBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiImportBlockWsdlSelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "wsdl_selector";

    /// <summary>
    /// The endpoint_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointName is required")]
    public required TerraformValue<string> EndpointName
    {
        get => GetArgument<TerraformValue<string>>("endpoint_name");
        set => SetArgument("endpoint_name", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformValue<string> ServiceName
    {
        get => GetArgument<TerraformValue<string>>("service_name");
        set => SetArgument("service_name", value);
    }

}


/// <summary>
/// Block type for license in AzurermApiManagementApi.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiLicenseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "license";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string>? Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}


/// <summary>
/// Block type for oauth2_authorization in AzurermApiManagementApi.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOauth2AuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth2_authorization";

    /// <summary>
    /// The authorization_server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationServerName is required")]
    public required TerraformValue<string> AuthorizationServerName
    {
        get => GetArgument<TerraformValue<string>>("authorization_server_name");
        set => SetArgument("authorization_server_name", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => GetArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

}


/// <summary>
/// Block type for openid_authentication in AzurermApiManagementApi.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOpenidAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "openid_authentication";

    /// <summary>
    /// The bearer_token_sending_methods attribute.
    /// </summary>
    public TerraformSet<string>? BearerTokenSendingMethods
    {
        get => GetArgument<TerraformSet<string>>("bearer_token_sending_methods");
        set => SetArgument("bearer_token_sending_methods", value);
    }

    /// <summary>
    /// The openid_provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OpenidProviderName is required")]
    public required TerraformValue<string> OpenidProviderName
    {
        get => GetArgument<TerraformValue<string>>("openid_provider_name");
        set => SetArgument("openid_provider_name", value);
    }

}


/// <summary>
/// Block type for subscription_key_parameter_names in AzurermApiManagementApi.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiSubscriptionKeyParameterNamesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subscription_key_parameter_names";

    /// <summary>
    /// The header attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Header is required")]
    public required TerraformValue<string> Header
    {
        get => GetArgument<TerraformValue<string>>("header");
        set => SetArgument("header", value);
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformValue<string> Query
    {
        get => GetArgument<TerraformValue<string>>("query");
        set => SetArgument("query", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermApiManagementApi.
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementApiTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_api_management_api Terraform resource.
/// Manages a azurerm_api_management_api resource.
/// </summary>
public partial class AzurermApiManagementApi(string name) : TerraformResource("azurerm_api_management_api", name)
{
    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformValue<string> ApiManagementName
    {
        get => GetArgument<TerraformValue<string>>("api_management_name");
        set => SetArgument("api_management_name", value);
    }

    /// <summary>
    /// The api_type attribute.
    /// </summary>
    public TerraformValue<string>? ApiType
    {
        get => GetArgument<TerraformValue<string>>("api_type");
        set => SetArgument("api_type", value);
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
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformSet<string>? Protocols
    {
        get => GetArgument<TerraformSet<string>>("protocols");
        set => SetArgument("protocols", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    public required TerraformValue<string> Revision
    {
        get => GetArgument<TerraformValue<string>>("revision");
        set => SetArgument("revision", value);
    }

    /// <summary>
    /// The revision_description attribute.
    /// </summary>
    public TerraformValue<string>? RevisionDescription
    {
        get => GetArgument<TerraformValue<string>>("revision_description");
        set => SetArgument("revision_description", value);
    }

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    public TerraformValue<string>? ServiceUrl
    {
        get => GetArgument<TerraformValue<string>>("service_url");
        set => SetArgument("service_url", value);
    }

    /// <summary>
    /// The source_api_id attribute.
    /// </summary>
    public TerraformValue<string>? SourceApiId
    {
        get => GetArgument<TerraformValue<string>>("source_api_id");
        set => SetArgument("source_api_id", value);
    }

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    public TerraformValue<bool>? SubscriptionRequired
    {
        get => GetArgument<TerraformValue<bool>>("subscription_required");
        set => SetArgument("subscription_required", value);
    }

    /// <summary>
    /// The terms_of_service_url attribute.
    /// </summary>
    public TerraformValue<string>? TermsOfServiceUrl
    {
        get => GetArgument<TerraformValue<string>>("terms_of_service_url");
        set => SetArgument("terms_of_service_url", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    public TerraformValue<string>? VersionDescription
    {
        get => GetArgument<TerraformValue<string>>("version_description");
        set => SetArgument("version_description", value);
    }

    /// <summary>
    /// The version_set_id attribute.
    /// </summary>
    public TerraformValue<string>? VersionSetId
    {
        get => GetArgument<TerraformValue<string>>("version_set_id");
        set => SetArgument("version_set_id", value);
    }

    /// <summary>
    /// The is_current attribute.
    /// </summary>
    public TerraformValue<bool> IsCurrent
        => AsReference("is_current");

    /// <summary>
    /// The is_online attribute.
    /// </summary>
    public TerraformValue<bool> IsOnline
        => AsReference("is_online");

    /// <summary>
    /// Contact block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Contact block(s) allowed")]
    public TerraformList<AzurermApiManagementApiContactBlock>? Contact
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiContactBlock>>("contact");
        set => SetArgument("contact", value);
    }

    /// <summary>
    /// Import block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Import block(s) allowed")]
    public TerraformList<AzurermApiManagementApiImportBlock>? Import
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiImportBlock>>("import");
        set => SetArgument("import", value);
    }

    /// <summary>
    /// License block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 License block(s) allowed")]
    public TerraformList<AzurermApiManagementApiLicenseBlock>? License
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiLicenseBlock>>("license");
        set => SetArgument("license", value);
    }

    /// <summary>
    /// Oauth2Authorization block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oauth2Authorization block(s) allowed")]
    public TerraformList<AzurermApiManagementApiOauth2AuthorizationBlock>? Oauth2Authorization
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiOauth2AuthorizationBlock>>("oauth2_authorization");
        set => SetArgument("oauth2_authorization", value);
    }

    /// <summary>
    /// OpenidAuthentication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenidAuthentication block(s) allowed")]
    public TerraformList<AzurermApiManagementApiOpenidAuthenticationBlock>? OpenidAuthentication
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiOpenidAuthenticationBlock>>("openid_authentication");
        set => SetArgument("openid_authentication", value);
    }

    /// <summary>
    /// SubscriptionKeyParameterNames block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubscriptionKeyParameterNames block(s) allowed")]
    public TerraformList<AzurermApiManagementApiSubscriptionKeyParameterNamesBlock>? SubscriptionKeyParameterNames
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiSubscriptionKeyParameterNamesBlock>>("subscription_key_parameter_names");
        set => SetArgument("subscription_key_parameter_names", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementApiTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementApiTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
