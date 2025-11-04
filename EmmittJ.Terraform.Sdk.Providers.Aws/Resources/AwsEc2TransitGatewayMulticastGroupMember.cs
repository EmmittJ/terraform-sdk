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
    public string? GroupIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_ip_address")?.Value;
        set => this.WithProperty("group_ip_address", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The network_interface_id attribute.
    /// </summary>
    public string? NetworkInterfaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_interface_id")?.Value;
        set => this.WithProperty("network_interface_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
