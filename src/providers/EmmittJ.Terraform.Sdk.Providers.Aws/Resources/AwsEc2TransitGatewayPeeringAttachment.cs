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
        get => new TerraformReference<string>(this, "dynamic_routing");
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The peer_account_id attribute.
    /// </summary>
    public TerraformValue<string> PeerAccountId
    {
        get => new TerraformReference<string>(this, "peer_account_id");
        set => SetArgument("peer_account_id", value);
    }

    /// <summary>
    /// The peer_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerRegion is required")]
    public required TerraformValue<string> PeerRegion
    {
        get => new TerraformReference<string>(this, "peer_region");
        set => SetArgument("peer_region", value);
    }

    /// <summary>
    /// The peer_transit_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerTransitGatewayId is required")]
    public required TerraformValue<string> PeerTransitGatewayId
    {
        get => new TerraformReference<string>(this, "peer_transit_gateway_id");
        set => SetArgument("peer_transit_gateway_id", value);
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
    /// The transit_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayId is required")]
    public required TerraformValue<string> TransitGatewayId
    {
        get => new TerraformReference<string>(this, "transit_gateway_id");
        set => SetArgument("transit_gateway_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

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
