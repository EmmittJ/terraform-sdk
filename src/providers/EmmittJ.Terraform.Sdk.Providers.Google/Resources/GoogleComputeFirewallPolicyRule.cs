using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for match in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeFirewallPolicyRuleMatchBlock : ITerraformBlock
{
    /// <summary>
    /// Address groups which should be matched against the traffic destination. Maximum number of destination address groups is 10.
    /// </summary>
    [TerraformPropertyName("dest_address_groups")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DestAddressGroups { get; set; }

    /// <summary>
    /// Fully Qualified Domain Name (FQDN) which should be matched against traffic destination. Maximum number of destination fqdn allowed is 100.
    /// </summary>
    [TerraformPropertyName("dest_fqdns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DestFqdns { get; set; }

    /// <summary>
    /// CIDR IP address range. Maximum number of destination CIDR IP ranges allowed is 5000.
    /// </summary>
    [TerraformPropertyName("dest_ip_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DestIpRanges { get; set; }

    /// <summary>
    /// Region codes whose IP addresses will be used to match for destination of traffic. Should be specified as 2 letter country code defined as per ISO 3166 alpha-2 country codes. ex.&amp;quot;US&amp;quot; Maximum number of dest region codes allowed is 5000.
    /// </summary>
    [TerraformPropertyName("dest_region_codes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DestRegionCodes { get; set; }

    /// <summary>
    /// Names of Network Threat Intelligence lists. The IPs in these lists will be matched against traffic destination.
    /// </summary>
    [TerraformPropertyName("dest_threat_intelligences")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DestThreatIntelligences { get; set; }

    /// <summary>
    /// Address groups which should be matched against the traffic source. Maximum number of source address groups is 10.
    /// </summary>
    [TerraformPropertyName("src_address_groups")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SrcAddressGroups { get; set; }

    /// <summary>
    /// Fully Qualified Domain Name (FQDN) which should be matched against traffic source. Maximum number of source fqdn allowed is 100.
    /// </summary>
    [TerraformPropertyName("src_fqdns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SrcFqdns { get; set; }

    /// <summary>
    /// CIDR IP address range. Maximum number of source CIDR IP ranges allowed is 5000.
    /// </summary>
    [TerraformPropertyName("src_ip_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SrcIpRanges { get; set; }

    /// <summary>
    /// Region codes whose IP addresses will be used to match for source of traffic. Should be specified as 2 letter country code defined as per ISO 3166 alpha-2 country codes. ex.&amp;quot;US&amp;quot; Maximum number of source region codes allowed is 5000.
    /// </summary>
    [TerraformPropertyName("src_region_codes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SrcRegionCodes { get; set; }

    /// <summary>
    /// Names of Network Threat Intelligence lists. The IPs in these lists will be matched against traffic source.
    /// </summary>
    [TerraformPropertyName("src_threat_intelligences")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SrcThreatIntelligences { get; set; }

}

/// <summary>
/// Block type for target_secure_tags in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeFirewallPolicyRuleTargetSecureTagsBlock : ITerraformBlock
{
    /// <summary>
    /// Name of the secure tag, created with TagManager&#39;s TagValue API.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// State of the secure tag, either EFFECTIVE or INEFFECTIVE. A secure tag is INEFFECTIVE when it is deleted or its network is deleted.
    /// </summary>
    [TerraformPropertyName("state")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>("", "state");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeFirewallPolicyRuleTimeoutsBlock : ITerraformBlock
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
/// Manages a google_compute_firewall_policy_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeFirewallPolicyRule : TerraformResource
{
    public GoogleComputeFirewallPolicyRule(string name) : base("google_compute_firewall_policy_rule", name)
    {
    }

    /// <summary>
    /// The Action to perform when the client connection triggers the rule. Valid actions are &amp;quot;allow&amp;quot;, &amp;quot;deny&amp;quot;, &amp;quot;goto_next&amp;quot; and &amp;quot;apply_security_profile_group&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformPropertyName("action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Action { get; set; }

    /// <summary>
    /// An optional description for this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The direction in which this rule applies. Possible values: [&amp;quot;INGRESS&amp;quot;, &amp;quot;EGRESS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Direction is required")]
    [TerraformPropertyName("direction")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Direction { get; set; }

    /// <summary>
    /// Denotes whether the firewall policy rule is disabled.
    /// When set to true, the firewall policy rule is not enforced and traffic behaves as if it did not exist.
    /// If this is unspecified, the firewall policy rule will be enabled.
    /// </summary>
    [TerraformPropertyName("disabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Disabled { get; set; }

    /// <summary>
    /// Denotes whether to enable logging for a particular rule.
    /// If logging is enabled, logs will be exported to the configured export destination in Stackdriver.
    /// Logs may be exported to BigQuery or Pub/Sub.
    /// Note: you cannot enable logging on &amp;quot;goto_next&amp;quot; rules.
    /// </summary>
    [TerraformPropertyName("enable_logging")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableLogging { get; set; }

    /// <summary>
    /// The firewall policy of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallPolicy is required")]
    [TerraformPropertyName("firewall_policy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FirewallPolicy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// An integer indicating the priority of a rule in the list.
    /// The priority must be a positive value between 0 and 2147483647.
    /// Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest prority.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformPropertyName("priority")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Priority { get; set; }

    /// <summary>
    /// A fully-qualified URL of a SecurityProfile resource instance.
    /// Example: https://networksecurity.googleapis.com/v1/projects/{project}/locations/{location}/securityProfileGroups/my-security-profile-group
    /// Must be specified if action = &#39;apply_security_profile_group&#39; and cannot be specified for other actions.
    /// </summary>
    [TerraformPropertyName("security_profile_group")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecurityProfileGroup { get; set; }

    /// <summary>
    /// A list of network resource URLs to which this rule applies.
    /// This field allows you to control which network&#39;s VMs get this rule.
    /// If this field is left blank, all VMs within the organization will receive the rule.
    /// </summary>
    [TerraformPropertyName("target_resources")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? TargetResources { get; set; }

    /// <summary>
    /// A list of service accounts indicating the sets of instances that are applied with this rule.
    /// </summary>
    [TerraformPropertyName("target_service_accounts")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? TargetServiceAccounts { get; set; }

    /// <summary>
    /// Boolean flag indicating if the traffic should be TLS decrypted.
    /// Can be set only if action = &#39;apply_security_profile_group&#39; and cannot be set for other actions.
    /// </summary>
    [TerraformPropertyName("tls_inspect")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TlsInspect { get; set; }

    /// <summary>
    /// Block for match.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Match is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Match block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    [TerraformPropertyName("match")]
    public TerraformList<TerraformBlock<GoogleComputeFirewallPolicyRuleMatchBlock>>? Match { get; set; } = new();

    /// <summary>
    /// Block for target_secure_tags.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("target_secure_tags")]
    public TerraformList<TerraformBlock<GoogleComputeFirewallPolicyRuleTargetSecureTagsBlock>>? TargetSecureTags { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeFirewallPolicyRuleTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// Type of the resource. Always &#39;compute#firewallPolicyRule&#39; for firewall policy rules
    /// </summary>
    [TerraformPropertyName("kind")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Kind => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kind");

    /// <summary>
    /// Calculation of the complexity of a single firewall policy rule.
    /// </summary>
    [TerraformPropertyName("rule_tuple_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> RuleTupleCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "rule_tuple_count");

}
