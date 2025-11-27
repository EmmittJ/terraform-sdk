using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for access_settings in GoogleIapSettings.
/// Nesting mode: list
/// </summary>
public class GoogleIapSettingsAccessSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_settings";

    /// <summary>
    /// Identity sources that IAP can use to authenticate the end user. Only one identity source
    /// can be configured. The possible values are:
    /// 
    /// * &#39;WORKFORCE_IDENTITY_FEDERATION&#39;: Use external identities set up on Google Cloud Workforce
    ///   				     Identity Federation. Possible values: [&amp;quot;WORKFORCE_IDENTITY_FEDERATION&amp;quot;]
    /// </summary>
    public TerraformList<string>? IdentitySources
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "identity_sources").ResolveNodes(ctx));
        set => SetArgument("identity_sources", value);
    }

    /// <summary>
    /// AllowedDomainsSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllowedDomainsSettings block(s) allowed")]
    public TerraformList<GoogleIapSettingsAccessSettingsBlockAllowedDomainsSettingsBlock>? AllowedDomainsSettings
    {
        get => GetArgument<TerraformList<GoogleIapSettingsAccessSettingsBlockAllowedDomainsSettingsBlock>>("allowed_domains_settings");
        set => SetArgument("allowed_domains_settings", value);
    }

    /// <summary>
    /// CorsSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsSettings block(s) allowed")]
    public TerraformList<GoogleIapSettingsAccessSettingsBlockCorsSettingsBlock>? CorsSettings
    {
        get => GetArgument<TerraformList<GoogleIapSettingsAccessSettingsBlockCorsSettingsBlock>>("cors_settings");
        set => SetArgument("cors_settings", value);
    }

    /// <summary>
    /// GcipSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcipSettings block(s) allowed")]
    public TerraformList<GoogleIapSettingsAccessSettingsBlockGcipSettingsBlock>? GcipSettings
    {
        get => GetArgument<TerraformList<GoogleIapSettingsAccessSettingsBlockGcipSettingsBlock>>("gcip_settings");
        set => SetArgument("gcip_settings", value);
    }

    /// <summary>
    /// OauthSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthSettings block(s) allowed")]
    public TerraformList<GoogleIapSettingsAccessSettingsBlockOauthSettingsBlock>? OauthSettings
    {
        get => GetArgument<TerraformList<GoogleIapSettingsAccessSettingsBlockOauthSettingsBlock>>("oauth_settings");
        set => SetArgument("oauth_settings", value);
    }

    /// <summary>
    /// ReauthSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReauthSettings block(s) allowed")]
    public TerraformList<GoogleIapSettingsAccessSettingsBlockReauthSettingsBlock>? ReauthSettings
    {
        get => GetArgument<TerraformList<GoogleIapSettingsAccessSettingsBlockReauthSettingsBlock>>("reauth_settings");
        set => SetArgument("reauth_settings", value);
    }

    /// <summary>
    /// WorkforceIdentitySettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkforceIdentitySettings block(s) allowed")]
    public TerraformList<GoogleIapSettingsAccessSettingsBlockWorkforceIdentitySettingsBlock>? WorkforceIdentitySettings
    {
        get => GetArgument<TerraformList<GoogleIapSettingsAccessSettingsBlockWorkforceIdentitySettingsBlock>>("workforce_identity_settings");
        set => SetArgument("workforce_identity_settings", value);
    }

}

/// <summary>
/// Block type for allowed_domains_settings in GoogleIapSettingsAccessSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIapSettingsAccessSettingsBlockAllowedDomainsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allowed_domains_settings";

    /// <summary>
    /// List of trusted domains.
    /// </summary>
    public TerraformList<string>? Domains
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "domains").ResolveNodes(ctx));
        set => SetArgument("domains", value);
    }

    /// <summary>
    /// Configuration for customers to opt in for the feature.
    /// </summary>
    public TerraformValue<bool>? Enable
    {
        get => new TerraformReference<bool>(this, "enable");
        set => SetArgument("enable", value);
    }

}

/// <summary>
/// Block type for cors_settings in GoogleIapSettingsAccessSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIapSettingsAccessSettingsBlockCorsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors_settings";

    /// <summary>
    /// Configuration to allow HTTP OPTIONS calls to skip authorization.
    /// If undefined, IAP will not apply any special logic to OPTIONS requests.
    /// </summary>
    public TerraformValue<bool>? AllowHttpOptions
    {
        get => new TerraformReference<bool>(this, "allow_http_options");
        set => SetArgument("allow_http_options", value);
    }

}

/// <summary>
/// Block type for gcip_settings in GoogleIapSettingsAccessSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIapSettingsAccessSettingsBlockGcipSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcip_settings";

    /// <summary>
    /// Login page URI associated with the GCIP tenants. Typically, all resources within
    /// the same project share the same login page, though it could be overridden at the
    /// sub resource level.
    /// </summary>
    public TerraformValue<string>? LoginPageUri
    {
        get => new TerraformReference<string>(this, "login_page_uri");
        set => SetArgument("login_page_uri", value);
    }

    /// <summary>
    /// GCIP tenant ids that are linked to the IAP resource. tenantIds could be a string
    /// beginning with a number character to indicate authenticating with GCIP tenant flow,
    /// or in the format of _ to indicate authenticating with GCIP agent flow. If agent flow
    /// is used, tenantIds should only contain one single element, while for tenant flow,
    /// tenantIds can contain multiple elements.
    /// </summary>
    public TerraformList<string>? TenantIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "tenant_ids").ResolveNodes(ctx));
        set => SetArgument("tenant_ids", value);
    }

}

/// <summary>
/// Block type for oauth_settings in GoogleIapSettingsAccessSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIapSettingsAccessSettingsBlockOauthSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth_settings";

    /// <summary>
    /// Domain hint to send as hd=? parameter in OAuth request flow.
    /// Enables redirect to primary IDP by skipping Google&#39;s login screen.
    /// (https://developers.google.com/identity/protocols/OpenIDConnect#hd-param)
    /// Note: IAP does not verify that the id token&#39;s hd claim matches this value
    /// since access behavior is managed by IAM policies.
    /// * loginHint setting is not a replacement for access control. Always enforce an appropriate access policy if you want to restrict access to users outside your domain.
    /// </summary>
    public TerraformValue<string>? LoginHint
    {
        get => new TerraformReference<string>(this, "login_hint");
        set => SetArgument("login_hint", value);
    }

    /// <summary>
    /// List of client ids allowed to use IAP programmatically.
    /// </summary>
    public TerraformList<string>? ProgrammaticClients
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "programmatic_clients").ResolveNodes(ctx));
        set => SetArgument("programmatic_clients", value);
    }

}

/// <summary>
/// Block type for reauth_settings in GoogleIapSettingsAccessSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIapSettingsAccessSettingsBlockReauthSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reauth_settings";

    /// <summary>
    /// Reauth session lifetime, how long before a user has to reauthenticate again.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;.
    /// Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxAge is required")]
    public required TerraformValue<string> MaxAge
    {
        get => new TerraformReference<string>(this, "max_age");
        set => SetArgument("max_age", value);
    }

    /// <summary>
    /// Reauth method requested. The possible values are:
    /// 
    /// * &#39;LOGIN&#39;: Prompts the user to log in again.
    /// * &#39;SECURE_KEY&#39;: User must use their secure key 2nd factor device.
    /// * &#39;ENROLLED_SECOND_FACTORS&#39;: User can use any enabled 2nd factor. Possible values: [&amp;quot;LOGIN&amp;quot;, &amp;quot;SECURE_KEY&amp;quot;, &amp;quot;ENROLLED_SECOND_FACTORS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Method is required")]
    public required TerraformValue<string> Method
    {
        get => new TerraformReference<string>(this, "method");
        set => SetArgument("method", value);
    }

    /// <summary>
    /// How IAP determines the effective policy in cases of hierarchical policies.
    /// Policies are merged from higher in the hierarchy to lower in the hierarchy.
    /// The possible values are:
    /// 
    /// * &#39;MINIMUM&#39;: This policy acts as a minimum to other policies, lower in the hierarchy.
    /// 		   Effective policy may only be the same or stricter.
    /// * &#39;DEFAULT&#39;: This policy acts as a default if no other reauth policy is set. Possible values: [&amp;quot;MINIMUM&amp;quot;, &amp;quot;DEFAULT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyType is required")]
    public required TerraformValue<string> PolicyType
    {
        get => new TerraformReference<string>(this, "policy_type");
        set => SetArgument("policy_type", value);
    }

}

/// <summary>
/// Block type for workforce_identity_settings in GoogleIapSettingsAccessSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIapSettingsAccessSettingsBlockWorkforceIdentitySettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workforce_identity_settings";

    /// <summary>
    /// The workforce pool resources. Only one workforce pool is accepted.
    /// </summary>
    public TerraformList<string>? WorkforcePools
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "workforce_pools").ResolveNodes(ctx));
        set => SetArgument("workforce_pools", value);
    }

    /// <summary>
    /// Oauth2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oauth2 block(s) allowed")]
    public TerraformList<GoogleIapSettingsAccessSettingsBlockWorkforceIdentitySettingsBlockOauth2Block>? Oauth2
    {
        get => GetArgument<TerraformList<GoogleIapSettingsAccessSettingsBlockWorkforceIdentitySettingsBlockOauth2Block>>("oauth2");
        set => SetArgument("oauth2", value);
    }

}

/// <summary>
/// Block type for oauth2 in GoogleIapSettingsAccessSettingsBlockWorkforceIdentitySettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIapSettingsAccessSettingsBlockWorkforceIdentitySettingsBlockOauth2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth2";

    /// <summary>
    /// The OAuth 2.0 client ID registered in the workforce identity
    /// federation OAuth 2.0 Server.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// Input only. The OAuth 2.0 client secret created while registering
    /// the client ID.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// Output only. SHA256 hash value for the client secret. This field
    /// is returned by IAP when the settings are retrieved.
    /// </summary>
    public TerraformValue<string> ClientSecretSha256
    {
        get => new TerraformReference<string>(this, "client_secret_sha256");
    }

}


/// <summary>
/// Block type for application_settings in GoogleIapSettings.
/// Nesting mode: list
/// </summary>
public class GoogleIapSettingsApplicationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_settings";

    /// <summary>
    /// The Domain value to set for cookies generated by IAP. This value is not validated by the API,
    /// but will be ignored at runtime if invalid.
    /// </summary>
    public TerraformValue<string>? CookieDomain
    {
        get => new TerraformReference<string>(this, "cookie_domain");
        set => SetArgument("cookie_domain", value);
    }

    /// <summary>
    /// AccessDeniedPageSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessDeniedPageSettings block(s) allowed")]
    public TerraformList<GoogleIapSettingsApplicationSettingsBlockAccessDeniedPageSettingsBlock>? AccessDeniedPageSettings
    {
        get => GetArgument<TerraformList<GoogleIapSettingsApplicationSettingsBlockAccessDeniedPageSettingsBlock>>("access_denied_page_settings");
        set => SetArgument("access_denied_page_settings", value);
    }

    /// <summary>
    /// AttributePropagationSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AttributePropagationSettings block(s) allowed")]
    public TerraformList<GoogleIapSettingsApplicationSettingsBlockAttributePropagationSettingsBlock>? AttributePropagationSettings
    {
        get => GetArgument<TerraformList<GoogleIapSettingsApplicationSettingsBlockAttributePropagationSettingsBlock>>("attribute_propagation_settings");
        set => SetArgument("attribute_propagation_settings", value);
    }

    /// <summary>
    /// CsmSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CsmSettings block(s) allowed")]
    public TerraformList<GoogleIapSettingsApplicationSettingsBlockCsmSettingsBlock>? CsmSettings
    {
        get => GetArgument<TerraformList<GoogleIapSettingsApplicationSettingsBlockCsmSettingsBlock>>("csm_settings");
        set => SetArgument("csm_settings", value);
    }

}

/// <summary>
/// Block type for access_denied_page_settings in GoogleIapSettingsApplicationSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIapSettingsApplicationSettingsBlockAccessDeniedPageSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_denied_page_settings";

    /// <summary>
    /// The URI to be redirected to when access is denied.
    /// </summary>
    public TerraformValue<string>? AccessDeniedPageUri
    {
        get => new TerraformReference<string>(this, "access_denied_page_uri");
        set => SetArgument("access_denied_page_uri", value);
    }

    /// <summary>
    /// Whether to generate a troubleshooting URL on access denied events to this application.
    /// </summary>
    public TerraformValue<bool>? GenerateTroubleshootingUri
    {
        get => new TerraformReference<bool>(this, "generate_troubleshooting_uri");
        set => SetArgument("generate_troubleshooting_uri", value);
    }

    /// <summary>
    /// Whether to generate remediation token on access denied events to this application.
    /// </summary>
    public TerraformValue<bool>? RemediationTokenGenerationEnabled
    {
        get => new TerraformReference<bool>(this, "remediation_token_generation_enabled");
        set => SetArgument("remediation_token_generation_enabled", value);
    }

}

/// <summary>
/// Block type for attribute_propagation_settings in GoogleIapSettingsApplicationSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIapSettingsApplicationSettingsBlockAttributePropagationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attribute_propagation_settings";

    /// <summary>
    /// Whether the provided attribute propagation settings should be evaluated on user requests.
    /// If set to true, attributes returned from the expression will be propagated in the set output credentials.
    /// </summary>
    public TerraformValue<bool>? Enable
    {
        get => new TerraformReference<bool>(this, "enable");
        set => SetArgument("enable", value);
    }

    /// <summary>
    /// Raw string CEL expression. Must return a list of attributes. A maximum of 45 attributes can
    /// be selected. Expressions can select different attribute types from attributes:
    /// attributes.saml_attributes, attributes.iap_attributes.
    /// </summary>
    public TerraformValue<string>? Expression
    {
        get => new TerraformReference<string>(this, "expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// Which output credentials attributes selected by the CEL expression should be propagated in.
    /// All attributes will be fully duplicated in each selected output credential.
    /// Possible values are:
    /// 
    /// * &#39;HEADER&#39;: Propagate attributes in the headers with &amp;quot;x-goog-iap-attr-&amp;quot; prefix.
    /// * &#39;JWT&#39;: Propagate attributes in the JWT of the form:
    ///          &amp;quot;additional_claims&amp;quot;: { &amp;quot;my_attribute&amp;quot;: [&amp;quot;value1&amp;quot;, &amp;quot;value2&amp;quot;] }
    /// * &#39;RCTOKEN&#39;: Propagate attributes in the RCToken of the form: &amp;quot;
    ///              additional_claims&amp;quot;: { &amp;quot;my_attribute&amp;quot;: [&amp;quot;value1&amp;quot;, &amp;quot;value2&amp;quot;] } Possible values: [&amp;quot;HEADER&amp;quot;, &amp;quot;JWT&amp;quot;, &amp;quot;RCTOKEN&amp;quot;]
    /// </summary>
    public TerraformList<string>? OutputCredentials
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "output_credentials").ResolveNodes(ctx));
        set => SetArgument("output_credentials", value);
    }

}

/// <summary>
/// Block type for csm_settings in GoogleIapSettingsApplicationSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIapSettingsApplicationSettingsBlockCsmSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "csm_settings";

    /// <summary>
    /// Audience claim set in the generated RCToken. This value is not validated by IAP.
    /// </summary>
    public TerraformValue<string>? RctokenAud
    {
        get => new TerraformReference<string>(this, "rctoken_aud");
        set => SetArgument("rctoken_aud", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleIapSettings.
/// Nesting mode: single
/// </summary>
public class GoogleIapSettingsTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_iap_settings Terraform resource.
/// Manages a google_iap_settings resource.
/// </summary>
public partial class GoogleIapSettings(string name) : TerraformResource("google_iap_settings", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource name of the IAP protected resource. Name can have below resources:
    /// * organizations/{organization_id}
    /// * folders/{folder_id}
    /// * projects/{project_id}
    /// * projects/{project_id}/iap_web
    /// * projects/{project_id}/iap_web/compute
    /// * projects/{project_id}/iap_web/compute-{region}
    /// * projects/{project_id}/iap_web/compute/services/{service_id}
    /// * projects/{project_id}/iap_web/compute-{region}/services/{service_id}
    /// * projects/{project_id}/iap_web/appengine-{app_id}
    /// * projects/{project_id}/iap_web/appengine-{app_id}/services/{service_id}
    /// * projects/{project_id}/iap_web/appengine-{app_id}/services/{service_id}/version/{version_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// AccessSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessSettings block(s) allowed")]
    public TerraformList<GoogleIapSettingsAccessSettingsBlock>? AccessSettings
    {
        get => GetArgument<TerraformList<GoogleIapSettingsAccessSettingsBlock>>("access_settings");
        set => SetArgument("access_settings", value);
    }

    /// <summary>
    /// ApplicationSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationSettings block(s) allowed")]
    public TerraformList<GoogleIapSettingsApplicationSettingsBlock>? ApplicationSettings
    {
        get => GetArgument<TerraformList<GoogleIapSettingsApplicationSettingsBlock>>("application_settings");
        set => SetArgument("application_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleIapSettingsTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleIapSettingsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
