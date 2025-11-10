using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationRegistrationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azuread_application_registration resource.
/// </summary>
public class AzureadApplicationRegistration : TerraformResource
{
    public AzureadApplicationRegistration(string name) : base("azuread_application_registration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("client_id");
        SetOutput("disabled_by_microsoft");
        SetOutput("object_id");
        SetOutput("publisher_domain");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("group_membership_claims");
        SetOutput("homepage_url");
        SetOutput("id");
        SetOutput("implicit_access_token_issuance_enabled");
        SetOutput("implicit_id_token_issuance_enabled");
        SetOutput("logout_url");
        SetOutput("marketing_url");
        SetOutput("notes");
        SetOutput("privacy_statement_url");
        SetOutput("requested_access_token_version");
        SetOutput("service_management_reference");
        SetOutput("sign_in_audience");
        SetOutput("support_url");
        SetOutput("terms_of_service_url");
    }

    /// <summary>
    /// Description of the application as shown to end users
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The display name for the application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Configures the `groups` claim that the app expects issued in a user or OAuth access token
    /// </summary>
    public HashSet<TerraformProperty<string>> GroupMembershipClaims
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("group_membership_claims");
        set => SetProperty("group_membership_claims", value);
    }

    /// <summary>
    /// URL of the home page for the application
    /// </summary>
    public TerraformProperty<string> HomepageUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("homepage_url");
        set => SetProperty("homepage_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Whether this application can request an access token using OAuth implicit flow
    /// </summary>
    public TerraformProperty<bool> ImplicitAccessTokenIssuanceEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("implicit_access_token_issuance_enabled");
        set => SetProperty("implicit_access_token_issuance_enabled", value);
    }

    /// <summary>
    /// Whether this application can request an ID token using OAuth implicit flow
    /// </summary>
    public TerraformProperty<bool> ImplicitIdTokenIssuanceEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("implicit_id_token_issuance_enabled");
        set => SetProperty("implicit_id_token_issuance_enabled", value);
    }

    /// <summary>
    /// URL of the logout page for the application, where the session is cleared for single sign-out
    /// </summary>
    public TerraformProperty<string> LogoutUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("logout_url");
        set => SetProperty("logout_url", value);
    }

    /// <summary>
    /// URL of the marketing page for the application
    /// </summary>
    public TerraformProperty<string> MarketingUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("marketing_url");
        set => SetProperty("marketing_url", value);
    }

    /// <summary>
    /// User-specified notes relevant for the management of the application
    /// </summary>
    public TerraformProperty<string> Notes
    {
        get => GetRequiredOutput<TerraformProperty<string>>("notes");
        set => SetProperty("notes", value);
    }

    /// <summary>
    /// URL of the privacy statement for the application
    /// </summary>
    public TerraformProperty<string> PrivacyStatementUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("privacy_statement_url");
        set => SetProperty("privacy_statement_url", value);
    }

    /// <summary>
    /// The access token version expected by this resource
    /// </summary>
    public TerraformProperty<double> RequestedAccessTokenVersion
    {
        get => GetRequiredOutput<TerraformProperty<double>>("requested_access_token_version");
        set => SetProperty("requested_access_token_version", value);
    }

    /// <summary>
    /// References application or contact information from a service or asset management database
    /// </summary>
    public TerraformProperty<string> ServiceManagementReference
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_management_reference");
        set => SetProperty("service_management_reference", value);
    }

    /// <summary>
    /// The Microsoft account types that are supported for the current application
    /// </summary>
    public TerraformProperty<string> SignInAudience
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sign_in_audience");
        set => SetProperty("sign_in_audience", value);
    }

    /// <summary>
    /// URL of the support page for the application
    /// </summary>
    public TerraformProperty<string> SupportUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("support_url");
        set => SetProperty("support_url", value);
    }

    /// <summary>
    /// URL of the terms of service statement for the application
    /// </summary>
    public TerraformProperty<string> TermsOfServiceUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("terms_of_service_url");
        set => SetProperty("terms_of_service_url", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadApplicationRegistrationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The Client ID (also called Application ID)
    /// </summary>
    public TerraformExpression ClientId => this["client_id"];

    /// <summary>
    /// If the application has been disabled by Microsoft, this shows the status or reason
    /// </summary>
    public TerraformExpression DisabledByMicrosoft => this["disabled_by_microsoft"];

    /// <summary>
    /// The object ID of the application within the tenant
    /// </summary>
    public TerraformExpression ObjectId => this["object_id"];

    /// <summary>
    /// The verified publisher domain for the application
    /// </summary>
    public TerraformExpression PublisherDomain => this["publisher_domain"];

}
