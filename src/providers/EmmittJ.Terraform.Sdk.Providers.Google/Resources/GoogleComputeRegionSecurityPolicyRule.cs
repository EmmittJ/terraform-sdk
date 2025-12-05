using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for match in GoogleComputeRegionSecurityPolicyRule.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRuleMatchBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("versioned_expr");
        set => SetArgument("versioned_expr", value);
    }

    /// <summary>
    /// Config block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public TerraformList<GoogleComputeRegionSecurityPolicyRuleMatchBlockConfigBlock>? Config
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRuleMatchBlockConfigBlock>>("config");
        set => SetArgument("config", value);
    }

    /// <summary>
    /// Expr block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Expr block(s) allowed")]
    public TerraformList<GoogleComputeRegionSecurityPolicyRuleMatchBlockExprBlock>? Expr
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRuleMatchBlockExprBlock>>("expr");
        set => SetArgument("expr", value);
    }

}

/// <summary>
/// Block type for config in GoogleComputeRegionSecurityPolicyRuleMatchBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRuleMatchBlockConfigBlock : TerraformBlock
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
        get => GetArgument<TerraformList<string>>("src_ip_ranges");
        set => SetArgument("src_ip_ranges", value);
    }

}

/// <summary>
/// Block type for expr in GoogleComputeRegionSecurityPolicyRuleMatchBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRuleMatchBlockExprBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

}


/// <summary>
/// Block type for network_match in GoogleComputeRegionSecurityPolicyRule.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRuleNetworkMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_match";

    /// <summary>
    /// Destination IPv4/IPv6 addresses or CIDR prefixes, in standard text format.
    /// </summary>
    public TerraformList<string>? DestIpRanges
    {
        get => GetArgument<TerraformList<string>>("dest_ip_ranges");
        set => SetArgument("dest_ip_ranges", value);
    }

    /// <summary>
    /// Destination port numbers for TCP/UDP/SCTP. Each element can be a 16-bit unsigned decimal number (e.g. &amp;quot;80&amp;quot;) or range (e.g. &amp;quot;0-1023&amp;quot;).
    /// </summary>
    public TerraformList<string>? DestPorts
    {
        get => GetArgument<TerraformList<string>>("dest_ports");
        set => SetArgument("dest_ports", value);
    }

    /// <summary>
    /// IPv4 protocol / IPv6 next header (after extension headers). Each element can be an 8-bit unsigned decimal number (e.g. &amp;quot;6&amp;quot;), range (e.g. &amp;quot;253-254&amp;quot;), or one of the following protocol names: &amp;quot;tcp&amp;quot;, &amp;quot;udp&amp;quot;, &amp;quot;icmp&amp;quot;, &amp;quot;esp&amp;quot;, &amp;quot;ah&amp;quot;, &amp;quot;ipip&amp;quot;, or &amp;quot;sctp&amp;quot;.
    /// </summary>
    public TerraformList<string>? IpProtocols
    {
        get => GetArgument<TerraformList<string>>("ip_protocols");
        set => SetArgument("ip_protocols", value);
    }

    /// <summary>
    /// BGP Autonomous System Number associated with the source IP address.
    /// </summary>
    public TerraformList<double>? SrcAsns
    {
        get => GetArgument<TerraformList<double>>("src_asns");
        set => SetArgument("src_asns", value);
    }

    /// <summary>
    /// Source IPv4/IPv6 addresses or CIDR prefixes, in standard text format.
    /// </summary>
    public TerraformList<string>? SrcIpRanges
    {
        get => GetArgument<TerraformList<string>>("src_ip_ranges");
        set => SetArgument("src_ip_ranges", value);
    }

    /// <summary>
    /// Source port numbers for TCP/UDP/SCTP. Each element can be a 16-bit unsigned decimal number (e.g. &amp;quot;80&amp;quot;) or range (e.g. &amp;quot;0-1023&amp;quot;).
    /// </summary>
    public TerraformList<string>? SrcPorts
    {
        get => GetArgument<TerraformList<string>>("src_ports");
        set => SetArgument("src_ports", value);
    }

    /// <summary>
    /// Two-letter ISO 3166-1 alpha-2 country code associated with the source IP address.
    /// </summary>
    public TerraformList<string>? SrcRegionCodes
    {
        get => GetArgument<TerraformList<string>>("src_region_codes");
        set => SetArgument("src_region_codes", value);
    }

    /// <summary>
    /// UserDefinedFields block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionSecurityPolicyRuleNetworkMatchBlockUserDefinedFieldsBlock>? UserDefinedFields
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRuleNetworkMatchBlockUserDefinedFieldsBlock>>("user_defined_fields");
        set => SetArgument("user_defined_fields", value);
    }

}

/// <summary>
/// Block type for user_defined_fields in GoogleComputeRegionSecurityPolicyRuleNetworkMatchBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRuleNetworkMatchBlockUserDefinedFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_defined_fields";

    /// <summary>
    /// Name of the user-defined field, as given in the definition.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Matching values of the field. Each element can be a 32-bit unsigned decimal or hexadecimal (starting with &amp;quot;0x&amp;quot;) number (e.g. &amp;quot;64&amp;quot;) or range (e.g. &amp;quot;0x400-0x7ff&amp;quot;).
    /// </summary>
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for preconfigured_waf_config in GoogleComputeRegionSecurityPolicyRule.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "preconfigured_waf_config";

    /// <summary>
    /// Exclusion block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlock>? Exclusion
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlock>>("exclusion");
        set => SetArgument("exclusion", value);
    }

}

/// <summary>
/// Block type for exclusion in GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlock : TerraformBlock
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
        get => GetArgument<TerraformList<string>>("target_rule_ids");
        set => SetArgument("target_rule_ids", value);
    }

    /// <summary>
    /// Target WAF rule set to apply the preconfigured WAF exclusion.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRuleSet is required")]
    public required TerraformValue<string> TargetRuleSet
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_rule_set");
        set => SetArgument("target_rule_set", value);
    }

    /// <summary>
    /// RequestCookie block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestCookieBlock>? RequestCookie
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestCookieBlock>>("request_cookie");
        set => SetArgument("request_cookie", value);
    }

    /// <summary>
    /// RequestHeader block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestHeaderBlock>? RequestHeader
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestHeaderBlock>>("request_header");
        set => SetArgument("request_header", value);
    }

    /// <summary>
    /// RequestQueryParam block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestQueryParamBlock>? RequestQueryParam
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestQueryParamBlock>>("request_query_param");
        set => SetArgument("request_query_param", value);
    }

    /// <summary>
    /// RequestUri block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestUriBlock>? RequestUri
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestUriBlock>>("request_uri");
        set => SetArgument("request_uri", value);
    }

}

/// <summary>
/// Block type for request_cookie in GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestCookieBlock : TerraformBlock
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
    /// EQUALS_ANY: The operator matches if the field value is any value. Possible values: [&amp;quot;CONTAINS&amp;quot;, &amp;quot;ENDS_WITH&amp;quot;, &amp;quot;EQUALS&amp;quot;, &amp;quot;EQUALS_ANY&amp;quot;, &amp;quot;STARTS_WITH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation.
    /// The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for request_header in GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestHeaderBlock : TerraformBlock
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
    /// EQUALS_ANY: The operator matches if the field value is any value. Possible values: [&amp;quot;CONTAINS&amp;quot;, &amp;quot;ENDS_WITH&amp;quot;, &amp;quot;EQUALS&amp;quot;, &amp;quot;EQUALS_ANY&amp;quot;, &amp;quot;STARTS_WITH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation.
    /// The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for request_query_param in GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestQueryParamBlock : TerraformBlock
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
    /// EQUALS_ANY: The operator matches if the field value is any value. Possible values: [&amp;quot;CONTAINS&amp;quot;, &amp;quot;ENDS_WITH&amp;quot;, &amp;quot;EQUALS&amp;quot;, &amp;quot;EQUALS_ANY&amp;quot;, &amp;quot;STARTS_WITH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation.
    /// The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for request_uri in GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlockExclusionBlockRequestUriBlock : TerraformBlock
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
    /// EQUALS_ANY: The operator matches if the field value is any value. Possible values: [&amp;quot;CONTAINS&amp;quot;, &amp;quot;ENDS_WITH&amp;quot;, &amp;quot;EQUALS&amp;quot;, &amp;quot;EQUALS_ANY&amp;quot;, &amp;quot;STARTS_WITH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation.
    /// The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for rate_limit_options in GoogleComputeRegionSecurityPolicyRule.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRuleRateLimitOptionsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("ban_duration_sec");
        set => SetArgument("ban_duration_sec", value);
    }

    /// <summary>
    /// Action to take for requests that are under the configured rate limit threshold.
    /// Valid option is &amp;quot;allow&amp;quot; only.
    /// </summary>
    public TerraformValue<string>? ConformAction
    {
        get => GetArgument<TerraformValue<string>>("conform_action");
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
        get => GetArgument<TerraformValue<string>>("enforce_on_key");
        set => SetArgument("enforce_on_key", value);
    }

    /// <summary>
    /// Rate limit key name applicable only for the following key types:
    /// HTTP_HEADER -- Name of the HTTP header whose value is taken as the key value.
    /// HTTP_COOKIE -- Name of the HTTP cookie whose value is taken as the key value.
    /// </summary>
    public TerraformValue<string>? EnforceOnKeyName
    {
        get => GetArgument<TerraformValue<string>>("enforce_on_key_name");
        set => SetArgument("enforce_on_key_name", value);
    }

    /// <summary>
    /// Action to take for requests that are above the configured rate limit threshold, to deny with a specified HTTP response code.
    /// Valid options are deny(STATUS), where valid values for STATUS are 403, 404, 429, and 502.
    /// </summary>
    public TerraformValue<string>? ExceedAction
    {
        get => GetArgument<TerraformValue<string>>("exceed_action");
        set => SetArgument("exceed_action", value);
    }

    /// <summary>
    /// BanThreshold block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BanThreshold block(s) allowed")]
    public TerraformList<GoogleComputeRegionSecurityPolicyRuleRateLimitOptionsBlockBanThresholdBlock>? BanThreshold
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRuleRateLimitOptionsBlockBanThresholdBlock>>("ban_threshold");
        set => SetArgument("ban_threshold", value);
    }

    /// <summary>
    /// EnforceOnKeyConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionSecurityPolicyRuleRateLimitOptionsBlockEnforceOnKeyConfigsBlock>? EnforceOnKeyConfigs
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRuleRateLimitOptionsBlockEnforceOnKeyConfigsBlock>>("enforce_on_key_configs");
        set => SetArgument("enforce_on_key_configs", value);
    }

    /// <summary>
    /// RateLimitThreshold block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RateLimitThreshold block(s) allowed")]
    public TerraformList<GoogleComputeRegionSecurityPolicyRuleRateLimitOptionsBlockRateLimitThresholdBlock>? RateLimitThreshold
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRuleRateLimitOptionsBlockRateLimitThresholdBlock>>("rate_limit_threshold");
        set => SetArgument("rate_limit_threshold", value);
    }

}

/// <summary>
/// Block type for ban_threshold in GoogleComputeRegionSecurityPolicyRuleRateLimitOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRuleRateLimitOptionsBlockBanThresholdBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// Interval over which the threshold is computed.
    /// </summary>
    public TerraformValue<double>? IntervalSec
    {
        get => GetArgument<TerraformValue<double>>("interval_sec");
        set => SetArgument("interval_sec", value);
    }

}

/// <summary>
/// Block type for enforce_on_key_configs in GoogleComputeRegionSecurityPolicyRuleRateLimitOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRuleRateLimitOptionsBlockEnforceOnKeyConfigsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("enforce_on_key_name");
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
        get => GetArgument<TerraformValue<string>>("enforce_on_key_type");
        set => SetArgument("enforce_on_key_type", value);
    }

}

/// <summary>
/// Block type for rate_limit_threshold in GoogleComputeRegionSecurityPolicyRuleRateLimitOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRuleRateLimitOptionsBlockRateLimitThresholdBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// Interval over which the threshold is computed.
    /// </summary>
    public TerraformValue<double>? IntervalSec
    {
        get => GetArgument<TerraformValue<double>>("interval_sec");
        set => SetArgument("interval_sec", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeRegionSecurityPolicyRule.
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionSecurityPolicyRuleTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_region_security_policy_rule Terraform resource.
/// Manages a google_compute_region_security_policy_rule resource.
/// </summary>
public partial class GoogleComputeRegionSecurityPolicyRule(string name) : TerraformResource("google_compute_region_security_policy_rule", name)
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
        get => GetRequiredArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// If set to true, the specified action is not enforced.
    /// </summary>
    public TerraformValue<bool>? Preview
    {
        get => GetArgument<TerraformValue<bool>>("preview");
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
        get => GetRequiredArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The Region in which the created Region Security Policy rule should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformValue<string> Region
    {
        get => GetRequiredArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The name of the security policy this rule belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityPolicy is required")]
    public required TerraformValue<string> SecurityPolicy
    {
        get => GetRequiredArgument<TerraformValue<string>>("security_policy");
        set => SetArgument("security_policy", value);
    }

    /// <summary>
    /// Match block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public TerraformList<GoogleComputeRegionSecurityPolicyRuleMatchBlock>? Match
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRuleMatchBlock>>("match");
        set => SetArgument("match", value);
    }

    /// <summary>
    /// NetworkMatch block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkMatch block(s) allowed")]
    public TerraformList<GoogleComputeRegionSecurityPolicyRuleNetworkMatchBlock>? NetworkMatch
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRuleNetworkMatchBlock>>("network_match");
        set => SetArgument("network_match", value);
    }

    /// <summary>
    /// PreconfiguredWafConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreconfiguredWafConfig block(s) allowed")]
    public TerraformList<GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlock>? PreconfiguredWafConfig
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlock>>("preconfigured_waf_config");
        set => SetArgument("preconfigured_waf_config", value);
    }

    /// <summary>
    /// RateLimitOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RateLimitOptions block(s) allowed")]
    public TerraformList<GoogleComputeRegionSecurityPolicyRuleRateLimitOptionsBlock>? RateLimitOptions
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRuleRateLimitOptionsBlock>>("rate_limit_options");
        set => SetArgument("rate_limit_options", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeRegionSecurityPolicyRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeRegionSecurityPolicyRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
