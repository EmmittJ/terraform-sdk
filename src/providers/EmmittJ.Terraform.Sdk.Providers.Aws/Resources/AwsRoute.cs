using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRouteTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_route resource.
/// </summary>
public partial class AwsRoute : TerraformResource
{
    public AwsRoute(string name) : base("aws_route", name)
    {
    }

    /// <summary>
    /// The carrier_gateway_id attribute.
    /// </summary>
    [TerraformProperty("carrier_gateway_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CarrierGatewayId { get; set; }

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    [TerraformProperty("core_network_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CoreNetworkArn { get; set; }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    [TerraformProperty("destination_cidr_block")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DestinationCidrBlock { get; set; }

    /// <summary>
    /// The destination_ipv6_cidr_block attribute.
    /// </summary>
    [TerraformProperty("destination_ipv6_cidr_block")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DestinationIpv6CidrBlock { get; set; }

    /// <summary>
    /// The destination_prefix_list_id attribute.
    /// </summary>
    [TerraformProperty("destination_prefix_list_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DestinationPrefixListId { get; set; }

    /// <summary>
    /// The egress_only_gateway_id attribute.
    /// </summary>
    [TerraformProperty("egress_only_gateway_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EgressOnlyGatewayId { get; set; }

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    [TerraformProperty("gateway_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GatewayId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The local_gateway_id attribute.
    /// </summary>
    [TerraformProperty("local_gateway_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LocalGatewayId { get; set; }

    /// <summary>
    /// The nat_gateway_id attribute.
    /// </summary>
    [TerraformProperty("nat_gateway_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NatGatewayId { get; set; }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformProperty("network_interface_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NetworkInterfaceId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The route_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteTableId is required")]
    [TerraformProperty("route_table_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RouteTableId { get; set; }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TransitGatewayId { get; set; }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    [TerraformProperty("vpc_endpoint_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VpcEndpointId { get; set; }

    /// <summary>
    /// The vpc_peering_connection_id attribute.
    /// </summary>
    [TerraformProperty("vpc_peering_connection_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VpcPeeringConnectionId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsRouteTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [TerraformProperty("instance_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InstanceId { get; }

    /// <summary>
    /// The instance_owner_id attribute.
    /// </summary>
    [TerraformProperty("instance_owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InstanceOwnerId { get; }

    /// <summary>
    /// The origin attribute.
    /// </summary>
    [TerraformProperty("origin")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Origin { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
