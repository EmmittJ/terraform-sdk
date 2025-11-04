using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_route_server_endpoint resource.
/// </summary>
public class AwsVpcRouteServerEndpoint : TerraformResource
{
    public AwsVpcRouteServerEndpoint(string name) : base("aws_vpc_route_server_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("eni_address");
        this.DeclareOutput("eni_id");
        this.DeclareOutput("route_server_endpoint_id");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The route_server_id attribute.
    /// </summary>
    public string? RouteServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("route_server_id")?.Value;
        set => this.WithProperty("route_server_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The eni_address attribute.
    /// </summary>
    public TerraformExpression EniAddress => this["eni_address"];

    /// <summary>
    /// The eni_id attribute.
    /// </summary>
    public TerraformExpression EniId => this["eni_id"];

    /// <summary>
    /// The route_server_endpoint_id attribute.
    /// </summary>
    public TerraformExpression RouteServerEndpointId => this["route_server_endpoint_id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
