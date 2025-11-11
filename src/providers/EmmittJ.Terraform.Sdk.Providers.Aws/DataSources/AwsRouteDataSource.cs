using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRouteDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_route.
/// </summary>
public partial class AwsRouteDataSource : TerraformDataSource
{
    public AwsRouteDataSource(string name) : base("aws_route", name)
    {
    }

    /// <summary>
    /// The carrier_gateway_id attribute.
    /// </summary>
    [TerraformProperty("carrier_gateway_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CarrierGatewayId { get; set; }

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    [TerraformProperty("core_network_arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CoreNetworkArn { get; set; }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    [TerraformProperty("destination_cidr_block")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DestinationCidrBlock { get; set; }

    /// <summary>
    /// The destination_ipv6_cidr_block attribute.
    /// </summary>
    [TerraformProperty("destination_ipv6_cidr_block")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DestinationIpv6CidrBlock { get; set; }

    /// <summary>
    /// The destination_prefix_list_id attribute.
    /// </summary>
    [TerraformProperty("destination_prefix_list_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DestinationPrefixListId { get; set; }

    /// <summary>
    /// The egress_only_gateway_id attribute.
    /// </summary>
    [TerraformProperty("egress_only_gateway_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EgressOnlyGatewayId { get; set; }

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    [TerraformProperty("gateway_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> GatewayId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [TerraformProperty("instance_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> InstanceId { get; set; }

    /// <summary>
    /// The local_gateway_id attribute.
    /// </summary>
    [TerraformProperty("local_gateway_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> LocalGatewayId { get; set; }

    /// <summary>
    /// The nat_gateway_id attribute.
    /// </summary>
    [TerraformProperty("nat_gateway_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NatGatewayId { get; set; }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformProperty("network_interface_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NetworkInterfaceId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The route_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteTableId is required")]
    [TerraformProperty("route_table_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RouteTableId { get; set; }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> TransitGatewayId { get; set; }

    /// <summary>
    /// The vpc_peering_connection_id attribute.
    /// </summary>
    [TerraformProperty("vpc_peering_connection_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> VpcPeeringConnectionId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsRouteDataSourceTimeoutsBlock>? Timeouts { get; set; }

}
