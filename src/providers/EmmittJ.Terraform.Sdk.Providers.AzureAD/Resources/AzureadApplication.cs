using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for api in .
/// Nesting mode: list
/// </summary>
public class AzureadApplicationApiBlock : TerraformBlock
{
    /// <summary>
    /// Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app
    /// </summary>
    public HashSet<TerraformProperty<string>>? KnownClientApplications
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("known_client_applications");
        set => WithProperty("known_client_applications", value);
    }

    /// <summary>
    /// Allows an application to use claims mapping without specifying a custom signing key
    /// </summary>
    public TerraformProperty<bool>? MappedClaimsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("mapped_claims_enabled");
        set => WithProperty("mapped_claims_enabled", value);
    }

    /// <summary>
    /// The access token version expected by this resource
    /// </summary>
    public TerraformProperty<double>? RequestedAccessTokenVersion
    {
        get => GetProperty<TerraformProperty<double>>("requested_access_token_version");
        set => WithProperty("requested_access_token_version", value);
    }

}

/// <summary>
/// Block type for app_role in .
/// Nesting mode: set
/// </summary>
public class AzureadApplicationAppRoleBlock : TerraformBlock
{
    /// <summary>
    /// Specifies whether this app role definition can be assigned to users and groups by setting to `User`, or to other applications (that are accessing this application in a standalone scenario) by setting to `Application`, or to both
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMemberTypes is required")]
    public HashSet<TerraformProperty<string>>? AllowedMemberTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_member_types");
        set => WithProperty("allowed_member_types", value);
    }

    /// <summary>
    /// Description of the app role that appears when the role is being assigned and, if the role functions as an application permissions, during the consent experiences
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetRequiredProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// Display name for the app role that appears during app role assignment and in consent experiences
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => WithProperty("display_name", value);
    }

    /// <summary>
    /// Determines if the app role is enabled
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The unique identifier of the app role
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetRequiredProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The value that is used for the `roles` claim in ID tokens and OAuth 2.0 access tokens that are authenticating an assigned service or user principal
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for feature_tags in .
/// Nesting mode: list
/// </summary>
public class AzureadApplicationFeatureTagsBlock : TerraformBlock
{
    /// <summary>
    /// Whether this application represents a custom SAML application for linked service principals
    /// </summary>
    public TerraformProperty<bool>? CustomSingleSignOn
    {
        get => GetProperty<TerraformProperty<bool>>("custom_single_sign_on");
        set => WithProperty("custom_single_sign_on", value);
    }

    /// <summary>
    /// Whether this application represents an Enterprise Application for linked service principals
    /// </summary>
    public TerraformProperty<bool>? Enterprise
    {
        get => GetProperty<TerraformProperty<bool>>("enterprise");
        set => WithProperty("enterprise", value);
    }

    /// <summary>
    /// Whether this application represents a gallery application for linked service principals
    /// </summary>
    public TerraformProperty<bool>? Gallery
    {
        get => GetProperty<TerraformProperty<bool>>("gallery");
        set => WithProperty("gallery", value);
    }

    /// <summary>
    /// Whether this application is invisible to users in My Apps and Office 365 Launcher
    /// </summary>
    public TerraformProperty<bool>? Hide
    {
        get => GetProperty<TerraformProperty<bool>>("hide");
        set => WithProperty("hide", value);
    }

}

/// <summary>
/// Block type for optional_claims in .
/// Nesting mode: list
/// </summary>
public class AzureadApplicationOptionalClaimsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for password in .
/// Nesting mode: set
/// </summary>
public class AzureadApplicationPasswordBlock : TerraformBlock
{
    /// <summary>
    /// A display name for the password
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => WithProperty("display_name", value);
    }

    /// <summary>
    /// The end date until which the password is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`)
    /// </summary>
    public TerraformProperty<string>? EndDate
    {
        get => GetProperty<TerraformProperty<string>>("end_date");
        set => WithProperty("end_date", value);
    }

    /// <summary>
    /// A UUID used to uniquely identify this password credential
    /// </summary>
    public TerraformProperty<string>? KeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_id");
        set => WithProperty("key_id", value);
    }

    /// <summary>
    /// The start date from which the password is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If this isn&#39;t specified, the current date is used
    /// </summary>
    public TerraformProperty<string>? StartDate
    {
        get => GetProperty<TerraformProperty<string>>("start_date");
        set => WithProperty("start_date", value);
    }

    /// <summary>
    /// The password for this application, which is generated by Azure Active Directory
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for public_client in .
/// Nesting mode: list
/// </summary>
public class AzureadApplicationPublicClientBlock : TerraformBlock
{
    /// <summary>
    /// The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent
    /// </summary>
    public HashSet<TerraformProperty<string>>? RedirectUris
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("redirect_uris");
        set => WithProperty("redirect_uris", value);
    }

}

/// <summary>
/// Block type for required_resource_access in .
/// Nesting mode: set
/// </summary>
public class AzureadApplicationRequiredResourceAccessBlock : TerraformBlock
{
    /// <summary>
    /// The resource_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceAppId is required")]
    public required TerraformProperty<string> ResourceAppId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_app_id");
        set => WithProperty("resource_app_id", value);
    }

}

/// <summary>
/// Block type for single_page_application in .
/// Nesting mode: list
/// </summary>
public class AzureadApplicationSinglePageApplicationBlock : TerraformBlock
{
    /// <summary>
    /// The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent
    /// </summary>
    public HashSet<TerraformProperty<string>>? RedirectUris
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("redirect_uris");
        set => WithProperty("redirect_uris", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationTimeoutsBlock : TerraformBlock
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
/// Block type for web in .
/// Nesting mode: list
/// </summary>
public class AzureadApplicationWebBlock : TerraformBlock
{
    /// <summary>
    /// Home page or landing page of the application
    /// </summary>
    public TerraformProperty<string>? HomepageUrl
    {
        get => GetProperty<TerraformProperty<string>>("homepage_url");
        set => WithProperty("homepage_url", value);
    }

    /// <summary>
    /// The URL that will be used by Microsoft&#39;s authorization service to sign out a user using front-channel, back-channel or SAML logout protocols
    /// </summary>
    public TerraformProperty<string>? LogoutUrl
    {
        get => GetProperty<TerraformProperty<string>>("logout_url");
        set => WithProperty("logout_url", value);
    }

    /// <summary>
    /// The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent
    /// </summary>
    public HashSet<TerraformProperty<string>>? RedirectUris
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("redirect_uris");
        set => WithProperty("redirect_uris", value);
    }

}

/// <summary>
/// Manages a azuread_application resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzureadApplication : TerraformResource
{
    public AzureadApplication(string name) : base("azuread_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("app_role_ids");
        this.WithOutput("client_id");
        this.WithOutput("disabled_by_microsoft");
        this.WithOutput("logo_url");
        this.WithOutput("oauth2_permission_scope_ids");
        this.WithOutput("object_id");
        this.WithOutput("publisher_domain");
    }

    /// <summary>
    /// Description of the application as shown to end users
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Specifies whether this application supports device authentication without a user.
    /// </summary>
    public TerraformProperty<bool>? DeviceOnlyAuthEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("device_only_auth_enabled");
        set => this.WithProperty("device_only_auth_enabled", value);
    }

    /// <summary>
    /// The display name for the application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Specifies whether the application is a public client. Appropriate for apps using token grant flows that don&#39;t use a redirect URI
    /// </summary>
    public TerraformProperty<bool>? FallbackPublicClientEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("fallback_public_client_enabled");
        set => this.WithProperty("fallback_public_client_enabled", value);
    }

    /// <summary>
    /// Configures the `groups` claim issued in a user or OAuth 2.0 access token that the app expects
    /// </summary>
    public HashSet<TerraformProperty<string>>? GroupMembershipClaims
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("group_membership_claims");
        set => this.WithProperty("group_membership_claims", value);
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
    /// The user-defined URI(s) that uniquely identify an application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentifierUris
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identifier_uris");
        set => this.WithProperty("identifier_uris", value);
    }

    /// <summary>
    /// Base64 encoded logo image in gif, png or jpeg format
    /// </summary>
    public TerraformProperty<string>? LogoImage
    {
        get => GetProperty<TerraformProperty<string>>("logo_image");
        set => this.WithProperty("logo_image", value);
    }

    /// <summary>
    /// URL of the application&#39;s marketing page
    /// </summary>
    public TerraformProperty<string>? MarketingUrl
    {
        get => GetProperty<TerraformProperty<string>>("marketing_url");
        set => this.WithProperty("marketing_url", value);
    }

    /// <summary>
    /// User-specified notes relevant for the management of the application
    /// </summary>
    public TerraformProperty<string>? Notes
    {
        get => GetProperty<TerraformProperty<string>>("notes");
        set => this.WithProperty("notes", value);
    }

    /// <summary>
    /// Specifies whether, as part of OAuth 2.0 token requests, Azure AD allows POST requests, as opposed to GET requests.
    /// </summary>
    public TerraformProperty<bool>? Oauth2PostResponseRequired
    {
        get => GetProperty<TerraformProperty<bool>>("oauth2_post_response_required");
        set => this.WithProperty("oauth2_post_response_required", value);
    }

    /// <summary>
    /// A list of object IDs of principals that will be granted ownership of the application
    /// </summary>
    public HashSet<TerraformProperty<string>>? Owners
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("owners");
        set => this.WithProperty("owners", value);
    }

    /// <summary>
    /// If `true`, will return an error if an existing application is found with the same name
    /// </summary>
    public TerraformProperty<bool>? PreventDuplicateNames
    {
        get => GetProperty<TerraformProperty<bool>>("prevent_duplicate_names");
        set => this.WithProperty("prevent_duplicate_names", value);
    }

    /// <summary>
    /// URL of the application&#39;s privacy statement
    /// </summary>
    public TerraformProperty<string>? PrivacyStatementUrl
    {
        get => GetProperty<TerraformProperty<string>>("privacy_statement_url");
        set => this.WithProperty("privacy_statement_url", value);
    }

    /// <summary>
    /// References application or service contact information from a Service or Asset Management database
    /// </summary>
    public TerraformProperty<string>? ServiceManagementReference
    {
        get => GetProperty<TerraformProperty<string>>("service_management_reference");
        set => this.WithProperty("service_management_reference", value);
    }

    /// <summary>
    /// The Microsoft account types that are supported for the current application
    /// </summary>
    public TerraformProperty<string>? SignInAudience
    {
        get => GetProperty<TerraformProperty<string>>("sign_in_audience");
        set => this.WithProperty("sign_in_audience", value);
    }

    /// <summary>
    /// URL of the application&#39;s support page
    /// </summary>
    public TerraformProperty<string>? SupportUrl
    {
        get => GetProperty<TerraformProperty<string>>("support_url");
        set => this.WithProperty("support_url", value);
    }

    /// <summary>
    /// A set of tags to apply to the application
    /// </summary>
    public HashSet<TerraformProperty<string>>? Tags
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Unique ID of the application template from which this application is created
    /// </summary>
    public TerraformProperty<string>? TemplateId
    {
        get => GetProperty<TerraformProperty<string>>("template_id");
        set => this.WithProperty("template_id", value);
    }

    /// <summary>
    /// URL of the application&#39;s terms of service statement
    /// </summary>
    public TerraformProperty<string>? TermsOfServiceUrl
    {
        get => GetProperty<TerraformProperty<string>>("terms_of_service_url");
        set => this.WithProperty("terms_of_service_url", value);
    }

    /// <summary>
    /// Block for api.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Api block(s) allowed")]
    public List<AzureadApplicationApiBlock>? Api
    {
        get => GetProperty<List<AzureadApplicationApiBlock>>("api");
        set => this.WithProperty("api", value);
    }

    /// <summary>
    /// Block for app_role.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzureadApplicationAppRoleBlock>? AppRole
    {
        get => GetProperty<HashSet<AzureadApplicationAppRoleBlock>>("app_role");
        set => this.WithProperty("app_role", value);
    }

    /// <summary>
    /// Block for feature_tags.
    /// Nesting mode: list
    /// </summary>
    public List<AzureadApplicationFeatureTagsBlock>? FeatureTags
    {
        get => GetProperty<List<AzureadApplicationFeatureTagsBlock>>("feature_tags");
        set => this.WithProperty("feature_tags", value);
    }

    /// <summary>
    /// Block for optional_claims.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OptionalClaims block(s) allowed")]
    public List<AzureadApplicationOptionalClaimsBlock>? OptionalClaims
    {
        get => GetProperty<List<AzureadApplicationOptionalClaimsBlock>>("optional_claims");
        set => this.WithProperty("optional_claims", value);
    }

    /// <summary>
    /// Block for password.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Password block(s) allowed")]
    public HashSet<AzureadApplicationPasswordBlock>? Password
    {
        get => GetProperty<HashSet<AzureadApplicationPasswordBlock>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// Block for public_client.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicClient block(s) allowed")]
    public List<AzureadApplicationPublicClientBlock>? PublicClient
    {
        get => GetProperty<List<AzureadApplicationPublicClientBlock>>("public_client");
        set => this.WithProperty("public_client", value);
    }

    /// <summary>
    /// Block for required_resource_access.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzureadApplicationRequiredResourceAccessBlock>? RequiredResourceAccess
    {
        get => GetProperty<HashSet<AzureadApplicationRequiredResourceAccessBlock>>("required_resource_access");
        set => this.WithProperty("required_resource_access", value);
    }

    /// <summary>
    /// Block for single_page_application.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SinglePageApplication block(s) allowed")]
    public List<AzureadApplicationSinglePageApplicationBlock>? SinglePageApplication
    {
        get => GetProperty<List<AzureadApplicationSinglePageApplicationBlock>>("single_page_application");
        set => this.WithProperty("single_page_application", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadApplicationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadApplicationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for web.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Web block(s) allowed")]
    public List<AzureadApplicationWebBlock>? Web
    {
        get => GetProperty<List<AzureadApplicationWebBlock>>("web");
        set => this.WithProperty("web", value);
    }

    /// <summary>
    /// Mapping of app role names to UUIDs
    /// </summary>
    public TerraformExpression AppRoleIds => this["app_role_ids"];

    /// <summary>
    /// The Client ID (also called Application ID)
    /// </summary>
    public TerraformExpression ClientId => this["client_id"];

    /// <summary>
    /// Whether Microsoft has disabled the registered application
    /// </summary>
    public TerraformExpression DisabledByMicrosoft => this["disabled_by_microsoft"];

    /// <summary>
    /// CDN URL to the application&#39;s logo
    /// </summary>
    public TerraformExpression LogoUrl => this["logo_url"];

    /// <summary>
    /// Mapping of OAuth2.0 permission scope names to UUIDs
    /// </summary>
    public TerraformExpression Oauth2PermissionScopeIds => this["oauth2_permission_scope_ids"];

    /// <summary>
    /// The application&#39;s object ID
    /// </summary>
    public TerraformExpression ObjectId => this["object_id"];

    /// <summary>
    /// The verified publisher domain for the application
    /// </summary>
    public TerraformExpression PublisherDomain => this["publisher_domain"];

}
