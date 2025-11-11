using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for bgp_options in .
/// Nesting mode: list
/// </summary>
public class AwsVpcRouteServerPeerBgpOptionsBlock
{
    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAsn is required")]
    [TerraformPropertyName("peer_asn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> PeerAsn { get; set; }

    /// <summary>
    /// The peer_liveness_detection attribute.
    /// </summary>
    [TerraformPropertyName("peer_liveness_detection")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PeerLivenessDetection { get; set; } = default!;

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcRouteServerPeerTimeoutsBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_vpc_route_server_peer resource.
/// </summary>
public class AwsVpcRouteServerPeer : TerraformResource
{
    public AwsVpcRouteServerPeer(string name) : base("aws_vpc_route_server_peer", name)
    {
    }

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAddress is required")]
    [TerraformPropertyName("peer_address")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PeerAddress { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The route_server_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteServerEndpointId is required")]
    [TerraformPropertyName("route_server_endpoint_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RouteServerEndpointId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for bgp_options.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("bgp_options")]
    public TerraformList<TerraformBlock<AwsVpcRouteServerPeerBgpOptionsBlock>>? BgpOptions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcRouteServerPeerTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The endpoint_eni_address attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_eni_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EndpointEniAddress => new TerraformReference(this, "endpoint_eni_address");

    /// <summary>
    /// The endpoint_eni_id attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_eni_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EndpointEniId => new TerraformReference(this, "endpoint_eni_id");

    /// <summary>
    /// The route_server_id attribute.
    /// </summary>
    [TerraformPropertyName("route_server_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RouteServerId => new TerraformReference(this, "route_server_id");

    /// <summary>
    /// The route_server_peer_id attribute.
    /// </summary>
    [TerraformPropertyName("route_server_peer_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RouteServerPeerId => new TerraformReference(this, "route_server_peer_id");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SubnetId => new TerraformReference(this, "subnet_id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpcId => new TerraformReference(this, "vpc_id");

}
