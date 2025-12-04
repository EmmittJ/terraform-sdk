using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for api in AzureadApplication.
/// Nesting mode: list
/// </summary>
public class AzureadApplicationApiBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "api";

    /// <summary>
    /// Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app
    /// </summary>
    public TerraformSet<string>? KnownClientApplications
    {
        get => GetArgument<TerraformSet<string>>("known_client_applications");
        set => SetArgument("known_client_applications", value);
    }

    /// <summary>
    /// Allows an application to use claims mapping without specifying a custom signing key
    /// </summary>
    public TerraformValue<bool>? MappedClaimsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("mapped_claims_enabled");
        set => SetArgument("mapped_claims_enabled", value);
    }

    /// <summary>
    /// The access token version expected by this resource
    /// </summary>
    public TerraformValue<double>? RequestedAccessTokenVersion
    {
        get => GetArgument<TerraformValue<double>>("requested_access_token_version");
        set => SetArgument("requested_access_token_version", value);
    }

    /// <summary>
    /// Oauth2PermissionScope block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzureadApplicationApiBlockOauth2PermissionScopeBlock>? Oauth2PermissionScope
    {
        get => GetArgument<TerraformSet<AzureadApplicationApiBlockOauth2PermissionScopeBlock>>("oauth2_permission_scope");
        set => SetArgument("oauth2_permission_scope", value);
    }

}

/// <summary>
/// Block type for oauth2_permission_scope in AzureadApplicationApiBlock.
/// Nesting mode: set
/// </summary>
public class AzureadApplicationApiBlockOauth2PermissionScopeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth2_permission_scope";

    /// <summary>
    /// Delegated permission description that appears in all tenant-wide admin consent experiences, intended to be read by an administrator granting the permission on behalf of all users
    /// </summary>
    public TerraformValue<string>? AdminConsentDescription
    {
        get => GetArgument<TerraformValue<string>>("admin_consent_description");
        set => SetArgument("admin_consent_description", value);
    }

    /// <summary>
    /// Display name for the delegated permission, intended to be read by an administrator granting the permission on behalf of all users
    /// </summary>
    public TerraformValue<string>? AdminConsentDisplayName
    {
        get => GetArgument<TerraformValue<string>>("admin_consent_display_name");
        set => SetArgument("admin_consent_display_name", value);
    }

    /// <summary>
    /// Determines if the permission scope is enabled
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The unique identifier of the delegated permission
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Delegated permission description that appears in the end user consent experience, intended to be read by a user consenting on their own behalf
    /// </summary>
    public TerraformValue<string>? UserConsentDescription
    {
        get => GetArgument<TerraformValue<string>>("user_consent_description");
        set => SetArgument("user_consent_description", value);
    }

    /// <summary>
    /// Display name for the delegated permission that appears in the end user consent experience
    /// </summary>
    public TerraformValue<string>? UserConsentDisplayName
    {
        get => GetArgument<TerraformValue<string>>("user_consent_display_name");
        set => SetArgument("user_consent_display_name", value);
    }

    /// <summary>
    /// The value that is used for the `scp` claim in OAuth 2.0 access tokens
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for app_role in AzureadApplication.
/// Nesting mode: set
/// </summary>
public class AzureadApplicationAppRoleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "app_role";

    /// <summary>
    /// Specifies whether this app role definition can be assigned to users and groups by setting to `User`, or to other applications (that are accessing this application in a standalone scenario) by setting to `Application`, or to both
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMemberTypes is required")]
    public required TerraformSet<string> AllowedMemberTypes
    {
        get => GetArgument<TerraformSet<string>>("allowed_member_types");
        set => SetArgument("allowed_member_types", value);
    }

    /// <summary>
    /// Description of the app role that appears when the role is being assigned and, if the role functions as an application permissions, during the consent experiences
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Display name for the app role that appears during app role assignment and in consent experiences
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Determines if the app role is enabled
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The unique identifier of the app role
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The value that is used for the `roles` claim in ID tokens and OAuth 2.0 access tokens that are authenticating an assigned service or user principal
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for feature_tags in AzureadApplication.
/// Nesting mode: list
/// </summary>
public class AzureadApplicationFeatureTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "feature_tags";

    /// <summary>
    /// Whether this application represents a custom SAML application for linked service principals
    /// </summary>
    public TerraformValue<bool>? CustomSingleSignOn
    {
        get => GetArgument<TerraformValue<bool>>("custom_single_sign_on");
        set => SetArgument("custom_single_sign_on", value);
    }

    /// <summary>
    /// Whether this application represents an Enterprise Application for linked service principals
    /// </summary>
    public TerraformValue<bool>? Enterprise
    {
        get => GetArgument<TerraformValue<bool>>("enterprise");
        set => SetArgument("enterprise", value);
    }

    /// <summary>
    /// Whether this application represents a gallery application for linked service principals
    /// </summary>
    public TerraformValue<bool>? Gallery
    {
        get => GetArgument<TerraformValue<bool>>("gallery");
        set => SetArgument("gallery", value);
    }

    /// <summary>
    /// Whether this application is invisible to users in My Apps and Office 365 Launcher
    /// </summary>
    public TerraformValue<bool>? Hide
    {
        get => GetArgument<TerraformValue<bool>>("hide");
        set => SetArgument("hide", value);
    }

}


/// <summary>
/// Block type for optional_claims in AzureadApplication.
/// Nesting mode: list
/// </summary>
public class AzureadApplicationOptionalClaimsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "optional_claims";

    /// <summary>
    /// AccessToken block (nesting mode: list).
    /// </summary>
    public TerraformList<AzureadApplicationOptionalClaimsBlockAccessTokenBlock>? AccessToken
    {
        get => GetArgument<TerraformList<AzureadApplicationOptionalClaimsBlockAccessTokenBlock>>("access_token");
        set => SetArgument("access_token", value);
    }

    /// <summary>
    /// IdToken block (nesting mode: list).
    /// </summary>
    public TerraformList<AzureadApplicationOptionalClaimsBlockIdTokenBlock>? IdToken
    {
        get => GetArgument<TerraformList<AzureadApplicationOptionalClaimsBlockIdTokenBlock>>("id_token");
        set => SetArgument("id_token", value);
    }

    /// <summary>
    /// Saml2Token block (nesting mode: list).
    /// </summary>
    public TerraformList<AzureadApplicationOptionalClaimsBlockSaml2TokenBlock>? Saml2Token
    {
        get => GetArgument<TerraformList<AzureadApplicationOptionalClaimsBlockSaml2TokenBlock>>("saml2_token");
        set => SetArgument("saml2_token", value);
    }

}

/// <summary>
/// Block type for access_token in AzureadApplicationOptionalClaimsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadApplicationOptionalClaimsBlockAccessTokenBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_token";

    /// <summary>
    /// List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim
    /// </summary>
    public TerraformList<string>? AdditionalProperties
    {
        get => GetArgument<TerraformList<string>>("additional_properties");
        set => SetArgument("additional_properties", value);
    }

    /// <summary>
    /// Whether the claim specified by the client is necessary to ensure a smooth authorization experience
    /// </summary>
    public TerraformValue<bool>? Essential
    {
        get => GetArgument<TerraformValue<bool>>("essential");
        set => SetArgument("essential", value);
    }

    /// <summary>
    /// The name of the optional claim
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object
    /// </summary>
    public TerraformValue<string>? Source
    {
        get => GetArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

}

/// <summary>
/// Block type for id_token in AzureadApplicationOptionalClaimsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadApplicationOptionalClaimsBlockIdTokenBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "id_token";

    /// <summary>
    /// List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim
    /// </summary>
    public TerraformList<string>? AdditionalProperties
    {
        get => GetArgument<TerraformList<string>>("additional_properties");
        set => SetArgument("additional_properties", value);
    }

    /// <summary>
    /// Whether the claim specified by the client is necessary to ensure a smooth authorization experience
    /// </summary>
    public TerraformValue<bool>? Essential
    {
        get => GetArgument<TerraformValue<bool>>("essential");
        set => SetArgument("essential", value);
    }

    /// <summary>
    /// The name of the optional claim
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object
    /// </summary>
    public TerraformValue<string>? Source
    {
        get => GetArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

}

/// <summary>
/// Block type for saml2_token in AzureadApplicationOptionalClaimsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadApplicationOptionalClaimsBlockSaml2TokenBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "saml2_token";

    /// <summary>
    /// List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim
    /// </summary>
    public TerraformList<string>? AdditionalProperties
    {
        get => GetArgument<TerraformList<string>>("additional_properties");
        set => SetArgument("additional_properties", value);
    }

    /// <summary>
    /// Whether the claim specified by the client is necessary to ensure a smooth authorization experience
    /// </summary>
    public TerraformValue<bool>? Essential
    {
        get => GetArgument<TerraformValue<bool>>("essential");
        set => SetArgument("essential", value);
    }

    /// <summary>
    /// The name of the optional claim
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object
    /// </summary>
    public TerraformValue<string>? Source
    {
        get => GetArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

}


/// <summary>
/// Block type for password in AzureadApplication.
/// Nesting mode: set
/// </summary>
public class AzureadApplicationPasswordBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "password";

    /// <summary>
    /// A display name for the password
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The end date until which the password is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`)
    /// </summary>
    public TerraformValue<string>? EndDate
    {
        get => GetArgument<TerraformValue<string>>("end_date");
        set => SetArgument("end_date", value);
    }

    /// <summary>
    /// A UUID used to uniquely identify this password credential
    /// </summary>
    public TerraformValue<string> KeyId
        => AsReference("key_id");

    /// <summary>
    /// The start date from which the password is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If this isn&#39;t specified, the current date is used
    /// </summary>
    public TerraformValue<string>? StartDate
    {
        get => GetArgument<TerraformValue<string>>("start_date");
        set => SetArgument("start_date", value);
    }

    /// <summary>
    /// The password for this application, which is generated by Azure Active Directory
    /// </summary>
    public TerraformValue<string> Value
        => AsReference("value");

}


/// <summary>
/// Block type for public_client in AzureadApplication.
/// Nesting mode: list
/// </summary>
public class AzureadApplicationPublicClientBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "public_client";

    /// <summary>
    /// The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent
    /// </summary>
    public TerraformSet<string>? RedirectUris
    {
        get => GetArgument<TerraformSet<string>>("redirect_uris");
        set => SetArgument("redirect_uris", value);
    }

}


/// <summary>
/// Block type for required_resource_access in AzureadApplication.
/// Nesting mode: set
/// </summary>
public class AzureadApplicationRequiredResourceAccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "required_resource_access";

    /// <summary>
    /// The resource_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceAppId is required")]
    public required TerraformValue<string> ResourceAppId
    {
        get => GetArgument<TerraformValue<string>>("resource_app_id");
        set => SetArgument("resource_app_id", value);
    }

    /// <summary>
    /// ResourceAccess block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceAccess is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ResourceAccess block(s) required")]
    public required TerraformList<AzureadApplicationRequiredResourceAccessBlockResourceAccessBlock> ResourceAccess
    {
        get => GetRequiredArgument<TerraformList<AzureadApplicationRequiredResourceAccessBlockResourceAccessBlock>>("resource_access");
        set => SetArgument("resource_access", value);
    }

}

/// <summary>
/// Block type for resource_access in AzureadApplicationRequiredResourceAccessBlock.
/// Nesting mode: list
/// </summary>
public class AzureadApplicationRequiredResourceAccessBlockResourceAccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_access";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for single_page_application in AzureadApplication.
/// Nesting mode: list
/// </summary>
public class AzureadApplicationSinglePageApplicationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "single_page_application";

    /// <summary>
    /// The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent
    /// </summary>
    public TerraformSet<string>? RedirectUris
    {
        get => GetArgument<TerraformSet<string>>("redirect_uris");
        set => SetArgument("redirect_uris", value);
    }

}


/// <summary>
/// Block type for timeouts in AzureadApplication.
/// Nesting mode: single
/// </summary>
public class AzureadApplicationTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for web in AzureadApplication.
/// Nesting mode: list
/// </summary>
public class AzureadApplicationWebBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "web";

    /// <summary>
    /// Home page or landing page of the application
    /// </summary>
    public TerraformValue<string>? HomepageUrl
    {
        get => GetArgument<TerraformValue<string>>("homepage_url");
        set => SetArgument("homepage_url", value);
    }

    /// <summary>
    /// The URL that will be used by Microsoft&#39;s authorization service to sign out a user using front-channel, back-channel or SAML logout protocols
    /// </summary>
    public TerraformValue<string>? LogoutUrl
    {
        get => GetArgument<TerraformValue<string>>("logout_url");
        set => SetArgument("logout_url", value);
    }

    /// <summary>
    /// The URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent
    /// </summary>
    public TerraformSet<string>? RedirectUris
    {
        get => GetArgument<TerraformSet<string>>("redirect_uris");
        set => SetArgument("redirect_uris", value);
    }

    /// <summary>
    /// ImplicitGrant block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImplicitGrant block(s) allowed")]
    public TerraformList<AzureadApplicationWebBlockImplicitGrantBlock>? ImplicitGrant
    {
        get => GetArgument<TerraformList<AzureadApplicationWebBlockImplicitGrantBlock>>("implicit_grant");
        set => SetArgument("implicit_grant", value);
    }

}

/// <summary>
/// Block type for implicit_grant in AzureadApplicationWebBlock.
/// Nesting mode: list
/// </summary>
public class AzureadApplicationWebBlockImplicitGrantBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "implicit_grant";

    /// <summary>
    /// Whether this web application can request an access token using OAuth 2.0 implicit flow
    /// </summary>
    public TerraformValue<bool>? AccessTokenIssuanceEnabled
    {
        get => GetArgument<TerraformValue<bool>>("access_token_issuance_enabled");
        set => SetArgument("access_token_issuance_enabled", value);
    }

    /// <summary>
    /// Whether this web application can request an ID token using OAuth 2.0 implicit flow
    /// </summary>
    public TerraformValue<bool>? IdTokenIssuanceEnabled
    {
        get => GetArgument<TerraformValue<bool>>("id_token_issuance_enabled");
        set => SetArgument("id_token_issuance_enabled", value);
    }

}


/// <summary>
/// Represents a azuread_application Terraform resource.
/// Manages a azuread_application resource.
/// </summary>
public partial class AzureadApplication(string name) : TerraformResource("azuread_application", name)
{
    /// <summary>
    /// Description of the application as shown to end users
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Specifies whether this application supports device authentication without a user.
    /// </summary>
    public TerraformValue<bool>? DeviceOnlyAuthEnabled
    {
        get => GetArgument<TerraformValue<bool>>("device_only_auth_enabled");
        set => SetArgument("device_only_auth_enabled", value);
    }

    /// <summary>
    /// The display name for the application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Specifies whether the application is a public client. Appropriate for apps using token grant flows that don&#39;t use a redirect URI
    /// </summary>
    public TerraformValue<bool>? FallbackPublicClientEnabled
    {
        get => GetArgument<TerraformValue<bool>>("fallback_public_client_enabled");
        set => SetArgument("fallback_public_client_enabled", value);
    }

    /// <summary>
    /// Configures the `groups` claim issued in a user or OAuth 2.0 access token that the app expects
    /// </summary>
    public TerraformSet<string>? GroupMembershipClaims
    {
        get => GetArgument<TerraformSet<string>>("group_membership_claims");
        set => SetArgument("group_membership_claims", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The user-defined URI(s) that uniquely identify an application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant
    /// </summary>
    public TerraformSet<string>? IdentifierUris
    {
        get => GetArgument<TerraformSet<string>>("identifier_uris");
        set => SetArgument("identifier_uris", value);
    }

    /// <summary>
    /// Base64 encoded logo image in gif, png or jpeg format
    /// </summary>
    public TerraformValue<string>? LogoImage
    {
        get => GetArgument<TerraformValue<string>>("logo_image");
        set => SetArgument("logo_image", value);
    }

    /// <summary>
    /// URL of the application&#39;s marketing page
    /// </summary>
    public TerraformValue<string>? MarketingUrl
    {
        get => GetArgument<TerraformValue<string>>("marketing_url");
        set => SetArgument("marketing_url", value);
    }

    /// <summary>
    /// User-specified notes relevant for the management of the application
    /// </summary>
    public TerraformValue<string>? Notes
    {
        get => GetArgument<TerraformValue<string>>("notes");
        set => SetArgument("notes", value);
    }

    /// <summary>
    /// Specifies whether, as part of OAuth 2.0 token requests, Azure AD allows POST requests, as opposed to GET requests.
    /// </summary>
    public TerraformValue<bool>? Oauth2PostResponseRequired
    {
        get => GetArgument<TerraformValue<bool>>("oauth2_post_response_required");
        set => SetArgument("oauth2_post_response_required", value);
    }

    /// <summary>
    /// A list of object IDs of principals that will be granted ownership of the application
    /// </summary>
    public TerraformSet<string>? Owners
    {
        get => GetArgument<TerraformSet<string>>("owners");
        set => SetArgument("owners", value);
    }

    /// <summary>
    /// If `true`, will return an error if an existing application is found with the same name
    /// </summary>
    public TerraformValue<bool>? PreventDuplicateNames
    {
        get => GetArgument<TerraformValue<bool>>("prevent_duplicate_names");
        set => SetArgument("prevent_duplicate_names", value);
    }

    /// <summary>
    /// URL of the application&#39;s privacy statement
    /// </summary>
    public TerraformValue<string>? PrivacyStatementUrl
    {
        get => GetArgument<TerraformValue<string>>("privacy_statement_url");
        set => SetArgument("privacy_statement_url", value);
    }

    /// <summary>
    /// References application or service contact information from a Service or Asset Management database
    /// </summary>
    public TerraformValue<string>? ServiceManagementReference
    {
        get => GetArgument<TerraformValue<string>>("service_management_reference");
        set => SetArgument("service_management_reference", value);
    }

    /// <summary>
    /// The Microsoft account types that are supported for the current application
    /// </summary>
    public TerraformValue<string>? SignInAudience
    {
        get => GetArgument<TerraformValue<string>>("sign_in_audience");
        set => SetArgument("sign_in_audience", value);
    }

    /// <summary>
    /// URL of the application&#39;s support page
    /// </summary>
    public TerraformValue<string>? SupportUrl
    {
        get => GetArgument<TerraformValue<string>>("support_url");
        set => SetArgument("support_url", value);
    }

    /// <summary>
    /// A set of tags to apply to the application
    /// </summary>
    public TerraformSet<string>? Tags
    {
        get => GetArgument<TerraformSet<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Unique ID of the application template from which this application is created
    /// </summary>
    public TerraformValue<string>? TemplateId
    {
        get => GetArgument<TerraformValue<string>>("template_id");
        set => SetArgument("template_id", value);
    }

    /// <summary>
    /// URL of the application&#39;s terms of service statement
    /// </summary>
    public TerraformValue<string>? TermsOfServiceUrl
    {
        get => GetArgument<TerraformValue<string>>("terms_of_service_url");
        set => SetArgument("terms_of_service_url", value);
    }

    /// <summary>
    /// Mapping of app role names to UUIDs
    /// </summary>
    public TerraformMap<string> AppRoleIds
        => AsReference("app_role_ids");

    /// <summary>
    /// The Client ID (also called Application ID)
    /// </summary>
    public TerraformValue<string> ClientId
        => AsReference("client_id");

    /// <summary>
    /// Whether Microsoft has disabled the registered application
    /// </summary>
    public TerraformValue<string> DisabledByMicrosoft
        => AsReference("disabled_by_microsoft");

    /// <summary>
    /// CDN URL to the application&#39;s logo
    /// </summary>
    public TerraformValue<string> LogoUrl
        => AsReference("logo_url");

    /// <summary>
    /// Mapping of OAuth2.0 permission scope names to UUIDs
    /// </summary>
    public TerraformMap<string> Oauth2PermissionScopeIds
        => AsReference("oauth2_permission_scope_ids");

    /// <summary>
    /// The application&#39;s object ID
    /// </summary>
    public TerraformValue<string> ObjectId
        => AsReference("object_id");

    /// <summary>
    /// The verified publisher domain for the application
    /// </summary>
    public TerraformValue<string> PublisherDomain
        => AsReference("publisher_domain");

    /// <summary>
    /// Api block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Api block(s) allowed")]
    public TerraformList<AzureadApplicationApiBlock>? Api
    {
        get => GetArgument<TerraformList<AzureadApplicationApiBlock>>("api");
        set => SetArgument("api", value);
    }

    /// <summary>
    /// AppRole block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzureadApplicationAppRoleBlock>? AppRole
    {
        get => GetArgument<TerraformSet<AzureadApplicationAppRoleBlock>>("app_role");
        set => SetArgument("app_role", value);
    }

    /// <summary>
    /// FeatureTags block (nesting mode: list).
    /// </summary>
    public TerraformList<AzureadApplicationFeatureTagsBlock>? FeatureTags
    {
        get => GetArgument<TerraformList<AzureadApplicationFeatureTagsBlock>>("feature_tags");
        set => SetArgument("feature_tags", value);
    }

    /// <summary>
    /// OptionalClaims block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OptionalClaims block(s) allowed")]
    public TerraformList<AzureadApplicationOptionalClaimsBlock>? OptionalClaims
    {
        get => GetArgument<TerraformList<AzureadApplicationOptionalClaimsBlock>>("optional_claims");
        set => SetArgument("optional_claims", value);
    }

    /// <summary>
    /// Password block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Password block(s) allowed")]
    public TerraformSet<AzureadApplicationPasswordBlock>? Password
    {
        get => GetArgument<TerraformSet<AzureadApplicationPasswordBlock>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// PublicClient block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicClient block(s) allowed")]
    public TerraformList<AzureadApplicationPublicClientBlock>? PublicClient
    {
        get => GetArgument<TerraformList<AzureadApplicationPublicClientBlock>>("public_client");
        set => SetArgument("public_client", value);
    }

    /// <summary>
    /// RequiredResourceAccess block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzureadApplicationRequiredResourceAccessBlock>? RequiredResourceAccess
    {
        get => GetArgument<TerraformSet<AzureadApplicationRequiredResourceAccessBlock>>("required_resource_access");
        set => SetArgument("required_resource_access", value);
    }

    /// <summary>
    /// SinglePageApplication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SinglePageApplication block(s) allowed")]
    public TerraformList<AzureadApplicationSinglePageApplicationBlock>? SinglePageApplication
    {
        get => GetArgument<TerraformList<AzureadApplicationSinglePageApplicationBlock>>("single_page_application");
        set => SetArgument("single_page_application", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadApplicationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadApplicationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Web block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Web block(s) allowed")]
    public TerraformList<AzureadApplicationWebBlock>? Web
    {
        get => GetArgument<TerraformList<AzureadApplicationWebBlock>>("web");
        set => SetArgument("web", value);
    }

}
