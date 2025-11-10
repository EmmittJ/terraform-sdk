using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for feature_tags in .
/// Nesting mode: list
/// </summary>
public class AzureadServicePrincipalFeatureTagsBlock : TerraformBlock
{
    /// <summary>
    /// Whether this service principal represents a custom SAML application
    /// </summary>
    public TerraformProperty<bool>? CustomSingleSignOn
    {
        set => SetProperty("custom_single_sign_on", value);
    }

    /// <summary>
    /// Whether this service principal represents an Enterprise Application
    /// </summary>
    public TerraformProperty<bool>? Enterprise
    {
        set => SetProperty("enterprise", value);
    }

    /// <summary>
    /// Whether this service principal represents a gallery application
    /// </summary>
    public TerraformProperty<bool>? Gallery
    {
        set => SetProperty("gallery", value);
    }

    /// <summary>
    /// Whether this app is invisible to users in My Apps and Office 365 Launcher
    /// </summary>
    public TerraformProperty<bool>? Hide
    {
        set => SetProperty("hide", value);
    }

}

/// <summary>
/// Block type for features in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzureadServicePrincipalFeaturesBlock : TerraformBlock
{
    /// <summary>
    /// Whether this service principal represents a custom SAML application
    /// </summary>
    public TerraformProperty<bool>? CustomSingleSignOnApp
    {
        set => SetProperty("custom_single_sign_on_app", value);
    }

    /// <summary>
    /// Whether this service principal represents an Enterprise Application
    /// </summary>
    public TerraformProperty<bool>? EnterpriseApplication
    {
        set => SetProperty("enterprise_application", value);
    }

    /// <summary>
    /// Whether this service principal represents a gallery application
    /// </summary>
    public TerraformProperty<bool>? GalleryApplication
    {
        set => SetProperty("gallery_application", value);
    }

    /// <summary>
    /// Whether this app is visible to users in My Apps and Office 365 Launcher
    /// </summary>
    public TerraformProperty<bool>? VisibleToUsers
    {
        set => SetProperty("visible_to_users", value);
    }

}

/// <summary>
/// Block type for saml_single_sign_on in .
/// Nesting mode: list
/// </summary>
public class AzureadServicePrincipalSamlSingleSignOnBlock : TerraformBlock
{
    /// <summary>
    /// The relative URI the service provider would redirect to after completion of the single sign-on flow
    /// </summary>
    public TerraformProperty<string>? RelayState
    {
        set => SetProperty("relay_state", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadServicePrincipalTimeoutsBlock : TerraformBlock
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
/// Manages a azuread_service_principal resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzureadServicePrincipal : TerraformResource
{
    public AzureadServicePrincipal(string name) : base("azuread_service_principal", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("app_role_ids");
        SetOutput("app_roles");
        SetOutput("application_tenant_id");
        SetOutput("display_name");
        SetOutput("homepage_url");
        SetOutput("logout_url");
        SetOutput("oauth2_permission_scope_ids");
        SetOutput("oauth2_permission_scopes");
        SetOutput("object_id");
        SetOutput("redirect_uris");
        SetOutput("saml_metadata_url");
        SetOutput("service_principal_names");
        SetOutput("sign_in_audience");
        SetOutput("type");
        SetOutput("account_enabled");
        SetOutput("alternative_names");
        SetOutput("app_role_assignment_required");
        SetOutput("client_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("login_url");
        SetOutput("notes");
        SetOutput("notification_email_addresses");
        SetOutput("owners");
        SetOutput("preferred_single_sign_on_mode");
        SetOutput("tags");
        SetOutput("use_existing");
    }

    /// <summary>
    /// Whether or not the service principal account is enabled
    /// </summary>
    public TerraformProperty<bool> AccountEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("account_enabled");
        set => SetProperty("account_enabled", value);
    }

    /// <summary>
    /// A list of alternative names, used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities
    /// </summary>
    public HashSet<TerraformProperty<string>> AlternativeNames
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("alternative_names");
        set => SetProperty("alternative_names", value);
    }

    /// <summary>
    /// Whether this service principal requires an app role assignment to a user or group before Azure AD will issue a user or access token to the application
    /// </summary>
    public TerraformProperty<bool> AppRoleAssignmentRequired
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("app_role_assignment_required");
        set => SetProperty("app_role_assignment_required", value);
    }

    /// <summary>
    /// The client ID of the application for which to create a service principal
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformProperty<string> ClientId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_id");
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// Description of the service principal provided for internal end-users
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The URL where the service provider redirects the user to Azure AD to authenticate. Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps. When blank, Azure AD performs IdP-initiated sign-on for applications configured with SAML-based single sign-on
    /// </summary>
    public TerraformProperty<string> LoginUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("login_url");
        set => SetProperty("login_url", value);
    }

    /// <summary>
    /// Free text field to capture information about the service principal, typically used for operational purposes
    /// </summary>
    public TerraformProperty<string> Notes
    {
        get => GetRequiredOutput<TerraformProperty<string>>("notes");
        set => SetProperty("notes", value);
    }

    /// <summary>
    /// List of email addresses where Azure AD sends a notification when the active certificate is near the expiration date. This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications
    /// </summary>
    public HashSet<TerraformProperty<string>> NotificationEmailAddresses
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("notification_email_addresses");
        set => SetProperty("notification_email_addresses", value);
    }

    /// <summary>
    /// A list of object IDs of principals that will be granted ownership of the service principal
    /// </summary>
    public HashSet<TerraformProperty<string>> Owners
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("owners");
        set => SetProperty("owners", value);
    }

    /// <summary>
    /// The single sign-on mode configured for this application. Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps
    /// </summary>
    public TerraformProperty<string> PreferredSingleSignOnMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preferred_single_sign_on_mode");
        set => SetProperty("preferred_single_sign_on_mode", value);
    }

    /// <summary>
    /// A set of tags to apply to the service principal
    /// </summary>
    public HashSet<TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// When true, the resource will return an existing service principal instead of failing with an error
    /// </summary>
    public TerraformProperty<bool> UseExisting
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("use_existing");
        set => SetProperty("use_existing", value);
    }

    /// <summary>
    /// Block for feature_tags.
    /// Nesting mode: list
    /// </summary>
    public List<AzureadServicePrincipalFeatureTagsBlock>? FeatureTags
    {
        set => SetProperty("feature_tags", value);
    }

    /// <summary>
    /// Block for features.
    /// Nesting mode: list
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public List<AzureadServicePrincipalFeaturesBlock>? Features
    {
        set => SetProperty("features", value);
    }

    /// <summary>
    /// Block for saml_single_sign_on.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SamlSingleSignOn block(s) allowed")]
    public List<AzureadServicePrincipalSamlSingleSignOnBlock>? SamlSingleSignOn
    {
        set => SetProperty("saml_single_sign_on", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadServicePrincipalTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
