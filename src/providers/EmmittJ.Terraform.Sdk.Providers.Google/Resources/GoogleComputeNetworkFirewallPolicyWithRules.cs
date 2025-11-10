using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for rule in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeNetworkFirewallPolicyWithRulesRuleBlock : ITerraformBlock
{
    /// <summary>
    /// The Action to perform when the client connection triggers the rule. Can currently be either
    /// &amp;quot;allow&amp;quot;, &amp;quot;deny&amp;quot;, &amp;quot;apply_security_profile_group&amp;quot; or &amp;quot;goto_next&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformPropertyName("action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Action { get; set; }

    /// <summary>
    /// A description of the rule.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The direction in which this rule applies. If unspecified an INGRESS rule is created. Possible values: [&amp;quot;INGRESS&amp;quot;, &amp;quot;EGRESS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("direction")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Direction { get; set; }

    /// <summary>
    /// Denotes whether the firewall policy rule is disabled. When set to true,
    /// the firewall policy rule is not enforced and traffic behaves as if it did
    /// not exist. If this is unspecified, the firewall policy rule will be
    /// enabled.
    /// </summary>
    [TerraformPropertyName("disabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Disabled { get; set; }

    /// <summary>
    /// Denotes whether to enable logging for a particular rule.
    /// If logging is enabled, logs will be exported to the
    /// configured export destination in Stackdriver.
    /// </summary>
    [TerraformPropertyName("enable_logging")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableLogging { get; set; }

    /// <summary>
    /// An integer indicating the priority of a rule in the list. The priority must be a value
    /// between 0 and 2147483647. Rules are evaluated from highest to lowest priority where 0 is the
    /// highest priority and 2147483647 is the lowest priority.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformPropertyName("priority")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Priority { get; set; }

    /// <summary>
    /// An optional name for the rule. This field is not a unique identifier
    /// and can be updated.
    /// </summary>
    [TerraformPropertyName("rule_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RuleName { get; set; }

    /// <summary>
    /// A fully-qualified URL of a SecurityProfile resource instance.
    /// Example:
    /// https://networksecurity.googleapis.com/v1/projects/{project}/locations/{location}/securityProfileGroups/my-security-profile-group
    /// Must be specified if action is &#39;apply_security_profile_group&#39;.
    /// </summary>
    [TerraformPropertyName("security_profile_group")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecurityProfileGroup { get; set; }

    /// <summary>
    /// A list of service accounts indicating the sets of
    /// instances that are applied with this rule.
    /// </summary>
    [TerraformPropertyName("target_service_accounts")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? TargetServiceAccounts { get; set; }

    /// <summary>
    /// Boolean flag indicating if the traffic should be TLS decrypted.
    /// It can be set only if action = &#39;apply_security_profile_group&#39; and cannot be set for other actions.
    /// </summary>
    [TerraformPropertyName("tls_inspect")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TlsInspect { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeNetworkFirewallPolicyWithRulesTimeoutsBlock : ITerraformBlock
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
/// Manages a google_compute_network_firewall_policy_with_rules resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeNetworkFirewallPolicyWithRules : TerraformResource
{
    public GoogleComputeNetworkFirewallPolicyWithRules(string name) : base("google_compute_network_firewall_policy_with_rules", name)
    {
    }

    /// <summary>
    /// An optional description of this resource.
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
    /// User-provided name of the Network firewall policy.
    /// The name should be unique in the project in which the firewall policy is created.
    /// The name must be 1-63 characters long, and comply with RFC1035. Specifically,
    /// the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])?
    /// which means the first character must be a lowercase letter, and all following characters must be a dash,
    /// lowercase letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Policy type is used to determine which resources (networks) the policy can be associated with.
    /// A policy can be associated with a network only if the network has the matching policyType in its network profile.
    /// Different policy types may support some of the Firewall Rules features. Possible values: [&amp;quot;VPC_POLICY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("policy_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PolicyType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "policy_type");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    [TerraformPropertyName("rule")]
    public TerraformList<TerraformBlock<GoogleComputeNetworkFirewallPolicyWithRulesRuleBlock>>? Rule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeNetworkFirewallPolicyWithRulesTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// Fingerprint of the resource. This field is used internally during updates of this resource.
    /// </summary>
    [TerraformPropertyName("fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fingerprint");

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformPropertyName("network_firewall_policy_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkFirewallPolicyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_firewall_policy_id");

    /// <summary>
    /// A list of firewall policy pre-defined rules.
    /// </summary>
    [TerraformPropertyName("predefined_rules")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PredefinedRules => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "predefined_rules");

    /// <summary>
    /// Total count of all firewall policy rule tuples. A firewall policy can not exceed a set number of tuples.
    /// </summary>
    [TerraformPropertyName("rule_tuple_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> RuleTupleCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "rule_tuple_count");

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// Server-defined URL for this resource with the resource id.
    /// </summary>
    [TerraformPropertyName("self_link_with_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLinkWithId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link_with_id");

}
