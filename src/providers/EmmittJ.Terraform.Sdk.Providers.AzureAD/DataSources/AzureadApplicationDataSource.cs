using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadApplicationDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_application.
/// </summary>
public partial class AzureadApplicationDataSource : TerraformDataSource
{
    public AzureadApplicationDataSource(string name) : base("azuread_application", name)
    {
    }

    /// <summary>
    /// The Client ID (also called Application ID)
    /// </summary>
    [TerraformProperty("client_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// The display name for the application
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
    /// One of the application&#39;s identifier URIs
    /// </summary>
    [TerraformProperty("identifier_uri")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> IdentifierUri { get; set; }

    /// <summary>
    /// The application&#39;s object ID
    /// </summary>
    [TerraformProperty("object_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ObjectId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzureadApplicationDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The api attribute.
    /// </summary>
    [TerraformProperty("api")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Api { get; }

    /// <summary>
    /// Mapping of app role names to UUIDs
    /// </summary>
    [TerraformProperty("app_role_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> AppRoleIds { get; }

    /// <summary>
    /// List of app roles published by the application
    /// </summary>
    [TerraformProperty("app_roles")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AppRoles { get; }

    /// <summary>
    /// Description of the application as shown to end users
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// Specifies whether this application supports device authentication without a user.
    /// </summary>
    [TerraformProperty("device_only_auth_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> DeviceOnlyAuthEnabled { get; }

    /// <summary>
    /// Whether Microsoft has disabled the registered application
    /// </summary>
    [TerraformProperty("disabled_by_microsoft")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisabledByMicrosoft { get; }

    /// <summary>
    /// The fallback application type as public client, such as an installed application running on a mobile device
    /// </summary>
    [TerraformProperty("fallback_public_client_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> FallbackPublicClientEnabled { get; }

    /// <summary>
    /// Block of features configured for this application using tags
    /// </summary>
    [TerraformProperty("feature_tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> FeatureTags { get; }

    /// <summary>
    /// The `groups` claim issued in a user or OAuth 2.0 access token that the app expects
    /// </summary>
    [TerraformProperty("group_membership_claims")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> GroupMembershipClaims { get; }

    /// <summary>
    /// A list of user-defined URI(s) that uniquely identify a Web application within it&#39;s Azure AD tenant, or within a verified custom domain if the application is multi-tenant
    /// </summary>
    [TerraformProperty("identifier_uris")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> IdentifierUris { get; }

    /// <summary>
    /// CDN URL to the application&#39;s logo
    /// </summary>
    [TerraformProperty("logo_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LogoUrl { get; }

    /// <summary>
    /// URL of the application&#39;s marketing page
    /// </summary>
    [TerraformProperty("marketing_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MarketingUrl { get; }

    /// <summary>
    /// User-specified notes relevant for the management of the application
    /// </summary>
    [TerraformProperty("notes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Notes { get; }

    /// <summary>
    /// Mapping of OAuth2.0 permission scope names to UUIDs
    /// </summary>
    [TerraformProperty("oauth2_permission_scope_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Oauth2PermissionScopeIds { get; }

    /// <summary>
    /// Specifies whether, as part of OAuth 2.0 token requests, Azure AD allows POST requests, as opposed to GET requests.
    /// </summary>
    [TerraformProperty("oauth2_post_response_required")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Oauth2PostResponseRequired { get; }

    /// <summary>
    /// The optional_claims attribute.
    /// </summary>
    [TerraformProperty("optional_claims")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> OptionalClaims { get; }

    /// <summary>
    /// A list of object IDs of principals that are assigned ownership of the application
    /// </summary>
    [TerraformProperty("owners")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Owners { get; }

    /// <summary>
    /// URL of the application&#39;s privacy statement
    /// </summary>
    [TerraformProperty("privacy_statement_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrivacyStatementUrl { get; }

    /// <summary>
    /// The public_client attribute.
    /// </summary>
    [TerraformProperty("public_client")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PublicClient { get; }

    /// <summary>
    /// The verified publisher domain for the application
    /// </summary>
    [TerraformProperty("publisher_domain")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PublisherDomain { get; }

    /// <summary>
    /// The required_resource_access attribute.
    /// </summary>
    [TerraformProperty("required_resource_access")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RequiredResourceAccess { get; }

    /// <summary>
    /// References application or service contact information from a Service or Asset Management database
    /// </summary>
    [TerraformProperty("service_management_reference")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceManagementReference { get; }

    /// <summary>
    /// The Microsoft account types that are supported for the current application
    /// </summary>
    [TerraformProperty("sign_in_audience")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SignInAudience { get; }

    /// <summary>
    /// The single_page_application attribute.
    /// </summary>
    [TerraformProperty("single_page_application")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SinglePageApplication { get; }

    /// <summary>
    /// URL of the application&#39;s support page
    /// </summary>
    [TerraformProperty("support_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SupportUrl { get; }

    /// <summary>
    /// A set of tags applied to the application
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> Tags { get; }

    /// <summary>
    /// URL of the application&#39;s terms of service statement
    /// </summary>
    [TerraformProperty("terms_of_service_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TermsOfServiceUrl { get; }

    /// <summary>
    /// The web attribute.
    /// </summary>
    [TerraformProperty("web")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Web { get; }

}
