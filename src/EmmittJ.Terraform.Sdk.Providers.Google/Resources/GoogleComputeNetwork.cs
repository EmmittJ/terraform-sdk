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
    public TerraformLiteralProperty<bool>? AutoCreateSubnetworks
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_create_subnetworks");
        set => this.WithProperty("auto_create_subnetworks", value);
    }

    /// <summary>
    /// Enables/disables the comparison of MED across routes with different Neighbor ASNs.
    /// This value can only be set if the --bgp-best-path-selection-mode is STANDARD
    /// </summary>
    public TerraformLiteralProperty<bool>? BgpAlwaysCompareMed
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("bgp_always_compare_med");
        set => this.WithProperty("bgp_always_compare_med", value);
    }

    /// <summary>
    /// The BGP best selection algorithm to be employed. MODE can be LEGACY or STANDARD. Possible values: [&amp;quot;LEGACY&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? BgpBestPathSelectionMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bgp_best_path_selection_mode");
        set => this.WithProperty("bgp_best_path_selection_mode", value);
    }

    /// <summary>
    /// Choice of the behavior of inter-regional cost and MED in the BPS algorithm. Possible values: [&amp;quot;DEFAULT&amp;quot;, &amp;quot;ADD_COST_TO_MED&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? BgpInterRegionCost
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bgp_inter_region_cost");
        set => this.WithProperty("bgp_inter_region_cost", value);
    }

    /// <summary>
    /// If set to &#39;true&#39;, default routes (&#39;0.0.0.0/0&#39;) will be deleted
    /// immediately after network creation. Defaults to &#39;false&#39;.
    /// </summary>
    public TerraformLiteralProperty<bool>? DeleteDefaultRoutesOnCreate
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_default_routes_on_create");
        set => this.WithProperty("delete_default_routes_on_create", value);
    }

    /// <summary>
    /// An optional description of this resource. The resource must be
    /// recreated to modify this field.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Enable ULA internal ipv6 on this network. Enabling this feature will assign
    /// a /48 from google defined ULA prefix fd20::/20.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableUlaInternalIpv6
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_ula_internal_ipv6");
        set => this.WithProperty("enable_ula_internal_ipv6", value);
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
    /// When enabling ula internal ipv6, caller optionally can specify the /48 range
    /// they want from the google defined ULA prefix fd20::/20. The input must be a
    /// valid /48 ULA IPv6 address and must be within the fd20::/20. Operation will
    /// fail if the speficied /48 is already in used by another resource.
    /// If the field is not speficied, then a /48 range will be randomly allocated from fd20::/20 and returned via this field.
    /// </summary>
    public TerraformLiteralProperty<string>? InternalIpv6Range
    {
        get => GetProperty<TerraformLiteralProperty<string>>("internal_ipv6_range");
        set => this.WithProperty("internal_ipv6_range", value);
    }

    /// <summary>
    /// Maximum Transmission Unit in bytes. The default value is 1460 bytes.
    /// The minimum value for this field is 1300 and the maximum value is 8896 bytes (jumbo frames).
    /// Note that packets larger than 1500 bytes (standard Ethernet) can be subject to TCP-MSS clamping or dropped
    /// with an ICMP &#39;Fragmentation-Needed&#39; message if the packets are routed to the Internet or other VPCs
    /// with varying MTUs.
    /// </summary>
    public TerraformLiteralProperty<double>? Mtu
    {
        get => GetProperty<TerraformLiteralProperty<double>>("mtu");
        set => this.WithProperty("mtu", value);
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
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Set the order that Firewall Rules and Firewall Policies are evaluated. Default value: &amp;quot;AFTER_CLASSIC_FIREWALL&amp;quot; Possible values: [&amp;quot;BEFORE_CLASSIC_FIREWALL&amp;quot;, &amp;quot;AFTER_CLASSIC_FIREWALL&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkFirewallPolicyEnforcementOrder
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_firewall_policy_enforcement_order");
        set => this.WithProperty("network_firewall_policy_enforcement_order", value);
    }

    /// <summary>
    /// A full or partial URL of the network profile to apply to this network.
    /// This field can be set only at resource creation time. For example, the
    /// following are valid URLs:
    /// * https://www.googleapis.com/compute/v1/projects/{projectId}/global/networkProfiles/{network_profile_name}
    /// * projects/{projectId}/global/networkProfiles/{network_profile_name}
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_profile");
        set => this.WithProperty("network_profile", value);
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
    /// The network-wide routing mode to use. If set to &#39;REGIONAL&#39;, this
    /// network&#39;s cloud routers will only advertise routes with subnetworks
    /// of this network in the same region as the router. If set to &#39;GLOBAL&#39;,
    /// this network&#39;s cloud routers will advertise routes with all
    /// subnetworks of this network, across regions. Possible values: [&amp;quot;REGIONAL&amp;quot;, &amp;quot;GLOBAL&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? RoutingMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_mode");
        set => this.WithProperty("routing_mode", value);
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
