using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsRouteDataSource.
/// Nesting mode: single
/// </summary>
public class AwsRouteDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_route Terraform data source.
/// Retrieves information about a aws_route.
/// </summary>
public partial class AwsRouteDataSource(string name) : TerraformDataSource("aws_route", name)
{
    /// <summary>
    /// The carrier_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> CarrierGatewayId
    {
        get => GetArgument<TerraformValue<string>>("carrier_gateway_id") ?? CreateReference("carrier_gateway_id");
        set => SetArgument("carrier_gateway_id", value);
    }

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    public TerraformValue<string> CoreNetworkArn
    {
        get => GetArgument<TerraformValue<string>>("core_network_arn") ?? CreateReference("core_network_arn");
        set => SetArgument("core_network_arn", value);
    }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    public TerraformValue<string> DestinationCidrBlock
    {
        get => GetArgument<TerraformValue<string>>("destination_cidr_block") ?? CreateReference("destination_cidr_block");
        set => SetArgument("destination_cidr_block", value);
    }

    /// <summary>
    /// The destination_ipv6_cidr_block attribute.
    /// </summary>
    public TerraformValue<string> DestinationIpv6CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("destination_ipv6_cidr_block") ?? CreateReference("destination_ipv6_cidr_block");
        set => SetArgument("destination_ipv6_cidr_block", value);
    }

    /// <summary>
    /// The destination_prefix_list_id attribute.
    /// </summary>
    public TerraformValue<string> DestinationPrefixListId
    {
        get => GetArgument<TerraformValue<string>>("destination_prefix_list_id") ?? CreateReference("destination_prefix_list_id");
        set => SetArgument("destination_prefix_list_id", value);
    }

    /// <summary>
    /// The egress_only_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> EgressOnlyGatewayId
    {
        get => GetArgument<TerraformValue<string>>("egress_only_gateway_id") ?? CreateReference("egress_only_gateway_id");
        set => SetArgument("egress_only_gateway_id", value);
    }

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    public TerraformValue<string> GatewayId
    {
        get => GetArgument<TerraformValue<string>>("gateway_id") ?? CreateReference("gateway_id");
        set => SetArgument("gateway_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    public TerraformValue<string> InstanceId
    {
        get => GetArgument<TerraformValue<string>>("instance_id") ?? CreateReference("instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// The local_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> LocalGatewayId
    {
        get => GetArgument<TerraformValue<string>>("local_gateway_id") ?? CreateReference("local_gateway_id");
        set => SetArgument("local_gateway_id", value);
    }

    /// <summary>
    /// The nat_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> NatGatewayId
    {
        get => GetArgument<TerraformValue<string>>("nat_gateway_id") ?? CreateReference("nat_gateway_id");
        set => SetArgument("nat_gateway_id", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInterfaceId
    {
        get => GetArgument<TerraformValue<string>>("network_interface_id") ?? CreateReference("network_interface_id");
        set => SetArgument("network_interface_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The route_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteTableId is required")]
    public required TerraformValue<string> RouteTableId
    {
        get => GetRequiredArgument<TerraformValue<string>>("route_table_id");
        set => SetArgument("route_table_id", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayId
    {
        get => GetArgument<TerraformValue<string>>("transit_gateway_id") ?? CreateReference("transit_gateway_id");
        set => SetArgument("transit_gateway_id", value);
    }

    /// <summary>
    /// The vpc_peering_connection_id attribute.
    /// </summary>
    public TerraformValue<string> VpcPeeringConnectionId
    {
        get => GetArgument<TerraformValue<string>>("vpc_peering_connection_id") ?? CreateReference("vpc_peering_connection_id");
        set => SetArgument("vpc_peering_connection_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRouteDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRouteDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
