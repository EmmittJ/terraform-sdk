using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_multicast_domain_association resource.
/// </summary>
public class AwsEc2TransitGatewayMulticastDomainAssociation : TerraformResource
{
    public AwsEc2TransitGatewayMulticastDomainAssociation(string name) : base("aws_ec2_transit_gateway_multicast_domain_association", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The transit_gateway_multicast_domain_id attribute.
    /// </summary>
    public string? TransitGatewayMulticastDomainId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_multicast_domain_id")?.Value;
        set => this.WithProperty("transit_gateway_multicast_domain_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
