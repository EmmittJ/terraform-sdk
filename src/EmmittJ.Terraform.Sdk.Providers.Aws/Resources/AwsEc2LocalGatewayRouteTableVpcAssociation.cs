using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_local_gateway_route_table_vpc_association resource.
/// </summary>
public class AwsEc2LocalGatewayRouteTableVpcAssociation : TerraformResource
{
    public AwsEc2LocalGatewayRouteTableVpcAssociation(string name) : base("aws_ec2_local_gateway_route_table_vpc_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("local_gateway_id");
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
    /// The local_gateway_route_table_id attribute.
    /// </summary>
    public string? LocalGatewayRouteTableId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("local_gateway_route_table_id")?.Value;
        set => this.WithProperty("local_gateway_route_table_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public string? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id")?.Value;
        set => this.WithProperty("vpc_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The local_gateway_id attribute.
    /// </summary>
    public TerraformExpression LocalGatewayId => this["local_gateway_id"];

}
