using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for match in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRuleMatchBlock : ITerraformBlock
{
    /// <summary>
    /// Preconfigured versioned expression. If this field is specified, config must also be specified.
    /// Available preconfigured expressions along with their requirements are: SRC_IPS_V1 - must specify the corresponding srcIpRange field in config. Possible values: [&amp;quot;SRC_IPS_V1&amp;quot;]
    /// </summary>
    [TerraformPropertyName("versioned_expr")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VersionedExpr { get; set; }

}

/// <summary>
/// Block type for network_match in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRuleNetworkMatchBlock : ITerraformBlock
{
    /// <summary>
    /// Destination IPv4/IPv6 addresses or CIDR prefixes, in standard text format.
    /// </summary>
    [TerraformPropertyName("dest_ip_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DestIpRanges { get; set; }

    /// <summary>
    /// Destination port numbers for TCP/UDP/SCTP. Each element can be a 16-bit unsigned decimal number (e.g. &amp;quot;80&amp;quot;) or range (e.g. &amp;quot;0-1023&amp;quot;).
    /// </summary>
    [TerraformPropertyName("dest_ports")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DestPorts { get; set; }

    /// <summary>
    /// IPv4 protocol / IPv6 next header (after extension headers). Each element can be an 8-bit unsigned decimal number (e.g. &amp;quot;6&amp;quot;), range (e.g. &amp;quot;253-254&amp;quot;), or one of the following protocol names: &amp;quot;tcp&amp;quot;, &amp;quot;udp&amp;quot;, &amp;quot;icmp&amp;quot;, &amp;quot;esp&amp;quot;, &amp;quot;ah&amp;quot;, &amp;quot;ipip&amp;quot;, or &amp;quot;sctp&amp;quot;.
    /// </summary>
    [TerraformPropertyName("ip_protocols")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? IpProtocols { get; set; }

    /// <summary>
    /// BGP Autonomous System Number associated with the source IP address.
    /// </summary>
    [TerraformPropertyName("src_asns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<double>>>? SrcAsns { get; set; }

    /// <summary>
    /// Source IPv4/IPv6 addresses or CIDR prefixes, in standard text format.
    /// </summary>
    [TerraformPropertyName("src_ip_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SrcIpRanges { get; set; }

    /// <summary>
    /// Source port numbers for TCP/UDP/SCTP. Each element can be a 16-bit unsigned decimal number (e.g. &amp;quot;80&amp;quot;) or range (e.g. &amp;quot;0-1023&amp;quot;).
    /// </summary>
    [TerraformPropertyName("src_ports")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SrcPorts { get; set; }

    /// <summary>
    /// Two-letter ISO 3166-1 alpha-2 country code associated with the source IP address.
    /// </summary>
    [TerraformPropertyName("src_region_codes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SrcRegionCodes { get; set; }

}

/// <summary>
/// Block type for preconfigured_waf_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for rate_limit_options in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRuleRateLimitOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// Can only be specified if the action for the rule is &amp;quot;rate_based_ban&amp;quot;.
    /// If specified, determines the time (in seconds) the traffic will continue to be banned by the rate limit after the rate falls below the threshold.
    /// </summary>
    [TerraformPropertyName("ban_duration_sec")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BanDurationSec { get; set; }

    /// <summary>
    /// Action to take for requests that are under the configured rate limit threshold.
    /// Valid option is &amp;quot;allow&amp;quot; only.
    /// </summary>
    [TerraformPropertyName("conform_action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConformAction { get; set; }

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
    [TerraformPropertyName("enforce_on_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EnforceOnKey { get; set; }

    /// <summary>
    /// Rate limit key name applicable only for the following key types:
    /// HTTP_HEADER -- Name of the HTTP header whose value is taken as the key value.
    /// HTTP_COOKIE -- Name of the HTTP cookie whose value is taken as the key value.
    /// </summary>
    [TerraformPropertyName("enforce_on_key_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EnforceOnKeyName { get; set; }

    /// <summary>
    /// Action to take for requests that are above the configured rate limit threshold, to deny with a specified HTTP response code.
    /// Valid options are deny(STATUS), where valid values for STATUS are 403, 404, 429, and 502.
    /// </summary>
    [TerraformPropertyName("exceed_action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExceedAction { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionSecurityPolicyRuleTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_region_security_policy_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeRegionSecurityPolicyRule : TerraformResource
{
    public GoogleComputeRegionSecurityPolicyRule(string name) : base("google_compute_region_security_policy_rule", name)
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
    [TerraformPropertyName("action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Action { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// If set to true, the specified action is not enforced.
    /// </summary>
    [TerraformPropertyName("preview")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Preview { get; set; }

    /// <summary>
    /// An integer indicating the priority of a rule in the list.
    /// The priority must be a positive value between 0 and 2147483647.
    /// Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest priority.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformPropertyName("priority")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Priority { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The Region in which the created Region Security Policy rule should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    [TerraformPropertyName("region")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Region { get; set; }

    /// <summary>
    /// The name of the security policy this rule belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityPolicy is required")]
    [TerraformPropertyName("security_policy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SecurityPolicy { get; set; }

    /// <summary>
    /// Block for match.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    [TerraformPropertyName("match")]
    public TerraformList<TerraformBlock<GoogleComputeRegionSecurityPolicyRuleMatchBlock>>? Match { get; set; } = new();

    /// <summary>
    /// Block for network_match.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkMatch block(s) allowed")]
    [TerraformPropertyName("network_match")]
    public TerraformList<TerraformBlock<GoogleComputeRegionSecurityPolicyRuleNetworkMatchBlock>>? NetworkMatch { get; set; } = new();

    /// <summary>
    /// Block for preconfigured_waf_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreconfiguredWafConfig block(s) allowed")]
    [TerraformPropertyName("preconfigured_waf_config")]
    public TerraformList<TerraformBlock<GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlock>>? PreconfiguredWafConfig { get; set; } = new();

    /// <summary>
    /// Block for rate_limit_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RateLimitOptions block(s) allowed")]
    [TerraformPropertyName("rate_limit_options")]
    public TerraformList<TerraformBlock<GoogleComputeRegionSecurityPolicyRuleRateLimitOptionsBlock>>? RateLimitOptions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeRegionSecurityPolicyRuleTimeoutsBlock>? Timeouts { get; set; } = new();

}
