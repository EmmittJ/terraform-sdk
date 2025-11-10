using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for api in .
/// Nesting mode: list
/// </summary>
public class AzureadApplicationApiBlock : ITerraformBlock
{
    /// <summary>
    /// Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app
    /// </summary>
    [TerraformPropertyName("known_client_applications")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? KnownClientApplications { get; set; }

    /// <summary>
    /// Allows an application to use claims mapping without specifying a custom signing key
    /// </summary>
    [TerraformPropertyName("mapped_claims_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MappedClaimsEnabled { get; set; }

    /// <summary>
    /// The access token version expected by this resource
    /// </summary>
    [TerraformPropertyName("requested_access_token_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RequestedAccessTokenVersion { get; set; }

}

/// <summary>
/// Block type for app_role in .
/// Nesting mode: set
/// </summary>
public class AzureadApplicationAppRoleBlock : ITerraformBlock
{
    /// <summary>
    /// Specifies whether this app role definition can be assigned to users and groups by setting to `User`, or to other applications (that are accessing this application in a standalone scenario) by setting to `Application`, or to both
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMemberTypes is required")]
    [TerraformPropertyName("allowed_member_types")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AllowedMemberTypes { get; set; }

    /// <summary>
    /// Description of the app role that appears when the role is being assigned and, if the role functions as an application permissions, during the consent experiences
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformPropertyName("description")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Description { get; set; }

    /// <summary>
    /// Display name for the app role that appears during app role assignment and in consent experiences
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// Determines if the app role is enabled
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The unique identifier of the app role
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// The value that is used for the `roles` claim in ID tokens and OAuth 2.0 access tokens that are authenticating an assigned service or user principal
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Value { get; set; }

}

/// <summary>
/// Block type for feature_tags in .
/// Nesting mode: list
/// </summary>
public class AzureadApplicationFeatureTagsBlock : ITerraformBlock
{
    /// <summary>
    /// Whether this application represents a custom SAML application for linked service principals
    /// </summary>
    [TerraformPropertyName("custom_single_sign_on")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CustomSingleSignOn { get; set; }

    /// <summary>
    /// Whether this application represents an Enterprise Application for linked service principals
    /// </summary>
    [TerraformPropertyName("enterprise")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enterprise { get; set; }

    /// <summary>
    /// Whether this application represents a gallery application for linked service principals
    /// </summary>
    [TerraformPropertyName("gallery")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Gallery { get; set; }

    /// <summary>
    /// Whether this application is invisible to users in My Apps and Office 365 Launcher
    /// </summary>
    [TerraformPropertyName("hide")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Hide { get; set; }

}

/// <summary>
/// Block type for optional_claims in .
/// Nesting mode: list
/// </summary>
public class AzureadApplicationOptionalClaimsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for password in .
/// Nesting mode: set
/// </summary>
public class AzureadApplicationPasswordBlock : ITerraformBlock
{
    /// <summary>
    /// A display name for the password
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The end date until which the password is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`)
    /// </summary>
    [TerraformPropertyName("end_date")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EndDate { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "end_date");

    /// <summary>
    /// A UUID used to uniquely identify this password credential
    /// </summary>
    [TerraformPropertyName("key_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeyId => new TerraformReferenceProperty<TerraformProperty<string>>("", "key_id");

    /// <summary>
    /// The start date from which the password is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If this isn&#39;t specified, the current date is used
    /// </summary>
    [TerraformPropertyName("start_date")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StartDate { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "start_date");

    /// <summary>
    /// The password for this application, which is generated by Azure Active Directory
    /// </summary>
    [TerraformPropertyName("value")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Value => new TerraformReferenceProperty<TerraformProperty<string>>("", "value");

}

/// <summary>
/// Block type for public_client in .
/// Nesting mode: list
/// </summary>
public class AzureadApplicationPublicClientBlock : ITerraformBlock
{
    /// <summary>
    /// The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent
    /// </summary>
    [TerraformPropertyName("redirect_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? RedirectUris { get; set; }

}

/// <summary>
/// Block type for required_resource_access in .
/// Nesting mode: set
/// </summary>
public class AzureadApplicationRequiredResourceAccessBlock : ITerraformBlock
{
    /// <summary>
    /// The resource_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceAppId is required")]
    [TerraformPropertyName("resource_app_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceAppId { get; set; }

}

/// <summary>
/// Block type for single_page_application in .
/// Nesting mode: list
/// </summary>
public class AzureadApplicationSinglePageApplicationBlock : ITerraformBlock
{
    /// <summary>
    /// The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent
    /// </summary>
    [TerraformPropertyName("redirect_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? RedirectUris { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationTimeoutsBlock : ITerraformBlock
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
/// Block type for web in .
/// Nesting mode: list
/// </summary>
public class AzureadApplicationWebBlock : ITerraformBlock
{
    /// <summary>
    /// Home page or landing page of the application
    /// </summary>
    [TerraformPropertyName("homepage_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HomepageUrl { get; set; }

    /// <summary>
    /// The URL that will be used by Microsoft&#39;s authorization service to sign out a user using front-channel, back-channel or SAML logout protocols
    /// </summary>
    [TerraformPropertyName("logout_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LogoutUrl { get; set; }

    /// <summary>
    /// The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent
    /// </summary>
    [TerraformPropertyName("redirect_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? RedirectUris { get; set; }

}

/// <summary>
/// Manages a azuread_application resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzureadApplication : TerraformResource
{
    public AzureadApplication(string name) : base("azuread_application", name)
    {
    }

    /// <summary>
    /// Description of the application as shown to end users
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Specifies whether this application supports device authentication without a user.
    /// </summary>
    [TerraformPropertyName("device_only_auth_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeviceOnlyAuthEnabled { get; set; }

    /// <summary>
    /// The display name for the application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// Specifies whether the application is a public client. Appropriate for apps using token grant flows that don&#39;t use a redirect URI
    /// </summary>
    [TerraformPropertyName("fallback_public_client_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FallbackPublicClientEnabled { get; set; }

    /// <summary>
    /// Configures the `groups` claim issued in a user or OAuth 2.0 access token that the app expects
    /// </summary>
    [TerraformPropertyName("group_membership_claims")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? GroupMembershipClaims { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The user-defined URI(s) that uniquely identify an application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant
    /// </summary>
    [TerraformPropertyName("identifier_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentifierUris { get; set; }

    /// <summary>
    /// Base64 encoded logo image in gif, png or jpeg format
    /// </summary>
    [TerraformPropertyName("logo_image")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LogoImage { get; set; }

    /// <summary>
    /// URL of the application&#39;s marketing page
    /// </summary>
    [TerraformPropertyName("marketing_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MarketingUrl { get; set; }

    /// <summary>
    /// User-specified notes relevant for the management of the application
    /// </summary>
    [TerraformPropertyName("notes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Notes { get; set; }

    /// <summary>
    /// Specifies whether, as part of OAuth 2.0 token requests, Azure AD allows POST requests, as opposed to GET requests.
    /// </summary>
    [TerraformPropertyName("oauth2_post_response_required")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Oauth2PostResponseRequired { get; set; }

    /// <summary>
    /// A list of object IDs of principals that will be granted ownership of the application
    /// </summary>
    [TerraformPropertyName("owners")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Owners { get; set; }

    /// <summary>
    /// If `true`, will return an error if an existing application is found with the same name
    /// </summary>
    [TerraformPropertyName("prevent_duplicate_names")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PreventDuplicateNames { get; set; }

    /// <summary>
    /// URL of the application&#39;s privacy statement
    /// </summary>
    [TerraformPropertyName("privacy_statement_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrivacyStatementUrl { get; set; }

    /// <summary>
    /// References application or service contact information from a Service or Asset Management database
    /// </summary>
    [TerraformPropertyName("service_management_reference")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServiceManagementReference { get; set; }

    /// <summary>
    /// The Microsoft account types that are supported for the current application
    /// </summary>
    [TerraformPropertyName("sign_in_audience")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SignInAudience { get; set; }

    /// <summary>
    /// URL of the application&#39;s support page
    /// </summary>
    [TerraformPropertyName("support_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SupportUrl { get; set; }

    /// <summary>
    /// A set of tags to apply to the application
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// Unique ID of the application template from which this application is created
    /// </summary>
    [TerraformPropertyName("template_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TemplateId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "template_id");

    /// <summary>
    /// URL of the application&#39;s terms of service statement
    /// </summary>
    [TerraformPropertyName("terms_of_service_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TermsOfServiceUrl { get; set; }

    /// <summary>
    /// Block for api.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Api block(s) allowed")]
    [TerraformPropertyName("api")]
    public TerraformList<TerraformBlock<AzureadApplicationApiBlock>>? Api { get; set; } = new();

    /// <summary>
    /// Block for app_role.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("app_role")]
    public TerraformSet<TerraformBlock<AzureadApplicationAppRoleBlock>>? AppRole { get; set; } = new();

    /// <summary>
    /// Block for feature_tags.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("feature_tags")]
    public TerraformList<TerraformBlock<AzureadApplicationFeatureTagsBlock>>? FeatureTags { get; set; } = new();

    /// <summary>
    /// Block for optional_claims.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OptionalClaims block(s) allowed")]
    [TerraformPropertyName("optional_claims")]
    public TerraformList<TerraformBlock<AzureadApplicationOptionalClaimsBlock>>? OptionalClaims { get; set; } = new();

    /// <summary>
    /// Block for password.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Password block(s) allowed")]
    [TerraformPropertyName("password")]
    public TerraformSet<TerraformBlock<AzureadApplicationPasswordBlock>>? Password { get; set; } = new();

    /// <summary>
    /// Block for public_client.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicClient block(s) allowed")]
    [TerraformPropertyName("public_client")]
    public TerraformList<TerraformBlock<AzureadApplicationPublicClientBlock>>? PublicClient { get; set; } = new();

    /// <summary>
    /// Block for required_resource_access.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("required_resource_access")]
    public TerraformSet<TerraformBlock<AzureadApplicationRequiredResourceAccessBlock>>? RequiredResourceAccess { get; set; } = new();

    /// <summary>
    /// Block for single_page_application.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SinglePageApplication block(s) allowed")]
    [TerraformPropertyName("single_page_application")]
    public TerraformList<TerraformBlock<AzureadApplicationSinglePageApplicationBlock>>? SinglePageApplication { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadApplicationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for web.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Web block(s) allowed")]
    [TerraformPropertyName("web")]
    public TerraformList<TerraformBlock<AzureadApplicationWebBlock>>? Web { get; set; } = new();

    /// <summary>
    /// Mapping of app role names to UUIDs
    /// </summary>
    [TerraformPropertyName("app_role_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> AppRoleIds => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "app_role_ids");

    /// <summary>
    /// The Client ID (also called Application ID)
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClientId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "client_id");

    /// <summary>
    /// Whether Microsoft has disabled the registered application
    /// </summary>
    [TerraformPropertyName("disabled_by_microsoft")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisabledByMicrosoft => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "disabled_by_microsoft");

    /// <summary>
    /// CDN URL to the application&#39;s logo
    /// </summary>
    [TerraformPropertyName("logo_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LogoUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "logo_url");

    /// <summary>
    /// Mapping of OAuth2.0 permission scope names to UUIDs
    /// </summary>
    [TerraformPropertyName("oauth2_permission_scope_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Oauth2PermissionScopeIds => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "oauth2_permission_scope_ids");

    /// <summary>
    /// The application&#39;s object ID
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ObjectId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "object_id");

    /// <summary>
    /// The verified publisher domain for the application
    /// </summary>
    [TerraformPropertyName("publisher_domain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublisherDomain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "publisher_domain");

}
