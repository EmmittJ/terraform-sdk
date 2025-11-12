using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadApplicationRegistrationTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azuread_application_registration resource.
/// </summary>
public partial class AzureadApplicationRegistration : TerraformResource
{
    public AzureadApplicationRegistration(string name) : base("azuread_application_registration", name)
    {
    }

    /// <summary>
    /// Description of the application as shown to end users
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display name for the application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Configures the `groups` claim that the app expects issued in a user or OAuth access token
    /// </summary>
    [TerraformProperty("group_membership_claims")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? GroupMembershipClaims { get; set; }

    /// <summary>
    /// URL of the home page for the application
    /// </summary>
    [TerraformProperty("homepage_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HomepageUrl { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Whether this application can request an access token using OAuth implicit flow
    /// </summary>
    [TerraformProperty("implicit_access_token_issuance_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ImplicitAccessTokenIssuanceEnabled { get; set; }

    /// <summary>
    /// Whether this application can request an ID token using OAuth implicit flow
    /// </summary>
    [TerraformProperty("implicit_id_token_issuance_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ImplicitIdTokenIssuanceEnabled { get; set; }

    /// <summary>
    /// URL of the logout page for the application, where the session is cleared for single sign-out
    /// </summary>
    [TerraformProperty("logout_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LogoutUrl { get; set; }

    /// <summary>
    /// URL of the marketing page for the application
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
    /// URL of the privacy statement for the application
    /// </summary>
    [TerraformProperty("privacy_statement_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrivacyStatementUrl { get; set; }

    /// <summary>
    /// The access token version expected by this resource
    /// </summary>
    [TerraformProperty("requested_access_token_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RequestedAccessTokenVersion { get; set; }

    /// <summary>
    /// References application or contact information from a service or asset management database
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
    /// URL of the support page for the application
    /// </summary>
    [TerraformProperty("support_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SupportUrl { get; set; }

    /// <summary>
    /// URL of the terms of service statement for the application
    /// </summary>
    [TerraformProperty("terms_of_service_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TermsOfServiceUrl { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzureadApplicationRegistrationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The Client ID (also called Application ID)
    /// </summary>
    [TerraformProperty("client_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClientId { get; }

    /// <summary>
    /// If the application has been disabled by Microsoft, this shows the status or reason
    /// </summary>
    [TerraformProperty("disabled_by_microsoft")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisabledByMicrosoft { get; }

    /// <summary>
    /// The object ID of the application within the tenant
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
