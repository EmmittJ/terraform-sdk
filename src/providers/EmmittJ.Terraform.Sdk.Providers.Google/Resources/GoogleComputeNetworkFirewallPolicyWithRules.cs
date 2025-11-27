using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for rule in GoogleComputeNetworkFirewallPolicyWithRules.
/// Nesting mode: list
/// </summary>
public class GoogleComputeNetworkFirewallPolicyWithRulesRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The Action to perform when the client connection triggers the rule. Can currently be either
    /// &amp;quot;allow&amp;quot;, &amp;quot;deny&amp;quot;, &amp;quot;apply_security_profile_group&amp;quot; or &amp;quot;goto_next&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// A description of the rule.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The direction in which this rule applies. If unspecified an INGRESS rule is created. Possible values: [&amp;quot;INGRESS&amp;quot;, &amp;quot;EGRESS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Direction
    {
        get => new TerraformReference<string>(this, "direction");
        set => SetArgument("direction", value);
    }

    /// <summary>
    /// Denotes whether the firewall policy rule is disabled. When set to true,
    /// the firewall policy rule is not enforced and traffic behaves as if it did
    /// not exist. If this is unspecified, the firewall policy rule will be
    /// enabled.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// Denotes whether to enable logging for a particular rule.
    /// If logging is enabled, logs will be exported to the
    /// configured export destination in Stackdriver.
    /// </summary>
    public TerraformValue<bool>? EnableLogging
    {
        get => new TerraformReference<bool>(this, "enable_logging");
        set => SetArgument("enable_logging", value);
    }

    /// <summary>
    /// An integer indicating the priority of a rule in the list. The priority must be a value
    /// between 0 and 2147483647. Rules are evaluated from highest to lowest priority where 0 is the
    /// highest priority and 2147483647 is the lowest priority.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// An optional name for the rule. This field is not a unique identifier
    /// and can be updated.
    /// </summary>
    public TerraformValue<string>? RuleName
    {
        get => new TerraformReference<string>(this, "rule_name");
        set => SetArgument("rule_name", value);
    }

    /// <summary>
    /// A fully-qualified URL of a SecurityProfile resource instance.
    /// Example:
    /// https://networksecurity.googleapis.com/v1/projects/{project}/locations/{location}/securityProfileGroups/my-security-profile-group
    /// Must be specified if action is &#39;apply_security_profile_group&#39;.
    /// </summary>
    public TerraformValue<string>? SecurityProfileGroup
    {
        get => new TerraformReference<string>(this, "security_profile_group");
        set => SetArgument("security_profile_group", value);
    }

    /// <summary>
    /// A list of service accounts indicating the sets of
    /// instances that are applied with this rule.
    /// </summary>
    public TerraformList<string>? TargetServiceAccounts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "target_service_accounts").ResolveNodes(ctx));
        set => SetArgument("target_service_accounts", value);
    }

    /// <summary>
    /// Boolean flag indicating if the traffic should be TLS decrypted.
    /// It can be set only if action = &#39;apply_security_profile_group&#39; and cannot be set for other actions.
    /// </summary>
    public TerraformValue<bool>? TlsInspect
    {
        get => new TerraformReference<bool>(this, "tls_inspect");
        set => SetArgument("tls_inspect", value);
    }

    /// <summary>
    /// Match block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Match is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Match block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public required TerraformList<GoogleComputeNetworkFirewallPolicyWithRulesRuleBlockMatchBlock> Match
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeNetworkFirewallPolicyWithRulesRuleBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

    /// <summary>
    /// TargetSecureTag block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeNetworkFirewallPolicyWithRulesRuleBlockTargetSecureTagBlock>? TargetSecureTag
    {
        get => GetArgument<TerraformList<GoogleComputeNetworkFirewallPolicyWithRulesRuleBlockTargetSecureTagBlock>>("target_secure_tag");
        set => SetArgument("target_secure_tag", value);
    }

}

/// <summary>
/// Block type for match in GoogleComputeNetworkFirewallPolicyWithRulesRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeNetworkFirewallPolicyWithRulesRuleBlockMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match";

    /// <summary>
    /// Address groups which should be matched against the traffic destination.
    /// Maximum number of destination address groups is 10.
    /// </summary>
    public TerraformList<string>? DestAddressGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dest_address_groups").ResolveNodes(ctx));
        set => SetArgument("dest_address_groups", value);
    }

    /// <summary>
    /// Fully Qualified Domain Name (FQDN) which should be matched against
    /// traffic destination. Maximum number of destination fqdn allowed is 100.
    /// </summary>
    public TerraformList<string>? DestFqdns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dest_fqdns").ResolveNodes(ctx));
        set => SetArgument("dest_fqdns", value);
    }

    /// <summary>
    /// Destination IP address range in CIDR format. Required for
    /// EGRESS rules.
    /// </summary>
    public TerraformList<string>? DestIpRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dest_ip_ranges").ResolveNodes(ctx));
        set => SetArgument("dest_ip_ranges", value);
    }

    /// <summary>
    /// Region codes whose IP addresses will be used to match for destination
    /// of traffic. Should be specified as 2 letter country code defined as per
    /// ISO 3166 alpha-2 country codes. ex.&amp;quot;US&amp;quot;
    /// Maximum number of destination region codes allowed is 5000.
    /// </summary>
    public TerraformList<string>? DestRegionCodes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dest_region_codes").ResolveNodes(ctx));
        set => SetArgument("dest_region_codes", value);
    }

    /// <summary>
    /// Names of Network Threat Intelligence lists.
    /// The IPs in these lists will be matched against traffic destination.
    /// </summary>
    public TerraformList<string>? DestThreatIntelligences
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dest_threat_intelligences").ResolveNodes(ctx));
        set => SetArgument("dest_threat_intelligences", value);
    }

    /// <summary>
    /// Address groups which should be matched against the traffic source.
    /// Maximum number of source address groups is 10.
    /// </summary>
    public TerraformList<string>? SrcAddressGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "src_address_groups").ResolveNodes(ctx));
        set => SetArgument("src_address_groups", value);
    }

    /// <summary>
    /// Fully Qualified Domain Name (FQDN) which should be matched against
    /// traffic source. Maximum number of source fqdn allowed is 100.
    /// </summary>
    public TerraformList<string>? SrcFqdns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "src_fqdns").ResolveNodes(ctx));
        set => SetArgument("src_fqdns", value);
    }

    /// <summary>
    /// Source IP address range in CIDR format. Required for
    /// INGRESS rules.
    /// </summary>
    public TerraformList<string>? SrcIpRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "src_ip_ranges").ResolveNodes(ctx));
        set => SetArgument("src_ip_ranges", value);
    }

    /// <summary>
    /// Region codes whose IP addresses will be used to match for source
    /// of traffic. Should be specified as 2 letter country code defined as per
    /// ISO 3166 alpha-2 country codes. ex.&amp;quot;US&amp;quot;
    /// Maximum number of source region codes allowed is 5000.
    /// </summary>
    public TerraformList<string>? SrcRegionCodes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "src_region_codes").ResolveNodes(ctx));
        set => SetArgument("src_region_codes", value);
    }

    /// <summary>
    /// Names of Network Threat Intelligence lists.
    /// The IPs in these lists will be matched against traffic source.
    /// </summary>
    public TerraformList<string>? SrcThreatIntelligences
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "src_threat_intelligences").ResolveNodes(ctx));
        set => SetArgument("src_threat_intelligences", value);
    }

    /// <summary>
    /// Layer4Config block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Layer4Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Layer4Config block(s) required")]
    public required TerraformList<GoogleComputeNetworkFirewallPolicyWithRulesRuleBlockMatchBlockLayer4ConfigBlock> Layer4Config
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeNetworkFirewallPolicyWithRulesRuleBlockMatchBlockLayer4ConfigBlock>>("layer4_config");
        set => SetArgument("layer4_config", value);
    }

    /// <summary>
    /// SrcSecureTag block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeNetworkFirewallPolicyWithRulesRuleBlockMatchBlockSrcSecureTagBlock>? SrcSecureTag
    {
        get => GetArgument<TerraformList<GoogleComputeNetworkFirewallPolicyWithRulesRuleBlockMatchBlockSrcSecureTagBlock>>("src_secure_tag");
        set => SetArgument("src_secure_tag", value);
    }

}

/// <summary>
/// Block type for layer4_config in GoogleComputeNetworkFirewallPolicyWithRulesRuleBlockMatchBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeNetworkFirewallPolicyWithRulesRuleBlockMatchBlockLayer4ConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "layer4_config";

    /// <summary>
    /// The IP protocol to which this rule applies. The protocol
    /// type is required when creating a firewall rule.
    /// This value can either be one of the following well
    /// known protocol strings (tcp, udp, icmp, esp, ah, ipip, sctp),
    /// or the IP protocol number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpProtocol is required")]
    public required TerraformValue<string> IpProtocol
    {
        get => new TerraformReference<string>(this, "ip_protocol");
        set => SetArgument("ip_protocol", value);
    }

    /// <summary>
    /// An optional list of ports to which this rule applies. This field
    /// is only applicable for UDP or TCP protocol. Each entry must be
    /// either an integer or a range. If not specified, this rule
    /// applies to connections through any port.
    /// Example inputs include: [&amp;quot;22&amp;quot;], [&amp;quot;80&amp;quot;,&amp;quot;443&amp;quot;], and
    /// [&amp;quot;12345-12349&amp;quot;].
    /// </summary>
    public TerraformList<string>? Ports
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ports").ResolveNodes(ctx));
        set => SetArgument("ports", value);
    }

}

/// <summary>
/// Block type for src_secure_tag in GoogleComputeNetworkFirewallPolicyWithRulesRuleBlockMatchBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeNetworkFirewallPolicyWithRulesRuleBlockMatchBlockSrcSecureTagBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "src_secure_tag";

    /// <summary>
    /// Name of the secure tag, created with TagManager&#39;s TagValue API.
    /// @pattern tagValues/[0-9]+
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// [Output Only] State of the secure tag, either &#39;EFFECTIVE&#39; or
    /// &#39;INEFFECTIVE&#39;. A secure tag is &#39;INEFFECTIVE&#39; when it is deleted
    /// or its network is deleted.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

}

/// <summary>
/// Block type for target_secure_tag in GoogleComputeNetworkFirewallPolicyWithRulesRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeNetworkFirewallPolicyWithRulesRuleBlockTargetSecureTagBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_secure_tag";

    /// <summary>
    /// Name of the secure tag, created with TagManager&#39;s TagValue API.
    /// @pattern tagValues/[0-9]+
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// [Output Only] State of the secure tag, either &#39;EFFECTIVE&#39; or
    /// &#39;INEFFECTIVE&#39;. A secure tag is &#39;INEFFECTIVE&#39; when it is deleted
    /// or its network is deleted.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeNetworkFirewallPolicyWithRules.
/// Nesting mode: single
/// </summary>
public class GoogleComputeNetworkFirewallPolicyWithRulesTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_network_firewall_policy_with_rules Terraform resource.
/// Manages a google_compute_network_firewall_policy_with_rules resource.
/// </summary>
public partial class GoogleComputeNetworkFirewallPolicyWithRules(string name) : TerraformResource("google_compute_network_firewall_policy_with_rules", name)
{
    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// User-provided name of the Network firewall policy.
    /// The name should be unique in the project in which the firewall policy is created.
    /// The name must be 1-63 characters long, and comply with RFC1035. Specifically,
    /// the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])?
    /// which means the first character must be a lowercase letter, and all following characters must be a dash,
    /// lowercase letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Policy type is used to determine which resources (networks) the policy can be associated with.
    /// A policy can be associated with a network only if the network has the matching policyType in its network profile.
    /// Different policy types may support some of the Firewall Rules features. Possible values: [&amp;quot;VPC_POLICY&amp;quot;]
    /// </summary>
    public TerraformValue<string> PolicyType
    {
        get => new TerraformReference<string>(this, "policy_type");
        set => SetArgument("policy_type", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// Fingerprint of the resource. This field is used internally during updates of this resource.
    /// </summary>
    public TerraformValue<string> Fingerprint
    {
        get => new TerraformReference<string>(this, "fingerprint");
    }

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformValue<string> NetworkFirewallPolicyId
    {
        get => new TerraformReference<string>(this, "network_firewall_policy_id");
    }

    /// <summary>
    /// A list of firewall policy pre-defined rules.
    /// </summary>
    public TerraformList<TerraformMap<object>> PredefinedRules
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "predefined_rules").ResolveNodes(ctx));
    }

    /// <summary>
    /// Total count of all firewall policy rule tuples. A firewall policy can not exceed a set number of tuples.
    /// </summary>
    public TerraformValue<double> RuleTupleCount
    {
        get => new TerraformReference<double>(this, "rule_tuple_count");
    }

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// Server-defined URL for this resource with the resource id.
    /// </summary>
    public TerraformValue<string> SelfLinkWithId
    {
        get => new TerraformReference<string>(this, "self_link_with_id");
    }

    /// <summary>
    /// Rule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    public required TerraformList<GoogleComputeNetworkFirewallPolicyWithRulesRuleBlock> Rule
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeNetworkFirewallPolicyWithRulesRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeNetworkFirewallPolicyWithRulesTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeNetworkFirewallPolicyWithRulesTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
