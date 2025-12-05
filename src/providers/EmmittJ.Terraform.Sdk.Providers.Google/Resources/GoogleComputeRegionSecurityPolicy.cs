using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_options_config in GoogleComputeRegionSecurityPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyAdvancedOptionsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_options_config";

    /// <summary>
    /// JSON body parsing. Supported values include: &amp;quot;DISABLED&amp;quot;, &amp;quot;STANDARD&amp;quot;, &amp;quot;STANDARD_WITH_GRAPHQL&amp;quot;. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;STANDARD&amp;quot;, &amp;quot;STANDARD_WITH_GRAPHQL&amp;quot;]
    /// </summary>
    public TerraformValue<string>? JsonParsing
    {
        get => GetArgument<TerraformValue<string>>("json_parsing");
        set => SetArgument("json_parsing", value);
    }

    /// <summary>
    /// Logging level. Supported values include: &amp;quot;NORMAL&amp;quot;, &amp;quot;VERBOSE&amp;quot;. Possible values: [&amp;quot;NORMAL&amp;quot;, &amp;quot;VERBOSE&amp;quot;]
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
    public TerraformList<GoogleComputeRegionSecurityPolicyAdvancedOptionsConfigBlockJsonCustomConfigBlock>? JsonCustomConfig
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyAdvancedOptionsConfigBlockJsonCustomConfigBlock>>("json_custom_config");
        set => SetArgument("json_custom_config", value);
    }

}

/// <summary>
/// Block type for json_custom_config in GoogleComputeRegionSecurityPolicyAdvancedOptionsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyAdvancedOptionsConfigBlockJsonCustomConfigBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformSet<string>>("content_types");
        set => SetArgument("content_types", value);
    }

}


/// <summary>
/// Block type for ddos_protection_config in GoogleComputeRegionSecurityPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyDdosProtectionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ddos_protection_config";

    /// <summary>
    /// Google Cloud Armor offers the following options to help protect systems against DDoS attacks:
    /// - STANDARD: basic always-on protection for network load balancers, protocol forwarding, or VMs with public IP addresses.
    /// - ADVANCED: additional protections for Managed Protection Plus subscribers who use network load balancers, protocol forwarding, or VMs with public IP addresses.
    /// - ADVANCED_PREVIEW: flag to enable the security policy in preview mode. Possible values: [&amp;quot;ADVANCED&amp;quot;, &amp;quot;ADVANCED_PREVIEW&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DdosProtection is required")]
    public required TerraformValue<string> DdosProtection
    {
        get => GetRequiredArgument<TerraformValue<string>>("ddos_protection");
        set => SetArgument("ddos_protection", value);
    }

}


/// <summary>
/// Block type for rules in GoogleComputeRegionSecurityPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules";

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
    /// Match block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockMatchBlock>? Match
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

    /// <summary>
    /// NetworkMatch block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkMatch block(s) allowed")]
    public TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockNetworkMatchBlock>? NetworkMatch
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockNetworkMatchBlock>>("network_match");
        set => SetArgument("network_match", value);
    }

    /// <summary>
    /// PreconfiguredWafConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreconfiguredWafConfig block(s) allowed")]
    public TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlock>? PreconfiguredWafConfig
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlock>>("preconfigured_waf_config");
        set => SetArgument("preconfigured_waf_config", value);
    }

    /// <summary>
    /// RateLimitOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RateLimitOptions block(s) allowed")]
    public TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockRateLimitOptionsBlock>? RateLimitOptions
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockRateLimitOptionsBlock>>("rate_limit_options");
        set => SetArgument("rate_limit_options", value);
    }

}

/// <summary>
/// Block type for match in GoogleComputeRegionSecurityPolicyRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulesBlockMatchBlock : TerraformBlock
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
    public TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockMatchBlockConfigBlock>? Config
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockMatchBlockConfigBlock>>("config");
        set => SetArgument("config", value);
    }

    /// <summary>
    /// Expr block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Expr block(s) allowed")]
    public TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockMatchBlockExprBlock>? Expr
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockMatchBlockExprBlock>>("expr");
        set => SetArgument("expr", value);
    }

}

/// <summary>
/// Block type for config in GoogleComputeRegionSecurityPolicyRulesBlockMatchBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulesBlockMatchBlockConfigBlock : TerraformBlock
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
/// Block type for expr in GoogleComputeRegionSecurityPolicyRulesBlockMatchBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulesBlockMatchBlockExprBlock : TerraformBlock
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
/// Block type for network_match in GoogleComputeRegionSecurityPolicyRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulesBlockNetworkMatchBlock : TerraformBlock
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
    public TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockNetworkMatchBlockUserDefinedFieldsBlock>? UserDefinedFields
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockNetworkMatchBlockUserDefinedFieldsBlock>>("user_defined_fields");
        set => SetArgument("user_defined_fields", value);
    }

}

/// <summary>
/// Block type for user_defined_fields in GoogleComputeRegionSecurityPolicyRulesBlockNetworkMatchBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulesBlockNetworkMatchBlockUserDefinedFieldsBlock : TerraformBlock
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
/// Block type for preconfigured_waf_config in GoogleComputeRegionSecurityPolicyRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "preconfigured_waf_config";

    /// <summary>
    /// Exclusion block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlockExclusionBlock>? Exclusion
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlockExclusionBlock>>("exclusion");
        set => SetArgument("exclusion", value);
    }

}

/// <summary>
/// Block type for exclusion in GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlockExclusionBlock : TerraformBlock
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
    public TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlockExclusionBlockRequestCookieBlock>? RequestCookie
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlockExclusionBlockRequestCookieBlock>>("request_cookie");
        set => SetArgument("request_cookie", value);
    }

    /// <summary>
    /// RequestHeader block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlockExclusionBlockRequestHeaderBlock>? RequestHeader
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlockExclusionBlockRequestHeaderBlock>>("request_header");
        set => SetArgument("request_header", value);
    }

    /// <summary>
    /// RequestQueryParam block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlockExclusionBlockRequestQueryParamBlock>? RequestQueryParam
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlockExclusionBlockRequestQueryParamBlock>>("request_query_param");
        set => SetArgument("request_query_param", value);
    }

    /// <summary>
    /// RequestUri block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlockExclusionBlockRequestUriBlock>? RequestUri
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlockExclusionBlockRequestUriBlock>>("request_uri");
        set => SetArgument("request_uri", value);
    }

}

/// <summary>
/// Block type for request_cookie in GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlockExclusionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlockExclusionBlockRequestCookieBlock : TerraformBlock
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
/// Block type for request_header in GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlockExclusionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlockExclusionBlockRequestHeaderBlock : TerraformBlock
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
/// Block type for request_query_param in GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlockExclusionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlockExclusionBlockRequestQueryParamBlock : TerraformBlock
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
/// Block type for request_uri in GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlockExclusionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulesBlockPreconfiguredWafConfigBlockExclusionBlockRequestUriBlock : TerraformBlock
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
/// Block type for rate_limit_options in GoogleComputeRegionSecurityPolicyRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulesBlockRateLimitOptionsBlock : TerraformBlock
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
    public TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockRateLimitOptionsBlockBanThresholdBlock>? BanThreshold
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockRateLimitOptionsBlockBanThresholdBlock>>("ban_threshold");
        set => SetArgument("ban_threshold", value);
    }

    /// <summary>
    /// EnforceOnKeyConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockRateLimitOptionsBlockEnforceOnKeyConfigsBlock>? EnforceOnKeyConfigs
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockRateLimitOptionsBlockEnforceOnKeyConfigsBlock>>("enforce_on_key_configs");
        set => SetArgument("enforce_on_key_configs", value);
    }

    /// <summary>
    /// RateLimitThreshold block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RateLimitThreshold block(s) allowed")]
    public TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockRateLimitOptionsBlockRateLimitThresholdBlock>? RateLimitThreshold
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulesBlockRateLimitOptionsBlockRateLimitThresholdBlock>>("rate_limit_threshold");
        set => SetArgument("rate_limit_threshold", value);
    }

}

/// <summary>
/// Block type for ban_threshold in GoogleComputeRegionSecurityPolicyRulesBlockRateLimitOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulesBlockRateLimitOptionsBlockBanThresholdBlock : TerraformBlock
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
/// Block type for enforce_on_key_configs in GoogleComputeRegionSecurityPolicyRulesBlockRateLimitOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulesBlockRateLimitOptionsBlockEnforceOnKeyConfigsBlock : TerraformBlock
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
/// Block type for rate_limit_threshold in GoogleComputeRegionSecurityPolicyRulesBlockRateLimitOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulesBlockRateLimitOptionsBlockRateLimitThresholdBlock : TerraformBlock
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
/// Block type for timeouts in GoogleComputeRegionSecurityPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionSecurityPolicyTimeoutsBlock : TerraformBlock
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
/// Block type for user_defined_fields in GoogleComputeRegionSecurityPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyUserDefinedFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_defined_fields";

    /// <summary>
    /// The base relative to which &#39;offset&#39; is measured. Possible values are:
    /// - IPV4: Points to the beginning of the IPv4 header.
    /// - IPV6: Points to the beginning of the IPv6 header.
    /// - TCP: Points to the beginning of the TCP header, skipping over any IPv4 options or IPv6 extension headers. Not present for non-first fragments.
    /// - UDP: Points to the beginning of the UDP header, skipping over any IPv4 options or IPv6 extension headers. Not present for non-first fragments. Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;, &amp;quot;TCP&amp;quot;, &amp;quot;UDP&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseAttribute is required")]
    public required TerraformValue<string> BaseAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("base");
        set => SetArgument("base", value);
    }

    /// <summary>
    /// If specified, apply this mask (bitwise AND) to the field to ignore bits before matching.
    /// Encoded as a hexadecimal number (starting with &amp;quot;0x&amp;quot;).
    /// The last byte of the field (in network byte order) corresponds to the least significant byte of the mask.
    /// </summary>
    public TerraformValue<string>? Mask
    {
        get => GetArgument<TerraformValue<string>>("mask");
        set => SetArgument("mask", value);
    }

    /// <summary>
    /// The name of this field. Must be unique within the policy.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Offset of the first byte of the field (in network byte order) relative to &#39;base&#39;.
    /// </summary>
    public TerraformValue<double>? Offset
    {
        get => GetArgument<TerraformValue<double>>("offset");
        set => SetArgument("offset", value);
    }

    /// <summary>
    /// Size of the field in bytes. Valid values: 1-4.
    /// </summary>
    public TerraformValue<double>? Size
    {
        get => GetArgument<TerraformValue<double>>("size");
        set => SetArgument("size", value);
    }

}


/// <summary>
/// Represents a google_compute_region_security_policy Terraform resource.
/// Manages a google_compute_region_security_policy resource.
/// </summary>
public partial class GoogleComputeRegionSecurityPolicy(string name) : TerraformResource("google_compute_region_security_policy", name)
{
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
    /// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035.
    /// Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])? which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The Region in which the created Region Security Policy should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The type indicates the intended use of the security policy.
    /// - CLOUD_ARMOR: Cloud Armor backend security policies can be configured to filter incoming HTTP requests targeting backend services. They filter requests before they hit the origin servers.
    /// - CLOUD_ARMOR_EDGE: Cloud Armor edge security policies can be configured to filter incoming HTTP requests targeting backend services (including Cloud CDN-enabled) as well as backend buckets (Cloud Storage). They filter requests before the request is served from Google&#39;s cache.
    /// - CLOUD_ARMOR_NETWORK: Cloud Armor network policies can be configured to filter packets targeting network load balancing resources such as backend services, target pools, target instances, and instances with external IPs. They filter requests before the request is served from the application.
    /// This field can be set only at resource creation time. Possible values: [&amp;quot;CLOUD_ARMOR&amp;quot;, &amp;quot;CLOUD_ARMOR_EDGE&amp;quot;, &amp;quot;CLOUD_ARMOR_NETWORK&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Fingerprint of this resource. This field is used internally during
    /// updates of this resource.
    /// </summary>
    public TerraformValue<string> Fingerprint
        => CreateReference("fingerprint");

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformValue<string> PolicyId
        => CreateReference("policy_id");

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    public TerraformValue<string> SelfLink
        => CreateReference("self_link");

    /// <summary>
    /// Server-defined URL for this resource with the resource id.
    /// </summary>
    public TerraformValue<string> SelfLinkWithPolicyId
        => CreateReference("self_link_with_policy_id");

    /// <summary>
    /// AdvancedOptionsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedOptionsConfig block(s) allowed")]
    public TerraformList<GoogleComputeRegionSecurityPolicyAdvancedOptionsConfigBlock>? AdvancedOptionsConfig
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyAdvancedOptionsConfigBlock>>("advanced_options_config");
        set => SetArgument("advanced_options_config", value);
    }

    /// <summary>
    /// DdosProtectionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DdosProtectionConfig block(s) allowed")]
    public TerraformList<GoogleComputeRegionSecurityPolicyDdosProtectionConfigBlock>? DdosProtectionConfig
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyDdosProtectionConfigBlock>>("ddos_protection_config");
        set => SetArgument("ddos_protection_config", value);
    }

    /// <summary>
    /// Rules block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionSecurityPolicyRulesBlock>? Rules
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeRegionSecurityPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeRegionSecurityPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UserDefinedFields block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionSecurityPolicyUserDefinedFieldsBlock>? UserDefinedFields
    {
        get => GetArgument<TerraformList<GoogleComputeRegionSecurityPolicyUserDefinedFieldsBlock>>("user_defined_fields");
        set => SetArgument("user_defined_fields", value);
    }

}
