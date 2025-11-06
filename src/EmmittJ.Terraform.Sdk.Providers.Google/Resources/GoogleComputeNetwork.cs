using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_network resource.
/// </summary>
public class GoogleComputeNetwork : TerraformResource
{
    public GoogleComputeNetwork(string name) : base("google_compute_network", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("gateway_ipv4");
        this.DeclareOutput("network_id");
        this.DeclareOutput("numeric_id");
        this.DeclareOutput("self_link");
    }

    /// <summary>
    /// When set to &#39;true&#39;, the network is created in &amp;quot;auto subnet mode&amp;quot; and
    /// it will create a subnet for each region automatically across the
    /// &#39;10.128.0.0/9&#39; address range.
    /// 
    /// When set to &#39;false&#39;, the network is created in &amp;quot;custom subnet mode&amp;quot; so
    /// the user can explicitly connect subnetwork resources.
    /// </summary>
    public bool? AutoCreateSubnetworks
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_create_subnetworks")?.Value;
        set => this.WithProperty("auto_create_subnetworks", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Enables/disables the comparison of MED across routes with different Neighbor ASNs.
    /// This value can only be set if the --bgp-best-path-selection-mode is STANDARD
    /// </summary>
    public bool? BgpAlwaysCompareMed
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("bgp_always_compare_med")?.Value;
        set => this.WithProperty("bgp_always_compare_med", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The BGP best selection algorithm to be employed. MODE can be LEGACY or STANDARD. Possible values: [&amp;quot;LEGACY&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    public string? BgpBestPathSelectionMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bgp_best_path_selection_mode")?.Value;
        set => this.WithProperty("bgp_best_path_selection_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Choice of the behavior of inter-regional cost and MED in the BPS algorithm. Possible values: [&amp;quot;DEFAULT&amp;quot;, &amp;quot;ADD_COST_TO_MED&amp;quot;]
    /// </summary>
    public string? BgpInterRegionCost
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bgp_inter_region_cost")?.Value;
        set => this.WithProperty("bgp_inter_region_cost", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If set to &#39;true&#39;, default routes (&#39;0.0.0.0/0&#39;) will be deleted
    /// immediately after network creation. Defaults to &#39;false&#39;.
    /// </summary>
    public bool? DeleteDefaultRoutesOnCreate
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_default_routes_on_create")?.Value;
        set => this.WithProperty("delete_default_routes_on_create", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// An optional description of this resource. The resource must be
    /// recreated to modify this field.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Enable ULA internal ipv6 on this network. Enabling this feature will assign
    /// a /48 from google defined ULA prefix fd20::/20.
    /// </summary>
    public bool? EnableUlaInternalIpv6
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_ula_internal_ipv6")?.Value;
        set => this.WithProperty("enable_ula_internal_ipv6", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// When enabling ula internal ipv6, caller optionally can specify the /48 range
    /// they want from the google defined ULA prefix fd20::/20. The input must be a
    /// valid /48 ULA IPv6 address and must be within the fd20::/20. Operation will
    /// fail if the speficied /48 is already in used by another resource.
    /// If the field is not speficied, then a /48 range will be randomly allocated from fd20::/20 and returned via this field.
    /// </summary>
    public string? InternalIpv6Range
    {
        get => GetProperty<TerraformLiteralProperty<string>>("internal_ipv6_range")?.Value;
        set => this.WithProperty("internal_ipv6_range", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Maximum Transmission Unit in bytes. The default value is 1460 bytes.
    /// The minimum value for this field is 1300 and the maximum value is 8896 bytes (jumbo frames).
    /// Note that packets larger than 1500 bytes (standard Ethernet) can be subject to TCP-MSS clamping or dropped
    /// with an ICMP &#39;Fragmentation-Needed&#39; message if the packets are routed to the Internet or other VPCs
    /// with varying MTUs.
    /// </summary>
    public double? Mtu
    {
        get => GetProperty<TerraformLiteralProperty<double>>("mtu")?.Value;
        set => this.WithProperty("mtu", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Set the order that Firewall Rules and Firewall Policies are evaluated. Default value: &amp;quot;AFTER_CLASSIC_FIREWALL&amp;quot; Possible values: [&amp;quot;BEFORE_CLASSIC_FIREWALL&amp;quot;, &amp;quot;AFTER_CLASSIC_FIREWALL&amp;quot;]
    /// </summary>
    public string? NetworkFirewallPolicyEnforcementOrder
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_firewall_policy_enforcement_order")?.Value;
        set => this.WithProperty("network_firewall_policy_enforcement_order", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A full or partial URL of the network profile to apply to this network.
    /// This field can be set only at resource creation time. For example, the
    /// following are valid URLs:
    /// * https://www.googleapis.com/compute/v1/projects/{projectId}/global/networkProfiles/{network_profile_name}
    /// * projects/{projectId}/global/networkProfiles/{network_profile_name}
    /// </summary>
    public string? NetworkProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_profile")?.Value;
        set => this.WithProperty("network_profile", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network-wide routing mode to use. If set to &#39;REGIONAL&#39;, this
    /// network&#39;s cloud routers will only advertise routes with subnetworks
    /// of this network in the same region as the router. If set to &#39;GLOBAL&#39;,
    /// this network&#39;s cloud routers will advertise routes with all
    /// subnetworks of this network, across regions. Possible values: [&amp;quot;REGIONAL&amp;quot;, &amp;quot;GLOBAL&amp;quot;]
    /// </summary>
    public string? RoutingMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_mode")?.Value;
        set => this.WithProperty("routing_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
