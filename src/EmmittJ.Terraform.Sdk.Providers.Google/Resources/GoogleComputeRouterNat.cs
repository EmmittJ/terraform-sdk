using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for log_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterNatLogConfigBlock : TerraformBlock
{
    /// <summary>
    /// Indicates whether or not to export logs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enable is required")]
    public required TerraformProperty<bool> Enable
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("enable");
        set => WithProperty("enable", value);
    }

    /// <summary>
    /// Specifies the desired filtering of logs on this NAT. Possible values: [&amp;quot;ERRORS_ONLY&amp;quot;, &amp;quot;TRANSLATIONS_ONLY&amp;quot;, &amp;quot;ALL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformProperty<string> Filter
    {
        get => GetRequiredProperty<TerraformProperty<string>>("filter");
        set => WithProperty("filter", value);
    }

}

/// <summary>
/// Block type for nat64_subnetwork in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeRouterNatNat64SubnetworkBlock : TerraformBlock
{
    /// <summary>
    /// Self-link of the subnetwork resource that will use NAT64
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for rules in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeRouterNatRulesBlock : TerraformBlock
{
    /// <summary>
    /// An optional description of this rule.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
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
    public required TerraformProperty<string> Match
    {
        get => GetRequiredProperty<TerraformProperty<string>>("match");
        set => WithProperty("match", value);
    }

    /// <summary>
    /// An integer uniquely identifying a rule in the list.
    /// The rule number must be a positive value between 0 and 65000, and must be unique among rules within a NAT.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNumber is required")]
    public required TerraformProperty<double> RuleNumber
    {
        get => GetRequiredProperty<TerraformProperty<double>>("rule_number");
        set => WithProperty("rule_number", value);
    }

}

/// <summary>
/// Block type for subnetwork in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeRouterNatSubnetworkBlock : TerraformBlock
{
    /// <summary>
    /// Self-link of subnetwork to NAT
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// List of the secondary ranges of the subnetwork that are allowed
    /// to use NAT. This can be populated only if
    /// &#39;LIST_OF_SECONDARY_IP_RANGES&#39; is one of the values in
    /// sourceIpRangesToNat
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecondaryIpRangeNames
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("secondary_ip_range_names");
        set => WithProperty("secondary_ip_range_names", value);
    }

    /// <summary>
    /// List of options for which source IPs in the subnetwork
    /// should have NAT enabled. Supported values include:
    /// &#39;ALL_IP_RANGES&#39;, &#39;LIST_OF_SECONDARY_IP_RANGES&#39;,
    /// &#39;PRIMARY_IP_RANGE&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceIpRangesToNat is required")]
    public HashSet<TerraformProperty<string>>? SourceIpRangesToNat
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("source_ip_ranges_to_nat");
        set => WithProperty("source_ip_ranges_to_nat", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRouterNatTimeoutsBlock : TerraformBlock
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
/// Manages a google_compute_router_nat resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeRouterNat : TerraformResource
{
    public GoogleComputeRouterNat(string name) : base("google_compute_router_nat", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The network tier to use when automatically reserving NAT IP addresses.
    /// Must be one of: PREMIUM, STANDARD. If not specified, then the current
    /// project-level default tier is used. Possible values: [&amp;quot;PREMIUM&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? AutoNetworkTier
    {
        get => GetProperty<TerraformProperty<string>>("auto_network_tier");
        set => this.WithProperty("auto_network_tier", value);
    }

    /// <summary>
    /// A list of URLs of the IP resources to be drained. These IPs must be
    /// valid static external IPs that have been assigned to the NAT.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DrainNatIps
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("drain_nat_ips");
        set => this.WithProperty("drain_nat_ips", value);
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
    public TerraformProperty<bool>? EnableDynamicPortAllocation
    {
        get => GetProperty<TerraformProperty<bool>>("enable_dynamic_port_allocation");
        set => this.WithProperty("enable_dynamic_port_allocation", value);
    }

    /// <summary>
    /// Enable endpoint independent mapping.
    /// For more information see the [official documentation](https://cloud.google.com/nat/docs/overview#specs-rfcs).
    /// </summary>
    public TerraformProperty<bool>? EnableEndpointIndependentMapping
    {
        get => GetProperty<TerraformProperty<bool>>("enable_endpoint_independent_mapping");
        set => this.WithProperty("enable_endpoint_independent_mapping", value);
    }

    /// <summary>
    /// Specifies the endpoint Types supported by the NAT Gateway.
    /// Supported values include:
    ///       &#39;ENDPOINT_TYPE_VM&#39;, &#39;ENDPOINT_TYPE_SWG&#39;,
    ///       &#39;ENDPOINT_TYPE_MANAGED_PROXY_LB&#39;.
    /// </summary>
    public List<TerraformProperty<string>>? EndpointTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("endpoint_types");
        set => this.WithProperty("endpoint_types", value);
    }

    /// <summary>
    /// Timeout (in seconds) for ICMP connections. Defaults to 30s if not set.
    /// </summary>
    public TerraformProperty<double>? IcmpIdleTimeoutSec
    {
        get => GetProperty<TerraformProperty<double>>("icmp_idle_timeout_sec");
        set => this.WithProperty("icmp_idle_timeout_sec", value);
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
    /// Self-links of NAT IPs to be used as initial value for creation alongside a RouterNatAddress resource.
    /// Conflicts with natIps and drainNatIps. Only valid if natIpAllocateOption is set to MANUAL_ONLY.
    /// </summary>
    public HashSet<TerraformProperty<string>>? InitialNatIps
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("initial_nat_ips");
        set => this.WithProperty("initial_nat_ips", value);
    }

    /// <summary>
    /// Maximum number of ports allocated to a VM from this NAT.
    /// This field can only be set when enableDynamicPortAllocation is enabled.
    /// </summary>
    public TerraformProperty<double>? MaxPortsPerVm
    {
        get => GetProperty<TerraformProperty<double>>("max_ports_per_vm");
        set => this.WithProperty("max_ports_per_vm", value);
    }

    /// <summary>
    /// Minimum number of ports allocated to a VM from this NAT. Defaults to 64 for static port allocation and 32 dynamic port allocation if not set.
    /// </summary>
    public TerraformProperty<double>? MinPortsPerVm
    {
        get => GetProperty<TerraformProperty<double>>("min_ports_per_vm");
        set => this.WithProperty("min_ports_per_vm", value);
    }

    /// <summary>
    /// Name of the NAT service. The name must be 1-63 characters long and
    /// comply with RFC1035.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// How external IPs should be allocated for this NAT. Valid values are
    /// &#39;AUTO_ONLY&#39; for only allowing NAT IPs allocated by Google Cloud
    /// Platform, or &#39;MANUAL_ONLY&#39; for only user-allocated NAT IP addresses. Possible values: [&amp;quot;MANUAL_ONLY&amp;quot;, &amp;quot;AUTO_ONLY&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? NatIpAllocateOption
    {
        get => GetProperty<TerraformProperty<string>>("nat_ip_allocate_option");
        set => this.WithProperty("nat_ip_allocate_option", value);
    }

    /// <summary>
    /// Self-links of NAT IPs. Only valid if natIpAllocateOption
    /// is set to MANUAL_ONLY.
    /// If this field is used alongside with a count created list of address resources &#39;google_compute_address.foobar.*.self_link&#39;,
    /// the access level resource for the address resource must have a &#39;lifecycle&#39; block with &#39;create_before_destroy = true&#39; so
    /// the number of resources can be increased/decreased without triggering the &#39;resourceInUseByAnotherResource&#39; error.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NatIps
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("nat_ips");
        set => this.WithProperty("nat_ips", value);
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
    /// Region where the router and NAT reside.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The name of the Cloud Router in which this NAT will be configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Router is required")]
    public required TerraformProperty<string> Router
    {
        get => GetRequiredProperty<TerraformProperty<string>>("router");
        set => this.WithProperty("router", value);
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
    public required TerraformProperty<string> SourceSubnetworkIpRangesToNat
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source_subnetwork_ip_ranges_to_nat");
        set => this.WithProperty("source_subnetwork_ip_ranges_to_nat", value);
    }

    /// <summary>
    /// Specify the Nat option for NAT64, which can take one of the following values:
    /// ALL_IPV6_SUBNETWORKS: All of the IP ranges in every Subnetwork are allowed to Nat.
    /// LIST_OF_IPV6_SUBNETWORKS: A list of Subnetworks are allowed to Nat (specified in the field nat64Subnetwork below).
    /// Note that if this field contains NAT64_ALL_V6_SUBNETWORKS no other Router.Nat section in this region can also enable NAT64 for any Subnetworks in this network.
    /// Other Router.Nat sections can still be present to enable NAT44 only. Possible values: [&amp;quot;ALL_IPV6_SUBNETWORKS&amp;quot;, &amp;quot;LIST_OF_IPV6_SUBNETWORKS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? SourceSubnetworkIpRangesToNat64
    {
        get => GetProperty<TerraformProperty<string>>("source_subnetwork_ip_ranges_to_nat64");
        set => this.WithProperty("source_subnetwork_ip_ranges_to_nat64", value);
    }

    /// <summary>
    /// Timeout (in seconds) for TCP established connections.
    /// Defaults to 1200s if not set.
    /// </summary>
    public TerraformProperty<double>? TcpEstablishedIdleTimeoutSec
    {
        get => GetProperty<TerraformProperty<double>>("tcp_established_idle_timeout_sec");
        set => this.WithProperty("tcp_established_idle_timeout_sec", value);
    }

    /// <summary>
    /// Timeout (in seconds) for TCP connections that are in TIME_WAIT state.
    /// Defaults to 120s if not set.
    /// </summary>
    public TerraformProperty<double>? TcpTimeWaitTimeoutSec
    {
        get => GetProperty<TerraformProperty<double>>("tcp_time_wait_timeout_sec");
        set => this.WithProperty("tcp_time_wait_timeout_sec", value);
    }

    /// <summary>
    /// Timeout (in seconds) for TCP transitory connections.
    /// Defaults to 30s if not set.
    /// </summary>
    public TerraformProperty<double>? TcpTransitoryIdleTimeoutSec
    {
        get => GetProperty<TerraformProperty<double>>("tcp_transitory_idle_timeout_sec");
        set => this.WithProperty("tcp_transitory_idle_timeout_sec", value);
    }

    /// <summary>
    /// Indicates whether this NAT is used for public or private IP translation.
    /// If unspecified, it defaults to PUBLIC.
    /// If &#39;PUBLIC&#39; NAT used for public IP translation.
    /// If &#39;PRIVATE&#39; NAT used for private IP translation. Default value: &amp;quot;PUBLIC&amp;quot; Possible values: [&amp;quot;PUBLIC&amp;quot;, &amp;quot;PRIVATE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Timeout (in seconds) for UDP connections. Defaults to 30s if not set.
    /// </summary>
    public TerraformProperty<double>? UdpIdleTimeoutSec
    {
        get => GetProperty<TerraformProperty<double>>("udp_idle_timeout_sec");
        set => this.WithProperty("udp_idle_timeout_sec", value);
    }

    /// <summary>
    /// Block for log_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    public List<GoogleComputeRouterNatLogConfigBlock>? LogConfig
    {
        get => GetProperty<List<GoogleComputeRouterNatLogConfigBlock>>("log_config");
        set => this.WithProperty("log_config", value);
    }

    /// <summary>
    /// Block for nat64_subnetwork.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleComputeRouterNatNat64SubnetworkBlock>? Nat64Subnetwork
    {
        get => GetProperty<HashSet<GoogleComputeRouterNatNat64SubnetworkBlock>>("nat64_subnetwork");
        set => this.WithProperty("nat64_subnetwork", value);
    }

    /// <summary>
    /// Block for rules.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleComputeRouterNatRulesBlock>? Rules
    {
        get => GetProperty<HashSet<GoogleComputeRouterNatRulesBlock>>("rules");
        set => this.WithProperty("rules", value);
    }

    /// <summary>
    /// Block for subnetwork.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleComputeRouterNatSubnetworkBlock>? Subnetwork
    {
        get => GetProperty<HashSet<GoogleComputeRouterNatSubnetworkBlock>>("subnetwork");
        set => this.WithProperty("subnetwork", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeRouterNatTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeRouterNatTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
