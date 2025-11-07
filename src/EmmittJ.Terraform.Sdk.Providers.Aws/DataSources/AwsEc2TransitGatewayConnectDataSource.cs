using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_transit_gateway_connect.
/// </summary>
public class AwsEc2TransitGatewayConnectDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayConnectDataSource(string name) : base("aws_ec2_transit_gateway_connect", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("protocol");
        this.DeclareOutput("transit_gateway_id");
        this.DeclareOutput("transport_attachment_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The transit_gateway_connect_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TransitGatewayConnectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_connect_id");
        set => this.WithProperty("transit_gateway_connect_id", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformExpression Protocol => this["protocol"];

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformExpression TransitGatewayId => this["transit_gateway_id"];

    /// <summary>
    /// The transport_attachment_id attribute.
    /// </summary>
    public TerraformExpression TransportAttachmentId => this["transport_attachment_id"];

}
