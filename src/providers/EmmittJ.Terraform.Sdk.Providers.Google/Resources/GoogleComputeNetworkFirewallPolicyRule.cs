using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for match in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeNetworkFirewallPolicyRuleMatchBlock() : TerraformBlock("match")
{
    /// <summary>
    /// Address groups which should be matched against the traffic destination. Maximum number of destination address groups is 10.
    /// </summary>
    [TerraformProperty("dest_address_groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? DestAddressGroups { get; set; }

    /// <summary>
    /// Fully Qualified Domain Name (FQDN) which should be matched against traffic destination. Maximum number of destination fqdn allowed is 100.
    /// </summary>
    [TerraformProperty("dest_fqdns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? DestFqdns { get; set; }

    /// <summary>
    /// CIDR IP address range. Maximum number of destination CIDR IP ranges allowed is 5000.
    /// </summary>
    [TerraformProperty("dest_ip_ranges")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? DestIpRanges { get; set; }

    /// <summary>
    /// Region codes whose IP addresses will be used to match for destination of traffic. Should be specified as 2 letter country code defined as per ISO 3166 alpha-2 country codes. ex.&amp;quot;US&amp;quot; Maximum number of dest region codes allowed is 5000.
    /// </summary>
    [TerraformProperty("dest_region_codes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? DestRegionCodes { get; set; }

    /// <summary>
    /// Names of Network Threat Intelligence lists. The IPs in these lists will be matched against traffic destination.
    /// </summary>
    [TerraformProperty("dest_threat_intelligences")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? DestThreatIntelligences { get; set; }

    /// <summary>
    /// Address groups which should be matched against the traffic source. Maximum number of source address groups is 10.
    /// </summary>
    [TerraformProperty("src_address_groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SrcAddressGroups { get; set; }

    /// <summary>
    /// Fully Qualified Domain Name (FQDN) which should be matched against traffic source. Maximum number of source fqdn allowed is 100.
    /// </summary>
    [TerraformProperty("src_fqdns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SrcFqdns { get; set; }

    /// <summary>
    /// CIDR IP address range. Maximum number of source CIDR IP ranges allowed is 5000.
    /// </summary>
    [TerraformProperty("src_ip_ranges")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SrcIpRanges { get; set; }

    /// <summary>
    /// Region codes whose IP addresses will be used to match for source of traffic. Should be specified as 2 letter country code defined as per ISO 3166 alpha-2 country codes. ex.&amp;quot;US&amp;quot; Maximum number of source region codes allowed is 5000.
    /// </summary>
    [TerraformProperty("src_region_codes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SrcRegionCodes { get; set; }

    /// <summary>
    /// Names of Network Threat Intelligence lists. The IPs in these lists will be matched against traffic source.
    /// </summary>
    [TerraformProperty("src_threat_intelligences")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SrcThreatIntelligences { get; set; }

}

/// <summary>
/// Block type for target_secure_tags in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeNetworkFirewallPolicyRuleTargetSecureTagsBlock() : TerraformBlock("target_secure_tags")
{
    /// <summary>
    /// Name of the secure tag, created with TagManager&#39;s TagValue API.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeNetworkFirewallPolicyRuleTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_network_firewall_policy_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeNetworkFirewallPolicyRule : TerraformResource
{
    public GoogleComputeNetworkFirewallPolicyRule(string name) : base("google_compute_network_firewall_policy_rule", name)
    {
    }

    /// <summary>
    /// The Action to perform when the client connection triggers the rule. Valid actions are &amp;quot;allow&amp;quot;, &amp;quot;deny&amp;quot;, &amp;quot;goto_next&amp;quot; and &amp;quot;apply_security_profile_group&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Action { get; set; }

    /// <summary>
    /// An optional description for this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The direction in which this rule applies. Possible values: [&amp;quot;INGRESS&amp;quot;, &amp;quot;EGRESS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Direction is required")]
    [TerraformProperty("direction")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Direction { get; set; }

    /// <summary>
    /// Denotes whether the firewall policy rule is disabled.
    /// When set to true, the firewall policy rule is not enforced and traffic behaves as if it did not exist.
    /// If this is unspecified, the firewall policy rule will be enabled.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// Denotes whether to enable logging for a particular rule.
    /// If logging is enabled, logs will be exported to the configured export destination in Stackdriver.
    /// Logs may be exported to BigQuery or Pub/Sub.
    /// Note: you cannot enable logging on &amp;quot;goto_next&amp;quot; rules.
    /// </summary>
    [TerraformProperty("enable_logging")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableLogging { get; set; }

    /// <summary>
    /// The firewall policy of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallPolicy is required")]
    [TerraformProperty("firewall_policy")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FirewallPolicy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// An integer indicating the priority of a rule in the list.
    /// The priority must be a positive value between 0 and 2147483647.
    /// Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest prority.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// An optional name for the rule. This field is not a unique identifier and can be updated.
    /// </summary>
    [TerraformProperty("rule_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RuleName { get; set; }

    /// <summary>
    /// A fully-qualified URL of a SecurityProfile resource instance.
    /// Example: https://networksecurity.googleapis.com/v1/projects/{project}/locations/{location}/securityProfileGroups/my-security-profile-group
    /// Must be specified if action = &#39;apply_security_profile_group&#39; and cannot be specified for other actions.
    /// </summary>
    [TerraformProperty("security_profile_group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecurityProfileGroup { get; set; }

    /// <summary>
    /// A list of service accounts indicating the sets of instances that are applied with this rule.
    /// </summary>
    [TerraformProperty("target_service_accounts")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? TargetServiceAccounts { get; set; }

    /// <summary>
    /// Boolean flag indicating if the traffic should be TLS decrypted.
    /// Can be set only if action = &#39;apply_security_profile_group&#39; and cannot be set for other actions.
    /// </summary>
    [TerraformProperty("tls_inspect")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TlsInspect { get; set; }

    /// <summary>
    /// Block for match.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Match is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Match block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    [TerraformProperty("match")]
    public required TerraformList<GoogleComputeNetworkFirewallPolicyRuleMatchBlock> Match { get; set; } = new();

    /// <summary>
    /// Block for target_secure_tags.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("target_secure_tags")]
    public TerraformList<GoogleComputeNetworkFirewallPolicyRuleTargetSecureTagsBlock> TargetSecureTags { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleComputeNetworkFirewallPolicyRuleTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// Type of the resource. Always &#39;compute#firewallPolicyRule&#39; for firewall policy rules
    /// </summary>
    [TerraformProperty("kind")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Kind { get; }

    /// <summary>
    /// Calculation of the complexity of a single firewall policy rule.
    /// </summary>
    [TerraformProperty("rule_tuple_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> RuleTupleCount { get; }

}
