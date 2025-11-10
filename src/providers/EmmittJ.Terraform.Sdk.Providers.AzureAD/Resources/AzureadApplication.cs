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
        set => SetProperty("known_client_applications", value);
    }

    /// <summary>
    /// Allows an application to use claims mapping without specifying a custom signing key
    /// </summary>
    public TerraformProperty<bool>? MappedClaimsEnabled
    {
        set => SetProperty("mapped_claims_enabled", value);
    }

    /// <summary>
    /// The access token version expected by this resource
    /// </summary>
    public TerraformProperty<double>? RequestedAccessTokenVersion
    {
        set => SetProperty("requested_access_token_version", value);
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
        set => SetProperty("allowed_member_types", value);
    }

    /// <summary>
    /// Description of the app role that appears when the role is being assigned and, if the role functions as an application permissions, during the consent experiences
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Display name for the app role that appears during app role assignment and in consent experiences
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Determines if the app role is enabled
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The unique identifier of the app role
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The value that is used for the `roles` claim in ID tokens and OAuth 2.0 access tokens that are authenticating an assigned service or user principal
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
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
        set => SetProperty("custom_single_sign_on", value);
    }

    /// <summary>
    /// Whether this application represents an Enterprise Application for linked service principals
    /// </summary>
    public TerraformProperty<bool>? Enterprise
    {
        set => SetProperty("enterprise", value);
    }

    /// <summary>
    /// Whether this application represents a gallery application for linked service principals
    /// </summary>
    public TerraformProperty<bool>? Gallery
    {
        set => SetProperty("gallery", value);
    }

    /// <summary>
    /// Whether this application is invisible to users in My Apps and Office 365 Launcher
    /// </summary>
    public TerraformProperty<bool>? Hide
    {
        set => SetProperty("hide", value);
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
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The end date until which the password is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`)
    /// </summary>
    public TerraformProperty<string>? EndDate
    {
        set => SetProperty("end_date", value);
    }

    /// <summary>
    /// A UUID used to uniquely identify this password credential
    /// </summary>
    public TerraformProperty<string>? KeyId
    {
        set => SetProperty("key_id", value);
    }

    /// <summary>
    /// The start date from which the password is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If this isn&#39;t specified, the current date is used
    /// </summary>
    public TerraformProperty<string>? StartDate
    {
        set => SetProperty("start_date", value);
    }

    /// <summary>
    /// The password for this application, which is generated by Azure Active Directory
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
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
        set => SetProperty("redirect_uris", value);
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
        set => SetProperty("resource_app_id", value);
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
        set => SetProperty("redirect_uris", value);
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
        set => SetProperty("homepage_url", value);
    }

    /// <summary>
    /// The URL that will be used by Microsoft&#39;s authorization service to sign out a user using front-channel, back-channel or SAML logout protocols
    /// </summary>
    public TerraformProperty<string>? LogoutUrl
    {
        set => SetProperty("logout_url", value);
    }

    /// <summary>
    /// The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent
    /// </summary>
    public HashSet<TerraformProperty<string>>? RedirectUris
    {
        set => SetProperty("redirect_uris", value);
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
        SetOutput("app_role_ids");
        SetOutput("client_id");
        SetOutput("disabled_by_microsoft");
        SetOutput("logo_url");
        SetOutput("oauth2_permission_scope_ids");
        SetOutput("object_id");
        SetOutput("publisher_domain");
        SetOutput("description");
        SetOutput("device_only_auth_enabled");
        SetOutput("display_name");
        SetOutput("fallback_public_client_enabled");
        SetOutput("group_membership_claims");
        SetOutput("id");
        SetOutput("identifier_uris");
        SetOutput("logo_image");
        SetOutput("marketing_url");
        SetOutput("notes");
        SetOutput("oauth2_post_response_required");
        SetOutput("owners");
        SetOutput("prevent_duplicate_names");
        SetOutput("privacy_statement_url");
        SetOutput("service_management_reference");
        SetOutput("sign_in_audience");
        SetOutput("support_url");
        SetOutput("tags");
        SetOutput("template_id");
        SetOutput("terms_of_service_url");
    }

    /// <summary>
    /// Description of the application as shown to end users
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Specifies whether this application supports device authentication without a user.
    /// </summary>
    public TerraformProperty<bool> DeviceOnlyAuthEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("device_only_auth_enabled");
        set => SetProperty("device_only_auth_enabled", value);
    }

    /// <summary>
    /// The display name for the application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Specifies whether the application is a public client. Appropriate for apps using token grant flows that don&#39;t use a redirect URI
    /// </summary>
    public TerraformProperty<bool> FallbackPublicClientEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("fallback_public_client_enabled");
        set => SetProperty("fallback_public_client_enabled", value);
    }

    /// <summary>
    /// Configures the `groups` claim issued in a user or OAuth 2.0 access token that the app expects
    /// </summary>
    public HashSet<TerraformProperty<string>> GroupMembershipClaims
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("group_membership_claims");
        set => SetProperty("group_membership_claims", value);
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
    /// The user-defined URI(s) that uniquely identify an application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant
    /// </summary>
    public HashSet<TerraformProperty<string>> IdentifierUris
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("identifier_uris");
        set => SetProperty("identifier_uris", value);
    }

    /// <summary>
    /// Base64 encoded logo image in gif, png or jpeg format
    /// </summary>
    public TerraformProperty<string> LogoImage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("logo_image");
        set => SetProperty("logo_image", value);
    }

    /// <summary>
    /// URL of the application&#39;s marketing page
    /// </summary>
    public TerraformProperty<string> MarketingUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("marketing_url");
        set => SetProperty("marketing_url", value);
    }

    /// <summary>
    /// User-specified notes relevant for the management of the application
    /// </summary>
    public TerraformProperty<string> Notes
    {
        get => GetRequiredOutput<TerraformProperty<string>>("notes");
        set => SetProperty("notes", value);
    }

    /// <summary>
    /// Specifies whether, as part of OAuth 2.0 token requests, Azure AD allows POST requests, as opposed to GET requests.
    /// </summary>
    public TerraformProperty<bool> Oauth2PostResponseRequired
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("oauth2_post_response_required");
        set => SetProperty("oauth2_post_response_required", value);
    }

    /// <summary>
    /// A list of object IDs of principals that will be granted ownership of the application
    /// </summary>
    public HashSet<TerraformProperty<string>> Owners
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("owners");
        set => SetProperty("owners", value);
    }

    /// <summary>
    /// If `true`, will return an error if an existing application is found with the same name
    /// </summary>
    public TerraformProperty<bool> PreventDuplicateNames
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("prevent_duplicate_names");
        set => SetProperty("prevent_duplicate_names", value);
    }

    /// <summary>
    /// URL of the application&#39;s privacy statement
    /// </summary>
    public TerraformProperty<string> PrivacyStatementUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("privacy_statement_url");
        set => SetProperty("privacy_statement_url", value);
    }

    /// <summary>
    /// References application or service contact information from a Service or Asset Management database
    /// </summary>
    public TerraformProperty<string> ServiceManagementReference
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_management_reference");
        set => SetProperty("service_management_reference", value);
    }

    /// <summary>
    /// The Microsoft account types that are supported for the current application
    /// </summary>
    public TerraformProperty<string> SignInAudience
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sign_in_audience");
        set => SetProperty("sign_in_audience", value);
    }

    /// <summary>
    /// URL of the application&#39;s support page
    /// </summary>
    public TerraformProperty<string> SupportUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("support_url");
        set => SetProperty("support_url", value);
    }

    /// <summary>
    /// A set of tags to apply to the application
    /// </summary>
    public HashSet<TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Unique ID of the application template from which this application is created
    /// </summary>
    public TerraformProperty<string> TemplateId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("template_id");
        set => SetProperty("template_id", value);
    }

    /// <summary>
    /// URL of the application&#39;s terms of service statement
    /// </summary>
    public TerraformProperty<string> TermsOfServiceUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("terms_of_service_url");
        set => SetProperty("terms_of_service_url", value);
    }

    /// <summary>
    /// Block for api.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Api block(s) allowed")]
    public List<AzureadApplicationApiBlock>? Api
    {
        set => SetProperty("api", value);
    }

    /// <summary>
    /// Block for app_role.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzureadApplicationAppRoleBlock>? AppRole
    {
        set => SetProperty("app_role", value);
    }

    /// <summary>
    /// Block for feature_tags.
    /// Nesting mode: list
    /// </summary>
    public List<AzureadApplicationFeatureTagsBlock>? FeatureTags
    {
        set => SetProperty("feature_tags", value);
    }

    /// <summary>
    /// Block for optional_claims.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OptionalClaims block(s) allowed")]
    public List<AzureadApplicationOptionalClaimsBlock>? OptionalClaims
    {
        set => SetProperty("optional_claims", value);
    }

    /// <summary>
    /// Block for password.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Password block(s) allowed")]
    public HashSet<AzureadApplicationPasswordBlock>? Password
    {
        set => SetProperty("password", value);
    }

    /// <summary>
    /// Block for public_client.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicClient block(s) allowed")]
    public List<AzureadApplicationPublicClientBlock>? PublicClient
    {
        set => SetProperty("public_client", value);
    }

    /// <summary>
    /// Block for required_resource_access.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzureadApplicationRequiredResourceAccessBlock>? RequiredResourceAccess
    {
        set => SetProperty("required_resource_access", value);
    }

    /// <summary>
    /// Block for single_page_application.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SinglePageApplication block(s) allowed")]
    public List<AzureadApplicationSinglePageApplicationBlock>? SinglePageApplication
    {
        set => SetProperty("single_page_application", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadApplicationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for web.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Web block(s) allowed")]
    public List<AzureadApplicationWebBlock>? Web
    {
        set => SetProperty("web", value);
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
