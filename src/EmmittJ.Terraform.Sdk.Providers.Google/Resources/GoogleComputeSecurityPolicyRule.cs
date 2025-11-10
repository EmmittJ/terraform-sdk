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
        get => GetProperty<TerraformProperty<string>>("versioned_expr");
        set => WithProperty("versioned_expr", value);
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
        get => GetProperty<TerraformProperty<double>>("ban_duration_sec");
        set => WithProperty("ban_duration_sec", value);
    }

    /// <summary>
    /// Action to take for requests that are under the configured rate limit threshold.
    /// Valid option is &amp;quot;allow&amp;quot; only.
    /// </summary>
    public TerraformProperty<string>? ConformAction
    {
        get => GetProperty<TerraformProperty<string>>("conform_action");
        set => WithProperty("conform_action", value);
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
        get => GetProperty<TerraformProperty<string>>("enforce_on_key");
        set => WithProperty("enforce_on_key", value);
    }

    /// <summary>
    /// Rate limit key name applicable only for the following key types:
    /// HTTP_HEADER -- Name of the HTTP header whose value is taken as the key value.
    /// HTTP_COOKIE -- Name of the HTTP cookie whose value is taken as the key value.
    /// </summary>
    public TerraformProperty<string>? EnforceOnKeyName
    {
        get => GetProperty<TerraformProperty<string>>("enforce_on_key_name");
        set => WithProperty("enforce_on_key_name", value);
    }

    /// <summary>
    /// Action to take for requests that are above the configured rate limit threshold, to either deny with a specified HTTP response code, or redirect to a different endpoint.
    /// Valid options are deny(STATUS), where valid values for STATUS are 403, 404, 429, and 502.
    /// </summary>
    public TerraformProperty<string>? ExceedAction
    {
        get => GetProperty<TerraformProperty<string>>("exceed_action");
        set => WithProperty("exceed_action", value);
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
        get => GetProperty<TerraformProperty<string>>("target");
        set => WithProperty("target", value);
    }

    /// <summary>
    /// Type of the redirect action.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_security_policy_rule resource.
/// </summary>
public class GoogleComputeSecurityPolicyRule : TerraformResource
{
    public GoogleComputeSecurityPolicyRule(string name) : base("google_compute_security_policy_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
        get => GetProperty<TerraformProperty<string>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// If set to true, the specified action is not enforced.
    /// </summary>
    public TerraformProperty<bool>? Preview
    {
        get => GetProperty<TerraformProperty<bool>>("preview");
        set => this.WithProperty("preview", value);
    }

    /// <summary>
    /// An integer indicating the priority of a rule in the list.
    /// The priority must be a positive value between 0 and 2147483647.
    /// Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest priority.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The name of the security policy this rule belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityPolicy is required")]
    public required TerraformProperty<string> SecurityPolicy
    {
        get => GetProperty<TerraformProperty<string>>("security_policy");
        set => this.WithProperty("security_policy", value);
    }

    /// <summary>
    /// Block for header_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderAction block(s) allowed")]
    public List<GoogleComputeSecurityPolicyRuleHeaderActionBlock>? HeaderAction
    {
        get => GetProperty<List<GoogleComputeSecurityPolicyRuleHeaderActionBlock>>("header_action");
        set => this.WithProperty("header_action", value);
    }

    /// <summary>
    /// Block for match.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public List<GoogleComputeSecurityPolicyRuleMatchBlock>? Match
    {
        get => GetProperty<List<GoogleComputeSecurityPolicyRuleMatchBlock>>("match");
        set => this.WithProperty("match", value);
    }

    /// <summary>
    /// Block for preconfigured_waf_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreconfiguredWafConfig block(s) allowed")]
    public List<GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlock>? PreconfiguredWafConfig
    {
        get => GetProperty<List<GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlock>>("preconfigured_waf_config");
        set => this.WithProperty("preconfigured_waf_config", value);
    }

    /// <summary>
    /// Block for rate_limit_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RateLimitOptions block(s) allowed")]
    public List<GoogleComputeSecurityPolicyRuleRateLimitOptionsBlock>? RateLimitOptions
    {
        get => GetProperty<List<GoogleComputeSecurityPolicyRuleRateLimitOptionsBlock>>("rate_limit_options");
        set => this.WithProperty("rate_limit_options", value);
    }

    /// <summary>
    /// Block for redirect_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedirectOptions block(s) allowed")]
    public List<GoogleComputeSecurityPolicyRuleRedirectOptionsBlock>? RedirectOptions
    {
        get => GetProperty<List<GoogleComputeSecurityPolicyRuleRedirectOptionsBlock>>("redirect_options");
        set => this.WithProperty("redirect_options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeSecurityPolicyRuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeSecurityPolicyRuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
