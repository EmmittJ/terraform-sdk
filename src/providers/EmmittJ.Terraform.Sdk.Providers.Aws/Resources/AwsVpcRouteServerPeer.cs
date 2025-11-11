using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for bgp_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsVpcRouteServerPeerBgpOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAsn is required")]
    [TerraformProperty("peer_asn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> PeerAsn { get; set; }

    /// <summary>
    /// The peer_liveness_detection attribute.
    /// </summary>
    [TerraformProperty("peer_liveness_detection")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PeerLivenessDetection { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsVpcRouteServerPeerTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_vpc_route_server_peer resource.
/// </summary>
public partial class AwsVpcRouteServerPeer : TerraformResource
{
    public AwsVpcRouteServerPeer(string name) : base("aws_vpc_route_server_peer", name)
    {
    }

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAddress is required")]
    [TerraformProperty("peer_address")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PeerAddress { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The route_server_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteServerEndpointId is required")]
    [TerraformProperty("route_server_endpoint_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RouteServerEndpointId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for bgp_options.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("bgp_options")]
    public TerraformList<TerraformBlock<AwsVpcRouteServerPeerBgpOptionsBlock>>? BgpOptions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsVpcRouteServerPeerTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The endpoint_eni_address attribute.
    /// </summary>
    [TerraformProperty("endpoint_eni_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EndpointEniAddress { get; }

    /// <summary>
    /// The endpoint_eni_id attribute.
    /// </summary>
    [TerraformProperty("endpoint_eni_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EndpointEniId { get; }

    /// <summary>
    /// The route_server_id attribute.
    /// </summary>
    [TerraformProperty("route_server_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RouteServerId { get; }

    /// <summary>
    /// The route_server_peer_id attribute.
    /// </summary>
    [TerraformProperty("route_server_peer_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RouteServerPeerId { get; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SubnetId { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VpcId { get; }

}
