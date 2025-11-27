using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ec2_transit_gateway_multicast_group_source Terraform resource.
/// Manages a aws_ec2_transit_gateway_multicast_group_source resource.
/// </summary>
public partial class AwsEc2TransitGatewayMulticastGroupSource(string name) : TerraformResource("aws_ec2_transit_gateway_multicast_group_source", name)
{
    /// <summary>
    /// The group_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupIpAddress is required")]
    public required TerraformValue<string> GroupIpAddress
    {
        get => new TerraformReference<string>(this, "group_ip_address");
        set => SetArgument("group_ip_address", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    public required TerraformValue<string> NetworkInterfaceId
    {
        get => new TerraformReference<string>(this, "network_interface_id");
        set => SetArgument("network_interface_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The transit_gateway_multicast_domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayMulticastDomainId is required")]
    public required TerraformValue<string> TransitGatewayMulticastDomainId
    {
        get => new TerraformReference<string>(this, "transit_gateway_multicast_domain_id");
        set => SetArgument("transit_gateway_multicast_domain_id", value);
    }

}
