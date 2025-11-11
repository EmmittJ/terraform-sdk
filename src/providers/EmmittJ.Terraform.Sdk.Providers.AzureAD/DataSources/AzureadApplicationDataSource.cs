using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ClientId { get; set; } = default!;

    /// <summary>
    /// The display name for the application
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
    /// One of the application&#39;s identifier URIs
    /// </summary>
    [TerraformPropertyName("identifier_uri")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> IdentifierUri { get; set; } = default!;

    /// <summary>
    /// The application&#39;s object ID
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ObjectId { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadApplicationDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The api attribute.
    /// </summary>
    [TerraformPropertyName("api")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Api => new TerraformReference(this, "api");

    /// <summary>
    /// Mapping of app role names to UUIDs
    /// </summary>
    [TerraformPropertyName("app_role_ids")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> AppRoleIds => new TerraformReference(this, "app_role_ids");

    /// <summary>
    /// List of app roles published by the application
    /// </summary>
    [TerraformPropertyName("app_roles")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AppRoles => new TerraformReference(this, "app_roles");

    /// <summary>
    /// Description of the application as shown to end users
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// Specifies whether this application supports device authentication without a user.
    /// </summary>
    [TerraformPropertyName("device_only_auth_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DeviceOnlyAuthEnabled => new TerraformReference(this, "device_only_auth_enabled");

    /// <summary>
    /// Whether Microsoft has disabled the registered application
    /// </summary>
    [TerraformPropertyName("disabled_by_microsoft")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisabledByMicrosoft => new TerraformReference(this, "disabled_by_microsoft");

    /// <summary>
    /// The fallback application type as public client, such as an installed application running on a mobile device
    /// </summary>
    [TerraformPropertyName("fallback_public_client_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> FallbackPublicClientEnabled => new TerraformReference(this, "fallback_public_client_enabled");

    /// <summary>
    /// Block of features configured for this application using tags
    /// </summary>
    [TerraformPropertyName("feature_tags")]
    // Output-only attribute - read-only reference
    public TerraformList<object> FeatureTags => new TerraformReference(this, "feature_tags");

    /// <summary>
    /// The `groups` claim issued in a user or OAuth 2.0 access token that the app expects
    /// </summary>
    [TerraformPropertyName("group_membership_claims")]
    // Output-only attribute - read-only reference
    public TerraformList<string> GroupMembershipClaims => new TerraformReference(this, "group_membership_claims");

    /// <summary>
    /// A list of user-defined URI(s) that uniquely identify a Web application within it&#39;s Azure AD tenant, or within a verified custom domain if the application is multi-tenant
    /// </summary>
    [TerraformPropertyName("identifier_uris")]
    // Output-only attribute - read-only reference
    public TerraformList<string> IdentifierUris => new TerraformReference(this, "identifier_uris");

    /// <summary>
    /// CDN URL to the application&#39;s logo
    /// </summary>
    [TerraformPropertyName("logo_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LogoUrl => new TerraformReference(this, "logo_url");

    /// <summary>
    /// URL of the application&#39;s marketing page
    /// </summary>
    [TerraformPropertyName("marketing_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MarketingUrl => new TerraformReference(this, "marketing_url");

    /// <summary>
    /// User-specified notes relevant for the management of the application
    /// </summary>
    [TerraformPropertyName("notes")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Notes => new TerraformReference(this, "notes");

    /// <summary>
    /// Mapping of OAuth2.0 permission scope names to UUIDs
    /// </summary>
    [TerraformPropertyName("oauth2_permission_scope_ids")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Oauth2PermissionScopeIds => new TerraformReference(this, "oauth2_permission_scope_ids");

    /// <summary>
    /// Specifies whether, as part of OAuth 2.0 token requests, Azure AD allows POST requests, as opposed to GET requests.
    /// </summary>
    [TerraformPropertyName("oauth2_post_response_required")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Oauth2PostResponseRequired => new TerraformReference(this, "oauth2_post_response_required");

    /// <summary>
    /// The optional_claims attribute.
    /// </summary>
    [TerraformPropertyName("optional_claims")]
    // Output-only attribute - read-only reference
    public TerraformList<object> OptionalClaims => new TerraformReference(this, "optional_claims");

    /// <summary>
    /// A list of object IDs of principals that are assigned ownership of the application
    /// </summary>
    [TerraformPropertyName("owners")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Owners => new TerraformReference(this, "owners");

    /// <summary>
    /// URL of the application&#39;s privacy statement
    /// </summary>
    [TerraformPropertyName("privacy_statement_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivacyStatementUrl => new TerraformReference(this, "privacy_statement_url");

    /// <summary>
    /// The public_client attribute.
    /// </summary>
    [TerraformPropertyName("public_client")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PublicClient => new TerraformReference(this, "public_client");

    /// <summary>
    /// The verified publisher domain for the application
    /// </summary>
    [TerraformPropertyName("publisher_domain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublisherDomain => new TerraformReference(this, "publisher_domain");

    /// <summary>
    /// The required_resource_access attribute.
    /// </summary>
    [TerraformPropertyName("required_resource_access")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RequiredResourceAccess => new TerraformReference(this, "required_resource_access");

    /// <summary>
    /// References application or service contact information from a Service or Asset Management database
    /// </summary>
    [TerraformPropertyName("service_management_reference")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceManagementReference => new TerraformReference(this, "service_management_reference");

    /// <summary>
    /// The Microsoft account types that are supported for the current application
    /// </summary>
    [TerraformPropertyName("sign_in_audience")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SignInAudience => new TerraformReference(this, "sign_in_audience");

    /// <summary>
    /// The single_page_application attribute.
    /// </summary>
    [TerraformPropertyName("single_page_application")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SinglePageApplication => new TerraformReference(this, "single_page_application");

    /// <summary>
    /// URL of the application&#39;s support page
    /// </summary>
    [TerraformPropertyName("support_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SupportUrl => new TerraformReference(this, "support_url");

    /// <summary>
    /// A set of tags applied to the application
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// URL of the application&#39;s terms of service statement
    /// </summary>
    [TerraformPropertyName("terms_of_service_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TermsOfServiceUrl => new TerraformReference(this, "terms_of_service_url");

    /// <summary>
    /// The web attribute.
    /// </summary>
    [TerraformPropertyName("web")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Web => new TerraformReference(this, "web");

}
