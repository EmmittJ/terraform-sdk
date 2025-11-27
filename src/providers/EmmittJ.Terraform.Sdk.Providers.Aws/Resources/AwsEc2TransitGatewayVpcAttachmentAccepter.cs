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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayAttachmentId is required")]
    public required TerraformValue<string> TransitGatewayAttachmentId
    {
        get => new TerraformReference<string>(this, "transit_gateway_attachment_id");
        set => SetArgument("transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The transit_gateway_default_route_table_association attribute.
    /// </summary>
    public TerraformValue<bool>? TransitGatewayDefaultRouteTableAssociation
    {
        get => new TerraformReference<bool>(this, "transit_gateway_default_route_table_association");
        set => SetArgument("transit_gateway_default_route_table_association", value);
    }

    /// <summary>
    /// The transit_gateway_default_route_table_propagation attribute.
    /// </summary>
    public TerraformValue<bool>? TransitGatewayDefaultRouteTablePropagation
    {
        get => new TerraformReference<bool>(this, "transit_gateway_default_route_table_propagation");
        set => SetArgument("transit_gateway_default_route_table_propagation", value);
    }

    /// <summary>
    /// The appliance_mode_support attribute.
    /// </summary>
    public TerraformValue<string> ApplianceModeSupport
    {
        get => new TerraformReference<string>(this, "appliance_mode_support");
    }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    public TerraformValue<string> DnsSupport
    {
        get => new TerraformReference<string>(this, "dns_support");
    }

    /// <summary>
    /// The ipv6_support attribute.
    /// </summary>
    public TerraformValue<string> Ipv6Support
    {
        get => new TerraformReference<string>(this, "ipv6_support");
    }

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    public TerraformValue<string> SecurityGroupReferencingSupport
    {
        get => new TerraformReference<string>(this, "security_group_referencing_support");
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayId
    {
        get => new TerraformReference<string>(this, "transit_gateway_id");
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

    /// <summary>
    /// The vpc_owner_id attribute.
    /// </summary>
    public TerraformValue<string> VpcOwnerId
    {
        get => new TerraformReference<string>(this, "vpc_owner_id");
    }

}
