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
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Specifies whether this application supports device authentication without a user.
    /// </summary>
    public bool? DeviceOnlyAuthEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("device_only_auth_enabled")?.Value;
        set => this.WithProperty("device_only_auth_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The display name for the application
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Specifies whether the application is a public client. Appropriate for apps using token grant flows that don&#39;t use a redirect URI
    /// </summary>
    public bool? FallbackPublicClientEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("fallback_public_client_enabled")?.Value;
        set => this.WithProperty("fallback_public_client_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Configures the `groups` claim issued in a user or OAuth 2.0 access token that the app expects
    /// </summary>
    public HashSet<string>? GroupMembershipClaims
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("group_membership_claims")?.Value;
        set => this.WithProperty("group_membership_claims", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The user-defined URI(s) that uniquely identify an application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant
    /// </summary>
    public HashSet<string>? IdentifierUris
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("identifier_uris")?.Value;
        set => this.WithProperty("identifier_uris", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// Base64 encoded logo image in gif, png or jpeg format
    /// </summary>
    public string? LogoImage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("logo_image")?.Value;
        set => this.WithProperty("logo_image", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// URL of the application&#39;s marketing page
    /// </summary>
    public string? MarketingUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("marketing_url")?.Value;
        set => this.WithProperty("marketing_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// User-specified notes relevant for the management of the application
    /// </summary>
    public string? Notes
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notes")?.Value;
        set => this.WithProperty("notes", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Specifies whether, as part of OAuth 2.0 token requests, Azure AD allows POST requests, as opposed to GET requests.
    /// </summary>
    public bool? Oauth2PostResponseRequired
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("oauth2_post_response_required")?.Value;
        set => this.WithProperty("oauth2_post_response_required", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// A list of object IDs of principals that will be granted ownership of the application
    /// </summary>
    public HashSet<string>? Owners
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("owners")?.Value;
        set => this.WithProperty("owners", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// If `true`, will return an error if an existing application is found with the same name
    /// </summary>
    public bool? PreventDuplicateNames
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("prevent_duplicate_names")?.Value;
        set => this.WithProperty("prevent_duplicate_names", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// URL of the application&#39;s privacy statement
    /// </summary>
    public string? PrivacyStatementUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("privacy_statement_url")?.Value;
        set => this.WithProperty("privacy_statement_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// References application or service contact information from a Service or Asset Management database
    /// </summary>
    public string? ServiceManagementReference
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_management_reference")?.Value;
        set => this.WithProperty("service_management_reference", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Microsoft account types that are supported for the current application
    /// </summary>
    public string? SignInAudience
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sign_in_audience")?.Value;
        set => this.WithProperty("sign_in_audience", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// URL of the application&#39;s support page
    /// </summary>
    public string? SupportUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("support_url")?.Value;
        set => this.WithProperty("support_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A set of tags to apply to the application
    /// </summary>
    public HashSet<string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// Unique ID of the application template from which this application is created
    /// </summary>
    public string? TemplateId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_id")?.Value;
        set => this.WithProperty("template_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// URL of the application&#39;s terms of service statement
    /// </summary>
    public string? TermsOfServiceUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("terms_of_service_url")?.Value;
        set => this.WithProperty("terms_of_service_url", value == null ? null : new TerraformLiteralProperty<string>(value));
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
