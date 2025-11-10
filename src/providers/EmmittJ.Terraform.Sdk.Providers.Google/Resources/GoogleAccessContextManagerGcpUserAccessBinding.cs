using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for scoped_access_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for session_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerGcpUserAccessBindingSessionSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Optional. How long a user is allowed to take between actions before a new access token must be issued. Only set for Google Cloud apps.
    /// </summary>
    public TerraformProperty<string>? MaxInactivity
    {
        set => SetProperty("max_inactivity", value);
    }

    /// <summary>
    /// Optional. The session length. Setting this field to zero is equal to disabling session. Also can set infinite session by flipping the enabled bit to false below. If useOidcMaxAge is true, for OIDC apps, the session length will be the minimum of this field and OIDC max_age param.
    /// </summary>
    public TerraformProperty<string>? SessionLength
    {
        set => SetProperty("session_length", value);
    }

    /// <summary>
    /// Optional. This field enables or disables Google Cloud session length. When false, all fields set above will be disregarded and the session length is basically infinite.
    /// </summary>
    public TerraformProperty<bool>? SessionLengthEnabled
    {
        set => SetProperty("session_length_enabled", value);
    }

    /// <summary>
    /// Optional. The session challenges proposed to users when the Google Cloud session length is up. Possible values: [&amp;quot;LOGIN&amp;quot;, &amp;quot;SECURITY_KEY&amp;quot;, &amp;quot;PASSWORD&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? SessionReauthMethod
    {
        set => SetProperty("session_reauth_method", value);
    }

    /// <summary>
    /// Optional. Only useful for OIDC apps. When false, the OIDC max_age param, if passed in the authentication request will be ignored. When true, the re-auth period will be the minimum of the sessionLength field and the max_age OIDC param.
    /// </summary>
    public TerraformProperty<bool>? UseOidcMaxAge
    {
        set => SetProperty("use_oidc_max_age", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerGcpUserAccessBindingTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_access_context_manager_gcp_user_access_binding resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAccessContextManagerGcpUserAccessBinding : TerraformResource
{
    public GoogleAccessContextManagerGcpUserAccessBinding(string name) : base("google_access_context_manager_gcp_user_access_binding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("access_levels");
        SetOutput("group_key");
        SetOutput("id");
        SetOutput("organization_id");
    }

    /// <summary>
    /// Optional. Access level that a user must have to be granted access. Only one access level is supported, not multiple. This repeated field must have exactly one element. Example: &amp;quot;accessPolicies/9522/accessLevels/device_trusted&amp;quot;
    /// </summary>
    public List<TerraformProperty<string>> AccessLevels
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("access_levels");
        set => SetProperty("access_levels", value);
    }

    /// <summary>
    /// Required. Immutable. Google Group id whose members are subject to this binding&#39;s restrictions. See &amp;quot;id&amp;quot; in the G Suite Directory API&#39;s Groups resource. If a group&#39;s email address/alias is changed, this resource will continue to point at the changed group. This field does not accept group email addresses or aliases. Example: &amp;quot;01d520gv4vjcrht&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupKey is required")]
    public required TerraformProperty<string> GroupKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("group_key");
        set => SetProperty("group_key", value);
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
    /// Required. ID of the parent organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrganizationId is required")]
    public required TerraformProperty<string> OrganizationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("organization_id");
        set => SetProperty("organization_id", value);
    }

    /// <summary>
    /// Block for scoped_access_settings.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlock>? ScopedAccessSettings
    {
        set => SetProperty("scoped_access_settings", value);
    }

    /// <summary>
    /// Block for session_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SessionSettings block(s) allowed")]
    public List<GoogleAccessContextManagerGcpUserAccessBindingSessionSettingsBlock>? SessionSettings
    {
        set => SetProperty("session_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAccessContextManagerGcpUserAccessBindingTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Immutable. Assigned by the server during creation. The last segment has an arbitrary length and has only URI unreserved characters (as defined by RFC 3986 Section 2.3). Should not be specified by the client during creation. Example: &amp;quot;organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N&amp;quot;
    /// </summary>
    public TerraformExpression Name => this["name"];

}
