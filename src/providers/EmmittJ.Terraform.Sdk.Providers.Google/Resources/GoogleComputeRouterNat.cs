using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for log_config in GoogleComputeRouterNat.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterNatLogConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_config";

    /// <summary>
    /// Indicates whether or not to export logs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enable is required")]
    public required TerraformValue<bool> Enable
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enable");
        set => SetArgument("enable", value);
    }

    /// <summary>
    /// Specifies the desired filtering of logs on this NAT. Possible values: [&amp;quot;ERRORS_ONLY&amp;quot;, &amp;quot;TRANSLATIONS_ONLY&amp;quot;, &amp;quot;ALL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformValue<string> Filter
    {
        get => GetRequiredArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

}


/// <summary>
/// Block type for nat64_subnetwork in GoogleComputeRouterNat.
/// Nesting mode: set
/// </summary>
public class GoogleComputeRouterNatNat64SubnetworkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "nat64_subnetwork";

    /// <summary>
    /// Self-link of the subnetwork resource that will use NAT64
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for rules in GoogleComputeRouterNat.
/// Nesting mode: set
/// </summary>
public class GoogleComputeRouterNatRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules";

    /// <summary>
    /// An optional description of this rule.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// CEL expression that specifies the match condition that egress traffic from a VM is evaluated against.
    /// If it evaluates to true, the corresponding action is enforced.
    /// 
    /// The following examples are valid match expressions for public NAT:
    /// 
    /// &amp;quot;inIpRange(destination.ip, &#39;1.1.0.0/16&#39;) || inIpRange(destination.ip, &#39;2.2.0.0/16&#39;)&amp;quot;
    /// 
    /// &amp;quot;destination.ip == &#39;1.1.0.1&#39; || destination.ip == &#39;8.8.8.8&#39;&amp;quot;
    /// 
    /// The following example is a valid match expression for private NAT:
    /// 
    /// &amp;quot;nexthop.hub == &#39;https://networkconnectivity.googleapis.com/v1alpha1/projects/my-project/global/hub/hub-1&#39;&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Match is required")]
    public required TerraformValue<string> Match
    {
        get => GetRequiredArgument<TerraformValue<string>>("match");
        set => SetArgument("match", value);
    }

    /// <summary>
    /// An integer uniquely identifying a rule in the list.
    /// The rule number must be a positive value between 0 and 65000, and must be unique among rules within a NAT.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNumber is required")]
    public required TerraformValue<double> RuleNumber
    {
        get => GetRequiredArgument<TerraformValue<double>>("rule_number");
        set => SetArgument("rule_number", value);
    }

    /// <summary>
    /// Action block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public TerraformList<GoogleComputeRouterNatRulesBlockActionBlock>? Action
    {
        get => GetArgument<TerraformList<GoogleComputeRouterNatRulesBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

}

/// <summary>
/// Block type for action in GoogleComputeRouterNatRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterNatRulesBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// A list of URLs of the IP resources used for this NAT rule.
    /// These IP addresses must be valid static external IP addresses assigned to the project.
    /// This field is used for public NAT.
    /// </summary>
    public TerraformSet<string>? SourceNatActiveIps
    {
        get => GetArgument<TerraformSet<string>>("source_nat_active_ips");
        set => SetArgument("source_nat_active_ips", value);
    }

    /// <summary>
    /// A list of URLs of the subnetworks used as source ranges for this NAT Rule.
    /// These subnetworks must have purpose set to PRIVATE_NAT.
    /// This field is used for private NAT.
    /// </summary>
    public TerraformSet<string>? SourceNatActiveRanges
    {
        get => GetArgument<TerraformSet<string>>("source_nat_active_ranges");
        set => SetArgument("source_nat_active_ranges", value);
    }

    /// <summary>
    /// A list of URLs of the IP resources to be drained.
    /// These IPs must be valid static external IPs that have been assigned to the NAT.
    /// These IPs should be used for updating/patching a NAT rule only.
    /// This field is used for public NAT.
    /// </summary>
    public TerraformSet<string>? SourceNatDrainIps
    {
        get => GetArgument<TerraformSet<string>>("source_nat_drain_ips");
        set => SetArgument("source_nat_drain_ips", value);
    }

    /// <summary>
    /// A list of URLs of subnetworks representing source ranges to be drained.
    /// This is only supported on patch/update, and these subnetworks must have previously been used as active ranges in this NAT Rule.
    /// This field is used for private NAT.
    /// </summary>
    public TerraformSet<string>? SourceNatDrainRanges
    {
        get => GetArgument<TerraformSet<string>>("source_nat_drain_ranges");
        set => SetArgument("source_nat_drain_ranges", value);
    }

}


/// <summary>
/// Block type for subnetwork in GoogleComputeRouterNat.
/// Nesting mode: set
/// </summary>
public class GoogleComputeRouterNatSubnetworkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subnetwork";

    /// <summary>
    /// Self-link of subnetwork to NAT
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// List of the secondary ranges of the subnetwork that are allowed
    /// to use NAT. This can be populated only if
    /// &#39;LIST_OF_SECONDARY_IP_RANGES&#39; is one of the values in
    /// sourceIpRangesToNat
    /// </summary>
    public TerraformSet<string>? SecondaryIpRangeNames
    {
        get => GetArgument<TerraformSet<string>>("secondary_ip_range_names");
        set => SetArgument("secondary_ip_range_names", value);
    }

    /// <summary>
    /// List of options for which source IPs in the subnetwork
    /// should have NAT enabled. Supported values include:
    /// &#39;ALL_IP_RANGES&#39;, &#39;LIST_OF_SECONDARY_IP_RANGES&#39;,
    /// &#39;PRIMARY_IP_RANGE&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceIpRangesToNat is required")]
    public required TerraformSet<string> SourceIpRangesToNat
    {
        get => GetRequiredArgument<TerraformSet<string>>("source_ip_ranges_to_nat");
        set => SetArgument("source_ip_ranges_to_nat", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeRouterNat.
/// Nesting mode: single
/// </summary>
public class GoogleComputeRouterNatTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_router_nat Terraform resource.
/// Manages a google_compute_router_nat resource.
/// </summary>
public partial class GoogleComputeRouterNat(string name) : TerraformResource("google_compute_router_nat", name)
{
    /// <summary>
    /// The network tier to use when automatically reserving NAT IP addresses.
    /// Must be one of: PREMIUM, STANDARD. If not specified, then the current
    /// project-level default tier is used. Possible values: [&amp;quot;PREMIUM&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    public TerraformValue<string> AutoNetworkTier
    {
        get => GetArgument<TerraformValue<string>>("auto_network_tier") ?? CreateReference("auto_network_tier");
        set => SetArgument("auto_network_tier", value);
    }

    /// <summary>
    /// A list of URLs of the IP resources to be drained. These IPs must be
    /// valid static external IPs that have been assigned to the NAT.
    /// </summary>
    public TerraformSet<string> DrainNatIps
    {
        get => GetArgument<TerraformSet<string>>("drain_nat_ips") ?? CreateReference("drain_nat_ips");
        set => SetArgument("drain_nat_ips", value);
    }

    /// <summary>
    /// Enable Dynamic Port Allocation.
    /// If minPortsPerVm is set, minPortsPerVm must be set to a power of two greater than or equal to 32.
    /// If minPortsPerVm is not set, a minimum of 32 ports will be allocated to a VM from this NAT config.
    /// If maxPortsPerVm is set, maxPortsPerVm must be set to a power of two greater than minPortsPerVm.
    /// If maxPortsPerVm is not set, a maximum of 65536 ports will be allocated to a VM from this NAT config.
    /// 
    /// Mutually exclusive with enableEndpointIndependentMapping.
    /// </summary>
    public TerraformValue<bool> EnableDynamicPortAllocation
    {
        get => GetArgument<TerraformValue<bool>>("enable_dynamic_port_allocation") ?? CreateReference("enable_dynamic_port_allocation");
        set => SetArgument("enable_dynamic_port_allocation", value);
    }

    /// <summary>
    /// Enable endpoint independent mapping.
    /// For more information see the [official documentation](https://cloud.google.com/nat/docs/overview#specs-rfcs).
    /// </summary>
    public TerraformValue<bool> EnableEndpointIndependentMapping
    {
        get => GetArgument<TerraformValue<bool>>("enable_endpoint_independent_mapping") ?? CreateReference("enable_endpoint_independent_mapping");
        set => SetArgument("enable_endpoint_independent_mapping", value);
    }

    /// <summary>
    /// Specifies the endpoint Types supported by the NAT Gateway.
    /// Supported values include:
    ///       &#39;ENDPOINT_TYPE_VM&#39;, &#39;ENDPOINT_TYPE_SWG&#39;,
    ///       &#39;ENDPOINT_TYPE_MANAGED_PROXY_LB&#39;.
    /// </summary>
    public TerraformList<string> EndpointTypes
    {
        get => GetArgument<TerraformList<string>>("endpoint_types") ?? CreateReference("endpoint_types");
        set => SetArgument("endpoint_types", value);
    }

    /// <summary>
    /// Timeout (in seconds) for ICMP connections. Defaults to 30s if not set.
    /// </summary>
    public TerraformValue<double>? IcmpIdleTimeoutSec
    {
        get => GetArgument<TerraformValue<double>>("icmp_idle_timeout_sec");
        set => SetArgument("icmp_idle_timeout_sec", value);
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
    /// Self-links of NAT IPs to be used as initial value for creation alongside a RouterNatAddress resource.
    /// Conflicts with natIps and drainNatIps. Only valid if natIpAllocateOption is set to MANUAL_ONLY.
    /// </summary>
    public TerraformSet<string>? InitialNatIps
    {
        get => GetArgument<TerraformSet<string>>("initial_nat_ips");
        set => SetArgument("initial_nat_ips", value);
    }

    /// <summary>
    /// Maximum number of ports allocated to a VM from this NAT.
    /// This field can only be set when enableDynamicPortAllocation is enabled.
    /// </summary>
    public TerraformValue<double>? MaxPortsPerVm
    {
        get => GetArgument<TerraformValue<double>>("max_ports_per_vm");
        set => SetArgument("max_ports_per_vm", value);
    }

    /// <summary>
    /// Minimum number of ports allocated to a VM from this NAT. Defaults to 64 for static port allocation and 32 dynamic port allocation if not set.
    /// </summary>
    public TerraformValue<double> MinPortsPerVm
    {
        get => GetArgument<TerraformValue<double>>("min_ports_per_vm") ?? CreateReference("min_ports_per_vm");
        set => SetArgument("min_ports_per_vm", value);
    }

    /// <summary>
    /// Name of the NAT service. The name must be 1-63 characters long and
    /// comply with RFC1035.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// How external IPs should be allocated for this NAT. Valid values are
    /// &#39;AUTO_ONLY&#39; for only allowing NAT IPs allocated by Google Cloud
    /// Platform, or &#39;MANUAL_ONLY&#39; for only user-allocated NAT IP addresses. Possible values: [&amp;quot;MANUAL_ONLY&amp;quot;, &amp;quot;AUTO_ONLY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? NatIpAllocateOption
    {
        get => GetArgument<TerraformValue<string>>("nat_ip_allocate_option");
        set => SetArgument("nat_ip_allocate_option", value);
    }

    /// <summary>
    /// Self-links of NAT IPs. Only valid if natIpAllocateOption
    /// is set to MANUAL_ONLY.
    /// If this field is used alongside with a count created list of address resources &#39;google_compute_address.foobar.*.self_link&#39;,
    /// the access level resource for the address resource must have a &#39;lifecycle&#39; block with &#39;create_before_destroy = true&#39; so
    /// the number of resources can be increased/decreased without triggering the &#39;resourceInUseByAnotherResource&#39; error.
    /// </summary>
    public TerraformSet<string> NatIps
    {
        get => GetArgument<TerraformSet<string>>("nat_ips") ?? CreateReference("nat_ips");
        set => SetArgument("nat_ips", value);
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
    /// Region where the router and NAT reside.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The name of the Cloud Router in which this NAT will be configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Router is required")]
    public required TerraformValue<string> Router
    {
        get => GetRequiredArgument<TerraformValue<string>>("router");
        set => SetArgument("router", value);
    }

    /// <summary>
    /// How NAT should be configured per Subnetwork.
    /// If &#39;ALL_SUBNETWORKS_ALL_IP_RANGES&#39;, all of the
    /// IP ranges in every Subnetwork are allowed to Nat.
    /// If &#39;ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES&#39;, all of the primary IP
    /// ranges in every Subnetwork are allowed to Nat.
    /// &#39;LIST_OF_SUBNETWORKS&#39;: A list of Subnetworks are allowed to Nat
    /// (specified in the field subnetwork below). Note that if this field
    /// contains ALL_SUBNETWORKS_ALL_IP_RANGES or
    /// ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES, then there should not be any
    /// other RouterNat section in any Router for this network in this region. Possible values: [&amp;quot;ALL_SUBNETWORKS_ALL_IP_RANGES&amp;quot;, &amp;quot;ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES&amp;quot;, &amp;quot;LIST_OF_SUBNETWORKS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceSubnetworkIpRangesToNat is required")]
    public required TerraformValue<string> SourceSubnetworkIpRangesToNat
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_subnetwork_ip_ranges_to_nat");
        set => SetArgument("source_subnetwork_ip_ranges_to_nat", value);
    }

    /// <summary>
    /// Specify the Nat option for NAT64, which can take one of the following values:
    /// ALL_IPV6_SUBNETWORKS: All of the IP ranges in every Subnetwork are allowed to Nat.
    /// LIST_OF_IPV6_SUBNETWORKS: A list of Subnetworks are allowed to Nat (specified in the field nat64Subnetwork below).
    /// Note that if this field contains NAT64_ALL_V6_SUBNETWORKS no other Router.Nat section in this region can also enable NAT64 for any Subnetworks in this network.
    /// Other Router.Nat sections can still be present to enable NAT44 only. Possible values: [&amp;quot;ALL_IPV6_SUBNETWORKS&amp;quot;, &amp;quot;LIST_OF_IPV6_SUBNETWORKS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? SourceSubnetworkIpRangesToNat64
    {
        get => GetArgument<TerraformValue<string>>("source_subnetwork_ip_ranges_to_nat64");
        set => SetArgument("source_subnetwork_ip_ranges_to_nat64", value);
    }

    /// <summary>
    /// Timeout (in seconds) for TCP established connections.
    /// Defaults to 1200s if not set.
    /// </summary>
    public TerraformValue<double>? TcpEstablishedIdleTimeoutSec
    {
        get => GetArgument<TerraformValue<double>>("tcp_established_idle_timeout_sec");
        set => SetArgument("tcp_established_idle_timeout_sec", value);
    }

    /// <summary>
    /// Timeout (in seconds) for TCP connections that are in TIME_WAIT state.
    /// Defaults to 120s if not set.
    /// </summary>
    public TerraformValue<double>? TcpTimeWaitTimeoutSec
    {
        get => GetArgument<TerraformValue<double>>("tcp_time_wait_timeout_sec");
        set => SetArgument("tcp_time_wait_timeout_sec", value);
    }

    /// <summary>
    /// Timeout (in seconds) for TCP transitory connections.
    /// Defaults to 30s if not set.
    /// </summary>
    public TerraformValue<double>? TcpTransitoryIdleTimeoutSec
    {
        get => GetArgument<TerraformValue<double>>("tcp_transitory_idle_timeout_sec");
        set => SetArgument("tcp_transitory_idle_timeout_sec", value);
    }

    /// <summary>
    /// Indicates whether this NAT is used for public or private IP translation.
    /// If unspecified, it defaults to PUBLIC.
    /// If &#39;PUBLIC&#39; NAT used for public IP translation.
    /// If &#39;PRIVATE&#39; NAT used for private IP translation. Default value: &amp;quot;PUBLIC&amp;quot; Possible values: [&amp;quot;PUBLIC&amp;quot;, &amp;quot;PRIVATE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Timeout (in seconds) for UDP connections. Defaults to 30s if not set.
    /// </summary>
    public TerraformValue<double>? UdpIdleTimeoutSec
    {
        get => GetArgument<TerraformValue<double>>("udp_idle_timeout_sec");
        set => SetArgument("udp_idle_timeout_sec", value);
    }

    /// <summary>
    /// LogConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    public TerraformList<GoogleComputeRouterNatLogConfigBlock>? LogConfig
    {
        get => GetArgument<TerraformList<GoogleComputeRouterNatLogConfigBlock>>("log_config");
        set => SetArgument("log_config", value);
    }

    /// <summary>
    /// Nat64Subnetwork block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeRouterNatNat64SubnetworkBlock>? Nat64Subnetwork
    {
        get => GetArgument<TerraformSet<GoogleComputeRouterNatNat64SubnetworkBlock>>("nat64_subnetwork");
        set => SetArgument("nat64_subnetwork", value);
    }

    /// <summary>
    /// Rules block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeRouterNatRulesBlock>? Rules
    {
        get => GetArgument<TerraformSet<GoogleComputeRouterNatRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

    /// <summary>
    /// Subnetwork block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeRouterNatSubnetworkBlock>? Subnetwork
    {
        get => GetArgument<TerraformSet<GoogleComputeRouterNatSubnetworkBlock>>("subnetwork");
        set => SetArgument("subnetwork", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeRouterNatTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeRouterNatTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
