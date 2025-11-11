using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for feature_tags in .
/// Nesting mode: list
/// </summary>
public partial class AzureadServicePrincipalFeatureTagsBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether this service principal represents a custom SAML application
    /// </summary>
    [TerraformProperty("custom_single_sign_on")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? CustomSingleSignOn { get; set; }

    /// <summary>
    /// Whether this service principal represents an Enterprise Application
    /// </summary>
    [TerraformProperty("enterprise")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enterprise { get; set; }

    /// <summary>
    /// Whether this service principal represents a gallery application
    /// </summary>
    [TerraformProperty("gallery")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Gallery { get; set; }

    /// <summary>
    /// Whether this app is invisible to users in My Apps and Office 365 Launcher
    /// </summary>
    [TerraformProperty("hide")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Hide { get; set; }

}

/// <summary>
/// Block type for features in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AzureadServicePrincipalFeaturesBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether this service principal represents a custom SAML application
    /// </summary>
    [TerraformProperty("custom_single_sign_on_app")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? CustomSingleSignOnApp { get; set; }

    /// <summary>
    /// Whether this service principal represents an Enterprise Application
    /// </summary>
    [TerraformProperty("enterprise_application")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnterpriseApplication { get; set; }

    /// <summary>
    /// Whether this service principal represents a gallery application
    /// </summary>
    [TerraformProperty("gallery_application")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? GalleryApplication { get; set; }

    /// <summary>
    /// Whether this app is visible to users in My Apps and Office 365 Launcher
    /// </summary>
    [TerraformProperty("visible_to_users")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? VisibleToUsers { get; set; }

}

/// <summary>
/// Block type for saml_single_sign_on in .
/// Nesting mode: list
/// </summary>
public partial class AzureadServicePrincipalSamlSingleSignOnBlock : TerraformBlockBase
{
    /// <summary>
    /// The relative URI the service provider would redirect to after completion of the single sign-on flow
    /// </summary>
    [TerraformProperty("relay_state")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RelayState { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadServicePrincipalTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_service_principal resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzureadServicePrincipal : TerraformResource
{
    public AzureadServicePrincipal(string name) : base("azuread_service_principal", name)
    {
    }

    /// <summary>
    /// Whether or not the service principal account is enabled
    /// </summary>
    [TerraformProperty("account_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AccountEnabled { get; set; }

    /// <summary>
    /// A list of alternative names, used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities
    /// </summary>
    [TerraformProperty("alternative_names")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AlternativeNames { get; set; }

    /// <summary>
    /// Whether this service principal requires an app role assignment to a user or group before Azure AD will issue a user or access token to the application
    /// </summary>
    [TerraformProperty("app_role_assignment_required")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AppRoleAssignmentRequired { get; set; }

    /// <summary>
    /// The client ID of the application for which to create a service principal
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformProperty("client_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// Description of the service principal provided for internal end-users
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The URL where the service provider redirects the user to Azure AD to authenticate. Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps. When blank, Azure AD performs IdP-initiated sign-on for applications configured with SAML-based single sign-on
    /// </summary>
    [TerraformProperty("login_url")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LoginUrl { get; set; }

    /// <summary>
    /// Free text field to capture information about the service principal, typically used for operational purposes
    /// </summary>
    [TerraformProperty("notes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Notes { get; set; }

    /// <summary>
    /// List of email addresses where Azure AD sends a notification when the active certificate is near the expiration date. This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications
    /// </summary>
    [TerraformProperty("notification_email_addresses")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? NotificationEmailAddresses { get; set; }

    /// <summary>
    /// A list of object IDs of principals that will be granted ownership of the service principal
    /// </summary>
    [TerraformProperty("owners")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Owners { get; set; }

    /// <summary>
    /// The single sign-on mode configured for this application. Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps
    /// </summary>
    [TerraformProperty("preferred_single_sign_on_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PreferredSingleSignOnMode { get; set; }

    /// <summary>
    /// A set of tags to apply to the service principal
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> Tags { get; set; }

    /// <summary>
    /// When true, the resource will return an existing service principal instead of failing with an error
    /// </summary>
    [TerraformProperty("use_existing")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseExisting { get; set; }

    /// <summary>
    /// Block for feature_tags.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("feature_tags")]
    public TerraformList<TerraformBlock<AzureadServicePrincipalFeatureTagsBlock>>? FeatureTags { get; set; }

    /// <summary>
    /// Block for features.
    /// Nesting mode: list
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("features")]
    public TerraformList<TerraformBlock<AzureadServicePrincipalFeaturesBlock>>? Features { get; set; }

    /// <summary>
    /// Block for saml_single_sign_on.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SamlSingleSignOn block(s) allowed")]
    [TerraformProperty("saml_single_sign_on")]
    public TerraformList<TerraformBlock<AzureadServicePrincipalSamlSingleSignOnBlock>>? SamlSingleSignOn { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzureadServicePrincipalTimeoutsBlock>? Timeouts { get; set; }

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
    /// The display name of the application associated with this service principal
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// Home page or landing page of the application
    /// </summary>
    [TerraformProperty("homepage_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HomepageUrl { get; }

    /// <summary>
    /// The URL that will be used by Microsoft&#39;s authorization service to sign out a user using front-channel, back-channel or SAML logout protocols
    /// </summary>
    [TerraformProperty("logout_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LogoutUrl { get; }

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
    /// The object ID of the service principal
    /// </summary>
    [TerraformProperty("object_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ObjectId { get; }

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
    /// Identifies whether the service principal represents an application or a managed identity
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Type { get; }

}
