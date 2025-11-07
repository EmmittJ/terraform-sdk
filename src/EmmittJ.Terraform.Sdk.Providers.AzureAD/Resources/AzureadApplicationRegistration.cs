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
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display name for the application
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Configures the `groups` claim that the app expects issued in a user or OAuth access token
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? GroupMembershipClaims
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("group_membership_claims");
        set => this.WithProperty("group_membership_claims", value);
    }

    /// <summary>
    /// URL of the home page for the application
    /// </summary>
    public TerraformLiteralProperty<string>? HomepageUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("homepage_url");
        set => this.WithProperty("homepage_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Whether this application can request an access token using OAuth implicit flow
    /// </summary>
    public TerraformLiteralProperty<bool>? ImplicitAccessTokenIssuanceEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("implicit_access_token_issuance_enabled");
        set => this.WithProperty("implicit_access_token_issuance_enabled", value);
    }

    /// <summary>
    /// Whether this application can request an ID token using OAuth implicit flow
    /// </summary>
    public TerraformLiteralProperty<bool>? ImplicitIdTokenIssuanceEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("implicit_id_token_issuance_enabled");
        set => this.WithProperty("implicit_id_token_issuance_enabled", value);
    }

    /// <summary>
    /// URL of the logout page for the application, where the session is cleared for single sign-out
    /// </summary>
    public TerraformLiteralProperty<string>? LogoutUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("logout_url");
        set => this.WithProperty("logout_url", value);
    }

    /// <summary>
    /// URL of the marketing page for the application
    /// </summary>
    public TerraformLiteralProperty<string>? MarketingUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("marketing_url");
        set => this.WithProperty("marketing_url", value);
    }

    /// <summary>
    /// User-specified notes relevant for the management of the application
    /// </summary>
    public TerraformLiteralProperty<string>? Notes
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notes");
        set => this.WithProperty("notes", value);
    }

    /// <summary>
    /// URL of the privacy statement for the application
    /// </summary>
    public TerraformLiteralProperty<string>? PrivacyStatementUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("privacy_statement_url");
        set => this.WithProperty("privacy_statement_url", value);
    }

    /// <summary>
    /// The access token version expected by this resource
    /// </summary>
    public TerraformLiteralProperty<double>? RequestedAccessTokenVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("requested_access_token_version");
        set => this.WithProperty("requested_access_token_version", value);
    }

    /// <summary>
    /// References application or contact information from a service or asset management database
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceManagementReference
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_management_reference");
        set => this.WithProperty("service_management_reference", value);
    }

    /// <summary>
    /// The Microsoft account types that are supported for the current application
    /// </summary>
    public TerraformLiteralProperty<string>? SignInAudience
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sign_in_audience");
        set => this.WithProperty("sign_in_audience", value);
    }

    /// <summary>
    /// URL of the support page for the application
    /// </summary>
    public TerraformLiteralProperty<string>? SupportUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("support_url");
        set => this.WithProperty("support_url", value);
    }

    /// <summary>
    /// URL of the terms of service statement for the application
    /// </summary>
    public TerraformLiteralProperty<string>? TermsOfServiceUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("terms_of_service_url");
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
