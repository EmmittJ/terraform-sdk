using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_multicast_group_source resource.
/// </summary>
public class AwsEc2TransitGatewayMulticastGroupSource : TerraformResource
{
    public AwsEc2TransitGatewayMulticastGroupSource(string name) : base("aws_ec2_transit_gateway_multicast_group_source", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The group_ip_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GroupIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_ip_address");
        set => this.WithProperty("group_ip_address", value);
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
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkInterfaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_interface_id");
        set => this.WithProperty("network_interface_id", value);
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
    /// The transit_gateway_multicast_domain_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TransitGatewayMulticastDomainId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_multicast_domain_id");
        set => this.WithProperty("transit_gateway_multicast_domain_id", value);
    }

}
