using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationRegistrationTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_application_registration resource.
/// </summary>
public class AzureadApplicationRegistration : TerraformResource
{
    public AzureadApplicationRegistration(string name) : base("azuread_application_registration", name)
    {
    }

    /// <summary>
    /// Description of the application as shown to end users
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display name for the application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Configures the `groups` claim that the app expects issued in a user or OAuth access token
    /// </summary>
    [TerraformPropertyName("group_membership_claims")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? GroupMembershipClaims { get; set; }

    /// <summary>
    /// URL of the home page for the application
    /// </summary>
    [TerraformPropertyName("homepage_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HomepageUrl { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Whether this application can request an access token using OAuth implicit flow
    /// </summary>
    [TerraformPropertyName("implicit_access_token_issuance_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ImplicitAccessTokenIssuanceEnabled { get; set; }

    /// <summary>
    /// Whether this application can request an ID token using OAuth implicit flow
    /// </summary>
    [TerraformPropertyName("implicit_id_token_issuance_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ImplicitIdTokenIssuanceEnabled { get; set; }

    /// <summary>
    /// URL of the logout page for the application, where the session is cleared for single sign-out
    /// </summary>
    [TerraformPropertyName("logout_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LogoutUrl { get; set; }

    /// <summary>
    /// URL of the marketing page for the application
    /// </summary>
    [TerraformPropertyName("marketing_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MarketingUrl { get; set; }

    /// <summary>
    /// User-specified notes relevant for the management of the application
    /// </summary>
    [TerraformPropertyName("notes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Notes { get; set; }

    /// <summary>
    /// URL of the privacy statement for the application
    /// </summary>
    [TerraformPropertyName("privacy_statement_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrivacyStatementUrl { get; set; }

    /// <summary>
    /// The access token version expected by this resource
    /// </summary>
    [TerraformPropertyName("requested_access_token_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RequestedAccessTokenVersion { get; set; }

    /// <summary>
    /// References application or contact information from a service or asset management database
    /// </summary>
    [TerraformPropertyName("service_management_reference")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServiceManagementReference { get; set; }

    /// <summary>
    /// The Microsoft account types that are supported for the current application
    /// </summary>
    [TerraformPropertyName("sign_in_audience")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SignInAudience { get; set; }

    /// <summary>
    /// URL of the support page for the application
    /// </summary>
    [TerraformPropertyName("support_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SupportUrl { get; set; }

    /// <summary>
    /// URL of the terms of service statement for the application
    /// </summary>
    [TerraformPropertyName("terms_of_service_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TermsOfServiceUrl { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadApplicationRegistrationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The Client ID (also called Application ID)
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClientId => new TerraformReference(this, "client_id");

    /// <summary>
    /// If the application has been disabled by Microsoft, this shows the status or reason
    /// </summary>
    [TerraformPropertyName("disabled_by_microsoft")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisabledByMicrosoft => new TerraformReference(this, "disabled_by_microsoft");

    /// <summary>
    /// The object ID of the application within the tenant
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ObjectId => new TerraformReference(this, "object_id");

    /// <summary>
    /// The verified publisher domain for the application
    /// </summary>
    [TerraformPropertyName("publisher_domain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublisherDomain => new TerraformReference(this, "publisher_domain");

}
