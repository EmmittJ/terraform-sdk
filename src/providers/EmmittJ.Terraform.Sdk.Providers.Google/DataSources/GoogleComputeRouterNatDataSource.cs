using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_router_nat.
/// </summary>
public class GoogleComputeRouterNatDataSource : TerraformDataSource
{
    public GoogleComputeRouterNatDataSource(string name) : base("google_compute_router_nat", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Name of the NAT service. The name must be 1-63 characters long and
    /// comply with RFC1035.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// Region where the router and NAT reside.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Region { get; set; }

    /// <summary>
    /// The name of the Cloud Router in which this NAT will be configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Router is required")]
    [TerraformPropertyName("router")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Router { get; set; }

    /// <summary>
    /// The network tier to use when automatically reserving NAT IP addresses.
    /// Must be one of: PREMIUM, STANDARD. If not specified, then the current
    /// project-level default tier is used. Possible values: [&amp;quot;PREMIUM&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    [TerraformPropertyName("auto_network_tier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AutoNetworkTier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "auto_network_tier");

    /// <summary>
    /// A list of URLs of the IP resources to be drained. These IPs must be
    /// valid static external IPs that have been assigned to the NAT.
    /// </summary>
    [TerraformPropertyName("drain_nat_ips")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> DrainNatIps => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "drain_nat_ips");

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
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableDynamicPortAllocation => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_dynamic_port_allocation");

    /// <summary>
    /// Enable endpoint independent mapping.
    /// For more information see the [official documentation](https://cloud.google.com/nat/docs/overview#specs-rfcs).
    /// </summary>
    [TerraformPropertyName("enable_endpoint_independent_mapping")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableEndpointIndependentMapping => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_endpoint_independent_mapping");

    /// <summary>
    /// Specifies the endpoint Types supported by the NAT Gateway.
    /// Supported values include:
    ///       &#39;ENDPOINT_TYPE_VM&#39;, &#39;ENDPOINT_TYPE_SWG&#39;,
    ///       &#39;ENDPOINT_TYPE_MANAGED_PROXY_LB&#39;.
    /// </summary>
    [TerraformPropertyName("endpoint_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> EndpointTypes => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "endpoint_types");

    /// <summary>
    /// Timeout (in seconds) for ICMP connections. Defaults to 30s if not set.
    /// </summary>
    [TerraformPropertyName("icmp_idle_timeout_sec")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> IcmpIdleTimeoutSec => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "icmp_idle_timeout_sec");

    /// <summary>
    /// Self-links of NAT IPs to be used as initial value for creation alongside a RouterNatAddress resource.
    /// Conflicts with natIps and drainNatIps. Only valid if natIpAllocateOption is set to MANUAL_ONLY.
    /// </summary>
    [TerraformPropertyName("initial_nat_ips")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> InitialNatIps => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "initial_nat_ips");

    /// <summary>
    /// Configuration for logging on NAT
    /// </summary>
    [TerraformPropertyName("log_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LogConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "log_config");

    /// <summary>
    /// Maximum number of ports allocated to a VM from this NAT.
    /// This field can only be set when enableDynamicPortAllocation is enabled.
    /// </summary>
    [TerraformPropertyName("max_ports_per_vm")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxPortsPerVm => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_ports_per_vm");

    /// <summary>
    /// Minimum number of ports allocated to a VM from this NAT. Defaults to 64 for static port allocation and 32 dynamic port allocation if not set.
    /// </summary>
    [TerraformPropertyName("min_ports_per_vm")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MinPortsPerVm => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "min_ports_per_vm");

    /// <summary>
    /// One or more subnetwork NAT configurations whose traffic should be translated by NAT64 Gateway.
    /// Only used if &#39;source_subnetwork_ip_ranges_to_nat64&#39; is set to &#39;LIST_OF_IPV6_SUBNETWORKS&#39;
    /// </summary>
    [TerraformPropertyName("nat64_subnetwork")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Nat64Subnetwork => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "nat64_subnetwork");

    /// <summary>
    /// How external IPs should be allocated for this NAT. Valid values are
    /// &#39;AUTO_ONLY&#39; for only allowing NAT IPs allocated by Google Cloud
    /// Platform, or &#39;MANUAL_ONLY&#39; for only user-allocated NAT IP addresses. Possible values: [&amp;quot;MANUAL_ONLY&amp;quot;, &amp;quot;AUTO_ONLY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("nat_ip_allocate_option")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NatIpAllocateOption => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "nat_ip_allocate_option");

    /// <summary>
    /// Self-links of NAT IPs. Only valid if natIpAllocateOption
    /// is set to MANUAL_ONLY.
    /// If this field is used alongside with a count created list of address resources &#39;google_compute_address.foobar.*.self_link&#39;,
    /// the access level resource for the address resource must have a &#39;lifecycle&#39; block with &#39;create_before_destroy = true&#39; so
    /// the number of resources can be increased/decreased without triggering the &#39;resourceInUseByAnotherResource&#39; error.
    /// </summary>
    [TerraformPropertyName("nat_ips")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> NatIps => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "nat_ips");

    /// <summary>
    /// A list of rules associated with this NAT.
    /// </summary>
    [TerraformPropertyName("rules")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Rules => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "rules");

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
    [TerraformPropertyName("source_subnetwork_ip_ranges_to_nat")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceSubnetworkIpRangesToNat => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_subnetwork_ip_ranges_to_nat");

    /// <summary>
    /// Specify the Nat option for NAT64, which can take one of the following values:
    /// ALL_IPV6_SUBNETWORKS: All of the IP ranges in every Subnetwork are allowed to Nat.
    /// LIST_OF_IPV6_SUBNETWORKS: A list of Subnetworks are allowed to Nat (specified in the field nat64Subnetwork below).
    /// Note that if this field contains NAT64_ALL_V6_SUBNETWORKS no other Router.Nat section in this region can also enable NAT64 for any Subnetworks in this network.
    /// Other Router.Nat sections can still be present to enable NAT44 only. Possible values: [&amp;quot;ALL_IPV6_SUBNETWORKS&amp;quot;, &amp;quot;LIST_OF_IPV6_SUBNETWORKS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("source_subnetwork_ip_ranges_to_nat64")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceSubnetworkIpRangesToNat64 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_subnetwork_ip_ranges_to_nat64");

    /// <summary>
    /// One or more subnetwork NAT configurations. Only used if
    /// &#39;source_subnetwork_ip_ranges_to_nat&#39; is set to &#39;LIST_OF_SUBNETWORKS&#39;
    /// </summary>
    [TerraformPropertyName("subnetwork")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Subnetwork => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "subnetwork");

    /// <summary>
    /// Timeout (in seconds) for TCP established connections.
    /// Defaults to 1200s if not set.
    /// </summary>
    [TerraformPropertyName("tcp_established_idle_timeout_sec")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TcpEstablishedIdleTimeoutSec => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "tcp_established_idle_timeout_sec");

    /// <summary>
    /// Timeout (in seconds) for TCP connections that are in TIME_WAIT state.
    /// Defaults to 120s if not set.
    /// </summary>
    [TerraformPropertyName("tcp_time_wait_timeout_sec")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TcpTimeWaitTimeoutSec => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "tcp_time_wait_timeout_sec");

    /// <summary>
    /// Timeout (in seconds) for TCP transitory connections.
    /// Defaults to 30s if not set.
    /// </summary>
    [TerraformPropertyName("tcp_transitory_idle_timeout_sec")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TcpTransitoryIdleTimeoutSec => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "tcp_transitory_idle_timeout_sec");

    /// <summary>
    /// Indicates whether this NAT is used for public or private IP translation.
    /// If unspecified, it defaults to PUBLIC.
    /// If &#39;PUBLIC&#39; NAT used for public IP translation.
    /// If &#39;PRIVATE&#39; NAT used for private IP translation. Default value: &amp;quot;PUBLIC&amp;quot; Possible values: [&amp;quot;PUBLIC&amp;quot;, &amp;quot;PRIVATE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// Timeout (in seconds) for UDP connections. Defaults to 30s if not set.
    /// </summary>
    [TerraformPropertyName("udp_idle_timeout_sec")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> UdpIdleTimeoutSec => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "udp_idle_timeout_sec");

}
