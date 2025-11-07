using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_router_nat.
/// </summary>
public class GoogleComputeRouterNatDataSource : TerraformDataSource
{
    public GoogleComputeRouterNatDataSource(string name) : base("google_compute_router_nat", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("auto_network_tier");
        this.DeclareOutput("drain_nat_ips");
        this.DeclareOutput("enable_dynamic_port_allocation");
        this.DeclareOutput("enable_endpoint_independent_mapping");
        this.DeclareOutput("endpoint_types");
        this.DeclareOutput("icmp_idle_timeout_sec");
        this.DeclareOutput("initial_nat_ips");
        this.DeclareOutput("log_config");
        this.DeclareOutput("max_ports_per_vm");
        this.DeclareOutput("min_ports_per_vm");
        this.DeclareOutput("nat64_subnetwork");
        this.DeclareOutput("nat_ip_allocate_option");
        this.DeclareOutput("nat_ips");
        this.DeclareOutput("rules");
        this.DeclareOutput("source_subnetwork_ip_ranges_to_nat");
        this.DeclareOutput("source_subnetwork_ip_ranges_to_nat64");
        this.DeclareOutput("subnetwork");
        this.DeclareOutput("tcp_established_idle_timeout_sec");
        this.DeclareOutput("tcp_time_wait_timeout_sec");
        this.DeclareOutput("tcp_transitory_idle_timeout_sec");
        this.DeclareOutput("type");
        this.DeclareOutput("udp_idle_timeout_sec");
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
    /// Name of the NAT service. The name must be 1-63 characters long and
    /// comply with RFC1035.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    public TerraformProperty<string>? Router
    {
        get => GetProperty<TerraformProperty<string>>("router");
        set => this.WithProperty("router", value);
    }

    /// <summary>
    /// The network tier to use when automatically reserving NAT IP addresses.
    /// Must be one of: PREMIUM, STANDARD. If not specified, then the current
    /// project-level default tier is used. Possible values: [&amp;quot;PREMIUM&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    public TerraformExpression AutoNetworkTier => this["auto_network_tier"];

    /// <summary>
    /// A list of URLs of the IP resources to be drained. These IPs must be
    /// valid static external IPs that have been assigned to the NAT.
    /// </summary>
    public TerraformExpression DrainNatIps => this["drain_nat_ips"];

    /// <summary>
    /// Enable Dynamic Port Allocation.
    /// If minPortsPerVm is set, minPortsPerVm must be set to a power of two greater than or equal to 32.
    /// If minPortsPerVm is not set, a minimum of 32 ports will be allocated to a VM from this NAT config.
    /// If maxPortsPerVm is set, maxPortsPerVm must be set to a power of two greater than minPortsPerVm.
    /// If maxPortsPerVm is not set, a maximum of 65536 ports will be allocated to a VM from this NAT config.
    /// 
    /// Mutually exclusive with enableEndpointIndependentMapping.
    /// </summary>
    public TerraformExpression EnableDynamicPortAllocation => this["enable_dynamic_port_allocation"];

    /// <summary>
    /// Enable endpoint independent mapping.
    /// For more information see the [official documentation](https://cloud.google.com/nat/docs/overview#specs-rfcs).
    /// </summary>
    public TerraformExpression EnableEndpointIndependentMapping => this["enable_endpoint_independent_mapping"];

    /// <summary>
    /// Specifies the endpoint Types supported by the NAT Gateway.
    /// Supported values include:
    ///       &#39;ENDPOINT_TYPE_VM&#39;, &#39;ENDPOINT_TYPE_SWG&#39;,
    ///       &#39;ENDPOINT_TYPE_MANAGED_PROXY_LB&#39;.
    /// </summary>
    public TerraformExpression EndpointTypes => this["endpoint_types"];

    /// <summary>
    /// Timeout (in seconds) for ICMP connections. Defaults to 30s if not set.
    /// </summary>
    public TerraformExpression IcmpIdleTimeoutSec => this["icmp_idle_timeout_sec"];

    /// <summary>
    /// Self-links of NAT IPs to be used as initial value for creation alongside a RouterNatAddress resource.
    /// Conflicts with natIps and drainNatIps. Only valid if natIpAllocateOption is set to MANUAL_ONLY.
    /// </summary>
    public TerraformExpression InitialNatIps => this["initial_nat_ips"];

    /// <summary>
    /// Configuration for logging on NAT
    /// </summary>
    public TerraformExpression LogConfig => this["log_config"];

    /// <summary>
    /// Maximum number of ports allocated to a VM from this NAT.
    /// This field can only be set when enableDynamicPortAllocation is enabled.
    /// </summary>
    public TerraformExpression MaxPortsPerVm => this["max_ports_per_vm"];

    /// <summary>
    /// Minimum number of ports allocated to a VM from this NAT. Defaults to 64 for static port allocation and 32 dynamic port allocation if not set.
    /// </summary>
    public TerraformExpression MinPortsPerVm => this["min_ports_per_vm"];

    /// <summary>
    /// One or more subnetwork NAT configurations whose traffic should be translated by NAT64 Gateway.
    /// Only used if &#39;source_subnetwork_ip_ranges_to_nat64&#39; is set to &#39;LIST_OF_IPV6_SUBNETWORKS&#39;
    /// </summary>
    public TerraformExpression Nat64Subnetwork => this["nat64_subnetwork"];

    /// <summary>
    /// How external IPs should be allocated for this NAT. Valid values are
    /// &#39;AUTO_ONLY&#39; for only allowing NAT IPs allocated by Google Cloud
    /// Platform, or &#39;MANUAL_ONLY&#39; for only user-allocated NAT IP addresses. Possible values: [&amp;quot;MANUAL_ONLY&amp;quot;, &amp;quot;AUTO_ONLY&amp;quot;]
    /// </summary>
    public TerraformExpression NatIpAllocateOption => this["nat_ip_allocate_option"];

    /// <summary>
    /// Self-links of NAT IPs. Only valid if natIpAllocateOption
    /// is set to MANUAL_ONLY.
    /// If this field is used alongside with a count created list of address resources &#39;google_compute_address.foobar.*.self_link&#39;,
    /// the access level resource for the address resource must have a &#39;lifecycle&#39; block with &#39;create_before_destroy = true&#39; so
    /// the number of resources can be increased/decreased without triggering the &#39;resourceInUseByAnotherResource&#39; error.
    /// </summary>
    public TerraformExpression NatIps => this["nat_ips"];

    /// <summary>
    /// A list of rules associated with this NAT.
    /// </summary>
    public TerraformExpression Rules => this["rules"];

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
    public TerraformExpression SourceSubnetworkIpRangesToNat => this["source_subnetwork_ip_ranges_to_nat"];

    /// <summary>
    /// Specify the Nat option for NAT64, which can take one of the following values:
    /// ALL_IPV6_SUBNETWORKS: All of the IP ranges in every Subnetwork are allowed to Nat.
    /// LIST_OF_IPV6_SUBNETWORKS: A list of Subnetworks are allowed to Nat (specified in the field nat64Subnetwork below).
    /// Note that if this field contains NAT64_ALL_V6_SUBNETWORKS no other Router.Nat section in this region can also enable NAT64 for any Subnetworks in this network.
    /// Other Router.Nat sections can still be present to enable NAT44 only. Possible values: [&amp;quot;ALL_IPV6_SUBNETWORKS&amp;quot;, &amp;quot;LIST_OF_IPV6_SUBNETWORKS&amp;quot;]
    /// </summary>
    public TerraformExpression SourceSubnetworkIpRangesToNat64 => this["source_subnetwork_ip_ranges_to_nat64"];

    /// <summary>
    /// One or more subnetwork NAT configurations. Only used if
    /// &#39;source_subnetwork_ip_ranges_to_nat&#39; is set to &#39;LIST_OF_SUBNETWORKS&#39;
    /// </summary>
    public TerraformExpression Subnetwork => this["subnetwork"];

    /// <summary>
    /// Timeout (in seconds) for TCP established connections.
    /// Defaults to 1200s if not set.
    /// </summary>
    public TerraformExpression TcpEstablishedIdleTimeoutSec => this["tcp_established_idle_timeout_sec"];

    /// <summary>
    /// Timeout (in seconds) for TCP connections that are in TIME_WAIT state.
    /// Defaults to 120s if not set.
    /// </summary>
    public TerraformExpression TcpTimeWaitTimeoutSec => this["tcp_time_wait_timeout_sec"];

    /// <summary>
    /// Timeout (in seconds) for TCP transitory connections.
    /// Defaults to 30s if not set.
    /// </summary>
    public TerraformExpression TcpTransitoryIdleTimeoutSec => this["tcp_transitory_idle_timeout_sec"];

    /// <summary>
    /// Indicates whether this NAT is used for public or private IP translation.
    /// If unspecified, it defaults to PUBLIC.
    /// If &#39;PUBLIC&#39; NAT used for public IP translation.
    /// If &#39;PRIVATE&#39; NAT used for private IP translation. Default value: &amp;quot;PUBLIC&amp;quot; Possible values: [&amp;quot;PUBLIC&amp;quot;, &amp;quot;PRIVATE&amp;quot;]
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// Timeout (in seconds) for UDP connections. Defaults to 30s if not set.
    /// </summary>
    public TerraformExpression UdpIdleTimeoutSec => this["udp_idle_timeout_sec"];

}
