using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for bgp_options in AwsVpcRouteServerPeer.
/// Nesting mode: list
/// </summary>
public class AwsVpcRouteServerPeerBgpOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bgp_options";

    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAsn is required")]
    public required TerraformValue<double> PeerAsn
    {
        get => GetRequiredArgument<TerraformValue<double>>("peer_asn");
        set => SetArgument("peer_asn", value);
    }

    /// <summary>
    /// The peer_liveness_detection attribute.
    /// </summary>
    public TerraformValue<string> PeerLivenessDetection
    {
        get => GetArgument<TerraformValue<string>>("peer_liveness_detection") ?? AsReference("peer_liveness_detection");
        set => SetArgument("peer_liveness_detection", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsVpcRouteServerPeer.
/// Nesting mode: single
/// </summary>
public class AwsVpcRouteServerPeerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_vpc_route_server_peer Terraform resource.
/// Manages a aws_vpc_route_server_peer resource.
/// </summary>
public partial class AwsVpcRouteServerPeer(string name) : TerraformResource("aws_vpc_route_server_peer", name)
{
    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAddress is required")]
    public required TerraformValue<string> PeerAddress
    {
        get => GetRequiredArgument<TerraformValue<string>>("peer_address");
        set => SetArgument("peer_address", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The route_server_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteServerEndpointId is required")]
    public required TerraformValue<string> RouteServerEndpointId
    {
        get => GetRequiredArgument<TerraformValue<string>>("route_server_endpoint_id");
        set => SetArgument("route_server_endpoint_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The endpoint_eni_address attribute.
    /// </summary>
    public TerraformValue<string> EndpointEniAddress
        => AsReference("endpoint_eni_address");

    /// <summary>
    /// The endpoint_eni_id attribute.
    /// </summary>
    public TerraformValue<string> EndpointEniId
        => AsReference("endpoint_eni_id");

    /// <summary>
    /// The route_server_id attribute.
    /// </summary>
    public TerraformValue<string> RouteServerId
        => AsReference("route_server_id");

    /// <summary>
    /// The route_server_peer_id attribute.
    /// </summary>
    public TerraformValue<string> RouteServerPeerId
        => AsReference("route_server_peer_id");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
        => AsReference("subnet_id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => AsReference("vpc_id");

    /// <summary>
    /// BgpOptions block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVpcRouteServerPeerBgpOptionsBlock>? BgpOptions
    {
        get => GetArgument<TerraformList<AwsVpcRouteServerPeerBgpOptionsBlock>>("bgp_options");
        set => SetArgument("bgp_options", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpcRouteServerPeerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpcRouteServerPeerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
