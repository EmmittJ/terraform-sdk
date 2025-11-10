using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for params in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouteParamsBlock : ITerraformBlock
{
    /// <summary>
    /// Resource manager tags to be bound to the route. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456. The field is ignored when empty.
    /// The field is immutable and causes resource replacement when mutated. This field is only
    /// set at create time and modifying this field after creation will trigger recreation.
    /// To apply tags to an existing resource, see the google_tags_tag_binding resource.
    /// </summary>
    [TerraformPropertyName("resource_manager_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? ResourceManagerTags { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRouteTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a google_compute_route resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeRoute : TerraformResource
{
    public GoogleComputeRoute(string name) : base("google_compute_route", name)
    {
    }

    /// <summary>
    /// An optional description of this resource. Provide this property
    /// when you create the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The destination range of outgoing packets that this route applies to.
    /// Only IPv4 is supported.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestRange is required")]
    [TerraformPropertyName("dest_range")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DestRange { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The network that this route applies to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformPropertyName("network")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Network { get; set; }

    /// <summary>
    /// URL to a gateway that should handle matching packets.
    /// Currently, you can only specify the internet gateway, using a full or
    /// partial valid URL:
    /// * &#39;https://www.googleapis.com/compute/v1/projects/project/global/gateways/default-internet-gateway&#39;
    /// * &#39;projects/project/global/gateways/default-internet-gateway&#39;
    /// * &#39;global/gateways/default-internet-gateway&#39;
    /// * The string &#39;default-internet-gateway&#39;.
    /// </summary>
    [TerraformPropertyName("next_hop_gateway")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NextHopGateway { get; set; }

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
    [TerraformPropertyName("next_hop_ilb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NextHopIlb { get; set; }

    /// <summary>
    /// URL to an instance that should handle matching packets.
    /// You can specify this as a full or partial URL. For example:
    /// * &#39;https://www.googleapis.com/compute/v1/projects/project/zones/zone/instances/instance&#39;
    /// * &#39;projects/project/zones/zone/instances/instance&#39;
    /// * &#39;zones/zone/instances/instance&#39;
    /// * Just the instance name, with the zone in &#39;next_hop_instance_zone&#39;.
    /// </summary>
    [TerraformPropertyName("next_hop_instance")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NextHopInstance { get; set; }

    /// <summary>
    /// The zone of the instance specified in next_hop_instance. Omit if next_hop_instance is specified as a URL.
    /// </summary>
    [TerraformPropertyName("next_hop_instance_zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NextHopInstanceZone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "next_hop_instance_zone");

    /// <summary>
    /// Network IP address of an instance that should handle matching packets.
    /// </summary>
    [TerraformPropertyName("next_hop_ip")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NextHopIp { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "next_hop_ip");

    /// <summary>
    /// URL to a VpnTunnel that should handle matching packets.
    /// </summary>
    [TerraformPropertyName("next_hop_vpn_tunnel")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NextHopVpnTunnel { get; set; }

    /// <summary>
    /// The priority of this route. Priority is used to break ties in cases
    /// where there is more than one matching route of equal prefix length.
    /// 
    /// In the case of two routes with equal prefix length, the one with the
    /// lowest-numbered priority value wins.
    /// 
    /// Default value is 1000. Valid range is 0 through 65535.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Priority { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// A list of instance tags to which this route applies.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Params block(s) allowed")]
    [TerraformPropertyName("params")]
    public TerraformList<TerraformBlock<GoogleComputeRouteParamsBlock>>? Params { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeRouteTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The as_paths attribute.
    /// </summary>
    [TerraformPropertyName("as_paths")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AsPaths => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "as_paths");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// The hub network that should handle matching packets, which should conform to RFC1035.
    /// </summary>
    [TerraformPropertyName("next_hop_hub")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NextHopHub => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "next_hop_hub");

    /// <summary>
    /// Internal fixed region-to-region cost that Google Cloud calculates based on factors such as network performance, distance, and available bandwidth between regions.
    /// </summary>
    [TerraformPropertyName("next_hop_inter_region_cost")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NextHopInterRegionCost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "next_hop_inter_region_cost");

    /// <summary>
    /// Multi-Exit Discriminator, a BGP route metric that indicates the desirability of a particular route in a network.
    /// </summary>
    [TerraformPropertyName("next_hop_med")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NextHopMed => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "next_hop_med");

    /// <summary>
    /// URL to a Network that should handle matching packets.
    /// </summary>
    [TerraformPropertyName("next_hop_network")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NextHopNetwork => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "next_hop_network");

    /// <summary>
    /// Indicates the origin of the route. Can be IGP (Interior Gateway Protocol), EGP (Exterior Gateway Protocol), or INCOMPLETE.
    /// </summary>
    [TerraformPropertyName("next_hop_origin")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NextHopOrigin => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "next_hop_origin");

    /// <summary>
    /// The network peering name that should handle matching packets, which should conform to RFC1035.
    /// </summary>
    [TerraformPropertyName("next_hop_peering")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NextHopPeering => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "next_hop_peering");

    /// <summary>
    /// The status of the route, which can be one of the following values:
    /// - &#39;ACTIVE&#39; for an active route
    /// - &#39;INACTIVE&#39; for an inactive route
    /// </summary>
    [TerraformPropertyName("route_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RouteStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "route_status");

    /// <summary>
    /// The type of this route, which can be one of the following values:
    /// - &#39;TRANSIT&#39; for a transit route that this router learned from another Cloud Router and will readvertise to one of its BGP peers
    /// - &#39;SUBNET&#39; for a route from a subnet of the VPC
    /// - &#39;BGP&#39; for a route learned from a BGP peer of this router
    /// - &#39;STATIC&#39; for a static route
    /// </summary>
    [TerraformPropertyName("route_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RouteType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "route_type");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// If potential misconfigurations are detected for this route, this field will be populated with warning messages.
    /// </summary>
    [TerraformPropertyName("warnings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Warnings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "warnings");

}
