using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for bgp_options in .
/// Nesting mode: list
/// </summary>
public class AwsVpcRouteServerPeerBgpOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAsn is required")]
    public required TerraformProperty<double> PeerAsn
    {
        set => SetProperty("peer_asn", value);
    }

    /// <summary>
    /// The peer_liveness_detection attribute.
    /// </summary>
    public TerraformProperty<string>? PeerLivenessDetection
    {
        set => SetProperty("peer_liveness_detection", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcRouteServerPeerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_vpc_route_server_peer resource.
/// </summary>
public class AwsVpcRouteServerPeer : TerraformResource
{
    public AwsVpcRouteServerPeer(string name) : base("aws_vpc_route_server_peer", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("endpoint_eni_address");
        SetOutput("endpoint_eni_id");
        SetOutput("route_server_id");
        SetOutput("route_server_peer_id");
        SetOutput("subnet_id");
        SetOutput("tags_all");
        SetOutput("vpc_id");
        SetOutput("peer_address");
        SetOutput("region");
        SetOutput("route_server_endpoint_id");
        SetOutput("tags");
    }

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAddress is required")]
    public required TerraformProperty<string> PeerAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peer_address");
        set => SetProperty("peer_address", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The route_server_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteServerEndpointId is required")]
    public required TerraformProperty<string> RouteServerEndpointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("route_server_endpoint_id");
        set => SetProperty("route_server_endpoint_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for bgp_options.
    /// Nesting mode: list
    /// </summary>
    public List<AwsVpcRouteServerPeerBgpOptionsBlock>? BgpOptions
    {
        set => SetProperty("bgp_options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcRouteServerPeerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The endpoint_eni_address attribute.
    /// </summary>
    public TerraformExpression EndpointEniAddress => this["endpoint_eni_address"];

    /// <summary>
    /// The endpoint_eni_id attribute.
    /// </summary>
    public TerraformExpression EndpointEniId => this["endpoint_eni_id"];

    /// <summary>
    /// The route_server_id attribute.
    /// </summary>
    public TerraformExpression RouteServerId => this["route_server_id"];

    /// <summary>
    /// The route_server_peer_id attribute.
    /// </summary>
    public TerraformExpression RouteServerPeerId => this["route_server_peer_id"];

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformExpression SubnetId => this["subnet_id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
