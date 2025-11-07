using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("arn");
        this.DeclareOutput("endpoint_eni_address");
        this.DeclareOutput("endpoint_eni_id");
        this.DeclareOutput("route_server_id");
        this.DeclareOutput("route_server_peer_id");
        this.DeclareOutput("subnet_id");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PeerAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peer_address");
        set => this.WithProperty("peer_address", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The route_server_endpoint_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RouteServerEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("route_server_endpoint_id");
        set => this.WithProperty("route_server_endpoint_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
