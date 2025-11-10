using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRouteTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_route resource.
/// </summary>
public class AwsRoute : TerraformResource
{
    public AwsRoute(string name) : base("aws_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("instance_id");
        this.WithOutput("instance_owner_id");
        this.WithOutput("origin");
        this.WithOutput("state");
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
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_endpoint_id");
        set => this.WithProperty("vpc_endpoint_id", value);
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
    public AwsRouteTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsRouteTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    public TerraformExpression InstanceId => this["instance_id"];

    /// <summary>
    /// The instance_owner_id attribute.
    /// </summary>
    public TerraformExpression InstanceOwnerId => this["instance_owner_id"];

    /// <summary>
    /// The origin attribute.
    /// </summary>
    public TerraformExpression Origin => this["origin"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
