using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRouteTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? CarrierGatewayId { get; set; }

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    [TerraformPropertyName("core_network_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CoreNetworkArn { get; set; }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("destination_cidr_block")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DestinationCidrBlock { get; set; }

    /// <summary>
    /// The destination_ipv6_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("destination_ipv6_cidr_block")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DestinationIpv6CidrBlock { get; set; }

    /// <summary>
    /// The destination_prefix_list_id attribute.
    /// </summary>
    [TerraformPropertyName("destination_prefix_list_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DestinationPrefixListId { get; set; }

    /// <summary>
    /// The egress_only_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("egress_only_gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EgressOnlyGatewayId { get; set; }

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GatewayId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The local_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("local_gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LocalGatewayId { get; set; }

    /// <summary>
    /// The nat_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("nat_gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NatGatewayId { get; set; }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NetworkInterfaceId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_interface_id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The route_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteTableId is required")]
    [TerraformPropertyName("route_table_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RouteTableId { get; set; }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TransitGatewayId { get; set; }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VpcEndpointId { get; set; }

    /// <summary>
    /// The vpc_peering_connection_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_peering_connection_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VpcPeeringConnectionId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRouteTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [TerraformPropertyName("instance_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_id");

    /// <summary>
    /// The instance_owner_id attribute.
    /// </summary>
    [TerraformPropertyName("instance_owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceOwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_owner_id");

    /// <summary>
    /// The origin attribute.
    /// </summary>
    [TerraformPropertyName("origin")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Origin => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "origin");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
