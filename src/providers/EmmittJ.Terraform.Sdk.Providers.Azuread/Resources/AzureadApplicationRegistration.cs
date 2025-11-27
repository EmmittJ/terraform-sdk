using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadApplicationRegistration.
/// Nesting mode: single
/// </summary>
public class AzureadApplicationRegistrationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azuread_application_registration Terraform resource.
/// Manages a azuread_application_registration resource.
/// </summary>
public partial class AzureadApplicationRegistration(string name) : TerraformResource("azuread_application_registration", name)
{
    /// <summary>
    /// Description of the application as shown to end users
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display name for the application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Configures the `groups` claim that the app expects issued in a user or OAuth access token
    /// </summary>
    public TerraformSet<string>? GroupMembershipClaims
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "group_membership_claims").ResolveNodes(ctx));
        set => SetArgument("group_membership_claims", value);
    }

    /// <summary>
    /// URL of the home page for the application
    /// </summary>
    public TerraformValue<string>? HomepageUrl
    {
        get => new TerraformReference<string>(this, "homepage_url");
        set => SetArgument("homepage_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Whether this application can request an access token using OAuth implicit flow
    /// </summary>
    public TerraformValue<bool>? ImplicitAccessTokenIssuanceEnabled
    {
        get => new TerraformReference<bool>(this, "implicit_access_token_issuance_enabled");
        set => SetArgument("implicit_access_token_issuance_enabled", value);
    }

    /// <summary>
    /// Whether this application can request an ID token using OAuth implicit flow
    /// </summary>
    public TerraformValue<bool>? ImplicitIdTokenIssuanceEnabled
    {
        get => new TerraformReference<bool>(this, "implicit_id_token_issuance_enabled");
        set => SetArgument("implicit_id_token_issuance_enabled", value);
    }

    /// <summary>
    /// URL of the logout page for the application, where the session is cleared for single sign-out
    /// </summary>
    public TerraformValue<string>? LogoutUrl
    {
        get => new TerraformReference<string>(this, "logout_url");
        set => SetArgument("logout_url", value);
    }

    /// <summary>
    /// URL of the marketing page for the application
    /// </summary>
    public TerraformValue<string>? MarketingUrl
    {
        get => new TerraformReference<string>(this, "marketing_url");
        set => SetArgument("marketing_url", value);
    }

    /// <summary>
    /// User-specified notes relevant for the management of the application
    /// </summary>
    public TerraformValue<string>? Notes
    {
        get => new TerraformReference<string>(this, "notes");
        set => SetArgument("notes", value);
    }

    /// <summary>
    /// URL of the privacy statement for the application
    /// </summary>
    public TerraformValue<string>? PrivacyStatementUrl
    {
        get => new TerraformReference<string>(this, "privacy_statement_url");
        set => SetArgument("privacy_statement_url", value);
    }

    /// <summary>
    /// The access token version expected by this resource
    /// </summary>
    public TerraformValue<double>? RequestedAccessTokenVersion
    {
        get => new TerraformReference<double>(this, "requested_access_token_version");
        set => SetArgument("requested_access_token_version", value);
    }

    /// <summary>
    /// References application or contact information from a service or asset management database
    /// </summary>
    public TerraformValue<string>? ServiceManagementReference
    {
        get => new TerraformReference<string>(this, "service_management_reference");
        set => SetArgument("service_management_reference", value);
    }

    /// <summary>
    /// The Microsoft account types that are supported for the current application
    /// </summary>
    public TerraformValue<string>? SignInAudience
    {
        get => new TerraformReference<string>(this, "sign_in_audience");
        set => SetArgument("sign_in_audience", value);
    }

    /// <summary>
    /// URL of the support page for the application
    /// </summary>
    public TerraformValue<string>? SupportUrl
    {
        get => new TerraformReference<string>(this, "support_url");
        set => SetArgument("support_url", value);
    }

    /// <summary>
    /// URL of the terms of service statement for the application
    /// </summary>
    public TerraformValue<string>? TermsOfServiceUrl
    {
        get => new TerraformReference<string>(this, "terms_of_service_url");
        set => SetArgument("terms_of_service_url", value);
    }

    /// <summary>
    /// The Client ID (also called Application ID)
    /// </summary>
    public TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
    }

    /// <summary>
    /// If the application has been disabled by Microsoft, this shows the status or reason
    /// </summary>
    public TerraformValue<string> DisabledByMicrosoft
    {
        get => new TerraformReference<string>(this, "disabled_by_microsoft");
    }

    /// <summary>
    /// The object ID of the application within the tenant
    /// </summary>
    public TerraformValue<string> ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
    }

    /// <summary>
    /// The verified publisher domain for the application
    /// </summary>
    public TerraformValue<string> PublisherDomain
    {
        get => new TerraformReference<string>(this, "publisher_domain");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadApplicationRegistrationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadApplicationRegistrationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
