using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for match in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionSecurityPolicyRuleMatchBlock : TerraformBlockBase
{
    /// <summary>
    /// Preconfigured versioned expression. If this field is specified, config must also be specified.
    /// Available preconfigured expressions along with their requirements are: SRC_IPS_V1 - must specify the corresponding srcIpRange field in config. Possible values: [&amp;quot;SRC_IPS_V1&amp;quot;]
    /// </summary>
    [TerraformProperty("versioned_expr")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VersionedExpr { get; set; }

}

/// <summary>
/// Block type for network_match in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionSecurityPolicyRuleNetworkMatchBlock : TerraformBlockBase
{
    /// <summary>
    /// Destination IPv4/IPv6 addresses or CIDR prefixes, in standard text format.
    /// </summary>
    [TerraformProperty("dest_ip_ranges")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? DestIpRanges { get; set; }

    /// <summary>
    /// Destination port numbers for TCP/UDP/SCTP. Each element can be a 16-bit unsigned decimal number (e.g. &amp;quot;80&amp;quot;) or range (e.g. &amp;quot;0-1023&amp;quot;).
    /// </summary>
    [TerraformProperty("dest_ports")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? DestPorts { get; set; }

    /// <summary>
    /// IPv4 protocol / IPv6 next header (after extension headers). Each element can be an 8-bit unsigned decimal number (e.g. &amp;quot;6&amp;quot;), range (e.g. &amp;quot;253-254&amp;quot;), or one of the following protocol names: &amp;quot;tcp&amp;quot;, &amp;quot;udp&amp;quot;, &amp;quot;icmp&amp;quot;, &amp;quot;esp&amp;quot;, &amp;quot;ah&amp;quot;, &amp;quot;ipip&amp;quot;, or &amp;quot;sctp&amp;quot;.
    /// </summary>
    [TerraformProperty("ip_protocols")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? IpProtocols { get; set; }

    /// <summary>
    /// BGP Autonomous System Number associated with the source IP address.
    /// </summary>
    [TerraformProperty("src_asns")]
    // Optional argument - source generator will implement get/set
    public TerraformList<double>? SrcAsns { get; set; }

    /// <summary>
    /// Source IPv4/IPv6 addresses or CIDR prefixes, in standard text format.
    /// </summary>
    [TerraformProperty("src_ip_ranges")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? SrcIpRanges { get; set; }

    /// <summary>
    /// Source port numbers for TCP/UDP/SCTP. Each element can be a 16-bit unsigned decimal number (e.g. &amp;quot;80&amp;quot;) or range (e.g. &amp;quot;0-1023&amp;quot;).
    /// </summary>
    [TerraformProperty("src_ports")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? SrcPorts { get; set; }

    /// <summary>
    /// Two-letter ISO 3166-1 alpha-2 country code associated with the source IP address.
    /// </summary>
    [TerraformProperty("src_region_codes")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? SrcRegionCodes { get; set; }

}

/// <summary>
/// Block type for preconfigured_waf_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for rate_limit_options in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionSecurityPolicyRuleRateLimitOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// Can only be specified if the action for the rule is &amp;quot;rate_based_ban&amp;quot;.
    /// If specified, determines the time (in seconds) the traffic will continue to be banned by the rate limit after the rate falls below the threshold.
    /// </summary>
    [TerraformProperty("ban_duration_sec")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? BanDurationSec { get; set; }

    /// <summary>
    /// Action to take for requests that are under the configured rate limit threshold.
    /// Valid option is &amp;quot;allow&amp;quot; only.
    /// </summary>
    [TerraformProperty("conform_action")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConformAction { get; set; }

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
    [TerraformProperty("enforce_on_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EnforceOnKey { get; set; }

    /// <summary>
    /// Rate limit key name applicable only for the following key types:
    /// HTTP_HEADER -- Name of the HTTP header whose value is taken as the key value.
    /// HTTP_COOKIE -- Name of the HTTP cookie whose value is taken as the key value.
    /// </summary>
    [TerraformProperty("enforce_on_key_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EnforceOnKeyName { get; set; }

    /// <summary>
    /// Action to take for requests that are above the configured rate limit threshold, to deny with a specified HTTP response code.
    /// Valid options are deny(STATUS), where valid values for STATUS are 403, 404, 429, and 502.
    /// </summary>
    [TerraformProperty("exceed_action")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExceedAction { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeRegionSecurityPolicyRuleTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_region_security_policy_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeRegionSecurityPolicyRule : TerraformResource
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
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Action { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// If set to true, the specified action is not enforced.
    /// </summary>
    [TerraformProperty("preview")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Preview { get; set; }

    /// <summary>
    /// An integer indicating the priority of a rule in the list.
    /// The priority must be a positive value between 0 and 2147483647.
    /// Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest priority.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The Region in which the created Region Security Policy rule should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    [TerraformProperty("region")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The name of the security policy this rule belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityPolicy is required")]
    [TerraformProperty("security_policy")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SecurityPolicy { get; set; }

    /// <summary>
    /// Block for match.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    [TerraformProperty("match")]
    public TerraformList<TerraformBlock<GoogleComputeRegionSecurityPolicyRuleMatchBlock>>? Match { get; set; }

    /// <summary>
    /// Block for network_match.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkMatch block(s) allowed")]
    [TerraformProperty("network_match")]
    public TerraformList<TerraformBlock<GoogleComputeRegionSecurityPolicyRuleNetworkMatchBlock>>? NetworkMatch { get; set; }

    /// <summary>
    /// Block for preconfigured_waf_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreconfiguredWafConfig block(s) allowed")]
    [TerraformProperty("preconfigured_waf_config")]
    public TerraformList<TerraformBlock<GoogleComputeRegionSecurityPolicyRulePreconfiguredWafConfigBlock>>? PreconfiguredWafConfig { get; set; }

    /// <summary>
    /// Block for rate_limit_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RateLimitOptions block(s) allowed")]
    [TerraformProperty("rate_limit_options")]
    public TerraformList<TerraformBlock<GoogleComputeRegionSecurityPolicyRuleRateLimitOptionsBlock>>? RateLimitOptions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleComputeRegionSecurityPolicyRuleTimeoutsBlock>? Timeouts { get; set; }

}
