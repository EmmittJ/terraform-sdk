using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for params in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeNetworkParamsBlock : TerraformBlock
{
    /// <summary>
    /// Resource manager tags to be bound to the network. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ResourceManagerTags
    {
        set => SetProperty("resource_manager_tags", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeNetworkTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_network resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeNetwork : TerraformResource
{
    public GoogleComputeNetwork(string name) : base("google_compute_network", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("gateway_ipv4");
        SetOutput("network_id");
        SetOutput("numeric_id");
        SetOutput("self_link");
        SetOutput("auto_create_subnetworks");
        SetOutput("bgp_always_compare_med");
        SetOutput("bgp_best_path_selection_mode");
        SetOutput("bgp_inter_region_cost");
        SetOutput("delete_default_routes_on_create");
        SetOutput("description");
        SetOutput("enable_ula_internal_ipv6");
        SetOutput("id");
        SetOutput("internal_ipv6_range");
        SetOutput("mtu");
        SetOutput("name");
        SetOutput("network_firewall_policy_enforcement_order");
        SetOutput("network_profile");
        SetOutput("project");
        SetOutput("routing_mode");
    }

    /// <summary>
    /// When set to &#39;true&#39;, the network is created in &amp;quot;auto subnet mode&amp;quot; and
    /// it will create a subnet for each region automatically across the
    /// &#39;10.128.0.0/9&#39; address range.
    /// 
    /// When set to &#39;false&#39;, the network is created in &amp;quot;custom subnet mode&amp;quot; so
    /// the user can explicitly connect subnetwork resources.
    /// </summary>
    public TerraformProperty<bool> AutoCreateSubnetworks
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_create_subnetworks");
        set => SetProperty("auto_create_subnetworks", value);
    }

    /// <summary>
    /// Enables/disables the comparison of MED across routes with different Neighbor ASNs.
    /// This value can only be set if the --bgp-best-path-selection-mode is STANDARD
    /// </summary>
    public TerraformProperty<bool> BgpAlwaysCompareMed
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("bgp_always_compare_med");
        set => SetProperty("bgp_always_compare_med", value);
    }

    /// <summary>
    /// The BGP best selection algorithm to be employed. MODE can be LEGACY or STANDARD. Possible values: [&amp;quot;LEGACY&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    public TerraformProperty<string> BgpBestPathSelectionMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bgp_best_path_selection_mode");
        set => SetProperty("bgp_best_path_selection_mode", value);
    }

    /// <summary>
    /// Choice of the behavior of inter-regional cost and MED in the BPS algorithm. Possible values: [&amp;quot;DEFAULT&amp;quot;, &amp;quot;ADD_COST_TO_MED&amp;quot;]
    /// </summary>
    public TerraformProperty<string> BgpInterRegionCost
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bgp_inter_region_cost");
        set => SetProperty("bgp_inter_region_cost", value);
    }

    /// <summary>
    /// If set to &#39;true&#39;, default routes (&#39;0.0.0.0/0&#39;) will be deleted
    /// immediately after network creation. Defaults to &#39;false&#39;.
    /// </summary>
    public TerraformProperty<bool> DeleteDefaultRoutesOnCreate
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("delete_default_routes_on_create");
        set => SetProperty("delete_default_routes_on_create", value);
    }

    /// <summary>
    /// An optional description of this resource. The resource must be
    /// recreated to modify this field.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Enable ULA internal ipv6 on this network. Enabling this feature will assign
    /// a /48 from google defined ULA prefix fd20::/20.
    /// </summary>
    public TerraformProperty<bool> EnableUlaInternalIpv6
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_ula_internal_ipv6");
        set => SetProperty("enable_ula_internal_ipv6", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// When enabling ula internal ipv6, caller optionally can specify the /48 range
    /// they want from the google defined ULA prefix fd20::/20. The input must be a
    /// valid /48 ULA IPv6 address and must be within the fd20::/20. Operation will
    /// fail if the speficied /48 is already in used by another resource.
    /// If the field is not speficied, then a /48 range will be randomly allocated from fd20::/20 and returned via this field.
    /// </summary>
    public TerraformProperty<string> InternalIpv6Range
    {
        get => GetRequiredOutput<TerraformProperty<string>>("internal_ipv6_range");
        set => SetProperty("internal_ipv6_range", value);
    }

    /// <summary>
    /// Maximum Transmission Unit in bytes. The default value is 1460 bytes.
    /// The minimum value for this field is 1300 and the maximum value is 8896 bytes (jumbo frames).
    /// Note that packets larger than 1500 bytes (standard Ethernet) can be subject to TCP-MSS clamping or dropped
    /// with an ICMP &#39;Fragmentation-Needed&#39; message if the packets are routed to the Internet or other VPCs
    /// with varying MTUs.
    /// </summary>
    public TerraformProperty<double> Mtu
    {
        get => GetRequiredOutput<TerraformProperty<double>>("mtu");
        set => SetProperty("mtu", value);
    }

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
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Set the order that Firewall Rules and Firewall Policies are evaluated. Default value: &amp;quot;AFTER_CLASSIC_FIREWALL&amp;quot; Possible values: [&amp;quot;BEFORE_CLASSIC_FIREWALL&amp;quot;, &amp;quot;AFTER_CLASSIC_FIREWALL&amp;quot;]
    /// </summary>
    public TerraformProperty<string> NetworkFirewallPolicyEnforcementOrder
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_firewall_policy_enforcement_order");
        set => SetProperty("network_firewall_policy_enforcement_order", value);
    }

    /// <summary>
    /// A full or partial URL of the network profile to apply to this network.
    /// This field can be set only at resource creation time. For example, the
    /// following are valid URLs:
    /// * https://www.googleapis.com/compute/v1/projects/{projectId}/global/networkProfiles/{network_profile_name}
    /// * projects/{projectId}/global/networkProfiles/{network_profile_name}
    /// </summary>
    public TerraformProperty<string> NetworkProfile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_profile");
        set => SetProperty("network_profile", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The network-wide routing mode to use. If set to &#39;REGIONAL&#39;, this
    /// network&#39;s cloud routers will only advertise routes with subnetworks
    /// of this network in the same region as the router. If set to &#39;GLOBAL&#39;,
    /// this network&#39;s cloud routers will advertise routes with all
    /// subnetworks of this network, across regions. Possible values: [&amp;quot;REGIONAL&amp;quot;, &amp;quot;GLOBAL&amp;quot;]
    /// </summary>
    public TerraformProperty<string> RoutingMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_mode");
        set => SetProperty("routing_mode", value);
    }

    /// <summary>
    /// Block for params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Params block(s) allowed")]
    public List<GoogleComputeNetworkParamsBlock>? Params
    {
        set => SetProperty("params", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeNetworkTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The gateway address for default routing out of the network. This value
    /// is selected by GCP.
    /// </summary>
    public TerraformExpression GatewayIpv4 => this["gateway_ipv4"];

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformExpression NetworkId => this["network_id"];

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformExpression NumericId => this["numeric_id"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
