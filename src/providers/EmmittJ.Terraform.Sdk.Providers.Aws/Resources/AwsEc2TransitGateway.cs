using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsEc2TransitGateway.
/// Nesting mode: single
/// </summary>
public class AwsEc2TransitGatewayTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_ec2_transit_gateway Terraform resource.
/// Manages a aws_ec2_transit_gateway resource.
/// </summary>
public partial class AwsEc2TransitGateway(string name) : TerraformResource("aws_ec2_transit_gateway", name)
{
    /// <summary>
    /// The amazon_side_asn attribute.
    /// </summary>
    public TerraformValue<double>? AmazonSideAsn
    {
        get => new TerraformReference<double>(this, "amazon_side_asn");
        set => SetArgument("amazon_side_asn", value);
    }

    /// <summary>
    /// The auto_accept_shared_attachments attribute.
    /// </summary>
    public TerraformValue<string>? AutoAcceptSharedAttachments
    {
        get => new TerraformReference<string>(this, "auto_accept_shared_attachments");
        set => SetArgument("auto_accept_shared_attachments", value);
    }

    /// <summary>
    /// The default_route_table_association attribute.
    /// </summary>
    public TerraformValue<string>? DefaultRouteTableAssociation
    {
        get => new TerraformReference<string>(this, "default_route_table_association");
        set => SetArgument("default_route_table_association", value);
    }

    /// <summary>
    /// The default_route_table_propagation attribute.
    /// </summary>
    public TerraformValue<string>? DefaultRouteTablePropagation
    {
        get => new TerraformReference<string>(this, "default_route_table_propagation");
        set => SetArgument("default_route_table_propagation", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    public TerraformValue<string>? DnsSupport
    {
        get => new TerraformReference<string>(this, "dns_support");
        set => SetArgument("dns_support", value);
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
    /// The multicast_support attribute.
    /// </summary>
    public TerraformValue<string>? MulticastSupport
    {
        get => new TerraformReference<string>(this, "multicast_support");
        set => SetArgument("multicast_support", value);
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
    /// The security_group_referencing_support attribute.
    /// </summary>
    public TerraformValue<string>? SecurityGroupReferencingSupport
    {
        get => new TerraformReference<string>(this, "security_group_referencing_support");
        set => SetArgument("security_group_referencing_support", value);
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
    /// The transit_gateway_cidr_blocks attribute.
    /// </summary>
    public TerraformSet<string>? TransitGatewayCidrBlocks
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "transit_gateway_cidr_blocks").ResolveNodes(ctx));
        set => SetArgument("transit_gateway_cidr_blocks", value);
    }

    /// <summary>
    /// The vpn_ecmp_support attribute.
    /// </summary>
    public TerraformValue<string>? VpnEcmpSupport
    {
        get => new TerraformReference<string>(this, "vpn_ecmp_support");
        set => SetArgument("vpn_ecmp_support", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The association_default_route_table_id attribute.
    /// </summary>
    public TerraformValue<string> AssociationDefaultRouteTableId
    {
        get => new TerraformReference<string>(this, "association_default_route_table_id");
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

    /// <summary>
    /// The propagation_default_route_table_id attribute.
    /// </summary>
    public TerraformValue<string> PropagationDefaultRouteTableId
    {
        get => new TerraformReference<string>(this, "propagation_default_route_table_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2TransitGatewayTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2TransitGatewayTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
