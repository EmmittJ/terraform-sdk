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
    public string? CarrierGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("carrier_gateway_id")?.Value;
        set => this.WithProperty("carrier_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    public string? CoreNetworkArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("core_network_arn")?.Value;
        set => this.WithProperty("core_network_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    public string? DestinationCidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_cidr_block")?.Value;
        set => this.WithProperty("destination_cidr_block", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination_ipv6_cidr_block attribute.
    /// </summary>
    public string? DestinationIpv6CidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_ipv6_cidr_block")?.Value;
        set => this.WithProperty("destination_ipv6_cidr_block", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination_prefix_list_id attribute.
    /// </summary>
    public string? DestinationPrefixListId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_prefix_list_id")?.Value;
        set => this.WithProperty("destination_prefix_list_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The egress_only_gateway_id attribute.
    /// </summary>
    public string? EgressOnlyGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("egress_only_gateway_id")?.Value;
        set => this.WithProperty("egress_only_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    public string? GatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gateway_id")?.Value;
        set => this.WithProperty("gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The instance_id attribute.
    /// </summary>
    public string? InstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_id")?.Value;
        set => this.WithProperty("instance_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The local_gateway_id attribute.
    /// </summary>
    public string? LocalGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("local_gateway_id")?.Value;
        set => this.WithProperty("local_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The nat_gateway_id attribute.
    /// </summary>
    public string? NatGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("nat_gateway_id")?.Value;
        set => this.WithProperty("nat_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public string? NetworkInterfaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_interface_id")?.Value;
        set => this.WithProperty("network_interface_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The route_table_id attribute.
    /// </summary>
    public string? RouteTableId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("route_table_id")?.Value;
        set => this.WithProperty("route_table_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public string? TransitGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_id")?.Value;
        set => this.WithProperty("transit_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpc_peering_connection_id attribute.
    /// </summary>
    public string? VpcPeeringConnectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_peering_connection_id")?.Value;
        set => this.WithProperty("vpc_peering_connection_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
