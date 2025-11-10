using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azuread_application.
/// </summary>
public class AzureadApplicationDataSource : TerraformDataSource
{
    public AzureadApplicationDataSource(string name) : base("azuread_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("api");
        this.DeclareOutput("app_role_ids");
        this.DeclareOutput("app_roles");
        this.DeclareOutput("description");
        this.DeclareOutput("device_only_auth_enabled");
        this.DeclareOutput("disabled_by_microsoft");
        this.DeclareOutput("fallback_public_client_enabled");
        this.DeclareOutput("feature_tags");
        this.DeclareOutput("group_membership_claims");
        this.DeclareOutput("identifier_uris");
        this.DeclareOutput("logo_url");
        this.DeclareOutput("marketing_url");
        this.DeclareOutput("notes");
        this.DeclareOutput("oauth2_permission_scope_ids");
        this.DeclareOutput("oauth2_post_response_required");
        this.DeclareOutput("optional_claims");
        this.DeclareOutput("owners");
        this.DeclareOutput("privacy_statement_url");
        this.DeclareOutput("public_client");
        this.DeclareOutput("publisher_domain");
        this.DeclareOutput("required_resource_access");
        this.DeclareOutput("service_management_reference");
        this.DeclareOutput("sign_in_audience");
        this.DeclareOutput("single_page_application");
        this.DeclareOutput("support_url");
        this.DeclareOutput("tags");
        this.DeclareOutput("terms_of_service_url");
        this.DeclareOutput("web");
    }

    /// <summary>
    /// The Client ID (also called Application ID)
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        get => GetProperty<TerraformProperty<string>>("client_id");
        set => this.WithProperty("client_id", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// One of the application&#39;s identifier URIs
    /// </summary>
    public TerraformProperty<string>? IdentifierUri
    {
        get => GetProperty<TerraformProperty<string>>("identifier_uri");
        set => this.WithProperty("identifier_uri", value);
    }

    /// <summary>
    /// The application&#39;s object ID
    /// </summary>
    public TerraformProperty<string>? ObjectId
    {
        get => GetProperty<TerraformProperty<string>>("object_id");
        set => this.WithProperty("object_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadApplicationDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadApplicationDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The api attribute.
    /// </summary>
    public TerraformExpression Api => this["api"];

    /// <summary>
    /// Mapping of app role names to UUIDs
    /// </summary>
    public TerraformExpression AppRoleIds => this["app_role_ids"];

    /// <summary>
    /// List of app roles published by the application
    /// </summary>
    public TerraformExpression AppRoles => this["app_roles"];

    /// <summary>
    /// Description of the application as shown to end users
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// Specifies whether this application supports device authentication without a user.
    /// </summary>
    public TerraformExpression DeviceOnlyAuthEnabled => this["device_only_auth_enabled"];

    /// <summary>
    /// Whether Microsoft has disabled the registered application
    /// </summary>
    public TerraformExpression DisabledByMicrosoft => this["disabled_by_microsoft"];

    /// <summary>
    /// The fallback application type as public client, such as an installed application running on a mobile device
    /// </summary>
    public TerraformExpression FallbackPublicClientEnabled => this["fallback_public_client_enabled"];

    /// <summary>
    /// Block of features configured for this application using tags
    /// </summary>
    public TerraformExpression FeatureTags => this["feature_tags"];

    /// <summary>
    /// The `groups` claim issued in a user or OAuth 2.0 access token that the app expects
    /// </summary>
    public TerraformExpression GroupMembershipClaims => this["group_membership_claims"];

    /// <summary>
    /// A list of user-defined URI(s) that uniquely identify a Web application within it&#39;s Azure AD tenant, or within a verified custom domain if the application is multi-tenant
    /// </summary>
    public TerraformExpression IdentifierUris => this["identifier_uris"];

    /// <summary>
    /// CDN URL to the application&#39;s logo
    /// </summary>
    public TerraformExpression LogoUrl => this["logo_url"];

    /// <summary>
    /// URL of the application&#39;s marketing page
    /// </summary>
    public TerraformExpression MarketingUrl => this["marketing_url"];

    /// <summary>
    /// User-specified notes relevant for the management of the application
    /// </summary>
    public TerraformExpression Notes => this["notes"];

    /// <summary>
    /// Mapping of OAuth2.0 permission scope names to UUIDs
    /// </summary>
    public TerraformExpression Oauth2PermissionScopeIds => this["oauth2_permission_scope_ids"];

    /// <summary>
    /// Specifies whether, as part of OAuth 2.0 token requests, Azure AD allows POST requests, as opposed to GET requests.
    /// </summary>
    public TerraformExpression Oauth2PostResponseRequired => this["oauth2_post_response_required"];

    /// <summary>
    /// The optional_claims attribute.
    /// </summary>
    public TerraformExpression OptionalClaims => this["optional_claims"];

    /// <summary>
    /// A list of object IDs of principals that are assigned ownership of the application
    /// </summary>
    public TerraformExpression Owners => this["owners"];

    /// <summary>
    /// URL of the application&#39;s privacy statement
    /// </summary>
    public TerraformExpression PrivacyStatementUrl => this["privacy_statement_url"];

    /// <summary>
    /// The public_client attribute.
    /// </summary>
    public TerraformExpression PublicClient => this["public_client"];

    /// <summary>
    /// The verified publisher domain for the application
    /// </summary>
    public TerraformExpression PublisherDomain => this["publisher_domain"];

    /// <summary>
    /// The required_resource_access attribute.
    /// </summary>
    public TerraformExpression RequiredResourceAccess => this["required_resource_access"];

    /// <summary>
    /// References application or service contact information from a Service or Asset Management database
    /// </summary>
    public TerraformExpression ServiceManagementReference => this["service_management_reference"];

    /// <summary>
    /// The Microsoft account types that are supported for the current application
    /// </summary>
    public TerraformExpression SignInAudience => this["sign_in_audience"];

    /// <summary>
    /// The single_page_application attribute.
    /// </summary>
    public TerraformExpression SinglePageApplication => this["single_page_application"];

    /// <summary>
    /// URL of the application&#39;s support page
    /// </summary>
    public TerraformExpression SupportUrl => this["support_url"];

    /// <summary>
    /// A set of tags applied to the application
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// URL of the application&#39;s terms of service statement
    /// </summary>
    public TerraformExpression TermsOfServiceUrl => this["terms_of_service_url"];

    /// <summary>
    /// The web attribute.
    /// </summary>
    public TerraformExpression Web => this["web"];

}
