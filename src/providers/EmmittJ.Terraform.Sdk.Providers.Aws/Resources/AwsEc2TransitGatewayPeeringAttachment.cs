using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for options in AwsEc2TransitGatewayPeeringAttachment.
/// Nesting mode: list
/// </summary>
public class AwsEc2TransitGatewayPeeringAttachmentOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "options";

    /// <summary>
    /// The dynamic_routing attribute.
    /// </summary>
    public TerraformValue<string>? DynamicRouting
    {
        get => GetArgument<TerraformValue<string>>("dynamic_routing");
        set => SetArgument("dynamic_routing", value);
    }

}


/// <summary>
/// Represents a aws_ec2_transit_gateway_peering_attachment Terraform resource.
/// Manages a aws_ec2_transit_gateway_peering_attachment resource.
/// </summary>
public partial class AwsEc2TransitGatewayPeeringAttachment(string name) : TerraformResource("aws_ec2_transit_gateway_peering_attachment", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The peer_account_id attribute.
    /// </summary>
    public TerraformValue<string> PeerAccountId
    {
        get => GetArgument<TerraformValue<string>>("peer_account_id") ?? CreateReference("peer_account_id");
        set => SetArgument("peer_account_id", value);
    }

    /// <summary>
    /// The peer_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerRegion is required")]
    public required TerraformValue<string> PeerRegion
    {
        get => GetRequiredArgument<TerraformValue<string>>("peer_region");
        set => SetArgument("peer_region", value);
    }

    /// <summary>
    /// The peer_transit_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerTransitGatewayId is required")]
    public required TerraformValue<string> PeerTransitGatewayId
    {
        get => GetRequiredArgument<TerraformValue<string>>("peer_transit_gateway_id");
        set => SetArgument("peer_transit_gateway_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// Options block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    public TerraformList<AwsEc2TransitGatewayPeeringAttachmentOptionsBlock>? Options
    {
        get => GetArgument<TerraformList<AwsEc2TransitGatewayPeeringAttachmentOptionsBlock>>("options");
        set => SetArgument("options", value);
    }

}
