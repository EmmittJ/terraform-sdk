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
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display name for the application
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Configures the `groups` claim that the app expects issued in a user or OAuth access token
    /// </summary>
    public TerraformProperty<HashSet<string>>? GroupMembershipClaims
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("group_membership_claims");
        set => this.WithProperty("group_membership_claims", value);
    }

    /// <summary>
    /// URL of the home page for the application
    /// </summary>
    public TerraformProperty<string>? HomepageUrl
    {
        get => GetProperty<TerraformProperty<string>>("homepage_url");
        set => this.WithProperty("homepage_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Whether this application can request an access token using OAuth implicit flow
    /// </summary>
    public TerraformProperty<bool>? ImplicitAccessTokenIssuanceEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("implicit_access_token_issuance_enabled");
        set => this.WithProperty("implicit_access_token_issuance_enabled", value);
    }

    /// <summary>
    /// Whether this application can request an ID token using OAuth implicit flow
    /// </summary>
    public TerraformProperty<bool>? ImplicitIdTokenIssuanceEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("implicit_id_token_issuance_enabled");
        set => this.WithProperty("implicit_id_token_issuance_enabled", value);
    }

    /// <summary>
    /// URL of the logout page for the application, where the session is cleared for single sign-out
    /// </summary>
    public TerraformProperty<string>? LogoutUrl
    {
        get => GetProperty<TerraformProperty<string>>("logout_url");
        set => this.WithProperty("logout_url", value);
    }

    /// <summary>
    /// URL of the marketing page for the application
    /// </summary>
    public TerraformProperty<string>? MarketingUrl
    {
        get => GetProperty<TerraformProperty<string>>("marketing_url");
        set => this.WithProperty("marketing_url", value);
    }

    /// <summary>
    /// User-specified notes relevant for the management of the application
    /// </summary>
    public TerraformProperty<string>? Notes
    {
        get => GetProperty<TerraformProperty<string>>("notes");
        set => this.WithProperty("notes", value);
    }

    /// <summary>
    /// URL of the privacy statement for the application
    /// </summary>
    public TerraformProperty<string>? PrivacyStatementUrl
    {
        get => GetProperty<TerraformProperty<string>>("privacy_statement_url");
        set => this.WithProperty("privacy_statement_url", value);
    }

    /// <summary>
    /// The access token version expected by this resource
    /// </summary>
    public TerraformProperty<double>? RequestedAccessTokenVersion
    {
        get => GetProperty<TerraformProperty<double>>("requested_access_token_version");
        set => this.WithProperty("requested_access_token_version", value);
    }

    /// <summary>
    /// References application or contact information from a service or asset management database
    /// </summary>
    public TerraformProperty<string>? ServiceManagementReference
    {
        get => GetProperty<TerraformProperty<string>>("service_management_reference");
        set => this.WithProperty("service_management_reference", value);
    }

    /// <summary>
    /// The Microsoft account types that are supported for the current application
    /// </summary>
    public TerraformProperty<string>? SignInAudience
    {
        get => GetProperty<TerraformProperty<string>>("sign_in_audience");
        set => this.WithProperty("sign_in_audience", value);
    }

    /// <summary>
    /// URL of the support page for the application
    /// </summary>
    public TerraformProperty<string>? SupportUrl
    {
        get => GetProperty<TerraformProperty<string>>("support_url");
        set => this.WithProperty("support_url", value);
    }

    /// <summary>
    /// URL of the terms of service statement for the application
    /// </summary>
    public TerraformProperty<string>? TermsOfServiceUrl
    {
        get => GetProperty<TerraformProperty<string>>("terms_of_service_url");
        set => this.WithProperty("terms_of_service_url", value);
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
