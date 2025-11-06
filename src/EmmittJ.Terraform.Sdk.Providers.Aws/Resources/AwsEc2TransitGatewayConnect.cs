using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_connect resource.
/// </summary>
public class AwsEc2TransitGatewayConnect : TerraformResource
{
    public AwsEc2TransitGatewayConnect(string name) : base("aws_ec2_transit_gateway_connect", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The protocol attribute.
    /// </summary>
    public string? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol")?.Value;
        set => this.WithProperty("protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The transit_gateway_default_route_table_association attribute.
    /// </summary>
    public bool? TransitGatewayDefaultRouteTableAssociation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("transit_gateway_default_route_table_association")?.Value;
        set => this.WithProperty("transit_gateway_default_route_table_association", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The transit_gateway_default_route_table_propagation attribute.
    /// </summary>
    public bool? TransitGatewayDefaultRouteTablePropagation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("transit_gateway_default_route_table_propagation")?.Value;
        set => this.WithProperty("transit_gateway_default_route_table_propagation", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public string? TransitGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_id")?.Value;
        set => this.WithProperty("transit_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The transport_attachment_id attribute.
    /// </summary>
    public string? TransportAttachmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transport_attachment_id")?.Value;
        set => this.WithProperty("transport_attachment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
