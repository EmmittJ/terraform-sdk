using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpnGatewayRoutePropagationTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a aws_vpn_gateway_route_propagation resource.
/// </summary>
public class AwsVpnGatewayRoutePropagation : TerraformResource
{
    public AwsVpnGatewayRoutePropagation(string name) : base("aws_vpn_gateway_route_propagation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
        get => GetProperty<TerraformProperty<string>>("route_table_id");
        set => this.WithProperty("route_table_id", value);
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnGatewayId is required")]
    public required TerraformProperty<string> VpnGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("vpn_gateway_id");
        set => this.WithProperty("vpn_gateway_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpnGatewayRoutePropagationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsVpnGatewayRoutePropagationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
