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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<double>>("amazon_side_asn");
        set => SetArgument("amazon_side_asn", value);
    }

    /// <summary>
    /// The auto_accept_shared_attachments attribute.
    /// </summary>
    public TerraformValue<string>? AutoAcceptSharedAttachments
    {
        get => GetArgument<TerraformValue<string>>("auto_accept_shared_attachments");
        set => SetArgument("auto_accept_shared_attachments", value);
    }

    /// <summary>
    /// The default_route_table_association attribute.
    /// </summary>
    public TerraformValue<string>? DefaultRouteTableAssociation
    {
        get => GetArgument<TerraformValue<string>>("default_route_table_association");
        set => SetArgument("default_route_table_association", value);
    }

    /// <summary>
    /// The default_route_table_propagation attribute.
    /// </summary>
    public TerraformValue<string>? DefaultRouteTablePropagation
    {
        get => GetArgument<TerraformValue<string>>("default_route_table_propagation");
        set => SetArgument("default_route_table_propagation", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The multicast_support attribute.
    /// </summary>
    public TerraformValue<string>? MulticastSupport
    {
        get => GetArgument<TerraformValue<string>>("multicast_support");
        set => SetArgument("multicast_support", value);
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
    public TerraformValue<string>? SecurityGroupReferencingSupport
    {
        get => GetArgument<TerraformValue<string>>("security_group_referencing_support");
        set => SetArgument("security_group_referencing_support", value);
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
    /// The transit_gateway_cidr_blocks attribute.
    /// </summary>
    public TerraformSet<string>? TransitGatewayCidrBlocks
    {
        get => GetArgument<TerraformSet<string>>("transit_gateway_cidr_blocks");
        set => SetArgument("transit_gateway_cidr_blocks", value);
    }

    /// <summary>
    /// The vpn_ecmp_support attribute.
    /// </summary>
    public TerraformValue<string>? VpnEcmpSupport
    {
        get => GetArgument<TerraformValue<string>>("vpn_ecmp_support");
        set => SetArgument("vpn_ecmp_support", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The association_default_route_table_id attribute.
    /// </summary>
    public TerraformValue<string> AssociationDefaultRouteTableId
        => AsReference("association_default_route_table_id");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => AsReference("owner_id");

    /// <summary>
    /// The propagation_default_route_table_id attribute.
    /// </summary>
    public TerraformValue<string> PropagationDefaultRouteTableId
        => AsReference("propagation_default_route_table_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2TransitGatewayTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2TransitGatewayTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
