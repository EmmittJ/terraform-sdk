using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for scoped_access_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlock
{
}

/// <summary>
/// Block type for session_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerGcpUserAccessBindingSessionSettingsBlock
{
    /// <summary>
    /// Optional. How long a user is allowed to take between actions before a new access token must be issued. Only set for Google Cloud apps.
    /// </summary>
    [TerraformPropertyName("max_inactivity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaxInactivity { get; set; }

    /// <summary>
    /// Optional. The session length. Setting this field to zero is equal to disabling session. Also can set infinite session by flipping the enabled bit to false below. If useOidcMaxAge is true, for OIDC apps, the session length will be the minimum of this field and OIDC max_age param.
    /// </summary>
    [TerraformPropertyName("session_length")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SessionLength { get; set; }

    /// <summary>
    /// Optional. This field enables or disables Google Cloud session length. When false, all fields set above will be disregarded and the session length is basically infinite.
    /// </summary>
    [TerraformPropertyName("session_length_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SessionLengthEnabled { get; set; }

    /// <summary>
    /// Optional. The session challenges proposed to users when the Google Cloud session length is up. Possible values: [&amp;quot;LOGIN&amp;quot;, &amp;quot;SECURITY_KEY&amp;quot;, &amp;quot;PASSWORD&amp;quot;]
    /// </summary>
    [TerraformPropertyName("session_reauth_method")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SessionReauthMethod { get; set; }

    /// <summary>
    /// Optional. Only useful for OIDC apps. When false, the OIDC max_age param, if passed in the authentication request will be ignored. When true, the re-auth period will be the minimum of the sessionLength field and the max_age OIDC param.
    /// </summary>
    [TerraformPropertyName("use_oidc_max_age")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UseOidcMaxAge { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerGcpUserAccessBindingTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_access_context_manager_gcp_user_access_binding resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAccessContextManagerGcpUserAccessBinding : TerraformResource
{
    public GoogleAccessContextManagerGcpUserAccessBinding(string name) : base("google_access_context_manager_gcp_user_access_binding", name)
    {
    }

    /// <summary>
    /// Optional. Access level that a user must have to be granted access. Only one access level is supported, not multiple. This repeated field must have exactly one element. Example: &amp;quot;accessPolicies/9522/accessLevels/device_trusted&amp;quot;
    /// </summary>
    [TerraformPropertyName("access_levels")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? AccessLevels { get; set; }

    /// <summary>
    /// Required. Immutable. Google Group id whose members are subject to this binding&#39;s restrictions. See &amp;quot;id&amp;quot; in the G Suite Directory API&#39;s Groups resource. If a group&#39;s email address/alias is changed, this resource will continue to point at the changed group. This field does not accept group email addresses or aliases. Example: &amp;quot;01d520gv4vjcrht&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupKey is required")]
    [TerraformPropertyName("group_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GroupKey { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Required. ID of the parent organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrganizationId is required")]
    [TerraformPropertyName("organization_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OrganizationId { get; set; }

    /// <summary>
    /// Block for scoped_access_settings.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("scoped_access_settings")]
    public TerraformList<TerraformBlock<GoogleAccessContextManagerGcpUserAccessBindingScopedAccessSettingsBlock>>? ScopedAccessSettings { get; set; }

    /// <summary>
    /// Block for session_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SessionSettings block(s) allowed")]
    [TerraformPropertyName("session_settings")]
    public TerraformList<TerraformBlock<GoogleAccessContextManagerGcpUserAccessBindingSessionSettingsBlock>>? SessionSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleAccessContextManagerGcpUserAccessBindingTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Immutable. Assigned by the server during creation. The last segment has an arbitrary length and has only URI unreserved characters (as defined by RFC 3986 Section 2.3). Should not be specified by the client during creation. Example: &amp;quot;organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N&amp;quot;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

}
