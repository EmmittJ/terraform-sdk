using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_service_principal resource.
/// </summary>
public class AzureadServicePrincipal : TerraformResource
{
    public AzureadServicePrincipal(string name) : base("azuread_service_principal", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("app_role_ids");
        this.DeclareOutput("app_roles");
        this.DeclareOutput("application_tenant_id");
        this.DeclareOutput("display_name");
        this.DeclareOutput("homepage_url");
        this.DeclareOutput("logout_url");
        this.DeclareOutput("oauth2_permission_scope_ids");
        this.DeclareOutput("oauth2_permission_scopes");
        this.DeclareOutput("object_id");
        this.DeclareOutput("redirect_uris");
        this.DeclareOutput("saml_metadata_url");
        this.DeclareOutput("service_principal_names");
        this.DeclareOutput("sign_in_audience");
        this.DeclareOutput("type");
    }

    /// <summary>
    /// Whether or not the service principal account is enabled
    /// </summary>
    public TerraformProperty<bool>? AccountEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("account_enabled");
        set => this.WithProperty("account_enabled", value);
    }

    /// <summary>
    /// A list of alternative names, used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities
    /// </summary>
    public TerraformProperty<HashSet<string>>? AlternativeNames
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("alternative_names");
        set => this.WithProperty("alternative_names", value);
    }

    /// <summary>
    /// Whether this service principal requires an app role assignment to a user or group before Azure AD will issue a user or access token to the application
    /// </summary>
    public TerraformProperty<bool>? AppRoleAssignmentRequired
    {
        get => GetProperty<TerraformProperty<bool>>("app_role_assignment_required");
        set => this.WithProperty("app_role_assignment_required", value);
    }

    /// <summary>
    /// The client ID of the application for which to create a service principal
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        get => GetProperty<TerraformProperty<string>>("client_id");
        set => this.WithProperty("client_id", value);
    }

    /// <summary>
    /// Description of the service principal provided for internal end-users
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The URL where the service provider redirects the user to Azure AD to authenticate. Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps. When blank, Azure AD performs IdP-initiated sign-on for applications configured with SAML-based single sign-on
    /// </summary>
    public TerraformProperty<string>? LoginUrl
    {
        get => GetProperty<TerraformProperty<string>>("login_url");
        set => this.WithProperty("login_url", value);
    }

    /// <summary>
    /// Free text field to capture information about the service principal, typically used for operational purposes
    /// </summary>
    public TerraformProperty<string>? Notes
    {
        get => GetProperty<TerraformProperty<string>>("notes");
        set => this.WithProperty("notes", value);
    }

    /// <summary>
    /// List of email addresses where Azure AD sends a notification when the active certificate is near the expiration date. This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications
    /// </summary>
    public TerraformProperty<HashSet<string>>? NotificationEmailAddresses
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("notification_email_addresses");
        set => this.WithProperty("notification_email_addresses", value);
    }

    /// <summary>
    /// A list of object IDs of principals that will be granted ownership of the service principal
    /// </summary>
    public TerraformProperty<HashSet<string>>? Owners
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("owners");
        set => this.WithProperty("owners", value);
    }

    /// <summary>
    /// The single sign-on mode configured for this application. Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps
    /// </summary>
    public TerraformProperty<string>? PreferredSingleSignOnMode
    {
        get => GetProperty<TerraformProperty<string>>("preferred_single_sign_on_mode");
        set => this.WithProperty("preferred_single_sign_on_mode", value);
    }

    /// <summary>
    /// A set of tags to apply to the service principal
    /// </summary>
    public TerraformProperty<HashSet<string>>? Tags
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// When true, the resource will return an existing service principal instead of failing with an error
    /// </summary>
    public TerraformProperty<bool>? UseExisting
    {
        get => GetProperty<TerraformProperty<bool>>("use_existing");
        set => this.WithProperty("use_existing", value);
    }

    /// <summary>
    /// Mapping of app role names to UUIDs
    /// </summary>
    public TerraformExpression AppRoleIds => this["app_role_ids"];

    /// <summary>
    /// The app_roles attribute.
    /// </summary>
    public TerraformExpression AppRoles => this["app_roles"];

    /// <summary>
    /// The tenant ID where the associated application is registered
    /// </summary>
    public TerraformExpression ApplicationTenantId => this["application_tenant_id"];

    /// <summary>
    /// The display name of the application associated with this service principal
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// Home page or landing page of the application
    /// </summary>
    public TerraformExpression HomepageUrl => this["homepage_url"];

    /// <summary>
    /// The URL that will be used by Microsoft&#39;s authorization service to sign out a user using front-channel, back-channel or SAML logout protocols
    /// </summary>
    public TerraformExpression LogoutUrl => this["logout_url"];

    /// <summary>
    /// Mapping of OAuth2.0 permission scope names to UUIDs
    /// </summary>
    public TerraformExpression Oauth2PermissionScopeIds => this["oauth2_permission_scope_ids"];

    /// <summary>
    /// The oauth2_permission_scopes attribute.
    /// </summary>
    public TerraformExpression Oauth2PermissionScopes => this["oauth2_permission_scopes"];

    /// <summary>
    /// The object ID of the service principal
    /// </summary>
    public TerraformExpression ObjectId => this["object_id"];

    /// <summary>
    /// The URLs where user tokens are sent for sign-in with the associated application, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent for the associated application
    /// </summary>
    public TerraformExpression RedirectUris => this["redirect_uris"];

    /// <summary>
    /// The URL where the service exposes SAML metadata for federation
    /// </summary>
    public TerraformExpression SamlMetadataUrl => this["saml_metadata_url"];

    /// <summary>
    /// A list of identifier URI(s), copied over from the associated application
    /// </summary>
    public TerraformExpression ServicePrincipalNames => this["service_principal_names"];

    /// <summary>
    /// The Microsoft account types that are supported for the associated application
    /// </summary>
    public TerraformExpression SignInAudience => this["sign_in_audience"];

    /// <summary>
    /// Identifies whether the service principal represents an application or a managed identity
    /// </summary>
    public TerraformExpression Type => this["type"];

}
