using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public TerraformProperty<string>? RouteTableId
    {
        get => GetProperty<TerraformProperty<string>>("route_table_id");
        set => this.WithProperty("route_table_id", value);
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpnGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("vpn_gateway_id");
        set => this.WithProperty("vpn_gateway_id", value);
    }

}
