using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_router_nat resource.
/// </summary>
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
    public TerraformLiteralProperty<string>? AutoNetworkTier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auto_network_tier");
        set => this.WithProperty("auto_network_tier", value);
    }

    /// <summary>
    /// A list of URLs of the IP resources to be drained. These IPs must be
    /// valid static external IPs that have been assigned to the NAT.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? DrainNatIps
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("drain_nat_ips");
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
    public TerraformLiteralProperty<bool>? EnableDynamicPortAllocation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_dynamic_port_allocation");
        set => this.WithProperty("enable_dynamic_port_allocation", value);
    }

    /// <summary>
    /// Enable endpoint independent mapping.
    /// For more information see the [official documentation](https://cloud.google.com/nat/docs/overview#specs-rfcs).
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableEndpointIndependentMapping
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_endpoint_independent_mapping");
        set => this.WithProperty("enable_endpoint_independent_mapping", value);
    }

    /// <summary>
    /// Specifies the endpoint Types supported by the NAT Gateway.
    /// Supported values include:
    ///       &#39;ENDPOINT_TYPE_VM&#39;, &#39;ENDPOINT_TYPE_SWG&#39;,
    ///       &#39;ENDPOINT_TYPE_MANAGED_PROXY_LB&#39;.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? EndpointTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("endpoint_types");
        set => this.WithProperty("endpoint_types", value);
    }

    /// <summary>
    /// Timeout (in seconds) for ICMP connections. Defaults to 30s if not set.
    /// </summary>
    public TerraformLiteralProperty<double>? IcmpIdleTimeoutSec
    {
        get => GetProperty<TerraformLiteralProperty<double>>("icmp_idle_timeout_sec");
        set => this.WithProperty("icmp_idle_timeout_sec", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Self-links of NAT IPs to be used as initial value for creation alongside a RouterNatAddress resource.
    /// Conflicts with natIps and drainNatIps. Only valid if natIpAllocateOption is set to MANUAL_ONLY.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? InitialNatIps
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("initial_nat_ips");
        set => this.WithProperty("initial_nat_ips", value);
    }

    /// <summary>
    /// Maximum number of ports allocated to a VM from this NAT.
    /// This field can only be set when enableDynamicPortAllocation is enabled.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxPortsPerVm
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_ports_per_vm");
        set => this.WithProperty("max_ports_per_vm", value);
    }

    /// <summary>
    /// Minimum number of ports allocated to a VM from this NAT. Defaults to 64 for static port allocation and 32 dynamic port allocation if not set.
    /// </summary>
    public TerraformLiteralProperty<double>? MinPortsPerVm
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_ports_per_vm");
        set => this.WithProperty("min_ports_per_vm", value);
    }

    /// <summary>
    /// Name of the NAT service. The name must be 1-63 characters long and
    /// comply with RFC1035.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// How external IPs should be allocated for this NAT. Valid values are
    /// &#39;AUTO_ONLY&#39; for only allowing NAT IPs allocated by Google Cloud
    /// Platform, or &#39;MANUAL_ONLY&#39; for only user-allocated NAT IP addresses. Possible values: [&amp;quot;MANUAL_ONLY&amp;quot;, &amp;quot;AUTO_ONLY&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? NatIpAllocateOption
    {
        get => GetProperty<TerraformLiteralProperty<string>>("nat_ip_allocate_option");
        set => this.WithProperty("nat_ip_allocate_option", value);
    }

    /// <summary>
    /// Self-links of NAT IPs. Only valid if natIpAllocateOption
    /// is set to MANUAL_ONLY.
    /// If this field is used alongside with a count created list of address resources &#39;google_compute_address.foobar.*.self_link&#39;,
    /// the access level resource for the address resource must have a &#39;lifecycle&#39; block with &#39;create_before_destroy = true&#39; so
    /// the number of resources can be increased/decreased without triggering the &#39;resourceInUseByAnotherResource&#39; error.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? NatIps
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("nat_ips");
        set => this.WithProperty("nat_ips", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Region where the router and NAT reside.
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The name of the Cloud Router in which this NAT will be configured.
    /// </summary>
    public TerraformLiteralProperty<string>? Router
    {
        get => GetProperty<TerraformLiteralProperty<string>>("router");
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
    public TerraformLiteralProperty<string>? SourceSubnetworkIpRangesToNat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_subnetwork_ip_ranges_to_nat");
        set => this.WithProperty("source_subnetwork_ip_ranges_to_nat", value);
    }

    /// <summary>
    /// Specify the Nat option for NAT64, which can take one of the following values:
    /// ALL_IPV6_SUBNETWORKS: All of the IP ranges in every Subnetwork are allowed to Nat.
    /// LIST_OF_IPV6_SUBNETWORKS: A list of Subnetworks are allowed to Nat (specified in the field nat64Subnetwork below).
    /// Note that if this field contains NAT64_ALL_V6_SUBNETWORKS no other Router.Nat section in this region can also enable NAT64 for any Subnetworks in this network.
    /// Other Router.Nat sections can still be present to enable NAT44 only. Possible values: [&amp;quot;ALL_IPV6_SUBNETWORKS&amp;quot;, &amp;quot;LIST_OF_IPV6_SUBNETWORKS&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? SourceSubnetworkIpRangesToNat64
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_subnetwork_ip_ranges_to_nat64");
        set => this.WithProperty("source_subnetwork_ip_ranges_to_nat64", value);
    }

    /// <summary>
    /// Timeout (in seconds) for TCP established connections.
    /// Defaults to 1200s if not set.
    /// </summary>
    public TerraformLiteralProperty<double>? TcpEstablishedIdleTimeoutSec
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tcp_established_idle_timeout_sec");
        set => this.WithProperty("tcp_established_idle_timeout_sec", value);
    }

    /// <summary>
    /// Timeout (in seconds) for TCP connections that are in TIME_WAIT state.
    /// Defaults to 120s if not set.
    /// </summary>
    public TerraformLiteralProperty<double>? TcpTimeWaitTimeoutSec
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tcp_time_wait_timeout_sec");
        set => this.WithProperty("tcp_time_wait_timeout_sec", value);
    }

    /// <summary>
    /// Timeout (in seconds) for TCP transitory connections.
    /// Defaults to 30s if not set.
    /// </summary>
    public TerraformLiteralProperty<double>? TcpTransitoryIdleTimeoutSec
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tcp_transitory_idle_timeout_sec");
        set => this.WithProperty("tcp_transitory_idle_timeout_sec", value);
    }

    /// <summary>
    /// Indicates whether this NAT is used for public or private IP translation.
    /// If unspecified, it defaults to PUBLIC.
    /// If &#39;PUBLIC&#39; NAT used for public IP translation.
    /// If &#39;PRIVATE&#39; NAT used for private IP translation. Default value: &amp;quot;PUBLIC&amp;quot; Possible values: [&amp;quot;PUBLIC&amp;quot;, &amp;quot;PRIVATE&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Timeout (in seconds) for UDP connections. Defaults to 30s if not set.
    /// </summary>
    public TerraformLiteralProperty<double>? UdpIdleTimeoutSec
    {
        get => GetProperty<TerraformLiteralProperty<double>>("udp_idle_timeout_sec");
        set => this.WithProperty("udp_idle_timeout_sec", value);
    }

}
