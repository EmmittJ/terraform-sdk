using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for match in GoogleComputeRegionNetworkFirewallPolicyRule.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionNetworkFirewallPolicyRuleMatchBlock : TerraformBlock
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
        get => GetArgument<TerraformList<string>>("dest_address_groups");
        set => SetArgument("dest_address_groups", value);
    }

    /// <summary>
    /// Fully Qualified Domain Name (FQDN) which should be matched against traffic destination. Maximum number of destination fqdn allowed is 100.
    /// </summary>
    public TerraformList<string>? DestFqdns
    {
        get => GetArgument<TerraformList<string>>("dest_fqdns");
        set => SetArgument("dest_fqdns", value);
    }

    /// <summary>
    /// CIDR IP address range. Maximum number of destination CIDR IP ranges allowed is 5000.
    /// </summary>
    public TerraformList<string>? DestIpRanges
    {
        get => GetArgument<TerraformList<string>>("dest_ip_ranges");
        set => SetArgument("dest_ip_ranges", value);
    }

    /// <summary>
    /// Region codes whose IP addresses will be used to match for destination of traffic. Should be specified as 2 letter country code defined as per ISO 3166 alpha-2 country codes. ex.&amp;quot;US&amp;quot; Maximum number of dest region codes allowed is 5000.
    /// </summary>
    public TerraformList<string>? DestRegionCodes
    {
        get => GetArgument<TerraformList<string>>("dest_region_codes");
        set => SetArgument("dest_region_codes", value);
    }

    /// <summary>
    /// Names of Network Threat Intelligence lists. The IPs in these lists will be matched against traffic destination.
    /// </summary>
    public TerraformList<string>? DestThreatIntelligences
    {
        get => GetArgument<TerraformList<string>>("dest_threat_intelligences");
        set => SetArgument("dest_threat_intelligences", value);
    }

    /// <summary>
    /// Address groups which should be matched against the traffic source. Maximum number of source address groups is 10.
    /// </summary>
    public TerraformList<string>? SrcAddressGroups
    {
        get => GetArgument<TerraformList<string>>("src_address_groups");
        set => SetArgument("src_address_groups", value);
    }

    /// <summary>
    /// Fully Qualified Domain Name (FQDN) which should be matched against traffic source. Maximum number of source fqdn allowed is 100.
    /// </summary>
    public TerraformList<string>? SrcFqdns
    {
        get => GetArgument<TerraformList<string>>("src_fqdns");
        set => SetArgument("src_fqdns", value);
    }

    /// <summary>
    /// CIDR IP address range. Maximum number of source CIDR IP ranges allowed is 5000.
    /// </summary>
    public TerraformList<string>? SrcIpRanges
    {
        get => GetArgument<TerraformList<string>>("src_ip_ranges");
        set => SetArgument("src_ip_ranges", value);
    }

    /// <summary>
    /// Region codes whose IP addresses will be used to match for source of traffic. Should be specified as 2 letter country code defined as per ISO 3166 alpha-2 country codes. ex.&amp;quot;US&amp;quot; Maximum number of source region codes allowed is 5000.
    /// </summary>
    public TerraformList<string>? SrcRegionCodes
    {
        get => GetArgument<TerraformList<string>>("src_region_codes");
        set => SetArgument("src_region_codes", value);
    }

    /// <summary>
    /// Names of Network Threat Intelligence lists. The IPs in these lists will be matched against traffic source.
    /// </summary>
    public TerraformList<string>? SrcThreatIntelligences
    {
        get => GetArgument<TerraformList<string>>("src_threat_intelligences");
        set => SetArgument("src_threat_intelligences", value);
    }

    /// <summary>
    /// Layer4Configs block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Layer4Configs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Layer4Configs block(s) required")]
    public required TerraformList<GoogleComputeRegionNetworkFirewallPolicyRuleMatchBlockLayer4ConfigsBlock> Layer4Configs
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeRegionNetworkFirewallPolicyRuleMatchBlockLayer4ConfigsBlock>>("layer4_configs");
        set => SetArgument("layer4_configs", value);
    }

    /// <summary>
    /// SrcSecureTags block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionNetworkFirewallPolicyRuleMatchBlockSrcSecureTagsBlock>? SrcSecureTags
    {
        get => GetArgument<TerraformList<GoogleComputeRegionNetworkFirewallPolicyRuleMatchBlockSrcSecureTagsBlock>>("src_secure_tags");
        set => SetArgument("src_secure_tags", value);
    }

}

/// <summary>
/// Block type for layer4_configs in GoogleComputeRegionNetworkFirewallPolicyRuleMatchBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionNetworkFirewallPolicyRuleMatchBlockLayer4ConfigsBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("ip_protocol");
        set => SetArgument("ip_protocol", value);
    }

    /// <summary>
    /// An optional list of ports to which this rule applies. This field is only applicable for UDP or TCP protocol. Each entry must be either an integer or a range. If not specified, this rule applies to connections through any port.
    /// Example inputs include: [&amp;quot;22&amp;quot;], [&amp;quot;80&amp;quot;,&amp;quot;443&amp;quot;], and [&amp;quot;12345-12349&amp;quot;].
    /// </summary>
    public TerraformList<string>? Ports
    {
        get => GetArgument<TerraformList<string>>("ports");
        set => SetArgument("ports", value);
    }

}

/// <summary>
/// Block type for src_secure_tags in GoogleComputeRegionNetworkFirewallPolicyRuleMatchBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionNetworkFirewallPolicyRuleMatchBlockSrcSecureTagsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// State of the secure tag, either EFFECTIVE or INEFFECTIVE. A secure tag is INEFFECTIVE when it is deleted or its network is deleted.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

}


/// <summary>
/// Block type for target_secure_tags in GoogleComputeRegionNetworkFirewallPolicyRule.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionNetworkFirewallPolicyRuleTargetSecureTagsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// State of the secure tag, either EFFECTIVE or INEFFECTIVE. A secure tag is INEFFECTIVE when it is deleted or its network is deleted.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

}


/// <summary>
/// Block type for timeouts in GoogleComputeRegionNetworkFirewallPolicyRule.
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionNetworkFirewallPolicyRuleTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_region_network_firewall_policy_rule Terraform resource.
/// Manages a google_compute_region_network_firewall_policy_rule resource.
/// </summary>
public partial class GoogleComputeRegionNetworkFirewallPolicyRule(string name) : TerraformResource("google_compute_region_network_firewall_policy_rule", name)
{
    /// <summary>
    /// The Action to perform when the client connection triggers the rule. Valid actions are &amp;quot;allow&amp;quot;, &amp;quot;deny&amp;quot;, &amp;quot;goto_next&amp;quot; and &amp;quot;apply_security_profile_group&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetRequiredArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// An optional description for this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The direction in which this rule applies. Possible values: [&amp;quot;INGRESS&amp;quot;, &amp;quot;EGRESS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Direction is required")]
    public required TerraformValue<string> Direction
    {
        get => GetRequiredArgument<TerraformValue<string>>("direction");
        set => SetArgument("direction", value);
    }

    /// <summary>
    /// Denotes whether the firewall policy rule is disabled.
    /// When set to true, the firewall policy rule is not enforced and traffic behaves as if it did not exist.
    /// If this is unspecified, the firewall policy rule will be enabled.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
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
        get => GetArgument<TerraformValue<bool>>("enable_logging");
        set => SetArgument("enable_logging", value);
    }

    /// <summary>
    /// The firewall policy of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallPolicy is required")]
    public required TerraformValue<string> FirewallPolicy
    {
        get => GetRequiredArgument<TerraformValue<string>>("firewall_policy");
        set => SetArgument("firewall_policy", value);
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
    /// An integer indicating the priority of a rule in the list.
    /// The priority must be a positive value between 0 and 2147483647.
    /// Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest prority.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => GetRequiredArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
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
    /// The location of this resource.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// An optional name for the rule. This field is not a unique identifier and can be updated.
    /// </summary>
    public TerraformValue<string>? RuleName
    {
        get => GetArgument<TerraformValue<string>>("rule_name");
        set => SetArgument("rule_name", value);
    }

    /// <summary>
    /// A fully-qualified URL of a SecurityProfile resource instance.
    /// Example: https://networksecurity.googleapis.com/v1/projects/{project}/locations/{location}/securityProfileGroups/my-security-profile-group
    /// Must be specified if action = &#39;apply_security_profile_group&#39; and cannot be specified for other actions.
    /// 
    /// Security Profile Group and Firewall Policy Rule must be in the same scope.
    /// </summary>
    public TerraformValue<string>? SecurityProfileGroup
    {
        get => GetArgument<TerraformValue<string>>("security_profile_group");
        set => SetArgument("security_profile_group", value);
    }

    /// <summary>
    /// A list of service accounts indicating the sets of instances that are applied with this rule.
    /// </summary>
    public TerraformList<string>? TargetServiceAccounts
    {
        get => GetArgument<TerraformList<string>>("target_service_accounts");
        set => SetArgument("target_service_accounts", value);
    }

    /// <summary>
    /// Boolean flag indicating if the traffic should be TLS decrypted.
    /// Can be set only if action = &#39;apply_security_profile_group&#39; and cannot be set for other actions.
    /// </summary>
    public TerraformValue<bool>? TlsInspect
    {
        get => GetArgument<TerraformValue<bool>>("tls_inspect");
        set => SetArgument("tls_inspect", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => CreateReference("creation_timestamp");

    /// <summary>
    /// Type of the resource. Always &#39;compute#firewallPolicyRule&#39; for firewall policy rules
    /// </summary>
    public TerraformValue<string> Kind
        => CreateReference("kind");

    /// <summary>
    /// Calculation of the complexity of a single firewall policy rule.
    /// </summary>
    public TerraformValue<double> RuleTupleCount
        => CreateReference("rule_tuple_count");

    /// <summary>
    /// Match block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Match is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Match block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public required TerraformList<GoogleComputeRegionNetworkFirewallPolicyRuleMatchBlock> Match
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeRegionNetworkFirewallPolicyRuleMatchBlock>>("match");
        set => SetArgument("match", value);
    }

    /// <summary>
    /// TargetSecureTags block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionNetworkFirewallPolicyRuleTargetSecureTagsBlock>? TargetSecureTags
    {
        get => GetArgument<TerraformList<GoogleComputeRegionNetworkFirewallPolicyRuleTargetSecureTagsBlock>>("target_secure_tags");
        set => SetArgument("target_secure_tags", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeRegionNetworkFirewallPolicyRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeRegionNetworkFirewallPolicyRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
