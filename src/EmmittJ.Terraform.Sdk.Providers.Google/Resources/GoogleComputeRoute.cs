using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_route resource.
/// </summary>
public class GoogleComputeRoute : TerraformResource
{
    public GoogleComputeRoute(string name) : base("google_compute_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("as_paths");
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("next_hop_hub");
        this.DeclareOutput("next_hop_inter_region_cost");
        this.DeclareOutput("next_hop_med");
        this.DeclareOutput("next_hop_network");
        this.DeclareOutput("next_hop_origin");
        this.DeclareOutput("next_hop_peering");
        this.DeclareOutput("route_status");
        this.DeclareOutput("route_type");
        this.DeclareOutput("self_link");
        this.DeclareOutput("warnings");
    }

    /// <summary>
    /// An optional description of this resource. Provide this property
    /// when you create the resource.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination range of outgoing packets that this route applies to.
    /// Only IPv4 is supported.
    /// </summary>
    public string? DestRange
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dest_range")?.Value;
        set => this.WithProperty("dest_range", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035.  Specifically, the name must be 1-63 characters long and
    /// match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means
    /// the first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the
    /// last character, which cannot be a dash.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network that this route applies to.
    /// </summary>
    public string? Network
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network")?.Value;
        set => this.WithProperty("network", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// URL to a gateway that should handle matching packets.
    /// Currently, you can only specify the internet gateway, using a full or
    /// partial valid URL:
    /// * &#39;https://www.googleapis.com/compute/v1/projects/project/global/gateways/default-internet-gateway&#39;
    /// * &#39;projects/project/global/gateways/default-internet-gateway&#39;
    /// * &#39;global/gateways/default-internet-gateway&#39;
    /// * The string &#39;default-internet-gateway&#39;.
    /// </summary>
    public string? NextHopGateway
    {
        get => GetProperty<TerraformLiteralProperty<string>>("next_hop_gateway")?.Value;
        set => this.WithProperty("next_hop_gateway", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The IP address or URL to a forwarding rule of type
    /// loadBalancingScheme=INTERNAL that should handle matching
    /// packets.
    /// 
    /// With the GA provider you can only specify the forwarding
    /// rule as a partial or full URL. For example, the following
    /// are all valid values:
    /// * 10.128.0.56
    /// * https://www.googleapis.com/compute/v1/projects/project/regions/region/forwardingRules/forwardingRule
    /// * regions/region/forwardingRules/forwardingRule
    /// 
    /// When the beta provider, you can also specify the IP address
    /// of a forwarding rule from the same VPC or any peered VPC.
    /// 
    /// Note that this can only be used when the destinationRange is
    /// a public (non-RFC 1918) IP CIDR range.
    /// </summary>
    public string? NextHopIlb
    {
        get => GetProperty<TerraformLiteralProperty<string>>("next_hop_ilb")?.Value;
        set => this.WithProperty("next_hop_ilb", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// URL to an instance that should handle matching packets.
    /// You can specify this as a full or partial URL. For example:
    /// * &#39;https://www.googleapis.com/compute/v1/projects/project/zones/zone/instances/instance&#39;
    /// * &#39;projects/project/zones/zone/instances/instance&#39;
    /// * &#39;zones/zone/instances/instance&#39;
    /// * Just the instance name, with the zone in &#39;next_hop_instance_zone&#39;.
    /// </summary>
    public string? NextHopInstance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("next_hop_instance")?.Value;
        set => this.WithProperty("next_hop_instance", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The zone of the instance specified in next_hop_instance. Omit if next_hop_instance is specified as a URL.
    /// </summary>
    public string? NextHopInstanceZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("next_hop_instance_zone")?.Value;
        set => this.WithProperty("next_hop_instance_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Network IP address of an instance that should handle matching packets.
    /// </summary>
    public string? NextHopIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("next_hop_ip")?.Value;
        set => this.WithProperty("next_hop_ip", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// URL to a VpnTunnel that should handle matching packets.
    /// </summary>
    public string? NextHopVpnTunnel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("next_hop_vpn_tunnel")?.Value;
        set => this.WithProperty("next_hop_vpn_tunnel", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The priority of this route. Priority is used to break ties in cases
    /// where there is more than one matching route of equal prefix length.
    /// 
    /// In the case of two routes with equal prefix length, the one with the
    /// lowest-numbered priority value wins.
    /// 
    /// Default value is 1000. Valid range is 0 through 65535.
    /// </summary>
    public double? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority")?.Value;
        set => this.WithProperty("priority", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// A list of instance tags to which this route applies.
    /// </summary>
    public HashSet<string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The as_paths attribute.
    /// </summary>
    public TerraformExpression AsPaths => this["as_paths"];

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The hub network that should handle matching packets, which should conform to RFC1035.
    /// </summary>
    public TerraformExpression NextHopHub => this["next_hop_hub"];

    /// <summary>
    /// Internal fixed region-to-region cost that Google Cloud calculates based on factors such as network performance, distance, and available bandwidth between regions.
    /// </summary>
    public TerraformExpression NextHopInterRegionCost => this["next_hop_inter_region_cost"];

    /// <summary>
    /// Multi-Exit Discriminator, a BGP route metric that indicates the desirability of a particular route in a network.
    /// </summary>
    public TerraformExpression NextHopMed => this["next_hop_med"];

    /// <summary>
    /// URL to a Network that should handle matching packets.
    /// </summary>
    public TerraformExpression NextHopNetwork => this["next_hop_network"];

    /// <summary>
    /// Indicates the origin of the route. Can be IGP (Interior Gateway Protocol), EGP (Exterior Gateway Protocol), or INCOMPLETE.
    /// </summary>
    public TerraformExpression NextHopOrigin => this["next_hop_origin"];

    /// <summary>
    /// The network peering name that should handle matching packets, which should conform to RFC1035.
    /// </summary>
    public TerraformExpression NextHopPeering => this["next_hop_peering"];

    /// <summary>
    /// The status of the route, which can be one of the following values:
    /// - &#39;ACTIVE&#39; for an active route
    /// - &#39;INACTIVE&#39; for an inactive route
    /// </summary>
    public TerraformExpression RouteStatus => this["route_status"];

    /// <summary>
    /// The type of this route, which can be one of the following values:
    /// - &#39;TRANSIT&#39; for a transit route that this router learned from another Cloud Router and will readvertise to one of its BGP peers
    /// - &#39;SUBNET&#39; for a route from a subnet of the VPC
    /// - &#39;BGP&#39; for a route learned from a BGP peer of this router
    /// - &#39;STATIC&#39; for a static route
    /// </summary>
    public TerraformExpression RouteType => this["route_type"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// If potential misconfigurations are detected for this route, this field will be populated with warning messages.
    /// </summary>
    public TerraformExpression Warnings => this["warnings"];

}
