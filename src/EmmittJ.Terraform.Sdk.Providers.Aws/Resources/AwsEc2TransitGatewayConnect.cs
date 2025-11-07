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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The transit_gateway_default_route_table_association attribute.
    /// </summary>
    public TerraformProperty<bool>? TransitGatewayDefaultRouteTableAssociation
    {
        get => GetProperty<TerraformProperty<bool>>("transit_gateway_default_route_table_association");
        set => this.WithProperty("transit_gateway_default_route_table_association", value);
    }

    /// <summary>
    /// The transit_gateway_default_route_table_propagation attribute.
    /// </summary>
    public TerraformProperty<bool>? TransitGatewayDefaultRouteTablePropagation
    {
        get => GetProperty<TerraformProperty<bool>>("transit_gateway_default_route_table_propagation");
        set => this.WithProperty("transit_gateway_default_route_table_propagation", value);
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
    /// The transport_attachment_id attribute.
    /// </summary>
    public TerraformProperty<string>? TransportAttachmentId
    {
        get => GetProperty<TerraformProperty<string>>("transport_attachment_id");
        set => this.WithProperty("transport_attachment_id", value);
    }

}
