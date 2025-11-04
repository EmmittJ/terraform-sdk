using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

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
        this.DeclareOutput("client_id");
        this.DeclareOutput("disabled_by_microsoft");
        this.DeclareOutput("object_id");
        this.DeclareOutput("publisher_domain");
    }

    /// <summary>
    /// Description of the application as shown to end users
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display name for the application
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Configures the `groups` claim that the app expects issued in a user or OAuth access token
    /// </summary>
    public HashSet<string>? GroupMembershipClaims
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("group_membership_claims")?.Value;
        set => this.WithProperty("group_membership_claims", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// URL of the home page for the application
    /// </summary>
    public string? HomepageUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("homepage_url")?.Value;
        set => this.WithProperty("homepage_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether this application can request an access token using OAuth implicit flow
    /// </summary>
    public bool? ImplicitAccessTokenIssuanceEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("implicit_access_token_issuance_enabled")?.Value;
        set => this.WithProperty("implicit_access_token_issuance_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Whether this application can request an ID token using OAuth implicit flow
    /// </summary>
    public bool? ImplicitIdTokenIssuanceEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("implicit_id_token_issuance_enabled")?.Value;
        set => this.WithProperty("implicit_id_token_issuance_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// URL of the logout page for the application, where the session is cleared for single sign-out
    /// </summary>
    public string? LogoutUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("logout_url")?.Value;
        set => this.WithProperty("logout_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// URL of the marketing page for the application
    /// </summary>
    public string? MarketingUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("marketing_url")?.Value;
        set => this.WithProperty("marketing_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// User-specified notes relevant for the management of the application
    /// </summary>
    public string? Notes
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notes")?.Value;
        set => this.WithProperty("notes", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// URL of the privacy statement for the application
    /// </summary>
    public string? PrivacyStatementUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("privacy_statement_url")?.Value;
        set => this.WithProperty("privacy_statement_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The access token version expected by this resource
    /// </summary>
    public double? RequestedAccessTokenVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("requested_access_token_version")?.Value;
        set => this.WithProperty("requested_access_token_version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// References application or contact information from a service or asset management database
    /// </summary>
    public string? ServiceManagementReference
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_management_reference")?.Value;
        set => this.WithProperty("service_management_reference", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Microsoft account types that are supported for the current application
    /// </summary>
    public string? SignInAudience
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sign_in_audience")?.Value;
        set => this.WithProperty("sign_in_audience", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// URL of the support page for the application
    /// </summary>
    public string? SupportUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("support_url")?.Value;
        set => this.WithProperty("support_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// URL of the terms of service statement for the application
    /// </summary>
    public string? TermsOfServiceUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("terms_of_service_url")?.Value;
        set => this.WithProperty("terms_of_service_url", value == null ? null : new TerraformLiteralProperty<string>(value));
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
