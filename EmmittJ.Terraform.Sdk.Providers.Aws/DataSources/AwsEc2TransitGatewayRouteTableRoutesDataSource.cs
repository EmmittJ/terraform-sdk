using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_transit_gateway_route_table_routes.
/// </summary>
public class AwsEc2TransitGatewayRouteTableRoutesDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayRouteTableRoutesDataSource(string name) : base("aws_ec2_transit_gateway_route_table_routes", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("routes");
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
    /// The transit_gateway_route_table_id attribute.
    /// </summary>
    public string? TransitGatewayRouteTableId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_route_table_id")?.Value;
        set => this.WithProperty("transit_gateway_route_table_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routes attribute.
    /// </summary>
    public TerraformExpression Routes => this["routes"];

}
