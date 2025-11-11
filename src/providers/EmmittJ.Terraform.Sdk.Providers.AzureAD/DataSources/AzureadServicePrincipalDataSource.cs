using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadServicePrincipalDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_service_principal.
/// </summary>
public partial class AzureadServicePrincipalDataSource : TerraformDataSource
{
    public AzureadServicePrincipalDataSource(string name) : base("azuread_service_principal", name)
    {
    }

    /// <summary>
    /// The client ID of the application associated with this service principal
    /// </summary>
    [TerraformProperty("client_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// The display name of the application associated with this service principal
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The object ID of the service principal
    /// </summary>
    [TerraformProperty("object_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ObjectId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzureadServicePrincipalDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Whether or not the service principal account is enabled
    /// </summary>
    [TerraformProperty("account_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AccountEnabled { get; }

    /// <summary>
    /// A list of alternative names, used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities
    /// </summary>
    [TerraformProperty("alternative_names")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AlternativeNames { get; }

    /// <summary>
    /// Whether this service principal requires an app role assignment to a user or group before Azure AD will issue a user or access token to the application
    /// </summary>
    [TerraformProperty("app_role_assignment_required")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AppRoleAssignmentRequired { get; }

    /// <summary>
    /// Mapping of app role names to UUIDs
    /// </summary>
    [TerraformProperty("app_role_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> AppRoleIds { get; }

    /// <summary>
    /// The app_roles attribute.
    /// </summary>
    [TerraformProperty("app_roles")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AppRoles { get; }

    /// <summary>
    /// The tenant ID where the associated application is registered
    /// </summary>
    [TerraformProperty("application_tenant_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ApplicationTenantId { get; }

    /// <summary>
    /// Description of the service principal provided for internal end-users
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// Block of features configured for this service principal using tags
    /// </summary>
    [TerraformProperty("feature_tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> FeatureTags { get; }

    /// <summary>
    /// Block of features configured for this service principal using tags
    /// </summary>
    [TerraformProperty("features")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Features { get; }

    /// <summary>
    /// Home page or landing page of the application
    /// </summary>
    [TerraformProperty("homepage_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HomepageUrl { get; }

    /// <summary>
    /// The URL where the service provider redirects the user to Azure AD to authenticate. Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps
    /// </summary>
    [TerraformProperty("login_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LoginUrl { get; }

    /// <summary>
    /// The URL that will be used by Microsoft&#39;s authorization service to sign out a user using front-channel, back-channel or SAML logout protocols
    /// </summary>
    [TerraformProperty("logout_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LogoutUrl { get; }

    /// <summary>
    /// Free text field to capture information about the service principal, typically used for operational purposes
    /// </summary>
    [TerraformProperty("notes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Notes { get; }

    /// <summary>
    /// List of email addresses where Azure AD sends a notification when the active certificate is near the expiration date. This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications
    /// </summary>
    [TerraformProperty("notification_email_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> NotificationEmailAddresses { get; }

    /// <summary>
    /// Mapping of OAuth2.0 permission scope names to UUIDs
    /// </summary>
    [TerraformProperty("oauth2_permission_scope_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Oauth2PermissionScopeIds { get; }

    /// <summary>
    /// The oauth2_permission_scopes attribute.
    /// </summary>
    [TerraformProperty("oauth2_permission_scopes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Oauth2PermissionScopes { get; }

    /// <summary>
    /// The single sign-on mode configured for this application. Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps
    /// </summary>
    [TerraformProperty("preferred_single_sign_on_mode")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PreferredSingleSignOnMode { get; }

    /// <summary>
    /// The URLs where user tokens are sent for sign-in with the associated application, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent for the associated application
    /// </summary>
    [TerraformProperty("redirect_uris")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> RedirectUris { get; }

    /// <summary>
    /// The URL where the service exposes SAML metadata for federation
    /// </summary>
    [TerraformProperty("saml_metadata_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SamlMetadataUrl { get; }

    /// <summary>
    /// Settings related to SAML single sign-on
    /// </summary>
    [TerraformProperty("saml_single_sign_on")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SamlSingleSignOn { get; }

    /// <summary>
    /// A list of identifier URI(s), copied over from the associated application
    /// </summary>
    [TerraformProperty("service_principal_names")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ServicePrincipalNames { get; }

    /// <summary>
    /// The Microsoft account types that are supported for the associated application
    /// </summary>
    [TerraformProperty("sign_in_audience")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SignInAudience { get; }

    /// <summary>
    /// A set of tags to apply to the service principal
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Tags { get; }

    /// <summary>
    /// Identifies whether the service principal represents an application or a managed identity
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Type { get; }

}
