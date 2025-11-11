using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for params in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeNetworkParamsBlock : TerraformBlockBase
{
    /// <summary>
    /// Resource manager tags to be bound to the network. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456.
    /// </summary>
    [TerraformProperty("resource_manager_tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? ResourceManagerTags { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeNetworkTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_network resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeNetwork : TerraformResource
{
    public GoogleComputeNetwork(string name) : base("google_compute_network", name)
    {
    }

    /// <summary>
    /// When set to &#39;true&#39;, the network is created in &amp;quot;auto subnet mode&amp;quot; and
    /// it will create a subnet for each region automatically across the
    /// &#39;10.128.0.0/9&#39; address range.
    /// 
    /// When set to &#39;false&#39;, the network is created in &amp;quot;custom subnet mode&amp;quot; so
    /// the user can explicitly connect subnetwork resources.
    /// </summary>
    [TerraformProperty("auto_create_subnetworks")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutoCreateSubnetworks { get; set; }

    /// <summary>
    /// Enables/disables the comparison of MED across routes with different Neighbor ASNs.
    /// This value can only be set if the --bgp-best-path-selection-mode is STANDARD
    /// </summary>
    [TerraformProperty("bgp_always_compare_med")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> BgpAlwaysCompareMed { get; set; }

    /// <summary>
    /// The BGP best selection algorithm to be employed. MODE can be LEGACY or STANDARD. Possible values: [&amp;quot;LEGACY&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    [TerraformProperty("bgp_best_path_selection_mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> BgpBestPathSelectionMode { get; set; }

    /// <summary>
    /// Choice of the behavior of inter-regional cost and MED in the BPS algorithm. Possible values: [&amp;quot;DEFAULT&amp;quot;, &amp;quot;ADD_COST_TO_MED&amp;quot;]
    /// </summary>
    [TerraformProperty("bgp_inter_region_cost")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> BgpInterRegionCost { get; set; }

    /// <summary>
    /// If set to &#39;true&#39;, default routes (&#39;0.0.0.0/0&#39;) will be deleted
    /// immediately after network creation. Defaults to &#39;false&#39;.
    /// </summary>
    [TerraformProperty("delete_default_routes_on_create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeleteDefaultRoutesOnCreate { get; set; }

    /// <summary>
    /// An optional description of this resource. The resource must be
    /// recreated to modify this field.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Enable ULA internal ipv6 on this network. Enabling this feature will assign
    /// a /48 from google defined ULA prefix fd20::/20.
    /// </summary>
    [TerraformProperty("enable_ula_internal_ipv6")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableUlaInternalIpv6 { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// When enabling ula internal ipv6, caller optionally can specify the /48 range
    /// they want from the google defined ULA prefix fd20::/20. The input must be a
    /// valid /48 ULA IPv6 address and must be within the fd20::/20. Operation will
    /// fail if the speficied /48 is already in used by another resource.
    /// If the field is not speficied, then a /48 range will be randomly allocated from fd20::/20 and returned via this field.
    /// </summary>
    [TerraformProperty("internal_ipv6_range")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> InternalIpv6Range { get; set; }

    /// <summary>
    /// Maximum Transmission Unit in bytes. The default value is 1460 bytes.
    /// The minimum value for this field is 1300 and the maximum value is 8896 bytes (jumbo frames).
    /// Note that packets larger than 1500 bytes (standard Ethernet) can be subject to TCP-MSS clamping or dropped
    /// with an ICMP &#39;Fragmentation-Needed&#39; message if the packets are routed to the Internet or other VPCs
    /// with varying MTUs.
    /// </summary>
    [TerraformProperty("mtu")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Mtu { get; set; }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Set the order that Firewall Rules and Firewall Policies are evaluated. Default value: &amp;quot;AFTER_CLASSIC_FIREWALL&amp;quot; Possible values: [&amp;quot;BEFORE_CLASSIC_FIREWALL&amp;quot;, &amp;quot;AFTER_CLASSIC_FIREWALL&amp;quot;]
    /// </summary>
    [TerraformProperty("network_firewall_policy_enforcement_order")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NetworkFirewallPolicyEnforcementOrder { get; set; }

    /// <summary>
    /// A full or partial URL of the network profile to apply to this network.
    /// This field can be set only at resource creation time. For example, the
    /// following are valid URLs:
    /// * https://www.googleapis.com/compute/v1/projects/{projectId}/global/networkProfiles/{network_profile_name}
    /// * projects/{projectId}/global/networkProfiles/{network_profile_name}
    /// </summary>
    [TerraformProperty("network_profile")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NetworkProfile { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The network-wide routing mode to use. If set to &#39;REGIONAL&#39;, this
    /// network&#39;s cloud routers will only advertise routes with subnetworks
    /// of this network in the same region as the router. If set to &#39;GLOBAL&#39;,
    /// this network&#39;s cloud routers will advertise routes with all
    /// subnetworks of this network, across regions. Possible values: [&amp;quot;REGIONAL&amp;quot;, &amp;quot;GLOBAL&amp;quot;]
    /// </summary>
    [TerraformProperty("routing_mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> RoutingMode { get; set; }

    /// <summary>
    /// Block for params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Params block(s) allowed")]
    [TerraformProperty("params")]
    public TerraformList<TerraformBlock<GoogleComputeNetworkParamsBlock>>? Params { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleComputeNetworkTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The gateway address for default routing out of the network. This value
    /// is selected by GCP.
    /// </summary>
    [TerraformProperty("gateway_ipv4")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GatewayIpv4 { get; }

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformProperty("network_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NetworkId { get; }

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformProperty("numeric_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NumericId { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

}
