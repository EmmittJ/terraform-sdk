using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for api in .
/// Nesting mode: list
/// </summary>
public partial class AzureadApplicationApiBlock : TerraformBlockBase
{
    /// <summary>
    /// Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app
    /// </summary>
    [TerraformProperty("known_client_applications")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? KnownClientApplications { get; set; }

    /// <summary>
    /// Allows an application to use claims mapping without specifying a custom signing key
    /// </summary>
    [TerraformProperty("mapped_claims_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MappedClaimsEnabled { get; set; }

    /// <summary>
    /// The access token version expected by this resource
    /// </summary>
    [TerraformProperty("requested_access_token_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RequestedAccessTokenVersion { get; set; }

}

/// <summary>
/// Block type for app_role in .
/// Nesting mode: set
/// </summary>
public partial class AzureadApplicationAppRoleBlock : TerraformBlockBase
{
    /// <summary>
    /// Specifies whether this app role definition can be assigned to users and groups by setting to `User`, or to other applications (that are accessing this application in a standalone scenario) by setting to `Application`, or to both
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMemberTypes is required")]
    [TerraformProperty("allowed_member_types")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> AllowedMemberTypes { get; set; }

    /// <summary>
    /// Description of the app role that appears when the role is being assigned and, if the role functions as an application permissions, during the consent experiences
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformProperty("description")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// Display name for the app role that appears during app role assignment and in consent experiences
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Determines if the app role is enabled
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The unique identifier of the app role
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The value that is used for the `roles` claim in ID tokens and OAuth 2.0 access tokens that are authenticating an assigned service or user principal
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for feature_tags in .
/// Nesting mode: list
/// </summary>
public partial class AzureadApplicationFeatureTagsBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether this application represents a custom SAML application for linked service principals
    /// </summary>
    [TerraformProperty("custom_single_sign_on")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CustomSingleSignOn { get; set; }

    /// <summary>
    /// Whether this application represents an Enterprise Application for linked service principals
    /// </summary>
    [TerraformProperty("enterprise")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enterprise { get; set; }

    /// <summary>
    /// Whether this application represents a gallery application for linked service principals
    /// </summary>
    [TerraformProperty("gallery")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Gallery { get; set; }

    /// <summary>
    /// Whether this application is invisible to users in My Apps and Office 365 Launcher
    /// </summary>
    [TerraformProperty("hide")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Hide { get; set; }

}

/// <summary>
/// Block type for optional_claims in .
/// Nesting mode: list
/// </summary>
public partial class AzureadApplicationOptionalClaimsBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for password in .
/// Nesting mode: set
/// </summary>
public partial class AzureadApplicationPasswordBlock : TerraformBlockBase
{
    /// <summary>
    /// A display name for the password
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The end date until which the password is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`)
    /// </summary>
    [TerraformProperty("end_date")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EndDate { get; set; }


    /// <summary>
    /// The start date from which the password is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If this isn&#39;t specified, the current date is used
    /// </summary>
    [TerraformProperty("start_date")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StartDate { get; set; }


}

/// <summary>
/// Block type for public_client in .
/// Nesting mode: list
/// </summary>
public partial class AzureadApplicationPublicClientBlock : TerraformBlockBase
{
    /// <summary>
    /// The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent
    /// </summary>
    [TerraformProperty("redirect_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? RedirectUris { get; set; }

}

/// <summary>
/// Block type for required_resource_access in .
/// Nesting mode: set
/// </summary>
public partial class AzureadApplicationRequiredResourceAccessBlock : TerraformBlockBase
{
    /// <summary>
    /// The resource_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceAppId is required")]
    [TerraformProperty("resource_app_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceAppId { get; set; }

}

/// <summary>
/// Block type for single_page_application in .
/// Nesting mode: list
/// </summary>
public partial class AzureadApplicationSinglePageApplicationBlock : TerraformBlockBase
{
    /// <summary>
    /// The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent
    /// </summary>
    [TerraformProperty("redirect_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? RedirectUris { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadApplicationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for web in .
/// Nesting mode: list
/// </summary>
public partial class AzureadApplicationWebBlock : TerraformBlockBase
{
    /// <summary>
    /// Home page or landing page of the application
    /// </summary>
    [TerraformProperty("homepage_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HomepageUrl { get; set; }

    /// <summary>
    /// The URL that will be used by Microsoft&#39;s authorization service to sign out a user using front-channel, back-channel or SAML logout protocols
    /// </summary>
    [TerraformProperty("logout_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LogoutUrl { get; set; }

    /// <summary>
    /// The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent
    /// </summary>
    [TerraformProperty("redirect_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? RedirectUris { get; set; }

}

/// <summary>
/// Manages a azuread_application resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzureadApplication : TerraformResource
{
    public AzureadApplication(string name) : base("azuread_application", name)
    {
    }

    /// <summary>
    /// Description of the application as shown to end users
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Specifies whether this application supports device authentication without a user.
    /// </summary>
    [TerraformProperty("device_only_auth_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeviceOnlyAuthEnabled { get; set; }

    /// <summary>
    /// The display name for the application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Specifies whether the application is a public client. Appropriate for apps using token grant flows that don&#39;t use a redirect URI
    /// </summary>
    [TerraformProperty("fallback_public_client_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? FallbackPublicClientEnabled { get; set; }

    /// <summary>
    /// Configures the `groups` claim issued in a user or OAuth 2.0 access token that the app expects
    /// </summary>
    [TerraformProperty("group_membership_claims")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? GroupMembershipClaims { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The user-defined URI(s) that uniquely identify an application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant
    /// </summary>
    [TerraformProperty("identifier_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentifierUris { get; set; }

    /// <summary>
    /// Base64 encoded logo image in gif, png or jpeg format
    /// </summary>
    [TerraformProperty("logo_image")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LogoImage { get; set; }

    /// <summary>
    /// URL of the application&#39;s marketing page
    /// </summary>
    [TerraformProperty("marketing_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MarketingUrl { get; set; }

    /// <summary>
    /// User-specified notes relevant for the management of the application
    /// </summary>
    [TerraformProperty("notes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Notes { get; set; }

    /// <summary>
    /// Specifies whether, as part of OAuth 2.0 token requests, Azure AD allows POST requests, as opposed to GET requests.
    /// </summary>
    [TerraformProperty("oauth2_post_response_required")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Oauth2PostResponseRequired { get; set; }

    /// <summary>
    /// A list of object IDs of principals that will be granted ownership of the application
    /// </summary>
    [TerraformProperty("owners")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Owners { get; set; }

    /// <summary>
    /// If `true`, will return an error if an existing application is found with the same name
    /// </summary>
    [TerraformProperty("prevent_duplicate_names")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PreventDuplicateNames { get; set; }

    /// <summary>
    /// URL of the application&#39;s privacy statement
    /// </summary>
    [TerraformProperty("privacy_statement_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrivacyStatementUrl { get; set; }

    /// <summary>
    /// References application or service contact information from a Service or Asset Management database
    /// </summary>
    [TerraformProperty("service_management_reference")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceManagementReference { get; set; }

    /// <summary>
    /// The Microsoft account types that are supported for the current application
    /// </summary>
    [TerraformProperty("sign_in_audience")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SignInAudience { get; set; }

    /// <summary>
    /// URL of the application&#39;s support page
    /// </summary>
    [TerraformProperty("support_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SupportUrl { get; set; }

    /// <summary>
    /// A set of tags to apply to the application
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> Tags { get; set; }

    /// <summary>
    /// Unique ID of the application template from which this application is created
    /// </summary>
    [TerraformProperty("template_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TemplateId { get; set; }

    /// <summary>
    /// URL of the application&#39;s terms of service statement
    /// </summary>
    [TerraformProperty("terms_of_service_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TermsOfServiceUrl { get; set; }

    /// <summary>
    /// Block for api.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Api block(s) allowed")]
    [TerraformProperty("api")]
    public partial TerraformList<TerraformBlock<AzureadApplicationApiBlock>>? Api { get; set; }

    /// <summary>
    /// Block for app_role.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("app_role")]
    public partial TerraformSet<TerraformBlock<AzureadApplicationAppRoleBlock>>? AppRole { get; set; }

    /// <summary>
    /// Block for feature_tags.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("feature_tags")]
    public partial TerraformList<TerraformBlock<AzureadApplicationFeatureTagsBlock>>? FeatureTags { get; set; }

    /// <summary>
    /// Block for optional_claims.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OptionalClaims block(s) allowed")]
    [TerraformProperty("optional_claims")]
    public partial TerraformList<TerraformBlock<AzureadApplicationOptionalClaimsBlock>>? OptionalClaims { get; set; }

    /// <summary>
    /// Block for password.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Password block(s) allowed")]
    [TerraformProperty("password")]
    public partial TerraformSet<TerraformBlock<AzureadApplicationPasswordBlock>>? Password { get; set; }

    /// <summary>
    /// Block for public_client.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicClient block(s) allowed")]
    [TerraformProperty("public_client")]
    public partial TerraformList<TerraformBlock<AzureadApplicationPublicClientBlock>>? PublicClient { get; set; }

    /// <summary>
    /// Block for required_resource_access.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("required_resource_access")]
    public partial TerraformSet<TerraformBlock<AzureadApplicationRequiredResourceAccessBlock>>? RequiredResourceAccess { get; set; }

    /// <summary>
    /// Block for single_page_application.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SinglePageApplication block(s) allowed")]
    [TerraformProperty("single_page_application")]
    public partial TerraformList<TerraformBlock<AzureadApplicationSinglePageApplicationBlock>>? SinglePageApplication { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzureadApplicationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for web.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Web block(s) allowed")]
    [TerraformProperty("web")]
    public partial TerraformList<TerraformBlock<AzureadApplicationWebBlock>>? Web { get; set; }

    /// <summary>
    /// Mapping of app role names to UUIDs
    /// </summary>
    [TerraformProperty("app_role_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> AppRoleIds { get; }

    /// <summary>
    /// The Client ID (also called Application ID)
    /// </summary>
    [TerraformProperty("client_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClientId { get; }

    /// <summary>
    /// Whether Microsoft has disabled the registered application
    /// </summary>
    [TerraformProperty("disabled_by_microsoft")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisabledByMicrosoft { get; }

    /// <summary>
    /// CDN URL to the application&#39;s logo
    /// </summary>
    [TerraformProperty("logo_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LogoUrl { get; }

    /// <summary>
    /// Mapping of OAuth2.0 permission scope names to UUIDs
    /// </summary>
    [TerraformProperty("oauth2_permission_scope_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Oauth2PermissionScopeIds { get; }

    /// <summary>
    /// The application&#39;s object ID
    /// </summary>
    [TerraformProperty("object_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ObjectId { get; }

    /// <summary>
    /// The verified publisher domain for the application
    /// </summary>
    [TerraformProperty("publisher_domain")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublisherDomain { get; }

}
