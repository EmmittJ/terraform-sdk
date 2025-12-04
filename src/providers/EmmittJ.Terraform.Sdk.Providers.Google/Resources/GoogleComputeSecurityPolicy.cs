using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for adaptive_protection_config in GoogleComputeSecurityPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyAdaptiveProtectionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "adaptive_protection_config";

    /// <summary>
    /// Layer7DdosDefenseConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Layer7DdosDefenseConfig block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyAdaptiveProtectionConfigBlockLayer7DdosDefenseConfigBlock>? Layer7DdosDefenseConfig
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyAdaptiveProtectionConfigBlockLayer7DdosDefenseConfigBlock>>("layer_7_ddos_defense_config");
        set => SetArgument("layer_7_ddos_defense_config", value);
    }

}

/// <summary>
/// Block type for layer_7_ddos_defense_config in GoogleComputeSecurityPolicyAdaptiveProtectionConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyAdaptiveProtectionConfigBlockLayer7DdosDefenseConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "layer_7_ddos_defense_config";

    /// <summary>
    /// If set to true, enables CAAP for L7 DDoS detection.
    /// </summary>
    public TerraformValue<bool>? Enable
    {
        get => GetArgument<TerraformValue<bool>>("enable");
        set => SetArgument("enable", value);
    }

    /// <summary>
    /// Rule visibility. Supported values include: &amp;quot;STANDARD&amp;quot;, &amp;quot;PREMIUM&amp;quot;.
    /// </summary>
    public TerraformValue<string>? RuleVisibility
    {
        get => GetArgument<TerraformValue<string>>("rule_visibility");
        set => SetArgument("rule_visibility", value);
    }

    /// <summary>
    /// ThresholdConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeSecurityPolicyAdaptiveProtectionConfigBlockLayer7DdosDefenseConfigBlockThresholdConfigsBlock>? ThresholdConfigs
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyAdaptiveProtectionConfigBlockLayer7DdosDefenseConfigBlockThresholdConfigsBlock>>("threshold_configs");
        set => SetArgument("threshold_configs", value);
    }

}

/// <summary>
/// Block type for threshold_configs in GoogleComputeSecurityPolicyAdaptiveProtectionConfigBlockLayer7DdosDefenseConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyAdaptiveProtectionConfigBlockLayer7DdosDefenseConfigBlockThresholdConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "threshold_configs";

    /// <summary>
    /// The auto_deploy_confidence_threshold attribute.
    /// </summary>
    public TerraformValue<double>? AutoDeployConfidenceThreshold
    {
        get => GetArgument<TerraformValue<double>>("auto_deploy_confidence_threshold");
        set => SetArgument("auto_deploy_confidence_threshold", value);
    }

    /// <summary>
    /// The auto_deploy_expiration_sec attribute.
    /// </summary>
    public TerraformValue<double>? AutoDeployExpirationSec
    {
        get => GetArgument<TerraformValue<double>>("auto_deploy_expiration_sec");
        set => SetArgument("auto_deploy_expiration_sec", value);
    }

    /// <summary>
    /// The auto_deploy_impacted_baseline_threshold attribute.
    /// </summary>
    public TerraformValue<double>? AutoDeployImpactedBaselineThreshold
    {
        get => GetArgument<TerraformValue<double>>("auto_deploy_impacted_baseline_threshold");
        set => SetArgument("auto_deploy_impacted_baseline_threshold", value);
    }

    /// <summary>
    /// The auto_deploy_load_threshold attribute.
    /// </summary>
    public TerraformValue<double>? AutoDeployLoadThreshold
    {
        get => GetArgument<TerraformValue<double>>("auto_deploy_load_threshold");
        set => SetArgument("auto_deploy_load_threshold", value);
    }

    /// <summary>
    /// The detection_absolute_qps attribute.
    /// </summary>
    public TerraformValue<double>? DetectionAbsoluteQps
    {
        get => GetArgument<TerraformValue<double>>("detection_absolute_qps");
        set => SetArgument("detection_absolute_qps", value);
    }

    /// <summary>
    /// The detection_load_threshold attribute.
    /// </summary>
    public TerraformValue<double>? DetectionLoadThreshold
    {
        get => GetArgument<TerraformValue<double>>("detection_load_threshold");
        set => SetArgument("detection_load_threshold", value);
    }

    /// <summary>
    /// The detection_relative_to_baseline_qps attribute.
    /// </summary>
    public TerraformValue<double>? DetectionRelativeToBaselineQps
    {
        get => GetArgument<TerraformValue<double>>("detection_relative_to_baseline_qps");
        set => SetArgument("detection_relative_to_baseline_qps", value);
    }

    /// <summary>
    /// The name must be 1-63 characters long, and comply with RFC1035. The name must be unique within the security policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// TrafficGranularityConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeSecurityPolicyAdaptiveProtectionConfigBlockLayer7DdosDefenseConfigBlockThresholdConfigsBlockTrafficGranularityConfigsBlock>? TrafficGranularityConfigs
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyAdaptiveProtectionConfigBlockLayer7DdosDefenseConfigBlockThresholdConfigsBlockTrafficGranularityConfigsBlock>>("traffic_granularity_configs");
        set => SetArgument("traffic_granularity_configs", value);
    }

}

/// <summary>
/// Block type for traffic_granularity_configs in GoogleComputeSecurityPolicyAdaptiveProtectionConfigBlockLayer7DdosDefenseConfigBlockThresholdConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyAdaptiveProtectionConfigBlockLayer7DdosDefenseConfigBlockThresholdConfigsBlockTrafficGranularityConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "traffic_granularity_configs";

    /// <summary>
    /// If enabled, traffic matching each unique value for the specified type constitutes a separate traffic unit. It can only be set to true if value is empty.
    /// </summary>
    public TerraformValue<bool>? EnableEachUniqueValue
    {
        get => GetArgument<TerraformValue<bool>>("enable_each_unique_value");
        set => SetArgument("enable_each_unique_value", value);
    }

    /// <summary>
    /// Type of this configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Requests that match this value constitute a granular traffic unit.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for advanced_options_config in GoogleComputeSecurityPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyAdvancedOptionsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_options_config";

    /// <summary>
    /// JSON body parsing. Supported values include: &amp;quot;DISABLED&amp;quot;, &amp;quot;STANDARD&amp;quot;.
    /// </summary>
    public TerraformValue<string>? JsonParsing
    {
        get => GetArgument<TerraformValue<string>>("json_parsing");
        set => SetArgument("json_parsing", value);
    }

    /// <summary>
    /// Logging level. Supported values include: &amp;quot;NORMAL&amp;quot;, &amp;quot;VERBOSE&amp;quot;.
    /// </summary>
    public TerraformValue<string>? LogLevel
    {
        get => GetArgument<TerraformValue<string>>("log_level");
        set => SetArgument("log_level", value);
    }

    /// <summary>
    /// An optional list of case-insensitive request header names to use for resolving the callers client IP address.
    /// </summary>
    public TerraformSet<string>? UserIpRequestHeaders
    {
        get => GetArgument<TerraformSet<string>>("user_ip_request_headers");
        set => SetArgument("user_ip_request_headers", value);
    }

    /// <summary>
    /// JsonCustomConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JsonCustomConfig block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyAdvancedOptionsConfigBlockJsonCustomConfigBlock>? JsonCustomConfig
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyAdvancedOptionsConfigBlockJsonCustomConfigBlock>>("json_custom_config");
        set => SetArgument("json_custom_config", value);
    }

}

/// <summary>
/// Block type for json_custom_config in GoogleComputeSecurityPolicyAdvancedOptionsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyAdvancedOptionsConfigBlockJsonCustomConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "json_custom_config";

    /// <summary>
    /// A list of custom Content-Type header values to apply the JSON parsing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentTypes is required")]
    public required TerraformSet<string> ContentTypes
    {
        get => GetArgument<TerraformSet<string>>("content_types");
        set => SetArgument("content_types", value);
    }

}


/// <summary>
/// Block type for recaptcha_options_config in GoogleComputeSecurityPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRecaptchaOptionsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recaptcha_options_config";

    /// <summary>
    /// A field to supply a reCAPTCHA site key to be used for all the rules using the redirect action with the type of GOOGLE_RECAPTCHA under the security policy. The specified site key needs to be created from the reCAPTCHA API. The user is responsible for the validity of the specified site key. If not specified, a Google-managed site key is used.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectSiteKey is required")]
    public required TerraformValue<string> RedirectSiteKey
    {
        get => GetArgument<TerraformValue<string>>("redirect_site_key");
        set => SetArgument("redirect_site_key", value);
    }

}


/// <summary>
/// Block type for rule in GoogleComputeSecurityPolicy.
/// Nesting mode: set
/// </summary>
public class GoogleComputeSecurityPolicyRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// Action to take when match matches the request.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// An optional description of this rule. Max size is 64.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// When set to true, the action specified above is not enforced. Stackdriver logs for requests that trigger a preview action are annotated as such.
    /// </summary>
    public TerraformValue<bool>? Preview
    {
        get => GetArgument<TerraformValue<bool>>("preview");
        set => SetArgument("preview", value);
    }

    /// <summary>
    /// An unique positive integer indicating the priority of evaluation for a rule. Rules are evaluated from highest priority (lowest numerically) to lowest priority (highest numerically) in order.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// HeaderAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderAction block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyRuleBlockHeaderActionBlock>? HeaderAction
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleBlockHeaderActionBlock>>("header_action");
        set => SetArgument("header_action", value);
    }

    /// <summary>
    /// Match block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Match is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Match block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public required TerraformList<GoogleComputeSecurityPolicyRuleBlockMatchBlock> Match
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeSecurityPolicyRuleBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

    /// <summary>
    /// PreconfiguredWafConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreconfiguredWafConfig block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlock>? PreconfiguredWafConfig
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlock>>("preconfigured_waf_config");
        set => SetArgument("preconfigured_waf_config", value);
    }

    /// <summary>
    /// RateLimitOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RateLimitOptions block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyRuleBlockRateLimitOptionsBlock>? RateLimitOptions
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleBlockRateLimitOptionsBlock>>("rate_limit_options");
        set => SetArgument("rate_limit_options", value);
    }

    /// <summary>
    /// RedirectOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedirectOptions block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyRuleBlockRedirectOptionsBlock>? RedirectOptions
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleBlockRedirectOptionsBlock>>("redirect_options");
        set => SetArgument("redirect_options", value);
    }

}

/// <summary>
/// Block type for header_action in GoogleComputeSecurityPolicyRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleBlockHeaderActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header_action";

    /// <summary>
    /// RequestHeadersToAdds block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequestHeadersToAdds is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RequestHeadersToAdds block(s) required")]
    public required TerraformList<GoogleComputeSecurityPolicyRuleBlockHeaderActionBlockRequestHeadersToAddsBlock> RequestHeadersToAdds
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeSecurityPolicyRuleBlockHeaderActionBlockRequestHeadersToAddsBlock>>("request_headers_to_adds");
        set => SetArgument("request_headers_to_adds", value);
    }

}

/// <summary>
/// Block type for request_headers_to_adds in GoogleComputeSecurityPolicyRuleBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleBlockHeaderActionBlockRequestHeadersToAddsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_headers_to_adds";

    /// <summary>
    /// The name of the header to set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value to set the named header to.
    /// </summary>
    public TerraformValue<string>? HeaderValue
    {
        get => GetArgument<TerraformValue<string>>("header_value");
        set => SetArgument("header_value", value);
    }

}

/// <summary>
/// Block type for match in GoogleComputeSecurityPolicyRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleBlockMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match";

    /// <summary>
    /// Predefined rule expression. If this field is specified, config must also be specified. Available options:   SRC_IPS_V1: Must specify the corresponding src_ip_ranges field in config.
    /// </summary>
    public TerraformValue<string>? VersionedExpr
    {
        get => GetArgument<TerraformValue<string>>("versioned_expr");
        set => SetArgument("versioned_expr", value);
    }

    /// <summary>
    /// Config block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyRuleBlockMatchBlockConfigBlock>? Config
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleBlockMatchBlockConfigBlock>>("config");
        set => SetArgument("config", value);
    }

    /// <summary>
    /// Expr block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Expr block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyRuleBlockMatchBlockExprBlock>? Expr
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleBlockMatchBlockExprBlock>>("expr");
        set => SetArgument("expr", value);
    }

    /// <summary>
    /// ExprOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExprOptions block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyRuleBlockMatchBlockExprOptionsBlock>? ExprOptions
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleBlockMatchBlockExprOptionsBlock>>("expr_options");
        set => SetArgument("expr_options", value);
    }

}

/// <summary>
/// Block type for config in GoogleComputeSecurityPolicyRuleBlockMatchBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleBlockMatchBlockConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config";

    /// <summary>
    /// Set of IP addresses or ranges (IPV4 or IPV6) in CIDR notation to match against inbound traffic. There is a limit of 10 IP ranges per rule. A value of &#39;*&#39; matches all IPs (can be used to override the default behavior).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SrcIpRanges is required")]
    public required TerraformSet<string> SrcIpRanges
    {
        get => GetArgument<TerraformSet<string>>("src_ip_ranges");
        set => SetArgument("src_ip_ranges", value);
    }

}

/// <summary>
/// Block type for expr in GoogleComputeSecurityPolicyRuleBlockMatchBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleBlockMatchBlockExprBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

}

/// <summary>
/// Block type for expr_options in GoogleComputeSecurityPolicyRuleBlockMatchBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleBlockMatchBlockExprOptionsBlock : TerraformBlock
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
    public required TerraformList<GoogleComputeSecurityPolicyRuleBlockMatchBlockExprOptionsBlockRecaptchaOptionsBlock> RecaptchaOptions
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeSecurityPolicyRuleBlockMatchBlockExprOptionsBlockRecaptchaOptionsBlock>>("recaptcha_options");
        set => SetArgument("recaptcha_options", value);
    }

}

/// <summary>
/// Block type for recaptcha_options in GoogleComputeSecurityPolicyRuleBlockMatchBlockExprOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleBlockMatchBlockExprOptionsBlockRecaptchaOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recaptcha_options";

    /// <summary>
    /// A list of site keys to be used during the validation of reCAPTCHA action-tokens. The provided site keys need to be created from reCAPTCHA API under the same project where the security policy is created
    /// </summary>
    public TerraformList<string>? ActionTokenSiteKeys
    {
        get => GetArgument<TerraformList<string>>("action_token_site_keys");
        set => SetArgument("action_token_site_keys", value);
    }

    /// <summary>
    /// A list of site keys to be used during the validation of reCAPTCHA session-tokens. The provided site keys need to be created from reCAPTCHA API under the same project where the security policy is created.
    /// </summary>
    public TerraformList<string>? SessionTokenSiteKeys
    {
        get => GetArgument<TerraformList<string>>("session_token_site_keys");
        set => SetArgument("session_token_site_keys", value);
    }

}

/// <summary>
/// Block type for preconfigured_waf_config in GoogleComputeSecurityPolicyRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "preconfigured_waf_config";

    /// <summary>
    /// Exclusion block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlockExclusionBlock>? Exclusion
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlockExclusionBlock>>("exclusion");
        set => SetArgument("exclusion", value);
    }

}

/// <summary>
/// Block type for exclusion in GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlockExclusionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclusion";

    /// <summary>
    /// A list of target rule IDs under the WAF rule set to apply the preconfigured WAF exclusion. If omitted, it refers to all the rule IDs under the WAF rule set.
    /// </summary>
    public TerraformSet<string>? TargetRuleIds
    {
        get => GetArgument<TerraformSet<string>>("target_rule_ids");
        set => SetArgument("target_rule_ids", value);
    }

    /// <summary>
    /// Target WAF rule set to apply the preconfigured WAF exclusion.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRuleSet is required")]
    public required TerraformValue<string> TargetRuleSet
    {
        get => GetArgument<TerraformValue<string>>("target_rule_set");
        set => SetArgument("target_rule_set", value);
    }

    /// <summary>
    /// RequestCookie block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlockExclusionBlockRequestCookieBlock>? RequestCookie
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlockExclusionBlockRequestCookieBlock>>("request_cookie");
        set => SetArgument("request_cookie", value);
    }

    /// <summary>
    /// RequestHeader block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlockExclusionBlockRequestHeaderBlock>? RequestHeader
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlockExclusionBlockRequestHeaderBlock>>("request_header");
        set => SetArgument("request_header", value);
    }

    /// <summary>
    /// RequestQueryParam block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlockExclusionBlockRequestQueryParamBlock>? RequestQueryParam
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlockExclusionBlockRequestQueryParamBlock>>("request_query_param");
        set => SetArgument("request_query_param", value);
    }

    /// <summary>
    /// RequestUri block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlockExclusionBlockRequestUriBlock>? RequestUri
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlockExclusionBlockRequestUriBlock>>("request_uri");
        set => SetArgument("request_uri", value);
    }

}

/// <summary>
/// Block type for request_cookie in GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlockExclusionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlockExclusionBlockRequestCookieBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_cookie";

    /// <summary>
    /// You can specify an exact match or a partial match by using a field operator and a field value. Available options: EQUALS: The operator matches if the field value equals the specified value. STARTS_WITH: The operator matches if the field value starts with the specified value. ENDS_WITH: The operator matches if the field value ends with the specified value. CONTAINS: The operator matches if the field value contains the specified value. EQUALS_ANY: The operator matches if the field value is any value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation. The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for request_header in GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlockExclusionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlockExclusionBlockRequestHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_header";

    /// <summary>
    /// You can specify an exact match or a partial match by using a field operator and a field value. Available options: EQUALS: The operator matches if the field value equals the specified value. STARTS_WITH: The operator matches if the field value starts with the specified value. ENDS_WITH: The operator matches if the field value ends with the specified value. CONTAINS: The operator matches if the field value contains the specified value. EQUALS_ANY: The operator matches if the field value is any value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation. The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for request_query_param in GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlockExclusionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlockExclusionBlockRequestQueryParamBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_query_param";

    /// <summary>
    /// You can specify an exact match or a partial match by using a field operator and a field value. Available options: EQUALS: The operator matches if the field value equals the specified value. STARTS_WITH: The operator matches if the field value starts with the specified value. ENDS_WITH: The operator matches if the field value ends with the specified value. CONTAINS: The operator matches if the field value contains the specified value. EQUALS_ANY: The operator matches if the field value is any value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation. The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for request_uri in GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlockExclusionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleBlockPreconfiguredWafConfigBlockExclusionBlockRequestUriBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_uri";

    /// <summary>
    /// You can specify an exact match or a partial match by using a field operator and a field value. Available options: EQUALS: The operator matches if the field value equals the specified value. STARTS_WITH: The operator matches if the field value starts with the specified value. ENDS_WITH: The operator matches if the field value ends with the specified value. CONTAINS: The operator matches if the field value contains the specified value. EQUALS_ANY: The operator matches if the field value is any value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation. The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for rate_limit_options in GoogleComputeSecurityPolicyRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleBlockRateLimitOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rate_limit_options";

    /// <summary>
    /// Can only be specified if the action for the rule is &amp;quot;rate_based_ban&amp;quot;. If specified, determines the time (in seconds) the traffic will continue to be banned by the rate limit after the rate falls below the threshold.
    /// </summary>
    public TerraformValue<double>? BanDurationSec
    {
        get => GetArgument<TerraformValue<double>>("ban_duration_sec");
        set => SetArgument("ban_duration_sec", value);
    }

    /// <summary>
    /// Action to take for requests that are under the configured rate limit threshold. Valid option is &amp;quot;allow&amp;quot; only.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConformAction is required")]
    public required TerraformValue<string> ConformAction
    {
        get => GetArgument<TerraformValue<string>>("conform_action");
        set => SetArgument("conform_action", value);
    }

    /// <summary>
    /// Determines the key to enforce the rateLimitThreshold on
    /// </summary>
    public TerraformValue<string>? EnforceOnKey
    {
        get => GetArgument<TerraformValue<string>>("enforce_on_key");
        set => SetArgument("enforce_on_key", value);
    }

    /// <summary>
    /// Rate limit key name applicable only for the following key types: HTTP_HEADER -- Name of the HTTP header whose value is taken as the key value. HTTP_COOKIE -- Name of the HTTP cookie whose value is taken as the key value.
    /// </summary>
    public TerraformValue<string>? EnforceOnKeyName
    {
        get => GetArgument<TerraformValue<string>>("enforce_on_key_name");
        set => SetArgument("enforce_on_key_name", value);
    }

    /// <summary>
    /// Action to take for requests that are above the configured rate limit threshold, to either deny with a specified HTTP response code, or redirect to a different endpoint. Valid options are &amp;quot;deny()&amp;quot; where valid values for status are 403, 404, 429, and 502, and &amp;quot;redirect&amp;quot; where the redirect parameters come from exceedRedirectOptions below.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExceedAction is required")]
    public required TerraformValue<string> ExceedAction
    {
        get => GetArgument<TerraformValue<string>>("exceed_action");
        set => SetArgument("exceed_action", value);
    }

    /// <summary>
    /// BanThreshold block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BanThreshold block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyRuleBlockRateLimitOptionsBlockBanThresholdBlock>? BanThreshold
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleBlockRateLimitOptionsBlockBanThresholdBlock>>("ban_threshold");
        set => SetArgument("ban_threshold", value);
    }

    /// <summary>
    /// EnforceOnKeyConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeSecurityPolicyRuleBlockRateLimitOptionsBlockEnforceOnKeyConfigsBlock>? EnforceOnKeyConfigs
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleBlockRateLimitOptionsBlockEnforceOnKeyConfigsBlock>>("enforce_on_key_configs");
        set => SetArgument("enforce_on_key_configs", value);
    }

    /// <summary>
    /// ExceedRedirectOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExceedRedirectOptions block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyRuleBlockRateLimitOptionsBlockExceedRedirectOptionsBlock>? ExceedRedirectOptions
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRuleBlockRateLimitOptionsBlockExceedRedirectOptionsBlock>>("exceed_redirect_options");
        set => SetArgument("exceed_redirect_options", value);
    }

    /// <summary>
    /// RateLimitThreshold block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RateLimitThreshold is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RateLimitThreshold block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RateLimitThreshold block(s) allowed")]
    public required TerraformList<GoogleComputeSecurityPolicyRuleBlockRateLimitOptionsBlockRateLimitThresholdBlock> RateLimitThreshold
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeSecurityPolicyRuleBlockRateLimitOptionsBlockRateLimitThresholdBlock>>("rate_limit_threshold");
        set => SetArgument("rate_limit_threshold", value);
    }

}

/// <summary>
/// Block type for ban_threshold in GoogleComputeSecurityPolicyRuleBlockRateLimitOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleBlockRateLimitOptionsBlockBanThresholdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ban_threshold";

    /// <summary>
    /// Number of HTTP(S) requests for calculating the threshold.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountAttribute is required")]
    public required TerraformValue<double> CountAttribute
    {
        get => GetArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// Interval over which the threshold is computed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntervalSec is required")]
    public required TerraformValue<double> IntervalSec
    {
        get => GetArgument<TerraformValue<double>>("interval_sec");
        set => SetArgument("interval_sec", value);
    }

}

/// <summary>
/// Block type for enforce_on_key_configs in GoogleComputeSecurityPolicyRuleBlockRateLimitOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleBlockRateLimitOptionsBlockEnforceOnKeyConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enforce_on_key_configs";

    /// <summary>
    /// Rate limit key name applicable only for the following key types: HTTP_HEADER -- Name of the HTTP header whose value is taken as the key value. HTTP_COOKIE -- Name of the HTTP cookie whose value is taken as the key value.
    /// </summary>
    public TerraformValue<string>? EnforceOnKeyName
    {
        get => GetArgument<TerraformValue<string>>("enforce_on_key_name");
        set => SetArgument("enforce_on_key_name", value);
    }

    /// <summary>
    /// Determines the key to enforce the rate_limit_threshold on
    /// </summary>
    public TerraformValue<string>? EnforceOnKeyType
    {
        get => GetArgument<TerraformValue<string>>("enforce_on_key_type");
        set => SetArgument("enforce_on_key_type", value);
    }

}

/// <summary>
/// Block type for exceed_redirect_options in GoogleComputeSecurityPolicyRuleBlockRateLimitOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleBlockRateLimitOptionsBlockExceedRedirectOptionsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// Type of the redirect action.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for rate_limit_threshold in GoogleComputeSecurityPolicyRuleBlockRateLimitOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleBlockRateLimitOptionsBlockRateLimitThresholdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rate_limit_threshold";

    /// <summary>
    /// Number of HTTP(S) requests for calculating the threshold.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountAttribute is required")]
    public required TerraformValue<double> CountAttribute
    {
        get => GetArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// Interval over which the threshold is computed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntervalSec is required")]
    public required TerraformValue<double> IntervalSec
    {
        get => GetArgument<TerraformValue<double>>("interval_sec");
        set => SetArgument("interval_sec", value);
    }

}

/// <summary>
/// Block type for redirect_options in GoogleComputeSecurityPolicyRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRuleBlockRedirectOptionsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// Type of the redirect action. Available options: EXTERNAL_302: Must specify the corresponding target field in config. GOOGLE_RECAPTCHA: Cannot specify target field in config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeSecurityPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleComputeSecurityPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_security_policy Terraform resource.
/// Manages a google_compute_security_policy resource.
/// </summary>
public partial class GoogleComputeSecurityPolicy(string name) : TerraformResource("google_compute_security_policy", name)
{
    /// <summary>
    /// An optional description of this security policy. Max size is 2048.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// Labels to apply to this address.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The name of the security policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The type indicates the intended use of the security policy. CLOUD_ARMOR - Cloud Armor backend security policies can be configured to filter incoming HTTP requests targeting backend services. They filter requests before they hit the origin servers. CLOUD_ARMOR_EDGE - Cloud Armor edge security policies can be configured to filter incoming HTTP requests targeting backend services (including Cloud CDN-enabled) as well as backend buckets (Cloud Storage). They filter requests before the request is served from Google&#39;s cache.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Fingerprint of this resource.
    /// </summary>
    public TerraformValue<string> Fingerprint
        => AsReference("fingerprint");

    /// <summary>
    /// The unique fingerprint of the labels.
    /// </summary>
    public TerraformValue<string> LabelFingerprint
        => AsReference("label_fingerprint");

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// AdaptiveProtectionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdaptiveProtectionConfig block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyAdaptiveProtectionConfigBlock>? AdaptiveProtectionConfig
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyAdaptiveProtectionConfigBlock>>("adaptive_protection_config");
        set => SetArgument("adaptive_protection_config", value);
    }

    /// <summary>
    /// AdvancedOptionsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedOptionsConfig block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyAdvancedOptionsConfigBlock>? AdvancedOptionsConfig
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyAdvancedOptionsConfigBlock>>("advanced_options_config");
        set => SetArgument("advanced_options_config", value);
    }

    /// <summary>
    /// RecaptchaOptionsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecaptchaOptionsConfig block(s) allowed")]
    public TerraformList<GoogleComputeSecurityPolicyRecaptchaOptionsConfigBlock>? RecaptchaOptionsConfig
    {
        get => GetArgument<TerraformList<GoogleComputeSecurityPolicyRecaptchaOptionsConfigBlock>>("recaptcha_options_config");
        set => SetArgument("recaptcha_options_config", value);
    }

    /// <summary>
    /// Rule block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeSecurityPolicyRuleBlock>? Rule
    {
        get => GetArgument<TerraformSet<GoogleComputeSecurityPolicyRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeSecurityPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeSecurityPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
