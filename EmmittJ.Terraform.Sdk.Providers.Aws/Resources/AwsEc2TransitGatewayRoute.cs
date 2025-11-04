using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_route resource.
/// </summary>
public class AwsEc2TransitGatewayRoute : TerraformResource
{
    public AwsEc2TransitGatewayRoute(string name) : base("aws_ec2_transit_gateway_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The blackhole attribute.
    /// </summary>
    public bool? Blackhole
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("blackhole")?.Value;
        set => this.WithProperty("blackhole", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public string? TransitGatewayAttachmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_attachment_id")?.Value;
        set => this.WithProperty("transit_gateway_attachment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The transit_gateway_route_table_id attribute.
    /// </summary>
    public string? TransitGatewayRouteTableId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_route_table_id")?.Value;
        set => this.WithProperty("transit_gateway_route_table_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
