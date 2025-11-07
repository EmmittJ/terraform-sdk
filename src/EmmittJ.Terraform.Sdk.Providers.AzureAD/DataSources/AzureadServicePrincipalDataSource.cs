using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Retrieves information about a azuread_service_principal.
/// </summary>
public class AzureadServicePrincipalDataSource : TerraformDataSource
{
    public AzureadServicePrincipalDataSource(string name) : base("azuread_service_principal", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("account_enabled");
        this.DeclareOutput("alternative_names");
        this.DeclareOutput("app_role_assignment_required");
        this.DeclareOutput("app_role_ids");
        this.DeclareOutput("app_roles");
        this.DeclareOutput("application_tenant_id");
        this.DeclareOutput("description");
        this.DeclareOutput("feature_tags");
        this.DeclareOutput("features");
        this.DeclareOutput("homepage_url");
        this.DeclareOutput("login_url");
        this.DeclareOutput("logout_url");
        this.DeclareOutput("notes");
        this.DeclareOutput("notification_email_addresses");
        this.DeclareOutput("oauth2_permission_scope_ids");
        this.DeclareOutput("oauth2_permission_scopes");
        this.DeclareOutput("preferred_single_sign_on_mode");
        this.DeclareOutput("redirect_uris");
        this.DeclareOutput("saml_metadata_url");
        this.DeclareOutput("saml_single_sign_on");
        this.DeclareOutput("service_principal_names");
        this.DeclareOutput("sign_in_audience");
        this.DeclareOutput("tags");
        this.DeclareOutput("type");
    }

    /// <summary>
    /// The client ID of the application associated with this service principal
    /// </summary>
    public TerraformLiteralProperty<string>? ClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_id");
        set => this.WithProperty("client_id", value);
    }

    /// <summary>
    /// The display name of the application associated with this service principal
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The object ID of the service principal
    /// </summary>
    public TerraformLiteralProperty<string>? ObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_id");
        set => this.WithProperty("object_id", value);
    }

    /// <summary>
    /// Whether or not the service principal account is enabled
    /// </summary>
    public TerraformExpression AccountEnabled => this["account_enabled"];

    /// <summary>
    /// A list of alternative names, used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities
    /// </summary>
    public TerraformExpression AlternativeNames => this["alternative_names"];

    /// <summary>
    /// Whether this service principal requires an app role assignment to a user or group before Azure AD will issue a user or access token to the application
    /// </summary>
    public TerraformExpression AppRoleAssignmentRequired => this["app_role_assignment_required"];

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
    /// Description of the service principal provided for internal end-users
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// Block of features configured for this service principal using tags
    /// </summary>
    public TerraformExpression FeatureTags => this["feature_tags"];

    /// <summary>
    /// Block of features configured for this service principal using tags
    /// </summary>
    public TerraformExpression Features => this["features"];

    /// <summary>
    /// Home page or landing page of the application
    /// </summary>
    public TerraformExpression HomepageUrl => this["homepage_url"];

    /// <summary>
    /// The URL where the service provider redirects the user to Azure AD to authenticate. Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps
    /// </summary>
    public TerraformExpression LoginUrl => this["login_url"];

    /// <summary>
    /// The URL that will be used by Microsoft&#39;s authorization service to sign out a user using front-channel, back-channel or SAML logout protocols
    /// </summary>
    public TerraformExpression LogoutUrl => this["logout_url"];

    /// <summary>
    /// Free text field to capture information about the service principal, typically used for operational purposes
    /// </summary>
    public TerraformExpression Notes => this["notes"];

    /// <summary>
    /// List of email addresses where Azure AD sends a notification when the active certificate is near the expiration date. This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications
    /// </summary>
    public TerraformExpression NotificationEmailAddresses => this["notification_email_addresses"];

    /// <summary>
    /// Mapping of OAuth2.0 permission scope names to UUIDs
    /// </summary>
    public TerraformExpression Oauth2PermissionScopeIds => this["oauth2_permission_scope_ids"];

    /// <summary>
    /// The oauth2_permission_scopes attribute.
    /// </summary>
    public TerraformExpression Oauth2PermissionScopes => this["oauth2_permission_scopes"];

    /// <summary>
    /// The single sign-on mode configured for this application. Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps
    /// </summary>
    public TerraformExpression PreferredSingleSignOnMode => this["preferred_single_sign_on_mode"];

    /// <summary>
    /// The URLs where user tokens are sent for sign-in with the associated application, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent for the associated application
    /// </summary>
    public TerraformExpression RedirectUris => this["redirect_uris"];

    /// <summary>
    /// The URL where the service exposes SAML metadata for federation
    /// </summary>
    public TerraformExpression SamlMetadataUrl => this["saml_metadata_url"];

    /// <summary>
    /// Settings related to SAML single sign-on
    /// </summary>
    public TerraformExpression SamlSingleSignOn => this["saml_single_sign_on"];

    /// <summary>
    /// A list of identifier URI(s), copied over from the associated application
    /// </summary>
    public TerraformExpression ServicePrincipalNames => this["service_principal_names"];

    /// <summary>
    /// The Microsoft account types that are supported for the associated application
    /// </summary>
    public TerraformExpression SignInAudience => this["sign_in_audience"];

    /// <summary>
    /// A set of tags to apply to the service principal
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// Identifies whether the service principal represents an application or a managed identity
    /// </summary>
    public TerraformExpression Type => this["type"];

}
