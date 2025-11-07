using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_application resource.
/// </summary>
public class AzureadApplication : TerraformResource
{
    public AzureadApplication(string name) : base("azuread_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("app_role_ids");
        this.DeclareOutput("client_id");
        this.DeclareOutput("disabled_by_microsoft");
        this.DeclareOutput("logo_url");
        this.DeclareOutput("oauth2_permission_scope_ids");
        this.DeclareOutput("object_id");
        this.DeclareOutput("publisher_domain");
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
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
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
    public TerraformProperty<HashSet<string>>? GroupMembershipClaims
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("group_membership_claims");
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
    public TerraformProperty<HashSet<string>>? IdentifierUris
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("identifier_uris");
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
    public TerraformProperty<HashSet<string>>? Owners
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("owners");
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
    public TerraformProperty<HashSet<string>>? Tags
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("tags");
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
