using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for params in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouteParamsBlock : TerraformBlock
{
    /// <summary>
    /// Resource manager tags to be bound to the route. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456. The field is ignored when empty.
    /// The field is immutable and causes resource replacement when mutated. This field is only
    /// set at create time and modifying this field after creation will trigger recreation.
    /// To apply tags to an existing resource, see the google_tags_tag_binding resource.
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
public class GoogleComputeRouteTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_compute_route resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeRoute : TerraformResource
{
    public GoogleComputeRoute(string name) : base("google_compute_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("as_paths");
        SetOutput("creation_timestamp");
        SetOutput("next_hop_hub");
        SetOutput("next_hop_inter_region_cost");
        SetOutput("next_hop_med");
        SetOutput("next_hop_network");
        SetOutput("next_hop_origin");
        SetOutput("next_hop_peering");
        SetOutput("route_status");
        SetOutput("route_type");
        SetOutput("self_link");
        SetOutput("warnings");
        SetOutput("description");
        SetOutput("dest_range");
        SetOutput("id");
        SetOutput("name");
        SetOutput("network");
        SetOutput("next_hop_gateway");
        SetOutput("next_hop_ilb");
        SetOutput("next_hop_instance");
        SetOutput("next_hop_instance_zone");
        SetOutput("next_hop_ip");
        SetOutput("next_hop_vpn_tunnel");
        SetOutput("priority");
        SetOutput("project");
        SetOutput("tags");
    }

    /// <summary>
    /// An optional description of this resource. Provide this property
    /// when you create the resource.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The destination range of outgoing packets that this route applies to.
    /// Only IPv4 is supported.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestRange is required")]
    public required TerraformProperty<string> DestRange
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dest_range");
        set => SetProperty("dest_range", value);
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
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035.  Specifically, the name must be 1-63 characters long and
    /// match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means
    /// the first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the
    /// last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The network that this route applies to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network");
        set => SetProperty("network", value);
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
    public TerraformProperty<string> NextHopGateway
    {
        get => GetRequiredOutput<TerraformProperty<string>>("next_hop_gateway");
        set => SetProperty("next_hop_gateway", value);
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
    public TerraformProperty<string> NextHopIlb
    {
        get => GetRequiredOutput<TerraformProperty<string>>("next_hop_ilb");
        set => SetProperty("next_hop_ilb", value);
    }

    /// <summary>
    /// URL to an instance that should handle matching packets.
    /// You can specify this as a full or partial URL. For example:
    /// * &#39;https://www.googleapis.com/compute/v1/projects/project/zones/zone/instances/instance&#39;
    /// * &#39;projects/project/zones/zone/instances/instance&#39;
    /// * &#39;zones/zone/instances/instance&#39;
    /// * Just the instance name, with the zone in &#39;next_hop_instance_zone&#39;.
    /// </summary>
    public TerraformProperty<string> NextHopInstance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("next_hop_instance");
        set => SetProperty("next_hop_instance", value);
    }

    /// <summary>
    /// The zone of the instance specified in next_hop_instance. Omit if next_hop_instance is specified as a URL.
    /// </summary>
    public TerraformProperty<string> NextHopInstanceZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("next_hop_instance_zone");
        set => SetProperty("next_hop_instance_zone", value);
    }

    /// <summary>
    /// Network IP address of an instance that should handle matching packets.
    /// </summary>
    public TerraformProperty<string> NextHopIp
    {
        get => GetRequiredOutput<TerraformProperty<string>>("next_hop_ip");
        set => SetProperty("next_hop_ip", value);
    }

    /// <summary>
    /// URL to a VpnTunnel that should handle matching packets.
    /// </summary>
    public TerraformProperty<string> NextHopVpnTunnel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("next_hop_vpn_tunnel");
        set => SetProperty("next_hop_vpn_tunnel", value);
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
    public TerraformProperty<double> Priority
    {
        get => GetRequiredOutput<TerraformProperty<double>>("priority");
        set => SetProperty("priority", value);
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
    /// A list of instance tags to which this route applies.
    /// </summary>
    public HashSet<TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Params block(s) allowed")]
    public List<GoogleComputeRouteParamsBlock>? Params
    {
        set => SetProperty("params", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeRouteTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
