using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_transit_gateway_route_table_associations.
/// </summary>
public class AwsEc2TransitGatewayRouteTableAssociationsDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayRouteTableAssociationsDataSource(string name) : base("aws_ec2_transit_gateway_route_table_associations", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ids");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The transit_gateway_route_table_id attribute.
    /// </summary>
    public TerraformProperty<string>? TransitGatewayRouteTableId
    {
        get => GetProperty<TerraformProperty<string>>("transit_gateway_route_table_id");
        set => this.WithProperty("transit_gateway_route_table_id", value);
    }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    public TerraformExpression Ids => this["ids"];

}
