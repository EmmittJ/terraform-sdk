using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for contact in .
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
    [TerraformArgument("email")]
    public TerraformValue<string>? Email
    {
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformArgument("name")]
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformArgument("url")]
    public TerraformValue<string>? Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

}

/// <summary>
/// Block type for import in .
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
    [TerraformArgument("content_format")]
    public required TerraformValue<string> ContentFormat
    {
        get => new TerraformReference<string>(this, "content_format");
        set => SetArgument("content_format", value);
    }

    /// <summary>
    /// The content_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentValue is required")]
    [TerraformArgument("content_value")]
    public required TerraformValue<string> ContentValue
    {
        get => new TerraformReference<string>(this, "content_value");
        set => SetArgument("content_value", value);
    }

}

/// <summary>
/// Block type for license in .
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
    [TerraformArgument("name")]
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformArgument("url")]
    public TerraformValue<string>? Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

}

/// <summary>
/// Block type for oauth2_authorization in .
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
    [TerraformArgument("authorization_server_name")]
    public required TerraformValue<string> AuthorizationServerName
    {
        get => new TerraformReference<string>(this, "authorization_server_name");
        set => SetArgument("authorization_server_name", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformArgument("scope")]
    public TerraformValue<string>? Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

}

/// <summary>
/// Block type for openid_authentication in .
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
    [TerraformArgument("bearer_token_sending_methods")]
    public TerraformSet<string>? BearerTokenSendingMethods
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "bearer_token_sending_methods").ResolveNodes(ctx));
        set => SetArgument("bearer_token_sending_methods", value);
    }

    /// <summary>
    /// The openid_provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OpenidProviderName is required")]
    [TerraformArgument("openid_provider_name")]
    public required TerraformValue<string> OpenidProviderName
    {
        get => new TerraformReference<string>(this, "openid_provider_name");
        set => SetArgument("openid_provider_name", value);
    }

}

/// <summary>
/// Block type for subscription_key_parameter_names in .
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
    [TerraformArgument("header")]
    public required TerraformValue<string> Header
    {
        get => new TerraformReference<string>(this, "header");
        set => SetArgument("header", value);
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    [TerraformArgument("query")]
    public required TerraformValue<string> Query
    {
        get => new TerraformReference<string>(this, "query");
        set => SetArgument("query", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    [TerraformArgument("api_management_name")]
    public required TerraformValue<string> ApiManagementName
    {
        get => new TerraformReference<string>(this, "api_management_name");
        set => SetArgument("api_management_name", value);
    }

    /// <summary>
    /// The api_type attribute.
    /// </summary>
    [TerraformArgument("api_type")]
    public TerraformValue<string> ApiType
    {
        get => new TerraformReference<string>(this, "api_type");
        set => SetArgument("api_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformArgument("display_name")]
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformArgument("path")]
    public TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [TerraformArgument("protocols")]
    public TerraformSet<string> Protocols
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "protocols").ResolveNodes(ctx));
        set => SetArgument("protocols", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    [TerraformArgument("revision")]
    public required TerraformValue<string> Revision
    {
        get => new TerraformReference<string>(this, "revision");
        set => SetArgument("revision", value);
    }

    /// <summary>
    /// The revision_description attribute.
    /// </summary>
    [TerraformArgument("revision_description")]
    public TerraformValue<string>? RevisionDescription
    {
        get => new TerraformReference<string>(this, "revision_description");
        set => SetArgument("revision_description", value);
    }

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    [TerraformArgument("service_url")]
    public TerraformValue<string> ServiceUrl
    {
        get => new TerraformReference<string>(this, "service_url");
        set => SetArgument("service_url", value);
    }

    /// <summary>
    /// The source_api_id attribute.
    /// </summary>
    [TerraformArgument("source_api_id")]
    public TerraformValue<string>? SourceApiId
    {
        get => new TerraformReference<string>(this, "source_api_id");
        set => SetArgument("source_api_id", value);
    }

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    [TerraformArgument("subscription_required")]
    public TerraformValue<bool>? SubscriptionRequired
    {
        get => new TerraformReference<bool>(this, "subscription_required");
        set => SetArgument("subscription_required", value);
    }

    /// <summary>
    /// The terms_of_service_url attribute.
    /// </summary>
    [TerraformArgument("terms_of_service_url")]
    public TerraformValue<string>? TermsOfServiceUrl
    {
        get => new TerraformReference<string>(this, "terms_of_service_url");
        set => SetArgument("terms_of_service_url", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformArgument("version")]
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    [TerraformArgument("version_description")]
    public TerraformValue<string>? VersionDescription
    {
        get => new TerraformReference<string>(this, "version_description");
        set => SetArgument("version_description", value);
    }

    /// <summary>
    /// The version_set_id attribute.
    /// </summary>
    [TerraformArgument("version_set_id")]
    public TerraformValue<string> VersionSetId
    {
        get => new TerraformReference<string>(this, "version_set_id");
        set => SetArgument("version_set_id", value);
    }

    /// <summary>
    /// Block for contact.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Contact block(s) allowed")]
    [TerraformArgument("contact")]
    public TerraformList<AzurermApiManagementApiContactBlock> Contact { get; set; } = new();

    /// <summary>
    /// Block for import.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Import block(s) allowed")]
    [TerraformArgument("import")]
    public TerraformList<AzurermApiManagementApiImportBlock> Import { get; set; } = new();

    /// <summary>
    /// Block for license.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 License block(s) allowed")]
    [TerraformArgument("license")]
    public TerraformList<AzurermApiManagementApiLicenseBlock> License { get; set; } = new();

    /// <summary>
    /// Block for oauth2_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oauth2Authorization block(s) allowed")]
    [TerraformArgument("oauth2_authorization")]
    public TerraformList<AzurermApiManagementApiOauth2AuthorizationBlock> Oauth2Authorization { get; set; } = new();

    /// <summary>
    /// Block for openid_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenidAuthentication block(s) allowed")]
    [TerraformArgument("openid_authentication")]
    public TerraformList<AzurermApiManagementApiOpenidAuthenticationBlock> OpenidAuthentication { get; set; } = new();

    /// <summary>
    /// Block for subscription_key_parameter_names.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubscriptionKeyParameterNames block(s) allowed")]
    [TerraformArgument("subscription_key_parameter_names")]
    public TerraformList<AzurermApiManagementApiSubscriptionKeyParameterNamesBlock> SubscriptionKeyParameterNames { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermApiManagementApiTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The is_current attribute.
    /// </summary>
    [TerraformArgument("is_current")]
    public TerraformValue<bool> IsCurrent
    {
        get => new TerraformReference<bool>(this, "is_current");
    }

    /// <summary>
    /// The is_online attribute.
    /// </summary>
    [TerraformArgument("is_online")]
    public TerraformValue<bool> IsOnline
    {
        get => new TerraformReference<bool>(this, "is_online");
    }

}
