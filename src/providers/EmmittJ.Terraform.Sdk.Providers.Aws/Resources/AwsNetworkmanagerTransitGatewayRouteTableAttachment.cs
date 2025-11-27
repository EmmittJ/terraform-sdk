using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsNetworkmanagerTransitGatewayRouteTableAttachment.
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerTransitGatewayRouteTableAttachmentTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_networkmanager_transit_gateway_route_table_attachment Terraform resource.
/// Manages a aws_networkmanager_transit_gateway_route_table_attachment resource.
/// </summary>
public partial class AwsNetworkmanagerTransitGatewayRouteTableAttachment(string name) : TerraformResource("aws_networkmanager_transit_gateway_route_table_attachment", name)
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
    /// The peering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringId is required")]
    public required TerraformValue<string> PeeringId
    {
        get => new TerraformReference<string>(this, "peering_id");
        set => SetArgument("peering_id", value);
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
    /// The transit_gateway_route_table_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayRouteTableArn is required")]
    public required TerraformValue<string> TransitGatewayRouteTableArn
    {
        get => new TerraformReference<string>(this, "transit_gateway_route_table_arn");
        set => SetArgument("transit_gateway_route_table_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The attachment_policy_rule_number attribute.
    /// </summary>
    public TerraformValue<double> AttachmentPolicyRuleNumber
    {
        get => new TerraformReference<double>(this, "attachment_policy_rule_number");
    }

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    public TerraformValue<string> AttachmentType
    {
        get => new TerraformReference<string>(this, "attachment_type");
    }

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    public TerraformValue<string> CoreNetworkArn
    {
        get => new TerraformReference<string>(this, "core_network_arn");
    }

    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    public TerraformValue<string> CoreNetworkId
    {
        get => new TerraformReference<string>(this, "core_network_id");
    }

    /// <summary>
    /// The edge_location attribute.
    /// </summary>
    public TerraformValue<string> EdgeLocation
    {
        get => new TerraformReference<string>(this, "edge_location");
    }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerAccountId
    {
        get => new TerraformReference<string>(this, "owner_account_id");
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformValue<string> ResourceArn
    {
        get => new TerraformReference<string>(this, "resource_arn");
    }

    /// <summary>
    /// The segment_name attribute.
    /// </summary>
    public TerraformValue<string> SegmentName
    {
        get => new TerraformReference<string>(this, "segment_name");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNetworkmanagerTransitGatewayRouteTableAttachmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNetworkmanagerTransitGatewayRouteTableAttachmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
