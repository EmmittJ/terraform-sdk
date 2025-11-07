using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route.
/// </summary>
public class AwsRouteDataSource : TerraformDataSource
{
    public AwsRouteDataSource(string name) : base("aws_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The carrier_gateway_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CarrierGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("carrier_gateway_id");
        set => this.WithProperty("carrier_gateway_id", value);
    }

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CoreNetworkArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("core_network_arn");
        set => this.WithProperty("core_network_arn", value);
    }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DestinationCidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_cidr_block");
        set => this.WithProperty("destination_cidr_block", value);
    }

    /// <summary>
    /// The destination_ipv6_cidr_block attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DestinationIpv6CidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_ipv6_cidr_block");
        set => this.WithProperty("destination_ipv6_cidr_block", value);
    }

    /// <summary>
    /// The destination_prefix_list_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DestinationPrefixListId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_prefix_list_id");
        set => this.WithProperty("destination_prefix_list_id", value);
    }

    /// <summary>
    /// The egress_only_gateway_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EgressOnlyGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("egress_only_gateway_id");
        set => this.WithProperty("egress_only_gateway_id", value);
    }

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gateway_id");
        set => this.WithProperty("gateway_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
    }

    /// <summary>
    /// The local_gateway_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LocalGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("local_gateway_id");
        set => this.WithProperty("local_gateway_id", value);
    }

    /// <summary>
    /// The nat_gateway_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NatGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("nat_gateway_id");
        set => this.WithProperty("nat_gateway_id", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkInterfaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_interface_id");
        set => this.WithProperty("network_interface_id", value);
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
    /// The route_table_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RouteTableId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("route_table_id");
        set => this.WithProperty("route_table_id", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TransitGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_id");
        set => this.WithProperty("transit_gateway_id", value);
    }

    /// <summary>
    /// The vpc_peering_connection_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VpcPeeringConnectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_peering_connection_id");
        set => this.WithProperty("vpc_peering_connection_id", value);
    }

}
