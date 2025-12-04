using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for scoped_access_settings in GoogleAccessContextManagerGcpUserAccessBinding.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scoped_access_settings";

    /// <summary>
    /// ActiveSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveSettings block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlockActiveSettingsBlock>? ActiveSettings
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlockActiveSettingsBlock>>("active_settings");
        set => SetArgument("active_settings", value);
    }

    /// <summary>
    /// DryRunSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DryRunSettings block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlockDryRunSettingsBlock>? DryRunSettings
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlockDryRunSettingsBlock>>("dry_run_settings");
        set => SetArgument("dry_run_settings", value);
    }

    /// <summary>
    /// Scope block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scope block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlockScopeBlock>? Scope
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlockScopeBlock>>("scope");
        set => SetArgument("scope", value);
    }

}

/// <summary>
/// Block type for active_settings in GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlockActiveSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "active_settings";

    /// <summary>
    /// Optional. Access level that a user must have to be granted access. Only one access level is supported, not multiple. This repeated field must have exactly one element. Example: &amp;quot;accessPolicies/9522/accessLevels/device_trusted&amp;quot;
    /// </summary>
    public TerraformList<string>? AccessLevels
    {
        get => GetArgument<TerraformList<string>>("access_levels");
        set => SetArgument("access_levels", value);
    }

    /// <summary>
    /// SessionSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SessionSettings block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlockActiveSettingsBlockSessionSettingsBlock>? SessionSettings
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlockActiveSettingsBlockSessionSettingsBlock>>("session_settings");
        set => SetArgument("session_settings", value);
    }

}

/// <summary>
/// Block type for session_settings in GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlockActiveSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlockActiveSettingsBlockSessionSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "session_settings";

    /// <summary>
    /// Optional. How long a user is allowed to take between actions before a new access token must be issued. Only set for Google Cloud apps.
    /// </summary>
    public TerraformValue<string>? MaxInactivity
    {
        get => GetArgument<TerraformValue<string>>("max_inactivity");
        set => SetArgument("max_inactivity", value);
    }

    /// <summary>
    /// Optional. The session length. Setting this field to zero is equal to disabling session. Also can set infinite session by flipping the enabled bit to false below. If useOidcMaxAge is true, for OIDC apps, the session length will be the minimum of this field and OIDC max_age param.
    /// </summary>
    public TerraformValue<string>? SessionLength
    {
        get => GetArgument<TerraformValue<string>>("session_length");
        set => SetArgument("session_length", value);
    }

    /// <summary>
    /// Optional. This field enables or disables Google Cloud session length. When false, all fields set above will be disregarded and the session length is basically infinite.
    /// </summary>
    public TerraformValue<bool>? SessionLengthEnabled
    {
        get => GetArgument<TerraformValue<bool>>("session_length_enabled");
        set => SetArgument("session_length_enabled", value);
    }

    /// <summary>
    /// Optional. The session challenges proposed to users when the Google Cloud session length is up. Possible values: [&amp;quot;LOGIN&amp;quot;, &amp;quot;SECURITY_KEY&amp;quot;, &amp;quot;PASSWORD&amp;quot;]
    /// </summary>
    public TerraformValue<string>? SessionReauthMethod
    {
        get => GetArgument<TerraformValue<string>>("session_reauth_method");
        set => SetArgument("session_reauth_method", value);
    }

    /// <summary>
    /// Optional. Only useful for OIDC apps. When false, the OIDC max_age param, if passed in the authentication request will be ignored. When true, the re-auth period will be the minimum of the sessionLength field and the max_age OIDC param.
    /// </summary>
    public TerraformValue<bool>? UseOidcMaxAge
    {
        get => GetArgument<TerraformValue<bool>>("use_oidc_max_age");
        set => SetArgument("use_oidc_max_age", value);
    }

}

/// <summary>
/// Block type for dry_run_settings in GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlockDryRunSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dry_run_settings";

    /// <summary>
    /// Optional. Access level that a user must have to be granted access. Only one access level is supported, not multiple. This repeated field must have exactly one element. Example: &amp;quot;accessPolicies/9522/accessLevels/device_trusted&amp;quot;
    /// </summary>
    public TerraformList<string>? AccessLevels
    {
        get => GetArgument<TerraformList<string>>("access_levels");
        set => SetArgument("access_levels", value);
    }

}

/// <summary>
/// Block type for scope in GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlockScopeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scope";

    /// <summary>
    /// ClientScope block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientScope block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlockScopeBlockClientScopeBlock>? ClientScope
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlockScopeBlockClientScopeBlock>>("client_scope");
        set => SetArgument("client_scope", value);
    }

}

/// <summary>
/// Block type for client_scope in GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlockScopeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlockScopeBlockClientScopeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_scope";

    /// <summary>
    /// RestrictedClientApplication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestrictedClientApplication block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlockScopeBlockClientScopeBlockRestrictedClientApplicationBlock>? RestrictedClientApplication
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlockScopeBlockClientScopeBlockRestrictedClientApplicationBlock>>("restricted_client_application");
        set => SetArgument("restricted_client_application", value);
    }

}

/// <summary>
/// Block type for restricted_client_application in GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlockScopeBlockClientScopeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlockScopeBlockClientScopeBlockRestrictedClientApplicationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "restricted_client_application";

    /// <summary>
    /// The OAuth client ID of the application.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The name of the application. Example: &amp;quot;Cloud Console&amp;quot;
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for session_settings in GoogleAccessContextManagerGcpUserAccessBinding.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerGcpUserAccessBindingSessionSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "session_settings";

    /// <summary>
    /// Optional. How long a user is allowed to take between actions before a new access token must be issued. Only set for Google Cloud apps.
    /// </summary>
    public TerraformValue<string>? MaxInactivity
    {
        get => GetArgument<TerraformValue<string>>("max_inactivity");
        set => SetArgument("max_inactivity", value);
    }

    /// <summary>
    /// Optional. The session length. Setting this field to zero is equal to disabling session. Also can set infinite session by flipping the enabled bit to false below. If useOidcMaxAge is true, for OIDC apps, the session length will be the minimum of this field and OIDC max_age param.
    /// </summary>
    public TerraformValue<string>? SessionLength
    {
        get => GetArgument<TerraformValue<string>>("session_length");
        set => SetArgument("session_length", value);
    }

    /// <summary>
    /// Optional. This field enables or disables Google Cloud session length. When false, all fields set above will be disregarded and the session length is basically infinite.
    /// </summary>
    public TerraformValue<bool>? SessionLengthEnabled
    {
        get => GetArgument<TerraformValue<bool>>("session_length_enabled");
        set => SetArgument("session_length_enabled", value);
    }

    /// <summary>
    /// Optional. The session challenges proposed to users when the Google Cloud session length is up. Possible values: [&amp;quot;LOGIN&amp;quot;, &amp;quot;SECURITY_KEY&amp;quot;, &amp;quot;PASSWORD&amp;quot;]
    /// </summary>
    public TerraformValue<string>? SessionReauthMethod
    {
        get => GetArgument<TerraformValue<string>>("session_reauth_method");
        set => SetArgument("session_reauth_method", value);
    }

    /// <summary>
    /// Optional. Only useful for OIDC apps. When false, the OIDC max_age param, if passed in the authentication request will be ignored. When true, the re-auth period will be the minimum of the sessionLength field and the max_age OIDC param.
    /// </summary>
    public TerraformValue<bool>? UseOidcMaxAge
    {
        get => GetArgument<TerraformValue<bool>>("use_oidc_max_age");
        set => SetArgument("use_oidc_max_age", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleAccessContextManagerGcpUserAccessBinding.
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerGcpUserAccessBindingTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_access_context_manager_gcp_user_access_binding Terraform resource.
/// Manages a google_access_context_manager_gcp_user_access_binding resource.
/// </summary>
public partial class GoogleAccessContextManagerGcpUserAccessBinding(string name) : TerraformResource("google_access_context_manager_gcp_user_access_binding", name)
{
    /// <summary>
    /// Optional. Access level that a user must have to be granted access. Only one access level is supported, not multiple. This repeated field must have exactly one element. Example: &amp;quot;accessPolicies/9522/accessLevels/device_trusted&amp;quot;
    /// </summary>
    public TerraformList<string>? AccessLevels
    {
        get => GetArgument<TerraformList<string>>("access_levels");
        set => SetArgument("access_levels", value);
    }

    /// <summary>
    /// Required. Immutable. Google Group id whose members are subject to this binding&#39;s restrictions. See &amp;quot;id&amp;quot; in the G Suite Directory API&#39;s Groups resource. If a group&#39;s email address/alias is changed, this resource will continue to point at the changed group. This field does not accept group email addresses or aliases. Example: &amp;quot;01d520gv4vjcrht&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupKey is required")]
    public required TerraformValue<string> GroupKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("group_key");
        set => SetArgument("group_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Required. ID of the parent organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrganizationId is required")]
    public required TerraformValue<string> OrganizationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("organization_id");
        set => SetArgument("organization_id", value);
    }

    /// <summary>
    /// Immutable. Assigned by the server during creation. The last segment has an arbitrary length and has only URI unreserved characters (as defined by RFC 3986 Section 2.3). Should not be specified by the client during creation. Example: &amp;quot;organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N&amp;quot;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// ScopedAccessSettings block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlock>? ScopedAccessSettings
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlock>>("scoped_access_settings");
        set => SetArgument("scoped_access_settings", value);
    }

    /// <summary>
    /// SessionSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SessionSettings block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerGcpUserAccessBindingSessionSettingsBlock>? SessionSettings
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerGcpUserAccessBindingSessionSettingsBlock>>("session_settings");
        set => SetArgument("session_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAccessContextManagerGcpUserAccessBindingTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAccessContextManagerGcpUserAccessBindingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
