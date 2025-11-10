using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for bgp_options in .
/// Nesting mode: list
/// </summary>
public class AwsVpcRouteServerPeerBgpOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAsn is required")]
    [TerraformPropertyName("peer_asn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> PeerAsn { get; set; }

    /// <summary>
    /// The peer_liveness_detection attribute.
    /// </summary>
    [TerraformPropertyName("peer_liveness_detection")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PeerLivenessDetection { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "peer_liveness_detection");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcRouteServerPeerTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> PeerAddress { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The route_server_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteServerEndpointId is required")]
    [TerraformPropertyName("route_server_endpoint_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RouteServerEndpointId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for bgp_options.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("bgp_options")]
    public TerraformList<TerraformBlock<AwsVpcRouteServerPeerBgpOptionsBlock>>? BgpOptions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcRouteServerPeerTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The endpoint_eni_address attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_eni_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndpointEniAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_eni_address");

    /// <summary>
    /// The endpoint_eni_id attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_eni_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndpointEniId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_eni_id");

    /// <summary>
    /// The route_server_id attribute.
    /// </summary>
    [TerraformPropertyName("route_server_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RouteServerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "route_server_id");

    /// <summary>
    /// The route_server_peer_id attribute.
    /// </summary>
    [TerraformPropertyName("route_server_peer_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RouteServerPeerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "route_server_peer_id");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SubnetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnet_id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

}
