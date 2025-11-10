using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_options_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyAdvancedOptionsConfigBlock : ITerraformBlock
{
    /// <summary>
    /// JSON body parsing. Supported values include: &amp;quot;DISABLED&amp;quot;, &amp;quot;STANDARD&amp;quot;, &amp;quot;STANDARD_WITH_GRAPHQL&amp;quot;. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;STANDARD&amp;quot;, &amp;quot;STANDARD_WITH_GRAPHQL&amp;quot;]
    /// </summary>
    [TerraformPropertyName("json_parsing")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? JsonParsing { get; set; }

    /// <summary>
    /// Logging level. Supported values include: &amp;quot;NORMAL&amp;quot;, &amp;quot;VERBOSE&amp;quot;. Possible values: [&amp;quot;NORMAL&amp;quot;, &amp;quot;VERBOSE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("log_level")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LogLevel { get; set; }

    /// <summary>
    /// An optional list of case-insensitive request header names to use for resolving the callers client IP address.
    /// </summary>
    [TerraformPropertyName("user_ip_request_headers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? UserIpRequestHeaders { get; set; }

}

/// <summary>
/// Block type for ddos_protection_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyDdosProtectionConfigBlock : ITerraformBlock
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
    public required TerraformProperty<TerraformProperty<string>> DdosProtection { get; set; }

}

/// <summary>
/// Block type for rules in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulesBlock : ITerraformBlock
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
    public required TerraformProperty<TerraformProperty<string>> Action { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

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

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionSecurityPolicyTimeoutsBlock : ITerraformBlock
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
/// Block type for user_defined_fields in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyUserDefinedFieldsBlock : ITerraformBlock
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
    public required TerraformProperty<TerraformProperty<string>> Base { get; set; }

    /// <summary>
    /// If specified, apply this mask (bitwise AND) to the field to ignore bits before matching.
    /// Encoded as a hexadecimal number (starting with &amp;quot;0x&amp;quot;).
    /// The last byte of the field (in network byte order) corresponds to the least significant byte of the mask.
    /// </summary>
    [TerraformPropertyName("mask")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Mask { get; set; }

    /// <summary>
    /// The name of this field. Must be unique within the policy.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// Offset of the first byte of the field (in network byte order) relative to &#39;base&#39;.
    /// </summary>
    [TerraformPropertyName("offset")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Offset { get; set; }

    /// <summary>
    /// Size of the field in bytes. Valid values: 1-4.
    /// </summary>
    [TerraformPropertyName("size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Size { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035.
    /// Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])? which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The Region in which the created Region Security Policy should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The type indicates the intended use of the security policy.
    /// - CLOUD_ARMOR: Cloud Armor backend security policies can be configured to filter incoming HTTP requests targeting backend services. They filter requests before they hit the origin servers.
    /// - CLOUD_ARMOR_EDGE: Cloud Armor edge security policies can be configured to filter incoming HTTP requests targeting backend services (including Cloud CDN-enabled) as well as backend buckets (Cloud Storage). They filter requests before the request is served from Google&#39;s cache.
    /// - CLOUD_ARMOR_NETWORK: Cloud Armor network policies can be configured to filter packets targeting network load balancing resources such as backend services, target pools, target instances, and instances with external IPs. They filter requests before the request is served from the application.
    /// This field can be set only at resource creation time. Possible values: [&amp;quot;CLOUD_ARMOR&amp;quot;, &amp;quot;CLOUD_ARMOR_EDGE&amp;quot;, &amp;quot;CLOUD_ARMOR_NETWORK&amp;quot;]
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

    /// <summary>
    /// Block for advanced_options_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedOptionsConfig block(s) allowed")]
    [TerraformPropertyName("advanced_options_config")]
    public TerraformList<TerraformBlock<GoogleComputeRegionSecurityPolicyAdvancedOptionsConfigBlock>>? AdvancedOptionsConfig { get; set; } = new();

    /// <summary>
    /// Block for ddos_protection_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DdosProtectionConfig block(s) allowed")]
    [TerraformPropertyName("ddos_protection_config")]
    public TerraformList<TerraformBlock<GoogleComputeRegionSecurityPolicyDdosProtectionConfigBlock>>? DdosProtectionConfig { get; set; } = new();

    /// <summary>
    /// Block for rules.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("rules")]
    public TerraformList<TerraformBlock<GoogleComputeRegionSecurityPolicyRulesBlock>>? Rules { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeRegionSecurityPolicyTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for user_defined_fields.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("user_defined_fields")]
    public TerraformList<TerraformBlock<GoogleComputeRegionSecurityPolicyUserDefinedFieldsBlock>>? UserDefinedFields { get; set; } = new();

    /// <summary>
    /// Fingerprint of this resource. This field is used internally during
    /// updates of this resource.
    /// </summary>
    [TerraformPropertyName("fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fingerprint");

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformPropertyName("policy_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PolicyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "policy_id");

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// Server-defined URL for this resource with the resource id.
    /// </summary>
    [TerraformPropertyName("self_link_with_policy_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLinkWithPolicyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link_with_policy_id");

}
