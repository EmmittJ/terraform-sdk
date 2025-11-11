using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for log_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterNatLogConfigBlock
{
    /// <summary>
    /// Indicates whether or not to export logs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enable is required")]
    [TerraformPropertyName("enable")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enable { get; set; }

    /// <summary>
    /// Specifies the desired filtering of logs on this NAT. Possible values: [&amp;quot;ERRORS_ONLY&amp;quot;, &amp;quot;TRANSLATIONS_ONLY&amp;quot;, &amp;quot;ALL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [TerraformPropertyName("filter")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Filter { get; set; }

}

/// <summary>
/// Block type for nat64_subnetwork in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeRouterNatNat64SubnetworkBlock
{
    /// <summary>
    /// Self-link of the subnetwork resource that will use NAT64
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for rules in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeRouterNatRulesBlock
{
    /// <summary>
    /// An optional description of this rule.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

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
    [TerraformPropertyName("match")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Match { get; set; }

    /// <summary>
    /// An integer uniquely identifying a rule in the list.
    /// The rule number must be a positive value between 0 and 65000, and must be unique among rules within a NAT.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNumber is required")]
    [TerraformPropertyName("rule_number")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> RuleNumber { get; set; }

}

/// <summary>
/// Block type for subnetwork in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeRouterNatSubnetworkBlock
{
    /// <summary>
    /// Self-link of subnetwork to NAT
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// List of the secondary ranges of the subnetwork that are allowed
    /// to use NAT. This can be populated only if
    /// &#39;LIST_OF_SECONDARY_IP_RANGES&#39; is one of the values in
    /// sourceIpRangesToNat
    /// </summary>
    [TerraformPropertyName("secondary_ip_range_names")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SecondaryIpRangeNames { get; set; }

    /// <summary>
    /// List of options for which source IPs in the subnetwork
    /// should have NAT enabled. Supported values include:
    /// &#39;ALL_IP_RANGES&#39;, &#39;LIST_OF_SECONDARY_IP_RANGES&#39;,
    /// &#39;PRIMARY_IP_RANGE&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceIpRangesToNat is required")]
    [TerraformPropertyName("source_ip_ranges_to_nat")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> SourceIpRangesToNat { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRouterNatTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_router_nat resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeRouterNat : TerraformResource
{
    public GoogleComputeRouterNat(string name) : base("google_compute_router_nat", name)
    {
    }

    /// <summary>
    /// The network tier to use when automatically reserving NAT IP addresses.
    /// Must be one of: PREMIUM, STANDARD. If not specified, then the current
    /// project-level default tier is used. Possible values: [&amp;quot;PREMIUM&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    [TerraformPropertyName("auto_network_tier")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AutoNetworkTier { get; set; } = default!;

    /// <summary>
    /// A list of URLs of the IP resources to be drained. These IPs must be
    /// valid static external IPs that have been assigned to the NAT.
    /// </summary>
    [TerraformPropertyName("drain_nat_ips")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> DrainNatIps { get; set; } = default!;

    /// <summary>
    /// Enable Dynamic Port Allocation.
    /// If minPortsPerVm is set, minPortsPerVm must be set to a power of two greater than or equal to 32.
    /// If minPortsPerVm is not set, a minimum of 32 ports will be allocated to a VM from this NAT config.
    /// If maxPortsPerVm is set, maxPortsPerVm must be set to a power of two greater than minPortsPerVm.
    /// If maxPortsPerVm is not set, a maximum of 65536 ports will be allocated to a VM from this NAT config.
    /// 
    /// Mutually exclusive with enableEndpointIndependentMapping.
    /// </summary>
    [TerraformPropertyName("enable_dynamic_port_allocation")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableDynamicPortAllocation { get; set; } = default!;

    /// <summary>
    /// Enable endpoint independent mapping.
    /// For more information see the [official documentation](https://cloud.google.com/nat/docs/overview#specs-rfcs).
    /// </summary>
    [TerraformPropertyName("enable_endpoint_independent_mapping")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableEndpointIndependentMapping { get; set; } = default!;

    /// <summary>
    /// Specifies the endpoint Types supported by the NAT Gateway.
    /// Supported values include:
    ///       &#39;ENDPOINT_TYPE_VM&#39;, &#39;ENDPOINT_TYPE_SWG&#39;,
    ///       &#39;ENDPOINT_TYPE_MANAGED_PROXY_LB&#39;.
    /// </summary>
    [TerraformPropertyName("endpoint_types")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> EndpointTypes { get; set; } = default!;

    /// <summary>
    /// Timeout (in seconds) for ICMP connections. Defaults to 30s if not set.
    /// </summary>
    [TerraformPropertyName("icmp_idle_timeout_sec")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? IcmpIdleTimeoutSec { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Self-links of NAT IPs to be used as initial value for creation alongside a RouterNatAddress resource.
    /// Conflicts with natIps and drainNatIps. Only valid if natIpAllocateOption is set to MANUAL_ONLY.
    /// </summary>
    [TerraformPropertyName("initial_nat_ips")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? InitialNatIps { get; set; }

    /// <summary>
    /// Maximum number of ports allocated to a VM from this NAT.
    /// This field can only be set when enableDynamicPortAllocation is enabled.
    /// </summary>
    [TerraformPropertyName("max_ports_per_vm")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxPortsPerVm { get; set; }

    /// <summary>
    /// Minimum number of ports allocated to a VM from this NAT. Defaults to 64 for static port allocation and 32 dynamic port allocation if not set.
    /// </summary>
    [TerraformPropertyName("min_ports_per_vm")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MinPortsPerVm { get; set; } = default!;

    /// <summary>
    /// Name of the NAT service. The name must be 1-63 characters long and
    /// comply with RFC1035.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// How external IPs should be allocated for this NAT. Valid values are
    /// &#39;AUTO_ONLY&#39; for only allowing NAT IPs allocated by Google Cloud
    /// Platform, or &#39;MANUAL_ONLY&#39; for only user-allocated NAT IP addresses. Possible values: [&amp;quot;MANUAL_ONLY&amp;quot;, &amp;quot;AUTO_ONLY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("nat_ip_allocate_option")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NatIpAllocateOption { get; set; }

    /// <summary>
    /// Self-links of NAT IPs. Only valid if natIpAllocateOption
    /// is set to MANUAL_ONLY.
    /// If this field is used alongside with a count created list of address resources &#39;google_compute_address.foobar.*.self_link&#39;,
    /// the access level resource for the address resource must have a &#39;lifecycle&#39; block with &#39;create_before_destroy = true&#39; so
    /// the number of resources can be increased/decreased without triggering the &#39;resourceInUseByAnotherResource&#39; error.
    /// </summary>
    [TerraformPropertyName("nat_ips")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> NatIps { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Region where the router and NAT reside.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The name of the Cloud Router in which this NAT will be configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Router is required")]
    [TerraformPropertyName("router")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Router { get; set; }

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
    [TerraformPropertyName("source_subnetwork_ip_ranges_to_nat")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceSubnetworkIpRangesToNat { get; set; }

    /// <summary>
    /// Specify the Nat option for NAT64, which can take one of the following values:
    /// ALL_IPV6_SUBNETWORKS: All of the IP ranges in every Subnetwork are allowed to Nat.
    /// LIST_OF_IPV6_SUBNETWORKS: A list of Subnetworks are allowed to Nat (specified in the field nat64Subnetwork below).
    /// Note that if this field contains NAT64_ALL_V6_SUBNETWORKS no other Router.Nat section in this region can also enable NAT64 for any Subnetworks in this network.
    /// Other Router.Nat sections can still be present to enable NAT44 only. Possible values: [&amp;quot;ALL_IPV6_SUBNETWORKS&amp;quot;, &amp;quot;LIST_OF_IPV6_SUBNETWORKS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("source_subnetwork_ip_ranges_to_nat64")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceSubnetworkIpRangesToNat64 { get; set; }

    /// <summary>
    /// Timeout (in seconds) for TCP established connections.
    /// Defaults to 1200s if not set.
    /// </summary>
    [TerraformPropertyName("tcp_established_idle_timeout_sec")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TcpEstablishedIdleTimeoutSec { get; set; }

    /// <summary>
    /// Timeout (in seconds) for TCP connections that are in TIME_WAIT state.
    /// Defaults to 120s if not set.
    /// </summary>
    [TerraformPropertyName("tcp_time_wait_timeout_sec")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TcpTimeWaitTimeoutSec { get; set; }

    /// <summary>
    /// Timeout (in seconds) for TCP transitory connections.
    /// Defaults to 30s if not set.
    /// </summary>
    [TerraformPropertyName("tcp_transitory_idle_timeout_sec")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TcpTransitoryIdleTimeoutSec { get; set; }

    /// <summary>
    /// Indicates whether this NAT is used for public or private IP translation.
    /// If unspecified, it defaults to PUBLIC.
    /// If &#39;PUBLIC&#39; NAT used for public IP translation.
    /// If &#39;PRIVATE&#39; NAT used for private IP translation. Default value: &amp;quot;PUBLIC&amp;quot; Possible values: [&amp;quot;PUBLIC&amp;quot;, &amp;quot;PRIVATE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// Timeout (in seconds) for UDP connections. Defaults to 30s if not set.
    /// </summary>
    [TerraformPropertyName("udp_idle_timeout_sec")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? UdpIdleTimeoutSec { get; set; }

    /// <summary>
    /// Block for log_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    [TerraformPropertyName("log_config")]
    public TerraformList<TerraformBlock<GoogleComputeRouterNatLogConfigBlock>>? LogConfig { get; set; }

    /// <summary>
    /// Block for nat64_subnetwork.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("nat64_subnetwork")]
    public TerraformSet<TerraformBlock<GoogleComputeRouterNatNat64SubnetworkBlock>>? Nat64Subnetwork { get; set; }

    /// <summary>
    /// Block for rules.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("rules")]
    public TerraformSet<TerraformBlock<GoogleComputeRouterNatRulesBlock>>? Rules { get; set; }

    /// <summary>
    /// Block for subnetwork.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("subnetwork")]
    public TerraformSet<TerraformBlock<GoogleComputeRouterNatSubnetworkBlock>>? Subnetwork { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeRouterNatTimeoutsBlock>? Timeouts { get; set; }

}
