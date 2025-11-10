using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for feature_tags in .
/// Nesting mode: list
/// </summary>
public class AzureadServicePrincipalFeatureTagsBlock : ITerraformBlock
{
    /// <summary>
    /// Whether this service principal represents a custom SAML application
    /// </summary>
    [TerraformPropertyName("custom_single_sign_on")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CustomSingleSignOn { get; set; }

    /// <summary>
    /// Whether this service principal represents an Enterprise Application
    /// </summary>
    [TerraformPropertyName("enterprise")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enterprise { get; set; }

    /// <summary>
    /// Whether this service principal represents a gallery application
    /// </summary>
    [TerraformPropertyName("gallery")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Gallery { get; set; }

    /// <summary>
    /// Whether this app is invisible to users in My Apps and Office 365 Launcher
    /// </summary>
    [TerraformPropertyName("hide")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Hide { get; set; }

}

/// <summary>
/// Block type for features in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzureadServicePrincipalFeaturesBlock : ITerraformBlock
{
    /// <summary>
    /// Whether this service principal represents a custom SAML application
    /// </summary>
    [TerraformPropertyName("custom_single_sign_on_app")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CustomSingleSignOnApp { get; set; }

    /// <summary>
    /// Whether this service principal represents an Enterprise Application
    /// </summary>
    [TerraformPropertyName("enterprise_application")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnterpriseApplication { get; set; }

    /// <summary>
    /// Whether this service principal represents a gallery application
    /// </summary>
    [TerraformPropertyName("gallery_application")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? GalleryApplication { get; set; }

    /// <summary>
    /// Whether this app is visible to users in My Apps and Office 365 Launcher
    /// </summary>
    [TerraformPropertyName("visible_to_users")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? VisibleToUsers { get; set; }

}

/// <summary>
/// Block type for saml_single_sign_on in .
/// Nesting mode: list
/// </summary>
public class AzureadServicePrincipalSamlSingleSignOnBlock : ITerraformBlock
{
    /// <summary>
    /// The relative URI the service provider would redirect to after completion of the single sign-on flow
    /// </summary>
    [TerraformPropertyName("relay_state")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RelayState { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadServicePrincipalTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_service_principal resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzureadServicePrincipal : TerraformResource
{
    public AzureadServicePrincipal(string name) : base("azuread_service_principal", name)
    {
    }

    /// <summary>
    /// Whether or not the service principal account is enabled
    /// </summary>
    [TerraformPropertyName("account_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AccountEnabled { get; set; }

    /// <summary>
    /// A list of alternative names, used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities
    /// </summary>
    [TerraformPropertyName("alternative_names")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AlternativeNames { get; set; }

    /// <summary>
    /// Whether this service principal requires an app role assignment to a user or group before Azure AD will issue a user or access token to the application
    /// </summary>
    [TerraformPropertyName("app_role_assignment_required")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AppRoleAssignmentRequired { get; set; }

    /// <summary>
    /// The client ID of the application for which to create a service principal
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformPropertyName("client_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClientId { get; set; }

    /// <summary>
    /// Description of the service principal provided for internal end-users
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The URL where the service provider redirects the user to Azure AD to authenticate. Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps. When blank, Azure AD performs IdP-initiated sign-on for applications configured with SAML-based single sign-on
    /// </summary>
    [TerraformPropertyName("login_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LoginUrl { get; set; }

    /// <summary>
    /// Free text field to capture information about the service principal, typically used for operational purposes
    /// </summary>
    [TerraformPropertyName("notes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Notes { get; set; }

    /// <summary>
    /// List of email addresses where Azure AD sends a notification when the active certificate is near the expiration date. This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications
    /// </summary>
    [TerraformPropertyName("notification_email_addresses")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? NotificationEmailAddresses { get; set; }

    /// <summary>
    /// A list of object IDs of principals that will be granted ownership of the service principal
    /// </summary>
    [TerraformPropertyName("owners")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Owners { get; set; }

    /// <summary>
    /// The single sign-on mode configured for this application. Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps
    /// </summary>
    [TerraformPropertyName("preferred_single_sign_on_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PreferredSingleSignOnMode { get; set; }

    /// <summary>
    /// A set of tags to apply to the service principal
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// When true, the resource will return an existing service principal instead of failing with an error
    /// </summary>
    [TerraformPropertyName("use_existing")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseExisting { get; set; }

    /// <summary>
    /// Block for feature_tags.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("feature_tags")]
    public TerraformList<TerraformBlock<AzureadServicePrincipalFeatureTagsBlock>>? FeatureTags { get; set; } = new();

    /// <summary>
    /// Block for features.
    /// Nesting mode: list
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("features")]
    public TerraformList<TerraformBlock<AzureadServicePrincipalFeaturesBlock>>? Features { get; set; } = new();

    /// <summary>
    /// Block for saml_single_sign_on.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SamlSingleSignOn block(s) allowed")]
    [TerraformPropertyName("saml_single_sign_on")]
    public TerraformList<TerraformBlock<AzureadServicePrincipalSamlSingleSignOnBlock>>? SamlSingleSignOn { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadServicePrincipalTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Mapping of app role names to UUIDs
    /// </summary>
    [TerraformPropertyName("app_role_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> AppRoleIds => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "app_role_ids");

    /// <summary>
    /// The app_roles attribute.
    /// </summary>
    [TerraformPropertyName("app_roles")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AppRoles => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "app_roles");

    /// <summary>
    /// The tenant ID where the associated application is registered
    /// </summary>
    [TerraformPropertyName("application_tenant_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApplicationTenantId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "application_tenant_id");

    /// <summary>
    /// The display name of the application associated with this service principal
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// Home page or landing page of the application
    /// </summary>
    [TerraformPropertyName("homepage_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HomepageUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "homepage_url");

    /// <summary>
    /// The URL that will be used by Microsoft&#39;s authorization service to sign out a user using front-channel, back-channel or SAML logout protocols
    /// </summary>
    [TerraformPropertyName("logout_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LogoutUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "logout_url");

    /// <summary>
    /// Mapping of OAuth2.0 permission scope names to UUIDs
    /// </summary>
    [TerraformPropertyName("oauth2_permission_scope_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Oauth2PermissionScopeIds => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "oauth2_permission_scope_ids");

    /// <summary>
    /// The oauth2_permission_scopes attribute.
    /// </summary>
    [TerraformPropertyName("oauth2_permission_scopes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Oauth2PermissionScopes => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "oauth2_permission_scopes");

    /// <summary>
    /// The object ID of the service principal
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ObjectId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "object_id");

    /// <summary>
    /// The URLs where user tokens are sent for sign-in with the associated application, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent for the associated application
    /// </summary>
    [TerraformPropertyName("redirect_uris")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> RedirectUris => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "redirect_uris");

    /// <summary>
    /// The URL where the service exposes SAML metadata for federation
    /// </summary>
    [TerraformPropertyName("saml_metadata_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SamlMetadataUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "saml_metadata_url");

    /// <summary>
    /// A list of identifier URI(s), copied over from the associated application
    /// </summary>
    [TerraformPropertyName("service_principal_names")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ServicePrincipalNames => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "service_principal_names");

    /// <summary>
    /// The Microsoft account types that are supported for the associated application
    /// </summary>
    [TerraformPropertyName("sign_in_audience")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SignInAudience => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sign_in_audience");

    /// <summary>
    /// Identifies whether the service principal represents an application or a managed identity
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

}
