using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for feature_tags in AzureadServicePrincipal.
/// Nesting mode: list
/// </summary>
public class AzureadServicePrincipalFeatureTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "feature_tags";

    /// <summary>
    /// Whether this service principal represents a custom SAML application
    /// </summary>
    public TerraformValue<bool>? CustomSingleSignOn
    {
        get => new TerraformReference<bool>(this, "custom_single_sign_on");
        set => SetArgument("custom_single_sign_on", value);
    }

    /// <summary>
    /// Whether this service principal represents an Enterprise Application
    /// </summary>
    public TerraformValue<bool>? Enterprise
    {
        get => new TerraformReference<bool>(this, "enterprise");
        set => SetArgument("enterprise", value);
    }

    /// <summary>
    /// Whether this service principal represents a gallery application
    /// </summary>
    public TerraformValue<bool>? Gallery
    {
        get => new TerraformReference<bool>(this, "gallery");
        set => SetArgument("gallery", value);
    }

    /// <summary>
    /// Whether this app is invisible to users in My Apps and Office 365 Launcher
    /// </summary>
    public TerraformValue<bool>? Hide
    {
        get => new TerraformReference<bool>(this, "hide");
        set => SetArgument("hide", value);
    }

}


/// <summary>
/// Block type for features in AzureadServicePrincipal.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzureadServicePrincipalFeaturesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "features";

    /// <summary>
    /// Whether this service principal represents a custom SAML application
    /// </summary>
    public TerraformValue<bool>? CustomSingleSignOnApp
    {
        get => new TerraformReference<bool>(this, "custom_single_sign_on_app");
        set => SetArgument("custom_single_sign_on_app", value);
    }

    /// <summary>
    /// Whether this service principal represents an Enterprise Application
    /// </summary>
    public TerraformValue<bool>? EnterpriseApplication
    {
        get => new TerraformReference<bool>(this, "enterprise_application");
        set => SetArgument("enterprise_application", value);
    }

    /// <summary>
    /// Whether this service principal represents a gallery application
    /// </summary>
    public TerraformValue<bool>? GalleryApplication
    {
        get => new TerraformReference<bool>(this, "gallery_application");
        set => SetArgument("gallery_application", value);
    }

    /// <summary>
    /// Whether this app is visible to users in My Apps and Office 365 Launcher
    /// </summary>
    public TerraformValue<bool>? VisibleToUsers
    {
        get => new TerraformReference<bool>(this, "visible_to_users");
        set => SetArgument("visible_to_users", value);
    }

}


/// <summary>
/// Block type for saml_single_sign_on in AzureadServicePrincipal.
/// Nesting mode: list
/// </summary>
public class AzureadServicePrincipalSamlSingleSignOnBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "saml_single_sign_on";

    /// <summary>
    /// The relative URI the service provider would redirect to after completion of the single sign-on flow
    /// </summary>
    public TerraformValue<string>? RelayState
    {
        get => new TerraformReference<string>(this, "relay_state");
        set => SetArgument("relay_state", value);
    }

}


/// <summary>
/// Block type for timeouts in AzureadServicePrincipal.
/// Nesting mode: single
/// </summary>
public class AzureadServicePrincipalTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_service_principal Terraform resource.
/// Manages a azuread_service_principal resource.
/// </summary>
public partial class AzureadServicePrincipal(string name) : TerraformResource("azuread_service_principal", name)
{
    /// <summary>
    /// Whether or not the service principal account is enabled
    /// </summary>
    public TerraformValue<bool>? AccountEnabled
    {
        get => new TerraformReference<bool>(this, "account_enabled");
        set => SetArgument("account_enabled", value);
    }

    /// <summary>
    /// A list of alternative names, used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities
    /// </summary>
    public TerraformSet<string>? AlternativeNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "alternative_names").ResolveNodes(ctx));
        set => SetArgument("alternative_names", value);
    }

    /// <summary>
    /// Whether this service principal requires an app role assignment to a user or group before Azure AD will issue a user or access token to the application
    /// </summary>
    public TerraformValue<bool>? AppRoleAssignmentRequired
    {
        get => new TerraformReference<bool>(this, "app_role_assignment_required");
        set => SetArgument("app_role_assignment_required", value);
    }

    /// <summary>
    /// The client ID of the application for which to create a service principal
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// Description of the service principal provided for internal end-users
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The URL where the service provider redirects the user to Azure AD to authenticate. Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps. When blank, Azure AD performs IdP-initiated sign-on for applications configured with SAML-based single sign-on
    /// </summary>
    public TerraformValue<string>? LoginUrl
    {
        get => new TerraformReference<string>(this, "login_url");
        set => SetArgument("login_url", value);
    }

    /// <summary>
    /// Free text field to capture information about the service principal, typically used for operational purposes
    /// </summary>
    public TerraformValue<string>? Notes
    {
        get => new TerraformReference<string>(this, "notes");
        set => SetArgument("notes", value);
    }

    /// <summary>
    /// List of email addresses where Azure AD sends a notification when the active certificate is near the expiration date. This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications
    /// </summary>
    public TerraformSet<string>? NotificationEmailAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "notification_email_addresses").ResolveNodes(ctx));
        set => SetArgument("notification_email_addresses", value);
    }

    /// <summary>
    /// A list of object IDs of principals that will be granted ownership of the service principal
    /// </summary>
    public TerraformSet<string>? Owners
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "owners").ResolveNodes(ctx));
        set => SetArgument("owners", value);
    }

    /// <summary>
    /// The single sign-on mode configured for this application. Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps
    /// </summary>
    public TerraformValue<string>? PreferredSingleSignOnMode
    {
        get => new TerraformReference<string>(this, "preferred_single_sign_on_mode");
        set => SetArgument("preferred_single_sign_on_mode", value);
    }

    /// <summary>
    /// A set of tags to apply to the service principal
    /// </summary>
    public TerraformSet<string> Tags
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// When true, the resource will return an existing service principal instead of failing with an error
    /// </summary>
    public TerraformValue<bool>? UseExisting
    {
        get => new TerraformReference<bool>(this, "use_existing");
        set => SetArgument("use_existing", value);
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
    /// The display name of the application associated with this service principal
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// Home page or landing page of the application
    /// </summary>
    public TerraformValue<string> HomepageUrl
    {
        get => new TerraformReference<string>(this, "homepage_url");
    }

    /// <summary>
    /// The URL that will be used by Microsoft&#39;s authorization service to sign out a user using front-channel, back-channel or SAML logout protocols
    /// </summary>
    public TerraformValue<string> LogoutUrl
    {
        get => new TerraformReference<string>(this, "logout_url");
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
    /// The object ID of the service principal
    /// </summary>
    public TerraformValue<string> ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
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
    /// Identifies whether the service principal represents an application or a managed identity
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// FeatureTags block (nesting mode: list).
    /// </summary>
    public TerraformList<AzureadServicePrincipalFeatureTagsBlock>? FeatureTags
    {
        get => GetArgument<TerraformList<AzureadServicePrincipalFeatureTagsBlock>>("feature_tags");
        set => SetArgument("feature_tags", value);
    }

    /// <summary>
    /// Features block (nesting mode: list).
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public TerraformList<AzureadServicePrincipalFeaturesBlock>? Features
    {
        get => GetArgument<TerraformList<AzureadServicePrincipalFeaturesBlock>>("features");
        set => SetArgument("features", value);
    }

    /// <summary>
    /// SamlSingleSignOn block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SamlSingleSignOn block(s) allowed")]
    public TerraformList<AzureadServicePrincipalSamlSingleSignOnBlock>? SamlSingleSignOn
    {
        get => GetArgument<TerraformList<AzureadServicePrincipalSamlSingleSignOnBlock>>("saml_single_sign_on");
        set => SetArgument("saml_single_sign_on", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadServicePrincipalTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadServicePrincipalTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
