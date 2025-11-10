using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for match in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionNetworkFirewallPolicyRuleMatchBlock : TerraformBlock
{
    /// <summary>
    /// Address groups which should be matched against the traffic destination. Maximum number of destination address groups is 10.
    /// </summary>
    public List<TerraformProperty<string>>? DestAddressGroups
    {
        get => GetProperty<List<TerraformProperty<string>>>("dest_address_groups");
        set => WithProperty("dest_address_groups", value);
    }

    /// <summary>
    /// Fully Qualified Domain Name (FQDN) which should be matched against traffic destination. Maximum number of destination fqdn allowed is 100.
    /// </summary>
    public List<TerraformProperty<string>>? DestFqdns
    {
        get => GetProperty<List<TerraformProperty<string>>>("dest_fqdns");
        set => WithProperty("dest_fqdns", value);
    }

    /// <summary>
    /// CIDR IP address range. Maximum number of destination CIDR IP ranges allowed is 5000.
    /// </summary>
    public List<TerraformProperty<string>>? DestIpRanges
    {
        get => GetProperty<List<TerraformProperty<string>>>("dest_ip_ranges");
        set => WithProperty("dest_ip_ranges", value);
    }

    /// <summary>
    /// Region codes whose IP addresses will be used to match for destination of traffic. Should be specified as 2 letter country code defined as per ISO 3166 alpha-2 country codes. ex.&amp;quot;US&amp;quot; Maximum number of dest region codes allowed is 5000.
    /// </summary>
    public List<TerraformProperty<string>>? DestRegionCodes
    {
        get => GetProperty<List<TerraformProperty<string>>>("dest_region_codes");
        set => WithProperty("dest_region_codes", value);
    }

    /// <summary>
    /// Names of Network Threat Intelligence lists. The IPs in these lists will be matched against traffic destination.
    /// </summary>
    public List<TerraformProperty<string>>? DestThreatIntelligences
    {
        get => GetProperty<List<TerraformProperty<string>>>("dest_threat_intelligences");
        set => WithProperty("dest_threat_intelligences", value);
    }

    /// <summary>
    /// Address groups which should be matched against the traffic source. Maximum number of source address groups is 10.
    /// </summary>
    public List<TerraformProperty<string>>? SrcAddressGroups
    {
        get => GetProperty<List<TerraformProperty<string>>>("src_address_groups");
        set => WithProperty("src_address_groups", value);
    }

    /// <summary>
    /// Fully Qualified Domain Name (FQDN) which should be matched against traffic source. Maximum number of source fqdn allowed is 100.
    /// </summary>
    public List<TerraformProperty<string>>? SrcFqdns
    {
        get => GetProperty<List<TerraformProperty<string>>>("src_fqdns");
        set => WithProperty("src_fqdns", value);
    }

    /// <summary>
    /// CIDR IP address range. Maximum number of source CIDR IP ranges allowed is 5000.
    /// </summary>
    public List<TerraformProperty<string>>? SrcIpRanges
    {
        get => GetProperty<List<TerraformProperty<string>>>("src_ip_ranges");
        set => WithProperty("src_ip_ranges", value);
    }

    /// <summary>
    /// Region codes whose IP addresses will be used to match for source of traffic. Should be specified as 2 letter country code defined as per ISO 3166 alpha-2 country codes. ex.&amp;quot;US&amp;quot; Maximum number of source region codes allowed is 5000.
    /// </summary>
    public List<TerraformProperty<string>>? SrcRegionCodes
    {
        get => GetProperty<List<TerraformProperty<string>>>("src_region_codes");
        set => WithProperty("src_region_codes", value);
    }

    /// <summary>
    /// Names of Network Threat Intelligence lists. The IPs in these lists will be matched against traffic source.
    /// </summary>
    public List<TerraformProperty<string>>? SrcThreatIntelligences
    {
        get => GetProperty<List<TerraformProperty<string>>>("src_threat_intelligences");
        set => WithProperty("src_threat_intelligences", value);
    }

}

/// <summary>
/// Block type for target_secure_tags in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionNetworkFirewallPolicyRuleTargetSecureTagsBlock : TerraformBlock
{
    /// <summary>
    /// Name of the secure tag, created with TagManager&#39;s TagValue API.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// State of the secure tag, either EFFECTIVE or INEFFECTIVE. A secure tag is INEFFECTIVE when it is deleted or its network is deleted.
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => WithProperty("state", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionNetworkFirewallPolicyRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_region_network_firewall_policy_rule resource.
/// </summary>
public class GoogleComputeRegionNetworkFirewallPolicyRule : TerraformResource
{
    public GoogleComputeRegionNetworkFirewallPolicyRule(string name) : base("google_compute_region_network_firewall_policy_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("kind");
        this.DeclareOutput("rule_tuple_count");
    }

    /// <summary>
    /// The Action to perform when the client connection triggers the rule. Valid actions are &amp;quot;allow&amp;quot;, &amp;quot;deny&amp;quot;, &amp;quot;goto_next&amp;quot; and &amp;quot;apply_security_profile_group&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// An optional description for this resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The direction in which this rule applies. Possible values: [&amp;quot;INGRESS&amp;quot;, &amp;quot;EGRESS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Direction is required")]
    public required TerraformProperty<string> Direction
    {
        get => GetProperty<TerraformProperty<string>>("direction");
        set => this.WithProperty("direction", value);
    }

    /// <summary>
    /// Denotes whether the firewall policy rule is disabled.
    /// When set to true, the firewall policy rule is not enforced and traffic behaves as if it did not exist.
    /// If this is unspecified, the firewall policy rule will be enabled.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// Denotes whether to enable logging for a particular rule.
    /// If logging is enabled, logs will be exported to the configured export destination in Stackdriver.
    /// Logs may be exported to BigQuery or Pub/Sub.
    /// Note: you cannot enable logging on &amp;quot;goto_next&amp;quot; rules.
    /// </summary>
    public TerraformProperty<bool>? EnableLogging
    {
        get => GetProperty<TerraformProperty<bool>>("enable_logging");
        set => this.WithProperty("enable_logging", value);
    }

    /// <summary>
    /// The firewall policy of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallPolicy is required")]
    public required TerraformProperty<string> FirewallPolicy
    {
        get => GetProperty<TerraformProperty<string>>("firewall_policy");
        set => this.WithProperty("firewall_policy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// An integer indicating the priority of a rule in the list.
    /// The priority must be a positive value between 0 and 2147483647.
    /// Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest prority.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The location of this resource.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// An optional name for the rule. This field is not a unique identifier and can be updated.
    /// </summary>
    public TerraformProperty<string>? RuleName
    {
        get => GetProperty<TerraformProperty<string>>("rule_name");
        set => this.WithProperty("rule_name", value);
    }

    /// <summary>
    /// A fully-qualified URL of a SecurityProfile resource instance.
    /// Example: https://networksecurity.googleapis.com/v1/projects/{project}/locations/{location}/securityProfileGroups/my-security-profile-group
    /// Must be specified if action = &#39;apply_security_profile_group&#39; and cannot be specified for other actions.
    /// 
    /// Security Profile Group and Firewall Policy Rule must be in the same scope.
    /// </summary>
    public TerraformProperty<string>? SecurityProfileGroup
    {
        get => GetProperty<TerraformProperty<string>>("security_profile_group");
        set => this.WithProperty("security_profile_group", value);
    }

    /// <summary>
    /// A list of service accounts indicating the sets of instances that are applied with this rule.
    /// </summary>
    public List<TerraformProperty<string>>? TargetServiceAccounts
    {
        get => GetProperty<List<TerraformProperty<string>>>("target_service_accounts");
        set => this.WithProperty("target_service_accounts", value);
    }

    /// <summary>
    /// Boolean flag indicating if the traffic should be TLS decrypted.
    /// Can be set only if action = &#39;apply_security_profile_group&#39; and cannot be set for other actions.
    /// </summary>
    public TerraformProperty<bool>? TlsInspect
    {
        get => GetProperty<TerraformProperty<bool>>("tls_inspect");
        set => this.WithProperty("tls_inspect", value);
    }

    /// <summary>
    /// Block for match.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Match block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public List<GoogleComputeRegionNetworkFirewallPolicyRuleMatchBlock>? Match
    {
        get => GetProperty<List<GoogleComputeRegionNetworkFirewallPolicyRuleMatchBlock>>("match");
        set => this.WithProperty("match", value);
    }

    /// <summary>
    /// Block for target_secure_tags.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeRegionNetworkFirewallPolicyRuleTargetSecureTagsBlock>? TargetSecureTags
    {
        get => GetProperty<List<GoogleComputeRegionNetworkFirewallPolicyRuleTargetSecureTagsBlock>>("target_secure_tags");
        set => this.WithProperty("target_secure_tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeRegionNetworkFirewallPolicyRuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeRegionNetworkFirewallPolicyRuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// Type of the resource. Always &#39;compute#firewallPolicyRule&#39; for firewall policy rules
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// Calculation of the complexity of a single firewall policy rule.
    /// </summary>
    public TerraformExpression RuleTupleCount => this["rule_tuple_count"];

}
