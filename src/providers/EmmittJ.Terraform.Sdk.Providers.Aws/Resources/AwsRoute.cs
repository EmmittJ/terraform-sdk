using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRouteTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_route resource.
/// </summary>
public class AwsRoute : TerraformResource
{
    public AwsRoute(string name) : base("aws_route", name)
    {
    }

    /// <summary>
    /// The carrier_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("carrier_gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CarrierGatewayId { get; set; }

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    [TerraformPropertyName("core_network_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CoreNetworkArn { get; set; }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("destination_cidr_block")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DestinationCidrBlock { get; set; }

    /// <summary>
    /// The destination_ipv6_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("destination_ipv6_cidr_block")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DestinationIpv6CidrBlock { get; set; }

    /// <summary>
    /// The destination_prefix_list_id attribute.
    /// </summary>
    [TerraformPropertyName("destination_prefix_list_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DestinationPrefixListId { get; set; }

    /// <summary>
    /// The egress_only_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("egress_only_gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EgressOnlyGatewayId { get; set; }

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GatewayId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The local_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("local_gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LocalGatewayId { get; set; }

    /// <summary>
    /// The nat_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("nat_gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NatGatewayId { get; set; }

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
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TransitGatewayId { get; set; }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VpcEndpointId { get; set; }

    /// <summary>
    /// The vpc_peering_connection_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_peering_connection_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VpcPeeringConnectionId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRouteTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [TerraformPropertyName("instance_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InstanceId => new TerraformReference(this, "instance_id");

    /// <summary>
    /// The instance_owner_id attribute.
    /// </summary>
    [TerraformPropertyName("instance_owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InstanceOwnerId => new TerraformReference(this, "instance_owner_id");

    /// <summary>
    /// The origin attribute.
    /// </summary>
    [TerraformPropertyName("origin")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Origin => new TerraformReference(this, "origin");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

}
