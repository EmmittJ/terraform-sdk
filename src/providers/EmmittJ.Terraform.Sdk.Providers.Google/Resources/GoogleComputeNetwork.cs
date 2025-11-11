using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for params in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeNetworkParamsBlock
{
    /// <summary>
    /// Resource manager tags to be bound to the network. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456.
    /// </summary>
    [TerraformPropertyName("resource_manager_tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? ResourceManagerTags { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeNetworkTimeoutsBlock
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
/// Manages a google_compute_network resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeNetwork : TerraformResource
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
    [TerraformPropertyName("auto_create_subnetworks")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoCreateSubnetworks { get; set; }

    /// <summary>
    /// Enables/disables the comparison of MED across routes with different Neighbor ASNs.
    /// This value can only be set if the --bgp-best-path-selection-mode is STANDARD
    /// </summary>
    [TerraformPropertyName("bgp_always_compare_med")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> BgpAlwaysCompareMed { get; set; } = default!;

    /// <summary>
    /// The BGP best selection algorithm to be employed. MODE can be LEGACY or STANDARD. Possible values: [&amp;quot;LEGACY&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    [TerraformPropertyName("bgp_best_path_selection_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> BgpBestPathSelectionMode { get; set; } = default!;

    /// <summary>
    /// Choice of the behavior of inter-regional cost and MED in the BPS algorithm. Possible values: [&amp;quot;DEFAULT&amp;quot;, &amp;quot;ADD_COST_TO_MED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("bgp_inter_region_cost")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> BgpInterRegionCost { get; set; } = default!;

    /// <summary>
    /// If set to &#39;true&#39;, default routes (&#39;0.0.0.0/0&#39;) will be deleted
    /// immediately after network creation. Defaults to &#39;false&#39;.
    /// </summary>
    [TerraformPropertyName("delete_default_routes_on_create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeleteDefaultRoutesOnCreate { get; set; }

    /// <summary>
    /// An optional description of this resource. The resource must be
    /// recreated to modify this field.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Enable ULA internal ipv6 on this network. Enabling this feature will assign
    /// a /48 from google defined ULA prefix fd20::/20.
    /// </summary>
    [TerraformPropertyName("enable_ula_internal_ipv6")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableUlaInternalIpv6 { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// When enabling ula internal ipv6, caller optionally can specify the /48 range
    /// they want from the google defined ULA prefix fd20::/20. The input must be a
    /// valid /48 ULA IPv6 address and must be within the fd20::/20. Operation will
    /// fail if the speficied /48 is already in used by another resource.
    /// If the field is not speficied, then a /48 range will be randomly allocated from fd20::/20 and returned via this field.
    /// </summary>
    [TerraformPropertyName("internal_ipv6_range")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> InternalIpv6Range { get; set; } = default!;

    /// <summary>
    /// Maximum Transmission Unit in bytes. The default value is 1460 bytes.
    /// The minimum value for this field is 1300 and the maximum value is 8896 bytes (jumbo frames).
    /// Note that packets larger than 1500 bytes (standard Ethernet) can be subject to TCP-MSS clamping or dropped
    /// with an ICMP &#39;Fragmentation-Needed&#39; message if the packets are routed to the Internet or other VPCs
    /// with varying MTUs.
    /// </summary>
    [TerraformPropertyName("mtu")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Mtu { get; set; } = default!;

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
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Set the order that Firewall Rules and Firewall Policies are evaluated. Default value: &amp;quot;AFTER_CLASSIC_FIREWALL&amp;quot; Possible values: [&amp;quot;BEFORE_CLASSIC_FIREWALL&amp;quot;, &amp;quot;AFTER_CLASSIC_FIREWALL&amp;quot;]
    /// </summary>
    [TerraformPropertyName("network_firewall_policy_enforcement_order")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NetworkFirewallPolicyEnforcementOrder { get; set; }

    /// <summary>
    /// A full or partial URL of the network profile to apply to this network.
    /// This field can be set only at resource creation time. For example, the
    /// following are valid URLs:
    /// * https://www.googleapis.com/compute/v1/projects/{projectId}/global/networkProfiles/{network_profile_name}
    /// * projects/{projectId}/global/networkProfiles/{network_profile_name}
    /// </summary>
    [TerraformPropertyName("network_profile")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NetworkProfile { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The network-wide routing mode to use. If set to &#39;REGIONAL&#39;, this
    /// network&#39;s cloud routers will only advertise routes with subnetworks
    /// of this network in the same region as the router. If set to &#39;GLOBAL&#39;,
    /// this network&#39;s cloud routers will advertise routes with all
    /// subnetworks of this network, across regions. Possible values: [&amp;quot;REGIONAL&amp;quot;, &amp;quot;GLOBAL&amp;quot;]
    /// </summary>
    [TerraformPropertyName("routing_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoutingMode { get; set; } = default!;

    /// <summary>
    /// Block for params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Params block(s) allowed")]
    [TerraformPropertyName("params")]
    public TerraformList<TerraformBlock<GoogleComputeNetworkParamsBlock>>? Params { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeNetworkTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The gateway address for default routing out of the network. This value
    /// is selected by GCP.
    /// </summary>
    [TerraformPropertyName("gateway_ipv4")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GatewayIpv4 => new TerraformReference(this, "gateway_ipv4");

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformPropertyName("network_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkId => new TerraformReference(this, "network_id");

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformPropertyName("numeric_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NumericId => new TerraformReference(this, "numeric_id");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

}
