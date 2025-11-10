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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("instance_id");
        SetOutput("instance_owner_id");
        SetOutput("origin");
        SetOutput("state");
        SetOutput("carrier_gateway_id");
        SetOutput("core_network_arn");
        SetOutput("destination_cidr_block");
        SetOutput("destination_ipv6_cidr_block");
        SetOutput("destination_prefix_list_id");
        SetOutput("egress_only_gateway_id");
        SetOutput("gateway_id");
        SetOutput("id");
        SetOutput("local_gateway_id");
        SetOutput("nat_gateway_id");
        SetOutput("network_interface_id");
        SetOutput("region");
        SetOutput("route_table_id");
        SetOutput("transit_gateway_id");
        SetOutput("vpc_endpoint_id");
        SetOutput("vpc_peering_connection_id");
    }

    /// <summary>
    /// The carrier_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string> CarrierGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("carrier_gateway_id");
        set => SetProperty("carrier_gateway_id", value);
    }

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    public TerraformProperty<string> CoreNetworkArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("core_network_arn");
        set => SetProperty("core_network_arn", value);
    }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string> DestinationCidrBlock
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_cidr_block");
        set => SetProperty("destination_cidr_block", value);
    }

    /// <summary>
    /// The destination_ipv6_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string> DestinationIpv6CidrBlock
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_ipv6_cidr_block");
        set => SetProperty("destination_ipv6_cidr_block", value);
    }

    /// <summary>
    /// The destination_prefix_list_id attribute.
    /// </summary>
    public TerraformProperty<string> DestinationPrefixListId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_prefix_list_id");
        set => SetProperty("destination_prefix_list_id", value);
    }

    /// <summary>
    /// The egress_only_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string> EgressOnlyGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("egress_only_gateway_id");
        set => SetProperty("egress_only_gateway_id", value);
    }

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    public TerraformProperty<string> GatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gateway_id");
        set => SetProperty("gateway_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The local_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string> LocalGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("local_gateway_id");
        set => SetProperty("local_gateway_id", value);
    }

    /// <summary>
    /// The nat_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string> NatGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("nat_gateway_id");
        set => SetProperty("nat_gateway_id", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformProperty<string> NetworkInterfaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_interface_id");
        set => SetProperty("network_interface_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The route_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteTableId is required")]
    public required TerraformProperty<string> RouteTableId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("route_table_id");
        set => SetProperty("route_table_id", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string> TransitGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transit_gateway_id");
        set => SetProperty("transit_gateway_id", value);
    }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string> VpcEndpointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_endpoint_id");
        set => SetProperty("vpc_endpoint_id", value);
    }

    /// <summary>
    /// The vpc_peering_connection_id attribute.
    /// </summary>
    public TerraformProperty<string> VpcPeeringConnectionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_peering_connection_id");
        set => SetProperty("vpc_peering_connection_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRouteTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
