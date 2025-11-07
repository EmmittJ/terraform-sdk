using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_multicast_group_member resource.
/// </summary>
public class AwsEc2TransitGatewayMulticastGroupMember : TerraformResource
{
    public AwsEc2TransitGatewayMulticastGroupMember(string name) : base("aws_ec2_transit_gateway_multicast_group_member", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The group_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? GroupIpAddress
    {
        get => GetProperty<TerraformProperty<string>>("group_ip_address");
        set => this.WithProperty("group_ip_address", value);
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
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkInterfaceId
    {
        get => GetProperty<TerraformProperty<string>>("network_interface_id");
        set => this.WithProperty("network_interface_id", value);
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
    /// The transit_gateway_multicast_domain_id attribute.
    /// </summary>
    public TerraformProperty<string>? TransitGatewayMulticastDomainId
    {
        get => GetProperty<TerraformProperty<string>>("transit_gateway_multicast_domain_id");
        set => this.WithProperty("transit_gateway_multicast_domain_id", value);
    }

}
