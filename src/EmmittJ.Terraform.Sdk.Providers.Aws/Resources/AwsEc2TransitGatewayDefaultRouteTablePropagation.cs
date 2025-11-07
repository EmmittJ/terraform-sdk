using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_default_route_table_propagation resource.
/// </summary>
public class AwsEc2TransitGatewayDefaultRouteTablePropagation : TerraformResource
{
    public AwsEc2TransitGatewayDefaultRouteTablePropagation(string name) : base("aws_ec2_transit_gateway_default_route_table_propagation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("original_default_route_table_id");
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
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? TransitGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("transit_gateway_id");
        set => this.WithProperty("transit_gateway_id", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The original_default_route_table_id attribute.
    /// </summary>
    public TerraformExpression OriginalDefaultRouteTableId => this["original_default_route_table_id"];

}
