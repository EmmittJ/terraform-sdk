using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsEc2TransitGatewayDataSource.
/// Nesting mode: set
/// </summary>
public class AwsEc2TransitGatewayDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEc2TransitGatewayDataSource.
/// Nesting mode: single
/// </summary>
public class AwsEc2TransitGatewayDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_ec2_transit_gateway Terraform data source.
/// Retrieves information about a aws_ec2_transit_gateway.
/// </summary>
public partial class AwsEc2TransitGatewayDataSource(string name) : TerraformDataSource("aws_ec2_transit_gateway", name)
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
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The amazon_side_asn attribute.
    /// </summary>
    public TerraformValue<double> AmazonSideAsn
    {
        get => new TerraformReference<double>(this, "amazon_side_asn");
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
    /// The auto_accept_shared_attachments attribute.
    /// </summary>
    public TerraformValue<string> AutoAcceptSharedAttachments
    {
        get => new TerraformReference<string>(this, "auto_accept_shared_attachments");
    }

    /// <summary>
    /// The default_route_table_association attribute.
    /// </summary>
    public TerraformValue<string> DefaultRouteTableAssociation
    {
        get => new TerraformReference<string>(this, "default_route_table_association");
    }

    /// <summary>
    /// The default_route_table_propagation attribute.
    /// </summary>
    public TerraformValue<string> DefaultRouteTablePropagation
    {
        get => new TerraformReference<string>(this, "default_route_table_propagation");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    public TerraformValue<string> DnsSupport
    {
        get => new TerraformReference<string>(this, "dns_support");
    }

    /// <summary>
    /// The multicast_support attribute.
    /// </summary>
    public TerraformValue<string> MulticastSupport
    {
        get => new TerraformReference<string>(this, "multicast_support");
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
    /// The security_group_referencing_support attribute.
    /// </summary>
    public TerraformValue<string> SecurityGroupReferencingSupport
    {
        get => new TerraformReference<string>(this, "security_group_referencing_support");
    }

    /// <summary>
    /// The transit_gateway_cidr_blocks attribute.
    /// </summary>
    public TerraformList<string> TransitGatewayCidrBlocks
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "transit_gateway_cidr_blocks").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vpn_ecmp_support attribute.
    /// </summary>
    public TerraformValue<string> VpnEcmpSupport
    {
        get => new TerraformReference<string>(this, "vpn_ecmp_support");
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEc2TransitGatewayDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsEc2TransitGatewayDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2TransitGatewayDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2TransitGatewayDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
