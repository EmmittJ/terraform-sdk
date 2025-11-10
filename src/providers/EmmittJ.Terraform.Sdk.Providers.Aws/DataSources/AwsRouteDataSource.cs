using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRouteDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
    public TerraformProperty<string>? CarrierGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("carrier_gateway_id");
        set => this.WithProperty("carrier_gateway_id", value);
    }

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CoreNetworkArn
    {
        get => GetProperty<TerraformProperty<string>>("core_network_arn");
        set => this.WithProperty("core_network_arn", value);
    }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationCidrBlock
    {
        get => GetProperty<TerraformProperty<string>>("destination_cidr_block");
        set => this.WithProperty("destination_cidr_block", value);
    }

    /// <summary>
    /// The destination_ipv6_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationIpv6CidrBlock
    {
        get => GetProperty<TerraformProperty<string>>("destination_ipv6_cidr_block");
        set => this.WithProperty("destination_ipv6_cidr_block", value);
    }

    /// <summary>
    /// The destination_prefix_list_id attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationPrefixListId
    {
        get => GetProperty<TerraformProperty<string>>("destination_prefix_list_id");
        set => this.WithProperty("destination_prefix_list_id", value);
    }

    /// <summary>
    /// The egress_only_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? EgressOnlyGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("egress_only_gateway_id");
        set => this.WithProperty("egress_only_gateway_id", value);
    }

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? GatewayId
    {
        get => GetProperty<TerraformProperty<string>>("gateway_id");
        set => this.WithProperty("gateway_id", value);
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
    /// The instance_id attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceId
    {
        get => GetProperty<TerraformProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
    }

    /// <summary>
    /// The local_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? LocalGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("local_gateway_id");
        set => this.WithProperty("local_gateway_id", value);
    }

    /// <summary>
    /// The nat_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? NatGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("nat_gateway_id");
        set => this.WithProperty("nat_gateway_id", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkInterfaceId
    {
        get => GetProperty<TerraformProperty<string>>("network_interface_id");
        set => this.WithProperty("network_interface_id", value);
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
    /// The route_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteTableId is required")]
    public required TerraformProperty<string> RouteTableId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("route_table_id");
        set => this.WithProperty("route_table_id", value);
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
    /// The vpc_peering_connection_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcPeeringConnectionId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_peering_connection_id");
        set => this.WithProperty("vpc_peering_connection_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRouteDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsRouteDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
