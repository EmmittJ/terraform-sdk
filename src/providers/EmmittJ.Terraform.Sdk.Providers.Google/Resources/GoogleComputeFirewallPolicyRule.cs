using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for match in GoogleComputeFirewallPolicyRule.
/// Nesting mode: list
/// </summary>
public class GoogleComputeFirewallPolicyRuleMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match";

    /// <summary>
    /// Address groups which should be matched against the traffic destination. Maximum number of destination address groups is 10.
    /// </summary>
    public TerraformList<string>? DestAddressGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dest_address_groups").ResolveNodes(ctx));
        set => SetArgument("dest_address_groups", value);
    }

    /// <summary>
    /// Fully Qualified Domain Name (FQDN) which should be matched against traffic destination. Maximum number of destination fqdn allowed is 100.
    /// </summary>
    public TerraformList<string>? DestFqdns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dest_fqdns").ResolveNodes(ctx));
        set => SetArgument("dest_fqdns", value);
    }

    /// <summary>
    /// CIDR IP address range. Maximum number of destination CIDR IP ranges allowed is 5000.
    /// </summary>
    public TerraformList<string>? DestIpRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dest_ip_ranges").ResolveNodes(ctx));
        set => SetArgument("dest_ip_ranges", value);
    }

    /// <summary>
    /// Region codes whose IP addresses will be used to match for destination of traffic. Should be specified as 2 letter country code defined as per ISO 3166 alpha-2 country codes. ex.&amp;quot;US&amp;quot; Maximum number of dest region codes allowed is 5000.
    /// </summary>
    public TerraformList<string>? DestRegionCodes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dest_region_codes").ResolveNodes(ctx));
        set => SetArgument("dest_region_codes", value);
    }

    /// <summary>
    /// Names of Network Threat Intelligence lists. The IPs in these lists will be matched against traffic destination.
    /// </summary>
    public TerraformList<string>? DestThreatIntelligences
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dest_threat_intelligences").ResolveNodes(ctx));
        set => SetArgument("dest_threat_intelligences", value);
    }

    /// <summary>
    /// Address groups which should be matched against the traffic source. Maximum number of source address groups is 10.
    /// </summary>
    public TerraformList<string>? SrcAddressGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "src_address_groups").ResolveNodes(ctx));
        set => SetArgument("src_address_groups", value);
    }

    /// <summary>
    /// Fully Qualified Domain Name (FQDN) which should be matched against traffic source. Maximum number of source fqdn allowed is 100.
    /// </summary>
    public TerraformList<string>? SrcFqdns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "src_fqdns").ResolveNodes(ctx));
        set => SetArgument("src_fqdns", value);
    }

    /// <summary>
    /// CIDR IP address range. Maximum number of source CIDR IP ranges allowed is 5000.
    /// </summary>
    public TerraformList<string>? SrcIpRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "src_ip_ranges").ResolveNodes(ctx));
        set => SetArgument("src_ip_ranges", value);
    }

    /// <summary>
    /// Region codes whose IP addresses will be used to match for source of traffic. Should be specified as 2 letter country code defined as per ISO 3166 alpha-2 country codes. ex.&amp;quot;US&amp;quot; Maximum number of source region codes allowed is 5000.
    /// </summary>
    public TerraformList<string>? SrcRegionCodes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "src_region_codes").ResolveNodes(ctx));
        set => SetArgument("src_region_codes", value);
    }

    /// <summary>
    /// Names of Network Threat Intelligence lists. The IPs in these lists will be matched against traffic source.
    /// </summary>
    public TerraformList<string>? SrcThreatIntelligences
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "src_threat_intelligences").ResolveNodes(ctx));
        set => SetArgument("src_threat_intelligences", value);
    }

    /// <summary>
    /// Layer4Configs block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Layer4Configs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Layer4Configs block(s) required")]
    public required TerraformList<GoogleComputeFirewallPolicyRuleMatchBlockLayer4ConfigsBlock> Layer4Configs
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeFirewallPolicyRuleMatchBlockLayer4ConfigsBlock>>("layer4_configs");
        set => SetArgument("layer4_configs", value);
    }

    /// <summary>
    /// SrcSecureTags block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeFirewallPolicyRuleMatchBlockSrcSecureTagsBlock>? SrcSecureTags
    {
        get => GetArgument<TerraformList<GoogleComputeFirewallPolicyRuleMatchBlockSrcSecureTagsBlock>>("src_secure_tags");
        set => SetArgument("src_secure_tags", value);
    }

}

/// <summary>
/// Block type for layer4_configs in GoogleComputeFirewallPolicyRuleMatchBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeFirewallPolicyRuleMatchBlockLayer4ConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "layer4_configs";

    /// <summary>
    /// The IP protocol to which this rule applies. The protocol type is required when creating a firewall rule.
    /// This value can either be one of the following well known protocol strings (tcp, udp, icmp, esp, ah, ipip, sctp), or the IP protocol number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpProtocol is required")]
    public required TerraformValue<string> IpProtocol
    {
        get => new TerraformReference<string>(this, "ip_protocol");
        set => SetArgument("ip_protocol", value);
    }

    /// <summary>
    /// An optional list of ports to which this rule applies. This field is only applicable for UDP or TCP protocol. Each entry must be either an integer or a range. If not specified, this rule applies to connections through any port.
    /// Example inputs include: [&amp;quot;22&amp;quot;], [&amp;quot;80&amp;quot;,&amp;quot;443&amp;quot;], and [&amp;quot;12345-12349&amp;quot;].
    /// </summary>
    public TerraformList<string>? Ports
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ports").ResolveNodes(ctx));
        set => SetArgument("ports", value);
    }

}

/// <summary>
/// Block type for src_secure_tags in GoogleComputeFirewallPolicyRuleMatchBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeFirewallPolicyRuleMatchBlockSrcSecureTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "src_secure_tags";

    /// <summary>
    /// Name of the secure tag, created with TagManager&#39;s TagValue API.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// State of the secure tag, either EFFECTIVE or INEFFECTIVE. A secure tag is INEFFECTIVE when it is deleted or its network is deleted.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

}


/// <summary>
/// Block type for target_secure_tags in GoogleComputeFirewallPolicyRule.
/// Nesting mode: list
/// </summary>
public class GoogleComputeFirewallPolicyRuleTargetSecureTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_secure_tags";

    /// <summary>
    /// Name of the secure tag, created with TagManager&#39;s TagValue API.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// State of the secure tag, either EFFECTIVE or INEFFECTIVE. A secure tag is INEFFECTIVE when it is deleted or its network is deleted.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeFirewallPolicyRule.
/// Nesting mode: single
/// </summary>
public class GoogleComputeFirewallPolicyRuleTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_firewall_policy_rule Terraform resource.
/// Manages a google_compute_firewall_policy_rule resource.
/// </summary>
public partial class GoogleComputeFirewallPolicyRule(string name) : TerraformResource("google_compute_firewall_policy_rule", name)
{
    /// <summary>
    /// The Action to perform when the client connection triggers the rule. Valid actions are &amp;quot;allow&amp;quot;, &amp;quot;deny&amp;quot;, &amp;quot;goto_next&amp;quot; and &amp;quot;apply_security_profile_group&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// An optional description for this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The direction in which this rule applies. Possible values: [&amp;quot;INGRESS&amp;quot;, &amp;quot;EGRESS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Direction is required")]
    public required TerraformValue<string> Direction
    {
        get => new TerraformReference<string>(this, "direction");
        set => SetArgument("direction", value);
    }

    /// <summary>
    /// Denotes whether the firewall policy rule is disabled.
    /// When set to true, the firewall policy rule is not enforced and traffic behaves as if it did not exist.
    /// If this is unspecified, the firewall policy rule will be enabled.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// Denotes whether to enable logging for a particular rule.
    /// If logging is enabled, logs will be exported to the configured export destination in Stackdriver.
    /// Logs may be exported to BigQuery or Pub/Sub.
    /// Note: you cannot enable logging on &amp;quot;goto_next&amp;quot; rules.
    /// </summary>
    public TerraformValue<bool>? EnableLogging
    {
        get => new TerraformReference<bool>(this, "enable_logging");
        set => SetArgument("enable_logging", value);
    }

    /// <summary>
    /// The firewall policy of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallPolicy is required")]
    public required TerraformValue<string> FirewallPolicy
    {
        get => new TerraformReference<string>(this, "firewall_policy");
        set => SetArgument("firewall_policy", value);
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
    /// An integer indicating the priority of a rule in the list.
    /// The priority must be a positive value between 0 and 2147483647.
    /// Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest prority.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// A fully-qualified URL of a SecurityProfile resource instance.
    /// Example: https://networksecurity.googleapis.com/v1/projects/{project}/locations/{location}/securityProfileGroups/my-security-profile-group
    /// Must be specified if action = &#39;apply_security_profile_group&#39; and cannot be specified for other actions.
    /// </summary>
    public TerraformValue<string>? SecurityProfileGroup
    {
        get => new TerraformReference<string>(this, "security_profile_group");
        set => SetArgument("security_profile_group", value);
    }

    /// <summary>
    /// A list of network resource URLs to which this rule applies.
    /// This field allows you to control which network&#39;s VMs get this rule.
    /// If this field is left blank, all VMs within the organization will receive the rule.
    /// </summary>
    public TerraformList<string>? TargetResources
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "target_resources").ResolveNodes(ctx));
        set => SetArgument("target_resources", value);
    }

    /// <summary>
    /// A list of service accounts indicating the sets of instances that are applied with this rule.
    /// </summary>
    public TerraformList<string>? TargetServiceAccounts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "target_service_accounts").ResolveNodes(ctx));
        set => SetArgument("target_service_accounts", value);
    }

    /// <summary>
    /// Boolean flag indicating if the traffic should be TLS decrypted.
    /// Can be set only if action = &#39;apply_security_profile_group&#39; and cannot be set for other actions.
    /// </summary>
    public TerraformValue<bool>? TlsInspect
    {
        get => new TerraformReference<bool>(this, "tls_inspect");
        set => SetArgument("tls_inspect", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// Type of the resource. Always &#39;compute#firewallPolicyRule&#39; for firewall policy rules
    /// </summary>
    public TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
    }

    /// <summary>
    /// Calculation of the complexity of a single firewall policy rule.
    /// </summary>
    public TerraformValue<double> RuleTupleCount
    {
        get => new TerraformReference<double>(this, "rule_tuple_count");
    }

    /// <summary>
    /// Match block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Match is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Match block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public required TerraformList<GoogleComputeFirewallPolicyRuleMatchBlock> Match
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeFirewallPolicyRuleMatchBlock>>("match");
        set => SetArgument("match", value);
    }

    /// <summary>
    /// TargetSecureTags block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeFirewallPolicyRuleTargetSecureTagsBlock>? TargetSecureTags
    {
        get => GetArgument<TerraformList<GoogleComputeFirewallPolicyRuleTargetSecureTagsBlock>>("target_secure_tags");
        set => SetArgument("target_secure_tags", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeFirewallPolicyRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeFirewallPolicyRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
