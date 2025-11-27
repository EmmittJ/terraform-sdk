using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for header_action in GoogleComputeSecurityPolicyRule.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleHeaderActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header_action";

    /// <summary>
    /// RequestHeadersToAdds block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeSecurityPolicyRuleHeaderActionBlockRequestHeadersToAddsBlock>? RequestHeadersToAdds
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleHeaderActionBlockRequestHeadersToAddsBlock>>("request_headers_to_adds");
        set => SetArgument("request_headers_to_adds", value);
    }

}

/// <summary>
/// Block type for request_headers_to_adds in GoogleComputeSecurityPolicyRuleHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleHeaderActionBlockRequestHeadersToAddsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_headers_to_adds";

    /// <summary>
    /// The name of the header to set.
    /// </summary>
    public TerraformValue<string>? HeaderName
    {
        get => new TerraformReference<string>(this, "header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value to set the named header to.
    /// </summary>
    public TerraformValue<string>? HeaderValue
    {
        get => new TerraformReference<string>(this, "header_value");
        set => SetArgument("header_value", value);
    }

}


/// <summary>
/// Block type for match in GoogleComputeSecurityPolicyRule.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match";

    /// <summary>
    /// Preconfigured versioned expression. If this field is specified, config must also be specified.
    /// Available preconfigured expressions along with their requirements are: SRC_IPS_V1 - must specify the corresponding srcIpRange field in config. Possible values: [&amp;quot;SRC_IPS_V1&amp;quot;]
    /// </summary>
    public TerraformValue<string>? VersionedExpr
    {
        get => new TerraformReference<string>(this, "versioned_expr");
        set => SetArgument("versioned_expr", value);
    }

    /// <summary>
    /// Config block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyRuleMatchBlockConfigBlock>? Config
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleMatchBlockConfigBlock>>("config");
        set => SetArgument("config", value);
    }

    /// <summary>
    /// Expr block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Expr block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyRuleMatchBlockExprBlock>? Expr
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleMatchBlockExprBlock>>("expr");
        set => SetArgument("expr", value);
    }

    /// <summary>
    /// ExprOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExprOptions block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyRuleMatchBlockExprOptionsBlock>? ExprOptions
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleMatchBlockExprOptionsBlock>>("expr_options");
        set => SetArgument("expr_options", value);
    }

}

/// <summary>
/// Block type for config in GoogleComputeSecurityPolicyRuleMatchBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleMatchBlockConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config";

    /// <summary>
    /// CIDR IP address range. Maximum number of srcIpRanges allowed is 10.
    /// </summary>
    public TerraformList<string>? SrcIpRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "src_ip_ranges").ResolveNodes(ctx));
        set => SetArgument("src_ip_ranges", value);
    }

}

/// <summary>
/// Block type for expr in GoogleComputeSecurityPolicyRuleMatchBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleMatchBlockExprBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "expr";

    /// <summary>
    /// Textual representation of an expression in Common Expression Language syntax. The application context of the containing message determines which well-known feature set of CEL is supported.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => new TerraformReference<string>(this, "expression");
        set => SetArgument("expression", value);
    }

}

/// <summary>
/// Block type for expr_options in GoogleComputeSecurityPolicyRuleMatchBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleMatchBlockExprOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "expr_options";

    /// <summary>
    /// RecaptchaOptions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecaptchaOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RecaptchaOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecaptchaOptions block(s) allowed")]
    public required TerraformList<GoogleComputeSecurityPolicyRuleMatchBlockExprOptionsBlockRecaptchaOptionsBlock> RecaptchaOptions
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeSecurityPolicyRuleMatchBlockExprOptionsBlockRecaptchaOptionsBlock>>("recaptcha_options");
        set => SetArgument("recaptcha_options", value);
    }

}

/// <summary>
/// Block type for recaptcha_options in GoogleComputeSecurityPolicyRuleMatchBlockExprOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleMatchBlockExprOptionsBlockRecaptchaOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recaptcha_options";

    /// <summary>
    /// A list of site keys to be used during the validation of reCAPTCHA action-tokens. The provided site keys need to be created from reCAPTCHA API under the same project where the security policy is created.
    /// </summary>
    public TerraformList<string>? ActionTokenSiteKeys
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "action_token_site_keys").ResolveNodes(ctx));
        set => SetArgument("action_token_site_keys", value);
    }

    /// <summary>
    /// A list of site keys to be used during the validation of reCAPTCHA session-tokens. The provided site keys need to be created from reCAPTCHA API under the same project where the security policy is created.
    /// </summary>
    public TerraformList<string>? SessionTokenSiteKeys
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "session_token_site_keys").ResolveNodes(ctx));
        set => SetArgument("session_token_site_keys", value);
    }

}


/// <summary>
/// Block type for preconfigured_waf_config in GoogleComputeSecurityPolicyRule.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "preconfigured_waf_config";

    /// <summary>
    /// Exclusion block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlock>? Exclusion
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlock>>("exclusion");
        set => SetArgument("exclusion", value);
    }

}

/// <summary>
/// Block type for exclusion in GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclusion";

    /// <summary>
    /// A list of target rule IDs under the WAF rule set to apply the preconfigured WAF exclusion.
    /// If omitted, it refers to all the rule IDs under the WAF rule set.
    /// </summary>
    public TerraformList<string>? TargetRuleIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "target_rule_ids").ResolveNodes(ctx));
        set => SetArgument("target_rule_ids", value);
    }

    /// <summary>
    /// Target WAF rule set to apply the preconfigured WAF exclusion.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRuleSet is required")]
    public required TerraformValue<string> TargetRuleSet
    {
        get => new TerraformReference<string>(this, "target_rule_set");
        set => SetArgument("target_rule_set", value);
    }

    /// <summary>
    /// RequestCookie block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestCookieBlock>? RequestCookie
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestCookieBlock>>("request_cookie");
        set => SetArgument("request_cookie", value);
    }

    /// <summary>
    /// RequestHeader block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestHeaderBlock>? RequestHeader
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestHeaderBlock>>("request_header");
        set => SetArgument("request_header", value);
    }

    /// <summary>
    /// RequestQueryParam block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestQueryParamBlock>? RequestQueryParam
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestQueryParamBlock>>("request_query_param");
        set => SetArgument("request_query_param", value);
    }

    /// <summary>
    /// RequestUri block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestUriBlock>? RequestUri
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestUriBlock>>("request_uri");
        set => SetArgument("request_uri", value);
    }

}

/// <summary>
/// Block type for request_cookie in GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestCookieBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_cookie";

    /// <summary>
    /// You can specify an exact match or a partial match by using a field operator and a field value.
    /// Available options:
    /// EQUALS: The operator matches if the field value equals the specified value.
    /// STARTS_WITH: The operator matches if the field value starts with the specified value.
    /// ENDS_WITH: The operator matches if the field value ends with the specified value.
    /// CONTAINS: The operator matches if the field value contains the specified value.
    /// EQUALS_ANY: The operator matches if the field value is any value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation.
    /// The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for request_header in GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_header";

    /// <summary>
    /// You can specify an exact match or a partial match by using a field operator and a field value.
    /// Available options:
    /// EQUALS: The operator matches if the field value equals the specified value.
    /// STARTS_WITH: The operator matches if the field value starts with the specified value.
    /// ENDS_WITH: The operator matches if the field value ends with the specified value.
    /// CONTAINS: The operator matches if the field value contains the specified value.
    /// EQUALS_ANY: The operator matches if the field value is any value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation.
    /// The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for request_query_param in GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestQueryParamBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_query_param";

    /// <summary>
    /// You can specify an exact match or a partial match by using a field operator and a field value.
    /// Available options:
    /// EQUALS: The operator matches if the field value equals the specified value.
    /// STARTS_WITH: The operator matches if the field value starts with the specified value.
    /// ENDS_WITH: The operator matches if the field value ends with the specified value.
    /// CONTAINS: The operator matches if the field value contains the specified value.
    /// EQUALS_ANY: The operator matches if the field value is any value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation.
    /// The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for request_uri in GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestUriBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_uri";

    /// <summary>
    /// You can specify an exact match or a partial match by using a field operator and a field value.
    /// Available options:
    /// EQUALS: The operator matches if the field value equals the specified value.
    /// STARTS_WITH: The operator matches if the field value starts with the specified value.
    /// ENDS_WITH: The operator matches if the field value ends with the specified value.
    /// CONTAINS: The operator matches if the field value contains the specified value.
    /// EQUALS_ANY: The operator matches if the field value is any value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation.
    /// The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for rate_limit_options in GoogleComputeSecurityPolicyRule.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleRateLimitOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rate_limit_options";

    /// <summary>
    /// Can only be specified if the action for the rule is &amp;quot;rate_based_ban&amp;quot;.
    /// If specified, determines the time (in seconds) the traffic will continue to be banned by the rate limit after the rate falls below the threshold.
    /// </summary>
    public TerraformValue<double>? BanDurationSec
    {
        get => new TerraformReference<double>(this, "ban_duration_sec");
        set => SetArgument("ban_duration_sec", value);
    }

    /// <summary>
    /// Action to take for requests that are under the configured rate limit threshold.
    /// Valid option is &amp;quot;allow&amp;quot; only.
    /// </summary>
    public TerraformValue<string>? ConformAction
    {
        get => new TerraformReference<string>(this, "conform_action");
        set => SetArgument("conform_action", value);
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
    public TerraformValue<string>? EnforceOnKey
    {
        get => new TerraformReference<string>(this, "enforce_on_key");
        set => SetArgument("enforce_on_key", value);
    }

    /// <summary>
    /// Rate limit key name applicable only for the following key types:
    /// HTTP_HEADER -- Name of the HTTP header whose value is taken as the key value.
    /// HTTP_COOKIE -- Name of the HTTP cookie whose value is taken as the key value.
    /// </summary>
    public TerraformValue<string>? EnforceOnKeyName
    {
        get => new TerraformReference<string>(this, "enforce_on_key_name");
        set => SetArgument("enforce_on_key_name", value);
    }

    /// <summary>
    /// Action to take for requests that are above the configured rate limit threshold, to either deny with a specified HTTP response code, or redirect to a different endpoint.
    /// Valid options are deny(STATUS), where valid values for STATUS are 403, 404, 429, and 502.
    /// </summary>
    public TerraformValue<string>? ExceedAction
    {
        get => new TerraformReference<string>(this, "exceed_action");
        set => SetArgument("exceed_action", value);
    }

    /// <summary>
    /// BanThreshold block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BanThreshold block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyRuleRateLimitOptionsBlockBanThresholdBlock>? BanThreshold
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleRateLimitOptionsBlockBanThresholdBlock>>("ban_threshold");
        set => SetArgument("ban_threshold", value);
    }

    /// <summary>
    /// EnforceOnKeyConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeSecurityPolicyRuleRateLimitOptionsBlockEnforceOnKeyConfigsBlock>? EnforceOnKeyConfigs
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleRateLimitOptionsBlockEnforceOnKeyConfigsBlock>>("enforce_on_key_configs");
        set => SetArgument("enforce_on_key_configs", value);
    }

    /// <summary>
    /// ExceedRedirectOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExceedRedirectOptions block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyRuleRateLimitOptionsBlockExceedRedirectOptionsBlock>? ExceedRedirectOptions
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleRateLimitOptionsBlockExceedRedirectOptionsBlock>>("exceed_redirect_options");
        set => SetArgument("exceed_redirect_options", value);
    }

    /// <summary>
    /// RateLimitThreshold block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RateLimitThreshold block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyRuleRateLimitOptionsBlockRateLimitThresholdBlock>? RateLimitThreshold
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleRateLimitOptionsBlockRateLimitThresholdBlock>>("rate_limit_threshold");
        set => SetArgument("rate_limit_threshold", value);
    }

}

/// <summary>
/// Block type for ban_threshold in GoogleComputeSecurityPolicyRuleRateLimitOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleRateLimitOptionsBlockBanThresholdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ban_threshold";

    /// <summary>
    /// Number of HTTP(S) requests for calculating the threshold.
    /// </summary>
    public TerraformValue<double>? CountAttribute
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// Interval over which the threshold is computed.
    /// </summary>
    public TerraformValue<double>? IntervalSec
    {
        get => new TerraformReference<double>(this, "interval_sec");
        set => SetArgument("interval_sec", value);
    }

}

/// <summary>
/// Block type for enforce_on_key_configs in GoogleComputeSecurityPolicyRuleRateLimitOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleRateLimitOptionsBlockEnforceOnKeyConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enforce_on_key_configs";

    /// <summary>
    /// Rate limit key name applicable only for the following key types:
    /// HTTP_HEADER -- Name of the HTTP header whose value is taken as the key value.
    /// HTTP_COOKIE -- Name of the HTTP cookie whose value is taken as the key value.
    /// </summary>
    public TerraformValue<string>? EnforceOnKeyName
    {
        get => new TerraformReference<string>(this, "enforce_on_key_name");
        set => SetArgument("enforce_on_key_name", value);
    }

    /// <summary>
    /// Determines the key to enforce the rateLimitThreshold on. Possible values are:
    /// * ALL: A single rate limit threshold is applied to all the requests matching this rule. This is the default value if &amp;quot;enforceOnKeyConfigs&amp;quot; is not configured.
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
    public TerraformValue<string>? EnforceOnKeyType
    {
        get => new TerraformReference<string>(this, "enforce_on_key_type");
        set => SetArgument("enforce_on_key_type", value);
    }

}

/// <summary>
/// Block type for exceed_redirect_options in GoogleComputeSecurityPolicyRuleRateLimitOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleRateLimitOptionsBlockExceedRedirectOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exceed_redirect_options";

    /// <summary>
    /// Target for the redirect action. This is required if the type is EXTERNAL_302 and cannot be specified for GOOGLE_RECAPTCHA.
    /// </summary>
    public TerraformValue<string>? Target
    {
        get => new TerraformReference<string>(this, "target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// Type of the redirect action.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for rate_limit_threshold in GoogleComputeSecurityPolicyRuleRateLimitOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleRateLimitOptionsBlockRateLimitThresholdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rate_limit_threshold";

    /// <summary>
    /// Number of HTTP(S) requests for calculating the threshold.
    /// </summary>
    public TerraformValue<double>? CountAttribute
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// Interval over which the threshold is computed.
    /// </summary>
    public TerraformValue<double>? IntervalSec
    {
        get => new TerraformReference<double>(this, "interval_sec");
        set => SetArgument("interval_sec", value);
    }

}


/// <summary>
/// Block type for redirect_options in GoogleComputeSecurityPolicyRule.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleRedirectOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redirect_options";

    /// <summary>
    /// Target for the redirect action. This is required if the type is EXTERNAL_302 and cannot be specified for GOOGLE_RECAPTCHA.
    /// </summary>
    public TerraformValue<string>? Target
    {
        get => new TerraformReference<string>(this, "target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// Type of the redirect action.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeSecurityPolicyRule.
/// Nesting mode: single
/// </summary>
public class GoogleComputeSecurityPolicyRuleTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_security_policy_rule Terraform resource.
/// Manages a google_compute_security_policy_rule resource.
/// </summary>
public partial class GoogleComputeSecurityPolicyRule(string name) : TerraformResource("google_compute_security_policy_rule", name)
{
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
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
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
    /// If set to true, the specified action is not enforced.
    /// </summary>
    public TerraformValue<bool>? Preview
    {
        get => new TerraformReference<bool>(this, "preview");
        set => SetArgument("preview", value);
    }

    /// <summary>
    /// An integer indicating the priority of a rule in the list.
    /// The priority must be a positive value between 0 and 2147483647.
    /// Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest priority.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The name of the security policy this rule belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityPolicy is required")]
    public required TerraformValue<string> SecurityPolicy
    {
        get => new TerraformReference<string>(this, "security_policy");
        set => SetArgument("security_policy", value);
    }

    /// <summary>
    /// HeaderAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderAction block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyRuleHeaderActionBlock>? HeaderAction
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleHeaderActionBlock>>("header_action");
        set => SetArgument("header_action", value);
    }

    /// <summary>
    /// Match block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyRuleMatchBlock>? Match
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleMatchBlock>>("match");
        set => SetArgument("match", value);
    }

    /// <summary>
    /// PreconfiguredWafConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreconfiguredWafConfig block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlock>? PreconfiguredWafConfig
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRulePreconfiguredWafConfigBlock>>("preconfigured_waf_config");
        set => SetArgument("preconfigured_waf_config", value);
    }

    /// <summary>
    /// RateLimitOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RateLimitOptions block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyRuleRateLimitOptionsBlock>? RateLimitOptions
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleRateLimitOptionsBlock>>("rate_limit_options");
        set => SetArgument("rate_limit_options", value);
    }

    /// <summary>
    /// RedirectOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedirectOptions block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyRuleRedirectOptionsBlock>? RedirectOptions
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleRedirectOptionsBlock>>("redirect_options");
        set => SetArgument("redirect_options", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeSecurityPolicyRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeSecurityPolicyRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
