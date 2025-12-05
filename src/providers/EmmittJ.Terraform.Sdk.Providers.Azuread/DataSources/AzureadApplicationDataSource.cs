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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("client_id") ?? CreateReference("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The display name for the application
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name") ?? CreateReference("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// One of the application&#39;s identifier URIs
    /// </summary>
    public TerraformValue<string> IdentifierUri
    {
        get => GetArgument<TerraformValue<string>>("identifier_uri") ?? CreateReference("identifier_uri");
        set => SetArgument("identifier_uri", value);
    }

    /// <summary>
    /// The application&#39;s object ID
    /// </summary>
    public TerraformValue<string> ObjectId
    {
        get => GetArgument<TerraformValue<string>>("object_id") ?? CreateReference("object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// The api attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Api
        => CreateReference("api");

    /// <summary>
    /// Mapping of app role names to UUIDs
    /// </summary>
    public TerraformMap<string> AppRoleIds
        => CreateReference("app_role_ids");

    /// <summary>
    /// List of app roles published by the application
    /// </summary>
    public TerraformList<TerraformMap<object>> AppRoles
        => CreateReference("app_roles");

    /// <summary>
    /// Description of the application as shown to end users
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// Specifies whether this application supports device authentication without a user.
    /// </summary>
    public TerraformValue<bool> DeviceOnlyAuthEnabled
        => CreateReference("device_only_auth_enabled");

    /// <summary>
    /// Whether Microsoft has disabled the registered application
    /// </summary>
    public TerraformValue<string> DisabledByMicrosoft
        => CreateReference("disabled_by_microsoft");

    /// <summary>
    /// The fallback application type as public client, such as an installed application running on a mobile device
    /// </summary>
    public TerraformValue<bool> FallbackPublicClientEnabled
        => CreateReference("fallback_public_client_enabled");

    /// <summary>
    /// Block of features configured for this application using tags
    /// </summary>
    public TerraformList<TerraformMap<object>> FeatureTags
        => CreateReference("feature_tags");

    /// <summary>
    /// The `groups` claim issued in a user or OAuth 2.0 access token that the app expects
    /// </summary>
    public TerraformList<string> GroupMembershipClaims
        => CreateReference("group_membership_claims");

    /// <summary>
    /// A list of user-defined URI(s) that uniquely identify a Web application within it&#39;s Azure AD tenant, or within a verified custom domain if the application is multi-tenant
    /// </summary>
    public TerraformList<string> IdentifierUris
        => CreateReference("identifier_uris");

    /// <summary>
    /// CDN URL to the application&#39;s logo
    /// </summary>
    public TerraformValue<string> LogoUrl
        => CreateReference("logo_url");

    /// <summary>
    /// URL of the application&#39;s marketing page
    /// </summary>
    public TerraformValue<string> MarketingUrl
        => CreateReference("marketing_url");

    /// <summary>
    /// User-specified notes relevant for the management of the application
    /// </summary>
    public TerraformValue<string> Notes
        => CreateReference("notes");

    /// <summary>
    /// Mapping of OAuth2.0 permission scope names to UUIDs
    /// </summary>
    public TerraformMap<string> Oauth2PermissionScopeIds
        => CreateReference("oauth2_permission_scope_ids");

    /// <summary>
    /// Specifies whether, as part of OAuth 2.0 token requests, Azure AD allows POST requests, as opposed to GET requests.
    /// </summary>
    public TerraformValue<bool> Oauth2PostResponseRequired
        => CreateReference("oauth2_post_response_required");

    /// <summary>
    /// The optional_claims attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OptionalClaims
        => CreateReference("optional_claims");

    /// <summary>
    /// A list of object IDs of principals that are assigned ownership of the application
    /// </summary>
    public TerraformList<string> Owners
        => CreateReference("owners");

    /// <summary>
    /// URL of the application&#39;s privacy statement
    /// </summary>
    public TerraformValue<string> PrivacyStatementUrl
        => CreateReference("privacy_statement_url");

    /// <summary>
    /// The public_client attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PublicClient
        => CreateReference("public_client");

    /// <summary>
    /// The verified publisher domain for the application
    /// </summary>
    public TerraformValue<string> PublisherDomain
        => CreateReference("publisher_domain");

    /// <summary>
    /// The required_resource_access attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RequiredResourceAccess
        => CreateReference("required_resource_access");

    /// <summary>
    /// References application or service contact information from a Service or Asset Management database
    /// </summary>
    public TerraformValue<string> ServiceManagementReference
        => CreateReference("service_management_reference");

    /// <summary>
    /// The Microsoft account types that are supported for the current application
    /// </summary>
    public TerraformValue<string> SignInAudience
        => CreateReference("sign_in_audience");

    /// <summary>
    /// The single_page_application attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SinglePageApplication
        => CreateReference("single_page_application");

    /// <summary>
    /// URL of the application&#39;s support page
    /// </summary>
    public TerraformValue<string> SupportUrl
        => CreateReference("support_url");

    /// <summary>
    /// A set of tags applied to the application
    /// </summary>
    public TerraformSet<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// URL of the application&#39;s terms of service statement
    /// </summary>
    public TerraformValue<string> TermsOfServiceUrl
        => CreateReference("terms_of_service_url");

    /// <summary>
    /// The web attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Web
        => CreateReference("web");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadApplicationDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadApplicationDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
