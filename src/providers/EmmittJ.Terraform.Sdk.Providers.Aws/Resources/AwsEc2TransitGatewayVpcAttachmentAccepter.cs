using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ec2_transit_gateway_vpc_attachment_accepter Terraform resource.
/// Manages a aws_ec2_transit_gateway_vpc_attachment_accepter resource.
/// </summary>
public partial class AwsEc2TransitGatewayVpcAttachmentAccepter(string name) : TerraformResource("aws_ec2_transit_gateway_vpc_attachment_accepter", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayAttachmentId is required")]
    public required TerraformValue<string> TransitGatewayAttachmentId
    {
        get => GetArgument<TerraformValue<string>>("transit_gateway_attachment_id");
        set => SetArgument("transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The transit_gateway_default_route_table_association attribute.
    /// </summary>
    public TerraformValue<bool>? TransitGatewayDefaultRouteTableAssociation
    {
        get => GetArgument<TerraformValue<bool>>("transit_gateway_default_route_table_association");
        set => SetArgument("transit_gateway_default_route_table_association", value);
    }

    /// <summary>
    /// The transit_gateway_default_route_table_propagation attribute.
    /// </summary>
    public TerraformValue<bool>? TransitGatewayDefaultRouteTablePropagation
    {
        get => GetArgument<TerraformValue<bool>>("transit_gateway_default_route_table_propagation");
        set => SetArgument("transit_gateway_default_route_table_propagation", value);
    }

    /// <summary>
    /// The appliance_mode_support attribute.
    /// </summary>
    public TerraformValue<string> ApplianceModeSupport
        => AsReference("appliance_mode_support");

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    public TerraformValue<string> DnsSupport
        => AsReference("dns_support");

    /// <summary>
    /// The ipv6_support attribute.
    /// </summary>
    public TerraformValue<string> Ipv6Support
        => AsReference("ipv6_support");

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    public TerraformValue<string> SecurityGroupReferencingSupport
        => AsReference("security_group_referencing_support");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
        => AsReference("subnet_ids");

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayId
        => AsReference("transit_gateway_id");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => AsReference("vpc_id");

    /// <summary>
    /// The vpc_owner_id attribute.
    /// </summary>
    public TerraformValue<string> VpcOwnerId
        => AsReference("vpc_owner_id");

}
