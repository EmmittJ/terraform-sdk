using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadServicePrincipalDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_service_principal.
/// </summary>
public class AzureadServicePrincipalDataSource : TerraformDataSource
{
    public AzureadServicePrincipalDataSource(string name) : base("azuread_service_principal", name)
    {
    }

    /// <summary>
    /// The client ID of the application associated with this service principal
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ClientId { get; set; } = default!;

    /// <summary>
    /// The display name of the application associated with this service principal
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DisplayName { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The object ID of the service principal
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ObjectId { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadServicePrincipalDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Whether or not the service principal account is enabled
    /// </summary>
    [TerraformPropertyName("account_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AccountEnabled => new TerraformReference(this, "account_enabled");

    /// <summary>
    /// A list of alternative names, used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities
    /// </summary>
    [TerraformPropertyName("alternative_names")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AlternativeNames => new TerraformReference(this, "alternative_names");

    /// <summary>
    /// Whether this service principal requires an app role assignment to a user or group before Azure AD will issue a user or access token to the application
    /// </summary>
    [TerraformPropertyName("app_role_assignment_required")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AppRoleAssignmentRequired => new TerraformReference(this, "app_role_assignment_required");

    /// <summary>
    /// Mapping of app role names to UUIDs
    /// </summary>
    [TerraformPropertyName("app_role_ids")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> AppRoleIds => new TerraformReference(this, "app_role_ids");

    /// <summary>
    /// The app_roles attribute.
    /// </summary>
    [TerraformPropertyName("app_roles")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AppRoles => new TerraformReference(this, "app_roles");

    /// <summary>
    /// The tenant ID where the associated application is registered
    /// </summary>
    [TerraformPropertyName("application_tenant_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ApplicationTenantId => new TerraformReference(this, "application_tenant_id");

    /// <summary>
    /// Description of the service principal provided for internal end-users
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// Block of features configured for this service principal using tags
    /// </summary>
    [TerraformPropertyName("feature_tags")]
    // Output-only attribute - read-only reference
    public TerraformList<object> FeatureTags => new TerraformReference(this, "feature_tags");

    /// <summary>
    /// Block of features configured for this service principal using tags
    /// </summary>
    [TerraformPropertyName("features")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Features => new TerraformReference(this, "features");

    /// <summary>
    /// Home page or landing page of the application
    /// </summary>
    [TerraformPropertyName("homepage_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HomepageUrl => new TerraformReference(this, "homepage_url");

    /// <summary>
    /// The URL where the service provider redirects the user to Azure AD to authenticate. Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps
    /// </summary>
    [TerraformPropertyName("login_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LoginUrl => new TerraformReference(this, "login_url");

    /// <summary>
    /// The URL that will be used by Microsoft&#39;s authorization service to sign out a user using front-channel, back-channel or SAML logout protocols
    /// </summary>
    [TerraformPropertyName("logout_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LogoutUrl => new TerraformReference(this, "logout_url");

    /// <summary>
    /// Free text field to capture information about the service principal, typically used for operational purposes
    /// </summary>
    [TerraformPropertyName("notes")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Notes => new TerraformReference(this, "notes");

    /// <summary>
    /// List of email addresses where Azure AD sends a notification when the active certificate is near the expiration date. This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications
    /// </summary>
    [TerraformPropertyName("notification_email_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> NotificationEmailAddresses => new TerraformReference(this, "notification_email_addresses");

    /// <summary>
    /// Mapping of OAuth2.0 permission scope names to UUIDs
    /// </summary>
    [TerraformPropertyName("oauth2_permission_scope_ids")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Oauth2PermissionScopeIds => new TerraformReference(this, "oauth2_permission_scope_ids");

    /// <summary>
    /// The oauth2_permission_scopes attribute.
    /// </summary>
    [TerraformPropertyName("oauth2_permission_scopes")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Oauth2PermissionScopes => new TerraformReference(this, "oauth2_permission_scopes");

    /// <summary>
    /// The single sign-on mode configured for this application. Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps
    /// </summary>
    [TerraformPropertyName("preferred_single_sign_on_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PreferredSingleSignOnMode => new TerraformReference(this, "preferred_single_sign_on_mode");

    /// <summary>
    /// The URLs where user tokens are sent for sign-in with the associated application, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent for the associated application
    /// </summary>
    [TerraformPropertyName("redirect_uris")]
    // Output-only attribute - read-only reference
    public TerraformList<string> RedirectUris => new TerraformReference(this, "redirect_uris");

    /// <summary>
    /// The URL where the service exposes SAML metadata for federation
    /// </summary>
    [TerraformPropertyName("saml_metadata_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SamlMetadataUrl => new TerraformReference(this, "saml_metadata_url");

    /// <summary>
    /// Settings related to SAML single sign-on
    /// </summary>
    [TerraformPropertyName("saml_single_sign_on")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SamlSingleSignOn => new TerraformReference(this, "saml_single_sign_on");

    /// <summary>
    /// A list of identifier URI(s), copied over from the associated application
    /// </summary>
    [TerraformPropertyName("service_principal_names")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ServicePrincipalNames => new TerraformReference(this, "service_principal_names");

    /// <summary>
    /// The Microsoft account types that are supported for the associated application
    /// </summary>
    [TerraformPropertyName("sign_in_audience")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SignInAudience => new TerraformReference(this, "sign_in_audience");

    /// <summary>
    /// A set of tags to apply to the service principal
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// Identifies whether the service principal represents an application or a managed identity
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

}
