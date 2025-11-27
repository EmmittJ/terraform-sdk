using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadServicePrincipalDataSource.
/// Nesting mode: single
/// </summary>
public class AzureadServicePrincipalDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azuread_service_principal Terraform data source.
/// Retrieves information about a azuread_service_principal.
/// </summary>
public partial class AzureadServicePrincipalDataSource(string name) : TerraformDataSource("azuread_service_principal", name)
{
    /// <summary>
    /// The client ID of the application associated with this service principal
    /// </summary>
    public TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The display name of the application associated with this service principal
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The object ID of the service principal
    /// </summary>
    public TerraformValue<string> ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// Whether or not the service principal account is enabled
    /// </summary>
    public TerraformValue<bool> AccountEnabled
    {
        get => new TerraformReference<bool>(this, "account_enabled");
    }

    /// <summary>
    /// A list of alternative names, used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities
    /// </summary>
    public TerraformList<string> AlternativeNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "alternative_names").ResolveNodes(ctx));
    }

    /// <summary>
    /// Whether this service principal requires an app role assignment to a user or group before Azure AD will issue a user or access token to the application
    /// </summary>
    public TerraformValue<bool> AppRoleAssignmentRequired
    {
        get => new TerraformReference<bool>(this, "app_role_assignment_required");
    }

    /// <summary>
    /// Mapping of app role names to UUIDs
    /// </summary>
    public TerraformMap<string> AppRoleIds
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "app_role_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The app_roles attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AppRoles
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "app_roles").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tenant ID where the associated application is registered
    /// </summary>
    public TerraformValue<string> ApplicationTenantId
    {
        get => new TerraformReference<string>(this, "application_tenant_id");
    }

    /// <summary>
    /// Description of the service principal provided for internal end-users
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// Block of features configured for this service principal using tags
    /// </summary>
    public TerraformList<TerraformMap<object>> FeatureTags
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "feature_tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// Block of features configured for this service principal using tags
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformList<TerraformMap<object>> Features
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "features").ResolveNodes(ctx));
    }

    /// <summary>
    /// Home page or landing page of the application
    /// </summary>
    public TerraformValue<string> HomepageUrl
    {
        get => new TerraformReference<string>(this, "homepage_url");
    }

    /// <summary>
    /// The URL where the service provider redirects the user to Azure AD to authenticate. Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps
    /// </summary>
    public TerraformValue<string> LoginUrl
    {
        get => new TerraformReference<string>(this, "login_url");
    }

    /// <summary>
    /// The URL that will be used by Microsoft&#39;s authorization service to sign out a user using front-channel, back-channel or SAML logout protocols
    /// </summary>
    public TerraformValue<string> LogoutUrl
    {
        get => new TerraformReference<string>(this, "logout_url");
    }

    /// <summary>
    /// Free text field to capture information about the service principal, typically used for operational purposes
    /// </summary>
    public TerraformValue<string> Notes
    {
        get => new TerraformReference<string>(this, "notes");
    }

    /// <summary>
    /// List of email addresses where Azure AD sends a notification when the active certificate is near the expiration date. This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications
    /// </summary>
    public TerraformList<string> NotificationEmailAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "notification_email_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// Mapping of OAuth2.0 permission scope names to UUIDs
    /// </summary>
    public TerraformMap<string> Oauth2PermissionScopeIds
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "oauth2_permission_scope_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The oauth2_permission_scopes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Oauth2PermissionScopes
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "oauth2_permission_scopes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The single sign-on mode configured for this application. Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps
    /// </summary>
    public TerraformValue<string> PreferredSingleSignOnMode
    {
        get => new TerraformReference<string>(this, "preferred_single_sign_on_mode");
    }

    /// <summary>
    /// The URLs where user tokens are sent for sign-in with the associated application, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent for the associated application
    /// </summary>
    public TerraformList<string> RedirectUris
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "redirect_uris").ResolveNodes(ctx));
    }

    /// <summary>
    /// The URL where the service exposes SAML metadata for federation
    /// </summary>
    public TerraformValue<string> SamlMetadataUrl
    {
        get => new TerraformReference<string>(this, "saml_metadata_url");
    }

    /// <summary>
    /// Settings related to SAML single sign-on
    /// </summary>
    public TerraformList<TerraformMap<object>> SamlSingleSignOn
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "saml_single_sign_on").ResolveNodes(ctx));
    }

    /// <summary>
    /// A list of identifier URI(s), copied over from the associated application
    /// </summary>
    public TerraformList<string> ServicePrincipalNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "service_principal_names").ResolveNodes(ctx));
    }

    /// <summary>
    /// The Microsoft account types that are supported for the associated application
    /// </summary>
    public TerraformValue<string> SignInAudience
    {
        get => new TerraformReference<string>(this, "sign_in_audience");
    }

    /// <summary>
    /// A set of tags to apply to the service principal
    /// </summary>
    public TerraformList<string> Tags
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// Identifies whether the service principal represents an application or a managed identity
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadServicePrincipalDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadServicePrincipalDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
