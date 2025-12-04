using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsEc2TransitGatewayConnectPeerDataSource.
/// Nesting mode: set
/// </summary>
public class AwsEc2TransitGatewayConnectPeerDataSourceFilterBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEc2TransitGatewayConnectPeerDataSource.
/// Nesting mode: single
/// </summary>
public class AwsEc2TransitGatewayConnectPeerDataSourceTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_ec2_transit_gateway_connect_peer Terraform data source.
/// Retrieves information about a aws_ec2_transit_gateway_connect_peer.
/// </summary>
public partial class AwsEc2TransitGatewayConnectPeerDataSource(string name) : TerraformDataSource("aws_ec2_transit_gateway_connect_peer", name)
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
    /// The transit_gateway_connect_peer_id attribute.
    /// </summary>
    public TerraformValue<string>? TransitGatewayConnectPeerId
    {
        get => GetArgument<TerraformValue<string>>("transit_gateway_connect_peer_id");
        set => SetArgument("transit_gateway_connect_peer_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    public TerraformValue<string> BgpAsn
        => AsReference("bgp_asn");

    /// <summary>
    /// The bgp_peer_address attribute.
    /// </summary>
    public TerraformValue<string> BgpPeerAddress
        => AsReference("bgp_peer_address");

    /// <summary>
    /// The bgp_transit_gateway_addresses attribute.
    /// </summary>
    public TerraformSet<string> BgpTransitGatewayAddresses
        => AsReference("bgp_transit_gateway_addresses");

    /// <summary>
    /// The inside_cidr_blocks attribute.
    /// </summary>
    public TerraformList<string> InsideCidrBlocks
        => AsReference("inside_cidr_blocks");

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    public TerraformValue<string> PeerAddress
        => AsReference("peer_address");

    /// <summary>
    /// The transit_gateway_address attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayAddress
        => AsReference("transit_gateway_address");

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayAttachmentId
        => AsReference("transit_gateway_attachment_id");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEc2TransitGatewayConnectPeerDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsEc2TransitGatewayConnectPeerDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2TransitGatewayConnectPeerDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2TransitGatewayConnectPeerDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
