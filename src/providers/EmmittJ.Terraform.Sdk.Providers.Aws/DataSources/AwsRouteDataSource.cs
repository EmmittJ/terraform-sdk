using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRouteDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_route.
/// </summary>
public class AwsRouteDataSource : TerraformDataSource
{
    public AwsRouteDataSource(string name) : base("aws_route", name)
    {
    }

    /// <summary>
    /// The carrier_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("carrier_gateway_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CarrierGatewayId { get; set; } = default!;

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    [TerraformPropertyName("core_network_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CoreNetworkArn { get; set; } = default!;

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("destination_cidr_block")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DestinationCidrBlock { get; set; } = default!;

    /// <summary>
    /// The destination_ipv6_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("destination_ipv6_cidr_block")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DestinationIpv6CidrBlock { get; set; } = default!;

    /// <summary>
    /// The destination_prefix_list_id attribute.
    /// </summary>
    [TerraformPropertyName("destination_prefix_list_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DestinationPrefixListId { get; set; } = default!;

    /// <summary>
    /// The egress_only_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("egress_only_gateway_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EgressOnlyGatewayId { get; set; } = default!;

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("gateway_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> GatewayId { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [TerraformPropertyName("instance_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> InstanceId { get; set; } = default!;

    /// <summary>
    /// The local_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("local_gateway_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LocalGatewayId { get; set; } = default!;

    /// <summary>
    /// The nat_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("nat_gateway_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NatGatewayId { get; set; } = default!;

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NetworkInterfaceId { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The route_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteTableId is required")]
    [TerraformPropertyName("route_table_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RouteTableId { get; set; }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TransitGatewayId { get; set; } = default!;

    /// <summary>
    /// The vpc_peering_connection_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_peering_connection_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VpcPeeringConnectionId { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRouteDataSourceTimeoutsBlock>? Timeouts { get; set; }

}
