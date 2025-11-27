using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadApplicationDataSource.
/// Nesting mode: single
/// </summary>
public class AzureadApplicationDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azuread_application Terraform data source.
/// Retrieves information about a azuread_application.
/// </summary>
public partial class AzureadApplicationDataSource(string name) : TerraformDataSource("azuread_application", name)
{
    /// <summary>
    /// The Client ID (also called Application ID)
    /// </summary>
    public TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The display name for the application
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// One of the application&#39;s identifier URIs
    /// </summary>
    public TerraformValue<string> IdentifierUri
    {
        get => new TerraformReference<string>(this, "identifier_uri");
        set => SetArgument("identifier_uri", value);
    }

    /// <summary>
    /// The application&#39;s object ID
    /// </summary>
    public TerraformValue<string> ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// The api attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Api
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "api").ResolveNodes(ctx));
    }

    /// <summary>
    /// Mapping of app role names to UUIDs
    /// </summary>
    public TerraformMap<string> AppRoleIds
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "app_role_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// List of app roles published by the application
    /// </summary>
    public TerraformList<TerraformMap<object>> AppRoles
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "app_roles").ResolveNodes(ctx));
    }

    /// <summary>
    /// Description of the application as shown to end users
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// Specifies whether this application supports device authentication without a user.
    /// </summary>
    public TerraformValue<bool> DeviceOnlyAuthEnabled
    {
        get => new TerraformReference<bool>(this, "device_only_auth_enabled");
    }

    /// <summary>
    /// Whether Microsoft has disabled the registered application
    /// </summary>
    public TerraformValue<string> DisabledByMicrosoft
    {
        get => new TerraformReference<string>(this, "disabled_by_microsoft");
    }

    /// <summary>
    /// The fallback application type as public client, such as an installed application running on a mobile device
    /// </summary>
    public TerraformValue<bool> FallbackPublicClientEnabled
    {
        get => new TerraformReference<bool>(this, "fallback_public_client_enabled");
    }

    /// <summary>
    /// Block of features configured for this application using tags
    /// </summary>
    public TerraformList<TerraformMap<object>> FeatureTags
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "feature_tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The `groups` claim issued in a user or OAuth 2.0 access token that the app expects
    /// </summary>
    public TerraformList<string> GroupMembershipClaims
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "group_membership_claims").ResolveNodes(ctx));
    }

    /// <summary>
    /// A list of user-defined URI(s) that uniquely identify a Web application within it&#39;s Azure AD tenant, or within a verified custom domain if the application is multi-tenant
    /// </summary>
    public TerraformList<string> IdentifierUris
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "identifier_uris").ResolveNodes(ctx));
    }

    /// <summary>
    /// CDN URL to the application&#39;s logo
    /// </summary>
    public TerraformValue<string> LogoUrl
    {
        get => new TerraformReference<string>(this, "logo_url");
    }

    /// <summary>
    /// URL of the application&#39;s marketing page
    /// </summary>
    public TerraformValue<string> MarketingUrl
    {
        get => new TerraformReference<string>(this, "marketing_url");
    }

    /// <summary>
    /// User-specified notes relevant for the management of the application
    /// </summary>
    public TerraformValue<string> Notes
    {
        get => new TerraformReference<string>(this, "notes");
    }

    /// <summary>
    /// Mapping of OAuth2.0 permission scope names to UUIDs
    /// </summary>
    public TerraformMap<string> Oauth2PermissionScopeIds
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "oauth2_permission_scope_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// Specifies whether, as part of OAuth 2.0 token requests, Azure AD allows POST requests, as opposed to GET requests.
    /// </summary>
    public TerraformValue<bool> Oauth2PostResponseRequired
    {
        get => new TerraformReference<bool>(this, "oauth2_post_response_required");
    }

    /// <summary>
    /// The optional_claims attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OptionalClaims
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "optional_claims").ResolveNodes(ctx));
    }

    /// <summary>
    /// A list of object IDs of principals that are assigned ownership of the application
    /// </summary>
    public TerraformList<string> Owners
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "owners").ResolveNodes(ctx));
    }

    /// <summary>
    /// URL of the application&#39;s privacy statement
    /// </summary>
    public TerraformValue<string> PrivacyStatementUrl
    {
        get => new TerraformReference<string>(this, "privacy_statement_url");
    }

    /// <summary>
    /// The public_client attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PublicClient
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "public_client").ResolveNodes(ctx));
    }

    /// <summary>
    /// The verified publisher domain for the application
    /// </summary>
    public TerraformValue<string> PublisherDomain
    {
        get => new TerraformReference<string>(this, "publisher_domain");
    }

    /// <summary>
    /// The required_resource_access attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RequiredResourceAccess
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "required_resource_access").ResolveNodes(ctx));
    }

    /// <summary>
    /// References application or service contact information from a Service or Asset Management database
    /// </summary>
    public TerraformValue<string> ServiceManagementReference
    {
        get => new TerraformReference<string>(this, "service_management_reference");
    }

    /// <summary>
    /// The Microsoft account types that are supported for the current application
    /// </summary>
    public TerraformValue<string> SignInAudience
    {
        get => new TerraformReference<string>(this, "sign_in_audience");
    }

    /// <summary>
    /// The single_page_application attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SinglePageApplication
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "single_page_application").ResolveNodes(ctx));
    }

    /// <summary>
    /// URL of the application&#39;s support page
    /// </summary>
    public TerraformValue<string> SupportUrl
    {
        get => new TerraformReference<string>(this, "support_url");
    }

    /// <summary>
    /// A set of tags applied to the application
    /// </summary>
    public TerraformSet<string> Tags
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// URL of the application&#39;s terms of service statement
    /// </summary>
    public TerraformValue<string> TermsOfServiceUrl
    {
        get => new TerraformReference<string>(this, "terms_of_service_url");
    }

    /// <summary>
    /// The web attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Web
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "web").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadApplicationDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadApplicationDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
