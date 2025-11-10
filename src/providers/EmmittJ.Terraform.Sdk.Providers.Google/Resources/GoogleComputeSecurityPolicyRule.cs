using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for header_action in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleHeaderActionBlock : TerraformBlock
{
}

/// <summary>
/// Block type for match in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleMatchBlock : TerraformBlock
{
    /// <summary>
    /// Preconfigured versioned expression. If this field is specified, config must also be specified.
    /// Available preconfigured expressions along with their requirements are: SRC_IPS_V1 - must specify the corresponding srcIpRange field in config. Possible values: [&amp;quot;SRC_IPS_V1&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? VersionedExpr
    {
        set => SetProperty("versioned_expr", value);
    }

}

/// <summary>
/// Block type for preconfigured_waf_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for rate_limit_options in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleRateLimitOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Can only be specified if the action for the rule is &amp;quot;rate_based_ban&amp;quot;.
    /// If specified, determines the time (in seconds) the traffic will continue to be banned by the rate limit after the rate falls below the threshold.
    /// </summary>
    public TerraformProperty<double>? BanDurationSec
    {
        set => SetProperty("ban_duration_sec", value);
    }

    /// <summary>
    /// Action to take for requests that are under the configured rate limit threshold.
    /// Valid option is &amp;quot;allow&amp;quot; only.
    /// </summary>
    public TerraformProperty<string>? ConformAction
    {
        set => SetProperty("conform_action", value);
    }

    /// <summary>
    /// Determines the key to enforce the rateLimitThreshold on. Possible values are:
    /// * ALL: A single rate limit threshold is applied to all the requests matching this rule. This is the default value if &amp;quot;enforceOnKey&amp;quot; is not configured.
    /// * IP: The source IP address of the request is the key. Each IP has this limit enforced separately.
    /// * HTTP_HEADER: The value of the HTTP header whose name is configured under &amp;quot;enforceOnKeyName&amp;quot;. The key value is truncated to the first 128 bytes of the header value. If no such header is present in the request, the key type defaults to ALL.
    /// * XFF_IP: The first IP address (i.e. the originating client IP address) specified in the list of IPs under X-Forwarded-For HTTP header. If no such header is present or the value is not a valid IP, the key defaults to the source IP address of the request i.e. key type IP.
    /// * HTTP_COOKIE: The value of the HTTP cookie whose name is configured under &amp;quot;enforceOnKeyName&amp;quot;. The key value is truncated to the first 128 bytes of the cookie value. If no such cookie is present in the request, the key type defaults to ALL.
    /// * HTTP_PATH: The URL path of the HTTP request. The key value is truncated to the first 128 bytes.
    /// * SNI: Server name indication in the TLS session of the HTTPS request. The key value is truncated to the first 128 bytes. The key type defaults to ALL on a HTTP session.
    /// * REGION_CODE: The country/region from which the request originates.
    /// * TLS_JA3_FINGERPRINT: JA3 TLS/SSL fingerprint if the client connects using HTTPS, HTTP/2 or HTTP/3. If not available, the key type defaults to ALL.
    /// * TLS_JA4_FINGERPRINT: JA4 TLS/SSL fingerprint if the client connects using HTTPS, HTTP/2 or HTTP/3. If not available, the key type defaults to ALL.
    /// * USER_IP: The IP address of the originating client, which is resolved based on &amp;quot;userIpRequestHeaders&amp;quot; configured with the security policy. If there is no &amp;quot;userIpRequestHeaders&amp;quot; configuration or an IP address cannot be resolved from it, the key type defaults to IP. Possible values: [&amp;quot;ALL&amp;quot;, &amp;quot;IP&amp;quot;, &amp;quot;HTTP_HEADER&amp;quot;, &amp;quot;XFF_IP&amp;quot;, &amp;quot;HTTP_COOKIE&amp;quot;, &amp;quot;HTTP_PATH&amp;quot;, &amp;quot;SNI&amp;quot;, &amp;quot;REGION_CODE&amp;quot;, &amp;quot;TLS_JA3_FINGERPRINT&amp;quot;, &amp;quot;TLS_JA4_FINGERPRINT&amp;quot;, &amp;quot;USER_IP&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? EnforceOnKey
    {
        set => SetProperty("enforce_on_key", value);
    }

    /// <summary>
    /// Rate limit key name applicable only for the following key types:
    /// HTTP_HEADER -- Name of the HTTP header whose value is taken as the key value.
    /// HTTP_COOKIE -- Name of the HTTP cookie whose value is taken as the key value.
    /// </summary>
    public TerraformProperty<string>? EnforceOnKeyName
    {
        set => SetProperty("enforce_on_key_name", value);
    }

    /// <summary>
    /// Action to take for requests that are above the configured rate limit threshold, to either deny with a specified HTTP response code, or redirect to a different endpoint.
    /// Valid options are deny(STATUS), where valid values for STATUS are 403, 404, 429, and 502.
    /// </summary>
    public TerraformProperty<string>? ExceedAction
    {
        set => SetProperty("exceed_action", value);
    }

}

/// <summary>
/// Block type for redirect_options in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleRedirectOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Target for the redirect action. This is required if the type is EXTERNAL_302 and cannot be specified for GOOGLE_RECAPTCHA.
    /// </summary>
    public TerraformProperty<string>? Target
    {
        set => SetProperty("target", value);
    }

    /// <summary>
    /// Type of the redirect action.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeSecurityPolicyRuleTimeoutsBlock : TerraformBlock
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
/// Manages a google_compute_security_policy_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeSecurityPolicyRule : TerraformResource
{
    public GoogleComputeSecurityPolicyRule(string name) : base("google_compute_security_policy_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("action");
        SetOutput("description");
        SetOutput("id");
        SetOutput("preview");
        SetOutput("priority");
        SetOutput("project");
        SetOutput("security_policy");
    }

    /// <summary>
    /// The Action to perform when the rule is matched. The following are the valid actions:
    /// 
    /// * allow: allow access to target.
    /// 
    /// * deny(STATUS): deny access to target, returns the HTTP response code specified. Valid values for STATUS are 403, 404, and 502.
    /// 
    /// * rate_based_ban: limit client traffic to the configured threshold and ban the client if the traffic exceeds the threshold. Configure parameters for this action in RateLimitOptions. Requires rateLimitOptions to be set.
    /// 
    /// * redirect: redirect to a different target. This can either be an internal reCAPTCHA redirect, or an external URL-based redirect via a 302 response. Parameters for this action can be configured via redirectOptions. This action is only supported in Global Security Policies of type CLOUD_ARMOR.
    /// 
    /// * throttle: limit client traffic to the configured threshold. Configure parameters for this action in rateLimitOptions. Requires rateLimitOptions to be set for this.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetRequiredOutput<TerraformProperty<string>>("action");
        set => SetProperty("action", value);
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// If set to true, the specified action is not enforced.
    /// </summary>
    public TerraformProperty<bool> Preview
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("preview");
        set => SetProperty("preview", value);
    }

    /// <summary>
    /// An integer indicating the priority of a rule in the list.
    /// The priority must be a positive value between 0 and 2147483647.
    /// Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest priority.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetRequiredOutput<TerraformProperty<double>>("priority");
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The name of the security policy this rule belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityPolicy is required")]
    public required TerraformProperty<string> SecurityPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_policy");
        set => SetProperty("security_policy", value);
    }

    /// <summary>
    /// Block for header_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderAction block(s) allowed")]
    public List<GoogleComputeSecurityPolicyRuleHeaderActionBlock>? HeaderAction
    {
        set => SetProperty("header_action", value);
    }

    /// <summary>
    /// Block for match.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public List<GoogleComputeSecurityPolicyRuleMatchBlock>? Match
    {
        set => SetProperty("match", value);
    }

    /// <summary>
    /// Block for preconfigured_waf_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreconfiguredWafConfig block(s) allowed")]
    public List<GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlock>? PreconfiguredWafConfig
    {
        set => SetProperty("preconfigured_waf_config", value);
    }

    /// <summary>
    /// Block for rate_limit_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RateLimitOptions block(s) allowed")]
    public List<GoogleComputeSecurityPolicyRuleRateLimitOptionsBlock>? RateLimitOptions
    {
        set => SetProperty("rate_limit_options", value);
    }

    /// <summary>
    /// Block for redirect_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedirectOptions block(s) allowed")]
    public List<GoogleComputeSecurityPolicyRuleRedirectOptionsBlock>? RedirectOptions
    {
        set => SetProperty("redirect_options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeSecurityPolicyRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
