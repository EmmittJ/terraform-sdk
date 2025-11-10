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
        SetOutput("group_ip_address");
        SetOutput("id");
        SetOutput("network_interface_id");
        SetOutput("region");
        SetOutput("transit_gateway_multicast_domain_id");
    }

    /// <summary>
    /// The group_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupIpAddress is required")]
    public required TerraformProperty<string> GroupIpAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("group_ip_address");
        set => SetProperty("group_ip_address", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    public required TerraformProperty<string> NetworkInterfaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_interface_id");
        set => SetProperty("network_interface_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The transit_gateway_multicast_domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayMulticastDomainId is required")]
    public required TerraformProperty<string> TransitGatewayMulticastDomainId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transit_gateway_multicast_domain_id");
        set => SetProperty("transit_gateway_multicast_domain_id", value);
    }

}
