using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_local_gateway_route resource.
/// </summary>
public class AwsEc2LocalGatewayRoute : TerraformResource
{
    public AwsEc2LocalGatewayRoute(string name) : base("aws_ec2_local_gateway_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    public string? DestinationCidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_cidr_block")?.Value;
        set => this.WithProperty("destination_cidr_block", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The local_gateway_route_table_id attribute.
    /// </summary>
    public string? LocalGatewayRouteTableId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("local_gateway_route_table_id")?.Value;
        set => this.WithProperty("local_gateway_route_table_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The local_gateway_virtual_interface_group_id attribute.
    /// </summary>
    public string? LocalGatewayVirtualInterfaceGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("local_gateway_virtual_interface_group_id")?.Value;
        set => this.WithProperty("local_gateway_virtual_interface_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
