using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRouteDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CarrierGatewayId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "carrier_gateway_id");

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    [TerraformPropertyName("core_network_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CoreNetworkArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "core_network_arn");

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("destination_cidr_block")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DestinationCidrBlock { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "destination_cidr_block");

    /// <summary>
    /// The destination_ipv6_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("destination_ipv6_cidr_block")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DestinationIpv6CidrBlock { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "destination_ipv6_cidr_block");

    /// <summary>
    /// The destination_prefix_list_id attribute.
    /// </summary>
    [TerraformPropertyName("destination_prefix_list_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DestinationPrefixListId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "destination_prefix_list_id");

    /// <summary>
    /// The egress_only_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("egress_only_gateway_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EgressOnlyGatewayId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "egress_only_gateway_id");

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("gateway_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> GatewayId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gateway_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [TerraformPropertyName("instance_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> InstanceId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_id");

    /// <summary>
    /// The local_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("local_gateway_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LocalGatewayId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "local_gateway_id");

    /// <summary>
    /// The nat_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("nat_gateway_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NatGatewayId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "nat_gateway_id");

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TransitGatewayId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transit_gateway_id");

    /// <summary>
    /// The vpc_peering_connection_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_peering_connection_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VpcPeeringConnectionId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_peering_connection_id");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRouteDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

}
