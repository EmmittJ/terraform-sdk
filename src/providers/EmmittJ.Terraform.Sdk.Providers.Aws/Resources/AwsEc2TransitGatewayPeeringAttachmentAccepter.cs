using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ec2_transit_gateway_peering_attachment_accepter Terraform resource.
/// Manages a aws_ec2_transit_gateway_peering_attachment_accepter resource.
/// </summary>
public partial class AwsEc2TransitGatewayPeeringAttachmentAccepter(string name) : TerraformResource("aws_ec2_transit_gateway_peering_attachment_accepter", name)
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
    /// The peer_account_id attribute.
    /// </summary>
    public TerraformValue<string> PeerAccountId
    {
        get => new TerraformReference<string>(this, "peer_account_id");
    }

    /// <summary>
    /// The peer_region attribute.
    /// </summary>
    public TerraformValue<string> PeerRegion
    {
        get => new TerraformReference<string>(this, "peer_region");
    }

    /// <summary>
    /// The peer_transit_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> PeerTransitGatewayId
    {
        get => new TerraformReference<string>(this, "peer_transit_gateway_id");
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayId
    {
        get => new TerraformReference<string>(this, "transit_gateway_id");
    }

}
