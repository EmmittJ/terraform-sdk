using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_application.
/// </summary>
public class AzureadApplicationDataSource : TerraformDataSource
{
    public AzureadApplicationDataSource(string name) : base("azuread_application", name)
    {
    }

    /// <summary>
    /// The Client ID (also called Application ID)
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClientId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "client_id");

    /// <summary>
    /// The display name for the application
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DisplayName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// One of the application&#39;s identifier URIs
    /// </summary>
    [TerraformPropertyName("identifier_uri")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IdentifierUri { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "identifier_uri");

    /// <summary>
    /// The application&#39;s object ID
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ObjectId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "object_id");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadApplicationDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The api attribute.
    /// </summary>
    [TerraformPropertyName("api")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Api => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "api");

    /// <summary>
    /// Mapping of app role names to UUIDs
    /// </summary>
    [TerraformPropertyName("app_role_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> AppRoleIds => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "app_role_ids");

    /// <summary>
    /// List of app roles published by the application
    /// </summary>
    [TerraformPropertyName("app_roles")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AppRoles => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "app_roles");

    /// <summary>
    /// Description of the application as shown to end users
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// Specifies whether this application supports device authentication without a user.
    /// </summary>
    [TerraformPropertyName("device_only_auth_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DeviceOnlyAuthEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "device_only_auth_enabled");

    /// <summary>
    /// Whether Microsoft has disabled the registered application
    /// </summary>
    [TerraformPropertyName("disabled_by_microsoft")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisabledByMicrosoft => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "disabled_by_microsoft");

    /// <summary>
    /// The fallback application type as public client, such as an installed application running on a mobile device
    /// </summary>
    [TerraformPropertyName("fallback_public_client_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> FallbackPublicClientEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "fallback_public_client_enabled");

    /// <summary>
    /// Block of features configured for this application using tags
    /// </summary>
    [TerraformPropertyName("feature_tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> FeatureTags => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "feature_tags");

    /// <summary>
    /// The `groups` claim issued in a user or OAuth 2.0 access token that the app expects
    /// </summary>
    [TerraformPropertyName("group_membership_claims")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> GroupMembershipClaims => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "group_membership_claims");

    /// <summary>
    /// A list of user-defined URI(s) that uniquely identify a Web application within it&#39;s Azure AD tenant, or within a verified custom domain if the application is multi-tenant
    /// </summary>
    [TerraformPropertyName("identifier_uris")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> IdentifierUris => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "identifier_uris");

    /// <summary>
    /// CDN URL to the application&#39;s logo
    /// </summary>
    [TerraformPropertyName("logo_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LogoUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "logo_url");

    /// <summary>
    /// URL of the application&#39;s marketing page
    /// </summary>
    [TerraformPropertyName("marketing_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MarketingUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "marketing_url");

    /// <summary>
    /// User-specified notes relevant for the management of the application
    /// </summary>
    [TerraformPropertyName("notes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Notes => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "notes");

    /// <summary>
    /// Mapping of OAuth2.0 permission scope names to UUIDs
    /// </summary>
    [TerraformPropertyName("oauth2_permission_scope_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Oauth2PermissionScopeIds => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "oauth2_permission_scope_ids");

    /// <summary>
    /// Specifies whether, as part of OAuth 2.0 token requests, Azure AD allows POST requests, as opposed to GET requests.
    /// </summary>
    [TerraformPropertyName("oauth2_post_response_required")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Oauth2PostResponseRequired => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "oauth2_post_response_required");

    /// <summary>
    /// The optional_claims attribute.
    /// </summary>
    [TerraformPropertyName("optional_claims")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> OptionalClaims => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "optional_claims");

    /// <summary>
    /// A list of object IDs of principals that are assigned ownership of the application
    /// </summary>
    [TerraformPropertyName("owners")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Owners => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "owners");

    /// <summary>
    /// URL of the application&#39;s privacy statement
    /// </summary>
    [TerraformPropertyName("privacy_statement_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivacyStatementUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "privacy_statement_url");

    /// <summary>
    /// The public_client attribute.
    /// </summary>
    [TerraformPropertyName("public_client")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PublicClient => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "public_client");

    /// <summary>
    /// The verified publisher domain for the application
    /// </summary>
    [TerraformPropertyName("publisher_domain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublisherDomain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "publisher_domain");

    /// <summary>
    /// The required_resource_access attribute.
    /// </summary>
    [TerraformPropertyName("required_resource_access")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RequiredResourceAccess => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "required_resource_access");

    /// <summary>
    /// References application or service contact information from a Service or Asset Management database
    /// </summary>
    [TerraformPropertyName("service_management_reference")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceManagementReference => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_management_reference");

    /// <summary>
    /// The Microsoft account types that are supported for the current application
    /// </summary>
    [TerraformPropertyName("sign_in_audience")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SignInAudience => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sign_in_audience");

    /// <summary>
    /// The single_page_application attribute.
    /// </summary>
    [TerraformPropertyName("single_page_application")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SinglePageApplication => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "single_page_application");

    /// <summary>
    /// URL of the application&#39;s support page
    /// </summary>
    [TerraformPropertyName("support_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SupportUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "support_url");

    /// <summary>
    /// A set of tags applied to the application
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Tags => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// URL of the application&#39;s terms of service statement
    /// </summary>
    [TerraformPropertyName("terms_of_service_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TermsOfServiceUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "terms_of_service_url");

    /// <summary>
    /// The web attribute.
    /// </summary>
    [TerraformPropertyName("web")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Web => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "web");

}
