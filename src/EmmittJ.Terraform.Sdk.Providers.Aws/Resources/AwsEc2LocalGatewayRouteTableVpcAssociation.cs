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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The local_gateway_route_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalGatewayRouteTableId is required")]
    public required TerraformProperty<string> LocalGatewayRouteTableId
    {
        get => GetProperty<TerraformProperty<string>>("local_gateway_route_table_id");
        set => this.WithProperty("local_gateway_route_table_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
    }

    /// <summary>
    /// The local_gateway_id attribute.
    /// </summary>
    public TerraformExpression LocalGatewayId => this["local_gateway_id"];

}
