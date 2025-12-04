using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ec2_transit_gateway_vpc_attachment Terraform resource.
/// Manages a aws_ec2_transit_gateway_vpc_attachment resource.
/// </summary>
public partial class AwsEc2TransitGatewayVpcAttachment(string name) : TerraformResource("aws_ec2_transit_gateway_vpc_attachment", name)
{
    /// <summary>
    /// The appliance_mode_support attribute.
    /// </summary>
    public TerraformValue<string>? ApplianceModeSupport
    {
        get => GetArgument<TerraformValue<string>>("appliance_mode_support");
        set => SetArgument("appliance_mode_support", value);
    }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    public TerraformValue<string>? DnsSupport
    {
        get => GetArgument<TerraformValue<string>>("dns_support");
        set => SetArgument("dns_support", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ipv6_support attribute.
    /// </summary>
    public TerraformValue<string>? Ipv6Support
    {
        get => GetArgument<TerraformValue<string>>("ipv6_support");
        set => SetArgument("ipv6_support", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    public TerraformValue<string> SecurityGroupReferencingSupport
    {
        get => GetArgument<TerraformValue<string>>("security_group_referencing_support") ?? AsReference("security_group_referencing_support");
        set => SetArgument("security_group_referencing_support", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => GetRequiredArgument<TerraformSet<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The transit_gateway_default_route_table_association attribute.
    /// </summary>
    public TerraformValue<bool> TransitGatewayDefaultRouteTableAssociation
    {
        get => GetArgument<TerraformValue<bool>>("transit_gateway_default_route_table_association") ?? AsReference("transit_gateway_default_route_table_association");
        set => SetArgument("transit_gateway_default_route_table_association", value);
    }

    /// <summary>
    /// The transit_gateway_default_route_table_propagation attribute.
    /// </summary>
    public TerraformValue<bool> TransitGatewayDefaultRouteTablePropagation
    {
        get => GetArgument<TerraformValue<bool>>("transit_gateway_default_route_table_propagation") ?? AsReference("transit_gateway_default_route_table_propagation");
        set => SetArgument("transit_gateway_default_route_table_propagation", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayId is required")]
    public required TerraformValue<string> TransitGatewayId
    {
        get => GetRequiredArgument<TerraformValue<string>>("transit_gateway_id");
        set => SetArgument("transit_gateway_id", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformValue<string> VpcId
    {
        get => GetRequiredArgument<TerraformValue<string>>("vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The vpc_owner_id attribute.
    /// </summary>
    public TerraformValue<string> VpcOwnerId
        => AsReference("vpc_owner_id");

}
