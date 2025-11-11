using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_options_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyAdvancedOptionsConfigBlock
{
    /// <summary>
    /// JSON body parsing. Supported values include: &amp;quot;DISABLED&amp;quot;, &amp;quot;STANDARD&amp;quot;, &amp;quot;STANDARD_WITH_GRAPHQL&amp;quot;. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;STANDARD&amp;quot;, &amp;quot;STANDARD_WITH_GRAPHQL&amp;quot;]
    /// </summary>
    [TerraformPropertyName("json_parsing")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? JsonParsing { get; set; }

    /// <summary>
    /// Logging level. Supported values include: &amp;quot;NORMAL&amp;quot;, &amp;quot;VERBOSE&amp;quot;. Possible values: [&amp;quot;NORMAL&amp;quot;, &amp;quot;VERBOSE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("log_level")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LogLevel { get; set; }

    /// <summary>
    /// An optional list of case-insensitive request header names to use for resolving the callers client IP address.
    /// </summary>
    [TerraformPropertyName("user_ip_request_headers")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? UserIpRequestHeaders { get; set; }

}

/// <summary>
/// Block type for ddos_protection_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyDdosProtectionConfigBlock
{
    /// <summary>
    /// Google Cloud Armor offers the following options to help protect systems against DDoS attacks:
    /// - STANDARD: basic always-on protection for network load balancers, protocol forwarding, or VMs with public IP addresses.
    /// - ADVANCED: additional protections for Managed Protection Plus subscribers who use network load balancers, protocol forwarding, or VMs with public IP addresses.
    /// - ADVANCED_PREVIEW: flag to enable the security policy in preview mode. Possible values: [&amp;quot;ADVANCED&amp;quot;, &amp;quot;ADVANCED_PREVIEW&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DdosProtection is required")]
    [TerraformPropertyName("ddos_protection")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DdosProtection { get; set; }

}

/// <summary>
/// Block type for rules in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulesBlock
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
    [TerraformPropertyName("action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Action { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// If set to true, the specified action is not enforced.
    /// </summary>
    [TerraformPropertyName("preview")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Preview { get; set; }

    /// <summary>
    /// An integer indicating the priority of a rule in the list.
    /// The priority must be a positive value between 0 and 2147483647.
    /// Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest priority.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformPropertyName("priority")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Priority { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionSecurityPolicyTimeoutsBlock
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
/// Block type for user_defined_fields in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyUserDefinedFieldsBlock
{
    /// <summary>
    /// The base relative to which &#39;offset&#39; is measured. Possible values are:
    /// - IPV4: Points to the beginning of the IPv4 header.
    /// - IPV6: Points to the beginning of the IPv6 header.
    /// - TCP: Points to the beginning of the TCP header, skipping over any IPv4 options or IPv6 extension headers. Not present for non-first fragments.
    /// - UDP: Points to the beginning of the UDP header, skipping over any IPv4 options or IPv6 extension headers. Not present for non-first fragments. Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;, &amp;quot;TCP&amp;quot;, &amp;quot;UDP&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Base is required")]
    [TerraformPropertyName("base")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Base { get; set; }

    /// <summary>
    /// If specified, apply this mask (bitwise AND) to the field to ignore bits before matching.
    /// Encoded as a hexadecimal number (starting with &amp;quot;0x&amp;quot;).
    /// The last byte of the field (in network byte order) corresponds to the least significant byte of the mask.
    /// </summary>
    [TerraformPropertyName("mask")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Mask { get; set; }

    /// <summary>
    /// The name of this field. Must be unique within the policy.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Offset of the first byte of the field (in network byte order) relative to &#39;base&#39;.
    /// </summary>
    [TerraformPropertyName("offset")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Offset { get; set; }

    /// <summary>
    /// Size of the field in bytes. Valid values: 1-4.
    /// </summary>
    [TerraformPropertyName("size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Size { get; set; }

}

/// <summary>
/// Manages a google_compute_region_security_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeRegionSecurityPolicy : TerraformResource
{
    public GoogleComputeRegionSecurityPolicy(string name) : base("google_compute_region_security_policy", name)
    {
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035.
    /// Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])? which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The Region in which the created Region Security Policy should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The type indicates the intended use of the security policy.
    /// - CLOUD_ARMOR: Cloud Armor backend security policies can be configured to filter incoming HTTP requests targeting backend services. They filter requests before they hit the origin servers.
    /// - CLOUD_ARMOR_EDGE: Cloud Armor edge security policies can be configured to filter incoming HTTP requests targeting backend services (including Cloud CDN-enabled) as well as backend buckets (Cloud Storage). They filter requests before the request is served from Google&#39;s cache.
    /// - CLOUD_ARMOR_NETWORK: Cloud Armor network policies can be configured to filter packets targeting network load balancing resources such as backend services, target pools, target instances, and instances with external IPs. They filter requests before the request is served from the application.
    /// This field can be set only at resource creation time. Possible values: [&amp;quot;CLOUD_ARMOR&amp;quot;, &amp;quot;CLOUD_ARMOR_EDGE&amp;quot;, &amp;quot;CLOUD_ARMOR_NETWORK&amp;quot;]
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// Block for advanced_options_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedOptionsConfig block(s) allowed")]
    [TerraformPropertyName("advanced_options_config")]
    public TerraformList<TerraformBlock<GoogleComputeRegionSecurityPolicyAdvancedOptionsConfigBlock>>? AdvancedOptionsConfig { get; set; }

    /// <summary>
    /// Block for ddos_protection_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DdosProtectionConfig block(s) allowed")]
    [TerraformPropertyName("ddos_protection_config")]
    public TerraformList<TerraformBlock<GoogleComputeRegionSecurityPolicyDdosProtectionConfigBlock>>? DdosProtectionConfig { get; set; }

    /// <summary>
    /// Block for rules.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("rules")]
    public TerraformList<TerraformBlock<GoogleComputeRegionSecurityPolicyRulesBlock>>? Rules { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeRegionSecurityPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for user_defined_fields.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("user_defined_fields")]
    public TerraformList<TerraformBlock<GoogleComputeRegionSecurityPolicyUserDefinedFieldsBlock>>? UserDefinedFields { get; set; }

    /// <summary>
    /// Fingerprint of this resource. This field is used internally during
    /// updates of this resource.
    /// </summary>
    [TerraformPropertyName("fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Fingerprint => new TerraformReference(this, "fingerprint");

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformPropertyName("policy_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PolicyId => new TerraformReference(this, "policy_id");

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// Server-defined URL for this resource with the resource id.
    /// </summary>
    [TerraformPropertyName("self_link_with_policy_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLinkWithPolicyId => new TerraformReference(this, "self_link_with_policy_id");

}
